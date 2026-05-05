using System;

namespace Tarefe_de_POO
{
    
        public class Docente : Pessoa
        {
            public string categoria;

            public Docente(string nome, int idade, string categoria)
                : base(nome, idade)
            {
                this.categoria = categoria;
            }
        }

    }

