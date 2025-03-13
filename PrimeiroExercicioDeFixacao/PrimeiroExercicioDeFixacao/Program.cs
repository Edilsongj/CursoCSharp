using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            string produto01 = "computador";
            string produto02 = "mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco01 = 2100.0;
            double preco02 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("produtos:");
            Console.WriteLine($"{produto01}, cujo preço é $ {preco01.ToString("f2")}");
            Console.WriteLine($"{produto02}, cujo preço é $ {preco02.ToString("f2")}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade.ToString()} Anos de idade, código {codigo.ToString()} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"medida com oito casas decimaís: {medida.ToString("f8")}");
            Console.WriteLine($"Arredondado (com três casas decimais: {medida.ToString("f3")}");
            Console.WriteLine($"Separdor decimal invariant culture: {medida.ToString("f3",CultureInfo.InvariantCulture)}");        
            Console.WriteLine($"Separdor decimal invariant culture: {medida.ToString("f3",CultureInfo.InvariantCulture)}");        

            
        }
    }
}