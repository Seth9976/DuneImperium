using System;

namespace UnityEngine.XR
{
	// Token: 0x0200001A RID: 26
	public enum InputDeviceCharacteristics : uint
	{
		// Token: 0x04000128 RID: 296
		None,
		// Token: 0x04000129 RID: 297
		HeadMounted,
		// Token: 0x0400012A RID: 298
		Camera,
		// Token: 0x0400012B RID: 299
		HeldInHand = 4U,
		// Token: 0x0400012C RID: 300
		HandTracking = 8U,
		// Token: 0x0400012D RID: 301
		EyeTracking = 16U,
		// Token: 0x0400012E RID: 302
		TrackedDevice = 32U,
		// Token: 0x0400012F RID: 303
		Controller = 64U,
		// Token: 0x04000130 RID: 304
		TrackingReference = 128U,
		// Token: 0x04000131 RID: 305
		Left = 256U,
		// Token: 0x04000132 RID: 306
		Right = 512U,
		// Token: 0x04000133 RID: 307
		Simulated6DOF = 1024U
	}
}
