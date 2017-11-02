using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Package.Mammal m = new Package.Mammal();
            Package.Reptile r = new Package.Reptile();

            if (m.BloodType == Package.Enum.BloodTypeEnum.Warm)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Warm...");
            }
            if (r.BloodType == Package.Enum.BloodTypeEnum.Cold)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Cold...");
            }


        }
    }
}
