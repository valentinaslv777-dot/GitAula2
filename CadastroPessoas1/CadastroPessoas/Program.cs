using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(
                "Ana Souza",
                28,
                "CLI-001"
                );

            Funcionario funcionario = new Funcionario(
                "Carlos Lima",
                35,
                4500.00m
                );
            Gerente gerente = new Gerente(
                "Marina Alves",
                42,
                7000.00m,
                "Tecnologia"
                );

            Console.WriteLine("=== CLIENTE ===");
            cliente.ExibirDadosCLiente();

            Console.WriteLine();
            Console.WriteLine("=== FUNCIONÁRIO ===");
            funcionario.ExibirDadosFuncionario();

            Console.WriteLine();
            Console.WriteLine("=== GERENTE ===");
            gerente.ExibirDadosGerente();

            Console.ReadKey();
        }
    }
}
