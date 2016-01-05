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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            loadEmployeComboBox();
            loadUserListBox();
            loadPermissionsCheckedListBox();
        }

        private void loadEmployeComboBox()
        {
            BD DBCon = new BD();
            cb_employe.DataSource = DBCon.Read("SELECT id, CONCAT(nombre,' ',apellido) as name FROM empleado");
            cb_employe.DisplayMember = "name";
        }

        private void loadUserListBox()
        {
            BD DBCon = new BD();

            lb_users.DataSource = DBCon.Read("SELECT id,user FROM usuario WHERE id > 0");
            lb_users.DisplayMember = "user";
            lb_users.SelectedIndex = -1;
            clearAllFields();
        }

        private void loadPermissionsCheckedListBox()
        {
            BD DBCon = new BD();
            clb_permissions.DataSource = DBCon.Read("SELECT * FROM permiso");
            clb_permissions.DisplayMember = "area";
            clb_permissions.ClearSelected();
        }

        private void lb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_users.SelectedIndex != -1)
            {
                gb_userData.Enabled = true;
                int usuario_id = int.Parse((lb_users.SelectedItem as DataRowView)["id"].ToString());
                gb_userData.Text = "Datos de " + (lb_users.SelectedItem as DataRowView)["user"].ToString();

                BD DBCon = new BD();
                DataRow data = DBCon.Read("SELECT * FROM vista_datosUsuario WHERE id =" + usuario_id).Rows[0];

                loadAllUserData(data);
            }
            else
            {
                gb_userData.Enabled = false;
            }           
        }

        private void clearAllFields()
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

        private void loadAllUserData(DataRow data)
        {
            clearAllFields();
            tb_userName.Text = data["user"].ToString();
            tb_password.Text = data["pass"].ToString();
            int[] permissions =  parsePermissions(int.Parse(data["privilegio"].ToString()));
            
            
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

        private int[] parsePermissions(int privilege)
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
            int empleado_id = int.Parse((cb_employe.SelectedItem as DataRowView)["id"].ToString());
            if (empleado_id == 0)
            {
                lbl_employeNameValue.Text = "N/A";
                lbl_employeDNIValue.Text = "N/A";
                lbl_employeAddressValue.Text = "N/A";
                lbl_employePhoneValue.Text = "N/A";
                lbl_employePositionValue.Text = "N/A";
            }
            else
            {
                BD DBcon = new BD();
                DataRow data = DBcon.Read("SELECT * FROM empleado WHERE id =" + empleado_id).Rows[0];

                lbl_employeNameValue.Text = data["nombre"].ToString() + " " + data["apellido"].ToString();
                lbl_employeDNIValue.Text = data["dni"].ToString();
                lbl_employeAddressValue.Text = data["direccion"].ToString();
                lbl_employePhoneValue.Text = data["telefono"].ToString();
                lbl_employePositionValue.Text = data["cargo"].ToString();
            }          
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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
                int usuario_id = int.Parse((lb_users.SelectedItem as DataRowView)["id"].ToString());
                BD DBcon = new BD();
                DBcon.Write("DELETE FROM usuario WHERE id = " + usuario_id);
                loadUserListBox();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int usu_id = int.Parse((lb_users.SelectedItem as DataRowView)["id"].ToString());
            string usu_user = tb_userName.Text.Trim();
            string usu_pass = tb_password.Text.Trim();
            int usu_empleado_id = int.Parse((cb_employe.SelectedItem as DataRowView)["id"].ToString());
            int usu_privilegio = calculatePrivilege();

            BD DBCon = new BD();
            string query = "UPDATE usuario SET user = '{0}',pass = '{1}', privilegio = {2}, empleado_id = {3} WHERE id = {4}";
            query = String.Format(query, usu_user, usu_pass, usu_privilegio, usu_empleado_id, usu_id);
            DBCon.Write(query);

            loadUserListBox();
        }

        private int calculatePrivilege()
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
            AgregarNuevoUsuario ANU = new AgregarNuevoUsuario();
            if (ANU.ShowDialog(this) == DialogResult.OK)
            {
                string usu_user = ANU.tb_userName.Text.Trim();
                string usu_pass = ANU.tb_userPassword.Text.Trim();
                BD DBCon = new BD();
                DBCon.Write(String.Format("INSERT INTO usuario (user, pass) VALUES ('{0}','{1}')",usu_user,usu_pass));
                loadUserListBox();
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
