using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VentasExpress
{
    public partial class Form1 : Form
    {

        Usuario Datos = new Usuario();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formulario_interno form2 = new Formulario_interno();

            if(txb_Usuario.Text==Datos.Usuario1 && txb_Contraseña.Text == Datos.Contraseña1)
            {
                Datos.Usuario1 = Datos.Usuarioactual;
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
            else if(txb_Usuario.Text == Datos.Usuario2 && txb_Contraseña.Text == Datos.Contraseña2)
            {
                Datos.Usuario2 = Datos.Usuarioactual;
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
            else if (txb_Usuario.Text == Datos.Usuario3 && txb_Contraseña.Text == Datos.Contraseña3)
            {
                Datos.Usuario3 = Datos.Usuarioactual;
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("la contraseña o el usuario estan incorrectos");
            }

            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Ingresar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
