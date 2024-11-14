namespace Olamundo
{
    partial class frmOlaMundo
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
            this.btnOlaMundo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOlaMundo
            // 
            this.btnOlaMundo.Location = new System.Drawing.Point(421, 99);
            this.btnOlaMundo.Name = "btnOlaMundo";
            this.btnOlaMundo.Size = new System.Drawing.Size(103, 48);
            this.btnOlaMundo.TabIndex = 0;
            this.btnOlaMundo.Text = "Clique Aqui";
            this.btnOlaMundo.UseVisualStyleBackColor = true;
            this.btnOlaMundo.Click += new System.EventHandler(this.btnOlaMundo_Click);
            // 
            // frmOlaMundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOlaMundo);
            this.Name = "frmOlaMundo";
            this.Text = "Ola Mundo!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlaMundo;
    }
}

