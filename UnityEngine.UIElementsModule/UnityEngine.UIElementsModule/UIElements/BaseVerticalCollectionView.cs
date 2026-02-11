using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000047 RID: 71
	public class BaseVerticalCollectionView : BindableElement
	{
		// Token: 0x06000652 RID: 1618 RVA: 0x000349AC File Offset: 0x00032BAC
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVerticalCollectionView()
		{
			Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseVerticalCollectionView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr);
			BaseVerticalCollectionView.NativeFieldInfoPtr_k_RefreshMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "k_RefreshMarker");
			BaseVerticalCollectionView.NativeFieldInfoPtr_k_RebuildMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "k_RebuildMarker");
			BaseVerticalCollectionView.NativeFieldInfoPtr_itemsChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "itemsChosen");
			BaseVerticalCollectionView.NativeFieldInfoPtr_selectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "selectionChanged");
			BaseVerticalCollectionView.NativeFieldInfoPtr_selectedIndicesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "selectedIndicesChanged");
			BaseVerticalCollectionView.NativeFieldInfoPtr_itemIndexChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "itemIndexChanged");
			BaseVerticalCollectionView.NativeFieldInfoPtr_itemsSourceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "itemsSourceChanged");
			BaseVerticalCollectionView.NativeFieldInfoPtr_selectionNotChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "selectionNotChanged");
			BaseVerticalCollectionView.NativeFieldInfoPtr_canStartDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "canStartDrag");
			BaseVerticalCollectionView.NativeFieldInfoPtr_setupDragAndDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "setupDragAndDrop");
			BaseVerticalCollectionView.NativeFieldInfoPtr_dragAndDropUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "dragAndDropUpdate");
			BaseVerticalCollectionView.NativeFieldInfoPtr_handleDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "handleDrop");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_SelectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_SelectionType");
			BaseVerticalCollectionView.NativeFieldInfoPtr_k_EmptyItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "k_EmptyItems");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_HorizontalScrollingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_HorizontalScrollingEnabled");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_ShowAlternatingRowBackgrounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_ShowAlternatingRowBackgrounds");
			BaseVerticalCollectionView.NativeFieldInfoPtr_s_DefaultItemHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "s_DefaultItemHeight");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_FixedItemHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_FixedItemHeight");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_ItemHeightIsInline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_ItemHeightIsInline");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_VirtualizationMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_VirtualizationMethod");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_ScrollView");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_ViewController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_ViewController");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_VirtualizationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_VirtualizationController");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_NavigationManipulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_NavigationManipulator");
			BaseVerticalCollectionView.NativeFieldInfoPtr_serializedVirtualizationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "serializedVirtualizationData");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_SelectedIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_SelectedIds");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_Selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_Selection");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_LastHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_LastHeight");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_IsRangeSelectionDirectionUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_IsRangeSelectionDirectionUp");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_Dragger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_Dragger");
			BaseVerticalCollectionView.NativeFieldInfoPtr_s_ItemHeightProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "s_ItemHeightProperty");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_ItemIndexChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_ItemIndexChangedCallback");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_ItemsSourceChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_ItemsSourceChangedCallback");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_RebuildScheduled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_RebuildScheduled");
			BaseVerticalCollectionView.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "ussClassName");
			BaseVerticalCollectionView.NativeFieldInfoPtr_borderUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "borderUssClassName");
			BaseVerticalCollectionView.NativeFieldInfoPtr_itemUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "itemUssClassName");
			BaseVerticalCollectionView.NativeFieldInfoPtr_dragHoverBarUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "dragHoverBarUssClassName");
			BaseVerticalCollectionView.NativeFieldInfoPtr_dragHoverMarkerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "dragHoverMarkerUssClassName");
			BaseVerticalCollectionView.NativeFieldInfoPtr_itemDragHoverUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "itemDragHoverUssClassName");
			BaseVerticalCollectionView.NativeFieldInfoPtr_itemSelectedVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "itemSelectedVariantUssClassName");
			BaseVerticalCollectionView.NativeFieldInfoPtr_itemAlternativeBackgroundUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "itemAlternativeBackgroundUssClassName");
			BaseVerticalCollectionView.NativeFieldInfoPtr_listScrollViewUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "listScrollViewUssClassName");
			BaseVerticalCollectionView.NativeFieldInfoPtr_backgroundFillUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "backgroundFillUssClassName");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_TouchDownPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_TouchDownPosition");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_LastPointerDownTimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_LastPointerDownTimeStamp");
			BaseVerticalCollectionView.NativeFieldInfoPtr_m_PointerDownCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "m_PointerDownCount");
			BaseVerticalCollectionView.NativeMethodInfoPtr_HasCanStartDrag_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664160);
			BaseVerticalCollectionView.NativeMethodInfoPtr_RaiseCanStartDrag_Internal_Boolean_ReusableCollectionItem_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664161);
			BaseVerticalCollectionView.NativeMethodInfoPtr_RaiseSetupDragAndDrop_Internal_StartDragArgs_ReusableCollectionItem_IEnumerable_1_Int32_StartDragArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664162);
			BaseVerticalCollectionView.NativeMethodInfoPtr_RaiseHandleDragAndDrop_Internal_DragVisualMode_Vector2_DragAndDropArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664163);
			BaseVerticalCollectionView.NativeMethodInfoPtr_RaiseDrop_Internal_DragVisualMode_Vector2_DragAndDropArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664164);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_itemsSource_Public_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664165);
			BaseVerticalCollectionView.NativeMethodInfoPtr_set_itemsSource_Public_set_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664166);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664167);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_selectionType_Public_get_SelectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664168);
			BaseVerticalCollectionView.NativeMethodInfoPtr_set_selectionType_Public_set_Void_SelectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664169);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_selectedItems_Public_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664170);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_selectedIds_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664171);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_selectedIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664172);
			BaseVerticalCollectionView.NativeMethodInfoPtr_set_selectedIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664173);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_selectedIndices_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664174);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_activeItems_Internal_get_IEnumerable_1_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664175);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_scrollView_Internal_get_ScrollView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664176);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_dragger_Internal_get_ListViewDragger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664177);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_virtualizationController_Internal_get_CollectionVirtualizationController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664178);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_viewController_Public_get_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664179);
			BaseVerticalCollectionView.NativeMethodInfoPtr_ResolveItemHeight_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664180);
			BaseVerticalCollectionView.NativeMethodInfoPtr_set_showBorder_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664181);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_reorderable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664182);
			BaseVerticalCollectionView.NativeMethodInfoPtr_set_reorderable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664183);
			BaseVerticalCollectionView.NativeMethodInfoPtr_set_horizontalScrollingEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664184);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_showAlternatingRowBackgrounds_Public_get_AlternatingRowBackground_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664185);
			BaseVerticalCollectionView.NativeMethodInfoPtr_set_showAlternatingRowBackgrounds_Public_set_Void_AlternatingRowBackground_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664186);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_virtualizationMethod_Public_get_CollectionVirtualizationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664187);
			BaseVerticalCollectionView.NativeMethodInfoPtr_set_virtualizationMethod_Public_set_Void_CollectionVirtualizationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664188);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_fixedItemHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664189);
			BaseVerticalCollectionView.NativeMethodInfoPtr_set_fixedItemHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664190);
			BaseVerticalCollectionView.NativeMethodInfoPtr_get_lastHeight_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664191);
			BaseVerticalCollectionView.NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664192);
			BaseVerticalCollectionView.NativeMethodInfoPtr_GetOrCreateVirtualizationController_Internal_CollectionVirtualizationController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664193);
			BaseVerticalCollectionView.NativeMethodInfoPtr_CreateVirtualizationController_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664194);
			BaseVerticalCollectionView.NativeMethodInfoPtr_GetOrCreateViewController_Internal_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664195);
			BaseVerticalCollectionView.NativeMethodInfoPtr_CreateViewController_Protected_Abstract_Virtual_New_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664196);
			BaseVerticalCollectionView.NativeMethodInfoPtr_SetViewController_Public_Virtual_New_Void_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664197);
			BaseVerticalCollectionView.NativeMethodInfoPtr_CreateDragger_Internal_Virtual_New_ListViewDragger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664198);
			BaseVerticalCollectionView.NativeMethodInfoPtr_InitializeDragAndDropController_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664199);
			BaseVerticalCollectionView.NativeMethodInfoPtr_CreateDragAndDropController_Internal_Abstract_Virtual_New_ICollectionDragAndDropController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664200);
			BaseVerticalCollectionView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664201);
			BaseVerticalCollectionView.NativeMethodInfoPtr__ctor_Public_Void_IList_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664202);
			BaseVerticalCollectionView.NativeMethodInfoPtr_GetRootElementForId_Public_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664203);
			BaseVerticalCollectionView.NativeMethodInfoPtr_HasValidDataAndBindings_Internal_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664204);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnItemIndexChanged_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664205);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnItemsSourceChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664206);
			BaseVerticalCollectionView.NativeMethodInfoPtr_RefreshItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664207);
			BaseVerticalCollectionView.NativeMethodInfoPtr_Rebuild_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664208);
			BaseVerticalCollectionView.NativeMethodInfoPtr_ScheduleRebuild_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664209);
			BaseVerticalCollectionView.NativeMethodInfoPtr_RefreshSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664210);
			BaseVerticalCollectionView.NativeMethodInfoPtr_PostRefresh_FamAndAssem_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664211);
			BaseVerticalCollectionView.NativeMethodInfoPtr_ScrollToItem_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664212);
			BaseVerticalCollectionView.NativeMethodInfoPtr_ScrollToItemById_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664213);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnScroll_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664214);
			BaseVerticalCollectionView.NativeMethodInfoPtr_Resize_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664215);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664216);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664217);
			BaseVerticalCollectionView.NativeMethodInfoPtr_Apply_Private_Boolean_KeyboardNavigationOperation_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664218);
			BaseVerticalCollectionView.NativeMethodInfoPtr_Apply_Private_Void_KeyboardNavigationOperation_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664219);
			BaseVerticalCollectionView.NativeMethodInfoPtr_HandleItemNavigation_FamAndAssem_Virtual_New_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664220);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664221);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664222);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664223);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664224);
			BaseVerticalCollectionView.NativeMethodInfoPtr_ProcessPointerDown_Private_Void_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664225);
			BaseVerticalCollectionView.NativeMethodInfoPtr_ProcessPointerUp_Private_Void_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664226);
			BaseVerticalCollectionView.NativeMethodInfoPtr_DoSelect_Private_Void_Vector2_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664227);
			BaseVerticalCollectionView.NativeMethodInfoPtr_DoRangeSelection_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664228);
			BaseVerticalCollectionView.NativeMethodInfoPtr_ProcessSingleClick_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664229);
			BaseVerticalCollectionView.NativeMethodInfoPtr_SelectAll_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664230);
			BaseVerticalCollectionView.NativeMethodInfoPtr_AddToSelection_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664231);
			BaseVerticalCollectionView.NativeMethodInfoPtr_AddToSelection_Internal_Void_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664232);
			BaseVerticalCollectionView.NativeMethodInfoPtr_AddToSelectionWithoutValidation_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664233);
			BaseVerticalCollectionView.NativeMethodInfoPtr_RemoveFromSelection_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664234);
			BaseVerticalCollectionView.NativeMethodInfoPtr_RemoveFromSelectionWithoutValidation_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664235);
			BaseVerticalCollectionView.NativeMethodInfoPtr_SetSelection_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664236);
			BaseVerticalCollectionView.NativeMethodInfoPtr_SetSelection_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664237);
			BaseVerticalCollectionView.NativeMethodInfoPtr_SetSelectionWithoutNotify_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664238);
			BaseVerticalCollectionView.NativeMethodInfoPtr_SetSelectionInternal_Internal_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664239);
			BaseVerticalCollectionView.NativeMethodInfoPtr_MatchesExistingSelection_Private_Boolean_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664240);
			BaseVerticalCollectionView.NativeMethodInfoPtr_NotifyOfSelectionChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664241);
			BaseVerticalCollectionView.NativeMethodInfoPtr_ClearSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664242);
			BaseVerticalCollectionView.NativeMethodInfoPtr_ClearSelectionWithoutValidation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664243);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664244);
			BaseVerticalCollectionView.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664245);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnSizeChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664246);
			BaseVerticalCollectionView.NativeMethodInfoPtr_OnCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664247);
			BaseVerticalCollectionView.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664248);
			BaseVerticalCollectionView.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664249);
			BaseVerticalCollectionView.NativeMethodInfoPtr___ctor_b__159_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664251);
			BaseVerticalCollectionView.NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass172_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664252);
			BaseVerticalCollectionView.NativeMethodInfoPtr_Method_Private_Void_Int32_byref___c__DisplayClass183_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, 100664253);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000354CC File Offset: 0x000336CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290543, RefRangeEnd = 290544, XrefRangeStart = 290543, XrefRangeEnd = 290543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCanStartDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_HasCanStartDrag_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00035508 File Offset: 0x00033708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290547, RefRangeEnd = 290548, XrefRangeStart = 290544, XrefRangeEnd = 290547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_RaiseCanStartDrag_Internal_Boolean_ReusableCollectionItem_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00035568 File Offset: 0x00033768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290551, RefRangeEnd = 290552, XrefRangeStart = 290548, XrefRangeEnd = 290551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<int> ids, StartDragArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ids);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_RaiseSetupDragAndDrop_Internal_StartDragArgs_ReusableCollectionItem_IEnumerable_1_Int32_StartDragArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new StartDragArgs(intPtr);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000355DC File Offset: 0x000337DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290553, RefRangeEnd = 290555, XrefRangeStart = 290552, XrefRangeEnd = 290553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dragAndDropArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_RaiseHandleDragAndDrop_Internal_DragVisualMode_Vector2_DragAndDropArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0003563C File Offset: 0x0003383C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290556, RefRangeEnd = 290557, XrefRangeStart = 290555, XrefRangeEnd = 290556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dragAndDropArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_RaiseDrop_Internal_DragVisualMode_Vector2_DragAndDropArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0003569C File Offset: 0x0003389C
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x000356DC File Offset: 0x000338DC
		public unsafe IList itemsSource
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 290557, RefRangeEnd = 290574, XrefRangeStart = 290557, XrefRangeEnd = 290557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_itemsSource_Public_get_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290574, XrefRangeEnd = 290575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_set_itemsSource_Public_set_Void_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00035720 File Offset: 0x00033920
		public unsafe override VisualElement contentContainer
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0003576C File Offset: 0x0003396C
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x000357A8 File Offset: 0x000339A8
		public unsafe SelectionType selectionType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 290575, RefRangeEnd = 290576, XrefRangeStart = 290575, XrefRangeEnd = 290575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_selectionType_Public_get_SelectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 290579, RefRangeEnd = 290580, XrefRangeStart = 290576, XrefRangeEnd = 290579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_set_selectionType_Public_set_Void_SelectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x000357E8 File Offset: 0x000339E8
		public unsafe IEnumerable<Object> selectedItems
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 290586, RefRangeEnd = 290589, XrefRangeStart = 290580, XrefRangeEnd = 290586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_selectedItems_Public_get_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00035828 File Offset: 0x00033A28
		public unsafe IEnumerable<int> selectedIds
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 290589, RefRangeEnd = 290594, XrefRangeStart = 290589, XrefRangeEnd = 290589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_selectedIds_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00035868 File Offset: 0x00033A68
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x000358A4 File Offset: 0x00033AA4
		public unsafe int selectedIndex
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 290599, RefRangeEnd = 290606, XrefRangeStart = 290594, XrefRangeEnd = 290599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_selectedIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290606, XrefRangeEnd = 290607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_set_selectedIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x000358E4 File Offset: 0x00033AE4
		public unsafe IEnumerable<int> selectedIndices
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 290607, RefRangeEnd = 290612, XrefRangeStart = 290607, XrefRangeEnd = 290607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_selectedIndices_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00035924 File Offset: 0x00033B24
		public unsafe IEnumerable<ReusableCollectionItem> activeItems
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 290616, RefRangeEnd = 290628, XrefRangeStart = 290612, XrefRangeEnd = 290616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_activeItems_Internal_get_IEnumerable_1_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ReusableCollectionItem>>(intPtr3) : null;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00035964 File Offset: 0x00033B64
		public unsafe ScrollView scrollView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_scrollView_Internal_get_ScrollView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScrollView>(intPtr3) : null;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x000359A4 File Offset: 0x00033BA4
		public unsafe ListViewDragger dragger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_dragger_Internal_get_ListViewDragger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ListViewDragger>(intPtr3) : null;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x000359E4 File Offset: 0x00033BE4
		public unsafe CollectionVirtualizationController virtualizationController
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 290628, RefRangeEnd = 290635, XrefRangeStart = 290628, XrefRangeEnd = 290628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_virtualizationController_Internal_get_CollectionVirtualizationController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollectionVirtualizationController>(intPtr3) : null;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00035A24 File Offset: 0x00033C24
		public unsafe CollectionViewController viewController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_viewController_Public_get_CollectionViewController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollectionViewController>(intPtr3) : null;
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00035A64 File Offset: 0x00033C64
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 290635, RefRangeEnd = 290649, XrefRangeStart = 290635, XrefRangeEnd = 290635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ResolveItemHeight(float height = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_ResolveItemHeight_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00004756 File Offset: 0x00002956
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00035AB0 File Offset: 0x00033CB0
		public unsafe bool showBorder
		{
			get
			{
				return this.m_ScrollView.ClassListContains(BaseVerticalCollectionView.borderUssClassName);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290649, XrefRangeEnd = 290655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_set_showBorder_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00035AF0 File Offset: 0x00033CF0
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00035B2C File Offset: 0x00033D2C
		public unsafe bool reorderable
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 290662, RefRangeEnd = 290666, XrefRangeStart = 290655, XrefRangeEnd = 290662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_reorderable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290666, XrefRangeEnd = 290672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_set_reorderable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00004768 File Offset: 0x00002968
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00035B6C File Offset: 0x00033D6C
		public unsafe bool horizontalScrollingEnabled
		{
			get
			{
				return this.m_HorizontalScrollingEnabled;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290672, XrefRangeEnd = 290674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_set_horizontalScrollingEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00035BAC File Offset: 0x00033DAC
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00035BE8 File Offset: 0x00033DE8
		public unsafe AlternatingRowBackground showAlternatingRowBackgrounds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 290674, RefRangeEnd = 290676, XrefRangeStart = 290674, XrefRangeEnd = 290674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_showAlternatingRowBackgrounds_Public_get_AlternatingRowBackground_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290676, XrefRangeEnd = 290677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_set_showAlternatingRowBackgrounds_Public_set_Void_AlternatingRowBackground_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00035C28 File Offset: 0x00033E28
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00035C64 File Offset: 0x00033E64
		public unsafe CollectionVirtualizationMethod virtualizationMethod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_virtualizationMethod_Public_get_CollectionVirtualizationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290677, XrefRangeEnd = 290678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_set_virtualizationMethod_Public_set_Void_CollectionVirtualizationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00035CA4 File Offset: 0x00033EA4
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00035CE0 File Offset: 0x00033EE0
		public unsafe float fixedItemHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_fixedItemHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290678, XrefRangeEnd = 290682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_set_fixedItemHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00035D20 File Offset: 0x00033F20
		public unsafe float lastHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_get_lastHeight_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00035D5C File Offset: 0x00033F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290682, XrefRangeEnd = 290685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateVirtualizationController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00035D98 File Offset: 0x00033F98
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 290628, RefRangeEnd = 290635, XrefRangeStart = 290628, XrefRangeEnd = 290635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionVirtualizationController GetOrCreateVirtualizationController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_GetOrCreateVirtualizationController_Internal_CollectionVirtualizationController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollectionVirtualizationController>(intPtr3) : null;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00035DD8 File Offset: 0x00033FD8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 290690, RefRangeEnd = 290695, XrefRangeStart = 290685, XrefRangeEnd = 290690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateVirtualizationController<T>() where T : ReusableCollectionItem, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.MethodInfoStoreGeneric_CreateVirtualizationController_Internal_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00035E0C File Offset: 0x0003400C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 290695, RefRangeEnd = 290701, XrefRangeStart = 290695, XrefRangeEnd = 290695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionViewController GetOrCreateViewController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_GetOrCreateViewController_Internal_CollectionViewController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollectionViewController>(intPtr3) : null;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00035E4C File Offset: 0x0003404C
		[CallerCount(0)]
		public unsafe virtual CollectionViewController CreateViewController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_CreateViewController_Protected_Abstract_Virtual_New_CollectionViewController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollectionViewController>(intPtr3) : null;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00035E98 File Offset: 0x00034098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290708, RefRangeEnd = 290709, XrefRangeStart = 290701, XrefRangeEnd = 290708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetViewController(CollectionViewController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_SetViewController_Public_Virtual_New_Void_CollectionViewController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00035EE8 File Offset: 0x000340E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290709, XrefRangeEnd = 290713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ListViewDragger CreateDragger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_CreateDragger_Internal_Virtual_New_ListViewDragger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ListViewDragger>(intPtr3) : null;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00035F34 File Offset: 0x00034134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290721, RefRangeEnd = 290722, XrefRangeStart = 290713, XrefRangeEnd = 290721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDragAndDropController(bool enableReordering)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enableReordering;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_InitializeDragAndDropController_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00035F74 File Offset: 0x00034174
		[CallerCount(0)]
		public unsafe virtual ICollectionDragAndDropController CreateDragAndDropController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_CreateDragAndDropController_Internal_Abstract_Virtual_New_ICollectionDragAndDropController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollectionDragAndDropController>(intPtr3) : null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00035FC0 File Offset: 0x000341C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290858, RefRangeEnd = 290862, XrefRangeStart = 290722, XrefRangeEnd = 290858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVerticalCollectionView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00035FFC File Offset: 0x000341FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290862, XrefRangeEnd = 290866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1f)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemsSource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr__ctor_Public_Void_IList_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00036058 File Offset: 0x00034258
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290880, RefRangeEnd = 290883, XrefRangeStart = 290866, XrefRangeEnd = 290880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement GetRootElementForId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_GetRootElementForId_Public_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000360A4 File Offset: 0x000342A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290883, RefRangeEnd = 290885, XrefRangeStart = 290883, XrefRangeEnd = 290883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasValidDataAndBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_HasValidDataAndBindings_Internal_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000360EC File Offset: 0x000342EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290885, XrefRangeEnd = 290886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnItemIndexChanged(int srcIndex, int dstIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref srcIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnItemIndexChanged_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00036138 File Offset: 0x00034338
		[CallerCount(0)]
		public unsafe void OnItemsSourceChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnItemsSourceChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0003616C File Offset: 0x0003436C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 290908, RefRangeEnd = 290931, XrefRangeStart = 290886, XrefRangeEnd = 290908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_RefreshItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000361A0 File Offset: 0x000343A0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 290949, RefRangeEnd = 290962, XrefRangeStart = 290931, XrefRangeEnd = 290949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rebuild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_Rebuild_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000361D4 File Offset: 0x000343D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290970, RefRangeEnd = 290972, XrefRangeStart = 290962, XrefRangeEnd = 290970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleRebuild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_ScheduleRebuild_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00036208 File Offset: 0x00034408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291028, RefRangeEnd = 291030, XrefRangeStart = 290972, XrefRangeEnd = 291028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_RefreshSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0003623C File Offset: 0x0003443C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291034, RefRangeEnd = 291035, XrefRangeStart = 291030, XrefRangeEnd = 291034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_PostRefresh_FamAndAssem_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00036278 File Offset: 0x00034478
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 291035, RefRangeEnd = 291040, XrefRangeStart = 291035, XrefRangeEnd = 291035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScrollToItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_ScrollToItem_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000362B8 File Offset: 0x000344B8
		[CallerCount(0)]
		public unsafe void ScrollToItemById(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_ScrollToItemById_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000362F8 File Offset: 0x000344F8
		[CallerCount(0)]
		public unsafe void OnScroll(Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnScroll_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00036338 File Offset: 0x00034538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291041, RefRangeEnd = 291043, XrefRangeStart = 291040, XrefRangeEnd = 291041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(Vector2 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_Resize_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00036378 File Offset: 0x00034578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291043, XrefRangeEnd = 291092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAttachToPanel(AttachToPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000363BC File Offset: 0x000345BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291092, XrefRangeEnd = 291130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00036400 File Offset: 0x00034600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291172, RefRangeEnd = 291173, XrefRangeStart = 291130, XrefRangeEnd = 291172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shiftKey;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref altKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_Apply_Private_Boolean_KeyboardNavigationOperation_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00036468 File Offset: 0x00034668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291173, XrefRangeEnd = 291198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_Apply_Private_Void_KeyboardNavigationOperation_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000364B8 File Offset: 0x000346B8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 291198, RefRangeEnd = 291216, XrefRangeStart = 291198, XrefRangeEnd = 291198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HandleItemNavigation(bool moveIn, bool altKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveIn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref altKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_HandleItemNavigation_FamAndAssem_Virtual_New_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0003651C File Offset: 0x0003471C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291216, XrefRangeEnd = 291219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMove(PointerMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00036560 File Offset: 0x00034760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291219, XrefRangeEnd = 291227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDown(PointerDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000365A4 File Offset: 0x000347A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291227, XrefRangeEnd = 291229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerCancel(PointerCancelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000365E8 File Offset: 0x000347E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291229, XrefRangeEnd = 291237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUp(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0003662C File Offset: 0x0003482C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291259, RefRangeEnd = 291261, XrefRangeStart = 291237, XrefRangeEnd = 291259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPointerDown(IPointerEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_ProcessPointerDown_Private_Void_IPointerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00036670 File Offset: 0x00034870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291284, RefRangeEnd = 291285, XrefRangeStart = 291261, XrefRangeEnd = 291284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPointerUp(IPointerEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_ProcessPointerUp_Private_Void_IPointerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000366B4 File Offset: 0x000348B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291300, RefRangeEnd = 291301, XrefRangeStart = 291285, XrefRangeEnd = 291300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clickCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionKey;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shiftKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_DoSelect_Private_Void_Vector2_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0003671C File Offset: 0x0003491C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291322, RefRangeEnd = 291323, XrefRangeStart = 291301, XrefRangeEnd = 291322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoRangeSelection(int rangeSelectionFinalIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rangeSelectionFinalIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_DoRangeSelection_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0003675C File Offset: 0x0003495C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSingleClick(int clickedIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clickedIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_ProcessSingleClick_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0003679C File Offset: 0x0003499C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291349, RefRangeEnd = 291350, XrefRangeStart = 291323, XrefRangeEnd = 291349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_SelectAll_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000367D0 File Offset: 0x000349D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291350, XrefRangeEnd = 291356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToSelection(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_AddToSelection_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00036810 File Offset: 0x00034A10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291380, RefRangeEnd = 291382, XrefRangeStart = 291356, XrefRangeEnd = 291380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToSelection(IList<int> indexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indexes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_AddToSelection_Internal_Void_IList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00036854 File Offset: 0x00034A54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291405, RefRangeEnd = 291407, XrefRangeStart = 291382, XrefRangeEnd = 291405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToSelectionWithoutValidation(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_AddToSelectionWithoutValidation_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00036894 File Offset: 0x00034A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291407, XrefRangeEnd = 291410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromSelection(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_RemoveFromSelection_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000368D4 File Offset: 0x00034AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291446, RefRangeEnd = 291447, XrefRangeStart = 291410, XrefRangeEnd = 291446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromSelectionWithoutValidation(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_RemoveFromSelectionWithoutValidation_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00036914 File Offset: 0x00034B14
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 291452, RefRangeEnd = 291462, XrefRangeStart = 291447, XrefRangeEnd = 291452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelection(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_SetSelection_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00036954 File Offset: 0x00034B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291462, XrefRangeEnd = 291463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelection(IEnumerable<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_SetSelection_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00036998 File Offset: 0x00034B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291463, XrefRangeEnd = 291464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectionWithoutNotify(IEnumerable<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_SetSelectionWithoutNotify_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000369DC File Offset: 0x00034BDC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 291506, RefRangeEnd = 291512, XrefRangeStart = 291464, XrefRangeEnd = 291506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendNotification;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_SetSelectionInternal_Internal_Void_IEnumerable_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00036A2C File Offset: 0x00034C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291545, RefRangeEnd = 291546, XrefRangeStart = 291512, XrefRangeEnd = 291545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesExistingSelection(IEnumerable<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_MatchesExistingSelection_Private_Boolean_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00036A7C File Offset: 0x00034C7C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 291547, RefRangeEnd = 291553, XrefRangeStart = 291546, XrefRangeEnd = 291547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyOfSelectionChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_NotifyOfSelectionChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00036AB0 File Offset: 0x00034CB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 291556, RefRangeEnd = 291562, XrefRangeStart = 291553, XrefRangeEnd = 291556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_ClearSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00036AE4 File Offset: 0x00034CE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 291591, RefRangeEnd = 291594, XrefRangeStart = 291562, XrefRangeEnd = 291591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelectionWithoutValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_ClearSelectionWithoutValidation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00036B18 File Offset: 0x00034D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291594, XrefRangeEnd = 291599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewDataReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00036B54 File Offset: 0x00034D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291599, XrefRangeEnd = 291629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultAction(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00036BA4 File Offset: 0x00034DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291629, XrefRangeEnd = 291632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSizeChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnSizeChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00036BE8 File Offset: 0x00034DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291632, XrefRangeEnd = 291644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_OnCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00036C2C File Offset: 0x00034E2C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00036C60 File Offset: 0x00034E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291644, XrefRangeEnd = 291743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00036C94 File Offset: 0x00034E94
		[CallerCount(0)]
		public unsafe void __ctor_b__159_0(float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr___ctor_b__159_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00036CD4 File Offset: 0x00034ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291743, XrefRangeEnd = 291745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_byref___c__DisplayClass172_0_PDM_0(ref BaseVerticalCollectionView.__c__DisplayClass172_0 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass172_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00036D18 File Offset: 0x00034F18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291753, RefRangeEnd = 291755, XrefRangeStart = 291745, XrefRangeEnd = 291753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Int32_byref___c__DisplayClass183_0_0(int index, ref BaseVerticalCollectionView.__c__DisplayClass183_0 A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.NativeMethodInfoPtr_Method_Private_Void_Int32_byref___c__DisplayClass183_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000040D8 File Offset: 0x000022D8
		public BaseVerticalCollectionView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00036D6C File Offset: 0x00034F6C
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x000040E1 File Offset: 0x000022E1
		public unsafe static ProfilerMarker k_RefreshMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_k_RefreshMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_k_RefreshMarker, (void*)(&value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00036D88 File Offset: 0x00034F88
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x000040EF File Offset: 0x000022EF
		public unsafe static ProfilerMarker k_RebuildMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_k_RebuildMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_k_RebuildMarker, (void*)(&value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00036DA4 File Offset: 0x00034FA4
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x000040FD File Offset: 0x000022FD
		public unsafe Action<IEnumerable<Object>> itemsChosen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_itemsChosen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_itemsChosen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00036DD4 File Offset: 0x00034FD4
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x0000411C File Offset: 0x0000231C
		public unsafe Action<IEnumerable<Object>> selectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_selectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_selectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00036E04 File Offset: 0x00035004
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x0000413B File Offset: 0x0000233B
		public unsafe Action<IEnumerable<int>> selectedIndicesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_selectedIndicesChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_selectedIndicesChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00036E34 File Offset: 0x00035034
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x0000415A File Offset: 0x0000235A
		public unsafe Action<int, int> itemIndexChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_itemIndexChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_itemIndexChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00036E64 File Offset: 0x00035064
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00004179 File Offset: 0x00002379
		public unsafe Action itemsSourceChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_itemsSourceChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_itemsSourceChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00036E94 File Offset: 0x00035094
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00004198 File Offset: 0x00002398
		public unsafe Action selectionNotChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_selectionNotChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_selectionNotChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00036EC4 File Offset: 0x000350C4
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x000041B7 File Offset: 0x000023B7
		public unsafe Func<CanStartDragArgs, bool> canStartDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_canStartDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CanStartDragArgs, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_canStartDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00036EF4 File Offset: 0x000350F4
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x000041D6 File Offset: 0x000023D6
		public unsafe Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_setupDragAndDrop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SetupDragAndDropArgs, StartDragArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_setupDragAndDrop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00036F24 File Offset: 0x00035124
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x000041F5 File Offset: 0x000023F5
		public unsafe Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_dragAndDropUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HandleDragAndDropArgs, DragVisualMode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_dragAndDropUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00036F54 File Offset: 0x00035154
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00004214 File Offset: 0x00002414
		public unsafe Func<HandleDragAndDropArgs, DragVisualMode> handleDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_handleDrop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HandleDragAndDropArgs, DragVisualMode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_handleDrop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00036F84 File Offset: 0x00035184
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00004233 File Offset: 0x00002433
		public unsafe SelectionType m_SelectionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_SelectionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_SelectionType)) = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00036FAC File Offset: 0x000351AC
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x0000424E File Offset: 0x0000244E
		public unsafe static List<ReusableCollectionItem> k_EmptyItems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_k_EmptyItems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ReusableCollectionItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_k_EmptyItems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00036FD4 File Offset: 0x000351D4
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00004260 File Offset: 0x00002460
		public unsafe bool m_HorizontalScrollingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_HorizontalScrollingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_HorizontalScrollingEnabled)) = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00036FFC File Offset: 0x000351FC
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0000427B File Offset: 0x0000247B
		public unsafe AlternatingRowBackground m_ShowAlternatingRowBackgrounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ShowAlternatingRowBackgrounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ShowAlternatingRowBackgrounds)) = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00037024 File Offset: 0x00035224
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00004296 File Offset: 0x00002496
		public unsafe static int s_DefaultItemHeight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_s_DefaultItemHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_s_DefaultItemHeight, (void*)(&value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00037040 File Offset: 0x00035240
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x000042A4 File Offset: 0x000024A4
		public unsafe float m_FixedItemHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_FixedItemHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_FixedItemHeight)) = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00037068 File Offset: 0x00035268
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x000042BF File Offset: 0x000024BF
		public unsafe bool m_ItemHeightIsInline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ItemHeightIsInline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ItemHeightIsInline)) = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00037090 File Offset: 0x00035290
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x000042DA File Offset: 0x000024DA
		public unsafe CollectionVirtualizationMethod m_VirtualizationMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_VirtualizationMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_VirtualizationMethod)) = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x000370B8 File Offset: 0x000352B8
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x000042F5 File Offset: 0x000024F5
		public unsafe ScrollView m_ScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x000370E8 File Offset: 0x000352E8
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00004314 File Offset: 0x00002514
		public unsafe CollectionViewController m_ViewController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ViewController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionViewController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ViewController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00037118 File Offset: 0x00035318
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00004333 File Offset: 0x00002533
		public unsafe CollectionVirtualizationController m_VirtualizationController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_VirtualizationController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionVirtualizationController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_VirtualizationController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00037148 File Offset: 0x00035348
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00004352 File Offset: 0x00002552
		public unsafe KeyboardNavigationManipulator m_NavigationManipulator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_NavigationManipulator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyboardNavigationManipulator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_NavigationManipulator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00037178 File Offset: 0x00035378
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00004371 File Offset: 0x00002571
		public unsafe SerializedVirtualizationData serializedVirtualizationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_serializedVirtualizationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedVirtualizationData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_serializedVirtualizationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000371A8 File Offset: 0x000353A8
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00004390 File Offset: 0x00002590
		public unsafe List<int> m_SelectedIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_SelectedIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_SelectedIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x000371D8 File Offset: 0x000353D8
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x000043AF File Offset: 0x000025AF
		public unsafe BaseVerticalCollectionView.Selection m_Selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_Selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVerticalCollectionView.Selection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_Selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00037208 File Offset: 0x00035408
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x000043CE File Offset: 0x000025CE
		public unsafe float m_LastHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_LastHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_LastHeight)) = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00037230 File Offset: 0x00035430
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x000043E9 File Offset: 0x000025E9
		public unsafe bool m_IsRangeSelectionDirectionUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_IsRangeSelectionDirectionUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_IsRangeSelectionDirectionUp)) = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00037258 File Offset: 0x00035458
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00004404 File Offset: 0x00002604
		public unsafe ListViewDragger m_Dragger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_Dragger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListViewDragger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_Dragger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00037288 File Offset: 0x00035488
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00004423 File Offset: 0x00002623
		public unsafe static CustomStyleProperty<int> s_ItemHeightProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<int>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_s_ItemHeightProperty, intPtr);
				return new CustomStyleProperty<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_s_ItemHeightProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000372C4 File Offset: 0x000354C4
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x0000443A File Offset: 0x0000263A
		public unsafe Action<int, int> m_ItemIndexChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ItemIndexChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ItemIndexChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x000372F4 File Offset: 0x000354F4
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00004459 File Offset: 0x00002659
		public unsafe Action m_ItemsSourceChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ItemsSourceChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_ItemsSourceChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00037324 File Offset: 0x00035524
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00004478 File Offset: 0x00002678
		public unsafe IVisualElementScheduledItem m_RebuildScheduled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_RebuildScheduled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_RebuildScheduled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00037354 File Offset: 0x00035554
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00004497 File Offset: 0x00002697
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00037374 File Offset: 0x00035574
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x000044A9 File Offset: 0x000026A9
		public unsafe static string borderUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_borderUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_borderUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00037394 File Offset: 0x00035594
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x000044BB File Offset: 0x000026BB
		public unsafe static string itemUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_itemUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_itemUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x000373B4 File Offset: 0x000355B4
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x000044CD File Offset: 0x000026CD
		public unsafe static string dragHoverBarUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_dragHoverBarUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_dragHoverBarUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x000373D4 File Offset: 0x000355D4
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x000044DF File Offset: 0x000026DF
		public unsafe static string dragHoverMarkerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_dragHoverMarkerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_dragHoverMarkerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x000373F4 File Offset: 0x000355F4
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x000044F1 File Offset: 0x000026F1
		public unsafe static string itemDragHoverUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_itemDragHoverUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_itemDragHoverUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00037414 File Offset: 0x00035614
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00004503 File Offset: 0x00002703
		public unsafe static string itemSelectedVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_itemSelectedVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_itemSelectedVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00037434 File Offset: 0x00035634
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00004515 File Offset: 0x00002715
		public unsafe static string itemAlternativeBackgroundUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_itemAlternativeBackgroundUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_itemAlternativeBackgroundUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00037454 File Offset: 0x00035654
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00004527 File Offset: 0x00002727
		public unsafe static string listScrollViewUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_listScrollViewUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_listScrollViewUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00037474 File Offset: 0x00035674
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00004539 File Offset: 0x00002739
		public unsafe static string backgroundFillUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseVerticalCollectionView.NativeFieldInfoPtr_backgroundFillUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseVerticalCollectionView.NativeFieldInfoPtr_backgroundFillUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00037494 File Offset: 0x00035694
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x0000454B File Offset: 0x0000274B
		public unsafe Vector3 m_TouchDownPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_TouchDownPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_TouchDownPosition)) = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x000374BC File Offset: 0x000356BC
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00004566 File Offset: 0x00002766
		public unsafe long m_LastPointerDownTimeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_LastPointerDownTimeStamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_LastPointerDownTimeStamp)) = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x000374E4 File Offset: 0x000356E4
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00004581 File Offset: 0x00002781
		public unsafe int m_PointerDownCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_PointerDownCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.NativeFieldInfoPtr_m_PointerDownCount)) = value;
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0000459C File Offset: 0x0000279C
		public void add_onItemsChosen(Action<IEnumerable<Object>> value)
		{
			this.add_itemsChosen(value);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000045A6 File Offset: 0x000027A6
		public void remove_onItemsChosen(Action<IEnumerable<Object>> value)
		{
			this.remove_itemsChosen(value);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000045B0 File Offset: 0x000027B0
		public void add_itemsChosen(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000045BD File Offset: 0x000027BD
		public void remove_itemsChosen(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000045CA File Offset: 0x000027CA
		public void add_onSelectionChange(Action<IEnumerable<Object>> value)
		{
			this.add_selectionChanged(value);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000045D4 File Offset: 0x000027D4
		public void remove_onSelectionChange(Action<IEnumerable<Object>> value)
		{
			this.remove_selectionChanged(value);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000045DE File Offset: 0x000027DE
		public void add_selectionChanged(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000045EB File Offset: 0x000027EB
		public void remove_selectionChanged(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000045F8 File Offset: 0x000027F8
		public void add_onSelectedIndicesChange(Action<IEnumerable<int>> value)
		{
			this.add_selectedIndicesChanged(value);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00004602 File Offset: 0x00002802
		public void remove_onSelectedIndicesChange(Action<IEnumerable<int>> value)
		{
			this.remove_selectedIndicesChanged(value);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0000460C File Offset: 0x0000280C
		public void add_selectedIndicesChanged(Action<IEnumerable<int>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00004619 File Offset: 0x00002819
		public void remove_selectedIndicesChanged(Action<IEnumerable<int>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00004626 File Offset: 0x00002826
		public void add_itemIndexChanged(Action<int, int> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00004633 File Offset: 0x00002833
		public void remove_itemIndexChanged(Action<int, int> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00004640 File Offset: 0x00002840
		public void add_itemsSourceChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0000464D File Offset: 0x0000284D
		public void remove_itemsSourceChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0000465A File Offset: 0x0000285A
		public void add_selectionNotChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00004667 File Offset: 0x00002867
		public void remove_selectionNotChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00004674 File Offset: 0x00002874
		public void add_canStartDrag(Func<CanStartDragArgs, bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00004681 File Offset: 0x00002881
		public void remove_canStartDrag(Func<CanStartDragArgs, bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0000468E File Offset: 0x0000288E
		public void add_setupDragAndDrop(Func<SetupDragAndDropArgs, StartDragArgs> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0000469B File Offset: 0x0000289B
		public void remove_setupDragAndDrop(Func<SetupDragAndDropArgs, StartDragArgs> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000046A8 File Offset: 0x000028A8
		public void add_dragAndDropUpdate(Func<HandleDragAndDropArgs, DragVisualMode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000046B5 File Offset: 0x000028B5
		public void remove_dragAndDropUpdate(Func<HandleDragAndDropArgs, DragVisualMode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000046C2 File Offset: 0x000028C2
		public void add_handleDrop(Func<HandleDragAndDropArgs, DragVisualMode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000046CF File Offset: 0x000028CF
		public void remove_handleDrop(Func<HandleDragAndDropArgs, DragVisualMode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x000046DC File Offset: 0x000028DC
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x000046E8 File Offset: 0x000028E8
		public Func<VisualElement> makeItem
		{
			get
			{
				throw new UnityException("makeItem has been moved to ListView and TreeView. Use these ones instead.");
			}
			set
			{
				throw new UnityException("makeItem has been moved to ListView and TreeView. Use these ones instead.");
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x000046F4 File Offset: 0x000028F4
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00004700 File Offset: 0x00002900
		public Action<VisualElement, int> bindItem
		{
			get
			{
				throw new UnityException("bindItem has been moved to ListView and TreeView. Use these ones instead.");
			}
			set
			{
				throw new UnityException("bindItem has been moved to ListView and TreeView. Use these ones instead.");
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x0000470C File Offset: 0x0000290C
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00004718 File Offset: 0x00002918
		public Action<VisualElement, int> unbindItem
		{
			get
			{
				throw new UnityException("unbindItem has been moved to ListView and TreeView. Use these ones instead.");
			}
			set
			{
				throw new UnityException("unbindItem has been moved to ListView and TreeView. Use these ones instead.");
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00004724 File Offset: 0x00002924
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00004730 File Offset: 0x00002930
		public Action<VisualElement> destroyItem
		{
			get
			{
				throw new UnityException("destroyItem has been moved to ListView and TreeView. Use these ones instead.");
			}
			set
			{
				throw new UnityException("destroyItem has been moved to ListView and TreeView. Use these ones instead.");
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x0000473C File Offset: 0x0000293C
		public Object selectedItem
		{
			get
			{
				return this.m_Selection.FirstObject();
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00004749 File Offset: 0x00002949
		public float resolvedItemHeight
		{
			get
			{
				return this.ResolveItemHeight(-1f);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00004770 File Offset: 0x00002970
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00004779 File Offset: 0x00002979
		public int itemHeight
		{
			get
			{
				return (int)this.fixedItemHeight;
			}
			set
			{
				this.fixedItemHeight = (float)value;
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00004784 File Offset: 0x00002984
		public void SetDragAndDropController(ICollectionDragAndDropController dragAndDropController)
		{
			if (this.m_Dragger == null)
			{
				this.m_Dragger = this.CreateDragger();
			}
			this.m_Dragger.dragAndDropController = dragAndDropController;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0003750C File Offset: 0x0003570C
		public VisualElement GetRootElementForIndex(int index)
		{
			return this.GetRootElementForId(this.viewController.GetIdForIndex(index));
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00037530 File Offset: 0x00035730
		public void RefreshItem(int index)
		{
			foreach (ReusableCollectionItem reusableCollectionItem in this.activeItems)
			{
				int index2 = reusableCollectionItem.index;
				bool flag = index2 == index;
				if (flag)
				{
					this.viewController.InvokeUnbindItem(reusableCollectionItem, index2);
					this.viewController.InvokeBindItem(reusableCollectionItem, index2);
					break;
				}
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000047A8 File Offset: 0x000029A8
		public void Refresh()
		{
			this.Rebuild();
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000047B2 File Offset: 0x000029B2
		public void ScrollTo(VisualElement visualElement)
		{
			this.m_ScrollView.ScrollTo(visualElement);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000047C2 File Offset: 0x000029C2
		public void ScrollToId(int id)
		{
			this.ScrollToItemById(id);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000047CD File Offset: 0x000029CD
		public void OnKeyDown(KeyDownEvent evt)
		{
			this.m_NavigationManipulator.OnKeyDown(evt);
		}

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeFieldInfoPtr_k_RefreshMarker;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeFieldInfoPtr_k_RebuildMarker;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr_itemsChosen;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr_selectionChanged;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeFieldInfoPtr_selectedIndicesChanged;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr_itemIndexChanged;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr_itemsSourceChanged;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr_selectionNotChanged;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeFieldInfoPtr_canStartDrag;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeFieldInfoPtr_setupDragAndDrop;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr_dragAndDropUpdate;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeFieldInfoPtr_handleDrop;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionType;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr_k_EmptyItems;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollingEnabled;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_m_ShowAlternatingRowBackgrounds;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultItemHeight;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_m_FixedItemHeight;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemHeightIsInline;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr_m_VirtualizationMethod;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollView;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewController;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_m_VirtualizationController;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_m_NavigationManipulator;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_serializedVirtualizationData;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedIds;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_m_Selection;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_m_LastHeight;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_m_IsRangeSelectionDirectionUp;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_m_Dragger;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr_s_ItemHeightProperty;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemIndexChangedCallback;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemsSourceChangedCallback;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeFieldInfoPtr_m_RebuildScheduled;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_borderUssClassName;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_itemUssClassName;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_dragHoverBarUssClassName;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr_dragHoverMarkerUssClassName;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeFieldInfoPtr_itemDragHoverUssClassName;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeFieldInfoPtr_itemSelectedVariantUssClassName;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeFieldInfoPtr_itemAlternativeBackgroundUssClassName;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_listScrollViewUssClassName;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_backgroundFillUssClassName;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchDownPosition;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_m_LastPointerDownTimeStamp;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerDownCount;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_HasCanStartDrag_Internal_Boolean_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_RaiseCanStartDrag_Internal_Boolean_ReusableCollectionItem_IEnumerable_1_Int32_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_RaiseSetupDragAndDrop_Internal_StartDragArgs_ReusableCollectionItem_IEnumerable_1_Int32_StartDragArgs_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_RaiseHandleDragAndDrop_Internal_DragVisualMode_Vector2_DragAndDropArgs_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_RaiseDrop_Internal_DragVisualMode_Vector2_DragAndDropArgs_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_get_itemsSource_Public_get_IList_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_set_itemsSource_Public_set_Void_IList_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionType_Public_get_SelectionType_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionType_Public_set_Void_SelectionType_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedItems_Public_get_IEnumerable_1_Object_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedIds_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedIndex_Public_get_Int32_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedIndex_Public_set_Void_Int32_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedIndices_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_get_activeItems_Internal_get_IEnumerable_1_ReusableCollectionItem_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollView_Internal_get_ScrollView_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_get_dragger_Internal_get_ListViewDragger_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_get_virtualizationController_Internal_get_CollectionVirtualizationController_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_get_viewController_Public_get_CollectionViewController_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_ResolveItemHeight_Internal_Single_Single_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_set_showBorder_Public_set_Void_Boolean_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_get_reorderable_Public_get_Boolean_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_set_reorderable_Public_set_Void_Boolean_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollingEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_get_showAlternatingRowBackgrounds_Public_get_AlternatingRowBackground_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_set_showAlternatingRowBackgrounds_Public_set_Void_AlternatingRowBackground_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_get_virtualizationMethod_Public_get_CollectionVirtualizationMethod_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_set_virtualizationMethod_Public_set_Void_CollectionVirtualizationMethod_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedItemHeight_Public_get_Single_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_set_fixedItemHeight_Public_set_Void_Single_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_get_lastHeight_Internal_get_Single_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_New_Void_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateVirtualizationController_Internal_CollectionVirtualizationController_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_CreateVirtualizationController_Internal_Void_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateViewController_Internal_CollectionViewController_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_CreateViewController_Protected_Abstract_Virtual_New_CollectionViewController_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_SetViewController_Public_Virtual_New_Void_CollectionViewController_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_CreateDragger_Internal_Virtual_New_ListViewDragger_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDragAndDropController_Internal_Void_Boolean_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_CreateDragAndDropController_Internal_Abstract_Virtual_New_ICollectionDragAndDropController_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_Single_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_GetRootElementForId_Public_VisualElement_Int32_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_HasValidDataAndBindings_Internal_Virtual_New_Boolean_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_OnItemIndexChanged_Private_Void_Int32_Int32_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_OnItemsSourceChanged_Private_Void_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_RefreshItems_Public_Void_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Void_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleRebuild_Internal_Void_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSelection_Private_Void_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_PostRefresh_FamAndAssem_Virtual_New_Void_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_ScrollToItem_Public_Void_Int32_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_ScrollToItemById_Public_Void_Int32_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Private_Void_Vector2_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_Vector2_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Boolean_KeyboardNavigationOperation_Boolean_Boolean_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_KeyboardNavigationOperation_EventBase_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_HandleItemNavigation_FamAndAssem_Virtual_New_Boolean_Boolean_Boolean_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPointerDown_Private_Void_IPointerEvent_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPointerUp_Private_Void_IPointerEvent_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_DoSelect_Private_Void_Vector2_Int32_Boolean_Boolean_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_DoRangeSelection_Internal_Void_Int32_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSingleClick_Private_Void_Int32_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Internal_Void_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_AddToSelection_Public_Void_Int32_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_AddToSelection_Internal_Void_IList_1_Int32_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_AddToSelectionWithoutValidation_Private_Void_Int32_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromSelection_Public_Void_Int32_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromSelectionWithoutValidation_Private_Void_Int32_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_SetSelection_Public_Void_Int32_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_SetSelection_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionWithoutNotify_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionInternal_Internal_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_MatchesExistingSelection_Private_Boolean_IEnumerable_1_Int32_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_NotifyOfSelectionChange_Private_Void_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Public_Void_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelectionWithoutValidation_Private_Void_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_OnSizeChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_OnCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__159_0_Private_Void_Single_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass172_0_PDM_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Int32_byref___c__DisplayClass183_0_0;

		// Token: 0x04000536 RID: 1334
		public const string internalBindingKey = "__unity-collection-view-internal-binding";

		// Token: 0x04000537 RID: 1335
		public const float ItemHeightUnset = -1f;

		// Token: 0x02000338 RID: 824
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x060035C6 RID: 13766 RVA: 0x000DEC24 File Offset: 0x000DCE24
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr);
				BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_FixedItemHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr, "m_FixedItemHeight");
				BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_VirtualizationMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr, "m_VirtualizationMethod");
				BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_ShowBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr, "m_ShowBorder");
				BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_SelectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr, "m_SelectionType");
				BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_ShowAlternatingRowBackgrounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr, "m_ShowAlternatingRowBackgrounds");
				BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_Reorderable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr, "m_Reorderable");
				BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_HorizontalScrollingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr, "m_HorizontalScrollingEnabled");
				BaseVerticalCollectionView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr, 100664254);
				BaseVerticalCollectionView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr, 100664255);
			}

			// Token: 0x060035C7 RID: 13767 RVA: 0x000DED04 File Offset: 0x000DCF04
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 290344, RefRangeEnd = 290346, XrefRangeStart = 290267, XrefRangeEnd = 290344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVerticalCollectionView.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035C8 RID: 13768 RVA: 0x000DED40 File Offset: 0x000DCF40
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 290371, RefRangeEnd = 290373, XrefRangeStart = 290346, XrefRangeEnd = 290371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVerticalCollectionView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035C9 RID: 13769 RVA: 0x00015E77 File Offset: 0x00014077
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010AD RID: 4269
			// (get) Token: 0x060035CA RID: 13770 RVA: 0x000DEDB8 File Offset: 0x000DCFB8
			// (set) Token: 0x060035CB RID: 13771 RVA: 0x00015E80 File Offset: 0x00014080
			public unsafe UxmlIntAttributeDescription m_FixedItemHeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_FixedItemHeight);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_FixedItemHeight), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010AE RID: 4270
			// (get) Token: 0x060035CC RID: 13772 RVA: 0x000DEDE8 File Offset: 0x000DCFE8
			// (set) Token: 0x060035CD RID: 13773 RVA: 0x00015E9F File Offset: 0x0001409F
			public unsafe UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_VirtualizationMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<CollectionVirtualizationMethod>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_VirtualizationMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010AF RID: 4271
			// (get) Token: 0x060035CE RID: 13774 RVA: 0x000DEE18 File Offset: 0x000DD018
			// (set) Token: 0x060035CF RID: 13775 RVA: 0x00015EBE File Offset: 0x000140BE
			public unsafe UxmlBoolAttributeDescription m_ShowBorder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_ShowBorder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_ShowBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B0 RID: 4272
			// (get) Token: 0x060035D0 RID: 13776 RVA: 0x000DEE48 File Offset: 0x000DD048
			// (set) Token: 0x060035D1 RID: 13777 RVA: 0x00015EDD File Offset: 0x000140DD
			public unsafe UxmlEnumAttributeDescription<SelectionType> m_SelectionType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_SelectionType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<SelectionType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_SelectionType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B1 RID: 4273
			// (get) Token: 0x060035D2 RID: 13778 RVA: 0x000DEE78 File Offset: 0x000DD078
			// (set) Token: 0x060035D3 RID: 13779 RVA: 0x00015EFC File Offset: 0x000140FC
			public unsafe UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_ShowAlternatingRowBackgrounds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<AlternatingRowBackground>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_ShowAlternatingRowBackgrounds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B2 RID: 4274
			// (get) Token: 0x060035D4 RID: 13780 RVA: 0x000DEEA8 File Offset: 0x000DD0A8
			// (set) Token: 0x060035D5 RID: 13781 RVA: 0x00015F1B File Offset: 0x0001411B
			public unsafe UxmlBoolAttributeDescription m_Reorderable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_Reorderable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_Reorderable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B3 RID: 4275
			// (get) Token: 0x060035D6 RID: 13782 RVA: 0x000DEED8 File Offset: 0x000DD0D8
			// (set) Token: 0x060035D7 RID: 13783 RVA: 0x00015F3A File Offset: 0x0001413A
			public unsafe UxmlBoolAttributeDescription m_HorizontalScrollingEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_HorizontalScrollingEnabled);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.UxmlTraits.NativeFieldInfoPtr_m_HorizontalScrollingEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400269F RID: 9887
			private static readonly IntPtr NativeFieldInfoPtr_m_FixedItemHeight;

			// Token: 0x040026A0 RID: 9888
			private static readonly IntPtr NativeFieldInfoPtr_m_VirtualizationMethod;

			// Token: 0x040026A1 RID: 9889
			private static readonly IntPtr NativeFieldInfoPtr_m_ShowBorder;

			// Token: 0x040026A2 RID: 9890
			private static readonly IntPtr NativeFieldInfoPtr_m_SelectionType;

			// Token: 0x040026A3 RID: 9891
			private static readonly IntPtr NativeFieldInfoPtr_m_ShowAlternatingRowBackgrounds;

			// Token: 0x040026A4 RID: 9892
			private static readonly IntPtr NativeFieldInfoPtr_m_Reorderable;

			// Token: 0x040026A5 RID: 9893
			private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollingEnabled;

			// Token: 0x040026A6 RID: 9894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040026A7 RID: 9895
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x02000588 RID: 1416
			public new sealed class <get_uxmlChildElementsDescription>d__8
			{
			}
		}

		// Token: 0x02000339 RID: 825
		public class Selection : Object
		{
			// Token: 0x060035D8 RID: 13784 RVA: 0x000DEF08 File Offset: 0x000DD108
			// Note: this type is marked as 'beforefieldinit'.
			static Selection()
			{
				Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "Selection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr);
				BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_IndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, "m_IndexLookup");
				BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_IdLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, "m_IdLookup");
				BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_MinIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, "m_MinIndex");
				BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_MaxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, "m_MaxIndex");
				BaseVerticalCollectionView.Selection.NativeFieldInfoPtr__selectedIds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, "<selectedIds>k__BackingField");
				BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, "indices");
				BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, "items");
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_selectedIds_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664256);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_set_selectedIds_Public_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664257);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664258);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_idCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664259);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_minIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664260);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_maxIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664261);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664262);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_set_capacity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664263);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_FirstIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664264);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_ContainsIndex_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664265);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_ContainsId_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664266);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_AddId_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664267);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_AddIndex_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664268);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_TryRemove_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664269);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_RemoveId_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664270);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_ClearItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664271);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_ClearIds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664272);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_ClearIndices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664273);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664274);
				BaseVerticalCollectionView.Selection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr, 100664275);
			}

			// Token: 0x170010BB RID: 4283
			// (get) Token: 0x060035D9 RID: 13785 RVA: 0x000DF150 File Offset: 0x000DD350
			// (set) Token: 0x060035DA RID: 13786 RVA: 0x000DF190 File Offset: 0x000DD390
			public unsafe List<int> selectedIds
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_selectedIds_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_set_selectedIds_Public_set_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170010BC RID: 4284
			// (get) Token: 0x060035DB RID: 13787 RVA: 0x000DF1D4 File Offset: 0x000DD3D4
			public unsafe int indexCount
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 290374, RefRangeEnd = 290379, XrefRangeStart = 290373, XrefRangeEnd = 290374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170010BD RID: 4285
			// (get) Token: 0x060035DC RID: 13788 RVA: 0x000DF210 File Offset: 0x000DD410
			public unsafe int idCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290379, XrefRangeEnd = 290380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_idCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170010BE RID: 4286
			// (get) Token: 0x060035DD RID: 13789 RVA: 0x000DF24C File Offset: 0x000DD44C
			public unsafe int minIndex
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290380, XrefRangeEnd = 290381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_minIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170010BF RID: 4287
			// (get) Token: 0x060035DE RID: 13790 RVA: 0x000DF288 File Offset: 0x000DD488
			public unsafe int maxIndex
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290381, XrefRangeEnd = 290382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_maxIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170010C0 RID: 4288
			// (get) Token: 0x060035DF RID: 13791 RVA: 0x000DF2C4 File Offset: 0x000DD4C4
			// (set) Token: 0x060035E0 RID: 13792 RVA: 0x000DF300 File Offset: 0x000DD500
			public unsafe int capacity
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290382, XrefRangeEnd = 290386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_get_capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290386, XrefRangeEnd = 290394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_set_capacity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060035E1 RID: 13793 RVA: 0x000DF340 File Offset: 0x000DD540
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 290398, RefRangeEnd = 290400, XrefRangeStart = 290394, XrefRangeEnd = 290398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int FirstIndex()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_FirstIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060035E2 RID: 13794 RVA: 0x000DF37C File Offset: 0x000DD57C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 290404, RefRangeEnd = 290407, XrefRangeStart = 290400, XrefRangeEnd = 290404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ContainsIndex(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_ContainsIndex_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035E3 RID: 13795 RVA: 0x000DF3C8 File Offset: 0x000DD5C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 290411, RefRangeEnd = 290412, XrefRangeStart = 290407, XrefRangeEnd = 290411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ContainsId(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_ContainsId_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035E4 RID: 13796 RVA: 0x000DF414 File Offset: 0x000DD614
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 290421, RefRangeEnd = 290423, XrefRangeStart = 290412, XrefRangeEnd = 290421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddId(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_AddId_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060035E5 RID: 13797 RVA: 0x000DF454 File Offset: 0x000DD654
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 290433, RefRangeEnd = 290436, XrefRangeStart = 290423, XrefRangeEnd = 290433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddIndex(int index, Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_AddIndex_Public_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035E6 RID: 13798 RVA: 0x000DF4A4 File Offset: 0x000DD6A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290436, XrefRangeEnd = 290448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryRemove(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_TryRemove_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035E7 RID: 13799 RVA: 0x000DF4F0 File Offset: 0x000DD6F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290448, XrefRangeEnd = 290455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveId(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_RemoveId_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060035E8 RID: 13800 RVA: 0x000DF530 File Offset: 0x000DD730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290455, XrefRangeEnd = 290459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearItems()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_ClearItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035E9 RID: 13801 RVA: 0x000DF564 File Offset: 0x000DD764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290459, XrefRangeEnd = 290463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearIds()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_ClearIds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035EA RID: 13802 RVA: 0x000DF598 File Offset: 0x000DD798
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 290467, RefRangeEnd = 290468, XrefRangeStart = 290463, XrefRangeEnd = 290467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearIndices()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_ClearIndices_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035EB RID: 13803 RVA: 0x000DF5CC File Offset: 0x000DD7CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290468, XrefRangeEnd = 290479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035EC RID: 13804 RVA: 0x000DF600 File Offset: 0x000DD800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290479, XrefRangeEnd = 290506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Selection()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVerticalCollectionView.Selection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.Selection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035ED RID: 13805 RVA: 0x00015F59 File Offset: 0x00014159
			public Selection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B4 RID: 4276
			// (get) Token: 0x060035EE RID: 13806 RVA: 0x000DF63C File Offset: 0x000DD83C
			// (set) Token: 0x060035EF RID: 13807 RVA: 0x00015F62 File Offset: 0x00014162
			public unsafe HashSet<int> m_IndexLookup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_IndexLookup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_IndexLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B5 RID: 4277
			// (get) Token: 0x060035F0 RID: 13808 RVA: 0x000DF66C File Offset: 0x000DD86C
			// (set) Token: 0x060035F1 RID: 13809 RVA: 0x00015F81 File Offset: 0x00014181
			public unsafe HashSet<int> m_IdLookup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_IdLookup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_IdLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B6 RID: 4278
			// (get) Token: 0x060035F2 RID: 13810 RVA: 0x000DF69C File Offset: 0x000DD89C
			// (set) Token: 0x060035F3 RID: 13811 RVA: 0x00015FA0 File Offset: 0x000141A0
			public unsafe int m_MinIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_MinIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_MinIndex)) = value;
				}
			}

			// Token: 0x170010B7 RID: 4279
			// (get) Token: 0x060035F4 RID: 13812 RVA: 0x000DF6C4 File Offset: 0x000DD8C4
			// (set) Token: 0x060035F5 RID: 13813 RVA: 0x00015FBB File Offset: 0x000141BB
			public unsafe int m_MaxIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_MaxIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_m_MaxIndex)) = value;
				}
			}

			// Token: 0x170010B8 RID: 4280
			// (get) Token: 0x060035F6 RID: 13814 RVA: 0x000DF6EC File Offset: 0x000DD8EC
			// (set) Token: 0x060035F7 RID: 13815 RVA: 0x00015FD6 File Offset: 0x000141D6
			public unsafe List<int> _selectedIds_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr__selectedIds_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr__selectedIds_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B9 RID: 4281
			// (get) Token: 0x060035F8 RID: 13816 RVA: 0x000DF71C File Offset: 0x000DD91C
			// (set) Token: 0x060035F9 RID: 13817 RVA: 0x00015FF5 File Offset: 0x000141F5
			public unsafe List<int> indices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_indices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010BA RID: 4282
			// (get) Token: 0x060035FA RID: 13818 RVA: 0x000DF74C File Offset: 0x000DD94C
			// (set) Token: 0x060035FB RID: 13819 RVA: 0x00016014 File Offset: 0x00014214
			public unsafe Dictionary<int, Object> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.Selection.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040026A8 RID: 9896
			private static readonly IntPtr NativeFieldInfoPtr_m_IndexLookup;

			// Token: 0x040026A9 RID: 9897
			private static readonly IntPtr NativeFieldInfoPtr_m_IdLookup;

			// Token: 0x040026AA RID: 9898
			private static readonly IntPtr NativeFieldInfoPtr_m_MinIndex;

			// Token: 0x040026AB RID: 9899
			private static readonly IntPtr NativeFieldInfoPtr_m_MaxIndex;

			// Token: 0x040026AC RID: 9900
			private static readonly IntPtr NativeFieldInfoPtr__selectedIds_k__BackingField;

			// Token: 0x040026AD RID: 9901
			private static readonly IntPtr NativeFieldInfoPtr_indices;

			// Token: 0x040026AE RID: 9902
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x040026AF RID: 9903
			private static readonly IntPtr NativeMethodInfoPtr_get_selectedIds_Public_get_List_1_Int32_0;

			// Token: 0x040026B0 RID: 9904
			private static readonly IntPtr NativeMethodInfoPtr_set_selectedIds_Public_set_Void_List_1_Int32_0;

			// Token: 0x040026B1 RID: 9905
			private static readonly IntPtr NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0;

			// Token: 0x040026B2 RID: 9906
			private static readonly IntPtr NativeMethodInfoPtr_get_idCount_Public_get_Int32_0;

			// Token: 0x040026B3 RID: 9907
			private static readonly IntPtr NativeMethodInfoPtr_get_minIndex_Public_get_Int32_0;

			// Token: 0x040026B4 RID: 9908
			private static readonly IntPtr NativeMethodInfoPtr_get_maxIndex_Public_get_Int32_0;

			// Token: 0x040026B5 RID: 9909
			private static readonly IntPtr NativeMethodInfoPtr_get_capacity_Public_get_Int32_0;

			// Token: 0x040026B6 RID: 9910
			private static readonly IntPtr NativeMethodInfoPtr_set_capacity_Public_set_Void_Int32_0;

			// Token: 0x040026B7 RID: 9911
			private static readonly IntPtr NativeMethodInfoPtr_FirstIndex_Public_Int32_0;

			// Token: 0x040026B8 RID: 9912
			private static readonly IntPtr NativeMethodInfoPtr_ContainsIndex_Public_Boolean_Int32_0;

			// Token: 0x040026B9 RID: 9913
			private static readonly IntPtr NativeMethodInfoPtr_ContainsId_Public_Boolean_Int32_0;

			// Token: 0x040026BA RID: 9914
			private static readonly IntPtr NativeMethodInfoPtr_AddId_Public_Void_Int32_0;

			// Token: 0x040026BB RID: 9915
			private static readonly IntPtr NativeMethodInfoPtr_AddIndex_Public_Void_Int32_Object_0;

			// Token: 0x040026BC RID: 9916
			private static readonly IntPtr NativeMethodInfoPtr_TryRemove_Public_Boolean_Int32_0;

			// Token: 0x040026BD RID: 9917
			private static readonly IntPtr NativeMethodInfoPtr_RemoveId_Public_Void_Int32_0;

			// Token: 0x040026BE RID: 9918
			private static readonly IntPtr NativeMethodInfoPtr_ClearItems_Public_Void_0;

			// Token: 0x040026BF RID: 9919
			private static readonly IntPtr NativeMethodInfoPtr_ClearIds_Public_Void_0;

			// Token: 0x040026C0 RID: 9920
			private static readonly IntPtr NativeMethodInfoPtr_ClearIndices_Public_Void_0;

			// Token: 0x040026C1 RID: 9921
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x040026C2 RID: 9922
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200033A RID: 826
		[ObfuscatedName("UnityEngine.UIElements.BaseVerticalCollectionView+<>c__DisplayClass162_0")]
		public sealed class __c__DisplayClass162_0 : Object
		{
			// Token: 0x060035FC RID: 13820 RVA: 0x000DF77C File Offset: 0x000DD97C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass162_0()
			{
				Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass162_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "<>c__DisplayClass162_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass162_0>.NativeClassPtr);
				BaseVerticalCollectionView.__c__DisplayClass162_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass162_0>.NativeClassPtr, "id");
				BaseVerticalCollectionView.__c__DisplayClass162_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass162_0>.NativeClassPtr, 100664276);
				BaseVerticalCollectionView.__c__DisplayClass162_0.NativeMethodInfoPtr__GetRootElementForId_b__0_Internal_Boolean_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass162_0>.NativeClassPtr, 100664277);
			}

			// Token: 0x060035FD RID: 13821 RVA: 0x000DF7E4 File Offset: 0x000DD9E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass162_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass162_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.__c__DisplayClass162_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035FE RID: 13822 RVA: 0x000DF820 File Offset: 0x000DDA20
			[CallerCount(0)]
			public unsafe bool _GetRootElementForId_b__0(ReusableCollectionItem t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView.__c__DisplayClass162_0.NativeMethodInfoPtr__GetRootElementForId_b__0_Internal_Boolean_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035FF RID: 13823 RVA: 0x00016033 File Offset: 0x00014233
			public __c__DisplayClass162_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010C1 RID: 4289
			// (get) Token: 0x06003600 RID: 13824 RVA: 0x000DF870 File Offset: 0x000DDA70
			// (set) Token: 0x06003601 RID: 13825 RVA: 0x0001603C File Offset: 0x0001423C
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass162_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass162_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x040026C3 RID: 9923
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040026C4 RID: 9924
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040026C5 RID: 9925
			private static readonly IntPtr NativeMethodInfoPtr__GetRootElementForId_b__0_Internal_Boolean_ReusableCollectionItem_0;
		}

		// Token: 0x0200033B RID: 827
		[ObfuscatedName("UnityEngine.UIElements.BaseVerticalCollectionView+<>c__DisplayClass172_0")]
		public sealed class __c__DisplayClass172_0 : ValueType
		{
			// Token: 0x06003602 RID: 13826 RVA: 0x000DF898 File Offset: 0x000DDA98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass172_0()
			{
				Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass172_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "<>c__DisplayClass172_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass172_0>.NativeClassPtr);
				BaseVerticalCollectionView.__c__DisplayClass172_0.NativeFieldInfoPtr_selectedIndicesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass172_0>.NativeClassPtr, "selectedIndicesChanged");
				BaseVerticalCollectionView.__c__DisplayClass172_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass172_0>.NativeClassPtr, "<>4__this");
				BaseVerticalCollectionView.__c__DisplayClass172_0.NativeFieldInfoPtr_previousSelectionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass172_0>.NativeClassPtr, "previousSelectionCount");
			}

			// Token: 0x06003603 RID: 13827 RVA: 0x00016057 File Offset: 0x00014257
			public __c__DisplayClass172_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003604 RID: 13828 RVA: 0x00016060 File Offset: 0x00014260
			public __c__DisplayClass172_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass172_0>.NativeClassPtr))
			{
			}

			// Token: 0x170010C2 RID: 4290
			// (get) Token: 0x06003605 RID: 13829 RVA: 0x000DF900 File Offset: 0x000DDB00
			// (set) Token: 0x06003606 RID: 13830 RVA: 0x00016072 File Offset: 0x00014272
			public unsafe bool selectedIndicesChanged
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass172_0.NativeFieldInfoPtr_selectedIndicesChanged);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass172_0.NativeFieldInfoPtr_selectedIndicesChanged)) = value;
				}
			}

			// Token: 0x170010C3 RID: 4291
			// (get) Token: 0x06003607 RID: 13831 RVA: 0x000DF928 File Offset: 0x000DDB28
			// (set) Token: 0x06003608 RID: 13832 RVA: 0x0001608D File Offset: 0x0001428D
			public unsafe BaseVerticalCollectionView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass172_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVerticalCollectionView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass172_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010C4 RID: 4292
			// (get) Token: 0x06003609 RID: 13833 RVA: 0x000DF958 File Offset: 0x000DDB58
			// (set) Token: 0x0600360A RID: 13834 RVA: 0x000160AC File Offset: 0x000142AC
			public unsafe int previousSelectionCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass172_0.NativeFieldInfoPtr_previousSelectionCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass172_0.NativeFieldInfoPtr_previousSelectionCount)) = value;
				}
			}

			// Token: 0x040026C6 RID: 9926
			private static readonly IntPtr NativeFieldInfoPtr_selectedIndicesChanged;

			// Token: 0x040026C7 RID: 9927
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040026C8 RID: 9928
			private static readonly IntPtr NativeFieldInfoPtr_previousSelectionCount;
		}

		// Token: 0x0200033C RID: 828
		[ObfuscatedName("UnityEngine.UIElements.BaseVerticalCollectionView+<>c__DisplayClass183_0")]
		public sealed class __c__DisplayClass183_0 : ValueType
		{
			// Token: 0x0600360B RID: 13835 RVA: 0x000DF980 File Offset: 0x000DDB80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass183_0()
			{
				Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass183_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "<>c__DisplayClass183_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass183_0>.NativeClassPtr);
				BaseVerticalCollectionView.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass183_0>.NativeClassPtr, "<>4__this");
				BaseVerticalCollectionView.__c__DisplayClass183_0.NativeFieldInfoPtr_shiftKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass183_0>.NativeClassPtr, "shiftKey");
			}

			// Token: 0x0600360C RID: 13836 RVA: 0x000160C7 File Offset: 0x000142C7
			public __c__DisplayClass183_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600360D RID: 13837 RVA: 0x000160D0 File Offset: 0x000142D0
			public __c__DisplayClass183_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVerticalCollectionView.__c__DisplayClass183_0>.NativeClassPtr))
			{
			}

			// Token: 0x170010C5 RID: 4293
			// (get) Token: 0x0600360E RID: 13838 RVA: 0x000DF9D4 File Offset: 0x000DDBD4
			// (set) Token: 0x0600360F RID: 13839 RVA: 0x000160E2 File Offset: 0x000142E2
			public unsafe BaseVerticalCollectionView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVerticalCollectionView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010C6 RID: 4294
			// (get) Token: 0x06003610 RID: 13840 RVA: 0x000DFA04 File Offset: 0x000DDC04
			// (set) Token: 0x06003611 RID: 13841 RVA: 0x00016101 File Offset: 0x00014301
			public unsafe bool shiftKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass183_0.NativeFieldInfoPtr_shiftKey);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView.__c__DisplayClass183_0.NativeFieldInfoPtr_shiftKey)) = value;
				}
			}

			// Token: 0x040026C9 RID: 9929
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040026CA RID: 9930
			private static readonly IntPtr NativeFieldInfoPtr_shiftKey;
		}

		// Token: 0x0200033D RID: 829
		[ObfuscatedName("UnityEngine.UIElements.BaseVerticalCollectionView+<get_selectedItems>d__72")]
		public sealed class _get_selectedItems_d__72 : Object
		{
			// Token: 0x06003612 RID: 13842 RVA: 0x000DFA2C File Offset: 0x000DDC2C
			// Note: this type is marked as 'beforefieldinit'.
			static _get_selectedItems_d__72()
			{
				Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr, "<get_selectedItems>d__72");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr);
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, "<>1__state");
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, "<>2__current");
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, "<>l__initialThreadId");
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, "<>4__this");
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___s__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, "<>s__1");
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, "<index>5__2");
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr__item_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, "<item>5__3");
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, 100664278);
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, 100664279);
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, 100664280);
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, 100664281);
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, 100664282);
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, 100664283);
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, 100664284);
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, 100664285);
				BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr, 100664286);
			}

			// Token: 0x06003613 RID: 13843 RVA: 0x000DFB98 File Offset: 0x000DDD98
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_selectedItems_d__72(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVerticalCollectionView._get_selectedItems_d__72>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003614 RID: 13844 RVA: 0x000DFBE0 File Offset: 0x000DDDE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290506, XrefRangeEnd = 290511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003615 RID: 13845 RVA: 0x000DFC14 File Offset: 0x000DDE14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290511, XrefRangeEnd = 290533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003616 RID: 13846 RVA: 0x000DFC50 File Offset: 0x000DDE50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290533, XrefRangeEnd = 290536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010CE RID: 4302
			// (get) Token: 0x06003617 RID: 13847 RVA: 0x000DFC84 File Offset: 0x000DDE84
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003618 RID: 13848 RVA: 0x000DFCC4 File Offset: 0x000DDEC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290536, XrefRangeEnd = 290541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010CF RID: 4303
			// (get) Token: 0x06003619 RID: 13849 RVA: 0x000DFCF8 File Offset: 0x000DDEF8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600361A RID: 13850 RVA: 0x000DFD38 File Offset: 0x000DDF38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290541, XrefRangeEnd = 290543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Object> System_Collections_Generic_IEnumerable_System_Object__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Object>>(intPtr3) : null;
			}

			// Token: 0x0600361B RID: 13851 RVA: 0x000DFD78 File Offset: 0x000DDF78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVerticalCollectionView._get_selectedItems_d__72.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600361C RID: 13852 RVA: 0x0001611C File Offset: 0x0001431C
			public _get_selectedItems_d__72(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010C7 RID: 4295
			// (get) Token: 0x0600361D RID: 13853 RVA: 0x000DFDB8 File Offset: 0x000DDFB8
			// (set) Token: 0x0600361E RID: 13854 RVA: 0x00016125 File Offset: 0x00014325
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010C8 RID: 4296
			// (get) Token: 0x0600361F RID: 13855 RVA: 0x000DFDE0 File Offset: 0x000DDFE0
			// (set) Token: 0x06003620 RID: 13856 RVA: 0x00016140 File Offset: 0x00014340
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010C9 RID: 4297
			// (get) Token: 0x06003621 RID: 13857 RVA: 0x000DFE10 File Offset: 0x000DE010
			// (set) Token: 0x06003622 RID: 13858 RVA: 0x0001615F File Offset: 0x0001435F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170010CA RID: 4298
			// (get) Token: 0x06003623 RID: 13859 RVA: 0x000DFE38 File Offset: 0x000DE038
			// (set) Token: 0x06003624 RID: 13860 RVA: 0x0001617A File Offset: 0x0001437A
			public unsafe BaseVerticalCollectionView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVerticalCollectionView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010CB RID: 4299
			// (get) Token: 0x06003625 RID: 13861 RVA: 0x000DFE68 File Offset: 0x000DE068
			// (set) Token: 0x06003626 RID: 13862 RVA: 0x00016199 File Offset: 0x00014399
			public List<int>.Enumerator __s__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___s__1);
					return new List<int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr___s__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170010CC RID: 4300
			// (get) Token: 0x06003627 RID: 13863 RVA: 0x000DFE98 File Offset: 0x000DE098
			// (set) Token: 0x06003628 RID: 13864 RVA: 0x000161C7 File Offset: 0x000143C7
			public unsafe int _index_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr__index_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr__index_5__2)) = value;
				}
			}

			// Token: 0x170010CD RID: 4301
			// (get) Token: 0x06003629 RID: 13865 RVA: 0x000DFEC0 File Offset: 0x000DE0C0
			// (set) Token: 0x0600362A RID: 13866 RVA: 0x000161E2 File Offset: 0x000143E2
			public unsafe Object _item_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr__item_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVerticalCollectionView._get_selectedItems_d__72.NativeFieldInfoPtr__item_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040026CB RID: 9931
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040026CC RID: 9932
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040026CD RID: 9933
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040026CE RID: 9934
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040026CF RID: 9935
			private static readonly IntPtr NativeFieldInfoPtr___s__1;

			// Token: 0x040026D0 RID: 9936
			private static readonly IntPtr NativeFieldInfoPtr__index_5__2;

			// Token: 0x040026D1 RID: 9937
			private static readonly IntPtr NativeFieldInfoPtr__item_5__3;

			// Token: 0x040026D2 RID: 9938
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040026D3 RID: 9939
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040026D4 RID: 9940
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040026D5 RID: 9941
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040026D6 RID: 9942
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040026D7 RID: 9943
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040026D8 RID: 9944
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040026D9 RID: 9945
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0;

			// Token: 0x040026DA RID: 9946
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200033E RID: 830
		private sealed class MethodInfoStoreGeneric_CreateVirtualizationController_Internal_Void_0<T>
		{
			// Token: 0x040026DB RID: 9947
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseVerticalCollectionView.NativeMethodInfoPtr_CreateVirtualizationController_Internal_Void_0, Il2CppClassPointerStore<BaseVerticalCollectionView>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200033F RID: 831
		public sealed class <>c__DisplayClass162_0
		{
		}

		// Token: 0x02000340 RID: 832
		public sealed class <get_selectedItems>d__72
		{
		}
	}
}
