﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Figura
    {
        protected int px;
        protected int py;

        public virtual string Imprime()
        {
            return "figura[x:" + px + ",y:" + py + "]";
        }
        //Responsabilidade de desenhar

        public virtual void Desenha(Graphics g)
        {
        }
        public virtual string GeraLinhaArquivo()
        {
            return "Figura(x, y, l, a)";
        }
    }
}
