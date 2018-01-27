using System;
namespace IteratorPatternDemo
{
    public interface Iterator
    {
        bool HasNext();
        Object Next();
    }
}
