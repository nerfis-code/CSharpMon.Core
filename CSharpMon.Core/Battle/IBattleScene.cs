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
        BattleContext _context { get; }
        HandleEvent<BattleEvent> HandleEvent {  set; get; }
        async Task ShowMessage() {}
        async Task Loop() { }
    }
}
