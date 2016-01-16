using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Ventas
{
    partial class BusquedaProductoAgregarCantidad
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
            this.lbl_unidadesAgregar = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_ppuFirstStatic = new System.Windows.Forms.Label();
            this.lbl_ppuFirstVariable = new System.Windows.Forms.Label();
            this.lbl_ppuSecondVariable = new System.Windows.Forms.Label();
            this.lbl_ppuThirdVariable = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_calculator = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_unidadesAgregar
            // 
            this.lbl_unidadesAgregar.AutoSize = true;
            this.lbl_unidadesAgregar.Location = new System.Drawing.Point(102, 59);
            this.lbl_unidadesAgregar.Name = "lbl_unidadesAgregar";
            this.lbl_unidadesAgregar.Size = new System.Drawing.Size(106, 13);
            this.lbl_unidadesAgregar.TabIndex = 0;
            this.lbl_unidadesAgregar.Text = "Unidades a agregar: ";
            // 
            // btn_add
            // 
            this.btn_add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_add.Location = new System.Drawing.Point(121, 92);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(202, 92);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoEllipsis = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(12, 9);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(374, 13);
            this.lbl_productName.TabIndex = 4;
            this.lbl_productName.Text = "Nombre Producto";
            this.lbl_productName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ppuFirstStatic
            // 
            this.lbl_ppuFirstStatic.AutoSize = true;
            this.lbl_ppuFirstStatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ppuFirstStatic.Location = new System.Drawing.Point(3, 0);
            this.lbl_ppuFirstStatic.Name = "lbl_ppuFirstStatic";
            this.lbl_ppuFirstStatic.Size = new System.Drawing.Size(64, 13);
            this.lbl_ppuFirstStatic.TabIndex = 5;
            this.lbl_ppuFirstStatic.Text = "Precio por";
            this.lbl_ppuFirstStatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ppuFirstVariable
            // 
            this.lbl_ppuFirstVariable.AutoSize = true;
            this.lbl_ppuFirstVariable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ppuFirstVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ppuFirstVariable.Location = new System.Drawing.Point(73, 0);
            this.lbl_ppuFirstVariable.Name = "lbl_ppuFirstVariable";
            this.lbl_ppuFirstVariable.Size = new System.Drawing.Size(28, 13);
            this.lbl_ppuFirstVariable.TabIndex = 6;
            this.lbl_ppuFirstVariable.Text = "000";
            this.lbl_ppuFirstVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ppuSecondVariable
            // 
            this.lbl_ppuSecondVariable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ppuSecondVariable.AutoSize = true;
            this.lbl_ppuSecondVariable.Location = new System.Drawing.Point(112, 0);
            this.lbl_ppuSecondVariable.Name = "lbl_ppuSecondVariable";
            this.lbl_ppuSecondVariable.Size = new System.Drawing.Size(53, 13);
            this.lbl_ppuSecondVariable.TabIndex = 7;
            this.lbl_ppuSecondVariable.Text = "unidades:";
            // 
            // lbl_ppuThirdVariable
            // 
            this.lbl_ppuThirdVariable.AutoSize = true;
            this.lbl_ppuThirdVariable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ppuThirdVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ppuThirdVariable.Location = new System.Drawing.Point(177, 0);
            this.lbl_ppuThirdVariable.Name = "lbl_ppuThirdVariable";
            this.lbl_ppuThirdVariable.Size = new System.Drawing.Size(194, 13);
            this.lbl_ppuThirdVariable.TabIndex = 8;
            this.lbl_ppuThirdVariable.Text = "$0.00";
            this.lbl_ppuThirdVariable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(208, 55);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(69, 20);
            this.tb_quantity.TabIndex = 9;
            this.tb_quantity.TextChanged += new System.EventHandler(this.tb_quantity_TextChanged);
            this.tb_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_quantity_KeyDown);
            this.tb_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_quantity_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lbl_ppuFirstVariable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ppuSecondVariable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ppuFirstStatic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ppuThirdVariable, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 13);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btn_calculator
            // 
            this.btn_calculator.Location = new System.Drawing.Point(363, 92);
            this.btn_calculator.Name = "btn_calculator";
            this.btn_calculator.Size = new System.Drawing.Size(23, 23);
            this.btn_calculator.TabIndex = 11;
            this.btn_calculator.Text = "C";
            this.btn_calculator.UseVisualStyleBackColor = true;
            this.btn_calculator.Click += new System.EventHandler(this.btn_calculator_Click);
            // 
            // BusquedaProductoAgregarCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(398, 128);
            this.ControlBox = false;
            this.Controls.Add(this.btn_calculator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_unidadesAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BusquedaProductoAgregarCantidad";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cantidad";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BusquedaProductoAgregarCantidad_Load);
            this.Shown += new System.EventHandler(this.BusquedaProductoAgregarCantidad_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_unidadesAgregar;
        private Button btn_add;
        private Button btn_cancel;
        private Label lbl_productName;
        private Label lbl_ppuFirstStatic;
        private Label lbl_ppuFirstVariable;
        private Label lbl_ppuSecondVariable;
        private Label lbl_ppuThirdVariable;
        private TextBox tb_quantity;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_calculator;
    }
}