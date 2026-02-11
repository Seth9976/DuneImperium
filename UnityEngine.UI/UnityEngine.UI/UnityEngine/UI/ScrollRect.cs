using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000034 RID: 52
	public class ScrollRect : UIBehaviour
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x0001E090 File Offset: 0x0001C290
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollRect()
		{
			Il2CppClassPointerStore<ScrollRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ScrollRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr);
			ScrollRect.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Content");
			ScrollRect.NativeFieldInfoPtr_m_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Horizontal");
			ScrollRect.NativeFieldInfoPtr_m_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Vertical");
			ScrollRect.NativeFieldInfoPtr_m_MovementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_MovementType");
			ScrollRect.NativeFieldInfoPtr_m_Elasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Elasticity");
			ScrollRect.NativeFieldInfoPtr_m_Inertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Inertia");
			ScrollRect.NativeFieldInfoPtr_m_DecelerationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_DecelerationRate");
			ScrollRect.NativeFieldInfoPtr_m_ScrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ScrollSensitivity");
			ScrollRect.NativeFieldInfoPtr_m_Viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Viewport");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbar");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbar");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbarVisibility");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbarVisibility");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbarSpacing");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbarSpacing");
			ScrollRect.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_OnValueChanged");
			ScrollRect.NativeFieldInfoPtr_m_PointerStartLocalCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PointerStartLocalCursor");
			ScrollRect.NativeFieldInfoPtr_m_ContentStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ContentStartPosition");
			ScrollRect.NativeFieldInfoPtr_m_ViewRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ViewRect");
			ScrollRect.NativeFieldInfoPtr_m_ContentBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ContentBounds");
			ScrollRect.NativeFieldInfoPtr_m_ViewBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ViewBounds");
			ScrollRect.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Velocity");
			ScrollRect.NativeFieldInfoPtr_m_Dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Dragging");
			ScrollRect.NativeFieldInfoPtr_m_Scrolling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Scrolling");
			ScrollRect.NativeFieldInfoPtr_m_PrevPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PrevPosition");
			ScrollRect.NativeFieldInfoPtr_m_PrevContentBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PrevContentBounds");
			ScrollRect.NativeFieldInfoPtr_m_PrevViewBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PrevViewBounds");
			ScrollRect.NativeFieldInfoPtr_m_HasRebuiltLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HasRebuiltLayout");
			ScrollRect.NativeFieldInfoPtr_m_HSliderExpand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HSliderExpand");
			ScrollRect.NativeFieldInfoPtr_m_VSliderExpand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VSliderExpand");
			ScrollRect.NativeFieldInfoPtr_m_HSliderHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HSliderHeight");
			ScrollRect.NativeFieldInfoPtr_m_VSliderWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VSliderWidth");
			ScrollRect.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Rect");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbarRect");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbarRect");
			ScrollRect.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Tracker");
			ScrollRect.NativeFieldInfoPtr_m_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Corners");
			ScrollRect.NativeMethodInfoPtr_get_content_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664259);
			ScrollRect.NativeMethodInfoPtr_set_content_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664260);
			ScrollRect.NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664261);
			ScrollRect.NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664262);
			ScrollRect.NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664263);
			ScrollRect.NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664264);
			ScrollRect.NativeMethodInfoPtr_get_movementType_Public_get_MovementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664265);
			ScrollRect.NativeMethodInfoPtr_set_movementType_Public_set_Void_MovementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664266);
			ScrollRect.NativeMethodInfoPtr_get_elasticity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664267);
			ScrollRect.NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664268);
			ScrollRect.NativeMethodInfoPtr_get_inertia_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664269);
			ScrollRect.NativeMethodInfoPtr_set_inertia_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664270);
			ScrollRect.NativeMethodInfoPtr_get_decelerationRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664271);
			ScrollRect.NativeMethodInfoPtr_set_decelerationRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664272);
			ScrollRect.NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664273);
			ScrollRect.NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664274);
			ScrollRect.NativeMethodInfoPtr_get_viewport_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664275);
			ScrollRect.NativeMethodInfoPtr_set_viewport_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664276);
			ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664277);
			ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664278);
			ScrollRect.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664279);
			ScrollRect.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664280);
			ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarVisibility_Public_get_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664281);
			ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664282);
			ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarVisibility_Public_get_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664283);
			ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664284);
			ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664285);
			ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664286);
			ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664287);
			ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664288);
			ScrollRect.NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollRectEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664289);
			ScrollRect.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollRectEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664290);
			ScrollRect.NativeMethodInfoPtr_get_viewRect_Protected_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664291);
			ScrollRect.NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664292);
			ScrollRect.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664293);
			ScrollRect.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664294);
			ScrollRect.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664295);
			ScrollRect.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664296);
			ScrollRect.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664297);
			ScrollRect.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664298);
			ScrollRect.NativeMethodInfoPtr_UpdateCachedData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664299);
			ScrollRect.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664300);
			ScrollRect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664301);
			ScrollRect.NativeMethodInfoPtr_IsActive_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664302);
			ScrollRect.NativeMethodInfoPtr_EnsureLayoutHasRebuilt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664303);
			ScrollRect.NativeMethodInfoPtr_StopMovement_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664304);
			ScrollRect.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664305);
			ScrollRect.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664306);
			ScrollRect.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664307);
			ScrollRect.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664308);
			ScrollRect.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664309);
			ScrollRect.NativeMethodInfoPtr_SetContentAnchoredPosition_Protected_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664310);
			ScrollRect.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664311);
			ScrollRect.NativeMethodInfoPtr_UpdatePrevData_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664312);
			ScrollRect.NativeMethodInfoPtr_UpdateScrollbars_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664313);
			ScrollRect.NativeMethodInfoPtr_get_normalizedPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664314);
			ScrollRect.NativeMethodInfoPtr_set_normalizedPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664315);
			ScrollRect.NativeMethodInfoPtr_get_horizontalNormalizedPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664316);
			ScrollRect.NativeMethodInfoPtr_set_horizontalNormalizedPosition_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664317);
			ScrollRect.NativeMethodInfoPtr_get_verticalNormalizedPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664318);
			ScrollRect.NativeMethodInfoPtr_set_verticalNormalizedPosition_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664319);
			ScrollRect.NativeMethodInfoPtr_SetHorizontalNormalizedPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664320);
			ScrollRect.NativeMethodInfoPtr_SetVerticalNormalizedPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664321);
			ScrollRect.NativeMethodInfoPtr_SetNormalizedPosition_Protected_Virtual_New_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664322);
			ScrollRect.NativeMethodInfoPtr_RubberDelta_Private_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664323);
			ScrollRect.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664324);
			ScrollRect.NativeMethodInfoPtr_get_hScrollingNeeded_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664325);
			ScrollRect.NativeMethodInfoPtr_get_vScrollingNeeded_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664326);
			ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664327);
			ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664328);
			ScrollRect.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664329);
			ScrollRect.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664330);
			ScrollRect.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664331);
			ScrollRect.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664332);
			ScrollRect.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664333);
			ScrollRect.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664334);
			ScrollRect.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664335);
			ScrollRect.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664336);
			ScrollRect.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664337);
			ScrollRect.NativeMethodInfoPtr_UpdateScrollbarVisibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664338);
			ScrollRect.NativeMethodInfoPtr_UpdateOneScrollbarVisibility_Private_Static_Void_Boolean_Boolean_ScrollbarVisibility_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664339);
			ScrollRect.NativeMethodInfoPtr_UpdateScrollbarLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664340);
			ScrollRect.NativeMethodInfoPtr_UpdateBounds_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664341);
			ScrollRect.NativeMethodInfoPtr_AdjustBounds_Internal_Static_Void_byref_Bounds_byref_Vector2_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664342);
			ScrollRect.NativeMethodInfoPtr_GetBounds_Private_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664343);
			ScrollRect.NativeMethodInfoPtr_InternalGetBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664344);
			ScrollRect.NativeMethodInfoPtr_CalculateOffset_Private_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664345);
			ScrollRect.NativeMethodInfoPtr_InternalCalculateOffset_Internal_Static_Vector2_byref_Bounds_byref_Bounds_Boolean_Boolean_MovementType_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664346);
			ScrollRect.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664347);
			ScrollRect.NativeMethodInfoPtr_SetDirtyCaching_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664348);
			ScrollRect.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664349);
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x0001EB00 File Offset: 0x0001CD00
		public unsafe RectTransform content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_content_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_content_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0001EB44 File Offset: 0x0001CD44
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x0001EB80 File Offset: 0x0001CD80
		public unsafe bool horizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0001EBC0 File Offset: 0x0001CDC0
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x0001EBFC File Offset: 0x0001CDFC
		public unsafe bool vertical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0001EC3C File Offset: 0x0001CE3C
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x0001EC78 File Offset: 0x0001CE78
		public unsafe ScrollRect.MovementType movementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_movementType_Public_get_MovementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_movementType_Public_set_Void_MovementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0001ECB8 File Offset: 0x0001CEB8
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x0001ECF4 File Offset: 0x0001CEF4
		public unsafe float elasticity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318235, RefRangeEnd = 318236, XrefRangeStart = 318235, XrefRangeEnd = 318236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_elasticity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318236, RefRangeEnd = 318239, XrefRangeStart = 318236, XrefRangeEnd = 318239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0001ED34 File Offset: 0x0001CF34
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x0001ED70 File Offset: 0x0001CF70
		public unsafe bool inertia
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_inertia_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_inertia_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0001EDB0 File Offset: 0x0001CFB0
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x0001EDEC File Offset: 0x0001CFEC
		public unsafe float decelerationRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_decelerationRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 850305, RefRangeEnd = 850310, XrefRangeStart = 850305, XrefRangeEnd = 850310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_decelerationRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0001EE2C File Offset: 0x0001D02C
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x0001EE68 File Offset: 0x0001D068
		public unsafe float scrollSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604707, RefRangeEnd = 604708, XrefRangeStart = 604707, XrefRangeEnd = 604708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x0001EEE8 File Offset: 0x0001D0E8
		public unsafe RectTransform viewport
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_viewport_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1090870, RefRangeEnd = 1090873, XrefRangeStart = 1090868, XrefRangeEnd = 1090870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_viewport_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001EF2C File Offset: 0x0001D12C
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x0001EF6C File Offset: 0x0001D16C
		public unsafe Scrollbar horizontalScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1090899, RefRangeEnd = 1090900, XrefRangeStart = 1090873, XrefRangeEnd = 1090899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001EFB0 File Offset: 0x0001D1B0
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x0001EFF0 File Offset: 0x0001D1F0
		public unsafe Scrollbar verticalScrollbar
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1090926, RefRangeEnd = 1090929, XrefRangeStart = 1090900, XrefRangeEnd = 1090926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0001F034 File Offset: 0x0001D234
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x0001F070 File Offset: 0x0001D270
		public unsafe ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarVisibility_Public_get_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1090930, RefRangeEnd = 1090931, XrefRangeStart = 1090929, XrefRangeEnd = 1090930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x0001F0EC File Offset: 0x0001D2EC
		public unsafe ScrollRect.ScrollbarVisibility verticalScrollbarVisibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarVisibility_Public_get_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1090932, RefRangeEnd = 1090935, XrefRangeStart = 1090931, XrefRangeEnd = 1090932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001F12C File Offset: 0x0001D32C
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x0001F168 File Offset: 0x0001D368
		public unsafe float horizontalScrollbarSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1090936, RefRangeEnd = 1090937, XrefRangeStart = 1090935, XrefRangeEnd = 1090936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0001F1A8 File Offset: 0x0001D3A8
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x0001F1E4 File Offset: 0x0001D3E4
		public unsafe float verticalScrollbarSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1090938, RefRangeEnd = 1090941, XrefRangeStart = 1090937, XrefRangeEnd = 1090938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001F224 File Offset: 0x0001D424
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x0001F264 File Offset: 0x0001D464
		public unsafe ScrollRect.ScrollRectEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollRectEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScrollRect.ScrollRectEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollRectEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
		public unsafe RectTransform viewRect
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 1090955, RefRangeEnd = 1090982, XrefRangeStart = 1090941, XrefRangeEnd = 1090955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_viewRect_Protected_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0001F2E8 File Offset: 0x0001D4E8
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x0001F324 File Offset: 0x0001D524
		public unsafe Vector2 velocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x0001F364 File Offset: 0x0001D564
		public unsafe RectTransform rectTransform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1090990, RefRangeEnd = 1090993, XrefRangeStart = 1090982, XrefRangeEnd = 1090990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1091011, RefRangeEnd = 1091012, XrefRangeStart = 1090993, XrefRangeEnd = 1091011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollRect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091012, XrefRangeEnd = 1091018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001F42C File Offset: 0x0001D62C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001F468 File Offset: 0x0001D668
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001F4A4 File Offset: 0x0001D6A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1091071, RefRangeEnd = 1091073, XrefRangeStart = 1091018, XrefRangeEnd = 1091071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCachedData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateCachedData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0001F4D8 File Offset: 0x0001D6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091073, XrefRangeEnd = 1091103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0001F514 File Offset: 0x0001D714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091103, XrefRangeEnd = 1091140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001F550 File Offset: 0x0001D750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091140, XrefRangeEnd = 1091142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_IsActive_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0001F598 File Offset: 0x0001D798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091142, XrefRangeEnd = 1091147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureLayoutHasRebuilt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_EnsureLayoutHasRebuilt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0001F5CC File Offset: 0x0001D7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091147, XrefRangeEnd = 1091149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_StopMovement_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0001F608 File Offset: 0x0001D808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091149, XrefRangeEnd = 1091161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnScroll(PointerEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001F658 File Offset: 0x0001D858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1091163, RefRangeEnd = 1091164, XrefRangeStart = 1091161, XrefRangeEnd = 1091163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0001F6A8 File Offset: 0x0001D8A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1091174, RefRangeEnd = 1091175, XrefRangeStart = 1091164, XrefRangeEnd = 1091174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		[CallerCount(0)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0001F748 File Offset: 0x0001D948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1091186, RefRangeEnd = 1091187, XrefRangeStart = 1091175, XrefRangeEnd = 1091186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0001F798 File Offset: 0x0001D998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091187, XrefRangeEnd = 1091194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetContentAnchoredPosition(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetContentAnchoredPosition_Protected_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091194, XrefRangeEnd = 1091251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001F820 File Offset: 0x0001DA20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1091259, RefRangeEnd = 1091261, XrefRangeStart = 1091251, XrefRangeEnd = 1091259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrevData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdatePrevData_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001F854 File Offset: 0x0001DA54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1091277, RefRangeEnd = 1091279, XrefRangeStart = 1091261, XrefRangeEnd = 1091277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbars(Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateScrollbars_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001F894 File Offset: 0x0001DA94
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x0001F8D0 File Offset: 0x0001DAD0
		public unsafe Vector2 normalizedPosition
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1091281, RefRangeEnd = 1091283, XrefRangeStart = 1091279, XrefRangeEnd = 1091281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_normalizedPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1091283, RefRangeEnd = 1091285, XrefRangeStart = 1091283, XrefRangeEnd = 1091283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_normalizedPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001F910 File Offset: 0x0001DB10
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x0001F94C File Offset: 0x0001DB4C
		public unsafe float horizontalNormalizedPosition
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1091287, RefRangeEnd = 1091290, XrefRangeStart = 1091285, XrefRangeEnd = 1091287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalNormalizedPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalNormalizedPosition_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001F98C File Offset: 0x0001DB8C
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
		public unsafe float verticalNormalizedPosition
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1091292, RefRangeEnd = 1091299, XrefRangeStart = 1091290, XrefRangeEnd = 1091292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalNormalizedPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1091299, RefRangeEnd = 1091304, XrefRangeStart = 1091299, XrefRangeEnd = 1091299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalNormalizedPosition_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001FA08 File Offset: 0x0001DC08
		[CallerCount(0)]
		public unsafe void SetHorizontalNormalizedPosition(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetHorizontalNormalizedPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001FA48 File Offset: 0x0001DC48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1091299, RefRangeEnd = 1091304, XrefRangeStart = 1091299, XrefRangeEnd = 1091304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVerticalNormalizedPosition(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetVerticalNormalizedPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0001FA88 File Offset: 0x0001DC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091304, XrefRangeEnd = 1091328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNormalizedPosition(float value, int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetNormalizedPosition_Protected_Virtual_New_Void_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0001FAE0 File Offset: 0x0001DCE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1091329, RefRangeEnd = 1091331, XrefRangeStart = 1091328, XrefRangeEnd = 1091329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RubberDelta(float overStretching, float viewSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overStretching;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_RubberDelta_Private_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0001FB2C File Offset: 0x0001DD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091331, XrefRangeEnd = 1091332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0001FB68 File Offset: 0x0001DD68
		public unsafe bool hScrollingNeeded
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1091336, RefRangeEnd = 1091340, XrefRangeStart = 1091332, XrefRangeEnd = 1091336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_hScrollingNeeded_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001FBA4 File Offset: 0x0001DDA4
		public unsafe bool vScrollingNeeded
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1091344, RefRangeEnd = 1091349, XrefRangeStart = 1091340, XrefRangeEnd = 1091344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_vScrollingNeeded_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0001FBE0 File Offset: 0x0001DDE0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001FC1C File Offset: 0x0001DE1C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0001FC58 File Offset: 0x0001DE58
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001FCA0 File Offset: 0x0001DEA0
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001FCE8 File Offset: 0x0001DEE8
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001FD30 File Offset: 0x0001DF30
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0001FD78 File Offset: 0x0001DF78
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0001FE08 File Offset: 0x0001E008
		public unsafe virtual int layoutPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001FE50 File Offset: 0x0001E050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091349, XrefRangeEnd = 1091410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001FE8C File Offset: 0x0001E08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091410, XrefRangeEnd = 1091416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091416, XrefRangeEnd = 1091420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbarVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateScrollbarVisibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001FEFC File Offset: 0x0001E0FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1091428, RefRangeEnd = 1091432, XrefRangeStart = 1091420, XrefRangeEnd = 1091428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xScrollingNeeded;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xAxisEnabled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollbarVisibility;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scrollbar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateOneScrollbarVisibility_Private_Static_Void_Boolean_Boolean_ScrollbarVisibility_Scrollbar_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001FF5C File Offset: 0x0001E15C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1091461, RefRangeEnd = 1091462, XrefRangeStart = 1091432, XrefRangeEnd = 1091461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbarLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateScrollbarLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001FF90 File Offset: 0x0001E190
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1091494, RefRangeEnd = 1091505, XrefRangeStart = 1091462, XrefRangeEnd = 1091494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateBounds_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0001FFC4 File Offset: 0x0001E1C4
		[CallerCount(0)]
		public unsafe static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &viewBounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentPivot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_AdjustBounds_Internal_Static_Void_byref_Bounds_byref_Vector2_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00020020 File Offset: 0x0001E220
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1091514, RefRangeEnd = 1091519, XrefRangeStart = 1091505, XrefRangeEnd = 1091514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_GetBounds_Private_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0002005C File Offset: 0x0001E25C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1091522, RefRangeEnd = 1091523, XrefRangeStart = 1091519, XrefRangeEnd = 1091522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds InternalGetBounds(Il2CppStructArray<Vector3> corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(corners);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewWorldToLocalMatrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_InternalGetBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000200AC File Offset: 0x0001E2AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1091528, RefRangeEnd = 1091532, XrefRangeStart = 1091523, XrefRangeEnd = 1091528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalculateOffset(Vector2 delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_CalculateOffset_Private_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000200F8 File Offset: 0x0001E2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091532, XrefRangeEnd = 1091535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &viewBounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentBounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horizontal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertical;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref movementType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_InternalCalculateOffset_Internal_Static_Vector2_byref_Bounds_byref_Bounds_Boolean_Boolean_MovementType_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0002017C File Offset: 0x0001E37C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1091540, RefRangeEnd = 1091544, XrefRangeStart = 1091535, XrefRangeEnd = 1091540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000201B0 File Offset: 0x0001E3B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1091554, RefRangeEnd = 1091559, XrefRangeStart = 1091544, XrefRangeEnd = 1091554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirtyCaching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetDirtyCaching_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000201E4 File Offset: 0x0001E3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00004071 File Offset: 0x00002271
		public ScrollRect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00020224 File Offset: 0x0001E424
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x0000407A File Offset: 0x0000227A
		public unsafe RectTransform m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00020254 File Offset: 0x0001E454
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00004099 File Offset: 0x00002299
		public unsafe bool m_Horizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Horizontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Horizontal)) = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0002027C File Offset: 0x0001E47C
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x000040B4 File Offset: 0x000022B4
		public unsafe bool m_Vertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Vertical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Vertical)) = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x000202A4 File Offset: 0x0001E4A4
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x000040CF File Offset: 0x000022CF
		public unsafe ScrollRect.MovementType m_MovementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_MovementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_MovementType)) = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x000202CC File Offset: 0x0001E4CC
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x000040EA File Offset: 0x000022EA
		public unsafe float m_Elasticity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Elasticity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Elasticity)) = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x000202F4 File Offset: 0x0001E4F4
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00004105 File Offset: 0x00002305
		public unsafe bool m_Inertia
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Inertia);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Inertia)) = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0002031C File Offset: 0x0001E51C
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00004120 File Offset: 0x00002320
		public unsafe float m_DecelerationRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_DecelerationRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_DecelerationRate)) = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00020344 File Offset: 0x0001E544
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x0000413B File Offset: 0x0000233B
		public unsafe float m_ScrollSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ScrollSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ScrollSensitivity)) = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0002036C File Offset: 0x0001E56C
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00004156 File Offset: 0x00002356
		public unsafe RectTransform m_Viewport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Viewport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Viewport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0002039C File Offset: 0x0001E59C
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00004175 File Offset: 0x00002375
		public unsafe Scrollbar m_HorizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x000203CC File Offset: 0x0001E5CC
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00004194 File Offset: 0x00002394
		public unsafe Scrollbar m_VerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000203FC File Offset: 0x0001E5FC
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x000041B3 File Offset: 0x000023B3
		public unsafe ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarVisibility)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00020424 File Offset: 0x0001E624
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x000041CE File Offset: 0x000023CE
		public unsafe ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarVisibility)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0002044C File Offset: 0x0001E64C
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x000041E9 File Offset: 0x000023E9
		public unsafe float m_HorizontalScrollbarSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarSpacing)) = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00020474 File Offset: 0x0001E674
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00004204 File Offset: 0x00002404
		public unsafe float m_VerticalScrollbarSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarSpacing)) = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x0002049C File Offset: 0x0001E69C
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x0000421F File Offset: 0x0000241F
		public unsafe ScrollRect.ScrollRectEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect.ScrollRectEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x000204CC File Offset: 0x0001E6CC
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x0000423E File Offset: 0x0000243E
		public unsafe Vector2 m_PointerStartLocalCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PointerStartLocalCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PointerStartLocalCursor)) = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000204F4 File Offset: 0x0001E6F4
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00004259 File Offset: 0x00002459
		public unsafe Vector2 m_ContentStartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentStartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentStartPosition)) = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0002051C File Offset: 0x0001E71C
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00004274 File Offset: 0x00002474
		public unsafe RectTransform m_ViewRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0002054C File Offset: 0x0001E74C
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00004293 File Offset: 0x00002493
		public unsafe Bounds m_ContentBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentBounds)) = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00020574 File Offset: 0x0001E774
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x000042AE File Offset: 0x000024AE
		public unsafe Bounds m_ViewBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewBounds)) = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0002059C File Offset: 0x0001E79C
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x000042C9 File Offset: 0x000024C9
		public unsafe Vector2 m_Velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Velocity)) = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x000205C4 File Offset: 0x0001E7C4
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x000042E4 File Offset: 0x000024E4
		public unsafe bool m_Dragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Dragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Dragging)) = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x000205EC File Offset: 0x0001E7EC
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x000042FF File Offset: 0x000024FF
		public unsafe bool m_Scrolling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Scrolling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Scrolling)) = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00020614 File Offset: 0x0001E814
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x0000431A File Offset: 0x0000251A
		public unsafe Vector2 m_PrevPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevPosition)) = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0002063C File Offset: 0x0001E83C
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00004335 File Offset: 0x00002535
		public unsafe Bounds m_PrevContentBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevContentBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevContentBounds)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00020664 File Offset: 0x0001E864
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00004350 File Offset: 0x00002550
		public unsafe Bounds m_PrevViewBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevViewBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevViewBounds)) = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0002068C File Offset: 0x0001E88C
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x0000436B File Offset: 0x0000256B
		public unsafe bool m_HasRebuiltLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HasRebuiltLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HasRebuiltLayout)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000206B4 File Offset: 0x0001E8B4
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00004386 File Offset: 0x00002586
		public unsafe bool m_HSliderExpand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderExpand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderExpand)) = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x000206DC File Offset: 0x0001E8DC
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x000043A1 File Offset: 0x000025A1
		public unsafe bool m_VSliderExpand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderExpand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderExpand)) = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00020704 File Offset: 0x0001E904
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x000043BC File Offset: 0x000025BC
		public unsafe float m_HSliderHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderHeight)) = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0002072C File Offset: 0x0001E92C
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x000043D7 File Offset: 0x000025D7
		public unsafe float m_VSliderWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderWidth)) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00020754 File Offset: 0x0001E954
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x000043F2 File Offset: 0x000025F2
		public unsafe RectTransform m_Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00020784 File Offset: 0x0001E984
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00004411 File Offset: 0x00002611
		public unsafe RectTransform m_HorizontalScrollbarRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x000207B4 File Offset: 0x0001E9B4
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00004430 File Offset: 0x00002630
		public unsafe RectTransform m_VerticalScrollbarRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x000207E4 File Offset: 0x0001E9E4
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x0000444F File Offset: 0x0000264F
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0002080C File Offset: 0x0001EA0C
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x0000446A File Offset: 0x0000266A
		public unsafe Il2CppStructArray<Vector3> m_Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr_m_Horizontal;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr_m_Vertical;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_m_MovementType;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_m_Elasticity;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_m_Inertia;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr_m_DecelerationRate;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollSensitivity;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeFieldInfoPtr_m_Viewport;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbar;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbar;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbarVisibility;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarVisibility;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbarSpacing;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarSpacing;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerStartLocalCursor;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentStartPosition;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewRect;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentBounds;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewBounds;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr_m_Velocity;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr_m_Dragging;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr_m_Scrolling;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevPosition;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevContentBounds;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevViewBounds;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_m_HasRebuiltLayout;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_m_HSliderExpand;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeFieldInfoPtr_m_VSliderExpand;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeFieldInfoPtr_m_HSliderHeight;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeFieldInfoPtr_m_VSliderWidth;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbarRect;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarRect;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr_m_Corners;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_get_content_Public_get_RectTransform_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_set_content_Public_set_Void_RectTransform_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_get_movementType_Public_get_MovementType_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_set_movementType_Public_set_Void_MovementType_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_get_elasticity_Public_get_Single_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_get_inertia_Public_get_Boolean_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_set_inertia_Public_set_Void_Boolean_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_get_decelerationRate_Public_get_Single_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_set_decelerationRate_Public_set_Void_Single_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_get_viewport_Public_get_RectTransform_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_set_viewport_Public_set_Void_RectTransform_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_Scrollbar_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_Scrollbar_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarVisibility_Public_get_ScrollbarVisibility_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarVisibility_Public_get_ScrollbarVisibility_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarSpacing_Public_get_Single_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarSpacing_Public_set_Void_Single_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarSpacing_Public_get_Single_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarSpacing_Public_set_Void_Single_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollRectEvent_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollRectEvent_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_get_viewRect_Protected_get_RectTransform_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCachedData_Private_Void_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Boolean_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLayoutHasRebuilt_Private_Void_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_StopMovement_Public_Virtual_New_Void_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_SetContentAnchoredPosition_Protected_Virtual_New_Void_Vector2_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrevData_Protected_Void_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbars_Private_Void_Vector2_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_get_normalizedPosition_Public_get_Vector2_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_set_normalizedPosition_Public_set_Void_Vector2_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalNormalizedPosition_Public_get_Single_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalNormalizedPosition_Public_set_Void_Single_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalNormalizedPosition_Public_get_Single_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalNormalizedPosition_Public_set_Void_Single_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontalNormalizedPosition_Private_Void_Single_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticalNormalizedPosition_Private_Void_Single_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalizedPosition_Protected_Virtual_New_Void_Single_Int32_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_RubberDelta_Private_Static_Single_Single_Single_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_get_hScrollingNeeded_Private_get_Boolean_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_get_vScrollingNeeded_Private_get_Boolean_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbarVisibility_Private_Void_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOneScrollbarVisibility_Private_Static_Void_Boolean_Boolean_ScrollbarVisibility_Scrollbar_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbarLayout_Private_Void_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBounds_Protected_Void_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_AdjustBounds_Internal_Static_Void_byref_Bounds_byref_Vector2_byref_Vector3_byref_Vector3_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_GetBounds_Private_Bounds_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_CalculateOffset_Private_Vector2_Vector2_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_InternalCalculateOffset_Internal_Static_Vector2_byref_Bounds_byref_Bounds_Boolean_Boolean_MovementType_byref_Vector2_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_SetDirtyCaching_Protected_Void_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x020000AD RID: 173
		public enum MovementType
		{
			// Token: 0x040009EE RID: 2542
			Unrestricted,
			// Token: 0x040009EF RID: 2543
			Elastic,
			// Token: 0x040009F0 RID: 2544
			Clamped
		}

		// Token: 0x020000AE RID: 174
		public enum ScrollbarVisibility
		{
			// Token: 0x040009F2 RID: 2546
			Permanent,
			// Token: 0x040009F3 RID: 2547
			AutoHide,
			// Token: 0x040009F4 RID: 2548
			AutoHideAndExpandViewport
		}

		// Token: 0x020000AF RID: 175
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			// Token: 0x06000CD1 RID: 3281 RVA: 0x00006D09 File Offset: 0x00004F09
			// Note: this type is marked as 'beforefieldinit'.
			static ScrollRectEvent()
			{
				Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "ScrollRectEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr);
				ScrollRect.ScrollRectEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr, 100664350);
			}

			// Token: 0x06000CD2 RID: 3282 RVA: 0x00037708 File Offset: 0x00035908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090865, XrefRangeEnd = 1090868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScrollRectEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.ScrollRectEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CD3 RID: 3283 RVA: 0x00006D3D File Offset: 0x00004F3D
			public ScrollRectEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040009F5 RID: 2549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
