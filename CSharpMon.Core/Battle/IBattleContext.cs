using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle
{
    public interface IBattleContext
    {
        IBattleScene Scene { get; }
        HandleBattleEvent HandleBattleEvent { get; }
        List<Mon> PlayerParty { get; set;  }
        List<Mon> EnemyParty { get; set; }
    }
}
