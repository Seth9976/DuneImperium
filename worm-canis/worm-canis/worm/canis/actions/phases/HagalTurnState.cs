using System;

namespace worm.canis.actions.phases
{
	// Token: 0x020002CA RID: 714
	public enum HagalTurnState
	{
		// Token: 0x0400124C RID: 4684
		PrePlayerTurn,
		// Token: 0x0400124D RID: 4685
		DetermineTurn = 10,
		// Token: 0x0400124E RID: 4686
		TakeAgentTurn = 20,
		// Token: 0x0400124F RID: 4687
		TakeRevealTurn = 30,
		// Token: 0x04001250 RID: 4688
		ResolveDeferredAbilities = 40,
		// Token: 0x04001251 RID: 4689
		DeployUnits = 50,
		// Token: 0x04001252 RID: 4690
		Cleanup = 60
	}
}
