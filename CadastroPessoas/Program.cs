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

            cliente.Idade = 29;
            Console.WriteLine("Idade do cliente: " + cliente.Idade);

            cliente.Apresentar();
            cliente.Apresentar(true);

            Cliente clienteSemCodigo = new Cliente("Bruno Lima", 31);

            Pessoas[] pessoas = new Pessoas[]
            {
                cliente,
                funcionario,
                gerente
            };

            foreach (Pessoas pessoa in pessoas)
            {
                Console.WriteLine();
                pessoa.Apresentar();
            }

            Console.ReadKey();
        }
    }
}
