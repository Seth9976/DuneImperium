using System;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	public enum CollisionPairEventFlags : ushort
	{
		// Token: 0x040001D3 RID: 467
		SolveContacts = 1,
		// Token: 0x040001D4 RID: 468
		ModifyContacts,
		// Token: 0x040001D5 RID: 469
		NotifyTouchFound = 4,
		// Token: 0x040001D6 RID: 470
		NotifyTouchPersists = 8,
		// Token: 0x040001D7 RID: 471
		NotifyTouchLost = 16,
		// Token: 0x040001D8 RID: 472
		NotifyTouchCCD = 32,
		// Token: 0x040001D9 RID: 473
		NotifyThresholdForceFound = 64,
		// Token: 0x040001DA RID: 474
		NotifyThresholdForcePersists = 128,
		// Token: 0x040001DB RID: 475
		NotifyThresholdForceLost = 256,
		// Token: 0x040001DC RID: 476
		NotifyContactPoint = 512,
		// Token: 0x040001DD RID: 477
		DetectDiscreteContact = 1024,
		// Token: 0x040001DE RID: 478
		DetectCCDContact = 2048,
		// Token: 0x040001DF RID: 479
		PreSolverVelocity = 4096,
		// Token: 0x040001E0 RID: 480
		PostSolverVelocity = 8192,
		// Token: 0x040001E1 RID: 481
		ContactEventPose = 16384,
		// Token: 0x040001E2 RID: 482
		NextFree = 32768,
		// Token: 0x040001E3 RID: 483
		ContactDefault = 1025,
		// Token: 0x040001E4 RID: 484
		TriggerDefault = 1044
	}
}
