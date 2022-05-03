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
            //EjercioProfesor();
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
            int num;

            do
            {
                Console.Write("Ingrese cantidad de personas: ");
            } while (!Int32.TryParse(Console.ReadLine(), out num) || num < 1);

            int[] arrayP = new int[num]; // creamos arreglo

            while (num > 0) // cargamos PILA
            {
                bool validar;
                int numEdad;
                string edad = "";
                do
                {
                    validar = true;
                    Console.Write("Ingrese edad: ");
                    edad = Console.ReadLine();
                    if(Int32.TryParse(edad, out numEdad)==false || numEdad < 1)
                    {
                        Console.WriteLine("Error");
                        validar = false;
                    }
                } while (validar==false);
            
                fila.Push(numEdad); 
                num--;
            }

            for (int x = 0; x < arrayP.Length; x++) // pasamos de la pila a un arreglo
            {
                arrayP[x] = (int)fila.Pop();
            }

            Array.Sort(arrayP); // Ordenamos el arreglo
            Array.Reverse(arrayP);

            Console.WriteLine("Personas a pasar: "); // mostramos el arreglo
            foreach (int value in arrayP) 
            {
                Console.WriteLine("Edad: "+value);
            }

        }


    }
}

