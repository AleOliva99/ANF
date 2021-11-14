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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btt_Ingresar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tBox_username.Text) && !string.IsNullOrEmpty(tBox_password.Text))
            {
                Usuario User = Controller.AutentificarUsuario(tBox_username.Text, tBox_password.Text);
                if (User == null)
                {
                    MessageBox.Show("Error, Usuario o Contraseña invalidos");
                }
                else
                {
                    MessageBox.Show("Bienvenido " + User.nombre);
                    MainForm mainForm = new MainForm(User, this);
                    this.Hide(); 
                    mainForm.Show();
                    
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los datos");
            }
        }
    }
}
