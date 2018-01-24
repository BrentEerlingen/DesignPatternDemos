using System;
namespace TemplatePattenDemo
{
    public class FancyBuilding: BasicStructure
    {
        public FancyBuilding()
        {
        }

        public override void AddFlags()
        {
            Console.WriteLine("Add Flags");
        }

        public override void AddPool()
        {
            Console.WriteLine("Add Pool");
        }

        public override void AddTower()
        {
            Console.WriteLine("Add Tower");
        }
    }
}
