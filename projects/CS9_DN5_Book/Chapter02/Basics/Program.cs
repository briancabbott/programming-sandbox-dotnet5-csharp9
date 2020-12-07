using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Basics {
        
    public class Program {

        static void Main(string[] args) {
            // #error version
            // Console.WriteLine("Hello World!");

            var files = new Reveal().FindAssemblies();
            string filesAsJson = JsonSerializer.Serialize(files);
            File.WriteAllText("./FilesList.json", filesAsJson);

        }

    }
}