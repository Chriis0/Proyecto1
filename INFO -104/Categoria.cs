using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFO__104
{
    internal class Categoria
    {
        public static void promocion()
        {
            Console.WriteLine("Descuentos y promociones");
        }

        public List<float> listacategoria = new List<float>() { 0.15f, 2f , 0.50f  };

        public List<string> listacategorias = new List<string>() { "Descuento de 15%", "Promoción 2 x 1", "Todo a mitad de precio" };

        public void listadocategorias()
        {
            int x = 0;

            for (int i =0; i<listacategorias.Count; i++)
            {
                x = x + 1;
                Console.WriteLine("Categoria " + x + " es: " + listacategorias[i]);
            }
        }

        public float ListadoCategoria(int facu) 
        {

            Categoria1 categoria1 = new Categoria1();
            Categoria2 categoria2 = new Categoria2();
            Categoria3 categoria3 = new Categoria3();
            

            Console.Write("Ingrese la categoria escogida:  ");
            int k = int.Parse(Console.ReadLine());

            bool t = true;


            do 
            {

                t = verificar(k-1);

                if (t == false)
                {
                    Console.Write("Categoria no encontrada, vuelve a ingresar una Categoria:  ");
                    k = int.Parse(Console.ReadLine());
                }
               

            } while (t == false);

            switch (k)
            {
                case 1:
                    categoria1.promocion();
                    
                    return listacategoria[0];
                case 2:
                    categoria2.promocion();
                    facu = 1;
                    return listacategoria[1];
                case 3:
                    categoria3.promocion();
                    return listacategoria[2];
            }
            return 0;
        }

        public bool verificar(int prod)
        {
            if (prod >= 3 || prod < 0 )
            {
                return false;
            }
            else { return true; }


        }
    }
}
