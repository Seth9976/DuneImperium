using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004C9 RID: 1225
	[Serializable]
	public class Queue : Object
	{
		// Token: 0x06004AE5 RID: 19173 RVA: 0x0015A274 File Offset: 0x00158474
		// Note: this type is marked as 'beforefieldinit'.
		static Queue()
		{
			Il2CppClassPointerStore<Queue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "Queue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Queue>.NativeClassPtr);
			Queue.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_array");
			Queue.NativeFieldInfoPtr__head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_head");
			Queue.NativeFieldInfoPtr__tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_tail");
			Queue.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_size");
			Queue.NativeFieldInfoPtr__growFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_growFactor");
			Queue.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_version");
			Queue.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue>.NativeClassPtr, "_syncRoot");
			Queue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674214);
			Queue.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674215);
			Queue.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674216);
			Queue.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674217);
			Queue.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674218);
			Queue.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674219);
			Queue.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674220);
			Queue.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674221);
			Queue.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674222);
			Queue.NativeMethodInfoPtr_Enqueue_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674223);
			Queue.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674224);
			Queue.NativeMethodInfoPtr_Dequeue_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674225);
			Queue.NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674226);
			Queue.NativeMethodInfoPtr_GetElement_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674227);
			Queue.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue>.NativeClassPtr, 100674228);
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x0015A45C File Offset: 0x0015865C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1415168, RefRangeEnd = 1415171, XrefRangeStart = 1415167, XrefRangeEnd = 1415168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x0015A498 File Offset: 0x00158698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415171, XrefRangeEnd = 1415172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x0015A4E0 File Offset: 0x001586E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1415177, RefRangeEnd = 1415181, XrefRangeStart = 1415172, XrefRangeEnd = 1415177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue(int capacity, float growFactor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x0015A538 File Offset: 0x00158738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415181, XrefRangeEnd = 1415197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Queue(ICollection col)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06004AEA RID: 19178 RVA: 0x0015A584 File Offset: 0x00158784
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x0015A5CC File Offset: 0x001587CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415197, XrefRangeEnd = 1415204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06004AEC RID: 19180 RVA: 0x0015A618 File Offset: 0x00158818
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06004AED RID: 19181 RVA: 0x0015A660 File Offset: 0x00158860
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415204, XrefRangeEnd = 1415209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x0015A6AC File Offset: 0x001588AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415209, XrefRangeEnd = 1415214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x0015A708 File Offset: 0x00158908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415214, XrefRangeEnd = 1415223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enqueue(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_Enqueue_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x0015A758 File Offset: 0x00158958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415223, XrefRangeEnd = 1415229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x0015A7A4 File Offset: 0x001589A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415229, XrefRangeEnd = 1415230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_Dequeue_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x0015A7F0 File Offset: 0x001589F0
		[CallerCount(0)]
		public unsafe virtual Object Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x0015A83C File Offset: 0x00158A3C
		[CallerCount(0)]
		public unsafe Object GetElement(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr_GetElement_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x0015A888 File Offset: 0x00158A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415230, XrefRangeEnd = 1415237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x0001B68A File Offset: 0x0001988A
		public Queue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x0015A8C8 File Offset: 0x00158AC8
		// (set) Token: 0x06004AF7 RID: 19191 RVA: 0x0001B693 File Offset: 0x00019893
		public unsafe Il2CppReferenceArray<Object> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06004AF8 RID: 19192 RVA: 0x0015A8F8 File Offset: 0x00158AF8
		// (set) Token: 0x06004AF9 RID: 19193 RVA: 0x0001B6B2 File Offset: 0x000198B2
		public unsafe int _head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__head);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__head)) = value;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06004AFA RID: 19194 RVA: 0x0015A920 File Offset: 0x00158B20
		// (set) Token: 0x06004AFB RID: 19195 RVA: 0x0001B6CD File Offset: 0x000198CD
		public unsafe int _tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__tail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__tail)) = value;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06004AFC RID: 19196 RVA: 0x0015A948 File Offset: 0x00158B48
		// (set) Token: 0x06004AFD RID: 19197 RVA: 0x0001B6E8 File Offset: 0x000198E8
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06004AFE RID: 19198 RVA: 0x0015A970 File Offset: 0x00158B70
		// (set) Token: 0x06004AFF RID: 19199 RVA: 0x0001B703 File Offset: 0x00019903
		public unsafe int _growFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__growFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__growFactor)) = value;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06004B00 RID: 19200 RVA: 0x0015A998 File Offset: 0x00158B98
		// (set) Token: 0x06004B01 RID: 19201 RVA: 0x0001B71E File Offset: 0x0001991E
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06004B02 RID: 19202 RVA: 0x0015A9C0 File Offset: 0x00158BC0
		// (set) Token: 0x06004B03 RID: 19203 RVA: 0x0001B739 File Offset: 0x00019939
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D55 RID: 15701
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04003D56 RID: 15702
		private static readonly IntPtr NativeFieldInfoPtr__head;

		// Token: 0x04003D57 RID: 15703
		private static readonly IntPtr NativeFieldInfoPtr__tail;

		// Token: 0x04003D58 RID: 15704
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04003D59 RID: 15705
		private static readonly IntPtr NativeFieldInfoPtr__growFactor;

		// Token: 0x04003D5A RID: 15706
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04003D5B RID: 15707
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003D5C RID: 15708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D5D RID: 15709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003D5E RID: 15710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;

		// Token: 0x04003D5F RID: 15711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_0;

		// Token: 0x04003D60 RID: 15712
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003D61 RID: 15713
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04003D62 RID: 15714
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003D63 RID: 15715
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x04003D64 RID: 15716
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04003D65 RID: 15717
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Virtual_New_Void_Object_0;

		// Token: 0x04003D66 RID: 15718
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04003D67 RID: 15719
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Virtual_New_Object_0;

		// Token: 0x04003D68 RID: 15720
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0;

		// Token: 0x04003D69 RID: 15721
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Internal_Object_Int32_0;

		// Token: 0x04003D6A RID: 15722
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0;

		// Token: 0x020006E3 RID: 1763
		[Serializable]
		public class QueueEnumerator : Object
		{
			// Token: 0x06005D8D RID: 23949 RVA: 0x001A7080 File Offset: 0x001A5280
			// Note: this type is marked as 'beforefieldinit'.
			static QueueEnumerator()
			{
				Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Queue>.NativeClassPtr, "QueueEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr);
				Queue.QueueEnumerator.NativeFieldInfoPtr__q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, "_q");
				Queue.QueueEnumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, "_index");
				Queue.QueueEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, "_version");
				Queue.QueueEnumerator.NativeFieldInfoPtr__currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, "_currentElement");
				Queue.QueueEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Queue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, 100674229);
				Queue.QueueEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, 100674230);
				Queue.QueueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, 100674231);
				Queue.QueueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, 100674232);
				Queue.QueueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr, 100674233);
			}

			// Token: 0x06005D8E RID: 23950 RVA: 0x001A7160 File Offset: 0x001A5360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415155, XrefRangeEnd = 1415158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QueueEnumerator(Queue q)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Queue.QueueEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.QueueEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Queue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005D8F RID: 23951 RVA: 0x001A71AC File Offset: 0x001A53AC
			[CallerCount(105)]
			[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Queue.QueueEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06005D90 RID: 23952 RVA: 0x001A71EC File Offset: 0x001A53EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415158, XrefRangeEnd = 1415159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.QueueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001802 RID: 6146
			// (get) Token: 0x06005D91 RID: 23953 RVA: 0x001A7234 File Offset: 0x001A5434
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.QueueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005D92 RID: 23954 RVA: 0x001A7280 File Offset: 0x001A5480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415159, XrefRangeEnd = 1415167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Queue.QueueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005D93 RID: 23955 RVA: 0x0002231B File Offset: 0x0002051B
			public QueueEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017FE RID: 6142
			// (get) Token: 0x06005D94 RID: 23956 RVA: 0x001A72BC File Offset: 0x001A54BC
			// (set) Token: 0x06005D95 RID: 23957 RVA: 0x00022324 File Offset: 0x00020524
			public unsafe Queue _q
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__q);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__q), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017FF RID: 6143
			// (get) Token: 0x06005D96 RID: 23958 RVA: 0x001A72EC File Offset: 0x001A54EC
			// (set) Token: 0x06005D97 RID: 23959 RVA: 0x00022343 File Offset: 0x00020543
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x17001800 RID: 6144
			// (get) Token: 0x06005D98 RID: 23960 RVA: 0x001A7314 File Offset: 0x001A5514
			// (set) Token: 0x06005D99 RID: 23961 RVA: 0x0002235E File Offset: 0x0002055E
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x17001801 RID: 6145
			// (get) Token: 0x06005D9A RID: 23962 RVA: 0x001A733C File Offset: 0x001A553C
			// (set) Token: 0x06005D9B RID: 23963 RVA: 0x00022379 File Offset: 0x00020579
			public unsafe Object _currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__currentElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Queue.QueueEnumerator.NativeFieldInfoPtr__currentElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004C4D RID: 19533
			private static readonly IntPtr NativeFieldInfoPtr__q;

			// Token: 0x04004C4E RID: 19534
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04004C4F RID: 19535
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004C50 RID: 19536
			private static readonly IntPtr NativeFieldInfoPtr__currentElement;

			// Token: 0x04004C51 RID: 19537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Queue_0;

			// Token: 0x04004C52 RID: 19538
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x04004C53 RID: 19539
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0;

			// Token: 0x04004C54 RID: 19540
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0;

			// Token: 0x04004C55 RID: 19541
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
		}

		// Token: 0x020006E4 RID: 1764
		public class QueueDebugView : Object
		{
			// Token: 0x06005D9C RID: 23964 RVA: 0x00022398 File Offset: 0x00020598
			// Note: this type is marked as 'beforefieldinit'.
			static QueueDebugView()
			{
				Il2CppClassPointerStore<Queue.QueueDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Queue>.NativeClassPtr, "QueueDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Queue.QueueDebugView>.NativeClassPtr);
			}

			// Token: 0x06005D9D RID: 23965 RVA: 0x000223B8 File Offset: 0x000205B8
			public QueueDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
