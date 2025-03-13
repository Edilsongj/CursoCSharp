using System;
using System.Globalization;

namespace exercicio2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string nomecompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura(mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);




            Console.WriteLine(nomecompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(valor.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}