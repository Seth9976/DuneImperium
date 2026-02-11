using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200000D RID: 13
	public class TextMeshPro : TMP_Text
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		// Note: this type is marked as 'beforefieldinit'.
		static TextMeshPro()
		{
			Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TextMeshPro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr);
			TextMeshPro.NativeFieldInfoPtr__SortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "_SortingLayer");
			TextMeshPro.NativeFieldInfoPtr__SortingLayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "_SortingLayerID");
			TextMeshPro.NativeFieldInfoPtr__SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "_SortingOrder");
			TextMeshPro.NativeFieldInfoPtr_OnPreRenderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "OnPreRenderText");
			TextMeshPro.NativeFieldInfoPtr_m_currentAutoSizeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_currentAutoSizeMode");
			TextMeshPro.NativeFieldInfoPtr_m_hasFontAssetChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_hasFontAssetChanged");
			TextMeshPro.NativeFieldInfoPtr_m_previousLossyScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_previousLossyScaleY");
			TextMeshPro.NativeFieldInfoPtr_m_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_renderer");
			TextMeshPro.NativeFieldInfoPtr_m_meshFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_meshFilter");
			TextMeshPro.NativeFieldInfoPtr_m_isFirstAllocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_isFirstAllocation");
			TextMeshPro.NativeFieldInfoPtr_m_max_characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_max_characters");
			TextMeshPro.NativeFieldInfoPtr_m_max_numberOfLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_max_numberOfLines");
			TextMeshPro.NativeFieldInfoPtr_m_subTextObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_subTextObjects");
			TextMeshPro.NativeFieldInfoPtr_m_maskType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_maskType");
			TextMeshPro.NativeFieldInfoPtr_m_EnvMapMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_EnvMapMatrix");
			TextMeshPro.NativeFieldInfoPtr_m_RectTransformCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_RectTransformCorners");
			TextMeshPro.NativeFieldInfoPtr_m_isRegisteredForEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "m_isRegisteredForEvents");
			TextMeshPro.NativeFieldInfoPtr_k_GenerateTextMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_GenerateTextMarker");
			TextMeshPro.NativeFieldInfoPtr_k_SetArraySizesMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_SetArraySizesMarker");
			TextMeshPro.NativeFieldInfoPtr_k_GenerateTextPhaseIMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_GenerateTextPhaseIMarker");
			TextMeshPro.NativeFieldInfoPtr_k_ParseMarkupTextMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_ParseMarkupTextMarker");
			TextMeshPro.NativeFieldInfoPtr_k_CharacterLookupMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_CharacterLookupMarker");
			TextMeshPro.NativeFieldInfoPtr_k_HandleGPOSFeaturesMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_HandleGPOSFeaturesMarker");
			TextMeshPro.NativeFieldInfoPtr_k_CalculateVerticesPositionMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_CalculateVerticesPositionMarker");
			TextMeshPro.NativeFieldInfoPtr_k_ComputeTextMetricsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_ComputeTextMetricsMarker");
			TextMeshPro.NativeFieldInfoPtr_k_HandleVisibleCharacterMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_HandleVisibleCharacterMarker");
			TextMeshPro.NativeFieldInfoPtr_k_HandleWhiteSpacesMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_HandleWhiteSpacesMarker");
			TextMeshPro.NativeFieldInfoPtr_k_HandleHorizontalLineBreakingMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_HandleHorizontalLineBreakingMarker");
			TextMeshPro.NativeFieldInfoPtr_k_HandleVerticalLineBreakingMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_HandleVerticalLineBreakingMarker");
			TextMeshPro.NativeFieldInfoPtr_k_SaveGlyphVertexDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_SaveGlyphVertexDataMarker");
			TextMeshPro.NativeFieldInfoPtr_k_ComputeCharacterAdvanceMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_ComputeCharacterAdvanceMarker");
			TextMeshPro.NativeFieldInfoPtr_k_HandleCarriageReturnMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_HandleCarriageReturnMarker");
			TextMeshPro.NativeFieldInfoPtr_k_HandleLineTerminationMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_HandleLineTerminationMarker");
			TextMeshPro.NativeFieldInfoPtr_k_SavePageInfoMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_SavePageInfoMarker");
			TextMeshPro.NativeFieldInfoPtr_k_SaveProcessingStatesMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_SaveProcessingStatesMarker");
			TextMeshPro.NativeFieldInfoPtr_k_GenerateTextPhaseIIMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_GenerateTextPhaseIIMarker");
			TextMeshPro.NativeFieldInfoPtr_k_GenerateTextPhaseIIIMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, "k_GenerateTextPhaseIIIMarker");
			TextMeshPro.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663377);
			TextMeshPro.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663378);
			TextMeshPro.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663379);
			TextMeshPro.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663380);
			TextMeshPro.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663381);
			TextMeshPro.NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663382);
			TextMeshPro.NativeMethodInfoPtr_get_textContainer_Public_get_TextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663383);
			TextMeshPro.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663384);
			TextMeshPro.NativeMethodInfoPtr_get_renderer_Public_get_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663385);
			TextMeshPro.NativeMethodInfoPtr_get_mesh_Public_Virtual_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663386);
			TextMeshPro.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663387);
			TextMeshPro.NativeMethodInfoPtr_get_maskType_Public_get_MaskingTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663388);
			TextMeshPro.NativeMethodInfoPtr_set_maskType_Public_set_Void_MaskingTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663389);
			TextMeshPro.NativeMethodInfoPtr_SetMask_Public_Void_MaskingTypes_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663390);
			TextMeshPro.NativeMethodInfoPtr_SetMask_Public_Void_MaskingTypes_Vector4_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663391);
			TextMeshPro.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663392);
			TextMeshPro.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663393);
			TextMeshPro.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663394);
			TextMeshPro.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663395);
			TextMeshPro.NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663396);
			TextMeshPro.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663397);
			TextMeshPro.NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663398);
			TextMeshPro.NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663399);
			TextMeshPro.NativeMethodInfoPtr_GetTextInfo_Public_Virtual_TMP_TextInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663400);
			TextMeshPro.NativeMethodInfoPtr_ClearMesh_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663401);
			TextMeshPro.NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_add_Void_Action_1_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663402);
			TextMeshPro.NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_rem_Void_Action_1_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663403);
			TextMeshPro.NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_Void_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663404);
			TextMeshPro.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_TMP_VertexDataUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663405);
			TextMeshPro.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663406);
			TextMeshPro.NativeMethodInfoPtr_UpdateFontAsset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663407);
			TextMeshPro.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663408);
			TextMeshPro.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663409);
			TextMeshPro.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663410);
			TextMeshPro.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663411);
			TextMeshPro.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663412);
			TextMeshPro.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663413);
			TextMeshPro.NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663414);
			TextMeshPro.NativeMethodInfoPtr_UpdateEnvMapMatrix_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663415);
			TextMeshPro.NativeMethodInfoPtr_SetMask_Private_Void_MaskingTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663416);
			TextMeshPro.NativeMethodInfoPtr_SetMaskCoordinates_Private_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663417);
			TextMeshPro.NativeMethodInfoPtr_SetMaskCoordinates_Private_Void_Vector4_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663418);
			TextMeshPro.NativeMethodInfoPtr_EnableMasking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663419);
			TextMeshPro.NativeMethodInfoPtr_DisableMasking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663420);
			TextMeshPro.NativeMethodInfoPtr_UpdateMask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663421);
			TextMeshPro.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663422);
			TextMeshPro.NativeMethodInfoPtr_GetMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663423);
			TextMeshPro.NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663424);
			TextMeshPro.NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663425);
			TextMeshPro.NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663426);
			TextMeshPro.NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663427);
			TextMeshPro.NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663428);
			TextMeshPro.NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663429);
			TextMeshPro.NativeMethodInfoPtr_CreateMaterialInstance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663430);
			TextMeshPro.NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663431);
			TextMeshPro.NativeMethodInfoPtr_SetCulling_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663432);
			TextMeshPro.NativeMethodInfoPtr_SetPerspectiveCorrection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663433);
			TextMeshPro.NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_Int32_Il2CppStructArray_1_UnicodeChar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663434);
			TextMeshPro.NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663435);
			TextMeshPro.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663436);
			TextMeshPro.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663437);
			TextMeshPro.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663438);
			TextMeshPro.NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663439);
			TextMeshPro.NativeMethodInfoPtr_OnPreRenderObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663440);
			TextMeshPro.NativeMethodInfoPtr_GenerateTextMesh_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663441);
			TextMeshPro.NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663442);
			TextMeshPro.NativeMethodInfoPtr_SetMeshFilters_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663443);
			TextMeshPro.NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663444);
			TextMeshPro.NativeMethodInfoPtr_SetActiveSubTextObjectRenderers_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663445);
			TextMeshPro.NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663446);
			TextMeshPro.NativeMethodInfoPtr_UpdateSubMeshSortingLayerID_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663447);
			TextMeshPro.NativeMethodInfoPtr_UpdateSubMeshSortingOrder_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663448);
			TextMeshPro.NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663449);
			TextMeshPro.NativeMethodInfoPtr_UpdateSDFScale_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663450);
			TextMeshPro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr, 100663451);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000D114 File Offset: 0x0000B314
		public unsafe int sortingLayerID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032858, XrefRangeEnd = 1032864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032864, XrefRangeEnd = 1032881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000D154 File Offset: 0x0000B354
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000D190 File Offset: 0x0000B390
		public unsafe int sortingOrder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032881, XrefRangeEnd = 1032887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032887, XrefRangeEnd = 1032904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000D218 File Offset: 0x0000B418
		public unsafe override bool autoSizeTextContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032904, XrefRangeEnd = 1032908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000D264 File Offset: 0x0000B464
		public unsafe TextContainer textContainer
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_get_textContainer_Public_get_TextContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextContainer>(intPtr3) : null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
		public new unsafe Transform transform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1032916, RefRangeEnd = 1032919, XrefRangeStart = 1032908, XrefRangeEnd = 1032916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000D2E4 File Offset: 0x0000B4E4
		public unsafe Renderer renderer
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1032927, RefRangeEnd = 1032934, XrefRangeStart = 1032919, XrefRangeEnd = 1032927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_get_renderer_Public_get_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr3) : null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000D324 File Offset: 0x0000B524
		public unsafe override Mesh mesh
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032934, XrefRangeEnd = 1032944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_get_mesh_Public_Virtual_get_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000D370 File Offset: 0x0000B570
		public unsafe MeshFilter meshFilter
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1032961, RefRangeEnd = 1032963, XrefRangeStart = 1032944, XrefRangeEnd = 1032961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr3) : null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000D3EC File Offset: 0x0000B5EC
		public unsafe MaskingTypes maskType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_get_maskType_Public_get_MaskingTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032963, XrefRangeEnd = 1032964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_set_maskType_Public_set_Void_MaskingTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000D42C File Offset: 0x0000B62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032964, XrefRangeEnd = 1032970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMask(MaskingTypes type, Vector4 maskCoords)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskCoords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_SetMask_Public_Void_MaskingTypes_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000D478 File Offset: 0x0000B678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032970, XrefRangeEnd = 1032981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskCoords;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref softnessX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref softnessY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_SetMask_Public_Void_MaskingTypes_Vector4_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032981, XrefRangeEnd = 1032989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVerticesDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000D51C File Offset: 0x0000B71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032989, XrefRangeEnd = 1032998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000D558 File Offset: 0x0000B758
		[CallerCount(0)]
		public unsafe override void SetMaterialDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000D594 File Offset: 0x0000B794
		[CallerCount(0)]
		public unsafe override void SetAllDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000D5D0 File Offset: 0x0000B7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032998, XrefRangeEnd = 1033003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000D61C File Offset: 0x0000B81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033003, XrefRangeEnd = 1033019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000D658 File Offset: 0x0000B858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033019, XrefRangeEnd = 1033026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMeshPadding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000D694 File Offset: 0x0000B894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033026, XrefRangeEnd = 1033027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreActiveState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceTextReparsing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000D6EC File Offset: 0x0000B8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033027, XrefRangeEnd = 1033028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TMP_TextInfo GetTextInfo(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_GetTextInfo_Public_Virtual_TMP_TextInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000D748 File Offset: 0x0000B948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033028, XrefRangeEnd = 1033036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearMesh(bool updateMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_ClearMesh_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000D794 File Offset: 0x0000B994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033036, XrefRangeEnd = 1033041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnPreRenderText(Action<TMP_TextInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_add_Void_Action_1_TMP_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033041, XrefRangeEnd = 1033046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnPreRenderText(Action<TMP_TextInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_rem_Void_Action_1_TMP_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000D834 File Offset: 0x0000BA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033046, XrefRangeEnd = 1033048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateGeometry(Mesh mesh, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_Void_Mesh_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000D890 File Offset: 0x0000BA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033048, XrefRangeEnd = 1033056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_TMP_VertexDataUpdateFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000D8DC File Offset: 0x0000BADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033056, XrefRangeEnd = 1033067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateVertexData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000D918 File Offset: 0x0000BB18
		[CallerCount(0)]
		public unsafe void UpdateFontAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_UpdateFontAsset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000D94C File Offset: 0x0000BB4C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000D980 File Offset: 0x0000BB80
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033067, XrefRangeEnd = 1033130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033130, XrefRangeEnd = 1033136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000DA2C File Offset: 0x0000BC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033136, XrefRangeEnd = 1033143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000DA68 File Offset: 0x0000BC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033143, XrefRangeEnd = 1033155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000DAA4 File Offset: 0x0000BCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033155, XrefRangeEnd = 1033262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LoadFontAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000DAE0 File Offset: 0x0000BCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033262, XrefRangeEnd = 1033287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEnvMapMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_UpdateEnvMapMatrix_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000DB14 File Offset: 0x0000BD14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1033307, RefRangeEnd = 1033310, XrefRangeStart = 1033287, XrefRangeEnd = 1033307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMask(MaskingTypes maskType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maskType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_SetMask_Private_Void_MaskingTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000DB54 File Offset: 0x0000BD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033310, XrefRangeEnd = 1033315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaskCoordinates(Vector4 coords)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref coords;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_SetMaskCoordinates_Private_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000DB94 File Offset: 0x0000BD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033315, XrefRangeEnd = 1033325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaskCoordinates(Vector4 coords, float softX, float softY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref coords;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref softX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref softY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_SetMaskCoordinates_Private_Void_Vector4_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033325, XrefRangeEnd = 1033339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableMasking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_EnableMasking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000DC24 File Offset: 0x0000BE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033339, XrefRangeEnd = 1033368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableMasking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_DisableMasking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000DC58 File Offset: 0x0000BE58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1033384, RefRangeEnd = 1033386, XrefRangeStart = 1033368, XrefRangeEnd = 1033384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_UpdateMask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000DC8C File Offset: 0x0000BE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033386, XrefRangeEnd = 1033394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Material GetMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000DCE8 File Offset: 0x0000BEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033394, XrefRangeEnd = 1033412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Material> GetMaterials(Il2CppReferenceArray<Material> mats)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mats);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_GetMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000DD44 File Offset: 0x0000BF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033412, XrefRangeEnd = 1033413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetSharedMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000DD94 File Offset: 0x0000BF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033413, XrefRangeEnd = 1033428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Material> GetSharedMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033428, XrefRangeEnd = 1033469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetSharedMaterials(Il2CppReferenceArray<Material> materials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000DE30 File Offset: 0x0000C030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033469, XrefRangeEnd = 1033485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOutlineThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thickness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000DE7C File Offset: 0x0000C07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033485, XrefRangeEnd = 1033499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFaceColor(Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033499, XrefRangeEnd = 1033513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOutlineColor(Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000DF14 File Offset: 0x0000C114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033513, XrefRangeEnd = 1033526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateMaterialInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_CreateMaterialInstance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000DF48 File Offset: 0x0000C148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033526, XrefRangeEnd = 1033541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetShaderDepth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000DF84 File Offset: 0x0000C184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033541, XrefRangeEnd = 1033576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetCulling_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000DFC0 File Offset: 0x0000C1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033576, XrefRangeEnd = 1033585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPerspectiveCorrection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_SetPerspectiveCorrection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033585, XrefRangeEnd = 1033915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int SetArraySizes(Il2CppStructArray<TMP_Text.UnicodeChar> unicodeChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodeChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_Int32_Il2CppStructArray_1_UnicodeChar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000E04C File Offset: 0x0000C24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033915, XrefRangeEnd = 1033923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ComputeMarginSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000E088 File Offset: 0x0000C288
		[CallerCount(0)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
		[CallerCount(0)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000E100 File Offset: 0x0000C300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033923, XrefRangeEnd = 1033932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000E13C File Offset: 0x0000C33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033932, XrefRangeEnd = 1033935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InternalUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000E178 File Offset: 0x0000C378
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1033961, RefRangeEnd = 1033965, XrefRangeStart = 1033935, XrefRangeEnd = 1033961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreRenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_OnPreRenderObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033965, XrefRangeEnd = 1035122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GenerateTextMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_GenerateTextMesh_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035122, XrefRangeEnd = 1035129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<Vector3> GetTextContainerLocalCorners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000E234 File Offset: 0x0000C434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035129, XrefRangeEnd = 1035148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMeshFilters(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_SetMeshFilters_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000E274 File Offset: 0x0000C474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035148, XrefRangeEnd = 1035155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetActiveSubMeshes(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035155, XrefRangeEnd = 1035166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveSubTextObjectRenderers(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_SetActiveSubTextObjectRenderers_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000E300 File Offset: 0x0000C500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035166, XrefRangeEnd = 1035174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroySubMeshObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000E33C File Offset: 0x0000C53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035174, XrefRangeEnd = 1035185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSubMeshSortingLayerID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_UpdateSubMeshSortingLayerID_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000E37C File Offset: 0x0000C57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035185, XrefRangeEnd = 1035196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSubMeshSortingOrder(int order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_UpdateSubMeshSortingOrder_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035196, XrefRangeEnd = 1035204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Bounds GetCompoundBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextMeshPro.NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000E404 File Offset: 0x0000C604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1035211, RefRangeEnd = 1035212, XrefRangeStart = 1035204, XrefRangeEnd = 1035211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSDFScale(float scaleDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr_UpdateSDFScale_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000E444 File Offset: 0x0000C644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035212, XrefRangeEnd = 1035224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMeshPro()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMeshPro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshPro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002522 File Offset: 0x00000722
		public TextMeshPro(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000E480 File Offset: 0x0000C680
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000252B File Offset: 0x0000072B
		public unsafe int _SortingLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr__SortingLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr__SortingLayer)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002546 File Offset: 0x00000746
		public unsafe int _SortingLayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr__SortingLayerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr__SortingLayerID)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002561 File Offset: 0x00000761
		public unsafe int _SortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr__SortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr__SortingOrder)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000257C File Offset: 0x0000077C
		public new unsafe Action<TMP_TextInfo> OnPreRenderText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_OnPreRenderText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TMP_TextInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_OnPreRenderText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000E528 File Offset: 0x0000C728
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000259B File Offset: 0x0000079B
		public unsafe bool m_currentAutoSizeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_currentAutoSizeMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_currentAutoSizeMode)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000E550 File Offset: 0x0000C750
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000025B6 File Offset: 0x000007B6
		public unsafe bool m_hasFontAssetChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_hasFontAssetChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_hasFontAssetChanged)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000E578 File Offset: 0x0000C778
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000025D1 File Offset: 0x000007D1
		public unsafe float m_previousLossyScaleY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_previousLossyScaleY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_previousLossyScaleY)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		// (set) Token: 0x0600010C RID: 268 RVA: 0x000025EC File Offset: 0x000007EC
		public unsafe Renderer m_renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000E5D0 File Offset: 0x0000C7D0
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000260B File Offset: 0x0000080B
		public unsafe MeshFilter m_meshFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_meshFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_meshFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000E600 File Offset: 0x0000C800
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000262A File Offset: 0x0000082A
		public unsafe bool m_isFirstAllocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_isFirstAllocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_isFirstAllocation)) = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000E628 File Offset: 0x0000C828
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002645 File Offset: 0x00000845
		public unsafe int m_max_characters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_max_characters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_max_characters)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000E650 File Offset: 0x0000C850
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002660 File Offset: 0x00000860
		public unsafe int m_max_numberOfLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_max_numberOfLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_max_numberOfLines)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000E678 File Offset: 0x0000C878
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000267B File Offset: 0x0000087B
		public unsafe Il2CppReferenceArray<TMP_SubMesh> m_subTextObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_subTextObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_SubMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_subTextObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000E6A8 File Offset: 0x0000C8A8
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000269A File Offset: 0x0000089A
		public unsafe MaskingTypes m_maskType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_maskType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_maskType)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000026B5 File Offset: 0x000008B5
		public unsafe Matrix4x4 m_EnvMapMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_EnvMapMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_EnvMapMatrix)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000E6F8 File Offset: 0x0000C8F8
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000026D0 File Offset: 0x000008D0
		public unsafe Il2CppStructArray<Vector3> m_RectTransformCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_RectTransformCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_RectTransformCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000E728 File Offset: 0x0000C928
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000026EF File Offset: 0x000008EF
		public unsafe bool m_isRegisteredForEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_isRegisteredForEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshPro.NativeFieldInfoPtr_m_isRegisteredForEvents)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000E750 File Offset: 0x0000C950
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0000270A File Offset: 0x0000090A
		public unsafe static ProfilerMarker k_GenerateTextMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_GenerateTextMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_GenerateTextMarker, (void*)(&value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000E76C File Offset: 0x0000C96C
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002718 File Offset: 0x00000918
		public unsafe static ProfilerMarker k_SetArraySizesMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_SetArraySizesMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_SetArraySizesMarker, (void*)(&value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000E788 File Offset: 0x0000C988
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002726 File Offset: 0x00000926
		public unsafe static ProfilerMarker k_GenerateTextPhaseIMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_GenerateTextPhaseIMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_GenerateTextPhaseIMarker, (void*)(&value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002734 File Offset: 0x00000934
		public unsafe static ProfilerMarker k_ParseMarkupTextMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_ParseMarkupTextMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_ParseMarkupTextMarker, (void*)(&value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002742 File Offset: 0x00000942
		public unsafe static ProfilerMarker k_CharacterLookupMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_CharacterLookupMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_CharacterLookupMarker, (void*)(&value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000E7DC File Offset: 0x0000C9DC
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002750 File Offset: 0x00000950
		public unsafe static ProfilerMarker k_HandleGPOSFeaturesMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_HandleGPOSFeaturesMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_HandleGPOSFeaturesMarker, (void*)(&value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000275E File Offset: 0x0000095E
		public unsafe static ProfilerMarker k_CalculateVerticesPositionMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_CalculateVerticesPositionMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_CalculateVerticesPositionMarker, (void*)(&value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000E814 File Offset: 0x0000CA14
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000276C File Offset: 0x0000096C
		public unsafe static ProfilerMarker k_ComputeTextMetricsMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_ComputeTextMetricsMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_ComputeTextMetricsMarker, (void*)(&value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000E830 File Offset: 0x0000CA30
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000277A File Offset: 0x0000097A
		public unsafe static ProfilerMarker k_HandleVisibleCharacterMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_HandleVisibleCharacterMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_HandleVisibleCharacterMarker, (void*)(&value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000E84C File Offset: 0x0000CA4C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002788 File Offset: 0x00000988
		public unsafe static ProfilerMarker k_HandleWhiteSpacesMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_HandleWhiteSpacesMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_HandleWhiteSpacesMarker, (void*)(&value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000E868 File Offset: 0x0000CA68
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002796 File Offset: 0x00000996
		public unsafe static ProfilerMarker k_HandleHorizontalLineBreakingMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_HandleHorizontalLineBreakingMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_HandleHorizontalLineBreakingMarker, (void*)(&value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000E884 File Offset: 0x0000CA84
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000027A4 File Offset: 0x000009A4
		public unsafe static ProfilerMarker k_HandleVerticalLineBreakingMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_HandleVerticalLineBreakingMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_HandleVerticalLineBreakingMarker, (void*)(&value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000E8A0 File Offset: 0x0000CAA0
		// (set) Token: 0x06000138 RID: 312 RVA: 0x000027B2 File Offset: 0x000009B2
		public unsafe static ProfilerMarker k_SaveGlyphVertexDataMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_SaveGlyphVertexDataMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_SaveGlyphVertexDataMarker, (void*)(&value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000E8BC File Offset: 0x0000CABC
		// (set) Token: 0x0600013A RID: 314 RVA: 0x000027C0 File Offset: 0x000009C0
		public unsafe static ProfilerMarker k_ComputeCharacterAdvanceMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_ComputeCharacterAdvanceMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_ComputeCharacterAdvanceMarker, (void*)(&value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000027CE File Offset: 0x000009CE
		public unsafe static ProfilerMarker k_HandleCarriageReturnMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_HandleCarriageReturnMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_HandleCarriageReturnMarker, (void*)(&value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000027DC File Offset: 0x000009DC
		public unsafe static ProfilerMarker k_HandleLineTerminationMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_HandleLineTerminationMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_HandleLineTerminationMarker, (void*)(&value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000E910 File Offset: 0x0000CB10
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000027EA File Offset: 0x000009EA
		public unsafe static ProfilerMarker k_SavePageInfoMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_SavePageInfoMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_SavePageInfoMarker, (void*)(&value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000E92C File Offset: 0x0000CB2C
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000027F8 File Offset: 0x000009F8
		public unsafe static ProfilerMarker k_SaveProcessingStatesMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_SaveProcessingStatesMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_SaveProcessingStatesMarker, (void*)(&value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000E948 File Offset: 0x0000CB48
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002806 File Offset: 0x00000A06
		public unsafe static ProfilerMarker k_GenerateTextPhaseIIMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_GenerateTextPhaseIIMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_GenerateTextPhaseIIMarker, (void*)(&value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000E964 File Offset: 0x0000CB64
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002814 File Offset: 0x00000A14
		public unsafe static ProfilerMarker k_GenerateTextPhaseIIIMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TextMeshPro.NativeFieldInfoPtr_k_GenerateTextPhaseIIIMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextMeshPro.NativeFieldInfoPtr_k_GenerateTextPhaseIIIMarker, (void*)(&value));
			}
		}

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr__SortingLayer;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr__SortingLayerID;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr__SortingOrder;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_OnPreRenderText;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_m_currentAutoSizeMode;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_m_hasFontAssetChanged;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_m_previousLossyScaleY;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_m_renderer;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_m_meshFilter;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_m_isFirstAllocation;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_m_max_characters;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_m_max_numberOfLines;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_m_subTextObjects;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_m_maskType;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_m_EnvMapMatrix;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransformCorners;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_m_isRegisteredForEvents;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_k_GenerateTextMarker;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_k_SetArraySizesMarker;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_k_GenerateTextPhaseIMarker;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_k_ParseMarkupTextMarker;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_k_CharacterLookupMarker;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleGPOSFeaturesMarker;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_k_CalculateVerticesPositionMarker;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_k_ComputeTextMetricsMarker;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleVisibleCharacterMarker;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleWhiteSpacesMarker;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleHorizontalLineBreakingMarker;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleVerticalLineBreakingMarker;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_k_SaveGlyphVertexDataMarker;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_k_ComputeCharacterAdvanceMarker;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleCarriageReturnMarker;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_k_HandleLineTerminationMarker;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_k_SavePageInfoMarker;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_k_SaveProcessingStatesMarker;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_k_GenerateTextPhaseIIMarker;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_k_GenerateTextPhaseIIIMarker;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_get_Boolean_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_textContainer_Public_get_TextContainer_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_renderer_Public_get_Renderer_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_Virtual_get_Mesh_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_get_maskType_Public_get_MaskingTypes_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_set_maskType_Public_set_Void_MaskingTypes_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_SetMask_Public_Void_MaskingTypes_Vector4_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_SetMask_Public_Void_MaskingTypes_Vector4_Single_Single_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_Void_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_Void_Boolean_Boolean_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_GetTextInfo_Public_Virtual_TMP_TextInfo_String_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_ClearMesh_Public_Virtual_Void_Boolean_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_add_Void_Action_1_TMP_TextInfo_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_rem_Void_Action_1_TMP_TextInfo_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_Void_Mesh_Int32_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_TMP_VertexDataUpdateFlags_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_Void_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFontAsset_Public_Void_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_Void_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEnvMapMatrix_Private_Void_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_SetMask_Private_Void_MaskingTypes_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_SetMaskCoordinates_Private_Void_Vector4_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_SetMaskCoordinates_Private_Void_Vector4_Single_Single_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_EnableMasking_Private_Void_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_DisableMasking_Private_Void_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMask_Private_Void_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_Material_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_Void_Material_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_Void_Single_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_Void_Color32_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_Void_Color32_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_CreateMaterialInstance_Private_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_Void_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_SetCulling_Protected_Virtual_Void_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_SetPerspectiveCorrection_Private_Void_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_Int32_Il2CppStructArray_1_UnicodeChar_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_Void_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_Void_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRenderObject_Private_Void_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTextMesh_Protected_Virtual_New_Void_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_SetMeshFilters_Private_Void_Boolean_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSubTextObjectRenderers_Protected_Void_Boolean_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_Void_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSubMeshSortingLayerID_Internal_Void_Int32_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSubMeshSortingOrder_Internal_Void_Int32_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_Bounds_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSDFScale_Private_Void_Single_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
