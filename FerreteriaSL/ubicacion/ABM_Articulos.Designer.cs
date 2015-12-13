namespace FerreteriaSL
{
    partial class ABM_Articulos
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
            this.gb_articlesInSection = new System.Windows.Forms.GroupBox();
            this.gb_articles = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gb_articlesInSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_articlesInSection
            // 
            this.gb_articlesInSection.Controls.Add(this.textBox1);
            this.gb_articlesInSection.Location = new System.Drawing.Point(12, 12);
            this.gb_articlesInSection.Name = "gb_articlesInSection";
            this.gb_articlesInSection.Size = new System.Drawing.Size(555, 515);
            this.gb_articlesInSection.TabIndex = 0;
            this.gb_articlesInSection.TabStop = false;
            this.gb_articlesInSection.Text = "Articulos en Sección";
            // 
            // gb_articles
            // 
            this.gb_articles.Location = new System.Drawing.Point(573, 12);
            this.gb_articles.Name = "gb_articles";
            this.gb_articles.Size = new System.Drawing.Size(500, 503);
            this.gb_articles.TabIndex = 1;
            this.gb_articles.TabStop = false;
            this.gb_articles.Text = "Articulos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ABM_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 539);
            this.Controls.Add(this.gb_articles);
            this.Controls.Add(this.gb_articlesInSection);
            this.Name = "ABM_Articulos";
            this.Text = "ABM_Articulos";
            this.gb_articlesInSection.ResumeLayout(false);
            this.gb_articlesInSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_articlesInSection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gb_articles;
    }
}