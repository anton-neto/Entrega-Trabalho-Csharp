using System;

class Produto
{
    public string Nome = "";
    public double Preco;
    public int Quantidade;
    
    public double ValorTotal()
    {
        return Preco * Quantidade;
    }
}

class Exercicio6
{
    public static void Executar()
    {
        Produto[] produtos = new Produto[3];
        
        Console.WriteLine("Cadastro de Produtos");
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nProduto {i + 1}:");
            
            Produto produto = new Produto();
            
            Console.Write("Nome: ");
            string? nome = Console.ReadLine();
            if (nome == null) return;
            produto.Nome = nome;
            
            Console.Write("Preço: ");
            string? preco = Console.ReadLine();
            if (preco == null) return;
            produto.Preco = double.Parse(preco);
            
            Console.Write("Quantidade: ");
            string? qtd = Console.ReadLine();
            if (qtd == null) return;
            produto.Quantidade = int.Parse(qtd);
            
            produtos[i] = produto;
        }
        
        Console.WriteLine("\nLista de Produtos");
        double total = 0;
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nProduto {i + 1}:");
            Console.WriteLine($"Nome: {produtos[i].Nome}");
            Console.WriteLine($"Preço: R$ {produtos[i].Preco}");
            Console.WriteLine($"Quantidade: {produtos[i].Quantidade}");
            Console.WriteLine($"Total: R$ {produtos[i].ValorTotal()}");
            
            total += produtos[i].ValorTotal();
        }
        
        Console.WriteLine($"\nTotal geral: R$ {total}");
    }
}
