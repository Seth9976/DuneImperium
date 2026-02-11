using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000074 RID: 116
	public class CaptureCollection : Object
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x0003751C File Offset: 0x0003571C
		// Note: this type is marked as 'beforefieldinit'.
		static CaptureCollection()
		{
			Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "CaptureCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr);
			CaptureCollection.NativeFieldInfoPtr__group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, "_group");
			CaptureCollection.NativeFieldInfoPtr__capcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, "_capcount");
			CaptureCollection.NativeFieldInfoPtr__captures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, "_captures");
			CaptureCollection.NativeMethodInfoPtr__ctor_Internal_Void_Group_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664444);
			CaptureCollection.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664445);
			CaptureCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664446);
			CaptureCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Capture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664447);
			CaptureCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664448);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Capture__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664449);
			CaptureCollection.NativeMethodInfoPtr_GetCapture_Private_Capture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664450);
			CaptureCollection.NativeMethodInfoPtr_ForceInitialized_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664451);
			CaptureCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664452);
			CaptureCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664453);
			CaptureCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664454);
			CaptureCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Capture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664455);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__IndexOf_Private_Virtual_Final_New_Int32_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664456);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__Insert_Private_Virtual_Final_New_Void_Int32_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664457);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664458);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__get_Item_Private_Virtual_Final_New_get_Capture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664459);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__set_Item_Private_Virtual_Final_New_set_Void_Int32_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664460);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Add_Private_Virtual_Final_New_Void_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664461);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664462);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Contains_Private_Virtual_Final_New_Boolean_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664463);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Remove_Private_Virtual_Final_New_Boolean_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664464);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664465);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664466);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664467);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664468);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664469);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664470);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664471);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664472);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664473);
			CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664474);
			CaptureCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100664475);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00037808 File Offset: 0x00035A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437333, XrefRangeEnd = 437335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaptureCollection(Group group)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr__ctor_Internal_Void_Group_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00037854 File Offset: 0x00035A54
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00037890 File Offset: 0x00035A90
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000201 RID: 513
		public unsafe virtual Capture this[int i]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 437336, RefRangeEnd = 437339, XrefRangeStart = 437335, XrefRangeEnd = 437336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Capture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Capture>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00037918 File Offset: 0x00035B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437339, XrefRangeEnd = 437344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00037958 File Offset: 0x00035B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437344, XrefRangeEnd = 437349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<Capture> System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Capture__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Capture__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Capture>>(intPtr3) : null;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00037998 File Offset: 0x00035B98
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 437349, RefRangeEnd = 437357, XrefRangeStart = 437349, XrefRangeEnd = 437349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Capture GetCapture(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_GetCapture_Private_Capture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Capture>(intPtr3) : null;
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000379E4 File Offset: 0x00035BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437357, XrefRangeEnd = 437368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_ForceInitialized_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00037A18 File Offset: 0x00035C18
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00037A54 File Offset: 0x00035C54
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00037A94 File Offset: 0x00035C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437368, XrefRangeEnd = 437370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00037AE4 File Offset: 0x00035CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437370, XrefRangeEnd = 437373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<Capture> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Capture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00037B34 File Offset: 0x00035D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437373, XrefRangeEnd = 437377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__IndexOf(Capture item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__IndexOf_Private_Virtual_Final_New_Int32_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00037B84 File Offset: 0x00035D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437377, XrefRangeEnd = 437383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__Insert(int index, Capture item)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__Insert_Private_Virtual_Final_New_Void_Int32_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00037BD4 File Offset: 0x00035DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437383, XrefRangeEnd = 437389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00037C14 File Offset: 0x00035E14
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00037C60 File Offset: 0x00035E60
		public unsafe virtual Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 437336, RefRangeEnd = 437339, XrefRangeStart = 437336, XrefRangeEnd = 437339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__get_Item_Private_Virtual_Final_New_get_Capture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Capture>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437389, XrefRangeEnd = 437395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__set_Item_Private_Virtual_Final_New_set_Void_Int32_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00037CB0 File Offset: 0x00035EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437395, XrefRangeEnd = 437401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Add(Capture item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Add_Private_Virtual_Final_New_Void_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00037CF4 File Offset: 0x00035EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437401, XrefRangeEnd = 437407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00037D28 File Offset: 0x00035F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437407, XrefRangeEnd = 437410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Contains(Capture item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Contains_Private_Virtual_Final_New_Boolean_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00037D78 File Offset: 0x00035F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437410, XrefRangeEnd = 437416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Remove(Capture item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Remove_Private_Virtual_Final_New_Boolean_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00037DC8 File Offset: 0x00035FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437416, XrefRangeEnd = 437422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00037E18 File Offset: 0x00036018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437422, XrefRangeEnd = 437428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00037E4C File Offset: 0x0003604C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437428, XrefRangeEnd = 437434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00037E9C File Offset: 0x0003609C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437434, XrefRangeEnd = 437439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00037EEC File Offset: 0x000360EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437439, XrefRangeEnd = 437445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00037F3C File Offset: 0x0003613C
		public unsafe virtual bool System.Collections.IList.IsFixedSize
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00037F78 File Offset: 0x00036178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437445, XrefRangeEnd = 437451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00037FBC File Offset: 0x000361BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437451, XrefRangeEnd = 437457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00037FFC File Offset: 0x000361FC
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00038048 File Offset: 0x00036248
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 437336, RefRangeEnd = 437339, XrefRangeStart = 437336, XrefRangeEnd = 437339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437457, XrefRangeEnd = 437463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00038098 File Offset: 0x00036298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437463, XrefRangeEnd = 437466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaptureCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0000447B File Offset: 0x0000267B
		public CaptureCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x000380D4 File Offset: 0x000362D4
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00004484 File Offset: 0x00002684
		public unsafe Group _group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Group>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00038104 File Offset: 0x00036304
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x000044A3 File Offset: 0x000026A3
		public unsafe int _capcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__capcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__capcount)) = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x0003812C File Offset: 0x0003632C
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x000044BE File Offset: 0x000026BE
		public unsafe Il2CppReferenceArray<Capture> _captures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__captures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Capture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__captures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr__group;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeFieldInfoPtr__capcount;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeFieldInfoPtr__captures;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Group_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Capture_Int32_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Text_RegularExpressions_Capture__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Capture_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_GetCapture_Private_Capture_Int32_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_ForceInitialized_Internal_Void_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Capture_Int32_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__IndexOf_Private_Virtual_Final_New_Int32_Capture_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__Insert_Private_Virtual_Final_New_Void_Int32_Capture_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__get_Item_Private_Virtual_Final_New_get_Capture_Int32_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_System_Text_RegularExpressions_Capture__set_Item_Private_Virtual_Final_New_set_Void_Int32_Capture_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Add_Private_Virtual_Final_New_Void_Capture_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Contains_Private_Virtual_Final_New_Boolean_Capture_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_System_Text_RegularExpressions_Capture__Remove_Private_Virtual_Final_New_Boolean_Capture_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x020002C8 RID: 712
		[Serializable]
		public sealed class Enumerator : Object
		{
			// Token: 0x06002B79 RID: 11129 RVA: 0x000C09A0 File Offset: 0x000BEBA0
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr);
				CaptureCollection.Enumerator.NativeFieldInfoPtr__collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr, "_collection");
				CaptureCollection.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr, "_index");
				CaptureCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_CaptureCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr, 100664476);
				CaptureCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr, 100664477);
				CaptureCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr, 100664478);
				CaptureCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr, 100664479);
				CaptureCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr, 100664480);
				CaptureCollection.Enumerator.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr, 100664481);
			}

			// Token: 0x06002B7A RID: 11130 RVA: 0x000C0A6C File Offset: 0x000BEC6C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 437321, RefRangeEnd = 437325, XrefRangeStart = 437319, XrefRangeEnd = 437321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(CaptureCollection collection)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaptureCollection.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_CaptureCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B7B RID: 11131 RVA: 0x000C0AB8 File Offset: 0x000BECB8
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DA8 RID: 3496
			// (get) Token: 0x06002B7C RID: 11132 RVA: 0x000C0AF4 File Offset: 0x000BECF4
			public unsafe Capture Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437325, XrefRangeEnd = 437333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Capture>(intPtr3) : null;
				}
			}

			// Token: 0x17000DA9 RID: 3497
			// (get) Token: 0x06002B7D RID: 11133 RVA: 0x000C0B34 File Offset: 0x000BED34
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B7E RID: 11134 RVA: 0x000C0B74 File Offset: 0x000BED74
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B7F RID: 11135 RVA: 0x000C0BA8 File Offset: 0x000BEDA8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.Enumerator.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B80 RID: 11136 RVA: 0x000138AC File Offset: 0x00011AAC
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DA6 RID: 3494
			// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000C0BDC File Offset: 0x000BEDDC
			// (set) Token: 0x06002B82 RID: 11138 RVA: 0x000138B5 File Offset: 0x00011AB5
			public unsafe CaptureCollection _collection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.Enumerator.NativeFieldInfoPtr__collection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CaptureCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.Enumerator.NativeFieldInfoPtr__collection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA7 RID: 3495
			// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000C0C0C File Offset: 0x000BEE0C
			// (set) Token: 0x06002B84 RID: 11140 RVA: 0x000138D4 File Offset: 0x00011AD4
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x0400225D RID: 8797
			private static readonly IntPtr NativeFieldInfoPtr__collection;

			// Token: 0x0400225E RID: 8798
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x0400225F RID: 8799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CaptureCollection_0;

			// Token: 0x04002260 RID: 8800
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002261 RID: 8801
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Capture_0;

			// Token: 0x04002262 RID: 8802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002263 RID: 8803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002264 RID: 8804
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
		}
	}
}
