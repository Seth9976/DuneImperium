using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x020004D1 RID: 1233
	[Serializable]
	public class ConcurrentQueue<T> : Object
	{
		// Token: 0x06004C02 RID: 19458 RVA: 0x0015EE98 File Offset: 0x0015D098
		// Note: this type is marked as 'beforefieldinit'.
		static ConcurrentQueue()
		{
			Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "ConcurrentQueue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr);
			ConcurrentQueue<T>.NativeFieldInfoPtr_InitialSegmentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, "InitialSegmentLength");
			ConcurrentQueue<T>.NativeFieldInfoPtr_MaxSegmentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, "MaxSegmentLength");
			ConcurrentQueue<T>.NativeFieldInfoPtr__crossSegmentLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, "_crossSegmentLock");
			ConcurrentQueue<T>.NativeFieldInfoPtr__tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, "_tail");
			ConcurrentQueue<T>.NativeFieldInfoPtr__head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, "_head");
			ConcurrentQueue<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674558);
			ConcurrentQueue<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674559);
			ConcurrentQueue<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674560);
			ConcurrentQueue<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674561);
			ConcurrentQueue<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674562);
			ConcurrentQueue<T>.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674563);
			ConcurrentQueue<T>.NativeMethodInfoPtr_ToArray_Public_Virtual_Final_New_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674564);
			ConcurrentQueue<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674565);
			ConcurrentQueue<T>.NativeMethodInfoPtr_GetCount_Private_Static_Int32_Segment_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674566);
			ConcurrentQueue<T>.NativeMethodInfoPtr_GetCount_Private_Static_Int64_Segment_T_Int32_Segment_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674567);
			ConcurrentQueue<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674568);
			ConcurrentQueue<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674569);
			ConcurrentQueue<T>.NativeMethodInfoPtr_SnapForObservation_Private_Void_byref_Segment_T_byref_Int32_byref_Segment_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674570);
			ConcurrentQueue<T>.NativeMethodInfoPtr_GetItemWhenAvailable_Private_T_Segment_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674571);
			ConcurrentQueue<T>.NativeMethodInfoPtr_Enumerate_Private_IEnumerator_1_T_Segment_T_Int32_Segment_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674572);
			ConcurrentQueue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674573);
			ConcurrentQueue<T>.NativeMethodInfoPtr_EnqueueSlow_Private_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674574);
			ConcurrentQueue<T>.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674575);
			ConcurrentQueue<T>.NativeMethodInfoPtr_TryDequeueSlow_Private_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674576);
			ConcurrentQueue<T>.NativeMethodInfoPtr_TryPeek_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674577);
			ConcurrentQueue<T>.NativeMethodInfoPtr_TryPeek_Private_Boolean_byref_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674578);
			ConcurrentQueue<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, 100674579);
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x0015F120 File Offset: 0x0015D320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417470, RefRangeEnd = 1417471, XrefRangeStart = 1417377, XrefRangeEnd = 1417470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x0015F15C File Offset: 0x0015D35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417471, XrefRangeEnd = 1417477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06004C05 RID: 19461 RVA: 0x0015F1AC File Offset: 0x0015D3AC
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06004C06 RID: 19462 RVA: 0x0015F1E8 File Offset: 0x0015D3E8
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417477, XrefRangeEnd = 1417482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x0015F228 File Offset: 0x0015D428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417482, XrefRangeEnd = 1417513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06004C08 RID: 19464 RVA: 0x0015F268 File Offset: 0x0015D468
		public unsafe bool IsEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417513, XrefRangeEnd = 1417514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x0015F2A4 File Offset: 0x0015D4A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417542, RefRangeEnd = 1417543, XrefRangeStart = 1417514, XrefRangeEnd = 1417542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_ToArray_Public_Virtual_Final_New_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x0015F2DC File Offset: 0x0015D4DC
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417543, XrefRangeEnd = 1417558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x0015F318 File Offset: 0x0015D518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417558, XrefRangeEnd = 1417560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCount(ConcurrentQueue<T>.Segment s, int head, int tail)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref head;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_GetCount_Private_Static_Int32_Segment_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x0015F378 File Offset: 0x0015D578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417560, XrefRangeEnd = 1417569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetCount(ConcurrentQueue<T>.Segment head, int headHead, ConcurrentQueue<T>.Segment tail, int tailTail)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(head);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headHead;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tail);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tailTail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_GetCount_Private_Static_Int64_Segment_T_Int32_Segment_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x0015F3E8 File Offset: 0x0015D5E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417596, RefRangeEnd = 1417597, XrefRangeStart = 1417569, XrefRangeEnd = 1417596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x0015F438 File Offset: 0x0015D638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417597, XrefRangeEnd = 1417599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x0015F478 File Offset: 0x0015D678
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1417611, RefRangeEnd = 1417614, XrefRangeStart = 1417599, XrefRangeEnd = 1417611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SnapForObservation(out ConcurrentQueue<T>.Segment head, out int headHead, out ConcurrentQueue<T>.Segment tail, out int tailTail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &headHead;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tailTail;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_SnapForObservation_Private_Void_byref_Segment_T_byref_Int32_byref_Segment_T_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			head = ((intPtr5 == 0) ? null : new ConcurrentQueue<T>.Segment(intPtr5));
			IntPtr intPtr6 = intPtr2;
			tail = ((intPtr6 == 0) ? null : new ConcurrentQueue<T>.Segment(intPtr6));
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x0015F50C File Offset: 0x0015D70C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1417620, RefRangeEnd = 1417625, XrefRangeStart = 1417614, XrefRangeEnd = 1417620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetItemWhenAvailable(ConcurrentQueue<T>.Segment segment, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(segment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_GetItemWhenAvailable_Private_T_Segment_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x0015F564 File Offset: 0x0015D764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417625, XrefRangeEnd = 1417631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> Enumerate(ConcurrentQueue<T>.Segment head, int headHead, ConcurrentQueue<T>.Segment tail, int tailTail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(head);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headHead;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tail);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tailTail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_Enumerate_Private_IEnumerator_1_T_Segment_T_Int32_Segment_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x0015F5E4 File Offset: 0x0015D7E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1417634, RefRangeEnd = 1417636, XrefRangeStart = 1417631, XrefRangeEnd = 1417634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x0015F65C File Offset: 0x0015D85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417656, RefRangeEnd = 1417657, XrefRangeStart = 1417636, XrefRangeEnd = 1417656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnqueueSlow(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_EnqueueSlow_Private_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x0015F6D4 File Offset: 0x0015D8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417657, XrefRangeEnd = 1417659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryDequeue(out T result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref result;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x0015F760 File Offset: 0x0015D960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417659, XrefRangeEnd = 1417668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryDequeueSlow(out T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref item;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_TryDequeueSlow_Private_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					item = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x0015F7EC File Offset: 0x0015D9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417668, XrefRangeEnd = 1417675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryPeek(out T result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref result;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_TryPeek_Public_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x0015F878 File Offset: 0x0015DA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417675, XrefRangeEnd = 1417681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryPeek(out T result, bool resultUsed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref result;
				}
				ptr2 = intPtr2;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultUsed;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_TryPeek_Private_Boolean_byref_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x0015F910 File Offset: 0x0015DB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417681, XrefRangeEnd = 1417694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x0001BC56 File Offset: 0x00019E56
		public ConcurrentQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06004C1A RID: 19482 RVA: 0x0015F944 File Offset: 0x0015DB44
		// (set) Token: 0x06004C1B RID: 19483 RVA: 0x0001BC5F File Offset: 0x00019E5F
		public unsafe static int InitialSegmentLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ConcurrentQueue<T>.NativeFieldInfoPtr_InitialSegmentLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConcurrentQueue<T>.NativeFieldInfoPtr_InitialSegmentLength, (void*)(&value));
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06004C1C RID: 19484 RVA: 0x0015F960 File Offset: 0x0015DB60
		// (set) Token: 0x06004C1D RID: 19485 RVA: 0x0001BC6D File Offset: 0x00019E6D
		public unsafe static int MaxSegmentLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ConcurrentQueue<T>.NativeFieldInfoPtr_MaxSegmentLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConcurrentQueue<T>.NativeFieldInfoPtr_MaxSegmentLength, (void*)(&value));
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06004C1E RID: 19486 RVA: 0x0015F97C File Offset: 0x0015DB7C
		// (set) Token: 0x06004C1F RID: 19487 RVA: 0x0001BC7B File Offset: 0x00019E7B
		public unsafe Object _crossSegmentLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.NativeFieldInfoPtr__crossSegmentLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.NativeFieldInfoPtr__crossSegmentLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06004C20 RID: 19488 RVA: 0x0015F9AC File Offset: 0x0015DBAC
		// (set) Token: 0x06004C21 RID: 19489 RVA: 0x0001BC9A File Offset: 0x00019E9A
		public unsafe ConcurrentQueue<T>.Segment _tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.NativeFieldInfoPtr__tail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<T>.Segment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.NativeFieldInfoPtr__tail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06004C22 RID: 19490 RVA: 0x0015F9DC File Offset: 0x0015DBDC
		// (set) Token: 0x06004C23 RID: 19491 RVA: 0x0001BCB9 File Offset: 0x00019EB9
		public unsafe ConcurrentQueue<T>.Segment _head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.NativeFieldInfoPtr__head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<T>.Segment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.NativeFieldInfoPtr__head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E2D RID: 15917
		private static readonly IntPtr NativeFieldInfoPtr_InitialSegmentLength;

		// Token: 0x04003E2E RID: 15918
		private static readonly IntPtr NativeFieldInfoPtr_MaxSegmentLength;

		// Token: 0x04003E2F RID: 15919
		private static readonly IntPtr NativeFieldInfoPtr__crossSegmentLock;

		// Token: 0x04003E30 RID: 15920
		private static readonly IntPtr NativeFieldInfoPtr__tail;

		// Token: 0x04003E31 RID: 15921
		private static readonly IntPtr NativeFieldInfoPtr__head;

		// Token: 0x04003E32 RID: 15922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E33 RID: 15923
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003E34 RID: 15924
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003E35 RID: 15925
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003E36 RID: 15926
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003E37 RID: 15927
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x04003E38 RID: 15928
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_Final_New_Il2CppArrayBase_1_T_0;

		// Token: 0x04003E39 RID: 15929
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003E3A RID: 15930
		private static readonly IntPtr NativeMethodInfoPtr_GetCount_Private_Static_Int32_Segment_T_Int32_Int32_0;

		// Token: 0x04003E3B RID: 15931
		private static readonly IntPtr NativeMethodInfoPtr_GetCount_Private_Static_Int64_Segment_T_Int32_Segment_T_Int32_0;

		// Token: 0x04003E3C RID: 15932
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04003E3D RID: 15933
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04003E3E RID: 15934
		private static readonly IntPtr NativeMethodInfoPtr_SnapForObservation_Private_Void_byref_Segment_T_byref_Int32_byref_Segment_T_byref_Int32_0;

		// Token: 0x04003E3F RID: 15935
		private static readonly IntPtr NativeMethodInfoPtr_GetItemWhenAvailable_Private_T_Segment_T_Int32_0;

		// Token: 0x04003E40 RID: 15936
		private static readonly IntPtr NativeMethodInfoPtr_Enumerate_Private_IEnumerator_1_T_Segment_T_Int32_Segment_T_Int32_0;

		// Token: 0x04003E41 RID: 15937
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_T_0;

		// Token: 0x04003E42 RID: 15938
		private static readonly IntPtr NativeMethodInfoPtr_EnqueueSlow_Private_Void_T_0;

		// Token: 0x04003E43 RID: 15939
		private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_T_0;

		// Token: 0x04003E44 RID: 15940
		private static readonly IntPtr NativeMethodInfoPtr_TryDequeueSlow_Private_Boolean_byref_T_0;

		// Token: 0x04003E45 RID: 15941
		private static readonly IntPtr NativeMethodInfoPtr_TryPeek_Public_Boolean_byref_T_0;

		// Token: 0x04003E46 RID: 15942
		private static readonly IntPtr NativeMethodInfoPtr_TryPeek_Private_Boolean_byref_T_Boolean_0;

		// Token: 0x04003E47 RID: 15943
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x020006F7 RID: 1783
		public sealed class Segment : Object
		{
			// Token: 0x06005EC6 RID: 24262 RVA: 0x001AC464 File Offset: 0x001AA664
			// Note: this type is marked as 'beforefieldinit'.
			static Segment()
			{
				Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, "Segment"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr);
				ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, "_slots");
				ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__slotsMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, "_slotsMask");
				ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__headAndTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, "_headAndTail");
				ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__preservedForObservation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, "_preservedForObservation");
				ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__frozenForEnqueues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, "_frozenForEnqueues");
				ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__nextSegment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, "_nextSegment");
				ConcurrentQueue<T>.Segment.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, 100674580);
				ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_get_Capacity_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, 100674581);
				ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_get_FreezeOffset_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, 100674582);
				ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_EnsureFrozenForEnqueues_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, 100674583);
				ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, 100674584);
				ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_TryPeek_Public_Boolean_byref_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, 100674585);
				ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_TryEnqueue_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, 100674586);
			}

			// Token: 0x06005EC7 RID: 24263 RVA: 0x001AC5D0 File Offset: 0x001AA7D0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1417296, RefRangeEnd = 1417300, XrefRangeStart = 1417291, XrefRangeEnd = 1417296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Segment(int boundedLength)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref boundedLength;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.Segment.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700186C RID: 6252
			// (get) Token: 0x06005EC8 RID: 24264 RVA: 0x001AC618 File Offset: 0x001AA818
			public unsafe int Capacity
			{
				[CallerCount(39)]
				[CachedScanResults(RefRangeStart = 320461, RefRangeEnd = 320500, XrefRangeStart = 320461, XrefRangeEnd = 320500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_get_Capacity_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700186D RID: 6253
			// (get) Token: 0x06005EC9 RID: 24265 RVA: 0x001AC654 File Offset: 0x001AA854
			public unsafe int FreezeOffset
			{
				[CallerCount(16)]
				[CachedScanResults(RefRangeStart = 1417300, RefRangeEnd = 1417316, XrefRangeStart = 1417300, XrefRangeEnd = 1417300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_get_FreezeOffset_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005ECA RID: 24266 RVA: 0x001AC690 File Offset: 0x001AA890
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1417324, RefRangeEnd = 1417327, XrefRangeStart = 1417316, XrefRangeEnd = 1417324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EnsureFrozenForEnqueues()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_EnsureFrozenForEnqueues_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005ECB RID: 24267 RVA: 0x001AC6C4 File Offset: 0x001AA8C4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1417331, RefRangeEnd = 1417334, XrefRangeStart = 1417327, XrefRangeEnd = 1417331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryDequeue(out T item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					IntPtr intPtr2;
					if (!typeof(T).IsValueType)
					{
						intPtr = 0;
						intPtr2 = &intPtr;
					}
					else
					{
						intPtr2 = ref item;
					}
					ptr2 = intPtr2;
					IntPtr intPtr4;
					IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
					Il2CppException.RaiseExceptionIfNecessary(intPtr4);
					if (!typeof(T).IsValueType)
					{
						IntPtr intPtr5 = intPtr;
						item = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
					}
					return *IL2CPP.il2cpp_object_unbox(intPtr3);
				}
			}

			// Token: 0x06005ECC RID: 24268 RVA: 0x001AC750 File Offset: 0x001AA950
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1417344, RefRangeEnd = 1417345, XrefRangeStart = 1417334, XrefRangeEnd = 1417344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryPeek(out T result, bool resultUsed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr2;
					if (!typeof(T).IsValueType)
					{
						intPtr = 0;
						intPtr2 = &intPtr;
					}
					else
					{
						intPtr2 = ref result;
					}
					ptr2 = intPtr2;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultUsed;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_TryPeek_Public_Boolean_byref_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06005ECD RID: 24269 RVA: 0x001AC7E8 File Offset: 0x001AA9E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1417348, RefRangeEnd = 1417350, XrefRangeStart = 1417345, XrefRangeEnd = 1417348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryEnqueue(T item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = item;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>.Segment.NativeMethodInfoPtr_TryEnqueue_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005ECE RID: 24270 RVA: 0x000229B2 File Offset: 0x00020BB2
			public Segment(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001866 RID: 6246
			// (get) Token: 0x06005ECF RID: 24271 RVA: 0x001AC86C File Offset: 0x001AAA6C
			// (set) Token: 0x06005ED0 RID: 24272 RVA: 0x000229BB File Offset: 0x00020BBB
			public unsafe Il2CppReferenceArray<ConcurrentQueue<T>.Segment.Slot> _slots
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__slots);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConcurrentQueue<T>.Segment.Slot>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__slots), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001867 RID: 6247
			// (get) Token: 0x06005ED1 RID: 24273 RVA: 0x001AC89C File Offset: 0x001AAA9C
			// (set) Token: 0x06005ED2 RID: 24274 RVA: 0x000229DA File Offset: 0x00020BDA
			public unsafe int _slotsMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__slotsMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__slotsMask)) = value;
				}
			}

			// Token: 0x17001868 RID: 6248
			// (get) Token: 0x06005ED3 RID: 24275 RVA: 0x001AC8C4 File Offset: 0x001AAAC4
			// (set) Token: 0x06005ED4 RID: 24276 RVA: 0x000229F5 File Offset: 0x00020BF5
			public unsafe PaddedHeadAndTail _headAndTail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__headAndTail);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__headAndTail)) = value;
				}
			}

			// Token: 0x17001869 RID: 6249
			// (get) Token: 0x06005ED5 RID: 24277 RVA: 0x001AC8EC File Offset: 0x001AAAEC
			// (set) Token: 0x06005ED6 RID: 24278 RVA: 0x00022A10 File Offset: 0x00020C10
			public unsafe bool _preservedForObservation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__preservedForObservation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__preservedForObservation)) = value;
				}
			}

			// Token: 0x1700186A RID: 6250
			// (get) Token: 0x06005ED7 RID: 24279 RVA: 0x001AC914 File Offset: 0x001AAB14
			// (set) Token: 0x06005ED8 RID: 24280 RVA: 0x00022A2B File Offset: 0x00020C2B
			public unsafe bool _frozenForEnqueues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__frozenForEnqueues);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__frozenForEnqueues)) = value;
				}
			}

			// Token: 0x1700186B RID: 6251
			// (get) Token: 0x06005ED9 RID: 24281 RVA: 0x001AC93C File Offset: 0x001AAB3C
			// (set) Token: 0x06005EDA RID: 24282 RVA: 0x00022A46 File Offset: 0x00020C46
			public unsafe ConcurrentQueue<T>.Segment _nextSegment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__nextSegment);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<T>.Segment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.NativeFieldInfoPtr__nextSegment), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004D2F RID: 19759
			private static readonly IntPtr NativeFieldInfoPtr__slots;

			// Token: 0x04004D30 RID: 19760
			private static readonly IntPtr NativeFieldInfoPtr__slotsMask;

			// Token: 0x04004D31 RID: 19761
			private static readonly IntPtr NativeFieldInfoPtr__headAndTail;

			// Token: 0x04004D32 RID: 19762
			private static readonly IntPtr NativeFieldInfoPtr__preservedForObservation;

			// Token: 0x04004D33 RID: 19763
			private static readonly IntPtr NativeFieldInfoPtr__frozenForEnqueues;

			// Token: 0x04004D34 RID: 19764
			private static readonly IntPtr NativeFieldInfoPtr__nextSegment;

			// Token: 0x04004D35 RID: 19765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004D36 RID: 19766
			private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Internal_get_Int32_0;

			// Token: 0x04004D37 RID: 19767
			private static readonly IntPtr NativeMethodInfoPtr_get_FreezeOffset_Internal_get_Int32_0;

			// Token: 0x04004D38 RID: 19768
			private static readonly IntPtr NativeMethodInfoPtr_EnsureFrozenForEnqueues_Internal_Void_0;

			// Token: 0x04004D39 RID: 19769
			private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_T_0;

			// Token: 0x04004D3A RID: 19770
			private static readonly IntPtr NativeMethodInfoPtr_TryPeek_Public_Boolean_byref_T_Boolean_0;

			// Token: 0x04004D3B RID: 19771
			private static readonly IntPtr NativeMethodInfoPtr_TryEnqueue_Public_Boolean_T_0;

			// Token: 0x02000792 RID: 1938
			public sealed class Slot : ValueType
			{
				// Token: 0x06006335 RID: 25397 RVA: 0x001BA598 File Offset: 0x001B8798
				// Note: this type is marked as 'beforefieldinit'.
				static Slot()
				{
					Il2CppClassPointerStore<ConcurrentQueue<T>.Segment.Slot>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment>.NativeClassPtr, "Slot"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment.Slot>.NativeClassPtr);
					ConcurrentQueue<T>.Segment.Slot.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment.Slot>.NativeClassPtr, "Item");
					ConcurrentQueue<T>.Segment.Slot.NativeFieldInfoPtr_SequenceNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment.Slot>.NativeClassPtr, "SequenceNumber");
				}

				// Token: 0x06006336 RID: 25398 RVA: 0x0002528F File Offset: 0x0002348F
				public Slot(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06006337 RID: 25399 RVA: 0x00025298 File Offset: 0x00023498
				public Slot()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentQueue<T>.Segment.Slot>.NativeClassPtr))
				{
				}

				// Token: 0x1700199E RID: 6558
				// (get) Token: 0x06006338 RID: 25400 RVA: 0x001BA628 File Offset: 0x001B8828
				// (set) Token: 0x06006339 RID: 25401 RVA: 0x001BA650 File Offset: 0x001B8850
				public unsafe T Item
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.Slot.NativeFieldInfoPtr_Item);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.Slot.NativeFieldInfoPtr_Item);
						Type typeFromHandle = typeof(T);
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

				// Token: 0x1700199F RID: 6559
				// (get) Token: 0x0600633A RID: 25402 RVA: 0x001BA6F8 File Offset: 0x001B88F8
				// (set) Token: 0x0600633B RID: 25403 RVA: 0x000252AA File Offset: 0x000234AA
				public unsafe int SequenceNumber
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.Slot.NativeFieldInfoPtr_SequenceNumber);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>.Segment.Slot.NativeFieldInfoPtr_SequenceNumber)) = value;
					}
				}

				// Token: 0x040050FE RID: 20734
				private static readonly IntPtr NativeFieldInfoPtr_Item;

				// Token: 0x040050FF RID: 20735
				private static readonly IntPtr NativeFieldInfoPtr_SequenceNumber;
			}
		}

		// Token: 0x020006F8 RID: 1784
		[ObfuscatedName("System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__28")]
		public sealed class _Enumerate_d__28 : Object
		{
			// Token: 0x06005EDB RID: 24283 RVA: 0x001AC96C File Offset: 0x001AAB6C
			// Note: this type is marked as 'beforefieldinit'.
			static _Enumerate_d__28()
			{
				Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentQueue<T>>.NativeClassPtr, "<Enumerate>d__28"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr);
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "<>1__state");
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "<>2__current");
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "head");
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "tail");
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_tailTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "tailTail");
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_headHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "headHead");
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "<>4__this");
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__headTail_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "<headTail>5__2");
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "<i>5__3");
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__s_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "<s>5__4");
				ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, "<i>5__5");
				ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, 100674587);
				ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, 100674588);
				ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, 100674589);
				ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, 100674590);
				ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, 100674591);
				ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr, 100674592);
			}

			// Token: 0x06005EDC RID: 24284 RVA: 0x001ACB28 File Offset: 0x001AAD28
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Enumerate_d__28(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentQueue<T>._Enumerate_d__28>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005EDD RID: 24285 RVA: 0x001ACB70 File Offset: 0x001AAD70
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005EDE RID: 24286 RVA: 0x001ACBA4 File Offset: 0x001AADA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417350, XrefRangeEnd = 1417377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001879 RID: 6265
			// (get) Token: 0x06005EDF RID: 24287 RVA: 0x001ACBE0 File Offset: 0x001AADE0
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06005EE0 RID: 24288 RVA: 0x001ACC1C File Offset: 0x001AAE1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700187A RID: 6266
			// (get) Token: 0x06005EE1 RID: 24289 RVA: 0x001ACC50 File Offset: 0x001AAE50
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentQueue<T>._Enumerate_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005EE2 RID: 24290 RVA: 0x00022A65 File Offset: 0x00020C65
			public _Enumerate_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700186E RID: 6254
			// (get) Token: 0x06005EE3 RID: 24291 RVA: 0x001ACC90 File Offset: 0x001AAE90
			// (set) Token: 0x06005EE4 RID: 24292 RVA: 0x00022A6E File Offset: 0x00020C6E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700186F RID: 6255
			// (get) Token: 0x06005EE5 RID: 24293 RVA: 0x001ACCB8 File Offset: 0x001AAEB8
			// (set) Token: 0x06005EE6 RID: 24294 RVA: 0x001ACCE0 File Offset: 0x001AAEE0
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
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

			// Token: 0x17001870 RID: 6256
			// (get) Token: 0x06005EE7 RID: 24295 RVA: 0x001ACD88 File Offset: 0x001AAF88
			// (set) Token: 0x06005EE8 RID: 24296 RVA: 0x00022A89 File Offset: 0x00020C89
			public unsafe ConcurrentQueue<T>.Segment head
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_head);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<T>.Segment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001871 RID: 6257
			// (get) Token: 0x06005EE9 RID: 24297 RVA: 0x001ACDB8 File Offset: 0x001AAFB8
			// (set) Token: 0x06005EEA RID: 24298 RVA: 0x00022AA8 File Offset: 0x00020CA8
			public unsafe ConcurrentQueue<T>.Segment tail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_tail);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<T>.Segment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_tail), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001872 RID: 6258
			// (get) Token: 0x06005EEB RID: 24299 RVA: 0x001ACDE8 File Offset: 0x001AAFE8
			// (set) Token: 0x06005EEC RID: 24300 RVA: 0x00022AC7 File Offset: 0x00020CC7
			public unsafe int tailTail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_tailTail);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_tailTail)) = value;
				}
			}

			// Token: 0x17001873 RID: 6259
			// (get) Token: 0x06005EED RID: 24301 RVA: 0x001ACE10 File Offset: 0x001AB010
			// (set) Token: 0x06005EEE RID: 24302 RVA: 0x00022AE2 File Offset: 0x00020CE2
			public unsafe int headHead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_headHead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr_headHead)) = value;
				}
			}

			// Token: 0x17001874 RID: 6260
			// (get) Token: 0x06005EEF RID: 24303 RVA: 0x001ACE38 File Offset: 0x001AB038
			// (set) Token: 0x06005EF0 RID: 24304 RVA: 0x00022AFD File Offset: 0x00020CFD
			public unsafe ConcurrentQueue<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001875 RID: 6261
			// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x001ACE68 File Offset: 0x001AB068
			// (set) Token: 0x06005EF2 RID: 24306 RVA: 0x00022B1C File Offset: 0x00020D1C
			public unsafe int _headTail_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__headTail_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__headTail_5__2)) = value;
				}
			}

			// Token: 0x17001876 RID: 6262
			// (get) Token: 0x06005EF3 RID: 24307 RVA: 0x001ACE90 File Offset: 0x001AB090
			// (set) Token: 0x06005EF4 RID: 24308 RVA: 0x00022B37 File Offset: 0x00020D37
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x17001877 RID: 6263
			// (get) Token: 0x06005EF5 RID: 24309 RVA: 0x001ACEB8 File Offset: 0x001AB0B8
			// (set) Token: 0x06005EF6 RID: 24310 RVA: 0x00022B52 File Offset: 0x00020D52
			public unsafe ConcurrentQueue<T>.Segment _s_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__s_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<T>.Segment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__s_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001878 RID: 6264
			// (get) Token: 0x06005EF7 RID: 24311 RVA: 0x001ACEE8 File Offset: 0x001AB0E8
			// (set) Token: 0x06005EF8 RID: 24312 RVA: 0x00022B71 File Offset: 0x00020D71
			public unsafe int _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentQueue<T>._Enumerate_d__28.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04004D3C RID: 19772
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004D3D RID: 19773
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004D3E RID: 19774
			private static readonly IntPtr NativeFieldInfoPtr_head;

			// Token: 0x04004D3F RID: 19775
			private static readonly IntPtr NativeFieldInfoPtr_tail;

			// Token: 0x04004D40 RID: 19776
			private static readonly IntPtr NativeFieldInfoPtr_tailTail;

			// Token: 0x04004D41 RID: 19777
			private static readonly IntPtr NativeFieldInfoPtr_headHead;

			// Token: 0x04004D42 RID: 19778
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004D43 RID: 19779
			private static readonly IntPtr NativeFieldInfoPtr__headTail_5__2;

			// Token: 0x04004D44 RID: 19780
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04004D45 RID: 19781
			private static readonly IntPtr NativeFieldInfoPtr__s_5__4;

			// Token: 0x04004D46 RID: 19782
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04004D47 RID: 19783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004D48 RID: 19784
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004D49 RID: 19785
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004D4A RID: 19786
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x04004D4B RID: 19787
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004D4C RID: 19788
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
