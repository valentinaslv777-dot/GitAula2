using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public class Gerente : Funcionario
    {
        public string Departamento;

        public Gerente(
            string nome,
            int idade,
            decimal salario,
            string departamento)
        {
            Departamento = departamento;
        }
        public void ExibirDadosGerente()
        {
            Console.WriteLine("Departamento: " + Departamento);
            ExibirDadosFuncionario();
        }
    }
}
