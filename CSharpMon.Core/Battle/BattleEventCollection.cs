using System;
using System.Threading.Tasks;

namespace CSharpMon.Core.Battle.Events
{
    public class BattleEventCollection
    {
        private static BattleEventCollection? _instance;
        private static readonly object _lock = new object();

        public static BattleEventCollection Instance 
        { 
            get 
            {
                if (_instance == null)
                    throw new InvalidOperationException("BattleEventCollection is not initialized.");
                return _instance;
            } 
        }

        private BattleContext _battleContext;

        private BattleEventCollection(BattleContext battleContext)
        {
            _battleContext = battleContext ?? throw new ArgumentNullException(nameof(battleContext));
        }

        public static void Initialize(BattleContext battleContext)
        {
            lock (_lock)
            {
                if (_instance != null)
                    throw new InvalidOperationException("BattleEventCollection is already initialized.");
                
                _instance = new BattleEventCollection(battleContext);
            }
        }

        public BattleEvent StartBattle()
        {
            return new BattleEvent
            {
                Type = BattleEventType.StartBattle,
                ShouldRun = () => true,
                ShouldBeEliminated = () => false,
                OneShot = true,
                Run = () => {
                }
            };
        }
        public BattleEvent EnemyReveal()
        {
            return new BattleEvent
            {
                Type = BattleEventType.EnemyReveal,
                Run =  () => { 
                    
                }
            };
        }
        public BattleEvent Custom(){
            return new BattleEvent
            {
                Type = BattleEventType.StartBattle,
                Run =  () => { }
            };
        }

    }
}

// public BattleEvent TestBattle(string pokename)
//     {
//         return new BattleEvent
//         {
//             Type = BattleEventType.EnemyReveal,
//             ShouldRun = () => true,
//             ShouldBeEliminated = () => false,
//             OneShot = true,
//             Run =  () => { }
//         };
//     }
