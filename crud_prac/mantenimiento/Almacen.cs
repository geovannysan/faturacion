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

namespace crud_prac.mantenimiento
{
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_sub_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Nombre.Text)) errorProvider1.SetError(Nombre, "hjgh");
            if (String.IsNullOrEmpty(Representante.Text)) errorProvider1.SetError(Representante, "hgjghj");
            if (String.IsNullOrEmpty(Ruc.Text)) errorProvider1.SetError(Ruc, "ghjhgjg");
            if (String.IsNullOrEmpty(Domicilio.Text)) errorProvider1.SetError(Domicilio, "hjhjhg");
            if (String.IsNullOrEmpty(Email.Text)) { errorProvider1.SetError(Email, "hjhgjg");  }
            else
            try
            {

                SqlConnection connection = new SqlConnection("server=DESKTOP-RMUN493\\SQLEXPRESS;database=Tienda;integrated security=true");
                connection.Open();
                SqlCommand da = new SqlCommand("newalmace", connection);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@id", id.Text.ToString());
                da.Parameters.AddWithValue("@Nombre", Nombre.Text.ToString());
                da.Parameters.AddWithValue("@Propietario", Representante.Text.ToString());
                da.Parameters.AddWithValue("@Ruc", Ruc.Text.ToString());
               da.Parameters.AddWithValue("@telefono", Telefono.Text.ToString());
                da.Parameters.AddWithValue("@Dommici", Domicilio.Text.ToString());
                da.Parameters.AddWithValue("@Email", Email.Text.ToString());
                da.Parameters.AddWithValue("@Estado", 1);
                da.Parameters.Add("@Identifica", SqlDbType.Int).Direction = ParameterDirection.Output;
                da.ExecuteNonQuery();
                String documentoId = Convert.ToString(da.Parameters["@Identifica"].Value);
                connection.Close();

                MessageBox.Show(documentoId);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ ex);
            }


        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Almacen_Load(object sender, EventArgs e)
        {

        }
    }
}
