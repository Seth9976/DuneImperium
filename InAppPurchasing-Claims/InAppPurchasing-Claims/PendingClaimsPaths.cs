using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace iap.claims
{
	// Token: 0x0200000A RID: 10
	public static class PendingClaimsPaths : Object
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00002413 File Offset: 0x00000613
		// Note: this type is marked as 'beforefieldinit'.
		static PendingClaimsPaths()
		{
			Il2CppClassPointerStore<PendingClaimsPaths>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Claims.dll", "iap.claims", "PendingClaimsPaths");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingClaimsPaths>.NativeClassPtr);
			PendingClaimsPaths.NativeMethodInfoPtr_get_SavePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingClaimsPaths>.NativeClassPtr, 100663347);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00003EB4 File Offset: 0x000020B4
		public unsafe static string SavePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268038, XrefRangeEnd = 1268042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingClaimsPaths.NativeMethodInfoPtr_get_SavePath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000244C File Offset: 0x0000064C
		public PendingClaimsPaths(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_SavePath_Public_Static_get_String_0;
	}
}
