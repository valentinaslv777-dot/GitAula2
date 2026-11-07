using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CadastroPessoas
{
    public abstract class Pessoas
    {
        private string nome;
        private int idade;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string novoNome)
        {
            nome = novoNome;
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
            }
        }

        public virtual void Apresentar()
        {
            Console.WriteLine("Nome: " + GetNome());
            Console.WriteLine("Idade: " + Idade);
        }

        public void Apresentar(bool mostrarTipo)
        {
            Apresentar();

            if (mostrarTipo)
            {
                Console.WriteLine("Tipo: Pessoa");
            }
        }

        public Pessoas(string nome, int idade)
        {
            SetNome(nome);
            Idade = idade;
        }
    }
}