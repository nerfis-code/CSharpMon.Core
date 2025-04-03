using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpMon.Core.Battle;
using CSharpMon.Core.Battle.Events;

namespace CSharpMon.Core
{
    public static class Program
    {
        public static void Main(string[] args) {

            test();
        }

        public static async Task test()
        {
            var ctx = new BattleContext();
            BattleEventCollection.Initialize(ctx);
            var c = BattleEventCollection.Instance;
            var scene = new BattleSceneConsole(ctx,
                [
                    c.StartBattle()
                ]);
            await scene.Loop();
        }
    }
}
