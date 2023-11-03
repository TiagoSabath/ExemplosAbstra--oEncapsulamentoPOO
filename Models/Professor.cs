using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosAbstraçãoEncapsulamento.Models
{
    public sealed class Professor : Pessoa // sealed essa classe e a classe final nao pode ser herdada
    {
        public Professor()
        {
            
        }

        public Professor(string nome) : base(nome)
        {

        }

        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor  e meu salario é {Salario}");
        }
    }
    

}