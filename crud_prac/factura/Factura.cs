using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_prac.factura
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
            
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

       

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
      

       

        

        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
       // bool notlastColumn = true;
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {             
                e.SuppressKeyPress = true;
                SendKeys.Send("{Tab}");
            }
            /*  if (e.KeyCode ==Keys.Enter)
              {
                  int col = dataGridView1.CurrentCell.ColumnIndex;
                  int row = dataGridView1.CurrentCell.RowIndex;
                  if (col < dataGridView1.Columns.Count - 1)
                  {
                      dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[col+ 1];
                      dataGridView1.Focus();
                  }
                  else if (col==dataGridView1.Columns.Count-1)
                  {
                      dataGridView1.Rows.Add(1);
                      dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[0];
                      dataGridView1.Focus();

                  }

              }*/
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
          /*  foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value == null )
                {
                    row.Cells[1].Value = 0;
                   // MessageBox.Show("Hay algún campo vacío!");
                    // bCampoVacio = true;
                }
                else if (row.Cells[1].Value != null) {
                     Decimal sumatoria = Convert.ToDecimal(row.Cells[1].Value) + Convert.ToDecimal(row.Cells[2].Value);    //aqui recorre las celdas y las va sumando
                     row.Cells[3].Value = Convert.ToDecimal(sumatoria);
                 }

            }*/
        }
        int cantidad = 0;
        decimal precio = 0;
        decimal total = 0;


        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column2")
            {
                try
                {
                    cantidad = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ingrese Cantidad "+error);
               
                }
                try
                {
                    precio = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

                }
                catch (Exception error)
                {
                    MessageBox.Show("Seleccione Producto"+ error);

                }
                if (!(cantidad==0) && !(precio==0))
                {
                    total = cantidad * precio;
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = total;

                }

            }
        }
    }
}
