namespace Abstract_Factory
{
    /// <summary>
    /// The 'Client' class
    /// uses interfaces declared by AbstractFactory and AbstractProduct classes (Herbivore, Carnivore)
    /// </summary>
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}