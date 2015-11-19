using System;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Ventas
{
    public partial class FormaDePago : Form
    {
        public FormaDePago()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        { 
            Bd dbCon = new Bd();
            cb_payingType.DataSource = dbCon.Read("SELECT * FROM type_formadepago");
            cb_payingType.DisplayMember = "nombre";
            cb_payingType.ValueMember = "id";
        }

        void LoadConditionalComboBox(int type)
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
                    Bd dbCon = new Bd();        
                    cb_extraParameters.DataSource = dbCon.Read("SELECT * FROM tarjeta WHERE tipo_tarjeta = "+ (type - 3));
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
            LoadConditionalComboBox(int.Parse((sender as ComboBox).SelectedIndex.ToString()) + 1);
        }

    }
}
