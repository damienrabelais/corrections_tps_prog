using System;
using System.Collections.Generic;
using System.Text;

namespace POOComplexe
{
    internal class Complexe
    {
            private double x, y;
            // x,y : partie réelle et imaginaire

            public Complexe()
            {
                x = 0.0;
                y = 0.0;
            }
            public Complexe(double nouvX, double nouvY)
            {
                x = nouvX;
                y = nouvY;
            }

            public double GetPartieReelle()
            {
                return x;
            }

            public double GetPartieImaginaire()
            {
                return y;
            }

            public Complexe Addition(Complexe nombre)
            {
                return new Complexe(x + nombre.x, y + nombre.y);
            }

            public Complexe Soustraction(Complexe nombre)
            {
                return new Complexe(x - nombre.x, y - nombre.y);
            }

            public Complexe Produit(Complexe nombre)
            {
                return new Complexe(x * nombre.x - y * nombre.y, x * nombre.y + nombre.x * y);
            }

            public Complexe Inverse()
            {
                return new Complexe(x / (Math.Pow(x, 2) + Math.Pow(y, 2)), -y / (Math.Pow(x, 2) + Math.Pow(y, 2)));
            }

            public double GetModule()
            {
                return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            }

            public override string ToString()
            {
                return "\nPartie Reelle : " + x.ToString() + "\nPartie Imaginaire : " + y.ToString();
            }
}
}