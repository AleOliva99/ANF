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
    public partial class NuevoCatalogo : Form
    {
        private MainForm Main;
        public NuevoCatalogo(MainForm MainF)
        {
            InitializeComponent();
            Main = MainF;
        }

        private void btt_catagPlantilla_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = true;

            string path;
            if (folder.ShowDialog() == DialogResult.OK)
            {

                SLDocument archivo = new SLDocument();
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Codigo", typeof(string));
                tabla.Columns.Add("Nombre", typeof(string));
                archivo.ImportDataTable(1, 1, tabla, true);
                bool cop = false;
                while (cop == false)
                {
                    int pos = 0;
                    try
                    {
                        string nombre = "Catalogo_Plantilla" + ((pos == 0) ? "" : pos.ToString());

                        path = folder.SelectedPath + "/" + nombre + ".xlsx";
                        archivo.SaveAs(path);
                        cop = true;
                    }
                    catch
                    {
                        pos++;
                    }
                }

                MessageBox.Show("Plantilla creada en " + folder.SelectedPath);
            }
        }

        [System.Serializable]
        public class CuentasCatalogo
        {
            public float codigo { get; set; }
            public string nombre { get; set; }
        }
        private void btt_catagLoad_Click(object sender, EventArgs e)
        {
            string dataFile = "";
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.InitialDirectory = "C:/";
            archivo.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            archivo.RestoreDirectory = true;
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                dataFile = archivo.FileName;

                try
                {
                    SLDocument SL = new SLDocument(dataFile);


                    int column = 1;
                    int row = 2;

                    //SL.GetCellValueAsString(0, 0);
                    List < Catalogo > catags = new List<Catalogo>();

                    while (!string.IsNullOrWhiteSpace(SL.GetCellValueAsString(row, column)))
                    {
                        List<string> values = new List<string>();
                        while (!string.IsNullOrWhiteSpace(SL.GetCellValueAsString(row, column)))
                        {
                            string a = SL.GetCellValueAsString(row, column);
                            values.Add(a);

                            column++;
                        }
                        catags.Add(new Catalogo
                        {
                            cuenta = float.Parse(values[0].ToString()),
                            nombre = values[1].ToString().ToUpper(),
                            empresa = Main.GetUser().empresa
                        });
                        column = 1;
                        row++;
                    }
                    Controller.CreateNewCatalogo(catags);
                    //datos.Remove(datos[datos.Count - 1]);
                    MessageBox.Show("Catalogo importado para la empresa");
                }
                catch (SystemException err)
                {
                    MessageBox.Show(err.ToString());
                }

                this.Close();
            }
        }
    }
}
