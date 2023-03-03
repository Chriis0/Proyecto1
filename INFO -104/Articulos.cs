using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace INFO__104
{
    internal class Articulos
    {
        protected string codigo;
        protected string nombre;
        protected float precio;


        public List<string> Agregarproducto = new List<string>();
        public List<string> Agregarnombre = new List<string>();
        public List<float> Agregarprecio = new List<float>();


        public Articulos() { }
        


        public Articulos(string Codigo, string Nombre, float Precio)
        {
            this.codigo = Codigo;
            this.nombre = Nombre;
            this.precio = Precio;
        }

        public string getCodigo() 
        {
            return codigo;
        }

        public void setCodigo(string Codigo) 
        {
            this.codigo = Codigo;
        }
        public string getNombre() 
        {
            return nombre;
        }

        public void setNombre (string Nombre)
        {
            this.nombre = Nombre;
        }

        public float getPrecio ()
        {
            return precio;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }


        public  void AgregarArticulo()
        {


            Articulos articulos = new Articulos();

            int cantidad = Agregarnombre.Count; //dinámico



            if (cantidad < 5)
            {

                Console.Write("Ingrese el codigo del producto:  ");
                string Codigp = Console.ReadLine();
                articulos.codigo = Codigp;

                Console.Write("Ingrese el nombre del producto:  ");
                string Nombrep = Console.ReadLine();
                articulos.nombre = Nombrep;


                Console.Write("Ingrese el precio del producto:  ");
                float Preciop = float.Parse(Console.ReadLine());
                articulos.precio = Preciop;

                Agregarproducto.Add(articulos.getCodigo());
                Agregarnombre.Add(articulos.getNombre());
                Agregarprecio.Add(articulos.getPrecio());
            }
            else 
            {
                Console.WriteLine("Cantidad máxima de articulos ingresada");

                } return;
             
        }

        public void ConsultarArticulo()

        {
            int cantidad = Agregarnombre.Count; 

            Console.WriteLine("Consultar lista de productos");

            for (int i = 0; i < cantidad ; i++)
            {
                Console.WriteLine("Codigo del producto:  " + Agregarproducto[i]);
                Console.WriteLine("Nombre del producto:  " + Agregarnombre[i]);
                Console.WriteLine("Precio del producto:  " + Agregarprecio[i]);
                                                    Console.WriteLine("******");
            } return;

        }

        public void BorrarArticulo()

        {
          
            Console.WriteLine("Borrar lista de producto");
            bool mer = true;
            do
            {
               int  cantidad = Agregarnombre.Count;

                Console.WriteLine("Ingrese el nombre del producto que desea borrar:  ");

                string name = Console.ReadLine();
                int bora = 0;

                for (int i = 0; i < cantidad  ; i++)
                {
                    if (Agregarnombre[i].Equals(name))
                    {
                        bora = i;
                    }
                }

                Agregarnombre.RemoveAt(bora);
                Agregarproducto.RemoveAt(bora);
                Agregarprecio.RemoveAt(bora);

                Console.Write("¿Desea borrar otro producto?  s/n" );

                string lit = Console.ReadLine();

                if (lit.Equals("n")) 
                {
                    mer = false;
                        return;
                } 


            } while (mer == true);

        }

        public int Validar() 
        {
           
            Console.Write("Ingrese el codigo articulo:  ");

            string articuloBuscado = Console.ReadLine();

            for (int i = 0; i < Agregarproducto.Count; i++)
            {
                if (Agregarproducto.Contains(articuloBuscado))
                {
                    Console.WriteLine("El artículo existe en la lista.");
                    return Agregarproducto.IndexOf(articuloBuscado);
                } 
            }
            return  10;
        } 
        //IndexOf devolder la posición del artículo
    }
}
