using System.Data;
using System.Windows.Forms;

namespace FerreteriaSL.Clases_Genericas
{
    static class DgvHelper
    {
        public static DataTable ToDataTable(DataGridView input)
        {
            DataTable output = new DataTable();
            foreach (DataGridViewColumn col in input.Columns)
            {
                output.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in input.Rows)
            {
                DataRow dRow = output.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                output.Rows.Add(dRow);
            }
            return output;
        }
    }
}
