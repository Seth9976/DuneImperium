using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.iap
{
	// Token: 0x02000007 RID: 7
	public static class OwnedProductsPaths : Object
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000020F0 File Offset: 0x000002F0
		// Note: this type is marked as 'beforefieldinit'.
		static OwnedProductsPaths()
		{
			Il2CppClassPointerStore<OwnedProductsPaths>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.core.iap", "OwnedProductsPaths");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OwnedProductsPaths>.NativeClassPtr);
			OwnedProductsPaths.NativeMethodInfoPtr_get_SavePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedProductsPaths>.NativeClassPtr, 100663311);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00004308 File Offset: 0x00002508
		public unsafe static string SavePath
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1199600, RefRangeEnd = 1199602, XrefRangeStart = 1199589, XrefRangeEnd = 1199600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedProductsPaths.NativeMethodInfoPtr_get_SavePath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002129 File Offset: 0x00000329
		public OwnedProductsPaths(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_SavePath_Public_Static_get_String_0;
	}
}
