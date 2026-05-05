using Sistema_de_Veiculo;
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Veiculo carro1 = new Veiculo("AA-11-11", "Fiat", "Uno", 2015, 80000);
        Veiculo carro2 = new Veiculo("BB-22-22", "Ford", "Ka", 2019, 50000);

       
        Console.WriteLine("DADOS DOS CARROS:");
        carro1.MostrarDados();
        carro2.MostrarDados();

        carro1.AddKm(200.5);
        carro2.AddKm(150.0);

        
   
    }
}