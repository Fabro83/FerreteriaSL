using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Productos
{
    partial class AdministrarStock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarStock));
            this.btn_cerrarVentana = new System.Windows.Forms.Button();
            this.tb_listarProductos = new System.Windows.Forms.TabPage();
            this.tlp_productProgressInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pb_productProgress = new System.Windows.Forms.ProgressBar();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_pages = new System.Windows.Forms.Label();
            this.lbl_limitItems = new System.Windows.Forms.Label();
            this.btn_prevPage = new System.Windows.Forms.Button();
            this.cb_itemsPerPage = new System.Windows.Forms.ComboBox();
            this.lbl_filtroMostrar = new System.Windows.Forms.Label();
            this.btn_nextPage = new System.Windows.Forms.Button();
            this.cb_filtroArticulosAMostrar = new System.Windows.Forms.ComboBox();
            this.gb_filtrosFechaModificacion = new System.Windows.Forms.GroupBox();
            this.dtp_filtrosFechaModificacionAntes = new System.Windows.Forms.DateTimePicker();
            this.dtp_filtrosFechaModificacionDespues = new System.Windows.Forms.DateTimePicker();
            this.lbl_filtrosFechaModificacionAntes = new System.Windows.Forms.Label();
            this.lbl_filtrosFechaModificacionDespues = new System.Windows.Forms.Label();
            this.gb_filtrosFechaCreacion = new System.Windows.Forms.GroupBox();
            this.dtp_filtrosFechaCreacionAntes = new System.Windows.Forms.DateTimePicker();
            this.dtp_filtrosFechaCreacionDespues = new System.Windows.Forms.DateTimePicker();
            this.lbl_filtrosFechaCreacionAntes = new System.Windows.Forms.Label();
            this.lbl_filtrosFechaCreacionDespues = new System.Windows.Forms.Label();
            this.gb_filtroStock = new System.Windows.Forms.GroupBox();
            this.nud_stockMenor = new System.Windows.Forms.NumericUpDown();
            this.nud_stockMayor = new System.Windows.Forms.NumericUpDown();
            this.lbl_filtrosStockMenor = new System.Windows.Forms.Label();
            this.lbl_filtrosStockMayor = new System.Windows.Forms.Label();
            this.gb_filtrosPrecioFinal = new System.Windows.Forms.GroupBox();
            this.nud_precioFinalMenor = new System.Windows.Forms.NumericUpDown();
            this.nud_precioFinalMayor = new System.Windows.Forms.NumericUpDown();
            this.lbl_filtrosPreciodeCompraMenor = new System.Windows.Forms.Label();
            this.lbl_filtrosPreciodeCompraMayor = new System.Windows.Forms.Label();
            this.gb_filtrosPrecio = new System.Windows.Forms.GroupBox();
            this.nud_precioMenor = new System.Windows.Forms.NumericUpDown();
            this.nud_precioMayor = new System.Windows.Forms.NumericUpDown();
            this.lbl_filtrosPreciodeVentaMenor = new System.Windows.Forms.Label();
            this.lbl_filtrosPreciodeVentaMayor = new System.Windows.Forms.Label();
            this.gb_filtros = new System.Windows.Forms.GroupBox();
            this.lbl_filtrosProveedor = new System.Windows.Forms.Label();
            this.lbl_filtrosDescipcion = new System.Windows.Forms.Label();
            this.tb_filtroNombre = new System.Windows.Forms.TextBox();
            this.cb_filtroProveedor = new System.Windows.Forms.ComboBox();
            this.dgv_listaProductos = new System.Windows.Forms.DataGridView();
            this.cms_menuProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_filasSeleccionadas = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_menuProductoSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_seleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_marcarOculto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_marcarVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_aplicarPorcentaje = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_sumarPorcentaje = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_aplicarPorcentajeAPrecio = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_locationSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_addToLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_locationName = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_columnsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_chooseColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_deleteSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_agregarProductos = new System.Windows.Forms.TabPage();
            this.lbl_ap_info = new System.Windows.Forms.Label();
            this.nud_ap_porcentajeDeUtilidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_ap_porcentajeDeUtilidad = new System.Windows.Forms.Label();
            this.tb_ap_codigoDeBarras = new System.Windows.Forms.TextBox();
            this.lbl_ap_codigoDeBarras = new System.Windows.Forms.Label();
            this.nud_ap_precio = new System.Windows.Forms.NumericUpDown();
            this.btn_ap_limpiar = new System.Windows.Forms.Button();
            this.cb_ap_proveedor = new System.Windows.Forms.ComboBox();
            this.btn_ap_agregar = new System.Windows.Forms.Button();
            this.nud_ap_stock = new System.Windows.Forms.NumericUpDown();
            this.tb_ap_nombre = new System.Windows.Forms.TextBox();
            this.tb_ap_codigo = new System.Windows.Forms.TextBox();
            this.lbl_ap_precio = new System.Windows.Forms.Label();
            this.lbl_ap_stock = new System.Windows.Forms.Label();
            this.lbl_ap_nombre = new System.Windows.Forms.Label();
            this.lbl_ap_proveedor = new System.Windows.Forms.Label();
            this.lbl_ap_codigo = new System.Windows.Forms.Label();
            this.tc_productos = new System.Windows.Forms.TabControl();
            this.tp_importarProductos = new System.Windows.Forms.TabPage();
            this.cb_includeZeroPriced = new System.Windows.Forms.CheckBox();
            this.cb_updateDescription = new System.Windows.Forms.CheckBox();
            this.lbl_importedFileName = new System.Windows.Forms.Label();
            this.lbl_impArticleCount = new System.Windows.Forms.Label();
            this.lbl_proveedorInfo = new System.Windows.Forms.Label();
            this.lbl_mariconaDePorcentaje = new System.Windows.Forms.Label();
            this.nud_importPercentage = new System.Windows.Forms.NumericUpDown();
            this.lbl_importarPorcentaje = new System.Windows.Forms.Label();
            this.lbl_progresoInfo = new System.Windows.Forms.Label();
            this.btn_cancelarTransferencia = new System.Windows.Forms.Button();
            this.btn_transferir = new System.Windows.Forms.Button();
            this.cb_listaProveedores = new System.Windows.Forms.ComboBox();
            this.btn_seleccionarArchivo = new System.Windows.Forms.Button();
            this.pb_transferProgress = new System.Windows.Forms.ProgressBar();
            this.dgv_listadoExcel = new System.Windows.Forms.DataGridView();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.administrarStockSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_exportar = new System.Windows.Forms.Button();
            this.tb_listarProductos.SuspendLayout();
            this.tlp_productProgressInfo.SuspendLayout();
            this.gb_filtrosFechaModificacion.SuspendLayout();
            this.gb_filtrosFechaCreacion.SuspendLayout();
            this.gb_filtroStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockMayor)).BeginInit();
            this.gb_filtrosPrecioFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precioFinalMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precioFinalMayor)).BeginInit();
            this.gb_filtrosPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precioMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precioMayor)).BeginInit();
            this.gb_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).BeginInit();
            this.cms_menuProductos.SuspendLayout();
            this.tp_agregarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ap_porcentajeDeUtilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ap_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ap_stock)).BeginInit();
            this.tc_productos.SuspendLayout();
            this.tp_importarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_importPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrarStockSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrarVentana
            // 
            this.btn_cerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cerrarVentana.Location = new System.Drawing.Point(12, 447);
            this.btn_cerrarVentana.Name = "btn_cerrarVentana";
            this.btn_cerrarVentana.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrarVentana.TabIndex = 20;
            this.btn_cerrarVentana.Text = "Cerrar";
            this.btn_cerrarVentana.UseVisualStyleBackColor = true;
            this.btn_cerrarVentana.Click += new System.EventHandler(this.btn_cerrarVentana_Click);
            // 
            // tb_listarProductos
            // 
            this.tb_listarProductos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tb_listarProductos.Controls.Add(this.tlp_productProgressInfo);
            this.tb_listarProductos.Controls.Add(this.lbl_pages);
            this.tb_listarProductos.Controls.Add(this.lbl_limitItems);
            this.tb_listarProductos.Controls.Add(this.btn_prevPage);
            this.tb_listarProductos.Controls.Add(this.cb_itemsPerPage);
            this.tb_listarProductos.Controls.Add(this.lbl_filtroMostrar);
            this.tb_listarProductos.Controls.Add(this.btn_nextPage);
            this.tb_listarProductos.Controls.Add(this.cb_filtroArticulosAMostrar);
            this.tb_listarProductos.Controls.Add(this.gb_filtrosFechaModificacion);
            this.tb_listarProductos.Controls.Add(this.gb_filtrosFechaCreacion);
            this.tb_listarProductos.Controls.Add(this.gb_filtroStock);
            this.tb_listarProductos.Controls.Add(this.gb_filtrosPrecioFinal);
            this.tb_listarProductos.Controls.Add(this.gb_filtrosPrecio);
            this.tb_listarProductos.Controls.Add(this.gb_filtros);
            this.tb_listarProductos.Controls.Add(this.dgv_listaProductos);
            this.tb_listarProductos.Location = new System.Drawing.Point(4, 22);
            this.tb_listarProductos.Name = "tb_listarProductos";
            this.tb_listarProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tb_listarProductos.Size = new System.Drawing.Size(1201, 403);
            this.tb_listarProductos.TabIndex = 4;
            this.tb_listarProductos.Text = "Ver/Modificar Productos";
            this.tb_listarProductos.Enter += new System.EventHandler(this.tb_listarProductos_Enter);
            // 
            // tlp_productProgressInfo
            // 
            this.tlp_productProgressInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_productProgressInfo.ColumnCount = 2;
            this.tlp_productProgressInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_productProgressInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_productProgressInfo.Controls.Add(this.pb_productProgress, 1, 0);
            this.tlp_productProgressInfo.Controls.Add(this.lbl_estado, 0, 0);
            this.tlp_productProgressInfo.Location = new System.Drawing.Point(13, 352);
            this.tlp_productProgressInfo.Name = "tlp_productProgressInfo";
            this.tlp_productProgressInfo.RowCount = 1;
            this.tlp_productProgressInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_productProgressInfo.Size = new System.Drawing.Size(533, 23);
            this.tlp_productProgressInfo.TabIndex = 21;
            // 
            // pb_productProgress
            // 
            this.pb_productProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_productProgress.Location = new System.Drawing.Point(100, 3);
            this.pb_productProgress.Name = "pb_productProgress";
            this.pb_productProgress.Size = new System.Drawing.Size(430, 17);
            this.pb_productProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb_productProgress.TabIndex = 21;
            // 
            // lbl_estado
            // 
            this.lbl_estado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(3, 5);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(91, 13);
            this.lbl_estado.TabIndex = 4;
            this.lbl_estado.Text = "Seleccionar Todo";
            // 
            // lbl_pages
            // 
            this.lbl_pages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pages.AutoEllipsis = true;
            this.lbl_pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pages.Location = new System.Drawing.Point(1078, 354);
            this.lbl_pages.Name = "lbl_pages";
            this.lbl_pages.Size = new System.Drawing.Size(85, 21);
            this.lbl_pages.TabIndex = 20;
            this.lbl_pages.Text = "0/0";
            this.lbl_pages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_limitItems
            // 
            this.lbl_limitItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_limitItems.AutoSize = true;
            this.lbl_limitItems.Location = new System.Drawing.Point(835, 357);
            this.lbl_limitItems.Name = "lbl_limitItems";
            this.lbl_limitItems.Size = new System.Drawing.Size(103, 13);
            this.lbl_limitItems.TabIndex = 16;
            this.lbl_limitItems.Text = "Articulos por pagina:";
            // 
            // btn_prevPage
            // 
            this.btn_prevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prevPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_prevPage.BackgroundImage")));
            this.btn_prevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prevPage.CausesValidation = false;
            this.btn_prevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prevPage.FlatAppearance.BorderSize = 0;
            this.btn_prevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prevPage.Location = new System.Drawing.Point(1051, 354);
            this.btn_prevPage.Name = "btn_prevPage";
            this.btn_prevPage.Size = new System.Drawing.Size(21, 21);
            this.btn_prevPage.TabIndex = 19;
            this.btn_prevPage.TabStop = false;
            this.btn_prevPage.UseVisualStyleBackColor = true;
            this.btn_prevPage.Click += new System.EventHandler(this.btn_prevPage_Click);
            // 
            // cb_itemsPerPage
            // 
            this.cb_itemsPerPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_itemsPerPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_itemsPerPage.FormattingEnabled = true;
            this.cb_itemsPerPage.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "500",
            "1000",
            "Todos"});
            this.cb_itemsPerPage.Location = new System.Drawing.Point(938, 353);
            this.cb_itemsPerPage.Name = "cb_itemsPerPage";
            this.cb_itemsPerPage.Size = new System.Drawing.Size(71, 21);
            this.cb_itemsPerPage.TabIndex = 15;
            this.cb_itemsPerPage.TextChanged += new System.EventHandler(this.cb_itemsPerPage_TextChanged);
            // 
            // lbl_filtroMostrar
            // 
            this.lbl_filtroMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_filtroMostrar.AutoSize = true;
            this.lbl_filtroMostrar.Location = new System.Drawing.Point(612, 357);
            this.lbl_filtroMostrar.Name = "lbl_filtroMostrar";
            this.lbl_filtroMostrar.Size = new System.Drawing.Size(87, 13);
            this.lbl_filtroMostrar.TabIndex = 14;
            this.lbl_filtroMostrar.Text = "Mostrar articulos:";
            // 
            // btn_nextPage
            // 
            this.btn_nextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nextPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nextPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nextPage.BackgroundImage")));
            this.btn_nextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nextPage.FlatAppearance.BorderSize = 0;
            this.btn_nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nextPage.Location = new System.Drawing.Point(1169, 354);
            this.btn_nextPage.Name = "btn_nextPage";
            this.btn_nextPage.Size = new System.Drawing.Size(21, 21);
            this.btn_nextPage.TabIndex = 18;
            this.btn_nextPage.UseVisualStyleBackColor = true;
            this.btn_nextPage.Click += new System.EventHandler(this.btn_nextPage_Click);
            // 
            // cb_filtroArticulosAMostrar
            // 
            this.cb_filtroArticulosAMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_filtroArticulosAMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtroArticulosAMostrar.FormattingEnabled = true;
            this.cb_filtroArticulosAMostrar.Items.AddRange(new object[] {
            "Visibles",
            "Ocultos",
            "Ambos"});
            this.cb_filtroArticulosAMostrar.Location = new System.Drawing.Point(706, 353);
            this.cb_filtroArticulosAMostrar.Name = "cb_filtroArticulosAMostrar";
            this.cb_filtroArticulosAMostrar.Size = new System.Drawing.Size(121, 21);
            this.cb_filtroArticulosAMostrar.TabIndex = 13;
            this.cb_filtroArticulosAMostrar.SelectedIndexChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // gb_filtrosFechaModificacion
            // 
            this.gb_filtrosFechaModificacion.Controls.Add(this.dtp_filtrosFechaModificacionAntes);
            this.gb_filtrosFechaModificacion.Controls.Add(this.dtp_filtrosFechaModificacionDespues);
            this.gb_filtrosFechaModificacion.Controls.Add(this.lbl_filtrosFechaModificacionAntes);
            this.gb_filtrosFechaModificacion.Controls.Add(this.lbl_filtrosFechaModificacionDespues);
            this.gb_filtrosFechaModificacion.Location = new System.Drawing.Point(956, 7);
            this.gb_filtrosFechaModificacion.Name = "gb_filtrosFechaModificacion";
            this.gb_filtrosFechaModificacion.Size = new System.Drawing.Size(234, 66);
            this.gb_filtrosFechaModificacion.TabIndex = 11;
            this.gb_filtrosFechaModificacion.TabStop = false;
            this.gb_filtrosFechaModificacion.Text = "Fecha de Ultima Modificacion";
            // 
            // dtp_filtrosFechaModificacionAntes
            // 
            this.dtp_filtrosFechaModificacionAntes.CustomFormat = "dd/MM/yyyy H:mm";
            this.dtp_filtrosFechaModificacionAntes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_filtrosFechaModificacionAntes.Location = new System.Drawing.Point(72, 36);
            this.dtp_filtrosFechaModificacionAntes.Name = "dtp_filtrosFechaModificacionAntes";
            this.dtp_filtrosFechaModificacionAntes.ShowCheckBox = true;
            this.dtp_filtrosFechaModificacionAntes.Size = new System.Drawing.Size(146, 20);
            this.dtp_filtrosFechaModificacionAntes.TabIndex = 4;
            this.dtp_filtrosFechaModificacionAntes.ValueChanged += new System.EventHandler(this.FilterTrigger);
            this.dtp_filtrosFechaModificacionAntes.EnabledChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // dtp_filtrosFechaModificacionDespues
            // 
            this.dtp_filtrosFechaModificacionDespues.CustomFormat = "dd/MM/yyyy H:mm";
            this.dtp_filtrosFechaModificacionDespues.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_filtrosFechaModificacionDespues.Location = new System.Drawing.Point(72, 13);
            this.dtp_filtrosFechaModificacionDespues.Name = "dtp_filtrosFechaModificacionDespues";
            this.dtp_filtrosFechaModificacionDespues.ShowCheckBox = true;
            this.dtp_filtrosFechaModificacionDespues.Size = new System.Drawing.Size(146, 20);
            this.dtp_filtrosFechaModificacionDespues.TabIndex = 2;
            this.dtp_filtrosFechaModificacionDespues.ValueChanged += new System.EventHandler(this.FilterTrigger);
            this.dtp_filtrosFechaModificacionDespues.EnabledChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // lbl_filtrosFechaModificacionAntes
            // 
            this.lbl_filtrosFechaModificacionAntes.AutoSize = true;
            this.lbl_filtrosFechaModificacionAntes.Location = new System.Drawing.Point(20, 40);
            this.lbl_filtrosFechaModificacionAntes.Name = "lbl_filtrosFechaModificacionAntes";
            this.lbl_filtrosFechaModificacionAntes.Size = new System.Drawing.Size(52, 13);
            this.lbl_filtrosFechaModificacionAntes.TabIndex = 1;
            this.lbl_filtrosFechaModificacionAntes.Text = "Antes de:";
            // 
            // lbl_filtrosFechaModificacionDespues
            // 
            this.lbl_filtrosFechaModificacionDespues.AutoSize = true;
            this.lbl_filtrosFechaModificacionDespues.Location = new System.Drawing.Point(5, 17);
            this.lbl_filtrosFechaModificacionDespues.Name = "lbl_filtrosFechaModificacionDespues";
            this.lbl_filtrosFechaModificacionDespues.Size = new System.Drawing.Size(67, 13);
            this.lbl_filtrosFechaModificacionDespues.TabIndex = 0;
            this.lbl_filtrosFechaModificacionDespues.Text = "Después de:";
            // 
            // gb_filtrosFechaCreacion
            // 
            this.gb_filtrosFechaCreacion.Controls.Add(this.dtp_filtrosFechaCreacionAntes);
            this.gb_filtrosFechaCreacion.Controls.Add(this.dtp_filtrosFechaCreacionDespues);
            this.gb_filtrosFechaCreacion.Controls.Add(this.lbl_filtrosFechaCreacionAntes);
            this.gb_filtrosFechaCreacion.Controls.Add(this.lbl_filtrosFechaCreacionDespues);
            this.gb_filtrosFechaCreacion.Location = new System.Drawing.Point(716, 7);
            this.gb_filtrosFechaCreacion.Name = "gb_filtrosFechaCreacion";
            this.gb_filtrosFechaCreacion.Size = new System.Drawing.Size(234, 66);
            this.gb_filtrosFechaCreacion.TabIndex = 10;
            this.gb_filtrosFechaCreacion.TabStop = false;
            this.gb_filtrosFechaCreacion.Text = "Fecha de Creación";
            // 
            // dtp_filtrosFechaCreacionAntes
            // 
            this.dtp_filtrosFechaCreacionAntes.CustomFormat = "dd/MM/yyyy H:mm";
            this.dtp_filtrosFechaCreacionAntes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_filtrosFechaCreacionAntes.Location = new System.Drawing.Point(70, 36);
            this.dtp_filtrosFechaCreacionAntes.Name = "dtp_filtrosFechaCreacionAntes";
            this.dtp_filtrosFechaCreacionAntes.ShowCheckBox = true;
            this.dtp_filtrosFechaCreacionAntes.Size = new System.Drawing.Size(146, 20);
            this.dtp_filtrosFechaCreacionAntes.TabIndex = 4;
            this.dtp_filtrosFechaCreacionAntes.ValueChanged += new System.EventHandler(this.FilterTrigger);
            this.dtp_filtrosFechaCreacionAntes.EnabledChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // dtp_filtrosFechaCreacionDespues
            // 
            this.dtp_filtrosFechaCreacionDespues.CustomFormat = "dd/MM/yyyy H:mm";
            this.dtp_filtrosFechaCreacionDespues.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_filtrosFechaCreacionDespues.Location = new System.Drawing.Point(70, 13);
            this.dtp_filtrosFechaCreacionDespues.Name = "dtp_filtrosFechaCreacionDespues";
            this.dtp_filtrosFechaCreacionDespues.ShowCheckBox = true;
            this.dtp_filtrosFechaCreacionDespues.Size = new System.Drawing.Size(146, 20);
            this.dtp_filtrosFechaCreacionDespues.TabIndex = 2;
            this.dtp_filtrosFechaCreacionDespues.ValueChanged += new System.EventHandler(this.FilterTrigger);
            this.dtp_filtrosFechaCreacionDespues.EnabledChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // lbl_filtrosFechaCreacionAntes
            // 
            this.lbl_filtrosFechaCreacionAntes.AutoSize = true;
            this.lbl_filtrosFechaCreacionAntes.Location = new System.Drawing.Point(19, 40);
            this.lbl_filtrosFechaCreacionAntes.Name = "lbl_filtrosFechaCreacionAntes";
            this.lbl_filtrosFechaCreacionAntes.Size = new System.Drawing.Size(52, 13);
            this.lbl_filtrosFechaCreacionAntes.TabIndex = 1;
            this.lbl_filtrosFechaCreacionAntes.Text = "Antes de:";
            // 
            // lbl_filtrosFechaCreacionDespues
            // 
            this.lbl_filtrosFechaCreacionDespues.AutoSize = true;
            this.lbl_filtrosFechaCreacionDespues.Location = new System.Drawing.Point(5, 17);
            this.lbl_filtrosFechaCreacionDespues.Name = "lbl_filtrosFechaCreacionDespues";
            this.lbl_filtrosFechaCreacionDespues.Size = new System.Drawing.Size(67, 13);
            this.lbl_filtrosFechaCreacionDespues.TabIndex = 0;
            this.lbl_filtrosFechaCreacionDespues.Text = "Después de:";
            // 
            // gb_filtroStock
            // 
            this.gb_filtroStock.Controls.Add(this.nud_stockMenor);
            this.gb_filtroStock.Controls.Add(this.nud_stockMayor);
            this.gb_filtroStock.Controls.Add(this.lbl_filtrosStockMenor);
            this.gb_filtroStock.Controls.Add(this.lbl_filtrosStockMayor);
            this.gb_filtroStock.Location = new System.Drawing.Point(575, 7);
            this.gb_filtroStock.Name = "gb_filtroStock";
            this.gb_filtroStock.Size = new System.Drawing.Size(135, 66);
            this.gb_filtroStock.TabIndex = 9;
            this.gb_filtroStock.TabStop = false;
            this.gb_filtroStock.Text = "Stock";
            // 
            // nud_stockMenor
            // 
            this.nud_stockMenor.Location = new System.Drawing.Point(62, 36);
            this.nud_stockMenor.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_stockMenor.Name = "nud_stockMenor";
            this.nud_stockMenor.Size = new System.Drawing.Size(60, 20);
            this.nud_stockMenor.TabIndex = 3;
            this.nud_stockMenor.ValueChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // nud_stockMayor
            // 
            this.nud_stockMayor.Location = new System.Drawing.Point(62, 13);
            this.nud_stockMayor.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nud_stockMayor.Name = "nud_stockMayor";
            this.nud_stockMayor.Size = new System.Drawing.Size(60, 20);
            this.nud_stockMayor.TabIndex = 2;
            this.nud_stockMayor.ValueChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // lbl_filtrosStockMenor
            // 
            this.lbl_filtrosStockMenor.AutoSize = true;
            this.lbl_filtrosStockMenor.Location = new System.Drawing.Point(7, 40);
            this.lbl_filtrosStockMenor.Name = "lbl_filtrosStockMenor";
            this.lbl_filtrosStockMenor.Size = new System.Drawing.Size(49, 13);
            this.lbl_filtrosStockMenor.TabIndex = 1;
            this.lbl_filtrosStockMenor.Text = "Menor a:";
            // 
            // lbl_filtrosStockMayor
            // 
            this.lbl_filtrosStockMayor.AutoSize = true;
            this.lbl_filtrosStockMayor.Location = new System.Drawing.Point(7, 17);
            this.lbl_filtrosStockMayor.Name = "lbl_filtrosStockMayor";
            this.lbl_filtrosStockMayor.Size = new System.Drawing.Size(48, 13);
            this.lbl_filtrosStockMayor.TabIndex = 0;
            this.lbl_filtrosStockMayor.Text = "Mayor a:";
            // 
            // gb_filtrosPrecioFinal
            // 
            this.gb_filtrosPrecioFinal.Controls.Add(this.nud_precioFinalMenor);
            this.gb_filtrosPrecioFinal.Controls.Add(this.nud_precioFinalMayor);
            this.gb_filtrosPrecioFinal.Controls.Add(this.lbl_filtrosPreciodeCompraMenor);
            this.gb_filtrosPrecioFinal.Controls.Add(this.lbl_filtrosPreciodeCompraMayor);
            this.gb_filtrosPrecioFinal.Location = new System.Drawing.Point(410, 7);
            this.gb_filtrosPrecioFinal.Name = "gb_filtrosPrecioFinal";
            this.gb_filtrosPrecioFinal.Size = new System.Drawing.Size(159, 66);
            this.gb_filtrosPrecioFinal.TabIndex = 8;
            this.gb_filtrosPrecioFinal.TabStop = false;
            this.gb_filtrosPrecioFinal.Text = "Precio Final";
            // 
            // nud_precioFinalMenor
            // 
            this.nud_precioFinalMenor.DecimalPlaces = 2;
            this.nud_precioFinalMenor.Location = new System.Drawing.Point(62, 36);
            this.nud_precioFinalMenor.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_precioFinalMenor.Name = "nud_precioFinalMenor";
            this.nud_precioFinalMenor.Size = new System.Drawing.Size(85, 20);
            this.nud_precioFinalMenor.TabIndex = 3;
            this.nud_precioFinalMenor.ValueChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // nud_precioFinalMayor
            // 
            this.nud_precioFinalMayor.DecimalPlaces = 2;
            this.nud_precioFinalMayor.Location = new System.Drawing.Point(62, 13);
            this.nud_precioFinalMayor.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nud_precioFinalMayor.Name = "nud_precioFinalMayor";
            this.nud_precioFinalMayor.Size = new System.Drawing.Size(85, 20);
            this.nud_precioFinalMayor.TabIndex = 2;
            this.nud_precioFinalMayor.ValueChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // lbl_filtrosPreciodeCompraMenor
            // 
            this.lbl_filtrosPreciodeCompraMenor.AutoSize = true;
            this.lbl_filtrosPreciodeCompraMenor.Location = new System.Drawing.Point(7, 40);
            this.lbl_filtrosPreciodeCompraMenor.Name = "lbl_filtrosPreciodeCompraMenor";
            this.lbl_filtrosPreciodeCompraMenor.Size = new System.Drawing.Size(49, 13);
            this.lbl_filtrosPreciodeCompraMenor.TabIndex = 1;
            this.lbl_filtrosPreciodeCompraMenor.Text = "Menor a:";
            // 
            // lbl_filtrosPreciodeCompraMayor
            // 
            this.lbl_filtrosPreciodeCompraMayor.AutoSize = true;
            this.lbl_filtrosPreciodeCompraMayor.Location = new System.Drawing.Point(7, 17);
            this.lbl_filtrosPreciodeCompraMayor.Name = "lbl_filtrosPreciodeCompraMayor";
            this.lbl_filtrosPreciodeCompraMayor.Size = new System.Drawing.Size(48, 13);
            this.lbl_filtrosPreciodeCompraMayor.TabIndex = 0;
            this.lbl_filtrosPreciodeCompraMayor.Text = "Mayor a:";
            // 
            // gb_filtrosPrecio
            // 
            this.gb_filtrosPrecio.Controls.Add(this.nud_precioMenor);
            this.gb_filtrosPrecio.Controls.Add(this.nud_precioMayor);
            this.gb_filtrosPrecio.Controls.Add(this.lbl_filtrosPreciodeVentaMenor);
            this.gb_filtrosPrecio.Controls.Add(this.lbl_filtrosPreciodeVentaMayor);
            this.gb_filtrosPrecio.Location = new System.Drawing.Point(245, 7);
            this.gb_filtrosPrecio.Name = "gb_filtrosPrecio";
            this.gb_filtrosPrecio.Size = new System.Drawing.Size(159, 66);
            this.gb_filtrosPrecio.TabIndex = 7;
            this.gb_filtrosPrecio.TabStop = false;
            this.gb_filtrosPrecio.Text = "Precio";
            // 
            // nud_precioMenor
            // 
            this.nud_precioMenor.DecimalPlaces = 2;
            this.nud_precioMenor.Location = new System.Drawing.Point(62, 36);
            this.nud_precioMenor.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_precioMenor.Name = "nud_precioMenor";
            this.nud_precioMenor.Size = new System.Drawing.Size(85, 20);
            this.nud_precioMenor.TabIndex = 3;
            this.nud_precioMenor.ValueChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // nud_precioMayor
            // 
            this.nud_precioMayor.DecimalPlaces = 2;
            this.nud_precioMayor.Location = new System.Drawing.Point(62, 13);
            this.nud_precioMayor.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nud_precioMayor.Name = "nud_precioMayor";
            this.nud_precioMayor.Size = new System.Drawing.Size(85, 20);
            this.nud_precioMayor.TabIndex = 2;
            this.nud_precioMayor.ValueChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // lbl_filtrosPreciodeVentaMenor
            // 
            this.lbl_filtrosPreciodeVentaMenor.AutoSize = true;
            this.lbl_filtrosPreciodeVentaMenor.Location = new System.Drawing.Point(7, 40);
            this.lbl_filtrosPreciodeVentaMenor.Name = "lbl_filtrosPreciodeVentaMenor";
            this.lbl_filtrosPreciodeVentaMenor.Size = new System.Drawing.Size(49, 13);
            this.lbl_filtrosPreciodeVentaMenor.TabIndex = 1;
            this.lbl_filtrosPreciodeVentaMenor.Text = "Menor a:";
            // 
            // lbl_filtrosPreciodeVentaMayor
            // 
            this.lbl_filtrosPreciodeVentaMayor.AutoSize = true;
            this.lbl_filtrosPreciodeVentaMayor.Location = new System.Drawing.Point(7, 17);
            this.lbl_filtrosPreciodeVentaMayor.Name = "lbl_filtrosPreciodeVentaMayor";
            this.lbl_filtrosPreciodeVentaMayor.Size = new System.Drawing.Size(48, 13);
            this.lbl_filtrosPreciodeVentaMayor.TabIndex = 0;
            this.lbl_filtrosPreciodeVentaMayor.Text = "Mayor a:";
            // 
            // gb_filtros
            // 
            this.gb_filtros.Controls.Add(this.lbl_filtrosProveedor);
            this.gb_filtros.Controls.Add(this.lbl_filtrosDescipcion);
            this.gb_filtros.Controls.Add(this.tb_filtroNombre);
            this.gb_filtros.Controls.Add(this.cb_filtroProveedor);
            this.gb_filtros.Location = new System.Drawing.Point(13, 7);
            this.gb_filtros.Name = "gb_filtros";
            this.gb_filtros.Size = new System.Drawing.Size(226, 66);
            this.gb_filtros.TabIndex = 6;
            this.gb_filtros.TabStop = false;
            this.gb_filtros.Text = "Filtros";
            // 
            // lbl_filtrosProveedor
            // 
            this.lbl_filtrosProveedor.AutoSize = true;
            this.lbl_filtrosProveedor.Location = new System.Drawing.Point(14, 40);
            this.lbl_filtrosProveedor.Name = "lbl_filtrosProveedor";
            this.lbl_filtrosProveedor.Size = new System.Drawing.Size(59, 13);
            this.lbl_filtrosProveedor.TabIndex = 7;
            this.lbl_filtrosProveedor.Text = "Proveedor:";
            // 
            // lbl_filtrosDescipcion
            // 
            this.lbl_filtrosDescipcion.AutoSize = true;
            this.lbl_filtrosDescipcion.Location = new System.Drawing.Point(7, 18);
            this.lbl_filtrosDescipcion.Name = "lbl_filtrosDescipcion";
            this.lbl_filtrosDescipcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_filtrosDescipcion.TabIndex = 6;
            this.lbl_filtrosDescipcion.Text = "Descripción:";
            // 
            // tb_filtroNombre
            // 
            this.tb_filtroNombre.Location = new System.Drawing.Point(75, 14);
            this.tb_filtroNombre.Name = "tb_filtroNombre";
            this.tb_filtroNombre.Size = new System.Drawing.Size(139, 20);
            this.tb_filtroNombre.TabIndex = 3;
            this.tb_filtroNombre.TextChanged += new System.EventHandler(this.FilterTrigger);
            this.tb_filtroNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_filtroNombre_KeyDown);
            // 
            // cb_filtroProveedor
            // 
            this.cb_filtroProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtroProveedor.FormattingEnabled = true;
            this.cb_filtroProveedor.Location = new System.Drawing.Point(75, 36);
            this.cb_filtroProveedor.Name = "cb_filtroProveedor";
            this.cb_filtroProveedor.Size = new System.Drawing.Size(139, 21);
            this.cb_filtroProveedor.TabIndex = 5;
            this.cb_filtroProveedor.SelectedIndexChanged += new System.EventHandler(this.FilterTrigger);
            // 
            // dgv_listaProductos
            // 
            this.dgv_listaProductos.AllowUserToAddRows = false;
            this.dgv_listaProductos.AllowUserToDeleteRows = false;
            this.dgv_listaProductos.AllowUserToOrderColumns = true;
            this.dgv_listaProductos.AllowUserToResizeRows = false;
            this.dgv_listaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_listaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaProductos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_listaProductos.Location = new System.Drawing.Point(13, 85);
            this.dgv_listaProductos.Margin = new System.Windows.Forms.Padding(25);
            this.dgv_listaProductos.Name = "dgv_listaProductos";
            this.dgv_listaProductos.RowHeadersVisible = false;
            this.dgv_listaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listaProductos.Size = new System.Drawing.Size(1177, 256);
            this.dgv_listaProductos.TabIndex = 0;
            this.dgv_listaProductos.DataSourceChanged += new System.EventHandler(this.dgv_listaProductos_DataSourceChanged);
            this.dgv_listaProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_listaProductos_CellFormatting);
            this.dgv_listaProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_listaProductos_CellMouseClick);
            this.dgv_listaProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaProductos_CellValueChanged);
            this.dgv_listaProductos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_listaProductos_DataError);
            this.dgv_listaProductos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_listaProductos_EditingControlShowing);
            this.dgv_listaProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_listaProductos_KeyDown);
            // 
            // cms_menuProductos
            // 
            this.cms_menuProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_filasSeleccionadas,
            this.tss_menuProductoSeparador,
            this.tsmi_seleccionarTodo,
            this.tsmi_mostrar,
            this.tsmi_aplicarPorcentaje,
            this.tsmi_sumarPorcentaje,
            this.tsmi_aplicarPorcentajeAPrecio,
            this.tss_locationSeparator,
            this.tsmi_addToLocation,
            this.tsmi_locationName,
            this.tss_columnsSeparator,
            this.tsmi_chooseColumns,
            this.tss_deleteSeparator,
            this.tsmi_eliminar});
            this.cms_menuProductos.Name = "cms_menuProductos";
            this.cms_menuProductos.ShowImageMargin = false;
            this.cms_menuProductos.Size = new System.Drawing.Size(200, 248);
            this.cms_menuProductos.Text = "Hola";
            this.cms_menuProductos.Opening += new System.ComponentModel.CancelEventHandler(this.cms_menuProductos_Opening);
            // 
            // tsmi_filasSeleccionadas
            // 
            this.tsmi_filasSeleccionadas.Enabled = false;
            this.tsmi_filasSeleccionadas.Name = "tsmi_filasSeleccionadas";
            this.tsmi_filasSeleccionadas.Size = new System.Drawing.Size(199, 22);
            this.tsmi_filasSeleccionadas.Text = "X fila/s seleccionada/s";
            // 
            // tss_menuProductoSeparador
            // 
            this.tss_menuProductoSeparador.Name = "tss_menuProductoSeparador";
            this.tss_menuProductoSeparador.Size = new System.Drawing.Size(196, 6);
            // 
            // tsmi_seleccionarTodo
            // 
            this.tsmi_seleccionarTodo.Name = "tsmi_seleccionarTodo";
            this.tsmi_seleccionarTodo.Size = new System.Drawing.Size(199, 22);
            this.tsmi_seleccionarTodo.Text = "Seleccionar Todo";
            this.tsmi_seleccionarTodo.Click += new System.EventHandler(this.tsmi_seleccionarTodo_Click);
            // 
            // tsmi_mostrar
            // 
            this.tsmi_mostrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmi_mostrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_marcarOculto,
            this.tsmi_marcarVisible});
            this.tsmi_mostrar.Name = "tsmi_mostrar";
            this.tsmi_mostrar.Size = new System.Drawing.Size(199, 22);
            this.tsmi_mostrar.Text = "Marcar como";
            // 
            // tsmi_marcarOculto
            // 
            this.tsmi_marcarOculto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmi_marcarOculto.Name = "tsmi_marcarOculto";
            this.tsmi_marcarOculto.Size = new System.Drawing.Size(155, 22);
            this.tsmi_marcarOculto.Text = "Articulo Oculto";
            this.tsmi_marcarOculto.Click += new System.EventHandler(this.tsmi_marcar_Click);
            // 
            // tsmi_marcarVisible
            // 
            this.tsmi_marcarVisible.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmi_marcarVisible.Name = "tsmi_marcarVisible";
            this.tsmi_marcarVisible.Size = new System.Drawing.Size(155, 22);
            this.tsmi_marcarVisible.Text = "Articulo Visible";
            this.tsmi_marcarVisible.Click += new System.EventHandler(this.tsmi_marcar_Click);
            // 
            // tsmi_aplicarPorcentaje
            // 
            this.tsmi_aplicarPorcentaje.Name = "tsmi_aplicarPorcentaje";
            this.tsmi_aplicarPorcentaje.Size = new System.Drawing.Size(199, 22);
            this.tsmi_aplicarPorcentaje.Text = "Aplicar Porcentaje...";
            this.tsmi_aplicarPorcentaje.Click += new System.EventHandler(this.tsmi_Porcentaje_Click);
            // 
            // tsmi_sumarPorcentaje
            // 
            this.tsmi_sumarPorcentaje.Name = "tsmi_sumarPorcentaje";
            this.tsmi_sumarPorcentaje.Size = new System.Drawing.Size(199, 22);
            this.tsmi_sumarPorcentaje.Text = "Sumar Porcentaje...";
            this.tsmi_sumarPorcentaje.Click += new System.EventHandler(this.tsmi_Porcentaje_Click);
            // 
            // tsmi_aplicarPorcentajeAPrecio
            // 
            this.tsmi_aplicarPorcentajeAPrecio.Name = "tsmi_aplicarPorcentajeAPrecio";
            this.tsmi_aplicarPorcentajeAPrecio.Size = new System.Drawing.Size(199, 22);
            this.tsmi_aplicarPorcentajeAPrecio.Text = "Aplicar Porcentaje a Precio...";
            this.tsmi_aplicarPorcentajeAPrecio.Click += new System.EventHandler(this.tsmi_Porcentaje_Click);
            // 
            // tss_locationSeparator
            // 
            this.tss_locationSeparator.Name = "tss_locationSeparator";
            this.tss_locationSeparator.Size = new System.Drawing.Size(196, 6);
            this.tss_locationSeparator.Visible = false;
            // 
            // tsmi_addToLocation
            // 
            this.tsmi_addToLocation.Name = "tsmi_addToLocation";
            this.tsmi_addToLocation.Size = new System.Drawing.Size(199, 22);
            this.tsmi_addToLocation.Text = "Agregar a Ubicación";
            this.tsmi_addToLocation.Visible = false;
            this.tsmi_addToLocation.Click += new System.EventHandler(this.tsmi_addToLocation_Click);
            // 
            // tsmi_locationName
            // 
            this.tsmi_locationName.Enabled = false;
            this.tsmi_locationName.Name = "tsmi_locationName";
            this.tsmi_locationName.Size = new System.Drawing.Size(199, 22);
            this.tsmi_locationName.Text = "\\\\UBICACION";
            this.tsmi_locationName.Visible = false;
            // 
            // tss_columnsSeparator
            // 
            this.tss_columnsSeparator.Name = "tss_columnsSeparator";
            this.tss_columnsSeparator.Size = new System.Drawing.Size(196, 6);
            // 
            // tsmi_chooseColumns
            // 
            this.tsmi_chooseColumns.Name = "tsmi_chooseColumns";
            this.tsmi_chooseColumns.Size = new System.Drawing.Size(199, 22);
            this.tsmi_chooseColumns.Text = "Elegir Columnas...";
            this.tsmi_chooseColumns.Click += new System.EventHandler(this.tsmi_chooseColumns_Click);
            // 
            // tss_deleteSeparator
            // 
            this.tss_deleteSeparator.Name = "tss_deleteSeparator";
            this.tss_deleteSeparator.Size = new System.Drawing.Size(196, 6);
            // 
            // tsmi_eliminar
            // 
            this.tsmi_eliminar.Name = "tsmi_eliminar";
            this.tsmi_eliminar.Size = new System.Drawing.Size(199, 22);
            this.tsmi_eliminar.Text = "Eliminar Selección";
            this.tsmi_eliminar.Click += new System.EventHandler(this.tsmi_eliminar_Click);
            // 
            // tp_agregarProductos
            // 
            this.tp_agregarProductos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tp_agregarProductos.Controls.Add(this.lbl_ap_info);
            this.tp_agregarProductos.Controls.Add(this.nud_ap_porcentajeDeUtilidad);
            this.tp_agregarProductos.Controls.Add(this.lbl_ap_porcentajeDeUtilidad);
            this.tp_agregarProductos.Controls.Add(this.tb_ap_codigoDeBarras);
            this.tp_agregarProductos.Controls.Add(this.lbl_ap_codigoDeBarras);
            this.tp_agregarProductos.Controls.Add(this.nud_ap_precio);
            this.tp_agregarProductos.Controls.Add(this.btn_ap_limpiar);
            this.tp_agregarProductos.Controls.Add(this.cb_ap_proveedor);
            this.tp_agregarProductos.Controls.Add(this.btn_ap_agregar);
            this.tp_agregarProductos.Controls.Add(this.nud_ap_stock);
            this.tp_agregarProductos.Controls.Add(this.tb_ap_nombre);
            this.tp_agregarProductos.Controls.Add(this.tb_ap_codigo);
            this.tp_agregarProductos.Controls.Add(this.lbl_ap_precio);
            this.tp_agregarProductos.Controls.Add(this.lbl_ap_stock);
            this.tp_agregarProductos.Controls.Add(this.lbl_ap_nombre);
            this.tp_agregarProductos.Controls.Add(this.lbl_ap_proveedor);
            this.tp_agregarProductos.Controls.Add(this.lbl_ap_codigo);
            this.tp_agregarProductos.Location = new System.Drawing.Point(4, 22);
            this.tp_agregarProductos.Name = "tp_agregarProductos";
            this.tp_agregarProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_agregarProductos.Size = new System.Drawing.Size(1201, 403);
            this.tp_agregarProductos.TabIndex = 2;
            this.tp_agregarProductos.Text = "Agregar Producto";
            this.tp_agregarProductos.Enter += new System.EventHandler(this.tp_agregarProductos_Enter);
            // 
            // lbl_ap_info
            // 
            this.lbl_ap_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap_info.Location = new System.Drawing.Point(13, 247);
            this.lbl_ap_info.Name = "lbl_ap_info";
            this.lbl_ap_info.Size = new System.Drawing.Size(509, 18);
            this.lbl_ap_info.TabIndex = 13;
            this.lbl_ap_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_ap_porcentajeDeUtilidad
            // 
            this.nud_ap_porcentajeDeUtilidad.DecimalPlaces = 2;
            this.nud_ap_porcentajeDeUtilidad.Location = new System.Drawing.Point(189, 218);
            this.nud_ap_porcentajeDeUtilidad.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_ap_porcentajeDeUtilidad.Name = "nud_ap_porcentajeDeUtilidad";
            this.nud_ap_porcentajeDeUtilidad.Size = new System.Drawing.Size(80, 20);
            this.nud_ap_porcentajeDeUtilidad.TabIndex = 6;
            // 
            // lbl_ap_porcentajeDeUtilidad
            // 
            this.lbl_ap_porcentajeDeUtilidad.AutoSize = true;
            this.lbl_ap_porcentajeDeUtilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap_porcentajeDeUtilidad.Location = new System.Drawing.Point(9, 218);
            this.lbl_ap_porcentajeDeUtilidad.Name = "lbl_ap_porcentajeDeUtilidad";
            this.lbl_ap_porcentajeDeUtilidad.Size = new System.Drawing.Size(168, 20);
            this.lbl_ap_porcentajeDeUtilidad.TabIndex = 11;
            this.lbl_ap_porcentajeDeUtilidad.Text = "Porcentaje de Utilidad:";
            // 
            // tb_ap_codigoDeBarras
            // 
            this.tb_ap_codigoDeBarras.Location = new System.Drawing.Point(189, 53);
            this.tb_ap_codigoDeBarras.Name = "tb_ap_codigoDeBarras";
            this.tb_ap_codigoDeBarras.Size = new System.Drawing.Size(223, 20);
            this.tb_ap_codigoDeBarras.TabIndex = 1;
            // 
            // lbl_ap_codigoDeBarras
            // 
            this.lbl_ap_codigoDeBarras.AutoSize = true;
            this.lbl_ap_codigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap_codigoDeBarras.Location = new System.Drawing.Point(47, 53);
            this.lbl_ap_codigoDeBarras.Name = "lbl_ap_codigoDeBarras";
            this.lbl_ap_codigoDeBarras.Size = new System.Drawing.Size(136, 20);
            this.lbl_ap_codigoDeBarras.TabIndex = 9;
            this.lbl_ap_codigoDeBarras.Text = "Codigo de Barras:";
            // 
            // nud_ap_precio
            // 
            this.nud_ap_precio.DecimalPlaces = 2;
            this.nud_ap_precio.Location = new System.Drawing.Point(189, 185);
            this.nud_ap_precio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_ap_precio.Name = "nud_ap_precio";
            this.nud_ap_precio.Size = new System.Drawing.Size(80, 20);
            this.nud_ap_precio.TabIndex = 5;
            this.nud_ap_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_ap_precio_KeyPress);
            // 
            // btn_ap_limpiar
            // 
            this.btn_ap_limpiar.Location = new System.Drawing.Point(256, 273);
            this.btn_ap_limpiar.Name = "btn_ap_limpiar";
            this.btn_ap_limpiar.Size = new System.Drawing.Size(100, 23);
            this.btn_ap_limpiar.TabIndex = 8;
            this.btn_ap_limpiar.Text = "Limpiar Campos";
            this.btn_ap_limpiar.UseVisualStyleBackColor = true;
            this.btn_ap_limpiar.Click += new System.EventHandler(this.btn_ap_limpiar_Click);
            // 
            // cb_ap_proveedor
            // 
            this.cb_ap_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_ap_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_ap_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ap_proveedor.FormattingEnabled = true;
            this.cb_ap_proveedor.Location = new System.Drawing.Point(189, 86);
            this.cb_ap_proveedor.Name = "cb_ap_proveedor";
            this.cb_ap_proveedor.Size = new System.Drawing.Size(223, 21);
            this.cb_ap_proveedor.TabIndex = 2;
            this.cb_ap_proveedor.SelectedIndexChanged += new System.EventHandler(this.cb_ap_proveedor_SelectedIndexChanged);
            this.cb_ap_proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agregarProducto_KeyPress);
            this.cb_ap_proveedor.Leave += new System.EventHandler(this.cb_ap_proveedor_Leave);
            // 
            // btn_ap_agregar
            // 
            this.btn_ap_agregar.Enabled = false;
            this.btn_ap_agregar.Location = new System.Drawing.Point(144, 273);
            this.btn_ap_agregar.Name = "btn_ap_agregar";
            this.btn_ap_agregar.Size = new System.Drawing.Size(100, 23);
            this.btn_ap_agregar.TabIndex = 7;
            this.btn_ap_agregar.Text = "Agregar";
            this.btn_ap_agregar.UseVisualStyleBackColor = true;
            this.btn_ap_agregar.Click += new System.EventHandler(this.btn_ap_agregar_Click);
            // 
            // nud_ap_stock
            // 
            this.nud_ap_stock.Location = new System.Drawing.Point(189, 152);
            this.nud_ap_stock.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_ap_stock.Name = "nud_ap_stock";
            this.nud_ap_stock.Size = new System.Drawing.Size(80, 20);
            this.nud_ap_stock.TabIndex = 4;
            this.nud_ap_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agregarProducto_KeyPress);
            // 
            // tb_ap_nombre
            // 
            this.tb_ap_nombre.Location = new System.Drawing.Point(189, 119);
            this.tb_ap_nombre.Name = "tb_ap_nombre";
            this.tb_ap_nombre.Size = new System.Drawing.Size(333, 20);
            this.tb_ap_nombre.TabIndex = 3;
            this.tb_ap_nombre.TextChanged += new System.EventHandler(this.tb_ap_nombre_TextChanged);
            this.tb_ap_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agregarProducto_KeyPress);
            // 
            // tb_ap_codigo
            // 
            this.tb_ap_codigo.Location = new System.Drawing.Point(189, 20);
            this.tb_ap_codigo.Name = "tb_ap_codigo";
            this.tb_ap_codigo.Size = new System.Drawing.Size(223, 20);
            this.tb_ap_codigo.TabIndex = 0;
            this.tb_ap_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agregarProducto_KeyPress);
            this.tb_ap_codigo.Leave += new System.EventHandler(this.tb_ap_codigo_Leave);
            // 
            // lbl_ap_precio
            // 
            this.lbl_ap_precio.AutoSize = true;
            this.lbl_ap_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap_precio.Location = new System.Drawing.Point(126, 185);
            this.lbl_ap_precio.Name = "lbl_ap_precio";
            this.lbl_ap_precio.Size = new System.Drawing.Size(57, 20);
            this.lbl_ap_precio.TabIndex = 7;
            this.lbl_ap_precio.Text = "Precio:";
            // 
            // lbl_ap_stock
            // 
            this.lbl_ap_stock.AutoSize = true;
            this.lbl_ap_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap_stock.Location = new System.Drawing.Point(129, 152);
            this.lbl_ap_stock.Name = "lbl_ap_stock";
            this.lbl_ap_stock.Size = new System.Drawing.Size(54, 20);
            this.lbl_ap_stock.TabIndex = 4;
            this.lbl_ap_stock.Text = "Stock:";
            // 
            // lbl_ap_nombre
            // 
            this.lbl_ap_nombre.AutoSize = true;
            this.lbl_ap_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap_nombre.Location = new System.Drawing.Point(19, 119);
            this.lbl_ap_nombre.Name = "lbl_ap_nombre";
            this.lbl_ap_nombre.Size = new System.Drawing.Size(164, 20);
            this.lbl_ap_nombre.TabIndex = 3;
            this.lbl_ap_nombre.Text = "Nombre / Descripción:";
            // 
            // lbl_ap_proveedor
            // 
            this.lbl_ap_proveedor.AutoSize = true;
            this.lbl_ap_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap_proveedor.Location = new System.Drawing.Point(98, 86);
            this.lbl_ap_proveedor.Name = "lbl_ap_proveedor";
            this.lbl_ap_proveedor.Size = new System.Drawing.Size(85, 20);
            this.lbl_ap_proveedor.TabIndex = 1;
            this.lbl_ap_proveedor.Text = "Proveedor:";
            // 
            // lbl_ap_codigo
            // 
            this.lbl_ap_codigo.AutoSize = true;
            this.lbl_ap_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap_codigo.Location = new System.Drawing.Point(120, 20);
            this.lbl_ap_codigo.Name = "lbl_ap_codigo";
            this.lbl_ap_codigo.Size = new System.Drawing.Size(63, 20);
            this.lbl_ap_codigo.TabIndex = 0;
            this.lbl_ap_codigo.Text = "Codigo:";
            // 
            // tc_productos
            // 
            this.tc_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_productos.Controls.Add(this.tp_agregarProductos);
            this.tc_productos.Controls.Add(this.tb_listarProductos);
            this.tc_productos.Controls.Add(this.tp_importarProductos);
            this.tc_productos.Location = new System.Drawing.Point(12, 12);
            this.tc_productos.Name = "tc_productos";
            this.tc_productos.SelectedIndex = 0;
            this.tc_productos.Size = new System.Drawing.Size(1209, 429);
            this.tc_productos.TabIndex = 0;
            // 
            // tp_importarProductos
            // 
            this.tp_importarProductos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tp_importarProductos.Controls.Add(this.cb_includeZeroPriced);
            this.tp_importarProductos.Controls.Add(this.cb_updateDescription);
            this.tp_importarProductos.Controls.Add(this.lbl_importedFileName);
            this.tp_importarProductos.Controls.Add(this.lbl_impArticleCount);
            this.tp_importarProductos.Controls.Add(this.lbl_proveedorInfo);
            this.tp_importarProductos.Controls.Add(this.lbl_mariconaDePorcentaje);
            this.tp_importarProductos.Controls.Add(this.nud_importPercentage);
            this.tp_importarProductos.Controls.Add(this.lbl_importarPorcentaje);
            this.tp_importarProductos.Controls.Add(this.lbl_progresoInfo);
            this.tp_importarProductos.Controls.Add(this.btn_cancelarTransferencia);
            this.tp_importarProductos.Controls.Add(this.btn_transferir);
            this.tp_importarProductos.Controls.Add(this.cb_listaProveedores);
            this.tp_importarProductos.Controls.Add(this.btn_seleccionarArchivo);
            this.tp_importarProductos.Controls.Add(this.pb_transferProgress);
            this.tp_importarProductos.Controls.Add(this.dgv_listadoExcel);
            this.tp_importarProductos.Location = new System.Drawing.Point(4, 22);
            this.tp_importarProductos.Name = "tp_importarProductos";
            this.tp_importarProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_importarProductos.Size = new System.Drawing.Size(1201, 403);
            this.tp_importarProductos.TabIndex = 5;
            this.tp_importarProductos.Text = "Importar desde Excel";
            this.tp_importarProductos.Enter += new System.EventHandler(this.tp_importarProductos_Enter);
            // 
            // cb_includeZeroPriced
            // 
            this.cb_includeZeroPriced.AutoSize = true;
            this.cb_includeZeroPriced.Location = new System.Drawing.Point(582, 338);
            this.cb_includeZeroPriced.Name = "cb_includeZeroPriced";
            this.cb_includeZeroPriced.Size = new System.Drawing.Size(255, 17);
            this.cb_includeZeroPriced.TabIndex = 17;
            this.cb_includeZeroPriced.Text = "Incluir articulos sin precio. (marcados en amarillo)";
            this.cb_includeZeroPriced.UseVisualStyleBackColor = true;
            // 
            // cb_updateDescription
            // 
            this.cb_updateDescription.AutoSize = true;
            this.cb_updateDescription.Location = new System.Drawing.Point(326, 338);
            this.cb_updateDescription.Name = "cb_updateDescription";
            this.cb_updateDescription.Size = new System.Drawing.Size(250, 17);
            this.cb_updateDescription.TabIndex = 16;
            this.cb_updateDescription.Text = "Actualizar descripciones de articulos existentes.";
            this.cb_updateDescription.UseVisualStyleBackColor = true;
            // 
            // lbl_importedFileName
            // 
            this.lbl_importedFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importedFileName.Location = new System.Drawing.Point(152, 7);
            this.lbl_importedFileName.Name = "lbl_importedFileName";
            this.lbl_importedFileName.Size = new System.Drawing.Size(536, 23);
            this.lbl_importedFileName.TabIndex = 15;
            this.lbl_importedFileName.Text = "Ningun archivo importado.";
            this.lbl_importedFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_impArticleCount
            // 
            this.lbl_impArticleCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_impArticleCount.AutoSize = true;
            this.lbl_impArticleCount.Location = new System.Drawing.Point(7, 370);
            this.lbl_impArticleCount.Name = "lbl_impArticleCount";
            this.lbl_impArticleCount.Size = new System.Drawing.Size(135, 13);
            this.lbl_impArticleCount.TabIndex = 14;
            this.lbl_impArticleCount.Text = "No hay articulos a importar.";
            // 
            // lbl_proveedorInfo
            // 
            this.lbl_proveedorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_proveedorInfo.AutoSize = true;
            this.lbl_proveedorInfo.Location = new System.Drawing.Point(687, 11);
            this.lbl_proveedorInfo.Name = "lbl_proveedorInfo";
            this.lbl_proveedorInfo.Size = new System.Drawing.Size(59, 13);
            this.lbl_proveedorInfo.TabIndex = 13;
            this.lbl_proveedorInfo.Text = "Proveedor:";
            // 
            // lbl_mariconaDePorcentaje
            // 
            this.lbl_mariconaDePorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mariconaDePorcentaje.AutoSize = true;
            this.lbl_mariconaDePorcentaje.Location = new System.Drawing.Point(1134, 12);
            this.lbl_mariconaDePorcentaje.Name = "lbl_mariconaDePorcentaje";
            this.lbl_mariconaDePorcentaje.Size = new System.Drawing.Size(15, 13);
            this.lbl_mariconaDePorcentaje.TabIndex = 12;
            this.lbl_mariconaDePorcentaje.Text = "%";
            // 
            // nud_importPercentage
            // 
            this.nud_importPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_importPercentage.DecimalPlaces = 2;
            this.nud_importPercentage.Location = new System.Drawing.Point(1040, 8);
            this.nud_importPercentage.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_importPercentage.Name = "nud_importPercentage";
            this.nud_importPercentage.Size = new System.Drawing.Size(91, 20);
            this.nud_importPercentage.TabIndex = 11;
            this.nud_importPercentage.ValueChanged += new System.EventHandler(this.nud_importPercentage_ValueChanged);
            this.nud_importPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_importPercentage_KeyPress);
            // 
            // lbl_importarPorcentaje
            // 
            this.lbl_importarPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_importarPorcentaje.AutoSize = true;
            this.lbl_importarPorcentaje.Location = new System.Drawing.Point(933, 12);
            this.lbl_importarPorcentaje.Name = "lbl_importarPorcentaje";
            this.lbl_importarPorcentaje.Size = new System.Drawing.Size(104, 13);
            this.lbl_importarPorcentaje.TabIndex = 10;
            this.lbl_importarPorcentaje.Text = "Porcentaje a aplicar:";
            // 
            // lbl_progresoInfo
            // 
            this.lbl_progresoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_progresoInfo.Location = new System.Drawing.Point(196, 375);
            this.lbl_progresoInfo.Name = "lbl_progresoInfo";
            this.lbl_progresoInfo.Size = new System.Drawing.Size(635, 13);
            this.lbl_progresoInfo.TabIndex = 9;
            this.lbl_progresoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancelarTransferencia
            // 
            this.btn_cancelarTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelarTransferencia.Enabled = false;
            this.btn_cancelarTransferencia.Location = new System.Drawing.Point(839, 365);
            this.btn_cancelarTransferencia.Name = "btn_cancelarTransferencia";
            this.btn_cancelarTransferencia.Size = new System.Drawing.Size(136, 23);
            this.btn_cancelarTransferencia.TabIndex = 4;
            this.btn_cancelarTransferencia.Text = "Cancelar Transferencia";
            this.btn_cancelarTransferencia.UseVisualStyleBackColor = true;
            this.btn_cancelarTransferencia.Click += new System.EventHandler(this.btn_cancelarTransferencia_Click);
            // 
            // btn_transferir
            // 
            this.btn_transferir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_transferir.Enabled = false;
            this.btn_transferir.Location = new System.Drawing.Point(985, 365);
            this.btn_transferir.Name = "btn_transferir";
            this.btn_transferir.Size = new System.Drawing.Size(164, 23);
            this.btn_transferir.TabIndex = 3;
            this.btn_transferir.Text = "Transferir a Base de Datos";
            this.btn_transferir.UseVisualStyleBackColor = true;
            this.btn_transferir.Click += new System.EventHandler(this.btn_transferir_Click);
            // 
            // cb_listaProveedores
            // 
            this.cb_listaProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_listaProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_listaProveedores.FormattingEnabled = true;
            this.cb_listaProveedores.Location = new System.Drawing.Point(746, 7);
            this.cb_listaProveedores.Name = "cb_listaProveedores";
            this.cb_listaProveedores.Size = new System.Drawing.Size(165, 21);
            this.cb_listaProveedores.TabIndex = 2;
            this.cb_listaProveedores.SelectedIndexChanged += new System.EventHandler(this.cb_listaProveedores_SelectedIndexChanged);
            // 
            // btn_seleccionarArchivo
            // 
            this.btn_seleccionarArchivo.Location = new System.Drawing.Point(7, 7);
            this.btn_seleccionarArchivo.Name = "btn_seleccionarArchivo";
            this.btn_seleccionarArchivo.Size = new System.Drawing.Size(115, 23);
            this.btn_seleccionarArchivo.TabIndex = 0;
            this.btn_seleccionarArchivo.Text = "Importar Archivo";
            this.btn_seleccionarArchivo.UseVisualStyleBackColor = true;
            this.btn_seleccionarArchivo.Click += new System.EventHandler(this.btn_seleccionarArchivo_Click);
            // 
            // pb_transferProgress
            // 
            this.pb_transferProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_transferProgress.Location = new System.Drawing.Point(196, 365);
            this.pb_transferProgress.Name = "pb_transferProgress";
            this.pb_transferProgress.Size = new System.Drawing.Size(635, 6);
            this.pb_transferProgress.TabIndex = 7;
            // 
            // dgv_listadoExcel
            // 
            this.dgv_listadoExcel.AllowUserToAddRows = false;
            this.dgv_listadoExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_listadoExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listadoExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoExcel.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_listadoExcel.Location = new System.Drawing.Point(7, 37);
            this.dgv_listadoExcel.Name = "dgv_listadoExcel";
            this.dgv_listadoExcel.RowHeadersVisible = false;
            this.dgv_listadoExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listadoExcel.ShowEditingIcon = false;
            this.dgv_listadoExcel.Size = new System.Drawing.Size(1142, 295);
            this.dgv_listadoExcel.TabIndex = 5;
            this.dgv_listadoExcel.DataSourceChanged += new System.EventHandler(this.dgv_listadoExcel_DataSourceChanged);
            this.dgv_listadoExcel.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_listadoExcel_CellFormatting);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // bt_exportar
            // 
            this.bt_exportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_exportar.Location = new System.Drawing.Point(130, 447);
            this.bt_exportar.Name = "bt_exportar";
            this.bt_exportar.Size = new System.Drawing.Size(75, 23);
            this.bt_exportar.TabIndex = 21;
            this.bt_exportar.Text = "Exportar";
            this.bt_exportar.UseVisualStyleBackColor = true;
            this.bt_exportar.Click += new System.EventHandler(this.bt_exportar_Click);
            // 
            // AdministrarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1231, 482);
            this.Controls.Add(this.bt_exportar);
            this.Controls.Add(this.tc_productos);
            this.Controls.Add(this.btn_cerrarVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Articulos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrar_Stock_FormClosing);
            this.tb_listarProductos.ResumeLayout(false);
            this.tb_listarProductos.PerformLayout();
            this.tlp_productProgressInfo.ResumeLayout(false);
            this.tlp_productProgressInfo.PerformLayout();
            this.gb_filtrosFechaModificacion.ResumeLayout(false);
            this.gb_filtrosFechaModificacion.PerformLayout();
            this.gb_filtrosFechaCreacion.ResumeLayout(false);
            this.gb_filtrosFechaCreacion.PerformLayout();
            this.gb_filtroStock.ResumeLayout(false);
            this.gb_filtroStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockMenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockMayor)).EndInit();
            this.gb_filtrosPrecioFinal.ResumeLayout(false);
            this.gb_filtrosPrecioFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precioFinalMenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precioFinalMayor)).EndInit();
            this.gb_filtrosPrecio.ResumeLayout(false);
            this.gb_filtrosPrecio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precioMenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precioMayor)).EndInit();
            this.gb_filtros.ResumeLayout(false);
            this.gb_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).EndInit();
            this.cms_menuProductos.ResumeLayout(false);
            this.tp_agregarProductos.ResumeLayout(false);
            this.tp_agregarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ap_porcentajeDeUtilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ap_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ap_stock)).EndInit();
            this.tc_productos.ResumeLayout(false);
            this.tp_importarProductos.ResumeLayout(false);
            this.tp_importarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_importPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrarStockSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_cerrarVentana;
        private TabPage tb_listarProductos;
        private TextBox tb_filtroNombre;
        private DataGridView dgv_listaProductos;
        private TabPage tp_agregarProductos;
        private ComboBox cb_ap_proveedor;
        private Button btn_ap_agregar;
        private NumericUpDown nud_ap_stock;
        private TextBox tb_ap_nombre;
        private TextBox tb_ap_codigo;
        private Label lbl_ap_precio;
        private Label lbl_ap_stock;
        private Label lbl_ap_nombre;
        private Label lbl_ap_proveedor;
        private Label lbl_ap_codigo;
        private TabPage tp_importarProductos;
        private DataGridView dgv_listadoExcel;
        private Button btn_cancelarTransferencia;
        private Button btn_transferir;
        private ComboBox cb_listaProveedores;
        private Button btn_seleccionarArchivo;
        private ProgressBar pb_transferProgress;
        private Label lbl_estado;
        private ComboBox cb_filtroProveedor;
        private Label lbl_progresoInfo;
        private GroupBox gb_filtrosPrecio;
        private NumericUpDown nud_precioMayor;
        private Label lbl_filtrosPreciodeVentaMenor;
        private Label lbl_filtrosPreciodeVentaMayor;
        private GroupBox gb_filtros;
        private Label lbl_filtrosProveedor;
        private Label lbl_filtrosDescipcion;
        private GroupBox gb_filtrosPrecioFinal;
        private NumericUpDown nud_precioFinalMenor;
        private NumericUpDown nud_precioFinalMayor;
        private Label lbl_filtrosPreciodeCompraMenor;
        private Label lbl_filtrosPreciodeCompraMayor;
        private NumericUpDown nud_precioMenor;
        private GroupBox gb_filtroStock;
        private NumericUpDown nud_stockMenor;
        private NumericUpDown nud_stockMayor;
        private Label lbl_filtrosStockMenor;
        private Label lbl_filtrosStockMayor;
        private GroupBox gb_filtrosFechaCreacion;
        private DateTimePicker dtp_filtrosFechaCreacionAntes;
        private DateTimePicker dtp_filtrosFechaCreacionDespues;
        private Label lbl_filtrosFechaCreacionAntes;
        private Label lbl_filtrosFechaCreacionDespues;
        private GroupBox gb_filtrosFechaModificacion;
        private DateTimePicker dtp_filtrosFechaModificacionAntes;
        private DateTimePicker dtp_filtrosFechaModificacionDespues;
        private Label lbl_filtrosFechaModificacionAntes;
        private Label lbl_filtrosFechaModificacionDespues;
        private ContextMenuStrip cms_menuProductos;
        private ToolStripMenuItem tsmi_eliminar;
        private ToolStripMenuItem tsmi_mostrar;
        private ToolStripSeparator tss_menuProductoSeparador;
        private ToolStripMenuItem tsmi_filasSeleccionadas;
        private ToolStripMenuItem tsmi_marcarOculto;
        private ToolStripMenuItem tsmi_marcarVisible;
        private Label lbl_filtroMostrar;
        private ComboBox cb_filtroArticulosAMostrar;
        private ToolStripMenuItem tsmi_aplicarPorcentaje;
        private NumericUpDown nud_ap_precio;
        private Button btn_ap_limpiar;
        private Label lbl_importarPorcentaje;
        private NumericUpDown nud_importPercentage;
        private Label lbl_mariconaDePorcentaje;
        private ToolStripMenuItem tsmi_seleccionarTodo;
        private ToolStripMenuItem tsmi_sumarPorcentaje;
        private ToolStripMenuItem tsmi_aplicarPorcentajeAPrecio;
        private ToolStripSeparator tss_locationSeparator;
        private Label lbl_limitItems;
        private ComboBox cb_itemsPerPage;
        private Button btn_prevPage;
        private Button btn_nextPage;
        private Label lbl_pages;
        private Label lbl_proveedorInfo;
        private Label lbl_impArticleCount;
        private Label lbl_importedFileName;
        private ProgressBar pb_productProgress;
        private TableLayoutPanel tlp_productProgressInfo;
        private Timer timer1;
        private Label lbl_ap_info;
        private NumericUpDown nud_ap_porcentajeDeUtilidad;
        private Label lbl_ap_porcentajeDeUtilidad;
        private TextBox tb_ap_codigoDeBarras;
        private Label lbl_ap_codigoDeBarras;
        private ToolStripMenuItem tsmi_addToLocation;
        private ToolStripSeparator tss_deleteSeparator;
        private ToolStripMenuItem tsmi_locationName;
        private ToolStripSeparator tss_columnsSeparator;
        private ToolStripMenuItem tsmi_chooseColumns;
        public TabControl tc_productos;
        private CheckBox cb_includeZeroPriced;
        private CheckBox cb_updateDescription;
        private BindingSource settingsBindingSource;
        private BindingSource userSettingsBindingSource;
        private BindingSource administrarStockSettingsBindingSource;
        private Button bt_exportar;
    }
}