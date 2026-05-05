using System;

namespace Tarefe_de_POO
{
   
    

public abstract class Avaliacao_do_aluno
    {
        public double nota;
        public double percentagem;

        public Avaliacao_do_aluno(double nota, double peso)
        {
            this.nota = nota;
            this.percentagem = peso;
        }

        public abstract double CalcularNota();
    }

}

