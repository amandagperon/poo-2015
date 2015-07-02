using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
     class Circulo : Figura
    {
           int raio;
           static double pi = 3.1415;
           static int pcontador;
           public Circulo(int x, int y, int raio)
        {

            px = x;
            py = y;
            this.raio = raio;

            pcontador += 1;
        }

           public override string Imprime()
           {
               return "circulo[x:" + px + ",y:" + py + ",raio:" + this.raio + "]";
           }

           public static void ZeraContador()
           {
               pcontador = 0;
           }

           public static int LeContador()
           {
               return pcontador;
           }

           public override void Desenha(Graphics g)
           {
               g.DrawEllipse(Pens.Black, px, py, (this.raio * 2), (this.raio * 2));
           }
           public override string GeraLinhaArquivo()
           {
               return "Circulo\r\n" + px + "\r\n" + py + "\r\n" + this.raio;
           }
    }
 }
