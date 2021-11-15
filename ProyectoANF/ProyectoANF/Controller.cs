using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace ProyectoANF
{
    public static class Controller
    {

        public static MySqlConnection Conexion;

        private static bool Conectar()
        {
            if (Conexion == null)
            {
                try
                {
                    Conexion = new MySqlConnection("server=localhost; database=anf; user id=root; password=root");
                    //Conexion = new SqlConnection("server=.\\SQLEXPRESS ; database=ANF ; integrated security = true");
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }
            }
            else
            {
                return true;
            }
        }


        #region CRUD Usuario

        public static Usuario AutentificarUsuario(string user, string password)
        {
            Usuario oUsuario = new Usuario();

            if (Conectar())
            {
                Conexion.Open();


                MySqlCommand comando = new MySqlCommand("SELECT * FROM Usuario WHERE username = '" + user + "' AND contrasena = '" + password + "'", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {
                    int idEmpresa = int.Parse(data["empresaId"].ToString());
                    oUsuario = new Usuario
                    {
                        id = int.Parse(data["id"].ToString()),
                        username = data["username"].ToString(),
                        password = data["contrasena"].ToString(),
                        //                        empresa = GetEmpresa(),
                        permiso = int.Parse(data["permiso"].ToString()),
                        nombre = data["nombre"].ToString()
                    };

                    Conexion.Close();
                    //oUsuario.empresa = GetEmpresa(int.Parse(data["empresaId"].ToString()));
                    return new Usuario
                    {
                        id = oUsuario.id,
                        username = oUsuario.username,
                        password = oUsuario.password,
                        permiso = oUsuario.permiso,
                        nombre = oUsuario.nombre,
                        empresa = GetEmpresa(idEmpresa)

                    };
                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
                return null;
        }

        public static bool UsuarioExistente(string user)
        {
            if (Conectar())
            {
                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Usuario WHERE username = '" + user + "'", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                bool libre = !data.Read();
                Conexion.Close();
                return libre;

            }
            else
                return false;

        }

        public static bool AddUsuario(Usuario user)
        {
            if (Conectar())
            {

                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("INSERT INTO Usuario (username, contrasena, empresaId, permiso, nombre) VALUES ('" +
                    user.username + "', '" + user.password + "', " + user.empresa.id + ", " + user.permiso + ", '" + user.nombre + "')", Conexion);
                try
                {
                    comando.ExecuteReader();
                    Conexion.Close();
                    return true;
                }
                catch
                {
                    Conexion.Close();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region CRUD Empresa

        public static Empresa GetEmpresa(int id)
        {

            Empresa oEmpresa = new Empresa();

            if (Conectar())
            {

                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Empresa WHERE id = " + id, Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {
                    int idTipo = int.Parse(data["tipoId"].ToString());
                    oEmpresa = new Empresa
                    {
                        id = int.Parse(data["id"].ToString()),
                        nombre = data["nombre"].ToString(),
                        //tipo = GetTipo(int.Parse(data["tipoId"].ToString()))
                    };

                    Conexion.Close();
                    //oEmpresa.tipo = GetTipo(int.Parse(data["tipoId"].ToString()));
                    return new Empresa
                    {
                        id = oEmpresa.id,
                        nombre = oEmpresa.nombre,
                        tipo = GetTipo(idTipo)
                    };
                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
            {
                return null;
            }
        }
        public static Empresa GetEmpresa(string nombre)
        {

            Empresa oEmpresa = new Empresa();

            if (Conectar())
            {

                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Empresa WHERE nombre = '" + nombre + "'", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {
                    int idTipo = int.Parse(data["tipoId"].ToString());
                    oEmpresa = new Empresa
                    {
                        id = int.Parse(data["id"].ToString()),
                        nombre = data["nombre"].ToString(),
                        //tipo = GetTipo(int.Parse(data["tipoId"].ToString()))
                    };

                    Conexion.Close();
                    //oEmpresa.tipo = GetTipo(int.Parse(data["tipoId"].ToString()));
                    return new Empresa
                    {
                        id = oEmpresa.id,
                        nombre = oEmpresa.nombre,
                        tipo = GetTipo(idTipo)
                    };
                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
            {
                return null;
            }
        }

        public static Empresa GetAdminEmpresa()
        {
            return GetEmpresas()[0];
        }
        public static List<Empresa> GetEmpresas()
        {
            List<Empresa> oEmpresas = new List<Empresa>();
            List<int> idTipos = new List<int>();

            if (Conectar())
            {

                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Empresa", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {
                    do
                    {
                        oEmpresas.Add(new Empresa
                        {
                            id = int.Parse(data["id"].ToString()),
                            nombre = data["nombre"].ToString(),

                        });
                        idTipos.Add(int.Parse(data["tipoId"].ToString()));
                    } while (data.Read());
                    Conexion.Close();
                    List<Empresa> Empresas = new List<Empresa>();
                    int n = 0;
                    foreach (Empresa empresa in oEmpresas)
                    {
                        Empresas.Add(new Empresa
                        {
                            id = empresa.id,
                            nombre = empresa.nombre,
                            tipo = GetTipo(idTipos[n])
                        });
                        n++;
                    }
                    return Empresas;
                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
            {
                return null;
            }
        }

        public static bool EmpresaExistente(string emprise)
        {
            if (Conectar())
            {
                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Empresa WHERE nombre = '" + emprise + "'", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                bool libre = !data.Read();
                Conexion.Close();
                return libre;

            }
            else
                return false;

        }
        public static bool AddEmpresa(Empresa emprise)
        {
            if (Conectar())
            {

                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("INSERT INTO Empresa (nombre, tipoId) VALUES ('" +
                    emprise.nombre + "', " + emprise.tipo.id + ")", Conexion);
                try
                {
                    comando.ExecuteReader();
                    Conexion.Close();
                    return true;
                }
                catch (SystemException e)
                {
                    Conexion.Close();
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region CRUD TIPO

        public static List<Tipo> GetTipos()
        {

            List<Tipo> oTipos = new List<Tipo>();

            if (Conectar())
            {
                Conexion.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Tipo", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {
                    do
                    {
                        oTipos.Add(new Tipo
                        {
                            id = int.Parse(data["id"].ToString()),
                            tipo = data["tipo"].ToString(),
                            descripcion = data["descripción"].ToString()

                        });
                    } while (data.Read());
                    Conexion.Close();
                    return oTipos;
                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
            {
                return null;
            }

        }
        public static Tipo GetTipo(int id)
        {
            Tipo oTipo = new Tipo();

            if (Conectar())
            {

                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Tipo WHERE id = " + id, Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {

                    oTipo = new Tipo
                    {
                        id = int.Parse(data["id"].ToString()),
                        tipo = data["tipo"].ToString(),
                        descripcion = data["descripción"].ToString()
                    };

                    Conexion.Close();
                    return oTipo;
                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
                return null;
        }

        public static Tipo GetTipo(string tipo)
        {
            Tipo oTipo = new Tipo();

            if (Conectar())
            {

                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Tipo WHERE tipo = '" + tipo + "'", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {

                    oTipo = new Tipo
                    {
                        id = int.Parse(data["id"].ToString()),
                        tipo = data["tipo"].ToString(),
                        descripcion = data["descripción"].ToString()
                    };

                    Conexion.Close();
                    return oTipo;
                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
                return null;
        }
        #endregion

        #region CRUD Catalogo

        private static bool AutentificarCatalogo(Catalogo catalogo)
        {
            if (Conectar())
            {
                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Catalogo WHERE (empresaId = " +
                    catalogo.empresa.id + " AND cuenta = " + catalogo.cuenta + " AND nombre = '" +
                    catalogo.nombre + "' AND anio = " + catalogo.year + ")", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                bool libre = !data.Read();
                Conexion.Close();
                return libre;
            }
            else
            {
                return false;
            }
        }

        public static bool AddCatalogo(Catalogo catalogo)
        {


            if (Conectar())
            {

                if (AutentificarCatalogo(catalogo))
                {
                    Conexion.Open();

                    MySqlCommand comando = new MySqlCommand("INSERT INTO Catalogo(empresaId, cuenta, cuentaEspecifica, nombre, anio, saldo) VALUES (" +
                        +catalogo.empresa.id + ", " + catalogo.cuenta + ", " + catalogo.cuentaEspecifica + ", '" + catalogo.nombre + "', " + catalogo.year + ", " + catalogo.saldo + ")", Conexion);
                    try
                    {
                        MySqlDataReader data = comando.ExecuteReader();
                        Conexion.Close();
                        return true;
                    }
                    catch
                    {
                        Conexion.Close();
                        return false;
                    }
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("El catalogo " + catalogo.nombre + " ya existe, ¿desea actualizar los valores de saldo? (valor actual: )", "Catalogo existente", MessageBoxButtons.OKCancel);
                    if (dialog == DialogResult.OK)
                    {
                        MySqlCommand comando = new MySqlCommand("UPDATE Catalogo SET saldo = " + catalogo.saldo + " WHERE (empresaId = " +
                                                        catalogo.empresa.id + " AND cuenta = " + catalogo.cuenta + " AND nombre = '" +
                                                        catalogo.nombre + "' AND anio = " + catalogo.year + ")", Conexion);
                        Conexion.Open();
                        try
                        {
                            MySqlDataReader data = comando.ExecuteReader();
                            Conexion.Close();
                            return true;
                        }
                        catch (Exception err)
                        {
                            Conexion.Close();
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            else
            {
                return false;
            }
        }

        public static int GetCatalogoByName(string nombre)
        {
            if (Conectar())
            {
                Conexion.Open();
                int cat = -1;
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Cuenta WHERE (nombre = '" + nombre.ToUpper() + "')", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {
                    cat = int.Parse(data["cuentaId"].ToString());
                }
                else
                {
                    MessageBox.Show("Error, cuenta " + nombre + "inexistente");
                }

                Conexion.Close();
                return cat;
            }
            else
            {
                return -1;
            }
        }

        public static int NextCatalogo(Catalogo catalogo)
        {
            if (Conectar())
            {
                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Catalogo WHERE (empresaId = " +
                    catalogo.empresa.id + " AND cuenta = " + catalogo.cuenta + " AND anio = " + catalogo.year + ")", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                int next = 1;
                while (data.Read())
                {
                    next++;

                }

                Conexion.Close();
                return next;
            }
            else
            {
                MessageBox.Show("Error al conectar a la BD");
                return -1;
            }
        }

        public static List<Catalogo> GetCatalogos()
        {
            List<Catalogo> Catalogos = new List<Catalogo>();

            if (Conectar())
            {

                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Catalogo", Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {
                    do
                    {

                        Catalogos.Add(new Catalogo {
                            id = int.Parse(data["id"].ToString()),
                            cuenta = int.Parse(data["cuenta"].ToString()),
                            cuentaEspecifica = int.Parse(data["cuentaEspecifica"].ToString()),
                            empresa = new Empresa { id = int.Parse(data["empresaId"].ToString()) },
                            nombre = data["nombre"].ToString(),
                            year = int.Parse(data["anio"].ToString()),
                            saldo = float.Parse(data["saldo"].ToString())
                        });

                    } while (data.Read());
                    Conexion.Close();
                    foreach (Catalogo catalogo in Catalogos)
                    {
                        catalogo.empresa = Controller.GetEmpresa(catalogo.empresa.id);
                    }
                    return Catalogos;                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
            {
                return null;
            }
        }

        public static List<Catalogo> GetCatalogos(int empres)
        {
            List<Catalogo> Catalogos = new List<Catalogo>();

            if (Conectar())
            {
                Empresa oEmpresa = GetEmpresa(empres);

                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Catalogo WHERE empresaId = " + oEmpresa.id, Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {
                    do
                    {

                        Catalogos.Add(new Catalogo
                        {
                            id = int.Parse(data["id"].ToString()),
                            cuenta = int.Parse(data["cuenta"].ToString()),
                            cuentaEspecifica = int.Parse(data["cuentaEspecifica"].ToString()),
                            empresa = new Empresa { id = int.Parse(data["empresaId"].ToString()) },
                            nombre = data["nombre"].ToString(),
                            year = int.Parse(data["anio"].ToString()),
                            saldo = float.Parse(data["saldo"].ToString())
                        });

                    } while (data.Read());
                    Conexion.Close();
                    foreach (Catalogo catalogo in Catalogos)
                    {
                        catalogo.empresa = Controller.GetEmpresa(catalogo.empresa.id);
                    }
                    return Catalogos;                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
            {
                return null;
            }
        }

        public static List<Catalogo> GetCatalogos(string empresName)
        {
            List<Catalogo> Catalogos = new List<Catalogo>();

            if (Conectar())
            {
                Empresa oEmpresa = GetEmpresa(empresName);

                Conexion.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM Catalogo WHERE empresaId = " + oEmpresa.id, Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if (data.Read())
                {
                    do
                    {

                        Catalogos.Add(new Catalogo
                        {
                            id = int.Parse(data["id"].ToString()),
                            cuenta = int.Parse(data["cuenta"].ToString()),
                            cuentaEspecifica = int.Parse(data["cuentaEspecifica"].ToString()),
                            empresa = new Empresa { id = int.Parse(data["empresaId"].ToString()) },
                            nombre = data["nombre"].ToString(),
                            year = int.Parse(data["anio"].ToString()),
                            saldo = float.Parse(data["saldo"].ToString())
                        });

                    } while (data.Read());
                    Conexion.Close();
                    foreach (Catalogo catalogo in Catalogos)
                    {
                        catalogo.empresa = Controller.GetEmpresa(catalogo.empresa.id);
                    }
                    return Catalogos;                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
            {
                return null;
            }
        }


        public static Catalogo GetCatalogo(float cuenta)
        {
            string[] cuentaDivision = cuenta.ToString().Split('.');

            if (Conectar())
            {
                Conexion.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Cuenta WHERE cuenta = " + int.Parse(cuentaDivision[0]) + 
                                                        " AND cuentaEspecifica = " + int.Parse(cuentaDivision[1]), Conexion);
                MySqlDataReader data = comando.ExecuteReader();
                if(data.Read())
                {
                    Catalogo catalogo = new Catalogo
                    {
                        id = int.Parse(data["id"].ToString()),
                        cuenta = int.Parse(data["cuenta"].ToString()),
                        cuentaEspecifica = int.Parse(data["cuentaEspecifica"].ToString()),
                        empresa = new Empresa { id = int.Parse(data["empresaId"].ToString()) },
                        nombre = data["nombre"].ToString(),
                        year = int.Parse(data["anio"].ToString()),
                        saldo = float.Parse(data["saldo"].ToString())
                    };
                    catalogo.empresa = Controller.GetEmpresa(catalogo.empresa.id);
                    Conexion.Close();
                    return catalogo;
                }
                else
                {
                    Conexion.Close();
                    return null;
                }

            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
