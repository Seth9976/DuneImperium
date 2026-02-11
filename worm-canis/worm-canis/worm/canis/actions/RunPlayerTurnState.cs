using System;

namespace worm.canis.actions
{
	// Token: 0x02000294 RID: 660
	public enum RunPlayerTurnState
	{
		// Token: 0x040010FA RID: 4346
		DetermineAbilityOutcome,
		// Token: 0x040010FB RID: 4347
		ReevaluatePassiveAbilities = 100,
		// Token: 0x040010FC RID: 4348
		FireTriggers = 200,
		// Token: 0x040010FD RID: 4349
		Cleanup = 300
	}
}
