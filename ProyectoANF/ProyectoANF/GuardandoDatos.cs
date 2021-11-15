using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoANF
{
    public partial class GuardandoDatos : Form
    {
        public MainForm MainF;
        public GuardandoDatos(MainForm mainF)
        {
            InitializeComponent();
            MainF = mainF;
        }

        private void GuardandoDatos_Load(object sender, EventArgs e)
        {

        }

        public void Guardando(List<Catalogo> catalogos)
        {
            int step = 100 / catalogos.Count;
            pBar_saving.Value = 0;
            foreach (Catalogo catalogo in catalogos)
            {
                if (MainF.GetUser().empresa.id == Controller.GetAdminEmpresa().id || MainF.GetUser().empresa.id == catalogo.empresa.id)
                {
                    if (!Controller.AddCatalogo(catalogo))
                    {
                        MessageBox.Show("Error agregando " + catalogo.nombre + ", se seguira con el resto");
                    }
                    lbl_nombre.Text = catalogo.nombre;
                    lbl_cuenta.Text = catalogo.GetCode().ToString();
                    lbl_empresa.Text = catalogo.empresa.nombre;
                    lbl_saldo.Text = catalogo.saldo.ToString();
                    lbl_year.Text = catalogo.year.ToString();
                    pBar_saving.Value += step;
                }
                else
                {
                    lbl_nombre.Text = catalogo.nombre;
                    lbl_cuenta.Text = catalogo.GetCode().ToString();
                    lbl_empresa.Text = catalogo.empresa.nombre;
                    lbl_saldo.Text = catalogo.saldo.ToString();
                    lbl_year.Text = catalogo.year.ToString();
                    pBar_saving.Value += step;
                    MessageBox.Show("Error: La empresa no corresponde a su correspondiente empresa, se omitirá y seguira con el resto");
                }
            }
            pBar_saving.Value = 100;
            MessageBox.Show("Cuentas agregadas");
            MainF.EndSaveCatalogos();
            this.Close();
        }

        private void lbl_empresa_Click(object sender, EventArgs e)
        {

        }
    }
}
