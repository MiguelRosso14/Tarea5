using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5
{
    class ServicioCategoria
    {
        public void agregarcategoria()
        {

            Console.WriteLine("Ingrese el nombre de la nueva categoria");
            string nombrecategoria = Console.ReadLine();

            Categoria nuevacategoria = new Categoria(nombrecategoria);

            Repositorio.Instancia.categorias.Add(nuevacategoria);
            Console.WriteLine("se agrego con exito");
            Console.ReadKey();
        }
        public void Listarcategoria()
        {
            for (int i = 0; i < Repositorio.Instancia.categorias.Count; i++)
            {
                Categoria categoriaIntegrada = Repositorio.Instancia.categorias[i];
                Console.WriteLine((i + 1 + "- " + categoriaIntegrada.nombre));
            }
        }
        public void Borrarcategoria()
        {
            Listarcategoria();
            Console.WriteLine("Seleccione la categoria que desee borrar");
            int CategoriaAEliminar = Convert.ToInt32(Console.ReadLine());

            Repositorio.Instancia.categorias.RemoveAt(CategoriaAEliminar - 1);
            Console.WriteLine("Se ha eliminado con exito");
            Console.ReadKey();
        }
        public void Editarcategoria()
        {
            Listarcategoria();
            Console.WriteLine("Seleccione la categoria que desee editar");
            int CategoriaAEditar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo nombre");
            string nuevonombre = Console.ReadLine();

            Repositorio.Instancia.categorias[CategoriaAEditar - 1].nombre = nuevonombre;
            Console.WriteLine("Se ha editado con exito");
            Console.ReadKey();
        }
    }
}
