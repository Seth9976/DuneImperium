using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200002B RID: 43
	public class DefaultTreeViewController<T> : TreeViewController
	{
		// Token: 0x06000321 RID: 801 RVA: 0x0002885C File Offset: 0x00026A5C
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultTreeViewController()
		{
			Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DefaultTreeViewController`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr);
			DefaultTreeViewController<T>.NativeFieldInfoPtr_m_TreeDataController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, "m_TreeDataController");
			DefaultTreeViewController<T>.NativeMethodInfoPtr_get_treeDataController_Private_get_TreeDataController_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663735);
			DefaultTreeViewController<T>.NativeMethodInfoPtr_get_itemsSource_Public_Virtual_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663736);
			DefaultTreeViewController<T>.NativeMethodInfoPtr_set_itemsSource_Public_Virtual_set_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663737);
			DefaultTreeViewController<T>.NativeMethodInfoPtr_SetRootItems_Public_Virtual_Final_New_Void_IList_1_TreeViewItemData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663738);
			DefaultTreeViewController<T>.NativeMethodInfoPtr_GetItemForIndex_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663739);
			DefaultTreeViewController<T>.NativeMethodInfoPtr_GetParentId_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663740);
			DefaultTreeViewController<T>.NativeMethodInfoPtr_HasChildren_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663741);
			DefaultTreeViewController<T>.NativeMethodInfoPtr_GetChildrenIds_Public_Virtual_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663742);
			DefaultTreeViewController<T>.NativeMethodInfoPtr_Move_Public_Virtual_Void_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663743);
			DefaultTreeViewController<T>.NativeMethodInfoPtr_IsChildOf_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663744);
			DefaultTreeViewController<T>.NativeMethodInfoPtr_GetAllItemIds_Public_Virtual_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663745);
			DefaultTreeViewController<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr, 100663746);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000322 RID: 802 RVA: 0x000289CC File Offset: 0x00026BCC
		public unsafe TreeDataController<T> treeDataController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286074, XrefRangeEnd = 286078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTreeViewController<T>.NativeMethodInfoPtr_get_treeDataController_Private_get_TreeDataController_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TreeDataController<T>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00028A0C File Offset: 0x00026C0C
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00028A58 File Offset: 0x00026C58
		public unsafe override IList itemsSource
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultTreeViewController<T>.NativeMethodInfoPtr_get_itemsSource_Public_Virtual_get_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286078, XrefRangeEnd = 286091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultTreeViewController<T>.NativeMethodInfoPtr_set_itemsSource_Public_Virtual_set_Void_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00028AA8 File Offset: 0x00026CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286091, XrefRangeEnd = 286096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRootItems(IList<TreeViewItemData<T>> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTreeViewController<T>.NativeMethodInfoPtr_SetRootItems_Public_Virtual_Final_New_Void_IList_1_TreeViewItemData_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00028AEC File Offset: 0x00026CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286096, XrefRangeEnd = 286099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetItemForIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultTreeViewController<T>.NativeMethodInfoPtr_GetItemForIndex_Public_Virtual_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00028B44 File Offset: 0x00026D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286099, XrefRangeEnd = 286102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetParentId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultTreeViewController<T>.NativeMethodInfoPtr_GetParentId_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00028B98 File Offset: 0x00026D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286102, XrefRangeEnd = 286105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasChildren(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultTreeViewController<T>.NativeMethodInfoPtr_HasChildren_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00028BEC File Offset: 0x00026DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286105, XrefRangeEnd = 286108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<int> GetChildrenIds(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultTreeViewController<T>.NativeMethodInfoPtr_GetChildrenIds_Public_Virtual_IEnumerable_1_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00028C44 File Offset: 0x00026E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286108, XrefRangeEnd = 286114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultTreeViewController<T>.NativeMethodInfoPtr_Move_Public_Virtual_Void_Int32_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00028CB8 File Offset: 0x00026EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286114, XrefRangeEnd = 286117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChildOf(int childId, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref childId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTreeViewController<T>.NativeMethodInfoPtr_IsChildOf_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00028D10 File Offset: 0x00026F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286117, XrefRangeEnd = 286120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultTreeViewController<T>.NativeMethodInfoPtr_GetAllItemIds_Public_Virtual_IEnumerable_1_Int32_IEnumerable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00028D6C File Offset: 0x00026F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286124, RefRangeEnd = 286125, XrefRangeStart = 286120, XrefRangeEnd = 286124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultTreeViewController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultTreeViewController<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTreeViewController<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002DB3 File Offset: 0x00000FB3
		public DefaultTreeViewController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00028DA8 File Offset: 0x00026FA8
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00002DBC File Offset: 0x00000FBC
		public unsafe TreeDataController<T> m_TreeDataController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultTreeViewController<T>.NativeFieldInfoPtr_m_TreeDataController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TreeDataController<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultTreeViewController<T>.NativeFieldInfoPtr_m_TreeDataController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00028DD8 File Offset: 0x00026FD8
		public virtual void AddItem([In] ref TreeViewItemData<T> item, int parentId, int childIndex, [Optional] bool rebuildTree)
		{
			this.treeDataController.AddItem(ref item, parentId, childIndex);
			if (rebuildTree)
			{
				base.RebuildTree();
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00028E04 File Offset: 0x00027004
		public override bool TryRemoveItem(int id, [Optional] bool rebuildTree)
		{
			bool flag = this.treeDataController.TryRemoveItem(id);
			bool flag2;
			if (flag)
			{
				if (rebuildTree)
				{
					base.RebuildTree();
				}
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00028E38 File Offset: 0x00027038
		public virtual Object GetItemDataForId(int id)
		{
			TreeViewItemData<T> treeItemDataForId = this.treeDataController.GetTreeItemDataForId(id);
			return treeItemDataForId.data;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00028E64 File Offset: 0x00027064
		public virtual TreeViewItemData<T> GetTreeViewItemDataForId(int id)
		{
			return this.treeDataController.GetTreeItemDataForId(id);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00028E84 File Offset: 0x00027084
		public virtual TreeViewItemData<T> GetTreeViewItemDataForIndex(int index)
		{
			int idForIndex = this.GetIdForIndex(index);
			return this.treeDataController.GetTreeItemDataForId(idForIndex);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00028EAC File Offset: 0x000270AC
		public virtual T GetDataForId(int id)
		{
			return this.treeDataController.GetDataForId(id);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00028ECC File Offset: 0x000270CC
		public virtual T GetDataForIndex(int index)
		{
			return this.treeDataController.GetDataForId(this.GetIdForIndex(index));
		}

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_m_TreeDataController;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_get_treeDataController_Private_get_TreeDataController_1_T_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_get_itemsSource_Public_Virtual_get_IList_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_set_itemsSource_Public_Virtual_set_Void_IList_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_SetRootItems_Public_Virtual_Final_New_Void_IList_1_TreeViewItemData_1_T_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_GetItemForIndex_Public_Virtual_Object_Int32_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_GetParentId_Public_Virtual_Int32_Int32_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_HasChildren_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_GetChildrenIds_Public_Virtual_IEnumerable_1_Int32_Int32_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Virtual_Void_Int32_Int32_Int32_Boolean_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_IsChildOf_Private_Boolean_Int32_Int32_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItemIds_Public_Virtual_IEnumerable_1_Int32_IEnumerable_1_Int32_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
