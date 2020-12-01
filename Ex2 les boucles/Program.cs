using System;

namespace Ex2_les_boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 1;
            int numberTow = 50;
            while(numberOne < 30)
            {
                int result = numberOne * numberTow;
                Console.WriteLine(result);
                numberOne++;
            }
            int numberThree = 1;
            for (numberThree=1; numberThree < 10; numberThree++)
            {
               // Console.WriteLine(numberThree);
                int moiTie = numberThree + numberThree / 2;
                Console.WriteLine(moiTie);
            }
            int numberFoor ;
            for(numberFoor = 1 ; numberFoor <= 15; numberFoor++)
            {
                Console.WriteLine(numberFoor);
                
            }Console.WriteLine("On y arrive presque");
            for(numberFoor=20; numberFoor>=0; numberFoor--)
            {
                Console.WriteLine(numberFoor);
            }Console.WriteLine("C'est presque bon...");
            for(numberFoor=1; numberFoor<=100; numberFoor+=15)
            {
                Console.WriteLine(numberFoor);
            }Console.WriteLine("bon bout...");
            for(numberFoor=200; numberFoor>=0; numberFoor -= 12)
            {
                Console.WriteLine(numberFoor);
            }Console.WriteLine("Enfin ! ! ");
        }
    }
}
