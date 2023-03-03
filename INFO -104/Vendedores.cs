using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFO__104
{
    internal class Vendedores
    {
        Dictionary<int, string> vendedor = new Dictionary<int, string>

        {
            {1,"Pamela"},
            {2,"Pablo"}
        };
        public Vendedores() { }

        public void ListadoVendedores()
        {
            foreach (KeyValuePair<int, string> item in vendedor)
            {
                Console.WriteLine("Vendedor " + item.Key + " es: " + item.Value);
            }
        }
        
        public string codigovendedor(int ID)
        {
            string valor;


            if (vendedor.TryGetValue(ID, out valor))
            {
                return valor;
            }
            else
            {
                return "Vendedor no encontrado";
            }
        }
    }
}

