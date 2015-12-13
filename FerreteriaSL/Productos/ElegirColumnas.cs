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
    public partial class ElegirColumnas : Form
    {
        DataGridViewColumnCollection currentColumns;
        Administrar_Stock caller;
        string[] untouchableColumns = { "pro_seccion_id", "id", "oculto", "id_proveedor" };

        public ElegirColumnas(DataGridViewColumnCollection currentColumns, Administrar_Stock caller)
        {
            InitializeComponent();
            this.currentColumns = currentColumns;
            this.caller = caller;
            fillCheckListBox();
        }

        public void fillCheckListBox()
        {
            foreach (DataGridViewColumn sCol in currentColumns)
            {
                if (!untouchableColumns.Contains<string>(sCol.Name))
                {
                    cbl_columns.Items.Add(sCol, sCol.Visible);
                    cbl_columns.DisplayMember = "HeaderText";
                }
            }
        }

        private void cbl_columns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            (cbl_columns.Items[e.Index] as DataGridViewColumn).Visible = e.NewValue == CheckState.Checked ? true : false;
            caller.ParseDataGrid();
        }
    }
}
