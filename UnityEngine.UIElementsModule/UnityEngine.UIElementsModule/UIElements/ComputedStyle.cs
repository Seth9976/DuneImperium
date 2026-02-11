using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017D RID: 381
	public sealed class ComputedStyle : ValueType
	{
		// Token: 0x06001C35 RID: 7221 RVA: 0x000807B8 File Offset: 0x0007E9B8
		// Note: this type is marked as 'beforefieldinit'.
		static ComputedStyle()
		{
			Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ComputedStyle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr);
			ComputedStyle.NativeFieldInfoPtr_inheritedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "inheritedData");
			ComputedStyle.NativeFieldInfoPtr_layoutData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "layoutData");
			ComputedStyle.NativeFieldInfoPtr_rareData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "rareData");
			ComputedStyle.NativeFieldInfoPtr_transformData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "transformData");
			ComputedStyle.NativeFieldInfoPtr_transitionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "transitionData");
			ComputedStyle.NativeFieldInfoPtr_visualData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "visualData");
			ComputedStyle.NativeFieldInfoPtr_yogaNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "yogaNode");
			ComputedStyle.NativeFieldInfoPtr_customProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "customProperties");
			ComputedStyle.NativeFieldInfoPtr_matchingRulesHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "matchingRulesHash");
			ComputedStyle.NativeFieldInfoPtr_dpiScaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "dpiScaling");
			ComputedStyle.NativeFieldInfoPtr_computedTransitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "computedTransitions");
			ComputedStyle.NativeMethodInfoPtr_get_customPropertiesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667386);
			ComputedStyle.NativeMethodInfoPtr_get_hasTransition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667387);
			ComputedStyle.NativeMethodInfoPtr_FinalizeApply_Public_Void_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667388);
			ComputedStyle.NativeMethodInfoPtr_SyncWithLayout_Public_Void_YogaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667389);
			ComputedStyle.NativeMethodInfoPtr_ApplyGlobalKeyword_Private_Boolean_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667390);
			ComputedStyle.NativeMethodInfoPtr_ApplyGlobalKeyword_Private_Boolean_StylePropertyId_StyleKeyword_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667391);
			ComputedStyle.NativeMethodInfoPtr_RemoveCustomStyleProperty_Private_Void_StylePropertyReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667392);
			ComputedStyle.NativeMethodInfoPtr_ApplyCustomStyleProperty_Private_Void_StylePropertyReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667393);
			ComputedStyle.NativeMethodInfoPtr_ApplyAllPropertyInitial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667394);
			ComputedStyle.NativeMethodInfoPtr_ResetComputedTransitions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667395);
			ComputedStyle.NativeMethodInfoPtr_StartAnimationInlineTranslate_Public_Static_Boolean_VisualElement_byref_ComputedStyle_StyleTranslate_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667396);
			ComputedStyle.NativeMethodInfoPtr_get_alignContent_Public_get_Align_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667397);
			ComputedStyle.NativeMethodInfoPtr_get_alignItems_Public_get_Align_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667398);
			ComputedStyle.NativeMethodInfoPtr_get_alignSelf_Public_get_Align_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667399);
			ComputedStyle.NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667400);
			ComputedStyle.NativeMethodInfoPtr_get_backgroundImage_Public_get_Background_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667401);
			ComputedStyle.NativeMethodInfoPtr_get_backgroundPositionX_Public_get_BackgroundPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667402);
			ComputedStyle.NativeMethodInfoPtr_get_backgroundPositionY_Public_get_BackgroundPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667403);
			ComputedStyle.NativeMethodInfoPtr_get_backgroundRepeat_Public_get_BackgroundRepeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667404);
			ComputedStyle.NativeMethodInfoPtr_get_backgroundSize_Public_get_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667405);
			ComputedStyle.NativeMethodInfoPtr_get_borderBottomColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667406);
			ComputedStyle.NativeMethodInfoPtr_get_borderBottomLeftRadius_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667407);
			ComputedStyle.NativeMethodInfoPtr_get_borderBottomRightRadius_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667408);
			ComputedStyle.NativeMethodInfoPtr_get_borderBottomWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667409);
			ComputedStyle.NativeMethodInfoPtr_get_borderLeftColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667410);
			ComputedStyle.NativeMethodInfoPtr_get_borderLeftWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667411);
			ComputedStyle.NativeMethodInfoPtr_get_borderRightColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667412);
			ComputedStyle.NativeMethodInfoPtr_get_borderRightWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667413);
			ComputedStyle.NativeMethodInfoPtr_get_borderTopColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667414);
			ComputedStyle.NativeMethodInfoPtr_get_borderTopLeftRadius_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667415);
			ComputedStyle.NativeMethodInfoPtr_get_borderTopRightRadius_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667416);
			ComputedStyle.NativeMethodInfoPtr_get_borderTopWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667417);
			ComputedStyle.NativeMethodInfoPtr_get_bottom_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667418);
			ComputedStyle.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667419);
			ComputedStyle.NativeMethodInfoPtr_get_cursor_Public_get_Cursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667420);
			ComputedStyle.NativeMethodInfoPtr_get_display_Public_get_DisplayStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667421);
			ComputedStyle.NativeMethodInfoPtr_get_flexBasis_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667422);
			ComputedStyle.NativeMethodInfoPtr_get_flexDirection_Public_get_FlexDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667423);
			ComputedStyle.NativeMethodInfoPtr_get_flexGrow_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667424);
			ComputedStyle.NativeMethodInfoPtr_get_flexShrink_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667425);
			ComputedStyle.NativeMethodInfoPtr_get_flexWrap_Public_get_Wrap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667426);
			ComputedStyle.NativeMethodInfoPtr_get_fontSize_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667427);
			ComputedStyle.NativeMethodInfoPtr_get_height_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667428);
			ComputedStyle.NativeMethodInfoPtr_get_justifyContent_Public_get_Justify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667429);
			ComputedStyle.NativeMethodInfoPtr_get_left_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667430);
			ComputedStyle.NativeMethodInfoPtr_get_letterSpacing_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667431);
			ComputedStyle.NativeMethodInfoPtr_get_marginBottom_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667432);
			ComputedStyle.NativeMethodInfoPtr_get_marginLeft_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667433);
			ComputedStyle.NativeMethodInfoPtr_get_marginRight_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667434);
			ComputedStyle.NativeMethodInfoPtr_get_marginTop_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667435);
			ComputedStyle.NativeMethodInfoPtr_get_maxHeight_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667436);
			ComputedStyle.NativeMethodInfoPtr_get_maxWidth_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667437);
			ComputedStyle.NativeMethodInfoPtr_get_minHeight_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667438);
			ComputedStyle.NativeMethodInfoPtr_get_minWidth_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667439);
			ComputedStyle.NativeMethodInfoPtr_get_opacity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667440);
			ComputedStyle.NativeMethodInfoPtr_get_overflow_Public_get_OverflowInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667441);
			ComputedStyle.NativeMethodInfoPtr_get_paddingBottom_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667442);
			ComputedStyle.NativeMethodInfoPtr_get_paddingLeft_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667443);
			ComputedStyle.NativeMethodInfoPtr_get_paddingRight_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667444);
			ComputedStyle.NativeMethodInfoPtr_get_paddingTop_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667445);
			ComputedStyle.NativeMethodInfoPtr_get_position_Public_get_Position_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667446);
			ComputedStyle.NativeMethodInfoPtr_get_right_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667447);
			ComputedStyle.NativeMethodInfoPtr_get_rotate_Public_get_Rotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667448);
			ComputedStyle.NativeMethodInfoPtr_get_scale_Public_get_Scale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667449);
			ComputedStyle.NativeMethodInfoPtr_get_textOverflow_Public_get_TextOverflow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667450);
			ComputedStyle.NativeMethodInfoPtr_get_textShadow_Public_get_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667451);
			ComputedStyle.NativeMethodInfoPtr_get_top_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667452);
			ComputedStyle.NativeMethodInfoPtr_get_transformOrigin_Public_get_TransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667453);
			ComputedStyle.NativeMethodInfoPtr_get_transitionDelay_Public_get_List_1_TimeValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667454);
			ComputedStyle.NativeMethodInfoPtr_get_transitionDuration_Public_get_List_1_TimeValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667455);
			ComputedStyle.NativeMethodInfoPtr_get_transitionProperty_Public_get_List_1_StylePropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667456);
			ComputedStyle.NativeMethodInfoPtr_get_transitionTimingFunction_Public_get_List_1_EasingFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667457);
			ComputedStyle.NativeMethodInfoPtr_get_translate_Public_get_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667458);
			ComputedStyle.NativeMethodInfoPtr_get_unityBackgroundImageTintColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667459);
			ComputedStyle.NativeMethodInfoPtr_get_unityFont_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667460);
			ComputedStyle.NativeMethodInfoPtr_get_unityFontDefinition_Public_get_FontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667461);
			ComputedStyle.NativeMethodInfoPtr_get_unityFontStyleAndWeight_Public_get_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667462);
			ComputedStyle.NativeMethodInfoPtr_get_unityOverflowClipBox_Public_get_OverflowClipBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667463);
			ComputedStyle.NativeMethodInfoPtr_get_unityParagraphSpacing_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667464);
			ComputedStyle.NativeMethodInfoPtr_get_unitySliceBottom_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667465);
			ComputedStyle.NativeMethodInfoPtr_get_unitySliceLeft_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667466);
			ComputedStyle.NativeMethodInfoPtr_get_unitySliceRight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667467);
			ComputedStyle.NativeMethodInfoPtr_get_unitySliceScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667468);
			ComputedStyle.NativeMethodInfoPtr_get_unitySliceTop_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667469);
			ComputedStyle.NativeMethodInfoPtr_get_unityTextAlign_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667470);
			ComputedStyle.NativeMethodInfoPtr_get_unityTextOutlineColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667471);
			ComputedStyle.NativeMethodInfoPtr_get_unityTextOutlineWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667472);
			ComputedStyle.NativeMethodInfoPtr_get_unityTextOverflowPosition_Public_get_TextOverflowPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667473);
			ComputedStyle.NativeMethodInfoPtr_get_visibility_Public_get_Visibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667474);
			ComputedStyle.NativeMethodInfoPtr_get_whiteSpace_Public_get_WhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667475);
			ComputedStyle.NativeMethodInfoPtr_get_width_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667476);
			ComputedStyle.NativeMethodInfoPtr_get_wordSpacing_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667477);
			ComputedStyle.NativeMethodInfoPtr_Create_Public_Static_ComputedStyle_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667478);
			ComputedStyle.NativeMethodInfoPtr_CreateInitial_Public_Static_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667479);
			ComputedStyle.NativeMethodInfoPtr_Acquire_Public_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667480);
			ComputedStyle.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667481);
			ComputedStyle.NativeMethodInfoPtr_CopyFrom_Public_Void_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667482);
			ComputedStyle.NativeMethodInfoPtr_ApplyProperties_Public_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667483);
			ComputedStyle.NativeMethodInfoPtr_ApplyStyleValue_Public_Void_StyleValue_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667484);
			ComputedStyle.NativeMethodInfoPtr_ApplyStyleValueManaged_Public_Void_StyleValueManaged_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667485);
			ComputedStyle.NativeMethodInfoPtr_ApplyStyleCursor_Public_Void_Cursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667486);
			ComputedStyle.NativeMethodInfoPtr_ApplyStyleTextShadow_Public_Void_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667487);
			ComputedStyle.NativeMethodInfoPtr_ApplyFromComputedStyle_Public_Void_StylePropertyId_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667488);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667489);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667490);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667491);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_BackgroundPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667492);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_BackgroundRepeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667493);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667494);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667495);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Background_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667496);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667497);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_FontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667498);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667499);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667500);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_TransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667501);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Rotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667502);
			ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Scale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667503);
			ComputedStyle.NativeMethodInfoPtr_StartAnimation_Public_Static_Boolean_VisualElement_StylePropertyId_byref_ComputedStyle_byref_ComputedStyle_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667504);
			ComputedStyle.NativeMethodInfoPtr_StartAnimationAllProperty_Public_Static_Boolean_VisualElement_byref_ComputedStyle_byref_ComputedStyle_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667505);
			ComputedStyle.NativeMethodInfoPtr_StartAnimationInline_Public_Static_Boolean_VisualElement_StylePropertyId_byref_ComputedStyle_StyleValue_Int32_Int32_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667506);
			ComputedStyle.NativeMethodInfoPtr_ApplyStyleTransformOrigin_Public_Void_TransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667507);
			ComputedStyle.NativeMethodInfoPtr_ApplyStyleTranslate_Public_Void_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667508);
			ComputedStyle.NativeMethodInfoPtr_ApplyStyleRotate_Public_Void_Rotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667509);
			ComputedStyle.NativeMethodInfoPtr_ApplyStyleScale_Public_Void_Scale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667510);
			ComputedStyle.NativeMethodInfoPtr_ApplyStyleBackgroundSize_Public_Void_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667511);
			ComputedStyle.NativeMethodInfoPtr_ApplyInitialValue_Public_Void_StylePropertyReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667512);
			ComputedStyle.NativeMethodInfoPtr_ApplyInitialValue_Public_Void_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667513);
			ComputedStyle.NativeMethodInfoPtr_ApplyUnsetValue_Public_Void_StylePropertyReader_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667514);
			ComputedStyle.NativeMethodInfoPtr_ApplyUnsetValue_Public_Void_StylePropertyId_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667515);
			ComputedStyle.NativeMethodInfoPtr_CompareChanges_Public_Static_VersionChangeType_byref_ComputedStyle_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100667516);
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00081300 File Offset: 0x0007F500
		public unsafe int customPropertiesCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 323966, RefRangeEnd = 323968, XrefRangeStart = 323963, XrefRangeEnd = 323966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_customPropertiesCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x00081344 File Offset: 0x0007F544
		public unsafe bool hasTransition
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 323968, RefRangeEnd = 323972, XrefRangeStart = 323968, XrefRangeEnd = 323968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_hasTransition_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00081388 File Offset: 0x0007F588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323991, RefRangeEnd = 323992, XrefRangeStart = 323972, XrefRangeEnd = 323991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeApply(ref ComputedStyle parentStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(parentStyle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_FinalizeApply_Public_Void_byref_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x000813D0 File Offset: 0x0007F5D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 324149, RefRangeEnd = 324152, XrefRangeStart = 323992, XrefRangeEnd = 324149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncWithLayout(UnityEngine.Yoga.YogaNode targetNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_SyncWithLayout_Public_Void_YogaNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00081418 File Offset: 0x0007F618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324152, XrefRangeEnd = 324155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref ComputedStyle parentStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parentStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyGlobalKeyword_Private_Boolean_StylePropertyReader_byref_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00081480 File Offset: 0x0007F680
		[CallerCount(0)]
		public unsafe bool ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parentStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyGlobalKeyword_Private_Boolean_StylePropertyId_StyleKeyword_byref_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x000814F0 File Offset: 0x0007F6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324155, XrefRangeEnd = 324162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_RemoveCustomStyleProperty_Private_Void_StylePropertyReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00081538 File Offset: 0x0007F738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324174, RefRangeEnd = 324175, XrefRangeStart = 324162, XrefRangeEnd = 324174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyCustomStyleProperty_Private_Void_StylePropertyReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00081580 File Offset: 0x0007F780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324175, XrefRangeEnd = 324180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAllPropertyInitial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyAllPropertyInitial_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x000815B8 File Offset: 0x0007F7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324180, XrefRangeEnd = 324181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetComputedTransitions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ResetComputedTransitions_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x000815F0 File Offset: 0x0007F7F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324198, RefRangeEnd = 324199, XrefRangeStart = 324181, XrefRangeEnd = 324198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_StartAnimationInlineTranslate_Public_Static_Boolean_VisualElement_byref_ComputedStyle_StyleTranslate_Int32_Int32_Func_2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00081684 File Offset: 0x0007F884
		public unsafe Align alignContent
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324202, RefRangeEnd = 324204, XrefRangeStart = 324199, XrefRangeEnd = 324202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_alignContent_Public_get_Align_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x000816C8 File Offset: 0x0007F8C8
		public unsafe Align alignItems
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324207, RefRangeEnd = 324209, XrefRangeStart = 324204, XrefRangeEnd = 324207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_alignItems_Public_get_Align_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0008170C File Offset: 0x0007F90C
		public unsafe Align alignSelf
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324212, RefRangeEnd = 324214, XrefRangeStart = 324209, XrefRangeEnd = 324212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_alignSelf_Public_get_Align_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00081750 File Offset: 0x0007F950
		public unsafe Color backgroundColor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324217, RefRangeEnd = 324220, XrefRangeStart = 324214, XrefRangeEnd = 324217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x00081794 File Offset: 0x0007F994
		public unsafe Background backgroundImage
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324223, RefRangeEnd = 324225, XrefRangeStart = 324220, XrefRangeEnd = 324223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_backgroundImage_Public_get_Background_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Background(intPtr);
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x000817D0 File Offset: 0x0007F9D0
		public unsafe BackgroundPosition backgroundPositionX
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324228, RefRangeEnd = 324230, XrefRangeStart = 324225, XrefRangeEnd = 324228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_backgroundPositionX_Public_get_BackgroundPosition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x00081814 File Offset: 0x0007FA14
		public unsafe BackgroundPosition backgroundPositionY
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324233, RefRangeEnd = 324235, XrefRangeStart = 324230, XrefRangeEnd = 324233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_backgroundPositionY_Public_get_BackgroundPosition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00081858 File Offset: 0x0007FA58
		public unsafe BackgroundRepeat backgroundRepeat
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 324238, RefRangeEnd = 324242, XrefRangeStart = 324235, XrefRangeEnd = 324238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_backgroundRepeat_Public_get_BackgroundRepeat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x0008189C File Offset: 0x0007FA9C
		public unsafe BackgroundSize backgroundSize
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 324245, RefRangeEnd = 324249, XrefRangeStart = 324242, XrefRangeEnd = 324245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_backgroundSize_Public_get_BackgroundSize_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x000818E0 File Offset: 0x0007FAE0
		public unsafe Color borderBottomColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324252, RefRangeEnd = 324253, XrefRangeStart = 324249, XrefRangeEnd = 324252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderBottomColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00081924 File Offset: 0x0007FB24
		public unsafe Length borderBottomLeftRadius
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324256, RefRangeEnd = 324258, XrefRangeStart = 324253, XrefRangeEnd = 324256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderBottomLeftRadius_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00081968 File Offset: 0x0007FB68
		public unsafe Length borderBottomRightRadius
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324261, RefRangeEnd = 324263, XrefRangeStart = 324258, XrefRangeEnd = 324261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderBottomRightRadius_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x000819AC File Offset: 0x0007FBAC
		public unsafe float borderBottomWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324266, RefRangeEnd = 324267, XrefRangeStart = 324263, XrefRangeEnd = 324266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderBottomWidth_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x000819F0 File Offset: 0x0007FBF0
		public unsafe Color borderLeftColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324270, RefRangeEnd = 324271, XrefRangeStart = 324267, XrefRangeEnd = 324270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderLeftColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00081A34 File Offset: 0x0007FC34
		public unsafe float borderLeftWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324274, RefRangeEnd = 324275, XrefRangeStart = 324271, XrefRangeEnd = 324274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderLeftWidth_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x00081A78 File Offset: 0x0007FC78
		public unsafe Color borderRightColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324278, RefRangeEnd = 324279, XrefRangeStart = 324275, XrefRangeEnd = 324278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderRightColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x00081ABC File Offset: 0x0007FCBC
		public unsafe float borderRightWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324282, RefRangeEnd = 324283, XrefRangeStart = 324279, XrefRangeEnd = 324282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderRightWidth_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00081B00 File Offset: 0x0007FD00
		public unsafe Color borderTopColor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324286, RefRangeEnd = 324289, XrefRangeStart = 324283, XrefRangeEnd = 324286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderTopColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00081B44 File Offset: 0x0007FD44
		public unsafe Length borderTopLeftRadius
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324292, RefRangeEnd = 324294, XrefRangeStart = 324289, XrefRangeEnd = 324292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderTopLeftRadius_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00081B88 File Offset: 0x0007FD88
		public unsafe Length borderTopRightRadius
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 324297, RefRangeEnd = 324301, XrefRangeStart = 324294, XrefRangeEnd = 324297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderTopRightRadius_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00081BCC File Offset: 0x0007FDCC
		public unsafe float borderTopWidth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324304, RefRangeEnd = 324307, XrefRangeStart = 324301, XrefRangeEnd = 324304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_borderTopWidth_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00081C10 File Offset: 0x0007FE10
		public unsafe Length bottom
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324310, RefRangeEnd = 324313, XrefRangeStart = 324307, XrefRangeEnd = 324310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_bottom_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00081C54 File Offset: 0x0007FE54
		public unsafe Color color
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324316, RefRangeEnd = 324318, XrefRangeStart = 324313, XrefRangeEnd = 324316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00081C98 File Offset: 0x0007FE98
		public unsafe Cursor cursor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324321, RefRangeEnd = 324323, XrefRangeStart = 324318, XrefRangeEnd = 324321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_cursor_Public_get_Cursor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Cursor(intPtr);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x00081CD4 File Offset: 0x0007FED4
		public unsafe DisplayStyle display
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324326, RefRangeEnd = 324328, XrefRangeStart = 324323, XrefRangeEnd = 324326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_display_Public_get_DisplayStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00081D18 File Offset: 0x0007FF18
		public unsafe Length flexBasis
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324331, RefRangeEnd = 324334, XrefRangeStart = 324328, XrefRangeEnd = 324331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_flexBasis_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00081D5C File Offset: 0x0007FF5C
		public unsafe FlexDirection flexDirection
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 324337, RefRangeEnd = 324341, XrefRangeStart = 324334, XrefRangeEnd = 324337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_flexDirection_Public_get_FlexDirection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00081DA0 File Offset: 0x0007FFA0
		public unsafe float flexGrow
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324344, RefRangeEnd = 324346, XrefRangeStart = 324341, XrefRangeEnd = 324344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_flexGrow_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00081DE4 File Offset: 0x0007FFE4
		public unsafe float flexShrink
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324349, RefRangeEnd = 324351, XrefRangeStart = 324346, XrefRangeEnd = 324349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_flexShrink_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00081E28 File Offset: 0x00080028
		public unsafe Wrap flexWrap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324351, XrefRangeEnd = 324354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_flexWrap_Public_get_Wrap_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x00081E6C File Offset: 0x0008006C
		public unsafe Length fontSize
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 324357, RefRangeEnd = 324362, XrefRangeStart = 324354, XrefRangeEnd = 324357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_fontSize_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x00081EB0 File Offset: 0x000800B0
		public unsafe Length height
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324365, RefRangeEnd = 324368, XrefRangeStart = 324362, XrefRangeEnd = 324365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_height_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00081EF4 File Offset: 0x000800F4
		public unsafe Justify justifyContent
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324371, RefRangeEnd = 324373, XrefRangeStart = 324368, XrefRangeEnd = 324371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_justifyContent_Public_get_Justify_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00081F38 File Offset: 0x00080138
		public unsafe Length left
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324376, RefRangeEnd = 324379, XrefRangeStart = 324373, XrefRangeEnd = 324376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_left_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00081F7C File Offset: 0x0008017C
		public unsafe Length letterSpacing
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324382, RefRangeEnd = 324385, XrefRangeStart = 324379, XrefRangeEnd = 324382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_letterSpacing_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x00081FC0 File Offset: 0x000801C0
		public unsafe Length marginBottom
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324388, RefRangeEnd = 324391, XrefRangeStart = 324385, XrefRangeEnd = 324388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_marginBottom_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00082004 File Offset: 0x00080204
		public unsafe Length marginLeft
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324394, RefRangeEnd = 324397, XrefRangeStart = 324391, XrefRangeEnd = 324394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_marginLeft_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x00082048 File Offset: 0x00080248
		public unsafe Length marginRight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324400, RefRangeEnd = 324403, XrefRangeStart = 324397, XrefRangeEnd = 324400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_marginRight_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x0008208C File Offset: 0x0008028C
		public unsafe Length marginTop
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324406, RefRangeEnd = 324409, XrefRangeStart = 324403, XrefRangeEnd = 324406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_marginTop_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x000820D0 File Offset: 0x000802D0
		public unsafe Length maxHeight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324412, RefRangeEnd = 324415, XrefRangeStart = 324409, XrefRangeEnd = 324412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_maxHeight_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x00082114 File Offset: 0x00080314
		public unsafe Length maxWidth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324418, RefRangeEnd = 324421, XrefRangeStart = 324415, XrefRangeEnd = 324418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_maxWidth_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00082158 File Offset: 0x00080358
		public unsafe Length minHeight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324424, RefRangeEnd = 324427, XrefRangeStart = 324421, XrefRangeEnd = 324424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_minHeight_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x0008219C File Offset: 0x0008039C
		public unsafe Length minWidth
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 324430, RefRangeEnd = 324434, XrefRangeStart = 324427, XrefRangeEnd = 324430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_minWidth_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x000821E0 File Offset: 0x000803E0
		public unsafe float opacity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324437, RefRangeEnd = 324438, XrefRangeStart = 324434, XrefRangeEnd = 324437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_opacity_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x00082224 File Offset: 0x00080424
		public unsafe OverflowInternal overflow
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 324441, RefRangeEnd = 324448, XrefRangeStart = 324438, XrefRangeEnd = 324441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_overflow_Public_get_OverflowInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00082268 File Offset: 0x00080468
		public unsafe Length paddingBottom
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324451, RefRangeEnd = 324454, XrefRangeStart = 324448, XrefRangeEnd = 324451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_paddingBottom_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x000822AC File Offset: 0x000804AC
		public unsafe Length paddingLeft
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324457, RefRangeEnd = 324460, XrefRangeStart = 324454, XrefRangeEnd = 324457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_paddingLeft_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x000822F0 File Offset: 0x000804F0
		public unsafe Length paddingRight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324463, RefRangeEnd = 324466, XrefRangeStart = 324460, XrefRangeEnd = 324463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_paddingRight_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x00082334 File Offset: 0x00080534
		public unsafe Length paddingTop
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324469, RefRangeEnd = 324472, XrefRangeStart = 324466, XrefRangeEnd = 324469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_paddingTop_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00082378 File Offset: 0x00080578
		public unsafe Position position
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324475, RefRangeEnd = 324478, XrefRangeStart = 324472, XrefRangeEnd = 324475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_position_Public_get_Position_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x000823BC File Offset: 0x000805BC
		public unsafe Length right
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324481, RefRangeEnd = 324484, XrefRangeStart = 324478, XrefRangeEnd = 324481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_right_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00082400 File Offset: 0x00080600
		public unsafe Rotate rotate
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 324487, RefRangeEnd = 324491, XrefRangeStart = 324484, XrefRangeEnd = 324487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_rotate_Public_get_Rotate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x00082444 File Offset: 0x00080644
		public unsafe Scale scale
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 324494, RefRangeEnd = 324499, XrefRangeStart = 324491, XrefRangeEnd = 324494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_scale_Public_get_Scale_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00082488 File Offset: 0x00080688
		public unsafe TextOverflow textOverflow
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 324502, RefRangeEnd = 324509, XrefRangeStart = 324499, XrefRangeEnd = 324502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_textOverflow_Public_get_TextOverflow_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x000824CC File Offset: 0x000806CC
		public unsafe TextShadow textShadow
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 324512, RefRangeEnd = 324523, XrefRangeStart = 324509, XrefRangeEnd = 324512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_textShadow_Public_get_TextShadow_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00082510 File Offset: 0x00080710
		public unsafe Length top
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324526, RefRangeEnd = 324529, XrefRangeStart = 324523, XrefRangeEnd = 324526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_top_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00082554 File Offset: 0x00080754
		public unsafe TransformOrigin transformOrigin
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324532, RefRangeEnd = 324533, XrefRangeStart = 324529, XrefRangeEnd = 324532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_transformOrigin_Public_get_TransformOrigin_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x00082598 File Offset: 0x00080798
		public unsafe List<TimeValue> transitionDelay
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324536, RefRangeEnd = 324538, XrefRangeStart = 324533, XrefRangeEnd = 324536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_transitionDelay_Public_get_List_1_TimeValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TimeValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x000825DC File Offset: 0x000807DC
		public unsafe List<TimeValue> transitionDuration
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324541, RefRangeEnd = 324543, XrefRangeStart = 324538, XrefRangeEnd = 324541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_transitionDuration_Public_get_List_1_TimeValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TimeValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x00082620 File Offset: 0x00080820
		public unsafe List<StylePropertyName> transitionProperty
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324546, RefRangeEnd = 324548, XrefRangeStart = 324543, XrefRangeEnd = 324546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_transitionProperty_Public_get_List_1_StylePropertyName_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StylePropertyName>>(intPtr3) : null;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x00082664 File Offset: 0x00080864
		public unsafe List<EasingFunction> transitionTimingFunction
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324551, RefRangeEnd = 324553, XrefRangeStart = 324548, XrefRangeEnd = 324551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_transitionTimingFunction_Public_get_List_1_EasingFunction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EasingFunction>>(intPtr3) : null;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x000826A8 File Offset: 0x000808A8
		public unsafe Translate translate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324556, RefRangeEnd = 324557, XrefRangeStart = 324553, XrefRangeEnd = 324556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_translate_Public_get_Translate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x000826EC File Offset: 0x000808EC
		public unsafe Color unityBackgroundImageTintColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324560, RefRangeEnd = 324562, XrefRangeStart = 324557, XrefRangeEnd = 324560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unityBackgroundImageTintColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x00082730 File Offset: 0x00080930
		public unsafe Font unityFont
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 324565, RefRangeEnd = 324570, XrefRangeStart = 324562, XrefRangeEnd = 324565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unityFont_Public_get_Font_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x00082774 File Offset: 0x00080974
		public unsafe FontDefinition unityFontDefinition
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 324573, RefRangeEnd = 324579, XrefRangeStart = 324570, XrefRangeEnd = 324573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unityFontDefinition_Public_get_FontDefinition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FontDefinition(intPtr);
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x000827B0 File Offset: 0x000809B0
		public unsafe FontStyle unityFontStyleAndWeight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324582, RefRangeEnd = 324585, XrefRangeStart = 324579, XrefRangeEnd = 324582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unityFontStyleAndWeight_Public_get_FontStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x000827F4 File Offset: 0x000809F4
		public unsafe OverflowClipBox unityOverflowClipBox
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324588, RefRangeEnd = 324590, XrefRangeStart = 324585, XrefRangeEnd = 324588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unityOverflowClipBox_Public_get_OverflowClipBox_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00082838 File Offset: 0x00080A38
		public unsafe Length unityParagraphSpacing
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324593, RefRangeEnd = 324596, XrefRangeStart = 324590, XrefRangeEnd = 324593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unityParagraphSpacing_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0008287C File Offset: 0x00080A7C
		public unsafe int unitySliceBottom
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324599, RefRangeEnd = 324600, XrefRangeStart = 324596, XrefRangeEnd = 324599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unitySliceBottom_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x000828C0 File Offset: 0x00080AC0
		public unsafe int unitySliceLeft
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 324603, RefRangeEnd = 324607, XrefRangeStart = 324600, XrefRangeEnd = 324603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unitySliceLeft_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00082904 File Offset: 0x00080B04
		public unsafe int unitySliceRight
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 324610, RefRangeEnd = 324614, XrefRangeStart = 324607, XrefRangeEnd = 324610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unitySliceRight_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00082948 File Offset: 0x00080B48
		public unsafe float unitySliceScale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324617, RefRangeEnd = 324618, XrefRangeStart = 324614, XrefRangeEnd = 324617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unitySliceScale_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0008298C File Offset: 0x00080B8C
		public unsafe int unitySliceTop
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324621, RefRangeEnd = 324624, XrefRangeStart = 324618, XrefRangeEnd = 324621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unitySliceTop_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x000829D0 File Offset: 0x00080BD0
		public unsafe TextAnchor unityTextAlign
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324627, RefRangeEnd = 324628, XrefRangeStart = 324624, XrefRangeEnd = 324627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unityTextAlign_Public_get_TextAnchor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00082A14 File Offset: 0x00080C14
		public unsafe Color unityTextOutlineColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324631, RefRangeEnd = 324632, XrefRangeStart = 324628, XrefRangeEnd = 324631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unityTextOutlineColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x00082A58 File Offset: 0x00080C58
		public unsafe float unityTextOutlineWidth
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 324635, RefRangeEnd = 324639, XrefRangeStart = 324632, XrefRangeEnd = 324635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unityTextOutlineWidth_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00082A9C File Offset: 0x00080C9C
		public unsafe TextOverflowPosition unityTextOverflowPosition
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 324642, RefRangeEnd = 324649, XrefRangeStart = 324639, XrefRangeEnd = 324642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_unityTextOverflowPosition_Public_get_TextOverflowPosition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x00082AE0 File Offset: 0x00080CE0
		public unsafe Visibility visibility
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324652, RefRangeEnd = 324653, XrefRangeStart = 324649, XrefRangeEnd = 324652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_visibility_Public_get_Visibility_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00082B24 File Offset: 0x00080D24
		public unsafe WhiteSpace whiteSpace
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 324656, RefRangeEnd = 324660, XrefRangeStart = 324653, XrefRangeEnd = 324656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_whiteSpace_Public_get_WhiteSpace_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00082B68 File Offset: 0x00080D68
		public unsafe Length width
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324663, RefRangeEnd = 324666, XrefRangeStart = 324660, XrefRangeEnd = 324663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_width_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x00082BAC File Offset: 0x00080DAC
		public unsafe Length wordSpacing
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 324669, RefRangeEnd = 324672, XrefRangeStart = 324666, XrefRangeEnd = 324669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_wordSpacing_Public_get_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00082BF0 File Offset: 0x00080DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324700, RefRangeEnd = 324701, XrefRangeStart = 324672, XrefRangeEnd = 324700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ComputedStyle Create(ref ComputedStyle parentStyle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(parentStyle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_Create_Public_Static_ComputedStyle_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ComputedStyle(intPtr);
			}
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00082C30 File Offset: 0x00080E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324701, XrefRangeEnd = 324725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ComputedStyle CreateInitial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_CreateInitial_Public_Static_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ComputedStyle(intPtr);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00082C5C File Offset: 0x00080E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324743, RefRangeEnd = 324745, XrefRangeStart = 324725, XrefRangeEnd = 324743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputedStyle Acquire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_Acquire_Public_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ComputedStyle(intPtr);
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00082C98 File Offset: 0x00080E98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324763, RefRangeEnd = 324764, XrefRangeStart = 324745, XrefRangeEnd = 324763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00082CD0 File Offset: 0x00080ED0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324785, RefRangeEnd = 324787, XrefRangeStart = 324764, XrefRangeEnd = 324785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ref ComputedStyle other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_CopyFrom_Public_Void_byref_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00082D18 File Offset: 0x00080F18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325267, RefRangeEnd = 325269, XrefRangeStart = 324787, XrefRangeEnd = 325267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyProperties(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref ComputedStyle parentStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parentStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyProperties_Public_Void_StylePropertyReader_byref_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00082D74 File Offset: 0x00080F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325278, RefRangeEnd = 325279, XrefRangeStart = 325269, XrefRangeEnd = 325278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue sv, ref ComputedStyle parentStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sv;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parentStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyStyleValue_Public_Void_StyleValue_byref_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00082DCC File Offset: 0x00080FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325298, RefRangeEnd = 325299, XrefRangeStart = 325279, XrefRangeEnd = 325298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged sv, ref ComputedStyle parentStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sv));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parentStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyStyleValueManaged_Public_Void_StyleValueManaged_byref_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00082E2C File Offset: 0x0008102C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325303, RefRangeEnd = 325304, XrefRangeStart = 325299, XrefRangeEnd = 325303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleCursor(Cursor cursor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cursor));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyStyleCursor_Public_Void_Cursor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00082E78 File Offset: 0x00081078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325307, RefRangeEnd = 325308, XrefRangeStart = 325304, XrefRangeEnd = 325307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleTextShadow(TextShadow st)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref st;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyStyleTextShadow_Public_Void_TextShadow_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00082EBC File Offset: 0x000810BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325308, XrefRangeEnd = 325330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref ComputedStyle other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyFromComputedStyle_Public_Void_StylePropertyId_byref_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00082F14 File Offset: 0x00081114
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325341, RefRangeEnd = 325343, XrefRangeStart = 325330, XrefRangeEnd = 325341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, Length newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Length_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00082F78 File Offset: 0x00081178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325360, RefRangeEnd = 325362, XrefRangeStart = 325343, XrefRangeEnd = 325360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00082FDC File Offset: 0x000811DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325481, RefRangeEnd = 325483, XrefRangeStart = 325362, XrefRangeEnd = 325481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, int newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00083040 File Offset: 0x00081240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325491, RefRangeEnd = 325493, XrefRangeStart = 325483, XrefRangeEnd = 325491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, BackgroundPosition newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_BackgroundPosition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000830A4 File Offset: 0x000812A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325501, RefRangeEnd = 325503, XrefRangeStart = 325493, XrefRangeEnd = 325501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, BackgroundRepeat newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_BackgroundRepeat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00083108 File Offset: 0x00081308
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325507, RefRangeEnd = 325509, XrefRangeStart = 325503, XrefRangeEnd = 325507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, BackgroundSize newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_BackgroundSize_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0008316C File Offset: 0x0008136C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325530, RefRangeEnd = 325532, XrefRangeStart = 325509, XrefRangeEnd = 325530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x000831D0 File Offset: 0x000813D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325541, RefRangeEnd = 325543, XrefRangeStart = 325532, XrefRangeEnd = 325541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, Background newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newValue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Background_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0008323C File Offset: 0x0008143C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325555, RefRangeEnd = 325557, XrefRangeStart = 325543, XrefRangeEnd = 325555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, Font newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Font_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x000832A4 File Offset: 0x000814A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325566, RefRangeEnd = 325568, XrefRangeStart = 325557, XrefRangeEnd = 325566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, FontDefinition newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newValue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_FontDefinition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00083310 File Offset: 0x00081510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325572, RefRangeEnd = 325574, XrefRangeStart = 325568, XrefRangeEnd = 325572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, TextShadow newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_TextShadow_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00083374 File Offset: 0x00081574
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325578, RefRangeEnd = 325580, XrefRangeStart = 325574, XrefRangeEnd = 325578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, Translate newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Translate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x000833D8 File Offset: 0x000815D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325584, RefRangeEnd = 325586, XrefRangeStart = 325580, XrefRangeEnd = 325584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, TransformOrigin newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_TransformOrigin_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0008343C File Offset: 0x0008163C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325590, RefRangeEnd = 325592, XrefRangeStart = 325586, XrefRangeEnd = 325590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, Rotate newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Rotate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x000834A0 File Offset: 0x000816A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325596, RefRangeEnd = 325598, XrefRangeStart = 325592, XrefRangeEnd = 325596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPropertyAnimation(VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, Scale newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Scale_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00083504 File Offset: 0x00081704
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326396, RefRangeEnd = 326399, XrefRangeStart = 325598, XrefRangeEnd = 326396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartAnimation(VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(oldStyle);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(newStyle);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_StartAnimation_Public_Static_Boolean_VisualElement_StylePropertyId_byref_ComputedStyle_byref_ComputedStyle_Int32_Int32_Func_2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x000835A8 File Offset: 0x000817A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326712, RefRangeEnd = 326713, XrefRangeStart = 326399, XrefRangeEnd = 326712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(oldStyle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(newStyle);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_StartAnimationAllProperty_Public_Static_Boolean_VisualElement_byref_ComputedStyle_byref_ComputedStyle_Int32_Int32_Func_2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00083640 File Offset: 0x00081840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327387, RefRangeEnd = 327388, XrefRangeStart = 326713, XrefRangeEnd = 327387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartAnimationInline(VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StyleValue sv, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sv;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easingCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_StartAnimationInline_Public_Static_Boolean_VisualElement_StylePropertyId_byref_ComputedStyle_StyleValue_Int32_Int32_Func_2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x000836E0 File Offset: 0x000818E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327391, RefRangeEnd = 327392, XrefRangeStart = 327388, XrefRangeEnd = 327391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleTransformOrigin(TransformOrigin st)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref st;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyStyleTransformOrigin_Public_Void_TransformOrigin_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00083724 File Offset: 0x00081924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327395, RefRangeEnd = 327396, XrefRangeStart = 327392, XrefRangeEnd = 327395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleTranslate(Translate translateValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref translateValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyStyleTranslate_Public_Void_Translate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00083768 File Offset: 0x00081968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327399, RefRangeEnd = 327400, XrefRangeStart = 327396, XrefRangeEnd = 327399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleRotate(Rotate rotateValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotateValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyStyleRotate_Public_Void_Rotate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000837AC File Offset: 0x000819AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327403, RefRangeEnd = 327404, XrefRangeStart = 327400, XrefRangeEnd = 327403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleScale(Scale scaleValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyStyleScale_Public_Void_Scale_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x000837F0 File Offset: 0x000819F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327407, RefRangeEnd = 327408, XrefRangeStart = 327404, XrefRangeEnd = 327407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref backgroundSizeValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyStyleBackgroundSize_Public_Void_BackgroundSize_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00083834 File Offset: 0x00081A34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327415, RefRangeEnd = 327417, XrefRangeStart = 327408, XrefRangeEnd = 327415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyInitialValue_Public_Void_StylePropertyReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0008387C File Offset: 0x00081A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327435, RefRangeEnd = 327437, XrefRangeStart = 327417, XrefRangeEnd = 327435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyInitialValue_Public_Void_StylePropertyId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000838C0 File Offset: 0x00081AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327444, RefRangeEnd = 327445, XrefRangeStart = 327437, XrefRangeEnd = 327444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref ComputedStyle parentStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parentStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyUnsetValue_Public_Void_StylePropertyReader_byref_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0008391C File Offset: 0x00081B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327445, XrefRangeEnd = 327451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref ComputedStyle parentStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parentStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_ApplyUnsetValue_Public_Void_StylePropertyId_byref_ComputedStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00083974 File Offset: 0x00081B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327821, RefRangeEnd = 327822, XrefRangeStart = 327451, XrefRangeEnd = 327821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_CompareChanges_Public_Static_VersionChangeType_byref_ComputedStyle_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0000CB04 File Offset: 0x0000AD04
		public ComputedStyle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0000CB0D File Offset: 0x0000AD0D
		public ComputedStyle()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr))
		{
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x000839CC File Offset: 0x00081BCC
		// (set) Token: 0x06001CBC RID: 7356 RVA: 0x0000CB1F File Offset: 0x0000AD1F
		public StyleDataRef<InheritedData> inheritedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_inheritedData);
				return new StyleDataRef<InheritedData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleDataRef<InheritedData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_inheritedData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StyleDataRef<InheritedData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x000839FC File Offset: 0x00081BFC
		// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0000CB4D File Offset: 0x0000AD4D
		public StyleDataRef<LayoutData> layoutData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_layoutData);
				return new StyleDataRef<LayoutData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleDataRef<LayoutData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_layoutData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StyleDataRef<LayoutData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00083A2C File Offset: 0x00081C2C
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x0000CB7B File Offset: 0x0000AD7B
		public StyleDataRef<RareData> rareData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_rareData);
				return new StyleDataRef<RareData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleDataRef<RareData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_rareData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StyleDataRef<RareData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00083A5C File Offset: 0x00081C5C
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x0000CBA9 File Offset: 0x0000ADA9
		public StyleDataRef<TransformData> transformData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_transformData);
				return new StyleDataRef<TransformData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleDataRef<TransformData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_transformData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StyleDataRef<TransformData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00083A8C File Offset: 0x00081C8C
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x0000CBD7 File Offset: 0x0000ADD7
		public StyleDataRef<TransitionData> transitionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_transitionData);
				return new StyleDataRef<TransitionData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleDataRef<TransitionData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_transitionData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StyleDataRef<TransitionData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00083ABC File Offset: 0x00081CBC
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x0000CC05 File Offset: 0x0000AE05
		public StyleDataRef<VisualData> visualData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_visualData);
				return new StyleDataRef<VisualData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleDataRef<VisualData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_visualData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StyleDataRef<VisualData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00083AEC File Offset: 0x00081CEC
		// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x0000CC33 File Offset: 0x0000AE33
		public unsafe UnityEngine.Yoga.YogaNode yogaNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_yogaNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Yoga.YogaNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_yogaNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00083B1C File Offset: 0x00081D1C
		// (set) Token: 0x06001CCA RID: 7370 RVA: 0x0000CC52 File Offset: 0x0000AE52
		public unsafe Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_customProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_customProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00083B4C File Offset: 0x00081D4C
		// (set) Token: 0x06001CCC RID: 7372 RVA: 0x0000CC71 File Offset: 0x0000AE71
		public unsafe long matchingRulesHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_matchingRulesHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_matchingRulesHash)) = value;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00083B74 File Offset: 0x00081D74
		// (set) Token: 0x06001CCE RID: 7374 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		public unsafe float dpiScaling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_dpiScaling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_dpiScaling)) = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x00083B9C File Offset: 0x00081D9C
		// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x0000CCA7 File Offset: 0x0000AEA7
		public unsafe Il2CppReferenceArray<ComputedTransitionProperty> computedTransitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_computedTransitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ComputedTransitionProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_computedTransitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00083BCC File Offset: 0x00081DCC
		public static ComputedStyle Create()
		{
			return UnityEngine.UIElements.StyleSheets.InitialStyle.Acquire();
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0000CCC6 File Offset: 0x0000AEC6
		public static bool StartAnimationInlineTextShadow(VisualElement element, ref ComputedStyle computedStyle, StyleTextShadow textShadow, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0000CCD3 File Offset: 0x0000AED3
		public static bool StartAnimationInlineRotate(VisualElement element, ref ComputedStyle computedStyle, StyleRotate rotate, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
		public static bool StartAnimationInlineScale(VisualElement element, ref ComputedStyle computedStyle, StyleScale scale, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0000CCED File Offset: 0x0000AEED
		public static bool StartAnimationInlineTransformOrigin(VisualElement element, ref ComputedStyle computedStyle, StyleTransformOrigin transformOrigin, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0000CCFA File Offset: 0x0000AEFA
		public static bool StartAnimationInlineBackgroundSize(VisualElement element, ref ComputedStyle computedStyle, StyleBackgroundSize backgroundSize, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeFieldInfoPtr_inheritedData;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeFieldInfoPtr_layoutData;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeFieldInfoPtr_rareData;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeFieldInfoPtr_transformData;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeFieldInfoPtr_transitionData;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeFieldInfoPtr_visualData;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeFieldInfoPtr_yogaNode;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeFieldInfoPtr_customProperties;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeFieldInfoPtr_matchingRulesHash;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeFieldInfoPtr_dpiScaling;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeFieldInfoPtr_computedTransitions;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_get_customPropertiesCount_Public_get_Int32_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_get_hasTransition_Public_get_Boolean_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeApply_Public_Void_byref_ComputedStyle_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_SyncWithLayout_Public_Void_YogaNode_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGlobalKeyword_Private_Boolean_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGlobalKeyword_Private_Boolean_StylePropertyId_StyleKeyword_byref_ComputedStyle_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomStyleProperty_Private_Void_StylePropertyReader_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_ApplyCustomStyleProperty_Private_Void_StylePropertyReader_0;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAllPropertyInitial_Private_Void_0;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeMethodInfoPtr_ResetComputedTransitions_Private_Void_0;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr_StartAnimationInlineTranslate_Public_Static_Boolean_VisualElement_byref_ComputedStyle_StyleTranslate_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_get_alignContent_Public_get_Align_0;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_get_alignItems_Public_get_Align_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_get_alignSelf_Public_get_Align_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundImage_Public_get_Background_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundPositionX_Public_get_BackgroundPosition_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundPositionY_Public_get_BackgroundPosition_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundRepeat_Public_get_BackgroundRepeat_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundSize_Public_get_BackgroundSize_0;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeMethodInfoPtr_get_borderBottomColor_Public_get_Color_0;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeMethodInfoPtr_get_borderBottomLeftRadius_Public_get_Length_0;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr_get_borderBottomRightRadius_Public_get_Length_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr_get_borderBottomWidth_Public_get_Single_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_get_borderLeftColor_Public_get_Color_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_get_borderLeftWidth_Public_get_Single_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_get_borderRightColor_Public_get_Color_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_get_borderRightWidth_Public_get_Single_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_get_borderTopColor_Public_get_Color_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_get_borderTopLeftRadius_Public_get_Length_0;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr_get_borderTopRightRadius_Public_get_Length_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_get_borderTopWidth_Public_get_Single_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_get_bottom_Public_get_Length_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr_get_cursor_Public_get_Cursor_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_get_display_Public_get_DisplayStyle_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_get_flexBasis_Public_get_Length_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_get_flexDirection_Public_get_FlexDirection_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_get_flexGrow_Public_get_Single_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_get_flexShrink_Public_get_Single_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_get_flexWrap_Public_get_Wrap_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Length_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Length_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_get_justifyContent_Public_get_Justify_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_get_Length_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_get_letterSpacing_Public_get_Length_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_get_marginBottom_Public_get_Length_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_get_marginLeft_Public_get_Length_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_get_marginRight_Public_get_Length_0;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeMethodInfoPtr_get_marginTop_Public_get_Length_0;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_get_maxHeight_Public_get_Length_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_get_maxWidth_Public_get_Length_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_get_Length_0;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_get_Length_0;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeMethodInfoPtr_get_opacity_Public_get_Single_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr_get_overflow_Public_get_OverflowInternal_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_get_paddingBottom_Public_get_Length_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_get_paddingLeft_Public_get_Length_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr_get_paddingRight_Public_get_Length_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeMethodInfoPtr_get_paddingTop_Public_get_Length_0;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Position_0;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_get_Length_0;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeMethodInfoPtr_get_rotate_Public_get_Rotate_0;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Scale_0;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr_get_textOverflow_Public_get_TextOverflow_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_get_textShadow_Public_get_TextShadow_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_get_top_Public_get_Length_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_get_transformOrigin_Public_get_TransformOrigin_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionDelay_Public_get_List_1_TimeValue_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionDuration_Public_get_List_1_TimeValue_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionProperty_Public_get_List_1_StylePropertyName_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr_get_transitionTimingFunction_Public_get_List_1_EasingFunction_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr_get_translate_Public_get_Translate_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_get_unityBackgroundImageTintColor_Public_get_Color_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_get_unityFont_Public_get_Font_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_get_unityFontDefinition_Public_get_FontDefinition_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_get_unityFontStyleAndWeight_Public_get_FontStyle_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_get_unityOverflowClipBox_Public_get_OverflowClipBox_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_get_unityParagraphSpacing_Public_get_Length_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_get_unitySliceBottom_Public_get_Int32_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_get_unitySliceLeft_Public_get_Int32_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_get_unitySliceRight_Public_get_Int32_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_get_unitySliceScale_Public_get_Single_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr_get_unitySliceTop_Public_get_Int32_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_get_unityTextAlign_Public_get_TextAnchor_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_get_unityTextOutlineColor_Public_get_Color_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_get_unityTextOutlineWidth_Public_get_Single_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_get_unityTextOverflowPosition_Public_get_TextOverflowPosition_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_get_visibility_Public_get_Visibility_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteSpace_Public_get_WhiteSpace_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Length_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_get_wordSpacing_Public_get_Length_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ComputedStyle_byref_ComputedStyle_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_CreateInitial_Public_Static_ComputedStyle_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_ComputedStyle_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_byref_ComputedStyle_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_ApplyProperties_Public_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleValue_Public_Void_StyleValue_byref_ComputedStyle_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleValueManaged_Public_Void_StyleValueManaged_byref_ComputedStyle_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleCursor_Public_Void_Cursor_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleTextShadow_Public_Void_TextShadow_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFromComputedStyle_Public_Void_StylePropertyId_byref_ComputedStyle_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Length_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Single_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Int32_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_BackgroundPosition_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_BackgroundRepeat_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_BackgroundSize_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Color_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Background_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Font_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_FontDefinition_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_TextShadow_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Translate_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_TransformOrigin_0;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Rotate_0;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPropertyAnimation_Public_Void_VisualElement_StylePropertyId_Scale_0;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeMethodInfoPtr_StartAnimation_Public_Static_Boolean_VisualElement_StylePropertyId_byref_ComputedStyle_byref_ComputedStyle_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_StartAnimationAllProperty_Public_Static_Boolean_VisualElement_byref_ComputedStyle_byref_ComputedStyle_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_StartAnimationInline_Public_Static_Boolean_VisualElement_StylePropertyId_byref_ComputedStyle_StyleValue_Int32_Int32_Func_2_Single_Single_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleTransformOrigin_Public_Void_TransformOrigin_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleTranslate_Public_Void_Translate_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleRotate_Public_Void_Rotate_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleScale_Public_Void_Scale_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleBackgroundSize_Public_Void_BackgroundSize_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInitialValue_Public_Void_StylePropertyReader_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInitialValue_Public_Void_StylePropertyId_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_ApplyUnsetValue_Public_Void_StylePropertyReader_byref_ComputedStyle_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_ApplyUnsetValue_Public_Void_StylePropertyId_byref_ComputedStyle_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_CompareChanges_Public_Static_VersionChangeType_byref_ComputedStyle_byref_ComputedStyle_0;
	}
}
