namespace CSharpMon.Core.Battle
{
    
    public interface IBattleAction
    {
        public string Type { get; set; }
        public bool IsValid();
        public void Execute(IBattleContext BattleContext);
    }
}