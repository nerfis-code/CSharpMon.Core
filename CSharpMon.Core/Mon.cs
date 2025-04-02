using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core
{
    public class Mon
    {
        private readonly Species _species;
        public string Name { get; set; }
        public int[] Stats { get; set; }
    }
}
