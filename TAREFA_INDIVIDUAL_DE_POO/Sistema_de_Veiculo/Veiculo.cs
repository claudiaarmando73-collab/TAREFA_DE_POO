using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Veiculo
{
  
    
    
        internal class Veiculo
        {



            private string matricula;
            private string marca;
            private string modelo;
            private int ano;
            private double km;


            public Veiculo()
            {
                matricula = "";
                marca = "";
                modelo = "";
                ano = 0;
                km = 0.0;
            }


            public Veiculo(string matricula, string marca, string modelo, int ano, double km)
            {
                this.matricula = matricula;
                this.marca = marca;
                this.modelo = modelo;
                this.ano = ano;
                this.km = km;
            }


            public string Matricula
            {
                get { return matricula; }
                set { matricula = value; }
            }

            public string Marca
            {
                get { return marca; }
                set { marca = value; }
            }

            public string Modelo
            {
                get { return modelo; }
                set { modelo = value; }
            }

            public int Ano
            {
                get { return ano; }
                set { ano = value; }
            }

            public double Km
            {
                get { return km; }
                set { km = value; }
            }


            public void AddKm(double valor)
            {
                if (valor > 0)
                {
                    km = km + valor;
                    
                }
                else
                {
                    Console.WriteLine("Erro! O valor improduzido tem que ser maior que zero.");
                }
            }


            public void MostrarDados()
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Matricula: " + matricula);
                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("Modelo: " + modelo);
                Console.WriteLine("Ano: " + ano);
                Console.WriteLine("Kilometragem: " + km);
                Console.WriteLine("---------------------");
            }
        }
    }

