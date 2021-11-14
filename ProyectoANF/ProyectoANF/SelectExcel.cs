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
    public partial class SelectExcel : Form
    {
        private MainForm MF;
        public SelectExcel(MainForm mainForm)
        {
            InitializeComponent();
            MF = mainForm;
        }

        private void btt_Select_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.InitialDirectory = "C:/";
            archivo.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            archivo.RestoreDirectory = true;
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                filePath = archivo.FileName;
                MF.ImportarDatos(filePath);
                this.Close();
            }
        }

        private void btt_create_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = true;
            
            string path;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                
                SLDocument archivo = new SLDocument();
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Empresa", typeof(string));
                tabla.Columns.Add("Cuenta", typeof(string));
                tabla.Columns.Add("Nombre", typeof(string));
                tabla.Columns.Add("Año", typeof(string));
                tabla.Columns.Add("Saldo", typeof(string));
                archivo.ImportDataTable(1, 1, tabla, true);
                bool cop = false;
                while (cop == false)
                {
                    int pos = 0;
                    try
                    {
                        string nombre = "Plantilla" + ((pos == 0) ? "" : pos.ToString());

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
    }
}
