using System;

class Exercicio8
{
    public static void Executar()
    {
        Console.WriteLine("Calculadora de IMC");
        
        Console.Write("Peso (kg): ");
        string? entradaPeso = Console.ReadLine();
        if (entradaPeso == null) return;
        double peso = double.Parse(entradaPeso);
        
        Console.Write("Altura (m): ");
        string? entradaAltura = Console.ReadLine();
        if (entradaAltura == null) return;
        double altura = double.Parse(entradaAltura);
        
        double imc = peso / (altura * altura);
        
        Console.WriteLine($"\nIMC: {imc}");
        
        if (imc < 18.5)
            Console.WriteLine("Abaixo do peso");
        else if (imc < 25)
            Console.WriteLine("Peso normal");
        else if (imc < 30)
            Console.WriteLine("Sobrepeso");
        else
            Console.WriteLine("Obesidade");
    }
} 