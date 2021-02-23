using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5
{
    public class MenuProducto : iMenu
    {
        public static List<string> productos = new List<string>();
        private ServicioProducto servicio { get; set; }

        public MenuProducto()
        {
            servicio = new ServicioProducto();
        }

        public void ImprimirMenu()
        {
            try
            {
                MenuPrincipal menu = new MenuPrincipal();
                Console.Clear();
                Console.WriteLine(" 1-Agregar producto" +
                                  "\n2-Listar producto" +
                                  "\n3-Editar producto" +
                                  "\n4-Eliminar producto" +
                                  "\n5-Listar inscripcion" +
                                  "\n6- Volver al menu anterior");
                Console.WriteLine("Eliga una de las opciones:");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        servicio.Agregarproducto();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case 2:
                        servicio.Listarproducto();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case 3:
                        servicio.Editarproducto();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case 4:
                        servicio.Borrarproducto();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case 5:
                        servicio.Listarinscripcion();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case 6:
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
