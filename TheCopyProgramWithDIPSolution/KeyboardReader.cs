using System;

namespace TheCopyProgramWithDIPSolution
{
    internal class KeyboardReader : IReader
    {
        public void Read()
        {
            Console.WriteLine("Reading from Keyboard...");
        }
    }
}