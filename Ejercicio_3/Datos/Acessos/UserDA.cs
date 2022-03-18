using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Acessos
{
    public class UserDA
    {
        readonly string cadena = "Server=Localhost; Port=3306; Database=Ejercicio3; Uid=root; Pwd=chidori1;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Users Login(string iduser, string pasword)
        {
            Users user = null;

            try
            {
                string sql = "SELECT * FROM users WHERE Iduser = @Iduser AND Pasword = @Pasword;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Iduser", iduser);
                cmd.Parameters.AddWithValue("@Pasword", pasword);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Users();
                    user.Iduser = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.TipoUsuario = reader[2].ToString();
                    user.Pasword = reader[3].ToString();
                    user.Enlinea = Convert.ToBoolean(reader[4]);

                }
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
            }
            return user;


        }


        public DataTable Listausers()
        {
            DataTable listaUsersDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM users;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaUsersDT.Load(reader);
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
            }
            return listaUsersDT;
        }


    }
}
