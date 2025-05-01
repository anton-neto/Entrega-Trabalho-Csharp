using System;

class Exercicio7
{
    public static void Executar()
    {
        int soma = 0;
        
        Console.WriteLine("Digite 10 números:");
        
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            string? entrada = Console.ReadLine();
            if (entrada == null) return;
            
            int num = int.Parse(entrada);
            
            if (num % 2 == 0)
            {
                soma = soma + num;
            }
        }
        
        Console.WriteLine($"Soma dos pares: {soma}");
    }
}
