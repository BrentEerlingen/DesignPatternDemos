using System;

namespace Template_Method
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm
    /// implements a template method defining the skeleton of an algorithm. 
    /// The template method calls primitive operations as well as operations defined in AbstractClass or those of other objects.
    /// </summary>
    public abstract class DataExporter
    {
        // This will not vary as the data is read from sql only
        public void ReadData()
        {
            Console.WriteLine("Reading the data from SqlServer");
        }

        // This will not vary as the format of report is fixed.
        public void FormatData()
        {
            Console.WriteLine("Formating the data as per requriements.");
        }

        // This may vary based on target file type choosen
        public abstract void ExportData();        

        // This is the template method that the client will use.
        public void ExportFormatedData()
        {
            this.ReadData();
            this.FormatData();
            this.ExportData();
        }
       
    }
}