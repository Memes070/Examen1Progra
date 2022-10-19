using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra
{
    internal class Vendedores
    {

        private static Dictionary<string, string> VendedoresDictionary = new Dictionary<string, string>()
        {

            {"1" , "Vendedor 1" },
            {"2" , "Vendedor 2" },
            {" " , "  " }

        };

        public static void ListadoVendedores() 
        {
            foreach(var ser in VendedoresDictionary)
            {
                Console.WriteLine(VendedoresDictionary);
            }
        }

        public static String CodigoVendedor(string value)
        {
            string result;
            if(VendedoresDictionary.TryGetValue(value, out result))
            {
                Console.WriteLine(result);
            }
            return value;
        }
    }
}
