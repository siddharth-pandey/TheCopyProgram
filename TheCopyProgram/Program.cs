using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheCopyProgram
{
    class CopyProgram
    {
        static void Main(string[] args)
        {
            // Main purpose of this copy program is to read from keyboard and then write to a printer which the below classes are just going to spoof that its reading 
            //from user input and writing to a printer.

            var keyboardReader = new KeyboardReader();
            keyboardReader.Read();

            Thread.Sleep(2000);

            var printerWriter = new PrinterWriter();
            printerWriter.Write();


            // The code above does the job very well. But say suppose, the requirements of our copy program changes and we are asked to write to the disk instead of a printer!!
            // Or instead of reading from keyboard, read from some other source for example a touch device!!
            // In any of the cases above, our CopyProgram needs to be modified because at the moment it directly depends on classes KeyboardReader and PrinterWriter. So, if we want
            // to add support for writing to disk, we will have to comment out the code on line number 22-23 and uncomment the lines below:

            //var diskWriter = new DiskWriter();
            //diskWriter.Write();

            //The solution to above issue is in the other project TheCopyProgramWithDIPSolution
        }
    }
}
