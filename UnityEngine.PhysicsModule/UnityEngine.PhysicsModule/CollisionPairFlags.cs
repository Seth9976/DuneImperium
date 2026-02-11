using System;

namespace UnityEngine
{
	// Token: 0x02000016 RID: 22
	public enum CollisionPairFlags : ushort
	{
		// Token: 0x040001CC RID: 460
		RemovedShape = 1,
		// Token: 0x040001CD RID: 461
		RemovedOtherShape,
		// Token: 0x040001CE RID: 462
		ActorPairHasFirstTouch = 4,
		// Token: 0x040001CF RID: 463
		ActorPairLostTouch = 8,
		// Token: 0x040001D0 RID: 464
		InternalHasImpulses = 16,
		// Token: 0x040001D1 RID: 465
		InternalContactsAreFlipped = 32
	}
}
