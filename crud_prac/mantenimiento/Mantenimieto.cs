using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_prac.mantenimiento
{
    public partial class Mantenimieto : Form
    {
        public Mantenimieto()
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

        }

        private void proformaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirforms2(new ingresos.Categoria());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirforms2(new ingresos.Subcate());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
