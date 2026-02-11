using System;

namespace worm.canis.actions.phases
{
	// Token: 0x020002D8 RID: 728
	public enum SetupState
	{
		// Token: 0x040012D6 RID: 4822
		BeginSetup,
		// Token: 0x040012D7 RID: 4823
		CreateDecks = 10,
		// Token: 0x040012D8 RID: 4824
		EmitSerializedGameState = 20,
		// Token: 0x040012D9 RID: 4825
		LeaderAssignment = 30,
		// Token: 0x040012DA RID: 4826
		DraftDeckSetup = 35,
		// Token: 0x040012DB RID: 4827
		CompleteSetup = 40,
		// Token: 0x040012DC RID: 4828
		AdditionalLeaderSetup = 50,
		// Token: 0x040012DD RID: 4829
		AdditionalLeaderSetup2 = 60
	}
}
