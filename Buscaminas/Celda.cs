using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Celda
    {
        int valor;
        bool visible;

        public Celda(int val, bool vis)
        {
            valor = val;
            visible = vis;

        }

        public int Valor
        {
            get { return valor; }

             set { valor = value;}
        }

        public bool Visible
        {
            get {return visible;}
            set { visible = value; }
        }
    }
}
