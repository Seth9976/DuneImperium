using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x02000185 RID: 389
	public class InlineStyleAccess : StyleValueCollection
	{
		// Token: 0x06001D2A RID: 7466 RVA: 0x000851D0 File Offset: 0x000833D0
		// Note: this type is marked as 'beforefieldinit'.
		static InlineStyleAccess()
		{
			Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "InlineStyleAccess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr);
			InlineStyleAccess.NativeFieldInfoPtr_s_StylePropertyReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "s_StylePropertyReader");
			InlineStyleAccess.NativeFieldInfoPtr_m_ValuesManaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_ValuesManaged");
			InlineStyleAccess.NativeFieldInfoPtr__ve_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "<ve>k__BackingField");
			InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_HasInlineCursor");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineCursor");
			InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTextShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_HasInlineTextShadow");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineTextShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineTextShadow");
			InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTransformOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_HasInlineTransformOrigin");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineTransformOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineTransformOrigin");
			InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTranslate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_HasInlineTranslate");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineTranslateOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineTranslateOperation");
			InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_HasInlineRotate");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineRotateOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineRotateOperation");
			InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_HasInlineScale");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineScale");
			InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineBackgroundSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_HasInlineBackgroundSize");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineBackgroundSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineBackgroundSize");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineRule");
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_backgroundColor_Private_Virtual_Final_New_set_Void_StyleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667588);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomColor_Private_Virtual_Final_New_set_Void_StyleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667589);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomLeftRadius_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667590);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomRightRadius_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667591);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667592);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderLeftColor_Private_Virtual_Final_New_set_Void_StyleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667593);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderLeftWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667594);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderRightColor_Private_Virtual_Final_New_set_Void_StyleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667595);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderRightWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667596);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopColor_Private_Virtual_Final_New_set_Void_StyleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667597);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopLeftRadius_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667598);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopRightRadius_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667599);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667600);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_bottom_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667601);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_color_Private_Virtual_Final_New_set_Void_StyleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667602);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_display_Private_Virtual_Final_New_get_StyleEnum_1_DisplayStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667603);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_display_Private_Virtual_Final_New_set_Void_StyleEnum_1_DisplayStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667604);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexBasis_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667605);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexDirection_Private_Virtual_Final_New_set_Void_StyleEnum_1_FlexDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667606);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexGrow_Private_Virtual_Final_New_set_Void_StyleFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667607);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexShrink_Private_Virtual_Final_New_set_Void_StyleFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667608);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_fontSize_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667609);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_height_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667610);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_left_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667611);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginBottom_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667612);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginLeft_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667613);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginRight_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667614);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginTop_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667615);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_maxHeight_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667616);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_maxWidth_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667617);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_minWidth_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667618);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_opacity_Private_Virtual_Final_New_set_Void_StyleFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667619);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_overflow_Private_Virtual_Final_New_set_Void_StyleEnum_1_Overflow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667620);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingBottom_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667621);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingLeft_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667622);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingRight_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667623);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_paddingTop_Private_Virtual_Final_New_get_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667624);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingTop_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667625);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_position_Private_Virtual_Final_New_set_Void_StyleEnum_1_Position_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667626);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_right_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667627);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_top_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667628);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_unityBackgroundImageTintColor_Private_Virtual_Final_New_set_Void_StyleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667629);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_unityFont_Private_Virtual_Final_New_set_Void_StyleFont_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667630);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_unityFontDefinition_Private_Virtual_Final_New_set_Void_StyleFontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667631);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_visibility_Private_Virtual_Final_New_set_Void_StyleEnum_1_Visibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667632);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_width_Private_Virtual_Final_New_get_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667633);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_width_Private_Virtual_Final_New_set_Void_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667634);
			InlineStyleAccess.NativeMethodInfoPtr_get_ve_Private_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667635);
			InlineStyleAccess.NativeMethodInfoPtr_set_ve_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667636);
			InlineStyleAccess.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667637);
			InlineStyleAccess.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667638);
			InlineStyleAccess.NativeMethodInfoPtr_SetInlineRule_Public_Void_StyleSheet_StyleRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667639);
			InlineStyleAccess.NativeMethodInfoPtr_IsValueSet_Public_Boolean_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667640);
			InlineStyleAccess.NativeMethodInfoPtr_ApplyInlineStyles_Public_Void_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667641);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_cursor_Private_Virtual_Final_New_get_StyleCursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667642);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_textShadow_Private_Virtual_Final_New_get_StyleTextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667643);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_backgroundSize_Private_Virtual_Final_New_get_StyleBackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667644);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_transformOrigin_Private_Virtual_Final_New_get_StyleTransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667645);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_translate_Private_Virtual_Final_New_get_StyleTranslate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667646);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_translate_Private_Virtual_Final_New_set_Void_StyleTranslate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667647);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_rotate_Private_Virtual_Final_New_get_StyleRotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667648);
			InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_scale_Private_Virtual_Final_New_get_StyleScale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667649);
			InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667650);
			InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667651);
			InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667652);
			InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleEnum_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667653);
			InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleFontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667654);
			InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleFont_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667655);
			InlineStyleAccess.NativeMethodInfoPtr_SetInlineTranslate_Private_Boolean_StyleTranslate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667656);
			InlineStyleAccess.NativeMethodInfoPtr_ApplyStyleTranslate_Private_Void_StyleTranslate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667657);
			InlineStyleAccess.NativeMethodInfoPtr_ApplyStyleValue_Private_Void_StyleValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667658);
			InlineStyleAccess.NativeMethodInfoPtr_RemoveInlineStyle_Private_Boolean_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667659);
			InlineStyleAccess.NativeMethodInfoPtr_ApplyFromComputedStyle_Private_Void_StylePropertyId_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667660);
			InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineCursor_Public_Boolean_byref_StyleCursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667661);
			InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineTextShadow_Public_Boolean_byref_StyleTextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667662);
			InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineTransformOrigin_Public_Boolean_byref_StyleTransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667663);
			InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineTranslate_Public_Boolean_byref_StyleTranslate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667664);
			InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineRotate_Public_Boolean_byref_StyleRotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667665);
			InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineScale_Public_Boolean_byref_StyleScale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667666);
			InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineBackgroundSize_Public_Boolean_byref_StyleBackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, 100667667);
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x00087388 File Offset: 0x00085588
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x000859A8 File Offset: 0x00083BA8
		public unsafe virtual StyleColor UnityEngine.UIElements.IStyle.backgroundColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundColor);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328543, XrefRangeEnd = 328545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_backgroundColor_Private_Virtual_Final_New_set_Void_StyleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x000874F8 File Offset: 0x000856F8
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x000859E8 File Offset: 0x00083BE8
		public unsafe virtual StyleColor UnityEngine.UIElements.IStyle.borderBottomColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomColor);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328545, XrefRangeEnd = 328547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomColor_Private_Virtual_Final_New_set_Void_StyleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00087518 File Offset: 0x00085718
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x00085A28 File Offset: 0x00083C28
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomLeftRadius);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328547, XrefRangeEnd = 328549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomLeftRadius_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00087538 File Offset: 0x00085738
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x00085A68 File Offset: 0x00083C68
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomRightRadius);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328549, XrefRangeEnd = 328551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomRightRadius_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00087558 File Offset: 0x00085758
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x00085AA8 File Offset: 0x00083CA8
		public unsafe virtual StyleFloat UnityEngine.UIElements.IStyle.borderBottomWidth
		{
			get
			{
				return base.GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomWidth);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328551, XrefRangeEnd = 328556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x00087578 File Offset: 0x00085778
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x00085AE8 File Offset: 0x00083CE8
		public unsafe virtual StyleColor UnityEngine.UIElements.IStyle.borderLeftColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftColor);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328556, XrefRangeEnd = 328558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderLeftColor_Private_Virtual_Final_New_set_Void_StyleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x00087598 File Offset: 0x00085798
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x00085B28 File Offset: 0x00083D28
		public unsafe virtual StyleFloat UnityEngine.UIElements.IStyle.borderLeftWidth
		{
			get
			{
				return base.GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftWidth);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328558, XrefRangeEnd = 328563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderLeftWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x000875B8 File Offset: 0x000857B8
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x00085B68 File Offset: 0x00083D68
		public unsafe virtual StyleColor UnityEngine.UIElements.IStyle.borderRightColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightColor);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328563, XrefRangeEnd = 328565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderRightColor_Private_Virtual_Final_New_set_Void_StyleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x000875D8 File Offset: 0x000857D8
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x00085BA8 File Offset: 0x00083DA8
		public unsafe virtual StyleFloat UnityEngine.UIElements.IStyle.borderRightWidth
		{
			get
			{
				return base.GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightWidth);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328565, XrefRangeEnd = 328570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderRightWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x000875F8 File Offset: 0x000857F8
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x00085BE8 File Offset: 0x00083DE8
		public unsafe virtual StyleColor UnityEngine.UIElements.IStyle.borderTopColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopColor);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328570, XrefRangeEnd = 328572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopColor_Private_Virtual_Final_New_set_Void_StyleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00087618 File Offset: 0x00085818
		// (set) Token: 0x06001D35 RID: 7477 RVA: 0x00085C28 File Offset: 0x00083E28
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopLeftRadius);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328572, XrefRangeEnd = 328574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopLeftRadius_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00087638 File Offset: 0x00085838
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x00085C68 File Offset: 0x00083E68
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopRightRadius);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328574, XrefRangeEnd = 328576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopRightRadius_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x00087658 File Offset: 0x00085858
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00085CA8 File Offset: 0x00083EA8
		public unsafe virtual StyleFloat UnityEngine.UIElements.IStyle.borderTopWidth
		{
			get
			{
				return base.GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopWidth);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328576, XrefRangeEnd = 328581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00087678 File Offset: 0x00085878
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x00085CE8 File Offset: 0x00083EE8
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.bottom
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Bottom);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328581, XrefRangeEnd = 328587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_bottom_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x00087698 File Offset: 0x00085898
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x00085D28 File Offset: 0x00083F28
		public unsafe virtual StyleColor UnityEngine.UIElements.IStyle.color
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.Color);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328587, XrefRangeEnd = 328589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_color_Private_Virtual_Final_New_set_Void_StyleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00085D68 File Offset: 0x00083F68
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00085DA0 File Offset: 0x00083FA0
		public unsafe virtual StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.display
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328589, XrefRangeEnd = 328595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_display_Private_Virtual_Final_New_get_StyleEnum_1_DisplayStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StyleEnum<DisplayStyle>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328595, XrefRangeEnd = 328602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_display_Private_Virtual_Final_New_set_Void_StyleEnum_1_DisplayStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x000876B8 File Offset: 0x000858B8
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x00085DE8 File Offset: 0x00083FE8
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.flexBasis
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexBasis);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328602, XrefRangeEnd = 328608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexBasis_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x000876D8 File Offset: 0x000858D8
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00085E28 File Offset: 0x00084028
		public unsafe virtual StyleEnum<FlexDirection> UnityEngine.UIElements.IStyle.flexDirection
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexDirection);
				return new StyleEnum<FlexDirection>((FlexDirection)styleInt.value, styleInt.keyword);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328608, XrefRangeEnd = 328615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexDirection_Private_Virtual_Final_New_set_Void_StyleEnum_1_FlexDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x0008770C File Offset: 0x0008590C
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00085E70 File Offset: 0x00084070
		public unsafe virtual StyleFloat UnityEngine.UIElements.IStyle.flexGrow
		{
			get
			{
				return base.GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexGrow);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328615, XrefRangeEnd = 328620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexGrow_Private_Virtual_Final_New_set_Void_StyleFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x0008772C File Offset: 0x0008592C
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x00085EB0 File Offset: 0x000840B0
		public unsafe virtual StyleFloat UnityEngine.UIElements.IStyle.flexShrink
		{
			get
			{
				return base.GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexShrink);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328620, XrefRangeEnd = 328625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexShrink_Private_Virtual_Final_New_set_Void_StyleFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x000877D0 File Offset: 0x000859D0
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x00085EF0 File Offset: 0x000840F0
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.fontSize
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328625, XrefRangeEnd = 328627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_fontSize_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x000877F0 File Offset: 0x000859F0
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x00085F30 File Offset: 0x00084130
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.height
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Height);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328627, XrefRangeEnd = 328633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_height_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x00087894 File Offset: 0x00085A94
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x00085F70 File Offset: 0x00084170
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.left
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Left);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328633, XrefRangeEnd = 328639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_left_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00087908 File Offset: 0x00085B08
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x00085FB0 File Offset: 0x000841B0
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.marginBottom
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginBottom);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328639, XrefRangeEnd = 328645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginBottom_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x00087928 File Offset: 0x00085B28
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x00085FF0 File Offset: 0x000841F0
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.marginLeft
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginLeft);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328645, XrefRangeEnd = 328651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginLeft_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x00087948 File Offset: 0x00085B48
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x00086030 File Offset: 0x00084230
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.marginRight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginRight);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328651, XrefRangeEnd = 328657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginRight_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x00087968 File Offset: 0x00085B68
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x00086070 File Offset: 0x00084270
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.marginTop
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginTop);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328657, XrefRangeEnd = 328663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginTop_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x00087988 File Offset: 0x00085B88
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x000860B0 File Offset: 0x000842B0
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.maxHeight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxHeight);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328663, XrefRangeEnd = 328669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_maxHeight_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x000879A8 File Offset: 0x00085BA8
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x000860F0 File Offset: 0x000842F0
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.maxWidth
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxWidth);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328669, XrefRangeEnd = 328675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_maxWidth_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00087A3C File Offset: 0x00085C3C
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x00086130 File Offset: 0x00084330
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.minWidth
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MinWidth);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328675, XrefRangeEnd = 328681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_minWidth_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x00087A5C File Offset: 0x00085C5C
		// (set) Token: 0x06001D4A RID: 7498 RVA: 0x00086170 File Offset: 0x00084370
		public unsafe virtual StyleFloat UnityEngine.UIElements.IStyle.opacity
		{
			get
			{
				return base.GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.Opacity);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328681, XrefRangeEnd = 328683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_opacity_Private_Virtual_Final_New_set_Void_StyleFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00087A7C File Offset: 0x00085C7C
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x000861B0 File Offset: 0x000843B0
		public unsafe virtual StyleEnum<Overflow> UnityEngine.UIElements.IStyle.overflow
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.Overflow);
				return new StyleEnum<Overflow>((Overflow)styleInt.value, styleInt.keyword);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328683, XrefRangeEnd = 328699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_overflow_Private_Virtual_Final_New_set_Void_StyleEnum_1_Overflow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x00087AB0 File Offset: 0x00085CB0
		// (set) Token: 0x06001D4C RID: 7500 RVA: 0x000861F8 File Offset: 0x000843F8
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.paddingBottom
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingBottom);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328699, XrefRangeEnd = 328705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingBottom_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x00087AD0 File Offset: 0x00085CD0
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x00086238 File Offset: 0x00084438
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.paddingLeft
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingLeft);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328705, XrefRangeEnd = 328711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingLeft_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00087AF0 File Offset: 0x00085CF0
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x00086278 File Offset: 0x00084478
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.paddingRight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingRight);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328711, XrefRangeEnd = 328717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingRight_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x000862B8 File Offset: 0x000844B8
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x000862F4 File Offset: 0x000844F4
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.paddingTop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328717, XrefRangeEnd = 328718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_paddingTop_Private_Virtual_Final_New_get_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328718, XrefRangeEnd = 328724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingTop_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00087B10 File Offset: 0x00085D10
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x00086334 File Offset: 0x00084534
		public unsafe virtual StyleEnum<Position> UnityEngine.UIElements.IStyle.position
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.Position);
				return new StyleEnum<Position>((Position)styleInt.value, styleInt.keyword);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328724, XrefRangeEnd = 328731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_position_Private_Virtual_Final_New_set_Void_StyleEnum_1_Position_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x00087B44 File Offset: 0x00085D44
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x0008637C File Offset: 0x0008457C
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.right
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Right);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328731, XrefRangeEnd = 328737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_right_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00087BCC File Offset: 0x00085DCC
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x000863BC File Offset: 0x000845BC
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.top
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Top);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328737, XrefRangeEnd = 328743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_top_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x00087BEC File Offset: 0x00085DEC
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x000863FC File Offset: 0x000845FC
		public unsafe virtual StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundImageTintColor);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328743, XrefRangeEnd = 328745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_unityBackgroundImageTintColor_Private_Virtual_Final_New_set_Void_StyleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x00087C0C File Offset: 0x00085E0C
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0008643C File Offset: 0x0008463C
		public unsafe virtual StyleFont UnityEngine.UIElements.IStyle.unityFont
		{
			get
			{
				return base.GetStyleFont(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFont);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328745, XrefRangeEnd = 328747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_unityFont_Private_Virtual_Final_New_set_Void_StyleFont_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x00087C2C File Offset: 0x00085E2C
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x00086484 File Offset: 0x00084684
		public unsafe virtual StyleFontDefinition UnityEngine.UIElements.IStyle.unityFontDefinition
		{
			get
			{
				return base.GetStyleFontDefinition(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontDefinition);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328747, XrefRangeEnd = 328749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_unityFontDefinition_Private_Virtual_Final_New_set_Void_StyleFontDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x0008808C File Offset: 0x0008628C
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x000864CC File Offset: 0x000846CC
		public unsafe virtual StyleEnum<Visibility> UnityEngine.UIElements.IStyle.visibility
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.Visibility);
				return new StyleEnum<Visibility>((Visibility)styleInt.value, styleInt.keyword);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328749, XrefRangeEnd = 328753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_visibility_Private_Virtual_Final_New_set_Void_StyleEnum_1_Visibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00086514 File Offset: 0x00084714
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x00086550 File Offset: 0x00084750
		public unsafe virtual StyleLength UnityEngine.UIElements.IStyle.width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328753, XrefRangeEnd = 328754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_width_Private_Virtual_Final_New_get_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328754, XrefRangeEnd = 328760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_width_Private_Virtual_Final_New_set_Void_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00086590 File Offset: 0x00084790
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x000865D0 File Offset: 0x000847D0
		public unsafe VisualElement ve
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_get_ve_Private_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_set_ve_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00086614 File Offset: 0x00084814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328762, RefRangeEnd = 328764, XrefRangeStart = 328760, XrefRangeEnd = 328762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InlineStyleAccess(VisualElement ve)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00086660 File Offset: 0x00084860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328764, XrefRangeEnd = 328773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InlineStyleAccess.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x0008669C File Offset: 0x0008489C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328783, RefRangeEnd = 328784, XrefRangeStart = 328773, XrefRangeEnd = 328783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInlineRule(StyleSheet sheet, StyleRule rule)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_SetInlineRule_Public_Void_StyleSheet_StyleRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x000866F0 File Offset: 0x000848F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328823, RefRangeEnd = 328825, XrefRangeStart = 328784, XrefRangeEnd = 328823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValueSet(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_IsValueSet_Public_Boolean_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x0008673C File Offset: 0x0008493C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328920, RefRangeEnd = 328922, XrefRangeStart = 328825, XrefRangeEnd = 328920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInlineStyles(ref ComputedStyle computedStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_ApplyInlineStyles_Public_Void_byref_ComputedStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x00086780 File Offset: 0x00084980
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x00088178 File Offset: 0x00086378
		public unsafe virtual StyleCursor UnityEngine.UIElements.IStyle.cursor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328922, XrefRangeEnd = 328923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_cursor_Private_Virtual_Final_New_get_StyleCursor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StyleCursor(intPtr);
			}
			set
			{
				bool flag = this.SetInlineCursor(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles);
				}
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x000867B8 File Offset: 0x000849B8
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x000881A4 File Offset: 0x000863A4
		public unsafe virtual StyleTextShadow UnityEngine.UIElements.IStyle.textShadow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_textShadow_Private_Virtual_Final_New_get_StyleTextShadow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = this.SetInlineTextShadow(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x000867F4 File Offset: 0x000849F4
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x000881D0 File Offset: 0x000863D0
		public unsafe virtual StyleBackgroundSize UnityEngine.UIElements.IStyle.backgroundSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_backgroundSize_Private_Virtual_Final_New_get_StyleBackgroundSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = this.SetInlineBackgroundSize(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x00086830 File Offset: 0x00084A30
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x00088328 File Offset: 0x00086528
		public unsafe virtual StyleTransformOrigin UnityEngine.UIElements.IStyle.transformOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_transformOrigin_Private_Virtual_Final_New_get_StyleTransformOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = this.SetInlineTransformOrigin(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0008686C File Offset: 0x00084A6C
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x000868A8 File Offset: 0x00084AA8
		public unsafe virtual StyleTranslate UnityEngine.UIElements.IStyle.translate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_translate_Private_Virtual_Final_New_get_StyleTranslate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328923, XrefRangeEnd = 328935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_translate_Private_Virtual_Final_New_set_Void_StyleTranslate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x000868E8 File Offset: 0x00084AE8
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x00088354 File Offset: 0x00086554
		public unsafe virtual StyleRotate UnityEngine.UIElements.IStyle.rotate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_rotate_Private_Virtual_Final_New_get_StyleRotate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = this.SetInlineRotate(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00086924 File Offset: 0x00084B24
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x00088380 File Offset: 0x00086580
		public unsafe virtual StyleScale UnityEngine.UIElements.IStyle.scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_scale_Private_Virtual_Final_New_get_StyleScale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = this.SetInlineScale(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00086960 File Offset: 0x00084B60
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 328948, RefRangeEnd = 328971, XrefRangeStart = 328935, XrefRangeEnd = 328948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleLength inlineValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inlineValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x000869B8 File Offset: 0x00084BB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 328983, RefRangeEnd = 328990, XrefRangeStart = 328971, XrefRangeEnd = 328983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleFloat inlineValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inlineValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00086A10 File Offset: 0x00084C10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 329002, RefRangeEnd = 329009, XrefRangeStart = 328990, XrefRangeEnd = 329002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleColor inlineValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inlineValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00086A68 File Offset: 0x00084C68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 329014, RefRangeEnd = 329019, XrefRangeStart = 329009, XrefRangeEnd = 329014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetStyleValue<T>(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleEnum<T> inlineValue) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inlineValue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.MethodInfoStoreGeneric_SetStyleValue_Private_Boolean_StylePropertyId_StyleEnum_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00086AC8 File Offset: 0x00084CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329064, RefRangeEnd = 329065, XrefRangeStart = 329019, XrefRangeEnd = 329064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleFontDefinition inlineValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inlineValue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleFontDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00086B28 File Offset: 0x00084D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329093, RefRangeEnd = 329094, XrefRangeStart = 329065, XrefRangeEnd = 329093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleFont inlineValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inlineValue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleFont_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x00086B88 File Offset: 0x00084D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329094, XrefRangeEnd = 329099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetInlineTranslate(StyleTranslate inlineValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inlineValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_SetInlineTranslate_Private_Boolean_StyleTranslate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00086BD4 File Offset: 0x00084DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329114, RefRangeEnd = 329115, XrefRangeStart = 329099, XrefRangeEnd = 329114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleTranslate(StyleTranslate translate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref translate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_ApplyStyleTranslate_Private_Void_StyleTranslate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00086C14 File Offset: 0x00084E14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 329142, RefRangeEnd = 329147, XrefRangeStart = 329115, XrefRangeEnd = 329142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_ApplyStyleValue_Private_Void_StyleValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00086C54 File Offset: 0x00084E54
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 329159, RefRangeEnd = 329165, XrefRangeStart = 329147, XrefRangeEnd = 329159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_RemoveInlineStyle_Private_Boolean_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00086CA0 File Offset: 0x00084EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329184, RefRangeEnd = 329185, XrefRangeStart = 329165, XrefRangeEnd = 329184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref ComputedStyle newStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(newStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_ApplyFromComputedStyle_Private_Void_StylePropertyId_byref_ComputedStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00086CF4 File Offset: 0x00084EF4
		[CallerCount(0)]
		public unsafe bool TryGetInlineCursor(ref StyleCursor value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineCursor_Public_Boolean_byref_StyleCursor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00086D44 File Offset: 0x00084F44
		[CallerCount(0)]
		public unsafe bool TryGetInlineTextShadow(ref StyleTextShadow value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineTextShadow_Public_Boolean_byref_StyleTextShadow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00086D90 File Offset: 0x00084F90
		[CallerCount(0)]
		public unsafe bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineTransformOrigin_Public_Boolean_byref_StyleTransformOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00086DDC File Offset: 0x00084FDC
		[CallerCount(0)]
		public unsafe bool TryGetInlineTranslate(ref StyleTranslate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineTranslate_Public_Boolean_byref_StyleTranslate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00086E28 File Offset: 0x00085028
		[CallerCount(0)]
		public unsafe bool TryGetInlineRotate(ref StyleRotate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineRotate_Public_Boolean_byref_StyleRotate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00086E74 File Offset: 0x00085074
		[CallerCount(0)]
		public unsafe bool TryGetInlineScale(ref StyleScale value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineScale_Public_Boolean_byref_StyleScale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00086EC0 File Offset: 0x000850C0
		[CallerCount(0)]
		public unsafe bool TryGetInlineBackgroundSize(ref StyleBackgroundSize value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InlineStyleAccess.NativeMethodInfoPtr_TryGetInlineBackgroundSize_Public_Boolean_byref_StyleBackgroundSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0000CE64 File Offset: 0x0000B064
		public InlineStyleAccess(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00086F0C File Offset: 0x0008510C
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0000CE6D File Offset: 0x0000B06D
		public unsafe static UnityEngine.UIElements.StyleSheets.StylePropertyReader s_StylePropertyReader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InlineStyleAccess.NativeFieldInfoPtr_s_StylePropertyReader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.StyleSheets.StylePropertyReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InlineStyleAccess.NativeFieldInfoPtr_s_StylePropertyReader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00086F34 File Offset: 0x00085134
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0000CE7F File Offset: 0x0000B07F
		public unsafe List<UnityEngine.UIElements.StyleSheets.StyleValueManaged> m_ValuesManaged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_ValuesManaged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.UIElements.StyleSheets.StyleValueManaged>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_ValuesManaged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00086F64 File Offset: 0x00085164
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0000CE9E File Offset: 0x0000B09E
		public unsafe VisualElement _ve_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr__ve_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr__ve_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x00086F94 File Offset: 0x00085194
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x0000CEBD File Offset: 0x0000B0BD
		public unsafe bool m_HasInlineCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineCursor)) = value;
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x00086FBC File Offset: 0x000851BC
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x0000CED8 File Offset: 0x0000B0D8
		public StyleCursor m_InlineCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineCursor);
				return new StyleCursor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineCursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x00086FEC File Offset: 0x000851EC
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0000CF06 File Offset: 0x0000B106
		public unsafe bool m_HasInlineTextShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTextShadow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTextShadow)) = value;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00087014 File Offset: 0x00085214
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0000CF21 File Offset: 0x0000B121
		public unsafe StyleTextShadow m_InlineTextShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineTextShadow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineTextShadow)) = value;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0008703C File Offset: 0x0008523C
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x0000CF3C File Offset: 0x0000B13C
		public unsafe bool m_HasInlineTransformOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTransformOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTransformOrigin)) = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00087064 File Offset: 0x00085264
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x0000CF57 File Offset: 0x0000B157
		public unsafe StyleTransformOrigin m_InlineTransformOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineTransformOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineTransformOrigin)) = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x0008708C File Offset: 0x0008528C
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x0000CF72 File Offset: 0x0000B172
		public unsafe bool m_HasInlineTranslate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTranslate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTranslate)) = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x000870B4 File Offset: 0x000852B4
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x0000CF8D File Offset: 0x0000B18D
		public unsafe StyleTranslate m_InlineTranslateOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineTranslateOperation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineTranslateOperation)) = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x000870DC File Offset: 0x000852DC
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		public unsafe bool m_HasInlineRotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineRotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineRotate)) = value;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00087104 File Offset: 0x00085304
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0000CFC3 File Offset: 0x0000B1C3
		public unsafe StyleRotate m_InlineRotateOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineRotateOperation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineRotateOperation)) = value;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0008712C File Offset: 0x0008532C
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x0000CFDE File Offset: 0x0000B1DE
		public unsafe bool m_HasInlineScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineScale)) = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x00087154 File Offset: 0x00085354
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x0000CFF9 File Offset: 0x0000B1F9
		public unsafe StyleScale m_InlineScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineScale)) = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0008717C File Offset: 0x0008537C
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x0000D014 File Offset: 0x0000B214
		public unsafe bool m_HasInlineBackgroundSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineBackgroundSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineBackgroundSize)) = value;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000871A4 File Offset: 0x000853A4
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x0000D02F File Offset: 0x0000B22F
		public unsafe StyleBackgroundSize m_InlineBackgroundSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineBackgroundSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineBackgroundSize)) = value;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000871CC File Offset: 0x000853CC
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0000D04A File Offset: 0x0000B24A
		public InlineStyleAccess.InlineRule m_InlineRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineRule);
				return new InlineStyleAccess.InlineRule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineRule), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x000871FC File Offset: 0x000853FC
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x00087230 File Offset: 0x00085430
		public StyleEnum<Align> UnityEngine.UIElements.IStyle.alignContent
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignContent);
				return new StyleEnum<Align>((Align)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Align>(UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignContent, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.AlignContent = (UnityEngine.Yoga.YogaAlign)this.ve.computedStyle.alignContent;
				}
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x00087280 File Offset: 0x00085480
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x000872B4 File Offset: 0x000854B4
		public StyleEnum<Align> UnityEngine.UIElements.IStyle.alignItems
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignItems);
				return new StyleEnum<Align>((Align)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Align>(UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignItems, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.AlignItems = (UnityEngine.Yoga.YogaAlign)this.ve.computedStyle.alignItems;
				}
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00087304 File Offset: 0x00085504
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x00087338 File Offset: 0x00085538
		public StyleEnum<Align> UnityEngine.UIElements.IStyle.alignSelf
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignSelf);
				return new StyleEnum<Align>((Align)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Align>(UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignSelf, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.AlignSelf = (UnityEngine.Yoga.YogaAlign)this.ve.computedStyle.alignSelf;
				}
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x000873A8 File Offset: 0x000855A8
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x000873C8 File Offset: 0x000855C8
		public StyleBackground UnityEngine.UIElements.IStyle.backgroundImage
		{
			get
			{
				return base.GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x000873FC File Offset: 0x000855FC
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0008741C File Offset: 0x0008561C
		public StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionX
		{
			get
			{
				return base.GetStyleBackgroundPosition(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionX);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionX, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00087450 File Offset: 0x00085650
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x00087470 File Offset: 0x00085670
		public StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionY
		{
			get
			{
				return base.GetStyleBackgroundPosition(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionY);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionY, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x000874A4 File Offset: 0x000856A4
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x000874C4 File Offset: 0x000856C4
		public StyleBackgroundRepeat UnityEngine.UIElements.IStyle.backgroundRepeat
		{
			get
			{
				return base.GetStyleBackgroundRepeat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundRepeat);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundRepeat, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0008774C File Offset: 0x0008594C
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00087780 File Offset: 0x00085980
		public StyleEnum<Wrap> UnityEngine.UIElements.IStyle.flexWrap
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexWrap);
				return new StyleEnum<Wrap>((Wrap)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Wrap>(UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexWrap, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.Wrap = (UnityEngine.Yoga.YogaWrap)this.ve.computedStyle.flexWrap;
				}
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00087810 File Offset: 0x00085A10
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00087844 File Offset: 0x00085A44
		public StyleEnum<Justify> UnityEngine.UIElements.IStyle.justifyContent
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.JustifyContent);
				return new StyleEnum<Justify>((Justify)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Justify>(UnityEngine.UIElements.StyleSheets.StylePropertyId.JustifyContent, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.JustifyContent = (UnityEngine.Yoga.YogaJustify)this.ve.computedStyle.justifyContent;
				}
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x000878B4 File Offset: 0x00085AB4
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x000878D4 File Offset: 0x00085AD4
		public StyleLength UnityEngine.UIElements.IStyle.letterSpacing
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.LetterSpacing);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.LetterSpacing, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x000879C8 File Offset: 0x00085BC8
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x000879E8 File Offset: 0x00085BE8
		public StyleLength UnityEngine.UIElements.IStyle.minHeight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MinHeight);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.MinHeight, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.MinHeight = this.ve.computedStyle.minHeight.ToYogaValue();
				}
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00087B64 File Offset: 0x00085D64
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x00087B98 File Offset: 0x00085D98
		public StyleEnum<TextOverflow> UnityEngine.UIElements.IStyle.textOverflow
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.TextOverflow);
				return new StyleEnum<TextOverflow>((TextOverflow)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<TextOverflow>(UnityEngine.UIElements.StyleSheets.StylePropertyId.TextOverflow, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00087C4C File Offset: 0x00085E4C
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00087C80 File Offset: 0x00085E80
		public StyleEnum<FontStyle> UnityEngine.UIElements.IStyle.unityFontStyleAndWeight
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontStyleAndWeight);
				return new StyleEnum<FontStyle>((FontStyle)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<FontStyle>(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontStyleAndWeight, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00087CB4 File Offset: 0x00085EB4
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x00087CE8 File Offset: 0x00085EE8
		public StyleEnum<OverflowClipBox> UnityEngine.UIElements.IStyle.unityOverflowClipBox
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityOverflowClipBox);
				return new StyleEnum<OverflowClipBox>((OverflowClipBox)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<OverflowClipBox>(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityOverflowClipBox, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00087D1C File Offset: 0x00085F1C
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00087D3C File Offset: 0x00085F3C
		public StyleLength UnityEngine.UIElements.IStyle.unityParagraphSpacing
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityParagraphSpacing);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityParagraphSpacing, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x00087D70 File Offset: 0x00085F70
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x00087D90 File Offset: 0x00085F90
		public StyleInt UnityEngine.UIElements.IStyle.unitySliceBottom
		{
			get
			{
				return base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceBottom);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceBottom, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00087DC4 File Offset: 0x00085FC4
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x00087DE4 File Offset: 0x00085FE4
		public StyleInt UnityEngine.UIElements.IStyle.unitySliceLeft
		{
			get
			{
				return base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceLeft);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceLeft, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x00087E18 File Offset: 0x00086018
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x00087E38 File Offset: 0x00086038
		public StyleInt UnityEngine.UIElements.IStyle.unitySliceRight
		{
			get
			{
				return base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceRight);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceRight, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00087E6C File Offset: 0x0008606C
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x00087E8C File Offset: 0x0008608C
		public StyleFloat UnityEngine.UIElements.IStyle.unitySliceScale
		{
			get
			{
				return base.GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceScale);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceScale, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00087EC0 File Offset: 0x000860C0
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x00087EE0 File Offset: 0x000860E0
		public StyleInt UnityEngine.UIElements.IStyle.unitySliceTop
		{
			get
			{
				return base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceTop);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceTop, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00087F14 File Offset: 0x00086114
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x00087F48 File Offset: 0x00086148
		public StyleEnum<TextAnchor> UnityEngine.UIElements.IStyle.unityTextAlign
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextAlign);
				return new StyleEnum<TextAnchor>((TextAnchor)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<TextAnchor>(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextAlign, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x00087F7C File Offset: 0x0008617C
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x00087F9C File Offset: 0x0008619C
		public StyleColor UnityEngine.UIElements.IStyle.unityTextOutlineColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineColor, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x00087FD0 File Offset: 0x000861D0
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x00087FF0 File Offset: 0x000861F0
		public StyleFloat UnityEngine.UIElements.IStyle.unityTextOutlineWidth
		{
			get
			{
				return base.GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineWidth);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineWidth, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x00088024 File Offset: 0x00086224
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x00088058 File Offset: 0x00086258
		public StyleEnum<TextOverflowPosition> UnityEngine.UIElements.IStyle.unityTextOverflowPosition
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOverflowPosition);
				return new StyleEnum<TextOverflowPosition>((TextOverflowPosition)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<TextOverflowPosition>(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOverflowPosition, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x000880C0 File Offset: 0x000862C0
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x000880F4 File Offset: 0x000862F4
		public StyleEnum<WhiteSpace> UnityEngine.UIElements.IStyle.whiteSpace
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId.WhiteSpace);
				return new StyleEnum<WhiteSpace>((WhiteSpace)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<WhiteSpace>(UnityEngine.UIElements.StyleSheets.StylePropertyId.WhiteSpace, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles);
				}
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00088124 File Offset: 0x00086324
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x00088144 File Offset: 0x00086344
		public StyleLength UnityEngine.UIElements.IStyle.wordSpacing
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.WordSpacing);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.WordSpacing, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0000D078 File Offset: 0x0000B278
		public InlineStyleAccess.InlineRule inlineRule
		{
			get
			{
				return this.m_InlineRule;
			}
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x000881FC File Offset: 0x000863FC
		public void SetStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged value)
		{
			bool flag = this.m_ValuesManaged == null;
			if (flag)
			{
				this.m_ValuesManaged = new List<UnityEngine.UIElements.StyleSheets.StyleValueManaged>();
			}
			for (int i = 0; i < this.m_ValuesManaged.Count; i++)
			{
				bool flag2 = this.m_ValuesManaged[i].id == value.id;
				if (flag2)
				{
					bool flag3 = value.keyword == StyleKeyword.Null;
					if (flag3)
					{
						this.m_ValuesManaged.RemoveAt(i);
					}
					else
					{
						this.m_ValuesManaged[i] = value;
					}
					return;
				}
			}
			this.m_ValuesManaged.Add(value);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0008829C File Offset: 0x0008649C
		public bool TryGetStyleValueManaged(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.StyleSheets.StyleValueManaged value)
		{
			value.id = UnityEngine.UIElements.StyleSheets.StylePropertyId.Unknown;
			bool flag = this.m_ValuesManaged == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				List<UnityEngine.UIElements.StyleSheets.StyleValueManaged>.Enumerator enumerator = this.m_ValuesManaged.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						UnityEngine.UIElements.StyleSheets.StyleValueManaged styleValueManaged = enumerator.Current;
						bool flag3 = styleValueManaged.id == id;
						if (flag3)
						{
							value = styleValueManaged;
							return true;
						}
					}
				}
				finally
				{
					enumerator.Dispose();
				}
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x000883AC File Offset: 0x000865AC
		public bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleBackgroundPosition inlineValue)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool flag2 = styleValue.position == inlineValue.value && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.position = inlineValue.value;
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool flag5;
			if (flag4)
			{
				flag5 = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				flag5 = true;
			}
			return flag5;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0008846C File Offset: 0x0008666C
		public bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleBackgroundRepeat inlineValue)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool flag2 = styleValue.repeat == inlineValue.value && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.repeat = inlineValue.value;
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool flag5;
			if (flag4)
			{
				flag5 = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				flag5 = true;
			}
			return flag5;
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0008852C File Offset: 0x0008672C
		public bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleInt inlineValue)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool flag2 = styleValue.number == (float)inlineValue.value && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.number = (float)inlineValue.value;
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool flag5;
			if (flag4)
			{
				flag5 = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				flag5 = true;
			}
			return flag5;
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x000885E8 File Offset: 0x000867E8
		public bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleBackground inlineValue)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			Background background;
			if (flag)
			{
				VectorImage vectorImage = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<VectorImage>() : null);
				Sprite sprite = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<Sprite>() : null);
				Texture2D texture2D = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<Texture2D>() : null);
				RenderTexture renderTexture = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<RenderTexture>() : null);
				Object @object = vectorImage;
				background = inlineValue.value;
				bool flag2;
				if (@object == background.vectorImage)
				{
					Object object2 = texture2D;
					background = inlineValue.value;
					if (object2 == background.texture)
					{
						Object object3 = sprite;
						background = inlineValue.value;
						if (object3 == background.sprite)
						{
							Object object4 = renderTexture;
							background = inlineValue.value;
							if (object4 == background.renderTexture)
							{
								flag2 = styleValue.keyword == inlineValue.keyword;
								goto IL_011C;
							}
						}
					}
				}
				flag2 = false;
				IL_011C:
				bool flag3 = flag2;
				if (flag3)
				{
					return false;
				}
				bool isAllocated = styleValue.resource.IsAllocated;
				if (isAllocated)
				{
					styleValue.resource.Free();
				}
			}
			else
			{
				bool flag4 = inlineValue.keyword == StyleKeyword.Null;
				if (flag4)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			background = inlineValue.value;
			bool flag5 = background.vectorImage != null;
			if (flag5)
			{
				background = inlineValue.value;
				styleValue.resource = GCHandle.Alloc(background.vectorImage);
			}
			else
			{
				background = inlineValue.value;
				bool flag6 = background.sprite != null;
				if (flag6)
				{
					background = inlineValue.value;
					styleValue.resource = GCHandle.Alloc(background.sprite);
				}
				else
				{
					background = inlineValue.value;
					bool flag7 = background.texture != null;
					if (flag7)
					{
						background = inlineValue.value;
						styleValue.resource = GCHandle.Alloc(background.texture);
					}
					else
					{
						background = inlineValue.value;
						bool flag8 = background.renderTexture != null;
						if (flag8)
						{
							background = inlineValue.value;
							styleValue.resource = GCHandle.Alloc(background.renderTexture);
						}
						else
						{
							styleValue.resource = default(GCHandle);
						}
					}
				}
			}
			base.SetStyleValue(styleValue);
			bool flag9 = inlineValue.keyword == StyleKeyword.Null;
			bool flag10;
			if (flag9)
			{
				flag10 = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				flag10 = true;
			}
			return flag10;
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x000888A0 File Offset: 0x00086AA0
		public bool SetInlineCursor(StyleCursor inlineValue)
		{
			StyleCursor styleCursor = null;
			bool flag = this.TryGetInlineCursor(ref styleCursor);
			if (flag)
			{
				bool flag2 = styleCursor.value == inlineValue.value && styleCursor.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleCursor.value = inlineValue.value;
			styleCursor.keyword = inlineValue.keyword;
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool flag5;
			if (flag4)
			{
				this.m_HasInlineCursor = false;
				flag5 = this.RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId.Cursor);
			}
			else
			{
				this.m_InlineCursor = styleCursor;
				this.m_HasInlineCursor = true;
				this.ApplyStyleCursor(styleCursor);
				flag5 = true;
			}
			return flag5;
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0008896C File Offset: 0x00086B6C
		public void ApplyStyleCursor(StyleCursor cursor)
		{
			this.ve.computedStyle.ApplyStyleCursor(cursor.value);
			BaseVisualElementPanel elementPanel = this.ve.elementPanel;
			bool flag = ((elementPanel != null) ? elementPanel.GetTopElementUnderPointer(PointerId.mousePointerId) : null) == this.ve;
			if (flag)
			{
				this.ve.elementPanel.cursorManager.SetCursor(cursor.value);
			}
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x000889D8 File Offset: 0x00086BD8
		public bool SetInlineTextShadow(StyleTextShadow inlineValue)
		{
			StyleTextShadow styleTextShadow = default(StyleTextShadow);
			bool flag = this.TryGetInlineTextShadow(ref styleTextShadow);
			if (flag)
			{
				bool flag2 = styleTextShadow.value == inlineValue.value && styleTextShadow.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleTextShadow.value = inlineValue.value;
			styleTextShadow.keyword = inlineValue.keyword;
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool flag5;
			if (flag4)
			{
				this.m_HasInlineTextShadow = false;
				flag5 = this.RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId.TextShadow);
			}
			else
			{
				this.m_InlineTextShadow = styleTextShadow;
				this.m_HasInlineTextShadow = true;
				this.ApplyStyleTextShadow(styleTextShadow);
				flag5 = true;
			}
			return flag5;
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00088AA4 File Offset: 0x00086CA4
		public void ApplyStyleTextShadow(StyleTextShadow textShadow)
		{
			ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
			bool flag = false;
			ComputedTransitionProperty computedTransitionProperty;
			bool flag2 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId.TextShadow, out computedTransitionProperty);
			if (flag2)
			{
				flag = ComputedStyle.StartAnimationInlineTextShadow(this.ve, this.ve.computedStyle, textShadow, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
			}
			else
			{
				this.ve.styleAnimation.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId.TextShadow);
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.ve.computedStyle.ApplyStyleTextShadow(textShadow.value);
			}
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00088B6C File Offset: 0x00086D6C
		public bool SetInlineTransformOrigin(StyleTransformOrigin inlineValue)
		{
			StyleTransformOrigin styleTransformOrigin = default(StyleTransformOrigin);
			bool flag = this.TryGetInlineTransformOrigin(ref styleTransformOrigin);
			if (flag)
			{
				bool flag2 = styleTransformOrigin.value == inlineValue.value && styleTransformOrigin.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool flag5;
			if (flag4)
			{
				this.m_HasInlineTransformOrigin = false;
				flag5 = this.RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId.TransformOrigin);
			}
			else
			{
				this.m_InlineTransformOrigin = inlineValue;
				this.m_HasInlineTransformOrigin = true;
				this.ApplyStyleTransformOrigin(inlineValue);
				flag5 = true;
			}
			return flag5;
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00088C18 File Offset: 0x00086E18
		public void ApplyStyleTransformOrigin(StyleTransformOrigin transformOrigin)
		{
			ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
			bool flag = false;
			ComputedTransitionProperty computedTransitionProperty;
			bool flag2 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId.TransformOrigin, out computedTransitionProperty);
			if (flag2)
			{
				flag = ComputedStyle.StartAnimationInlineTransformOrigin(this.ve, this.ve.computedStyle, transformOrigin, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
			}
			else
			{
				this.ve.styleAnimation.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId.TransformOrigin);
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.ve.computedStyle.ApplyStyleTransformOrigin(transformOrigin.value);
			}
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00088CE0 File Offset: 0x00086EE0
		public bool SetInlineScale(StyleScale inlineValue)
		{
			StyleScale styleScale = default(StyleScale);
			bool flag = this.TryGetInlineScale(ref styleScale);
			if (flag)
			{
				bool flag2 = styleScale.value == inlineValue.value && styleScale.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool flag5;
			if (flag4)
			{
				this.m_HasInlineScale = false;
				flag5 = this.RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId.Scale);
			}
			else
			{
				this.m_InlineScale = inlineValue;
				this.m_HasInlineScale = true;
				this.ApplyStyleScale(inlineValue);
				flag5 = true;
			}
			return flag5;
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00088D8C File Offset: 0x00086F8C
		public void ApplyStyleScale(StyleScale scale)
		{
			ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
			bool flag = false;
			ComputedTransitionProperty computedTransitionProperty;
			bool flag2 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId.Scale, out computedTransitionProperty);
			if (flag2)
			{
				flag = ComputedStyle.StartAnimationInlineScale(this.ve, this.ve.computedStyle, scale, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
			}
			else
			{
				this.ve.styleAnimation.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId.Scale);
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.ve.computedStyle.ApplyStyleScale(scale.value);
			}
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00088E54 File Offset: 0x00087054
		public bool SetInlineRotate(StyleRotate inlineValue)
		{
			StyleRotate styleRotate = default(StyleRotate);
			bool flag = this.TryGetInlineRotate(ref styleRotate);
			if (flag)
			{
				bool flag2 = styleRotate.value == inlineValue.value && styleRotate.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool flag5;
			if (flag4)
			{
				this.m_HasInlineRotate = false;
				flag5 = this.RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId.Rotate);
			}
			else
			{
				this.m_InlineRotateOperation = inlineValue;
				this.m_HasInlineRotate = true;
				this.ApplyStyleRotate(inlineValue);
				flag5 = true;
			}
			return flag5;
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00088F00 File Offset: 0x00087100
		public void ApplyStyleRotate(StyleRotate rotate)
		{
			VisualElement.Hierarchy hierarchy = this.ve.hierarchy;
			VisualElement parent = hierarchy.parent;
			if (parent != null)
			{
				ref ComputedStyle computedStyle = ref parent.computedStyle;
				ref ComputedStyle computedStyle2 = ref parent.computedStyle;
			}
			else
			{
				UnityEngine.UIElements.StyleSheets.InitialStyle.Get();
			}
			ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
			bool flag = false;
			ComputedTransitionProperty computedTransitionProperty;
			bool flag2 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId.Rotate, out computedTransitionProperty);
			if (flag2)
			{
				flag = ComputedStyle.StartAnimationInlineRotate(this.ve, this.ve.computedStyle, rotate, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
			}
			else
			{
				this.ve.styleAnimation.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId.Rotate);
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.ve.computedStyle.ApplyStyleRotate(rotate.value);
			}
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00088FFC File Offset: 0x000871FC
		public bool SetInlineBackgroundSize(StyleBackgroundSize inlineValue)
		{
			StyleBackgroundSize styleBackgroundSize = default(StyleBackgroundSize);
			bool flag = this.TryGetInlineBackgroundSize(ref styleBackgroundSize);
			if (flag)
			{
				bool flag2 = styleBackgroundSize.value == inlineValue.value && styleBackgroundSize.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool flag5;
			if (flag4)
			{
				this.m_HasInlineBackgroundSize = false;
				flag5 = this.RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundSize);
			}
			else
			{
				this.m_InlineBackgroundSize = inlineValue;
				this.m_HasInlineBackgroundSize = true;
				this.ApplyStyleBackgroundSize(inlineValue);
				flag5 = true;
			}
			return flag5;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x000890A8 File Offset: 0x000872A8
		public void ApplyStyleBackgroundSize(StyleBackgroundSize backgroundSize)
		{
			ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
			bool flag = false;
			ComputedTransitionProperty computedTransitionProperty;
			bool flag2 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundSize, out computedTransitionProperty);
			if (flag2)
			{
				flag = ComputedStyle.StartAnimationInlineBackgroundSize(this.ve, this.ve.computedStyle, backgroundSize, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
			}
			else
			{
				this.ve.styleAnimation.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId.TransformOrigin);
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.ve.computedStyle.ApplyStyleBackgroundSize(backgroundSize.value);
			}
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00089170 File Offset: 0x00087370
		public void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValueManaged value)
		{
			VisualElement.Hierarchy hierarchy = this.ve.hierarchy;
			VisualElement parent = hierarchy.parent;
			ref ComputedStyle ptr;
			if (parent != null)
			{
				ref ComputedStyle computedStyle = ref parent.computedStyle;
				ptr = parent.computedStyle;
			}
			else
			{
				ptr = UnityEngine.UIElements.StyleSheets.InitialStyle.Get();
			}
			ref ComputedStyle ptr2 = ref ptr;
			this.ve.computedStyle.ApplyStyleValueManaged(value, ref ptr2);
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x000891C0 File Offset: 0x000873C0
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x00089240 File Offset: 0x00087440
		public StyleEnum<ScaleMode> UnityEngine.UIElements.IStyle.unityBackgroundScaleMode
		{
			get
			{
				bool flag;
				return new StyleEnum<ScaleMode>(BackgroundPropertyHelper.ResolveUnityBackgroundScaleMode(this.ve.style.backgroundPositionX.value, this.ve.style.backgroundPositionY.value, this.ve.style.backgroundRepeat.value, this.ve.style.backgroundSize.value, out flag));
			}
			set
			{
				this.ve.style.backgroundPositionX = BackgroundPropertyHelper.ConvertScaleModeToBackgroundPosition(value.value);
				this.ve.style.backgroundPositionY = BackgroundPropertyHelper.ConvertScaleModeToBackgroundPosition(value.value);
				this.ve.style.backgroundRepeat = BackgroundPropertyHelper.ConvertScaleModeToBackgroundRepeat(value.value);
				this.ve.style.backgroundSize = BackgroundPropertyHelper.ConvertScaleModeToBackgroundSize(value.value);
			}
		}

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeFieldInfoPtr_s_StylePropertyReader;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeFieldInfoPtr_m_ValuesManaged;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr__ve_k__BackingField;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr_m_HasInlineCursor;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineCursor;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeFieldInfoPtr_m_HasInlineTextShadow;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineTextShadow;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeFieldInfoPtr_m_HasInlineTransformOrigin;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineTransformOrigin;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeFieldInfoPtr_m_HasInlineTranslate;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineTranslateOperation;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeFieldInfoPtr_m_HasInlineRotate;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineRotateOperation;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeFieldInfoPtr_m_HasInlineScale;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineScale;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeFieldInfoPtr_m_HasInlineBackgroundSize;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineBackgroundSize;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineRule;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_backgroundColor_Private_Virtual_Final_New_set_Void_StyleColor_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomColor_Private_Virtual_Final_New_set_Void_StyleColor_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomLeftRadius_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomRightRadius_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderBottomWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderLeftColor_Private_Virtual_Final_New_set_Void_StyleColor_0;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderLeftWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderRightColor_Private_Virtual_Final_New_set_Void_StyleColor_0;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderRightWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopColor_Private_Virtual_Final_New_set_Void_StyleColor_0;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopLeftRadius_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopRightRadius_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_borderTopWidth_Private_Virtual_Final_New_set_Void_StyleFloat_0;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_bottom_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_color_Private_Virtual_Final_New_set_Void_StyleColor_0;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_display_Private_Virtual_Final_New_get_StyleEnum_1_DisplayStyle_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_display_Private_Virtual_Final_New_set_Void_StyleEnum_1_DisplayStyle_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexBasis_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexDirection_Private_Virtual_Final_New_set_Void_StyleEnum_1_FlexDirection_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexGrow_Private_Virtual_Final_New_set_Void_StyleFloat_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_flexShrink_Private_Virtual_Final_New_set_Void_StyleFloat_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_fontSize_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_height_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_left_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginBottom_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginLeft_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginRight_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_marginTop_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_maxHeight_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_maxWidth_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_minWidth_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_opacity_Private_Virtual_Final_New_set_Void_StyleFloat_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_overflow_Private_Virtual_Final_New_set_Void_StyleEnum_1_Overflow_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingBottom_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingLeft_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingRight_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_paddingTop_Private_Virtual_Final_New_get_StyleLength_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_paddingTop_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_position_Private_Virtual_Final_New_set_Void_StyleEnum_1_Position_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_right_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_top_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_unityBackgroundImageTintColor_Private_Virtual_Final_New_set_Void_StyleColor_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_unityFont_Private_Virtual_Final_New_set_Void_StyleFont_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_unityFontDefinition_Private_Virtual_Final_New_set_Void_StyleFontDefinition_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_visibility_Private_Virtual_Final_New_set_Void_StyleEnum_1_Visibility_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_width_Private_Virtual_Final_New_get_StyleLength_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_width_Private_Virtual_Final_New_set_Void_StyleLength_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_get_ve_Private_get_VisualElement_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_set_ve_Private_set_Void_VisualElement_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisualElement_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_SetInlineRule_Public_Void_StyleSheet_StyleRule_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_IsValueSet_Public_Boolean_StylePropertyId_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInlineStyles_Public_Void_byref_ComputedStyle_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_cursor_Private_Virtual_Final_New_get_StyleCursor_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_textShadow_Private_Virtual_Final_New_get_StyleTextShadow_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_backgroundSize_Private_Virtual_Final_New_get_StyleBackgroundSize_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_transformOrigin_Private_Virtual_Final_New_get_StyleTransformOrigin_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_translate_Private_Virtual_Final_New_get_StyleTranslate_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_set_translate_Private_Virtual_Final_New_set_Void_StyleTranslate_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_rotate_Private_Virtual_Final_New_get_StyleRotate_0;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IStyle_get_scale_Private_Virtual_Final_New_get_StyleScale_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleLength_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleFloat_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleColor_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleEnum_1_T_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleFontDefinition_0;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleFont_0;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeMethodInfoPtr_SetInlineTranslate_Private_Boolean_StyleTranslate_0;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleTranslate_Private_Void_StyleTranslate_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleValue_Private_Void_StyleValue_0;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInlineStyle_Private_Boolean_StylePropertyId_0;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFromComputedStyle_Private_Void_StylePropertyId_byref_ComputedStyle_0;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeMethodInfoPtr_TryGetInlineCursor_Public_Boolean_byref_StyleCursor_0;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeMethodInfoPtr_TryGetInlineTextShadow_Public_Boolean_byref_StyleTextShadow_0;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeMethodInfoPtr_TryGetInlineTransformOrigin_Public_Boolean_byref_StyleTransformOrigin_0;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeMethodInfoPtr_TryGetInlineTranslate_Public_Boolean_byref_StyleTranslate_0;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeMethodInfoPtr_TryGetInlineRotate_Public_Boolean_byref_StyleRotate_0;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeMethodInfoPtr_TryGetInlineScale_Public_Boolean_byref_StyleScale_0;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr_TryGetInlineBackgroundSize_Public_Boolean_byref_StyleBackgroundSize_0;

		// Token: 0x020004A2 RID: 1186
		public sealed class InlineRule : ValueType
		{
			// Token: 0x06003D67 RID: 15719 RVA: 0x000F4CC0 File Offset: 0x000F2EC0
			// Note: this type is marked as 'beforefieldinit'.
			static InlineRule()
			{
				Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "InlineRule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr);
				InlineStyleAccess.InlineRule.NativeFieldInfoPtr_sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr, "sheet");
				InlineStyleAccess.InlineRule.NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr, "rule");
				InlineStyleAccess.InlineRule.NativeFieldInfoPtr_propertyIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr, "propertyIds");
			}

			// Token: 0x06003D68 RID: 15720 RVA: 0x00019DD1 File Offset: 0x00017FD1
			public InlineRule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003D69 RID: 15721 RVA: 0x00019DDA File Offset: 0x00017FDA
			public InlineRule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr))
			{
			}

			// Token: 0x1700129B RID: 4763
			// (get) Token: 0x06003D6A RID: 15722 RVA: 0x000F4D28 File Offset: 0x000F2F28
			// (set) Token: 0x06003D6B RID: 15723 RVA: 0x00019DEC File Offset: 0x00017FEC
			public unsafe StyleSheet sheet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_sheet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700129C RID: 4764
			// (get) Token: 0x06003D6C RID: 15724 RVA: 0x000F4D58 File Offset: 0x000F2F58
			// (set) Token: 0x06003D6D RID: 15725 RVA: 0x00019E0B File Offset: 0x0001800B
			public unsafe StyleRule rule
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_rule);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleRule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_rule), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700129D RID: 4765
			// (get) Token: 0x06003D6E RID: 15726 RVA: 0x000F4D88 File Offset: 0x000F2F88
			// (set) Token: 0x06003D6F RID: 15727 RVA: 0x00019E2A File Offset: 0x0001802A
			public unsafe Il2CppStructArray<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_propertyIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UnityEngine.UIElements.StyleSheets.StylePropertyId>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_propertyIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B5F RID: 11103
			private static readonly IntPtr NativeFieldInfoPtr_sheet;

			// Token: 0x04002B60 RID: 11104
			private static readonly IntPtr NativeFieldInfoPtr_rule;

			// Token: 0x04002B61 RID: 11105
			private static readonly IntPtr NativeFieldInfoPtr_propertyIds;
		}

		// Token: 0x020004A3 RID: 1187
		private sealed class MethodInfoStoreGeneric_SetStyleValue_Private_Boolean_StylePropertyId_StyleEnum_1_T_0<T>
		{
			// Token: 0x04002B62 RID: 11106
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InlineStyleAccess.NativeMethodInfoPtr_SetStyleValue_Private_Boolean_StylePropertyId_StyleEnum_1_T_0, Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
