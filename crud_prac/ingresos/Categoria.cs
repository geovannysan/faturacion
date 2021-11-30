using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace crud_prac.ingresos
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(descriptio.Text))
                {
                    if (string.IsNullOrEmpty(Nombre.Text)) errorProvider1.SetError(Nombre, "ingrese un Nombre");
                    if (string.IsNullOrEmpty(descriptio.Text)) errorProvider1.SetError(descriptio, "ingrese un desciption");                           

                }
                else
                {
                    String ingreso = String.Format("insertcategory '{0}','{1}','{2}'", Nombre.Text.ToString(), descriptio.Text.ToString(), 1);
                    Class1.Ejecutar(ingreso);
                    MessageBox.Show("Categoria ingresada correctamente");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error intente de nuevo");
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void descriptio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
