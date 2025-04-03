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
        public Func<bool> ShouldRun { get; set; } = () => { throw new NotImplementedException(); };
        public Func<bool> ShouldBeEliminated { get; set; } = () => { throw new NotImplementedException(); };
        public bool OneShot { get; set; }
        public Lazy<Task> Run { get; set; } // Run.value // new Lazy<Task<int>>(async () => await CalculateAsync());
    }
}
