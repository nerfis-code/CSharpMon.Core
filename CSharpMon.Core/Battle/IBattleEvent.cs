using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle
{
    public interface IBattleEvent
    {
        string Type { get; }
        bool ShouldExecute(IBattleContext BattleContext);
        bool ShouldEliminated(IBattleContext BattleContext);

        async Task Run(IBattleContext BattleContext) {}
    }
}
