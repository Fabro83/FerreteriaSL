using System;
using System.Windows.Forms;
using FerreteriaSL.Caja_Diaria;
using FerreteriaSL.Clases_Genericas;
using FerreteriaSL.Productos;
using FerreteriaSL.RegistroVentas;
using FerreteriaSL.Ubicación;

namespace FerreteriaSL
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Shown += MainWindow_Shown;
            Usuario.UserChanged += UserHasChanged;
            Usuario.UserLogedOut += Usuario_UserLogedOut;
        }

        void Usuario_UserLogedOut(object sender, EventArgs e)
        {
            Enabled = false;
            Text = "Ferreteria San Lorenzo";
            MainWindow_Shown(null, EventArgs.Empty);
        }

        private void UserHasChanged(object sender, EventArgs e)
        {
            Text = "[" + Usuario.Name + "]" + " - Ferreteria San Lorenzo";
            ManagePrivilege();
        }

        private void ManagePrivilege()
        {
            // CAMBIAR PARA QUE SE ADAPTER DINAMICAMENTE A LA CANTIDAD DE OPCIONES Y PRIVILEGIOS [MainWindow.cs:37 | Usuario.cs:60 | Usuarios.cs:112]
            ToolStripMenuItem[] maintenanceControls = {tsmi_mantenimientoClientes,tsmi_mantenimientoProductos,
                                                       tsmi_mantenimientoProveedores,tsmi_mantenimientoPedidos,
                                                       tsmi_mantenimientoVentas,tsmi_mantenimientoUsuarios,
                                                       tsmi_mantenimientoEmpleados,tsmi_mantenimientoCajaDiaria,
                                                       tsmi_mantenimientoSecciones};
            
            Enabled = true;

            for (int i = 0; i < maintenanceControls.Length; i++)
            {
                maintenanceControls[i].Enabled = Usuario.Permissions[i];
            }
            OpenChild(new Ventas.Ventas());

        }

        void MainWindow_Shown(object sender, EventArgs e)
        {
            Inicio login = new Inicio(this);
            login.Owner = this;
            login.Show(this);
            Enabled = false;
            login.Focus();
        }

        private void tsmi_mantenimientoClientes_Click(object sender, EventArgs e)
        {
            OpenChild(new Clientes.Clientes());
        }

        private void tsmi_mantenimientoProductos_Click(object sender, EventArgs e)
        {
            OpenChild(new AdministrarStock());
        }

        private void tsmi_mantenimientoProveedores_Click(object sender, EventArgs e)
        {
            OpenChild(new Proveedores.Proveedores());
        }

        private void tsmi_mantenimientoPedidos_Click(object sender, EventArgs e)
        {
            OpenChild(new Pedidos.Pedidos());
        }

        private void OpenChild(Form winType)
        {
            winType.MdiParent = this;
            winType.Show();
        }

        private void tsmi_archivoSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmi_ventas_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm is Ventas.Ventas)
                {
                    frm.Focus();
                    return;
                }
            }
            OpenChild(new Ventas.Ventas());
        }

        private void tsmi_cambiarUsuario_Click(object sender, EventArgs e)
        {
            Form[] formsToClose = new Form[0];
            int last = 0;
            
            foreach (Form sForm in Application.OpenForms)
            {
                if (!(sForm is MainWindow))
                {
                    Array.Resize<Form>(ref formsToClose, formsToClose.Length + 1);
                    formsToClose[last] = sForm;
                    last++;
                }
            }

            for (int i = 0; i < formsToClose.Length; i++)
            {
                formsToClose[i].Close();
            }

            Usuario.LogOut();
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cajas c = new Cajas();
            OpenChild(c);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.Usuarios u = new Usuarios.Usuarios();
            OpenChild(u);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(new Empleados.Empleados());
        }

        private void tsmi_mantenimientoCajaDiaria_Click(object sender, EventArgs e)
        {
            OpenChild(new CajaDiaria());
        }

        private void ubicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(new Ubicacion());
        }

        private void testPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
