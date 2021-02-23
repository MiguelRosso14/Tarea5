using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5
{
    class MenuCategorias : iMenu
    {
        private ServicioCategoria categoria{get; set;} 


        public MenuCategorias()
        {
            categoria = new ServicioCategoria();
        }
        public void ImprimirMenu()
        {
            try
            {
                MenuPrincipal menu = new MenuPrincipal();
                Console.Clear();
                Console.WriteLine("1-Agregar categoria" +
                                  "\n2-Editar categoria" +
                                  "\n3-Eliminar categoria" +
                                  "\n4-Listar categoria" +
                                  "\n5-Volver atras");
                Console.WriteLine("Eliga una de las opciones:");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        categoria.agregarcategoria();
                        ImprimirMenu();
                        break;
                    case 2:
                        categoria.Editarcategoria();
                        ImprimirMenu();
                        break;
                    case 3:
                        categoria.Borrarcategoria();
                        ImprimirMenu();
                        break;
                    case 4:
                        categoria.Listarcategoria();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case 5:
                        menu.ImprimirMenu();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    default:
                        Console.WriteLine("Debe elegir una opcion valida");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe elegir una opcion valida");
                Console.ReadKey();
                ImprimirMenu();
            }
        }
    }
}
