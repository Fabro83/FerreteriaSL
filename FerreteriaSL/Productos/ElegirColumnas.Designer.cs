using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Productos
{
    partial class ElegirColumnas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btn_ok = new System.Windows.Forms.Button();
            this.cbl_columns = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(100, 239);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Aceptar";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // cbl_columns
            // 
            this.cbl_columns.CheckOnClick = true;
            this.cbl_columns.FormattingEnabled = true;
            this.cbl_columns.Location = new System.Drawing.Point(14, 12);
            this.cbl_columns.Name = "cbl_columns";
            this.cbl_columns.Size = new System.Drawing.Size(246, 214);
            this.cbl_columns.TabIndex = 0;
            this.cbl_columns.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbl_columns_ItemCheck);
            // 
            // ElegirColumnas
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 274);
            this.ControlBox = false;
            this.Controls.Add(this.cbl_columns);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ElegirColumnas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Columnas a mostrar...";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_ok;
        public CheckedListBox cbl_columns;
    }
}