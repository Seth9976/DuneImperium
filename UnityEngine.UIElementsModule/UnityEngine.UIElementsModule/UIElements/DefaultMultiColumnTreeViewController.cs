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
	// Token: 0x0200002A RID: 42
	public class DefaultMultiColumnTreeViewController<T> : MultiColumnTreeViewController
	{
		// Token: 0x0600030B RID: 779 RVA: 0x000281C0 File Offset: 0x000263C0
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultMultiColumnTreeViewController()
		{
			Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DefaultMultiColumnTreeViewController`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr);
			DefaultMultiColumnTreeViewController<T>.NativeFieldInfoPtr_m_TreeDataController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, "m_TreeDataController");
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_get_treeDataController_Private_get_TreeDataController_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663723);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663724);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_get_itemsSource_Public_Virtual_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663725);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_set_itemsSource_Public_Virtual_set_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663726);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_SetRootItems_Public_Virtual_Final_New_Void_IList_1_TreeViewItemData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663727);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_GetItemForIndex_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663728);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_GetParentId_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663729);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_HasChildren_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663730);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_GetChildrenIds_Public_Virtual_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663731);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_Move_Public_Virtual_Void_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663732);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_IsChildOf_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663733);
			DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_GetAllItemIds_Public_Virtual_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr, 100663734);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00028330 File Offset: 0x00026530
		public unsafe TreeDataController<T> treeDataController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286016, XrefRangeEnd = 286020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_get_treeDataController_Private_get_TreeDataController_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TreeDataController<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00028370 File Offset: 0x00026570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286021, RefRangeEnd = 286022, XrefRangeStart = 286020, XrefRangeEnd = 286021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultMultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultMultiColumnTreeViewController<T>>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000283E0 File Offset: 0x000265E0
		// (set) Token: 0x0600030F RID: 783 RVA: 0x0002842C File Offset: 0x0002662C
		public unsafe override IList itemsSource
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286022, XrefRangeEnd = 286027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_get_itemsSource_Public_Virtual_get_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286027, XrefRangeEnd = 286040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_set_itemsSource_Public_Virtual_set_Void_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0002847C File Offset: 0x0002667C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286040, XrefRangeEnd = 286045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRootItems(IList<TreeViewItemData<T>> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_SetRootItems_Public_Virtual_Final_New_Void_IList_1_TreeViewItemData_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000284C0 File Offset: 0x000266C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286045, XrefRangeEnd = 286050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetItemForIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_GetItemForIndex_Public_Virtual_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00028518 File Offset: 0x00026718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286050, XrefRangeEnd = 286054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetParentId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_GetParentId_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0002856C File Offset: 0x0002676C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286054, XrefRangeEnd = 286057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasChildren(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_HasChildren_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000285C0 File Offset: 0x000267C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286057, XrefRangeEnd = 286061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<int> GetChildrenIds(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_GetChildrenIds_Public_Virtual_IEnumerable_1_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00028618 File Offset: 0x00026818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286061, XrefRangeEnd = 286067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_Move_Public_Virtual_Void_Int32_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0002868C File Offset: 0x0002688C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286067, XrefRangeEnd = 286071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_IsChildOf_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000286E4 File Offset: 0x000268E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286071, XrefRangeEnd = 286074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultMultiColumnTreeViewController<T>.NativeMethodInfoPtr_GetAllItemIds_Public_Virtual_IEnumerable_1_Int32_IEnumerable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002D8B File Offset: 0x00000F8B
		public DefaultMultiColumnTreeViewController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00028740 File Offset: 0x00026940
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00002D94 File Offset: 0x00000F94
		public unsafe TreeDataController<T> m_TreeDataController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultMultiColumnTreeViewController<T>.NativeFieldInfoPtr_m_TreeDataController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TreeDataController<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultMultiColumnTreeViewController<T>.NativeFieldInfoPtr_m_TreeDataController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00028770 File Offset: 0x00026970
		public virtual void AddItem([In] ref TreeViewItemData<T> item, int parentId, int childIndex, [Optional] bool rebuildTree)
		{
			this.treeDataController.AddItem(ref item, parentId, childIndex);
			if (rebuildTree)
			{
				base.RebuildTree();
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0002879C File Offset: 0x0002699C
		public virtual TreeViewItemData<T> GetTreeViewItemDataForId(int id)
		{
			return this.treeDataController.GetTreeItemDataForId(id);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000287BC File Offset: 0x000269BC
		public virtual TreeViewItemData<T> GetTreeViewItemDataForIndex(int index)
		{
			int idForIndex = this.GetIdForIndex(index);
			return this.treeDataController.GetTreeItemDataForId(idForIndex);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000287E4 File Offset: 0x000269E4
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

		// Token: 0x0600031F RID: 799 RVA: 0x00028818 File Offset: 0x00026A18
		public T GetDataForId(int id)
		{
			return this.treeDataController.GetDataForId(id);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00028838 File Offset: 0x00026A38
		public T GetDataForIndex(int index)
		{
			return this.treeDataController.GetDataForId(this.GetIdForIndex(index));
		}

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_m_TreeDataController;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_get_treeDataController_Private_get_TreeDataController_1_T_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_get_itemsSource_Public_Virtual_get_IList_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_set_itemsSource_Public_Virtual_set_Void_IList_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_SetRootItems_Public_Virtual_Final_New_Void_IList_1_TreeViewItemData_1_T_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_GetItemForIndex_Public_Virtual_Object_Int32_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_GetParentId_Public_Virtual_Int32_Int32_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_HasChildren_Public_Virtual_Boolean_Int32_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_GetChildrenIds_Public_Virtual_IEnumerable_1_Int32_Int32_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Virtual_Void_Int32_Int32_Int32_Boolean_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_IsChildOf_Private_Boolean_Int32_Int32_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItemIds_Public_Virtual_IEnumerable_1_Int32_IEnumerable_1_Int32_0;
	}
}
