namespace Factory_Method
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// overrides the factory method to return an instance of a ConcreteProduct (SkillsPage,...).
    /// </summary>
    public class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}