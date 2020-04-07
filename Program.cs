using System;

namespace dz0404
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter currency = new Converter () { usd = 10.22, eur = 11.11, rub = 0.141};
            Console.Write(" Push *1* to change somoni to dollar \n Push *2* to change somoni to euro \n Push *3* to change somoni to rubli \n Your choise  ");
            int choise = int.Parse(Console.ReadLine());
            Console.Write("Enter amoung of somoni: ");
            double somoni = double.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1: 
                {   
                    Console.WriteLine(currency.changeUsd(somoni) + " Somoni");
                    Console.WriteLine(currency.changeToUsd(somoni)  + " Usd");
                } break;
                case 2: 
                {   
                    Console.WriteLine(currency.changeEur(somoni) + "  Somoni");
                    Console.WriteLine(currency.changeToEur(somoni) + "  Euro");
                } break;
                case 3: 
                {   
                    Console.WriteLine(currency.changeRub(somoni) + " Somoni");
                    Console.WriteLine(currency.changeToRub(somoni) + " Rub");
                } break;   

            }

        }
    }

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
        public double changeToUsd (double somoni)
        {
            return somoni/usd;
        }
        public double changeUsd ( double somoni )
        {
            return changeToUsd(somoni)*usd;
        }
        public double changeToEur (double somoni)
        {
            return somoni/eur;
        }
        public double changeEur ( double somoni )
        {
            return changeToEur(somoni)*eur;
        }
        public double changeToRub (double somoni)
        {
            return somoni/rub;
        }
        public double changeRub ( double somoni )
        {
            return changeToRub (somoni)*rub;
        }
        
    }
}
