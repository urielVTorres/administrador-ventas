using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }
        public int Cantidad { get; set; }
        public float PrecioPaquete { get; set; }
        public float PrecioUnitario { get; set; }
        public Producto(string name, string barcode, int cantidad, float precioP, float precioU) 
        {
            StreamReader existencia = new StreamReader($@"..\..\..\Inventario\Existencia.txt");
            Id = Int32.Parse(existencia.ReadLine());
            existencia.Close();
            Name = name;
            BarCode = barcode;
            Cantidad = cantidad;
            PrecioPaquete = precioP;
            PrecioUnitario = precioU;
        }

        public void AgregarInventario()
        {
            StreamWriter s = new StreamWriter($@"..\..\..\Inventario\Productos\producto{this.Id}.txt");
            string producto = $"{this.Id},{this.Name},{this.BarCode},{this.Cantidad},{this.PrecioPaquete},{this.PrecioUnitario}";
            s.WriteLine(producto);
            s.Close();
            int i = this.Id;
            i++;

            StreamWriter existencia = new StreamWriter($@"..\..\..\Inventario\Existencia.txt");
            existencia.WriteLine(i);
            existencia.Close();

        }

    }
}
