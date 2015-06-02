namespace FerreteriaSL
{
    partial class BusquedaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaProducto));
            this.dgv_productList = new System.Windows.Forms.DataGridView();
            this.tb_filterWords = new System.Windows.Forms.TextBox();
            this.cb_filterProvider = new System.Windows.Forms.ComboBox();
            this.chb_stock = new System.Windows.Forms.CheckBox();
            this.btn_nextPage = new System.Windows.Forms.Button();
            this.btn_prevPage = new System.Windows.Forms.Button();
            this.lbl_pageInfo = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_productList
            // 
            this.dgv_productList.AllowUserToAddRows = false;
            this.dgv_productList.AllowUserToDeleteRows = false;
            this.dgv_productList.AllowUserToResizeRows = false;
            this.dgv_productList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_productList.Location = new System.Drawing.Point(12, 39);
            this.dgv_productList.MultiSelect = false;
            this.dgv_productList.Name = "dgv_productList";
            this.dgv_productList.ReadOnly = true;
            this.dgv_productList.RowHeadersVisible = false;
            this.dgv_productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productList.Size = new System.Drawing.Size(777, 568);
            this.dgv_productList.TabIndex = 0;
            this.dgv_productList.DataSourceChanged += new System.EventHandler(this.dgv_productList_DataSourceChanged);
            this.dgv_productList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_productList_CellMouseDoubleClick);
            this.dgv_productList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_productList_KeyDown);
            // 
            // tb_filterWords
            // 
            this.tb_filterWords.Location = new System.Drawing.Point(211, 12);
            this.tb_filterWords.Name = "tb_filterWords";
            this.tb_filterWords.Size = new System.Drawing.Size(478, 20);
            this.tb_filterWords.TabIndex = 1;
            this.tb_filterWords.TextChanged += new System.EventHandler(this.tb_filterWords_TextChanged);
            this.tb_filterWords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_filterWords_KeyDown);
            // 
            // cb_filterProvider
            // 
            this.cb_filterProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filterProvider.FormattingEnabled = true;
            this.cb_filterProvider.Location = new System.Drawing.Point(12, 12);
            this.cb_filterProvider.Name = "cb_filterProvider";
            this.cb_filterProvider.Size = new System.Drawing.Size(193, 21);
            this.cb_filterProvider.TabIndex = 2;
            this.cb_filterProvider.SelectedIndexChanged += new System.EventHandler(this.cb_filterProvider_SelectedIndexChanged);
            // 
            // chb_stock
            // 
            this.chb_stock.AutoSize = true;
            this.chb_stock.Location = new System.Drawing.Point(695, 14);
            this.chb_stock.Name = "chb_stock";
            this.chb_stock.Size = new System.Drawing.Size(76, 17);
            this.chb_stock.TabIndex = 3;
            this.chb_stock.Text = "Con Stock";
            this.chb_stock.UseVisualStyleBackColor = true;
            this.chb_stock.CheckedChanged += new System.EventHandler(this.chb_stock_CheckedChanged);
            // 
            // btn_nextPage
            // 
            this.btn_nextPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nextPage.BackgroundImage = global::FerreteriaSL.Properties.Resources.Arrow_Right;
            this.btn_nextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nextPage.Enabled = false;
            this.btn_nextPage.FlatAppearance.BorderSize = 0;
            this.btn_nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nextPage.Location = new System.Drawing.Point(766, 613);
            this.btn_nextPage.Name = "btn_nextPage";
            this.btn_nextPage.Size = new System.Drawing.Size(23, 23);
            this.btn_nextPage.TabIndex = 5;
            this.btn_nextPage.UseVisualStyleBackColor = true;
            this.btn_nextPage.Click += new System.EventHandler(this.btn_nextPage_Click);
            // 
            // btn_prevPage
            // 
            this.btn_prevPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prevPage.BackgroundImage = global::FerreteriaSL.Properties.Resources.Arrow_Left;
            this.btn_prevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prevPage.Enabled = false;
            this.btn_prevPage.FlatAppearance.BorderSize = 0;
            this.btn_prevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prevPage.Location = new System.Drawing.Point(659, 613);
            this.btn_prevPage.Name = "btn_prevPage";
            this.btn_prevPage.Size = new System.Drawing.Size(23, 23);
            this.btn_prevPage.TabIndex = 6;
            this.btn_prevPage.UseVisualStyleBackColor = true;
            this.btn_prevPage.Click += new System.EventHandler(this.btn_prevPage_Click);
            // 
            // lbl_pageInfo
            // 
            this.lbl_pageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pageInfo.Location = new System.Drawing.Point(682, 613);
            this.lbl_pageInfo.Name = "lbl_pageInfo";
            this.lbl_pageInfo.Size = new System.Drawing.Size(84, 23);
            this.lbl_pageInfo.TabIndex = 7;
            this.lbl_pageInfo.Text = "0/0";
            this.lbl_pageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 614);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(93, 618);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(41, 13);
            this.lbl_info.TabIndex = 9;
            this.lbl_info.Text = "sdgsdg";
            // 
            // BusquedaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_pageInfo);
            this.Controls.Add(this.btn_prevPage);
            this.Controls.Add(this.btn_nextPage);
            this.Controls.Add(this.chb_stock);
            this.Controls.Add(this.cb_filterProvider);
            this.Controls.Add(this.tb_filterWords);
            this.Controls.Add(this.dgv_productList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusquedaProducto";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BusquedaProducto_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productList;
        private System.Windows.Forms.TextBox tb_filterWords;
        private System.Windows.Forms.ComboBox cb_filterProvider;
        private System.Windows.Forms.CheckBox chb_stock;
        private System.Windows.Forms.Button btn_nextPage;
        private System.Windows.Forms.Button btn_prevPage;
        private System.Windows.Forms.Label lbl_pageInfo;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_info;
    }
}