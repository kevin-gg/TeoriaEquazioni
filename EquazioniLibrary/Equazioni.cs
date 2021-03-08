using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool isDetermined(double a)
        {
            if (a != 0)
            {
                return true;

            }
            else
            {

                return false;
            }
        }

        public static bool isInconsisted(double a, double b)
        {
            if (a == 0)
            {
                if (b != 0)
                    return true;
            }
            return false;
        }

        public static bool isDegree2(double g)
        {
            if (g == 2)
                return true;
            return false;
        }

        public static double Delta(double a, double b, double c)
        {
            double r = b * b;
            double r1 = a * c;
            double r2 = r1 * 4;
            double delta = r - r2;
            return delta;
        }

        public static string EquationDegree1(double a, double b, double c)
        {
            string risultato = "";
            if (a == 0)
            {
                if (b != 0)
                {
                    risultato = "Impossibile";
                }
            }
            if (a != 0)
            {
                if (b == 0)
                {
                    risultato = "Indeterminata";
                }
                else
                {
                    double x1, x2;
                    double delta = (b * b) - (4 * a * c);
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    return ($"x1={x1} x2={x2}");
                }
            }

            return risultato;

        }

        public static string Result(double a, double b, double c)
        {

            double x1, x2;
            double delta = (b * b) - (4 * a * c);
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return ($"x1={x1} x2={x2}");
        }





    }
}

