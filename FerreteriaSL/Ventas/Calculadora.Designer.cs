using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Ventas
{
    partial class Calculadora
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.gb_units = new System.Windows.Forms.GroupBox();
            this.lbl_equivalentUnits = new System.Windows.Forms.Label();
            this.lbl_info3 = new System.Windows.Forms.Label();
            this.tb_articleUnitsToSell = new System.Windows.Forms.TextBox();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.tb_articleContains = new System.Windows.Forms.TextBox();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.gb_units.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_insert.Location = new System.Drawing.Point(93, 194);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Insertar";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(174, 194);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Peso o unidades en paquete",
            "Precio objetivo"});
            this.cb_type.Location = new System.Drawing.Point(168, 10);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(157, 21);
            this.cb_type.TabIndex = 2;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(18, 13);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(144, 13);
            this.lbl_type.TabIndex = 3;
            this.lbl_type.Text = "Obtener unidades a partir de:";
            // 
            // gb_units
            // 
            this.gb_units.Controls.Add(this.lbl_equivalentUnits);
            this.gb_units.Controls.Add(this.lbl_info3);
            this.gb_units.Controls.Add(this.tb_articleUnitsToSell);
            this.gb_units.Controls.Add(this.lbl_info2);
            this.gb_units.Controls.Add(this.tb_articleContains);
            this.gb_units.Controls.Add(this.lbl_info1);
            this.gb_units.Location = new System.Drawing.Point(19, 37);
            this.gb_units.Name = "gb_units";
            this.gb_units.Size = new System.Drawing.Size(304, 151);
            this.gb_units.TabIndex = 4;
            this.gb_units.TabStop = false;
            this.gb_units.Text = "Peso o unidades en paquete";
            // 
            // lbl_equivalentUnits
            // 
            this.lbl_equivalentUnits.AutoSize = true;
            this.lbl_equivalentUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equivalentUnits.Location = new System.Drawing.Point(163, 101);
            this.lbl_equivalentUnits.Name = "lbl_equivalentUnits";
            this.lbl_equivalentUnits.Size = new System.Drawing.Size(30, 13);
            this.lbl_equivalentUnits.TabIndex = 5;
            this.lbl_equivalentUnits.Text = "N/A";
            // 
            // lbl_info3
            // 
            this.lbl_info3.AutoSize = true;
            this.lbl_info3.Location = new System.Drawing.Point(42, 101);
            this.lbl_info3.Name = "lbl_info3";
            this.lbl_info3.Size = new System.Drawing.Size(118, 13);
            this.lbl_info3.TabIndex = 4;
            this.lbl_info3.Text = "Unidades equivalentes:";
            // 
            // tb_articleUnitsToSell
            // 
            this.tb_articleUnitsToSell.Location = new System.Drawing.Point(163, 64);
            this.tb_articleUnitsToSell.Name = "tb_articleUnitsToSell";
            this.tb_articleUnitsToSell.Size = new System.Drawing.Size(100, 20);
            this.tb_articleUnitsToSell.TabIndex = 3;
            this.tb_articleUnitsToSell.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_articleUnitsToSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // lbl_info2
            // 
            this.lbl_info2.AutoSize = true;
            this.lbl_info2.Location = new System.Drawing.Point(69, 68);
            this.lbl_info2.Name = "lbl_info2";
            this.lbl_info2.Size = new System.Drawing.Size(91, 13);
            this.lbl_info2.TabIndex = 2;
            this.lbl_info2.Text = "Se quiere vender:";
            // 
            // tb_articleContains
            // 
            this.tb_articleContains.Location = new System.Drawing.Point(163, 31);
            this.tb_articleContains.Name = "tb_articleContains";
            this.tb_articleContains.Size = new System.Drawing.Size(100, 20);
            this.tb_articleContains.TabIndex = 1;
            this.tb_articleContains.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_articleContains.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // lbl_info1
            // 
            this.lbl_info1.Location = new System.Drawing.Point(45, 35);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(115, 13);
            this.lbl_info1.TabIndex = 0;
            this.lbl_info1.Text = "El articulo contiene:";
            this.lbl_info1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(343, 227);
            this.ControlBox = false;
            this.Controls.Add(this.gb_units);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculadora";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.gb_units.ResumeLayout(false);
            this.gb_units.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_insert;
        private Button btn_cancel;
        private ComboBox cb_type;
        private Label lbl_type;
        private GroupBox gb_units;
        private Label lbl_equivalentUnits;
        private Label lbl_info3;
        private TextBox tb_articleUnitsToSell;
        private Label lbl_info2;
        private TextBox tb_articleContains;
        private Label lbl_info1;
    }
}