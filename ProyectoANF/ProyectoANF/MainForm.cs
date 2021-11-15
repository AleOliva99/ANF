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
        private List<ItemExcel> datos;
        public MainForm(Usuario usuario, Form1 login)
        {
            InitializeComponent();
            user = usuario;
            Login = login;
        }

        public Usuario GetUser() { return user; }

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

        private SelectExcel selec;
        private void btt_Upload_Click(object sender, EventArgs e)
        {
            if (Controller.CatalogoExists(Controller.GetEmpresa(cBox_empresa.Text).id))
            {
                try
                {
                    if (selec == null)
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
            else
            {
                MessageBox.Show("Antes de importar datos, por favor cree un Catalogo para su empresa");
            }
        }

        public void ImportarDatos(string dataFile)
        {

            try
            {
                SLDocument SL = new SLDocument(dataFile);


                int column = 1;
                int row = 2;

                //SL.GetCellValueAsString(0, 0);
                this.datos = new List<ItemExcel>();

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
                CargarDatos(this.datos);
                MessageBox.Show("Importación terminada");
                selec = null;
            }
            catch (SystemException err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void CargarDatos(List<ItemExcel> datas)
        {
            DGV_Datos.Rows.Clear();
            for (int i = 0; i < datas.Count; i++)
            {
                DGV_Datos.Rows.Add(new DataGridViewRow());
                DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[0].Value = datas[i].empresa;
                DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[1].Value = datas[i].cuenta;
                DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[2].Value = datas[i].nombre;
                DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[3].Value = datas[i].year;
                DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[4].Value = datas[i].saldo;
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

        private void button1_Click(object sender, EventArgs e)
        {
            AnalisisHorizontal analisisHorizontal = new AnalisisHorizontal(this.datos);
            analisisHorizontal.ShowDialog();
        }

        private GuardandoDatos savingData;
        public void EndSaveCatalogos()
        {
            savingData = null;
        }

        
        private void btt_saveData_Click(object sender, EventArgs e)
        {
            if (savingData == null)
            {
                if (DGV_Datos.Rows.Count != 0)
                {
                    List<Cuenta> cuentas = new List<Cuenta>();
                    for (int i = 0; i < DGV_Datos.Rows.Count; i++)
                    {
                        try
                        {

                            float cuentaCode = 0;
                            int cuentaId = 0;
                            if (!float.TryParse(DGV_Datos.Rows[i].Cells[1].Value.ToString(), out cuentaCode))
                            {
                                cuentaId = Controller.GetCatalogo(DGV_Datos.Rows[i].Cells[1].Value.ToString(), Controller.GetEmpresa(cBox_empresa.Text).id).id;
                            }
                            else
                            {
                                cuentaId = Controller.GetCatalogo(cuentaCode, Controller.GetEmpresa(cBox_empresa.Text).id).id;
                            }
                            cuentas.Add(new Cuenta
                            {
                                cuentaId = cuentaId,
                                year = int.Parse(DGV_Datos.Rows[i].Cells[3].Value.ToString()),
                                saldo = float.Parse(DGV_Datos.Rows[i].Cells[4].Value.ToString())
                            });
                            

                        }
                        catch(Exception es)
                        {
                            MessageBox.Show("Error con la cuenta de nombre " + DGV_Datos.Rows[i].Cells[2].Value.ToString() + "\n" + es.Message);
                        }
                    }
                    savingData = new GuardandoDatos(this);
                    savingData.Show();
                    savingData.Guardando(cuentas);
                }
                else
                {
                    MessageBox.Show("Datos vacios, favor subir datos primero");
                }
            }
            else
            {
                savingData.Show();
                savingData.BringToFront();
            }
            /*
            
            {
                if (DGV_Datos.Rows.Count != 0)
                {

                    List<Catalogo> catalogos = new List<Catalogo>();
                    for (int i = 0; i < DGV_Datos.Rows.Count; i++)
                    {
                        try
                        {
                            int cuentaN = 0;
                            if (!int.TryParse(DGV_Datos.Rows[i].Cells[1].Value.ToString(), out cuentaN))
                            {
                                cuentaN = Controller.GetCatalogoByName(DGV_Datos.Rows[i].Cells[1].Value.ToString());
                            }
                            Catalogo catalogoNew = new Catalogo
                            {
                                id = -1,
                                empresa = ((int.TryParse(DGV_Datos.Rows[i].Cells[0].Value.ToString(), out int empresId)) ?
                                Controller.GetEmpresa(empresId) : Controller.GetEmpresa(DGV_Datos.Rows[i].Cells[0].Value.ToString())),
                                cuenta = cuentaN,
                                cuentaEspecifica = -1,
                                nombre = DGV_Datos.Rows[i].Cells[2].Value.ToString(),
                                year = int.Parse(DGV_Datos.Rows[i].Cells[3].Value.ToString()),
                                saldo = float.Parse(DGV_Datos.Rows[i].Cells[4].Value.ToString())
                            };
                            catalogoNew.cuentaEspecifica = Controller.NextCatalogo(catalogoNew);
                            catalogos.Add(catalogoNew);
                        }
                        catch (System.Exception es)
                        {
                            MessageBox.Show("Error con la cuenta de nombre " + DGV_Datos.Rows[i].Cells[2].Value.ToString() + "\n" + es.Message);
                        }

                    }
                    savingData = new GuardandoDatos(this);
                    savingData.Show();
                    savingData.Guardando(catalogos);
                }
                else
                {
                    MessageBox.Show("Datos vacios, favor subir datos primero");
                }
            }
            else
            {
                savingData.Show();
                savingData.BringToFront();
            }
            */
        }

        private void btt_Load_Click(object sender, EventArgs e)
        {
            
        }

        NuevoCatalogo newCata;
        private void btt_NewCata_Click(object sender, EventArgs e)
        {
            if(!Controller.CatalogoExists(Controller.GetEmpresa(cBox_empresa.Text).id))
            {
                try
                {
                    if (newCata == null)
                        newCata = new NuevoCatalogo(this);
                    newCata.Show();
                }
                catch
                {
                    newCata = new NuevoCatalogo(this);
                    newCata.Show();
                }
                newCata.BringToFront();
            }
            else
            {
                MessageBox.Show("Ya existe un catalogo para esta empresa, si decide crear otro puede crear conflictos");
                try
                {
                    if (newCata == null)
                        newCata = new NuevoCatalogo(this);
                    newCata.Show();
                }
                catch
                {
                    newCata = new NuevoCatalogo(this);
                    newCata.Show();
                }
                newCata.BringToFront();
            }
        }
    }
}
