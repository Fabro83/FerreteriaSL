namespace FerreteriaSL.ExcelExporter
{
    partial class ExcelExporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelExporter));
            this.lbl_message = new System.Windows.Forms.Label();
            this.pb_progress = new System.Windows.Forms.ProgressBar();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.llbl_openFolder = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(18, 11);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(211, 13);
            this.lbl_message.TabIndex = 0;
            this.lbl_message.Text = "Exportando a Excel, un momento por favor.";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_progress
            // 
            this.pb_progress.Location = new System.Drawing.Point(18, 32);
            this.pb_progress.Name = "pb_progress";
            this.pb_progress.Size = new System.Drawing.Size(211, 23);
            this.pb_progress.TabIndex = 1;
            // 
            // lbl_info
            // 
            this.lbl_info.Location = new System.Drawing.Point(18, 66);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(211, 13);
            this.lbl_info.TabIndex = 2;
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Location = new System.Drawing.Point(86, 108);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // llbl_openFolder
            // 
            this.llbl_openFolder.AutoSize = true;
            this.llbl_openFolder.Enabled = false;
            this.llbl_openFolder.Location = new System.Drawing.Point(61, 86);
            this.llbl_openFolder.Name = "llbl_openFolder";
            this.llbl_openFolder.Size = new System.Drawing.Size(124, 13);
            this.llbl_openFolder.TabIndex = 4;
            this.llbl_openFolder.TabStop = true;
            this.llbl_openFolder.Text = "Abrir carpeta contendora";
            this.llbl_openFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_openFolder_LinkClicked);
            // 
            // ExcelExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(247, 141);
            this.ControlBox = false;
            this.Controls.Add(this.llbl_openFolder);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.pb_progress);
            this.Controls.Add(this.lbl_message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcelExporter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exportando...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.ProgressBar pb_progress;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.LinkLabel llbl_openFolder;
    }
}