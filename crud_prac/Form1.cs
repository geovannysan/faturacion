using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using ClassLibrary1;

namespace crud_prac
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();      
         // Cree un administrador de temas de materiales y agregue el formulario para administrar (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configurar esquema de color
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue500, Primary.Blue500,
            Primary.Blue500, Accent.LightBlue200,
            TextShade.WHITE
            );
        }
        public static String Nombre = ""; 
        private void Form1_Load(object sender, EventArgs e)
        {
            
               
        }                                                               
         private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

      

        private void materialSingleLineTextField1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Panel pael = new Panel();
            // Form2 fo = new Form2();                 
            try
            {
                string consul = string.Format("SELECT * FROM usuario where email= '{0}'", usuario.Text.Trim());
                DataSet dataSet = Class1.Ejecutar(consul);
                Nombre = dataSet.Tables[0].Rows[0]["email"].ToString().Trim();
                String passw = dataSet.Tables[0].Rows[0]["pass"].ToString().Trim();

                if (passw == contrase.Text.Trim())
                {
                    this.Hide();
                    pael.Show();
                }
                else
                {
                    MessageBox.Show("falta");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error "+ex);
            }
        }
    }
}
