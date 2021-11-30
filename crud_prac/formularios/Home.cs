using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_prac.formularios
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private Form activos = null;
        private void abrirforms(Form ChildForm)
        {
            if (activos != null)
            {
                activos.Close();
                activos = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
              ChildForm.Dock = DockStyle.Fill;
                panel2.Controls.Add(ChildForm);
                panel2.Tag = ChildForm;
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
                panel2.Controls.Add(ChildForm);
               panel2.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
        }
        private void abrirforms2(Form ChildForm)
        {
            if (activos != null)
            {
                activos.Close();
                activos = ChildForm;
                ChildForm.TopLevel = false;
                panel2.Controls.Add(ChildForm);
                panel2.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
            else
            {
                // activos.Close();
                activos = ChildForm;
                ChildForm.TopLevel = false;
                panel2.Controls.Add(ChildForm);
                panel2.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   factura.Factura Frm = new factura.Factura();
            abrirforms(new factura.Factura());/*
            Frm.TopLevel = false;           
            Frm.Dock = DockStyle.Fill;
            panel2.Controls.Add(Frm);
            Frm.Show();*/
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            abrirforms2(new ingresos.Provedor());       
        }
    }
}
