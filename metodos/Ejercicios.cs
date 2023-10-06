using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2.metodos
{
    internal class Ejercicios
    {/*
        public void Eje1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arreglo1 = new int[n];
            int[] arreglo2 = new int[n];
            int[] arreglo3 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingresa el primer numero: ");
                arreglo1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Ingresa el segundo numero: ");
                arreglo2[i] = int.Parse(Console.ReadLine());

                arreglo3[i] = arreglo1[i] + arreglo2[i];
            }

            Console.WriteLine("Contenido del arreglo 1: ");
            foreach (int i in arreglo1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Contenido del arreglo 2: ");
            foreach (int i in arreglo2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Contenido del arreglo 3: ");
            foreach (int i in arreglo3)
            {
                Console.WriteLine(i);
            }
        }
        */
        public void Eje2(int valorB)
        {

            int[] arreglo1 = {0,1,2,3,4,5,6,7,8,9,10}; 


            List<int> valores = new List<int>();

            for (int i = 0; i < arreglo1.Length; i++)
            {
                if (arreglo1[i] == valorB)
                {
                    valores.Add(i);
                }
            }
            if (valores.Count > 0)
            {
                Console.WriteLine("El valor se encontro en: ");
                foreach (int valor in valores)
                {
                    Console.WriteLine(valor);
                }
            }
            else
            {
                Console.WriteLine("El elemento no se encontro mi compita");
            }
        
        }
    }
}
