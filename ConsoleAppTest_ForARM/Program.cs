using System;
using System.IO;
using MongoDB.Driver;

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
                //var libraryVersion = MongoDB.Libmongocrypt.Library.Version;
                var t = new MongoClient();
                Console.WriteLine("Success"); // should not be reached with ARM
            }
            catch (FileNotFoundException e)
            {
                // expected path for ARM
                Console.WriteLine("Expected failing: " + e);
            }
        }
    }
}
