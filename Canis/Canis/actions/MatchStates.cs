using System;

namespace Canis.actions
{
	// Token: 0x020001B3 RID: 435
	public enum MatchStates
	{
		// Token: 0x04000C0F RID: 3087
		Initialize,
		// Token: 0x04000C10 RID: 3088
		GameSetup = 10,
		// Token: 0x04000C11 RID: 3089
		GameTurn = 20,
		// Token: 0x04000C12 RID: 3090
		GameTurnOver = 30,
		// Token: 0x04000C13 RID: 3091
		GameOver = 40,
		// Token: 0x04000C14 RID: 3092
		MatchOver = 50
	}
}
