using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle
{
    public interface IBattleEvent
    {
        List<IBattleAction> Actions { get; set; }
        string Name { get; }
        List<Action<IBattleContext>> SortActionsByPriority();
        async Task<bool> Run(IBattleContext BattleContext) {
            return true;
        }
    }
}
