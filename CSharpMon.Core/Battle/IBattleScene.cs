using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle
{
    public interface IBattleScene
    {
        BattleContext Context { get; }
        HandleEvent<BattleEvent> HandleEvent {  set; get; }
        BattleEvent CurrentBattleEvent { get; set; }
        async Task ShowMessage(string message) {}
        async Task Loop() { }
    }
}
