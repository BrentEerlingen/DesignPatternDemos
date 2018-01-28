using System;

namespace Abstract_Factory
{
    /// <summary>
    /// The 'ProductB2' class
    /// defines a product object to be created by the corresponding concrete factory (Africafactory, AmericaFactory)
    /// implements the AbstractProduct interface (Herbivore, Carnivore)
    /// </summary>
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}