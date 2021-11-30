using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
namespace crud_prac
{
    public partial class Panel : MaterialForm
    {
        public Panel()
        {
            InitializeComponent();
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
        private Form  activos = null;
        private void abrirform( Form ChildForm)
        {
            if(activos != null)
            {
                activos.Close();
                activos = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                panel3.Controls.Add(ChildForm);
                panel3.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
            else
            {
               // activos.Close();
                activos = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                panel3.Controls.Add(ChildForm);
                panel3.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
        }
        private void abrirform2(Form ChildForm)
        {
            if (activos != null)
            {
                activos.Close();
                activos = ChildForm;
                ChildForm.TopLevel = true;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
              //  panel3.Controls.Add(ChildForm);
                panel3.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
            else
            {
                // activos.Close();
                activos = ChildForm;
                ChildForm.TopLevel = true;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                //panel3.Controls.Add(ChildForm);
                panel3.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
        }
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
           // formularios.Home Frm = new formularios.Home();
           abrirform(new formularios.Home());
           // formularios.Home Frm = new formularios.Home();
           /* Frm.TopLevel = false;
            Frm.FormBorderStyle = FormBorderStyle.None;
            Frm.Dock = DockStyle.Fill;
            panel3.Controls.Add(Frm);
            Frm.Show();*/
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ingresos.Provedor Frm = new ingresos.Provedor();
            Frm.Show();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            emaillo.Text = Form1.Nombre.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            abrirform(new mantenimiento.Mantenimieto());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            abrirform2(new herramienta.Administracion());

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            abrirform(new herramienta.Administracion());
        }
    }
}
