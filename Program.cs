using System;

namespace dz0404
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter currency = new Converter () { usd = 10.22, eur = 11.11, rub = 0.14};

        }
    }
    /// <summary>
    /// добавить соотношения
    /// </summary>
    public class Converter 
    {
        public double usd { get; set; }
        public double eur { get; set; }
        public double rub { get; set; }
        public Converter( double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public Converter () {}
        
    }
}
