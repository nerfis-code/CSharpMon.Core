using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle
{
    public class BattleEvent
    {
        public BattleEventType Type { get; set; }
        public string ID { get; set; }
        public Func<bool> ShouldRun { get; set; }
        public Func<bool> ShouldBeEliminated { get; set; }
        public bool OneShot { get; set; }
        public Action Run { get; set; } 
    }
}
