using System;

namespace TheCopyProgramWithDIPSolution
{
    internal class DiskWriter : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Writing to Disk...");
        }
    }
}