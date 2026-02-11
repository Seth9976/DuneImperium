using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.Internal
{
	// Token: 0x020002AF RID: 687
	public class MultiColumnCollectionHeader : VisualElement
	{
		// Token: 0x060032EC RID: 13036 RVA: 0x000D7390 File Offset: 0x000D5590
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnCollectionHeader()
		{
			Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Internal", "MultiColumnCollectionHeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr);
			MultiColumnCollectionHeader.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "ussClassName");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_columnContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "columnContainerUssClassName");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_handleContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "handleContainerUssClassName");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_reorderableUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "reorderableUssClassName");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "m_SortingEnabled");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortedColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "m_SortedColumns");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "m_SortDescriptions");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_m_OldSortedColumnStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "m_OldSortedColumnStates");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortingUpdatesTemporarilyDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "m_SortingUpdatesTemporarilyDisabled");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_m_ViewState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "m_ViewState");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_m_ApplyingViewState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "m_ApplyingViewState");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_m_DoLayoutScheduled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "m_DoLayoutScheduled");
			MultiColumnCollectionHeader.NativeFieldInfoPtr__columnDataMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "<columnDataMap>k__BackingField");
			MultiColumnCollectionHeader.NativeFieldInfoPtr__columnLayout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "<columnLayout>k__BackingField");
			MultiColumnCollectionHeader.NativeFieldInfoPtr__columnContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "<columnContainer>k__BackingField");
			MultiColumnCollectionHeader.NativeFieldInfoPtr__resizeHandleContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "<resizeHandleContainer>k__BackingField");
			MultiColumnCollectionHeader.NativeFieldInfoPtr__columns_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "<columns>k__BackingField");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_columnResized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "columnResized");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_columnSortingChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "columnSortingChanged");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_contextMenuPopulateEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "contextMenuPopulateEvent");
			MultiColumnCollectionHeader.NativeFieldInfoPtr_viewDataRestored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "viewDataRestored");
			MultiColumnCollectionHeader.NativeMethodInfoPtr_get_isApplyingViewState_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670683);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_get_columnDataMap_Public_get_Dictionary_2_Column_ColumnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670684);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_get_columnLayout_Public_get_ColumnLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670685);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_get_columnContainer_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670686);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_get_resizeHandleContainer_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670687);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_get_sortedColumns_Public_get_IEnumerable_1_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670688);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_get_sortDescriptions_Public_get_SortColumnDescriptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670689);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_set_sortDescriptions_FamOrAssem_set_Void_SortColumnDescriptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670690);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_get_columns_Public_get_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670691);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_get_sortingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670692);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_set_sortingEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670693);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_add_columnResized_Public_add_Void_Action_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670694);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_remove_columnResized_Public_rem_Void_Action_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670695);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_add_columnSortingChanged_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670696);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_remove_columnSortingChanged_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670697);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_add_contextMenuPopulateEvent_Public_add_Void_Action_2_ContextualMenuPopulateEvent_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670698);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_remove_contextMenuPopulateEvent_Public_rem_Void_Action_2_ContextualMenuPopulateEvent_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670699);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_add_viewDataRestored_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670700);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_remove_viewDataRestored_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670701);
			MultiColumnCollectionHeader.NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670702);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_ScheduleDoLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670703);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_ResizeToFit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670704);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_UpdateSortedColumns_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670705);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_UpdateColumnControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670706);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670707);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670708);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnRemoved_Private_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670709);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670710);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnReordered_Private_Void_Column_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670711);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670712);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnContextualMenuManipulator_Private_Void_ContextualMenuPopulateEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670713);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnMoveManipulatorActivated_Private_Void_ColumnMover_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670714);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670715);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_DoLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670716);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnControlGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670717);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnClicked_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670718);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_UpdateSortColumnDescriptionsOnClick_Private_Void_Column_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670719);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_ScrollHorizontally_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670720);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_RaiseColumnResized_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670721);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_RaiseColumnSortingChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670722);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_ApplyColumnSorting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670723);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_UpdateSortingStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670724);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670725);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_SaveViewState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670726);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_CleanupColumnData_Private_Void_ColumnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670727);
			MultiColumnCollectionHeader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670728);
			MultiColumnCollectionHeader.NativeMethodInfoPtr__OnContextualMenuManipulator_b__65_0_Private_Void_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, 100670730);
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x060032ED RID: 13037 RVA: 0x000D7910 File Offset: 0x000D5B10
		public unsafe bool isApplyingViewState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_get_isApplyingViewState_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x000D794C File Offset: 0x000D5B4C
		public unsafe Dictionary<Column, MultiColumnCollectionHeader.ColumnData> columnDataMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_get_columnDataMap_Public_get_Dictionary_2_Column_ColumnData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Column, MultiColumnCollectionHeader.ColumnData>>(intPtr3) : null;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x060032EF RID: 13039 RVA: 0x000D798C File Offset: 0x000D5B8C
		public unsafe ColumnLayout columnLayout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_get_columnLayout_Public_get_ColumnLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColumnLayout>(intPtr3) : null;
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x000D79CC File Offset: 0x000D5BCC
		public unsafe VisualElement columnContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_get_columnContainer_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x060032F1 RID: 13041 RVA: 0x000D7A0C File Offset: 0x000D5C0C
		public unsafe VisualElement resizeHandleContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_get_resizeHandleContainer_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x000D7A4C File Offset: 0x000D5C4C
		public unsafe IEnumerable<SortColumnDescription> sortedColumns
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_get_sortedColumns_Public_get_IEnumerable_1_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SortColumnDescription>>(intPtr3) : null;
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x060032F3 RID: 13043 RVA: 0x000D7A8C File Offset: 0x000D5C8C
		// (set) Token: 0x060032F4 RID: 13044 RVA: 0x000D7ACC File Offset: 0x000D5CCC
		public unsafe SortColumnDescriptions sortDescriptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_get_sortDescriptions_Public_get_SortColumnDescriptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortColumnDescriptions>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 360712, RefRangeEnd = 360716, XrefRangeStart = 360702, XrefRangeEnd = 360712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_set_sortDescriptions_FamOrAssem_set_Void_SortColumnDescriptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x000D7B10 File Offset: 0x000D5D10
		public unsafe Columns columns
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_get_columns_Public_get_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Columns>(intPtr3) : null;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x000D7B50 File Offset: 0x000D5D50
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x000D7B8C File Offset: 0x000D5D8C
		public unsafe bool sortingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_get_sortingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 360718, RefRangeEnd = 360724, XrefRangeStart = 360716, XrefRangeEnd = 360718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_set_sortingEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x000D7BCC File Offset: 0x000D5DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360729, RefRangeEnd = 360730, XrefRangeStart = 360724, XrefRangeEnd = 360729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_columnResized(Action<int, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_add_columnResized_Public_add_Void_Action_2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000D7C10 File Offset: 0x000D5E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360735, RefRangeEnd = 360736, XrefRangeStart = 360730, XrefRangeEnd = 360735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_columnResized(Action<int, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_remove_columnResized_Public_rem_Void_Action_2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x000D7C54 File Offset: 0x000D5E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360740, RefRangeEnd = 360741, XrefRangeStart = 360736, XrefRangeEnd = 360740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_columnSortingChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_add_columnSortingChanged_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x000D7C98 File Offset: 0x000D5E98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360745, RefRangeEnd = 360746, XrefRangeStart = 360741, XrefRangeEnd = 360745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_columnSortingChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_remove_columnSortingChanged_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x000D7CDC File Offset: 0x000D5EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360751, RefRangeEnd = 360752, XrefRangeStart = 360746, XrefRangeEnd = 360751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_add_contextMenuPopulateEvent_Public_add_Void_Action_2_ContextualMenuPopulateEvent_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000D7D20 File Offset: 0x000D5F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360757, RefRangeEnd = 360758, XrefRangeStart = 360752, XrefRangeEnd = 360757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_remove_contextMenuPopulateEvent_Public_rem_Void_Action_2_ContextualMenuPopulateEvent_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x000D7D64 File Offset: 0x000D5F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360762, RefRangeEnd = 360763, XrefRangeStart = 360758, XrefRangeEnd = 360762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_viewDataRestored(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_add_viewDataRestored_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x000D7DA8 File Offset: 0x000D5FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360767, RefRangeEnd = 360768, XrefRangeStart = 360763, XrefRangeEnd = 360767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_viewDataRestored(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_remove_viewDataRestored_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x000D7DEC File Offset: 0x000D5FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360904, RefRangeEnd = 360905, XrefRangeStart = 360768, XrefRangeEnd = 360904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnCollectionHeader(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortDescriptions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortedColumns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x000D7E5C File Offset: 0x000D605C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360905, XrefRangeEnd = 360915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleDoLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_ScheduleDoLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x000D7E90 File Offset: 0x000D6090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360915, XrefRangeEnd = 360918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeToFit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_ResizeToFit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x000D7EC4 File Offset: 0x000D60C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 360990, RefRangeEnd = 360994, XrefRangeStart = 360918, XrefRangeEnd = 360990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSortedColumns()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_UpdateSortedColumns_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x000D7EF8 File Offset: 0x000D60F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 361047, RefRangeEnd = 361052, XrefRangeStart = 360994, XrefRangeEnd = 361047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColumnControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_UpdateColumnControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x000D7F2C File Offset: 0x000D612C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361052, XrefRangeEnd = 361053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnAdded(Column column, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000D7F7C File Offset: 0x000D617C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 361119, RefRangeEnd = 361122, XrefRangeStart = 361053, XrefRangeEnd = 361119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnAdded(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x000D7FC0 File Offset: 0x000D61C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 361161, RefRangeEnd = 361163, XrefRangeStart = 361122, XrefRangeEnd = 361161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnRemoved(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnRemoved_Private_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x000D8004 File Offset: 0x000D6204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361163, XrefRangeEnd = 361171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnChanged(Column column, ColumnDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x000D8054 File Offset: 0x000D6254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361171, XrefRangeEnd = 361188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnReordered(Column column, int from, int to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnReordered_Private_Void_Column_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x000D80B4 File Offset: 0x000D62B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361188, XrefRangeEnd = 361190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnResized(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x000D80F8 File Offset: 0x000D62F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361190, XrefRangeEnd = 361265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnContextualMenuManipulator_Private_Void_ContextualMenuPopulateEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000D813C File Offset: 0x000D633C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361265, XrefRangeEnd = 361273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMoveManipulatorActivated(ColumnMover mover)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mover);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnMoveManipulatorActivated_Private_Void_ColumnMover_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x000D8180 File Offset: 0x000D6380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361273, XrefRangeEnd = 361276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGeometryChanged(GeometryChangedEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x000D81C4 File Offset: 0x000D63C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361276, XrefRangeEnd = 361278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_DoLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x000D81F8 File Offset: 0x000D63F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361278, XrefRangeEnd = 361306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnControlGeometryChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnControlGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x000D823C File Offset: 0x000D643C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361306, XrefRangeEnd = 361324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnClicked(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_OnColumnClicked_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x000D8280 File Offset: 0x000D6480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361357, RefRangeEnd = 361358, XrefRangeStart = 361324, XrefRangeEnd = 361357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_UpdateSortColumnDescriptionsOnClick_Private_Void_Column_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x000D82D0 File Offset: 0x000D64D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361368, RefRangeEnd = 361369, XrefRangeStart = 361358, XrefRangeEnd = 361368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScrollHorizontally(float horizontalOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref horizontalOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_ScrollHorizontally_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x000D8310 File Offset: 0x000D6510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361369, XrefRangeEnd = 361374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseColumnResized(int columnIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref columnIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_RaiseColumnResized_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x000D8350 File Offset: 0x000D6550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361374, XrefRangeEnd = 361375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseColumnSortingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_RaiseColumnSortingChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000D8384 File Offset: 0x000D6584
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 361448, RefRangeEnd = 361451, XrefRangeStart = 361375, XrefRangeEnd = 361448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColumnSorting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_ApplyColumnSorting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x000D83B8 File Offset: 0x000D65B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 361499, RefRangeEnd = 361501, XrefRangeStart = 361451, XrefRangeEnd = 361499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSortingStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_UpdateSortingStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x000D83EC File Offset: 0x000D65EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361501, XrefRangeEnd = 361509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewDataReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnCollectionHeader.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x000D8428 File Offset: 0x000D6628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveViewState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_SaveViewState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x000D845C File Offset: 0x000D665C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361541, RefRangeEnd = 361542, XrefRangeStart = 361509, XrefRangeEnd = 361541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupColumnData(MultiColumnCollectionHeader.ColumnData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_CleanupColumnData_Private_Void_ColumnData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x000D84A0 File Offset: 0x000D66A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361610, RefRangeEnd = 361611, XrefRangeStart = 361542, XrefRangeEnd = 361610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x000D84D4 File Offset: 0x000D66D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnContextualMenuManipulator_b__65_0(DropdownMenuAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.NativeMethodInfoPtr__OnContextualMenuManipulator_b__65_0_Private_Void_DropdownMenuAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x0001499B File Offset: 0x00012B9B
		public MultiColumnCollectionHeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x0600331D RID: 13085 RVA: 0x000D8518 File Offset: 0x000D6718
		// (set) Token: 0x0600331E RID: 13086 RVA: 0x000149A4 File Offset: 0x00012BA4
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnCollectionHeader.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnCollectionHeader.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x0600331F RID: 13087 RVA: 0x000D8538 File Offset: 0x000D6738
		// (set) Token: 0x06003320 RID: 13088 RVA: 0x000149B6 File Offset: 0x00012BB6
		public unsafe static string columnContainerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnCollectionHeader.NativeFieldInfoPtr_columnContainerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnCollectionHeader.NativeFieldInfoPtr_columnContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06003321 RID: 13089 RVA: 0x000D8558 File Offset: 0x000D6758
		// (set) Token: 0x06003322 RID: 13090 RVA: 0x000149C8 File Offset: 0x00012BC8
		public unsafe static string handleContainerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnCollectionHeader.NativeFieldInfoPtr_handleContainerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnCollectionHeader.NativeFieldInfoPtr_handleContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06003323 RID: 13091 RVA: 0x000D8578 File Offset: 0x000D6778
		// (set) Token: 0x06003324 RID: 13092 RVA: 0x000149DA File Offset: 0x00012BDA
		public unsafe static string reorderableUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnCollectionHeader.NativeFieldInfoPtr_reorderableUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnCollectionHeader.NativeFieldInfoPtr_reorderableUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06003325 RID: 13093 RVA: 0x000D8598 File Offset: 0x000D6798
		// (set) Token: 0x06003326 RID: 13094 RVA: 0x000149EC File Offset: 0x00012BEC
		public unsafe bool m_SortingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortingEnabled)) = value;
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06003327 RID: 13095 RVA: 0x000D85C0 File Offset: 0x000D67C0
		// (set) Token: 0x06003328 RID: 13096 RVA: 0x00014A07 File Offset: 0x00012C07
		public unsafe List<SortColumnDescription> m_SortedColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortedColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SortColumnDescription>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortedColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x000D85F0 File Offset: 0x000D67F0
		// (set) Token: 0x0600332A RID: 13098 RVA: 0x00014A26 File Offset: 0x00012C26
		public unsafe SortColumnDescriptions m_SortDescriptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortDescriptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortColumnDescriptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortDescriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x000D8620 File Offset: 0x000D6820
		// (set) Token: 0x0600332C RID: 13100 RVA: 0x00014A45 File Offset: 0x00012C45
		public unsafe List<MultiColumnCollectionHeader.SortedColumnState> m_OldSortedColumnStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_OldSortedColumnStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MultiColumnCollectionHeader.SortedColumnState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_OldSortedColumnStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x0600332D RID: 13101 RVA: 0x000D8650 File Offset: 0x000D6850
		// (set) Token: 0x0600332E RID: 13102 RVA: 0x00014A64 File Offset: 0x00012C64
		public unsafe bool m_SortingUpdatesTemporarilyDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortingUpdatesTemporarilyDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_SortingUpdatesTemporarilyDisabled)) = value;
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x000D8678 File Offset: 0x000D6878
		// (set) Token: 0x06003330 RID: 13104 RVA: 0x00014A7F File Offset: 0x00012C7F
		public unsafe MultiColumnCollectionHeader.ViewState m_ViewState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_ViewState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiColumnCollectionHeader.ViewState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_ViewState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06003331 RID: 13105 RVA: 0x000D86A8 File Offset: 0x000D68A8
		// (set) Token: 0x06003332 RID: 13106 RVA: 0x00014A9E File Offset: 0x00012C9E
		public unsafe bool m_ApplyingViewState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_ApplyingViewState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_ApplyingViewState)) = value;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06003333 RID: 13107 RVA: 0x000D86D0 File Offset: 0x000D68D0
		// (set) Token: 0x06003334 RID: 13108 RVA: 0x00014AB9 File Offset: 0x00012CB9
		public unsafe bool m_DoLayoutScheduled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_DoLayoutScheduled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_m_DoLayoutScheduled)) = value;
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x000D86F8 File Offset: 0x000D68F8
		// (set) Token: 0x06003336 RID: 13110 RVA: 0x00014AD4 File Offset: 0x00012CD4
		public unsafe Dictionary<Column, MultiColumnCollectionHeader.ColumnData> _columnDataMap_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr__columnDataMap_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Column, MultiColumnCollectionHeader.ColumnData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr__columnDataMap_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06003337 RID: 13111 RVA: 0x000D8728 File Offset: 0x000D6928
		// (set) Token: 0x06003338 RID: 13112 RVA: 0x00014AF3 File Offset: 0x00012CF3
		public unsafe ColumnLayout _columnLayout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr__columnLayout_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColumnLayout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr__columnLayout_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x000D8758 File Offset: 0x000D6958
		// (set) Token: 0x0600333A RID: 13114 RVA: 0x00014B12 File Offset: 0x00012D12
		public unsafe VisualElement _columnContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr__columnContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr__columnContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x0600333B RID: 13115 RVA: 0x000D8788 File Offset: 0x000D6988
		// (set) Token: 0x0600333C RID: 13116 RVA: 0x00014B31 File Offset: 0x00012D31
		public unsafe VisualElement _resizeHandleContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr__resizeHandleContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr__resizeHandleContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x000D87B8 File Offset: 0x000D69B8
		// (set) Token: 0x0600333E RID: 13118 RVA: 0x00014B50 File Offset: 0x00012D50
		public unsafe Columns _columns_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr__columns_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Columns>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr__columns_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x0600333F RID: 13119 RVA: 0x000D87E8 File Offset: 0x000D69E8
		// (set) Token: 0x06003340 RID: 13120 RVA: 0x00014B6F File Offset: 0x00012D6F
		public unsafe Action<int, float> columnResized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_columnResized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_columnResized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06003341 RID: 13121 RVA: 0x000D8818 File Offset: 0x000D6A18
		// (set) Token: 0x06003342 RID: 13122 RVA: 0x00014B8E File Offset: 0x00012D8E
		public unsafe Action columnSortingChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_columnSortingChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_columnSortingChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06003343 RID: 13123 RVA: 0x000D8848 File Offset: 0x000D6A48
		// (set) Token: 0x06003344 RID: 13124 RVA: 0x00014BAD File Offset: 0x00012DAD
		public unsafe Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_contextMenuPopulateEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ContextualMenuPopulateEvent, Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_contextMenuPopulateEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06003345 RID: 13125 RVA: 0x000D8878 File Offset: 0x000D6A78
		// (set) Token: 0x06003346 RID: 13126 RVA: 0x00014BCC File Offset: 0x00012DCC
		public unsafe Action viewDataRestored
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_viewDataRestored);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.NativeFieldInfoPtr_viewDataRestored), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeFieldInfoPtr_columnContainerUssClassName;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeFieldInfoPtr_handleContainerUssClassName;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeFieldInfoPtr_reorderableUssClassName;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingEnabled;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeFieldInfoPtr_m_SortedColumns;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeFieldInfoPtr_m_SortDescriptions;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeFieldInfoPtr_m_OldSortedColumnStates;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingUpdatesTemporarilyDisabled;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewState;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeFieldInfoPtr_m_ApplyingViewState;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeFieldInfoPtr_m_DoLayoutScheduled;

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeFieldInfoPtr__columnDataMap_k__BackingField;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeFieldInfoPtr__columnLayout_k__BackingField;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeFieldInfoPtr__columnContainer_k__BackingField;

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeFieldInfoPtr__resizeHandleContainer_k__BackingField;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeFieldInfoPtr__columns_k__BackingField;

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeFieldInfoPtr_columnResized;

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeFieldInfoPtr_columnSortingChanged;

		// Token: 0x04002569 RID: 9577
		private static readonly IntPtr NativeFieldInfoPtr_contextMenuPopulateEvent;

		// Token: 0x0400256A RID: 9578
		private static readonly IntPtr NativeFieldInfoPtr_viewDataRestored;

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeMethodInfoPtr_get_isApplyingViewState_Internal_get_Boolean_0;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeMethodInfoPtr_get_columnDataMap_Public_get_Dictionary_2_Column_ColumnData_0;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeMethodInfoPtr_get_columnLayout_Public_get_ColumnLayout_0;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeMethodInfoPtr_get_columnContainer_Public_get_VisualElement_0;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeMethodInfoPtr_get_resizeHandleContainer_Public_get_VisualElement_0;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeMethodInfoPtr_get_sortedColumns_Public_get_IEnumerable_1_SortColumnDescription_0;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeMethodInfoPtr_get_sortDescriptions_Public_get_SortColumnDescriptions_0;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeMethodInfoPtr_set_sortDescriptions_FamOrAssem_set_Void_SortColumnDescriptions_0;

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeMethodInfoPtr_get_columns_Public_get_Columns_0;

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingEnabled_Public_get_Boolean_0;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeMethodInfoPtr_add_columnResized_Public_add_Void_Action_2_Int32_Single_0;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeMethodInfoPtr_remove_columnResized_Public_rem_Void_Action_2_Int32_Single_0;

		// Token: 0x04002578 RID: 9592
		private static readonly IntPtr NativeMethodInfoPtr_add_columnSortingChanged_Public_add_Void_Action_0;

		// Token: 0x04002579 RID: 9593
		private static readonly IntPtr NativeMethodInfoPtr_remove_columnSortingChanged_Public_rem_Void_Action_0;

		// Token: 0x0400257A RID: 9594
		private static readonly IntPtr NativeMethodInfoPtr_add_contextMenuPopulateEvent_Public_add_Void_Action_2_ContextualMenuPopulateEvent_Column_0;

		// Token: 0x0400257B RID: 9595
		private static readonly IntPtr NativeMethodInfoPtr_remove_contextMenuPopulateEvent_Public_rem_Void_Action_2_ContextualMenuPopulateEvent_Column_0;

		// Token: 0x0400257C RID: 9596
		private static readonly IntPtr NativeMethodInfoPtr_add_viewDataRestored_Internal_add_Void_Action_0;

		// Token: 0x0400257D RID: 9597
		private static readonly IntPtr NativeMethodInfoPtr_remove_viewDataRestored_Internal_rem_Void_Action_0;

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleDoLayout_Private_Void_0;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeMethodInfoPtr_ResizeToFit_Private_Void_0;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSortedColumns_Private_Void_0;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColumnControls_Private_Void_0;

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_Int32_0;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_0;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnRemoved_Private_Void_Column_0;

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnReordered_Private_Void_Column_Int32_Int32_0;

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeMethodInfoPtr_OnContextualMenuManipulator_Private_Void_ContextualMenuPopulateEvent_0;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeMethodInfoPtr_OnMoveManipulatorActivated_Private_Void_ColumnMover_0;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeMethodInfoPtr_DoLayout_Private_Void_0;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnControlGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnClicked_Private_Void_EventBase_0;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSortColumnDescriptionsOnClick_Private_Void_Column_EventModifiers_0;

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeMethodInfoPtr_ScrollHorizontally_Public_Void_Single_0;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeMethodInfoPtr_RaiseColumnResized_Private_Void_Int32_0;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeMethodInfoPtr_RaiseColumnSortingChanged_Private_Void_0;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColumnSorting_Private_Void_0;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSortingStatus_Private_Void_0;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeMethodInfoPtr_SaveViewState_Private_Void_0;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeMethodInfoPtr_CleanupColumnData_Private_Void_ColumnData_0;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeMethodInfoPtr__OnContextualMenuManipulator_b__65_0_Private_Void_DropdownMenuAction_0;

		// Token: 0x0400259A RID: 9626
		public const int kMaxStableLayoutPassCount = 2;

		// Token: 0x02000575 RID: 1397
		[Serializable]
		public class ViewState : Object
		{
			// Token: 0x06004272 RID: 17010 RVA: 0x00104B9C File Offset: 0x00102D9C
			// Note: this type is marked as 'beforefieldinit'.
			static ViewState()
			{
				Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "ViewState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState>.NativeClassPtr);
				MultiColumnCollectionHeader.ViewState.NativeFieldInfoPtr_m_HasPersistedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState>.NativeClassPtr, "m_HasPersistedData");
				MultiColumnCollectionHeader.ViewState.NativeFieldInfoPtr_m_SortDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState>.NativeClassPtr, "m_SortDescriptions");
				MultiColumnCollectionHeader.ViewState.NativeFieldInfoPtr_m_OrderedColumnStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState>.NativeClassPtr, "m_OrderedColumnStates");
				MultiColumnCollectionHeader.ViewState.NativeMethodInfoPtr_Save_Internal_Void_MultiColumnCollectionHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState>.NativeClassPtr, 100670731);
				MultiColumnCollectionHeader.ViewState.NativeMethodInfoPtr_Apply_Internal_Void_MultiColumnCollectionHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState>.NativeClassPtr, 100670732);
				MultiColumnCollectionHeader.ViewState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState>.NativeClassPtr, 100670733);
			}

			// Token: 0x06004273 RID: 17011 RVA: 0x00104C40 File Offset: 0x00102E40
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 360615, RefRangeEnd = 360622, XrefRangeStart = 360567, XrefRangeEnd = 360615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Save(MultiColumnCollectionHeader header)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(header);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.ViewState.NativeMethodInfoPtr_Save_Internal_Void_MultiColumnCollectionHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004274 RID: 17012 RVA: 0x00104C84 File Offset: 0x00102E84
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 360661, RefRangeEnd = 360662, XrefRangeStart = 360622, XrefRangeEnd = 360661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Apply(MultiColumnCollectionHeader header)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(header);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.ViewState.NativeMethodInfoPtr_Apply_Internal_Void_MultiColumnCollectionHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004275 RID: 17013 RVA: 0x00104CC8 File Offset: 0x00102EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360662, XrefRangeEnd = 360695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ViewState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.ViewState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004276 RID: 17014 RVA: 0x0001C5EA File Offset: 0x0001A7EA
			public ViewState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013E7 RID: 5095
			// (get) Token: 0x06004277 RID: 17015 RVA: 0x00104D04 File Offset: 0x00102F04
			// (set) Token: 0x06004278 RID: 17016 RVA: 0x0001C5F3 File Offset: 0x0001A7F3
			public unsafe bool m_HasPersistedData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.NativeFieldInfoPtr_m_HasPersistedData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.NativeFieldInfoPtr_m_HasPersistedData)) = value;
				}
			}

			// Token: 0x170013E8 RID: 5096
			// (get) Token: 0x06004279 RID: 17017 RVA: 0x00104D2C File Offset: 0x00102F2C
			// (set) Token: 0x0600427A RID: 17018 RVA: 0x0001C60E File Offset: 0x0001A80E
			public unsafe List<SortColumnDescription> m_SortDescriptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.NativeFieldInfoPtr_m_SortDescriptions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SortColumnDescription>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.NativeFieldInfoPtr_m_SortDescriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E9 RID: 5097
			// (get) Token: 0x0600427B RID: 17019 RVA: 0x00104D5C File Offset: 0x00102F5C
			// (set) Token: 0x0600427C RID: 17020 RVA: 0x0001C62D File Offset: 0x0001A82D
			public unsafe List<MultiColumnCollectionHeader.ViewState.ColumnState> m_OrderedColumnStates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.NativeFieldInfoPtr_m_OrderedColumnStates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MultiColumnCollectionHeader.ViewState.ColumnState>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.NativeFieldInfoPtr_m_OrderedColumnStates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E93 RID: 11923
			private static readonly IntPtr NativeFieldInfoPtr_m_HasPersistedData;

			// Token: 0x04002E94 RID: 11924
			private static readonly IntPtr NativeFieldInfoPtr_m_SortDescriptions;

			// Token: 0x04002E95 RID: 11925
			private static readonly IntPtr NativeFieldInfoPtr_m_OrderedColumnStates;

			// Token: 0x04002E96 RID: 11926
			private static readonly IntPtr NativeMethodInfoPtr_Save_Internal_Void_MultiColumnCollectionHeader_0;

			// Token: 0x04002E97 RID: 11927
			private static readonly IntPtr NativeMethodInfoPtr_Apply_Internal_Void_MultiColumnCollectionHeader_0;

			// Token: 0x04002E98 RID: 11928
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x020005A0 RID: 1440
			[Serializable]
			public sealed class ColumnState : ValueType
			{
				// Token: 0x06004307 RID: 17159 RVA: 0x00106804 File Offset: 0x00104A04
				// Note: this type is marked as 'beforefieldinit'.
				static ColumnState()
				{
					Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState.ColumnState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState>.NativeClassPtr, "ColumnState");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState.ColumnState>.NativeClassPtr);
					MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState.ColumnState>.NativeClassPtr, "index");
					MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState.ColumnState>.NativeClassPtr, "name");
					MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_actualWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState.ColumnState>.NativeClassPtr, "actualWidth");
					MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState.ColumnState>.NativeClassPtr, "width");
					MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState.ColumnState>.NativeClassPtr, "visible");
				}

				// Token: 0x06004308 RID: 17160 RVA: 0x0001CA47 File Offset: 0x0001AC47
				public ColumnState(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06004309 RID: 17161 RVA: 0x0001CA50 File Offset: 0x0001AC50
				public ColumnState()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnCollectionHeader.ViewState.ColumnState>.NativeClassPtr))
				{
				}

				// Token: 0x1700140A RID: 5130
				// (get) Token: 0x0600430A RID: 17162 RVA: 0x00106894 File Offset: 0x00104A94
				// (set) Token: 0x0600430B RID: 17163 RVA: 0x0001CA62 File Offset: 0x0001AC62
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x1700140B RID: 5131
				// (get) Token: 0x0600430C RID: 17164 RVA: 0x001068BC File Offset: 0x00104ABC
				// (set) Token: 0x0600430D RID: 17165 RVA: 0x0001CA7D File Offset: 0x0001AC7D
				public unsafe string name
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_name);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700140C RID: 5132
				// (get) Token: 0x0600430E RID: 17166 RVA: 0x001068E4 File Offset: 0x00104AE4
				// (set) Token: 0x0600430F RID: 17167 RVA: 0x0001CA9C File Offset: 0x0001AC9C
				public unsafe float actualWidth
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_actualWidth);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_actualWidth)) = value;
					}
				}

				// Token: 0x1700140D RID: 5133
				// (get) Token: 0x06004310 RID: 17168 RVA: 0x0010690C File Offset: 0x00104B0C
				// (set) Token: 0x06004311 RID: 17169 RVA: 0x0001CAB7 File Offset: 0x0001ACB7
				public unsafe Length width
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_width);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_width)) = value;
					}
				}

				// Token: 0x1700140E RID: 5134
				// (get) Token: 0x06004312 RID: 17170 RVA: 0x00106934 File Offset: 0x00104B34
				// (set) Token: 0x06004313 RID: 17171 RVA: 0x0001CAD2 File Offset: 0x0001ACD2
				public unsafe bool visible
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_visible);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ViewState.ColumnState.NativeFieldInfoPtr_visible)) = value;
					}
				}

				// Token: 0x04002EDE RID: 11998
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x04002EDF RID: 11999
				private static readonly IntPtr NativeFieldInfoPtr_name;

				// Token: 0x04002EE0 RID: 12000
				private static readonly IntPtr NativeFieldInfoPtr_actualWidth;

				// Token: 0x04002EE1 RID: 12001
				private static readonly IntPtr NativeFieldInfoPtr_width;

				// Token: 0x04002EE2 RID: 12002
				private static readonly IntPtr NativeFieldInfoPtr_visible;
			}
		}

		// Token: 0x02000576 RID: 1398
		public class ColumnData : Object
		{
			// Token: 0x0600427D RID: 17021 RVA: 0x00104D8C File Offset: 0x00102F8C
			// Note: this type is marked as 'beforefieldinit'.
			static ColumnData()
			{
				Il2CppClassPointerStore<MultiColumnCollectionHeader.ColumnData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "ColumnData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnCollectionHeader.ColumnData>.NativeClassPtr);
				MultiColumnCollectionHeader.ColumnData.NativeFieldInfoPtr__control_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.ColumnData>.NativeClassPtr, "<control>k__BackingField");
				MultiColumnCollectionHeader.ColumnData.NativeFieldInfoPtr__resizeHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.ColumnData>.NativeClassPtr, "<resizeHandle>k__BackingField");
				MultiColumnCollectionHeader.ColumnData.NativeMethodInfoPtr_get_control_Public_get_MultiColumnHeaderColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.ColumnData>.NativeClassPtr, 100670734);
				MultiColumnCollectionHeader.ColumnData.NativeMethodInfoPtr_set_control_Public_set_Void_MultiColumnHeaderColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.ColumnData>.NativeClassPtr, 100670735);
				MultiColumnCollectionHeader.ColumnData.NativeMethodInfoPtr_get_resizeHandle_Public_get_MultiColumnHeaderColumnResizeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.ColumnData>.NativeClassPtr, 100670736);
				MultiColumnCollectionHeader.ColumnData.NativeMethodInfoPtr_set_resizeHandle_Public_set_Void_MultiColumnHeaderColumnResizeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.ColumnData>.NativeClassPtr, 100670737);
				MultiColumnCollectionHeader.ColumnData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.ColumnData>.NativeClassPtr, 100670738);
			}

			// Token: 0x170013EC RID: 5100
			// (get) Token: 0x0600427E RID: 17022 RVA: 0x00104E44 File Offset: 0x00103044
			// (set) Token: 0x0600427F RID: 17023 RVA: 0x00104E84 File Offset: 0x00103084
			public unsafe MultiColumnHeaderColumn control
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.ColumnData.NativeMethodInfoPtr_get_control_Public_get_MultiColumnHeaderColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultiColumnHeaderColumn>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.ColumnData.NativeMethodInfoPtr_set_control_Public_set_Void_MultiColumnHeaderColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170013ED RID: 5101
			// (get) Token: 0x06004280 RID: 17024 RVA: 0x00104EC8 File Offset: 0x001030C8
			// (set) Token: 0x06004281 RID: 17025 RVA: 0x00104F08 File Offset: 0x00103108
			public unsafe MultiColumnHeaderColumnResizeHandle resizeHandle
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.ColumnData.NativeMethodInfoPtr_get_resizeHandle_Public_get_MultiColumnHeaderColumnResizeHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultiColumnHeaderColumnResizeHandle>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.ColumnData.NativeMethodInfoPtr_set_resizeHandle_Public_set_Void_MultiColumnHeaderColumnResizeHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004282 RID: 17026 RVA: 0x00104F4C File Offset: 0x0010314C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColumnData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnCollectionHeader.ColumnData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.ColumnData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004283 RID: 17027 RVA: 0x0001C64C File Offset: 0x0001A84C
			public ColumnData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013EA RID: 5098
			// (get) Token: 0x06004284 RID: 17028 RVA: 0x00104F88 File Offset: 0x00103188
			// (set) Token: 0x06004285 RID: 17029 RVA: 0x0001C655 File Offset: 0x0001A855
			public unsafe MultiColumnHeaderColumn _control_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ColumnData.NativeFieldInfoPtr__control_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiColumnHeaderColumn>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ColumnData.NativeFieldInfoPtr__control_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013EB RID: 5099
			// (get) Token: 0x06004286 RID: 17030 RVA: 0x00104FB8 File Offset: 0x001031B8
			// (set) Token: 0x06004287 RID: 17031 RVA: 0x0001C674 File Offset: 0x0001A874
			public unsafe MultiColumnHeaderColumnResizeHandle _resizeHandle_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ColumnData.NativeFieldInfoPtr__resizeHandle_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiColumnHeaderColumnResizeHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.ColumnData.NativeFieldInfoPtr__resizeHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E99 RID: 11929
			private static readonly IntPtr NativeFieldInfoPtr__control_k__BackingField;

			// Token: 0x04002E9A RID: 11930
			private static readonly IntPtr NativeFieldInfoPtr__resizeHandle_k__BackingField;

			// Token: 0x04002E9B RID: 11931
			private static readonly IntPtr NativeMethodInfoPtr_get_control_Public_get_MultiColumnHeaderColumn_0;

			// Token: 0x04002E9C RID: 11932
			private static readonly IntPtr NativeMethodInfoPtr_set_control_Public_set_Void_MultiColumnHeaderColumn_0;

			// Token: 0x04002E9D RID: 11933
			private static readonly IntPtr NativeMethodInfoPtr_get_resizeHandle_Public_get_MultiColumnHeaderColumnResizeHandle_0;

			// Token: 0x04002E9E RID: 11934
			private static readonly IntPtr NativeMethodInfoPtr_set_resizeHandle_Public_set_Void_MultiColumnHeaderColumnResizeHandle_0;

			// Token: 0x04002E9F RID: 11935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000577 RID: 1399
		public sealed class SortedColumnState : ValueType
		{
			// Token: 0x06004288 RID: 17032 RVA: 0x00104FE8 File Offset: 0x001031E8
			// Note: this type is marked as 'beforefieldinit'.
			static SortedColumnState()
			{
				Il2CppClassPointerStore<MultiColumnCollectionHeader.SortedColumnState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "SortedColumnState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnCollectionHeader.SortedColumnState>.NativeClassPtr);
				MultiColumnCollectionHeader.SortedColumnState.NativeFieldInfoPtr_columnDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.SortedColumnState>.NativeClassPtr, "columnDesc");
				MultiColumnCollectionHeader.SortedColumnState.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.SortedColumnState>.NativeClassPtr, "direction");
				MultiColumnCollectionHeader.SortedColumnState.NativeMethodInfoPtr__ctor_Public_Void_SortColumnDescription_SortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.SortedColumnState>.NativeClassPtr, 100670739);
			}

			// Token: 0x06004289 RID: 17033 RVA: 0x00105050 File Offset: 0x00103250
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 336243, RefRangeEnd = 336283, XrefRangeStart = 336243, XrefRangeEnd = 336283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SortedColumnState(SortColumnDescription desc, SortDirection dir)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnCollectionHeader.SortedColumnState>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.SortedColumnState.NativeMethodInfoPtr__ctor_Public_Void_SortColumnDescription_SortDirection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600428A RID: 17034 RVA: 0x0001C693 File Offset: 0x0001A893
			public SortedColumnState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600428B RID: 17035 RVA: 0x0001C69C File Offset: 0x0001A89C
			public SortedColumnState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnCollectionHeader.SortedColumnState>.NativeClassPtr))
			{
			}

			// Token: 0x170013EE RID: 5102
			// (get) Token: 0x0600428C RID: 17036 RVA: 0x001050B0 File Offset: 0x001032B0
			// (set) Token: 0x0600428D RID: 17037 RVA: 0x0001C6AE File Offset: 0x0001A8AE
			public unsafe SortColumnDescription columnDesc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.SortedColumnState.NativeFieldInfoPtr_columnDesc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortColumnDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.SortedColumnState.NativeFieldInfoPtr_columnDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013EF RID: 5103
			// (get) Token: 0x0600428E RID: 17038 RVA: 0x001050E0 File Offset: 0x001032E0
			// (set) Token: 0x0600428F RID: 17039 RVA: 0x0001C6CD File Offset: 0x0001A8CD
			public unsafe SortDirection direction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.SortedColumnState.NativeFieldInfoPtr_direction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.SortedColumnState.NativeFieldInfoPtr_direction)) = value;
				}
			}

			// Token: 0x04002EA0 RID: 11936
			private static readonly IntPtr NativeFieldInfoPtr_columnDesc;

			// Token: 0x04002EA1 RID: 11937
			private static readonly IntPtr NativeFieldInfoPtr_direction;

			// Token: 0x04002EA2 RID: 11938
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SortColumnDescription_SortDirection_0;
		}

		// Token: 0x02000578 RID: 1400
		[ObfuscatedName("UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : Object
		{
			// Token: 0x06004290 RID: 17040 RVA: 0x00105108 File Offset: 0x00103308
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass65_0>.NativeClassPtr);
				MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass65_0>.NativeClassPtr, "column");
				MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass65_0>.NativeClassPtr, "<>4__this");
				MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass65_0>.NativeClassPtr, 100670740);
				MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeMethodInfoPtr__OnContextualMenuManipulator_b__1_Internal_Void_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass65_0>.NativeClassPtr, 100670741);
				MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeMethodInfoPtr__OnContextualMenuManipulator_b__2_Internal_Status_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass65_0>.NativeClassPtr, 100670742);
			}

			// Token: 0x06004291 RID: 17041 RVA: 0x00105198 File Offset: 0x00103398
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004292 RID: 17042 RVA: 0x001051D4 File Offset: 0x001033D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360695, XrefRangeEnd = 360697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnContextualMenuManipulator_b__1(DropdownMenuAction a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeMethodInfoPtr__OnContextualMenuManipulator_b__1_Internal_Void_DropdownMenuAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004293 RID: 17043 RVA: 0x00105218 File Offset: 0x00103418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360697, XrefRangeEnd = 360699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropdownMenuAction.Status _OnContextualMenuManipulator_b__2(DropdownMenuAction a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeMethodInfoPtr__OnContextualMenuManipulator_b__2_Internal_Status_DropdownMenuAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004294 RID: 17044 RVA: 0x0001C6E8 File Offset: 0x0001A8E8
			public __c__DisplayClass65_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013F0 RID: 5104
			// (get) Token: 0x06004295 RID: 17045 RVA: 0x00105268 File Offset: 0x00103468
			// (set) Token: 0x06004296 RID: 17046 RVA: 0x0001C6F1 File Offset: 0x0001A8F1
			public unsafe Column column
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeFieldInfoPtr_column);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Column>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeFieldInfoPtr_column), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F1 RID: 5105
			// (get) Token: 0x06004297 RID: 17047 RVA: 0x00105298 File Offset: 0x00103498
			// (set) Token: 0x06004298 RID: 17048 RVA: 0x0001C710 File Offset: 0x0001A910
			public unsafe MultiColumnCollectionHeader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiColumnCollectionHeader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002EA3 RID: 11939
			private static readonly IntPtr NativeFieldInfoPtr_column;

			// Token: 0x04002EA4 RID: 11940
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002EA5 RID: 11941
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002EA6 RID: 11942
			private static readonly IntPtr NativeMethodInfoPtr__OnContextualMenuManipulator_b__1_Internal_Void_DropdownMenuAction_0;

			// Token: 0x04002EA7 RID: 11943
			private static readonly IntPtr NativeMethodInfoPtr__OnContextualMenuManipulator_b__2_Internal_Status_DropdownMenuAction_0;
		}

		// Token: 0x02000579 RID: 1401
		[ObfuscatedName("UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+<>c__DisplayClass71_0")]
		public sealed class __c__DisplayClass71_0 : Object
		{
			// Token: 0x06004299 RID: 17049 RVA: 0x001052C8 File Offset: 0x001034C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass71_0()
			{
				Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiColumnCollectionHeader>.NativeClassPtr, "<>c__DisplayClass71_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass71_0>.NativeClassPtr);
				MultiColumnCollectionHeader.__c__DisplayClass71_0.NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass71_0>.NativeClassPtr, "column");
				MultiColumnCollectionHeader.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass71_0>.NativeClassPtr, 100670743);
				MultiColumnCollectionHeader.__c__DisplayClass71_0.NativeMethodInfoPtr__UpdateSortColumnDescriptionsOnClick_b__0_Internal_Boolean_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass71_0>.NativeClassPtr, 100670744);
			}

			// Token: 0x0600429A RID: 17050 RVA: 0x00105330 File Offset: 0x00103530
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass71_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnCollectionHeader.__c__DisplayClass71_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600429B RID: 17051 RVA: 0x0010536C File Offset: 0x0010356C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360699, XrefRangeEnd = 360702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateSortColumnDescriptionsOnClick_b__0(SortColumnDescription d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnCollectionHeader.__c__DisplayClass71_0.NativeMethodInfoPtr__UpdateSortColumnDescriptionsOnClick_b__0_Internal_Boolean_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600429C RID: 17052 RVA: 0x0001C72F File Offset: 0x0001A92F
			public __c__DisplayClass71_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013F2 RID: 5106
			// (get) Token: 0x0600429D RID: 17053 RVA: 0x001053BC File Offset: 0x001035BC
			// (set) Token: 0x0600429E RID: 17054 RVA: 0x0001C738 File Offset: 0x0001A938
			public unsafe Column column
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.__c__DisplayClass71_0.NativeFieldInfoPtr_column);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Column>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnCollectionHeader.__c__DisplayClass71_0.NativeFieldInfoPtr_column), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002EA8 RID: 11944
			private static readonly IntPtr NativeFieldInfoPtr_column;

			// Token: 0x04002EA9 RID: 11945
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002EAA RID: 11946
			private static readonly IntPtr NativeMethodInfoPtr__UpdateSortColumnDescriptionsOnClick_b__0_Internal_Boolean_SortColumnDescription_0;
		}

		// Token: 0x0200057A RID: 1402
		public sealed class <>c__DisplayClass65_0
		{
		}

		// Token: 0x0200057B RID: 1403
		public sealed class <>c__DisplayClass71_0
		{
		}
	}
}
