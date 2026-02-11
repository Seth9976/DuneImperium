using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000087 RID: 135
	public class ScrollView : VisualElement
	{
		// Token: 0x06000D3E RID: 3390 RVA: 0x0004BA64 File Offset: 0x00049C64
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollView()
		{
			Il2CppClassPointerStore<ScrollView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ScrollView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollView>.NativeClassPtr);
			ScrollView.NativeFieldInfoPtr_m_FirstLayoutPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_FirstLayoutPass");
			ScrollView.NativeFieldInfoPtr_m_HorizontalScrollerVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_HorizontalScrollerVisibility");
			ScrollView.NativeFieldInfoPtr_m_VerticalScrollerVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_VerticalScrollerVisibility");
			ScrollView.NativeFieldInfoPtr_m_AttachedRootVisualContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_AttachedRootVisualContainer");
			ScrollView.NativeFieldInfoPtr_m_SingleLineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_SingleLineHeight");
			ScrollView.NativeFieldInfoPtr_m_MouseWheelScrollSizeIsInline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_MouseWheelScrollSizeIsInline");
			ScrollView.NativeFieldInfoPtr_m_HorizontalPageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_HorizontalPageSize");
			ScrollView.NativeFieldInfoPtr_m_VerticalPageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_VerticalPageSize");
			ScrollView.NativeFieldInfoPtr_m_MouseWheelScrollSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_MouseWheelScrollSize");
			ScrollView.NativeFieldInfoPtr_k_DefaultScrollDecelerationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "k_DefaultScrollDecelerationRate");
			ScrollView.NativeFieldInfoPtr_m_ScrollDecelerationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_ScrollDecelerationRate");
			ScrollView.NativeFieldInfoPtr_k_ScaledPixelsPerPointMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "k_ScaledPixelsPerPointMultiplier");
			ScrollView.NativeFieldInfoPtr_k_TouchScrollInertiaBaseTimeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "k_TouchScrollInertiaBaseTimeInterval");
			ScrollView.NativeFieldInfoPtr_k_DefaultElasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "k_DefaultElasticity");
			ScrollView.NativeFieldInfoPtr_m_Elasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_Elasticity");
			ScrollView.NativeFieldInfoPtr_m_TouchScrollBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_TouchScrollBehavior");
			ScrollView.NativeFieldInfoPtr_m_NestedInteractionKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_NestedInteractionKind");
			ScrollView.NativeFieldInfoPtr_k_DefaultElasticAnimationInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "k_DefaultElasticAnimationInterval");
			ScrollView.NativeFieldInfoPtr_m_ElasticAnimationIntervalMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_ElasticAnimationIntervalMs");
			ScrollView.NativeFieldInfoPtr__contentViewport_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "<contentViewport>k__BackingField");
			ScrollView.NativeFieldInfoPtr__horizontalScroller_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "<horizontalScroller>k__BackingField");
			ScrollView.NativeFieldInfoPtr__verticalScroller_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "<verticalScroller>k__BackingField");
			ScrollView.NativeFieldInfoPtr_m_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_ContentContainer");
			ScrollView.NativeFieldInfoPtr_m_ContentAndVerticalScrollContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_ContentAndVerticalScrollContainer");
			ScrollView.NativeFieldInfoPtr_previousVerticalTouchScrollTimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "previousVerticalTouchScrollTimeStamp");
			ScrollView.NativeFieldInfoPtr_previousHorizontalTouchScrollTimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "previousHorizontalTouchScrollTimeStamp");
			ScrollView.NativeFieldInfoPtr_elapsedTimeSinceLastVerticalTouchScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "elapsedTimeSinceLastVerticalTouchScroll");
			ScrollView.NativeFieldInfoPtr_elapsedTimeSinceLastHorizontalTouchScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "elapsedTimeSinceLastHorizontalTouchScroll");
			ScrollView.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "ussClassName");
			ScrollView.NativeFieldInfoPtr_viewportUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "viewportUssClassName");
			ScrollView.NativeFieldInfoPtr_horizontalVariantViewportUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "horizontalVariantViewportUssClassName");
			ScrollView.NativeFieldInfoPtr_verticalVariantViewportUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "verticalVariantViewportUssClassName");
			ScrollView.NativeFieldInfoPtr_verticalHorizontalVariantViewportUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "verticalHorizontalVariantViewportUssClassName");
			ScrollView.NativeFieldInfoPtr_contentAndVerticalScrollUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "contentAndVerticalScrollUssClassName");
			ScrollView.NativeFieldInfoPtr_contentUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "contentUssClassName");
			ScrollView.NativeFieldInfoPtr_horizontalVariantContentUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "horizontalVariantContentUssClassName");
			ScrollView.NativeFieldInfoPtr_verticalVariantContentUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "verticalVariantContentUssClassName");
			ScrollView.NativeFieldInfoPtr_verticalHorizontalVariantContentUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "verticalHorizontalVariantContentUssClassName");
			ScrollView.NativeFieldInfoPtr_hScrollerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "hScrollerUssClassName");
			ScrollView.NativeFieldInfoPtr_vScrollerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "vScrollerUssClassName");
			ScrollView.NativeFieldInfoPtr_horizontalVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "horizontalVariantUssClassName");
			ScrollView.NativeFieldInfoPtr_verticalVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "verticalVariantUssClassName");
			ScrollView.NativeFieldInfoPtr_verticalHorizontalVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "verticalHorizontalVariantUssClassName");
			ScrollView.NativeFieldInfoPtr_scrollVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "scrollVariantUssClassName");
			ScrollView.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_Mode");
			ScrollView.NativeFieldInfoPtr_m_ScheduledLayoutPassResetItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_ScheduledLayoutPassResetItem");
			ScrollView.NativeFieldInfoPtr_m_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_StartPosition");
			ScrollView.NativeFieldInfoPtr_m_PointerStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_PointerStartPosition");
			ScrollView.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_Velocity");
			ScrollView.NativeFieldInfoPtr_m_SpringBackVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_SpringBackVelocity");
			ScrollView.NativeFieldInfoPtr_m_LowBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_LowBounds");
			ScrollView.NativeFieldInfoPtr_m_HighBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_HighBounds");
			ScrollView.NativeFieldInfoPtr_m_LastVelocityLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_LastVelocityLerpTime");
			ScrollView.NativeFieldInfoPtr_m_StartedMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_StartedMoving");
			ScrollView.NativeFieldInfoPtr_m_TouchPointerMoveAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_TouchPointerMoveAllowed");
			ScrollView.NativeFieldInfoPtr_m_TouchStoppedVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_TouchStoppedVelocity");
			ScrollView.NativeFieldInfoPtr_m_CapturedTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_CapturedTarget");
			ScrollView.NativeFieldInfoPtr_m_CapturedTargetPointerMoveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_CapturedTargetPointerMoveCallback");
			ScrollView.NativeFieldInfoPtr_m_CapturedTargetPointerUpCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_CapturedTargetPointerUpCallback");
			ScrollView.NativeFieldInfoPtr_m_PostPointerUpAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "m_PostPointerUpAnimation");
			ScrollView.NativeMethodInfoPtr_get_horizontalScrollerVisibility_Public_get_ScrollerVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665205);
			ScrollView.NativeMethodInfoPtr_set_horizontalScrollerVisibility_Public_set_Void_ScrollerVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665206);
			ScrollView.NativeMethodInfoPtr_get_verticalScrollerVisibility_Public_get_ScrollerVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665207);
			ScrollView.NativeMethodInfoPtr_set_verticalScrollerVisibility_Public_set_Void_ScrollerVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665208);
			ScrollView.NativeMethodInfoPtr_set_showHorizontal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665209);
			ScrollView.NativeMethodInfoPtr_set_showVertical_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665210);
			ScrollView.NativeMethodInfoPtr_get_needsHorizontal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665211);
			ScrollView.NativeMethodInfoPtr_get_needsVertical_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665212);
			ScrollView.NativeMethodInfoPtr_get_isVerticalScrollDisplayed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665213);
			ScrollView.NativeMethodInfoPtr_get_isHorizontalScrollDisplayed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665214);
			ScrollView.NativeMethodInfoPtr_get_scrollOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665215);
			ScrollView.NativeMethodInfoPtr_set_scrollOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665216);
			ScrollView.NativeMethodInfoPtr_set_horizontalPageSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665217);
			ScrollView.NativeMethodInfoPtr_set_verticalPageSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665218);
			ScrollView.NativeMethodInfoPtr_get_mouseWheelScrollSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665219);
			ScrollView.NativeMethodInfoPtr_set_mouseWheelScrollSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665220);
			ScrollView.NativeMethodInfoPtr_get_scrollableWidth_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665221);
			ScrollView.NativeMethodInfoPtr_get_scrollableHeight_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665222);
			ScrollView.NativeMethodInfoPtr_get_hasInertia_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665223);
			ScrollView.NativeMethodInfoPtr_get_scrollDecelerationRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665224);
			ScrollView.NativeMethodInfoPtr_set_scrollDecelerationRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665225);
			ScrollView.NativeMethodInfoPtr_get_elasticity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665226);
			ScrollView.NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665227);
			ScrollView.NativeMethodInfoPtr_get_touchScrollBehavior_Public_get_TouchScrollBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665228);
			ScrollView.NativeMethodInfoPtr_set_touchScrollBehavior_Public_set_Void_TouchScrollBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665229);
			ScrollView.NativeMethodInfoPtr_get_nestedInteractionKind_Public_get_NestedInteractionKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665230);
			ScrollView.NativeMethodInfoPtr_set_nestedInteractionKind_Public_set_Void_NestedInteractionKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665231);
			ScrollView.NativeMethodInfoPtr_set_elasticAnimationIntervalMs_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665232);
			ScrollView.NativeMethodInfoPtr_OnHorizontalScrollDragElementChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665233);
			ScrollView.NativeMethodInfoPtr_OnVerticalScrollDragElementChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665234);
			ScrollView.NativeMethodInfoPtr_UpdateHorizontalSliderPageSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665235);
			ScrollView.NativeMethodInfoPtr_UpdateVerticalSliderPageSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665236);
			ScrollView.NativeMethodInfoPtr_UpdateContentViewTransform_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665237);
			ScrollView.NativeMethodInfoPtr_ScrollTo_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665238);
			ScrollView.NativeMethodInfoPtr_GetXDeltaOffset_Private_Single_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665239);
			ScrollView.NativeMethodInfoPtr_GetYDeltaOffset_Private_Single_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665240);
			ScrollView.NativeMethodInfoPtr_GetDeltaDistance_Private_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665241);
			ScrollView.NativeMethodInfoPtr_get_contentViewport_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665242);
			ScrollView.NativeMethodInfoPtr_get_horizontalScroller_Public_get_Scroller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665243);
			ScrollView.NativeMethodInfoPtr_get_verticalScroller_Public_get_Scroller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665244);
			ScrollView.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665245);
			ScrollView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665246);
			ScrollView.NativeMethodInfoPtr__ctor_Public_Void_ScrollViewMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665247);
			ScrollView.NativeMethodInfoPtr_get_mode_Public_get_ScrollViewMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665248);
			ScrollView.NativeMethodInfoPtr_set_mode_Public_set_Void_ScrollViewMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665249);
			ScrollView.NativeMethodInfoPtr_SetScrollViewMode_Private_Void_ScrollViewMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665250);
			ScrollView.NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665251);
			ScrollView.NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665252);
			ScrollView.NativeMethodInfoPtr_OnPointerCapture_Private_Void_PointerCaptureEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665253);
			ScrollView.NativeMethodInfoPtr_OnPointerCaptureOut_Private_Void_PointerCaptureOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665254);
			ScrollView.NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665255);
			ScrollView.NativeMethodInfoPtr_ScheduleResetLayoutPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665256);
			ScrollView.NativeMethodInfoPtr_ResetLayoutPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665257);
			ScrollView.NativeMethodInfoPtr_ComputeElasticOffset_Private_Static_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665258);
			ScrollView.NativeMethodInfoPtr_ComputeInitialSpringBackVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665259);
			ScrollView.NativeMethodInfoPtr_SpringBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665260);
			ScrollView.NativeMethodInfoPtr_ApplyScrollInertia_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665261);
			ScrollView.NativeMethodInfoPtr_PostPointerUpAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665262);
			ScrollView.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665263);
			ScrollView.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665264);
			ScrollView.NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665265);
			ScrollView.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665266);
			ScrollView.NativeMethodInfoPtr_InitTouchScrolling_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665267);
			ScrollView.NativeMethodInfoPtr_ComputeTouchScrolling_Internal_TouchScrollingResult_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665268);
			ScrollView.NativeMethodInfoPtr_ApplyTouchScrolling_Private_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665269);
			ScrollView.NativeMethodInfoPtr_ReleaseScrolling_Private_Boolean_Int32_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665270);
			ScrollView.NativeMethodInfoPtr_ExecuteElasticSpringAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665271);
			ScrollView.NativeMethodInfoPtr_AdjustScrollers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665272);
			ScrollView.NativeMethodInfoPtr_UpdateScrollers_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665273);
			ScrollView.NativeMethodInfoPtr_OnScrollersGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665274);
			ScrollView.NativeMethodInfoPtr_OnScrollWheel_Private_Void_WheelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665275);
			ScrollView.NativeMethodInfoPtr_OnRootCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665276);
			ScrollView.NativeMethodInfoPtr_OnRootPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665277);
			ScrollView.NativeMethodInfoPtr_ReadSingleLineHeight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665278);
			ScrollView.NativeMethodInfoPtr_UpdateElasticBehaviour_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665279);
			ScrollView.NativeMethodInfoPtr___ctor_b__126_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665281);
			ScrollView.NativeMethodInfoPtr___ctor_b__126_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, 100665282);
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0004C548 File Offset: 0x0004A748
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x0004C584 File Offset: 0x0004A784
		public unsafe ScrollerVisibility horizontalScrollerVisibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_horizontalScrollerVisibility_Public_get_ScrollerVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 303899, RefRangeEnd = 303902, XrefRangeStart = 303893, XrefRangeEnd = 303899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_horizontalScrollerVisibility_Public_set_Void_ScrollerVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0004C5C4 File Offset: 0x0004A7C4
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x0004C600 File Offset: 0x0004A800
		public unsafe ScrollerVisibility verticalScrollerVisibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_verticalScrollerVisibility_Public_get_ScrollerVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 303908, RefRangeEnd = 303909, XrefRangeStart = 303902, XrefRangeEnd = 303908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_verticalScrollerVisibility_Public_set_Void_ScrollerVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0000749E File Offset: 0x0000569E
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x0004C640 File Offset: 0x0004A840
		public unsafe bool showHorizontal
		{
			get
			{
				return this.horizontalScrollerVisibility == ScrollerVisibility.AlwaysVisible;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_showHorizontal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x000074A9 File Offset: 0x000056A9
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x0004C680 File Offset: 0x0004A880
		public unsafe bool showVertical
		{
			get
			{
				return this.verticalScrollerVisibility == ScrollerVisibility.AlwaysVisible;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_showVertical_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0004C6C0 File Offset: 0x0004A8C0
		public unsafe bool needsHorizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_needsHorizontal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x0004C6FC File Offset: 0x0004A8FC
		public unsafe bool needsVertical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_needsVertical_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0004C738 File Offset: 0x0004A938
		public unsafe bool isVerticalScrollDisplayed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303909, XrefRangeEnd = 303913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_isVerticalScrollDisplayed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x0004C774 File Offset: 0x0004A974
		public unsafe bool isHorizontalScrollDisplayed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303913, XrefRangeEnd = 303917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_isHorizontalScrollDisplayed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x0004C7B0 File Offset: 0x0004A9B0
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x0004C7EC File Offset: 0x0004A9EC
		public unsafe Vector2 scrollOffset
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 303917, RefRangeEnd = 303943, XrefRangeStart = 303917, XrefRangeEnd = 303917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_scrollOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 303952, RefRangeEnd = 303961, XrefRangeStart = 303943, XrefRangeEnd = 303952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_scrollOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x0004E1E8 File Offset: 0x0004C3E8
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x0004C82C File Offset: 0x0004AA2C
		public unsafe float horizontalPageSize
		{
			get
			{
				return this.m_HorizontalPageSize;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303961, XrefRangeEnd = 303962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_horizontalPageSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x0004E200 File Offset: 0x0004C400
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x0004C86C File Offset: 0x0004AA6C
		public unsafe float verticalPageSize
		{
			get
			{
				return this.m_VerticalPageSize;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303962, XrefRangeEnd = 303963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_verticalPageSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0004C8AC File Offset: 0x0004AAAC
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x0004C8E8 File Offset: 0x0004AAE8
		public unsafe float mouseWheelScrollSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_mouseWheelScrollSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303963, XrefRangeEnd = 303966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_mouseWheelScrollSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x0004C928 File Offset: 0x0004AB28
		public unsafe float scrollableWidth
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 303968, RefRangeEnd = 303977, XrefRangeStart = 303966, XrefRangeEnd = 303968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_scrollableWidth_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0004C964 File Offset: 0x0004AB64
		public unsafe float scrollableHeight
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 303979, RefRangeEnd = 303988, XrefRangeStart = 303977, XrefRangeEnd = 303979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_scrollableHeight_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0004C9A0 File Offset: 0x0004ABA0
		public unsafe bool hasInertia
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_hasInertia_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0004C9DC File Offset: 0x0004ABDC
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x0004CA18 File Offset: 0x0004AC18
		public unsafe float scrollDecelerationRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_scrollDecelerationRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_scrollDecelerationRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x0004CA58 File Offset: 0x0004AC58
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x0004CA94 File Offset: 0x0004AC94
		public unsafe float elasticity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_elasticity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x0004CAD4 File Offset: 0x0004ACD4
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x0004CB10 File Offset: 0x0004AD10
		public unsafe ScrollView.TouchScrollBehavior touchScrollBehavior
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_touchScrollBehavior_Public_get_TouchScrollBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 303989, RefRangeEnd = 303991, XrefRangeStart = 303988, XrefRangeEnd = 303989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_touchScrollBehavior_Public_set_Void_TouchScrollBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x0004CB50 File Offset: 0x0004AD50
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x0004CB8C File Offset: 0x0004AD8C
		public unsafe ScrollView.NestedInteractionKind nestedInteractionKind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_nestedInteractionKind_Public_get_NestedInteractionKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_nestedInteractionKind_Public_set_Void_NestedInteractionKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0004E218 File Offset: 0x0004C418
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x0004CBCC File Offset: 0x0004ADCC
		public unsafe long elasticAnimationIntervalMs
		{
			get
			{
				return this.m_ElasticAnimationIntervalMs;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303991, XrefRangeEnd = 304005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_elasticAnimationIntervalMs_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0004CC0C File Offset: 0x0004AE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304005, XrefRangeEnd = 304006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnHorizontalScrollDragElementChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0004CC50 File Offset: 0x0004AE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304006, XrefRangeEnd = 304007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnVerticalScrollDragElementChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0004CC94 File Offset: 0x0004AE94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 304016, RefRangeEnd = 304020, XrefRangeStart = 304007, XrefRangeEnd = 304016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHorizontalSliderPageSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_UpdateHorizontalSliderPageSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0004CCC8 File Offset: 0x0004AEC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 304029, RefRangeEnd = 304033, XrefRangeStart = 304020, XrefRangeEnd = 304029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVerticalSliderPageSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_UpdateVerticalSliderPageSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0004CCFC File Offset: 0x0004AEFC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 304056, RefRangeEnd = 304066, XrefRangeStart = 304033, XrefRangeEnd = 304056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateContentViewTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_UpdateContentViewTransform_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0004CD30 File Offset: 0x0004AF30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304074, RefRangeEnd = 304075, XrefRangeStart = 304066, XrefRangeEnd = 304074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScrollTo(VisualElement child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ScrollTo_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0004CD74 File Offset: 0x0004AF74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304090, RefRangeEnd = 304091, XrefRangeStart = 304075, XrefRangeEnd = 304090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetXDeltaOffset(VisualElement child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_GetXDeltaOffset_Private_Single_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0004CDC4 File Offset: 0x0004AFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304106, RefRangeEnd = 304107, XrefRangeStart = 304091, XrefRangeEnd = 304106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetYDeltaOffset(VisualElement child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_GetYDeltaOffset_Private_Single_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0004CE14 File Offset: 0x0004B014
		[CallerCount(0)]
		public unsafe float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref childBoundaryMin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref childBoundaryMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_GetDeltaDistance_Private_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x0004CE88 File Offset: 0x0004B088
		public unsafe VisualElement contentViewport
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_contentViewport_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x0004CEC8 File Offset: 0x0004B0C8
		public unsafe Scroller horizontalScroller
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_horizontalScroller_Public_get_Scroller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scroller>(intPtr3) : null;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x0004CF08 File Offset: 0x0004B108
		public unsafe Scroller verticalScroller
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_verticalScroller_Public_get_Scroller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scroller>(intPtr3) : null;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x0004CF48 File Offset: 0x0004B148
		public unsafe override VisualElement contentContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollView.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0004CF94 File Offset: 0x0004B194
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 304108, RefRangeEnd = 304111, XrefRangeStart = 304107, XrefRangeEnd = 304108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0004CFD0 File Offset: 0x0004B1D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304337, RefRangeEnd = 304338, XrefRangeStart = 304111, XrefRangeEnd = 304337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollView(ScrollViewMode scrollViewMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollView>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollViewMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr__ctor_Public_Void_ScrollViewMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0004D018 File Offset: 0x0004B218
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x0004D054 File Offset: 0x0004B254
		public unsafe ScrollViewMode mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_get_mode_Public_get_ScrollViewMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 304339, RefRangeEnd = 304342, XrefRangeStart = 304338, XrefRangeEnd = 304339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_set_mode_Public_set_Void_ScrollViewMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0004D094 File Offset: 0x0004B294
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 304375, RefRangeEnd = 304378, XrefRangeStart = 304342, XrefRangeEnd = 304375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScrollViewMode(ScrollViewMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_SetScrollViewMode_Private_Void_ScrollViewMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0004D0D4 File Offset: 0x0004B2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304378, XrefRangeEnd = 304457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAttachToPanel(AttachToPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0004D118 File Offset: 0x0004B318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304457, XrefRangeEnd = 304537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0004D15C File Offset: 0x0004B35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304537, XrefRangeEnd = 304551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerCapture(PointerCaptureEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnPointerCapture_Private_Void_PointerCaptureEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0004D1A0 File Offset: 0x0004B3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304551, XrefRangeEnd = 304561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerCaptureOut(PointerCaptureOutEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnPointerCaptureOut_Private_Void_PointerCaptureOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0004D1E4 File Offset: 0x0004B3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304561, XrefRangeEnd = 304588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGeometryChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0004D228 File Offset: 0x0004B428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304588, XrefRangeEnd = 304596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleResetLayoutPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ScheduleResetLayoutPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0004D25C File Offset: 0x0004B45C
		[CallerCount(0)]
		public unsafe void ResetLayoutPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ResetLayoutPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0004D290 File Offset: 0x0004B490
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304600, RefRangeEnd = 304602, XrefRangeStart = 304596, XrefRangeEnd = 304600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaPointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialScrollOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowLimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardLowLimit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highLimit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardHighLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ComputeElasticOffset_Private_Static_Single_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0004D314 File Offset: 0x0004B514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304602, XrefRangeEnd = 304609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeInitialSpringBackVelocity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ComputeInitialSpringBackVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0004D348 File Offset: 0x0004B548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304621, RefRangeEnd = 304622, XrefRangeStart = 304609, XrefRangeEnd = 304621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpringBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_SpringBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0004D37C File Offset: 0x0004B57C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304634, RefRangeEnd = 304635, XrefRangeStart = 304622, XrefRangeEnd = 304634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyScrollInertia()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ApplyScrollInertia_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0004D3B0 File Offset: 0x0004B5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304635, XrefRangeEnd = 304648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostPointerUpAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_PostPointerUpAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0004D3E4 File Offset: 0x0004B5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304648, XrefRangeEnd = 304672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDown(PointerDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0004D428 File Offset: 0x0004B628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304672, XrefRangeEnd = 304684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMove(PointerMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0004D46C File Offset: 0x0004B66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304684, XrefRangeEnd = 304688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerCancel(PointerCancelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0004D4B0 File Offset: 0x0004B6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304688, XrefRangeEnd = 304694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUp(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0004D4F4 File Offset: 0x0004B6F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304723, RefRangeEnd = 304724, XrefRangeStart = 304694, XrefRangeEnd = 304723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitTouchScrolling(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_InitTouchScrolling_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0004D534 File Offset: 0x0004B734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304750, RefRangeEnd = 304751, XrefRangeStart = 304724, XrefRangeEnd = 304750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollView.TouchScrollingResult ComputeTouchScrolling(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ComputeTouchScrolling_Internal_TouchScrollingResult_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0004D580 File Offset: 0x0004B780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304759, RefRangeEnd = 304760, XrefRangeStart = 304751, XrefRangeEnd = 304759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ApplyTouchScrolling(Vector2 newScrollOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newScrollOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ApplyTouchScrolling_Private_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0004D5CC File Offset: 0x0004B7CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 304765, RefRangeEnd = 304769, XrefRangeStart = 304760, XrefRangeEnd = 304765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReleaseScrolling(int pointerId, IEventHandler target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ReleaseScrolling_Private_Boolean_Int32_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0004D628 File Offset: 0x0004B828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304790, RefRangeEnd = 304792, XrefRangeStart = 304769, XrefRangeEnd = 304790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteElasticSpringAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ExecuteElasticSpringAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0004D65C File Offset: 0x0004B85C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304802, RefRangeEnd = 304804, XrefRangeStart = 304792, XrefRangeEnd = 304802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustScrollers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_AdjustScrollers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0004D690 File Offset: 0x0004B890
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 304856, RefRangeEnd = 304862, XrefRangeStart = 304804, XrefRangeEnd = 304856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollers(bool displayHorizontal, bool displayVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayHorizontal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref displayVertical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_UpdateScrollers_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0004D6DC File Offset: 0x0004B8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304862, XrefRangeEnd = 304871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScrollersGeometryChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnScrollersGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0004D720 File Offset: 0x0004B920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304871, XrefRangeEnd = 304898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScrollWheel(WheelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnScrollWheel_Private_Void_WheelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0004D764 File Offset: 0x0004B964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304898, XrefRangeEnd = 304899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnRootCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0004D7A8 File Offset: 0x0004B9A8
		[CallerCount(0)]
		public unsafe void OnRootPointerUp(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_OnRootPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0004D7EC File Offset: 0x0004B9EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304908, RefRangeEnd = 304910, XrefRangeStart = 304899, XrefRangeEnd = 304908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadSingleLineHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_ReadSingleLineHeight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0004D820 File Offset: 0x0004BA20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304935, RefRangeEnd = 304936, XrefRangeStart = 304910, XrefRangeEnd = 304935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElasticBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr_UpdateElasticBehaviour_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0004D854 File Offset: 0x0004BA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304936, XrefRangeEnd = 304939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__126_0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr___ctor_b__126_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0004D894 File Offset: 0x0004BA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304939, XrefRangeEnd = 304942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__126_1(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.NativeMethodInfoPtr___ctor_b__126_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00006ECC File Offset: 0x000050CC
		public ScrollView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0004D8D4 File Offset: 0x0004BAD4
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x00006ED5 File Offset: 0x000050D5
		public unsafe int m_FirstLayoutPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_FirstLayoutPass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_FirstLayoutPass)) = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0004D8FC File Offset: 0x0004BAFC
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x00006EF0 File Offset: 0x000050F0
		public unsafe ScrollerVisibility m_HorizontalScrollerVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_HorizontalScrollerVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_HorizontalScrollerVisibility)) = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0004D924 File Offset: 0x0004BB24
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x00006F0B File Offset: 0x0000510B
		public unsafe ScrollerVisibility m_VerticalScrollerVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_VerticalScrollerVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_VerticalScrollerVisibility)) = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0004D94C File Offset: 0x0004BB4C
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00006F26 File Offset: 0x00005126
		public unsafe VisualElement m_AttachedRootVisualContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_AttachedRootVisualContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_AttachedRootVisualContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0004D97C File Offset: 0x0004BB7C
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x00006F45 File Offset: 0x00005145
		public unsafe float m_SingleLineHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_SingleLineHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_SingleLineHeight)) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0004D9A4 File Offset: 0x0004BBA4
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00006F60 File Offset: 0x00005160
		public unsafe bool m_MouseWheelScrollSizeIsInline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_MouseWheelScrollSizeIsInline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_MouseWheelScrollSizeIsInline)) = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0004D9CC File Offset: 0x0004BBCC
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x00006F7B File Offset: 0x0000517B
		public unsafe float m_HorizontalPageSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_HorizontalPageSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_HorizontalPageSize)) = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0004D9F4 File Offset: 0x0004BBF4
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00006F96 File Offset: 0x00005196
		public unsafe float m_VerticalPageSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_VerticalPageSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_VerticalPageSize)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0004DA1C File Offset: 0x0004BC1C
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00006FB1 File Offset: 0x000051B1
		public unsafe float m_MouseWheelScrollSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_MouseWheelScrollSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_MouseWheelScrollSize)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0004DA44 File Offset: 0x0004BC44
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x00006FCC File Offset: 0x000051CC
		public unsafe static float k_DefaultScrollDecelerationRate
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_k_DefaultScrollDecelerationRate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_k_DefaultScrollDecelerationRate, (void*)(&value));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0004DA60 File Offset: 0x0004BC60
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x00006FDA File Offset: 0x000051DA
		public unsafe float m_ScrollDecelerationRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_ScrollDecelerationRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_ScrollDecelerationRate)) = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0004DA88 File Offset: 0x0004BC88
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x00006FF5 File Offset: 0x000051F5
		public unsafe float k_ScaledPixelsPerPointMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_k_ScaledPixelsPerPointMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_k_ScaledPixelsPerPointMultiplier)) = value;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0004DAB0 File Offset: 0x0004BCB0
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x00007010 File Offset: 0x00005210
		public unsafe float k_TouchScrollInertiaBaseTimeInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_k_TouchScrollInertiaBaseTimeInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_k_TouchScrollInertiaBaseTimeInterval)) = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0004DAD8 File Offset: 0x0004BCD8
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x0000702B File Offset: 0x0000522B
		public unsafe static float k_DefaultElasticity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_k_DefaultElasticity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_k_DefaultElasticity, (void*)(&value));
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x0004DAF4 File Offset: 0x0004BCF4
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x00007039 File Offset: 0x00005239
		public unsafe float m_Elasticity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_Elasticity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_Elasticity)) = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0004DB1C File Offset: 0x0004BD1C
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x00007054 File Offset: 0x00005254
		public unsafe ScrollView.TouchScrollBehavior m_TouchScrollBehavior
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_TouchScrollBehavior);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_TouchScrollBehavior)) = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x0004DB44 File Offset: 0x0004BD44
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x0000706F File Offset: 0x0000526F
		public unsafe ScrollView.NestedInteractionKind m_NestedInteractionKind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_NestedInteractionKind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_NestedInteractionKind)) = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x0004DB6C File Offset: 0x0004BD6C
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x0000708A File Offset: 0x0000528A
		public unsafe static long k_DefaultElasticAnimationInterval
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_k_DefaultElasticAnimationInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_k_DefaultElasticAnimationInterval, (void*)(&value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0004DB88 File Offset: 0x0004BD88
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x00007098 File Offset: 0x00005298
		public unsafe long m_ElasticAnimationIntervalMs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_ElasticAnimationIntervalMs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_ElasticAnimationIntervalMs)) = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x000070B3 File Offset: 0x000052B3
		public unsafe VisualElement _contentViewport_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr__contentViewport_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr__contentViewport_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x0004DBE0 File Offset: 0x0004BDE0
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x000070D2 File Offset: 0x000052D2
		public unsafe Scroller _horizontalScroller_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr__horizontalScroller_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scroller>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr__horizontalScroller_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0004DC10 File Offset: 0x0004BE10
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x000070F1 File Offset: 0x000052F1
		public unsafe Scroller _verticalScroller_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr__verticalScroller_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scroller>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr__verticalScroller_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0004DC40 File Offset: 0x0004BE40
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x00007110 File Offset: 0x00005310
		public unsafe VisualElement m_ContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_ContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x0004DC70 File Offset: 0x0004BE70
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x0000712F File Offset: 0x0000532F
		public unsafe VisualElement m_ContentAndVerticalScrollContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_ContentAndVerticalScrollContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_ContentAndVerticalScrollContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x0004DCA0 File Offset: 0x0004BEA0
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x0000714E File Offset: 0x0000534E
		public unsafe float previousVerticalTouchScrollTimeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_previousVerticalTouchScrollTimeStamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_previousVerticalTouchScrollTimeStamp)) = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x0004DCC8 File Offset: 0x0004BEC8
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x00007169 File Offset: 0x00005369
		public unsafe float previousHorizontalTouchScrollTimeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_previousHorizontalTouchScrollTimeStamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_previousHorizontalTouchScrollTimeStamp)) = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x0004DCF0 File Offset: 0x0004BEF0
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00007184 File Offset: 0x00005384
		public unsafe float elapsedTimeSinceLastVerticalTouchScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_elapsedTimeSinceLastVerticalTouchScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_elapsedTimeSinceLastVerticalTouchScroll)) = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0004DD18 File Offset: 0x0004BF18
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x0000719F File Offset: 0x0000539F
		public unsafe float elapsedTimeSinceLastHorizontalTouchScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_elapsedTimeSinceLastHorizontalTouchScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_elapsedTimeSinceLastHorizontalTouchScroll)) = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x0004DD40 File Offset: 0x0004BF40
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x000071BA File Offset: 0x000053BA
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0004DD60 File Offset: 0x0004BF60
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x000071CC File Offset: 0x000053CC
		public unsafe static string viewportUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_viewportUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_viewportUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x0004DD80 File Offset: 0x0004BF80
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x000071DE File Offset: 0x000053DE
		public unsafe static string horizontalVariantViewportUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_horizontalVariantViewportUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_horizontalVariantViewportUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x0004DDA0 File Offset: 0x0004BFA0
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x000071F0 File Offset: 0x000053F0
		public unsafe static string verticalVariantViewportUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_verticalVariantViewportUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_verticalVariantViewportUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x0004DDC0 File Offset: 0x0004BFC0
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00007202 File Offset: 0x00005402
		public unsafe static string verticalHorizontalVariantViewportUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_verticalHorizontalVariantViewportUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_verticalHorizontalVariantViewportUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x0004DDE0 File Offset: 0x0004BFE0
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00007214 File Offset: 0x00005414
		public unsafe static string contentAndVerticalScrollUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_contentAndVerticalScrollUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_contentAndVerticalScrollUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0004DE00 File Offset: 0x0004C000
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00007226 File Offset: 0x00005426
		public unsafe static string contentUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_contentUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_contentUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0004DE20 File Offset: 0x0004C020
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x00007238 File Offset: 0x00005438
		public unsafe static string horizontalVariantContentUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_horizontalVariantContentUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_horizontalVariantContentUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x0004DE40 File Offset: 0x0004C040
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x0000724A File Offset: 0x0000544A
		public unsafe static string verticalVariantContentUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_verticalVariantContentUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_verticalVariantContentUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x0004DE60 File Offset: 0x0004C060
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x0000725C File Offset: 0x0000545C
		public unsafe static string verticalHorizontalVariantContentUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_verticalHorizontalVariantContentUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_verticalHorizontalVariantContentUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x0004DE80 File Offset: 0x0004C080
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x0000726E File Offset: 0x0000546E
		public unsafe static string hScrollerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_hScrollerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_hScrollerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0004DEA0 File Offset: 0x0004C0A0
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x00007280 File Offset: 0x00005480
		public unsafe static string vScrollerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_vScrollerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_vScrollerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0004DEC0 File Offset: 0x0004C0C0
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x00007292 File Offset: 0x00005492
		public unsafe static string horizontalVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_horizontalVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_horizontalVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0004DEE0 File Offset: 0x0004C0E0
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x000072A4 File Offset: 0x000054A4
		public unsafe static string verticalVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_verticalVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_verticalVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0004DF00 File Offset: 0x0004C100
		// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x000072B6 File Offset: 0x000054B6
		public unsafe static string verticalHorizontalVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_verticalHorizontalVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_verticalHorizontalVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x0004DF20 File Offset: 0x0004C120
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x000072C8 File Offset: 0x000054C8
		public unsafe static string scrollVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScrollView.NativeFieldInfoPtr_scrollVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScrollView.NativeFieldInfoPtr_scrollVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0004DF40 File Offset: 0x0004C140
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x000072DA File Offset: 0x000054DA
		public unsafe ScrollViewMode m_Mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_Mode)) = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0004DF68 File Offset: 0x0004C168
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x000072F5 File Offset: 0x000054F5
		public unsafe IVisualElementScheduledItem m_ScheduledLayoutPassResetItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_ScheduledLayoutPassResetItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_ScheduledLayoutPassResetItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x0004DF98 File Offset: 0x0004C198
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x00007314 File Offset: 0x00005514
		public unsafe Vector2 m_StartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_StartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_StartPosition)) = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x0004DFC0 File Offset: 0x0004C1C0
		// (set) Token: 0x06000DEC RID: 3564 RVA: 0x0000732F File Offset: 0x0000552F
		public unsafe Vector2 m_PointerStartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_PointerStartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_PointerStartPosition)) = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x0004DFE8 File Offset: 0x0004C1E8
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x0000734A File Offset: 0x0000554A
		public unsafe Vector2 m_Velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_Velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_Velocity)) = value;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x0004E010 File Offset: 0x0004C210
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x00007365 File Offset: 0x00005565
		public unsafe Vector2 m_SpringBackVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_SpringBackVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_SpringBackVelocity)) = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x0004E038 File Offset: 0x0004C238
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x00007380 File Offset: 0x00005580
		public unsafe Vector2 m_LowBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_LowBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_LowBounds)) = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x0004E060 File Offset: 0x0004C260
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x0000739B File Offset: 0x0000559B
		public unsafe Vector2 m_HighBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_HighBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_HighBounds)) = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0004E088 File Offset: 0x0004C288
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x000073B6 File Offset: 0x000055B6
		public unsafe float m_LastVelocityLerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_LastVelocityLerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_LastVelocityLerpTime)) = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0004E0B0 File Offset: 0x0004C2B0
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x000073D1 File Offset: 0x000055D1
		public unsafe bool m_StartedMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_StartedMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_StartedMoving)) = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x0004E0D8 File Offset: 0x0004C2D8
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x000073EC File Offset: 0x000055EC
		public unsafe bool m_TouchPointerMoveAllowed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_TouchPointerMoveAllowed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_TouchPointerMoveAllowed)) = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x0004E100 File Offset: 0x0004C300
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x00007407 File Offset: 0x00005607
		public unsafe bool m_TouchStoppedVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_TouchStoppedVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_TouchStoppedVelocity)) = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0004E128 File Offset: 0x0004C328
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x00007422 File Offset: 0x00005622
		public unsafe VisualElement m_CapturedTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_CapturedTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_CapturedTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x0004E158 File Offset: 0x0004C358
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00007441 File Offset: 0x00005641
		public unsafe EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_CapturedTargetPointerMoveCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<PointerMoveEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_CapturedTargetPointerMoveCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0004E188 File Offset: 0x0004C388
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x00007460 File Offset: 0x00005660
		public unsafe EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_CapturedTargetPointerUpCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<PointerUpEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_CapturedTargetPointerUpCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0004E1B8 File Offset: 0x0004C3B8
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x0000747F File Offset: 0x0000567F
		public unsafe IVisualElementScheduledItem m_PostPointerUpAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_PostPointerUpAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.NativeFieldInfoPtr_m_PostPointerUpAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstLayoutPass;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollerVisibility;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollerVisibility;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeFieldInfoPtr_m_AttachedRootVisualContainer;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleLineHeight;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseWheelScrollSizeIsInline;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalPageSize;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalPageSize;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseWheelScrollSize;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultScrollDecelerationRate;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollDecelerationRate;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr_k_ScaledPixelsPerPointMultiplier;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr_k_TouchScrollInertiaBaseTimeInterval;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultElasticity;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_m_Elasticity;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchScrollBehavior;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeFieldInfoPtr_m_NestedInteractionKind;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultElasticAnimationInterval;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr_m_ElasticAnimationIntervalMs;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr__contentViewport_k__BackingField;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr__horizontalScroller_k__BackingField;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr__verticalScroller_k__BackingField;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentContainer;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentAndVerticalScrollContainer;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeFieldInfoPtr_previousVerticalTouchScrollTimeStamp;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeFieldInfoPtr_previousHorizontalTouchScrollTimeStamp;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeFieldInfoPtr_elapsedTimeSinceLastVerticalTouchScroll;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr_elapsedTimeSinceLastHorizontalTouchScroll;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeFieldInfoPtr_viewportUssClassName;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr_horizontalVariantViewportUssClassName;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeFieldInfoPtr_verticalVariantViewportUssClassName;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeFieldInfoPtr_verticalHorizontalVariantViewportUssClassName;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_contentAndVerticalScrollUssClassName;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr_contentUssClassName;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_horizontalVariantContentUssClassName;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr_verticalVariantContentUssClassName;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr_verticalHorizontalVariantContentUssClassName;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr_hScrollerUssClassName;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr_vScrollerUssClassName;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeFieldInfoPtr_horizontalVariantUssClassName;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeFieldInfoPtr_verticalVariantUssClassName;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr_verticalHorizontalVariantUssClassName;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr_scrollVariantUssClassName;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_m_ScheduledLayoutPassResetItem;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_m_StartPosition;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerStartPosition;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr_m_Velocity;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeFieldInfoPtr_m_SpringBackVelocity;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_m_LowBounds;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_m_HighBounds;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeFieldInfoPtr_m_LastVelocityLerpTime;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_m_StartedMoving;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchPointerMoveAllowed;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchStoppedVelocity;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeFieldInfoPtr_m_CapturedTarget;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr_m_CapturedTargetPointerMoveCallback;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr_m_CapturedTargetPointerUpCallback;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeFieldInfoPtr_m_PostPointerUpAnimation;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollerVisibility_Public_get_ScrollerVisibility_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollerVisibility_Public_set_Void_ScrollerVisibility_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollerVisibility_Public_get_ScrollerVisibility_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollerVisibility_Public_set_Void_ScrollerVisibility_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_set_showHorizontal_Public_set_Void_Boolean_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_set_showVertical_Public_set_Void_Boolean_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_get_needsHorizontal_Internal_get_Boolean_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_get_needsVertical_Internal_get_Boolean_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_get_isVerticalScrollDisplayed_Internal_get_Boolean_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_get_isHorizontalScrollDisplayed_Internal_get_Boolean_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollOffset_Public_get_Vector2_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollOffset_Public_set_Void_Vector2_0;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalPageSize_Public_set_Void_Single_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalPageSize_Public_set_Void_Single_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseWheelScrollSize_Public_get_Single_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_set_mouseWheelScrollSize_Public_set_Void_Single_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollableWidth_Internal_get_Single_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollableHeight_Internal_get_Single_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_get_hasInertia_Private_get_Boolean_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollDecelerationRate_Public_get_Single_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollDecelerationRate_Public_set_Void_Single_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_get_elasticity_Public_get_Single_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_get_touchScrollBehavior_Public_get_TouchScrollBehavior_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_set_touchScrollBehavior_Public_set_Void_TouchScrollBehavior_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_get_nestedInteractionKind_Public_get_NestedInteractionKind_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_set_nestedInteractionKind_Public_set_Void_NestedInteractionKind_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_set_elasticAnimationIntervalMs_Public_set_Void_Int64_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_OnHorizontalScrollDragElementChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_OnVerticalScrollDragElementChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHorizontalSliderPageSize_Private_Void_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVerticalSliderPageSize_Private_Void_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_UpdateContentViewTransform_Internal_Void_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_ScrollTo_Public_Void_VisualElement_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_GetXDeltaOffset_Private_Single_VisualElement_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_GetYDeltaOffset_Private_Single_VisualElement_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_GetDeltaDistance_Private_Single_Single_Single_Single_Single_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_get_contentViewport_Public_get_VisualElement_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScroller_Public_get_Scroller_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScroller_Public_get_Scroller_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScrollViewMode_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_get_mode_Public_get_ScrollViewMode_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_set_mode_Public_set_Void_ScrollViewMode_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_SetScrollViewMode_Private_Void_ScrollViewMode_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerCapture_Private_Void_PointerCaptureEvent_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerCaptureOut_Private_Void_PointerCaptureOutEvent_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleResetLayoutPass_Private_Void_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_ResetLayoutPass_Private_Void_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_ComputeElasticOffset_Private_Static_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_ComputeInitialSpringBackVelocity_Private_Void_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_SpringBack_Private_Void_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_ApplyScrollInertia_Internal_Void_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_PostPointerUpAnimation_Private_Void_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_InitTouchScrolling_Internal_Void_Vector2_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_ComputeTouchScrolling_Internal_TouchScrollingResult_Vector2_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTouchScrolling_Private_Boolean_Vector2_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseScrolling_Private_Boolean_Int32_IEventHandler_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteElasticSpringAnimation_Private_Void_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_AdjustScrollers_Private_Void_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollers_Internal_Void_Boolean_Boolean_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_OnScrollersGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_OnScrollWheel_Private_Void_WheelEvent_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_OnRootCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_OnRootPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_ReadSingleLineHeight_Private_Void_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElasticBehaviour_Private_Void_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__126_0_Private_Void_Single_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__126_1_Private_Void_Single_0;

		// Token: 0x040009BD RID: 2493
		public const int k_MaxLocalLayoutPassCount = 5;

		// Token: 0x040009BE RID: 2494
		public const float k_SizeThreshold = 0.001f;

		// Token: 0x040009BF RID: 2495
		public const string k_SingleLineHeightPropertyName = "--unity-metrics-single_line-height";

		// Token: 0x040009C0 RID: 2496
		public const float k_ScrollPageOverlapFactor = 0.1f;

		// Token: 0x040009C1 RID: 2497
		public const float k_UnsetPageSizeValue = -1f;

		// Token: 0x040009C2 RID: 2498
		public const float k_MouseWheelScrollSizeDefaultValue = 18f;

		// Token: 0x040009C3 RID: 2499
		public const float k_MouseWheelScrollSizeUnset = -1f;

		// Token: 0x040009C4 RID: 2500
		public const float k_VelocityLerpTimeFactor = 10f;

		// Token: 0x040009C5 RID: 2501
		public const float ScrollThresholdSquared = 100f;

		// Token: 0x020003BE RID: 958
		public new class UxmlFactory : UxmlFactory<ScrollView, ScrollView.UxmlTraits>
		{
			// Token: 0x0600395F RID: 14687 RVA: 0x00018195 File Offset: 0x00016395
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<ScrollView.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollView.UxmlFactory>.NativeClassPtr);
				ScrollView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView.UxmlFactory>.NativeClassPtr, 100665283);
			}

			// Token: 0x06003960 RID: 14688 RVA: 0x000E9244 File Offset: 0x000E7444
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 303727, RefRangeEnd = 303728, XrefRangeStart = 303724, XrefRangeEnd = 303727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollView.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003961 RID: 14689 RVA: 0x000181C9 File Offset: 0x000163C9
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002895 RID: 10389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003BF RID: 959
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x06003962 RID: 14690 RVA: 0x000E9280 File Offset: 0x000E7480
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollView>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr);
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ScrollViewMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_ScrollViewMode");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_NestedInteractionKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_NestedInteractionKind");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ShowHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_ShowHorizontal");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ShowVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_ShowVertical");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_HorizontalScrollerVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_HorizontalScrollerVisibility");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_VerticalScrollerVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_VerticalScrollerVisibility");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_HorizontalPageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_HorizontalPageSize");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_VerticalPageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_VerticalPageSize");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_MouseWheelScrollSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_MouseWheelScrollSize");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_TouchScrollBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_TouchScrollBehavior");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ScrollDecelerationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_ScrollDecelerationRate");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_Elasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_Elasticity");
				ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ElasticAnimationIntervalMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, "m_ElasticAnimationIntervalMs");
				ScrollView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, 100665284);
				ScrollView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr, 100665285);
			}

			// Token: 0x06003963 RID: 14691 RVA: 0x000E93D8 File Offset: 0x000E75D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303728, XrefRangeEnd = 303773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003964 RID: 14692 RVA: 0x000E9450 File Offset: 0x000E7650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303773, XrefRangeEnd = 303893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollView.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003965 RID: 14693 RVA: 0x000181D2 File Offset: 0x000163D2
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700119C RID: 4508
			// (get) Token: 0x06003966 RID: 14694 RVA: 0x000E948C File Offset: 0x000E768C
			// (set) Token: 0x06003967 RID: 14695 RVA: 0x000181DB File Offset: 0x000163DB
			public unsafe UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ScrollViewMode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<ScrollViewMode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ScrollViewMode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700119D RID: 4509
			// (get) Token: 0x06003968 RID: 14696 RVA: 0x000E94BC File Offset: 0x000E76BC
			// (set) Token: 0x06003969 RID: 14697 RVA: 0x000181FA File Offset: 0x000163FA
			public unsafe UxmlEnumAttributeDescription<ScrollView.NestedInteractionKind> m_NestedInteractionKind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_NestedInteractionKind);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<ScrollView.NestedInteractionKind>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_NestedInteractionKind), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700119E RID: 4510
			// (get) Token: 0x0600396A RID: 14698 RVA: 0x000E94EC File Offset: 0x000E76EC
			// (set) Token: 0x0600396B RID: 14699 RVA: 0x00018219 File Offset: 0x00016419
			public unsafe UxmlBoolAttributeDescription m_ShowHorizontal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ShowHorizontal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ShowHorizontal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700119F RID: 4511
			// (get) Token: 0x0600396C RID: 14700 RVA: 0x000E951C File Offset: 0x000E771C
			// (set) Token: 0x0600396D RID: 14701 RVA: 0x00018238 File Offset: 0x00016438
			public unsafe UxmlBoolAttributeDescription m_ShowVertical
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ShowVertical);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ShowVertical), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A0 RID: 4512
			// (get) Token: 0x0600396E RID: 14702 RVA: 0x000E954C File Offset: 0x000E774C
			// (set) Token: 0x0600396F RID: 14703 RVA: 0x00018257 File Offset: 0x00016457
			public unsafe UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_HorizontalScrollerVisibility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<ScrollerVisibility>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_HorizontalScrollerVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A1 RID: 4513
			// (get) Token: 0x06003970 RID: 14704 RVA: 0x000E957C File Offset: 0x000E777C
			// (set) Token: 0x06003971 RID: 14705 RVA: 0x00018276 File Offset: 0x00016476
			public unsafe UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_VerticalScrollerVisibility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<ScrollerVisibility>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_VerticalScrollerVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A2 RID: 4514
			// (get) Token: 0x06003972 RID: 14706 RVA: 0x000E95AC File Offset: 0x000E77AC
			// (set) Token: 0x06003973 RID: 14707 RVA: 0x00018295 File Offset: 0x00016495
			public unsafe UxmlFloatAttributeDescription m_HorizontalPageSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_HorizontalPageSize);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_HorizontalPageSize), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A3 RID: 4515
			// (get) Token: 0x06003974 RID: 14708 RVA: 0x000E95DC File Offset: 0x000E77DC
			// (set) Token: 0x06003975 RID: 14709 RVA: 0x000182B4 File Offset: 0x000164B4
			public unsafe UxmlFloatAttributeDescription m_VerticalPageSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_VerticalPageSize);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_VerticalPageSize), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A4 RID: 4516
			// (get) Token: 0x06003976 RID: 14710 RVA: 0x000E960C File Offset: 0x000E780C
			// (set) Token: 0x06003977 RID: 14711 RVA: 0x000182D3 File Offset: 0x000164D3
			public unsafe UxmlFloatAttributeDescription m_MouseWheelScrollSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_MouseWheelScrollSize);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_MouseWheelScrollSize), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A5 RID: 4517
			// (get) Token: 0x06003978 RID: 14712 RVA: 0x000E963C File Offset: 0x000E783C
			// (set) Token: 0x06003979 RID: 14713 RVA: 0x000182F2 File Offset: 0x000164F2
			public unsafe UxmlEnumAttributeDescription<ScrollView.TouchScrollBehavior> m_TouchScrollBehavior
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_TouchScrollBehavior);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<ScrollView.TouchScrollBehavior>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_TouchScrollBehavior), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A6 RID: 4518
			// (get) Token: 0x0600397A RID: 14714 RVA: 0x000E966C File Offset: 0x000E786C
			// (set) Token: 0x0600397B RID: 14715 RVA: 0x00018311 File Offset: 0x00016511
			public unsafe UxmlFloatAttributeDescription m_ScrollDecelerationRate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ScrollDecelerationRate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ScrollDecelerationRate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A7 RID: 4519
			// (get) Token: 0x0600397C RID: 14716 RVA: 0x000E969C File Offset: 0x000E789C
			// (set) Token: 0x0600397D RID: 14717 RVA: 0x00018330 File Offset: 0x00016530
			public unsafe UxmlFloatAttributeDescription m_Elasticity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_Elasticity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_Elasticity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A8 RID: 4520
			// (get) Token: 0x0600397E RID: 14718 RVA: 0x000E96CC File Offset: 0x000E78CC
			// (set) Token: 0x0600397F RID: 14719 RVA: 0x0001834F File Offset: 0x0001654F
			public unsafe UxmlLongAttributeDescription m_ElasticAnimationIntervalMs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ElasticAnimationIntervalMs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlLongAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollView.UxmlTraits.NativeFieldInfoPtr_m_ElasticAnimationIntervalMs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002896 RID: 10390
			private static readonly IntPtr NativeFieldInfoPtr_m_ScrollViewMode;

			// Token: 0x04002897 RID: 10391
			private static readonly IntPtr NativeFieldInfoPtr_m_NestedInteractionKind;

			// Token: 0x04002898 RID: 10392
			private static readonly IntPtr NativeFieldInfoPtr_m_ShowHorizontal;

			// Token: 0x04002899 RID: 10393
			private static readonly IntPtr NativeFieldInfoPtr_m_ShowVertical;

			// Token: 0x0400289A RID: 10394
			private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollerVisibility;

			// Token: 0x0400289B RID: 10395
			private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollerVisibility;

			// Token: 0x0400289C RID: 10396
			private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalPageSize;

			// Token: 0x0400289D RID: 10397
			private static readonly IntPtr NativeFieldInfoPtr_m_VerticalPageSize;

			// Token: 0x0400289E RID: 10398
			private static readonly IntPtr NativeFieldInfoPtr_m_MouseWheelScrollSize;

			// Token: 0x0400289F RID: 10399
			private static readonly IntPtr NativeFieldInfoPtr_m_TouchScrollBehavior;

			// Token: 0x040028A0 RID: 10400
			private static readonly IntPtr NativeFieldInfoPtr_m_ScrollDecelerationRate;

			// Token: 0x040028A1 RID: 10401
			private static readonly IntPtr NativeFieldInfoPtr_m_Elasticity;

			// Token: 0x040028A2 RID: 10402
			private static readonly IntPtr NativeFieldInfoPtr_m_ElasticAnimationIntervalMs;

			// Token: 0x040028A3 RID: 10403
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040028A4 RID: 10404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003C0 RID: 960
		public enum TouchScrollBehavior
		{
			// Token: 0x040028A6 RID: 10406
			Unrestricted,
			// Token: 0x040028A7 RID: 10407
			Elastic,
			// Token: 0x040028A8 RID: 10408
			Clamped
		}

		// Token: 0x020003C1 RID: 961
		public enum NestedInteractionKind
		{
			// Token: 0x040028AA RID: 10410
			Default,
			// Token: 0x040028AB RID: 10411
			StopScrolling,
			// Token: 0x040028AC RID: 10412
			ForwardScrolling
		}

		// Token: 0x020003C2 RID: 962
		public enum TouchScrollingResult
		{
			// Token: 0x040028AE RID: 10414
			Apply,
			// Token: 0x040028AF RID: 10415
			Forward,
			// Token: 0x040028B0 RID: 10416
			Block
		}
	}
}
