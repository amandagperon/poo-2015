using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    class Linha : Figura
    {
        private int xini;
        private int yini;
        private int xfim;
        private int yfim;

        public Linha(int xi, int yi, int xf, int yf)
        {
            xini = xi;
            yini = yi;
            xfim = xf;
            yfim = yf;
        }
        public override string GeraLinhaArquivo()
        {
            return "Linha\r\n" + xini + "\r\n" + yini + "\r\n" + xfim + "\r\n" + yfim;
        }

        public override void Desenha(Graphics g)
        {
            g.DrawLine(Pens.Black, xini, yini, xfim, yfim);
        }
    }
}
