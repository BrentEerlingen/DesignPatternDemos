using System;
namespace TemplatePattenDemo
{
    public abstract class BasicStructure
    {
        public abstract void AddFlags();
        public abstract void AddTower();
        public abstract void AddPool();


        public BasicStructure()
        {
        }

        public void Build(){
            AddPool();
            AddFlags();
            AddTower();
        }
    }
}
