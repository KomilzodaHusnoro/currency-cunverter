using System;

namespace dz0404
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter currency = new Converter () { usd = 10.18, eur = 11.13, rub = 0.14, usdToSomoni = 0.098, eurToSomoni = 0.090, rubToSomoni = 7.25};
            System.Console.WriteLine("Operation list: \n*1* --> somoni to other currency\n*2*--> any currency to comoni\nYour choise: ");
            int operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                {
                    Console.Write(" Push *1* to change somoni to dollar \n Push *2* to change somoni to euro \n Push *3* to change somoni to rubli \n Your choise: ");
                    int choise = int.Parse(Console.ReadLine());
                    Console.Write("Enter amoung of somoni: ");
                    double somoni = double.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        case 1: 
                        {   
                           Console.WriteLine(currency.changeToUsd(somoni)  + " Usd");
                        } break;
                        case 2: 
                        {   
                            Console.WriteLine(currency.changeToEur(somoni) + "  Euro");
                        } break;
                        case 3: 
                        {   
                            Console.WriteLine(currency.changeToRub(somoni) + " Rub");
                        } break;   

                    }
                }break;
                case 2:
                {
                    Console.Write(" Push *1* to change dollar to somoni \n Push *2* to change euro to somoni \n Push *3* to change rubli to somoni \n Your choise: ");
                    int choise2 = int.Parse(Console.ReadLine());
                    switch (choise2)
                    {
                        case 1:
                        {
                            Console.Write("Enter amoung of USD: ");
                            double usd = double.Parse(Console.ReadLine());
                            System.Console.WriteLine(currency.changeUsd(usd) + " somoni");
                        } break;
                        case 2:
                        {
                            Console.Write("Enter amoung of Eur: ");
                            double eur = double.Parse(Console.ReadLine());
                            System.Console.WriteLine(currency.changeEur(eur) + " somoni");

                        }break;
                        case 3:
                        {
                            Console.Write("Enter amoung of Rub: ");
                            double rub = double.Parse(Console.ReadLine());
                            System.Console.WriteLine(currency.changeRub(rub) + " somoni");
                        }break;
                    }

                }break;

            }
            

        }
    }

    public class Converter 
    {
        public double usd { get; set; }
        public double eur { get; set; }
        public double rub { get; set; }
        public double usdToSomoni { get; set;}
        public double eurToSomoni { get; set;}
        public double rubToSomoni { get; set;}
        public Converter( double usd, double eur, double rub, double usdToSomoni, double eurToSomoni, double rubToSomoni)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
            this.usdToSomoni = usdToSomoni;
            this.eurToSomoni = eurToSomoni;
            this.rubToSomoni = rubToSomoni;
        }
        public Converter () {}
        public double changeToUsd (double somoni)
        {
            return somoni/usd;
        }
        public double changeUsd ( double usd )
        {
            return usd/usdToSomoni;
        }
        public double changeToEur (double somoni)
        {
            return somoni/eur;
        }
        public double changeEur ( double eur )
        {
            return eur/eurToSomoni;
        }
        public double changeToRub (double somoni)
        {
            return somoni/rub;
        }
        public double changeRub ( double rub )
        {
            return rub/rubToSomoni;
        }
        
    }
}
