﻿namespace Factory_Method
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// overrides the factory method to return an instance of a ConcreteProduct (Skillspage,...).
    /// </summary>
    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}