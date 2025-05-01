using System;

class Exercicio5
{
    public static void Executar()
    {
        Console.WriteLine("Digite uma palavra:");
        string? entrada = Console.ReadLine();
        if (entrada == null) return;

        string palavra = entrada.ToLower();
        bool ePalindromo = true;
        int inicio = 0;
        int fim = palavra.Length - 1;

        while(inicio < fim)
        {
            if(palavra[inicio] != palavra[fim])
            {
                ePalindromo = false;
                break;
            }
            inicio++;
            fim--;
        }

        if(ePalindromo)
        {
            Console.WriteLine("É um palíndromo");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo");
        }
    }
}