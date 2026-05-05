using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefe_de_POO
{
    internal class Exame_final
    {
        public class ExameFinal : Avaliacao_do_aluno
        {
            public ExameFinal(double n, double p) : base(n, p) { }

            public override double CalcularNota()
            {
                return nota * percentagem;
            }
        }


    }
}
