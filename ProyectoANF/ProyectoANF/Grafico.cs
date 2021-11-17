using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoANF
{
    public partial class Grafico : Form
    {
        MainForm MainF;
        public Grafico(MainForm mainF)
        {
            InitializeComponent();
            MainF = mainF;
        }

        private void btt_graficar_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            if(int.TryParse(tBox_start.Text, out int start) && int.TryParse(tBox_end.Text, out int end))
            {
                int margen = Math.Abs(end - start) + 1;
                string[] series = new string[margen];
                for(int i = start; i <= end; i++)
                {
                    series[i - start] = (start + (i - start)).ToString("0000");
                }
                int CuentaId = Controller.GetCatalogo(tBox_cuenta.Text.ToUpper(), MainF.GetEmpresaUser().id).id;
                if (CuentaId != -1)
                {
                    float[] puntos = new float[series.Length];
                    for (int i = 0; i < series.Length; i++)
                    {
                        puntos[i] = Controller.GetCuenta(CuentaId, int.Parse(series[i])).saldo;
                    }

                    for (int i = 0; i < series.Length; i++)
                    {
                        Series serie = chart.Series.Add(series[i]);
                        serie.Label = puntos[i].ToString();
                        serie.Points.Add(puntos[i]);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Cuenta no encontrada");
                }
            }
            else
            {
                MessageBox.Show("Error, por favor introduzca numeros naturales");
            }
        }
    }
}
