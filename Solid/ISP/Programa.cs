using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            IImpresora impresora = new Impresora();
            impresora.Imprimir();

            IFax multifuncionalFax = new Multifuncional();
            multifuncionalFax.EnviarFax();
        }
    }
}