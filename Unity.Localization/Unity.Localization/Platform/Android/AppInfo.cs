using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Platform.Android
{
	// Token: 0x020000AF RID: 175
	[Serializable]
	public class AppInfo : Object
	{
		// Token: 0x060008BA RID: 2234 RVA: 0x0002AD60 File Offset: 0x00028F60
		// Note: this type is marked as 'beforefieldinit'.
		static AppInfo()
		{
			Il2CppClassPointerStore<AppInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Platform.Android", "AppInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppInfo>.NativeClassPtr);
			AppInfo.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, "m_DisplayName");
			AppInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664841);
			AppInfo.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664842);
			AppInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664843);
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0002ADE0 File Offset: 0x00028FE0
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x0002AE20 File Offset: 0x00029020
		public unsafe LocalizedString DisplayName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0002AE64 File Offset: 0x00029064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077007, XrefRangeEnd = 1077013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00005525 File Offset: 0x00003725
		public AppInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0002AEA0 File Offset: 0x000290A0
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x0000552E File Offset: 0x0000372E
		public unsafe LocalizedString m_DisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_DisplayName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_DisplayName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayName;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_LocalizedString_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_LocalizedString_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
