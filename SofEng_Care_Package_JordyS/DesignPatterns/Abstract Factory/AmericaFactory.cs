namespace Abstract_Factory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// implements the operations to create concrete product objects (Wildebeest, ...)
    /// </summary>
    public class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}