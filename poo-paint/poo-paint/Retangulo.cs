using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Retangulo : Figura
    {
        int bretangulo;
        int hretangulo;
        static int contador;

        public Retangulo(int ax, int ay, int altura, int largura)
        {

            px = ax;
            py = ay;
            hretangulo = altura;
            bretangulo = largura;
            contador++;
        }

        public override String Imprime()
        {
            return "retangulo[x:" + this.px + ",y:" + this.py + ",l:" + this.plargura + ",a:" + this.paltura + "]";
        }

        public static void ZeraContador()
        {

            contador = 0;

        }

        public static int LeContador()
        {

            return contador;

        }

    }
}