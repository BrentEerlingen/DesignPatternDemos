using System;
namespace IteratorPatternDemo
{
    public class NameRepository : Container
    {

        public string[] names = { "Robert", "John", "Julie", "Lora" };


        public Iterator GetIterator()
        {
            return new NameIterator(this);
        }

        private class NameIterator : Iterator
        {

            int index;

            NameRepository namerepo;

            public NameIterator(NameRepository namerepo){
                this.namerepo = namerepo;
            }


            public bool HasNext()
            {

                if (index < namerepo.names.Length)
                {
                    return true;
                }
                return false;
            }


            public Object Next()
            {

                if (this.HasNext())
                {
                    return namerepo.names[index++];
                }
                return null;
            }
        }
    }
}
