using System;
using System.Collections.Generic;
using System.Linq;

namespace Tarefe_de_POO
{
    internal class Unidade_curricular
    {

public class UnidadeCurricular
    {
        public string nomeUC;
        public List<Estudante> listaEstudantes = new List<Estudante>();

        public UnidadeCurricular(string nomeUC)
        {
            this.nomeUC = nomeUC;
        }

        public void EmitirPauta()
        {
            Console.WriteLine("\n========== PAUTA FINAL: " + nomeUC + " ==========");

            var ordenados = listaEstudantes.OrderByDescending(est => est.minhasNotas.Sum(n => n.CalcularNota())).ToList();

            foreach (var est in ordenados)
            {
                double notaFinal = est.minhasNotas.Sum(n => n.CalcularNota());
                Console.WriteLine($"Aluno: {est.nome} | Nº: {est.numeroEstudante} | Nota Final: {notaFinal:F1}");
            }
            Console.WriteLine("===============================================");
        }
    }

}
}
