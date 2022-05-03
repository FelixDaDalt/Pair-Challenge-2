using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EjercioProfesor();
            PairChallenge();
            Console.ReadKey();
        }

        static void EjercioProfesor()
        {
            Stack cola = new Stack();
            int x = 5;
            while (x >= 0)
            {
                double num;
                Console.Write("Numero: ");
                num = Convert.ToDouble(Console.ReadLine());
                cola.Push(num);
                x--;
            }
            foreach (double valor in cola)
            {
                Console.WriteLine(valor);
            }
        }

        static void PairChallenge()
        {
            Stack fila = new Stack();


            Console.WriteLine("Ingrese cantidad de personas: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arrayP = new int[num];

            while (num > 0)
            {
                Console.WriteLine("Ingrese edad: ");
                int numEdad = Convert.ToInt32(Console.ReadLine());
                fila.Push(numEdad);
                num--;
            }
            for (int x = 0; x < arrayP.Length; x++)
            {
                arrayP[x] = (int)fila.Pop();
            }

            Array.Sort(arrayP);
            Array.Reverse(arrayP);

            Console.WriteLine("Personas a pasar: ");

            foreach (int value in arrayP)
            {
                Console.WriteLine(value);
            }

        }


    }
}

