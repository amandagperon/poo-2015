using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    public partial class AreaDeDesenho : Form
    {
        private static int qtdfiguras = 0;
        Figura[] figuras = new Figura[0];
        private int xinicial;
        private int yinicial;
        private bool desenhando = false;
        private string desenhos = "";


        public AreaDeDesenho()
        {
            InitializeComponent();
            comboxFerramenta.Items.Add("Retangulo");
            comboxFerramenta.Items.Add("Circulo");
            comboxFerramenta.Items.Add("Linha");
            comboxFerramenta.SelectedIndex = 0;
        }

        // método para adicionar figuras
        public void AdicionaFigura(Figura f)
        {
            qtdfiguras++;
            Array.Resize(ref figuras, (qtdfiguras));
            figuras[qtdfiguras - 1] = f;
        }
        
        //Código incluido conforme orientação ex 5. 
        public void Desenha(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < this.figuras.Length; i++)
            {
                Figura f = new Figura();
                f = this.figuras[i];
                f.Desenha(g);
                desenhos += f.GeraLinhaArquivo();
                desenhos += Environment.NewLine;
            }
        }
        //Este evento pega as posições X e Y do clique do mouse. 
        private void DesenhaCliqueInicial(object sender, MouseEventArgs e)
        {
            xinicial = e.X;
            yinicial = e.Y;
            desenhando = true;
        }
        private void DesenhaCliqueFinal(object sender, MouseEventArgs e)
        {
            if (comboxFerramenta.SelectedIndex == 0)
            {
                DesenhaCliqueRetangulo(e.X, e.Y);
            }
            else if (comboxFerramenta.SelectedIndex == 1)
            {
                DesenhaCliqueCirculo(e.X, e.Y);
            }
            else if (comboxFerramenta.SelectedIndex == 2)
            {
                DesenhaCliqueLinha(e.X, e.Y);
            }

            desenhando = false;
        }

        private void DesenhaCliqueCirculo(int xfinal, int yfinal)
        {
            if (xfinal > xinicial)
            {
                if (yfinal > yinicial)
                {
                    AdicionaFigura(new Circulo(xinicial, yinicial, ((xfinal - xinicial) / 2)));
                }
                else
                {
                    AdicionaFigura(new Circulo(xinicial, yfinal, (xfinal - xinicial) / 2));
                }
            }
            else
            {
                if (yfinal > yinicial)
                {
                    AdicionaFigura(new Circulo(xfinal, yinicial, (xinicial - xfinal) / 2));
                }
                else
                {
                    AdicionaFigura(new Circulo(xfinal, yfinal, (xinicial - xfinal) / 2));
                }
            }

            this.Invalidate();
        }

        private void DesenhaCliqueRetangulo(int xfinal, int yfinal)
        {
            if (xfinal > xinicial)
            {
                if (yfinal > yinicial)
                {
                    AdicionaFigura(new Retangulo(xinicial, yinicial, (xfinal - xinicial), (yfinal - yinicial)));
                }
                else
                {
                    AdicionaFigura(new Retangulo(xinicial, yfinal, (xfinal - xinicial), (yinicial - yfinal)));
                }
            }
            else
            {
                if (yfinal > yinicial)
                {
                    AdicionaFigura(new Retangulo(xfinal, yinicial, (xinicial - xfinal), (yfinal - yinicial)));
                }
                else
                {
                    AdicionaFigura(new Retangulo(xfinal, yfinal, (xinicial - xfinal), (yinicial - yfinal)));
                }
            }
            this.Invalidate();
        }
        private void DesenhaCliqueLinha(int xfinal, int yfinal)
        {
            AdicionaFigura(new Linha(xinicial, yinicial, xfinal, yfinal));
            this.Invalidate();
        }
        
        private void AreaDeDesenho_Load(object sender, EventArgs e)
        {

        }

        private void comboxFerramenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
