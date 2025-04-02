using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle
{
    public abstract class HandleBattleEvent
    {
        // initial events
        public IBattleEvent? StartBattle {  get; }
        public IBattleEvent? OpponentReveal { get; }
        public IBattleEvent? PlayerReveal { get; }
        // loop event
        public IBattleEvent? StartTurn { get; }
        public IBattleEvent? HandleInput { get; }
        public IBattleEvent? OrganizeTurns { get; }
        public IBattleEvent? ExecuteMove { get; }
        public IBattleEvent? SwapBattler { get; }
        public IBattleEvent? Item { get; }
        public IBattleEvent? Scape { get; }
        public IBattleEvent? EndBattle { get; }


        public IBattleEvent? DefeadBattler { get; }
        public IBattleEvent? BattlerRelease { get; }
        public IBattleEvent? BattlerEntry { get; }
    }
}
