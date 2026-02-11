using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x0200009F RID: 159
	[Serializable]
	public class SpecificLocaleSelector : Object
	{
		// Token: 0x060007EC RID: 2028 RVA: 0x00027D44 File Offset: 0x00025F44
		// Note: this type is marked as 'beforefieldinit'.
		static SpecificLocaleSelector()
		{
			Il2CppClassPointerStore<SpecificLocaleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "SpecificLocaleSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecificLocaleSelector>.NativeClassPtr);
			SpecificLocaleSelector.NativeFieldInfoPtr_m_LocaleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecificLocaleSelector>.NativeClassPtr, "m_LocaleId");
			SpecificLocaleSelector.NativeMethodInfoPtr_get_LocaleId_Public_get_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecificLocaleSelector>.NativeClassPtr, 100664711);
			SpecificLocaleSelector.NativeMethodInfoPtr_set_LocaleId_Public_set_Void_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecificLocaleSelector>.NativeClassPtr, 100664712);
			SpecificLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecificLocaleSelector>.NativeClassPtr, 100664713);
			SpecificLocaleSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecificLocaleSelector>.NativeClassPtr, 100664714);
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00027DD8 File Offset: 0x00025FD8
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00027E10 File Offset: 0x00026010
		public unsafe LocaleIdentifier LocaleId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecificLocaleSelector.NativeMethodInfoPtr_get_LocaleId_Public_get_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LocaleIdentifier(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075926, XrefRangeEnd = 1075942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecificLocaleSelector.NativeMethodInfoPtr_set_LocaleId_Public_set_Void_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00027E58 File Offset: 0x00026058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075942, XrefRangeEnd = 1075945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableLocales);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecificLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00027EA8 File Offset: 0x000260A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075945, XrefRangeEnd = 1075948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecificLocaleSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecificLocaleSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecificLocaleSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000050B0 File Offset: 0x000032B0
		public SpecificLocaleSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00027EE4 File Offset: 0x000260E4
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x000050B9 File Offset: 0x000032B9
		public LocaleIdentifier m_LocaleId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecificLocaleSelector.NativeFieldInfoPtr_m_LocaleId);
				return new LocaleIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecificLocaleSelector.NativeFieldInfoPtr_m_LocaleId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_m_LocaleId;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_get_LocaleId_Public_get_LocaleIdentifier_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_set_LocaleId_Public_set_Void_LocaleIdentifier_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
