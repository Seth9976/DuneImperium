using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200000C RID: 12
	public sealed class FontEngine : Object
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x0000508C File Offset: 0x0000328C
		// Note: this type is marked as 'beforefieldinit'.
		static FontEngine()
		{
			Il2CppClassPointerStore<FontEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "FontEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontEngine>.NativeClassPtr);
			FontEngine.NativeFieldInfoPtr_s_Glyphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_Glyphs");
			FontEngine.NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphIndexes_MarshallingArray_A");
			FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphMarshallingStruct_IN");
			FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphMarshallingStruct_OUT");
			FontEngine.NativeFieldInfoPtr_s_FreeGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_FreeGlyphRects");
			FontEngine.NativeFieldInfoPtr_s_UsedGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_UsedGlyphRects");
			FontEngine.NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_PairAdjustmentRecords_MarshallingArray");
			FontEngine.NativeFieldInfoPtr_s_GlyphLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphLookupDictionary");
			FontEngine.NativeMethodInfoPtr_InitializeFontEngine_Public_Static_FontEngineError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663367);
			FontEngine.NativeMethodInfoPtr_InitializeFontEngine_Internal_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663368);
			FontEngine.NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663369);
			FontEngine.NativeMethodInfoPtr_LoadFontFace_With_Size_And_FaceIndex_Internal_Private_Static_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663370);
			FontEngine.NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663371);
			FontEngine.NativeMethodInfoPtr_LoadFontFace_With_Size_FromFont_Internal_Private_Static_Int32_Font_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663372);
			FontEngine.NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663373);
			FontEngine.NativeMethodInfoPtr_LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Private_Static_Int32_Font_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663374);
			FontEngine.NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663375);
			FontEngine.NativeMethodInfoPtr_LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Private_Static_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663376);
			FontEngine.NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Static_Boolean_String_String_byref_FontReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663377);
			FontEngine.NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Private_Static_Boolean_String_String_byref_FontReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663378);
			FontEngine.NativeMethodInfoPtr_GetFaceInfo_Public_Static_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663379);
			FontEngine.NativeMethodInfoPtr_GetFaceInfo_Internal_Private_Static_Int32_byref_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663380);
			FontEngine.NativeMethodInfoPtr_GetGlyphIndex_Internal_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663381);
			FontEngine.NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663382);
			FontEngine.NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663383);
			FontEngine.NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663384);
			FontEngine.NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663385);
			FontEngine.NativeMethodInfoPtr_SetTextureUploadMode_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663386);
			FontEngine.NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Static_Boolean_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663387);
			FontEngine.NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_byref_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663388);
			FontEngine.NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Static_Boolean_List_1_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Il2CppReferenceArray_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663389);
			FontEngine.NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Private_Static_Boolean_Il2CppStructArray_1_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_Il2CppStructArray_1_GlyphMarshallingStruct_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663390);
			FontEngine.NativeMethodInfoPtr_GetGlyphPairAdjustmentTable_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663391);
			FontEngine.NativeMethodInfoPtr_GetGlyphPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_List_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663392);
			FontEngine.NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663393);
			FontEngine.NativeMethodInfoPtr_GetPairAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663394);
			FontEngine.NativeMethodInfoPtr_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663395);
			FontEngine.NativeMethodInfoPtr_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663396);
			FontEngine.NativeMethodInfoPtr_ResetAtlasTexture_Internal_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663397);
			FontEngine.DestroyFontEngine_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.DestroyFontEngine_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::DestroyFontEngine_Internal");
			FontEngine.SendCancellationRequest_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.SendCancellationRequest_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::SendCancellationRequest_Internal");
			FontEngine.get_isProcessingDoneDelegateField = IL2CPP.ResolveICall<FontEngine.get_isProcessingDoneDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::get_isProcessingDone");
			FontEngine.get_generationProgressDelegateField = IL2CPP.ResolveICall<FontEngine.get_generationProgressDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::get_generationProgress");
			FontEngine.LoadFontFace_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_Internal");
			FontEngine.LoadFontFace_With_Size_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_With_Size_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_Internal");
			FontEngine.LoadFontFace_FromSourceFontFile_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_FromSourceFontFile_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_FromSourceFontFile_Internal");
			FontEngine.LoadFontFace_With_Size_FromSourceFontFile_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_With_Size_FromSourceFontFile_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_FromSourceFontFile_Internal");
			FontEngine.LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal");
			FontEngine.LoadFontFace_FromFont_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_FromFont_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_FromFont_Internal");
			FontEngine.LoadFontFace_by_FamilyName_and_StyleName_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_by_FamilyName_and_StyleName_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_by_FamilyName_and_StyleName_Internal");
			FontEngine.UnloadFontFace_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.UnloadFontFace_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::UnloadFontFace_Internal");
			FontEngine.UnloadAllFontFaces_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.UnloadAllFontFaces_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::UnloadAllFontFaces_Internal");
			FontEngine.GetSystemFontNames_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.GetSystemFontNames_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetSystemFontNames_Internal");
			FontEngine.GetSystemFontReferencesDelegateField = IL2CPP.ResolveICall<FontEngine.GetSystemFontReferencesDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetSystemFontReferences");
			FontEngine.SetFaceSize_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.SetFaceSize_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::SetFaceSize_Internal");
			FontEngine.GetFaceCountDelegateField = IL2CPP.ResolveICall<FontEngine.GetFaceCountDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetFaceCount");
			FontEngine.GetFontFaces_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.GetFontFaces_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetFontFaces_Internal");
			FontEngine.GetVariantGlyphIndexDelegateField = IL2CPP.ResolveICall<FontEngine.GetVariantGlyphIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetVariantGlyphIndex");
			FontEngine.TryGetGlyphIndexDelegateField = IL2CPP.ResolveICall<FontEngine.TryGetGlyphIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryGetGlyphIndex");
			FontEngine.LoadGlyph_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadGlyph_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadGlyph_Internal");
			FontEngine.TryPackGlyphInAtlas_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.TryPackGlyphInAtlas_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryPackGlyphInAtlas_Internal");
			FontEngine.TryPackGlyphsInAtlas_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.TryPackGlyphsInAtlas_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryPackGlyphsInAtlas_Internal");
			FontEngine.RenderGlyphsToTexture_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.RenderGlyphsToTexture_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphsToTexture_Internal");
			FontEngine.RenderGlyphsToTextureBuffer_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.RenderGlyphsToTextureBuffer_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphsToTextureBuffer_Internal");
			FontEngine.RenderGlyphsToSharedTexture_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.RenderGlyphsToSharedTexture_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphsToSharedTexture_Internal");
			FontEngine.SetSharedTextureDelegateField = IL2CPP.ResolveICall<FontEngine.SetSharedTextureDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::SetSharedTexture");
			FontEngine.ReleaseSharedTextureDelegateField = IL2CPP.ResolveICall<FontEngine.ReleaseSharedTextureDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::ReleaseSharedTexture");
			FontEngine.TryAddGlyphsToTexture_Internal_MultiThreadDelegateField = IL2CPP.ResolveICall<FontEngine.TryAddGlyphsToTexture_Internal_MultiThreadDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryAddGlyphsToTexture_Internal_MultiThread");
			FontEngine.PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes");
			FontEngine.GetAllMultipleSubstitutionRecordsDelegateField = IL2CPP.ResolveICall<FontEngine.GetAllMultipleSubstitutionRecordsDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetAllMultipleSubstitutionRecords");
			FontEngine.PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes");
			FontEngine.GetMultipleSubstitutionRecordsFromMarshallingArrayDelegateField = IL2CPP.ResolveICall<FontEngine.GetMultipleSubstitutionRecordsFromMarshallingArrayDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMultipleSubstitutionRecordsFromMarshallingArray");
			FontEngine.PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes");
			FontEngine.GetAllLigatureSubstitutionRecordsDelegateField = IL2CPP.ResolveICall<FontEngine.GetAllLigatureSubstitutionRecordsDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetAllLigatureSubstitutionRecords");
			FontEngine.PopulateLigatureSubstitutionRecordMarshallingArrayDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateLigatureSubstitutionRecordMarshallingArrayDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateLigatureSubstitutionRecordMarshallingArray");
			FontEngine.PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndexDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex");
			FontEngine.GetLigatureSubstitutionRecordsFromMarshallingArrayDelegateField = IL2CPP.ResolveICall<FontEngine.GetLigatureSubstitutionRecordsFromMarshallingArrayDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetLigatureSubstitutionRecordsFromMarshallingArray");
			FontEngine.PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes");
			FontEngine.PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes");
			FontEngine.PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegateField = IL2CPP.ResolveICall<FontEngine.PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndex");
			FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegateField = IL2CPP.ResolveICall<FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes");
			FontEngine.PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexesDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexesDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes");
			FontEngine.GetSingleAdjustmentRecordsFromMarshallingArrayDelegateField = IL2CPP.ResolveICall<FontEngine.GetSingleAdjustmentRecordsFromMarshallingArrayDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetSingleAdjustmentRecordsFromMarshallingArray");
			FontEngine.GetPairAdjustmentRecordsDelegateField = IL2CPP.ResolveICall<FontEngine.GetPairAdjustmentRecordsDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetPairAdjustmentRecords");
			FontEngine.GetAllPairAdjustmentRecordsDelegateField = IL2CPP.ResolveICall<FontEngine.GetAllPairAdjustmentRecordsDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetAllPairAdjustmentRecords");
			FontEngine.PopulatePairAdjustmentRecordMarshallingArrayDelegateField = IL2CPP.ResolveICall<FontEngine.PopulatePairAdjustmentRecordMarshallingArrayDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulatePairAdjustmentRecordMarshallingArray");
			FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndexDelegateField = IL2CPP.ResolveICall<FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex");
			FontEngine.GetAllMarkToBaseAdjustmentRecordsDelegateField = IL2CPP.ResolveICall<FontEngine.GetAllMarkToBaseAdjustmentRecordsDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetAllMarkToBaseAdjustmentRecords");
			FontEngine.GetMarkToBaseAdjustmentRecordsDelegateField = IL2CPP.ResolveICall<FontEngine.GetMarkToBaseAdjustmentRecordsDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMarkToBaseAdjustmentRecords");
			FontEngine.PopulateMarkToBaseAdjustmentRecordMarshallingArrayDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateMarkToBaseAdjustmentRecordMarshallingArrayDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateMarkToBaseAdjustmentRecordMarshallingArray");
			FontEngine.PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndexDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex");
			FontEngine.GetMarkToBaseAdjustmentRecordsFromMarshallingArrayDelegateField = IL2CPP.ResolveICall<FontEngine.GetMarkToBaseAdjustmentRecordsFromMarshallingArrayDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMarkToBaseAdjustmentRecordsFromMarshallingArray");
			FontEngine.GetAllMarkToMarkAdjustmentRecordsDelegateField = IL2CPP.ResolveICall<FontEngine.GetAllMarkToMarkAdjustmentRecordsDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetAllMarkToMarkAdjustmentRecords");
			FontEngine.GetMarkToMarkAdjustmentRecordsDelegateField = IL2CPP.ResolveICall<FontEngine.GetMarkToMarkAdjustmentRecordsDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMarkToMarkAdjustmentRecords");
			FontEngine.PopulateMarkToMarkAdjustmentRecordMarshallingArrayDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateMarkToMarkAdjustmentRecordMarshallingArrayDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateMarkToMarkAdjustmentRecordMarshallingArray");
			FontEngine.PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndexDelegateField = IL2CPP.ResolveICall<FontEngine.PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex");
			FontEngine.GetMarkToMarkAdjustmentRecordsFromMarshallingArrayDelegateField = IL2CPP.ResolveICall<FontEngine.GetMarkToMarkAdjustmentRecordsFromMarshallingArrayDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMarkToMarkAdjustmentRecordsFromMarshallingArray");
			FontEngine.RenderBufferToTextureDelegateField = IL2CPP.ResolveICall<FontEngine.RenderBufferToTextureDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderBufferToTexture");
			FontEngine.RenderGlyphToTexture_Internal_InjectedDelegateField = IL2CPP.ResolveICall<FontEngine.RenderGlyphToTexture_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphToTexture_Internal_Injected");
			FontEngine.GetGlyphPairAdjustmentRecord_InjectedDelegateField = IL2CPP.ResolveICall<FontEngine.GetGlyphPairAdjustmentRecord_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetGlyphPairAdjustmentRecord_Injected");
			FontEngine.GetPairAdjustmentRecord_InjectedDelegateField = IL2CPP.ResolveICall<FontEngine.GetPairAdjustmentRecord_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetPairAdjustmentRecord_Injected");
			FontEngine.GetMarkToBaseAdjustmentRecord_InjectedDelegateField = IL2CPP.ResolveICall<FontEngine.GetMarkToBaseAdjustmentRecord_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMarkToBaseAdjustmentRecord_Injected");
			FontEngine.GetMarkToMarkAdjustmentRecord_InjectedDelegateField = IL2CPP.ResolveICall<FontEngine.GetMarkToMarkAdjustmentRecord_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMarkToMarkAdjustmentRecord_Injected");
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005788 File Offset: 0x00003988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252880, RefRangeEnd = 1252881, XrefRangeStart = 1252875, XrefRangeEnd = 1252880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontEngineError InitializeFontEngine()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_InitializeFontEngine_Public_Static_FontEngineError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000057B8 File Offset: 0x000039B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252881, XrefRangeEnd = 1252883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InitializeFontEngine_Internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_InitializeFontEngine_Internal_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000057E8 File Offset: 0x000039E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252888, RefRangeEnd = 1252889, XrefRangeStart = 1252883, XrefRangeEnd = 1252888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005848 File Offset: 0x00003A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252889, XrefRangeEnd = 1252891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_LoadFontFace_With_Size_And_FaceIndex_Internal_Private_Static_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000058A8 File Offset: 0x00003AA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1252896, RefRangeEnd = 1252903, XrefRangeStart = 1252891, XrefRangeEnd = 1252896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontEngineError LoadFontFace(Font font, int pointSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000058F8 File Offset: 0x00003AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252903, XrefRangeEnd = 1252905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_LoadFontFace_With_Size_FromFont_Internal_Private_Static_Int32_Font_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005948 File Offset: 0x00003B48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1252910, RefRangeEnd = 1252913, XrefRangeStart = 1252905, XrefRangeEnd = 1252910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000059A8 File Offset: 0x00003BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252913, XrefRangeEnd = 1252915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Private_Static_Int32_Font_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005A08 File Offset: 0x00003C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252920, RefRangeEnd = 1252921, XrefRangeStart = 1252915, XrefRangeEnd = 1252920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005A6C File Offset: 0x00003C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252921, XrefRangeEnd = 1252923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Private_Static_Int32_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005AD0 File Offset: 0x00003CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252966, RefRangeEnd = 1252967, XrefRangeStart = 1252923, XrefRangeEnd = 1252966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(styleName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Static_Boolean_String_String_byref_FontReference_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fontRef = ((intPtr4 == 0) ? null : new FontReference(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005B48 File Offset: 0x00003D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252967, XrefRangeEnd = 1252969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(styleName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Private_Static_Boolean_String_String_byref_FontReference_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fontRef = ((intPtr4 == 0) ? null : new FontReference(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00005BC0 File Offset: 0x00003DC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1252974, RefRangeEnd = 1252976, XrefRangeStart = 1252969, XrefRangeEnd = 1252974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FaceInfo GetFaceInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetFaceInfo_Public_Static_FaceInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new FaceInfo(intPtr);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005BEC File Offset: 0x00003DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252976, XrefRangeEnd = 1252978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFaceInfo_Internal(ref FaceInfo faceInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(faceInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetFaceInfo_Internal_Private_Static_Int32_byref_FaceInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005C30 File Offset: 0x00003E30
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1252980, RefRangeEnd = 1253000, XrefRangeStart = 1252978, XrefRangeEnd = 1252980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetGlyphIndex(uint unicode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetGlyphIndex_Internal_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005C70 File Offset: 0x00003E70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253011, RefRangeEnd = 1253013, XrefRangeStart = 1253000, XrefRangeEnd = 1253011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			glyph = ((intPtr4 == 0) ? null : new Glyph(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005CE0 File Offset: 0x00003EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253013, XrefRangeEnd = 1253015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &glyphStruct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005D3C File Offset: 0x00003F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253026, RefRangeEnd = 1253028, XrefRangeStart = 1253015, XrefRangeEnd = 1253026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			glyph = ((intPtr4 == 0) ? null : new Glyph(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005DAC File Offset: 0x00003FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253028, XrefRangeEnd = 1253030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &glyphStruct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005E08 File Offset: 0x00004008
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1253032, RefRangeEnd = 1253035, XrefRangeStart = 1253030, XrefRangeEnd = 1253032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTextureUploadMode(bool shouldUploadImmediately)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shouldUploadImmediately;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_SetTextureUploadMode_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005E3C File Offset: 0x0000403C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1253076, RefRangeEnd = 1253080, XrefRangeStart = 1253035, XrefRangeEnd = 1253076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(freeGlyphRects);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(usedGlyphRects);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Static_Boolean_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Glyph_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			glyph = ((intPtr4 == 0) ? null : new Glyph(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005F00 File Offset: 0x00004100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253080, XrefRangeEnd = 1253082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingMode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &freeGlyphRectCount;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &usedGlyphRectCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &glyph;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_byref_GlyphMarshallingStruct_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*freeGlyphRects = ((intPtr5 == 0) ? null : new Il2CppStructArray<GlyphRect>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*usedGlyphRects = ((intPtr6 == 0) ? null : new Il2CppStructArray<GlyphRect>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005FF0 File Offset: 0x000041F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1253199, RefRangeEnd = 1253205, XrefRangeStart = 1253082, XrefRangeEnd = 1253199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Il2CppReferenceArray<Glyph> glyphs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(freeGlyphRects);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(usedGlyphRects);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Static_Boolean_List_1_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Il2CppReferenceArray_1_Glyph_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			glyphs = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Glyph>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000060B8 File Offset: 0x000042B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253205, XrefRangeEnd = 1253207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAddGlyphsToTexture_Internal(Il2CppStructArray<uint> glyphIndex, int padding, GlyphPackingMode packingMode, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] Il2CppStructArray<GlyphMarshallingStruct> glyphs, ref int glyphCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingMode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &freeGlyphRectCount;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &usedGlyphRectCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &glyphCount;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Private_Static_Boolean_Il2CppStructArray_1_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_Il2CppStructArray_1_GlyphMarshallingStruct_byref_Int32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			*freeGlyphRects = ((intPtr6 == 0) ? null : new Il2CppStructArray<GlyphRect>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			*usedGlyphRects = ((intPtr7 == 0) ? null : new Il2CppStructArray<GlyphRect>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			*glyphs = ((intPtr8 == 0) ? null : new Il2CppStructArray<GlyphMarshallingStruct>(intPtr8));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000061D4 File Offset: 0x000043D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253223, RefRangeEnd = 1253225, XrefRangeStart = 1253207, XrefRangeEnd = 1253223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentTable(Il2CppStructArray<uint> glyphIndexes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetGlyphPairAdjustmentTable_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr3) : null;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006218 File Offset: 0x00004418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253246, RefRangeEnd = 1253248, XrefRangeStart = 1253225, XrefRangeEnd = 1253246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &recordCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetGlyphPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_List_1_UInt32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr3) : null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000626C File Offset: 0x0000446C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253248, XrefRangeEnd = 1253250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &recordCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000062BC File Offset: 0x000044BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253250, XrefRangeEnd = 1253252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPairAdjustmentRecordsFromMarshallingArray([Out] Il2CppStructArray<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetPairAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*glyphPairAdjustmentRecords = ((intPtr4 == 0) ? null : new Il2CppStructArray<GlyphPairAdjustmentRecord>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006310 File Offset: 0x00004510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1253260, RefRangeEnd = 1253261, XrefRangeStart = 1253252, XrefRangeEnd = 1253260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref Il2CppArrayBase<T> dstArray)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(srcList);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(dstArray);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FontEngine.MethodInfoStoreGeneric_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			srcList = ((intPtr5 == 0) ? null : new List<T>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			dstArray = ((intPtr6 == 0) ? null : new Il2CppArrayBase<T>(intPtr6));
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006384 File Offset: 0x00004584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253267, RefRangeEnd = 1253269, XrefRangeStart = 1253261, XrefRangeEnd = 1253267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMarshallingArraySize<T>(ref Il2CppArrayBase<T> marshallingArray, int recordCount)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(marshallingArray);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordCount;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.MethodInfoStoreGeneric_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			marshallingArray = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000063E0 File Offset: 0x000045E0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1253271, RefRangeEnd = 1253282, XrefRangeStart = 1253269, XrefRangeEnd = 1253271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetAtlasTexture(Texture2D texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_ResetAtlasTexture_Internal_Static_Void_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002492 File Offset: 0x00000692
		public FontEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00006418 File Offset: 0x00004618
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000249B File Offset: 0x0000069B
		public unsafe static Il2CppReferenceArray<Glyph> s_Glyphs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_Glyphs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Glyph>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_Glyphs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00006440 File Offset: 0x00004640
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000024AD File Offset: 0x000006AD
		public unsafe static Il2CppStructArray<uint> s_GlyphIndexes_MarshallingArray_A
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00006468 File Offset: 0x00004668
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000024BF File Offset: 0x000006BF
		public unsafe static Il2CppStructArray<GlyphMarshallingStruct> s_GlyphMarshallingStruct_IN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphMarshallingStruct>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00006490 File Offset: 0x00004690
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000024D1 File Offset: 0x000006D1
		public unsafe static Il2CppStructArray<GlyphMarshallingStruct> s_GlyphMarshallingStruct_OUT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphMarshallingStruct>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000064B8 File Offset: 0x000046B8
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000024E3 File Offset: 0x000006E3
		public unsafe static Il2CppStructArray<GlyphRect> s_FreeGlyphRects
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_FreeGlyphRects, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphRect>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_FreeGlyphRects, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000064E0 File Offset: 0x000046E0
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000024F5 File Offset: 0x000006F5
		public unsafe static Il2CppStructArray<GlyphRect> s_UsedGlyphRects
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_UsedGlyphRects, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphRect>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_UsedGlyphRects, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00006508 File Offset: 0x00004708
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002507 File Offset: 0x00000707
		public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> s_PairAdjustmentRecords_MarshallingArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00006530 File Offset: 0x00004730
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002519 File Offset: 0x00000719
		public unsafe static Dictionary<uint, Glyph> s_GlyphLookupDictionary
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_GlyphLookupDictionary, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_GlyphLookupDictionary, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00006558 File Offset: 0x00004758
		public static FontEngineError DestroyFontEngine()
		{
			return (FontEngineError)FontEngine.DestroyFontEngine_Internal();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000252B File Offset: 0x0000072B
		public static int DestroyFontEngine_Internal()
		{
			return FontEngine.DestroyFontEngine_InternalDelegateField();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002537 File Offset: 0x00000737
		public static void SendCancellationRequest()
		{
			FontEngine.SendCancellationRequest_Internal();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002540 File Offset: 0x00000740
		public static void SendCancellationRequest_Internal()
		{
			FontEngine.SendCancellationRequest_InternalDelegateField();
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000254C File Offset: 0x0000074C
		public static bool isProcessingDone
		{
			get
			{
				return FontEngine.get_isProcessingDoneDelegateField();
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00002558 File Offset: 0x00000758
		public static float generationProgress
		{
			get
			{
				return FontEngine.get_generationProgressDelegateField();
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00006570 File Offset: 0x00004770
		public static FontEngineError LoadFontFace(string filePath)
		{
			return (FontEngineError)FontEngine.LoadFontFace_Internal(filePath);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002564 File Offset: 0x00000764
		public static int LoadFontFace_Internal(string filePath)
		{
			return FontEngine.LoadFontFace_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(filePath));
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00006588 File Offset: 0x00004788
		public static FontEngineError LoadFontFace(string filePath, int pointSize)
		{
			return (FontEngineError)FontEngine.LoadFontFace_With_Size_Internal(filePath, pointSize);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002576 File Offset: 0x00000776
		public static int LoadFontFace_With_Size_Internal(string filePath, int pointSize)
		{
			return FontEngine.LoadFontFace_With_Size_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(filePath), pointSize);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000065A4 File Offset: 0x000047A4
		public static FontEngineError LoadFontFace(Il2CppStructArray<byte> sourceFontFile)
		{
			bool flag = sourceFontFile.Length == 0;
			FontEngineError fontEngineError;
			if (flag)
			{
				fontEngineError = FontEngineError.Invalid_File;
			}
			else
			{
				fontEngineError = (FontEngineError)FontEngine.LoadFontFace_FromSourceFontFile_Internal(sourceFontFile);
			}
			return fontEngineError;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002589 File Offset: 0x00000789
		public static int LoadFontFace_FromSourceFontFile_Internal(Il2CppStructArray<byte> sourceFontFile)
		{
			return FontEngine.LoadFontFace_FromSourceFontFile_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sourceFontFile));
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000065D0 File Offset: 0x000047D0
		public static FontEngineError LoadFontFace(Il2CppStructArray<byte> sourceFontFile, int pointSize)
		{
			bool flag = sourceFontFile.Length == 0;
			FontEngineError fontEngineError;
			if (flag)
			{
				fontEngineError = FontEngineError.Invalid_File;
			}
			else
			{
				fontEngineError = (FontEngineError)FontEngine.LoadFontFace_With_Size_FromSourceFontFile_Internal(sourceFontFile, pointSize);
			}
			return fontEngineError;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000259B File Offset: 0x0000079B
		public static int LoadFontFace_With_Size_FromSourceFontFile_Internal(Il2CppStructArray<byte> sourceFontFile, int pointSize)
		{
			return FontEngine.LoadFontFace_With_Size_FromSourceFontFile_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sourceFontFile), pointSize);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000065FC File Offset: 0x000047FC
		public static FontEngineError LoadFontFace(Il2CppStructArray<byte> sourceFontFile, int pointSize, int faceIndex)
		{
			bool flag = sourceFontFile.Length == 0;
			FontEngineError fontEngineError;
			if (flag)
			{
				fontEngineError = FontEngineError.Invalid_File;
			}
			else
			{
				fontEngineError = (FontEngineError)FontEngine.LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal(sourceFontFile, pointSize, faceIndex);
			}
			return fontEngineError;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000025AE File Offset: 0x000007AE
		public static int LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal(Il2CppStructArray<byte> sourceFontFile, int pointSize, int faceIndex)
		{
			return FontEngine.LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sourceFontFile), pointSize, faceIndex);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00006628 File Offset: 0x00004828
		public static FontEngineError LoadFontFace(Font font)
		{
			return (FontEngineError)FontEngine.LoadFontFace_FromFont_Internal(font);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000025C2 File Offset: 0x000007C2
		public static int LoadFontFace_FromFont_Internal(Font font)
		{
			return FontEngine.LoadFontFace_FromFont_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(font));
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00006640 File Offset: 0x00004840
		public static FontEngineError LoadFontFace(string familyName, string styleName)
		{
			return (FontEngineError)FontEngine.LoadFontFace_by_FamilyName_and_StyleName_Internal(familyName, styleName);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000025D4 File Offset: 0x000007D4
		public static int LoadFontFace_by_FamilyName_and_StyleName_Internal(string familyName, string styleName)
		{
			return FontEngine.LoadFontFace_by_FamilyName_and_StyleName_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(familyName), IL2CPP.ManagedStringToIl2Cpp(styleName));
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000665C File Offset: 0x0000485C
		public static FontEngineError UnloadFontFace()
		{
			return (FontEngineError)FontEngine.UnloadFontFace_Internal();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000025EC File Offset: 0x000007EC
		public static int UnloadFontFace_Internal()
		{
			return FontEngine.UnloadFontFace_InternalDelegateField();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006674 File Offset: 0x00004874
		public static FontEngineError UnloadAllFontFaces()
		{
			return (FontEngineError)FontEngine.UnloadAllFontFaces_Internal();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000025F8 File Offset: 0x000007F8
		public static int UnloadAllFontFaces_Internal()
		{
			return FontEngine.UnloadAllFontFaces_InternalDelegateField();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000668C File Offset: 0x0000488C
		public static Il2CppStringArray GetSystemFontNames()
		{
			Il2CppStringArray systemFontNames_Internal = FontEngine.GetSystemFontNames_Internal();
			bool flag = systemFontNames_Internal != null && systemFontNames_Internal.Length == 0;
			Il2CppStringArray il2CppStringArray;
			if (flag)
			{
				il2CppStringArray = null;
			}
			else
			{
				il2CppStringArray = systemFontNames_Internal;
			}
			return il2CppStringArray;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000066BC File Offset: 0x000048BC
		public static Il2CppStringArray GetSystemFontNames_Internal()
		{
			IntPtr intPtr = FontEngine.GetSystemFontNames_InternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000066E4 File Offset: 0x000048E4
		public static Il2CppReferenceArray<FontReference> GetSystemFontReferences()
		{
			IntPtr intPtr = FontEngine.GetSystemFontReferencesDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FontReference>>(intPtr2) : null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000670C File Offset: 0x0000490C
		public static FontEngineError SetFaceSize(int pointSize)
		{
			return (FontEngineError)FontEngine.SetFaceSize_Internal(pointSize);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002604 File Offset: 0x00000804
		public static int SetFaceSize_Internal(int pointSize)
		{
			return FontEngine.SetFaceSize_InternalDelegateField(pointSize);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002611 File Offset: 0x00000811
		public static int GetFaceCount()
		{
			return FontEngine.GetFaceCountDelegateField();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00006724 File Offset: 0x00004924
		public static Il2CppStringArray GetFontFaces()
		{
			Il2CppStringArray fontFaces_Internal = FontEngine.GetFontFaces_Internal();
			bool flag = fontFaces_Internal != null && fontFaces_Internal.Length == 0;
			Il2CppStringArray il2CppStringArray;
			if (flag)
			{
				il2CppStringArray = null;
			}
			else
			{
				il2CppStringArray = fontFaces_Internal;
			}
			return il2CppStringArray;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00006754 File Offset: 0x00004954
		public static Il2CppStringArray GetFontFaces_Internal()
		{
			IntPtr intPtr = FontEngine.GetFontFaces_InternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000261D File Offset: 0x0000081D
		public static uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode)
		{
			return FontEngine.GetVariantGlyphIndexDelegateField(unicode, variantSelectorUnicode);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000262B File Offset: 0x0000082B
		public static bool TryGetGlyphIndex(uint unicode, out uint glyphIndex)
		{
			return FontEngine.TryGetGlyphIndexDelegateField(unicode, out glyphIndex);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000677C File Offset: 0x0000497C
		public static FontEngineError LoadGlyph(uint unicode, GlyphLoadFlags flags)
		{
			return (FontEngineError)FontEngine.LoadGlyph_Internal(unicode, flags);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002639 File Offset: 0x00000839
		public static int LoadGlyph_Internal(uint unicode, GlyphLoadFlags loadFlags)
		{
			return FontEngine.LoadGlyph_InternalDelegateField(unicode, loadFlags);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002647 File Offset: 0x00000847
		public static bool TryPackGlyphInAtlas(Glyph glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006798 File Offset: 0x00004998
		public static bool TryPackGlyphInAtlas_Internal(ref GlyphMarshallingStruct glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount)
		{
			return FontEngine.TryPackGlyphInAtlas_InternalDelegateField(ref glyph, padding, packingMode, renderMode, width, height, IL2CPP.Il2CppObjectBaseToPtr(freeGlyphRects), ref freeGlyphRectCount, IL2CPP.Il2CppObjectBaseToPtr(usedGlyphRects), ref usedGlyphRectCount);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002654 File Offset: 0x00000854
		public static bool TryPackGlyphsInAtlas(List<Glyph> glyphsToAdd, List<Glyph> glyphsAdded, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000067CC File Offset: 0x000049CC
		public static bool TryPackGlyphsInAtlas_Internal([Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsToAdd, ref int glyphsToAddCount, [Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsAdded, ref int glyphsAddedCount, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount)
		{
			return FontEngine.TryPackGlyphsInAtlas_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphsToAdd), ref glyphsToAddCount, IL2CPP.Il2CppObjectBaseToPtr(glyphsAdded), ref glyphsAddedCount, padding, packingMode, renderMode, width, height, IL2CPP.Il2CppObjectBaseToPtr(freeGlyphRects), ref freeGlyphRectCount, IL2CPP.Il2CppObjectBaseToPtr(usedGlyphRects), ref usedGlyphRectCount);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00006810 File Offset: 0x00004A10
		public static FontEngineError RenderGlyphToTexture(Glyph glyph, int padding, GlyphRenderMode renderMode, Texture2D texture)
		{
			GlyphMarshallingStruct glyphMarshallingStruct = new GlyphMarshallingStruct(glyph);
			return (FontEngineError)FontEngine.RenderGlyphToTexture_Internal(glyphMarshallingStruct, padding, renderMode, texture);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002661 File Offset: 0x00000861
		public static int RenderGlyphToTexture_Internal(GlyphMarshallingStruct glyphStruct, int padding, GlyphRenderMode renderMode, Texture2D texture)
		{
			return FontEngine.RenderGlyphToTexture_Internal_Injected(ref glyphStruct, padding, renderMode, texture);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000266D File Offset: 0x0000086D
		public static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Texture2D texture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000267A File Offset: 0x0000087A
		public static int RenderGlyphsToTexture_Internal(Il2CppStructArray<GlyphMarshallingStruct> glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, Texture2D texture)
		{
			return FontEngine.RenderGlyphsToTexture_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphs), glyphCount, padding, renderMode, IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002696 File Offset: 0x00000896
		public static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Il2CppStructArray<byte> texBuffer, int texWidth, int texHeight)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000026A3 File Offset: 0x000008A3
		public static int RenderGlyphsToTextureBuffer_Internal(Il2CppStructArray<GlyphMarshallingStruct> glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, [Out] Il2CppStructArray<byte> texBuffer, int texWidth, int texHeight)
		{
			return FontEngine.RenderGlyphsToTextureBuffer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphs), glyphCount, padding, renderMode, IL2CPP.Il2CppObjectBaseToPtr(texBuffer), texWidth, texHeight);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000026C3 File Offset: 0x000008C3
		public static FontEngineError RenderGlyphsToSharedTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000026D0 File Offset: 0x000008D0
		public static int RenderGlyphsToSharedTexture_Internal(Il2CppStructArray<GlyphMarshallingStruct> glyphs, int glyphCount, int padding, GlyphRenderMode renderMode)
		{
			return FontEngine.RenderGlyphsToSharedTexture_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphs), glyphCount, padding, renderMode);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000026E5 File Offset: 0x000008E5
		public static void SetSharedTexture(Texture2D texture)
		{
			FontEngine.SetSharedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000026F7 File Offset: 0x000008F7
		public static void ReleaseSharedTexture()
		{
			FontEngine.ReleaseSharedTextureDelegateField();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002703 File Offset: 0x00000903
		public static bool TryAddGlyphsToTexture(List<Glyph> glyphsToAdd, List<Glyph> glyphsAdded, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006834 File Offset: 0x00004A34
		public static bool TryAddGlyphsToTexture_Internal_MultiThread([Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsToAdd, ref int glyphsToAddCount, [Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsAdded, ref int glyphsAddedCount, int padding, GlyphPackingMode packingMode, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture)
		{
			return FontEngine.TryAddGlyphsToTexture_Internal_MultiThreadDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphsToAdd), ref glyphsToAddCount, IL2CPP.Il2CppObjectBaseToPtr(glyphsAdded), ref glyphsAddedCount, padding, packingMode, IL2CPP.Il2CppObjectBaseToPtr(freeGlyphRects), ref freeGlyphRectCount, IL2CPP.Il2CppObjectBaseToPtr(usedGlyphRects), ref usedGlyphRectCount, renderMode, IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002710 File Offset: 0x00000910
		public static Il2CppStructArray<OpenTypeFeature> GetOpenTypeFontFeatureList()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002717 File Offset: 0x00000917
		public static int PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
		{
			return FontEngine.PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), lookupIndex, out recordCount);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00006878 File Offset: 0x00004A78
		public static Il2CppReferenceArray<MultipleSubstitutionRecord> GetAllMultipleSubstitutionRecords()
		{
			IntPtr intPtr = FontEngine.GetAllMultipleSubstitutionRecordsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MultipleSubstitutionRecord>>(intPtr2) : null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000272B File Offset: 0x0000092B
		public static Il2CppReferenceArray<MultipleSubstitutionRecord> GetMultipleSubstitutionRecords(int lookupIndex, uint glyphIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002738 File Offset: 0x00000938
		public static Il2CppReferenceArray<MultipleSubstitutionRecord> GetMultipleSubstitutionRecords(int lookupIndex, List<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002745 File Offset: 0x00000945
		public static Il2CppReferenceArray<MultipleSubstitutionRecord> GetMultipleSubstitutionRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002752 File Offset: 0x00000952
		public static int PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
		{
			return FontEngine.PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), lookupIndex, out recordCount);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002766 File Offset: 0x00000966
		public static int GetMultipleSubstitutionRecordsFromMarshallingArray([Out] Il2CppReferenceArray<MultipleSubstitutionRecord> substitutionRecords)
		{
			return FontEngine.GetMultipleSubstitutionRecordsFromMarshallingArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(substitutionRecords));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002778 File Offset: 0x00000978
		public static int PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
		{
			return FontEngine.PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), lookupIndex, out recordCount);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000068A0 File Offset: 0x00004AA0
		public static Il2CppReferenceArray<LigatureSubstitutionRecord> GetAllLigatureSubstitutionRecords()
		{
			IntPtr intPtr = FontEngine.GetAllLigatureSubstitutionRecordsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LigatureSubstitutionRecord>>(intPtr2) : null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000278C File Offset: 0x0000098C
		public static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(uint glyphIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002799 File Offset: 0x00000999
		public static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(List<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000027A6 File Offset: 0x000009A6
		public static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(int lookupIndex, uint glyphIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000027B3 File Offset: 0x000009B3
		public static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(int lookupIndex, List<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000027C0 File Offset: 0x000009C0
		public static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(Il2CppStructArray<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000027CD File Offset: 0x000009CD
		public static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000027DA File Offset: 0x000009DA
		public static int PopulateLigatureSubstitutionRecordMarshallingArray(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
		{
			return FontEngine.PopulateLigatureSubstitutionRecordMarshallingArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), out recordCount);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000027ED File Offset: 0x000009ED
		public static int PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
		{
			return FontEngine.PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), lookupIndex, out recordCount);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002801 File Offset: 0x00000A01
		public static int GetLigatureSubstitutionRecordsFromMarshallingArray([Out] Il2CppReferenceArray<LigatureSubstitutionRecord> ligatureSubstitutionRecords)
		{
			return FontEngine.GetLigatureSubstitutionRecordsFromMarshallingArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ligatureSubstitutionRecords));
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002813 File Offset: 0x00000A13
		public static int PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
		{
			return FontEngine.PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), lookupIndex, out recordCount);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002827 File Offset: 0x00000A27
		public static int PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
		{
			return FontEngine.PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), lookupIndex, out recordCount);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000283B File Offset: 0x00000A3B
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentRecords(uint glyphIndex, out int recordCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002848 File Offset: 0x00000A48
		public static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndex(uint glyphIndex, out int recordCount)
		{
			return FontEngine.PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegateField(glyphIndex, out recordCount);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002856 File Offset: 0x00000A56
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002863 File Offset: 0x00000A63
		public static int PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes(Il2CppStructArray<uint> newGlyphIndexes, Il2CppStructArray<uint> allGlyphIndexes, out int recordCount)
		{
			return FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(newGlyphIndexes), IL2CPP.Il2CppObjectBaseToPtr(allGlyphIndexes), out recordCount);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000068C8 File Offset: 0x00004AC8
		public static GlyphPairAdjustmentRecord GetGlyphPairAdjustmentRecord(uint firstGlyphIndex, uint secondGlyphIndex)
		{
			GlyphPairAdjustmentRecord glyphPairAdjustmentRecord;
			FontEngine.GetGlyphPairAdjustmentRecord_Injected(firstGlyphIndex, secondGlyphIndex, out glyphPairAdjustmentRecord);
			return glyphPairAdjustmentRecord;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000287C File Offset: 0x00000A7C
		public static Il2CppStructArray<GlyphAdjustmentRecord> GetSingleAdjustmentRecords(int lookupIndex, uint glyphIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002889 File Offset: 0x00000A89
		public static Il2CppStructArray<GlyphAdjustmentRecord> GetSingleAdjustmentRecords(int lookupIndex, List<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002896 File Offset: 0x00000A96
		public static Il2CppStructArray<GlyphAdjustmentRecord> GetSingleAdjustmentRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000028A3 File Offset: 0x00000AA3
		public static int PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
		{
			return FontEngine.PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), lookupIndex, out recordCount);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000028B7 File Offset: 0x00000AB7
		public static int GetSingleAdjustmentRecordsFromMarshallingArray([Out] Il2CppStructArray<GlyphAdjustmentRecord> singleSubstitutionRecords)
		{
			return FontEngine.GetSingleAdjustmentRecordsFromMarshallingArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(singleSubstitutionRecords));
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000068E0 File Offset: 0x00004AE0
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(uint glyphIndex)
		{
			IntPtr intPtr = FontEngine.GetPairAdjustmentRecordsDelegateField(glyphIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr2) : null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006908 File Offset: 0x00004B08
		public static GlyphPairAdjustmentRecord GetPairAdjustmentRecord(uint firstGlyphIndex, uint secondGlyphIndex)
		{
			GlyphPairAdjustmentRecord glyphPairAdjustmentRecord;
			FontEngine.GetPairAdjustmentRecord_Injected(firstGlyphIndex, secondGlyphIndex, out glyphPairAdjustmentRecord);
			return glyphPairAdjustmentRecord;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006920 File Offset: 0x00004B20
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetAllPairAdjustmentRecords()
		{
			IntPtr intPtr = FontEngine.GetAllPairAdjustmentRecordsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr2) : null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000028C9 File Offset: 0x00000AC9
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(List<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000028D6 File Offset: 0x00000AD6
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(int lookupIndex, uint glyphIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000028E3 File Offset: 0x00000AE3
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(int lookupIndex, List<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000028F0 File Offset: 0x00000AF0
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(Il2CppStructArray<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000028FD File Offset: 0x00000AFD
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000290A File Offset: 0x00000B0A
		public static int PopulatePairAdjustmentRecordMarshallingArray(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
		{
			return FontEngine.PopulatePairAdjustmentRecordMarshallingArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), out recordCount);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000291D File Offset: 0x00000B1D
		public static int PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
		{
			return FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), lookupIndex, out recordCount);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006948 File Offset: 0x00004B48
		public static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetAllMarkToBaseAdjustmentRecords()
		{
			IntPtr intPtr = FontEngine.GetAllMarkToBaseAdjustmentRecordsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToBaseAdjustmentRecord>>(intPtr2) : null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006970 File Offset: 0x00004B70
		public static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetMarkToBaseAdjustmentRecords(uint baseGlyphIndex)
		{
			IntPtr intPtr = FontEngine.GetMarkToBaseAdjustmentRecordsDelegateField(baseGlyphIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToBaseAdjustmentRecord>>(intPtr2) : null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006998 File Offset: 0x00004B98
		public static MarkToBaseAdjustmentRecord GetMarkToBaseAdjustmentRecord(uint baseGlyphIndex, uint markGlyphIndex)
		{
			MarkToBaseAdjustmentRecord markToBaseAdjustmentRecord;
			FontEngine.GetMarkToBaseAdjustmentRecord_Injected(baseGlyphIndex, markGlyphIndex, out markToBaseAdjustmentRecord);
			return markToBaseAdjustmentRecord;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002931 File Offset: 0x00000B31
		public static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetMarkToBaseAdjustmentRecords(List<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000293E File Offset: 0x00000B3E
		public static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetMarkToBaseAdjustmentRecords(int lookupIndex, List<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000294B File Offset: 0x00000B4B
		public static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetMarkToBaseAdjustmentRecords(Il2CppStructArray<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002958 File Offset: 0x00000B58
		public static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetMarkToBaseAdjustmentRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002965 File Offset: 0x00000B65
		public static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
		{
			return FontEngine.PopulateMarkToBaseAdjustmentRecordMarshallingArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), out recordCount);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002978 File Offset: 0x00000B78
		public static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
		{
			return FontEngine.PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), lookupIndex, out recordCount);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000298C File Offset: 0x00000B8C
		public static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray([Out] Il2CppStructArray<MarkToBaseAdjustmentRecord> adjustmentRecords)
		{
			return FontEngine.GetMarkToBaseAdjustmentRecordsFromMarshallingArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(adjustmentRecords));
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000069B0 File Offset: 0x00004BB0
		public static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetAllMarkToMarkAdjustmentRecords()
		{
			IntPtr intPtr = FontEngine.GetAllMarkToMarkAdjustmentRecordsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToMarkAdjustmentRecord>>(intPtr2) : null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000069D8 File Offset: 0x00004BD8
		public static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetMarkToMarkAdjustmentRecords(uint baseMarkGlyphIndex)
		{
			IntPtr intPtr = FontEngine.GetMarkToMarkAdjustmentRecordsDelegateField(baseMarkGlyphIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToMarkAdjustmentRecord>>(intPtr2) : null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006A00 File Offset: 0x00004C00
		public static MarkToMarkAdjustmentRecord GetMarkToMarkAdjustmentRecord(uint firstGlyphIndex, uint secondGlyphIndex)
		{
			MarkToMarkAdjustmentRecord markToMarkAdjustmentRecord;
			FontEngine.GetMarkToMarkAdjustmentRecord_Injected(firstGlyphIndex, secondGlyphIndex, out markToMarkAdjustmentRecord);
			return markToMarkAdjustmentRecord;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000299E File Offset: 0x00000B9E
		public static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetMarkToMarkAdjustmentRecords(List<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000029AB File Offset: 0x00000BAB
		public static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetMarkToMarkAdjustmentRecords(int lookupIndex, List<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000029B8 File Offset: 0x00000BB8
		public static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetMarkToMarkAdjustmentRecords(Il2CppStructArray<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000029C5 File Offset: 0x00000BC5
		public static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetMarkToMarkAdjustmentRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000029D2 File Offset: 0x00000BD2
		public static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
		{
			return FontEngine.PopulateMarkToMarkAdjustmentRecordMarshallingArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), out recordCount);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000029E5 File Offset: 0x00000BE5
		public static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
		{
			return FontEngine.PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), lookupIndex, out recordCount);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000029F9 File Offset: 0x00000BF9
		public static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray([Out] Il2CppStructArray<MarkToMarkAdjustmentRecord> adjustmentRecords)
		{
			return FontEngine.GetMarkToMarkAdjustmentRecordsFromMarshallingArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(adjustmentRecords));
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002A0B File Offset: 0x00000C0B
		public static void GlyphIndexToMarshallingArray(uint glyphIndex, ref Il2CppStructArray<uint> dstArray)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002A18 File Offset: 0x00000C18
		public static void RenderBufferToTexture(Texture2D srcTexture, int padding, GlyphRenderMode renderMode, Texture2D dstTexture)
		{
			FontEngine.RenderBufferToTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(srcTexture), padding, renderMode, IL2CPP.Il2CppObjectBaseToPtr(dstTexture));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002A32 File Offset: 0x00000C32
		public static int RenderGlyphToTexture_Internal_Injected(ref GlyphMarshallingStruct glyphStruct, int padding, GlyphRenderMode renderMode, Texture2D texture)
		{
			return FontEngine.RenderGlyphToTexture_Internal_InjectedDelegateField(ref glyphStruct, padding, renderMode, IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002A47 File Offset: 0x00000C47
		public static void GetGlyphPairAdjustmentRecord_Injected(uint firstGlyphIndex, uint secondGlyphIndex, out GlyphPairAdjustmentRecord ret)
		{
			FontEngine.GetGlyphPairAdjustmentRecord_InjectedDelegateField(firstGlyphIndex, secondGlyphIndex, out ret);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002A56 File Offset: 0x00000C56
		public static void GetPairAdjustmentRecord_Injected(uint firstGlyphIndex, uint secondGlyphIndex, out GlyphPairAdjustmentRecord ret)
		{
			FontEngine.GetPairAdjustmentRecord_InjectedDelegateField(firstGlyphIndex, secondGlyphIndex, out ret);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002A65 File Offset: 0x00000C65
		public static void GetMarkToBaseAdjustmentRecord_Injected(uint baseGlyphIndex, uint markGlyphIndex, out MarkToBaseAdjustmentRecord ret)
		{
			FontEngine.GetMarkToBaseAdjustmentRecord_InjectedDelegateField(baseGlyphIndex, markGlyphIndex, out ret);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002A74 File Offset: 0x00000C74
		public static void GetMarkToMarkAdjustmentRecord_Injected(uint firstGlyphIndex, uint secondGlyphIndex, out MarkToMarkAdjustmentRecord ret)
		{
			FontEngine.GetMarkToMarkAdjustmentRecord_InjectedDelegateField(firstGlyphIndex, secondGlyphIndex, out ret);
		}

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_s_Glyphs;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_s_FreeGlyphRects;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_s_UsedGlyphRects;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_s_GlyphLookupDictionary;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFontEngine_Public_Static_FontEngineError_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFontEngine_Internal_Private_Static_Int32_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_Int32_Int32_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_And_FaceIndex_Internal_Private_Static_Int32_String_Int32_Int32_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Int32_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_FromFont_Internal_Private_Static_Int32_Font_Int32_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Int32_Int32_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Private_Static_Int32_Font_Int32_Int32_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_String_Int32_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Private_Static_Int32_String_String_Int32_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Static_Boolean_String_String_byref_FontReference_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Private_Static_Boolean_String_String_byref_FontReference_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_GetFaceInfo_Public_Static_FaceInfo_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_GetFaceInfo_Internal_Private_Static_Int32_byref_FaceInfo_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphIndex_Internal_Static_UInt32_UInt32_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureUploadMode_Internal_Static_Void_Boolean_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Static_Boolean_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Glyph_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_byref_GlyphMarshallingStruct_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Static_Boolean_List_1_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Il2CppReferenceArray_1_Glyph_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Private_Static_Boolean_Il2CppStructArray_1_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_Il2CppStructArray_1_GlyphMarshallingStruct_byref_Int32_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphPairAdjustmentTable_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_List_1_UInt32_byref_Int32_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_GetPairAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_ResetAtlasTexture_Internal_Static_Void_Texture2D_0;

		// Token: 0x040000D4 RID: 212
		private static readonly FontEngine.DestroyFontEngine_InternalDelegate DestroyFontEngine_InternalDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly FontEngine.SendCancellationRequest_InternalDelegate SendCancellationRequest_InternalDelegateField;

		// Token: 0x040000D6 RID: 214
		private static readonly FontEngine.get_isProcessingDoneDelegate get_isProcessingDoneDelegateField;

		// Token: 0x040000D7 RID: 215
		private static readonly FontEngine.get_generationProgressDelegate get_generationProgressDelegateField;

		// Token: 0x040000D8 RID: 216
		private static readonly FontEngine.LoadFontFace_InternalDelegate LoadFontFace_InternalDelegateField;

		// Token: 0x040000D9 RID: 217
		private static readonly FontEngine.LoadFontFace_With_Size_InternalDelegate LoadFontFace_With_Size_InternalDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly FontEngine.LoadFontFace_FromSourceFontFile_InternalDelegate LoadFontFace_FromSourceFontFile_InternalDelegateField;

		// Token: 0x040000DB RID: 219
		private static readonly FontEngine.LoadFontFace_With_Size_FromSourceFontFile_InternalDelegate LoadFontFace_With_Size_FromSourceFontFile_InternalDelegateField;

		// Token: 0x040000DC RID: 220
		private static readonly FontEngine.LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegate LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegateField;

		// Token: 0x040000DD RID: 221
		private static readonly FontEngine.LoadFontFace_FromFont_InternalDelegate LoadFontFace_FromFont_InternalDelegateField;

		// Token: 0x040000DE RID: 222
		private static readonly FontEngine.LoadFontFace_by_FamilyName_and_StyleName_InternalDelegate LoadFontFace_by_FamilyName_and_StyleName_InternalDelegateField;

		// Token: 0x040000DF RID: 223
		private static readonly FontEngine.UnloadFontFace_InternalDelegate UnloadFontFace_InternalDelegateField;

		// Token: 0x040000E0 RID: 224
		private static readonly FontEngine.UnloadAllFontFaces_InternalDelegate UnloadAllFontFaces_InternalDelegateField;

		// Token: 0x040000E1 RID: 225
		private static readonly FontEngine.GetSystemFontNames_InternalDelegate GetSystemFontNames_InternalDelegateField;

		// Token: 0x040000E2 RID: 226
		private static readonly FontEngine.GetSystemFontReferencesDelegate GetSystemFontReferencesDelegateField;

		// Token: 0x040000E3 RID: 227
		private static readonly FontEngine.SetFaceSize_InternalDelegate SetFaceSize_InternalDelegateField;

		// Token: 0x040000E4 RID: 228
		private static readonly FontEngine.GetFaceCountDelegate GetFaceCountDelegateField;

		// Token: 0x040000E5 RID: 229
		private static readonly FontEngine.GetFontFaces_InternalDelegate GetFontFaces_InternalDelegateField;

		// Token: 0x040000E6 RID: 230
		private static readonly FontEngine.GetVariantGlyphIndexDelegate GetVariantGlyphIndexDelegateField;

		// Token: 0x040000E7 RID: 231
		private static readonly FontEngine.TryGetGlyphIndexDelegate TryGetGlyphIndexDelegateField;

		// Token: 0x040000E8 RID: 232
		private static readonly FontEngine.LoadGlyph_InternalDelegate LoadGlyph_InternalDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly FontEngine.TryPackGlyphInAtlas_InternalDelegate TryPackGlyphInAtlas_InternalDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly FontEngine.TryPackGlyphsInAtlas_InternalDelegate TryPackGlyphsInAtlas_InternalDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly FontEngine.RenderGlyphsToTexture_InternalDelegate RenderGlyphsToTexture_InternalDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly FontEngine.RenderGlyphsToTextureBuffer_InternalDelegate RenderGlyphsToTextureBuffer_InternalDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly FontEngine.RenderGlyphsToSharedTexture_InternalDelegate RenderGlyphsToSharedTexture_InternalDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly FontEngine.SetSharedTextureDelegate SetSharedTextureDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly FontEngine.ReleaseSharedTextureDelegate ReleaseSharedTextureDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly FontEngine.TryAddGlyphsToTexture_Internal_MultiThreadDelegate TryAddGlyphsToTexture_Internal_MultiThreadDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly FontEngine.PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly FontEngine.GetAllMultipleSubstitutionRecordsDelegate GetAllMultipleSubstitutionRecordsDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly FontEngine.PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly FontEngine.GetMultipleSubstitutionRecordsFromMarshallingArrayDelegate GetMultipleSubstitutionRecordsFromMarshallingArrayDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly FontEngine.PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField;

		// Token: 0x040000F6 RID: 246
		private static readonly FontEngine.GetAllLigatureSubstitutionRecordsDelegate GetAllLigatureSubstitutionRecordsDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly FontEngine.PopulateLigatureSubstitutionRecordMarshallingArrayDelegate PopulateLigatureSubstitutionRecordMarshallingArrayDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly FontEngine.PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndexDelegate PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndexDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly FontEngine.GetLigatureSubstitutionRecordsFromMarshallingArrayDelegate GetLigatureSubstitutionRecordsFromMarshallingArrayDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly FontEngine.PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly FontEngine.PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly FontEngine.PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegate PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegate PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly FontEngine.PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexesDelegate PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexesDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly FontEngine.GetSingleAdjustmentRecordsFromMarshallingArrayDelegate GetSingleAdjustmentRecordsFromMarshallingArrayDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly FontEngine.GetPairAdjustmentRecordsDelegate GetPairAdjustmentRecordsDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly FontEngine.GetAllPairAdjustmentRecordsDelegate GetAllPairAdjustmentRecordsDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly FontEngine.PopulatePairAdjustmentRecordMarshallingArrayDelegate PopulatePairAdjustmentRecordMarshallingArrayDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndexDelegate PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndexDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly FontEngine.GetAllMarkToBaseAdjustmentRecordsDelegate GetAllMarkToBaseAdjustmentRecordsDelegateField;

		// Token: 0x04000105 RID: 261
		private static readonly FontEngine.GetMarkToBaseAdjustmentRecordsDelegate GetMarkToBaseAdjustmentRecordsDelegateField;

		// Token: 0x04000106 RID: 262
		private static readonly FontEngine.PopulateMarkToBaseAdjustmentRecordMarshallingArrayDelegate PopulateMarkToBaseAdjustmentRecordMarshallingArrayDelegateField;

		// Token: 0x04000107 RID: 263
		private static readonly FontEngine.PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndexDelegate PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndexDelegateField;

		// Token: 0x04000108 RID: 264
		private static readonly FontEngine.GetMarkToBaseAdjustmentRecordsFromMarshallingArrayDelegate GetMarkToBaseAdjustmentRecordsFromMarshallingArrayDelegateField;

		// Token: 0x04000109 RID: 265
		private static readonly FontEngine.GetAllMarkToMarkAdjustmentRecordsDelegate GetAllMarkToMarkAdjustmentRecordsDelegateField;

		// Token: 0x0400010A RID: 266
		private static readonly FontEngine.GetMarkToMarkAdjustmentRecordsDelegate GetMarkToMarkAdjustmentRecordsDelegateField;

		// Token: 0x0400010B RID: 267
		private static readonly FontEngine.PopulateMarkToMarkAdjustmentRecordMarshallingArrayDelegate PopulateMarkToMarkAdjustmentRecordMarshallingArrayDelegateField;

		// Token: 0x0400010C RID: 268
		private static readonly FontEngine.PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndexDelegate PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndexDelegateField;

		// Token: 0x0400010D RID: 269
		private static readonly FontEngine.GetMarkToMarkAdjustmentRecordsFromMarshallingArrayDelegate GetMarkToMarkAdjustmentRecordsFromMarshallingArrayDelegateField;

		// Token: 0x0400010E RID: 270
		private static readonly FontEngine.RenderBufferToTextureDelegate RenderBufferToTextureDelegateField;

		// Token: 0x0400010F RID: 271
		private static readonly FontEngine.RenderGlyphToTexture_Internal_InjectedDelegate RenderGlyphToTexture_Internal_InjectedDelegateField;

		// Token: 0x04000110 RID: 272
		private static readonly FontEngine.GetGlyphPairAdjustmentRecord_InjectedDelegate GetGlyphPairAdjustmentRecord_InjectedDelegateField;

		// Token: 0x04000111 RID: 273
		private static readonly FontEngine.GetPairAdjustmentRecord_InjectedDelegate GetPairAdjustmentRecord_InjectedDelegateField;

		// Token: 0x04000112 RID: 274
		private static readonly FontEngine.GetMarkToBaseAdjustmentRecord_InjectedDelegate GetMarkToBaseAdjustmentRecord_InjectedDelegateField;

		// Token: 0x04000113 RID: 275
		private static readonly FontEngine.GetMarkToMarkAdjustmentRecord_InjectedDelegate GetMarkToMarkAdjustmentRecord_InjectedDelegateField;

		// Token: 0x0200001E RID: 30
		private sealed class MethodInfoStoreGeneric_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x0400019E RID: 414
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FontEngine.NativeMethodInfoPtr_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<FontEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001F RID: 31
		private sealed class MethodInfoStoreGeneric_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x0400019F RID: 415
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FontEngine.NativeMethodInfoPtr_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<FontEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate int DestroyFontEngine_InternalDelegate();

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate void SendCancellationRequest_InternalDelegate();

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate bool get_isProcessingDoneDelegate();

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate float get_generationProgressDelegate();

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate int LoadFontFace_InternalDelegate(IntPtr filePath);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate int LoadFontFace_With_Size_InternalDelegate(IntPtr filePath, int pointSize);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate int LoadFontFace_FromSourceFontFile_InternalDelegate(IntPtr sourceFontFile);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate int LoadFontFace_With_Size_FromSourceFontFile_InternalDelegate(IntPtr sourceFontFile, int pointSize);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate int LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegate(IntPtr sourceFontFile, int pointSize, int faceIndex);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate int LoadFontFace_FromFont_InternalDelegate(IntPtr font);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate int LoadFontFace_by_FamilyName_and_StyleName_InternalDelegate(IntPtr familyName, IntPtr styleName);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060001D2 RID: 466
		private delegate int UnloadFontFace_InternalDelegate();

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060001D4 RID: 468
		private delegate int UnloadAllFontFaces_InternalDelegate();

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x060001D6 RID: 470
		private delegate IntPtr GetSystemFontNames_InternalDelegate();

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x060001D8 RID: 472
		private delegate IntPtr GetSystemFontReferencesDelegate();

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060001DA RID: 474
		private delegate int SetFaceSize_InternalDelegate(int pointSize);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060001DC RID: 476
		private delegate int GetFaceCountDelegate();

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x060001DE RID: 478
		private delegate IntPtr GetFontFaces_InternalDelegate();

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060001E0 RID: 480
		private delegate uint GetVariantGlyphIndexDelegate(uint unicode, uint variantSelectorUnicode);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060001E2 RID: 482
		private delegate bool TryGetGlyphIndexDelegate(uint unicode, [Out] IntPtr glyphIndex);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x060001E4 RID: 484
		private delegate int LoadGlyph_InternalDelegate(uint unicode, GlyphLoadFlags loadFlags);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060001E6 RID: 486
		private delegate bool TryPackGlyphInAtlas_InternalDelegate(IntPtr glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] IntPtr freeGlyphRects, IntPtr freeGlyphRectCount, [Out] IntPtr usedGlyphRects, IntPtr usedGlyphRectCount);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x060001E8 RID: 488
		private delegate bool TryPackGlyphsInAtlas_InternalDelegate([Out] IntPtr glyphsToAdd, IntPtr glyphsToAddCount, [Out] IntPtr glyphsAdded, IntPtr glyphsAddedCount, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] IntPtr freeGlyphRects, IntPtr freeGlyphRectCount, [Out] IntPtr usedGlyphRects, IntPtr usedGlyphRectCount);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x060001EA RID: 490
		private delegate int RenderGlyphsToTexture_InternalDelegate(IntPtr glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, IntPtr texture);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x060001EC RID: 492
		private delegate int RenderGlyphsToTextureBuffer_InternalDelegate(IntPtr glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, [Out] IntPtr texBuffer, int texWidth, int texHeight);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x060001EE RID: 494
		private delegate int RenderGlyphsToSharedTexture_InternalDelegate(IntPtr glyphs, int glyphCount, int padding, GlyphRenderMode renderMode);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x060001F0 RID: 496
		private delegate void SetSharedTextureDelegate(IntPtr texture);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060001F2 RID: 498
		private delegate void ReleaseSharedTextureDelegate();

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x060001F4 RID: 500
		private delegate bool TryAddGlyphsToTexture_Internal_MultiThreadDelegate([Out] IntPtr glyphsToAdd, IntPtr glyphsToAddCount, [Out] IntPtr glyphsAdded, IntPtr glyphsAddedCount, int padding, GlyphPackingMode packingMode, [Out] IntPtr freeGlyphRects, IntPtr freeGlyphRectCount, [Out] IntPtr usedGlyphRects, IntPtr usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060001F6 RID: 502
		private delegate int PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate(IntPtr glyphIndexes, int lookupIndex, [Out] IntPtr recordCount);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060001F8 RID: 504
		private delegate IntPtr GetAllMultipleSubstitutionRecordsDelegate();

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060001FA RID: 506
		private delegate int PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate(IntPtr glyphIndexes, int lookupIndex, [Out] IntPtr recordCount);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060001FC RID: 508
		private delegate int GetMultipleSubstitutionRecordsFromMarshallingArrayDelegate([Out] IntPtr substitutionRecords);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060001FE RID: 510
		private delegate int PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate(IntPtr glyphIndexes, int lookupIndex, [Out] IntPtr recordCount);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000200 RID: 512
		private delegate IntPtr GetAllLigatureSubstitutionRecordsDelegate();

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000202 RID: 514
		private delegate int PopulateLigatureSubstitutionRecordMarshallingArrayDelegate(IntPtr glyphIndexes, [Out] IntPtr recordCount);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000204 RID: 516
		private delegate int PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndexDelegate(IntPtr glyphIndexes, int lookupIndex, [Out] IntPtr recordCount);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000206 RID: 518
		private delegate int GetLigatureSubstitutionRecordsFromMarshallingArrayDelegate([Out] IntPtr ligatureSubstitutionRecords);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000208 RID: 520
		private delegate int PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate(IntPtr glyphIndexes, int lookupIndex, [Out] IntPtr recordCount);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600020A RID: 522
		private delegate int PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexesDelegate(IntPtr glyphIndexes, int lookupIndex, [Out] IntPtr recordCount);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600020C RID: 524
		private delegate int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegate(uint glyphIndex, [Out] IntPtr recordCount);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600020E RID: 526
		private delegate int PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegate(IntPtr newGlyphIndexes, IntPtr allGlyphIndexes, [Out] IntPtr recordCount);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000210 RID: 528
		private delegate int PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexesDelegate(IntPtr glyphIndexes, int lookupIndex, [Out] IntPtr recordCount);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000212 RID: 530
		private delegate int GetSingleAdjustmentRecordsFromMarshallingArrayDelegate([Out] IntPtr singleSubstitutionRecords);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000214 RID: 532
		private delegate IntPtr GetPairAdjustmentRecordsDelegate(uint glyphIndex);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000216 RID: 534
		private delegate IntPtr GetAllPairAdjustmentRecordsDelegate();

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000218 RID: 536
		private delegate int PopulatePairAdjustmentRecordMarshallingArrayDelegate(IntPtr glyphIndexes, [Out] IntPtr recordCount);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x0600021A RID: 538
		private delegate int PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndexDelegate(IntPtr glyphIndexes, int lookupIndex, [Out] IntPtr recordCount);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x0600021C RID: 540
		private delegate IntPtr GetAllMarkToBaseAdjustmentRecordsDelegate();

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600021E RID: 542
		private delegate IntPtr GetMarkToBaseAdjustmentRecordsDelegate(uint baseGlyphIndex);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000220 RID: 544
		private delegate int PopulateMarkToBaseAdjustmentRecordMarshallingArrayDelegate(IntPtr glyphIndexes, [Out] IntPtr recordCount);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000222 RID: 546
		private delegate int PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndexDelegate(IntPtr glyphIndexes, int lookupIndex, [Out] IntPtr recordCount);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000224 RID: 548
		private delegate int GetMarkToBaseAdjustmentRecordsFromMarshallingArrayDelegate([Out] IntPtr adjustmentRecords);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000226 RID: 550
		private delegate IntPtr GetAllMarkToMarkAdjustmentRecordsDelegate();

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000228 RID: 552
		private delegate IntPtr GetMarkToMarkAdjustmentRecordsDelegate(uint baseMarkGlyphIndex);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x0600022A RID: 554
		private delegate int PopulateMarkToMarkAdjustmentRecordMarshallingArrayDelegate(IntPtr glyphIndexes, [Out] IntPtr recordCount);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600022C RID: 556
		private delegate int PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndexDelegate(IntPtr glyphIndexes, int lookupIndex, [Out] IntPtr recordCount);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600022E RID: 558
		private delegate int GetMarkToMarkAdjustmentRecordsFromMarshallingArrayDelegate([Out] IntPtr adjustmentRecords);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000230 RID: 560
		private delegate void RenderBufferToTextureDelegate(IntPtr srcTexture, int padding, GlyphRenderMode renderMode, IntPtr dstTexture);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000232 RID: 562
		private delegate int RenderGlyphToTexture_Internal_InjectedDelegate(IntPtr glyphStruct, int padding, GlyphRenderMode renderMode, IntPtr texture);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000234 RID: 564
		private delegate void GetGlyphPairAdjustmentRecord_InjectedDelegate(uint firstGlyphIndex, uint secondGlyphIndex, [Out] IntPtr ret);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000236 RID: 566
		private delegate void GetPairAdjustmentRecord_InjectedDelegate(uint firstGlyphIndex, uint secondGlyphIndex, [Out] IntPtr ret);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000238 RID: 568
		private delegate void GetMarkToBaseAdjustmentRecord_InjectedDelegate(uint baseGlyphIndex, uint markGlyphIndex, [Out] IntPtr ret);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x0600023A RID: 570
		private delegate void GetMarkToMarkAdjustmentRecord_InjectedDelegate(uint firstGlyphIndex, uint secondGlyphIndex, [Out] IntPtr ret);
	}
}
