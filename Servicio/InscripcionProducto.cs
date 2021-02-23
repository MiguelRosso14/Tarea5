using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5
{
    public class InscripcionProducto 
    {

        private List<Categoria> categoriasseleccionadas { get; set; } = new List<Categoria>();
        private bool Validarproductos()
        {
            if (Repositorio.Instancia.productos.Count <= 0)
            {
                return false;
            }

            return true;
        }
        private bool Validarcategoria()
        {
            if (Repositorio.Instancia.categorias.Count <= 0)
            {
                return false;
            }

            return true;
        }
        public void Inscribir()
        {
            MenuPrincipal menu = new MenuPrincipal();
            ServicioProducto servicioproducto = new ServicioProducto();

            if (Validarproductos() == false)
            {
                Console.WriteLine("No hay productos de momento");
                Console.ReadKey();
                menu.ImprimirMenu();
            }
            if (Validarcategoria() == false)
            {
                Console.WriteLine("No hay categorias de momento");
                Console.ReadKey();
                menu.ImprimirMenu();
            }

            Console.WriteLine("Seleccione el producto que desee listar: ");
            int Indexinscripcion = Convert.ToInt32(Console.ReadLine());

            Producto ProductoAListar = Repositorio.Instancia.productos[Indexinscripcion - 1];

            ProcesoDeInscripcion();
            Repositorio.Instancia.productos[Indexinscripcion -1].categoriasinscritas = categoriasseleccionadas;

            Console.WriteLine("El producto a sido inscrito con exito");
            Console.ReadKey();

            menu.ImprimirMenu();
        }

        public void ProcesoDeInscripcion()
        {
            Console.Clear();
            ServicioCategoria servicioCategoria = new ServicioCategoria();

            servicioCategoria.Listarcategoria();
            Console.WriteLine("Seleccione la categoria a inscribir");
            int IndexCategorias = Convert.ToInt32(Console.ReadLine());

            Categoria CategoriaSeleccionada = Repositorio.Instancia.categorias[IndexCategorias - 1];

            categoriasseleccionadas.Add(CategoriaSeleccionada);
        }
    }
}
