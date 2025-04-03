namespace CSharpMon.Core
{
    public class FactoryMon
    {
        public static Mon? Create(string speciesName)
        {
            var species = Resources.GetSpecies(speciesName);
            if (species == null) return null;
            var mon = new Mon{
                Species = species,
                Form = 0,
                Experience = 0,
                Level = 50,
                NickName = species.Name,
                PrimaryType = species.PrimaryType,
                SecondaryType = species.SecondaryType,
                CurrentPs = 0,
                Stats = new Stats(),
                Happiness = 50,
                Moves = [],
                Ability = ""
   
            };
            return mon;
        }
        public static Mon Create(string speciesName, int level)
        {
            return new Mon();
        }
    }
}