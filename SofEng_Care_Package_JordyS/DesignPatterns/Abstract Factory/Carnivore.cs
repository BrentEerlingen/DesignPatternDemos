namespace Abstract_Factory
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// declares an interface for a type of product object (Wildebeest,...)
    /// </summary>
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
}