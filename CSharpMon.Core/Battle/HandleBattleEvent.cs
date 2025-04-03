namespace CSharpMon.Core.Battle
{
    public class HandleBattleEvent: HandleEvent<IBattleEvent>
    {
        private IBattleContext _battleContext;
        public override HandleBattleEvent AddEvent(IBattleEvent battleEvent){
            for(int i = 0; i < _events.Count; i++){
                if((int)_events[i].Type > (int)battleEvent.Type){
                    _events.Insert(i, battleEvent);
                    return this;
                }
            }
            _events.Add(battleEvent);
            return this;
        }
        public override HandleBattleEvent AddEventCollection(IBattleEvent[] battleEvents){
            var sortedBattleEvents = battleEvents.OrderBy(x => (int)x.Type).ToArray();
            for(int i = 0; i < _events.Count; i++){
                if((int)_events[i].Type > (int)sortedBattleEvents[0].Type){
                    _events.InsertRange(i, sortedBattleEvents);
                    return this;
                }
            }
            _events.AddRange(sortedBattleEvents);
            return this;
        }
        public override async Task Execute(){
            while(_events.Count > 0){
                var battleEvent = _events[0];
                //_events.RemoveAt(0);
                if(battleEvent.ShouldRun(_battleContext)){
                    await battleEvent.Run(_battleContext);
                    if (battleEvent.OneShot){
                       _events.Remove(battleEvent);
                       continue;
                    }
                }
                if(battleEvent.ShouldEliminated(_battleContext)){
                    _events.Remove(battleEvent);
                }
            }
        }
    }
}