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
	// Token: 0x0200002F RID: 47
	public sealed class TreeDataController<T> : Object
	{
		// Token: 0x0600035D RID: 861 RVA: 0x00029A40 File Offset: 0x00027C40
		// Note: this type is marked as 'beforefieldinit'.
		static TreeDataController()
		{
			Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TreeDataController`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr);
			TreeDataController<T>.NativeFieldInfoPtr_m_TreeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, "m_TreeData");
			TreeDataController<T>.NativeFieldInfoPtr_m_IteratorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, "m_IteratorStack");
			TreeDataController<T>.NativeMethodInfoPtr_SetRootItems_Public_Void_IList_1_TreeViewItemData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, 100663774);
			TreeDataController<T>.NativeMethodInfoPtr_GetDataForId_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, 100663775);
			TreeDataController<T>.NativeMethodInfoPtr_GetParentId_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, 100663776);
			TreeDataController<T>.NativeMethodInfoPtr_HasChildren_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, 100663777);
			TreeDataController<T>.NativeMethodInfoPtr_GetItemIds_Private_Static_IEnumerable_1_Int32_IEnumerable_1_TreeViewItemData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, 100663778);
			TreeDataController<T>.NativeMethodInfoPtr_GetChildrenIds_Public_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, 100663779);
			TreeDataController<T>.NativeMethodInfoPtr_Move_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, 100663780);
			TreeDataController<T>.NativeMethodInfoPtr_IsChildOf_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, 100663781);
			TreeDataController<T>.NativeMethodInfoPtr_GetAllItemIds_Public_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, 100663782);
			TreeDataController<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, 100663783);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00029B9C File Offset: 0x00027D9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286349, RefRangeEnd = 286351, XrefRangeStart = 286347, XrefRangeEnd = 286349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRootItems(IList<TreeViewItemData<T>> rootItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootItems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>.NativeMethodInfoPtr_SetRootItems_Public_Void_IList_1_TreeViewItemData_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00029BE0 File Offset: 0x00027DE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286352, RefRangeEnd = 286354, XrefRangeStart = 286351, XrefRangeEnd = 286352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetDataForId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>.NativeMethodInfoPtr_GetDataForId_Public_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00029C28 File Offset: 0x00027E28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286359, RefRangeEnd = 286361, XrefRangeStart = 286354, XrefRangeEnd = 286359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParentId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>.NativeMethodInfoPtr_GetParentId_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00029C74 File Offset: 0x00027E74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 286362, RefRangeEnd = 286365, XrefRangeStart = 286361, XrefRangeEnd = 286362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChildren(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>.NativeMethodInfoPtr_HasChildren_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00029CC0 File Offset: 0x00027EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286365, XrefRangeEnd = 286371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetItemIds(IEnumerable<TreeViewItemData<T>> items)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>.NativeMethodInfoPtr_GetItemIds_Private_Static_IEnumerable_1_Int32_IEnumerable_1_TreeViewItemData_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00029D04 File Offset: 0x00027F04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 286378, RefRangeEnd = 286381, XrefRangeStart = 286371, XrefRangeEnd = 286378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> GetChildrenIds(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>.NativeMethodInfoPtr_GetChildrenIds_Public_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00029D50 File Offset: 0x00027F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286383, RefRangeEnd = 286385, XrefRangeStart = 286381, XrefRangeEnd = 286383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move(int id, int newParentId, int childIndex = -1)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>.NativeMethodInfoPtr_Move_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00029DAC File Offset: 0x00027FAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 286386, RefRangeEnd = 286390, XrefRangeStart = 286385, XrefRangeEnd = 286386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>.NativeMethodInfoPtr_IsChildOf_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00029E04 File Offset: 0x00028004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286395, RefRangeEnd = 286397, XrefRangeStart = 286390, XrefRangeEnd = 286395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>.NativeMethodInfoPtr_GetAllItemIds_Public_IEnumerable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00029E54 File Offset: 0x00028054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286405, RefRangeEnd = 286407, XrefRangeStart = 286397, XrefRangeEnd = 286405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeDataController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002E34 File Offset: 0x00001034
		public TreeDataController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00029E90 File Offset: 0x00028090
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00002E3D File Offset: 0x0000103D
		public TreeData<T> m_TreeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>.NativeFieldInfoPtr_m_TreeData);
				return new TreeData<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>.NativeFieldInfoPtr_m_TreeData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TreeData<T>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00029EC0 File Offset: 0x000280C0
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00002E6B File Offset: 0x0000106B
		public unsafe Stack<IEnumerator<int>> m_IteratorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>.NativeFieldInfoPtr_m_IteratorStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<IEnumerator<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>.NativeFieldInfoPtr_m_IteratorStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002E8A File Offset: 0x0000108A
		public void AddItem([In] ref TreeViewItemData<T> item, int parentId, int childIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002E97 File Offset: 0x00001097
		public bool TryRemoveItem(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002EA4 File Offset: 0x000010A4
		public TreeViewItemData<T> GetTreeItemDataForId(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_m_TreeData;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_m_IteratorStack;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_SetRootItems_Public_Void_IList_1_TreeViewItemData_1_T_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_GetDataForId_Public_T_Int32_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_GetParentId_Public_Int32_Int32_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_HasChildren_Public_Boolean_Int32_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_GetItemIds_Private_Static_IEnumerable_1_Int32_IEnumerable_1_TreeViewItemData_1_T_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_GetChildrenIds_Public_IEnumerable_1_Int32_Int32_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_IsChildOf_Public_Boolean_Int32_Int32_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItemIds_Public_IEnumerable_1_Int32_IEnumerable_1_Int32_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000329 RID: 809
		[ObfuscatedName("UnityEngine.UIElements.TreeDataController`1+<GetAllItemIds>d__13")]
		public sealed class _GetAllItemIds_d__13 : Object
		{
			// Token: 0x06003540 RID: 13632 RVA: 0x000DD098 File Offset: 0x000DB298
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAllItemIds_d__13()
			{
				Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, "<GetAllItemIds>d__13"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr);
				TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, "<>1__state");
				TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, "<>2__current");
				TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, "<>l__initialThreadId");
				TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr_rootIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, "rootIds");
				TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___3__rootIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, "<>3__rootIds");
				TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, "<>4__this");
				TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr__currentIterator_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, "<currentIterator>5__1");
				TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr__hasNext_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, "<hasNext>5__2");
				TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr__currentItemId_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, "<currentItemId>5__3");
				TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, 100663784);
				TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, 100663785);
				TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, 100663786);
				TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, 100663787);
				TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, 100663788);
				TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, 100663789);
				TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, 100663790);
				TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr, 100663791);
			}

			// Token: 0x06003541 RID: 13633 RVA: 0x000DD254 File Offset: 0x000DB454
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 286249, RefRangeEnd = 286258, XrefRangeStart = 286247, XrefRangeEnd = 286249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAllItemIds_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeDataController<T>._GetAllItemIds_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003542 RID: 13634 RVA: 0x000DD29C File Offset: 0x000DB49C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003543 RID: 13635 RVA: 0x000DD2D0 File Offset: 0x000DB4D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286258, XrefRangeEnd = 286284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700108D RID: 4237
			// (get) Token: 0x06003544 RID: 13636 RVA: 0x000DD30C File Offset: 0x000DB50C
			public unsafe int System.Collections.Generic.IEnumerator<System.Int32>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003545 RID: 13637 RVA: 0x000DD348 File Offset: 0x000DB548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700108E RID: 4238
			// (get) Token: 0x06003546 RID: 13638 RVA: 0x000DD37C File Offset: 0x000DB57C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286284, XrefRangeEnd = 286287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003547 RID: 13639 RVA: 0x000DD3BC File Offset: 0x000DB5BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286287, XrefRangeEnd = 286295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<int> System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr3) : null;
			}

			// Token: 0x06003548 RID: 13640 RVA: 0x000DD3FC File Offset: 0x000DB5FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286295, XrefRangeEnd = 286303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetAllItemIds_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003549 RID: 13641 RVA: 0x000159EC File Offset: 0x00013BEC
			public _GetAllItemIds_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001084 RID: 4228
			// (get) Token: 0x0600354A RID: 13642 RVA: 0x000DD43C File Offset: 0x000DB63C
			// (set) Token: 0x0600354B RID: 13643 RVA: 0x000159F5 File Offset: 0x00013BF5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001085 RID: 4229
			// (get) Token: 0x0600354C RID: 13644 RVA: 0x000DD464 File Offset: 0x000DB664
			// (set) Token: 0x0600354D RID: 13645 RVA: 0x00015A10 File Offset: 0x00013C10
			public unsafe int __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x17001086 RID: 4230
			// (get) Token: 0x0600354E RID: 13646 RVA: 0x000DD48C File Offset: 0x000DB68C
			// (set) Token: 0x0600354F RID: 13647 RVA: 0x00015A2B File Offset: 0x00013C2B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001087 RID: 4231
			// (get) Token: 0x06003550 RID: 13648 RVA: 0x000DD4B4 File Offset: 0x000DB6B4
			// (set) Token: 0x06003551 RID: 13649 RVA: 0x00015A46 File Offset: 0x00013C46
			public unsafe IEnumerable<int> rootIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr_rootIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr_rootIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001088 RID: 4232
			// (get) Token: 0x06003552 RID: 13650 RVA: 0x000DD4E4 File Offset: 0x000DB6E4
			// (set) Token: 0x06003553 RID: 13651 RVA: 0x00015A65 File Offset: 0x00013C65
			public unsafe IEnumerable<int> __3__rootIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___3__rootIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___3__rootIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001089 RID: 4233
			// (get) Token: 0x06003554 RID: 13652 RVA: 0x000DD514 File Offset: 0x000DB714
			// (set) Token: 0x06003555 RID: 13653 RVA: 0x00015A84 File Offset: 0x00013C84
			public unsafe TreeDataController<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TreeDataController<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108A RID: 4234
			// (get) Token: 0x06003556 RID: 13654 RVA: 0x000DD544 File Offset: 0x000DB744
			// (set) Token: 0x06003557 RID: 13655 RVA: 0x00015AA3 File Offset: 0x00013CA3
			public unsafe IEnumerator<int> _currentIterator_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr__currentIterator_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr__currentIterator_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108B RID: 4235
			// (get) Token: 0x06003558 RID: 13656 RVA: 0x000DD574 File Offset: 0x000DB774
			// (set) Token: 0x06003559 RID: 13657 RVA: 0x00015AC2 File Offset: 0x00013CC2
			public unsafe bool _hasNext_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr__hasNext_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr__hasNext_5__2)) = value;
				}
			}

			// Token: 0x1700108C RID: 4236
			// (get) Token: 0x0600355A RID: 13658 RVA: 0x000DD59C File Offset: 0x000DB79C
			// (set) Token: 0x0600355B RID: 13659 RVA: 0x00015ADD File Offset: 0x00013CDD
			public unsafe int _currentItemId_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr__currentItemId_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetAllItemIds_d__13.NativeFieldInfoPtr__currentItemId_5__3)) = value;
				}
			}

			// Token: 0x04002645 RID: 9797
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002646 RID: 9798
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002647 RID: 9799
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002648 RID: 9800
			private static readonly IntPtr NativeFieldInfoPtr_rootIds;

			// Token: 0x04002649 RID: 9801
			private static readonly IntPtr NativeFieldInfoPtr___3__rootIds;

			// Token: 0x0400264A RID: 9802
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400264B RID: 9803
			private static readonly IntPtr NativeFieldInfoPtr__currentIterator_5__1;

			// Token: 0x0400264C RID: 9804
			private static readonly IntPtr NativeFieldInfoPtr__hasNext_5__2;

			// Token: 0x0400264D RID: 9805
			private static readonly IntPtr NativeFieldInfoPtr__currentItemId_5__3;

			// Token: 0x0400264E RID: 9806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400264F RID: 9807
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002650 RID: 9808
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002651 RID: 9809
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002652 RID: 9810
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002653 RID: 9811
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002654 RID: 9812
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0;

			// Token: 0x04002655 RID: 9813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200032A RID: 810
		[ObfuscatedName("UnityEngine.UIElements.TreeDataController`1+<GetItemIds>d__9")]
		public sealed class _GetItemIds_d__9 : Object
		{
			// Token: 0x0600355C RID: 13660 RVA: 0x000DD5C4 File Offset: 0x000DB7C4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetItemIds_d__9()
			{
				Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TreeDataController<T>>.NativeClassPtr, "<GetItemIds>d__9"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr);
				TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, "<>1__state");
				TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, "<>2__current");
				TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, "<>l__initialThreadId");
				TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, "items");
				TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___3__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, "<>3__items");
				TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___s__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, "<>s__1");
				TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr__item_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, "<item>5__2");
				TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, 100663792);
				TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, 100663793);
				TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, 100663794);
				TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, 100663795);
				TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, 100663796);
				TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, 100663797);
				TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, 100663798);
				TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, 100663799);
				TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr, 100663800);
			}

			// Token: 0x0600355D RID: 13661 RVA: 0x000DD76C File Offset: 0x000DB96C
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 286249, RefRangeEnd = 286258, XrefRangeStart = 286249, XrefRangeEnd = 286258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetItemIds_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeDataController<T>._GetItemIds_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600355E RID: 13662 RVA: 0x000DD7B4 File Offset: 0x000DB9B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286303, XrefRangeEnd = 286308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600355F RID: 13663 RVA: 0x000DD7E8 File Offset: 0x000DB9E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286308, XrefRangeEnd = 286327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003560 RID: 13664 RVA: 0x000DD824 File Offset: 0x000DBA24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286327, XrefRangeEnd = 286330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001096 RID: 4246
			// (get) Token: 0x06003561 RID: 13665 RVA: 0x000DD858 File Offset: 0x000DBA58
			public unsafe int System.Collections.Generic.IEnumerator<System.Int32>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003562 RID: 13666 RVA: 0x000DD894 File Offset: 0x000DBA94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001097 RID: 4247
			// (get) Token: 0x06003563 RID: 13667 RVA: 0x000DD8C8 File Offset: 0x000DBAC8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286330, XrefRangeEnd = 286333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003564 RID: 13668 RVA: 0x000DD908 File Offset: 0x000DBB08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286333, XrefRangeEnd = 286340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<int> System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr3) : null;
			}

			// Token: 0x06003565 RID: 13669 RVA: 0x000DD948 File Offset: 0x000DBB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286340, XrefRangeEnd = 286347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeDataController<T>._GetItemIds_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003566 RID: 13670 RVA: 0x00015AF8 File Offset: 0x00013CF8
			public _GetItemIds_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700108F RID: 4239
			// (get) Token: 0x06003567 RID: 13671 RVA: 0x000DD988 File Offset: 0x000DBB88
			// (set) Token: 0x06003568 RID: 13672 RVA: 0x00015B01 File Offset: 0x00013D01
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001090 RID: 4240
			// (get) Token: 0x06003569 RID: 13673 RVA: 0x000DD9B0 File Offset: 0x000DBBB0
			// (set) Token: 0x0600356A RID: 13674 RVA: 0x00015B1C File Offset: 0x00013D1C
			public unsafe int __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x17001091 RID: 4241
			// (get) Token: 0x0600356B RID: 13675 RVA: 0x000DD9D8 File Offset: 0x000DBBD8
			// (set) Token: 0x0600356C RID: 13676 RVA: 0x00015B37 File Offset: 0x00013D37
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001092 RID: 4242
			// (get) Token: 0x0600356D RID: 13677 RVA: 0x000DDA00 File Offset: 0x000DBC00
			// (set) Token: 0x0600356E RID: 13678 RVA: 0x00015B52 File Offset: 0x00013D52
			public unsafe IEnumerable<TreeViewItemData<T>> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TreeViewItemData<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001093 RID: 4243
			// (get) Token: 0x0600356F RID: 13679 RVA: 0x000DDA30 File Offset: 0x000DBC30
			// (set) Token: 0x06003570 RID: 13680 RVA: 0x00015B71 File Offset: 0x00013D71
			public unsafe IEnumerable<TreeViewItemData<T>> __3__items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___3__items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TreeViewItemData<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___3__items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001094 RID: 4244
			// (get) Token: 0x06003571 RID: 13681 RVA: 0x000DDA60 File Offset: 0x000DBC60
			// (set) Token: 0x06003572 RID: 13682 RVA: 0x00015B90 File Offset: 0x00013D90
			public unsafe IEnumerator<TreeViewItemData<T>> __s__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___s__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TreeViewItemData<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr___s__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001095 RID: 4245
			// (get) Token: 0x06003573 RID: 13683 RVA: 0x000DDA90 File Offset: 0x000DBC90
			// (set) Token: 0x06003574 RID: 13684 RVA: 0x00015BAF File Offset: 0x00013DAF
			public TreeViewItemData<T> _item_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr__item_5__2);
					return new TreeViewItemData<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeDataController<T>._GetItemIds_d__9.NativeFieldInfoPtr__item_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002656 RID: 9814
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002657 RID: 9815
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002658 RID: 9816
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002659 RID: 9817
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x0400265A RID: 9818
			private static readonly IntPtr NativeFieldInfoPtr___3__items;

			// Token: 0x0400265B RID: 9819
			private static readonly IntPtr NativeFieldInfoPtr___s__1;

			// Token: 0x0400265C RID: 9820
			private static readonly IntPtr NativeFieldInfoPtr__item_5__2;

			// Token: 0x0400265D RID: 9821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400265E RID: 9822
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400265F RID: 9823
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002660 RID: 9824
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002661 RID: 9825
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002662 RID: 9826
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002663 RID: 9827
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002664 RID: 9828
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0;

			// Token: 0x04002665 RID: 9829
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
