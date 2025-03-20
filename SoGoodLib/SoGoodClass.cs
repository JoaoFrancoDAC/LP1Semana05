using System;

namespace SoGoodLib
{
    public class SoGoodClass
    {
        public static string SoGoodMethod()
        {
            return "I came from another project!";
        }

        public static int SoGoodFib(int n_number)
        {
            if (n_number <= 1)
                return n_number;
            else
                return SoGoodFib(n_number - 1) + SoGoodFib(n_number - 2);
        }
    }
}
