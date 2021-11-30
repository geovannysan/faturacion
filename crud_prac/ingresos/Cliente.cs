using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_prac.ingresos
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Nombre.Text)||String.IsNullOrEmpty(Apellido.Text)||String.IsNullOrEmpty(Dirrecion.Text))
            {
                if (String.IsNullOrEmpty(Nombre.Text)) errorProvider1.SetError(Nombre, "Ingrese nombre");
                if (String.IsNullOrEmpty(Apellido.Text)) errorProvider1.SetError(Apellido, "Ingrese nombre");
                if (String.IsNullOrEmpty(Dirrecion.Text)) errorProvider1.SetError(Dirrecion, "Ingrese nombre");


            }
           else if (String.IsNullOrEmpty(Cedula.Text) || String.IsNullOrEmpty(Telefono.Text)|| String.IsNullOrEmpty(Email.Text))
            {
                if (String.IsNullOrEmpty(Cedula.Text)) errorProvider1.SetError(Cedula, "Ingrese nombre");
                if (String.IsNullOrEmpty(Telefono.Text)) errorProvider1.SetError(Telefono, "Ingrese nombre");
                if (String.IsNullOrEmpty(Email.Text)) errorProvider1.SetError(Email, "Ingrese nombre");
            }
            else
            {
                try
                {

                }catch(Exception ex)
                {

                }
            }
        }
    }
}
