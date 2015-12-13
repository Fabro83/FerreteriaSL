namespace FerreteriaSL
{
    partial class Ventas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dgv_productosIngresados = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_totalMonto = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_imprimirTicket = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.tm_fechaHora = new System.Windows.Forms.Timer(this.components);
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_incrementar = new System.Windows.Forms.Button();
            this.btn_disminuir = new System.Windows.Forms.Button();
            this.btn_removerTodos = new System.Windows.Forms.Button();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.nud_discountPercent = new System.Windows.Forms.NumericUpDown();
            this.lbl_percentSymbol = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_ivaValue = new System.Windows.Forms.Label();
            this.nud_discountImport = new System.Windows.Forms.NumericUpDown();
            this.lbl_pesosSymbol = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.tt_help = new System.Windows.Forms.ToolTip(this.components);
            this.btn_exportar = new System.Windows.Forms.Button();
            this.cg_busqueda = new FerreteriaSL.ComboGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productosIngresados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_discountPercent)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_discountImport)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(12, 439);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(79, 23);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dgv_productosIngresados
            // 
            this.dgv_productosIngresados.AllowUserToAddRows = false;
            this.dgv_productosIngresados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_productosIngresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productosIngresados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.precio_unitario,
            this.precio_subtotal,
            this.id,
            this.proveedor,
            this.proveedor_id});
            this.dgv_productosIngresados.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_productosIngresados.Location = new System.Drawing.Point(13, 70);
            this.dgv_productosIngresados.Name = "dgv_productosIngresados";
            this.dgv_productosIngresados.ReadOnly = true;
            this.dgv_productosIngresados.RowHeadersVisible = false;
            this.dgv_productosIngresados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productosIngresados.Size = new System.Drawing.Size(977, 277);
            this.dgv_productosIngresados.TabIndex = 4;
            this.dgv_productosIngresados.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_productosIngresados_RowsAdded);
            this.dgv_productosIngresados.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_productosIngresados_RowsRemoved);
            this.dgv_productosIngresados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_productosIngresados_KeyDown);
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo.FillWeight = 28.63248F;
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.FillWeight = 151.4012F;
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 87;
            // 
            // precio_unitario
            // 
            this.precio_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "$0.00";
            dataGridViewCellStyle1.NullValue = null;
            this.precio_unitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.precio_unitario.FillWeight = 59.99657F;
            this.precio_unitario.HeaderText = "PRECIO UNITARIO";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            // 
            // precio_subtotal
            // 
            this.precio_subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "$0.00";
            this.precio_subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.precio_subtotal.FillWeight = 59.96976F;
            this.precio_subtotal.HeaderText = "PRECIO SUBTOTAL";
            this.precio_subtotal.Name = "precio_subtotal";
            this.precio_subtotal.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            this.proveedor.Visible = false;
            // 
            // proveedor_id
            // 
            this.proveedor_id.HeaderText = "proveedor_id";
            this.proveedor_id.Name = "proveedor_id";
            this.proveedor_id.ReadOnly = true;
            this.proveedor_id.Visible = false;
            // 
            // lbl_totalMonto
            // 
            this.lbl_totalMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_totalMonto.AutoSize = true;
            this.lbl_totalMonto.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalMonto.ForeColor = System.Drawing.Color.Red;
            this.lbl_totalMonto.Location = new System.Drawing.Point(192, 0);
            this.lbl_totalMonto.Name = "lbl_totalMonto";
            this.lbl_totalMonto.Size = new System.Drawing.Size(71, 32);
            this.lbl_totalMonto.TabIndex = 6;
            this.lbl_totalMonto.Text = "0,00";
            this.lbl_totalMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Red;
            this.lbl_total.Location = new System.Drawing.Point(33, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(153, 32);
            this.lbl_total.TabIndex = 7;
            this.lbl_total.Text = "TOTAL  $";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_imprimirTicket
            // 
            this.btn_imprimirTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_imprimirTicket.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_imprimirTicket.Enabled = false;
            this.btn_imprimirTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimirTicket.Location = new System.Drawing.Point(610, 434);
            this.btn_imprimirTicket.Name = "btn_imprimirTicket";
            this.btn_imprimirTicket.Size = new System.Drawing.Size(379, 33);
            this.btn_imprimirTicket.TabIndex = 8;
            this.btn_imprimirTicket.Text = "Realizar Venta (F5)";
            this.btn_imprimirTicket.UseVisualStyleBackColor = false;
            this.btn_imprimirTicket.Click += new System.EventHandler(this.btn_imprimirTicket_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.AutoSize = true;
            this.btn_remover.Enabled = false;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(289, 362);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(133, 25);
            this.btn_remover.TabIndex = 13;
            this.btn_remover.Text = "Remover Articulo";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.Navy;
            this.lbl_fecha.Location = new System.Drawing.Point(106, 440);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(99, 20);
            this.lbl_fecha.TabIndex = 19;
            this.lbl_fecha.Text = "00/00/0000";
            // 
            // tm_fechaHora
            // 
            this.tm_fechaHora.Enabled = true;
            this.tm_fechaHora.Interval = 1000;
            this.tm_fechaHora.Tick += new System.EventHandler(this.tm_fechaHora_Tick);
            // 
            // nud_cantidad
            // 
            this.nud_cantidad.Enabled = false;
            this.nud_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_cantidad.Location = new System.Drawing.Point(82, 35);
            this.nud_cantidad.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_cantidad.Name = "nud_cantidad";
            this.nud_cantidad.Size = new System.Drawing.Size(56, 24);
            this.nud_cantidad.TabIndex = 23;
            this.nud_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cantidad.Enter += new System.EventHandler(this.nud_cantidad_Enter);
            this.nud_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_cantidad_KeyPress);
            this.nud_cantidad.Leave += new System.EventHandler(this.nud_cantidad_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "unidades.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Articulo:";
            // 
            // btn_incrementar
            // 
            this.btn_incrementar.AutoSize = true;
            this.btn_incrementar.Enabled = false;
            this.btn_incrementar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incrementar.Location = new System.Drawing.Point(110, 362);
            this.btn_incrementar.Name = "btn_incrementar";
            this.btn_incrementar.Size = new System.Drawing.Size(159, 25);
            this.btn_incrementar.TabIndex = 27;
            this.btn_incrementar.Text = "Incrementar Unidades";
            this.btn_incrementar.UseVisualStyleBackColor = true;
            this.btn_incrementar.Click += new System.EventHandler(this.btn_incrementar_Click);
            // 
            // btn_disminuir
            // 
            this.btn_disminuir.AutoSize = true;
            this.btn_disminuir.Enabled = false;
            this.btn_disminuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disminuir.Location = new System.Drawing.Point(110, 393);
            this.btn_disminuir.Name = "btn_disminuir";
            this.btn_disminuir.Size = new System.Drawing.Size(159, 25);
            this.btn_disminuir.TabIndex = 28;
            this.btn_disminuir.Text = "Disminuir Unidades";
            this.btn_disminuir.UseVisualStyleBackColor = true;
            this.btn_disminuir.Click += new System.EventHandler(this.btn_disminuir_Click);
            // 
            // btn_removerTodos
            // 
            this.btn_removerTodos.AutoSize = true;
            this.btn_removerTodos.Enabled = false;
            this.btn_removerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removerTodos.Location = new System.Drawing.Point(289, 393);
            this.btn_removerTodos.Name = "btn_removerTodos";
            this.btn_removerTodos.Size = new System.Drawing.Size(132, 25);
            this.btn_removerTodos.TabIndex = 29;
            this.btn_removerTodos.Text = "Remover Todos";
            this.btn_removerTodos.UseVisualStyleBackColor = true;
            this.btn_removerTodos.Click += new System.EventHandler(this.btn_removerTodos_Click);
            // 
            // lbl_hora
            // 
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.Navy;
            this.lbl_hora.Location = new System.Drawing.Point(211, 440);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(109, 20);
            this.lbl_hora.TabIndex = 30;
            this.lbl_hora.Text = "00:00:00 PM";
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.Location = new System.Drawing.Point(456, 362);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(110, 24);
            this.lbl_discount.TabIndex = 31;
            this.lbl_discount.Text = "Descuento";
            // 
            // nud_discountPercent
            // 
            this.nud_discountPercent.DecimalPlaces = 2;
            this.nud_discountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_discountPercent.Location = new System.Drawing.Point(459, 389);
            this.nud_discountPercent.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.nud_discountPercent.Minimum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            -2147483648});
            this.nud_discountPercent.Name = "nud_discountPercent";
            this.nud_discountPercent.Size = new System.Drawing.Size(83, 29);
            this.nud_discountPercent.TabIndex = 32;
            this.nud_discountPercent.ValueChanged += new System.EventHandler(this.nud_discount_ValueChanged);
            this.nud_discountPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_discountPercent_KeyPress);
            // 
            // lbl_percentSymbol
            // 
            this.lbl_percentSymbol.AutoSize = true;
            this.lbl_percentSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percentSymbol.Location = new System.Drawing.Point(542, 391);
            this.lbl_percentSymbol.Name = "lbl_percentSymbol";
            this.lbl_percentSymbol.Size = new System.Drawing.Size(26, 24);
            this.lbl_percentSymbol.TabIndex = 33;
            this.lbl_percentSymbol.Text = "%";
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(666, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 23);
            this.btn_search.TabIndex = 34;
            this.btn_search.Text = "Buscar (F1)";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_total, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_totalMonto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_iva, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ivaValue, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(610, 364);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 64);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // lbl_iva
            // 
            this.lbl_iva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.Location = new System.Drawing.Point(75, 32);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(111, 32);
            this.lbl_iva.TabIndex = 8;
            this.lbl_iva.Text = "IVA (21%): $";
            this.lbl_iva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ivaValue
            // 
            this.lbl_ivaValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ivaValue.AutoSize = true;
            this.lbl_ivaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ivaValue.Location = new System.Drawing.Point(192, 32);
            this.lbl_ivaValue.Name = "lbl_ivaValue";
            this.lbl_ivaValue.Size = new System.Drawing.Size(44, 32);
            this.lbl_ivaValue.TabIndex = 9;
            this.lbl_ivaValue.Text = "0,00";
            this.lbl_ivaValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nud_discountImport
            // 
            this.nud_discountImport.DecimalPlaces = 2;
            this.nud_discountImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_discountImport.Location = new System.Drawing.Point(459, 424);
            this.nud_discountImport.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nud_discountImport.Minimum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            -2147483648});
            this.nud_discountImport.Name = "nud_discountImport";
            this.nud_discountImport.Size = new System.Drawing.Size(83, 29);
            this.nud_discountImport.TabIndex = 36;
            this.nud_discountImport.ValueChanged += new System.EventHandler(this.nud_discountImport_ValueChanged);
            this.nud_discountImport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_discountImport_KeyPress);
            // 
            // lbl_pesosSymbol
            // 
            this.lbl_pesosSymbol.AutoSize = true;
            this.lbl_pesosSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesosSymbol.Location = new System.Drawing.Point(545, 426);
            this.lbl_pesosSymbol.Name = "lbl_pesosSymbol";
            this.lbl_pesosSymbol.Size = new System.Drawing.Size(21, 24);
            this.lbl_pesosSymbol.TabIndex = 37;
            this.lbl_pesosSymbol.Text = "$";
            // 
            // btn_help
            // 
            this.btn_help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_help.BackgroundImage")));
            this.btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_help.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Location = new System.Drawing.Point(23, 362);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(56, 51);
            this.btn_help.TabIndex = 39;
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.MouseEnter += new System.EventHandler(this.btn_help_MouseEnter);
            this.btn_help.MouseLeave += new System.EventHandler(this.btn_help_MouseLeave);
            // 
            // tt_help
            // 
            this.tt_help.AutoPopDelay = 5000;
            this.tt_help.InitialDelay = 500;
            this.tt_help.ReshowDelay = 100;
            this.tt_help.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_help.ToolTipTitle = "Información";
            // 
            // btn_exportar
            // 
            this.btn_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.Location = new System.Drawing.Point(327, 424);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(95, 43);
            this.btn_exportar.TabIndex = 40;
            this.btn_exportar.Text = "Exportar a Excel";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // cg_busqueda
            // 
            this.cg_busqueda.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cg_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cg_busqueda.Location = new System.Drawing.Point(82, 8);
            this.cg_busqueda.Margin = new System.Windows.Forms.Padding(0);
            this.cg_busqueda.Name = "cg_busqueda";
            this.cg_busqueda.SearchPhrase = "";
            this.cg_busqueda.Size = new System.Drawing.Size(581, 21);
            this.cg_busqueda.TabIndex = 22;
            this.cg_busqueda.SelectionMade += new FerreteriaSL.SelectionMadeHandler(this.comboGrid1_SelectionMade);
            this.cg_busqueda.Leave += new System.EventHandler(this.cg_busqueda_Leave);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1002, 474);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.lbl_pesosSymbol);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.nud_discountImport);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_percentSymbol);
            this.Controls.Add(this.nud_discountPercent);
            this.Controls.Add(this.lbl_discount);
            this.Controls.Add(this.btn_imprimirTicket);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.btn_removerTodos);
            this.Controls.Add(this.btn_disminuir);
            this.Controls.Add(this.btn_incrementar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cg_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_cantidad);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.dgv_productosIngresados);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ventas_FormClosing);
            this.Shown += new System.EventHandler(this.Ventas_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productosIngresados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_discountPercent)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_discountImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_totalMonto;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_imprimirTicket;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.Timer tm_fechaHora;
        private ComboGrid cg_busqueda;
        private System.Windows.Forms.NumericUpDown nud_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_incrementar;
        private System.Windows.Forms.Button btn_disminuir;
        private System.Windows.Forms.Button btn_removerTodos;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.NumericUpDown nud_discountPercent;
        private System.Windows.Forms.Label lbl_percentSymbol;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lbl_ivaValue;
        private System.Windows.Forms.NumericUpDown nud_discountImport;
        private System.Windows.Forms.Label lbl_pesosSymbol;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.ToolTip tt_help;
        public System.Windows.Forms.DataGridView dgv_productosIngresados;
        private System.Windows.Forms.Button btn_exportar;
    }
}