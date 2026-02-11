using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Profiling;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class FontAsset : TextAsset
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00006E1C File Offset: 0x0000501C
		// Note: this type is marked as 'beforefieldinit'.
		static FontAsset()
		{
			Il2CppClassPointerStore<FontAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAsset>.NativeClassPtr);
			FontAsset.NativeFieldInfoPtr_m_SourceFontFileGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_SourceFontFileGUID");
			FontAsset.NativeFieldInfoPtr_m_fontAssetCreationEditorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_fontAssetCreationEditorSettings");
			FontAsset.NativeFieldInfoPtr_m_SourceFontFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_SourceFontFile");
			FontAsset.NativeFieldInfoPtr_m_SourceFontFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_SourceFontFilePath");
			FontAsset.NativeFieldInfoPtr_m_AtlasPopulationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasPopulationMode");
			FontAsset.NativeFieldInfoPtr_InternalDynamicOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "InternalDynamicOS");
			FontAsset.NativeFieldInfoPtr_m_FaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FaceInfo");
			FontAsset.NativeFieldInfoPtr_m_FamilyNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FamilyNameHashCode");
			FontAsset.NativeFieldInfoPtr_m_StyleNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_StyleNameHashCode");
			FontAsset.NativeFieldInfoPtr_m_GlyphTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphTable");
			FontAsset.NativeFieldInfoPtr_m_GlyphLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphLookupDictionary");
			FontAsset.NativeFieldInfoPtr_m_CharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_CharacterTable");
			FontAsset.NativeFieldInfoPtr_m_CharacterLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_CharacterLookupDictionary");
			FontAsset.NativeFieldInfoPtr_m_AtlasTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasTexture");
			FontAsset.NativeFieldInfoPtr_m_AtlasTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasTextures");
			FontAsset.NativeFieldInfoPtr_m_AtlasTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasTextureIndex");
			FontAsset.NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_IsMultiAtlasTexturesEnabled");
			FontAsset.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_ClearDynamicDataOnBuild");
			FontAsset.NativeFieldInfoPtr_m_AtlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasWidth");
			FontAsset.NativeFieldInfoPtr_m_AtlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasHeight");
			FontAsset.NativeFieldInfoPtr_m_AtlasPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasPadding");
			FontAsset.NativeFieldInfoPtr_m_AtlasRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasRenderMode");
			FontAsset.NativeFieldInfoPtr_m_UsedGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_UsedGlyphRects");
			FontAsset.NativeFieldInfoPtr_m_FreeGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FreeGlyphRects");
			FontAsset.NativeFieldInfoPtr_m_FontFeatureTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FontFeatureTable");
			FontAsset.NativeFieldInfoPtr_m_FallbackFontAssetTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FallbackFontAssetTable");
			FontAsset.NativeFieldInfoPtr_m_FontWeightTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FontWeightTable");
			FontAsset.NativeFieldInfoPtr_m_RegularStyleWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_RegularStyleWeight");
			FontAsset.NativeFieldInfoPtr_m_RegularStyleSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_RegularStyleSpacing");
			FontAsset.NativeFieldInfoPtr_m_BoldStyleWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_BoldStyleWeight");
			FontAsset.NativeFieldInfoPtr_m_BoldStyleSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_BoldStyleSpacing");
			FontAsset.NativeFieldInfoPtr_m_ItalicStyleSlant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_ItalicStyleSlant");
			FontAsset.NativeFieldInfoPtr_m_TabMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_TabMultiple");
			FontAsset.NativeFieldInfoPtr_IsFontAssetLookupTablesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "IsFontAssetLookupTablesDirty");
			FontAsset.NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_ReadFontAssetDefinitionMarker");
			FontAsset.NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_AddSynthesizedCharactersMarker");
			FontAsset.NativeFieldInfoPtr_k_TryAddCharacterMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_TryAddCharacterMarker");
			FontAsset.NativeFieldInfoPtr_k_TryAddCharactersMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_TryAddCharactersMarker");
			FontAsset.NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_UpdateGlyphAdjustmentRecordsMarker");
			FontAsset.NativeFieldInfoPtr_k_UpdateDiacriticalMarkAdjustmentRecordsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_UpdateDiacriticalMarkAdjustmentRecordsMarker");
			FontAsset.NativeFieldInfoPtr_k_ClearFontAssetDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_ClearFontAssetDataMarker");
			FontAsset.NativeFieldInfoPtr_k_UpdateFontAssetDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_UpdateFontAssetDataMarker");
			FontAsset.NativeFieldInfoPtr_k_TryAddGlyphMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_TryAddGlyphMarker");
			FontAsset.NativeFieldInfoPtr_s_DefaultMaterialSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "s_DefaultMaterialSuffix");
			FontAsset.NativeFieldInfoPtr_k_SearchedFontAssetLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_SearchedFontAssetLookup");
			FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_FontAssets_FontFeaturesUpdateQueue");
			FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_FontAssets_FontFeaturesUpdateQueueLookup");
			FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_FontAssets_AtlasTexturesUpdateQueue");
			FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_FontAssets_AtlasTexturesUpdateQueueLookup");
			FontAsset.NativeFieldInfoPtr_m_GlyphsToRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphsToRender");
			FontAsset.NativeFieldInfoPtr_m_GlyphsRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphsRendered");
			FontAsset.NativeFieldInfoPtr_m_GlyphIndexList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphIndexList");
			FontAsset.NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphIndexListNewlyAdded");
			FontAsset.NativeFieldInfoPtr_m_GlyphsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphsToAdd");
			FontAsset.NativeFieldInfoPtr_m_GlyphsToAddLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphsToAddLookup");
			FontAsset.NativeFieldInfoPtr_m_CharactersToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_CharactersToAdd");
			FontAsset.NativeFieldInfoPtr_m_CharactersToAddLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_CharactersToAddLookup");
			FontAsset.NativeFieldInfoPtr_s_MissingCharacterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "s_MissingCharacterList");
			FontAsset.NativeFieldInfoPtr_m_MissingUnicodesFromFontFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_MissingUnicodesFromFontFile");
			FontAsset.NativeFieldInfoPtr_k_GlyphIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_GlyphIndexArray");
			FontAsset.NativeMethodInfoPtr_get_fontAssetCreationEditorSettings_Public_get_FontAssetCreationEditorSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663302);
			FontAsset.NativeMethodInfoPtr_set_fontAssetCreationEditorSettings_Public_set_Void_FontAssetCreationEditorSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663303);
			FontAsset.NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663304);
			FontAsset.NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663305);
			FontAsset.NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663306);
			FontAsset.NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663307);
			FontAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663308);
			FontAsset.NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663309);
			FontAsset.NativeMethodInfoPtr_get_familyNameHashCode_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663310);
			FontAsset.NativeMethodInfoPtr_set_familyNameHashCode_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663311);
			FontAsset.NativeMethodInfoPtr_get_styleNameHashCode_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663312);
			FontAsset.NativeMethodInfoPtr_set_styleNameHashCode_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663313);
			FontAsset.NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663314);
			FontAsset.NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663315);
			FontAsset.NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663316);
			FontAsset.NativeMethodInfoPtr_get_characterTable_Public_get_List_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663317);
			FontAsset.NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663318);
			FontAsset.NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663319);
			FontAsset.NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663320);
			FontAsset.NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663321);
			FontAsset.NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663322);
			FontAsset.NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663323);
			FontAsset.NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663324);
			FontAsset.NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663325);
			FontAsset.NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663326);
			FontAsset.NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663327);
			FontAsset.NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663328);
			FontAsset.NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663329);
			FontAsset.NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663330);
			FontAsset.NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663331);
			FontAsset.NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663332);
			FontAsset.NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663333);
			FontAsset.NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663334);
			FontAsset.NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663335);
			FontAsset.NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663336);
			FontAsset.NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663337);
			FontAsset.NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663338);
			FontAsset.NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663339);
			FontAsset.NativeMethodInfoPtr_get_fontFeatureTable_Public_get_FontFeatureTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663340);
			FontAsset.NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_FontFeatureTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663341);
			FontAsset.NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663342);
			FontAsset.NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663343);
			FontAsset.NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_FontWeightPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663344);
			FontAsset.NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_FontWeightPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663345);
			FontAsset.NativeMethodInfoPtr_get_regularStyleWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663346);
			FontAsset.NativeMethodInfoPtr_set_regularStyleWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663347);
			FontAsset.NativeMethodInfoPtr_get_regularStyleSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663348);
			FontAsset.NativeMethodInfoPtr_set_regularStyleSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663349);
			FontAsset.NativeMethodInfoPtr_get_boldStyleWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663350);
			FontAsset.NativeMethodInfoPtr_set_boldStyleWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663351);
			FontAsset.NativeMethodInfoPtr_get_boldStyleSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663352);
			FontAsset.NativeMethodInfoPtr_set_boldStyleSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663353);
			FontAsset.NativeMethodInfoPtr_get_italicStyleSlant_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663354);
			FontAsset.NativeMethodInfoPtr_set_italicStyleSlant_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663355);
			FontAsset.NativeMethodInfoPtr_get_tabMultiple_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663356);
			FontAsset.NativeMethodInfoPtr_set_tabMultiple_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663357);
			FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663358);
			FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663359);
			FontAsset.NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663360);
			FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663361);
			FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663362);
			FontAsset.NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663363);
			FontAsset.NativeMethodInfoPtr_CreateFontAssetInstance_Private_Static_FontAsset_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663364);
			FontAsset.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663365);
			FontAsset.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663366);
			FontAsset.NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663367);
			FontAsset.NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663368);
			FontAsset.NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663369);
			FontAsset.NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663370);
			FontAsset.NativeMethodInfoPtr_InitializeLigatureSubstitutionLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663371);
			FontAsset.NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663372);
			FontAsset.NativeMethodInfoPtr_InitializeMarkToBaseAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663373);
			FontAsset.NativeMethodInfoPtr_InitializeMarkToMarkAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663374);
			FontAsset.NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663375);
			FontAsset.NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663376);
			FontAsset.NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663377);
			FontAsset.NativeMethodInfoPtr_LoadFontFace_Private_FontEngineError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663378);
			FontAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663379);
			FontAsset.NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663380);
			FontAsset.NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663381);
			FontAsset.NativeMethodInfoPtr_SortAllTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663382);
			FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663383);
			FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663384);
			FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663385);
			FontAsset.NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663386);
			FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663387);
			FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663388);
			FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663389);
			FontAsset.NativeMethodInfoPtr_GetCharacters_Public_Static_String_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663390);
			FontAsset.NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663391);
			FontAsset.NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663392);
			FontAsset.NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663393);
			FontAsset.NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663394);
			FontAsset.NativeMethodInfoPtr_RegisterAtlasTextureForApply_Internal_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663395);
			FontAsset.NativeMethodInfoPtr_UpdateAtlasTexturesInQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663396);
			FontAsset.NativeMethodInfoPtr_UpdateFontAssetsInUpdateQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663397);
			FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663398);
			FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663399);
			FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663400);
			FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663401);
			FontAsset.NativeMethodInfoPtr_TryAddGlyphInternal_Internal_Boolean_UInt32_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663402);
			FontAsset.NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_Character_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663403);
			FontAsset.NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_Character_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663404);
			FontAsset.NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663405);
			FontAsset.NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663406);
			FontAsset.NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663407);
			FontAsset.NativeMethodInfoPtr_UpdateAllFontFeatures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663408);
			FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663409);
			FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663410);
			FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663411);
			FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663412);
			FontAsset.NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663413);
			FontAsset.NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663414);
			FontAsset.NativeMethodInfoPtr_ClearFontAssetDataInternal_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663415);
			FontAsset.NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663416);
			FontAsset.NativeMethodInfoPtr_ClearFontAssetTables_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663417);
			FontAsset.NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663418);
			FontAsset.NativeMethodInfoPtr_DestroyAtlasTextures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663419);
			FontAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663420);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00007C48 File Offset: 0x00005E48
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00007C80 File Offset: 0x00005E80
		public unsafe FontAssetCreationEditorSettings fontAssetCreationEditorSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_fontAssetCreationEditorSettings_Public_get_FontAssetCreationEditorSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FontAssetCreationEditorSettings(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097856, XrefRangeEnd = 1097857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_fontAssetCreationEditorSettings_Public_set_Void_FontAssetCreationEditorSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00007CC8 File Offset: 0x00005EC8
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00007D08 File Offset: 0x00005F08
		public unsafe Font sourceFontFile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00007D4C File Offset: 0x00005F4C
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00007D88 File Offset: 0x00005F88
		public unsafe AtlasPopulationMode atlasPopulationMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00007DC8 File Offset: 0x00005FC8
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00007E00 File Offset: 0x00006000
		public unsafe FaceInfo faceInfo
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 1097857, RefRangeEnd = 1097877, XrefRangeStart = 1097857, XrefRangeEnd = 1097857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FaceInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097877, XrefRangeEnd = 1097878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00007E48 File Offset: 0x00006048
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00007E84 File Offset: 0x00006084
		public unsafe int familyNameHashCode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1097880, RefRangeEnd = 1097884, XrefRangeStart = 1097878, XrefRangeEnd = 1097880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_familyNameHashCode_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_familyNameHashCode_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00007EC4 File Offset: 0x000060C4
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00007F00 File Offset: 0x00006100
		public unsafe int styleNameHashCode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1097886, RefRangeEnd = 1097890, XrefRangeStart = 1097884, XrefRangeEnd = 1097886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_styleNameHashCode_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_styleNameHashCode_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00007F40 File Offset: 0x00006140
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00007F80 File Offset: 0x00006180
		public unsafe List<Glyph> glyphTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00007FC4 File Offset: 0x000061C4
		public unsafe Dictionary<uint, Glyph> glyphLookupTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097890, XrefRangeEnd = 1097891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr3) : null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00008004 File Offset: 0x00006204
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00008044 File Offset: 0x00006244
		public unsafe List<Character> characterTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_characterTable_Public_get_List_1_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Character>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00008088 File Offset: 0x00006288
		public unsafe Dictionary<uint, Character> characterLookupTable
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1097892, RefRangeEnd = 1097898, XrefRangeStart = 1097891, XrefRangeEnd = 1097892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Character>>(intPtr3) : null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000080C8 File Offset: 0x000062C8
		public unsafe Texture2D atlasTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097898, XrefRangeEnd = 1097903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00008108 File Offset: 0x00006308
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00008148 File Offset: 0x00006348
		public unsafe Il2CppReferenceArray<Texture2D> atlasTextures
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1097903, RefRangeEnd = 1097904, XrefRangeStart = 1097903, XrefRangeEnd = 1097903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000818C File Offset: 0x0000638C
		public unsafe int atlasTextureCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000081C8 File Offset: 0x000063C8
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00008204 File Offset: 0x00006404
		public unsafe bool isMultiAtlasTexturesEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1097904, RefRangeEnd = 1097905, XrefRangeStart = 1097904, XrefRangeEnd = 1097904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00008244 File Offset: 0x00006444
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00008280 File Offset: 0x00006480
		public unsafe bool clearDynamicDataOnBuild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000082C0 File Offset: 0x000064C0
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000082FC File Offset: 0x000064FC
		public unsafe int atlasWidth
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1097905, RefRangeEnd = 1097909, XrefRangeStart = 1097905, XrefRangeEnd = 1097905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000833C File Offset: 0x0000653C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00008378 File Offset: 0x00006578
		public unsafe int atlasHeight
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1097909, RefRangeEnd = 1097913, XrefRangeStart = 1097909, XrefRangeEnd = 1097909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000083B8 File Offset: 0x000065B8
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000083F4 File Offset: 0x000065F4
		public unsafe int atlasPadding
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1097913, RefRangeEnd = 1097916, XrefRangeStart = 1097913, XrefRangeEnd = 1097913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00008434 File Offset: 0x00006634
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00008470 File Offset: 0x00006670
		public unsafe GlyphRenderMode atlasRenderMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1097916, RefRangeEnd = 1097917, XrefRangeStart = 1097916, XrefRangeEnd = 1097916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000084B0 File Offset: 0x000066B0
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000084F0 File Offset: 0x000066F0
		public unsafe List<GlyphRect> usedGlyphRects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00008534 File Offset: 0x00006734
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00008574 File Offset: 0x00006774
		public unsafe List<GlyphRect> freeGlyphRects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097917, XrefRangeEnd = 1097918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000085B8 File Offset: 0x000067B8
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000085F8 File Offset: 0x000067F8
		public unsafe FontFeatureTable fontFeatureTable
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1097918, RefRangeEnd = 1097925, XrefRangeStart = 1097918, XrefRangeEnd = 1097918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_fontFeatureTable_Public_get_FontFeatureTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontFeatureTable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097925, XrefRangeEnd = 1097926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_FontFeatureTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000863C File Offset: 0x0000683C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0000867C File Offset: 0x0000687C
		public unsafe List<FontAsset> fallbackFontAssetTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000086C0 File Offset: 0x000068C0
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00008700 File Offset: 0x00006900
		public unsafe Il2CppReferenceArray<FontWeightPair> fontWeightTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_FontWeightPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FontWeightPair>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097926, XrefRangeEnd = 1097927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_FontWeightPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00008744 File Offset: 0x00006944
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00008780 File Offset: 0x00006980
		public unsafe float regularStyleWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_regularStyleWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_regularStyleWeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000087C0 File Offset: 0x000069C0
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000087FC File Offset: 0x000069FC
		public unsafe float regularStyleSpacing
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1097927, RefRangeEnd = 1097934, XrefRangeStart = 1097927, XrefRangeEnd = 1097927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_regularStyleSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_regularStyleSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000883C File Offset: 0x00006A3C
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00008878 File Offset: 0x00006A78
		public unsafe float boldStyleWeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1097934, RefRangeEnd = 1097935, XrefRangeStart = 1097934, XrefRangeEnd = 1097934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_boldStyleWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_boldStyleWeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000088B8 File Offset: 0x00006AB8
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000088F4 File Offset: 0x00006AF4
		public unsafe float boldStyleSpacing
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1097935, RefRangeEnd = 1097937, XrefRangeStart = 1097935, XrefRangeEnd = 1097935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_boldStyleSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_boldStyleSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00008934 File Offset: 0x00006B34
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00008970 File Offset: 0x00006B70
		public unsafe byte italicStyleSlant
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1097937, RefRangeEnd = 1097938, XrefRangeStart = 1097937, XrefRangeEnd = 1097937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_italicStyleSlant_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_italicStyleSlant_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000089B0 File Offset: 0x00006BB0
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000089EC File Offset: 0x00006BEC
		public unsafe byte tabMultiple
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1097938, RefRangeEnd = 1097940, XrefRangeStart = 1097938, XrefRangeEnd = 1097938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_get_tabMultiple_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_set_tabMultiple_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008A2C File Offset: 0x00006C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1097968, RefRangeEnd = 1097969, XrefRangeStart = 1097940, XrefRangeEnd = 1097968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(styleName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008A90 File Offset: 0x00006C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097969, XrefRangeEnd = 1097973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fontFilePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplingPointSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPadding;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008B28 File Offset: 0x00006D28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1097992, RefRangeEnd = 1097994, XrefRangeStart = 1097973, XrefRangeEnd = 1097992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.DynamicOS, bool enableMultiAtlasSupport = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fontFilePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplingPointSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPadding;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPopulationMode;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMultiAtlasSupport;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008BE0 File Offset: 0x00006DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097994, XrefRangeEnd = 1097998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontAsset CreateFontAsset(Font font)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00008C24 File Offset: 0x00006E24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1098015, RefRangeEnd = 1098017, XrefRangeStart = 1097998, XrefRangeEnd = 1098015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplingPointSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPadding;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPopulationMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMultiAtlasSupport;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008CCC File Offset: 0x00006ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098017, XrefRangeEnd = 1098031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplingPointSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPadding;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPopulationMode;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMultiAtlasSupport;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00008D84 File Offset: 0x00006F84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1098107, RefRangeEnd = 1098110, XrefRangeStart = 1098031, XrefRangeEnd = 1098107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPadding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasPopulationMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMultiAtlasSupport;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_CreateFontAssetInstance_Private_Static_FontAsset_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00008E1C File Offset: 0x0000701C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00008E50 File Offset: 0x00007050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098110, XrefRangeEnd = 1098124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00008E84 File Offset: 0x00007084
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1098185, RefRangeEnd = 1098197, XrefRangeStart = 1098124, XrefRangeEnd = 1098185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadFontAssetDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00008EB8 File Offset: 0x000070B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098197, XrefRangeEnd = 1098203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDictionaryLookupTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00008EEC File Offset: 0x000070EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1098243, RefRangeEnd = 1098245, XrefRangeStart = 1098203, XrefRangeEnd = 1098243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeGlyphLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00008F20 File Offset: 0x00007120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1098272, RefRangeEnd = 1098274, XrefRangeStart = 1098245, XrefRangeEnd = 1098272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeCharacterLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00008F54 File Offset: 0x00007154
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1098314, RefRangeEnd = 1098316, XrefRangeStart = 1098274, XrefRangeEnd = 1098314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeLigatureSubstitutionLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_InitializeLigatureSubstitutionLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00008F88 File Offset: 0x00007188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1098342, RefRangeEnd = 1098344, XrefRangeStart = 1098316, XrefRangeEnd = 1098342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00008FBC File Offset: 0x000071BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1098368, RefRangeEnd = 1098370, XrefRangeStart = 1098344, XrefRangeEnd = 1098368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_InitializeMarkToBaseAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00008FF0 File Offset: 0x000071F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1098394, RefRangeEnd = 1098396, XrefRangeStart = 1098370, XrefRangeEnd = 1098394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_InitializeMarkToMarkAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009024 File Offset: 0x00007224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1098419, RefRangeEnd = 1098420, XrefRangeStart = 1098396, XrefRangeEnd = 1098419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSynthesizedCharactersAndFaceMetrics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009058 File Offset: 0x00007258
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1098442, RefRangeEnd = 1098454, XrefRangeStart = 1098420, XrefRangeEnd = 1098442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFontFaceLoaded;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addImmediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000090B4 File Offset: 0x000072B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1098458, RefRangeEnd = 1098459, XrefRangeStart = 1098454, XrefRangeEnd = 1098458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCharacterToLookupCache(uint unicode, Character character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(character);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00009104 File Offset: 0x00007304
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1098472, RefRangeEnd = 1098479, XrefRangeStart = 1098459, XrefRangeEnd = 1098472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontEngineError LoadFontFace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_LoadFontFace_Private_FontEngineError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00009140 File Offset: 0x00007340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098479, XrefRangeEnd = 1098502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortCharacterTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00009174 File Offset: 0x00007374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098502, XrefRangeEnd = 1098525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000091A8 File Offset: 0x000073A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098525, XrefRangeEnd = 1098529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortFontFeatureTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000091DC File Offset: 0x000073DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098529, XrefRangeEnd = 1098579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortAllTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_SortAllTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00009210 File Offset: 0x00007410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098579, XrefRangeEnd = 1098582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(int character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000925C File Offset: 0x0000745C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098582, XrefRangeEnd = 1098583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryAddCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000092C4 File Offset: 0x000074C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1098635, RefRangeEnd = 1098636, XrefRangeStart = 1098583, XrefRangeEnd = 1098635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryAddCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_HasCharacter_Public_Boolean_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000932C File Offset: 0x0000752C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1098662, RefRangeEnd = 1098665, XrefRangeStart = 1098636, XrefRangeEnd = 1098662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryAddCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00009394 File Offset: 0x00007594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098665, XrefRangeEnd = 1098684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacters(string text, out List<char> missingCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			missingCharacters = ((intPtr4 == 0) ? null : new List<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00009404 File Offset: 0x00007604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098684, XrefRangeEnd = 1098745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacters(string text, out Il2CppStructArray<uint> missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryAddCharacter;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			missingCharacters = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009490 File Offset: 0x00007690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098745, XrefRangeEnd = 1098751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacters(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000094E0 File Offset: 0x000076E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098751, XrefRangeEnd = 1098763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCharacters(FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_GetCharacters_Public_Static_String_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000951C File Offset: 0x0000771C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098763, XrefRangeEnd = 1098771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetCharactersArray(FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00009560 File Offset: 0x00007760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1098780, RefRangeEnd = 1098781, XrefRangeStart = 1098771, XrefRangeEnd = 1098780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetGlyphIndex(uint unicode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000095AC File Offset: 0x000077AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1098795, RefRangeEnd = 1098797, XrefRangeStart = 1098781, XrefRangeEnd = 1098795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000095E4 File Offset: 0x000077E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098797, XrefRangeEnd = 1098820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateFontFeaturesForFontAssetsInQueue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000960C File Offset: 0x0000780C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1098834, RefRangeEnd = 1098835, XrefRangeStart = 1098820, XrefRangeEnd = 1098834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterAtlasTextureForApply(Texture2D texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_RegisterAtlasTextureForApply_Internal_Static_Void_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00009644 File Offset: 0x00007844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098835, XrefRangeEnd = 1098857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateAtlasTexturesInQueue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_UpdateAtlasTexturesInQueue_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000966C File Offset: 0x0000786C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1098903, RefRangeEnd = 1098904, XrefRangeStart = 1098857, XrefRangeEnd = 1098903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateFontAssetsInUpdateQueue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_UpdateFontAssetsInUpdateQueue_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00009694 File Offset: 0x00007894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098904, XrefRangeEnd = 1098905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(Il2CppStructArray<uint> unicodes, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000096F0 File Offset: 0x000078F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1099040, RefRangeEnd = 1099042, XrefRangeStart = 1098905, XrefRangeEnd = 1099040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(Il2CppStructArray<uint> unicodes, out Il2CppStructArray<uint> missingUnicodes, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			missingUnicodes = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00009770 File Offset: 0x00007970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099042, XrefRangeEnd = 1099043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(string characters, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000097CC File Offset: 0x000079CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1099175, RefRangeEnd = 1099176, XrefRangeStart = 1099043, XrefRangeEnd = 1099175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFontFeatures;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			missingCharacters = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00009844 File Offset: 0x00007A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1099267, RefRangeEnd = 1099268, XrefRangeStart = 1099176, XrefRangeEnd = 1099267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_TryAddGlyphInternal_Internal_Boolean_UInt32_byref_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			glyph = ((intPtr4 == 0) ? null : new Glyph(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000098B0 File Offset: 0x00007AB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1099365, RefRangeEnd = 1099369, XrefRangeStart = 1099268, XrefRangeEnd = 1099365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddCharacterInternal(uint unicode, out Character character, bool shouldGetFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldGetFontFeatures;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_Character_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new Character(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000992C File Offset: 0x00007B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099369, XrefRangeEnd = 1099426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out Character character, bool shouldGetFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldGetFontFeatures;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_Character_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new Character(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000099A8 File Offset: 0x00007BA8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryAddGlyphsToAtlasTextures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000099DC File Offset: 0x00007BDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1099472, RefRangeEnd = 1099474, XrefRangeStart = 1099426, XrefRangeEnd = 1099472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddGlyphsToNewAtlasTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00009A18 File Offset: 0x00007C18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1099492, RefRangeEnd = 1099495, XrefRangeStart = 1099474, XrefRangeEnd = 1099492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupNewAtlasTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009A4C File Offset: 0x00007C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099495, XrefRangeEnd = 1099497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAllFontFeatures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_UpdateAllFontFeatures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00009A80 File Offset: 0x00007C80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1099539, RefRangeEnd = 1099544, XrefRangeStart = 1099497, XrefRangeEnd = 1099539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00009AB4 File Offset: 0x00007CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099544, XrefRangeEnd = 1099585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords(Il2CppStructArray<uint> glyphIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00009AF8 File Offset: 0x00007CF8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00009B3C File Offset: 0x00007D3C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newGlyphIndexes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allGlyphIndexes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_List_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00009B90 File Offset: 0x00007D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyListDataToArray<T>(List<T> srcList, ref Il2CppArrayBase<T> dstArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcList);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dstArray);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontAsset.MethodInfoStoreGeneric_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dstArray = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00009BFC File Offset: 0x00007DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099585, XrefRangeEnd = 1099599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFontAssetData(bool setAtlasSizeToZero = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setAtlasSizeToZero;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00009C3C File Offset: 0x00007E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099599, XrefRangeEnd = 1099601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFontAssetDataInternal(bool clearFontFeatures = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearFontFeatures;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_ClearFontAssetDataInternal_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00009C7C File Offset: 0x00007E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099601, XrefRangeEnd = 1099624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFontAssetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00009CB0 File Offset: 0x00007EB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1099640, RefRangeEnd = 1099643, XrefRangeStart = 1099624, XrefRangeEnd = 1099640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFontAssetTables(bool clearFontFeatures)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearFontFeatures;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_ClearFontAssetTables_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1099662, RefRangeEnd = 1099665, XrefRangeStart = 1099643, XrefRangeEnd = 1099662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAtlasTextures(bool setAtlasSizeToZero = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setAtlasSizeToZero;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00009D30 File Offset: 0x00007F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099665, XrefRangeEnd = 1099673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyAtlasTextures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr_DestroyAtlasTextures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00009D64 File Offset: 0x00007F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099673, XrefRangeEnd = 1099751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000022B1 File Offset: 0x000004B1
		public FontAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00009DA0 File Offset: 0x00007FA0
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000022BA File Offset: 0x000004BA
		public unsafe string m_SourceFontFileGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_SourceFontFileGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_SourceFontFileGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00009DC8 File Offset: 0x00007FC8
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000022D9 File Offset: 0x000004D9
		public FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_fontAssetCreationEditorSettings);
				return new FontAssetCreationEditorSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_fontAssetCreationEditorSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00009DF8 File Offset: 0x00007FF8
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002307 File Offset: 0x00000507
		public unsafe Font m_SourceFontFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_SourceFontFile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_SourceFontFile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00009E28 File Offset: 0x00008028
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002326 File Offset: 0x00000526
		public unsafe string m_SourceFontFilePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_SourceFontFilePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_SourceFontFilePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00009E50 File Offset: 0x00008050
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002345 File Offset: 0x00000545
		public unsafe AtlasPopulationMode m_AtlasPopulationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasPopulationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasPopulationMode)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00009E78 File Offset: 0x00008078
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002360 File Offset: 0x00000560
		public unsafe bool InternalDynamicOS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_InternalDynamicOS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_InternalDynamicOS)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00009EA0 File Offset: 0x000080A0
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000237B File Offset: 0x0000057B
		public FaceInfo m_FaceInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FaceInfo);
				return new FaceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FaceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00009ED0 File Offset: 0x000080D0
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000023A9 File Offset: 0x000005A9
		public unsafe int m_FamilyNameHashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FamilyNameHashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FamilyNameHashCode)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00009EF8 File Offset: 0x000080F8
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000023C4 File Offset: 0x000005C4
		public unsafe int m_StyleNameHashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_StyleNameHashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_StyleNameHashCode)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00009F20 File Offset: 0x00008120
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000023DF File Offset: 0x000005DF
		public unsafe List<Glyph> m_GlyphTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00009F50 File Offset: 0x00008150
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000023FE File Offset: 0x000005FE
		public unsafe Dictionary<uint, Glyph> m_GlyphLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00009F80 File Offset: 0x00008180
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000241D File Offset: 0x0000061D
		public unsafe List<Character> m_CharacterTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_CharacterTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Character>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_CharacterTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00009FB0 File Offset: 0x000081B0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000243C File Offset: 0x0000063C
		public unsafe Dictionary<uint, Character> m_CharacterLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_CharacterLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Character>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_CharacterLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00009FE0 File Offset: 0x000081E0
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000245B File Offset: 0x0000065B
		public unsafe Texture2D m_AtlasTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000A010 File Offset: 0x00008210
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000247A File Offset: 0x0000067A
		public unsafe Il2CppReferenceArray<Texture2D> m_AtlasTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000A040 File Offset: 0x00008240
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002499 File Offset: 0x00000699
		public unsafe int m_AtlasTextureIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasTextureIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasTextureIndex)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000A068 File Offset: 0x00008268
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000024B4 File Offset: 0x000006B4
		public unsafe bool m_IsMultiAtlasTexturesEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000A090 File Offset: 0x00008290
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000024CF File Offset: 0x000006CF
		public unsafe bool m_ClearDynamicDataOnBuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_ClearDynamicDataOnBuild)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000A0B8 File Offset: 0x000082B8
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000024EA File Offset: 0x000006EA
		public unsafe int m_AtlasWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasWidth)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000A0E0 File Offset: 0x000082E0
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002505 File Offset: 0x00000705
		public unsafe int m_AtlasHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasHeight)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000A108 File Offset: 0x00008308
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002520 File Offset: 0x00000720
		public unsafe int m_AtlasPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasPadding)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000A130 File Offset: 0x00008330
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000253B File Offset: 0x0000073B
		public unsafe GlyphRenderMode m_AtlasRenderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasRenderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_AtlasRenderMode)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000A158 File Offset: 0x00008358
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002556 File Offset: 0x00000756
		public unsafe List<GlyphRect> m_UsedGlyphRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_UsedGlyphRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_UsedGlyphRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000A188 File Offset: 0x00008388
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002575 File Offset: 0x00000775
		public unsafe List<GlyphRect> m_FreeGlyphRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FreeGlyphRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FreeGlyphRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000A1B8 File Offset: 0x000083B8
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002594 File Offset: 0x00000794
		public unsafe FontFeatureTable m_FontFeatureTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FontFeatureTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontFeatureTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FontFeatureTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000A1E8 File Offset: 0x000083E8
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000025B3 File Offset: 0x000007B3
		public unsafe List<FontAsset> m_FallbackFontAssetTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FallbackFontAssetTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FallbackFontAssetTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000A218 File Offset: 0x00008418
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000025D2 File Offset: 0x000007D2
		public unsafe Il2CppReferenceArray<FontWeightPair> m_FontWeightTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FontWeightTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FontWeightPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_FontWeightTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000A248 File Offset: 0x00008448
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000025F1 File Offset: 0x000007F1
		public unsafe float m_RegularStyleWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_RegularStyleWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_RegularStyleWeight)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000A270 File Offset: 0x00008470
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000260C File Offset: 0x0000080C
		public unsafe float m_RegularStyleSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_RegularStyleSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_RegularStyleSpacing)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000A298 File Offset: 0x00008498
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002627 File Offset: 0x00000827
		public unsafe float m_BoldStyleWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_BoldStyleWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_BoldStyleWeight)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000A2C0 File Offset: 0x000084C0
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002642 File Offset: 0x00000842
		public unsafe float m_BoldStyleSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_BoldStyleSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_BoldStyleSpacing)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000A2E8 File Offset: 0x000084E8
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000265D File Offset: 0x0000085D
		public unsafe byte m_ItalicStyleSlant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_ItalicStyleSlant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_ItalicStyleSlant)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000A310 File Offset: 0x00008510
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002678 File Offset: 0x00000878
		public unsafe byte m_TabMultiple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_TabMultiple);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_TabMultiple)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000A338 File Offset: 0x00008538
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002693 File Offset: 0x00000893
		public unsafe bool IsFontAssetLookupTablesDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_IsFontAssetLookupTablesDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_IsFontAssetLookupTablesDirty)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000A360 File Offset: 0x00008560
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000026AE File Offset: 0x000008AE
		public unsafe static ProfilerMarker k_ReadFontAssetDefinitionMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker, (void*)(&value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000A37C File Offset: 0x0000857C
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000026BC File Offset: 0x000008BC
		public unsafe static ProfilerMarker k_AddSynthesizedCharactersMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker, (void*)(&value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000A398 File Offset: 0x00008598
		// (set) Token: 0x060000FB RID: 251 RVA: 0x000026CA File Offset: 0x000008CA
		public unsafe static ProfilerMarker k_TryAddCharacterMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_TryAddCharacterMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_TryAddCharacterMarker, (void*)(&value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000A3B4 File Offset: 0x000085B4
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000026D8 File Offset: 0x000008D8
		public unsafe static ProfilerMarker k_TryAddCharactersMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_TryAddCharactersMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_TryAddCharactersMarker, (void*)(&value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000A3D0 File Offset: 0x000085D0
		// (set) Token: 0x060000FF RID: 255 RVA: 0x000026E6 File Offset: 0x000008E6
		public unsafe static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker, (void*)(&value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000A3EC File Offset: 0x000085EC
		// (set) Token: 0x06000101 RID: 257 RVA: 0x000026F4 File Offset: 0x000008F4
		public unsafe static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_UpdateDiacriticalMarkAdjustmentRecordsMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_UpdateDiacriticalMarkAdjustmentRecordsMarker, (void*)(&value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000A408 File Offset: 0x00008608
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002702 File Offset: 0x00000902
		public unsafe static ProfilerMarker k_ClearFontAssetDataMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_ClearFontAssetDataMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_ClearFontAssetDataMarker, (void*)(&value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000A424 File Offset: 0x00008624
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002710 File Offset: 0x00000910
		public unsafe static ProfilerMarker k_UpdateFontAssetDataMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_UpdateFontAssetDataMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_UpdateFontAssetDataMarker, (void*)(&value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000A440 File Offset: 0x00008640
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000271E File Offset: 0x0000091E
		public unsafe static ProfilerMarker k_TryAddGlyphMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_TryAddGlyphMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_TryAddGlyphMarker, (void*)(&value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000A45C File Offset: 0x0000865C
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000272C File Offset: 0x0000092C
		public unsafe static string s_DefaultMaterialSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_s_DefaultMaterialSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_s_DefaultMaterialSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000A47C File Offset: 0x0000867C
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000273E File Offset: 0x0000093E
		public unsafe static HashSet<int> k_SearchedFontAssetLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_SearchedFontAssetLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_SearchedFontAssetLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000A4A4 File Offset: 0x000086A4
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002750 File Offset: 0x00000950
		public unsafe static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000A4CC File Offset: 0x000086CC
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002762 File Offset: 0x00000962
		public unsafe static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000A4F4 File Offset: 0x000086F4
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002774 File Offset: 0x00000974
		public unsafe static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000A51C File Offset: 0x0000871C
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002786 File Offset: 0x00000986
		public unsafe static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000A544 File Offset: 0x00008744
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002798 File Offset: 0x00000998
		public unsafe List<Glyph> m_GlyphsToRender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphsToRender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphsToRender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000A574 File Offset: 0x00008774
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000027B7 File Offset: 0x000009B7
		public unsafe List<Glyph> m_GlyphsRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphsRendered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphsRendered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000A5A4 File Offset: 0x000087A4
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000027D6 File Offset: 0x000009D6
		public unsafe List<uint> m_GlyphIndexList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphIndexList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphIndexList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000A5D4 File Offset: 0x000087D4
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000027F5 File Offset: 0x000009F5
		public unsafe List<uint> m_GlyphIndexListNewlyAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000A604 File Offset: 0x00008804
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002814 File Offset: 0x00000A14
		public unsafe List<uint> m_GlyphsToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphsToAdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphsToAdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000A634 File Offset: 0x00008834
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002833 File Offset: 0x00000A33
		public unsafe HashSet<uint> m_GlyphsToAddLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphsToAddLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_GlyphsToAddLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000A664 File Offset: 0x00008864
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002852 File Offset: 0x00000A52
		public unsafe List<Character> m_CharactersToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_CharactersToAdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Character>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_CharactersToAdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000A694 File Offset: 0x00008894
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002871 File Offset: 0x00000A71
		public unsafe HashSet<uint> m_CharactersToAddLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_CharactersToAddLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_CharactersToAddLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000A6C4 File Offset: 0x000088C4
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002890 File Offset: 0x00000A90
		public unsafe List<uint> s_MissingCharacterList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_s_MissingCharacterList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_s_MissingCharacterList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000A6F4 File Offset: 0x000088F4
		// (set) Token: 0x06000127 RID: 295 RVA: 0x000028AF File Offset: 0x00000AAF
		public unsafe HashSet<uint> m_MissingUnicodesFromFontFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_MissingUnicodesFromFontFile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAsset.NativeFieldInfoPtr_m_MissingUnicodesFromFontFile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000A724 File Offset: 0x00008924
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000028CE File Offset: 0x00000ACE
		public unsafe static Il2CppStructArray<uint> k_GlyphIndexArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontAsset.NativeFieldInfoPtr_k_GlyphIndexArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAsset.NativeFieldInfoPtr_k_GlyphIndexArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceFontFileGUID;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_m_fontAssetCreationEditorSettings;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceFontFile;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceFontFilePath;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasPopulationMode;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_InternalDynamicOS;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceInfo;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_m_FamilyNameHashCode;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleNameHashCode;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphTable;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphLookupDictionary;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterTable;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterLookupDictionary;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTexture;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTextures;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTextureIndex;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearDynamicDataOnBuild;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasWidth;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasHeight;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasPadding;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasRenderMode;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_m_UsedGlyphRects;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_m_FreeGlyphRects;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_m_FontFeatureTable;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackFontAssetTable;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightTable;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_m_RegularStyleWeight;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_m_RegularStyleSpacing;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_m_BoldStyleWeight;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_m_BoldStyleSpacing;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_m_ItalicStyleSlant;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_m_TabMultiple;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_IsFontAssetLookupTablesDirty;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_k_TryAddCharacterMarker;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_k_TryAddCharactersMarker;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_k_UpdateDiacriticalMarkAdjustmentRecordsMarker;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_k_ClearFontAssetDataMarker;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_k_UpdateFontAssetDataMarker;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_k_TryAddGlyphMarker;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultMaterialSuffix;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_k_SearchedFontAssetLookup;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsToRender;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsRendered;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndexList;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsToAdd;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphsToAddLookup;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_m_CharactersToAdd;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_m_CharactersToAddLookup;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_s_MissingCharacterList;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_m_MissingUnicodesFromFontFile;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_k_GlyphIndexArray;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_get_fontAssetCreationEditorSettings_Public_get_FontAssetCreationEditorSettings_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_set_fontAssetCreationEditorSettings_Public_set_Void_FontAssetCreationEditorSettings_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_familyNameHashCode_Internal_get_Int32_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_set_familyNameHashCode_Internal_set_Void_Int32_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_styleNameHashCode_Internal_get_Int32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_set_styleNameHashCode_Internal_set_Void_Int32_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_get_characterTable_Public_get_List_1_Character_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_Character_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_Character_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_fontFeatureTable_Public_get_FontFeatureTable_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_FontFeatureTable_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_FontAsset_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_FontAsset_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_FontWeightPair_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_FontWeightPair_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_get_regularStyleWeight_Public_get_Single_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_set_regularStyleWeight_Public_set_Void_Single_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_regularStyleSpacing_Public_get_Single_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_set_regularStyleSpacing_Public_set_Void_Single_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_get_boldStyleWeight_Public_get_Single_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_set_boldStyleWeight_Public_set_Void_Single_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_get_boldStyleSpacing_Public_get_Single_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_set_boldStyleSpacing_Public_set_Void_Single_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_get_italicStyleSlant_Public_get_Byte_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_set_italicStyleSlant_Public_set_Void_Byte_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_get_tabMultiple_Public_get_Byte_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_set_tabMultiple_Public_set_Void_Byte_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_String_Int32_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_CreateFontAssetInstance_Private_Static_FontAsset_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLigatureSubstitutionLookupDictionary_Internal_Void_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_InitializeMarkToBaseAdjustmentRecordsLookupDictionary_Internal_Void_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_InitializeMarkToMarkAdjustmentRecordsLookupDictionary_Internal_Void_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_Character_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_Private_FontEngineError_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_SortAllTables_Internal_Void_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_UInt32_Boolean_Boolean_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacters_Public_Static_String_FontAsset_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_FontAsset_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_FontAsset_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_RegisterAtlasTextureForApply_Internal_Static_Void_Texture2D_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAtlasTexturesInQueue_Internal_Static_Void_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFontAssetsInUpdateQueue_Internal_Static_Void_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphInternal_Internal_Boolean_UInt32_byref_Glyph_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_Character_Boolean_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_Character_Boolean_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAllFontFeatures_Private_Void_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_List_1_UInt32_List_1_UInt32_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_ClearFontAssetDataInternal_Internal_Void_Boolean_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_ClearFontAssetTables_Internal_Void_Boolean_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_DestroyAtlasTextures_Private_Void_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000044 RID: 68
		[ObfuscatedName("UnityEngine.TextCore.Text.FontAsset+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600071B RID: 1819 RVA: 0x0001BC5C File Offset: 0x00019E5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FontAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAsset.__c>.NativeClassPtr);
				FontAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset.__c>.NativeClassPtr, "<>9");
				FontAsset.__c.NativeFieldInfoPtr___9__151_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset.__c>.NativeClassPtr, "<>9__151_0");
				FontAsset.__c.NativeFieldInfoPtr___9__152_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset.__c>.NativeClassPtr, "<>9__152_0");
				FontAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset.__c>.NativeClassPtr, 100663423);
				FontAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__151_0_Internal_UInt32_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset.__c>.NativeClassPtr, 100663424);
				FontAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__152_0_Internal_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset.__c>.NativeClassPtr, 100663425);
			}

			// Token: 0x0600071C RID: 1820 RVA: 0x0001BD00 File Offset: 0x00019F00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAsset.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600071D RID: 1821 RVA: 0x0001BD3C File Offset: 0x00019F3C
			[CallerCount(0)]
			public unsafe uint _SortCharacterTable_b__151_0(Character c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__151_0_Internal_UInt32_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600071E RID: 1822 RVA: 0x0001BD8C File Offset: 0x00019F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortGlyphTable_b__152_0(Glyph c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__152_0_Internal_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600071F RID: 1823 RVA: 0x000062EA File Offset: 0x000044EA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x06000720 RID: 1824 RVA: 0x0001BDDC File Offset: 0x00019FDC
			// (set) Token: 0x06000721 RID: 1825 RVA: 0x000062F3 File Offset: 0x000044F3
			public unsafe static FontAsset.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontAsset.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontAsset.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06000722 RID: 1826 RVA: 0x0001BE04 File Offset: 0x0001A004
			// (set) Token: 0x06000723 RID: 1827 RVA: 0x00006305 File Offset: 0x00004505
			public unsafe static Func<Character, uint> __9__151_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontAsset.__c.NativeFieldInfoPtr___9__151_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Character, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontAsset.__c.NativeFieldInfoPtr___9__151_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x06000724 RID: 1828 RVA: 0x0001BE2C File Offset: 0x0001A02C
			// (set) Token: 0x06000725 RID: 1829 RVA: 0x00006317 File Offset: 0x00004517
			public unsafe static Func<Glyph, uint> __9__152_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontAsset.__c.NativeFieldInfoPtr___9__152_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Glyph, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontAsset.__c.NativeFieldInfoPtr___9__152_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005D6 RID: 1494
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040005D7 RID: 1495
			private static readonly IntPtr NativeFieldInfoPtr___9__151_0;

			// Token: 0x040005D8 RID: 1496
			private static readonly IntPtr NativeFieldInfoPtr___9__152_0;

			// Token: 0x040005D9 RID: 1497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005DA RID: 1498
			private static readonly IntPtr NativeMethodInfoPtr__SortCharacterTable_b__151_0_Internal_UInt32_Character_0;

			// Token: 0x040005DB RID: 1499
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphTable_b__152_0_Internal_UInt32_Glyph_0;
		}

		// Token: 0x02000045 RID: 69
		private sealed class MethodInfoStoreGeneric_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x040005DC RID: 1500
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FontAsset.NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<FontAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000046 RID: 70
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
