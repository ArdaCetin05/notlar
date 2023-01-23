using System;

namespace ForİçİçeDöngüler02
{
    class Program
    {
        static void Main(string[] args)
        {

            #region loops


            for (int i = 0; i <= 10 ; i++)
            {
                for (int j = 0; j <= i ; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
            #endregion
            Console.Read();

        }
    }
}
