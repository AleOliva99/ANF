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
    public partial class NuevaEmpresa : Form
    {
        MainForm main;

        public NuevaEmpresa(MainForm mainForm)
        {
            InitializeComponent();
            main = mainForm;
            Controller.Conexion.Close();
            List<Tipo> tipos = Controller.GetTipos();
            foreach(Tipo tipo in tipos)
            {
                if(tipo.id != 1)
                    cBox_type.Items.Add(tipo.tipo);
            }
            cBox_type.SelectedIndex = 0;
        }

        private void btt_save_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tBox_nombre.Text))
            {
                Empresa newEmpresa = new Empresa
                {
                    id = -1,
                    nombre = tBox_nombre.Text,
                    tipo = Controller.GetTipo(cBox_type.Text)
                };
                if (Controller.EmpresaExistente(newEmpresa.nombre))
                {
                    if (Controller.AddEmpresa(newEmpresa))
                    {
                        MessageBox.Show("Empresa " + newEmpresa.nombre + " agregada con exito");
                    }
                    else
                    {
                        MessageBox.Show("La empresa no pudo ser registrada");
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de empresa ya existente");
                }

            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre valido");
            }
        }

        private void NuevaEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.RecargarEmpresas();
        }
    }
}
