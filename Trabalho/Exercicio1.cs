using System;

class Exercicio1{

    public static void Executar(){
    Console.WriteLine("Digite uma senha: ");
    string? senha = Console.ReadLine();
    if(senha == null) return;

    bool temMaiscula = false;
    bool temNumero = false;
    bool temEspecial = false;
    bool temTamanho = senha.Length >= 8;
    
    for (int i = 0; i < senha.Length; i++){
        if(senha[i] >= 'A' && senha[i] <= 'Z'){
            temMaiscula = true;
        }else if(senha[i] >= '0' && senha[i] <= '9'){
            temNumero = true;
        }else if("!@#$%^&*(),.?\":{}|<>".Contains(senha[i])){
            temEspecial = true;
        }
    }

    if(temTamanho && temMaiscula && temNumero && temEspecial)
    Console.WriteLine("Senha forte");
    else{
        Console.WriteLine("Senha fraca");
        if(!temTamanho)
        Console.WriteLine("- A senha deve ter no mínimo 8 caracteres");
        if(!temMaiscula)
        Console.WriteLine("- A senha deve conter pelo menos uma letra maiúscula");
        if(!temNumero)
        Console.WriteLine("- A senha deve conter pelo menos um número");
        if(!temEspecial)
        Console.WriteLine("- A senha deve conter pelo menos um caractere especial (!, @, #, etc)");
        }
    }
}