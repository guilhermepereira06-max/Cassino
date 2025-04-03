namespace Roleta
{
    partial class frmCacaNiquel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGirar = new System.Windows.Forms.Button();
            this.lblNiquel1 = new System.Windows.Forms.Label();
            this.lblNiquel2 = new System.Windows.Forms.Label();
            this.lblNiquel3 = new System.Windows.Forms.Label();
            this.tmrSorteio_Geral = new System.Windows.Forms.Timer(this.components);
            this.btnJogar = new System.Windows.Forms.Button();
            this.tmrNiquel = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnGirar
            // 
            this.btnGirar.Location = new System.Drawing.Point(105, 179);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(75, 23);
            this.btnGirar.TabIndex = 0;
            this.btnGirar.Text = "&Girar";
            this.btnGirar.UseVisualStyleBackColor = true;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // lblNiquel1
            // 
            this.lblNiquel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNiquel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNiquel1.Location = new System.Drawing.Point(30, 33);
            this.lblNiquel1.Name = "lblNiquel1";
            this.lblNiquel1.Size = new System.Drawing.Size(50, 78);
            this.lblNiquel1.TabIndex = 1;
            this.lblNiquel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNiquel2
            // 
            this.lblNiquel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNiquel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNiquel2.Location = new System.Drawing.Point(119, 33);
            this.lblNiquel2.Name = "lblNiquel2";
            this.lblNiquel2.Size = new System.Drawing.Size(47, 78);
            this.lblNiquel2.TabIndex = 2;
            this.lblNiquel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNiquel3
            // 
            this.lblNiquel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNiquel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNiquel3.Location = new System.Drawing.Point(199, 33);
            this.lblNiquel3.Name = "lblNiquel3";
            this.lblNiquel3.Size = new System.Drawing.Size(49, 78);
            this.lblNiquel3.TabIndex = 3;
            this.lblNiquel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSorteio_Geral
            // 
            this.tmrSorteio_Geral.Tick += new System.EventHandler(this.tmrSorteioGeral_Tick);
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(212, 178);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 4;
            this.btnJogar.Text = "&Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // tmrNiquel
            // 
            this.tmrNiquel.Tick += new System.EventHandler(this.tmrNiquel_Tick);
            // 
            // frmCacaNiquel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 298);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblNiquel3);
            this.Controls.Add(this.lblNiquel2);
            this.Controls.Add(this.lblNiquel1);
            this.Controls.Add(this.btnGirar);
            this.Name = "frmCacaNiquel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCacaNiquel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGirar;
        private System.Windows.Forms.Label lblNiquel1;
        private System.Windows.Forms.Label lblNiquel2;
        private System.Windows.Forms.Label lblNiquel3;
        private System.Windows.Forms.Timer tmrSorteio_Geral;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Timer tmrNiquel;
    }
}

