using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_prac.herramienta
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }
        private Form activos = null;
        private void abrirforms2(Form ChildForm)
        {
            if (activos != null)
            {
                activos.Close();
                activos = ChildForm;
                ChildForm.TopLevel = false;
                Panel.Controls.Add(ChildForm);
                Panel.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
            else
            {
                // activos.Close();
                activos = ChildForm;
                ChildForm.TopLevel = false;
                Panel.Controls.Add(ChildForm);
                Panel.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirforms2(new herramienta.Administracion());
        }
    }
}
