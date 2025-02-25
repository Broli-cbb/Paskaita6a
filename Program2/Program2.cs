namespace ConsoleApp1
{
    public class Program2
    {
        Random random = new Random();



        int[] pirmasMasyvas = new int[5];
            

            for(int i = 0; i < 5; i++)

        {

            pirmasMasyvas[i] = random.Next(1, 101);
            Console.WriteLine(pirmasMasyvas[i]);

        }

        double masyvovidurkis = (pirmasMasyvas[0] + pirmasMasyvas[1] + pirmasMasyvas[2] + pirmasMasyvas[3] +
                                 pirmasMasyvas[4]);
            
        Console.WriteLine(masyvovidurkis / 5);
           
            
//  Console.WriteLine(pirmasMasyvas);

        Console.WriteLine();
            
    }
    }
}