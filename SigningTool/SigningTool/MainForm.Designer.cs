namespace SigningTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargarDocumento = new System.Windows.Forms.Button();
            this.btnCargarFirma = new System.Windows.Forms.Button();
            this.btnFirmarDocumento = new System.Windows.Forms.Button();
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.btnDigest = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnVerificarDocumento = new System.Windows.Forms.Button();
            this.btnCargarFirmaPublica = new System.Windows.Forms.Button();
            this.lblFirmaPublica = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVerificarCertificado = new System.Windows.Forms.Button();
            this.btnGuardarFirma = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnFirmaMasiva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarDocumento
            // 
            this.btnCargarDocumento.Location = new System.Drawing.Point(60, 14);
            this.btnCargarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarDocumento.Name = "btnCargarDocumento";
            this.btnCargarDocumento.Size = new System.Drawing.Size(160, 34);
            this.btnCargarDocumento.TabIndex = 0;
            this.btnCargarDocumento.Text = "1.-Cargar documento";
            this.btnCargarDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarDocumento.UseVisualStyleBackColor = true;
            this.btnCargarDocumento.Click += new System.EventHandler(this.btnCargarDocumento_Click);
            // 
            // btnCargarFirma
            // 
            this.btnCargarFirma.Location = new System.Drawing.Point(60, 66);
            this.btnCargarFirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarFirma.Name = "btnCargarFirma";
            this.btnCargarFirma.Size = new System.Drawing.Size(160, 34);
            this.btnCargarFirma.TabIndex = 1;
            this.btnCargarFirma.Text = "2.-Cargar firma privada";
            this.btnCargarFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarFirma.UseVisualStyleBackColor = true;
            this.btnCargarFirma.Click += new System.EventHandler(this.btnCargarFirma_Click);
            // 
            // btnFirmarDocumento
            // 
            this.btnFirmarDocumento.Location = new System.Drawing.Point(60, 269);
            this.btnFirmarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirmarDocumento.Name = "btnFirmarDocumento";
            this.btnFirmarDocumento.Size = new System.Drawing.Size(160, 34);
            this.btnFirmarDocumento.TabIndex = 5;
            this.btnFirmarDocumento.Text = "5.-Firmar documento";
            this.btnFirmarDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmarDocumento.UseVisualStyleBackColor = true;
            this.btnFirmarDocumento.Click += new System.EventHandler(this.btnFirmarDocumento_Click);
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Location = new System.Drawing.Point(264, 14);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(84, 17);
            this.lblDocument.TabIndex = 2;
            this.lblDocument.Text = "Documento:";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(264, 66);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(47, 17);
            this.lblFirma.TabIndex = 3;
            this.lblFirma.Text = "Firma:";
            // 
            // btnDigest
            // 
            this.btnDigest.Location = new System.Drawing.Point(60, 179);
            this.btnDigest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDigest.Name = "btnDigest";
            this.btnDigest.Size = new System.Drawing.Size(160, 34);
            this.btnDigest.TabIndex = 3;
            this.btnDigest.Text = "4.-Digerir documento";
            this.btnDigest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDigest.UseVisualStyleBackColor = true;
            this.btnDigest.Click += new System.EventHandler(this.btnDigest_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 318);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(727, 337);
            this.textBox2.TabIndex = 6;
            // 
            // btnVerificarDocumento
            // 
            this.btnVerificarDocumento.Location = new System.Drawing.Point(242, 269);
            this.btnVerificarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerificarDocumento.Name = "btnVerificarDocumento";
            this.btnVerificarDocumento.Size = new System.Drawing.Size(160, 34);
            this.btnVerificarDocumento.TabIndex = 7;
            this.btnVerificarDocumento.Text = "6.-Verificar documento";
            this.btnVerificarDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerificarDocumento.UseVisualStyleBackColor = true;
            this.btnVerificarDocumento.Click += new System.EventHandler(this.btnVerificarDocumento_Click);
            // 
            // btnCargarFirmaPublica
            // 
            this.btnCargarFirmaPublica.Location = new System.Drawing.Point(60, 121);
            this.btnCargarFirmaPublica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarFirmaPublica.Name = "btnCargarFirmaPublica";
            this.btnCargarFirmaPublica.Size = new System.Drawing.Size(160, 34);
            this.btnCargarFirmaPublica.TabIndex = 2;
            this.btnCargarFirmaPublica.Text = "3.-Cargar firma pública";
            this.btnCargarFirmaPublica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarFirmaPublica.UseVisualStyleBackColor = true;
            this.btnCargarFirmaPublica.Click += new System.EventHandler(this.btnCargarFirmaPublica_Click);
            // 
            // lblFirmaPublica
            // 
            this.lblFirmaPublica.AutoSize = true;
            this.lblFirmaPublica.Location = new System.Drawing.Point(264, 121);
            this.lblFirmaPublica.Name = "lblFirmaPublica";
            this.lblFirmaPublica.Size = new System.Drawing.Size(47, 17);
            this.lblFirmaPublica.TabIndex = 3;
            this.lblFirmaPublica.Text = "Firma:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 226);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(727, 22);
            this.textBox1.TabIndex = 4;
            // 
            // btnVerificarCertificado
            // 
            this.btnVerificarCertificado.Location = new System.Drawing.Point(428, 269);
            this.btnVerificarCertificado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerificarCertificado.Name = "btnVerificarCertificado";
            this.btnVerificarCertificado.Size = new System.Drawing.Size(160, 34);
            this.btnVerificarCertificado.TabIndex = 8;
            this.btnVerificarCertificado.Text = "7.-Verificar certificado";
            this.btnVerificarCertificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerificarCertificado.UseVisualStyleBackColor = true;
            this.btnVerificarCertificado.Click += new System.EventHandler(this.btnVerificarCertificado_Click);
            // 
            // btnGuardarFirma
            // 
            this.btnGuardarFirma.Location = new System.Drawing.Point(708, 269);
            this.btnGuardarFirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarFirma.Name = "btnGuardarFirma";
            this.btnGuardarFirma.Size = new System.Drawing.Size(79, 34);
            this.btnGuardarFirma.TabIndex = 8;
            this.btnGuardarFirma.Text = "Guardar";
            this.btnGuardarFirma.UseVisualStyleBackColor = true;
            this.btnGuardarFirma.Click += new System.EventHandler(this.btnGuardarFirma_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(612, 269);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(79, 34);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnFirmaMasiva
            // 
            this.btnFirmaMasiva.Location = new System.Drawing.Point(676, 660);
            this.btnFirmaMasiva.Name = "btnFirmaMasiva";
            this.btnFirmaMasiva.Size = new System.Drawing.Size(111, 36);
            this.btnFirmaMasiva.TabIndex = 9;
            this.btnFirmaMasiva.Text = "Firma Masiva";
            this.btnFirmaMasiva.UseVisualStyleBackColor = true;
            this.btnFirmaMasiva.Click += new System.EventHandler(this.btnFirmaMasiva_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 737);
            this.Controls.Add(this.btnFirmaMasiva);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFirmaPublica);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.btnDigest);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnGuardarFirma);
            this.Controls.Add(this.btnVerificarCertificado);
            this.Controls.Add(this.btnVerificarDocumento);
            this.Controls.Add(this.btnFirmarDocumento);
            this.Controls.Add(this.btnCargarFirmaPublica);
            this.Controls.Add(this.btnCargarFirma);
            this.Controls.Add(this.btnCargarDocumento);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarDocumento;
        private System.Windows.Forms.Button btnCargarFirma;
        private System.Windows.Forms.Button btnFirmarDocumento;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Button btnDigest;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnVerificarDocumento;
        private System.Windows.Forms.Button btnCargarFirmaPublica;
        private System.Windows.Forms.Label lblFirmaPublica;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVerificarCertificado;
        private System.Windows.Forms.Button btnGuardarFirma;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnFirmaMasiva;
    }
}