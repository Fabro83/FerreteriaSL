using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FerreteriaSL.Ventas
{
    partial class ComboGrid
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private IContainer components = null;

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
            this.tb_cuadroBusqueda = new TextBox();
            this.dgv_vistaResultados = new DataGridView();
            this.lbl_moreInfo = new Label();
            ((ISupportInitialize)(this.dgv_vistaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cuadroBusqueda
            // 
            this.tb_cuadroBusqueda.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.tb_cuadroBusqueda.Location = new Point(0, 1);
            this.tb_cuadroBusqueda.Margin = new Padding(0);
            this.tb_cuadroBusqueda.Name = "tb_cuadroBusqueda";
            this.tb_cuadroBusqueda.Size = new Size(395, 20);
            this.tb_cuadroBusqueda.TabIndex = 0;
            this.tb_cuadroBusqueda.TextChanged += new EventHandler(this.tb_cuadroBusqueda_TextChanged);
            this.tb_cuadroBusqueda.KeyDown += new KeyEventHandler(this.tb_cuadroBusqueda_KeyDown);
            // 
            // dgv_vistaResultados
            // 
            this.dgv_vistaResultados.AllowUserToAddRows = false;
            this.dgv_vistaResultados.AllowUserToDeleteRows = false;
            this.dgv_vistaResultados.AllowUserToResizeColumns = false;
            this.dgv_vistaResultados.AllowUserToResizeRows = false;
            this.dgv_vistaResultados.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.dgv_vistaResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vistaResultados.BackgroundColor = SystemColors.ActiveCaptionText;
            this.dgv_vistaResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vistaResultados.ColumnHeadersVisible = false;
            this.dgv_vistaResultados.GridColor = SystemColors.ControlDarkDark;
            this.dgv_vistaResultados.Location = new Point(0, 22);
            this.dgv_vistaResultados.Margin = new Padding(0);
            this.dgv_vistaResultados.MultiSelect = false;
            this.dgv_vistaResultados.Name = "dgv_vistaResultados";
            this.dgv_vistaResultados.ReadOnly = true;
            this.dgv_vistaResultados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv_vistaResultados.RowHeadersVisible = false;
            this.dgv_vistaResultados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_vistaResultados.ScrollBars = ScrollBars.Vertical;
            this.dgv_vistaResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vistaResultados.ShowCellToolTips = false;
            this.dgv_vistaResultados.ShowEditingIcon = false;
            this.dgv_vistaResultados.Size = new Size(395, 304);
            this.dgv_vistaResultados.TabIndex = 1;
            this.dgv_vistaResultados.DataSourceChanged += new EventHandler(this.dgv_vistaResultados_DataSourceChanged);
            this.dgv_vistaResultados.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dgv_vistaResultados_CellContentDoubleClick);
            // 
            // lbl_moreInfo
            // 
            this.lbl_moreInfo.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.lbl_moreInfo.BackColor = SystemColors.ActiveCaptionText;
            this.lbl_moreInfo.BorderStyle = BorderStyle.FixedSingle;
            this.lbl_moreInfo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moreInfo.Location = new Point(0, 326);
            this.lbl_moreInfo.Name = "lbl_moreInfo";
            this.lbl_moreInfo.Size = new Size(395, 21);
            this.lbl_moreInfo.TabIndex = 2;
            this.lbl_moreInfo.Text = "Info";
            this.lbl_moreInfo.TextAlign = ContentAlignment.MiddleCenter;
            this.lbl_moreInfo.Visible = false;
            // 
            // ComboGrid
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.DarkSeaGreen;
            this.Controls.Add(this.lbl_moreInfo);
            this.Controls.Add(this.dgv_vistaResultados);
            this.Controls.Add(this.tb_cuadroBusqueda);
            this.Margin = new Padding(0);
            this.Name = "ComboGrid";
            this.Size = new Size(395, 347);
            this.Enter += new EventHandler(this.ComboGrid_Enter);
            ((ISupportInitialize)(this.dgv_vistaResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_cuadroBusqueda;
        private DataGridView dgv_vistaResultados;
        private Label lbl_moreInfo;
    }
}
