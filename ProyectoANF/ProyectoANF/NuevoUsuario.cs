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
    public partial class NuevoUsuario : Form
    {
        private List<Empresa> empresas;
        Usuario usuario;
        public NuevoUsuario(Usuario user)
        {
            InitializeComponent();
            usuario = user;
            if (user.permiso > 0)
            {
                cBox_empresa.Text = user.empresa.nombre;
                cBox_empresa.Enabled = false;
                cBox_permiso.Items.Add("Administrador de empresa");
                cBox_permiso.Items.Add("Empleado");
                cBox_permiso.SelectedIndex = 0;
            }
            else
            {
                empresas = Controller.GetEmpresas();
                foreach (Empresa empresa in empresas)
                {
                    cBox_empresa.Items.Add(empresa.nombre);
                }
                cBox_empresa.SelectedIndex = 0;
                cBox_permiso.Items.Add("Administrador de app");
                cBox_permiso.SelectedIndex = 0;
                cBox_permiso.Enabled = false;

            }

            
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void cBox_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(usuario.empresa.id == Controller.GetAdminEmpresa().id)
            {
                if(cBox_empresa.Text.ToLower() == usuario.empresa.nombre.ToLower())
                {
                    try
                    {
                        cBox_permiso.Items.Clear();
                        cBox_permiso.Items.Add("Administrador de app");
                        cBox_permiso.SelectedIndex = 0;
                    }
                    catch
                    {

                    }
                    cBox_permiso.Enabled = false;
                }
                else
                {
                    cBox_permiso.Items.Clear();
                    cBox_permiso.Items.Add("Administrador de empresa");
                    cBox_permiso.Items.Add("Empleado");
                    cBox_permiso.SelectedIndex = 0;
                    cBox_permiso.Enabled = true;
                }
            }
        }

        private void btt_singin_Click(object sender, EventArgs e)
        {
            int permiso = -1;

            switch(cBox_permiso.Text)
            {
                case "Administrador de app":
                    permiso = 0;
                    break;

                case "Administrador de empresa":
                    permiso = 1;
                    break;

                case "Empleado":
                    permiso = 2;
                    break;
            }

            Usuario newUser = new Usuario
            {
                id = -1,
                username = tBox_userName.Text,
                password = tBox_password.Text,
                nombre = tBox_nombre.Text,
                empresa = Controller.GetEmpresa(cBox_empresa.Text),
                permiso = permiso
                
            };

            if(Controller.UsuarioExistente(newUser.username))
            {
                if(Controller.AddUsuario(newUser))
                {
                    MessageBox.Show("Usuario registrado con exito");
                }
                else
                {
                    MessageBox.Show("Error en el registro de usuario");
                }
            }
            else
            {
                MessageBox.Show("Nombre de Usuario ya existente");
            }
        }

        private void NuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
