using System;

class numeros_primos
{
    static bool EhPrimo(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Digite a quantidade de números primos desejada: ");
        int n = int.Parse(Console.ReadLine());

        int contador = 0, numero = 2;
        while (contador < n)
        {
            if (EhPrimo(numero))
            {
                Console.Write(numero + " ");
                contador++;
            }
            numero++;
        }
    }
}
