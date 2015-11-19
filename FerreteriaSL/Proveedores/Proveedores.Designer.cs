using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Proveedores
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.lb_providers = new System.Windows.Forms.ListBox();
            this.gb_providerData = new System.Windows.Forms.GroupBox();
            this.gb_statistics = new System.Windows.Forms.GroupBox();
            this.lbl_itemQuantityInStockValue = new System.Windows.Forms.Label();
            this.lbl_itemQuantityInStock = new System.Windows.Forms.Label();
            this.lbl_totalImportValue = new System.Windows.Forms.Label();
            this.lbl_soldItemsValue = new System.Windows.Forms.Label();
            this.lbl_itemQuantityValue = new System.Windows.Forms.Label();
            this.lbl_totalImport = new System.Windows.Forms.Label();
            this.lbl_soldItems = new System.Windows.Forms.Label();
            this.lbl_itemQuantity = new System.Windows.Forms.Label();
            this.tb_providerAddress = new System.Windows.Forms.TextBox();
            this.tb_providerPhone = new System.Windows.Forms.TextBox();
            this.btn_deleteProvider = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_providerAddress = new System.Windows.Forms.Label();
            this.tb_providerCuit = new System.Windows.Forms.TextBox();
            this.tb_providerName = new System.Windows.Forms.TextBox();
            this.lbl_providerPhone = new System.Windows.Forms.Label();
            this.lbl_providerCuit = new System.Windows.Forms.Label();
            this.lbl_providerName = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addNewProvider = new System.Windows.Forms.Button();
            this.gb_providerData.SuspendLayout();
            this.gb_statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_providers
            // 
            this.lb_providers.FormattingEnabled = true;
            this.lb_providers.Location = new System.Drawing.Point(12, 12);
            this.lb_providers.Name = "lb_providers";
            this.lb_providers.Size = new System.Drawing.Size(191, 290);
            this.lb_providers.TabIndex = 0;
            this.lb_providers.SelectedIndexChanged += new System.EventHandler(this.lb_provider_SelectedIndexChanged);
            // 
            // gb_providerData
            // 
            this.gb_providerData.Controls.Add(this.gb_statistics);
            this.gb_providerData.Controls.Add(this.tb_providerAddress);
            this.gb_providerData.Controls.Add(this.tb_providerPhone);
            this.gb_providerData.Controls.Add(this.btn_deleteProvider);
            this.gb_providerData.Controls.Add(this.btn_save);
            this.gb_providerData.Controls.Add(this.lbl_providerAddress);
            this.gb_providerData.Controls.Add(this.tb_providerCuit);
            this.gb_providerData.Controls.Add(this.tb_providerName);
            this.gb_providerData.Controls.Add(this.lbl_providerPhone);
            this.gb_providerData.Controls.Add(this.lbl_providerCuit);
            this.gb_providerData.Controls.Add(this.lbl_providerName);
            this.gb_providerData.Enabled = false;
            this.gb_providerData.Location = new System.Drawing.Point(209, 12);
            this.gb_providerData.Name = "gb_providerData";
            this.gb_providerData.Size = new System.Drawing.Size(367, 290);
            this.gb_providerData.TabIndex = 1;
            this.gb_providerData.TabStop = false;
            this.gb_providerData.Text = "Datos de";
            // 
            // gb_statistics
            // 
            this.gb_statistics.Controls.Add(this.lbl_itemQuantityInStockValue);
            this.gb_statistics.Controls.Add(this.lbl_itemQuantityInStock);
            this.gb_statistics.Controls.Add(this.lbl_totalImportValue);
            this.gb_statistics.Controls.Add(this.lbl_soldItemsValue);
            this.gb_statistics.Controls.Add(this.lbl_itemQuantityValue);
            this.gb_statistics.Controls.Add(this.lbl_totalImport);
            this.gb_statistics.Controls.Add(this.lbl_soldItems);
            this.gb_statistics.Controls.Add(this.lbl_itemQuantity);
            this.gb_statistics.Location = new System.Drawing.Point(9, 126);
            this.gb_statistics.Name = "gb_statistics";
            this.gb_statistics.Size = new System.Drawing.Size(343, 129);
            this.gb_statistics.TabIndex = 23;
            this.gb_statistics.TabStop = false;
            this.gb_statistics.Text = "Estadísticas";
            // 
            // lbl_itemQuantityInStockValue
            // 
            this.lbl_itemQuantityInStockValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemQuantityInStockValue.Location = new System.Drawing.Point(171, 54);
            this.lbl_itemQuantityInStockValue.Name = "lbl_itemQuantityInStockValue";
            this.lbl_itemQuantityInStockValue.Size = new System.Drawing.Size(166, 13);
            this.lbl_itemQuantityInStockValue.TabIndex = 7;
            // 
            // lbl_itemQuantityInStock
            // 
            this.lbl_itemQuantityInStock.AutoSize = true;
            this.lbl_itemQuantityInStock.Location = new System.Drawing.Point(8, 54);
            this.lbl_itemQuantityInStock.Name = "lbl_itemQuantityInStock";
            this.lbl_itemQuantityInStock.Size = new System.Drawing.Size(164, 13);
            this.lbl_itemQuantityInStock.TabIndex = 6;
            this.lbl_itemQuantityInStock.Text = "Cantidad de Productos en Stock:";
            // 
            // lbl_totalImportValue
            // 
            this.lbl_totalImportValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalImportValue.Location = new System.Drawing.Point(171, 104);
            this.lbl_totalImportValue.Name = "lbl_totalImportValue";
            this.lbl_totalImportValue.Size = new System.Drawing.Size(166, 13);
            this.lbl_totalImportValue.TabIndex = 5;
            // 
            // lbl_soldItemsValue
            // 
            this.lbl_soldItemsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soldItemsValue.Location = new System.Drawing.Point(171, 79);
            this.lbl_soldItemsValue.Name = "lbl_soldItemsValue";
            this.lbl_soldItemsValue.Size = new System.Drawing.Size(166, 13);
            this.lbl_soldItemsValue.TabIndex = 4;
            // 
            // lbl_itemQuantityValue
            // 
            this.lbl_itemQuantityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemQuantityValue.Location = new System.Drawing.Point(171, 29);
            this.lbl_itemQuantityValue.Name = "lbl_itemQuantityValue";
            this.lbl_itemQuantityValue.Size = new System.Drawing.Size(166, 13);
            this.lbl_itemQuantityValue.TabIndex = 3;
            // 
            // lbl_totalImport
            // 
            this.lbl_totalImport.AutoSize = true;
            this.lbl_totalImport.Location = new System.Drawing.Point(88, 104);
            this.lbl_totalImport.Name = "lbl_totalImport";
            this.lbl_totalImport.Size = new System.Drawing.Size(85, 13);
            this.lbl_totalImport.TabIndex = 2;
            this.lbl_totalImport.Text = "Total en Ventas:";
            // 
            // lbl_soldItems
            // 
            this.lbl_soldItems.AutoSize = true;
            this.lbl_soldItems.Location = new System.Drawing.Point(7, 79);
            this.lbl_soldItems.Name = "lbl_soldItems";
            this.lbl_soldItems.Size = new System.Drawing.Size(165, 13);
            this.lbl_soldItems.TabIndex = 1;
            this.lbl_soldItems.Text = "Cantidad de Productos Vendidos:";
            // 
            // lbl_itemQuantity
            // 
            this.lbl_itemQuantity.AutoSize = true;
            this.lbl_itemQuantity.Location = new System.Drawing.Point(14, 29);
            this.lbl_itemQuantity.Name = "lbl_itemQuantity";
            this.lbl_itemQuantity.Size = new System.Drawing.Size(158, 13);
            this.lbl_itemQuantity.TabIndex = 0;
            this.lbl_itemQuantity.Text = "Cantidad de Productos en Lista:";
            // 
            // tb_providerAddress
            // 
            this.tb_providerAddress.Location = new System.Drawing.Point(122, 86);
            this.tb_providerAddress.Name = "tb_providerAddress";
            this.tb_providerAddress.Size = new System.Drawing.Size(230, 20);
            this.tb_providerAddress.TabIndex = 3;
            this.tb_providerAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // tb_providerPhone
            // 
            this.tb_providerPhone.Location = new System.Drawing.Point(122, 65);
            this.tb_providerPhone.Name = "tb_providerPhone";
            this.tb_providerPhone.Size = new System.Drawing.Size(230, 20);
            this.tb_providerPhone.TabIndex = 2;
            this.tb_providerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // btn_deleteProvider
            // 
            this.btn_deleteProvider.Location = new System.Drawing.Point(166, 261);
            this.btn_deleteProvider.Name = "btn_deleteProvider";
            this.btn_deleteProvider.Size = new System.Drawing.Size(114, 23);
            this.btn_deleteProvider.TabIndex = 20;
            this.btn_deleteProvider.Text = "Eliminar Proveedor";
            this.btn_deleteProvider.UseVisualStyleBackColor = true;
            this.btn_deleteProvider.Click += new System.EventHandler(this.btn_deleteProvider_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(286, 261);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_providerAddress
            // 
            this.lbl_providerAddress.AutoSize = true;
            this.lbl_providerAddress.Location = new System.Drawing.Point(65, 90);
            this.lbl_providerAddress.Name = "lbl_providerAddress";
            this.lbl_providerAddress.Size = new System.Drawing.Size(55, 13);
            this.lbl_providerAddress.TabIndex = 7;
            this.lbl_providerAddress.Text = "Dirección:";
            // 
            // tb_providerCuit
            // 
            this.tb_providerCuit.Location = new System.Drawing.Point(122, 44);
            this.tb_providerCuit.Name = "tb_providerCuit";
            this.tb_providerCuit.Size = new System.Drawing.Size(230, 20);
            this.tb_providerCuit.TabIndex = 1;
            this.tb_providerCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // tb_providerName
            // 
            this.tb_providerName.Location = new System.Drawing.Point(122, 24);
            this.tb_providerName.Name = "tb_providerName";
            this.tb_providerName.Size = new System.Drawing.Size(230, 20);
            this.tb_providerName.TabIndex = 0;
            this.tb_providerName.TextChanged += new System.EventHandler(this.tb_providerName_TextChanged);
            this.tb_providerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // lbl_providerPhone
            // 
            this.lbl_providerPhone.AutoSize = true;
            this.lbl_providerPhone.Location = new System.Drawing.Point(68, 69);
            this.lbl_providerPhone.Name = "lbl_providerPhone";
            this.lbl_providerPhone.Size = new System.Drawing.Size(52, 13);
            this.lbl_providerPhone.TabIndex = 2;
            this.lbl_providerPhone.Text = "Teléfono:";
            // 
            // lbl_providerCuit
            // 
            this.lbl_providerCuit.AutoSize = true;
            this.lbl_providerCuit.Location = new System.Drawing.Point(85, 48);
            this.lbl_providerCuit.Name = "lbl_providerCuit";
            this.lbl_providerCuit.Size = new System.Drawing.Size(35, 13);
            this.lbl_providerCuit.TabIndex = 1;
            this.lbl_providerCuit.Text = "CUIT:";
            // 
            // lbl_providerName
            // 
            this.lbl_providerName.AutoSize = true;
            this.lbl_providerName.Location = new System.Drawing.Point(6, 27);
            this.lbl_providerName.Name = "lbl_providerName";
            this.lbl_providerName.Size = new System.Drawing.Size(114, 13);
            this.lbl_providerName.TabIndex = 0;
            this.lbl_providerName.Text = "Nombre de Proveedor:";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(257, 308);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addNewProvider
            // 
            this.btn_addNewProvider.Location = new System.Drawing.Point(12, 306);
            this.btn_addNewProvider.Name = "btn_addNewProvider";
            this.btn_addNewProvider.Size = new System.Drawing.Size(191, 23);
            this.btn_addNewProvider.TabIndex = 3;
            this.btn_addNewProvider.Text = "Agregar Nuevo Proveedor";
            this.btn_addNewProvider.UseVisualStyleBackColor = true;
            this.btn_addNewProvider.Click += new System.EventHandler(this.btn_addNewProvider_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(588, 341);
            this.Controls.Add(this.btn_addNewProvider);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.gb_providerData);
            this.Controls.Add(this.lb_providers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Proveedores";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.gb_providerData.ResumeLayout(false);
            this.gb_providerData.PerformLayout();
            this.gb_statistics.ResumeLayout(false);
            this.gb_statistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lb_providers;
        private GroupBox gb_providerData;
        private Button btn_save;
        private Label lbl_providerAddress;
        private TextBox tb_providerCuit;
        private TextBox tb_providerName;
        private Label lbl_providerPhone;
        private Label lbl_providerCuit;
        private Label lbl_providerName;
        private Button btn_close;
        private Button btn_deleteProvider;
        private Button btn_addNewProvider;
        private TextBox tb_providerPhone;
        private GroupBox gb_statistics;
        private Label lbl_totalImport;
        private Label lbl_soldItems;
        private Label lbl_itemQuantity;
        private TextBox tb_providerAddress;
        private Label lbl_totalImportValue;
        private Label lbl_soldItemsValue;
        private Label lbl_itemQuantityValue;
        private Label lbl_itemQuantityInStockValue;
        private Label lbl_itemQuantityInStock;
    }
}