using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x0200009E RID: 158
	[Serializable]
	public class PlayerPrefLocaleSelector : Object
	{
		// Token: 0x060007E3 RID: 2019 RVA: 0x00027B28 File Offset: 0x00025D28
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPrefLocaleSelector()
		{
			Il2CppClassPointerStore<PlayerPrefLocaleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "PlayerPrefLocaleSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefLocaleSelector>.NativeClassPtr);
			PlayerPrefLocaleSelector.NativeFieldInfoPtr_m_PlayerPreferenceKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPrefLocaleSelector>.NativeClassPtr, "m_PlayerPreferenceKey");
			PlayerPrefLocaleSelector.NativeMethodInfoPtr_get_PlayerPreferenceKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefLocaleSelector>.NativeClassPtr, 100664706);
			PlayerPrefLocaleSelector.NativeMethodInfoPtr_set_PlayerPreferenceKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefLocaleSelector>.NativeClassPtr, 100664707);
			PlayerPrefLocaleSelector.NativeMethodInfoPtr_PostInitialization_Public_Virtual_Final_New_Void_LocalizationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefLocaleSelector>.NativeClassPtr, 100664708);
			PlayerPrefLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefLocaleSelector>.NativeClassPtr, 100664709);
			PlayerPrefLocaleSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefLocaleSelector>.NativeClassPtr, 100664710);
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00027BD0 File Offset: 0x00025DD0
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00027C08 File Offset: 0x00025E08
		public unsafe string PlayerPreferenceKey
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefLocaleSelector.NativeMethodInfoPtr_get_PlayerPreferenceKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefLocaleSelector.NativeMethodInfoPtr_set_PlayerPreferenceKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00027C4C File Offset: 0x00025E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075908, XrefRangeEnd = 1075914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostInitialization(LocalizationSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefLocaleSelector.NativeMethodInfoPtr_PostInitialization_Public_Virtual_Final_New_Void_LocalizationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00027C90 File Offset: 0x00025E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075914, XrefRangeEnd = 1075921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableLocales);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00027CE0 File Offset: 0x00025EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075921, XrefRangeEnd = 1075926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPrefLocaleSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPrefLocaleSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefLocaleSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00005088 File Offset: 0x00003288
		public PlayerPrefLocaleSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00027D1C File Offset: 0x00025F1C
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00005091 File Offset: 0x00003291
		public unsafe string m_PlayerPreferenceKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPrefLocaleSelector.NativeFieldInfoPtr_m_PlayerPreferenceKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPrefLocaleSelector.NativeFieldInfoPtr_m_PlayerPreferenceKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerPreferenceKey;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerPreferenceKey_Public_get_String_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerPreferenceKey_Public_set_Void_String_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_PostInitialization_Public_Virtual_Final_New_Void_LocalizationSettings_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
