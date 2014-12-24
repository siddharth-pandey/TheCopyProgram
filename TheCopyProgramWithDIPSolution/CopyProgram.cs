using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheCopyProgramWithDIPSolution
{
    class CopyProgram
    {
        static void Main(string[] args)
        {
            // Go through TheCopyProgramWithProblem project before looking at this code.
            // Main purpose of this copy program is to read from a reader and then write to a specified writer.

            // Below we are following DIP, so that the high level module - CopyProgram defines an interface, a reader and a writer i.e. IReader and IWriter.
            // Now the lower level modules like Keyboard, Touch devices can implement IReader interface if they want to be consumed by CopyProgram class.
            // Similarly, the lower level modules like Printer, Disk, etc. can implement IWriter interface if they want to be consume by CopyProgram class.

            // For the sake of demo purpose, The concrete class names are used for instantiation. This can be replaced by user input like which device to 
            // choose and create an object of specific readers and writers depending on user's input.

            // if done in the way explained above, CopyProgram will have require no changes to be done even if we add n number of new or modify existing devices
            // to read and write.

            IReader reader = new KeyboardReader();
            reader.Read();

            Thread.Sleep(2000);

            IWriter writer = new PrinterWriter();
            writer.Write();
        }
    }
}
