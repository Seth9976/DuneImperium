using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Data
{
	// Token: 0x0200006F RID: 111
	public class RBTree<K> : Object
	{
		// Token: 0x06000A1C RID: 2588 RVA: 0x000343B8 File Offset: 0x000325B8
		// Note: this type is marked as 'beforefieldinit'.
		static RBTree()
		{
			Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "RBTree`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr);
			RBTree<K>.NativeFieldInfoPtr__pageTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "_pageTable");
			RBTree<K>.NativeFieldInfoPtr__pageTableMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "_pageTableMap");
			RBTree<K>.NativeFieldInfoPtr__inUsePageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "_inUsePageCount");
			RBTree<K>.NativeFieldInfoPtr__nextFreePageLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "_nextFreePageLine");
			RBTree<K>.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "root");
			RBTree<K>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "_version");
			RBTree<K>.NativeFieldInfoPtr__inUseNodeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "_inUseNodeCount");
			RBTree<K>.NativeFieldInfoPtr__inUseSatelliteTreeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "_inUseSatelliteTreeCount");
			RBTree<K>.NativeFieldInfoPtr__accessMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "_accessMethod");
			RBTree<K>.NativeMethodInfoPtr_CompareNode_Protected_Abstract_Virtual_New_Int32_K_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664954);
			RBTree<K>.NativeMethodInfoPtr_CompareSateliteTreeNode_Protected_Abstract_Virtual_New_Int32_K_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664955);
			RBTree<K>.NativeMethodInfoPtr__ctor_Protected_Void_TreeAccessMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664956);
			RBTree<K>.NativeMethodInfoPtr_InitTree_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664957);
			RBTree<K>.NativeMethodInfoPtr_FreePage_Private_Void_TreePage_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664958);
			RBTree<K>.NativeMethodInfoPtr_AllocPage_Private_TreePage_K_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664959);
			RBTree<K>.NativeMethodInfoPtr_MarkPageFull_Private_Void_TreePage_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664960);
			RBTree<K>.NativeMethodInfoPtr_MarkPageFree_Private_Void_TreePage_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664961);
			RBTree<K>.NativeMethodInfoPtr_GetIntValueFromBitMap_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664962);
			RBTree<K>.NativeMethodInfoPtr_FreeNode_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664963);
			RBTree<K>.NativeMethodInfoPtr_GetIndexOfPageWithFreeSlot_Private_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664964);
			RBTree<K>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664965);
			RBTree<K>.NativeMethodInfoPtr_get_HasDuplicates_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664966);
			RBTree<K>.NativeMethodInfoPtr_GetNewNode_Private_Int32_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664967);
			RBTree<K>.NativeMethodInfoPtr_Successor_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664968);
			RBTree<K>.NativeMethodInfoPtr_Successor_Private_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664969);
			RBTree<K>.NativeMethodInfoPtr_Minimum_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664970);
			RBTree<K>.NativeMethodInfoPtr_LeftRotate_Private_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664971);
			RBTree<K>.NativeMethodInfoPtr_RightRotate_Private_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664972);
			RBTree<K>.NativeMethodInfoPtr_RBInsert_Private_Int32_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664973);
			RBTree<K>.NativeMethodInfoPtr_UpdateNodeKey_Public_Void_K_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664974);
			RBTree<K>.NativeMethodInfoPtr_DeleteByIndex_Public_K_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664975);
			RBTree<K>.NativeMethodInfoPtr_RBDelete_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664976);
			RBTree<K>.NativeMethodInfoPtr_RBDeleteX_Private_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664977);
			RBTree<K>.NativeMethodInfoPtr_RBDeleteFixup_Private_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664978);
			RBTree<K>.NativeMethodInfoPtr_SearchSubTree_Private_Int32_Int32_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664979);
			RBTree<K>.NativeMethodInfoPtr_get_Item_Public_get_K_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664980);
			RBTree<K>.NativeMethodInfoPtr_GetNodeByKey_Private_NodePath_K_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664981);
			RBTree<K>.NativeMethodInfoPtr_GetIndexByKey_Public_Int32_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664982);
			RBTree<K>.NativeMethodInfoPtr_GetIndexByNode_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664983);
			RBTree<K>.NativeMethodInfoPtr_GetIndexByNodePath_Private_Int32_NodePath_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664984);
			RBTree<K>.NativeMethodInfoPtr_ComputeIndexByNode_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664985);
			RBTree<K>.NativeMethodInfoPtr_ComputeIndexWithSatelliteByNode_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664986);
			RBTree<K>.NativeMethodInfoPtr_GetNodeByIndex_Private_NodePath_K_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664987);
			RBTree<K>.NativeMethodInfoPtr_ComputeNodeByIndex_Private_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664988);
			RBTree<K>.NativeMethodInfoPtr_ComputeNodeByIndex_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664989);
			RBTree<K>.NativeMethodInfoPtr_Insert_Public_Int32_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664990);
			RBTree<K>.NativeMethodInfoPtr_Add_Public_Int32_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664991);
			RBTree<K>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664992);
			RBTree<K>.NativeMethodInfoPtr_IndexOf_Public_Int32_Int32_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664993);
			RBTree<K>.NativeMethodInfoPtr_Insert_Public_Int32_Int32_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664994);
			RBTree<K>.NativeMethodInfoPtr_InsertAt_Public_Int32_Int32_K_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664995);
			RBTree<K>.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664996);
			RBTree<K>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664997);
			RBTree<K>.NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664998);
			RBTree<K>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_K_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100664999);
			RBTree<K>.NativeMethodInfoPtr_SetRight_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665000);
			RBTree<K>.NativeMethodInfoPtr_SetLeft_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665001);
			RBTree<K>.NativeMethodInfoPtr_SetParent_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665002);
			RBTree<K>.NativeMethodInfoPtr_SetColor_Private_Void_Int32_NodeColor_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665003);
			RBTree<K>.NativeMethodInfoPtr_SetKey_Private_Void_Int32_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665004);
			RBTree<K>.NativeMethodInfoPtr_SetNext_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665005);
			RBTree<K>.NativeMethodInfoPtr_SetSubTreeSize_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665006);
			RBTree<K>.NativeMethodInfoPtr_IncreaseSize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665007);
			RBTree<K>.NativeMethodInfoPtr_RecomputeSize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665008);
			RBTree<K>.NativeMethodInfoPtr_DecreaseSize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665009);
			RBTree<K>.NativeMethodInfoPtr_Right_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665010);
			RBTree<K>.NativeMethodInfoPtr_Left_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665011);
			RBTree<K>.NativeMethodInfoPtr_Parent_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665012);
			RBTree<K>.NativeMethodInfoPtr_color_Private_NodeColor_K_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665013);
			RBTree<K>.NativeMethodInfoPtr_Next_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665014);
			RBTree<K>.NativeMethodInfoPtr_SubTreeSize_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665015);
			RBTree<K>.NativeMethodInfoPtr_Key_Public_K_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, 100665016);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000349C4 File Offset: 0x00032BC4
		[CallerCount(0)]
		public unsafe virtual int CompareNode(K record1, K record2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = record1;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref record1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(K).IsValueType)
			{
				K k2 = record2;
				intPtr2 = ((k2 is string) ? IL2CPP.ManagedStringToIl2Cpp(k2 as string) : IL2CPP.Il2CppObjectBaseToPtr(k2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref record2;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RBTree<K>.NativeMethodInfoPtr_CompareNode_Protected_Abstract_Virtual_New_Int32_K_K_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00034A9C File Offset: 0x00032C9C
		[CallerCount(0)]
		public unsafe virtual int CompareSateliteTreeNode(K record1, K record2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = record1;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref record1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(K).IsValueType)
			{
				K k2 = record2;
				intPtr2 = ((k2 is string) ? IL2CPP.ManagedStringToIl2Cpp(k2 as string) : IL2CPP.Il2CppObjectBaseToPtr(k2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref record2;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RBTree<K>.NativeMethodInfoPtr_CompareSateliteTreeNode_Protected_Abstract_Virtual_New_Int32_K_K_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00034B74 File Offset: 0x00032D74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 905722, RefRangeEnd = 905724, XrefRangeStart = 905716, XrefRangeEnd = 905722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RBTree(TreeAccessMethod accessMethod)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref accessMethod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr__ctor_Protected_Void_TreeAccessMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00034BBC File Offset: 0x00032DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905724, XrefRangeEnd = 905732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitTree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_InitTree_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00034BF0 File Offset: 0x00032DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905732, XrefRangeEnd = 905733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreePage(RBTree<K>.TreePage page)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(page);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_FreePage_Private_Void_TreePage_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00034C34 File Offset: 0x00032E34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 905752, RefRangeEnd = 905759, XrefRangeStart = 905733, XrefRangeEnd = 905752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RBTree<K>.TreePage AllocPage(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_AllocPage_Private_TreePage_K_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RBTree<K>.TreePage>(intPtr3) : null;
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00034C80 File Offset: 0x00032E80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905759, RefRangeEnd = 905760, XrefRangeStart = 905759, XrefRangeEnd = 905759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPageFull(RBTree<K>.TreePage page)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(page);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_MarkPageFull_Private_Void_TreePage_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00034CC4 File Offset: 0x00032EC4
		[CallerCount(0)]
		public unsafe void MarkPageFree(RBTree<K>.TreePage page)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(page);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_MarkPageFree_Private_Void_TreePage_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00034D08 File Offset: 0x00032F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905760, RefRangeEnd = 905761, XrefRangeStart = 905760, XrefRangeEnd = 905760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetIntValueFromBitMap(uint bitMap)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitMap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_GetIntValueFromBitMap_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00034D48 File Offset: 0x00032F48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 905761, RefRangeEnd = 905763, XrefRangeStart = 905761, XrefRangeEnd = 905761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeNode(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_FreeNode_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00034D88 File Offset: 0x00032F88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 905764, RefRangeEnd = 905766, XrefRangeStart = 905763, XrefRangeEnd = 905764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndexOfPageWithFreeSlot(bool allocatedPage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocatedPage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_GetIndexOfPageWithFreeSlot_Private_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00034DD4 File Offset: 0x00032FD4
		public unsafe int Count
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 905766, RefRangeEnd = 905769, XrefRangeStart = 905766, XrefRangeEnd = 905766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00034E10 File Offset: 0x00033010
		public unsafe bool HasDuplicates
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 905769, RefRangeEnd = 905772, XrefRangeStart = 905769, XrefRangeEnd = 905769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_get_HasDuplicates_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00034E4C File Offset: 0x0003304C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 905786, RefRangeEnd = 905791, XrefRangeStart = 905772, XrefRangeEnd = 905786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNewNode(K key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_GetNewNode_Private_Int32_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00034ED0 File Offset: 0x000330D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 905791, RefRangeEnd = 905796, XrefRangeStart = 905791, XrefRangeEnd = 905791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Successor(int x_id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Successor_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00034F1C File Offset: 0x0003311C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905800, RefRangeEnd = 905801, XrefRangeStart = 905796, XrefRangeEnd = 905800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Successor(ref int nodeId, ref int mainTreeNodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &nodeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mainTreeNodeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Successor_Private_Boolean_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00034F74 File Offset: 0x00033174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905801, XrefRangeEnd = 905802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Minimum(int x_id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Minimum_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00034FC0 File Offset: 0x000331C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 905813, RefRangeEnd = 905816, XrefRangeStart = 905802, XrefRangeEnd = 905813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LeftRotate(int root_id, int x_id, int mainTreeNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref root_id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x_id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainTreeNode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_LeftRotate_Private_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00035028 File Offset: 0x00033228
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 905827, RefRangeEnd = 905830, XrefRangeStart = 905816, XrefRangeEnd = 905827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RightRotate(int root_id, int x_id, int mainTreeNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref root_id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x_id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainTreeNode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_RightRotate_Private_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00035090 File Offset: 0x00033290
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 905879, RefRangeEnd = 905885, XrefRangeStart = 905830, XrefRangeEnd = 905879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref root_id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x_id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainTreeNodeID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_RBInsert_Private_Int32_Int32_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00035114 File Offset: 0x00033314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905886, RefRangeEnd = 905887, XrefRangeStart = 905885, XrefRangeEnd = 905886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNodeKey(K currentKey, K newKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = currentKey;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref currentKey;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(K).IsValueType)
			{
				K k2 = newKey;
				intPtr2 = ((k2 is string) ? IL2CPP.ManagedStringToIl2Cpp(k2 as string) : IL2CPP.Il2CppObjectBaseToPtr(k2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newKey;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_UpdateNodeKey_Public_Void_K_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000351D4 File Offset: 0x000333D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905889, RefRangeEnd = 905890, XrefRangeStart = 905887, XrefRangeEnd = 905889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe K DeleteByIndex(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_DeleteByIndex_Public_K_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<K>(intPtr, false, true);
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0003521C File Offset: 0x0003341C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905890, XrefRangeEnd = 905891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RBDelete(int z_id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref z_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_RBDelete_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00035268 File Offset: 0x00033468
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 905952, RefRangeEnd = 905955, XrefRangeStart = 905891, XrefRangeEnd = 905952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RBDeleteX(int root_id, int z_id, int mainTreeNodeID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref root_id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z_id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainTreeNodeID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_RBDeleteX_Private_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000352D0 File Offset: 0x000334D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906024, RefRangeEnd = 906025, XrefRangeStart = 905955, XrefRangeEnd = 906024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref root_id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x_id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref px_id;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainTreeNodeID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_RBDeleteFixup_Private_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00035344 File Offset: 0x00033544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906025, XrefRangeEnd = 906031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SearchSubTree(int root_id, K key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref root_id;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(K).IsValueType)
			{
				K k = key;
				intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_SearchSubTree_Private_Int32_Int32_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x1700028D RID: 653
		public unsafe K this[int index]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 906032, RefRangeEnd = 906034, XrefRangeStart = 906031, XrefRangeEnd = 906032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_get_Item_Public_get_K_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<K>(intPtr, false, true);
				}
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00035420 File Offset: 0x00033620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906041, RefRangeEnd = 906043, XrefRangeStart = 906034, XrefRangeEnd = 906041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RBTree<K>.NodePath GetNodeByKey(K key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_GetNodeByKey_Private_NodePath_K_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return new RBTree<K>.NodePath(intPtr2);
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000354A0 File Offset: 0x000336A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 906046, RefRangeEnd = 906050, XrefRangeStart = 906043, XrefRangeEnd = 906046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndexByKey(K key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_GetIndexByKey_Public_Int32_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00035524 File Offset: 0x00033724
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906057, RefRangeEnd = 906059, XrefRangeStart = 906050, XrefRangeEnd = 906057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndexByNode(int node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_GetIndexByNode_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00035570 File Offset: 0x00033770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906059, XrefRangeEnd = 906061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndexByNodePath(RBTree<K>.NodePath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_GetIndexByNodePath_Private_Int32_NodePath_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000355C4 File Offset: 0x000337C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 906063, RefRangeEnd = 906066, XrefRangeStart = 906061, XrefRangeEnd = 906063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ComputeIndexByNode(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_ComputeIndexByNode_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00035610 File Offset: 0x00033810
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 906072, RefRangeEnd = 906075, XrefRangeStart = 906066, XrefRangeEnd = 906072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ComputeIndexWithSatelliteByNode(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_ComputeIndexWithSatelliteByNode_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0003565C File Offset: 0x0003385C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906075, XrefRangeEnd = 906079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RBTree<K>.NodePath GetNodeByIndex(int userIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_GetNodeByIndex_Private_NodePath_K_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RBTree<K>.NodePath(intPtr);
			}
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x000356A0 File Offset: 0x000338A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906089, RefRangeEnd = 906091, XrefRangeStart = 906079, XrefRangeEnd = 906089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ComputeNodeByIndex(int index, out int satelliteRootId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &satelliteRootId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_ComputeNodeByIndex_Private_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000356F8 File Offset: 0x000338F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906091, XrefRangeEnd = 906093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ComputeNodeByIndex(int x_id, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x_id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_ComputeNodeByIndex_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00035750 File Offset: 0x00033950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906093, XrefRangeEnd = 906095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Insert(K item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = item;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Insert_Public_Int32_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000357D4 File Offset: 0x000339D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(K item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = item;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Add_Public_Int32_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00035858 File Offset: 0x00033A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906095, XrefRangeEnd = 906097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00035898 File Offset: 0x00033A98
		[CallerCount(0)]
		public unsafe int IndexOf(int nodeId, K item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(K).IsValueType)
			{
				K k = item;
				intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_IndexOf_Public_Int32_Int32_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0003592C File Offset: 0x00033B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906097, XrefRangeEnd = 906099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Insert(int position, K item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(K).IsValueType)
			{
				K k = item;
				intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Insert_Public_Int32_Int32_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000359C0 File Offset: 0x00033BC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906101, RefRangeEnd = 906103, XrefRangeStart = 906099, XrefRangeEnd = 906101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InsertAt(int position, K item, bool append)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(K).IsValueType)
			{
				K k = item;
				intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_InsertAt_Public_Int32_Int32_K_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00035A60 File Offset: 0x00033C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906103, XrefRangeEnd = 906105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00035AA0 File Offset: 0x00033CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906105, XrefRangeEnd = 906106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00035AD4 File Offset: 0x00033CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906106, XrefRangeEnd = 906111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00035B24 File Offset: 0x00033D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906111, XrefRangeEnd = 906113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppArrayBase<K> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_K_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00035B74 File Offset: 0x00033D74
		[CallerCount(0)]
		public unsafe void SetRight(int nodeId, int rightNodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightNodeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_SetRight_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00035BC0 File Offset: 0x00033DC0
		[CallerCount(0)]
		public unsafe void SetLeft(int nodeId, int leftNodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftNodeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_SetLeft_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00035C0C File Offset: 0x00033E0C
		[CallerCount(0)]
		public unsafe void SetParent(int nodeId, int parentNodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentNodeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_SetParent_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00035C58 File Offset: 0x00033E58
		[CallerCount(0)]
		public unsafe void SetColor(int nodeId, RBTree<K>.NodeColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_SetColor_Private_Void_Int32_NodeColor_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00035CA4 File Offset: 0x00033EA4
		[CallerCount(0)]
		public unsafe void SetKey(int nodeId, K key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(K).IsValueType)
			{
				K k = key;
				intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_SetKey_Private_Void_Int32_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00035D2C File Offset: 0x00033F2C
		[CallerCount(0)]
		public unsafe void SetNext(int nodeId, int nextNodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextNodeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_SetNext_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00035D78 File Offset: 0x00033F78
		[CallerCount(0)]
		public unsafe void SetSubTreeSize(int nodeId, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_SetSubTreeSize_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00035DC4 File Offset: 0x00033FC4
		[CallerCount(0)]
		public unsafe void IncreaseSize(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_IncreaseSize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00035E04 File Offset: 0x00034004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906114, RefRangeEnd = 906115, XrefRangeStart = 906113, XrefRangeEnd = 906114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecomputeSize(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_RecomputeSize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00035E44 File Offset: 0x00034044
		[CallerCount(0)]
		public unsafe void DecreaseSize(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_DecreaseSize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00035E84 File Offset: 0x00034084
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 906115, RefRangeEnd = 906120, XrefRangeStart = 906115, XrefRangeEnd = 906115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Right(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Right_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00035ED0 File Offset: 0x000340D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 906120, RefRangeEnd = 906125, XrefRangeStart = 906120, XrefRangeEnd = 906120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Left(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Left_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00035F1C File Offset: 0x0003411C
		[CallerCount(0)]
		public unsafe int Parent(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Parent_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00035F68 File Offset: 0x00034168
		[CallerCount(0)]
		public unsafe RBTree<K>.NodeColor color(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_color_Private_NodeColor_K_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00035FB4 File Offset: 0x000341B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906125, RefRangeEnd = 906127, XrefRangeStart = 906125, XrefRangeEnd = 906125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Next(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Next_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00036000 File Offset: 0x00034200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906127, RefRangeEnd = 906128, XrefRangeStart = 906127, XrefRangeEnd = 906127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SubTreeSize(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_SubTreeSize_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0003604C File Offset: 0x0003424C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 906128, RefRangeEnd = 906133, XrefRangeStart = 906128, XrefRangeEnd = 906128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe K Key(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NativeMethodInfoPtr_Key_Public_K_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<K>(intPtr, false, true);
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x000050D9 File Offset: 0x000032D9
		public RBTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00036094 File Offset: 0x00034294
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x000050E2 File Offset: 0x000032E2
		public unsafe Il2CppReferenceArray<RBTree<K>.TreePage> _pageTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__pageTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RBTree<K>.TreePage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__pageTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000360C4 File Offset: 0x000342C4
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00005101 File Offset: 0x00003301
		public unsafe Il2CppStructArray<int> _pageTableMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__pageTableMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__pageTableMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x000360F4 File Offset: 0x000342F4
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00005120 File Offset: 0x00003320
		public unsafe int _inUsePageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__inUsePageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__inUsePageCount)) = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0003611C File Offset: 0x0003431C
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x0000513B File Offset: 0x0000333B
		public unsafe int _nextFreePageLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__nextFreePageLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__nextFreePageLine)) = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00036144 File Offset: 0x00034344
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x00005156 File Offset: 0x00003356
		public unsafe int root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr_root);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr_root)) = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0003616C File Offset: 0x0003436C
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x00005171 File Offset: 0x00003371
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00036194 File Offset: 0x00034394
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0000518C File Offset: 0x0000338C
		public unsafe int _inUseNodeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__inUseNodeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__inUseNodeCount)) = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x000361BC File Offset: 0x000343BC
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x000051A7 File Offset: 0x000033A7
		public unsafe int _inUseSatelliteTreeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__inUseSatelliteTreeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__inUseSatelliteTreeCount)) = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x000361E4 File Offset: 0x000343E4
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x000051C2 File Offset: 0x000033C2
		public unsafe TreeAccessMethod _accessMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__accessMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NativeFieldInfoPtr__accessMethod)) = value;
			}
		}

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeFieldInfoPtr__pageTable;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeFieldInfoPtr__pageTableMap;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeFieldInfoPtr__inUsePageCount;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeFieldInfoPtr__nextFreePageLine;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeFieldInfoPtr__inUseNodeCount;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeFieldInfoPtr__inUseSatelliteTreeCount;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeFieldInfoPtr__accessMethod;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_CompareNode_Protected_Abstract_Virtual_New_Int32_K_K_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_CompareSateliteTreeNode_Protected_Abstract_Virtual_New_Int32_K_K_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_TreeAccessMethod_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_InitTree_Private_Void_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_FreePage_Private_Void_TreePage_K_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_AllocPage_Private_TreePage_K_Int32_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_MarkPageFull_Private_Void_TreePage_K_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_MarkPageFree_Private_Void_TreePage_K_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_GetIntValueFromBitMap_Private_Static_Int32_UInt32_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_FreeNode_Private_Void_Int32_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexOfPageWithFreeSlot_Private_Int32_Boolean_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDuplicates_Public_get_Boolean_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_GetNewNode_Private_Int32_K_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_Successor_Private_Int32_Int32_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_Successor_Private_Boolean_byref_Int32_byref_Int32_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_Minimum_Private_Int32_Int32_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_LeftRotate_Private_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_RightRotate_Private_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_RBInsert_Private_Int32_Int32_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNodeKey_Public_Void_K_K_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_DeleteByIndex_Public_K_Int32_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_RBDelete_Public_Int32_Int32_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_RBDeleteX_Private_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_RBDeleteFixup_Private_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_SearchSubTree_Private_Int32_Int32_K_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_K_Int32_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_GetNodeByKey_Private_NodePath_K_K_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexByKey_Public_Int32_K_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexByNode_Public_Int32_Int32_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexByNodePath_Private_Int32_NodePath_K_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_ComputeIndexByNode_Private_Int32_Int32_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_ComputeIndexWithSatelliteByNode_Private_Int32_Int32_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_GetNodeByIndex_Private_NodePath_K_Int32_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_ComputeNodeByIndex_Private_Int32_Int32_byref_Int32_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_ComputeNodeByIndex_Private_Int32_Int32_Int32_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Int32_K_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_K_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Int32_K_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Int32_Int32_K_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_InsertAt_Public_Int32_Int32_K_Boolean_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int32_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_K_Int32_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_SetRight_Private_Void_Int32_Int32_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_SetLeft_Private_Void_Int32_Int32_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Private_Void_Int32_Int32_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Private_Void_Int32_NodeColor_K_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_SetKey_Private_Void_Int32_K_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_SetNext_Private_Void_Int32_Int32_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_SetSubTreeSize_Private_Void_Int32_Int32_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseSize_Private_Void_Int32_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeSize_Private_Void_Int32_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_DecreaseSize_Private_Void_Int32_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_Right_Public_Int32_Int32_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_Left_Public_Int32_Int32_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_Parent_Public_Int32_Int32_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_color_Private_NodeColor_K_Int32_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Int32_Int32_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_SubTreeSize_Public_Int32_Int32_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_Key_Public_K_Int32_0;

		// Token: 0x020000E3 RID: 227
		public enum NodeColor
		{
			// Token: 0x04001148 RID: 4424
			red,
			// Token: 0x04001149 RID: 4425
			black
		}

		// Token: 0x020000E4 RID: 228
		public sealed class Node : ValueType
		{
			// Token: 0x060014AD RID: 5293 RVA: 0x000629E8 File Offset: 0x00060BE8
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "Node"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr);
				RBTree<K>.Node.NativeFieldInfoPtr__selfId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr, "_selfId");
				RBTree<K>.Node.NativeFieldInfoPtr__leftId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr, "_leftId");
				RBTree<K>.Node.NativeFieldInfoPtr__rightId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr, "_rightId");
				RBTree<K>.Node.NativeFieldInfoPtr__parentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr, "_parentId");
				RBTree<K>.Node.NativeFieldInfoPtr__nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr, "_nextId");
				RBTree<K>.Node.NativeFieldInfoPtr__subTreeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr, "_subTreeSize");
				RBTree<K>.Node.NativeFieldInfoPtr__keyOfNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr, "_keyOfNode");
				RBTree<K>.Node.NativeFieldInfoPtr__nodeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr, "_nodeColor");
			}

			// Token: 0x060014AE RID: 5294 RVA: 0x00007CA2 File Offset: 0x00005EA2
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060014AF RID: 5295 RVA: 0x00007CAB File Offset: 0x00005EAB
			public Node()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RBTree<K>.Node>.NativeClassPtr))
			{
			}

			// Token: 0x170004B2 RID: 1202
			// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00062AF0 File Offset: 0x00060CF0
			// (set) Token: 0x060014B1 RID: 5297 RVA: 0x00007CBD File Offset: 0x00005EBD
			public unsafe int _selfId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__selfId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__selfId)) = value;
				}
			}

			// Token: 0x170004B3 RID: 1203
			// (get) Token: 0x060014B2 RID: 5298 RVA: 0x00062B18 File Offset: 0x00060D18
			// (set) Token: 0x060014B3 RID: 5299 RVA: 0x00007CD8 File Offset: 0x00005ED8
			public unsafe int _leftId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__leftId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__leftId)) = value;
				}
			}

			// Token: 0x170004B4 RID: 1204
			// (get) Token: 0x060014B4 RID: 5300 RVA: 0x00062B40 File Offset: 0x00060D40
			// (set) Token: 0x060014B5 RID: 5301 RVA: 0x00007CF3 File Offset: 0x00005EF3
			public unsafe int _rightId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__rightId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__rightId)) = value;
				}
			}

			// Token: 0x170004B5 RID: 1205
			// (get) Token: 0x060014B6 RID: 5302 RVA: 0x00062B68 File Offset: 0x00060D68
			// (set) Token: 0x060014B7 RID: 5303 RVA: 0x00007D0E File Offset: 0x00005F0E
			public unsafe int _parentId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__parentId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__parentId)) = value;
				}
			}

			// Token: 0x170004B6 RID: 1206
			// (get) Token: 0x060014B8 RID: 5304 RVA: 0x00062B90 File Offset: 0x00060D90
			// (set) Token: 0x060014B9 RID: 5305 RVA: 0x00007D29 File Offset: 0x00005F29
			public unsafe int _nextId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__nextId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__nextId)) = value;
				}
			}

			// Token: 0x170004B7 RID: 1207
			// (get) Token: 0x060014BA RID: 5306 RVA: 0x00062BB8 File Offset: 0x00060DB8
			// (set) Token: 0x060014BB RID: 5307 RVA: 0x00007D44 File Offset: 0x00005F44
			public unsafe int _subTreeSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__subTreeSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__subTreeSize)) = value;
				}
			}

			// Token: 0x170004B8 RID: 1208
			// (get) Token: 0x060014BC RID: 5308 RVA: 0x00062BE0 File Offset: 0x00060DE0
			// (set) Token: 0x060014BD RID: 5309 RVA: 0x00062C08 File Offset: 0x00060E08
			public unsafe K _keyOfNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__keyOfNode);
					return IL2CPP.PointerToValueGeneric<K>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__keyOfNode);
					Type typeFromHandle = typeof(K);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170004B9 RID: 1209
			// (get) Token: 0x060014BE RID: 5310 RVA: 0x00062CB0 File Offset: 0x00060EB0
			// (set) Token: 0x060014BF RID: 5311 RVA: 0x00007D5F File Offset: 0x00005F5F
			public unsafe RBTree<K>.NodeColor _nodeColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__nodeColor);
					return *intPtr;
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.Node.NativeFieldInfoPtr__nodeColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RBTree<K>.NodeColor>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400114A RID: 4426
			private static readonly IntPtr NativeFieldInfoPtr__selfId;

			// Token: 0x0400114B RID: 4427
			private static readonly IntPtr NativeFieldInfoPtr__leftId;

			// Token: 0x0400114C RID: 4428
			private static readonly IntPtr NativeFieldInfoPtr__rightId;

			// Token: 0x0400114D RID: 4429
			private static readonly IntPtr NativeFieldInfoPtr__parentId;

			// Token: 0x0400114E RID: 4430
			private static readonly IntPtr NativeFieldInfoPtr__nextId;

			// Token: 0x0400114F RID: 4431
			private static readonly IntPtr NativeFieldInfoPtr__subTreeSize;

			// Token: 0x04001150 RID: 4432
			private static readonly IntPtr NativeFieldInfoPtr__keyOfNode;

			// Token: 0x04001151 RID: 4433
			private static readonly IntPtr NativeFieldInfoPtr__nodeColor;
		}

		// Token: 0x020000E5 RID: 229
		public sealed class NodePath : ValueType
		{
			// Token: 0x060014C0 RID: 5312 RVA: 0x00062CD8 File Offset: 0x00060ED8
			// Note: this type is marked as 'beforefieldinit'.
			static NodePath()
			{
				Il2CppClassPointerStore<RBTree<K>.NodePath>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "NodePath"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RBTree<K>.NodePath>.NativeClassPtr);
				RBTree<K>.NodePath.NativeFieldInfoPtr__nodeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.NodePath>.NativeClassPtr, "_nodeID");
				RBTree<K>.NodePath.NativeFieldInfoPtr__mainTreeNodeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.NodePath>.NativeClassPtr, "_mainTreeNodeID");
				RBTree<K>.NodePath.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.NodePath>.NativeClassPtr, 100665017);
			}

			// Token: 0x060014C1 RID: 5313 RVA: 0x00062D7C File Offset: 0x00060F7C
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodePath(int nodeID, int mainTreeNodeID)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RBTree<K>.NodePath>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref nodeID;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainTreeNodeID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.NodePath.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014C2 RID: 5314 RVA: 0x00007D8D File Offset: 0x00005F8D
			public NodePath(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060014C3 RID: 5315 RVA: 0x00007D96 File Offset: 0x00005F96
			public NodePath()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RBTree<K>.NodePath>.NativeClassPtr))
			{
			}

			// Token: 0x170004BA RID: 1210
			// (get) Token: 0x060014C4 RID: 5316 RVA: 0x00062DD8 File Offset: 0x00060FD8
			// (set) Token: 0x060014C5 RID: 5317 RVA: 0x00007DA8 File Offset: 0x00005FA8
			public unsafe int _nodeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NodePath.NativeFieldInfoPtr__nodeID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NodePath.NativeFieldInfoPtr__nodeID)) = value;
				}
			}

			// Token: 0x170004BB RID: 1211
			// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00062E00 File Offset: 0x00061000
			// (set) Token: 0x060014C7 RID: 5319 RVA: 0x00007DC3 File Offset: 0x00005FC3
			public unsafe int _mainTreeNodeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NodePath.NativeFieldInfoPtr__mainTreeNodeID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.NodePath.NativeFieldInfoPtr__mainTreeNodeID)) = value;
				}
			}

			// Token: 0x04001152 RID: 4434
			private static readonly IntPtr NativeFieldInfoPtr__nodeID;

			// Token: 0x04001153 RID: 4435
			private static readonly IntPtr NativeFieldInfoPtr__mainTreeNodeID;

			// Token: 0x04001154 RID: 4436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0;
		}

		// Token: 0x020000E6 RID: 230
		public sealed class TreePage : Object
		{
			// Token: 0x060014C8 RID: 5320 RVA: 0x00062E28 File Offset: 0x00061028
			// Note: this type is marked as 'beforefieldinit'.
			static TreePage()
			{
				Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "TreePage"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr);
				RBTree<K>.TreePage.NativeFieldInfoPtr__slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, "_slots");
				RBTree<K>.TreePage.NativeFieldInfoPtr__slotMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, "_slotMap");
				RBTree<K>.TreePage.NativeFieldInfoPtr__inUseCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, "_inUseCount");
				RBTree<K>.TreePage.NativeFieldInfoPtr__pageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, "_pageId");
				RBTree<K>.TreePage.NativeFieldInfoPtr__nextFreeSlotLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, "_nextFreeSlotLine");
				RBTree<K>.TreePage.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, 100665018);
				RBTree<K>.TreePage.NativeMethodInfoPtr_AllocSlot_Internal_Int32_RBTree_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, 100665019);
				RBTree<K>.TreePage.NativeMethodInfoPtr_get_InUseCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, 100665020);
				RBTree<K>.TreePage.NativeMethodInfoPtr_set_InUseCount_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, 100665021);
				RBTree<K>.TreePage.NativeMethodInfoPtr_get_PageId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, 100665022);
				RBTree<K>.TreePage.NativeMethodInfoPtr_set_PageId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr, 100665023);
			}

			// Token: 0x060014C9 RID: 5321 RVA: 0x00062F6C File Offset: 0x0006116C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 905688, RefRangeEnd = 905690, XrefRangeStart = 905656, XrefRangeEnd = 905688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TreePage(int size)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RBTree<K>.TreePage>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.TreePage.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060014CA RID: 5322 RVA: 0x00062FB4 File Offset: 0x000611B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 905694, RefRangeEnd = 905696, XrefRangeStart = 905690, XrefRangeEnd = 905694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int AllocSlot(RBTree<K> tree)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.TreePage.NativeMethodInfoPtr_AllocSlot_Internal_Int32_RBTree_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170004C1 RID: 1217
			// (get) Token: 0x060014CB RID: 5323 RVA: 0x00063004 File Offset: 0x00061204
			// (set) Token: 0x060014CC RID: 5324 RVA: 0x00063040 File Offset: 0x00061240
			public unsafe int InUseCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.TreePage.NativeMethodInfoPtr_get_InUseCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.TreePage.NativeMethodInfoPtr_set_InUseCount_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170004C2 RID: 1218
			// (get) Token: 0x060014CD RID: 5325 RVA: 0x00063080 File Offset: 0x00061280
			// (set) Token: 0x060014CE RID: 5326 RVA: 0x000630BC File Offset: 0x000612BC
			public unsafe int PageId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.TreePage.NativeMethodInfoPtr_get_PageId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.TreePage.NativeMethodInfoPtr_set_PageId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060014CF RID: 5327 RVA: 0x00007DDE File Offset: 0x00005FDE
			public TreePage(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004BC RID: 1212
			// (get) Token: 0x060014D0 RID: 5328 RVA: 0x000630FC File Offset: 0x000612FC
			// (set) Token: 0x060014D1 RID: 5329 RVA: 0x00007DE7 File Offset: 0x00005FE7
			public unsafe Il2CppReferenceArray<RBTree<K>.Node> _slots
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.TreePage.NativeFieldInfoPtr__slots);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RBTree<K>.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.TreePage.NativeFieldInfoPtr__slots), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004BD RID: 1213
			// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0006312C File Offset: 0x0006132C
			// (set) Token: 0x060014D3 RID: 5331 RVA: 0x00007E06 File Offset: 0x00006006
			public unsafe Il2CppStructArray<int> _slotMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.TreePage.NativeFieldInfoPtr__slotMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.TreePage.NativeFieldInfoPtr__slotMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004BE RID: 1214
			// (get) Token: 0x060014D4 RID: 5332 RVA: 0x0006315C File Offset: 0x0006135C
			// (set) Token: 0x060014D5 RID: 5333 RVA: 0x00007E25 File Offset: 0x00006025
			public unsafe int _inUseCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.TreePage.NativeFieldInfoPtr__inUseCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.TreePage.NativeFieldInfoPtr__inUseCount)) = value;
				}
			}

			// Token: 0x170004BF RID: 1215
			// (get) Token: 0x060014D6 RID: 5334 RVA: 0x00063184 File Offset: 0x00061384
			// (set) Token: 0x060014D7 RID: 5335 RVA: 0x00007E40 File Offset: 0x00006040
			public unsafe int _pageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.TreePage.NativeFieldInfoPtr__pageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.TreePage.NativeFieldInfoPtr__pageId)) = value;
				}
			}

			// Token: 0x170004C0 RID: 1216
			// (get) Token: 0x060014D8 RID: 5336 RVA: 0x000631AC File Offset: 0x000613AC
			// (set) Token: 0x060014D9 RID: 5337 RVA: 0x00007E5B File Offset: 0x0000605B
			public unsafe int _nextFreeSlotLine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.TreePage.NativeFieldInfoPtr__nextFreeSlotLine);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.TreePage.NativeFieldInfoPtr__nextFreeSlotLine)) = value;
				}
			}

			// Token: 0x04001155 RID: 4437
			private static readonly IntPtr NativeFieldInfoPtr__slots;

			// Token: 0x04001156 RID: 4438
			private static readonly IntPtr NativeFieldInfoPtr__slotMap;

			// Token: 0x04001157 RID: 4439
			private static readonly IntPtr NativeFieldInfoPtr__inUseCount;

			// Token: 0x04001158 RID: 4440
			private static readonly IntPtr NativeFieldInfoPtr__pageId;

			// Token: 0x04001159 RID: 4441
			private static readonly IntPtr NativeFieldInfoPtr__nextFreeSlotLine;

			// Token: 0x0400115A RID: 4442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x0400115B RID: 4443
			private static readonly IntPtr NativeMethodInfoPtr_AllocSlot_Internal_Int32_RBTree_1_K_0;

			// Token: 0x0400115C RID: 4444
			private static readonly IntPtr NativeMethodInfoPtr_get_InUseCount_Internal_get_Int32_0;

			// Token: 0x0400115D RID: 4445
			private static readonly IntPtr NativeMethodInfoPtr_set_InUseCount_Internal_set_Void_Int32_0;

			// Token: 0x0400115E RID: 4446
			private static readonly IntPtr NativeMethodInfoPtr_get_PageId_Internal_get_Int32_0;

			// Token: 0x0400115F RID: 4447
			private static readonly IntPtr NativeMethodInfoPtr_set_PageId_Internal_set_Void_Int32_0;
		}

		// Token: 0x020000E7 RID: 231
		public sealed class RBTreeEnumerator : ValueType
		{
			// Token: 0x060014DA RID: 5338 RVA: 0x000631D4 File Offset: 0x000613D4
			// Note: this type is marked as 'beforefieldinit'.
			static RBTreeEnumerator()
			{
				Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RBTree<K>>.NativeClassPtr, "RBTreeEnumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr);
				RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, "_tree");
				RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, "_version");
				RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, "_index");
				RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__mainTreeNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, "_mainTreeNodeId");
				RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, "_current");
				RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_RBTree_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, 100665024);
				RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_RBTree_1_K_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, 100665025);
				RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, 100665026);
				RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, 100665027);
				RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, 100665028);
				RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, 100665029);
				RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr, 100665030);
			}

			// Token: 0x060014DB RID: 5339 RVA: 0x0006332C File Offset: 0x0006152C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905696, XrefRangeEnd = 905697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RBTreeEnumerator(RBTree<K> tree)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_RBTree_1_K_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060014DC RID: 5340 RVA: 0x0006337C File Offset: 0x0006157C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 905701, RefRangeEnd = 905703, XrefRangeStart = 905697, XrefRangeEnd = 905701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RBTreeEnumerator(RBTree<K> tree, int position)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_RBTree_1_K_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014DD RID: 5341 RVA: 0x000633DC File Offset: 0x000615DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014DE RID: 5342 RVA: 0x00063414 File Offset: 0x00061614
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 905706, RefRangeEnd = 905713, XrefRangeStart = 905703, XrefRangeEnd = 905706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170004C8 RID: 1224
			// (get) Token: 0x060014DF RID: 5343 RVA: 0x00063458 File Offset: 0x00061658
			public unsafe K Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_K_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<K>(intPtr, false, true);
				}
			}

			// Token: 0x170004C9 RID: 1225
			// (get) Token: 0x060014E0 RID: 5344 RVA: 0x00063498 File Offset: 0x00061698
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905713, XrefRangeEnd = 905716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060014E1 RID: 5345 RVA: 0x000634DC File Offset: 0x000616DC
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBTree<K>.RBTreeEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014E2 RID: 5346 RVA: 0x00007E76 File Offset: 0x00006076
			public RBTreeEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060014E3 RID: 5347 RVA: 0x00007E7F File Offset: 0x0000607F
			public RBTreeEnumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RBTree<K>.RBTreeEnumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170004C3 RID: 1219
			// (get) Token: 0x060014E4 RID: 5348 RVA: 0x00063514 File Offset: 0x00061714
			// (set) Token: 0x060014E5 RID: 5349 RVA: 0x00007E91 File Offset: 0x00006091
			public unsafe RBTree<K> _tree
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__tree);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RBTree<K>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__tree), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004C4 RID: 1220
			// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00063544 File Offset: 0x00061744
			// (set) Token: 0x060014E7 RID: 5351 RVA: 0x00007EB0 File Offset: 0x000060B0
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170004C5 RID: 1221
			// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0006356C File Offset: 0x0006176C
			// (set) Token: 0x060014E9 RID: 5353 RVA: 0x00007ECB File Offset: 0x000060CB
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x170004C6 RID: 1222
			// (get) Token: 0x060014EA RID: 5354 RVA: 0x00063594 File Offset: 0x00061794
			// (set) Token: 0x060014EB RID: 5355 RVA: 0x00007EE6 File Offset: 0x000060E6
			public unsafe int _mainTreeNodeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__mainTreeNodeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__mainTreeNodeId)) = value;
				}
			}

			// Token: 0x170004C7 RID: 1223
			// (get) Token: 0x060014EC RID: 5356 RVA: 0x000635BC File Offset: 0x000617BC
			// (set) Token: 0x060014ED RID: 5357 RVA: 0x000635E4 File Offset: 0x000617E4
			public unsafe K _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__current);
					return IL2CPP.PointerToValueGeneric<K>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBTree<K>.RBTreeEnumerator.NativeFieldInfoPtr__current);
					Type typeFromHandle = typeof(K);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04001160 RID: 4448
			private static readonly IntPtr NativeFieldInfoPtr__tree;

			// Token: 0x04001161 RID: 4449
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04001162 RID: 4450
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04001163 RID: 4451
			private static readonly IntPtr NativeFieldInfoPtr__mainTreeNodeId;

			// Token: 0x04001164 RID: 4452
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x04001165 RID: 4453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RBTree_1_K_0;

			// Token: 0x04001166 RID: 4454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RBTree_1_K_Int32_0;

			// Token: 0x04001167 RID: 4455
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04001168 RID: 4456
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04001169 RID: 4457
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_K_0;

			// Token: 0x0400116A RID: 4458
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400116B RID: 4459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
