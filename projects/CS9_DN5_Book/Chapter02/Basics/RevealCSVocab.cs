using System;
using System.Collections.Generic;
using System.IO;

namespace Basics {

    public class Reveal {
        public List<string> FindAssemblies() {
            var list = new List<string>();

            var eo = new EnumerationOptions();
            eo.IgnoreInaccessible = true;
            eo.RecurseSubdirectories = true;
            
            var paths = Directory.EnumerateFiles("/", "*.dll", eo); // les.GetFiles("/", "*.dll", SearchOption.AllDirectories);
            list.AddRange(paths);
            return list;
        }
    } 
}