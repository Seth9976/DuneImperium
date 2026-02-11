using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x020000A0 RID: 160
	[Serializable]
	public class SystemLocaleSelector : Object
	{
		// Token: 0x060007F4 RID: 2036 RVA: 0x00027F14 File Offset: 0x00026114
		// Note: this type is marked as 'beforefieldinit'.
		static SystemLocaleSelector()
		{
			Il2CppClassPointerStore<SystemLocaleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "SystemLocaleSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemLocaleSelector>.NativeClassPtr);
			SystemLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemLocaleSelector>.NativeClassPtr, 100664715);
			SystemLocaleSelector.NativeMethodInfoPtr_FindLocaleOrFallback_Private_Static_Locale_LocaleIdentifier_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemLocaleSelector>.NativeClassPtr, 100664716);
			SystemLocaleSelector.NativeMethodInfoPtr_GetSystemCulture_Protected_Virtual_New_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemLocaleSelector>.NativeClassPtr, 100664717);
			SystemLocaleSelector.NativeMethodInfoPtr_GetApplicationSystemLanguage_Protected_Virtual_New_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemLocaleSelector>.NativeClassPtr, 100664718);
			SystemLocaleSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemLocaleSelector>.NativeClassPtr, 100664719);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00027FA8 File Offset: 0x000261A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075948, XrefRangeEnd = 1075956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableLocales);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00027FF8 File Offset: 0x000261F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1075993, RefRangeEnd = 1075995, XrefRangeStart = 1075956, XrefRangeEnd = 1075993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Locale FindLocaleOrFallback(LocaleIdentifier localeIdentifier, ILocalesProvider availableLocales)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(availableLocales);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemLocaleSelector.NativeMethodInfoPtr_FindLocaleOrFallback_Private_Static_Locale_LocaleIdentifier_ILocalesProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00028054 File Offset: 0x00026254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075995, XrefRangeEnd = 1075999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual CultureInfo GetSystemCulture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SystemLocaleSelector.NativeMethodInfoPtr_GetSystemCulture_Protected_Virtual_New_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000280A0 File Offset: 0x000262A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075999, XrefRangeEnd = 1076003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SystemLanguage GetApplicationSystemLanguage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SystemLocaleSelector.NativeMethodInfoPtr_GetApplicationSystemLanguage_Protected_Virtual_New_SystemLanguage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000280E8 File Offset: 0x000262E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemLocaleSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemLocaleSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemLocaleSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000050E7 File Offset: 0x000032E7
		public SystemLocaleSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_FindLocaleOrFallback_Private_Static_Locale_LocaleIdentifier_ILocalesProvider_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemCulture_Protected_Virtual_New_CultureInfo_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_GetApplicationSystemLanguage_Protected_Virtual_New_SystemLanguage_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
