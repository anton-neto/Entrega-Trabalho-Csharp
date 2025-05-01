using System;

class Exercicio9
{
    public static void Executar()
    {
        Random random = new Random();
        int num = random.Next(1, 101);
        int tentativas = 0;
        
        Console.WriteLine("Adivinhe o número");
        
        while (true)
        {
            tentativas++;
            Console.Write($"Tentativa {tentativas}: ");
            string? entrada = Console.ReadLine();
            if (entrada == null) return;
            
            int palpite = int.Parse(entrada);
            
            if (palpite < num)
                Console.WriteLine("Maior");
            else if (palpite > num)
                Console.WriteLine("Menor");
            else
            {
                Console.WriteLine($"Acertou em {tentativas} tentativas");
                break;
            }
        }
    }
}
