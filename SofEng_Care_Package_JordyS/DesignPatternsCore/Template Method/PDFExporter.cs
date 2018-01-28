using System;

namespace Template_Method
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// implements the primitive operations ot carry out subclass-specific steps of the algorithm
    /// </summary>
    public class PDFExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting the data to a PDF file.");
        }
    }
}