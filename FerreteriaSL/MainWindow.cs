using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FerreteriaSL
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Shown += new EventHandler(MainWindow_Shown);
            Usuario.UserChanged += new Usuario.UserChangedHandler(userHasChanged);
            Usuario.UserLogedOut += new EventHandler(Usuario_UserLogedOut);
        }

        void Usuario_UserLogedOut(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Text = "Ferreteria San Lorenzo";
            MainWindow_Shown(null, EventArgs.Empty);
        }

        private void userHasChanged(object sender, EventArgs e)
        {
            this.Text = "[" + Usuario.Name + "]" + " - Ferreteria San Lorenzo";
            managePrivilege();
        }

        private void managePrivilege()
        {
            // CAMBIAR PARA QUE SE ADAPTER DINAMICAMENTE A LA CANTIDAD DE OPCIONES Y PRIVILEGIOS [MainWindow.cs:37 | Usuario.cs:60 | Usuarios.cs:112]
            ToolStripMenuItem[] maintenanceControls = {tsmi_mantenimientoClientes,tsmi_mantenimientoProductos,
                                                       tsmi_mantenimientoProveedores,tsmi_mantenimientoPedidos,
                                                       tsmi_mantenimientoVentas,tsmi_mantenimientoUsuarios,
                                                       tsmi_mantenimientoEmpleados,tsmi_mantenimientoCajaDiaria,
                                                       tsmi_mantenimientoSecciones};

            this.Enabled = true;

            for (int i = 0; i < maintenanceControls.Length; i++)
            {
                maintenanceControls[i].Enabled = Usuario.Permissions[i];
            }
            OpenChild(new Ventas());

        }

        void MainWindow_Shown(object sender, EventArgs e)
        {
            Inicio Login = new Inicio(this);
            Login.Owner = this;
            Login.Show(this);
            this.Enabled = false;
            Login.Focus();
        }

        private void tsmi_mantenimientoClientes_Click(object sender, EventArgs e)
        {
            OpenChild(new Clientes());
        }

        private void tsmi_mantenimientoProductos_Click(object sender, EventArgs e)
        {
            OpenChild(new Administrar_Stock());
        }

        private void tsmi_mantenimientoProveedores_Click(object sender, EventArgs e)
        {
            OpenChild(new Proveedores());
        }

        private void tsmi_mantenimientoPedidos_Click(object sender, EventArgs e)
        {
            OpenChild(new Pedidos());
        }

        private void OpenChild(Form WinType)
        {
            WinType.MdiParent = this;
            WinType.Show();
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
                if (frm is Ventas)
                {
                    frm.Focus();
                    return;
                }
            }
            OpenChild(new Ventas());
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
            Cajas C = new Cajas();
            OpenChild(C);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios U = new Usuarios();
            OpenChild(U);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(new Empleados());
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
    
