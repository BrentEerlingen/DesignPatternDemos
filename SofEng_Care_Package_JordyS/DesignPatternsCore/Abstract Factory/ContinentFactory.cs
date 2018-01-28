namespace Abstract_Factory
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// declares an interface for operations that create abstract products (Herbivore, Carnivore,..)
    /// </summary>
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
        
    }
}