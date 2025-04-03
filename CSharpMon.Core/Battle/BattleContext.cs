using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle
{
    public class BattleContext
    {
        public IBattleScene Scene { get; set; }
        public HandleEvent<BattleEvent> HandleBattleEvent { get; set; } = new HandleBattleEvent();
        public List<Mon> PlayerParty { get; set;  } = [];
        public List<Mon> EnemyParty { get; set; } = [];
        public BattleStatus BattleStatus { get; set; } = BattleStatus.InProgress;
    }
}
