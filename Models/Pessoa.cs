using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosAbstraçãoEncapsulamento.Models
{
    public class Pessoa
    {
        public Pessoa()  // constructor Vazio para nao passa nenhum parâmetro 
        {

        }

        public Pessoa(string nome) // constructor para passar um parâmetro
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()  // "virtual" função para sobre escrever o método 
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}