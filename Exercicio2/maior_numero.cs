using System;
class maior_numero
{
    static void Main()
    {
        int num1, num2, num3, maior = 0;

        Console.WriteLine("Digite três números: ");
        Console.Write("Numero 1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Numero 2: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Numero 3: ");
        num3 = int.Parse(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3)
        {
            maior = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            maior = num2;
        }
        else
        {
            maior = num3;
        }
        Console.WriteLine("O maior número é: " + maior);
    }
}