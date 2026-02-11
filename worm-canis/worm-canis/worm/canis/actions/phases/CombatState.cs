using System;

namespace worm.canis.actions.phases
{
	// Token: 0x020002B4 RID: 692
	public enum CombatState
	{
		// Token: 0x040011BC RID: 4540
		BeginCombat,
		// Token: 0x040011BD RID: 4541
		PlayCombatIntrigueCards = 100,
		// Token: 0x040011BE RID: 4542
		DetermineRewards = 200,
		// Token: 0x040011BF RID: 4543
		ResolveCombat = 300,
		// Token: 0x040011C0 RID: 4544
		PlayCombatResolutionIntrigueCards = 400
	}
}
