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
    public partial class Procuradores : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-11M8QL9; Initial Catalog=Abogados; integrated security=true");
        public Procuradores()
        {
            InitializeComponent();
        }

        
private void btnGuardarProc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand altas = new SqlCommand("insert into Procuradores (ID_proc, Name_proc, Apellido_proc, Dir_proc, Fecha_nacp) values " +
                                "(@IDProc, @NameProc, @ApellidoProc, @DirProc, @FechaNacProc)", conexion);
                altas.Parameters.AddWithValue("IDProc", txtIDProc.Text);
                altas.Parameters.AddWithValue("NameProc", txtNombreProc.Text);
                altas.Parameters.AddWithValue("ApellidoProc", txtApellidoProc.Text);
                altas.Parameters.AddWithValue("DirProc", txtDireccionProc.Text);
                altas.Parameters.AddWithValue("FechaNacProc", txtFNProc.Value);

                conexion.Open();
                altas.ExecuteNonQuery();

                MessageBox.Show("Procurador almacenado correctamente");
                conexion.Close();
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

        private void btnCancelarProc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarProc_Click(object sender, EventArgs e)
        {
            try
            {
                string baja = "DELETE FROM Procuradores WHERE ID_proc = @ID_proc";
                conexion.Open();

                SqlCommand bajas = new SqlCommand(baja, conexion);

                bajas.Parameters.Add("ID_proc", txtIDProc.Text);
                bajas.ExecuteNonQuery();
                bajas.Dispose();
                bajas = null;
                txtIDProc.Clear();
                MessageBox.Show("Procurador eliminado");
                conexion.Close();
                dataviem();
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

        private void btnConsultarProc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT * FROM Procuradores WHERE ID_proc = @ID_proc", conexion);
                conexion.Open();

                consulta.Parameters.AddWithValue("@ID_proc", txtIDProc.Text);


                SqlDataReader reader = consulta.ExecuteReader();
                while (reader.Read())
                {
                    txtIDProc.Text = reader[0].ToString();
                    txtNombreProc.Text = reader[1].ToString();
                    txtApellidoProc.Text = reader[2].ToString();
                    txtDireccionProc.Text = reader[3].ToString();
                    txtFNProc.Text = reader[4].ToString();
                }
                MessageBox.Show("Consulta Completada");
               
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

        private void Procuradores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet8.Asunto_Procurador' Puede moverla o quitarla según sea necesario.
            this.asunto_ProcuradorTableAdapter.Fill(this.abogadosDataSet8.Asunto_Procurador);
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet.Procuradores' Puede moverla o quitarla según sea necesario.
            this.procuradoresTableAdapter.Fill(this.abogadosDataSet.Procuradores);

        }

        private void btnActualizarProc_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand actualizar = new SqlCommand("UPDATE Procuradores SET ID_proc = @ID_proc, Name_proc=@Name_proc, Apellido_proc=@Apellido_proc, Dir_proc=@Dir_proc, Fecha_nacp=@Fecha_nacp " +
                    "WHERE ID_proc = @ID_proc", conexion);


                actualizar.Parameters.AddWithValue("@ID_proc", txtIDProc.Text);
                actualizar.Parameters.AddWithValue("@Name_proc", txtNombreProc.Text);
                actualizar.Parameters.AddWithValue("@Apellido_proc", txtApellidoProc.Text);
                actualizar.Parameters.AddWithValue("@Dir_proc", txtDireccionProc.Text);
                actualizar.Parameters.AddWithValue("@Fecha_nacp", txtFNProc.Text);

                actualizar.ExecuteNonQuery();



                MessageBox.Show("Datos actualizados");
                conexion.Close();
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
        public void dataviem()
        {
            conexion.Open();

            SqlDataAdapter da = new SqlDataAdapter("select*from Procuradores", conexion);
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
                txtIDProc.Text = grv.Cells[0].Value.ToString();

            }
        }
    }
}
