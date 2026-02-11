using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000310 RID: 784
	public static class FrameDebugger
	{
		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002DE4 RID: 11748 RVA: 0x00012492 File Offset: 0x00010692
		public static bool enabled
		{
			get
			{
				return FrameDebugger.IsLocalEnabled() || FrameDebugger.IsRemoteEnabled();
			}
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x000124A3 File Offset: 0x000106A3
		public static bool IsLocalEnabled()
		{
			return FrameDebugger.IsLocalEnabledDelegateField();
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x000124AF File Offset: 0x000106AF
		public static bool IsRemoteEnabled()
		{
			return FrameDebugger.IsRemoteEnabledDelegateField();
		}

		// Token: 0x04002951 RID: 10577
		private static readonly FrameDebugger.IsLocalEnabledDelegate IsLocalEnabledDelegateField = IL2CPP.ResolveICall<FrameDebugger.IsLocalEnabledDelegate>("UnityEngine.FrameDebugger::IsLocalEnabled");

		// Token: 0x04002952 RID: 10578
		private static readonly FrameDebugger.IsRemoteEnabledDelegate IsRemoteEnabledDelegateField = IL2CPP.ResolveICall<FrameDebugger.IsRemoteEnabledDelegate>("UnityEngine.FrameDebugger::IsRemoteEnabled");

		// Token: 0x02000B6E RID: 2926
		// (Invoke) Token: 0x06003FD1 RID: 16337
		private delegate bool IsLocalEnabledDelegate();

		// Token: 0x02000B6F RID: 2927
		// (Invoke) Token: 0x06003FD3 RID: 16339
		private delegate bool IsRemoteEnabledDelegate();
	}
}
