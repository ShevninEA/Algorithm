using System;


namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isPrime(int num)
            {
                int iter = 1;
                int d = 0;
                for (int i = 2; i < num; i++)
                {
                    iter++;
                    if (num%i==0)
                    {
                        d++;
                    }

                }
                if (d == 0)
                    return true;
                return false;
            }
        }
    }
}
