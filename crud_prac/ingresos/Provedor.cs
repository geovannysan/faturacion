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
using ClassLibrary1;



namespace crud_prac.ingresos
{
    public partial class Provedor : Form
    {
        public Provedor()
        {
            InitializeComponent();
        }

        private void Provedor_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty( Nombre.Text.ToString()))
                {
                    SqlConnection connection = new SqlConnection("server=DESKTOP-RMUN493\\SQLEXPRESS;database=Tienda;integrated security=true");
                    connection.Open();
                    SqlCommand da = new SqlCommand("actualizarproveedor", connection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.AddWithValue("@ID", codi.Text.ToString());
                    da.Parameters.AddWithValue("@Nombre", Nombre.Text.ToString());
                    da.Parameters.AddWithValue("@Representa", Representnte.Text.ToString());
                    da.Parameters.AddWithValue("@Ruc", Dni.Text.ToString());
                    da.Parameters.AddWithValue("@telefono", Telefono.Text.ToString());
                    da.Parameters.AddWithValue("@direccion", Direccion.Text.ToString());
                    da.Parameters.AddWithValue("@email", Email.Text.ToString());
                    da.Parameters.AddWithValue("@estado", 1);
                    da.Parameters.Add("@New_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    da.ExecuteNonQuery();
                    String documentoId = Convert.ToString(da.Parameters["@New_id"].Value);
                    connection.Close();
                   
                    MessageBox.Show(documentoId);
                    Limpiar();
                }
                else
                {
                    if (string.IsNullOrEmpty(Nombre.Text)) errorProvider1.SetError(Nombre, "ingrese un Nombre");
                    if (string.IsNullOrEmpty(Representnte.Text)) errorProvider1.SetError(Representnte, "ingrese un desciption");


                    MessageBox.Show("ingrese los datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }   

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(Nombre.Text.ToString()))
                {
                    SqlConnection connection = new SqlConnection("server=DESKTOP-RMUN493\\SQLEXPRESS;database=Tienda;integrated security=true");
                    connection.Open();
                    SqlCommand da = new SqlCommand("actualizarproveedor", connection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.AddWithValue("@ID", codi.Text.ToString());
                    da.Parameters.AddWithValue("@Nombre", Nombre.Text.ToString());
                    da.Parameters.AddWithValue("@Representa", Representnte.Text.ToString());
                    da.Parameters.AddWithValue("@Ruc", Dni.Text.ToString());
                    da.Parameters.AddWithValue("@telefono", Telefono.Text.ToString());
                    da.Parameters.AddWithValue("@direccion", Direccion.Text.ToString());
                    da.Parameters.AddWithValue("@email", Email.Text.ToString());
                    da.Parameters.AddWithValue("@estado", 1);
                    da.Parameters.Add("@New_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    da.ExecuteNonQuery();
                    String documentoId = Convert.ToString(da.Parameters["@New_id"].Value);
                    connection.Close();
                    // return documentoId;
                    //String ingreso = String.Format("actualizarproveedor '{0}','{1}','{2}','{3}','{4}','{5}','{6}'", null, Nombre.Text.ToString(), Representnte.Text.ToString(), Dni.Text.ToString(), Telefono.Text.ToString(), Direccion.Text.ToString(), Email.Text.ToString(), 1);
                    // Class1.Ejecutar(ingreso);
                    MessageBox.Show(documentoId);
                    Limpiar();
                }
                else
                {
                    errorProvider1.SetError(Representnte, "ingrese un dato");

                    MessageBox.Show("ingrese los datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            listas.Consultaprove consultaprove = new listas.Consultaprove("Proveedor");
           
            consultaprove.ShowDialog();
            if(consultaprove.DialogResult == DialogResult.OK)
            {
                codi.Text = consultaprove.dataGridView1.Rows[consultaprove.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                Nombre.Text = consultaprove.dataGridView1.Rows[consultaprove.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                Representnte.Text = consultaprove.dataGridView1.Rows[consultaprove.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                Dni.Text = consultaprove.dataGridView1.Rows[consultaprove.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                Telefono.Text = consultaprove.dataGridView1.Rows[consultaprove.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                Email.Text = consultaprove.dataGridView1.Rows[consultaprove.dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                Direccion.Text = consultaprove.dataGridView1.Rows[consultaprove.dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                Nombre.Focus();
            }
        }

        public void Limpiar()
        {
            codi.Text = "";
            Nombre.Text = "";
            Representnte.Text = ""; 
            Dni.Text = "";
            Telefono.Text = "";
            Email.Text = "";
            Direccion.Text = "";

        }
        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void codi_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Nombre.Text))
            {
                Editarn.Enabled = false;
                Eliminar.Enabled = false;
                Guardar.Enabled = true;
            }
            else
            {
                Editarn.Enabled = true;
                Eliminar.Enabled = true;
                Guardar.Enabled = false;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
