namespace CSharpMon.Core.Battle
{
    public class BattleSceneConsole:  IBattleScene
    {
        public BattleContext _context { get; }
        public HandleEvent<BattleEvent> HandleEvent {  set; get; }
        public async Task ShowMessage(string message = ""){
            Console.WriteLine("Hello World!");
        }
        async Task Loop() { }
    }
}
