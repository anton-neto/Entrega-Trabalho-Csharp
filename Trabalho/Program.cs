using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        
        while (continuar)
        {
            Console.WriteLine("\n=== Menu de Exercícios ===");
            Console.WriteLine("1 - Verificador de Senha Forte");
            Console.WriteLine("2 - Tabuada Completa");
            Console.WriteLine("3 - Cálculo de Fatorial");
            Console.WriteLine("4 - Conversor de Temperaturas");
            Console.WriteLine("5 - Verificador de Palíndromos");
            Console.WriteLine("6 - Cadastro de Produtos");
            Console.WriteLine("7 - Soma de Números Pares");
            Console.WriteLine("8 - Cálculo de IMC");
            Console.WriteLine("9 - Jogo da Adivinhação");
            Console.WriteLine("10 - Lista de Tarefas");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha um exercício (0-10): ");
            
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("\nOpção inválida! Tente novamente.");
                continue;
            }
            
            int opcao = int.Parse(input);
            
            switch (opcao)
            {
                case 1:
                    Exercicio1.Executar();
                    break;
                    
                case 2:
                    Exercicio2.Executar();
                    break;
                    
                case 3:
                    Exercicio3.Executar();
                    break;
                    
                case 4:
                    Exercicio4.Executar();
                    break;
                    
                case 5:
                    Exercicio5.Executar();
                    break;
                    
                case 6:
                    Exercicio6.Executar();
                    break;
                    
                case 7:
                    Exercicio7.Executar();
                    break;
                    
                case 8:
                    Exercicio8.Executar();
                    break;
                    
                case 9:
                    Exercicio9.Executar();
                    break;
                    
                case 10:
                    Exercicio10.Executar();
                    break;
                    
                case 0:
                    continuar = false;
                    Console.WriteLine("\nPrograma encerrado.");
                    break;
                    
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    break;
            }
            
            if (opcao != 0)
            {
                Console.WriteLine("\nVoltando ao menu principal em 2 segundos...");
                Console.ReadKey(); 
            }
        }
    }
}
