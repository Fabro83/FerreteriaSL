namespace FerreteriaSL.Ventas
{
    partial class ComboGrid
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_cuadroBusqueda = new System.Windows.Forms.TextBox();
            this.dgv_vistaResultados = new System.Windows.Forms.DataGridView();
            this.lbl_moreInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cuadroBusqueda
            // 
            this.tb_cuadroBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_cuadroBusqueda.Location = new System.Drawing.Point(0, 1);
            this.tb_cuadroBusqueda.Margin = new System.Windows.Forms.Padding(0);
            this.tb_cuadroBusqueda.Name = "tb_cuadroBusqueda";
            this.tb_cuadroBusqueda.Size = new System.Drawing.Size(395, 20);
            this.tb_cuadroBusqueda.TabIndex = 0;
            this.tb_cuadroBusqueda.TextChanged += new System.EventHandler(this.tb_cuadroBusqueda_TextChanged);
            this.tb_cuadroBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_cuadroBusqueda_KeyDown);
            // 
            // dgv_vistaResultados
            // 
            this.dgv_vistaResultados.AllowUserToAddRows = false;
            this.dgv_vistaResultados.AllowUserToDeleteRows = false;
            this.dgv_vistaResultados.AllowUserToResizeColumns = false;
            this.dgv_vistaResultados.AllowUserToResizeRows = false;
            this.dgv_vistaResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vistaResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vistaResultados.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_vistaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vistaResultados.ColumnHeadersVisible = false;
            this.dgv_vistaResultados.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_vistaResultados.Location = new System.Drawing.Point(0, 22);
            this.dgv_vistaResultados.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_vistaResultados.MultiSelect = false;
            this.dgv_vistaResultados.Name = "dgv_vistaResultados";
            this.dgv_vistaResultados.ReadOnly = true;
            this.dgv_vistaResultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_vistaResultados.RowHeadersVisible = false;
            this.dgv_vistaResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_vistaResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_vistaResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vistaResultados.ShowCellToolTips = false;
            this.dgv_vistaResultados.ShowEditingIcon = false;
            this.dgv_vistaResultados.Size = new System.Drawing.Size(395, 304);
            this.dgv_vistaResultados.TabIndex = 1;
            this.dgv_vistaResultados.DataSourceChanged += new System.EventHandler(this.dgv_vistaResultados_DataSourceChanged);
            this.dgv_vistaResultados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vistaResultados_CellContentDoubleClick);
            // 
            // lbl_moreInfo
            // 
            this.lbl_moreInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_moreInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_moreInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_moreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moreInfo.Location = new System.Drawing.Point(0, 326);
            this.lbl_moreInfo.Name = "lbl_moreInfo";
            this.lbl_moreInfo.Size = new System.Drawing.Size(395, 21);
            this.lbl_moreInfo.TabIndex = 2;
            this.lbl_moreInfo.Text = "Info";
            this.lbl_moreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_moreInfo.Visible = false;
            // 
            // ComboGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.lbl_moreInfo);
            this.Controls.Add(this.dgv_vistaResultados);
            this.Controls.Add(this.tb_cuadroBusqueda);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ComboGrid";
            this.Size = new System.Drawing.Size(395, 347);
            this.Enter += new System.EventHandler(this.ComboGrid_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cuadroBusqueda;
        private System.Windows.Forms.DataGridView dgv_vistaResultados;
        private System.Windows.Forms.Label lbl_moreInfo;
    }
}
