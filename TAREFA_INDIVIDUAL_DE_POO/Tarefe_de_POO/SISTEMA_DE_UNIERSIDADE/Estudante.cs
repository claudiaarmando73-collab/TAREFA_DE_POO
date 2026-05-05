using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefe_de_POO
{
    

public class Estudante : Pessoa
    {
        public int numeroEstudante;
        public List<Avaliacao_do_aluno> minhasNotas = new List<Avaliacao_do_aluno>();

        public Estudante(string nome, int idade, int numeroEstudante)
            : base(nome, idade)
        {
            this.numeroEstudante = numeroEstudante;
        }
    }


}

