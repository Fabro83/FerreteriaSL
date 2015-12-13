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
    public partial class FormaDePago : Form
    {
        public FormaDePago()
        {
            InitializeComponent();
            initialize();
        }

        void initialize()
        { 
            BD DBCon = new BD();
            cb_payingType.DataSource = DBCon.Read("SELECT * FROM type_formadepago");
            cb_payingType.DisplayMember = "nombre";
            cb_payingType.ValueMember = "id";
        }

        void loadConditionalComboBox(int type)
        {
            switch (type)
            { 
                case 1:
                    cb_extraParameters.Enabled = false;
                    break;
                case 2:
                    // AGREGAR VENTANA NUEVA PARA CARGAR CHEQUE
                    cb_extraParameters.Enabled = false;
                    break;
                case 3:                   
                case 4:
                    BD DBCon = new BD();        
                    cb_extraParameters.DataSource = DBCon.Read("SELECT * FROM tarjeta WHERE tipo_tarjeta = "+ (type - 3));
                    cb_extraParameters.DisplayMember = "nombre";
                    cb_extraParameters.Enabled = true;
                    break;
                case 5:
                    //ELEGIR CLIENTE
                    break;
                case 6:
                    // ELEGIR NOTA DE CREDITO
                    break;
            }
        }

        private void cb_payingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadConditionalComboBox(int.Parse((sender as ComboBox).SelectedIndex.ToString()) + 1);
        }

    }
}
