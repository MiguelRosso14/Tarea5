using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5
{
    class EntradaInventario
    {
        private List<Producto> cantidad { get; set; } = new List<Producto>();

        public void ProcesoDeInscripcion()
        {
            Console.Clear();
            ServicioProducto servicioProducto = new ServicioProducto();

            servicioProducto.Listarproducto();

            Console.WriteLine("Digite la cantidad que desea almacenar: ");
            int IndexCantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Repositorio.Instancia.productos.Count; i++)
            {
                Producto cantidadIntegrado = Repositorio.Instancia.productos[i];
                Console.WriteLine((i + 1 + "- " + cantidadIntegrado.Nombre));
            }

            Producto ProductoSeleccionada = Repositorio.Instancia.productos[IndexCantidad - 1];

            cantidad.Add(ProductoSeleccionada);

        }
    }
}
