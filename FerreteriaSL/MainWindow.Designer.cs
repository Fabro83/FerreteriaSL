﻿namespace FerreteriaSL
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ms_mainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmi_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_archivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mantenimientoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mantenimientoProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mantenimientoProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mantenimientoPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mantenimientoVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mantenimientoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mantenimientoEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mantenimientoCajaDiaria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mantenimientoSecciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_cambiarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.testPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_mainStatusBar = new System.Windows.Forms.StatusStrip();
            this.ms_mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_mainMenu
            // 
            this.ms_mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_archivo,
            this.tsmi_mantenimiento,
            this.tsmi_cambiarUsuario,
            this.tsmi_ventas,
            this.testPrintToolStripMenuItem});
            this.ms_mainMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_mainMenu.Name = "ms_mainMenu";
            this.ms_mainMenu.Size = new System.Drawing.Size(895, 24);
            this.ms_mainMenu.TabIndex = 1;
            this.ms_mainMenu.Text = "menuStrip1";
            // 
            // tsmi_archivo
            // 
            this.tsmi_archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_archivoSalir});
            this.tsmi_archivo.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_archivo.Image")));
            this.tsmi_archivo.Name = "tsmi_archivo";
            this.tsmi_archivo.Size = new System.Drawing.Size(76, 20);
            this.tsmi_archivo.Text = "Archivo";
            // 
            // tsmi_archivoSalir
            // 
            this.tsmi_archivoSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_archivoSalir.Image")));
            this.tsmi_archivoSalir.Name = "tsmi_archivoSalir";
            this.tsmi_archivoSalir.Size = new System.Drawing.Size(96, 22);
            this.tsmi_archivoSalir.Text = "Salir";
            this.tsmi_archivoSalir.Click += new System.EventHandler(this.tsmi_archivoSalir_Click);
            // 
            // tsmi_mantenimiento
            // 
            this.tsmi_mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_mantenimientoClientes,
            this.tsmi_mantenimientoProductos,
            this.tsmi_mantenimientoProveedores,
            this.tsmi_mantenimientoPedidos,
            this.tsmi_mantenimientoVentas,
            this.tsmi_mantenimientoUsuarios,
            this.tsmi_mantenimientoEmpleados,
            this.tsmi_mantenimientoCajaDiaria,
            this.tsmi_mantenimientoSecciones});
            this.tsmi_mantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mantenimiento.Image")));
            this.tsmi_mantenimiento.Name = "tsmi_mantenimiento";
            this.tsmi_mantenimiento.Size = new System.Drawing.Size(117, 20);
            this.tsmi_mantenimiento.Text = "Mantenimiento";
            // 
            // tsmi_mantenimientoClientes
            // 
            this.tsmi_mantenimientoClientes.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mantenimientoClientes.Image")));
            this.tsmi_mantenimientoClientes.Name = "tsmi_mantenimientoClientes";
            this.tsmi_mantenimientoClientes.Size = new System.Drawing.Size(193, 22);
            this.tsmi_mantenimientoClientes.Text = "Clientes";
            this.tsmi_mantenimientoClientes.Click += new System.EventHandler(this.tsmi_mantenimientoClientes_Click);
            // 
            // tsmi_mantenimientoProductos
            // 
            this.tsmi_mantenimientoProductos.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mantenimientoProductos.Image")));
            this.tsmi_mantenimientoProductos.Name = "tsmi_mantenimientoProductos";
            this.tsmi_mantenimientoProductos.Size = new System.Drawing.Size(193, 22);
            this.tsmi_mantenimientoProductos.Text = "Productos";
            this.tsmi_mantenimientoProductos.Click += new System.EventHandler(this.tsmi_mantenimientoProductos_Click);
            // 
            // tsmi_mantenimientoProveedores
            // 
            this.tsmi_mantenimientoProveedores.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mantenimientoProveedores.Image")));
            this.tsmi_mantenimientoProveedores.Name = "tsmi_mantenimientoProveedores";
            this.tsmi_mantenimientoProveedores.Size = new System.Drawing.Size(193, 22);
            this.tsmi_mantenimientoProveedores.Text = "Proveedores";
            this.tsmi_mantenimientoProveedores.Click += new System.EventHandler(this.tsmi_mantenimientoProveedores_Click);
            // 
            // tsmi_mantenimientoPedidos
            // 
            this.tsmi_mantenimientoPedidos.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mantenimientoPedidos.Image")));
            this.tsmi_mantenimientoPedidos.Name = "tsmi_mantenimientoPedidos";
            this.tsmi_mantenimientoPedidos.Size = new System.Drawing.Size(193, 22);
            this.tsmi_mantenimientoPedidos.Text = "Pedidos a Proveedores";
            this.tsmi_mantenimientoPedidos.Click += new System.EventHandler(this.tsmi_mantenimientoPedidos_Click);
            // 
            // tsmi_mantenimientoVentas
            // 
            this.tsmi_mantenimientoVentas.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mantenimientoVentas.Image")));
            this.tsmi_mantenimientoVentas.Name = "tsmi_mantenimientoVentas";
            this.tsmi_mantenimientoVentas.Size = new System.Drawing.Size(193, 22);
            this.tsmi_mantenimientoVentas.Text = "Registro de Ventas";
            this.tsmi_mantenimientoVentas.Click += new System.EventHandler(this.cajasToolStripMenuItem_Click);
            // 
            // tsmi_mantenimientoUsuarios
            // 
            this.tsmi_mantenimientoUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mantenimientoUsuarios.Image")));
            this.tsmi_mantenimientoUsuarios.Name = "tsmi_mantenimientoUsuarios";
            this.tsmi_mantenimientoUsuarios.Size = new System.Drawing.Size(193, 22);
            this.tsmi_mantenimientoUsuarios.Text = "Usuarios";
            this.tsmi_mantenimientoUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // tsmi_mantenimientoEmpleados
            // 
            this.tsmi_mantenimientoEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mantenimientoEmpleados.Image")));
            this.tsmi_mantenimientoEmpleados.Name = "tsmi_mantenimientoEmpleados";
            this.tsmi_mantenimientoEmpleados.Size = new System.Drawing.Size(193, 22);
            this.tsmi_mantenimientoEmpleados.Text = "Empleados";
            this.tsmi_mantenimientoEmpleados.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // tsmi_mantenimientoCajaDiaria
            // 
            this.tsmi_mantenimientoCajaDiaria.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mantenimientoCajaDiaria.Image")));
            this.tsmi_mantenimientoCajaDiaria.Name = "tsmi_mantenimientoCajaDiaria";
            this.tsmi_mantenimientoCajaDiaria.Size = new System.Drawing.Size(193, 22);
            this.tsmi_mantenimientoCajaDiaria.Text = "Caja Diaria";
            this.tsmi_mantenimientoCajaDiaria.Click += new System.EventHandler(this.tsmi_mantenimientoCajaDiaria_Click);
            // 
            // tsmi_mantenimientoSecciones
            // 
            this.tsmi_mantenimientoSecciones.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mantenimientoSecciones.Image")));
            this.tsmi_mantenimientoSecciones.Name = "tsmi_mantenimientoSecciones";
            this.tsmi_mantenimientoSecciones.Size = new System.Drawing.Size(193, 22);
            this.tsmi_mantenimientoSecciones.Text = "Secciones";
            this.tsmi_mantenimientoSecciones.Click += new System.EventHandler(this.ubicacionesToolStripMenuItem_Click);
            // 
            // tsmi_cambiarUsuario
            // 
            this.tsmi_cambiarUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_cambiarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_cambiarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_cambiarUsuario.Image")));
            this.tsmi_cambiarUsuario.Name = "tsmi_cambiarUsuario";
            this.tsmi_cambiarUsuario.Size = new System.Drawing.Size(143, 20);
            this.tsmi_cambiarUsuario.Text = "Cambiar Usuario";
            this.tsmi_cambiarUsuario.Click += new System.EventHandler(this.tsmi_cambiarUsuario_Click);
            // 
            // tsmi_ventas
            // 
            this.tsmi_ventas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_ventas.BackColor = System.Drawing.SystemColors.Control;
            this.tsmi_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmi_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_ventas.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_ventas.Image")));
            this.tsmi_ventas.Name = "tsmi_ventas";
            this.tsmi_ventas.Size = new System.Drawing.Size(78, 20);
            this.tsmi_ventas.Text = "Ventas";
            this.tsmi_ventas.Click += new System.EventHandler(this.tsmi_ventas_Click);
            // 
            // testPrintToolStripMenuItem
            // 
            this.testPrintToolStripMenuItem.Name = "testPrintToolStripMenuItem";
            this.testPrintToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.testPrintToolStripMenuItem.Text = "Test Print";
            this.testPrintToolStripMenuItem.Click += new System.EventHandler(this.testPrintToolStripMenuItem_Click);
            // 
            // ss_mainStatusBar
            // 
            this.ss_mainStatusBar.Location = new System.Drawing.Point(0, 561);
            this.ss_mainStatusBar.Name = "ss_mainStatusBar";
            this.ss_mainStatusBar.Size = new System.Drawing.Size(895, 22);
            this.ss_mainStatusBar.TabIndex = 3;
            this.ss_mainStatusBar.Text = "statusStrip1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 583);
            this.Controls.Add(this.ss_mainStatusBar);
            this.Controls.Add(this.ms_mainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_mainMenu;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferreteria San Lorenzo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ms_mainMenu.ResumeLayout(false);
            this.ms_mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mantenimientoClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mantenimientoProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mantenimientoProveedores;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mantenimientoPedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_cambiarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmi_archivo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_archivoSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ventas;
        private System.Windows.Forms.StatusStrip ss_mainStatusBar;
        public System.Windows.Forms.ToolStripMenuItem tsmi_mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mantenimientoVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mantenimientoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mantenimientoEmpleados;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mantenimientoCajaDiaria;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mantenimientoSecciones;
        private System.Windows.Forms.ToolStripMenuItem testPrintToolStripMenuItem;
    }
}