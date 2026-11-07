using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public class Cliente : Pessoas
    {
        public string CodigoCliente;
        public void ExibirDadosCLiente()
        {
            Console.WriteLine("Codigo cliente " + CodigoCliente);
            Apresentar();
        }
        public Cliente(string nome, int idade, string codigoCliente)
            : base(nome, idade)
        {
            CodigoCliente= codigoCliente;
        }
    }
}
