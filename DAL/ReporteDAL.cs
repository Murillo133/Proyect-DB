using ENTITIES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReporteDAL
    {
       

        public LinkedList<int> porcentajeOcupacion()
        {
            LinkedList<int> num = new LinkedList<int>();
            try
            {   string sql;
                sql = "EXEC AVG_WORK";
                using (SqlConnection con = Conexion.Conectar())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        num.AddLast(dr.GetInt32(0));

                    }

                    con.Close();
                }

            }
            catch (Exception)
            {
                return null;
            }
            return num;
        }
        public LinkedList<string> Ocupacion()
        {
            LinkedList<string> num = new LinkedList<string>();
            try
            {
                string sql;
                sql = "EXEC AVG_WORK";
                using (SqlConnection con = Conexion.Conectar())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        num.AddLast(dr.GetString(1));

                    }

                    con.Close();
                }

            }
            catch (Exception)
            {
                return null;
            }
            return num;
        }

       
         

    }
}
