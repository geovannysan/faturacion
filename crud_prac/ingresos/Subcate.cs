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
using System.Data.SqlClient;

namespace crud_prac.ingresos
{
    public partial class Subcate : Form
    {
        public Subcate()
        {
            InitializeComponent();
        }
        public DataSet cargar_datos(string table)
        {
            DataSet DT;
            string cmd = string.Format(table);
            DT = Class1.Ejecutar(cmd);

            return DT;

        }
        private void Subcate_Load(object sender, EventArgs e)     
        {
            DataSet datos = cargar_datos("select id_s,nombre from tipo_subcat");         
           
            ComboBox1.DisplayMember = "nombre";
            ComboBox1.ValueMember = "id_s";
            ComboBox1.DataSource = datos.Tables[0].DefaultView;
           

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_sub.Text = ComboBox1.SelectedValue.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nombre.Text) || string.IsNullOrEmpty(description.Text))
                {
                    if (string.IsNullOrEmpty(nombre.Text)) errorProvider1.SetError(nombre, "ingrese un Nombre");
                    if (string.IsNullOrEmpty(description.Text)) errorProvider1.SetError(description, "ingrese un desciption");
                }
                else
                {
                 
                    // String ingreso = String.Format("insertsubcate '{0}','{1}','{2}','{3}','{4}','{5}'", null, nombre.Text.ToString(), description.Text.ToString(), "1", int.Parse(id_sub.Text.ToString()),"");

                    string data= Class1.Ejecutars(id.Text.ToString(), nombre.Text.ToString(), description.Text.ToString(), "1", id_sub.Text.ToString());

                    //   String re = data.T.ToString();
                    id.Text = data;
                    MessageBox.Show(""+data);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex);

            }
           


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            listas.Consultaprove consultaprove = new listas.Consultaprove("categoria");

            consultaprove.ShowDialog();
            if (consultaprove.DialogResult == DialogResult.OK)
            {
                nombre.Text = consultaprove.dataGridView1.Rows[consultaprove.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                nombre.Focus();
            }
        }
    }
}
