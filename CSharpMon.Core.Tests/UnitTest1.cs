using CSharpMon.Core;
namespace CSharpMon.Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Resources_GetSepecies_SpeciesNameExist_ReturnSpecies()
        {
            Assert.IsType<Species>(Resources.GetSpecies("PIKACHU"));
        }
        [Fact]
        public void Resources_GetSepecies_NoneExistentSpeciesName_ReturnNull()
        {
            Assert.True(Resources.GetSpecies("NoneExistent") is null);
        }
    }
}