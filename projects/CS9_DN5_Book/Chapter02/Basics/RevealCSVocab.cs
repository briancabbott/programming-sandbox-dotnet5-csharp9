using System;
using System.Collections.Generic;
using System.IO;

namespace Basics {

    public class Reveal {
        public List<string> FindAssemblies() {
            var list = new List<string>();
            var paths = Directory.GetFiles("/", "*.dll", SearchOption.AllDirectories);
            list.AddRange(paths);
            return list;
        }
    } 
}