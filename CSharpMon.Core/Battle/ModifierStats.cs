namespace CSharpMon.Core.Battle
{
    public class ModifierStats
    {
        public string StatTarget { get; private set; } = string.Empty;
        public float Modifier { get; private set; }
        public ModifierStats(string statTarget, float modifier){
            StatTarget = statTarget;
            Modifier = modifier;
        }
        public void Apply(Stats stats){
            switch (StatTarget)
            {
                case "PS":
                    stats.PS = (int)(stats.PS * Modifier);
                    break;
                case "Attack":
                    stats.Attack = (int)(stats.Attack * Modifier);
                    break;
                case "Defense":
                    stats.Defense = (int)(stats.Defense * Modifier);
                    break;
                case "SpecialAttack":
                    stats.SpecialAttack = (int)(stats.SpecialAttack * Modifier);
                    break;
                case "SpecialDefense":
                    stats.SpecialDefense = (int)(stats.SpecialDefense * Modifier);
                    break;
                case "Speed":
                    stats.Speed = (int)(stats.Speed * Modifier);
                    break;
                case "Accuracy":
                    stats.Accuracy = (int)(stats.Accuracy * Modifier);
                    break;
                case "Evasion":
                    stats.Evasion = (int)(stats.Evasion * Modifier);
                    break;
                default:
                    break;
            }
        }
    }
    
}