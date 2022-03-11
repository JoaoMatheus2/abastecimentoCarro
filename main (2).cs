using System;

namespace ConsoleApp3 
{
    class Program 
    {
        static void Main(String[] args) 
        {
            double gasolina = 7.199;
            double etanol = 5.419;
            double GNV = 4.259;
            double litrosGasolina;
            double litrosEtanol;
            double metroGnv;
            double valorGasolina;
            double valorEtanol;
            double valorGNV;
            double valorTotal;
            
            Console.WriteLine("Quantos litros de Gasolina você abasteceu?");
            litrosGasolina = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos litros de Etanol você abasteceu?");
            litrosEtanol = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos metros cúbicos de GNV você abasteceu?");
            metroGnv = double.Parse(Console.ReadLine());
            
            valorGasolina = gasolina * litrosGasolina;
            valorEtanol = etanol * litrosEtanol;
            valorGNV = GNV * metroGnv;
            
            Console.WriteLine("Você gastou " + valorGasolina + " reais em Gasolina");
            Console.WriteLine("Você gastou " + valorEtanol + " reais em Etanol");
            Console.WriteLine("Você gastou " + valorGNV + " reais em GNV");
            
            valorTotal = valorGasolina + valorEtanol + valorGNV;
            
            Console.WriteLine("Ao todo você gastou " + valorTotal + " reais");
            
            


            
        }
    }
} 