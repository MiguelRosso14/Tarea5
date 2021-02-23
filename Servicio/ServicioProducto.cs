using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5
{
    public class ServicioProducto
    {
        private List<Categoria> categoriasseleccionadas { get; set; } = new List<Categoria>();

        private bool Validarcategoria()
        {
            if (Repositorio.Instancia.categorias.Count <= 0)
            {
                return false;
            }

            return true;
        }

        public void Agregarproducto()
        {
            Console.WriteLine("Ingrese el nombre del producto");
            string nombreproducto = Console.ReadLine();
            Producto nuevoproducto = new Producto(nombreproducto);
            Repositorio.Instancia.productos.Add(nuevoproducto);

            Console.WriteLine("Ingrese el precio del producto");
            double precio = double.Parse(Console.ReadLine());
            Producto precioproducto = new Producto(precio);
            Repositorio.Instancia.productos.Add(precioproducto);

            Console.WriteLine("se agrego con exito");
            Console.ReadKey();

            MenuPrincipal menu = new MenuPrincipal();
            ServicioProducto servicioproducto = new ServicioProducto();


            if (Validarcategoria() == false)
            {
                Console.WriteLine("No hay categorias de momento");
                Console.ReadKey();
                menu.ImprimirMenu();
            }

            servicioproducto.Listarproducto();

            Console.WriteLine("Seleccione el producto que desee listar: ");
            int Indexinscripcion = Convert.ToInt32(Console.ReadLine());

            Producto ProductoAListar = Repositorio.Instancia.productos[Indexinscripcion - 1];

            ProcesoDeInscripcion();
            Repositorio.Instancia.productos[Indexinscripcion - 1].categoriasinscritas = categoriasseleccionadas;

            Console.WriteLine("El producto a sido inscrito con exito");
            Console.ReadKey();

            menu.ImprimirMenu();
          
        }
        public  void Listarproducto()
        {
            for (int i = 0; i < Repositorio.Instancia.productos.Count; i++)
            {
                Producto productoIntegrado = Repositorio.Instancia.productos[i];
                Console.WriteLine((i + 1 + "- " + productoIntegrado.Nombre));
            }
        }

        public void Borrarproducto()
        {
            Listarproducto();
            Console.WriteLine("Seleccione el producto que desee borrar");
            int ProductoAEliminar = Convert.ToInt32(Console.ReadLine());

            Repositorio.Instancia.productos.RemoveAt(ProductoAEliminar - 1);
            Console.WriteLine("Se ha eliminado con exito");
            Console.ReadKey();
        }

        public void Editarproducto()
        {
            Listarproducto();
            Console.WriteLine("Seleccione el producto que desee editar");
            int ProductoAEditar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo nombre");
            string nuevoproducto = Console.ReadLine();

            Console.WriteLine("Ingrese el precio");
            double nuevoprecio = double.Parse(Console.ReadLine());

            Repositorio.Instancia.productos[ProductoAEditar - 1].Nombre = nuevoproducto;
            Repositorio.Instancia.productos[ProductoAEditar - 1].Precio = nuevoprecio;

            MenuPrincipal menu = new MenuPrincipal();
            ServicioProducto servicioproducto = new ServicioProducto();


            if (Validarcategoria() == false)
            {
                Console.WriteLine("No hay categorias de momento");
                Console.ReadKey();
                menu.ImprimirMenu();
            }

            servicioproducto.Listarproducto();

            Console.WriteLine("Seleccione el producto que desee listar: ");
            int Indexinscripcion = Convert.ToInt32(Console.ReadLine());

            Producto ProductoAListar = Repositorio.Instancia.productos[Indexinscripcion - 1];

            ProcesoDeInscripcion();
            Repositorio.Instancia.productos[Indexinscripcion - 1].categoriasinscritas = categoriasseleccionadas;

            Console.WriteLine("El producto a sido inscrito con exito");
            Console.ReadKey();

            menu.ImprimirMenu();


            Console.WriteLine("Se ha editado con exito");
            Console.ReadKey();
        }
        public void Listarinscripcion()
        {
            int i = 1;
            int j = 1;

            foreach (Producto item in Repositorio.Instancia.productos)
            {
                j = 1;
                Console.WriteLine((i)+ "- " + item.Nombre);

                Console.WriteLine("Categorias inscritas");

                foreach (Categoria categoria in item.categoriasinscritas)
                {
                    Console.WriteLine((j ) + "- " + categoria.nombre);
                    j++;
                }
                i++;
            }
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

            Console.WriteLine("Desea agregar otro categoria? S/N");
            string respuesta = Console.ReadLine();

            if (respuesta == "S")
            {
                ProcesoDeInscripcion();
            }
        }
    }
}
