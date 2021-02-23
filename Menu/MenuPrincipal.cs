using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5
{
    public class MenuPrincipal : iMenu
    {
        public void ImprimirMenu()
        {
            try
            {
                InscripcionProducto inventario = new InscripcionProducto();
                EntradaInventario entrada = new EntradaInventario();

                iMenu menu;
                Console.Clear();
                Console.WriteLine("1-Mantenimiento de categorias \n " +
                                  "2-Mantenimiento de productos \n " +
                                  "3-Entrada de inventario \n " +
                                  "4-Salida de inventario \n " +
                                  "5-Salir");
                Console.Write("Eliga que desea hacer:");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        menu = new MenuCategorias();
                        menu.ImprimirMenu();
                        break;
                    case 2:
                        menu = new MenuProducto();
                        menu.ImprimirMenu();
                        break;
                    case 3:
                        entrada.ProcesoDeInscripcion();
                        break;
                    case 4:
                        Console.WriteLine("Salida de inventario");
                        break;
                    case 5:
                        Console.WriteLine("Salida");
                        break;
                    default:
                        Console.WriteLine("Debe elegir una opcion existente");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe elegir una opcion existente");
                Console.ReadKey();
                ImprimirMenu();
            }
        }
    }
}
