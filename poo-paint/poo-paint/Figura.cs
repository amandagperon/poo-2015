using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
   class Figura
    {
        public int px;
        public int py;

        public virtual string Imprime()
        {

            return "Figura ["               + "]";
        }
    }

}