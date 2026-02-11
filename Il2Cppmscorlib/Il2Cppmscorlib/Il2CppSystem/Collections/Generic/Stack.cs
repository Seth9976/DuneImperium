using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004F8 RID: 1272
	[Serializable]
	public class Stack<T> : Object
	{
		// Token: 0x06004E8A RID: 20106 RVA: 0x0016CAE4 File Offset: 0x0016ACE4
		// Note: this type is marked as 'beforefieldinit'.
		static Stack()
		{
			Il2CppClassPointerStore<Stack<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "Stack`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr);
			Stack<T>.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "_array");
			Stack<T>.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "_size");
			Stack<T>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "_version");
			Stack<T>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "_syncRoot");
			Stack<T>.NativeFieldInfoPtr_DefaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "DefaultCapacity");
			Stack<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675115);
			Stack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675116);
			Stack<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675117);
			Stack<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675118);
			Stack<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675119);
			Stack<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675120);
			Stack<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675121);
			Stack<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675122);
			Stack<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675123);
			Stack<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675124);
			Stack<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675125);
			Stack<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675126);
			Stack<T>.NativeMethodInfoPtr_Peek_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675127);
			Stack<T>.NativeMethodInfoPtr_Pop_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675128);
			Stack<T>.NativeMethodInfoPtr_Push_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675129);
			Stack<T>.NativeMethodInfoPtr_PushWithResize_Private_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675130);
			Stack<T>.NativeMethodInfoPtr_ThrowForEmptyStack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100675131);
		}

		// Token: 0x06004E8B RID: 20107 RVA: 0x0016CD08 File Offset: 0x0016AF08
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 1425608, RefRangeEnd = 1425650, XrefRangeStart = 1425586, XrefRangeEnd = 1425608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x0016CD44 File Offset: 0x0016AF44
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1425485, RefRangeEnd = 1425500, XrefRangeStart = 1425485, XrefRangeEnd = 1425500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x0016CD8C File Offset: 0x0016AF8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1425713, RefRangeEnd = 1425715, XrefRangeStart = 1425650, XrefRangeEnd = 1425713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack(IEnumerable<T> collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06004E8E RID: 20110 RVA: 0x0016CDD8 File Offset: 0x0016AFD8
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06004E8F RID: 20111 RVA: 0x0016CE14 File Offset: 0x0016B014
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06004E90 RID: 20112 RVA: 0x0016CE50 File Offset: 0x0016B050
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425715, XrefRangeEnd = 1425720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x0016CE90 File Offset: 0x0016B090
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1415701, RefRangeEnd = 1415715, XrefRangeStart = 1415701, XrefRangeEnd = 1415715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x0016CEC4 File Offset: 0x0016B0C4
		[CallerCount(0)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x0016CF48 File Offset: 0x0016B148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425720, XrefRangeEnd = 1425726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x0016CF98 File Offset: 0x0016B198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425726, XrefRangeEnd = 1425727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Stack<T>.Enumerator(intPtr);
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x0016CFD0 File Offset: 0x0016B1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425727, XrefRangeEnd = 1425729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x0016D010 File Offset: 0x0016B210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x0016D050 File Offset: 0x0016B250
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1425729, RefRangeEnd = 1425738, XrefRangeStart = 1425729, XrefRangeEnd = 1425729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_Peek_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x0016D08C File Offset: 0x0016B28C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1425739, RefRangeEnd = 1425743, XrefRangeStart = 1425738, XrefRangeEnd = 1425739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_Pop_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x0016D0C8 File Offset: 0x0016B2C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1425744, RefRangeEnd = 1425749, XrefRangeStart = 1425743, XrefRangeEnd = 1425744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_Push_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x0016D140 File Offset: 0x0016B340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425752, RefRangeEnd = 1425753, XrefRangeStart = 1425749, XrefRangeEnd = 1425752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushWithResize(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_PushWithResize_Private_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x0016D1B8 File Offset: 0x0016B3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425753, XrefRangeEnd = 1425758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowForEmptyStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_ThrowForEmptyStack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x0001C5D5 File Offset: 0x0001A7D5
		public Stack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06004E9D RID: 20125 RVA: 0x0016D1EC File Offset: 0x0016B3EC
		// (set) Token: 0x06004E9E RID: 20126 RVA: 0x0001C5DE File Offset: 0x0001A7DE
		public unsafe Il2CppArrayBase<T> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__array);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06004E9F RID: 20127 RVA: 0x0016D214 File Offset: 0x0016B414
		// (set) Token: 0x06004EA0 RID: 20128 RVA: 0x0001C5FD File Offset: 0x0001A7FD
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06004EA1 RID: 20129 RVA: 0x0016D23C File Offset: 0x0016B43C
		// (set) Token: 0x06004EA2 RID: 20130 RVA: 0x0001C618 File Offset: 0x0001A818
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06004EA3 RID: 20131 RVA: 0x0016D264 File Offset: 0x0016B464
		// (set) Token: 0x06004EA4 RID: 20132 RVA: 0x0001C633 File Offset: 0x0001A833
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06004EA5 RID: 20133 RVA: 0x0016D294 File Offset: 0x0016B494
		// (set) Token: 0x06004EA6 RID: 20134 RVA: 0x0001C652 File Offset: 0x0001A852
		public unsafe static int DefaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Stack<T>.NativeFieldInfoPtr_DefaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stack<T>.NativeFieldInfoPtr_DefaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x04004025 RID: 16421
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04004026 RID: 16422
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04004027 RID: 16423
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04004028 RID: 16424
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04004029 RID: 16425
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCapacity;

		// Token: 0x0400402A RID: 16426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400402B RID: 16427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400402C RID: 16428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x0400402D RID: 16429
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400402E RID: 16430
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400402F RID: 16431
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004030 RID: 16432
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04004031 RID: 16433
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T_0;

		// Token: 0x04004032 RID: 16434
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04004033 RID: 16435
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x04004034 RID: 16436
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04004035 RID: 16437
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04004036 RID: 16438
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_T_0;

		// Token: 0x04004037 RID: 16439
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_T_0;

		// Token: 0x04004038 RID: 16440
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_T_0;

		// Token: 0x04004039 RID: 16441
		private static readonly IntPtr NativeMethodInfoPtr_PushWithResize_Private_Void_T_0;

		// Token: 0x0400403A RID: 16442
		private static readonly IntPtr NativeMethodInfoPtr_ThrowForEmptyStack_Private_Void_0;

		// Token: 0x0200070E RID: 1806
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06005FE3 RID: 24547 RVA: 0x001B0FAC File Offset: 0x001AF1AC
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr);
				Stack<T>.Enumerator.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, "_stack");
				Stack<T>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, "_version");
				Stack<T>.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, "_index");
				Stack<T>.Enumerator.NativeFieldInfoPtr__currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, "_currentElement");
				Stack<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Stack_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100675132);
				Stack<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100675133);
				Stack<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100675134);
				Stack<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100675135);
				Stack<T>.Enumerator.NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100675136);
				Stack<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100675137);
				Stack<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100675138);
			}

			// Token: 0x06005FE4 RID: 24548 RVA: 0x001B10F0 File Offset: 0x001AF2F0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1425563, RefRangeEnd = 1425566, XrefRangeStart = 1425562, XrefRangeEnd = 1425563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Stack<T> stack)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Stack_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005FE5 RID: 24549 RVA: 0x001B1140 File Offset: 0x001AF340
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1425566, RefRangeEnd = 1425568, XrefRangeStart = 1425566, XrefRangeEnd = 1425566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005FE6 RID: 24550 RVA: 0x001B1178 File Offset: 0x001AF378
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018CE RID: 6350
			// (get) Token: 0x06005FE7 RID: 24551 RVA: 0x001B11BC File Offset: 0x001AF3BC
			public unsafe T Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06005FE8 RID: 24552 RVA: 0x001B11FC File Offset: 0x001AF3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425568, XrefRangeEnd = 1425583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ThrowEnumerationNotStartedOrEnded()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018CF RID: 6351
			// (get) Token: 0x06005FE9 RID: 24553 RVA: 0x001B1234 File Offset: 0x001AF434
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425583, XrefRangeEnd = 1425586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005FEA RID: 24554 RVA: 0x001B1278 File Offset: 0x001AF478
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005FEB RID: 24555 RVA: 0x00023095 File Offset: 0x00021295
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005FEC RID: 24556 RVA: 0x0002309E File Offset: 0x0002129E
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170018CA RID: 6346
			// (get) Token: 0x06005FED RID: 24557 RVA: 0x001B12B0 File Offset: 0x001AF4B0
			// (set) Token: 0x06005FEE RID: 24558 RVA: 0x000230B0 File Offset: 0x000212B0
			public unsafe Stack<T> _stack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__stack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018CB RID: 6347
			// (get) Token: 0x06005FEF RID: 24559 RVA: 0x001B12E0 File Offset: 0x001AF4E0
			// (set) Token: 0x06005FF0 RID: 24560 RVA: 0x000230CF File Offset: 0x000212CF
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170018CC RID: 6348
			// (get) Token: 0x06005FF1 RID: 24561 RVA: 0x001B1308 File Offset: 0x001AF508
			// (set) Token: 0x06005FF2 RID: 24562 RVA: 0x000230EA File Offset: 0x000212EA
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x170018CD RID: 6349
			// (get) Token: 0x06005FF3 RID: 24563 RVA: 0x001B1330 File Offset: 0x001AF530
			// (set) Token: 0x06005FF4 RID: 24564 RVA: 0x001B1358 File Offset: 0x001AF558
			public unsafe T _currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__currentElement);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__currentElement);
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

			// Token: 0x04004DE8 RID: 19944
			private static readonly IntPtr NativeFieldInfoPtr__stack;

			// Token: 0x04004DE9 RID: 19945
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004DEA RID: 19946
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04004DEB RID: 19947
			private static readonly IntPtr NativeFieldInfoPtr__currentElement;

			// Token: 0x04004DEC RID: 19948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stack_1_T_0;

			// Token: 0x04004DED RID: 19949
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004DEE RID: 19950
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004DEF RID: 19951
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04004DF0 RID: 19952
			private static readonly IntPtr NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0;

			// Token: 0x04004DF1 RID: 19953
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004DF2 RID: 19954
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
