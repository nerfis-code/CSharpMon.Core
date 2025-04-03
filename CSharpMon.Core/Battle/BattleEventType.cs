namespace CSharpMon.Core.Battle
{
    // sorted by priority
    //TODO: Add more events
    public enum BattleEventType
    {
        StartBattle,
        EndBattle,
        EnemyReveal,
        PlayerReveal,

        DefeadBattler,
        BattlerEntry,
        BattlerExit,
        
        OrganizeTurns,
        Escape,
        SwapBattler,
        ExecuteMove,
        Item,
        
        StartTurn,
        HandlePlayerInput,
        HandleEnemyInput,
        EndTurn,

    }
}
