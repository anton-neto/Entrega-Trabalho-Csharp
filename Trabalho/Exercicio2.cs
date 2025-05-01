using System;

class Exercicio2{

    public static void Executar(){
    Console.WriteLine("Digite um número:");
    string? entrada = Console.ReadLine();
    if (entrada == null)return;

    int numero = int.Parse(entrada);

    Console.WriteLine("\n Tabuada");

    for (int i = 1; i < 10; i++){
        Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}