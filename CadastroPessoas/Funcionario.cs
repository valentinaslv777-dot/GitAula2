using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public class Funcionario : Pessoas
    {
        public decimal Salario;

        public decimal CalcularBonus()
        {
            return Salario * 0.10m;
        }

        public void ExibirDadosFuncionario()
        {
            Console.WriteLine("Salario: " + Salario);
            Console.WriteLine("Bonus: " + CalcularBonus());
            Apresentar();
        }

        public override void Apresentar()
        {
            Console.WriteLine("Funcionário: " + GetNome());
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Salário: " + Salario);
        }

        public Funcionario(string nome, int idade, decimal salario)
            : base(nome, idade)
        {
            Salario = salario;
        }
    }
}
