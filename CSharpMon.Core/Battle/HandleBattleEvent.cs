namespace CSharpMon.Core.Battle
{
    public class HandleBattleEvent: HandleEvent<IBattleEvent>
    {
        private IBattleContext _battleContext;
        public override void AddEvent(IBattleEvent battleEvent){
            _events.Add(battleEvent);
        }
        public override void Execute(){

        }
    }
}