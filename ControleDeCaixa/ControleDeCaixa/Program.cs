using System;
using System.Globalization;

int codigo1, codigo2, qte1, qte2;
double preco1, preco2, total;

string[] valores = Console.ReadLine().Split(' ');

codigo1 = int.Parse(valores[0]);
qte1 = int.Parse(valores[1]);
preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

valores = Console.ReadLine().Split(' ');

codigo2 = int.Parse(valores[0]);
qte2 = int.Parse(valores[1]);
preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);


total = preco1 * qte1 + preco2 * qte2;

Console.WriteLine("valor a pagar R$ " + total.ToString("F2", CultureInfo.InvariantCulture));








