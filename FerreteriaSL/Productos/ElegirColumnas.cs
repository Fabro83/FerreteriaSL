using System.Linq;
using System.Windows.Forms;

namespace FerreteriaSL.Productos
{
    public partial class ElegirColumnas : Form
    {
        DataGridViewColumnCollection _currentColumns;
        AdministrarStock _caller;
        string[] _untouchableColumns = { "pro_seccion_id", "id", "oculto", "id_proveedor" };

        public ElegirColumnas(DataGridViewColumnCollection currentColumns, AdministrarStock caller)
        {
            InitializeComponent();
            _currentColumns = currentColumns;
            _caller = caller;
            FillCheckListBox();
        }

        public void FillCheckListBox()
        {
            foreach (DataGridViewColumn sCol in _currentColumns)
            {
                if (!_untouchableColumns.Contains<string>(sCol.Name))
                {
                    cbl_columns.Items.Add(sCol, sCol.Visible);
                    cbl_columns.DisplayMember = "HeaderText";
                }
            }
        }

        private void cbl_columns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            (cbl_columns.Items[e.Index] as DataGridViewColumn).Visible = e.NewValue == CheckState.Checked ? true : false;
            _caller.ParseDataGrid();
        }
    }
}
