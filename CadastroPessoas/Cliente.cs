using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public class Cliente : Pessoas
    {
        public string CodigoCliente { get; set; }

        public void ExibirDadosCliente()
        {
            Console.WriteLine("Codigo do cliente: " + CodigoCliente);
            Apresentar();
        }

        public override void Apresentar()
        {
            Console.WriteLine("Cliente: " + GetNome());
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Código: " + CodigoCliente);
        }

        public Cliente(string nome, int idade, string codigoCliente)
            : base(nome, idade)
        {
            CodigoCliente = codigoCliente;
        }

        public Cliente(string nome, int idade)
            : base(nome, idade)
        {
            CodigoCliente = "SEM-CODIGO";
        }
    }
}
