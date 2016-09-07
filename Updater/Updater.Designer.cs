namespace Updater
{
    partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.lbUpdateInfo = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUpdateInfo
            // 
            this.lbUpdateInfo.AutoSize = true;
            this.lbUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdateInfo.Location = new System.Drawing.Point(74, 9);
            this.lbUpdateInfo.Name = "lbUpdateInfo";
            this.lbUpdateInfo.Size = new System.Drawing.Size(265, 25);
            this.lbUpdateInfo.TabIndex = 0;
            this.lbUpdateInfo.Text = "Un momento por favor...";
            // 
            // pbLoading
            // 
            this.pbLoading.Image = global::Updater.Properties.Resources.loading;
            this.pbLoading.Location = new System.Drawing.Point(173, 51);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(66, 69);
            this.pbLoading.TabIndex = 1;
            this.pbLoading.TabStop = false;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 159);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.lbUpdateInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizando";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Updater_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbUpdateInfo;
        public System.Windows.Forms.PictureBox pbLoading;

    }
}

