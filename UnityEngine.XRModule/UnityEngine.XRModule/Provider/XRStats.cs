using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR.Provider
{
	// Token: 0x02000024 RID: 36
	public static class XRStats
	{
		// Token: 0x06000175 RID: 373 RVA: 0x000066E8 File Offset: 0x000048E8
		public static bool TryGetStat(IntegratedSubsystem xrSubsystem, string tag, out float value)
		{
			return XRStats.TryGetStat_Internal(xrSubsystem.m_Ptr, tag, out value);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002CA1 File Offset: 0x00000EA1
		public static bool TryGetStat_Internal(IntPtr ptr, string tag, out float value)
		{
			return XRStats.TryGetStat_InternalDelegateField(ptr, IL2CPP.ManagedStringToIl2Cpp(tag), out value);
		}

		// Token: 0x0400015B RID: 347
		private static readonly XRStats.TryGetStat_InternalDelegate TryGetStat_InternalDelegateField = IL2CPP.ResolveICall<XRStats.TryGetStat_InternalDelegate>("UnityEngine.XR.Provider.XRStats::TryGetStat_Internal");

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000264 RID: 612
		private delegate bool TryGetStat_InternalDelegate(IntPtr ptr, IntPtr tag, [Out] IntPtr value);
	}
}
