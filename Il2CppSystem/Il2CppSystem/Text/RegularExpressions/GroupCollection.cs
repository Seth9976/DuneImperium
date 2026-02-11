using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000077 RID: 119
	[Serializable]
	public class GroupCollection : Object
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x000384BC File Offset: 0x000366BC
		// Note: this type is marked as 'beforefieldinit'.
		static GroupCollection()
		{
			Il2CppClassPointerStore<GroupCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "GroupCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr);
			GroupCollection.NativeFieldInfoPtr__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, "_match");
			GroupCollection.NativeFieldInfoPtr__captureMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, "_captureMap");
			GroupCollection.NativeFieldInfoPtr__groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, "_groups");
			GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_Match_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664487);
			GroupCollection.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664488);
			GroupCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664489);
			GroupCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664490);
			GroupCollection.NativeMethodInfoPtr_get_Item_Public_get_Group_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664491);
			GroupCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664492);
			GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Group__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Group_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664493);
			GroupCollection.NativeMethodInfoPtr_GetGroup_Private_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664494);
			GroupCollection.NativeMethodInfoPtr_GetGroupImpl_Private_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664495);
			GroupCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664496);
			GroupCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664497);
			GroupCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664498);
			GroupCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664499);
			GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__IndexOf_Private_Virtual_Final_New_Int32_Group_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664500);
			GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__Insert_Private_Virtual_Final_New_Void_Int32_Group_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664501);
			GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664502);
			GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__get_Item_Private_Virtual_Final_New_get_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664503);
			GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__set_Item_Private_Virtual_Final_New_set_Void_Int32_Group_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664504);
			GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Add_Private_Virtual_Final_New_Void_Group_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664505);
			GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664506);
			GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Contains_Private_Virtual_Final_New_Boolean_Group_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664507);
			GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Remove_Private_Virtual_Final_New_Boolean_Group_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664508);
			GroupCollection.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664509);
			GroupCollection.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664510);
			GroupCollection.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664511);
			GroupCollection.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664512);
			GroupCollection.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664513);
			GroupCollection.NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664514);
			GroupCollection.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664515);
			GroupCollection.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664516);
			GroupCollection.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664517);
			GroupCollection.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664518);
			GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664519);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000387BC File Offset: 0x000369BC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupCollection(Match match, Hashtable caps)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_Match_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x0003881C File Offset: 0x00036A1C
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00038858 File Offset: 0x00036A58
		public unsafe virtual int Count
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 437508, RefRangeEnd = 437511, XrefRangeStart = 437508, XrefRangeEnd = 437508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000213 RID: 531
		public unsafe virtual Group this[int groupnum]
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 437512, RefRangeEnd = 437530, XrefRangeStart = 437511, XrefRangeEnd = 437512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref groupnum;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000214 RID: 532
		public unsafe Group this[string groupname]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 437534, RefRangeEnd = 437540, XrefRangeStart = 437530, XrefRangeEnd = 437534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(groupname);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_Item_Public_get_Group_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00038930 File Offset: 0x00036B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437540, XrefRangeEnd = 437545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00038970 File Offset: 0x00036B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437545, XrefRangeEnd = 437550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<Group> System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Group__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Group__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Group_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Group>>(intPtr3) : null;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000389B0 File Offset: 0x00036BB0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 437594, RefRangeEnd = 437604, XrefRangeStart = 437550, XrefRangeEnd = 437594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group GetGroup(int groupnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref groupnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_GetGroup_Private_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000389FC File Offset: 0x00036BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 437634, RefRangeEnd = 437635, XrefRangeStart = 437604, XrefRangeEnd = 437634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group GetGroupImpl(int groupnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref groupnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_GetGroupImpl_Private_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00038A48 File Offset: 0x00036C48
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00038A84 File Offset: 0x00036C84
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00038AC4 File Offset: 0x00036CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437635, XrefRangeEnd = 437638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00038B14 File Offset: 0x00036D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437638, XrefRangeEnd = 437642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<Group> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00038B64 File Offset: 0x00036D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437642, XrefRangeEnd = 437647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_Generic_IList_System_Text_RegularExpressions_Group__IndexOf(Group item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__IndexOf_Private_Virtual_Final_New_Int32_Group_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00038BB4 File Offset: 0x00036DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437647, XrefRangeEnd = 437653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_IList_System_Text_RegularExpressions_Group__Insert(int index, Group item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__Insert_Private_Virtual_Final_New_Void_Int32_Group_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00038C04 File Offset: 0x00036E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437653, XrefRangeEnd = 437659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_IList_System_Text_RegularExpressions_Group__RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00038C44 File Offset: 0x00036E44
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00038C90 File Offset: 0x00036E90
		public unsafe virtual Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 437512, RefRangeEnd = 437530, XrefRangeStart = 437512, XrefRangeEnd = 437530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__get_Item_Private_Virtual_Final_New_get_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437659, XrefRangeEnd = 437665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__set_Item_Private_Virtual_Final_New_set_Void_Int32_Group_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00038CE0 File Offset: 0x00036EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437665, XrefRangeEnd = 437671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Add(Group item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Add_Private_Virtual_Final_New_Void_Group_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00038D24 File Offset: 0x00036F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437671, XrefRangeEnd = 437677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00038D58 File Offset: 0x00036F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437677, XrefRangeEnd = 437680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Contains(Group item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Contains_Private_Virtual_Final_New_Boolean_Group_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00038DA8 File Offset: 0x00036FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437680, XrefRangeEnd = 437686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Remove(Group item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Remove_Private_Virtual_Final_New_Boolean_Group_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00038DF8 File Offset: 0x00036FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437686, XrefRangeEnd = 437692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00038E48 File Offset: 0x00037048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437692, XrefRangeEnd = 437698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00038E7C File Offset: 0x0003707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437698, XrefRangeEnd = 437704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00038ECC File Offset: 0x000370CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437704, XrefRangeEnd = 437709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00038F1C File Offset: 0x0003711C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437709, XrefRangeEnd = 437715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Insert(int index, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00038F6C File Offset: 0x0003716C
		public unsafe virtual bool System.Collections.IList.IsFixedSize
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00038FA8 File Offset: 0x000371A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437715, XrefRangeEnd = 437721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00038FEC File Offset: 0x000371EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437721, XrefRangeEnd = 437727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0003902C File Offset: 0x0003722C
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00039078 File Offset: 0x00037278
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 437512, RefRangeEnd = 437530, XrefRangeStart = 437512, XrefRangeEnd = 437530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437727, XrefRangeEnd = 437733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000390C8 File Offset: 0x000372C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437733, XrefRangeEnd = 437736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00004579 File Offset: 0x00002779
		public GroupCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00039104 File Offset: 0x00037304
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00004582 File Offset: 0x00002782
		public unsafe Match _match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00039134 File Offset: 0x00037334
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x000045A1 File Offset: 0x000027A1
		public unsafe Hashtable _captureMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__captureMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__captureMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00039164 File Offset: 0x00037364
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x000045C0 File Offset: 0x000027C0
		public unsafe Il2CppReferenceArray<Group> _groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Group>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr__match;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeFieldInfoPtr__captureMap;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr__groups;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Match_Hashtable_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Group_Int32_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Group_String_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Group__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Group_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_GetGroup_Private_Group_Int32_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_GetGroupImpl_Private_Group_Int32_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Group_Int32_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__IndexOf_Private_Virtual_Final_New_Int32_Group_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__Insert_Private_Virtual_Final_New_Void_Int32_Group_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__get_Item_Private_Virtual_Final_New_get_Group_Int32_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Group__set_Item_Private_Virtual_Final_New_set_Void_Int32_Group_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Add_Private_Virtual_Final_New_Void_Group_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Contains_Private_Virtual_Final_New_Boolean_Group_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Group__Remove_Private_Virtual_Final_New_Boolean_Group_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x020002C9 RID: 713
		public sealed class Enumerator : Object
		{
			// Token: 0x06002B85 RID: 11141 RVA: 0x000C0C34 File Offset: 0x000BEE34
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr);
				GroupCollection.Enumerator.NativeFieldInfoPtr__collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr, "_collection");
				GroupCollection.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr, "_index");
				GroupCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_GroupCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr, 100664520);
				GroupCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr, 100664521);
				GroupCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Group_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr, 100664522);
				GroupCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr, 100664523);
				GroupCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr, 100664524);
				GroupCollection.Enumerator.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr, 100664525);
			}

			// Token: 0x06002B86 RID: 11142 RVA: 0x000C0D00 File Offset: 0x000BEF00
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 437321, RefRangeEnd = 437325, XrefRangeStart = 437321, XrefRangeEnd = 437325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(GroupCollection collection)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupCollection.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_GroupCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B87 RID: 11143 RVA: 0x000C0D4C File Offset: 0x000BEF4C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DAC RID: 3500
			// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000C0D88 File Offset: 0x000BEF88
			public unsafe Group Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437500, XrefRangeEnd = 437508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Group_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
				}
			}

			// Token: 0x17000DAD RID: 3501
			// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000C0DC8 File Offset: 0x000BEFC8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B8A RID: 11146 RVA: 0x000C0E08 File Offset: 0x000BF008
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B8B RID: 11147 RVA: 0x000C0E3C File Offset: 0x000BF03C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.Enumerator.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B8C RID: 11148 RVA: 0x000138EF File Offset: 0x00011AEF
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DAA RID: 3498
			// (get) Token: 0x06002B8D RID: 11149 RVA: 0x000C0E70 File Offset: 0x000BF070
			// (set) Token: 0x06002B8E RID: 11150 RVA: 0x000138F8 File Offset: 0x00011AF8
			public unsafe GroupCollection _collection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.Enumerator.NativeFieldInfoPtr__collection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.Enumerator.NativeFieldInfoPtr__collection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DAB RID: 3499
			// (get) Token: 0x06002B8F RID: 11151 RVA: 0x000C0EA0 File Offset: 0x000BF0A0
			// (set) Token: 0x06002B90 RID: 11152 RVA: 0x00013917 File Offset: 0x00011B17
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x04002265 RID: 8805
			private static readonly IntPtr NativeFieldInfoPtr__collection;

			// Token: 0x04002266 RID: 8806
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04002267 RID: 8807
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GroupCollection_0;

			// Token: 0x04002268 RID: 8808
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002269 RID: 8809
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Group_0;

			// Token: 0x0400226A RID: 8810
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400226B RID: 8811
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400226C RID: 8812
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
		}
	}
}
