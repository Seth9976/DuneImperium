using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Pool;

namespace UnityEngine.UIElements
{
	// Token: 0x02000090 RID: 144
	public sealed class TreeData<T> : ValueType
	{
		// Token: 0x06000E87 RID: 3719 RVA: 0x00050138 File Offset: 0x0004E338
		// Note: this type is marked as 'beforefieldinit'.
		static TreeData()
		{
			Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TreeData`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr);
			TreeData<T>.NativeFieldInfoPtr_m_RootItemIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, "m_RootItemIds");
			TreeData<T>.NativeFieldInfoPtr_m_Tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, "m_Tree");
			TreeData<T>.NativeFieldInfoPtr_m_ParentIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, "m_ParentIds");
			TreeData<T>.NativeFieldInfoPtr_m_ChildrenIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, "m_ChildrenIds");
			TreeData<T>.NativeMethodInfoPtr_get_rootItemIds_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665369);
			TreeData<T>.NativeMethodInfoPtr__ctor_Public_Void_IList_1_TreeViewItemData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665370);
			TreeData<T>.NativeMethodInfoPtr_GetDataForId_Public_TreeViewItemData_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665371);
			TreeData<T>.NativeMethodInfoPtr_GetParentId_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665372);
			TreeData<T>.NativeMethodInfoPtr_Move_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665373);
			TreeData<T>.NativeMethodInfoPtr_HasAncestor_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665374);
			TreeData<T>.NativeMethodInfoPtr_AddItemToParent_Private_Void_TreeViewItemData_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665375);
			TreeData<T>.NativeMethodInfoPtr_RemoveFromParent_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665376);
			TreeData<T>.NativeMethodInfoPtr_UpdateParentTree_Private_Void_TreeViewItemData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665377);
			TreeData<T>.NativeMethodInfoPtr_RefreshTree_Private_Void_IList_1_TreeViewItemData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665378);
			TreeData<T>.NativeMethodInfoPtr_BuildTree_Private_Void_IEnumerable_1_TreeViewItemData_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, 100665379);
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x000502D0 File Offset: 0x0004E4D0
		public unsafe IEnumerable<int> rootItemIds
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr_get_rootItemIds_Public_get_IEnumerable_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00050314 File Offset: 0x0004E514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306275, RefRangeEnd = 306276, XrefRangeStart = 306216, XrefRangeEnd = 306275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeData(IList<TreeViewItemData<T>> rootItems)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootItems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr__ctor_Public_Void_IList_1_TreeViewItemData_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00050364 File Offset: 0x0004E564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306276, XrefRangeEnd = 306278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeViewItemData<T> GetDataForId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr_GetDataForId_Public_TreeViewItemData_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TreeViewItemData<T>(intPtr);
			}
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000503B0 File Offset: 0x0004E5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306278, XrefRangeEnd = 306281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParentId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr_GetParentId_Public_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00050400 File Offset: 0x0004E600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306302, RefRangeEnd = 306303, XrefRangeStart = 306281, XrefRangeEnd = 306302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move(int id, int newParentId, int childIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newParentId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref childIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr_Move_Public_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00050460 File Offset: 0x0004E660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306303, XrefRangeEnd = 306306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAncestor(int childId, int ancestorId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref childId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ancestorId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr_HasAncestor_Public_Boolean_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x000504BC File Offset: 0x0004E6BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306321, RefRangeEnd = 306322, XrefRangeStart = 306306, XrefRangeEnd = 306321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemToParent(TreeViewItemData<T> item, int parentId, int childIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref childIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr_AddItemToParent_Private_Void_TreeViewItemData_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00050524 File Offset: 0x0004E724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306322, XrefRangeEnd = 306336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromParent(int id, int parentId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr_RemoveFromParent_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00050578 File Offset: 0x0004E778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306336, XrefRangeEnd = 306347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateParentTree(TreeViewItemData<T> current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(current));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr_UpdateParentTree_Private_Void_TreeViewItemData_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x000505C4 File Offset: 0x0004E7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306347, XrefRangeEnd = 306361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTree(IList<TreeViewItemData<T>> rootItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootItems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr_RefreshTree_Private_Void_IList_1_TreeViewItemData_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0005060C File Offset: 0x0004E80C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306427, RefRangeEnd = 306429, XrefRangeStart = 306361, XrefRangeEnd = 306427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildTree(IEnumerable<TreeViewItemData<T>> items, bool isRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeData<T>.NativeMethodInfoPtr_BuildTree_Private_Void_IEnumerable_1_TreeViewItemData_1_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00007731 File Offset: 0x00005931
		public TreeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0000773A File Offset: 0x0000593A
		public TreeData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x00050664 File Offset: 0x0004E864
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x0000774C File Offset: 0x0000594C
		public unsafe IList<int> m_RootItemIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeData<T>.NativeFieldInfoPtr_m_RootItemIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeData<T>.NativeFieldInfoPtr_m_RootItemIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00050694 File Offset: 0x0004E894
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x0000776B File Offset: 0x0000596B
		public unsafe Dictionary<int, TreeViewItemData<T>> m_Tree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeData<T>.NativeFieldInfoPtr_m_Tree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TreeViewItemData<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeData<T>.NativeFieldInfoPtr_m_Tree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000506C4 File Offset: 0x0004E8C4
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x0000778A File Offset: 0x0000598A
		public unsafe Dictionary<int, int> m_ParentIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeData<T>.NativeFieldInfoPtr_m_ParentIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeData<T>.NativeFieldInfoPtr_m_ParentIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x000506F4 File Offset: 0x0004E8F4
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x000077A9 File Offset: 0x000059A9
		public unsafe Dictionary<int, List<int>> m_ChildrenIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeData<T>.NativeFieldInfoPtr_m_ChildrenIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeData<T>.NativeFieldInfoPtr_m_ChildrenIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00050724 File Offset: 0x0004E924
		public void AddItem(TreeViewItemData<T> item, int parentId, int childIndex)
		{
			List<TreeViewItemData<T>> list = CollectionPool<List<TreeViewItemData<T>>, TreeViewItemData<T>>.Get();
			list.Add(item);
			this.BuildTree(list, false);
			this.AddItemToParent(item, parentId, childIndex);
			CollectionPool<List<TreeViewItemData<T>>, TreeViewItemData<T>>.Release(list);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0005075C File Offset: 0x0004E95C
		public bool TryRemove(int id)
		{
			int num;
			bool flag = this.m_ParentIds.TryGetValue(id, out num);
			if (flag)
			{
				this.RemoveFromParent(id, num);
			}
			else
			{
				this.m_RootItemIds.Remove(id);
			}
			return this.TryRemoveChildrenIds(id);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000507A4 File Offset: 0x0004E9A4
		public bool TryRemoveChildrenIds(int id)
		{
			TreeViewItemData<T> treeViewItemData;
			bool flag = this.m_Tree.TryGetValue(id, out treeViewItemData) && treeViewItemData.children != null;
			if (flag)
			{
				foreach (TreeViewItemData<T> treeViewItemData2 in treeViewItemData.children)
				{
					this.TryRemoveChildrenIds(treeViewItemData2.id);
				}
			}
			List<int> list;
			bool flag2 = this.m_ChildrenIds.TryGetValue(id, out list);
			if (flag2)
			{
				CollectionPool<List<int>, int>.Release(list);
			}
			bool flag3 = false;
			flag3 |= this.m_RootItemIds.Remove(id);
			flag3 |= this.m_ChildrenIds.Remove(id);
			flag3 |= this.m_ParentIds.Remove(id);
			flag3 |= this.m_Tree.Remove(id);
			return flag3 | this.m_RootItemIds.Remove(id);
		}

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr_m_RootItemIds;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeFieldInfoPtr_m_Tree;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentIds;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildrenIds;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_get_rootItemIds_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_TreeViewItemData_1_T_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_GetDataForId_Public_TreeViewItemData_1_T_Int32_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_GetParentId_Public_Int32_Int32_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_HasAncestor_Public_Boolean_Int32_Int32_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_AddItemToParent_Private_Void_TreeViewItemData_1_T_Int32_Int32_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromParent_Private_Void_Int32_Int32_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParentTree_Private_Void_TreeViewItemData_1_T_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTree_Private_Void_IList_1_TreeViewItemData_1_T_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_BuildTree_Private_Void_IEnumerable_1_TreeViewItemData_1_T_Boolean_0;
	}
}
