using System;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	// Token: 0x020002A5 RID: 677
	public static class NativeLeakDetection
	{
		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x000B2D08 File Offset: 0x000B0F08
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x000B2D20 File Offset: 0x000B0F20
		public static NativeLeakDetectionMode Mode
		{
			get
			{
				return Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetLeakDetectionMode();
			}
			set
			{
				bool flag = value < NativeLeakDetectionMode.Disabled || value > NativeLeakDetectionMode.EnabledWithStackTrace;
				if (flag)
				{
					throw new ArgumentException("NativeLeakDetectionMode out of range");
				}
				Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SetLeakDetectionMode(value);
			}
		}
	}
}
