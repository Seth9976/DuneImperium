using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

namespace localization
{
	// Token: 0x02000009 RID: 9
	public class PreLocalizationTMPLocalizer : MonoBehaviour
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002CF4 File Offset: 0x00000EF4
		// Note: this type is marked as 'beforefieldinit'.
		static PreLocalizationTMPLocalizer()
		{
			Il2CppClassPointerStore<PreLocalizationTMPLocalizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-localization.dll", "localization", "PreLocalizationTMPLocalizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLocalizationTMPLocalizer>.NativeClassPtr);
			PreLocalizationTMPLocalizer.NativeFieldInfoPtr__text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreLocalizationTMPLocalizer>.NativeClassPtr, "_text");
			PreLocalizationTMPLocalizer.NativeFieldInfoPtr_translations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreLocalizationTMPLocalizer>.NativeClassPtr, "translations");
			PreLocalizationTMPLocalizer.NativeMethodInfoPtr_get_text_Private_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreLocalizationTMPLocalizer>.NativeClassPtr, 100663308);
			PreLocalizationTMPLocalizer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreLocalizationTMPLocalizer>.NativeClassPtr, 100663309);
			PreLocalizationTMPLocalizer.NativeMethodInfoPtr_getLocalizedValue_Private_Static_String_List_1_LocPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreLocalizationTMPLocalizer>.NativeClassPtr, 100663310);
			PreLocalizationTMPLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreLocalizationTMPLocalizer>.NativeClassPtr, 100663311);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002D9C File Offset: 0x00000F9C
		public unsafe TMP_Text text
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266120, XrefRangeEnd = 1266128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreLocalizationTMPLocalizer.NativeMethodInfoPtr_get_text_Private_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002DDC File Offset: 0x00000FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266128, XrefRangeEnd = 1266138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreLocalizationTMPLocalizer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002E10 File Offset: 0x00001010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1266159, RefRangeEnd = 1266160, XrefRangeStart = 1266138, XrefRangeEnd = 1266159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getLocalizedValue(List<PreLocalizationTMPLocalizer.LocPair> locPairs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locPairs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreLocalizationTMPLocalizer.NativeMethodInfoPtr_getLocalizedValue_Private_Static_String_List_1_LocPair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002E4C File Offset: 0x0000104C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266160, XrefRangeEnd = 1266168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreLocalizationTMPLocalizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreLocalizationTMPLocalizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreLocalizationTMPLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002195 File Offset: 0x00000395
		public PreLocalizationTMPLocalizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002E88 File Offset: 0x00001088
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000219E File Offset: 0x0000039E
		public unsafe TMP_Text _text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreLocalizationTMPLocalizer.NativeFieldInfoPtr__text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreLocalizationTMPLocalizer.NativeFieldInfoPtr__text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002EB8 File Offset: 0x000010B8
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000021BD File Offset: 0x000003BD
		public unsafe List<PreLocalizationTMPLocalizer.LocPair> translations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreLocalizationTMPLocalizer.NativeFieldInfoPtr_translations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PreLocalizationTMPLocalizer.LocPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreLocalizationTMPLocalizer.NativeFieldInfoPtr_translations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr__text;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_translations;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Private_get_TMP_Text_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_getLocalizedValue_Private_Static_String_List_1_LocPair_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200000F RID: 15
		[Serializable]
		public sealed class LocPair : ValueType
		{
			// Token: 0x06000073 RID: 115 RVA: 0x00003A8C File Offset: 0x00001C8C
			// Note: this type is marked as 'beforefieldinit'.
			static LocPair()
			{
				Il2CppClassPointerStore<PreLocalizationTMPLocalizer.LocPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLocalizationTMPLocalizer>.NativeClassPtr, "LocPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLocalizationTMPLocalizer.LocPair>.NativeClassPtr);
				PreLocalizationTMPLocalizer.LocPair.NativeFieldInfoPtr_Locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreLocalizationTMPLocalizer.LocPair>.NativeClassPtr, "Locale");
				PreLocalizationTMPLocalizer.LocPair.NativeFieldInfoPtr_LocaleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreLocalizationTMPLocalizer.LocPair>.NativeClassPtr, "LocaleText");
			}

			// Token: 0x06000074 RID: 116 RVA: 0x00002394 File Offset: 0x00000594
			public LocPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000075 RID: 117 RVA: 0x0000239D File Offset: 0x0000059D
			public LocPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreLocalizationTMPLocalizer.LocPair>.NativeClassPtr))
			{
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000076 RID: 118 RVA: 0x00003AE0 File Offset: 0x00001CE0
			// (set) Token: 0x06000077 RID: 119 RVA: 0x000023AF File Offset: 0x000005AF
			public unsafe TextLocalization.Locale Locale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreLocalizationTMPLocalizer.LocPair.NativeFieldInfoPtr_Locale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreLocalizationTMPLocalizer.LocPair.NativeFieldInfoPtr_Locale)) = value;
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000078 RID: 120 RVA: 0x00003B08 File Offset: 0x00001D08
			// (set) Token: 0x06000079 RID: 121 RVA: 0x000023CA File Offset: 0x000005CA
			public unsafe string LocaleText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreLocalizationTMPLocalizer.LocPair.NativeFieldInfoPtr_LocaleText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreLocalizationTMPLocalizer.LocPair.NativeFieldInfoPtr_LocaleText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400003F RID: 63
			private static readonly IntPtr NativeFieldInfoPtr_Locale;

			// Token: 0x04000040 RID: 64
			private static readonly IntPtr NativeFieldInfoPtr_LocaleText;
		}
	}
}
