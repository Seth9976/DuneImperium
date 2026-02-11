using System;

namespace UnityEngine.XR
{
	// Token: 0x02000004 RID: 4
	[Flags]
	public enum AvailableTrackingData
	{
		// Token: 0x0400001A RID: 26
		None = 0,
		// Token: 0x0400001B RID: 27
		PositionAvailable = 1,
		// Token: 0x0400001C RID: 28
		RotationAvailable = 2,
		// Token: 0x0400001D RID: 29
		VelocityAvailable = 4,
		// Token: 0x0400001E RID: 30
		AngularVelocityAvailable = 8,
		// Token: 0x0400001F RID: 31
		AccelerationAvailable = 16,
		// Token: 0x04000020 RID: 32
		AngularAccelerationAvailable = 32
	}
}
