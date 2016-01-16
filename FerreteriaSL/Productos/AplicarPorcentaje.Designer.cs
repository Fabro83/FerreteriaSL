using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Productos
{
    partial class AplicarPorcentaje
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.nud_percent = new System.Windows.Forms.NumericUpDown();
            this.lbl_percentSymbol = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_percent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.Location = new System.Drawing.Point(9, 9);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(290, 26);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Ingrese el porcentaje a aplicar a los articulos seleccionados.";
            // 
            // nud_percent
            // 
            this.nud_percent.DecimalPlaces = 2;
            this.nud_percent.Location = new System.Drawing.Point(118, 40);
            this.nud_percent.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_percent.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_percent.Name = "nud_percent";
            this.nud_percent.Size = new System.Drawing.Size(57, 20);
            this.nud_percent.TabIndex = 1;
            this.nud_percent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_percent_KeyPress);
            // 
            // lbl_percentSymbol
            // 
            this.lbl_percentSymbol.AutoSize = true;
            this.lbl_percentSymbol.Location = new System.Drawing.Point(175, 44);
            this.lbl_percentSymbol.Name = "lbl_percentSymbol";
            this.lbl_percentSymbol.Size = new System.Drawing.Size(15, 13);
            this.lbl_percentSymbol.TabIndex = 2;
            this.lbl_percentSymbol.Text = "%";
            // 
            // btn_apply
            // 
            this.btn_apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_apply.Location = new System.Drawing.Point(76, 76);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Aplicar";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(157, 76);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // AplicarPorcentaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 113);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.lbl_percentSymbol);
            this.Controls.Add(this.nud_percent);
            this.Controls.Add(this.lbl_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AplicarPorcentaje";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Porcentaje";
            ((System.ComponentModel.ISupportInitialize)(this.nud_percent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_info;
        private NumericUpDown nud_percent;
        private Label lbl_percentSymbol;
        private Button btn_apply;
        private Button btn_cancel;
    }
}