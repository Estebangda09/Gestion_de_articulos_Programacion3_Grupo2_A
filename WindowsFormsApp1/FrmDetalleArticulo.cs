using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class FrmDetalleArticulo : Form
    {   //cosntructor
        public FrmDetalleArticulo()
        {
            InitializeComponent();
            Text = "Detall De articulos";

            Color color = Color.Black;
        }
        //metodo para buscar articulos
        public List<Articulo>buscararticulos (string articulo)
        {

           AccesoDatos accesoDatos = new AccesoDatos();

            
            List<Articulo> lista = new List<Articulo>();



                try
                {

                accesoDatos.SetearConsulta("SELECT  a.Codigo, a.Nombre, a.Descripcion, a.Precio,m.Descripcion AS Marca,   c.Descripcion AS Categoria,i.ImagenUrl FROM Articulos a LEFT JOIN Marcas m     ON m.Id = a.IdMarca  LEFT JOIN Categorias c ON c.Id = a.IdCategoria left join IMAGENES i on i.IdArticulo = a.Id WHERE Codigo = @Codigo");


                    accesoDatos.SetearParametros("@Codigo",articulo.Trim());
                    accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {


                    Articulo aux = new Articulo();

                    
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    
                    aux.ImagenUrl = new Imagen();

                    if (!(accesoDatos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];

                   

                    aux.Categoria = new Categoria();
                    aux.Marca = new Marca();



                  //  aux.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)accesoDatos.Lector["Categoria"];

                    aux.Marca.Descripcion = (string)accesoDatos.Lector["Marca"];

                   ///   aux.Marca.Id = (int)accesoDatos.Lector["IdMarca"];


                  

                    lista.Add(aux);


                    
                   
                }
                return lista;



                




                }
                catch (Exception ex)
                {
                MessageBox.Show("ANDA MAL0");
                    throw ex;
                }

                finally
                {
                    accesoDatos.CerrarConexion();

                }
            
            





            
        }

      
        //boton buscar
        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            List<Articulo>lista = new List<Articulo>();


            if (CodigoArttextBox.Text == "")
            {
                MessageBox.Show("pongo un codigo valido");
                return;
            }

            try
            {
                lista = buscararticulos(CodigoArttextBox.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }

         
             if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("no se encontro");
                return;
            }

            dataGridViewdetalle.DataSource = null;
            dataGridViewdetalle.DataSource = lista;
            imagenpictureBox.Load(lista[0].ImagenUrl.ImagenUrl);

            dataGridViewdetalle.Columns["ImagenUrl"].Visible = true;

            if (dataGridViewdetalle.Columns.Contains("Id"))
                dataGridViewdetalle.Columns["Id"].Visible = false;



        }
        //boton ver codigos
        private void Vercodigosbutton_Click(object sender, EventArgs e)
        {

           AccesoDatos accesoDatos = new AccesoDatos();
            VercodigoslistBox.DisplayMember = "Codigo";
            VercodigoslistBox.ValueMember = "Codigo";
            VercodigoslistBox.Items.Clear();
           
           


            accesoDatos.SetearConsulta("select distinct   a.Codigo  from ARTICULOS a order by a.Codigo asc");
            accesoDatos.EjecutarLectura();

            try
            {
                while (accesoDatos.Lector.Read())
                {

                    Articulo aux = new Articulo();

                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];

                    VercodigoslistBox.Items.Add(aux);



                }



            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                accesoDatos.CerrarConexion();
            }


           
        }
        //evento al seleccionar un codigo
        private void VercodigoslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VercodigoslistBox.SelectedItem is Articulo art)
                CodigoArttextBox.Text = art.Codigo;
        }
        //boton limpiar
        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            CodigoArttextBox.Text = "";

            VercodigoslistBox.Items.Clear();
            imagenpictureBox.Image = null;

            dataGridViewdetalle.DataSource = null;

            dataGridViewdetalle.Enabled = true;

            CodigoArttextBox.Focus();


        }
        //boton cancelar
        private void buttonCancelarDetalle_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    







