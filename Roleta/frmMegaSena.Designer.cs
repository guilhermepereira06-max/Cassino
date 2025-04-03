namespace Roleta
{
    partial class frmMegaSena
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
            this.components = new System.ComponentModel.Container();
            this.lblQtde = new System.Windows.Forms.Label();
            this.txtQntdDeCartões = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSortearNum = new System.Windows.Forms.Button();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lstCartoes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblQtde
            // 
            this.lblQtde.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQtde.Location = new System.Drawing.Point(40, 56);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(100, 23);
            this.lblQtde.TabIndex = 0;
            this.lblQtde.Text = "Qtde de Cartoes";
            // 
            // txtQntdDeCartões
            // 
            this.txtQntdDeCartões.Location = new System.Drawing.Point(180, 59);
            this.txtQntdDeCartões.Name = "txtQntdDeCartões";
            this.txtQntdDeCartões.Size = new System.Drawing.Size(100, 20);
            this.txtQntdDeCartões.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSortearNum
            // 
            this.btnSortearNum.Location = new System.Drawing.Point(140, 153);
            this.btnSortearNum.Name = "btnSortearNum";
            this.btnSortearNum.Size = new System.Drawing.Size(75, 23);
            this.btnSortearNum.TabIndex = 3;
            this.btnSortearNum.Text = "&Sortear";
            this.btnSortearNum.UseVisualStyleBackColor = true;
            this.btnSortearNum.Click += new System.EventHandler(this.btnSortearNum_Click);
            // 
            // lblNumeros
            // 
            this.lblNumeros.Location = new System.Drawing.Point(65, 105);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(234, 45);
            this.lblNumeros.TabIndex = 4;
            this.lblNumeros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstCartoes
            // 
            this.lstCartoes.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCartoes.FormattingEnabled = true;
            this.lstCartoes.ItemHeight = 22;
            this.lstCartoes.Location = new System.Drawing.Point(73, 217);
            this.lstCartoes.Name = "lstCartoes";
            this.lstCartoes.Size = new System.Drawing.Size(207, 158);
            this.lstCartoes.TabIndex = 5;
            // 
            // frmMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.lstCartoes);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.btnSortearNum);
            this.Controls.Add(this.txtQntdDeCartões);
            this.Controls.Add(this.lblQtde);
            this.Name = "frmMegaSena";
            this.Text = "Megasena";
            this.Load += new System.EventHandler(this.Megasena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.TextBox txtQntdDeCartões;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSortearNum;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.ListBox lstCartoes;
    }
}