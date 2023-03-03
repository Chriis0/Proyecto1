using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace INFO__104
{
    internal class Menu
    {
       public static Vendedores vendedores = new Vendedores();
       public static Categoria categoria = new Categoria();
       public static Articulos articulos = new Articulos();

        public static void menu()
        {

            byte opcion = 0;

            do
            {
                Console.WriteLine("1- Articulos");
                Console.WriteLine("2- Facturacion");
                Console.WriteLine("3- Reporte");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1- Articulos"); ArticuloSubMenu();
                        break;
                    case 2:
                        Console.WriteLine("2- Facturación"); Facturacion();
                        break;
                    case 3:
                        Console.WriteLine("3- Reporte"); Reporte();
                        break;
                    case 4:
                        Console.WriteLine("4- Salir");
                        break;
                    default:
                        break;
                }

            } while (opcion != 4);
        }

       public static void ArticuloSubMenu()

        {
            
            int opcionArticulos = 0;

            do
            {
                Console.WriteLine("1 - Agregar");
                Console.WriteLine("2 - Borrar");
                Console.WriteLine("3 - Consultar");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");
                opcionArticulos = int.Parse(Console.ReadLine());

                switch (opcionArticulos)
                {

                    case 1:
                        Console.WriteLine("1 - Agregar"); articulos.AgregarArticulo();
                        break;
                    case 2:
                        Console.WriteLine("2 - Borrar"); articulos.BorrarArticulo();
                        break;
                    case 3:
                        Console.WriteLine("3 - Consultar"); articulos.ConsultarArticulo();
                        break;
                    case 4:
                        Console.WriteLine("4 - Salir"); 
                        break;
                    default:
                        break;
                }
            } while (opcionArticulos != 4);
        }

        public static void Facturacion()
        {

            int cantidad = articulos.Agregarproducto.Count;

            int bora = articulos.Validar();

            int facu = 0;

            if (bora != 10)

            {
                Console.WriteLine("Ingrese su codigo de vendedor:  ");
                int cod = int.Parse(Console.ReadLine());
                string menavendedor = vendedores.codigovendedor(cod);

                do
                {

                    Console.WriteLine(menavendedor + "Vuelva ingresar su codigo");
                     cod = int.Parse(Console.ReadLine());
                     menavendedor = vendedores.codigovendedor(cod);

                } while (menavendedor == "Vendedor no encontrado") ;
                Console.WriteLine("El nombre del vendedr es:  " + menavendedor);

                float valicate = categoria.ListadoCategoria(facu);
                string mes;

                if (facu == 0)
                {
                    float des = valicate * articulos.Agregarprecio[bora];
                    float total = articulos.Agregarprecio[bora] - des;
                    mes = "El precio total es:  " + total + "\n La cantidad de articulo es:  " + 1;
                }
                else
                {
                    mes = "El precio total es:  " + articulos.Agregarprecio[bora] + "\n La cantidad de articulo es: " + valicate;
                }

                Console.WriteLine("El nombre del articulo es:  " + articulos.Agregarnombre[bora]);
                Console.WriteLine("El precio del articulo es:  " + articulos.Agregarprecio[bora]);

                Console.WriteLine(mes);

            } else { Console.WriteLine("El articulo no existe"); }
        }

        public static void Reporte() 
        {

            Console.WriteLine("Los vendedores son:  ");

            vendedores.ListadoVendedores();

            Console.WriteLine("*************");

            Console.WriteLine("La categoria es:  ");
            categoria.listadocategorias();

            Console.WriteLine("*************");

            Console.WriteLine("Los articulos son:  ");
            articulos.ConsultarArticulo();


        }
    }
}

        
