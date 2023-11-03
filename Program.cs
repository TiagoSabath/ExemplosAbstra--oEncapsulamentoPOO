using ExemplosAbstraçãoEncapsulamento.Models;

Pessoa p1 = new Pessoa("Tiago");
p1.Idade = 25;
p1.Apresentar();


ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(600);
c1.ExibirSaldo();
 

Aluno a1 = new Aluno("Tiago");
a1.Idade = 25;
a1.Nota= 10;
a1.Apresentar();


Professor p2 = new Professor("João");
p2.Idade = 30;
p2.Salario = 10000;
p2.Apresentar();

