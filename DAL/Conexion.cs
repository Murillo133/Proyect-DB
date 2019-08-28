using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DAL
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(
                "Data Source=DESKTOP-7SAGH0L\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True");
            return cn;
        }
        public static DataSet Con(string cmd)
        {
            SqlConnection cn = new SqlConnection(
                "Data Source=DESKTOP-7SAGH0L\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True");
            cn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd,cn);
            sda.Fill(ds);
            cn.Close();
            return ds;
        }
    }
}