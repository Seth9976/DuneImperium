using System;

namespace worm.canis.actions.phases
{
	// Token: 0x020002D0 RID: 720
	public enum RevealTurnState
	{
		// Token: 0x0400128F RID: 4751
		DoInitialReveal,
		// Token: 0x04001290 RID: 4752
		PlayRevealCardsPlay = 100,
		// Token: 0x04001291 RID: 4753
		FireRevealStartTriggers = 200,
		// Token: 0x04001292 RID: 4754
		ResolveRevealAbilities = 300,
		// Token: 0x04001293 RID: 4755
		ResolveImmediateDeferredAbilities = 400,
		// Token: 0x04001294 RID: 4756
		FirePlayedTriggers = 500
	}
}
