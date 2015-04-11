using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
     class Circulo : Figura
    {
           double raio;
           static double pi = 3.1415;
           double circunferencia;

           public Circulo(int x, int y, double raio)
        {

            px = x;
            py = y;
            this.raio = raio;

            circunferencia = Math.PI * Math.Pow(raio,2);
         }
            public override String Imprime()
            {
                return "Circulo[x:" + this.px + ",y:" + this.py + ",raio:" + this.raio + ",circunferência:" + circunferencia + "]";
            }

    }
}