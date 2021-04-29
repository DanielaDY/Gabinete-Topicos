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
    public partial class Asuntos : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-11M8QL9; Initial Catalog=Abogados; integrated security=true");
        public Asuntos()
        {
            InitializeComponent();
        }

        private void btnGuardarA_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand altas = new SqlCommand("insert into Asuntos (No_exp, FInicio, FFinal, Estado_exp, DNI_Cliente, Id_Proc) values (@NoExp, @FechaInicio, @FechaFinal, @EstadoExp, @DNICliente, @Id_Proc)", conexion);
                altas.Parameters.AddWithValue("NoExp", txtNoExp.Text);
                altas.Parameters.AddWithValue("FechaInicio", txtFInicio.Value);
                altas.Parameters.AddWithValue("FechaFinal", txtFFinal.Value);
                altas.Parameters.AddWithValue("EstadoExp", txtEstado.Text);
                altas.Parameters.AddWithValue("DNICliente", txtDNICliente.Text);
                altas.Parameters.AddWithValue("Id_Proc", txtIdProc.Text);


                conexion.Open();
                altas.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Asunto almacenado correctamente");
                dataviem();
                txtNoExp.Clear();
                txtEstado.ResetText();
                txtFInicio.ResetText();
                txtFFinal.ResetText();
                txtNoExp.Focus();

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

        private void btnCancelarA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarAsunto_Click(object sender, EventArgs e)
        {
            try
            {
                string baja = "DELETE FROM Asuntos WHERE No_exp = @No_exp";
                conexion.Open();

                SqlCommand bajas = new SqlCommand(baja, conexion);

                bajas.Parameters.Add("No_exp", txtNoExp.Text);
                bajas.ExecuteNonQuery();
                bajas.Dispose();
                bajas = null;
                txtNoExp.Clear();
                conexion.Close();
                MessageBox.Show("Asunto eliminado");
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

        private void btnConsultarAsunto_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT * FROM Asuntos WHERE No_exp = @No_exp", conexion);
                conexion.Open();

                consulta.Parameters.AddWithValue("@No_exp", txtNoExp.Text);


                SqlDataReader reader = consulta.ExecuteReader();
                while (reader.Read())
                {
                    txtNoExp.Text = reader[0].ToString();
                    txtFInicio.Text = reader[1].ToString();
                    txtFFinal.Text = reader[2].ToString();
                    txtEstado.Text = reader[3].ToString();
                    txtDNICliente.Text = reader[4].ToString();
                    txtIdProc.Text = reader[5].ToString();
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

        private void btnActualizarAsunto_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand actualizar = new SqlCommand("UPDATE Asuntos SET No_exp = @No_exp, FInicio=@FInicio, FFinal=@FFinal, Estado_exp=@Estado_exp, DNI_Cliente=@DNI_Cliente, Id_Proc=@Id_Proc " +
                    "WHERE No_exp = @No_exp", conexion);


                actualizar.Parameters.AddWithValue("@No_exp", txtNoExp.Text);
                actualizar.Parameters.AddWithValue("@FInicio", txtFInicio.Text);
                actualizar.Parameters.AddWithValue("@FFinal", txtFFinal.Text);
                actualizar.Parameters.AddWithValue("@Estado_exp", txtEstado.Text);
                actualizar.Parameters.AddWithValue("@DNI_Cliente", txtDNICliente.Text);
                actualizar.Parameters.AddWithValue("@Id_Proc", txtIdProc.Text);

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

        private void Asuntos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet11.Procuradores' Puede moverla o quitarla según sea necesario.
            this.procuradoresTableAdapter1.Fill(this.abogadosDataSet11.Procuradores);
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet10.Procuradores' Puede moverla o quitarla según sea necesario.
            this.procuradoresTableAdapter.Fill(this.abogadosDataSet10.Procuradores);
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet7.Asuntos' Puede moverla o quitarla según sea necesario.
            this.asuntosTableAdapter2.Fill(this.abogadosDataSet7.Asuntos);
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet6.Asunto_Procurador' Puede moverla o quitarla según sea necesario.
            this.asunto_ProcuradorTableAdapter1.Fill(this.abogadosDataSet6.Asunto_Procurador);
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet5.Asunto_Procurador' Puede moverla o quitarla según sea necesario.
            this.asunto_ProcuradorTableAdapter.Fill(this.abogadosDataSet5.Asunto_Procurador);
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet4.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.abogadosDataSet4.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet3.Asuntos' Puede moverla o quitarla según sea necesario.
            this.asuntosTableAdapter1.Fill(this.abogadosDataSet3.Asuntos);
            // TODO: esta línea de código carga datos en la tabla 'abogadosDataSet2.Asuntos' Puede moverla o quitarla según sea necesario.
            this.asuntosTableAdapter.Fill(this.abogadosDataSet2.Asuntos);
            dataviem();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.asunto_ProcuradorTableAdapter.FillBy(this.abogadosDataSet5.Asunto_Procurador);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public void dataviem()
        {
            conexion.Open();

            SqlDataAdapter da = new SqlDataAdapter("select*from Asuntos", conexion);
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
                txtNoExp.Text = grv.Cells[0].Value.ToString();

            }
        
    }
    }
}
