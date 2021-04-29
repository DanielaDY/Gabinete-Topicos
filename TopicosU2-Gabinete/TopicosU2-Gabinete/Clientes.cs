using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TopicosU2_Gabinete
{
    public partial class Clientes : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-11M8QL9; Initial Catalog=Abogados; integrated security=true");
        
        public Clientes()
        {
            InitializeComponent();
        }
        

        private void btnGuardarCl_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand altas = new SqlCommand("insert into Clientes (DNI_Cliente, Name_Cliente, Apellido_Cliente, Dir_Cliente, Fecha_nacc) values " +
                                "(@DNICliente, @NameCliente, @ApellidoCliente, @DirCliente, @FechaNac)", conexion);
                altas.Parameters.AddWithValue("DNICliente", txtDNICl.Text);
                altas.Parameters.AddWithValue("NameCliente", txtNombreCl.Text);
                altas.Parameters.AddWithValue("ApellidoCliente", txtApellidoCl.Text);
                altas.Parameters.AddWithValue("DirCliente", txtDireccionCl.Text);
                altas.Parameters.AddWithValue("FechaNac", txtFNCl.Value);


                conexion.Open();

                altas.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Cliente almacenado correctamente");
                dataviem();

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox text = ctrl as TextBox;
                        text.Clear();
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                
            }
            finally
            {
                conexion.Close();
            }
            
        }

        private void btnCancelarCl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarCl_Click(object sender, EventArgs e)
        {
            try
            {
                string baja = "DELETE FROM Clientes WHERE DNI_Cliente = @DNI_Cliente";
                conexion.Open();

                SqlCommand bajas = new SqlCommand(baja, conexion);

                bajas.Parameters.Add("DNI_Cliente", txtDNICl.Text);
                bajas.ExecuteNonQuery();
                bajas.Dispose();
                bajas = null;
                txtDNICl.Clear();

                conexion.Close();
                dataviem();
                MessageBox.Show("Cliente eliminado");
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
            
        }

        private void btnConsultaCl_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand consulta = new SqlCommand("SELECT * FROM Clientes WHERE DNI_Cliente = @DNI_Cliente", conexion);
                conexion.Open();

                consulta.Parameters.AddWithValue("@DNI_Cliente", txtDNICl.Text);


                SqlDataReader reader = consulta.ExecuteReader();
                while (reader.Read())
                {
                    txtDNICl.Text = reader[0].ToString();
                    txtNombreCl.Text = reader[1].ToString();
                    txtApellidoCl.Text = reader[2].ToString();
                    txtDireccionCl.Text = reader[3].ToString();
                    txtFNCl.Text = reader[4].ToString();
                }
                MessageBox.Show("Consulta Completada");
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnActualizarCl_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand actualizar = new SqlCommand("UPDATE Clientes SET DNI_Cliente = @DNI_Cliente, Name_Cliente=@Name_Cliente, Apellido_Cliente=@Apellido_Cliente, Dir_Cliente=@Dir_Cliente, Fecha_nacc=@Fecha_nacc " +
                    "WHERE DNI_Cliente = @DNI_Cliente", conexion);


                actualizar.Parameters.AddWithValue("@DNI_Cliente", txtDNICl.Text);
                actualizar.Parameters.AddWithValue("@Name_Cliente", txtNombreCl.Text);
                actualizar.Parameters.AddWithValue("@Apellido_Cliente", txtApellidoCl.Text);
                actualizar.Parameters.AddWithValue("@Dir_Cliente", txtDireccionCl.Text);
                actualizar.Parameters.AddWithValue("@Fecha_nacc", txtFNCl.Text);

                actualizar.ExecuteNonQuery();

                conexion.Close();
                dataviem();
                MessageBox.Show("Datos actualizados");
                
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox text = ctrl as TextBox;
                        text.Clear();
                    }

                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dataviem();
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.abogadosDataSet1.Clientes);

        }
        public void dataviem()
        {
            conexion.Open();

            SqlDataAdapter da = new SqlDataAdapter("select*from Clientes", conexion);
            DataSet ds = new DataSet();
            da.Fill(ds, "asuntos");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "asuntos";
            conexion.Close();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int select_row;

            if (e.RowIndex >= 0)
            {
                select_row = e.RowIndex;
                DataGridViewRow grv = dataGridView1.Rows[select_row];
                txtDNICl.Text = grv.Cells[0].Value.ToString();
                
            }
        }
    }
}
