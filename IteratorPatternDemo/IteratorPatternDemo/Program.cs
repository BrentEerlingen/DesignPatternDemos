using System;

namespace IteratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();

            for (Iterator iter = namesRepository.GetIterator(); iter.HasNext();)
            {
                String name = (String)iter.Next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}
