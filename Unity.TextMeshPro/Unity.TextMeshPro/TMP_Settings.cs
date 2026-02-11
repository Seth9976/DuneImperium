using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000050 RID: 80
	[Serializable]
	public class TMP_Settings : ScriptableObject
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x00025EF0 File Offset: 0x000240F0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Settings()
		{
			Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr);
			TMP_Settings.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "s_Instance");
			TMP_Settings.NativeFieldInfoPtr_m_enableWordWrapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableWordWrapping");
			TMP_Settings.NativeFieldInfoPtr_m_enableKerning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableKerning");
			TMP_Settings.NativeFieldInfoPtr_m_enableExtraPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableExtraPadding");
			TMP_Settings.NativeFieldInfoPtr_m_enableTintAllSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableTintAllSprites");
			TMP_Settings.NativeFieldInfoPtr_m_enableParseEscapeCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableParseEscapeCharacters");
			TMP_Settings.NativeFieldInfoPtr_m_EnableRaycastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_EnableRaycastTarget");
			TMP_Settings.NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_GetFontFeaturesAtRuntime");
			TMP_Settings.NativeFieldInfoPtr_m_missingGlyphCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_missingGlyphCharacter");
			TMP_Settings.NativeFieldInfoPtr_m_warningsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_warningsDisabled");
			TMP_Settings.NativeFieldInfoPtr_m_defaultFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontAsset");
			TMP_Settings.NativeFieldInfoPtr_m_defaultFontAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontAssetPath");
			TMP_Settings.NativeFieldInfoPtr_m_defaultFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontSize");
			TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMinRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultAutoSizeMinRatio");
			TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultAutoSizeMaxRatio");
			TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultTextMeshProTextContainerSize");
			TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultTextMeshProUITextContainerSize");
			TMP_Settings.NativeFieldInfoPtr_m_autoSizeTextContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_autoSizeTextContainer");
			TMP_Settings.NativeFieldInfoPtr_m_IsTextObjectScaleStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_IsTextObjectScaleStatic");
			TMP_Settings.NativeFieldInfoPtr_m_fallbackFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_fallbackFontAssets");
			TMP_Settings.NativeFieldInfoPtr_m_matchMaterialPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_matchMaterialPreset");
			TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultSpriteAsset");
			TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultSpriteAssetPath");
			TMP_Settings.NativeFieldInfoPtr_m_enableEmojiSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableEmojiSupport");
			TMP_Settings.NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_MissingCharacterSpriteUnicode");
			TMP_Settings.NativeFieldInfoPtr_m_defaultColorGradientPresetsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultColorGradientPresetsPath");
			TMP_Settings.NativeFieldInfoPtr_m_defaultStyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultStyleSheet");
			TMP_Settings.NativeFieldInfoPtr_m_StyleSheetsResourcePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_StyleSheetsResourcePath");
			TMP_Settings.NativeFieldInfoPtr_m_leadingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_leadingCharacters");
			TMP_Settings.NativeFieldInfoPtr_m_followingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_followingCharacters");
			TMP_Settings.NativeFieldInfoPtr_m_linebreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_linebreakingRules");
			TMP_Settings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_UseModernHangulLineBreakingRules");
			TMP_Settings.NativeMethodInfoPtr_get_version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664269);
			TMP_Settings.NativeMethodInfoPtr_get_enableWordWrapping_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664270);
			TMP_Settings.NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664271);
			TMP_Settings.NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664272);
			TMP_Settings.NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664273);
			TMP_Settings.NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664274);
			TMP_Settings.NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664275);
			TMP_Settings.NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664276);
			TMP_Settings.NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664277);
			TMP_Settings.NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664278);
			TMP_Settings.NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664279);
			TMP_Settings.NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664280);
			TMP_Settings.NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664281);
			TMP_Settings.NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664282);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664283);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664284);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664285);
			TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664286);
			TMP_Settings.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664287);
			TMP_Settings.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664288);
			TMP_Settings.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664289);
			TMP_Settings.NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664290);
			TMP_Settings.NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664291);
			TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664292);
			TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664293);
			TMP_Settings.NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664294);
			TMP_Settings.NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664295);
			TMP_Settings.NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664296);
			TMP_Settings.NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664297);
			TMP_Settings.NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664298);
			TMP_Settings.NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664299);
			TMP_Settings.NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664300);
			TMP_Settings.NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664301);
			TMP_Settings.NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664302);
			TMP_Settings.NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664303);
			TMP_Settings.NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664304);
			TMP_Settings.NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664305);
			TMP_Settings.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664306);
			TMP_Settings.NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664307);
			TMP_Settings.NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664308);
			TMP_Settings.NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664309);
			TMP_Settings.NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664310);
			TMP_Settings.NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664311);
			TMP_Settings.NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664312);
			TMP_Settings.NativeMethodInfoPtr_GetCharacters_Private_Static_Dictionary_2_Int32_Char_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664313);
			TMP_Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664314);
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00026538 File Offset: 0x00024738
		public unsafe static string version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044913, XrefRangeEnd = 1044915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_version_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00026564 File Offset: 0x00024764
		public unsafe static bool enableWordWrapping
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044916, RefRangeEnd = 1044917, XrefRangeStart = 1044915, XrefRangeEnd = 1044916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableWordWrapping_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00026594 File Offset: 0x00024794
		public unsafe static bool enableKerning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044918, RefRangeEnd = 1044919, XrefRangeStart = 1044917, XrefRangeEnd = 1044918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x000265C4 File Offset: 0x000247C4
		public unsafe static bool enableExtraPadding
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044920, RefRangeEnd = 1044921, XrefRangeStart = 1044919, XrefRangeEnd = 1044920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x000265F4 File Offset: 0x000247F4
		public unsafe static bool enableTintAllSprites
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044922, RefRangeEnd = 1044923, XrefRangeStart = 1044921, XrefRangeEnd = 1044922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00026624 File Offset: 0x00024824
		public unsafe static bool enableParseEscapeCharacters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044924, RefRangeEnd = 1044925, XrefRangeStart = 1044923, XrefRangeEnd = 1044924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00026654 File Offset: 0x00024854
		public unsafe static bool enableRaycastTarget
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044926, RefRangeEnd = 1044927, XrefRangeStart = 1044925, XrefRangeEnd = 1044926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00026684 File Offset: 0x00024884
		public unsafe static bool getFontFeaturesAtRuntime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044928, RefRangeEnd = 1044929, XrefRangeStart = 1044927, XrefRangeEnd = 1044928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x000266B4 File Offset: 0x000248B4
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x000266E4 File Offset: 0x000248E4
		public unsafe static int missingGlyphCharacter
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1044930, RefRangeEnd = 1044934, XrefRangeStart = 1044929, XrefRangeEnd = 1044930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044934, XrefRangeEnd = 1044935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x00026718 File Offset: 0x00024918
		public unsafe static bool warningsDisabled
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1044936, RefRangeEnd = 1044942, XrefRangeStart = 1044935, XrefRangeEnd = 1044936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00026748 File Offset: 0x00024948
		public unsafe static TMP_FontAsset defaultFontAsset
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1044943, RefRangeEnd = 1044955, XrefRangeStart = 1044942, XrefRangeEnd = 1044943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0002677C File Offset: 0x0002497C
		public unsafe static string defaultFontAssetPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044955, XrefRangeEnd = 1044956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x000267A8 File Offset: 0x000249A8
		public unsafe static float defaultFontSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044957, RefRangeEnd = 1044958, XrefRangeStart = 1044956, XrefRangeEnd = 1044957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x000267D8 File Offset: 0x000249D8
		public unsafe static float defaultTextAutoSizingMinRatio
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044959, RefRangeEnd = 1044960, XrefRangeStart = 1044958, XrefRangeEnd = 1044959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00026808 File Offset: 0x00024A08
		public unsafe static float defaultTextAutoSizingMaxRatio
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044961, RefRangeEnd = 1044962, XrefRangeStart = 1044960, XrefRangeEnd = 1044961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00026838 File Offset: 0x00024A38
		public unsafe static Vector2 defaultTextMeshProTextContainerSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044963, RefRangeEnd = 1044964, XrefRangeStart = 1044962, XrefRangeEnd = 1044963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00026868 File Offset: 0x00024A68
		public unsafe static Vector2 defaultTextMeshProUITextContainerSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044965, RefRangeEnd = 1044966, XrefRangeStart = 1044964, XrefRangeEnd = 1044965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00026898 File Offset: 0x00024A98
		public unsafe static bool autoSizeTextContainer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044967, RefRangeEnd = 1044968, XrefRangeStart = 1044966, XrefRangeEnd = 1044967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x000268C8 File Offset: 0x00024AC8
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x000268F8 File Offset: 0x00024AF8
		public unsafe static bool isTextObjectScaleStatic
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1044969, RefRangeEnd = 1044970, XrefRangeStart = 1044968, XrefRangeEnd = 1044969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044970, XrefRangeEnd = 1044971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0002692C File Offset: 0x00024B2C
		public unsafe static List<TMP_FontAsset> fallbackFontAssets
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1044972, RefRangeEnd = 1044987, XrefRangeStart = 1044971, XrefRangeEnd = 1044972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr3) : null;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00026960 File Offset: 0x00024B60
		public unsafe static bool matchMaterialPreset
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1044988, RefRangeEnd = 1044992, XrefRangeStart = 1044987, XrefRangeEnd = 1044988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00026990 File Offset: 0x00024B90
		public unsafe static TMP_SpriteAsset defaultSpriteAsset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044992, XrefRangeEnd = 1044993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x000269C4 File Offset: 0x00024BC4
		public unsafe static string defaultSpriteAssetPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044993, XrefRangeEnd = 1044994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x000269F0 File Offset: 0x00024BF0
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00026A20 File Offset: 0x00024C20
		public unsafe static bool enableEmojiSupport
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044994, XrefRangeEnd = 1044995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044995, XrefRangeEnd = 1044996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00026A54 File Offset: 0x00024C54
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00026A84 File Offset: 0x00024C84
		public unsafe static uint missingCharacterSpriteUnicode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044996, XrefRangeEnd = 1044997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044997, XrefRangeEnd = 1044998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00026AB8 File Offset: 0x00024CB8
		public unsafe static string defaultColorGradientPresetsPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044998, XrefRangeEnd = 1044999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x00026AE4 File Offset: 0x00024CE4
		public unsafe static TMP_StyleSheet defaultStyleSheet
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1045000, RefRangeEnd = 1045002, XrefRangeStart = 1044999, XrefRangeEnd = 1045000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr3) : null;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00026B18 File Offset: 0x00024D18
		public unsafe static string styleSheetsResourcePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045002, XrefRangeEnd = 1045003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00026B44 File Offset: 0x00024D44
		public unsafe static TextAsset leadingCharacters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045003, XrefRangeEnd = 1045004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00026B78 File Offset: 0x00024D78
		public unsafe static TextAsset followingCharacters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045004, XrefRangeEnd = 1045005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x00026BAC File Offset: 0x00024DAC
		public unsafe static TMP_Settings.LineBreakingTable linebreakingRules
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1045025, RefRangeEnd = 1045032, XrefRangeStart = 1045005, XrefRangeEnd = 1045025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings.LineBreakingTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00026BE0 File Offset: 0x00024DE0
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x00026C10 File Offset: 0x00024E10
		public unsafe static bool useModernHangulLineBreakingRules
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1045033, RefRangeEnd = 1045036, XrefRangeStart = 1045032, XrefRangeEnd = 1045033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045036, XrefRangeEnd = 1045037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00026C44 File Offset: 0x00024E44
		public unsafe static TMP_Settings instance
		{
			[CallerCount(56)]
			[CachedScanResults(RefRangeStart = 1045052, RefRangeEnd = 1045108, XrefRangeStart = 1045037, XrefRangeEnd = 1045052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00026C78 File Offset: 0x00024E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045108, XrefRangeEnd = 1045126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Settings LoadDefaultSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00026CAC File Offset: 0x00024EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045126, XrefRangeEnd = 1045132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Settings GetSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00026CE0 File Offset: 0x00024EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045132, XrefRangeEnd = 1045138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset GetFontAsset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00026D14 File Offset: 0x00024F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045138, XrefRangeEnd = 1045144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset GetSpriteAsset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00026D48 File Offset: 0x00024F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045144, XrefRangeEnd = 1045150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_StyleSheet GetStyleSheet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr3) : null;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00026D7C File Offset: 0x00024F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045150, XrefRangeEnd = 1045168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadLinebreakingRules()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00026DA4 File Offset: 0x00024FA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1045183, RefRangeEnd = 1045187, XrefRangeStart = 1045168, XrefRangeEnd = 1045183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, char> GetCharacters(TextAsset file)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr_GetCharacters_Private_Static_Dictionary_2_Int32_Char_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, char>>(intPtr3) : null;
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00026DE8 File Offset: 0x00024FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045187, XrefRangeEnd = 1045188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Settings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00005DEC File Offset: 0x00003FEC
		public TMP_Settings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x00026E24 File Offset: 0x00025024
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x00005DF5 File Offset: 0x00003FF5
		public unsafe static TMP_Settings s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Settings.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Settings.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00026E4C File Offset: 0x0002504C
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00005E07 File Offset: 0x00004007
		public unsafe bool m_enableWordWrapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableWordWrapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableWordWrapping)) = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00026E74 File Offset: 0x00025074
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x00005E22 File Offset: 0x00004022
		public unsafe bool m_enableKerning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableKerning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableKerning)) = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00026E9C File Offset: 0x0002509C
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00005E3D File Offset: 0x0000403D
		public unsafe bool m_enableExtraPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableExtraPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableExtraPadding)) = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00026EC4 File Offset: 0x000250C4
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00005E58 File Offset: 0x00004058
		public unsafe bool m_enableTintAllSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableTintAllSprites);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableTintAllSprites)) = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00026EEC File Offset: 0x000250EC
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00005E73 File Offset: 0x00004073
		public unsafe bool m_enableParseEscapeCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableParseEscapeCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableParseEscapeCharacters)) = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00026F14 File Offset: 0x00025114
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00005E8E File Offset: 0x0000408E
		public unsafe bool m_EnableRaycastTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_EnableRaycastTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_EnableRaycastTarget)) = value;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00026F3C File Offset: 0x0002513C
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00005EA9 File Offset: 0x000040A9
		public unsafe bool m_GetFontFeaturesAtRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime)) = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00026F64 File Offset: 0x00025164
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x00005EC4 File Offset: 0x000040C4
		public unsafe int m_missingGlyphCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_missingGlyphCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_missingGlyphCharacter)) = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00026F8C File Offset: 0x0002518C
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x00005EDF File Offset: 0x000040DF
		public unsafe bool m_warningsDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_warningsDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_warningsDisabled)) = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00026FB4 File Offset: 0x000251B4
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x00005EFA File Offset: 0x000040FA
		public unsafe TMP_FontAsset m_defaultFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x00026FE4 File Offset: 0x000251E4
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00005F19 File Offset: 0x00004119
		public unsafe string m_defaultFontAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0002700C File Offset: 0x0002520C
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x00005F38 File Offset: 0x00004138
		public unsafe float m_defaultFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultFontSize)) = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00027034 File Offset: 0x00025234
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x00005F53 File Offset: 0x00004153
		public unsafe float m_defaultAutoSizeMinRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMinRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMinRatio)) = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0002705C File Offset: 0x0002525C
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00005F6E File Offset: 0x0000416E
		public unsafe float m_defaultAutoSizeMaxRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio)) = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00027084 File Offset: 0x00025284
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00005F89 File Offset: 0x00004189
		public unsafe Vector2 m_defaultTextMeshProTextContainerSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize)) = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x000270AC File Offset: 0x000252AC
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00005FA4 File Offset: 0x000041A4
		public unsafe Vector2 m_defaultTextMeshProUITextContainerSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize)) = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x000270D4 File Offset: 0x000252D4
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00005FBF File Offset: 0x000041BF
		public unsafe bool m_autoSizeTextContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_autoSizeTextContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_autoSizeTextContainer)) = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x000270FC File Offset: 0x000252FC
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x00005FDA File Offset: 0x000041DA
		public unsafe bool m_IsTextObjectScaleStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_IsTextObjectScaleStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_IsTextObjectScaleStatic)) = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x00027124 File Offset: 0x00025324
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00005FF5 File Offset: 0x000041F5
		public unsafe List<TMP_FontAsset> m_fallbackFontAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_fallbackFontAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_fallbackFontAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00027154 File Offset: 0x00025354
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00006014 File Offset: 0x00004214
		public unsafe bool m_matchMaterialPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_matchMaterialPreset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_matchMaterialPreset)) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x0002717C File Offset: 0x0002537C
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x0000602F File Offset: 0x0000422F
		public unsafe TMP_SpriteAsset m_defaultSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x000271AC File Offset: 0x000253AC
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x0000604E File Offset: 0x0000424E
		public unsafe string m_defaultSpriteAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultSpriteAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x000271D4 File Offset: 0x000253D4
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x0000606D File Offset: 0x0000426D
		public unsafe bool m_enableEmojiSupport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableEmojiSupport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_enableEmojiSupport)) = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x000271FC File Offset: 0x000253FC
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00006088 File Offset: 0x00004288
		public unsafe uint m_MissingCharacterSpriteUnicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode)) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00027224 File Offset: 0x00025424
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x000060A3 File Offset: 0x000042A3
		public unsafe string m_defaultColorGradientPresetsPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultColorGradientPresetsPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultColorGradientPresetsPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0002724C File Offset: 0x0002544C
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x000060C2 File Offset: 0x000042C2
		public unsafe TMP_StyleSheet m_defaultStyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultStyleSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_defaultStyleSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0002727C File Offset: 0x0002547C
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x000060E1 File Offset: 0x000042E1
		public unsafe string m_StyleSheetsResourcePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_StyleSheetsResourcePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_StyleSheetsResourcePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x000272A4 File Offset: 0x000254A4
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00006100 File Offset: 0x00004300
		public unsafe TextAsset m_leadingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_leadingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_leadingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x000272D4 File Offset: 0x000254D4
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x0000611F File Offset: 0x0000431F
		public unsafe TextAsset m_followingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_followingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_followingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00027304 File Offset: 0x00025504
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x0000613E File Offset: 0x0000433E
		public unsafe TMP_Settings.LineBreakingTable m_linebreakingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_linebreakingRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Settings.LineBreakingTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_linebreakingRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00027334 File Offset: 0x00025534
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x0000615D File Offset: 0x0000435D
		public unsafe bool m_UseModernHangulLineBreakingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules)) = value;
			}
		}

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_m_enableWordWrapping;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_m_enableKerning;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_m_enableExtraPadding;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_m_enableTintAllSprites;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_m_enableParseEscapeCharacters;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableRaycastTarget;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr_m_missingGlyphCharacter;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_m_warningsDisabled;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultFontAsset;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultFontAssetPath;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultFontSize;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultAutoSizeMinRatio;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_m_autoSizeTextContainer;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextObjectScaleStatic;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackFontAssets;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_m_matchMaterialPreset;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultSpriteAsset;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultSpriteAssetPath;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_m_enableEmojiSupport;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultColorGradientPresetsPath;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultStyleSheet;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleSheetsResourcePath;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr_m_leadingCharacters;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr_m_followingCharacters;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr_m_linebreakingRules;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_Static_get_String_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_get_enableWordWrapping_Public_Static_get_Boolean_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacters_Private_Static_Dictionary_2_Int32_Char_TextAsset_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A6 RID: 166
		public class LineBreakingTable : global::Il2CppSystem.Object
		{
			// Token: 0x06000FC7 RID: 4039 RVA: 0x0003E688 File Offset: 0x0003C888
			// Note: this type is marked as 'beforefieldinit'.
			static LineBreakingTable()
			{
				Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "LineBreakingTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr);
				TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_leadingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr, "leadingCharacters");
				TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_followingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr, "followingCharacters");
				TMP_Settings.LineBreakingTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr, 100664315);
			}

			// Token: 0x06000FC8 RID: 4040 RVA: 0x0003E6F0 File Offset: 0x0003C8F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LineBreakingTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Settings.LineBreakingTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Settings.LineBreakingTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FC9 RID: 4041 RVA: 0x000097F8 File Offset: 0x000079F8
			public LineBreakingTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B8 RID: 1464
			// (get) Token: 0x06000FCA RID: 4042 RVA: 0x0003E72C File Offset: 0x0003C92C
			// (set) Token: 0x06000FCB RID: 4043 RVA: 0x00009801 File Offset: 0x00007A01
			public unsafe Dictionary<int, char> leadingCharacters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_leadingCharacters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_leadingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B9 RID: 1465
			// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0003E75C File Offset: 0x0003C95C
			// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00009820 File Offset: 0x00007A20
			public unsafe Dictionary<int, char> followingCharacters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_followingCharacters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Settings.LineBreakingTable.NativeFieldInfoPtr_followingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C60 RID: 3168
			private static readonly IntPtr NativeFieldInfoPtr_leadingCharacters;

			// Token: 0x04000C61 RID: 3169
			private static readonly IntPtr NativeFieldInfoPtr_followingCharacters;

			// Token: 0x04000C62 RID: 3170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
