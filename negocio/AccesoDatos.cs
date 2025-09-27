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
        //propiedad para el lector
        public SqlDataReader Lector
        {


            get { return lector; }
        }
        //constructor
        public AccesoDatos()
        {
            
            //esteban
            conexion = new SqlConnection("Server=localhost,1433; Database=CATALOGO_P3_DB; Integrated Security=False; User ID=sa; Password=Esteban94*;");
           //matias
           //conexion = new SqlConnection("server = .\\SQLEXPRESS02; database = CATALOGO_P3_DB; integrated security =true ;");
           //AdriR
           // conexion = new SqlConnection("Server=localhost,1433; Database=CATALOGO_P3_DB; Integrated Security=False; User ID=sa; Password=BaseDeDatos#2;");
                   
          
            comando = new SqlCommand();

        }
        //metodo para setear consulta
        public void SetearConsulta(string consulta)
        {

            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = consulta;
        }
        //metodo para ejecutar lectura
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
        //metodo para ejecutar accion
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

                throw ex;
            }

        }
        //metodo para ejecutar escalar
        public object EjecutarEscalar()
        {
            comando.Connection = conexion;
            conexion.Open();
            return comando.ExecuteScalar();
        }
        //metodo para setear parametro
       
        public void SetearParametros(string nombre,object valor)
        {

            comando.Parameters.AddWithValue(nombre, valor);

        }
        //metodo para cerrar conexion
        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();

        }
    }
}
