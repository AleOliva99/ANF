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
    public partial class Razones : Form
    {
        private MainForm MainF;
        public Razones(MainForm maianF)
        {
            InitializeComponent();
            MainF = maianF;
            errores = new List<string>();
        }

        private void Razones_Load(object sender, EventArgs e)
        {
            List<Empresa> empresas = Controller.GetEmpresas();
            int j = 0;
            int n = 0;
            foreach (Empresa empresa in empresas)
            {
                
                
                if(empresa.id != Controller.GetAdminEmpresa().id)
                {
                    if (MainF.GetUser().empresa.id == empresa.id)
                        j = n;
                    cBox_A_empresa.Items.Add(empresa.nombre);
                    cBox_B_empresa.Items.Add(empresa.nombre);
                    n++;
                }
                
            }

            cBox_A_empresa.SelectedIndex = j;
            cBox_B_empresa.SelectedIndex = j;
        }

        

        private void CalcularRazonesA()
        {
            razones_A.Rows.Clear();
            //Liquidez Corriente
            razones_A.Rows.Add(new DataGridViewRow());
            razones_A.Rows[razones_A.Rows.Count - 1].Cells[0].Value = "Liquidez Corriente";
            razones_A.Rows[razones_A.Rows.Count - 1].Cells[1].Value = Valid((Values("ACTIVOS CORRIENTES") / Values("PASIVO CORRIENTE")));

            //Razon rapida
            NewRowA("Razón rápida", Valid((Values("ACTIVOS CORRIENTES") - Values("INVENTARIO")) / Values("PASIVO CORRIENTE")));

            NewRowA("Razón de Capital de Trabajo", Valid(
                (Values("ACTIVOS CORRIENTES") - Values("PASIVO CORRIENTE"))/Values("ACTIVOS TOTALES")
                ));

            NewRowA("Razón de efectivo", Valid(
                (Values("EFECTIVO") + Values("VALORES DE CORTO PLAZO")) / Values("PASIVO CORRIENTE")
                ));

            NewRowA("Razón de Rotación de Inventario", Valid(
                Values("COSTO DE LAS VENTAS") / Values("INVENTARIO PROMEDIO")
                ));

            NewRowA("Razón de Días de Inventario", Valid(
                Values("INVENTARIO PROMEDIO") / (Values("COSTO DE LAS VENTAS") / 365.00f)
                ));

            NewRowA("Razón de Rotación de cuentas por cobrar", Valid(
                Values("VENTAS NETAS") / Values("PROMEDIO CUENTAS POR COBRAR COMERCIALES")
                ));

            NewRowA("Razón de periodo medio de cobranzas", Valid(
                (Values("PROMEDIO CUENTAS POR COBRAR COMERCIALES") * 365)/Values("VENTAS NETAS")
                ));

            NewRowA("Razón de Rotación de cuentas por pagar", Valid(
                Values("COMPRAS")/Values("PROMEDIO CUENTAS POR PAGAR COMERCIALES")
                ));


            NewRowA("Indice de rotación de activos totales", Valid(
                Values("VENTAS TOTALES")/Values("ACTIVO TOTAL PROMEDIO")
                ));
            NewRowA("Indice de rotación de activos fijos", Valid(
                Values("VENTAS TOTALES")/Values("ACTIVO FIJO NETO PROMEDIO")
                ));

            NewRowA("Indice de Margen Bruto", Valid(
                Values("UTILIDAD BRUTA")/Values("VENTAS")
                ));
            NewRowA("Indice de Margen Operativo", Valid(
                Values("UTILIDAD OPERATIVA")/Values("VENTAS")
                ));

            NewRowA("Grado de Endeudamiento", Valid(
                Values("PASIVO TOTAL") / Values("ACTIVO TOTAL")
                ));

            NewRowA("Grado de Propiedad", Valid(
                Values("PATRIMONIO") / Values("ACTIVO TOTAL")
                ));

            NewRowA("Razón de Endeudamiento Pat.", Valid(
                Values("PASIVO TOTAL")/Values("PATRIMONIO TOTAL")
                ));

            NewRowA("Razón de Cobertura de Gastos Financieros", Valid(
                Values("UTILIDADES ANTES DE INTERESES E IMPUESTOS")/ Values("GASTOS FINANCIEROS")
                ));

            NewRowA("Rentabilidad Neta del Patrimonio", Valid(
                Values("UTILIDAD NETA")/Values("PATRIMONIO PROMEDIO")
                ));

            NewRowA("Rentabilidad por Acción", Valid(
                Values("UTILIDAD NETA")/Values("NUMERO DE ACCIONES")
                ));

            NewRowA("Rentabilidad del Activo", Valid(
                Values("UTILIDAD NETA")/ Values("ACTIVO TOTAL PROMEDIO")
                ));

            NewRowA("Rentabilidad sobre ventas", Valid(
                Values("UTILIDAD NETA")/Values("VENTAS")
                ));
            NewRowA("Rentabilidad sobre inversion", Valid(
                (Values("INGRESOS") - Values("INVERSION"))/ Values("INVERSION")
                ));
        }

        private void CalcularRazonesB()
        {
            razones_B.Rows.Clear();
            //Liquidez Corriente
            razones_B.Rows.Add(new DataGridViewRow());
            razones_B.Rows[razones_B.Rows.Count - 1].Cells[0].Value = "Liquidez Corriente";
            razones_B.Rows[razones_B.Rows.Count - 1].Cells[1].Value = Valid((ValuesB("ACTIVOS CORRIENTES") / ValuesB("PASIVO CORRIENTE")));

            //Razon rapida
            NewRowB("Razón rápida", Valid((ValuesB("ACTIVOS CORRIENTES") - ValuesB("INVENTARIO")) / ValuesB("PASIVO CORRIENTE")));

            NewRowB("Razón de Capital de Trabajo", Valid(
                (ValuesB("ACTIVOS CORRIENTES") - ValuesB("PASIVO CORRIENTE")) / ValuesB("ACTIVOS TOTALES")
                ));

            NewRowB("Razón de efectivo", Valid(
                (ValuesB("EFECTIVO") + ValuesB("VALORES DE CORTO PLAZO")) / ValuesB("PASIVO CORRIENTE")
                ));

            NewRowB("Razón de Rotación de Inventario", Valid(
                ValuesB("COSTO DE LAS VENTAS") / ValuesB("INVENTARIO PROMEDIO")
                ));

            NewRowB("Razón de Días de Inventario", Valid(
                ValuesB("INVENTARIO PROMEDIO") / (ValuesB("COSTO DE LAS VENTAS") / 365.00f)
                ));

            NewRowB("Razón de Rotación de cuentas por cobrar", Valid(
                ValuesB("VENTAS NETAS") / ValuesB("PROMEDIO CUENTAS POR COBRAR COMERCIALES")
                ));

            NewRowB("Razón de periodo medio de cobranzas", Valid(
                (ValuesB("PROMEDIO CUENTAS POR COBRAR COMERCIALES") * 365) / ValuesB("VENTAS NETAS")
                ));

            NewRowB("Razón de Rotación de cuentas por pagar", Valid(
                ValuesB("COMPRAS") / ValuesB("PROMEDIO CUENTAS POR PAGAR COMERCIALES")
                ));


            NewRowB("Indice de rotación de activos totales", Valid(
                ValuesB("VENTAS TOTALES") / ValuesB("ACTIVO TOTAL PROMEDIO")
                ));
            NewRowB("Indice de rotación de activos fijos", Valid(
                ValuesB("VENTAS TOTALES") / ValuesB("ACTIVO FIJO NETO PROMEDIO")
                ));

            NewRowB("Indice de Margen Bruto", Valid(
                ValuesB("UTILIDAD BRUTA") / ValuesB("VENTAS")
                ));
            NewRowB("Indice de Margen Operativo", Valid(
                ValuesB("UTILIDAD OPERATIVA") / ValuesB("VENTAS")
                ));

            NewRowB("Grado de Endeudamiento", Valid(
                ValuesB("PASIVO TOTAL") / ValuesB("ACTIVO TOTAL")
                ));

            NewRowB("Grado de Propiedad", Valid(
                ValuesB("PATRIMONIO") / ValuesB("ACTIVO TOTAL")
                ));

            NewRowB("Razón de Endeudamiento Pat.", Valid(
                ValuesB("PASIVO TOTAL") / ValuesB("PATRIMONIO TOTAL")
                ));

            NewRowB("Razón de Cobertura de Gastos Financieros", Valid(
                ValuesB("UTILIDADES ANTES DE INTERESES E IMPUESTOS") / ValuesB("GASTOS FINANCIEROS")
                ));

            NewRowB("Rentabilidad Neta del Patrimonio", Valid(
                ValuesB("UTILIDAD NETA") / ValuesB("PATRIMONIO PROMEDIO")
                ));

            NewRowB("Rentabilidad por Acción", Valid(
                ValuesB("UTILIDAD NETA") / ValuesB("NUMERO DE ACCIONES")
                ));

            NewRowB("Rentabilidad del Activo", Valid(
                ValuesB("UTILIDAD NETA") / ValuesB("ACTIVO TOTAL PROMEDIO")
                ));

            NewRowB("Rentabilidad sobre ventas", Valid(
                ValuesB("UTILIDAD NETA") / ValuesB("VENTAS")
                ));
            NewRowB("Rentabilidad sobre inversion", Valid(
                (ValuesB("INGRESOS") - ValuesB("INVERSION")) / ValuesB("INVERSION")
                ));
        }

        private void NewRowA(string title, string valor)
        {
            razones_A.Rows.Add(new DataGridViewRow());
            razones_A.Rows[razones_A.Rows.Count - 1].Cells[0].Value = title;
            razones_A.Rows[razones_A.Rows.Count - 1].Cells[1].Value = valor;

        }
        private void NewRowB(string title, string valor)
        {
            razones_B.Rows.Add(new DataGridViewRow());
            razones_B.Rows[razones_B.Rows.Count - 1].Cells[0].Value = title;
            razones_B.Rows[razones_B.Rows.Count - 1].Cells[1].Value = valor;

        }

        private string Valid(float valor)
        {
            if (float.IsNaN(valor) || float.IsInfinity(valor))
                return "Dato invalido";
            else
                return valor.ToString();
        }

        public List<String> errores;
        private float Values(string nombre)
        {
             
            try
            {
                Cuenta cuenta = Controller.GetCuenta(nombre, int.Parse(tBox_A_year.Text), Controller.GetEmpresa(cBox_A_empresa.Text));
                if (cuenta.id != -1)
                    return cuenta.saldo;
                else
                {
                    errores.Add(nombre);
                    return 0;
                }
            }
            catch
            {
                errores.Add(nombre);
                return 0;
            }
        }

        private float ValuesB(string nombre)
        {
            try
            {
                Cuenta cuenta = Controller.GetCuenta(nombre, int.Parse(tBox_B_year.Text), Controller.GetEmpresa(cBox_B_empresa.Text));
                if (cuenta.id != -1)
                    return cuenta.saldo;
                else
                {
                    errores.Add(nombre);
                    return 0;
                }
            }
            catch
            {
                errores.Add(nombre);
                return 0;
            }
        }

        private void btt_calculateA_Click(object sender, EventArgs e)
        {
            CalcularRazonesA();
        }

        private void btt_calculate_B_Click(object sender, EventArgs e)
        {
            CalcularRazonesB();
        }

        private void btt_compare_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 22; i++)
            {
                razones_res.Rows.Add(new DataGridViewRow());
                razones_res.Rows[i].Cells[0].Value = Comparar(
                     razones_A.Rows[i].Cells[1].Value.ToString(),
                     razones_B.Rows[i].Cells[1].Value.ToString());
            }
        }

        private string Comparar(string A, string B)
        {
            if(float.TryParse(A, out float fA) && float.TryParse(B, out float fB))
            {
                return Controller.GetResultado(fA, fB);
            }
            else
            {
                return "Datos invalidos";
            }
        }
    }
}
