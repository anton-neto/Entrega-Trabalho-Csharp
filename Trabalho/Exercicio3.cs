using System;

class Exercicio3{

    public static void Executar(){
        Console.WriteLine("Digite um número:");
        string? entrada = Console.ReadLine();
        if(entrada == null) return;

        int numero = int.Parse(entrada);
        int fatorial = 1;

        for (int i = numero; i > 0; i--){
            fatorial = fatorial * i;
        }

        Console.WriteLine($"Fatorial de {numero} = {fatorial}");
    }
}