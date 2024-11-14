namespace ParImpar
{
    partial class frmParouImpar
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
            System.Windows.Forms.Label lblPar;
            System.Windows.Forms.Label lblImpar;
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnParImpar = new System.Windows.Forms.Button();
            lblPar = new System.Windows.Forms.Label();
            lblImpar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.White;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.Black;
            this.lblNumero.Location = new System.Drawing.Point(65, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(241, 25);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Entre com um número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(327, 34);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(189, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // lblPar
            // 
            lblPar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            lblPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPar.ForeColor = System.Drawing.Color.White;
            lblPar.Location = new System.Drawing.Point(46, 87);
            lblPar.Name = "lblPar";
            lblPar.Size = new System.Drawing.Size(732, 203);
            lblPar.TabIndex = 2;
            lblPar.Text = "Par";
            lblPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpar
            // 
            lblImpar.BackColor = System.Drawing.Color.Red;
            lblImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblImpar.ForeColor = System.Drawing.Color.White;
            lblImpar.Location = new System.Drawing.Point(51, 145);
            lblImpar.Name = "lblImpar";
            lblImpar.Size = new System.Drawing.Size(737, 203);
            lblImpar.TabIndex = 3;
            lblImpar.Text = "Impar";
            lblImpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnParImpar
            // 
            this.btnParImpar.Location = new System.Drawing.Point(36, 293);
            this.btnParImpar.Name = "btnParImpar";
            this.btnParImpar.Size = new System.Drawing.Size(742, 145);
            this.btnParImpar.TabIndex = 4;
            this.btnParImpar.Text = "Par ou impar ?";
            this.btnParImpar.UseVisualStyleBackColor = true;
            // 
            // frmParouImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParImpar);
            this.Controls.Add(lblImpar);
            this.Controls.Add(lblPar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParouImpar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Par ou Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnParImpar;
    }
}

