using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Pedidos
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.lb_proveedores = new System.Windows.Forms.ListBox();
            this.cb_tipoPedido = new System.Windows.Forms.ComboBox();
            this.lb_pedidos = new System.Windows.Forms.ListBox();
            this.gb_datosPedido = new System.Windows.Forms.GroupBox();
            this.lbl_costoTotalValue = new System.Windows.Forms.Label();
            this.lbl_costoTotal = new System.Windows.Forms.Label();
            this.lbl_fechaArrivoValue = new System.Windows.Forms.Label();
            this.lbl_fechaArrivo = new System.Windows.Forms.Label();
            this.dtp_fechaPedido = new System.Windows.Forms.DateTimePicker();
            this.btn_agregarProductos = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_eliminarPedido = new System.Windows.Forms.Button();
            this.btn_registrarIngreso = new System.Windows.Forms.Button();
            this.btn_cambiarFecha = new System.Windows.Forms.Button();
            this.dgv_pedido = new System.Windows.Forms.DataGridView();
            this.btn_agregarNuevoPedido = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.gb_datosPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_proveedores
            // 
            this.lb_proveedores.FormattingEnabled = true;
            this.lb_proveedores.Location = new System.Drawing.Point(12, 12);
            this.lb_proveedores.Name = "lb_proveedores";
            this.lb_proveedores.Size = new System.Drawing.Size(220, 433);
            this.lb_proveedores.TabIndex = 0;
            this.lb_proveedores.SelectedIndexChanged += new System.EventHandler(this.lb_proveedores_SelectedIndexChanged);
            // 
            // cb_tipoPedido
            // 
            this.cb_tipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipoPedido.FormattingEnabled = true;
            this.cb_tipoPedido.Items.AddRange(new object[] {
            "Activos",
            "Archivados"});
            this.cb_tipoPedido.Location = new System.Drawing.Point(238, 11);
            this.cb_tipoPedido.Name = "cb_tipoPedido";
            this.cb_tipoPedido.Size = new System.Drawing.Size(166, 21);
            this.cb_tipoPedido.TabIndex = 1;
            this.cb_tipoPedido.SelectedIndexChanged += new System.EventHandler(this.cb_tipoPedido_SelectedIndexChanged);
            // 
            // lb_pedidos
            // 
            this.lb_pedidos.FormattingEnabled = true;
            this.lb_pedidos.Location = new System.Drawing.Point(238, 38);
            this.lb_pedidos.Name = "lb_pedidos";
            this.lb_pedidos.Size = new System.Drawing.Size(166, 407);
            this.lb_pedidos.TabIndex = 2;
            this.lb_pedidos.SelectedIndexChanged += new System.EventHandler(this.lb_pedidos_SelectedIndexChanged);
            this.lb_pedidos.DataSourceChanged += new System.EventHandler(this.lb_pedidos_DataSourceChanged);
            // 
            // gb_datosPedido
            // 
            this.gb_datosPedido.Controls.Add(this.lbl_costoTotalValue);
            this.gb_datosPedido.Controls.Add(this.lbl_costoTotal);
            this.gb_datosPedido.Controls.Add(this.lbl_fechaArrivoValue);
            this.gb_datosPedido.Controls.Add(this.lbl_fechaArrivo);
            this.gb_datosPedido.Controls.Add(this.dtp_fechaPedido);
            this.gb_datosPedido.Controls.Add(this.btn_agregarProductos);
            this.gb_datosPedido.Controls.Add(this.lbl_fecha);
            this.gb_datosPedido.Controls.Add(this.btn_eliminarPedido);
            this.gb_datosPedido.Controls.Add(this.btn_registrarIngreso);
            this.gb_datosPedido.Controls.Add(this.btn_cambiarFecha);
            this.gb_datosPedido.Controls.Add(this.dgv_pedido);
            this.gb_datosPedido.Location = new System.Drawing.Point(410, 11);
            this.gb_datosPedido.Name = "gb_datosPedido";
            this.gb_datosPedido.Size = new System.Drawing.Size(531, 434);
            this.gb_datosPedido.TabIndex = 3;
            this.gb_datosPedido.TabStop = false;
            this.gb_datosPedido.Text = "Datos Del Pedido";
            // 
            // lbl_costoTotalValue
            // 
            this.lbl_costoTotalValue.AutoSize = true;
            this.lbl_costoTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costoTotalValue.Location = new System.Drawing.Point(400, 381);
            this.lbl_costoTotalValue.Name = "lbl_costoTotalValue";
            this.lbl_costoTotalValue.Size = new System.Drawing.Size(39, 13);
            this.lbl_costoTotalValue.TabIndex = 10;
            this.lbl_costoTotalValue.Text = "$0.00";
            // 
            // lbl_costoTotal
            // 
            this.lbl_costoTotal.AutoSize = true;
            this.lbl_costoTotal.Location = new System.Drawing.Point(336, 381);
            this.lbl_costoTotal.Name = "lbl_costoTotal";
            this.lbl_costoTotal.Size = new System.Drawing.Size(64, 13);
            this.lbl_costoTotal.TabIndex = 9;
            this.lbl_costoTotal.Text = "Costo Total:";
            // 
            // lbl_fechaArrivoValue
            // 
            this.lbl_fechaArrivoValue.AutoSize = true;
            this.lbl_fechaArrivoValue.Location = new System.Drawing.Point(91, 381);
            this.lbl_fechaArrivoValue.Name = "lbl_fechaArrivoValue";
            this.lbl_fechaArrivoValue.Size = new System.Drawing.Size(27, 13);
            this.lbl_fechaArrivoValue.TabIndex = 8;
            this.lbl_fechaArrivoValue.Text = "N/A";
            // 
            // lbl_fechaArrivo
            // 
            this.lbl_fechaArrivo.AutoSize = true;
            this.lbl_fechaArrivo.Location = new System.Drawing.Point(6, 381);
            this.lbl_fechaArrivo.Name = "lbl_fechaArrivo";
            this.lbl_fechaArrivo.Size = new System.Drawing.Size(85, 13);
            this.lbl_fechaArrivo.TabIndex = 7;
            this.lbl_fechaArrivo.Text = "Fecha de Arrivo:";
            // 
            // dtp_fechaPedido
            // 
            this.dtp_fechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaPedido.Location = new System.Drawing.Point(54, 16);
            this.dtp_fechaPedido.Name = "dtp_fechaPedido";
            this.dtp_fechaPedido.Size = new System.Drawing.Size(84, 20);
            this.dtp_fechaPedido.TabIndex = 6;
            this.dtp_fechaPedido.ValueChanged += new System.EventHandler(this.dtp_fechaPedido_ValueChanged);
            // 
            // btn_agregarProductos
            // 
            this.btn_agregarProductos.Location = new System.Drawing.Point(426, 405);
            this.btn_agregarProductos.Name = "btn_agregarProductos";
            this.btn_agregarProductos.Size = new System.Drawing.Size(99, 23);
            this.btn_agregarProductos.TabIndex = 5;
            this.btn_agregarProductos.Text = "Agregar Articulos";
            this.btn_agregarProductos.UseVisualStyleBackColor = true;
            this.btn_agregarProductos.Click += new System.EventHandler(this.btn_agregarProductos_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(7, 20);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 4;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // btn_eliminarPedido
            // 
            this.btn_eliminarPedido.Location = new System.Drawing.Point(6, 405);
            this.btn_eliminarPedido.Name = "btn_eliminarPedido";
            this.btn_eliminarPedido.Size = new System.Drawing.Size(103, 23);
            this.btn_eliminarPedido.TabIndex = 3;
            this.btn_eliminarPedido.Text = "Eliminar Pedido";
            this.btn_eliminarPedido.UseVisualStyleBackColor = true;
            this.btn_eliminarPedido.Click += new System.EventHandler(this.btn_eliminarPedido_Click);
            // 
            // btn_registrarIngreso
            // 
            this.btn_registrarIngreso.Location = new System.Drawing.Point(216, 405);
            this.btn_registrarIngreso.Name = "btn_registrarIngreso";
            this.btn_registrarIngreso.Size = new System.Drawing.Size(99, 23);
            this.btn_registrarIngreso.TabIndex = 2;
            this.btn_registrarIngreso.Text = "Registrar Ingreso";
            this.btn_registrarIngreso.UseVisualStyleBackColor = true;
            this.btn_registrarIngreso.Click += new System.EventHandler(this.btn_registrarIngreso_Click);
            // 
            // btn_cambiarFecha
            // 
            this.btn_cambiarFecha.Location = new System.Drawing.Point(144, 15);
            this.btn_cambiarFecha.Name = "btn_cambiarFecha";
            this.btn_cambiarFecha.Size = new System.Drawing.Size(108, 23);
            this.btn_cambiarFecha.TabIndex = 1;
            this.btn_cambiarFecha.Text = "Cambiar Fecha";
            this.btn_cambiarFecha.UseVisualStyleBackColor = true;
            this.btn_cambiarFecha.Click += new System.EventHandler(this.btn_cambiarFecha_Click);
            // 
            // dgv_pedido
            // 
            this.dgv_pedido.AllowUserToAddRows = false;
            this.dgv_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedido.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_pedido.Location = new System.Drawing.Point(6, 47);
            this.dgv_pedido.Name = "dgv_pedido";
            this.dgv_pedido.RowHeadersVisible = false;
            this.dgv_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pedido.Size = new System.Drawing.Size(519, 322);
            this.dgv_pedido.TabIndex = 0;
            this.dgv_pedido.DataSourceChanged += new System.EventHandler(this.dgv_pedido_DataSourceChanged);
            this.dgv_pedido.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedido_CellValidated);
            this.dgv_pedido.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_pedido_EditingControlShowing);
            this.dgv_pedido.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_pedido_UserDeletingRow);
            // 
            // btn_agregarNuevoPedido
            // 
            this.btn_agregarNuevoPedido.Location = new System.Drawing.Point(13, 452);
            this.btn_agregarNuevoPedido.Name = "btn_agregarNuevoPedido";
            this.btn_agregarNuevoPedido.Size = new System.Drawing.Size(219, 23);
            this.btn_agregarNuevoPedido.TabIndex = 4;
            this.btn_agregarNuevoPedido.Text = "Agregar Pedido a";
            this.btn_agregarNuevoPedido.UseVisualStyleBackColor = true;
            this.btn_agregarNuevoPedido.Click += new System.EventHandler(this.btn_agregarNuevoPedido_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(866, 451);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(953, 481);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_agregarNuevoPedido);
            this.Controls.Add(this.gb_datosPedido);
            this.Controls.Add(this.lb_pedidos);
            this.Controls.Add(this.cb_tipoPedido);
            this.Controls.Add(this.lb_proveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.gb_datosPedido.ResumeLayout(false);
            this.gb_datosPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lb_proveedores;
        private ComboBox cb_tipoPedido;
        private ListBox lb_pedidos;
        private GroupBox gb_datosPedido;
        private Button btn_eliminarPedido;
        private Button btn_registrarIngreso;
        private Button btn_cambiarFecha;
        private DataGridView dgv_pedido;
        private Button btn_agregarNuevoPedido;
        private Button btn_cerrar;
        private Label lbl_fecha;
        private DateTimePicker dtp_fechaPedido;
        private Button btn_agregarProductos;
        private Label lbl_costoTotalValue;
        private Label lbl_costoTotal;
        private Label lbl_fechaArrivoValue;
        private Label lbl_fechaArrivo;
    }
}