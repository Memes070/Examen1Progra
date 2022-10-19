using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra
{
    internal class Tipo
    {
        List<String> tipo = new List<String>() { "Motocicleta", "Automovil", "Dron" };
        int a = 0;
        


        public Tipo()
        {

        }

        public Boolean BuscarTipo(string valor)
        {
            Boolean existe = tipo.Contains(valor);

            return existe;
        }
    }
}
