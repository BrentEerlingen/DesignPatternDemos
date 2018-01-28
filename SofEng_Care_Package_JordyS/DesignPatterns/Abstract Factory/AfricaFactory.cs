namespace Abstract_Factory
{
    /// <summary>
    /// The 'ConcreteFactory1' Class
    /// implements the operations to create concrete product objects (Wildebeest, ...)
    /// </summary>
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}