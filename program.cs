using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Gerador de Números Aleatórios");
        Console.WriteLine("-----------------------------\n");

        Console.Write("Quantos números aleatórios você deseja gerar? ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();

        Console.WriteLine($"\nOs {quantidade} números aleatórios são:");

        for (int i = 0; i < quantidade; i++)
        {
            int numero = random.Next();
            Console.WriteLine(numero);
        }
    }
}
