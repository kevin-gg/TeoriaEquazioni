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

        

        }
    }

