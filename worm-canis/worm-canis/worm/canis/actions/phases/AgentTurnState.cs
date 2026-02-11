using System;

namespace worm.canis.actions.phases
{
	// Token: 0x020002AF RID: 687
	public enum AgentTurnState
	{
		// Token: 0x0400117C RID: 4476
		InitializeAgentTurn,
		// Token: 0x0400117D RID: 4477
		GraftCard = 50,
		// Token: 0x0400117E RID: 4478
		DetermineAbilities = 75,
		// Token: 0x0400117F RID: 4479
		PlayAgentCard = 100,
		// Token: 0x04001180 RID: 4480
		SendAgentToSpace = 200,
		// Token: 0x04001181 RID: 4481
		ReevaluatePassiveAbilities = 300,
		// Token: 0x04001182 RID: 4482
		ResolveFirstAbilities = 350,
		// Token: 0x04001183 RID: 4483
		ResolveSpaceAbility = 400,
		// Token: 0x04001184 RID: 4484
		ResolveAgentAbility = 500,
		// Token: 0x04001185 RID: 4485
		ResolveImmediateDeferredAbilities = 600,
		// Token: 0x04001186 RID: 4486
		FireTriggers = 700
	}
}
