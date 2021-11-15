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
    public partial class AnalisisHorizontal : Form
    {

        private List<ItemExcel> datos;
        private List<Analisis> datosAnalisis = new List<Analisis>();

        public class Analisis
        {

            public Analisis(String cuenta, int anioAnterior, int anioSiguiente, float saldoAnterior, float saldoSiguiente)
            {
                this.cuenta = cuenta;
                this.anioAnterior = anioAnterior;
                this.anioSiguiente = anioSiguiente;
                this.saldoAnterior = saldoAnterior;
                this.saldoSiguiente = saldoSiguiente;
            }

            public string cuenta { get; set; }
            public int anioAnterior { get; set; }
            public int anioSiguiente { get; set; }
            public float saldoAnterior { get; set; }
            public float saldoSiguiente { get; set; }
        }

        public AnalisisHorizontal(List<ItemExcel> items)
        {
            InitializeComponent();
            datos = items;
        }

        private void AnalisisHorizontal_Load(object sender, EventArgs e)
        {
            int anioAnterior = 0, anioSiguiente = 0;
            List<String> cuentas = this.datos.GroupBy(i => i.cuenta).Select(x => x.First().cuenta).ToList();
            for (int i = 0; i < cuentas.Count; i++)
            {
                List<ItemExcel> saldo = this.datos.FindAll(j => j.cuenta == cuentas[i]);
                saldo = saldo.OrderByDescending(j => j.year).ToList();
                anioAnterior = saldo[1].year;
                anioSiguiente = saldo[0].year;
                Analisis analisis = new Analisis(saldo[0].cuenta, saldo[1].year, saldo[0].year, saldo[1].saldo, saldo[0].saldo);
                this.datosAnalisis.Add(analisis);
            }            

            DGV_Datos.Rows.Clear();
            DGV_Datos.Columns[1].HeaderText = anioAnterior.ToString();
            DGV_Datos.Columns[2].HeaderText = anioSiguiente.ToString();
            DGV_Datos.Columns[3].HeaderText = "Variacion absoluta";
            DGV_Datos.Columns[4].HeaderText = "Variacion relativa";
            for (int i = 0; i < datosAnalisis.Count; i++)
            {
                float varAbsoluta = datosAnalisis[i].saldoSiguiente - datosAnalisis[i].saldoAnterior;
                DGV_Datos.Rows.Add(new DataGridViewRow());
                DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[0].Value = datosAnalisis[i].cuenta;
                DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[1].Value = "$" + datosAnalisis[i].saldoAnterior;
                DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[2].Value = "$" + datosAnalisis[i].saldoSiguiente;
                DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[3].Value = "$" + varAbsoluta;
                DGV_Datos.Rows[DGV_Datos.Rows.Count - 1].Cells[4].Value = varAbsoluta / datosAnalisis[i].saldoAnterior;
            }
        }           
            
    }
}
