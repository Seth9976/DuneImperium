using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004F6 RID: 1270
	[Serializable]
	public class Queue<T> : Object
	{
		// Token: 0x06004E61 RID: 20065 RVA: 0x0016C05C File Offset: 0x0016A25C
		// Note: this type is marked as 'beforefieldinit'.
		static Queue()
		{
			Il2CppClassPointerStore<Queue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "Queue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr);
			Queue<T>.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_array");
			Queue<T>.NativeFieldInfoPtr__head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_head");
			Queue<T>.NativeFieldInfoPtr__tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_tail");
			Queue<T>.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_size");
			Queue<T>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_version");
			Queue<T>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "_syncRoot");
			Queue<T>.NativeFieldInfoPtr_MinimumGrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "MinimumGrow");
			Queue<T>.NativeFieldInfoPtr_GrowFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "GrowFactor");
			Queue<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675087);
			Queue<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675088);
			Queue<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675089);
			Queue<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675090);
			Queue<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675091);
			Queue<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675092);
			Queue<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675093);
			Queue<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675094);
			Queue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675095);
			Queue<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675096);
			Queue<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675097);
			Queue<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675098);
			Queue<T>.NativeMethodInfoPtr_Dequeue_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675099);
			Queue<T>.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675100);
			Queue<T>.NativeMethodInfoPtr_Peek_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675101);
			Queue<T>.NativeMethodInfoPtr_TryPeek_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675102);
			Queue<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675103);
			Queue<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675104);
			Queue<T>.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675105);
			Queue<T>.NativeMethodInfoPtr_MoveNext_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675106);
			Queue<T>.NativeMethodInfoPtr_ThrowForEmptyQueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, 100675107);
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x0016C30C File Offset: 0x0016A50C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1425464, RefRangeEnd = 1425470, XrefRangeStart = 1425461, XrefRangeEnd = 1425464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x0016C348 File Offset: 0x0016A548
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1425485, RefRangeEnd = 1425500, XrefRangeStart = 1425470, XrefRangeEnd = 1425485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x0016C390 File Offset: 0x0016A590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425500, XrefRangeEnd = 1425503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue(IEnumerable<T> collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06004E65 RID: 20069 RVA: 0x0016C3DC File Offset: 0x0016A5DC
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06004E66 RID: 20070 RVA: 0x0016C418 File Offset: 0x0016A618
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06004E67 RID: 20071 RVA: 0x0016C454 File Offset: 0x0016A654
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425503, XrefRangeEnd = 1425508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x0016C494 File Offset: 0x0016A694
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1425511, RefRangeEnd = 1425520, XrefRangeStart = 1425508, XrefRangeEnd = 1425511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x0016C4C8 File Offset: 0x0016A6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425520, XrefRangeEnd = 1425526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x0016C518 File Offset: 0x0016A718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1425533, RefRangeEnd = 1425535, XrefRangeStart = 1425526, XrefRangeEnd = 1425533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x0016C590 File Offset: 0x0016A790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425536, RefRangeEnd = 1425537, XrefRangeStart = 1425535, XrefRangeEnd = 1425536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Queue<T>.Enumerator(intPtr);
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x0016C5C8 File Offset: 0x0016A7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425537, XrefRangeEnd = 1425539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x0016C608 File Offset: 0x0016A808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x0016C648 File Offset: 0x0016A848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425540, RefRangeEnd = 1425541, XrefRangeStart = 1425539, XrefRangeEnd = 1425540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_Dequeue_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x0016C684 File Offset: 0x0016A884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425541, XrefRangeEnd = 1425543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x0016C710 File Offset: 0x0016A910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425543, RefRangeEnd = 1425544, XrefRangeStart = 1425543, XrefRangeEnd = 1425543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_Peek_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x0016C74C File Offset: 0x0016A94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425544, XrefRangeEnd = 1425545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_TryPeek_Public_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x0016C7D8 File Offset: 0x0016A9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425545, XrefRangeEnd = 1425546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x0016C85C File Offset: 0x0016AA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425546, XrefRangeEnd = 1425551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x0016C894 File Offset: 0x0016AA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425551, XrefRangeEnd = 1425557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x0016C8D4 File Offset: 0x0016AAD4
		[CallerCount(0)]
		public unsafe void MoveNext(ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_MoveNext_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x0016C914 File Offset: 0x0016AB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425557, XrefRangeEnd = 1425562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowForEmptyQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.NativeMethodInfoPtr_ThrowForEmptyQueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x0001C4FD File Offset: 0x0001A6FD
		public Queue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06004E78 RID: 20088 RVA: 0x0016C948 File Offset: 0x0016AB48
		// (set) Token: 0x06004E79 RID: 20089 RVA: 0x0001C506 File Offset: 0x0001A706
		public unsafe Il2CppArrayBase<T> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__array);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06004E7A RID: 20090 RVA: 0x0016C970 File Offset: 0x0016AB70
		// (set) Token: 0x06004E7B RID: 20091 RVA: 0x0001C525 File Offset: 0x0001A725
		public unsafe int _head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__head);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__head)) = value;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06004E7C RID: 20092 RVA: 0x0016C998 File Offset: 0x0016AB98
		// (set) Token: 0x06004E7D RID: 20093 RVA: 0x0001C540 File Offset: 0x0001A740
		public unsafe int _tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__tail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__tail)) = value;
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06004E7E RID: 20094 RVA: 0x0016C9C0 File Offset: 0x0016ABC0
		// (set) Token: 0x06004E7F RID: 20095 RVA: 0x0001C55B File Offset: 0x0001A75B
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06004E80 RID: 20096 RVA: 0x0016C9E8 File Offset: 0x0016ABE8
		// (set) Token: 0x06004E81 RID: 20097 RVA: 0x0001C576 File Offset: 0x0001A776
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06004E82 RID: 20098 RVA: 0x0016CA10 File Offset: 0x0016AC10
		// (set) Token: 0x06004E83 RID: 20099 RVA: 0x0001C591 File Offset: 0x0001A791
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06004E84 RID: 20100 RVA: 0x0016CA40 File Offset: 0x0016AC40
		// (set) Token: 0x06004E85 RID: 20101 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		public unsafe static int MinimumGrow
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Queue<T>.NativeFieldInfoPtr_MinimumGrow, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Queue<T>.NativeFieldInfoPtr_MinimumGrow, (void*)(&value));
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06004E86 RID: 20102 RVA: 0x0016CA5C File Offset: 0x0016AC5C
		// (set) Token: 0x06004E87 RID: 20103 RVA: 0x0001C5BE File Offset: 0x0001A7BE
		public unsafe static int GrowFactor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Queue<T>.NativeFieldInfoPtr_GrowFactor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Queue<T>.NativeFieldInfoPtr_GrowFactor, (void*)(&value));
			}
		}

		// Token: 0x04004008 RID: 16392
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04004009 RID: 16393
		private static readonly IntPtr NativeFieldInfoPtr__head;

		// Token: 0x0400400A RID: 16394
		private static readonly IntPtr NativeFieldInfoPtr__tail;

		// Token: 0x0400400B RID: 16395
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x0400400C RID: 16396
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x0400400D RID: 16397
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x0400400E RID: 16398
		private static readonly IntPtr NativeFieldInfoPtr_MinimumGrow;

		// Token: 0x0400400F RID: 16399
		private static readonly IntPtr NativeFieldInfoPtr_GrowFactor;

		// Token: 0x04004010 RID: 16400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004011 RID: 16401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004012 RID: 16402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x04004013 RID: 16403
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04004014 RID: 16404
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004015 RID: 16405
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004016 RID: 16406
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04004017 RID: 16407
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04004018 RID: 16408
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_T_0;

		// Token: 0x04004019 RID: 16409
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x0400401A RID: 16410
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x0400401B RID: 16411
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400401C RID: 16412
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_T_0;

		// Token: 0x0400401D RID: 16413
		private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_T_0;

		// Token: 0x0400401E RID: 16414
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_T_0;

		// Token: 0x0400401F RID: 16415
		private static readonly IntPtr NativeMethodInfoPtr_TryPeek_Public_Boolean_byref_T_0;

		// Token: 0x04004020 RID: 16416
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T_0;

		// Token: 0x04004021 RID: 16417
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04004022 RID: 16418
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0;

		// Token: 0x04004023 RID: 16419
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Void_byref_Int32_0;

		// Token: 0x04004024 RID: 16420
		private static readonly IntPtr NativeMethodInfoPtr_ThrowForEmptyQueue_Private_Void_0;

		// Token: 0x0200070D RID: 1805
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06005FD1 RID: 24529 RVA: 0x001B0B58 File Offset: 0x001AED58
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Queue<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr);
				Queue<T>.Enumerator.NativeFieldInfoPtr__q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, "_q");
				Queue<T>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, "_version");
				Queue<T>.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, "_index");
				Queue<T>.Enumerator.NativeFieldInfoPtr__currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, "_currentElement");
				Queue<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Queue_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100675108);
				Queue<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100675109);
				Queue<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100675110);
				Queue<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100675111);
				Queue<T>.Enumerator.NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100675112);
				Queue<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100675113);
				Queue<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr, 100675114);
			}

			// Token: 0x06005FD2 RID: 24530 RVA: 0x001B0C9C File Offset: 0x001AEE9C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1425445, RefRangeEnd = 1425448, XrefRangeStart = 1425444, XrefRangeEnd = 1425445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Queue<T> q)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Queue_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005FD3 RID: 24531 RVA: 0x001B0CEC File Offset: 0x001AEEEC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1425448, RefRangeEnd = 1425450, XrefRangeStart = 1425448, XrefRangeEnd = 1425448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005FD4 RID: 24532 RVA: 0x001B0D24 File Offset: 0x001AEF24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1425451, RefRangeEnd = 1425452, XrefRangeStart = 1425450, XrefRangeEnd = 1425451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018C8 RID: 6344
			// (get) Token: 0x06005FD5 RID: 24533 RVA: 0x001B0D68 File Offset: 0x001AEF68
			public unsafe T Current
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1425452, RefRangeEnd = 1425453, XrefRangeStart = 1425452, XrefRangeEnd = 1425452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06005FD6 RID: 24534 RVA: 0x001B0DA8 File Offset: 0x001AEFA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425453, XrefRangeEnd = 1425458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ThrowEnumerationNotStartedOrEnded()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018C9 RID: 6345
			// (get) Token: 0x06005FD7 RID: 24535 RVA: 0x001B0DE0 File Offset: 0x001AEFE0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425458, XrefRangeEnd = 1425461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005FD8 RID: 24536 RVA: 0x001B0E24 File Offset: 0x001AF024
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005FD9 RID: 24537 RVA: 0x00023025 File Offset: 0x00021225
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005FDA RID: 24538 RVA: 0x0002302E File Offset: 0x0002122E
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170018C4 RID: 6340
			// (get) Token: 0x06005FDB RID: 24539 RVA: 0x001B0E5C File Offset: 0x001AF05C
			// (set) Token: 0x06005FDC RID: 24540 RVA: 0x00023040 File Offset: 0x00021240
			public unsafe Queue<T> _q
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__q);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__q), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018C5 RID: 6341
			// (get) Token: 0x06005FDD RID: 24541 RVA: 0x001B0E8C File Offset: 0x001AF08C
			// (set) Token: 0x06005FDE RID: 24542 RVA: 0x0002305F File Offset: 0x0002125F
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170018C6 RID: 6342
			// (get) Token: 0x06005FDF RID: 24543 RVA: 0x001B0EB4 File Offset: 0x001AF0B4
			// (set) Token: 0x06005FE0 RID: 24544 RVA: 0x0002307A File Offset: 0x0002127A
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x170018C7 RID: 6343
			// (get) Token: 0x06005FE1 RID: 24545 RVA: 0x001B0EDC File Offset: 0x001AF0DC
			// (set) Token: 0x06005FE2 RID: 24546 RVA: 0x001B0F04 File Offset: 0x001AF104
			public unsafe T _currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__currentElement);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue<T>.Enumerator.NativeFieldInfoPtr__currentElement);
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

			// Token: 0x04004DDD RID: 19933
			private static readonly IntPtr NativeFieldInfoPtr__q;

			// Token: 0x04004DDE RID: 19934
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004DDF RID: 19935
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04004DE0 RID: 19936
			private static readonly IntPtr NativeFieldInfoPtr__currentElement;

			// Token: 0x04004DE1 RID: 19937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Queue_1_T_0;

			// Token: 0x04004DE2 RID: 19938
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004DE3 RID: 19939
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004DE4 RID: 19940
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04004DE5 RID: 19941
			private static readonly IntPtr NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0;

			// Token: 0x04004DE6 RID: 19942
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004DE7 RID: 19943
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
