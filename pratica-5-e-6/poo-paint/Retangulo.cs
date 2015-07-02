using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Retangulo(int ax, int ay, int largura, int altura)
        {

            px = ax;
            py = ay;
            hretangulo = altura;
            bretangulo = largura;
            contador++;
        }

        public override String Imprime()
        {
            return "retangulo[x:" + this.px + ",y:" + this.py + ",l:" + this.bretangulo + ",a:" + this.hretangulo + "]";
        }

        public static void ZeraContador()
        {

            contador = 0;

        }

        public static int LeContador()
        {

            return contador;

        }

        public override void Desenha(Graphics g)
        {
            g.DrawRectangle(Pens.Black, px, py, bretangulo, hretangulo);
        }
        public override string GeraLinhaArquivo()
        {
            return "Retangulo\r\n" + px + "\r\n" + py + "\r\n" + bretangulo + "\r\n" + hretangulo;
        }
    }
}