using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica13
{
    class SumaNumeros
    {
        public int Suma()
        {
            int suma = 0;
            for (int i =1; i <=50; i++)
            {
                suma = suma + i;
            }
            return (suma);
        }
    }
}
