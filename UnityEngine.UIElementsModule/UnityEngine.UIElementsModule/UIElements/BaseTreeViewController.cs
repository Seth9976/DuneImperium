using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;
using UnityEngine.Pool;

namespace UnityEngine.UIElements
{
	// Token: 0x02000028 RID: 40
	public class BaseTreeViewController : CollectionViewController
	{
		// Token: 0x060002AE RID: 686 RVA: 0x000264B8 File Offset: 0x000246B8
		// Note: this type is marked as 'beforefieldinit'.
		static BaseTreeViewController()
		{
			Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseTreeViewController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr);
			BaseTreeViewController.NativeFieldInfoPtr_m_TreeItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, "m_TreeItems");
			BaseTreeViewController.NativeFieldInfoPtr_m_RootIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, "m_RootIndices");
			BaseTreeViewController.NativeFieldInfoPtr_m_ItemWrappers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, "m_ItemWrappers");
			BaseTreeViewController.NativeFieldInfoPtr_m_TreeItemIdsWithItemWrappers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, "m_TreeItemIdsWithItemWrappers");
			BaseTreeViewController.NativeFieldInfoPtr_m_WrapperInsertionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, "m_WrapperInsertionList");
			BaseTreeViewController.NativeFieldInfoPtr_K_ExpandItemByIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, "K_ExpandItemByIndex");
			BaseTreeViewController.NativeFieldInfoPtr_k_CreateWrappers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, "k_CreateWrappers");
			BaseTreeViewController.NativeMethodInfoPtr_get_baseTreeView_Protected_get_BaseTreeView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663657);
			BaseTreeViewController.NativeMethodInfoPtr_get_itemsSource_Public_Virtual_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663658);
			BaseTreeViewController.NativeMethodInfoPtr_set_itemsSource_Public_Virtual_set_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663659);
			BaseTreeViewController.NativeMethodInfoPtr_RebuildTree_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663660);
			BaseTreeViewController.NativeMethodInfoPtr_GetRootItemIds_Public_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663661);
			BaseTreeViewController.NativeMethodInfoPtr_GetAllItemIds_Public_Abstract_Virtual_New_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663662);
			BaseTreeViewController.NativeMethodInfoPtr_GetParentId_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663663);
			BaseTreeViewController.NativeMethodInfoPtr_GetChildrenIds_Public_Abstract_Virtual_New_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663664);
			BaseTreeViewController.NativeMethodInfoPtr_Move_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663665);
			BaseTreeViewController.NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663666);
			BaseTreeViewController.NativeMethodInfoPtr_InvokeBindItem_Internal_Virtual_Void_ReusableCollectionItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663667);
			BaseTreeViewController.NativeMethodInfoPtr_InvokeDestroyItem_Internal_Virtual_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663668);
			BaseTreeViewController.NativeMethodInfoPtr_PostInitRegistration_Internal_Void_ReusableTreeViewItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663669);
			BaseTreeViewController.NativeMethodInfoPtr_OnItemPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663670);
			BaseTreeViewController.NativeMethodInfoPtr_OnToggleValueChanged_Private_Void_ChangeEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663671);
			BaseTreeViewController.NativeMethodInfoPtr_GetIndexForId_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663672);
			BaseTreeViewController.NativeMethodInfoPtr_GetIdForIndex_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663673);
			BaseTreeViewController.NativeMethodInfoPtr_HasChildren_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663674);
			BaseTreeViewController.NativeMethodInfoPtr_Exists_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663675);
			BaseTreeViewController.NativeMethodInfoPtr_HasChildrenByIndex_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663676);
			BaseTreeViewController.NativeMethodInfoPtr_GetChildrenIdsByIndex_Public_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663677);
			BaseTreeViewController.NativeMethodInfoPtr_GetChildIndexForId_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663678);
			BaseTreeViewController.NativeMethodInfoPtr_GetIndentationDepth_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663679);
			BaseTreeViewController.NativeMethodInfoPtr_GetIndentationDepthByIndex_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663680);
			BaseTreeViewController.NativeMethodInfoPtr_CanChangeExpandedState_Internal_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663681);
			BaseTreeViewController.NativeMethodInfoPtr_IsExpanded_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663682);
			BaseTreeViewController.NativeMethodInfoPtr_IsExpandedByIndex_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663683);
			BaseTreeViewController.NativeMethodInfoPtr_ExpandItemByIndex_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663684);
			BaseTreeViewController.NativeMethodInfoPtr_ExpandItem_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663685);
			BaseTreeViewController.NativeMethodInfoPtr_CollapseItemByIndex_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663686);
			BaseTreeViewController.NativeMethodInfoPtr_CollapseItem_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663687);
			BaseTreeViewController.NativeMethodInfoPtr_RegenerateWrappers_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663688);
			BaseTreeViewController.NativeMethodInfoPtr_CreateWrappers_Private_Void_IEnumerable_1_Int32_Int32_byref_List_1_TreeViewItemWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663689);
			BaseTreeViewController.NativeMethodInfoPtr_IsIndexValid_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663690);
			BaseTreeViewController.NativeMethodInfoPtr_RaiseItemParentChanged_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663691);
			BaseTreeViewController.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, 100663692);
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00026844 File Offset: 0x00024A44
		public unsafe BaseTreeView baseTreeView
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 285280, RefRangeEnd = 285297, XrefRangeStart = 285279, XrefRangeEnd = 285280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_get_baseTreeView_Protected_get_BaseTreeView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseTreeView>(intPtr3) : null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00026884 File Offset: 0x00024A84
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x000268D0 File Offset: 0x00024AD0
		public unsafe override IList itemsSource
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_get_itemsSource_Public_Virtual_get_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285297, XrefRangeEnd = 285303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_set_itemsSource_Public_Virtual_set_Void_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00026920 File Offset: 0x00024B20
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 285332, RefRangeEnd = 285338, XrefRangeStart = 285303, XrefRangeEnd = 285332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildTree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_RebuildTree_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00026954 File Offset: 0x00024B54
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 285338, RefRangeEnd = 285365, XrefRangeStart = 285338, XrefRangeEnd = 285338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> GetRootItemIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_GetRootItemIds_Public_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00026994 File Offset: 0x00024B94
		[CallerCount(0)]
		public unsafe virtual IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_GetAllItemIds_Public_Abstract_Virtual_New_IEnumerable_1_Int32_IEnumerable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000269F0 File Offset: 0x00024BF0
		[CallerCount(0)]
		public unsafe virtual int GetParentId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_GetParentId_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00026A44 File Offset: 0x00024C44
		[CallerCount(0)]
		public unsafe virtual IEnumerable<int> GetChildrenIds(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_GetChildrenIds_Public_Abstract_Virtual_New_IEnumerable_1_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00026A9C File Offset: 0x00024C9C
		[CallerCount(0)]
		public unsafe virtual void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newParentId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref childIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rebuildTree;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_Move_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00026B10 File Offset: 0x00024D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285365, XrefRangeEnd = 285369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeMakeItem(ReusableCollectionItem reusableItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00026B60 File Offset: 0x00024D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285369, XrefRangeEnd = 285378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_InvokeBindItem_Internal_Virtual_Void_ReusableCollectionItem_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00026BBC File Offset: 0x00024DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285378, XrefRangeEnd = 285406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeDestroyItem(ReusableCollectionItem reusableItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_InvokeDestroyItem_Internal_Virtual_Void_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00026C0C File Offset: 0x00024E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285450, RefRangeEnd = 285452, XrefRangeStart = 285406, XrefRangeEnd = 285450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostInitRegistration(ReusableTreeViewItem treeItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(treeItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_PostInitRegistration_Internal_Void_ReusableTreeViewItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00026C50 File Offset: 0x00024E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285452, XrefRangeEnd = 285518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnItemPointerUp(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_OnItemPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00026C94 File Offset: 0x00024E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285518, XrefRangeEnd = 285534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleValueChanged(ChangeEvent<bool> evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_OnToggleValueChanged_Private_Void_ChangeEvent_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00026CD8 File Offset: 0x00024ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285534, XrefRangeEnd = 285543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetIndexForId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_GetIndexForId_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00026D2C File Offset: 0x00024F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285543, XrefRangeEnd = 285548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetIdForIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_GetIdForIndex_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00026D80 File Offset: 0x00024F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285548, XrefRangeEnd = 285551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasChildren(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_HasChildren_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00026DD4 File Offset: 0x00024FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285555, RefRangeEnd = 285556, XrefRangeStart = 285551, XrefRangeEnd = 285555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Exists(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_Exists_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00026E20 File Offset: 0x00025020
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 285561, RefRangeEnd = 285569, XrefRangeStart = 285556, XrefRangeEnd = 285561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChildrenByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_HasChildrenByIndex_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00026E6C File Offset: 0x0002506C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285574, RefRangeEnd = 285576, XrefRangeStart = 285569, XrefRangeEnd = 285574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> GetChildrenIdsByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_GetChildrenIdsByIndex_Public_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00026EB8 File Offset: 0x000250B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285600, RefRangeEnd = 285605, XrefRangeStart = 285576, XrefRangeEnd = 285600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetChildIndexForId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_GetChildIndexForId_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00026F04 File Offset: 0x00025104
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285605, RefRangeEnd = 285610, XrefRangeStart = 285605, XrefRangeEnd = 285605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndentationDepth(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_GetIndentationDepth_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00026F50 File Offset: 0x00025150
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285610, RefRangeEnd = 285612, XrefRangeStart = 285610, XrefRangeEnd = 285610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndentationDepthByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_GetIndentationDepthByIndex_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00026F9C File Offset: 0x0002519C
		[CallerCount(0)]
		public unsafe virtual bool CanChangeExpandedState(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTreeViewController.NativeMethodInfoPtr_CanChangeExpandedState_Internal_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00026FF0 File Offset: 0x000251F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285617, RefRangeEnd = 285618, XrefRangeStart = 285612, XrefRangeEnd = 285617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsExpanded(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_IsExpanded_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0002703C File Offset: 0x0002523C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 285627, RefRangeEnd = 285635, XrefRangeStart = 285618, XrefRangeEnd = 285627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsExpandedByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_IsExpandedByIndex_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00027088 File Offset: 0x00025288
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285726, RefRangeEnd = 285730, XrefRangeStart = 285635, XrefRangeEnd = 285726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expandAllChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refresh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_ExpandItemByIndex_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000270E4 File Offset: 0x000252E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285740, RefRangeEnd = 285745, XrefRangeStart = 285730, XrefRangeEnd = 285740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandItem(int id, bool expandAllChildren, bool refresh = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expandAllChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refresh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_ExpandItem_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00027140 File Offset: 0x00025340
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285786, RefRangeEnd = 285789, XrefRangeStart = 285745, XrefRangeEnd = 285786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollapseItemByIndex(int index, bool collapseAllChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collapseAllChildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_CollapseItemByIndex_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0002718C File Offset: 0x0002538C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285799, RefRangeEnd = 285800, XrefRangeStart = 285789, XrefRangeEnd = 285799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollapseItem(int id, bool collapseAllChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collapseAllChildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_CollapseItem_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000271D8 File Offset: 0x000253D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285807, RefRangeEnd = 285811, XrefRangeStart = 285800, XrefRangeEnd = 285807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateWrappers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_RegenerateWrappers_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0002720C File Offset: 0x0002540C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285862, RefRangeEnd = 285865, XrefRangeStart = 285811, XrefRangeEnd = 285862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateWrappers(IEnumerable<int> treeViewItemIds, int depth, ref List<TreeViewItemWrapper> wrappers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(treeViewItemIds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(wrappers);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_CreateWrappers_Private_Void_IEnumerable_1_Int32_Int32_byref_List_1_TreeViewItemWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			wrappers = ((intPtr4 == 0) ? null : new List<TreeViewItemWrapper>(intPtr4));
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00027284 File Offset: 0x00025484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285865, XrefRangeEnd = 285866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIndexValid(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_IsIndexValid_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000272D0 File Offset: 0x000254D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285866, RefRangeEnd = 285869, XrefRangeStart = 285866, XrefRangeEnd = 285866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseItemParentChanged(int id, int newParentId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newParentId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr_RaiseItemParentChanged_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0002731C File Offset: 0x0002551C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285903, RefRangeEnd = 285905, XrefRangeStart = 285869, XrefRangeEnd = 285903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseTreeViewController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002C46 File Offset: 0x00000E46
		public BaseTreeViewController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00027358 File Offset: 0x00025558
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00002C4F File Offset: 0x00000E4F
		public unsafe Dictionary<int, TreeItem> m_TreeItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.NativeFieldInfoPtr_m_TreeItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TreeItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.NativeFieldInfoPtr_m_TreeItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00027388 File Offset: 0x00025588
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00002C6E File Offset: 0x00000E6E
		public unsafe List<int> m_RootIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.NativeFieldInfoPtr_m_RootIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.NativeFieldInfoPtr_m_RootIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x000273B8 File Offset: 0x000255B8
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00002C8D File Offset: 0x00000E8D
		public unsafe List<TreeViewItemWrapper> m_ItemWrappers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.NativeFieldInfoPtr_m_ItemWrappers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TreeViewItemWrapper>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.NativeFieldInfoPtr_m_ItemWrappers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000273E8 File Offset: 0x000255E8
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00002CAC File Offset: 0x00000EAC
		public unsafe HashSet<int> m_TreeItemIdsWithItemWrappers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.NativeFieldInfoPtr_m_TreeItemIdsWithItemWrappers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.NativeFieldInfoPtr_m_TreeItemIdsWithItemWrappers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00027418 File Offset: 0x00025618
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00002CCB File Offset: 0x00000ECB
		public unsafe List<TreeViewItemWrapper> m_WrapperInsertionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.NativeFieldInfoPtr_m_WrapperInsertionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TreeViewItemWrapper>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.NativeFieldInfoPtr_m_WrapperInsertionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00027448 File Offset: 0x00025648
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00002CEA File Offset: 0x00000EEA
		public unsafe static ProfilerMarker K_ExpandItemByIndex
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(BaseTreeViewController.NativeFieldInfoPtr_K_ExpandItemByIndex, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseTreeViewController.NativeFieldInfoPtr_K_ExpandItemByIndex, (void*)(&value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00027464 File Offset: 0x00025664
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public unsafe static ProfilerMarker k_CreateWrappers
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(BaseTreeViewController.NativeFieldInfoPtr_k_CreateWrappers, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseTreeViewController.NativeFieldInfoPtr_k_CreateWrappers, (void*)(&value));
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00027480 File Offset: 0x00025680
		public virtual int GetTreeItemsCount()
		{
			return this.m_TreeItems.Count;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000274A0 File Offset: 0x000256A0
		public void ExpandAll()
		{
			foreach (int num in this.GetAllItemIds(null))
			{
				bool flag = !this.CanChangeExpandedState(num);
				if (!flag)
				{
					bool flag2 = !this.baseTreeView.expandedItemIds.Contains(num);
					if (flag2)
					{
						this.baseTreeView.expandedItemIds.Add(num);
					}
				}
			}
			this.RegenerateWrappers();
			this.baseTreeView.RefreshItems();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0002753C File Offset: 0x0002573C
		public void CollapseAll()
		{
			bool flag = this.baseTreeView.expandedItemIds.Count == 0;
			if (!flag)
			{
				List<int> list;
				PooledObject<List<int>> pooledObject = CollectionPool<List<int>, int>.Get(out list);
				try
				{
					List<int>.Enumerator enumerator = this.baseTreeView.expandedItemIds.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int num = enumerator.Current;
							bool flag2 = !this.CanChangeExpandedState(num);
							if (flag2)
							{
								list.Add(num);
							}
						}
					}
					finally
					{
						enumerator.Dispose();
					}
					this.baseTreeView.expandedItemIds.Clear();
					this.baseTreeView.expandedItemIds.AddRange(list);
				}
				finally
				{
					pooledObject.Dispose();
				}
				this.RegenerateWrappers();
				this.baseTreeView.RefreshItems();
			}
		}

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_m_TreeItems;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_m_RootIndices;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemWrappers;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_m_TreeItemIdsWithItemWrappers;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeFieldInfoPtr_m_WrapperInsertionList;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeFieldInfoPtr_K_ExpandItemByIndex;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeFieldInfoPtr_k_CreateWrappers;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_get_baseTreeView_Protected_get_BaseTreeView_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_get_itemsSource_Public_Virtual_get_IList_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_set_itemsSource_Public_Virtual_set_Void_IList_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_RebuildTree_Public_Void_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_GetRootItemIds_Public_IEnumerable_1_Int32_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItemIds_Public_Abstract_Virtual_New_IEnumerable_1_Int32_IEnumerable_1_Int32_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_GetParentId_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_GetChildrenIds_Public_Abstract_Virtual_New_IEnumerable_1_Int32_Int32_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Boolean_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_InvokeBindItem_Internal_Virtual_Void_ReusableCollectionItem_Int32_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDestroyItem_Internal_Virtual_Void_ReusableCollectionItem_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_PostInitRegistration_Internal_Void_ReusableTreeViewItem_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_OnItemPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleValueChanged_Private_Void_ChangeEvent_1_Boolean_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexForId_Public_Virtual_Int32_Int32_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_GetIdForIndex_Public_Virtual_Int32_Int32_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_HasChildren_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Internal_Boolean_Int32_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_HasChildrenByIndex_Public_Boolean_Int32_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_GetChildrenIdsByIndex_Public_IEnumerable_1_Int32_Int32_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_GetChildIndexForId_Public_Int32_Int32_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_GetIndentationDepth_Internal_Int32_Int32_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_GetIndentationDepthByIndex_Internal_Int32_Int32_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_CanChangeExpandedState_Internal_Virtual_New_Boolean_Int32_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_IsExpanded_Public_Boolean_Int32_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_IsExpandedByIndex_Public_Boolean_Int32_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_ExpandItemByIndex_Public_Void_Int32_Boolean_Boolean_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_ExpandItem_Public_Void_Int32_Boolean_Boolean_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_CollapseItemByIndex_Public_Void_Int32_Boolean_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_CollapseItem_Public_Void_Int32_Boolean_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateWrappers_Internal_Void_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_CreateWrappers_Private_Void_IEnumerable_1_Int32_Int32_byref_List_1_TreeViewItemWrapper_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_IsIndexValid_Private_Boolean_Int32_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_RaiseItemParentChanged_Internal_Void_Int32_Int32_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000327 RID: 807
		[ObfuscatedName("UnityEngine.UIElements.BaseTreeViewController+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x06003538 RID: 13624 RVA: 0x000DCF4C File Offset: 0x000DB14C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<BaseTreeViewController.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseTreeViewController>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseTreeViewController.__c__DisplayClass20_0>.NativeClassPtr);
				BaseTreeViewController.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeViewController.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				BaseTreeViewController.__c__DisplayClass20_0.NativeFieldInfoPtr_treeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTreeViewController.__c__DisplayClass20_0>.NativeClassPtr, "treeItem");
				BaseTreeViewController.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController.__c__DisplayClass20_0>.NativeClassPtr, 100663694);
				BaseTreeViewController.__c__DisplayClass20_0.NativeMethodInfoPtr__PostInitRegistration_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTreeViewController.__c__DisplayClass20_0>.NativeClassPtr, 100663695);
			}

			// Token: 0x06003539 RID: 13625 RVA: 0x000DCFC8 File Offset: 0x000DB1C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseTreeViewController.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600353A RID: 13626 RVA: 0x000DD004 File Offset: 0x000DB204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285278, XrefRangeEnd = 285279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PostInitRegistration_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTreeViewController.__c__DisplayClass20_0.NativeMethodInfoPtr__PostInitRegistration_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600353B RID: 13627 RVA: 0x000159A5 File Offset: 0x00013BA5
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001082 RID: 4226
			// (get) Token: 0x0600353C RID: 13628 RVA: 0x000DD038 File Offset: 0x000DB238
			// (set) Token: 0x0600353D RID: 13629 RVA: 0x000159AE File Offset: 0x00013BAE
			public unsafe BaseTreeViewController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseTreeViewController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001083 RID: 4227
			// (get) Token: 0x0600353E RID: 13630 RVA: 0x000DD068 File Offset: 0x000DB268
			// (set) Token: 0x0600353F RID: 13631 RVA: 0x000159CD File Offset: 0x00013BCD
			public unsafe ReusableTreeViewItem treeItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.__c__DisplayClass20_0.NativeFieldInfoPtr_treeItem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReusableTreeViewItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTreeViewController.__c__DisplayClass20_0.NativeFieldInfoPtr_treeItem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002641 RID: 9793
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002642 RID: 9794
			private static readonly IntPtr NativeFieldInfoPtr_treeItem;

			// Token: 0x04002643 RID: 9795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002644 RID: 9796
			private static readonly IntPtr NativeMethodInfoPtr__PostInitRegistration_b__0_Internal_Void_0;
		}

		// Token: 0x02000328 RID: 808
		public sealed class <>c__DisplayClass20_0
		{
		}
	}
}
