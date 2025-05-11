using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Erro: O nome não pode ser vazio.");
            return;
        }

        Console.Write("Digite seu CPF (apenas números): ");
        string cpf = Console.ReadLine();

        if (!ValidarCpf(cpf))
        {
            Console.WriteLine("Erro: CPF inválido. Deve conter 11 dígitos numéricos.");
            return;
        }

        Console.Write("Digite sua idade: ");
        if (!int.TryParse(Console.ReadLine(), out int idade) || idade < 0 || idade > 120)
        {
            Console.WriteLine("Erro: Idade inválida. Deve estar entre 0 e 120.");
            return;
        }

        Console.WriteLine("\n--- Dados do Usuário ---");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"CPF: {cpf}");
        Console.WriteLine($"Idade: {idade}");
    }

    public static bool ValidarCpf(string cpf)
    {
        return cpf != null && cpf.Length == 11 && long.TryParse(cpf, out _);
    }
}
