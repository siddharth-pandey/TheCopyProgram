using System;

namespace TheCopyProgramWithDIPSolution
{
    internal class PrinterWriter : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Writing to Printer...");
        }
    }
}