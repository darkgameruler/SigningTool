using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using System.IO;

namespace SigningTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCargarDocumento_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lblDocument.Text = dialog.FileName;
            }
        }

        private void btnCargarFirma_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lblFirma.Text = dialog.FileName;
            }
        }

        private void btnCargarFirmaPublica_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lblFirmaPublica.Text = dialog.FileName;
            }
        }

        private void btnDigest_Click(object sender, EventArgs e)
        {
            Sha1Digest dig = new Sha1Digest();
            byte[] msgBytes = File.ReadAllBytes(lblDocument.Text);
            dig.BlockUpdate(msgBytes, 0, msgBytes.Length);
            byte[] result = new byte[dig.GetDigestSize()];
            dig.DoFinal(result, 0);
            textBox1.Text = Convert.ToBase64String(result);
        }

        private void btnDigest_Click2(object sender, EventArgs e)
        {
            Sha1Digest dig = new Sha1Digest();
            byte[] msgBytes = File.ReadAllBytes(lblDocument.Text);
            dig.BlockUpdate(msgBytes, 0, msgBytes.Length);
            byte[] result = new byte[dig.GetDigestSize()];
            dig.DoFinal(result, 0);
            textBox1.Text = Convert.ToBase64String(result);
        }

        private void btnFirmarDocumento_Click(object sender, EventArgs e)
        {            
            AsymmetricKeyParameter akp = ReadPrivateKey(lblFirma.Text);
            Sha1Digest dig = new Sha1Digest();
            byte[] msgBytes = File.ReadAllBytes(lblDocument.Text);
            dig.BlockUpdate(msgBytes, 0, msgBytes.Length);
            byte[] result = new byte[dig.GetDigestSize()];
            dig.DoFinal(result, 0);
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner signer = new Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(dig);
            signer.Init(true, akp);            
            signer.BlockUpdate(result, 0, result.Length);
            byte[] sig = signer.GenerateSignature();
            textBox2.Text = Convert.ToBase64String(sig);
            MessageBox.Show("Se ha firmado el documento.");
        }
       
        private void btnVerificarDocumento_Click(object sender, EventArgs e)
        {
            byte[] sign = Convert.FromBase64String(textBox2.Text);
            AsymmetricKeyParameter akp = ReadPublicKey(lblFirmaPublica.Text);
            Sha1Digest dig = new Sha1Digest();
            byte[] msgBytes = File.ReadAllBytes(lblDocument.Text);
            dig.BlockUpdate(msgBytes, 0, msgBytes.Length);
            byte[] result = new byte[dig.GetDigestSize()];
            dig.DoFinal(result, 0);
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner signer = new Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(dig);
            signer.Init(false, akp);
            signer.BlockUpdate(result, 0, result.Length);
            if (!signer.VerifySignature(sign))
            {
                MessageBox.Show("RSA Digest Signer failed.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("RSA Digest Signer success.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerificarCertificado_Click(object sender, EventArgs e)
        {
            System.Security.Cryptography.X509Certificates.X509Certificate2 certificate = new System.Security.Cryptography.X509Certificates.X509Certificate2(lblFirmaPublica.Text);
            System.Security.Cryptography.X509Certificates.X509Chain chain = new System.Security.Cryptography.X509Certificates.X509Chain();
            chain.Build(certificate);
            string msg = string.Format("Verified root of chain = {0}", chain.ChainElements[chain.ChainElements.Count - 1].Certificate.Verify());
            MessageBox.Show(msg);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = File.ReadAllText(ofd.FileName, System.Text.Encoding.UTF8);
            }
        }

        private void btnGuardarFirma_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fname = sfd.FileName;
                string signText = textBox2.Text;
                File.WriteAllText(fname, signText, System.Text.Encoding.UTF8);
                MessageBox.Show("Se ha guardado el archivo.");
            }
        }

        private void btnFirmaMasiva_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dresult = fbd.ShowDialog();
            if (dresult == DialogResult.OK)
            {
                foreach (string file in Directory.GetFiles(fbd.SelectedPath))
                {
                    FileInfo fInfo = new FileInfo(file);
                    AsymmetricKeyParameter akp = ReadPrivateKey(lblFirma.Text);
                    Sha1Digest dig = new Sha1Digest();
                    byte[] msgBytes = File.ReadAllBytes(file);
                    dig.BlockUpdate(msgBytes, 0, msgBytes.Length);
                    byte[] result = new byte[dig.GetDigestSize()];
                    dig.DoFinal(result, 0);
                    Org.BouncyCastle.Crypto.Signers.RsaDigestSigner signer = new Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(dig);
                    signer.Init(true, akp);
                    signer.BlockUpdate(result, 0, result.Length);
                    byte[] sig = signer.GenerateSignature();
                    string signString = Convert.ToBase64String(sig);
                    string signPath = string.Format("{0}{1}", fInfo.FullName, "sgn");
                    File.WriteAllText(signPath, signString, System.Text.Encoding.UTF8);
                }

                MessageBox.Show("Firma finalizada.");
            }
        }

        private AsymmetricKeyParameter ReadPrivateKey(string privateKeyFileName)
        {
            AsymmetricCipherKeyPair keyPair;
            using (var reader = File.OpenText(privateKeyFileName))
                keyPair = (AsymmetricCipherKeyPair)new Org.BouncyCastle.OpenSsl.PemReader(reader).ReadObject();

            return keyPair.Private;
        }

        private AsymmetricKeyParameter ReadPublicKey(string publicKeyFileName)
        {
            Org.BouncyCastle.X509.X509Certificate cer;
            using (var reader = File.OpenText(publicKeyFileName))
                cer = (Org.BouncyCastle.X509.X509Certificate)new Org.BouncyCastle.OpenSsl.PemReader(reader).ReadObject();
            
            return cer.GetPublicKey();
        }        
    }
}