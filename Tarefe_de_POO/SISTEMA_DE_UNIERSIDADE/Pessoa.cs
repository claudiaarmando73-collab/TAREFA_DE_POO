using System;

namespace Tarefe_de_POO
{
    
    
        public abstract class Pessoa
        {
            public string nome;
            public int idade;

            public Pessoa(string nome, int idade)
            {
                this.nome = nome;
                this.idade = idade;
            }
        }

    }


