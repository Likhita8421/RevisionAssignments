using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class HandleException
    {   
       public static void Main()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Users\hp\Documents\RevisionAssignments\ExceptionHandling\ExceptionHandling\TextFile.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }

            catch(Exception e)
            {
                Console.WriteLine("Please Check if the file exists");
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block");

            }
        }

    }
}
