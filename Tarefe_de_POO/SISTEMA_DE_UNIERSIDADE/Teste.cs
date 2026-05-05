using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefe_de_POO
{
    
    
        public class Teste : Avaliacao_do_aluno
        {
            public Teste(double n, double p) : base(n, p) { }

            public override double CalcularNota()
            {
                return nota * percentagem;
            }
        }

    }
