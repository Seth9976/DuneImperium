using System;

namespace worm.canis.actions.phases
{
	// Token: 0x020002D5 RID: 725
	public enum RoundState
	{
		// Token: 0x040012BD RID: 4797
		RoundStart,
		// Token: 0x040012BE RID: 4798
		GenerateConflict = 3,
		// Token: 0x040012BF RID: 4799
		DrawCards = 7,
		// Token: 0x040012C0 RID: 4800
		PlayerTurns = 10,
		// Token: 0x040012C1 RID: 4801
		Combat = 20,
		// Token: 0x040012C2 RID: 4802
		Makers = 30,
		// Token: 0x040012C3 RID: 4803
		Recall = 40
	}
}
