using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Dynamic;

namespace negocio
{
    public class AccesoDatos
    {

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {

            get { return lector; }
        }

        public AccesoDatos()
        {
            
            /*estaban
            conexion = new SqlConnection("Server=localhost,1433; Database=CATALOGO_P3_DB; Integrated Security=False; User ID=sa; Password=Esteban94*;");*/

            ///matias
            conexion = new SqlConnection("server = .\\SQLEXPRESS02; database = CATALOGO_P3_DB; integrated security =true ;");
            comando = new SqlCommand();

        }

        public void SetearConsulta(string consulta)
        {

            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = consulta;
        }

        public void EjecutarLectura()
        {

            comando.Connection = conexion;
            try
            {
                conexion.Open();

                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

          


        }

        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            try
            {

                conexion.Open();
                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void SetearParametros(string nombre,object valor)
        {

            comando.Parameters.AddWithValue(nombre, valor);


        }

        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();

        }



    }
}
