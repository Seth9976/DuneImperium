using System;

namespace UnityEngine.XR
{
	// Token: 0x0200001B RID: 27
	public enum InputTrackingState : uint
	{
		// Token: 0x04000135 RID: 309
		None,
		// Token: 0x04000136 RID: 310
		Position,
		// Token: 0x04000137 RID: 311
		Rotation,
		// Token: 0x04000138 RID: 312
		Velocity = 4U,
		// Token: 0x04000139 RID: 313
		AngularVelocity = 8U,
		// Token: 0x0400013A RID: 314
		Acceleration = 16U,
		// Token: 0x0400013B RID: 315
		AngularAcceleration = 32U,
		// Token: 0x0400013C RID: 316
		All = 63U
	}
}
