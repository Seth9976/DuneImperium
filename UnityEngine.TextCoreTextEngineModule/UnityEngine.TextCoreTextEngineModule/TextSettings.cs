using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000038 RID: 56
	[Serializable]
	public class TextSettings : ScriptableObject
	{
		// Token: 0x060005C6 RID: 1478 RVA: 0x0001888C File Offset: 0x00016A8C
		// Note: this type is marked as 'beforefieldinit'.
		static TextSettings()
		{
			Il2CppClassPointerStore<TextSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextSettings>.NativeClassPtr);
			TextSettings.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_Version");
			TextSettings.NativeFieldInfoPtr_m_DefaultFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_DefaultFontAsset");
			TextSettings.NativeFieldInfoPtr_m_DefaultFontAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_DefaultFontAssetPath");
			TextSettings.NativeFieldInfoPtr_m_FallbackFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_FallbackFontAssets");
			TextSettings.NativeFieldInfoPtr_m_MatchMaterialPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_MatchMaterialPreset");
			TextSettings.NativeFieldInfoPtr_m_MissingCharacterUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_MissingCharacterUnicode");
			TextSettings.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_ClearDynamicDataOnBuild");
			TextSettings.NativeFieldInfoPtr_m_DefaultSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_DefaultSpriteAsset");
			TextSettings.NativeFieldInfoPtr_m_DefaultSpriteAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_DefaultSpriteAssetPath");
			TextSettings.NativeFieldInfoPtr_m_FallbackSpriteAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_FallbackSpriteAssets");
			TextSettings.NativeFieldInfoPtr_m_MissingSpriteCharacterUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_MissingSpriteCharacterUnicode");
			TextSettings.NativeFieldInfoPtr_m_DefaultStyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_DefaultStyleSheet");
			TextSettings.NativeFieldInfoPtr_m_StyleSheetsResourcePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_StyleSheetsResourcePath");
			TextSettings.NativeFieldInfoPtr_m_DefaultColorGradientPresetsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_DefaultColorGradientPresetsPath");
			TextSettings.NativeFieldInfoPtr_m_UnicodeLineBreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_UnicodeLineBreakingRules");
			TextSettings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_UseModernHangulLineBreakingRules");
			TextSettings.NativeFieldInfoPtr_m_DisplayWarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_DisplayWarnings");
			TextSettings.NativeFieldInfoPtr_m_FontLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_FontLookup");
			TextSettings.NativeFieldInfoPtr_m_FontReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "m_FontReferences");
			TextSettings.NativeMethodInfoPtr_get_version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663702);
			TextSettings.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663703);
			TextSettings.NativeMethodInfoPtr_get_defaultFontAsset_Public_get_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663704);
			TextSettings.NativeMethodInfoPtr_set_defaultFontAsset_Public_set_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663705);
			TextSettings.NativeMethodInfoPtr_get_defaultFontAssetPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663706);
			TextSettings.NativeMethodInfoPtr_set_defaultFontAssetPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663707);
			TextSettings.NativeMethodInfoPtr_get_fallbackFontAssets_Public_get_List_1_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663708);
			TextSettings.NativeMethodInfoPtr_set_fallbackFontAssets_Public_set_Void_List_1_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663709);
			TextSettings.NativeMethodInfoPtr_get_matchMaterialPreset_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663710);
			TextSettings.NativeMethodInfoPtr_set_matchMaterialPreset_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663711);
			TextSettings.NativeMethodInfoPtr_get_missingCharacterUnicode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663712);
			TextSettings.NativeMethodInfoPtr_set_missingCharacterUnicode_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663713);
			TextSettings.NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663714);
			TextSettings.NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663715);
			TextSettings.NativeMethodInfoPtr_get_defaultSpriteAsset_Public_get_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663716);
			TextSettings.NativeMethodInfoPtr_set_defaultSpriteAsset_Public_set_Void_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663717);
			TextSettings.NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663718);
			TextSettings.NativeMethodInfoPtr_set_defaultSpriteAssetPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663719);
			TextSettings.NativeMethodInfoPtr_get_fallbackSpriteAssets_Public_get_List_1_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663720);
			TextSettings.NativeMethodInfoPtr_set_fallbackSpriteAssets_Public_set_Void_List_1_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663721);
			TextSettings.NativeMethodInfoPtr_get_missingSpriteCharacterUnicode_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663722);
			TextSettings.NativeMethodInfoPtr_set_missingSpriteCharacterUnicode_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663723);
			TextSettings.NativeMethodInfoPtr_get_defaultStyleSheet_Public_get_TextStyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663724);
			TextSettings.NativeMethodInfoPtr_set_defaultStyleSheet_Public_set_Void_TextStyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663725);
			TextSettings.NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663726);
			TextSettings.NativeMethodInfoPtr_set_styleSheetsResourcePath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663727);
			TextSettings.NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663728);
			TextSettings.NativeMethodInfoPtr_set_defaultColorGradientPresetsPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663729);
			TextSettings.NativeMethodInfoPtr_get_lineBreakingRules_Public_get_UnicodeLineBreakingRules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663730);
			TextSettings.NativeMethodInfoPtr_set_lineBreakingRules_Public_set_Void_UnicodeLineBreakingRules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663731);
			TextSettings.NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663732);
			TextSettings.NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663733);
			TextSettings.NativeMethodInfoPtr_get_displayWarnings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663734);
			TextSettings.NativeMethodInfoPtr_set_displayWarnings_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663735);
			TextSettings.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663736);
			TextSettings.NativeMethodInfoPtr_InitializeFontReferenceLookup_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663737);
			TextSettings.NativeMethodInfoPtr_GetCachedFontAssetInternal_Protected_FontAsset_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663738);
			TextSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100663739);
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00018D30 File Offset: 0x00016F30
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00018D68 File Offset: 0x00016F68
		public unsafe string version
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00018DAC File Offset: 0x00016FAC
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00018DEC File Offset: 0x00016FEC
		public unsafe FontAsset defaultFontAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_defaultFontAsset_Public_get_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_defaultFontAsset_Public_set_Void_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00018E30 File Offset: 0x00017030
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00018E68 File Offset: 0x00017068
		public unsafe string defaultFontAssetPath
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_defaultFontAssetPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_defaultFontAssetPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00018EAC File Offset: 0x000170AC
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00018EEC File Offset: 0x000170EC
		public unsafe List<FontAsset> fallbackFontAssets
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_fallbackFontAssets_Public_get_List_1_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_fallbackFontAssets_Public_set_Void_List_1_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00018F30 File Offset: 0x00017130
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00018F6C File Offset: 0x0001716C
		public unsafe bool matchMaterialPreset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_matchMaterialPreset_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_matchMaterialPreset_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00018FAC File Offset: 0x000171AC
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00018FE8 File Offset: 0x000171E8
		public unsafe int missingCharacterUnicode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_missingCharacterUnicode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_missingCharacterUnicode_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00019028 File Offset: 0x00017228
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00019064 File Offset: 0x00017264
		public unsafe bool clearDynamicDataOnBuild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x000190A4 File Offset: 0x000172A4
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x000190E4 File Offset: 0x000172E4
		public unsafe SpriteAsset defaultSpriteAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_defaultSpriteAsset_Public_get_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_defaultSpriteAsset_Public_set_Void_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00019128 File Offset: 0x00017328
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00019160 File Offset: 0x00017360
		public unsafe string defaultSpriteAssetPath
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_defaultSpriteAssetPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x000191A4 File Offset: 0x000173A4
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x000191E4 File Offset: 0x000173E4
		public unsafe List<SpriteAsset> fallbackSpriteAssets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_fallbackSpriteAssets_Public_get_List_1_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SpriteAsset>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_fallbackSpriteAssets_Public_set_Void_List_1_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00019228 File Offset: 0x00017428
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00019264 File Offset: 0x00017464
		public unsafe uint missingSpriteCharacterUnicode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_missingSpriteCharacterUnicode_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 312518, RefRangeEnd = 312534, XrefRangeStart = 312518, XrefRangeEnd = 312534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_missingSpriteCharacterUnicode_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x000192A4 File Offset: 0x000174A4
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x000192E4 File Offset: 0x000174E4
		public unsafe TextStyleSheet defaultStyleSheet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_defaultStyleSheet_Public_get_TextStyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextStyleSheet>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_defaultStyleSheet_Public_set_Void_TextStyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00019328 File Offset: 0x00017528
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00019360 File Offset: 0x00017560
		public unsafe string styleSheetsResourcePath
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_styleSheetsResourcePath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x000193A4 File Offset: 0x000175A4
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x000193DC File Offset: 0x000175DC
		public unsafe string defaultColorGradientPresetsPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_defaultColorGradientPresetsPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00019420 File Offset: 0x00017620
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00019460 File Offset: 0x00017660
		public unsafe UnicodeLineBreakingRules lineBreakingRules
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1105680, RefRangeEnd = 1105685, XrefRangeStart = 1105674, XrefRangeEnd = 1105680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_lineBreakingRules_Public_get_UnicodeLineBreakingRules_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnicodeLineBreakingRules>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_lineBreakingRules_Public_set_Void_UnicodeLineBreakingRules_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000194A4 File Offset: 0x000176A4
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000194E0 File Offset: 0x000176E0
		public unsafe bool useModernHangulLineBreakingRules
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1105685, RefRangeEnd = 1105686, XrefRangeStart = 1105685, XrefRangeEnd = 1105685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00019520 File Offset: 0x00017720
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x0001955C File Offset: 0x0001775C
		public unsafe bool displayWarnings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_get_displayWarnings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_set_displayWarnings_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0001959C File Offset: 0x0001779C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105686, XrefRangeEnd = 1105694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000195D0 File Offset: 0x000177D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105730, RefRangeEnd = 1105731, XrefRangeStart = 1105694, XrefRangeEnd = 1105730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeFontReferenceLookup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_InitializeFontReferenceLookup_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00019604 File Offset: 0x00017804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105781, RefRangeEnd = 1105782, XrefRangeStart = 1105731, XrefRangeEnd = 1105781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontAsset GetCachedFontAssetInternal(Font font)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr_GetCachedFontAssetInternal_Protected_FontAsset_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00019654 File Offset: 0x00017854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105806, RefRangeEnd = 1105807, XrefRangeStart = 1105782, XrefRangeEnd = 1105806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000058FA File Offset: 0x00003AFA
		public TextSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00019690 File Offset: 0x00017890
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00005903 File Offset: 0x00003B03
		public unsafe string m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_Version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_Version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x000196B8 File Offset: 0x000178B8
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00005922 File Offset: 0x00003B22
		public unsafe FontAsset m_DefaultFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x000196E8 File Offset: 0x000178E8
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00005941 File Offset: 0x00003B41
		public unsafe string m_DefaultFontAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultFontAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultFontAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00019710 File Offset: 0x00017910
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00005960 File Offset: 0x00003B60
		public unsafe List<FontAsset> m_FallbackFontAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_FallbackFontAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_FallbackFontAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00019740 File Offset: 0x00017940
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x0000597F File Offset: 0x00003B7F
		public unsafe bool m_MatchMaterialPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_MatchMaterialPreset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_MatchMaterialPreset)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00019768 File Offset: 0x00017968
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x0000599A File Offset: 0x00003B9A
		public unsafe int m_MissingCharacterUnicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_MissingCharacterUnicode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_MissingCharacterUnicode)) = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00019790 File Offset: 0x00017990
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x000059B5 File Offset: 0x00003BB5
		public unsafe bool m_ClearDynamicDataOnBuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild)) = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x000197B8 File Offset: 0x000179B8
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x000059D0 File Offset: 0x00003BD0
		public unsafe SpriteAsset m_DefaultSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x000197E8 File Offset: 0x000179E8
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x000059EF File Offset: 0x00003BEF
		public unsafe string m_DefaultSpriteAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultSpriteAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultSpriteAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00019810 File Offset: 0x00017A10
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x00005A0E File Offset: 0x00003C0E
		public unsafe List<SpriteAsset> m_FallbackSpriteAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_FallbackSpriteAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpriteAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_FallbackSpriteAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00019840 File Offset: 0x00017A40
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00005A2D File Offset: 0x00003C2D
		public unsafe uint m_MissingSpriteCharacterUnicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_MissingSpriteCharacterUnicode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_MissingSpriteCharacterUnicode)) = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00019868 File Offset: 0x00017A68
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00005A48 File Offset: 0x00003C48
		public unsafe TextStyleSheet m_DefaultStyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultStyleSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextStyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultStyleSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00019898 File Offset: 0x00017A98
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00005A67 File Offset: 0x00003C67
		public unsafe string m_StyleSheetsResourcePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_StyleSheetsResourcePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_StyleSheetsResourcePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x000198C0 File Offset: 0x00017AC0
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x00005A86 File Offset: 0x00003C86
		public unsafe string m_DefaultColorGradientPresetsPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultColorGradientPresetsPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DefaultColorGradientPresetsPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x000198E8 File Offset: 0x00017AE8
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00005AA5 File Offset: 0x00003CA5
		public unsafe UnicodeLineBreakingRules m_UnicodeLineBreakingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_UnicodeLineBreakingRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnicodeLineBreakingRules>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_UnicodeLineBreakingRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00019918 File Offset: 0x00017B18
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00005AC4 File Offset: 0x00003CC4
		public unsafe bool m_UseModernHangulLineBreakingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules)) = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00019940 File Offset: 0x00017B40
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00005ADF File Offset: 0x00003CDF
		public unsafe bool m_DisplayWarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DisplayWarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_DisplayWarnings)) = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00019968 File Offset: 0x00017B68
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00005AFA File Offset: 0x00003CFA
		public unsafe Dictionary<int, FontAsset> m_FontLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_FontLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_FontLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00019998 File Offset: 0x00017B98
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00005B19 File Offset: 0x00003D19
		public unsafe List<TextSettings.FontReferenceMap> m_FontReferences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_FontReferences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextSettings.FontReferenceMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.NativeFieldInfoPtr_m_FontReferences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultFontAsset;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultFontAssetPath;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackFontAssets;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr_m_MatchMaterialPreset;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_m_MissingCharacterUnicode;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearDynamicDataOnBuild;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultSpriteAsset;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultSpriteAssetPath;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackSpriteAssets;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeFieldInfoPtr_m_MissingSpriteCharacterUnicode;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultStyleSheet;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleSheetsResourcePath;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultColorGradientPresetsPath;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeFieldInfoPtr_m_UnicodeLineBreakingRules;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayWarnings;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeFieldInfoPtr_m_FontLookup;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeFieldInfoPtr_m_FontReferences;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_get_String_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_set_version_Internal_set_Void_String_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontAsset_Public_get_FontAsset_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultFontAsset_Public_set_Void_FontAsset_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontAssetPath_Public_get_String_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultFontAssetPath_Public_set_Void_String_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackFontAssets_Public_get_List_1_FontAsset_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackFontAssets_Public_set_Void_List_1_FontAsset_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_get_matchMaterialPreset_Public_get_Boolean_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_set_matchMaterialPreset_Public_set_Void_Boolean_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_get_missingCharacterUnicode_Public_get_Int32_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_set_missingCharacterUnicode_Public_set_Void_Int32_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Public_get_Boolean_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Public_set_Void_Boolean_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpriteAsset_Public_get_SpriteAsset_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultSpriteAsset_Public_set_Void_SpriteAsset_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_get_String_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultSpriteAssetPath_Public_set_Void_String_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackSpriteAssets_Public_get_List_1_SpriteAsset_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackSpriteAssets_Public_set_Void_List_1_SpriteAsset_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_get_missingSpriteCharacterUnicode_Public_get_UInt32_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_set_missingSpriteCharacterUnicode_Public_set_Void_UInt32_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultStyleSheet_Public_get_TextStyleSheet_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultStyleSheet_Public_set_Void_TextStyleSheet_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_get_String_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_set_styleSheetsResourcePath_Public_set_Void_String_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_get_String_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultColorGradientPresetsPath_Public_set_Void_String_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_get_lineBreakingRules_Public_get_UnicodeLineBreakingRules_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_set_lineBreakingRules_Public_set_Void_UnicodeLineBreakingRules_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_get_Boolean_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_set_Void_Boolean_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_get_displayWarnings_Public_get_Boolean_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_set_displayWarnings_Public_set_Void_Boolean_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFontReferenceLookup_Protected_Void_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedFontAssetInternal_Protected_FontAsset_Font_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000052 RID: 82
		[Serializable]
		public sealed class FontReferenceMap : ValueType
		{
			// Token: 0x0600076E RID: 1902 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
			// Note: this type is marked as 'beforefieldinit'.
			static FontReferenceMap()
			{
				Il2CppClassPointerStore<TextSettings.FontReferenceMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "FontReferenceMap");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextSettings.FontReferenceMap>.NativeClassPtr);
				TextSettings.FontReferenceMap.NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings.FontReferenceMap>.NativeClassPtr, "font");
				TextSettings.FontReferenceMap.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings.FontReferenceMap>.NativeClassPtr, "fontAsset");
				TextSettings.FontReferenceMap.NativeMethodInfoPtr__ctor_Public_Void_Font_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings.FontReferenceMap>.NativeClassPtr, 100663740);
			}

			// Token: 0x0600076F RID: 1903 RVA: 0x0001CB20 File Offset: 0x0001AD20
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FontReferenceMap(Font font, FontAsset fontAsset)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextSettings.FontReferenceMap>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextSettings.FontReferenceMap.NativeMethodInfoPtr__ctor_Public_Void_Font_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000770 RID: 1904 RVA: 0x00006596 File Offset: 0x00004796
			public FontReferenceMap(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000771 RID: 1905 RVA: 0x0000659F File Offset: 0x0000479F
			public FontReferenceMap()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextSettings.FontReferenceMap>.NativeClassPtr))
			{
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x06000772 RID: 1906 RVA: 0x0001CB84 File Offset: 0x0001AD84
			// (set) Token: 0x06000773 RID: 1907 RVA: 0x000065B1 File Offset: 0x000047B1
			public unsafe Font font
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.FontReferenceMap.NativeFieldInfoPtr_font);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.FontReferenceMap.NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x06000774 RID: 1908 RVA: 0x0001CBB4 File Offset: 0x0001ADB4
			// (set) Token: 0x06000775 RID: 1909 RVA: 0x000065D0 File Offset: 0x000047D0
			public unsafe FontAsset fontAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.FontReferenceMap.NativeFieldInfoPtr_fontAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextSettings.FontReferenceMap.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000602 RID: 1538
			private static readonly IntPtr NativeFieldInfoPtr_font;

			// Token: 0x04000603 RID: 1539
			private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

			// Token: 0x04000604 RID: 1540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Font_FontAsset_0;
		}
	}
}
