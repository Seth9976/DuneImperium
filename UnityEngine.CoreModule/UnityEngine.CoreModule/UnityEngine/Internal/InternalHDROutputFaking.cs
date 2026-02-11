using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Internal
{
	// Token: 0x02000333 RID: 819
	public static class InternalHDROutputFaking
	{
		// Token: 0x06002E2E RID: 11822 RVA: 0x000127BF File Offset: 0x000109BF
		public static void SetEnabled(bool enabled)
		{
			InternalHDROutputFaking.SetEnabledDelegateField(enabled);
		}

		// Token: 0x040029B2 RID: 10674
		private static readonly InternalHDROutputFaking.SetEnabledDelegate SetEnabledDelegateField = IL2CPP.ResolveICall<InternalHDROutputFaking.SetEnabledDelegate>("UnityEngine.Internal.InternalHDROutputFaking::SetEnabled");

		// Token: 0x02000B84 RID: 2948
		// (Invoke) Token: 0x06003FFB RID: 16379
		private delegate void SetEnabledDelegate(bool enabled);
	}
}
