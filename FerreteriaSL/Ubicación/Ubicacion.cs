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
    public partial class Ubicacion : Form
    {
        public Ubicacion()
        {
            InitializeComponent();
            loadTreeView();
        }

        private void btn_addSection_Click(object sender, EventArgs e)
        {
            Nombre_Seccion NS = new Nombre_Seccion();
            if (NS.ShowDialog(this) == DialogResult.OK)
            {
                string newNodeName = NS.txb_name.Text.Trim().Replace("'","");
                string newNodeAbb = NS.txb_abb.Text.Trim().Replace("'", "").ToUpper();
                int newNodeLevel = tv_sections.SelectedNode != null ? tv_sections.SelectedNode.Level + 1 : 0;
                TreeNode newNodeParent = tv_sections.SelectedNode;
                if (!NodeAlreadyExists(newNodeName, newNodeAbb, int.Parse(newNodeParent.Name)))
                {
                    BD DBCon = new BD();
                    string query = String.Format("INSERT INTO PRO_SECCION (name,parent_node, level,abb) VALUES ('{0}',{1},{2},'{3}')", newNodeName, (newNodeParent != null ? newNodeParent.Name : "0"), newNodeLevel,newNodeAbb);
                    DBCon.Write(query);
                    string newNodeKey = DBCon.Read("SELECT * FROM PRO_SECCION ORDER BY id DESC LIMIT 1").Rows[0]["id"].ToString();
                    if (newNodeParent != null)
                    {
                        tv_sections.SelectedNode.Nodes.Add(newNodeKey, "[" + newNodeAbb + "] " + newNodeName);
                    }
                    else
                    {
                        tv_sections.Nodes.Add(newNodeKey, "[" + newNodeAbb + "] " + newNodeName);
                    }
                    
                }
                else
                {
                    MessageBox.Show("El nombre o abreviación elegido para la nueva sub-sección ya existe dentro de la sección seleccionada", "Nombre o abreviación ya registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
         
        }

        private void btn_deleteSection_Click(object sender, EventArgs e)
        {
            if (tv_sections.SelectedNode.Name == "1")
                return;
            BD DBcon = new BD();
            DBcon.Write("DELETE FROM PRO_SECCION WHERE id = " + tv_sections.SelectedNode.Name);
            tv_sections.SelectedNode.Remove();   
        }

        private void loadTreeView()
        {
            BD DBCon = new BD();
            string query = "SELECT * FROM PRO_SECCION ORDER BY level, id";
            DataTable treeViewDataTable = DBCon.Read(query);
            tv_sections.Nodes.Clear();
            List<TreeNode> insertedNodes = new List<TreeNode>();
            foreach (DataRow sRow in treeViewDataTable.Rows)
            {
                if (sRow["parent_node"].ToString() == "")
                {
                    insertedNodes.Add(tv_sections.Nodes.Add(sRow["id"].ToString(), "[" + sRow["abb"].ToString() + "] " + sRow["name"].ToString()));
                }
                else
                {
                    string parentNode = sRow["parent_node"].ToString();

                    TreeNode targetParentNode = insertedNodes.Find(d => d.Name == parentNode);

                    insertedNodes.Add(targetParentNode.Nodes.Add(sRow["id"].ToString(), "[" + sRow["abb"].ToString() + "] " + sRow["name"].ToString()));
                }
            }

        }

        private bool NodeAlreadyExists(string nodeName,string nodeAbb, int nodeParent)
        {
            BD DBCon = new BD();
            int res = int.Parse(DBCon.Read(String.Format("SELECT Count(*) FROM pro_seccion WHERE (name = '{0}' OR abb = '{1}') AND parent_node = {2}", nodeName, nodeAbb, nodeParent)).Rows[0][0].ToString());
            return res > 0 ? true : false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string selectedLocationName()
        {
            return tv_sections.SelectedNode.Text;
        }

        public int selectedLocationID()
        {
            return int.Parse(tv_sections.SelectedNode.Name);
        }

        private void btn_addItems_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Administrar_Stock)
                {
                    frm.Focus();
                    return;
                }
            }
            Administrar_Stock AS = new Administrar_Stock();
            AS.ShowInTaskbar = false;

            int height = Screen.FromControl(this).Bounds.Height / 2 - this.Size.Height / 2;
            this.Location = new Point(50, height);         
            AS.Show(this);
            AS.tc_productos.SelectedIndex = 1;
            AS.Height = this.Height;
            AS.Location = new Point(this.Location.X + this.Size.Width + 2, this.Location.Y + 45);                                  
        }

        private void tv_sections_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.BackColor = Color.Gold;          
        }

        private void tv_sections_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tv_sections.SelectedNode.BackColor = Color.White;
        }

    }
}
