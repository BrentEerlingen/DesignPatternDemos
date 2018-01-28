namespace Composite
{
    /// <summary>
    /// The 'Component' Treenode
    /// declares the interface for objects in the composition.
    /// implements default behavior for the interface common to all classes, as appropriate.
    /// declares an interface for accessing and managing its child components.
    /// (optional) defines an interface for accessing a component's parent in the recursive structure, 
    /// and implements it if that's appropriate. 
    /// </summary>
    abstract class DrawingElement
    {
        protected string _name;
 
        // Constructor

        public DrawingElement(string name)
        {
            this._name = name;
        }
 
        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }
}