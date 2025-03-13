using System;
using System.Globalization;


int funcionario, horas;
double valorhora, salario;

funcionario = int.Parse(Console.ReadLine());
horas = int.Parse(Console.ReadLine());
valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
salario = horas * valorhora;

Console.WriteLine("funcionario = " + funcionario);
Console.WriteLine("salario = U$ " + salario.ToString("F2"), CultureInfo.InvariantCulture);



