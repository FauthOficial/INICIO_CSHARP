using System;
using System.Globalization;
{

Console.WriteLine("ENTRE COM NOME: ");
    string nome = Console.ReadLine();
Console.WriteLine("-");

Console.WriteLine("NUMERO DE QUARTOS: ");
    int quartos = int.Parse(Console.ReadLine());
    Console.WriteLine("-");

Console.WriteLine("PRECO DE UM PRODUTO: ");
    double produto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    Console.WriteLine("-");

Console.WriteLine("ULTIMO NOME, IDADE E ALTURA (MESMA LINHA): ");
    string[] vet = Console.ReadLine().Split(' ');
    string ultimonome = vet[0];
    int age = int.Parse(vet[1]);
    double altura = double.Parse(vet[2]);
    Console.WriteLine("-");


Console.WriteLine("RESULTADO");
    Console.WriteLine("-");
    Console.WriteLine(nome);
    Console.WriteLine(quartos);
    Console.WriteLine(produto.ToString("F2",CultureInfo.InvariantCulture));
    Console.WriteLine(vet[0]);
    Console.WriteLine(vet[1]);
    Console.WriteLine(vet[2]);
}
