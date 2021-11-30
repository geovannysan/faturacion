using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_prac.listas
{
    public partial class Consultaprove : ingresos.Consulta
    {
        String cadenaRecibida;
        public Consultaprove(String cadenaQueRecibo)
        {
            cadenaRecibida = cadenaQueRecibo;
            InitializeComponent();
        }

        private void Consultaprove_Load(object sender, EventArgs e)
        {
            if (cadenaRecibida == "Proveedor") {
                dataGridView1.DataSource = cargar_datos("select id_pro as 'Codigo', razonsocial as 'Razon Social', represetante as 'Propietario',ruc as 'Ruc', telefono as 'Teléfono', dirreccion as 'Dirección', email as 'Email' from proveedor").Tables[0];
            }else if (cadenaRecibida == "categoria")
            {
                dataGridView1.DataSource = cargar_datos("select * from tipo_cat").Tables[0];

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
