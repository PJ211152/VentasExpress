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
        public Formulario_interno()
        {
            InitializeComponent();
            
        }

        private void Formulario_interno_Load(object sender, EventArgs e)
        {

        }

        private void Formulario_interno_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }
    }
}
