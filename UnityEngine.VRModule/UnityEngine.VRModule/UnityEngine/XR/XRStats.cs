using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x02000007 RID: 7
	public static class XRStats
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000021E2 File Offset: 0x000003E2
		public static bool TryGetGPUTimeLastFrame(out float gpuTimeLastFrame)
		{
			return XRStats.TryGetGPUTimeLastFrameDelegateField(out gpuTimeLastFrame);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021EF File Offset: 0x000003EF
		public static bool TryGetDroppedFrameCount(out int droppedFrameCount)
		{
			return XRStats.TryGetDroppedFrameCountDelegateField(out droppedFrameCount);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000021FC File Offset: 0x000003FC
		public static bool TryGetFramePresentCount(out int framePresentCount)
		{
			return XRStats.TryGetFramePresentCountDelegateField(out framePresentCount);
		}

		// Token: 0x0400002D RID: 45
		private static readonly XRStats.TryGetGPUTimeLastFrameDelegate TryGetGPUTimeLastFrameDelegateField = IL2CPP.ResolveICall<XRStats.TryGetGPUTimeLastFrameDelegate>("UnityEngine.XR.XRStats::TryGetGPUTimeLastFrame");

		// Token: 0x0400002E RID: 46
		private static readonly XRStats.TryGetDroppedFrameCountDelegate TryGetDroppedFrameCountDelegateField = IL2CPP.ResolveICall<XRStats.TryGetDroppedFrameCountDelegate>("UnityEngine.XR.XRStats::TryGetDroppedFrameCount");

		// Token: 0x0400002F RID: 47
		private static readonly XRStats.TryGetFramePresentCountDelegate TryGetFramePresentCountDelegateField = IL2CPP.ResolveICall<XRStats.TryGetFramePresentCountDelegate>("UnityEngine.XR.XRStats::TryGetFramePresentCount");

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600005D RID: 93
		private delegate bool TryGetGPUTimeLastFrameDelegate([Out] IntPtr gpuTimeLastFrame);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600005F RID: 95
		private delegate bool TryGetDroppedFrameCountDelegate([Out] IntPtr droppedFrameCount);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000061 RID: 97
		private delegate bool TryGetFramePresentCountDelegate([Out] IntPtr framePresentCount);
	}
}
