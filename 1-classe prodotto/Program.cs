using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_classe_prodotto
{
    // Classe
    class Prodotto
    {
        private string nome;
        private double prezzo;
        public Prodotto()
        {
            nome = "";
            prezzo = 0;
        }
        public Prodotto(string nome, double prezzo)
        {
            this.nome = nome;
            this.prezzo = prezzo;
        }
        public string ShowName()
        {
            return nome;
        }
        public double ShowPrice()
        {
            return prezzo;
        }
    }

    // Main
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto prodotto1 = new Prodotto("Carne", 5);
            Prodotto prodotto2 = new Prodotto("Pesce", 10);
            Console.WriteLine("Prodotto 1 - Nome: {0}, Prezzo: {1}", prodotto1.ShowName(), prodotto1.ShowPrice());
            Console.WriteLine("Prodotto 2 - Nome: {0}, Prezzo: {1}", prodotto2.ShowName(), prodotto2.ShowPrice());
            Console.ReadLine();
        }
    }

}
