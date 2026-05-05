using System;
using Tarefe_de_POO;
using static Tarefe_de_POO.Exame_final;
using static Tarefe_de_POO.Unidade_curricular;

class Program
{
    static void Main(string[] args)
    {
        UnidadeCurricular uc = new UnidadeCurricular("");
        bool rodando = true;

        while (rodando)
        {
            Console.WriteLine("\n--- UNIVERSIDADE KIMPA VITA ---");
            Console.WriteLine("1. Cadastrar Estudante");
            Console.WriteLine("2. Inserir Nota (Primeira_Prova/Projeto/Exame_final)");
            Console.WriteLine("3. Mostrar toda Pauta e sair");
            Console.Write("Escolha uma opção: ");

            string opcaoPrincipal = Console.ReadLine();

            switch (opcaoPrincipal)
            {
                case "1":
                    Console.Write(" Insira o nome do aluno: ");
                    string nome = Console.ReadLine();
                    Console.Write("Número do aluno: ");
                    int num = int.Parse(Console.ReadLine());
                    uc.listaEstudantes.Add(new Estudante(nome, 20, num));
                    Console.WriteLine("Estudante cadastrado com sucesso!");
                    break;

                case "2":
                    if (uc.listaEstudantes.Count == 0)
                    {
                        Console.WriteLine("Erro: Cadastre um aluno primeiro!");
                        break;
                    }
                    Console.WriteLine("\nEscolha o aluno apartir do número:");
                    for (int i = 0; i < uc.listaEstudantes.Count; i++)
                        Console.WriteLine($"{i}. {uc.listaEstudantes[i].nome}");

                    int indexAluno = int.Parse(Console.ReadLine());

                    Console.WriteLine("Tipo de Avaliação: 1-Primeira_Prova | 2-Projeto | 3-Exame_final");
                    int tipoAv = int.Parse(Console.ReadLine());

                    Console.Write("Nota (De 0-20 quanto o aluno teve?): ");
                    double vNota = double.Parse(Console.ReadLine());

                   
                    if (tipoAv == 1)
                    {
                      
                        uc.listaEstudantes[indexAluno].minhasNotas.Add(new Teste(vNota, 0.4));
                    }
                    else if (tipoAv == 2)
                    {
                       
                        uc.listaEstudantes[indexAluno].minhasNotas.Add(new Projecto(vNota, 0.3));
                    }
                    else if (tipoAv == 3)
                    {
                        
                        uc.listaEstudantes[indexAluno].minhasNotas.Add(new ExameFinal(vNota, 0.3));
                    }

                    Console.WriteLine("Nota adicionada com sucesso!");
                    break;

                case "3":
                    uc.EmitirPauta();
                    rodando = false;
                    break;

                default:
                    Console.WriteLine("Esta opção não existe !");
                    break;
            }
        }
    }
}