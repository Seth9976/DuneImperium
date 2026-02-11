using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	public static class SubsystemBindings
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002541 File Offset: 0x00000741
		public static void DestroySubsystem(IntPtr nativePtr)
		{
			SubsystemBindings.DestroySubsystemDelegateField(nativePtr);
		}

		// Token: 0x04000034 RID: 52
		private static readonly SubsystemBindings.DestroySubsystemDelegate DestroySubsystemDelegateField = IL2CPP.ResolveICall<SubsystemBindings.DestroySubsystemDelegate>("UnityEngine.SubsystemBindings::DestroySubsystem");

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000A7 RID: 167
		private delegate void DestroySubsystemDelegate(IntPtr nativePtr);
	}
}
