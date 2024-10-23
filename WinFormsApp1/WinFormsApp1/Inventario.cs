using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Inventario
    {
        public int CantidadInventario {  get; set; }

        public string IdProducto { get; set; }

        public string NombreProducto { get; set; }

        public Inventario() 
        {
            CantidadInventario = 10;
        }
    }
}
