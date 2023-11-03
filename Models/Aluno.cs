using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosAbstraçãoEncapsulamento.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()  // constructor Vazio para nao passa nenhum parâmetro 
        {

        }
        public Aluno(string nome) : base(nome) //// constructor para passar um parâmetro -- "base" para passa um parâmetro para classe pai
        {

        }

        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno  nota {Nota}");
        }
    }


}