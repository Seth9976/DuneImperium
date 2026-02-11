using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.Unity.DWD
{
	// Token: 0x020000A0 RID: 160
	public static class DWDSystemInfo : Object
	{
		// Token: 0x06000AD4 RID: 2772 RVA: 0x00005D24 File Offset: 0x00003F24
		// Note: this type is marked as 'beforefieldinit'.
		static DWDSystemInfo()
		{
			Il2CppClassPointerStore<DWDSystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.Unity.DWD", "DWDSystemInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDSystemInfo>.NativeClassPtr);
			DWDSystemInfo.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDSystemInfo>.NativeClassPtr, 100664808);
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0003CBF8 File Offset: 0x0003ADF8
		public unsafe static string deviceUniqueIdentifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863177, XrefRangeEnd = 863178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDSystemInfo.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00005D5D File Offset: 0x00003F5D
		public DWDSystemInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0;
	}
}
