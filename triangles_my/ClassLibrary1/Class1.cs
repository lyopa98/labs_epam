using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static bool IsTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            if (a + b <= c || b + c <= a || a + c <= b)
                return false;
            return true;
        }
    }
}
