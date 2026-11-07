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

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int novaIdade)
        {
            idade = novaIdade;
        }

        public void Apresentar()
        {
            Console.WriteLine("Nome: " + GetNome());
            Console.WriteLine("Idade: " + GetIdade());
        }

        public Pessoas(string nome, int idade)
        {
            SetNome(nome);
            SetIdade(idade);
        }
    }
}
