using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSharpMon.Core
{
    public class Species
    {
        public int Generation { get; set; }
        public string PrimaryType { get; set; } = string.Empty;
        public string SecondaryType { get; set; } = string.Empty;
        public double Height { get; set; }
        public double Weight { get; set; }
        public int BaseTotal { get; set; }
        public string Name { get; set; } = string.Empty;
        [JsonPropertyName("Species")]
        public string SpeciesName { get; set; } = string.Empty;
        public int CatchRate { get; set; }
        public int Happiness { get; set; }
        public int BaseExp { get; set; }
        public string GrowthRate { get; set; } = string.Empty;
        public int GenderRatio { get; set; }
        public int InternationalPokedex { get; set; }

        public object[] Moves { get; set; } = [];
        public string[] TutorMoves { get; set; } = [];
        public int[] BaseStats { get; set; } = [];
        public string[] EggMoves { get; set; } = [];
        public  string[] Abilities { get; set; } = [];
        public string[] HiddenAbilitie { get; set; } = [];
        public string[] Flags { get; set; } = [];
        public object[] Evs { get; set; } = [];
        // public object[] Forms { get; set; } = [];

    }
}
