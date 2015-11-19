using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Ventas
{
    partial class ConfirmacionVenta
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
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_totalMonto = new System.Windows.Forms.Label();
            this.lbl_pagaCon = new System.Windows.Forms.Label();
            this.tb_pagaConMonto = new System.Windows.Forms.TextBox();
            this.lbl_vuelto = new System.Windows.Forms.Label();
            this.lbl_vueltoMonto = new System.Windows.Forms.Label();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_otherForms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(187, 19);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(149, 55);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "Total:";
            // 
            // lbl_totalMonto
            // 
            this.lbl_totalMonto.AutoSize = true;
            this.lbl_totalMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalMonto.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_totalMonto.Location = new System.Drawing.Point(336, 19);
            this.lbl_totalMonto.Name = "lbl_totalMonto";
            this.lbl_totalMonto.Size = new System.Drawing.Size(150, 55);
            this.lbl_totalMonto.TabIndex = 1;
            this.lbl_totalMonto.Text = "$0,00";
            // 
            // lbl_pagaCon
            // 
            this.lbl_pagaCon.AutoSize = true;
            this.lbl_pagaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagaCon.Location = new System.Drawing.Point(190, 94);
            this.lbl_pagaCon.Name = "lbl_pagaCon";
            this.lbl_pagaCon.Size = new System.Drawing.Size(189, 37);
            this.lbl_pagaCon.TabIndex = 2;
            this.lbl_pagaCon.Text = "Paga con: $";
            // 
            // tb_pagaConMonto
            // 
            this.tb_pagaConMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pagaConMonto.Location = new System.Drawing.Point(379, 90);
            this.tb_pagaConMonto.Name = "tb_pagaConMonto";
            this.tb_pagaConMonto.Size = new System.Drawing.Size(117, 44);
            this.tb_pagaConMonto.TabIndex = 3;
            this.tb_pagaConMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pagaConMonto.TextChanged += new System.EventHandler(this.tb_pagaConMonto_TextChanged);
            this.tb_pagaConMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pagaConMonto_KeyPress);
            // 
            // lbl_vuelto
            // 
            this.lbl_vuelto.AutoSize = true;
            this.lbl_vuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vuelto.Location = new System.Drawing.Point(214, 155);
            this.lbl_vuelto.Name = "lbl_vuelto";
            this.lbl_vuelto.Size = new System.Drawing.Size(141, 42);
            this.lbl_vuelto.TabIndex = 4;
            this.lbl_vuelto.Text = "Vuelto:";
            // 
            // lbl_vueltoMonto
            // 
            this.lbl_vueltoMonto.AutoSize = true;
            this.lbl_vueltoMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vueltoMonto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_vueltoMonto.Location = new System.Drawing.Point(355, 155);
            this.lbl_vueltoMonto.Name = "lbl_vueltoMonto";
            this.lbl_vueltoMonto.Size = new System.Drawing.Size(117, 42);
            this.lbl_vueltoMonto.TabIndex = 5;
            this.lbl_vueltoMonto.Text = "$0,00";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.AutoSize = true;
            this.btn_finalizar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_finalizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_finalizar.Location = new System.Drawing.Point(148, 229);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(166, 35);
            this.btn_finalizar.TabIndex = 6;
            this.btn_finalizar.Text = "Finalizar Venta";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(364, 229);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(170, 35);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar Venta";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_otherForms
            // 
            this.btn_otherForms.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_otherForms.Location = new System.Drawing.Point(577, 229);
            this.btn_otherForms.Name = "btn_otherForms";
            this.btn_otherForms.Size = new System.Drawing.Size(85, 35);
            this.btn_otherForms.TabIndex = 8;
            this.btn_otherForms.Text = "Otras Formas de Pago";
            this.btn_otherForms.UseVisualStyleBackColor = true;
            // 
            // ConfirmacionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(679, 286);
            this.ControlBox = false;
            this.Controls.Add(this.btn_otherForms);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.lbl_vueltoMonto);
            this.Controls.Add(this.lbl_vuelto);
            this.Controls.Add(this.tb_pagaConMonto);
            this.Controls.Add(this.lbl_pagaCon);
            this.Controls.Add(this.lbl_totalMonto);
            this.Controls.Add(this.lbl_total);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmacionVenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmar Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_total;
        private Label lbl_totalMonto;
        private Label lbl_pagaCon;
        private TextBox tb_pagaConMonto;
        private Label lbl_vuelto;
        private Label lbl_vueltoMonto;
        private Button btn_finalizar;
        private Button btn_cancelar;
        private Button btn_otherForms;
    }
}