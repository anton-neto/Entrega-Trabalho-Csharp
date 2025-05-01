using System;

class Tarefa
{
    public string Nome = "";
    public bool Feita;
}

class Exercicio10
{
    public static void Executar()
    {
        Tarefa[] lista = new Tarefa[100];
        int total = 0;
        
        while (true)
        {
            Console.WriteLine("\nMenu de Tarefas:");
            Console.WriteLine("1 - Adicionar nova tarefa");
            Console.WriteLine("2 - Marcar tarefa como feita");
            Console.WriteLine("3 - Ver todas as tarefas");
            Console.WriteLine("4 - Sair do programa");
            
            string? entrada = Console.ReadLine();
            if (entrada == null) continue;
            int opcao = int.Parse(entrada);
            
            if (opcao == 1)
            {
                Console.Write("Digite o nome da tarefa: ");
                string? nome = Console.ReadLine();
                if (nome == null) continue;
                
                lista[total] = new Tarefa { 
                    Nome = nome, 
                    Feita = false 
                };
                total++;
            }
            else if (opcao == 2)
            {
                Console.Write("Digite o número da tarefa: ");
                string? num = Console.ReadLine();
                if (num == null) continue;
                
                int numero = int.Parse(num) - 1;
                if (numero >= 0 && numero < total)
                    lista[numero].Feita = true;
            }
            else if (opcao == 3)
            {
                for (int i = 0; i < total; i++)
                {
                    string status = lista[i].Feita ? "[Feita]" : "";
                    Console.WriteLine($"{i + 1} - {lista[i].Nome} {status}");
                }
            }
            else if (opcao == 4)
                break;
        }
    }
}
