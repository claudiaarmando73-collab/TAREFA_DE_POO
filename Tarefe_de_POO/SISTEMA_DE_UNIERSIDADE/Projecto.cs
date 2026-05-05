using System;

namespace Tarefe_de_POO
{
   
    
        public class Projecto : Avaliacao_do_aluno
        {
            public Projecto(double n, double p) : base(n, p) { }

            public override double CalcularNota()
            {
                return nota * percentagem;
            }
        }

    }

