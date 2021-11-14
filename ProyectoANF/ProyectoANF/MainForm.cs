using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace ProyectoANF
{
    public partial class MainForm : Form
    {
        private Usuario user;
        private List<Empresa> empresas;
        public MainForm(Usuario usuario, Form1 login)
        {
            InitializeComponent();
            user = usuario;
            Login = login;
        }

        private Form1 Login;
        private void MainForm_Load(object sender, EventArgs e)
        {
            tBox_usuario.Text = user.nombre;
            if (user.permiso > 0)
            {
                cBox_empresa.Text = user.empresa.nombre;
                cBox_empresa.Enabled = false;
                btt_newEmprise.Enabled = false;
                btt_newEmprise.Visible = false;
                if (user.permiso > 1)
                {
                    btt_newUser.Enabled = false;
                    btt_newUser.Visible = false;
                }
                else
                {
                    btt_newUser.Enabled = true;
                    btt_newUser.Visible = true;
                
                }
            }
            else
            {
                RecargarEmpresas();
                cBox_empresa.SelectedIndex = 0;
                btt_newUser.Enabled = true;
                btt_newUser.Visible = true;
                btt_newEmprise.Enabled = true;
                btt_newEmprise.Visible = true;
            }
        }

        public void RecargarEmpresas()
        {
            cBox_empresa.Items.Clear();
            empresas = Controller.GetEmpresas();
            foreach (Empresa empresa in empresas)
            {
                if (empresa.id != 0)
                    cBox_empresa.Items.Add(empresa.nombre);
            }
        }

        [System.Serializable]
        public class ItemExcel
        {
            public string empresa { get; set; }
            public string cuenta { get; set; }
            public string nombre { get; set; }
            public int year { get; set; }
            public float saldo { get; set; }
        }
        private SelectExcel selec;
        private void btt_Upload_Click(object sender, EventArgs e)
        {
            try
            {
                if(selec == null)
                    selec = new SelectExcel(this);
                selec.Show();
            }
            catch
            {
                selec = new SelectExcel(this);
                selec.Show();
            }
            selec.BringToFront();
        }

        public void ImportarDatos(string dataFile)
        {

            try
            {
                SLDocument SL = new SLDocument(dataFile);


                int column = 1;
                int row = 2;

                //SL.GetCellValueAsString(0, 0);
                List<ItemExcel> datos = new List<ItemExcel>();

                while (!string.IsNullOrWhiteSpace(SL.GetCellValueAsString(row, column)))
                {
                    List<string> values = new List<string>();
                    while (!string.IsNullOrWhiteSpace(SL.GetCellValueAsString(row, column)))
                    {
                        string a = SL.GetCellValueAsString(row, column);
                        values.Add(a);

                        column++;
                    }
                    datos.Add(new ItemExcel
                    {
                        empresa = values[0].ToString(),
                        cuenta = values[1].ToString(),
                        nombre = values[2].ToString(),
                        year = int.Parse(values[3]),
                        saldo = int.Parse(values[4]),
                    });
                    column = 1;
                    row++;
                }
                //datos.Remove(datos[datos.Count - 1]);
                DGV_Datos.Rows.Clear();
                for (int i = 0; i < datos.Count; i++)
                {
                    DGV_Datos.Rows.Add(new DataGridViewRow());
                    DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[0].Value = datos[i].empresa;
                    DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[1].Value = datos[i].cuenta;
                    DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[2].Value = datos[i].nombre;
                    DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[3].Value = datos[i].year;
                    DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[4].Value = datos[i].saldo;
                }
                MessageBox.Show("Importación terminada");
                selec = null;
            }
            catch (SystemException err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Close();
        }

        NuevoUsuario nuevoUsuario;
        private void btt_newUser_Click(object sender, EventArgs e)
        {
            try
            {
                if(nuevoUsuario == null)
                    nuevoUsuario = new NuevoUsuario(this.user);

                nuevoUsuario.Show();

            }
            catch
            {
                nuevoUsuario = new NuevoUsuario(this.user);
                nuevoUsuario.Show();
            }
            nuevoUsuario.BringToFront();
        }

        NuevaEmpresa nuevaEmpresa;
        private void btt_newEmprise_Click(object sender, EventArgs e)
        {
            try
            {
                if (nuevaEmpresa == null)
                    nuevaEmpresa = new NuevaEmpresa(this);
                nuevaEmpresa.Show();
                
            }
            catch
            {
                nuevaEmpresa = new NuevaEmpresa(this);
                nuevaEmpresa.Show();
            }
            nuevaEmpresa.BringToFront();
        }
    }
}
