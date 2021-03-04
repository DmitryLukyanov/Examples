using System;
using System.IO;

namespace ConsoleAppTest_ForARM
{
    class Program
    {
        // script to publish: 
        // dotnet publish -r linux-arm64 -f netcoreapp2.2 --configuration Release
        static void Main(string[] args)
        {
            // Check MongoDB.Libmongocrypt

            try
            {
                var libraryVersion = MongoDB.Libmongocrypt.Library.Version;
                Console.WriteLine(libraryVersion); // should not be reached with ARM
            }
            catch (FileNotFoundException e)
            {
                // expected path for ARM
                Console.WriteLine("Expected failing: " + e);
            }
        }
    }
}
