using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle
{
    public class BattleContext
    {
        public IBattleScene Scene { get; set; } = default!;
        public HandleEvent<BattleEvent> HandleBattleEvent { get; set; } = default!;
        public List<Mon> PlayerParty { get; set;  } = [];
        public List<Mon> EnemyParty { get; set; } = [];
        public BattleStatus BattleStatus { get; set; } = BattleStatus.InProgress;
        public List<Battler> EnemyBattlerSide { get; set; } = [];
        public List<Battler> PlayerBattlerSide { get; set; } = [];


        public Battler Attacker { get; set; } = default!;
        public Battler Defender { get; set; } = default!;
        public Move Move { get; set; } = default!;
    }
}
