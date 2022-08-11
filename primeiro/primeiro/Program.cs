using System;
using System.Globalization;

namespace Primeiro
{

    class Program
    {

        static void Main(string[] args)
        {

           CultureInfo CI = CultureInfo.InvariantCulture;  

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CI); 

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CI);

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CI));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);  
            Console.WriteLine(altura.ToString("F2", CI));  


        }
    }
}