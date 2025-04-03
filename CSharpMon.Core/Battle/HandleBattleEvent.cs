namespace CSharpMon.Core.Battle
{
    public class HandleBattleEvent: HandleEvent<BattleEvent>
    {
        public override HandleBattleEvent AddEvent(BattleEvent battleEvent){
            for(int i = 0; i < _events.Count; i++){
                if((int)_events[i].Type > (int)battleEvent.Type){
                    _events.Insert(i, battleEvent);
                    return this;
                }
            }
            _events.Add(battleEvent);
            return this;
        }
        public override HandleBattleEvent AddEventCollection(BattleEvent[] battleEvents){
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
        public override IEnumerable<BattleEvent> Execute(){
            while(_events.Count > 0){
                var battleEvent = _events[0];

                if (battleEvent.ShouldBeEliminated())
                {
                    _events.Remove(battleEvent);
                    continue;
                }
                if (battleEvent.ShouldRun()){
                    if (battleEvent.OneShot) _events.Remove(battleEvent);
                    yield return battleEvent;
                }
            }
        }
    }
}