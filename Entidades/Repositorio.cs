using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5
{
    public class Repositorio
    {
        public static Repositorio Instancia { get; } = new Repositorio();
        public List<Categoria> categorias { get; set; } = new List<Categoria>();
        public List<Producto> productos { get; set; } = new List<Producto>();

        private Repositorio()
        {

        }
    }
}
