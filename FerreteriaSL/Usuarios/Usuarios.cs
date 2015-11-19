using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Usuarios
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            LoadEmployeComboBox();
            LoadUserListBox();
            LoadPermissionsCheckedListBox();
        }

        private void LoadEmployeComboBox()
        {
            Bd dbCon = new Bd();
            cb_employe.DataSource = dbCon.Read("SELECT id, CONCAT(nombre,' ',apellido) as name FROM empleado");
            cb_employe.DisplayMember = "name";
        }

        private void LoadUserListBox()
        {
            Bd dbCon = new Bd();

            lb_users.DataSource = dbCon.Read("SELECT id,user FROM usuario WHERE id > 0");
            lb_users.DisplayMember = "user";
            lb_users.SelectedIndex = -1;
            ClearAllFields();
        }

        private void LoadPermissionsCheckedListBox()
        {
            Bd dbCon = new Bd();
            clb_permissions.DataSource = dbCon.Read("SELECT * FROM permiso");
            clb_permissions.DisplayMember = "area";
            clb_permissions.ClearSelected();
        }

        private void lb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_users.SelectedIndex != -1)
            {
                gb_userData.Enabled = true;
                int usuarioId = int.Parse((lb_users.SelectedItem as DataRowView)["id"].ToString());
                gb_userData.Text = "Datos de " + (lb_users.SelectedItem as DataRowView)["user"].ToString();

                Bd dbCon = new Bd();
                DataRow data = dbCon.Read("SELECT * FROM vista_datosUsuario WHERE id =" + usuarioId).Rows[0];

                LoadAllUserData(data);
            }
            else
            {
                gb_userData.Enabled = false;
            }           
        }

        private void ClearAllFields()
        {
            gb_userData.Text = "";
            tb_userName.Text = "";
            tb_password.Text = "";
            for (int i = 0; i < clb_permissions.Items.Count; i++)
            {
                clb_permissions.SetItemChecked(i, false);
            }
            clb_permissions.ClearSelected();

            cb_employe.SelectedIndex = 0;
            
        }

        private void LoadAllUserData(DataRow data)
        {
            ClearAllFields();
            tb_userName.Text = data["user"].ToString();
            tb_password.Text = data["pass"].ToString();
            int[] permissions =  ParsePermissions(int.Parse(data["privilegio"].ToString()));
            
            
            for(int i=0;i<clb_permissions.Items.Count;i++)
            {
                DataRowView castedItem = clb_permissions.Items[i] as DataRowView;
                if(permissions.Contains<int>(int.Parse(castedItem["id"].ToString())))
                {
                    clb_permissions.SetItemChecked(i, true);
                }
            }

            foreach (DataRowView sItem in cb_employe.Items)
            {
                if (sItem["id"].ToString() == data["empleado_id"].ToString())
                {
                    cb_employe.SelectedItem = sItem;
                }
            }

        }

        private int[] ParsePermissions(int privilege)
        { 
            int[] permissions = new int[0];
            int cont = 0;
            // CAMBIAR PARA QUE SE ADAPTER DINAMICAMENTE A LA CANTIDAD DE OPCIONES Y PRIVILEGIOS [MainWindow.cs:37 | Usuario.cs:60 | Usuarios.cs:112]
            for (int i = 9; i >= 1 && privilege > -1; i--) 
            {
                int currentNumber = Convert.ToInt32(Math.Pow(2, i));
                if (privilege - currentNumber > -1)
                {
                    Array.Resize<int>(ref permissions, permissions.Length + 1);
                    permissions[cont] = currentNumber;
                    cont++;
                    privilege -= currentNumber;

                }
            }

            return permissions;
        }

        private void cb_employe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int empleadoId = int.Parse((cb_employe.SelectedItem as DataRowView)["id"].ToString());
            if (empleadoId == 0)
            {
                lbl_employeNameValue.Text = "N/A";
                lbl_employeDNIValue.Text = "N/A";
                lbl_employeAddressValue.Text = "N/A";
                lbl_employePhoneValue.Text = "N/A";
                lbl_employePositionValue.Text = "N/A";
            }
            else
            {
                Bd dBcon = new Bd();
                DataRow data = dBcon.Read("SELECT * FROM empleado WHERE id =" + empleadoId).Rows[0];

                lbl_employeNameValue.Text = data["nombre"].ToString() + " " + data["apellido"].ToString();
                lbl_employeDNIValue.Text = data["dni"].ToString();
                lbl_employeAddressValue.Text = data["direccion"].ToString();
                lbl_employePhoneValue.Text = data["telefono"].ToString();
                lbl_employePositionValue.Text = data["cargo"].ToString();
            }          
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_togglePassword_Click(object sender, EventArgs e)
        {
            if (tb_password.UseSystemPasswordChar)
            {
                tb_password.UseSystemPasswordChar = false;
                btn_togglePassword.Text = "Ocultar";
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
                btn_togglePassword.Text = "Mostrar";
            }
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int usuarioId = int.Parse((lb_users.SelectedItem as DataRowView)["id"].ToString());
                Bd dBcon = new Bd();
                dBcon.Write("DELETE FROM usuario WHERE id = " + usuarioId);
                LoadUserListBox();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int usuId = int.Parse((lb_users.SelectedItem as DataRowView)["id"].ToString());
            string usuUser = tb_userName.Text.Trim();
            string usuPass = tb_password.Text.Trim();
            int usuEmpleadoId = int.Parse((cb_employe.SelectedItem as DataRowView)["id"].ToString());
            int usuPrivilegio = CalculatePrivilege();

            Bd dbCon = new Bd();
            string query = "UPDATE usuario SET user = '{0}',pass = '{1}', privilegio = {2}, empleado_id = {3} WHERE id = {4}";
            query = String.Format(query, usuUser, usuPass, usuPrivilegio, usuEmpleadoId, usuId);
            dbCon.Write(query);

            LoadUserListBox();
        }

        private int CalculatePrivilege()
        {
            int privilege = 0;

            foreach (object checkedItem in clb_permissions.CheckedItems)
            {
                DataRowView castedItem = checkedItem as DataRowView;
                privilege += int.Parse(castedItem["id"].ToString());
            }

            return privilege;
        }

        private void btn_addNewUSer_Click(object sender, EventArgs e)
        {
            AgregarNuevoUsuario anu = new AgregarNuevoUsuario();
            if (anu.ShowDialog(this) == DialogResult.OK)
            {
                string usuUser = anu.tb_userName.Text.Trim();
                string usuPass = anu.tb_userPassword.Text.Trim();
                Bd dbCon = new Bd();
                dbCon.Write(String.Format("INSERT INTO usuario (user, pass) VALUES ('{0}','{1}')",usuUser,usuPass));
                LoadUserListBox();
            }
        }

        private void RequiredFields_TextChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = tb_userName.Text.Trim().Length > 3 && tb_password.Text.Trim().Length > 3;
        }

        private void generic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_save.PerformClick();
        }
    }
}
