using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMon.Core
{
    public class Mon
    {
        public Species Species { get; set; }
        public int Form { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public string NickName { get; set; } = string.Empty;
        public string PrimaryType { get; set; } = string.Empty;
        public string SecondaryType { get; set; } = string.Empty;
        public int CurrentPs { get; set; }
        public Stats Stats { get; set; } = new Stats();
        public Stats EV { get; set; } = new Stats();
        public Stats IV { get; set; } = new Stats();
        public int Happiness { get; set; }
        public string[] Moves { get; set; } = [];
        public string Ability { get; set; } = string.Empty;

        public void CalculateStats(){
            var level = (float)Level;
            var LastMaxPs = Stats.PS;
            Stats.PS =              (int)(10+( level/100 * ((Species.BaseStats[0]*2)+IV.PS*4))            + level + level *EV.PS          /100);

            Stats.Attack =          (int)(5+( level /100 * ((Species.BaseStats[1]*2)+IV.Attack      *4))      + level *EV.Attack          /100);
            Stats.Defense =         (int)(5+( level /100 * ((Species.BaseStats[2]*2)+IV.Defense     *4))      + level *EV.Defense         /100);
            Stats.Speed =           (int)(5+( level /100 * ((Species.BaseStats[3]*2)+IV.Speed       *4))      + level *EV.Speed           /100);
            Stats.SpecialAttack =   (int)(5+( level /100 * ((Species.BaseStats[4]*2)+IV.SpecialAttack   *4))  + level *EV.SpecialAttack   /100);
            Stats.SpecialDefense =  (int)(5+( level /100 * ((Species.BaseStats[5]*2)+IV.SpecialDefense  *4))  + level *EV.SpecialDefense  /100);
        
            var lostPoints = LastMaxPs - CurrentPs;
            CurrentPs = Stats.PS - lostPoints;
        }
    }
}
