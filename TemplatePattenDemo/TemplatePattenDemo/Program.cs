using System;

namespace TemplatePattenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStructure building = new NormaBuilding();
            Console.WriteLine("Normal Buidling");
            building.Build();
            Console.WriteLine();

            building = new FancyBuilding();
            Console.WriteLine("Fancy Buidling");
            building.Build();
        }
    }
}
