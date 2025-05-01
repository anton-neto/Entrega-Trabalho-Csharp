using System;

class Exercicio4{

    public static void Executar(){
        
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1- Celsius para Fahrenheit");
        Console.WriteLine("2- Fahrenheit para Celsius");

        string? entrada = Console.ReadLine();
        if(entrada == null) return;
        int opcao = int.Parse(entrada);

        if(opcao == 1){
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9/5) + 32;
            Console.WriteLine($"{celsius}ºC = {fahrenheit}ºF");
        }else if (opcao == 2){
            Console.WriteLine("Digite a temperatura em Fahrenheit");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5/9;
            Console.WriteLine($"{fahrenheit}ºF = {celsius}ºC");
        }
    }
}