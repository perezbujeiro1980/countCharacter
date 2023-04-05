using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace countCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Dinosaurio";
            char[] stringChar = cadena.ToCharArray();
            int total;
            
            for (int i = 0; i <= cadena.Length - 1; i++)
            {
              total = 0;
              for (int j = 0; j <= cadena.Length - 1; j++)
			{
                if (cadena[i] == cadena[j]) {
                    total = total + 1;                 
                }
			}

            Console.WriteLine(cadena[i] + "- veces: " + total);
              
            }
            Console.ReadLine();
        }
           
    }

}
