using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClaseDatos
{
    internal class ClsConexion
    {
        SqlConnection con;
        public ClsConexion()
        {
            con = new SqlConnection("Server=DESKTOP-2TK8MGE; Database=Mi Primera Vez; Integrated security=true");
        }
        public SqlConnection Conectar()
        {
            try
            {
                con.Open();
                return con;
                MessageBox.Show("Conexion exitosa");
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
