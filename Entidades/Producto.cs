using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5
{
    public class Producto
    {
        private object nombre;
        public string mas { get; set; }
        public string Nombre { get; set; }
        public Double Precio { get; set; }
        public List<Categoria> categoriasinscritas { get; set; }

        public Producto(object nombre)
        {
            this.nombre = nombre;
        }
        public string Productos(string nombre) => this.Nombre = nombre;
    }
}
