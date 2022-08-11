using System;
using System.Globalization;
namespace exercicioAula
{
    class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

           
            Console.WriteLine("Entre com o seu nome completo: ");
            string nomecompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto: ");
            float produto = float.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Entre com o seu ultimo nome, idade e altura (mesma linha): ");

            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            float altura = float.Parse(vet[2], CI);

            Console.WriteLine("Voce digitou:");

            Console.WriteLine(nomecompleto);
            Console.WriteLine(quarto);
            Console.WriteLine(produto.ToString("F2", CI));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CI));

        }
    }
}

