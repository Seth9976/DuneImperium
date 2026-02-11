using System;

namespace worm.canis.actions.phases
{
	// Token: 0x020002CD RID: 717
	public enum PlayerTurnState
	{
		// Token: 0x0400126C RID: 4716
		PrePlayerTurn,
		// Token: 0x0400126D RID: 4717
		DetermineTurn = 10,
		// Token: 0x0400126E RID: 4718
		TakeAgentTurn = 20,
		// Token: 0x0400126F RID: 4719
		TakeRevealTurn = 30,
		// Token: 0x04001270 RID: 4720
		ResolveDeferredAbilities = 40,
		// Token: 0x04001271 RID: 4721
		ResolveDelayedAbilities = 50,
		// Token: 0x04001272 RID: 4722
		Cleanup = 60
	}
}
