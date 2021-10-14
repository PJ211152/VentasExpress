using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasExpress
{
    public partial class Formulario_interno : Form
    {

        Ventas ventas = new Ventas();
        Usuario Datos = new Usuario();
        public Formulario_interno()
        {
            InitializeComponent();
            string name = Datos.Usuarioactual;
            label2.Text="Bienvenido";
            ventas.agregar();
            ventas.agregarP();
            ventas.agregarS();
            dgw_Productos.Rows.Add();
            dgw_Productos.Rows[0].Cells[0].Value = "Codigo";
            dgw_Productos.Rows[0].Cells[1].Value = "Producto";
            dgw_Productos.Rows[0].Cells[2].Value = "Precio";

            for (int i=0;i<10;i++)
            {

                int n = dgw_Productos.Rows.Add();
                dgw_Productos.Rows[n].Cells[0].Value = i+1;
                dgw_Productos.Rows[n].Cells[1].Value = ventas.Productos[i];
                dgw_Productos.Rows[n].Cells[2].Value = ventas.Precios[i];
            }
            dgw_Consulta.Rows.Add();
            dgw_Consulta.Rows[0].Cells[0].Value = "Codigo";
            dgw_Consulta.Rows[0].Cells[1].Value = "Producto";
            dgw_Consulta.Rows[0].Cells[2].Value = "Stock";


        }

        private void Formulario_interno_Load(object sender, EventArgs e)
        {

        }

        private void Formulario_interno_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            txb_Consultar.Clear();
        }

        private void btn_Ordenar_Click(object sender, EventArgs e)
        {

            
       
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (txb_Consultar.Text == "todos" || txb_Consultar.Text == "TODOS")
            {
                dgw_Consulta.Rows.Clear();
                for (int i = 0; i < 10; i++)
                {

                    int n = dgw_Consulta.Rows.Add();
                    dgw_Consulta.Rows[n].Cells[0].Value = i + 1;
                    dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[i];
                    dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[i];
                }
            }
            else if (txb_Consultar.Text == "huevos" || txb_Consultar.Text == "HUEVOS" || txb_Consultar.Text == "1")
            {
                dgw_Consulta.Rows.Clear();
                int n = dgw_Consulta.Rows.Add();
                dgw_Consulta.Rows[n].Cells[0].Value = 1;
                dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[0];
                dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[0];
            }
            else if (txb_Consultar.Text == "pollo" || txb_Consultar.Text == "POllO" || txb_Consultar.Text == "2")
            {
                dgw_Consulta.Rows.Clear();
                int n = dgw_Consulta.Rows.Add();
                dgw_Consulta.Rows[n].Cells[0].Value = 2;
                dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[1];
                dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[1];
            }
            else if (txb_Consultar.Text == "aceite" || txb_Consultar.Text == "ACEITE" || txb_Consultar.Text == "3")
            {
                dgw_Consulta.Rows.Clear();
                int n = dgw_Consulta.Rows.Add();
                dgw_Consulta.Rows[n].Cells[0].Value = 3;
                dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[2];
                dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[2];
            }
            else if (txb_Consultar.Text == "dulces" || txb_Consultar.Text == "DULCES" || txb_Consultar.Text == "5")
            {
                dgw_Consulta.Rows.Clear();
                int n = dgw_Consulta.Rows.Add();
                dgw_Consulta.Rows[n].Cells[0].Value = 5;
                dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[4];
                dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[4];
            }
            else if (txb_Consultar.Text == "fosforos" || txb_Consultar.Text == "FOSFOROS" || txb_Consultar.Text == "4" || txb_Consultar.Text == "fósforos" || txb_Consultar.Text == "FOSFÓROS")
            {
                dgw_Consulta.Rows.Clear();
                int n = dgw_Consulta.Rows.Add();
                dgw_Consulta.Rows[n].Cells[0].Value = 4;
                dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[3];
                dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[3];
            }
            else if (txb_Consultar.Text == "margarina" || txb_Consultar.Text == "MARGARINA" || txb_Consultar.Text == "6")
            {
                dgw_Consulta.Rows.Clear();
                int n = dgw_Consulta.Rows.Add();
                dgw_Consulta.Rows[n].Cells[0].Value = 6;
                dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[5];
                dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[5];
            }
            else if (txb_Consultar.Text == "jabón" || txb_Consultar.Text == "JABÓN" || txb_Consultar.Text == "7" || txb_Consultar.Text == "JABON" || txb_Consultar.Text == "jabon")
            {
                dgw_Consulta.Rows.Clear();
                int n = dgw_Consulta.Rows.Add();
                dgw_Consulta.Rows[n].Cells[0].Value = 7;
                dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[6];
                dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[6];
            }
            else if (txb_Consultar.Text == "carne" || txb_Consultar.Text == "CARNE" || txb_Consultar.Text == "8")
            {
                dgw_Consulta.Rows.Clear();
                int n = dgw_Consulta.Rows.Add();
                dgw_Consulta.Rows[n].Cells[0].Value = 8;
                dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[7];
                dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[7];
            }
            else if (txb_Consultar.Text == "gaseosa" || txb_Consultar.Text == "GASEOSA" || txb_Consultar.Text == "9")
            {
                dgw_Consulta.Rows.Clear();
                int n = dgw_Consulta.Rows.Add();
                dgw_Consulta.Rows[n].Cells[0].Value = 9;
                dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[8];
                dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[8];
            }
            else if (txb_Consultar.Text == "desechables" || txb_Consultar.Text == "DESECHABLES" || txb_Consultar.Text == "10")
            {
                dgw_Consulta.Rows.Clear();
                int n = dgw_Consulta.Rows.Add();
                dgw_Consulta.Rows[n].Cells[0].Value = 10;
                dgw_Consulta.Rows[n].Cells[1].Value = ventas.Productos[9];
                dgw_Consulta.Rows[n].Cells[2].Value = ventas.Stock[9];
            }
            else
            {
                MessageBox.Show("El elemento mencionado no existe o esta mal escrtito, ingrese de nuevo el codigo o el nombre porfavor");
            }


        }
    }
}
