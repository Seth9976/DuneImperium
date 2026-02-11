using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using UnityEngine;

namespace localization
{
	// Token: 0x0200000A RID: 10
	public static class TextLocalization : global::Il2CppSystem.Object
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002EE8 File Offset: 0x000010E8
		// Note: this type is marked as 'beforefieldinit'.
		static TextLocalization()
		{
			Il2CppClassPointerStore<TextLocalization>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-localization.dll", "localization", "TextLocalization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr);
			TextLocalization.NativeFieldInfoPtr_localeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, "localeNames");
			TextLocalization.NativeFieldInfoPtr_EnglishCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, "EnglishCulture");
			TextLocalization.NativeFieldInfoPtr__currentCultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, "_currentCultureInfo");
			TextLocalization.NativeFieldInfoPtr__currentCompareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, "_currentCompareInfo");
			TextLocalization.NativeFieldInfoPtr_CurrentLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, "CurrentLocale");
			TextLocalization.NativeMethodInfoPtr_GetNameForLocale_Public_Static_String_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663312);
			TextLocalization.NativeMethodInfoPtr_get_CurrentCultureInfo_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663313);
			TextLocalization.NativeMethodInfoPtr_get_CurrentCompareInfo_Public_Static_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663314);
			TextLocalization.NativeMethodInfoPtr_get_SystemLocale_Public_Static_get_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663315);
			TextLocalization.NativeMethodInfoPtr_SystemLanguageToLocale_Public_Static_Locale_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663316);
			TextLocalization.NativeMethodInfoPtr_CurrentLocaleIsRTL_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663317);
			TextLocalization.NativeMethodInfoPtr_ToIETF_Public_Static_String_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663318);
			TextLocalization.NativeMethodInfoPtr_GetIetfLanguageTag_Public_Static_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663319);
			TextLocalization.NativeMethodInfoPtr_ToCultureInfo_Public_Static_CultureInfo_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663320);
			TextLocalization.NativeMethodInfoPtr_LocEnumerator_Public_Static_IEnumerable_1_KeyValuePair_2_String_String_List_1_Localization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663321);
			TextLocalization.NativeMethodInfoPtr_LocEnumerator_Public_Static_IEnumerable_1_KeyValuePair_2_String_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663322);
			TextLocalization.NativeMethodInfoPtr_LocEnumerator_Public_Static_IEnumerable_1_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, 100663323);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000306C File Offset: 0x0000126C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266321, XrefRangeEnd = 1266340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameForLocale(TextLocalization.Locale locale)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_GetNameForLocale_Public_Static_String_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000030A4 File Offset: 0x000012A4
		public unsafe static CultureInfo CurrentCultureInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1266378, RefRangeEnd = 1266379, XrefRangeStart = 1266340, XrefRangeEnd = 1266378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_get_CurrentCultureInfo_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000030D8 File Offset: 0x000012D8
		public unsafe static CompareInfo CurrentCompareInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266379, XrefRangeEnd = 1266391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_get_CurrentCompareInfo_Public_Static_get_CompareInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000310C File Offset: 0x0000130C
		public unsafe static TextLocalization.Locale SystemLocale
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1266399, RefRangeEnd = 1266404, XrefRangeStart = 1266391, XrefRangeEnd = 1266399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_get_SystemLocale_Public_Static_get_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000313C File Offset: 0x0000133C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1266435, RefRangeEnd = 1266436, XrefRangeStart = 1266404, XrefRangeEnd = 1266435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextLocalization.Locale SystemLanguageToLocale(SystemLanguage lang)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lang;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_SystemLanguageToLocale_Public_Static_Locale_SystemLanguage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000317C File Offset: 0x0000137C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266436, XrefRangeEnd = 1266443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CurrentLocaleIsRTL()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_CurrentLocaleIsRTL_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000031AC File Offset: 0x000013AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1266608, RefRangeEnd = 1266611, XrefRangeStart = 1266443, XrefRangeEnd = 1266608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToIETF(this TextLocalization.Locale locale)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_ToIETF_Public_Static_String_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000031E4 File Offset: 0x000013E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266611, XrefRangeEnd = 1266618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetIetfLanguageTag(this CultureInfo info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_GetIetfLanguageTag_Public_Static_String_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003220 File Offset: 0x00001420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266618, XrefRangeEnd = 1266626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo ToCultureInfo(this TextLocalization.Locale locale)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_ToCultureInfo_Public_Static_CultureInfo_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003260 File Offset: 0x00001460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266626, XrefRangeEnd = 1266632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<string, string>> LocEnumerator(List<Localization> locValues)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locValues);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_LocEnumerator_Public_Static_IEnumerable_1_KeyValuePair_2_String_String_List_1_Localization_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, string>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000032A4 File Offset: 0x000014A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266632, XrefRangeEnd = 1266638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<string, string>> LocEnumerator(Dictionary<string, string> locValues)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locValues);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_LocEnumerator_Public_Static_IEnumerable_1_KeyValuePair_2_String_String_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, string>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000032E8 File Offset: 0x000014E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266638, XrefRangeEnd = 1266644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> LocEnumerator(IList<string> locValues)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locValues);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization.NativeMethodInfoPtr_LocEnumerator_Public_Static_IEnumerable_1_String_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021DC File Offset: 0x000003DC
		public TextLocalization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000332C File Offset: 0x0000152C
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000021E5 File Offset: 0x000003E5
		public unsafe static Dictionary<TextLocalization.Locale, string> localeNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextLocalization.NativeFieldInfoPtr_localeNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TextLocalization.Locale, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextLocalization.NativeFieldInfoPtr_localeNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003354 File Offset: 0x00001554
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000021F7 File Offset: 0x000003F7
		public unsafe static CultureInfo EnglishCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextLocalization.NativeFieldInfoPtr_EnglishCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextLocalization.NativeFieldInfoPtr_EnglishCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002209 File Offset: 0x00000409
		public unsafe static CultureInfo _currentCultureInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextLocalization.NativeFieldInfoPtr__currentCultureInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextLocalization.NativeFieldInfoPtr__currentCultureInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000033A4 File Offset: 0x000015A4
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000221B File Offset: 0x0000041B
		public unsafe static CompareInfo _currentCompareInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextLocalization.NativeFieldInfoPtr__currentCompareInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextLocalization.NativeFieldInfoPtr__currentCompareInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000033CC File Offset: 0x000015CC
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0000222D File Offset: 0x0000042D
		public unsafe static TextLocalization.Locale CurrentLocale
		{
			get
			{
				TextLocalization.Locale locale;
				IL2CPP.il2cpp_field_static_get_value(TextLocalization.NativeFieldInfoPtr_CurrentLocale, (void*)(&locale));
				return locale;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextLocalization.NativeFieldInfoPtr_CurrentLocale, (void*)(&value));
			}
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_localeNames;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_EnglishCulture;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr__currentCultureInfo;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr__currentCompareInfo;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_CurrentLocale;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_GetNameForLocale_Public_Static_String_Locale_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCultureInfo_Public_Static_get_CultureInfo_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCompareInfo_Public_Static_get_CompareInfo_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemLocale_Public_Static_get_Locale_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_SystemLanguageToLocale_Public_Static_Locale_SystemLanguage_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_CurrentLocaleIsRTL_Public_Static_Boolean_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_ToIETF_Public_Static_String_Locale_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_GetIetfLanguageTag_Public_Static_String_CultureInfo_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_ToCultureInfo_Public_Static_CultureInfo_Locale_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_LocEnumerator_Public_Static_IEnumerable_1_KeyValuePair_2_String_String_List_1_Localization_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_LocEnumerator_Public_Static_IEnumerable_1_KeyValuePair_2_String_String_Dictionary_2_String_String_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_LocEnumerator_Public_Static_IEnumerable_1_String_IList_1_String_0;

		// Token: 0x02000010 RID: 16
		public enum Locale
		{
			// Token: 0x04000042 RID: 66
			HAS_REGIONAL_OVERRIDE = -2,
			// Token: 0x04000043 RID: 67
			xx_XX,
			// Token: 0x04000044 RID: 68
			en_US,
			// Token: 0x04000045 RID: 69
			en_PH,
			// Token: 0x04000046 RID: 70
			en_SG,
			// Token: 0x04000047 RID: 71
			pt_BR,
			// Token: 0x04000048 RID: 72
			de_DE,
			// Token: 0x04000049 RID: 73
			da_DK,
			// Token: 0x0400004A RID: 74
			el_GR,
			// Token: 0x0400004B RID: 75
			es_ES,
			// Token: 0x0400004C RID: 76
			es_MX,
			// Token: 0x0400004D RID: 77
			fr_FR,
			// Token: 0x0400004E RID: 78
			fi_FI,
			// Token: 0x0400004F RID: 79
			it_IT,
			// Token: 0x04000050 RID: 80
			ko_KR,
			// Token: 0x04000051 RID: 81
			nl_NL,
			// Token: 0x04000052 RID: 82
			no_NO,
			// Token: 0x04000053 RID: 83
			pl_PL,
			// Token: 0x04000054 RID: 84
			ro_RO,
			// Token: 0x04000055 RID: 85
			ru_RU,
			// Token: 0x04000056 RID: 86
			sv_SE,
			// Token: 0x04000057 RID: 87
			th_TH,
			// Token: 0x04000058 RID: 88
			tr_TR,
			// Token: 0x04000059 RID: 89
			vi_VN,
			// Token: 0x0400005A RID: 90
			zh_CN,
			// Token: 0x0400005B RID: 91
			zh_MY,
			// Token: 0x0400005C RID: 92
			zh_TW,
			// Token: 0x0400005D RID: 93
			ja_JP,
			// Token: 0x0400005E RID: 94
			cs_CZ,
			// Token: 0x0400005F RID: 95
			ar_AR,
			// Token: 0x04000060 RID: 96
			he_IL,
			// Token: 0x04000061 RID: 97
			hr_HR,
			// Token: 0x04000062 RID: 98
			hi_IN,
			// Token: 0x04000063 RID: 99
			hu_HU,
			// Token: 0x04000064 RID: 100
			in_ID,
			// Token: 0x04000065 RID: 101
			ms_MY,
			// Token: 0x04000066 RID: 102
			pt_PT,
			// Token: 0x04000067 RID: 103
			uk_UA
		}

		// Token: 0x02000011 RID: 17
		[ObfuscatedName("localization.TextLocalization+<LocEnumerator>d__18")]
		public sealed class _LocEnumerator_d__18 : global::Il2CppSystem.Object
		{
			// Token: 0x0600007A RID: 122 RVA: 0x00003B30 File Offset: 0x00001D30
			// Note: this type is marked as 'beforefieldinit'.
			static _LocEnumerator_d__18()
			{
				Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, "<LocEnumerator>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr);
				TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, "<>1__state");
				TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, "<>2__current");
				TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, "<>l__initialThreadId");
				TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr_locValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, "locValues");
				TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___3__locValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, "<>3__locValues");
				TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, "<>7__wrap1");
				TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, 100663325);
				TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, 100663326);
				TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, 100663327);
				TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, 100663328);
				TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, 100663329);
				TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, 100663330);
				TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, 100663331);
				TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, 100663332);
				TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr, 100663333);
			}

			// Token: 0x0600007B RID: 123 RVA: 0x00003C88 File Offset: 0x00001E88
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LocEnumerator_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600007C RID: 124 RVA: 0x00003CD0 File Offset: 0x00001ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266168, XrefRangeEnd = 1266173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600007D RID: 125 RVA: 0x00003D04 File Offset: 0x00001F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266173, XrefRangeEnd = 1266201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600007E RID: 126 RVA: 0x00003D40 File Offset: 0x00001F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266201, XrefRangeEnd = 1266204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600007F RID: 127 RVA: 0x00003D74 File Offset: 0x00001F74
			public unsafe KeyValuePair<string, string> prop_KeyValuePair_2_String_String_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, string>(intPtr);
				}
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00003DAC File Offset: 0x00001FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266204, XrefRangeEnd = 1266209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000081 RID: 129 RVA: 0x00003DE0 File Offset: 0x00001FE0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266209, XrefRangeEnd = 1266212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000082 RID: 130 RVA: 0x00003E20 File Offset: 0x00002020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266212, XrefRangeEnd = 1266220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<string, string>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, string>>>(intPtr3) : null;
			}

			// Token: 0x06000083 RID: 131 RVA: 0x00003E60 File Offset: 0x00002060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000084 RID: 132 RVA: 0x000023E9 File Offset: 0x000005E9
			public _LocEnumerator_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000085 RID: 133 RVA: 0x00003EA0 File Offset: 0x000020A0
			// (set) Token: 0x06000086 RID: 134 RVA: 0x000023F2 File Offset: 0x000005F2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000087 RID: 135 RVA: 0x00003EC8 File Offset: 0x000020C8
			// (set) Token: 0x06000088 RID: 136 RVA: 0x0000240D File Offset: 0x0000060D
			public KeyValuePair<string, string> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000089 RID: 137 RVA: 0x00003EF8 File Offset: 0x000020F8
			// (set) Token: 0x0600008A RID: 138 RVA: 0x0000243B File Offset: 0x0000063B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600008B RID: 139 RVA: 0x00003F20 File Offset: 0x00002120
			// (set) Token: 0x0600008C RID: 140 RVA: 0x00002456 File Offset: 0x00000656
			public unsafe List<Localization> locValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr_locValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Localization>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr_locValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600008D RID: 141 RVA: 0x00003F50 File Offset: 0x00002150
			// (set) Token: 0x0600008E RID: 142 RVA: 0x00002475 File Offset: 0x00000675
			public unsafe List<Localization> __3__locValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___3__locValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Localization>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___3__locValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600008F RID: 143 RVA: 0x00003F80 File Offset: 0x00002180
			// (set) Token: 0x06000090 RID: 144 RVA: 0x00002494 File Offset: 0x00000694
			public List<Localization>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___7__wrap1);
					return new List<Localization>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Localization>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__18.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Localization>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000068 RID: 104
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000069 RID: 105
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400006A RID: 106
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400006B RID: 107
			private static readonly IntPtr NativeFieldInfoPtr_locValues;

			// Token: 0x0400006C RID: 108
			private static readonly IntPtr NativeFieldInfoPtr___3__locValues;

			// Token: 0x0400006D RID: 109
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400006E RID: 110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400006F RID: 111
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000070 RID: 112
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000071 RID: 113
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000072 RID: 114
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0;

			// Token: 0x04000073 RID: 115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000074 RID: 116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000075 RID: 117
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0;

			// Token: 0x04000076 RID: 118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000012 RID: 18
		[ObfuscatedName("localization.TextLocalization+<LocEnumerator>d__19")]
		public sealed class _LocEnumerator_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x06000091 RID: 145 RVA: 0x00003FB0 File Offset: 0x000021B0
			// Note: this type is marked as 'beforefieldinit'.
			static _LocEnumerator_d__19()
			{
				Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, "<LocEnumerator>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr);
				TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, "<>1__state");
				TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, "<>2__current");
				TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, "<>l__initialThreadId");
				TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr_locValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, "locValues");
				TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___3__locValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, "<>3__locValues");
				TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, "<>7__wrap1");
				TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, 100663334);
				TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, 100663335);
				TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, 100663336);
				TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, 100663337);
				TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, 100663338);
				TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, 100663339);
				TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, 100663340);
				TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, 100663341);
				TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr, 100663342);
			}

			// Token: 0x06000092 RID: 146 RVA: 0x00004108 File Offset: 0x00002308
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LocEnumerator_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00004150 File Offset: 0x00002350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266220, XrefRangeEnd = 1266225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00004184 File Offset: 0x00002384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266225, XrefRangeEnd = 1266255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000095 RID: 149 RVA: 0x000041C0 File Offset: 0x000023C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266255, XrefRangeEnd = 1266258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x06000096 RID: 150 RVA: 0x000041F4 File Offset: 0x000023F4
			public unsafe KeyValuePair<string, string> prop_KeyValuePair_2_String_String_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, string>(intPtr);
				}
			}

			// Token: 0x06000097 RID: 151 RVA: 0x0000422C File Offset: 0x0000242C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266258, XrefRangeEnd = 1266263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000098 RID: 152 RVA: 0x00004260 File Offset: 0x00002460
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266263, XrefRangeEnd = 1266266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000099 RID: 153 RVA: 0x000042A0 File Offset: 0x000024A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266266, XrefRangeEnd = 1266274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<string, string>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, string>>>(intPtr3) : null;
			}

			// Token: 0x0600009A RID: 154 RVA: 0x000042E0 File Offset: 0x000024E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600009B RID: 155 RVA: 0x000024C2 File Offset: 0x000006C2
			public _LocEnumerator_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600009C RID: 156 RVA: 0x00004320 File Offset: 0x00002520
			// (set) Token: 0x0600009D RID: 157 RVA: 0x000024CB File Offset: 0x000006CB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x0600009E RID: 158 RVA: 0x00004348 File Offset: 0x00002548
			// (set) Token: 0x0600009F RID: 159 RVA: 0x000024E6 File Offset: 0x000006E6
			public KeyValuePair<string, string> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004378 File Offset: 0x00002578
			// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002514 File Offset: 0x00000714
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x000043A0 File Offset: 0x000025A0
			// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000252F File Offset: 0x0000072F
			public unsafe Dictionary<string, string> locValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr_locValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr_locValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x000043D0 File Offset: 0x000025D0
			// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000254E File Offset: 0x0000074E
			public unsafe Dictionary<string, string> __3__locValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___3__locValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___3__locValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x00004400 File Offset: 0x00002600
			// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000256D File Offset: 0x0000076D
			public Dictionary<string, string>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<string, string>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, string>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__19.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, string>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000077 RID: 119
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000078 RID: 120
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000079 RID: 121
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400007A RID: 122
			private static readonly IntPtr NativeFieldInfoPtr_locValues;

			// Token: 0x0400007B RID: 123
			private static readonly IntPtr NativeFieldInfoPtr___3__locValues;

			// Token: 0x0400007C RID: 124
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400007D RID: 125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400007E RID: 126
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400007F RID: 127
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000080 RID: 128
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000081 RID: 129
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0;

			// Token: 0x04000082 RID: 130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000083 RID: 131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000084 RID: 132
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0;

			// Token: 0x04000085 RID: 133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000013 RID: 19
		[ObfuscatedName("localization.TextLocalization+<LocEnumerator>d__20")]
		public sealed class _LocEnumerator_d__20 : global::Il2CppSystem.Object
		{
			// Token: 0x060000A8 RID: 168 RVA: 0x00004430 File Offset: 0x00002630
			// Note: this type is marked as 'beforefieldinit'.
			static _LocEnumerator_d__20()
			{
				Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextLocalization>.NativeClassPtr, "<LocEnumerator>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr);
				TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, "<>1__state");
				TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, "<>2__current");
				TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, "<>l__initialThreadId");
				TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr_locValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, "locValues");
				TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___3__locValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, "<>3__locValues");
				TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, "<>7__wrap1");
				TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, 100663343);
				TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, 100663344);
				TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, 100663345);
				TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, 100663346);
				TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, 100663347);
				TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, 100663348);
				TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, 100663349);
				TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, 100663350);
				TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr, 100663351);
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00004588 File Offset: 0x00002788
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LocEnumerator_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextLocalization._LocEnumerator_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000AA RID: 170 RVA: 0x000045D0 File Offset: 0x000027D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266274, XrefRangeEnd = 1266277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00004604 File Offset: 0x00002804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266277, XrefRangeEnd = 1266302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000AC RID: 172 RVA: 0x00004640 File Offset: 0x00002840
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1266305, RefRangeEnd = 1266308, XrefRangeStart = 1266302, XrefRangeEnd = 1266305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060000AD RID: 173 RVA: 0x00004674 File Offset: 0x00002874
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060000AE RID: 174 RVA: 0x000046AC File Offset: 0x000028AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266308, XrefRangeEnd = 1266313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060000AF RID: 175 RVA: 0x000046E0 File Offset: 0x000028E0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x00004720 File Offset: 0x00002920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266313, XrefRangeEnd = 1266321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x00004760 File Offset: 0x00002960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextLocalization._LocEnumerator_d__20.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x0000259B File Offset: 0x0000079B
			public _LocEnumerator_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060000B3 RID: 179 RVA: 0x000047A0 File Offset: 0x000029A0
			// (set) Token: 0x060000B4 RID: 180 RVA: 0x000025A4 File Offset: 0x000007A4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x000047C8 File Offset: 0x000029C8
			// (set) Token: 0x060000B6 RID: 182 RVA: 0x000025BF File Offset: 0x000007BF
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x000047F0 File Offset: 0x000029F0
			// (set) Token: 0x060000B8 RID: 184 RVA: 0x000025DE File Offset: 0x000007DE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x00004818 File Offset: 0x00002A18
			// (set) Token: 0x060000BA RID: 186 RVA: 0x000025F9 File Offset: 0x000007F9
			public unsafe IList<string> locValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr_locValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr_locValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060000BB RID: 187 RVA: 0x00004848 File Offset: 0x00002A48
			// (set) Token: 0x060000BC RID: 188 RVA: 0x00002618 File Offset: 0x00000818
			public unsafe IList<string> __3__locValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___3__locValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___3__locValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060000BD RID: 189 RVA: 0x00004878 File Offset: 0x00002A78
			// (set) Token: 0x060000BE RID: 190 RVA: 0x00002637 File Offset: 0x00000837
			public unsafe IEnumerator<string> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextLocalization._LocEnumerator_d__20.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000086 RID: 134
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000087 RID: 135
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000088 RID: 136
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000089 RID: 137
			private static readonly IntPtr NativeFieldInfoPtr_locValues;

			// Token: 0x0400008A RID: 138
			private static readonly IntPtr NativeFieldInfoPtr___3__locValues;

			// Token: 0x0400008B RID: 139
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400008C RID: 140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400008D RID: 141
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400008E RID: 142
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400008F RID: 143
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000090 RID: 144
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x04000091 RID: 145
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000092 RID: 146
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000093 RID: 147
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x04000094 RID: 148
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
