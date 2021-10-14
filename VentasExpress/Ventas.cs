using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasExpress
{
    class Ventas
    {

        string[] productos;

        public void agregar()
        {
            productos = new string[10];
            productos[0] = "Huevos";
            productos[1] = "Pollo";
            productos[2] = "Aceite";
            productos[3] = "Fósforos";
            productos[4] = "Dulces";
            productos[5] = "Margarina";
            productos[6] = "Jabón";
            productos[7] = "Carne";
            productos[8] = "Gaseosa";
            productos[9] = "Desechables";
        }

        public string[] Productos
        {
           
            get { return productos; }
            set { productos = value; }
        }

        double[] precios;

        public void agregarP()
        {
            precios = new double[10];
            precios[0] = 0.10;
            precios[1] = 5;
            precios[2] = 3;
            precios[3] = 0.5;
            precios[4] = 0.8;
            precios[5] = 0.3;
            precios[6] = 2.25;
            precios[7] = 2.75;
            precios[8] = 2.75;
            precios[9] = 3.25;
        }

        public double[] Precios
        {
            get { return precios; }
            set { precios = value; }
        }

        int[] stock;

        public void agregarS()
        {
            stock = new int[10];
            stock[0] = 30;
            stock[1] = 10;
            stock[2] = 50;
            stock[3] = 200;
            stock[4] = 500;
            stock[5] = 30;
            stock[6] = 25;
            stock[7] = 35;
            stock[8] = 200;
            stock[9] = 800;
        }

        public int[] Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
