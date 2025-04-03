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
        IBattleContext _context { get; }
        IBattleEvent[] _initialEvents {set; get;}
        IBattleEvent[] _eventLoop {set; get; }
        HandleEvent<IBattleEvent> HandleEvent {  set; get; }

        async Task Loop() { }
    }
}
