namespace CSharpMon.Core.Battle
{
    public class BattleSceneConsole:  IBattleScene
    {
        public BattleContext Context { get; set; }
        public HandleEvent<BattleEvent> HandleEvent {  set; get; }
        public BattleEvent? CurrentBattleEvent {  set; get; }
        public BattleSceneConsole(BattleContext ctx, BattleEvent[] events) 
        {
            Context = ctx;
            ctx.Scene = this;
            HandleEvent = new HandleBattleEvent();
            ctx.HandleBattleEvent = HandleEvent;
            HandleEvent.AddEventCollection(events);
        }
        public async Task ShowMessage(string message = ""){
            Console.WriteLine(message);
        }
        public async Task Loop() 
        {
            foreach (var e in HandleEvent.GetEventsToExecute()){
                e.Run?.Invoke();
            }
        }

    }
}