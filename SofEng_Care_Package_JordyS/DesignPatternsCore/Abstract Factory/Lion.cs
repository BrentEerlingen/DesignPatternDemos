using System;

namespace Abstract_Factory
{
    /// <summary>
    /// The 'ProductB1' class
    /// defines a product object to be created by the corresponding concrete factory (Africafactory, AmericaFactory)
    /// implements the AbstractProduct interface (Herbivore, Carnivore)
    /// </summary>
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}