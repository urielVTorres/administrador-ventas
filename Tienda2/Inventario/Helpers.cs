using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2.Inventario
{
    internal class Helpers
    {
        public Helpers()
        {

        }
        public List<Producto> leerProductos()
        {
            List<Producto> productos= new List<Producto>();

            StreamReader existencia = new StreamReader($@"..\..\..\Inventario\Existencia.txt");
            int num = Int32.Parse(existencia.ReadLine());
            existencia.Close();

            for(int i = 0; i < num; i++)
            {
                StreamReader producto = new StreamReader($@"..\..\..\Inventario\Productos\producto{i}.txt");
                string aux = producto.ReadLine();
                string[] info = aux.Split(',');
                Producto prod = new Producto(info[1], info[2], Int32.Parse(info[3]), float.Parse(info[4]), float.Parse(info[5]));
                productos.Add(prod);
            }

            return productos;
        }
    }
}
