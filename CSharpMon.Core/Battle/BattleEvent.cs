using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle
{
    public class BattleEvent
    {
        public BattleEventType Type { get; }
        public Action<IBattleContext> ShouldRun { get; } = context => { throw new NotImplementedException(); };
        public Action<IBattleContext> ShouldEliminated { get; } = context => { throw new NotImplementedException(); };
        public bool OneShot { get; }
        public Lazy<Task> Run { get; } // Run.value // new Lazy<Task<int>>(async () => await CalculateAsync());
    }
}
