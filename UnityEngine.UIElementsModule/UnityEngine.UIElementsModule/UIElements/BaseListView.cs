using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003F RID: 63
	public class BaseListView : BaseVerticalCollectionView
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x0002FA44 File Offset: 0x0002DC44
		// Note: this type is marked as 'beforefieldinit'.
		static BaseListView()
		{
			Il2CppClassPointerStore<BaseListView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseListView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseListView>.NativeClassPtr);
			BaseListView.NativeFieldInfoPtr_k_SizeFieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "k_SizeFieldLabel");
			BaseListView.NativeFieldInfoPtr_m_ShowBoundCollectionSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_ShowBoundCollectionSize");
			BaseListView.NativeFieldInfoPtr_m_ShowFoldoutHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_ShowFoldoutHeader");
			BaseListView.NativeFieldInfoPtr_m_HeaderTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_HeaderTitle");
			BaseListView.NativeFieldInfoPtr_itemsAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "itemsAdded");
			BaseListView.NativeFieldInfoPtr_itemsRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "itemsRemoved");
			BaseListView.NativeFieldInfoPtr_itemsSourceSizeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "itemsSourceSizeChanged");
			BaseListView.NativeFieldInfoPtr_m_ListViewLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_ListViewLabel");
			BaseListView.NativeFieldInfoPtr_m_Foldout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_Foldout");
			BaseListView.NativeFieldInfoPtr_m_ArraySizeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_ArraySizeField");
			BaseListView.NativeFieldInfoPtr_m_IsOverMultiEditLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_IsOverMultiEditLimit");
			BaseListView.NativeFieldInfoPtr_m_Footer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_Footer");
			BaseListView.NativeFieldInfoPtr_m_AddButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_AddButton");
			BaseListView.NativeFieldInfoPtr_m_RemoveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_RemoveButton");
			BaseListView.NativeFieldInfoPtr_m_ItemAddedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_ItemAddedCallback");
			BaseListView.NativeFieldInfoPtr_m_ItemRemovedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_ItemRemovedCallback");
			BaseListView.NativeFieldInfoPtr_m_ItemsSourceSizeChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_ItemsSourceSizeChangedCallback");
			BaseListView.NativeFieldInfoPtr_m_ReorderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_ReorderMode");
			BaseListView.NativeFieldInfoPtr_reorderModeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "reorderModeChanged");
			BaseListView.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "ussClassName");
			BaseListView.NativeFieldInfoPtr_itemUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "itemUssClassName");
			BaseListView.NativeFieldInfoPtr_emptyLabelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "emptyLabelUssClassName");
			BaseListView.NativeFieldInfoPtr_overMaxMultiEditLimitClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "overMaxMultiEditLimitClassName");
			BaseListView.NativeFieldInfoPtr_reorderableUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "reorderableUssClassName");
			BaseListView.NativeFieldInfoPtr_reorderableItemUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "reorderableItemUssClassName");
			BaseListView.NativeFieldInfoPtr_reorderableItemContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "reorderableItemContainerUssClassName");
			BaseListView.NativeFieldInfoPtr_reorderableItemHandleUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "reorderableItemHandleUssClassName");
			BaseListView.NativeFieldInfoPtr_reorderableItemHandleBarUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "reorderableItemHandleBarUssClassName");
			BaseListView.NativeFieldInfoPtr_footerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "footerUssClassName");
			BaseListView.NativeFieldInfoPtr_foldoutHeaderUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "foldoutHeaderUssClassName");
			BaseListView.NativeFieldInfoPtr_arraySizeFieldUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "arraySizeFieldUssClassName");
			BaseListView.NativeFieldInfoPtr_arraySizeFieldWithHeaderUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "arraySizeFieldWithHeaderUssClassName");
			BaseListView.NativeFieldInfoPtr_arraySizeFieldWithFooterUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "arraySizeFieldWithFooterUssClassName");
			BaseListView.NativeFieldInfoPtr_listViewWithHeaderUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "listViewWithHeaderUssClassName");
			BaseListView.NativeFieldInfoPtr_listViewWithFooterUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "listViewWithFooterUssClassName");
			BaseListView.NativeFieldInfoPtr_scrollViewWithFooterUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "scrollViewWithFooterUssClassName");
			BaseListView.NativeFieldInfoPtr_footerAddButtonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "footerAddButtonName");
			BaseListView.NativeFieldInfoPtr_footerRemoveButtonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "footerRemoveButtonName");
			BaseListView.NativeFieldInfoPtr_m_MaxMultiEditStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "m_MaxMultiEditStr");
			BaseListView.NativeFieldInfoPtr_k_EmptyListStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "k_EmptyListStr");
			BaseListView.NativeMethodInfoPtr_get_showBoundCollectionSize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664006);
			BaseListView.NativeMethodInfoPtr_set_showBoundCollectionSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664007);
			BaseListView.NativeMethodInfoPtr_get_showFoldoutHeader_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664008);
			BaseListView.NativeMethodInfoPtr_set_showFoldoutHeader_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664009);
			BaseListView.NativeMethodInfoPtr_SetupArraySizeField_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664010);
			BaseListView.NativeMethodInfoPtr_set_headerTitle_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664011);
			BaseListView.NativeMethodInfoPtr_get_showAddRemoveFooter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664012);
			BaseListView.NativeMethodInfoPtr_set_showAddRemoveFooter_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664013);
			BaseListView.NativeMethodInfoPtr_EnableFooter_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664014);
			BaseListView.NativeMethodInfoPtr_AddItems_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664015);
			BaseListView.NativeMethodInfoPtr_OnArraySizeFieldChanged_Private_Void_ChangeEvent_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664016);
			BaseListView.NativeMethodInfoPtr_UpdateArraySizeField_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664017);
			BaseListView.NativeMethodInfoPtr_UpdateListViewLabel_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664018);
			BaseListView.NativeMethodInfoPtr_OnAddClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664019);
			BaseListView.NativeMethodInfoPtr_OnRemoveClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664020);
			BaseListView.NativeMethodInfoPtr_get_footer_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664021);
			BaseListView.NativeMethodInfoPtr_get_viewController_Public_get_BaseListViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664022);
			BaseListView.NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664023);
			BaseListView.NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664024);
			BaseListView.NativeMethodInfoPtr_OnItemAdded_Private_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664025);
			BaseListView.NativeMethodInfoPtr_OnItemsRemoved_Private_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664026);
			BaseListView.NativeMethodInfoPtr_OnItemsSourceSizeChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664027);
			BaseListView.NativeMethodInfoPtr_add_reorderModeChanged_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664028);
			BaseListView.NativeMethodInfoPtr_remove_reorderModeChanged_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664029);
			BaseListView.NativeMethodInfoPtr_get_reorderMode_Public_get_ListViewReorderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664030);
			BaseListView.NativeMethodInfoPtr_set_reorderMode_Public_set_Void_ListViewReorderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664031);
			BaseListView.NativeMethodInfoPtr_CreateDragger_Internal_Virtual_ListViewDragger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664032);
			BaseListView.NativeMethodInfoPtr_CreateDragAndDropController_Internal_Virtual_ICollectionDragAndDropController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664033);
			BaseListView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664034);
			BaseListView.NativeMethodInfoPtr_PostRefresh_FamAndAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664035);
			BaseListView.NativeMethodInfoPtr_HandleItemNavigation_FamAndAssem_Virtual_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664036);
			BaseListView.NativeMethodInfoPtr__OnAddClicked_b__38_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, 100664038);
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00030014 File Offset: 0x0002E214
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00030050 File Offset: 0x0002E250
		public unsafe bool showBoundCollectionSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_get_showBoundCollectionSize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288702, RefRangeEnd = 288703, XrefRangeStart = 288701, XrefRangeEnd = 288702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_set_showBoundCollectionSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00030090 File Offset: 0x0002E290
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x000300CC File Offset: 0x0002E2CC
		public unsafe bool showFoldoutHeader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_get_showFoldoutHeader_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288729, RefRangeEnd = 288730, XrefRangeStart = 288703, XrefRangeEnd = 288729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_set_showFoldoutHeader_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0003010C File Offset: 0x0002E30C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288740, RefRangeEnd = 288742, XrefRangeStart = 288730, XrefRangeEnd = 288740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupArraySizeField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_SetupArraySizeField_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00003B2F File Offset: 0x00001D2F
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00030140 File Offset: 0x0002E340
		public unsafe string headerTitle
		{
			get
			{
				return this.m_HeaderTitle;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288744, RefRangeEnd = 288745, XrefRangeStart = 288742, XrefRangeEnd = 288744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_set_headerTitle_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00030184 File Offset: 0x0002E384
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x000301C0 File Offset: 0x0002E3C0
		public unsafe bool showAddRemoveFooter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_get_showAddRemoveFooter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288746, RefRangeEnd = 288747, XrefRangeStart = 288745, XrefRangeEnd = 288746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_set_showAddRemoveFooter_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00030200 File Offset: 0x0002E400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288771, RefRangeEnd = 288773, XrefRangeStart = 288747, XrefRangeEnd = 288771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableFooter(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_EnableFooter_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00030240 File Offset: 0x0002E440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288773, XrefRangeEnd = 288775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItems(int itemCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref itemCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_AddItems_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00030280 File Offset: 0x0002E480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288775, XrefRangeEnd = 288792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnArraySizeFieldChanged(ChangeEvent<string> evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_OnArraySizeFieldChanged_Private_Void_ChangeEvent_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000302C4 File Offset: 0x0002E4C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288796, RefRangeEnd = 288797, XrefRangeStart = 288792, XrefRangeEnd = 288796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateArraySizeField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_UpdateArraySizeField_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000302F8 File Offset: 0x0002E4F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288827, RefRangeEnd = 288830, XrefRangeStart = 288797, XrefRangeEnd = 288827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateListViewLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_UpdateListViewLabel_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0003032C File Offset: 0x0002E52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288830, XrefRangeEnd = 288854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAddClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_OnAddClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00030360 File Offset: 0x0002E560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288854, XrefRangeEnd = 288876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRemoveClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_OnRemoveClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00030394 File Offset: 0x0002E594
		public unsafe VisualElement footer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_get_footer_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x000303D4 File Offset: 0x0002E5D4
		public new unsafe BaseListViewController viewController
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 288877, RefRangeEnd = 288897, XrefRangeStart = 288876, XrefRangeEnd = 288877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_get_viewController_Public_get_BaseListViewController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseListViewController>(intPtr3) : null;
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00030414 File Offset: 0x0002E614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288897, XrefRangeEnd = 288900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateVirtualizationController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListView.NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00030450 File Offset: 0x0002E650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288957, RefRangeEnd = 288958, XrefRangeStart = 288900, XrefRangeEnd = 288957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetViewController(CollectionViewController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListView.NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000304A0 File Offset: 0x0002E6A0
		[CallerCount(0)]
		public unsafe void OnItemAdded(IEnumerable<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_OnItemAdded_Private_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000304E4 File Offset: 0x0002E6E4
		[CallerCount(0)]
		public unsafe void OnItemsRemoved(IEnumerable<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_OnItemsRemoved_Private_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00030528 File Offset: 0x0002E728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288958, XrefRangeEnd = 288963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnItemsSourceSizeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_OnItemsSourceSizeChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0003055C File Offset: 0x0002E75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288963, XrefRangeEnd = 288967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_reorderModeChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_add_reorderModeChanged_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000305A0 File Offset: 0x0002E7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288967, XrefRangeEnd = 288971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_reorderModeChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_remove_reorderModeChanged_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x000305E4 File Offset: 0x0002E7E4
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00030620 File Offset: 0x0002E820
		public unsafe ListViewReorderMode reorderMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_get_reorderMode_Public_get_ListViewReorderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288974, RefRangeEnd = 288975, XrefRangeStart = 288971, XrefRangeEnd = 288974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr_set_reorderMode_Public_set_Void_ListViewReorderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00030660 File Offset: 0x0002E860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288975, XrefRangeEnd = 288980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ListViewDragger CreateDragger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListView.NativeMethodInfoPtr_CreateDragger_Internal_Virtual_ListViewDragger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ListViewDragger>(intPtr3) : null;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000306AC File Offset: 0x0002E8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288980, XrefRangeEnd = 288984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICollectionDragAndDropController CreateDragAndDropController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListView.NativeMethodInfoPtr_CreateDragAndDropController_Internal_Virtual_ICollectionDragAndDropController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollectionDragAndDropController>(intPtr3) : null;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000306F8 File Offset: 0x0002E8F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288994, RefRangeEnd = 288996, XrefRangeStart = 288984, XrefRangeEnd = 288994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseListView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseListView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00030734 File Offset: 0x0002E934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288996, XrefRangeEnd = 288999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListView.NativeMethodInfoPtr_PostRefresh_FamAndAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00030770 File Offset: 0x0002E970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288999, XrefRangeEnd = 289043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HandleItemNavigation(bool moveIn, bool altPressed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveIn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref altPressed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListView.NativeMethodInfoPtr_HandleItemNavigation_FamAndAssem_Virtual_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000307D4 File Offset: 0x0002E9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289043, XrefRangeEnd = 289050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnAddClicked_b__38_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.NativeMethodInfoPtr__OnAddClicked_b__38_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000376F File Offset: 0x0000196F
		public BaseListView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00030808 File Offset: 0x0002EA08
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00003778 File Offset: 0x00001978
		public unsafe static string k_SizeFieldLabel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_k_SizeFieldLabel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_k_SizeFieldLabel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00030828 File Offset: 0x0002EA28
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x0000378A File Offset: 0x0000198A
		public unsafe bool m_ShowBoundCollectionSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ShowBoundCollectionSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ShowBoundCollectionSize)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00030850 File Offset: 0x0002EA50
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x000037A5 File Offset: 0x000019A5
		public unsafe bool m_ShowFoldoutHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ShowFoldoutHeader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ShowFoldoutHeader)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00030878 File Offset: 0x0002EA78
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x000037C0 File Offset: 0x000019C0
		public unsafe string m_HeaderTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_HeaderTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_HeaderTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x000308A0 File Offset: 0x0002EAA0
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x000037DF File Offset: 0x000019DF
		public unsafe Action<IEnumerable<int>> itemsAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_itemsAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_itemsAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x000308D0 File Offset: 0x0002EAD0
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x000037FE File Offset: 0x000019FE
		public unsafe Action<IEnumerable<int>> itemsRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_itemsRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_itemsRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00030900 File Offset: 0x0002EB00
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x0000381D File Offset: 0x00001A1D
		public unsafe Action itemsSourceSizeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_itemsSourceSizeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_itemsSourceSizeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00030930 File Offset: 0x0002EB30
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0000383C File Offset: 0x00001A3C
		public unsafe Label m_ListViewLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ListViewLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Label>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ListViewLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00030960 File Offset: 0x0002EB60
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x0000385B File Offset: 0x00001A5B
		public unsafe Foldout m_Foldout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_Foldout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Foldout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_Foldout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00030990 File Offset: 0x0002EB90
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0000387A File Offset: 0x00001A7A
		public unsafe TextField m_ArraySizeField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ArraySizeField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ArraySizeField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x000309C0 File Offset: 0x0002EBC0
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00003899 File Offset: 0x00001A99
		public unsafe bool m_IsOverMultiEditLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_IsOverMultiEditLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_IsOverMultiEditLimit)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x000309E8 File Offset: 0x0002EBE8
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x000038B4 File Offset: 0x00001AB4
		public unsafe VisualElement m_Footer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_Footer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_Footer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00030A18 File Offset: 0x0002EC18
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x000038D3 File Offset: 0x00001AD3
		public unsafe Button m_AddButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_AddButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_AddButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00030A48 File Offset: 0x0002EC48
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x000038F2 File Offset: 0x00001AF2
		public unsafe Button m_RemoveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_RemoveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_RemoveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00030A78 File Offset: 0x0002EC78
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00003911 File Offset: 0x00001B11
		public unsafe Action<IEnumerable<int>> m_ItemAddedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ItemAddedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ItemAddedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00030AA8 File Offset: 0x0002ECA8
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00003930 File Offset: 0x00001B30
		public unsafe Action<IEnumerable<int>> m_ItemRemovedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ItemRemovedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ItemRemovedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00030AD8 File Offset: 0x0002ECD8
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0000394F File Offset: 0x00001B4F
		public unsafe Action m_ItemsSourceSizeChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ItemsSourceSizeChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ItemsSourceSizeChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00030B08 File Offset: 0x0002ED08
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x0000396E File Offset: 0x00001B6E
		public unsafe ListViewReorderMode m_ReorderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ReorderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_ReorderMode)) = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00030B30 File Offset: 0x0002ED30
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00003989 File Offset: 0x00001B89
		public unsafe Action reorderModeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_reorderModeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_reorderModeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00030B60 File Offset: 0x0002ED60
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x000039A8 File Offset: 0x00001BA8
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00030B80 File Offset: 0x0002ED80
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000039BA File Offset: 0x00001BBA
		public new unsafe static string itemUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_itemUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_itemUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00030BA0 File Offset: 0x0002EDA0
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x000039CC File Offset: 0x00001BCC
		public unsafe static string emptyLabelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_emptyLabelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_emptyLabelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00030BC0 File Offset: 0x0002EDC0
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x000039DE File Offset: 0x00001BDE
		public unsafe static string overMaxMultiEditLimitClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_overMaxMultiEditLimitClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_overMaxMultiEditLimitClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00030BE0 File Offset: 0x0002EDE0
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x000039F0 File Offset: 0x00001BF0
		public unsafe static string reorderableUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_reorderableUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_reorderableUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00030C00 File Offset: 0x0002EE00
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00003A02 File Offset: 0x00001C02
		public unsafe static string reorderableItemUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_reorderableItemUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_reorderableItemUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00030C20 File Offset: 0x0002EE20
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00003A14 File Offset: 0x00001C14
		public unsafe static string reorderableItemContainerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_reorderableItemContainerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_reorderableItemContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00030C40 File Offset: 0x0002EE40
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00003A26 File Offset: 0x00001C26
		public unsafe static string reorderableItemHandleUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_reorderableItemHandleUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_reorderableItemHandleUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00030C60 File Offset: 0x0002EE60
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00003A38 File Offset: 0x00001C38
		public unsafe static string reorderableItemHandleBarUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_reorderableItemHandleBarUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_reorderableItemHandleBarUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00030C80 File Offset: 0x0002EE80
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00003A4A File Offset: 0x00001C4A
		public unsafe static string footerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_footerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_footerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00030CA0 File Offset: 0x0002EEA0
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00003A5C File Offset: 0x00001C5C
		public unsafe static string foldoutHeaderUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_foldoutHeaderUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_foldoutHeaderUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00030CC0 File Offset: 0x0002EEC0
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00003A6E File Offset: 0x00001C6E
		public unsafe static string arraySizeFieldUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_arraySizeFieldUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_arraySizeFieldUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00030CE0 File Offset: 0x0002EEE0
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00003A80 File Offset: 0x00001C80
		public unsafe static string arraySizeFieldWithHeaderUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_arraySizeFieldWithHeaderUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_arraySizeFieldWithHeaderUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00030D00 File Offset: 0x0002EF00
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00003A92 File Offset: 0x00001C92
		public unsafe static string arraySizeFieldWithFooterUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_arraySizeFieldWithFooterUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_arraySizeFieldWithFooterUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00030D20 File Offset: 0x0002EF20
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00003AA4 File Offset: 0x00001CA4
		public unsafe static string listViewWithHeaderUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_listViewWithHeaderUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_listViewWithHeaderUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00030D40 File Offset: 0x0002EF40
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00003AB6 File Offset: 0x00001CB6
		public unsafe static string listViewWithFooterUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_listViewWithFooterUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_listViewWithFooterUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00030D60 File Offset: 0x0002EF60
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00003AC8 File Offset: 0x00001CC8
		public unsafe static string scrollViewWithFooterUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_scrollViewWithFooterUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_scrollViewWithFooterUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00030D80 File Offset: 0x0002EF80
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00003ADA File Offset: 0x00001CDA
		public unsafe static string footerAddButtonName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_footerAddButtonName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_footerAddButtonName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00030DA0 File Offset: 0x0002EFA0
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00003AEC File Offset: 0x00001CEC
		public unsafe static string footerRemoveButtonName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_footerRemoveButtonName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_footerRemoveButtonName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00030DC0 File Offset: 0x0002EFC0
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00003AFE File Offset: 0x00001CFE
		public unsafe string m_MaxMultiEditStr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_MaxMultiEditStr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.NativeFieldInfoPtr_m_MaxMultiEditStr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00030DE8 File Offset: 0x0002EFE8
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00003B1D File Offset: 0x00001D1D
		public unsafe static string k_EmptyListStr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseListView.NativeFieldInfoPtr_k_EmptyListStr, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseListView.NativeFieldInfoPtr_k_EmptyListStr, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00003B37 File Offset: 0x00001D37
		public Foldout headerFoldout
		{
			get
			{
				return this.m_Foldout;
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00003B3F File Offset: 0x00001D3F
		public void add_itemsAdded(Action<IEnumerable<int>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00003B4C File Offset: 0x00001D4C
		public void remove_itemsAdded(Action<IEnumerable<int>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00003B59 File Offset: 0x00001D59
		public void add_itemsRemoved(Action<IEnumerable<int>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00003B66 File Offset: 0x00001D66
		public void remove_itemsRemoved(Action<IEnumerable<int>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00003B73 File Offset: 0x00001D73
		public void add_itemsSourceSizeChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00003B80 File Offset: 0x00001D80
		public void remove_itemsSourceSizeChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00003B8D File Offset: 0x00001D8D
		public void RemoveItems(List<int> indices)
		{
			this.viewController.RemoveItems(indices);
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00003B9D File Offset: 0x00001D9D
		public TextField arraySizeField
		{
			get
			{
				return this.m_ArraySizeField;
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00003BA5 File Offset: 0x00001DA5
		public void SetOverMaxMultiEditLimit(bool isOverLimit, int maxMultiEditCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr_k_SizeFieldLabel;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_m_ShowBoundCollectionSize;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeFieldInfoPtr_m_ShowFoldoutHeader;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeFieldInfoPtr_m_HeaderTitle;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr_itemsAdded;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_itemsRemoved;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_itemsSourceSizeChanged;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_m_ListViewLabel;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_m_Foldout;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_m_ArraySizeField;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOverMultiEditLimit;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_m_Footer;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr_m_AddButton;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr_m_RemoveButton;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemAddedCallback;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemRemovedCallback;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemsSourceSizeChangedCallback;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_m_ReorderMode;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_reorderModeChanged;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr_itemUssClassName;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_emptyLabelUssClassName;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_overMaxMultiEditLimitClassName;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_reorderableUssClassName;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_reorderableItemUssClassName;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_reorderableItemContainerUssClassName;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_reorderableItemHandleUssClassName;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_reorderableItemHandleBarUssClassName;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_footerUssClassName;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_foldoutHeaderUssClassName;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_arraySizeFieldUssClassName;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_arraySizeFieldWithHeaderUssClassName;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_arraySizeFieldWithFooterUssClassName;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_listViewWithHeaderUssClassName;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_listViewWithFooterUssClassName;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_scrollViewWithFooterUssClassName;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_footerAddButtonName;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr_footerRemoveButtonName;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxMultiEditStr;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_k_EmptyListStr;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_get_showBoundCollectionSize_Public_get_Boolean_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_set_showBoundCollectionSize_Public_set_Void_Boolean_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_get_showFoldoutHeader_Public_get_Boolean_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_set_showFoldoutHeader_Public_set_Void_Boolean_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_SetupArraySizeField_Internal_Void_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_set_headerTitle_Public_set_Void_String_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_get_showAddRemoveFooter_Public_get_Boolean_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_set_showAddRemoveFooter_Public_set_Void_Boolean_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_EnableFooter_Private_Void_Boolean_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_AddItems_Private_Void_Int32_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_OnArraySizeFieldChanged_Private_Void_ChangeEvent_1_String_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArraySizeField_Internal_Void_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_UpdateListViewLabel_Internal_Void_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_OnAddClicked_Private_Void_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_OnRemoveClicked_Private_Void_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_get_footer_Internal_get_VisualElement_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_get_viewController_Public_get_BaseListViewController_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_OnItemAdded_Private_Void_IEnumerable_1_Int32_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_OnItemsRemoved_Private_Void_IEnumerable_1_Int32_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_OnItemsSourceSizeChanged_Private_Void_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_add_reorderModeChanged_Internal_add_Void_Action_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_remove_reorderModeChanged_Internal_rem_Void_Action_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_get_reorderMode_Public_get_ListViewReorderMode_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_set_reorderMode_Public_set_Void_ListViewReorderMode_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_CreateDragger_Internal_Virtual_ListViewDragger_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_CreateDragAndDropController_Internal_Virtual_ICollectionDragAndDropController_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_PostRefresh_FamAndAssem_Virtual_Void_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_HandleItemNavigation_FamAndAssem_Virtual_Boolean_Boolean_Boolean_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr__OnAddClicked_b__38_0_Private_Void_0;

		// Token: 0x040003FC RID: 1020
		public const int k_FoldoutTabIndex = 10;

		// Token: 0x040003FD RID: 1021
		public const int k_ArraySizeFieldTabIndex = 20;

		// Token: 0x02000331 RID: 817
		public new class UxmlTraits : BaseVerticalCollectionView.UxmlTraits
		{
			// Token: 0x060035A2 RID: 13730 RVA: 0x000DE47C File Offset: 0x000DC67C
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<BaseListView.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseListView>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseListView.UxmlTraits>.NativeClassPtr);
				BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ShowFoldoutHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView.UxmlTraits>.NativeClassPtr, "m_ShowFoldoutHeader");
				BaseListView.UxmlTraits.NativeFieldInfoPtr_m_HeaderTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView.UxmlTraits>.NativeClassPtr, "m_HeaderTitle");
				BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ShowAddRemoveFooter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView.UxmlTraits>.NativeClassPtr, "m_ShowAddRemoveFooter");
				BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ReorderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView.UxmlTraits>.NativeClassPtr, "m_ReorderMode");
				BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ShowBoundCollectionSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListView.UxmlTraits>.NativeClassPtr, "m_ShowBoundCollectionSize");
				BaseListView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView.UxmlTraits>.NativeClassPtr, 100664039);
				BaseListView.UxmlTraits.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListView.UxmlTraits>.NativeClassPtr, 100664040);
			}

			// Token: 0x060035A3 RID: 13731 RVA: 0x000DE534 File Offset: 0x000DC734
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288650, RefRangeEnd = 288651, XrefRangeStart = 288640, XrefRangeEnd = 288650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035A4 RID: 13732 RVA: 0x000DE5AC File Offset: 0x000DC7AC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 288699, RefRangeEnd = 288701, XrefRangeStart = 288651, XrefRangeEnd = 288699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseListView.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListView.UxmlTraits.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035A5 RID: 13733 RVA: 0x00015D6C File Offset: 0x00013F6C
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010A5 RID: 4261
			// (get) Token: 0x060035A6 RID: 13734 RVA: 0x000DE5E8 File Offset: 0x000DC7E8
			// (set) Token: 0x060035A7 RID: 13735 RVA: 0x00015D75 File Offset: 0x00013F75
			public unsafe UxmlBoolAttributeDescription m_ShowFoldoutHeader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ShowFoldoutHeader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ShowFoldoutHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A6 RID: 4262
			// (get) Token: 0x060035A8 RID: 13736 RVA: 0x000DE618 File Offset: 0x000DC818
			// (set) Token: 0x060035A9 RID: 13737 RVA: 0x00015D94 File Offset: 0x00013F94
			public unsafe UxmlStringAttributeDescription m_HeaderTitle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.UxmlTraits.NativeFieldInfoPtr_m_HeaderTitle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.UxmlTraits.NativeFieldInfoPtr_m_HeaderTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A7 RID: 4263
			// (get) Token: 0x060035AA RID: 13738 RVA: 0x000DE648 File Offset: 0x000DC848
			// (set) Token: 0x060035AB RID: 13739 RVA: 0x00015DB3 File Offset: 0x00013FB3
			public unsafe UxmlBoolAttributeDescription m_ShowAddRemoveFooter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ShowAddRemoveFooter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ShowAddRemoveFooter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A8 RID: 4264
			// (get) Token: 0x060035AC RID: 13740 RVA: 0x000DE678 File Offset: 0x000DC878
			// (set) Token: 0x060035AD RID: 13741 RVA: 0x00015DD2 File Offset: 0x00013FD2
			public unsafe UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ReorderMode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<ListViewReorderMode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ReorderMode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A9 RID: 4265
			// (get) Token: 0x060035AE RID: 13742 RVA: 0x000DE6A8 File Offset: 0x000DC8A8
			// (set) Token: 0x060035AF RID: 13743 RVA: 0x00015DF1 File Offset: 0x00013FF1
			public unsafe UxmlBoolAttributeDescription m_ShowBoundCollectionSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ShowBoundCollectionSize);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListView.UxmlTraits.NativeFieldInfoPtr_m_ShowBoundCollectionSize), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002685 RID: 9861
			private static readonly IntPtr NativeFieldInfoPtr_m_ShowFoldoutHeader;

			// Token: 0x04002686 RID: 9862
			private static readonly IntPtr NativeFieldInfoPtr_m_HeaderTitle;

			// Token: 0x04002687 RID: 9863
			private static readonly IntPtr NativeFieldInfoPtr_m_ShowAddRemoveFooter;

			// Token: 0x04002688 RID: 9864
			private static readonly IntPtr NativeFieldInfoPtr_m_ReorderMode;

			// Token: 0x04002689 RID: 9865
			private static readonly IntPtr NativeFieldInfoPtr_m_ShowBoundCollectionSize;

			// Token: 0x0400268A RID: 9866
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x0400268B RID: 9867
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

			// Token: 0x02000586 RID: 1414
			public sealed class <get_uxmlChildElementsDescription>d__6
			{
			}
		}
	}
}
