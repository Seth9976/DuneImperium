using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Buffers;

namespace Il2CppSystem
{
	// Token: 0x020000C3 RID: 195
	public sealed class Memory<T> : ValueType
	{
		// Token: 0x06000CC6 RID: 3270 RVA: 0x00060EA8 File Offset: 0x0005F0A8
		// Note: this type is marked as 'beforefieldinit'.
		static Memory()
		{
			Il2CppClassPointerStore<Memory<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Memory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr);
			Memory<T>.NativeFieldInfoPtr__object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, "_object");
			Memory<T>.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, "_index");
			Memory<T>.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, "_length");
			Memory<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665534);
			Memory<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665535);
			Memory<T>.NativeMethodInfoPtr__ctor_Internal_Void_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665536);
			Memory<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Memory_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665537);
			Memory<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Memory_1_T_ArraySegment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665538);
			Memory<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyMemory_1_T_Memory_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665539);
			Memory<T>.NativeMethodInfoPtr_get_Empty_Public_Static_get_Memory_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665540);
			Memory<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665541);
			Memory<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665542);
			Memory<T>.NativeMethodInfoPtr_Slice_Public_Memory_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665543);
			Memory<T>.NativeMethodInfoPtr_get_Span_Public_get_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665544);
			Memory<T>.NativeMethodInfoPtr_Pin_Public_MemoryHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665545);
			Memory<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665546);
			Memory<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665547);
			Memory<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Memory_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665548);
			Memory<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665549);
			Memory<T>.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665550);
			Memory<T>.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr, 100665551);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x000610B8 File Offset: 0x0005F2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311078, XrefRangeEnd = 1311079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Memory(Il2CppArrayBase<T> array)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00061108 File Offset: 0x0005F308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311079, XrefRangeEnd = 1311083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Memory(Il2CppArrayBase<T> array, int start, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00061174 File Offset: 0x0005F374
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 745917, RefRangeEnd = 745928, XrefRangeStart = 745917, XrefRangeEnd = 745928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Memory(Object obj, int start, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr__ctor_Internal_Void_Object_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000611E0 File Offset: 0x0005F3E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1311085, RefRangeEnd = 1311092, XrefRangeStart = 1311083, XrefRangeEnd = 1311085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Memory<T>(Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Memory_1_T_Il2CppArrayBase_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Memory<T>(intPtr);
			}
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0006121C File Offset: 0x0005F41C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1311103, RefRangeEnd = 1311105, XrefRangeStart = 1311092, XrefRangeEnd = 1311103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Memory<T>(ArraySegment<T> segment)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Memory_1_T_ArraySegment_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Memory<T>(intPtr);
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00061260 File Offset: 0x0005F460
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ReadOnlyMemory<T>(Memory<T> memory)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(memory));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyMemory_1_T_Memory_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlyMemory<T>(intPtr);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000612A4 File Offset: 0x0005F4A4
		public unsafe static Memory<T> Empty
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1063114, RefRangeEnd = 1063118, XrefRangeStart = 1063114, XrefRangeEnd = 1063118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_get_Empty_Public_Static_get_Memory_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Memory<T>(intPtr);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x000612D0 File Offset: 0x0005F4D0
		public unsafe int Length
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1311105, RefRangeEnd = 1311123, XrefRangeStart = 1311105, XrefRangeEnd = 1311105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00061314 File Offset: 0x0005F514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311123, XrefRangeEnd = 1311143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00061350 File Offset: 0x0005F550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311143, XrefRangeEnd = 1311146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Memory<T> Slice(int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_Slice_Public_Memory_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Memory<T>(intPtr);
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000613A8 File Offset: 0x0005F5A8
		public unsafe Span<T> Span
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311146, XrefRangeEnd = 1311162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_get_Span_Public_get_Span_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Span<T>(intPtr);
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000613E4 File Offset: 0x0005F5E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1311183, RefRangeEnd = 1311188, XrefRangeStart = 1311162, XrefRangeEnd = 1311183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryHandle Pin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_Pin_Public_MemoryHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new MemoryHandle(intPtr);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00061420 File Offset: 0x0005F620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1311192, RefRangeEnd = 1311194, XrefRangeStart = 1311188, XrefRangeEnd = 1311192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0006145C File Offset: 0x0005F65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311194, XrefRangeEnd = 1311202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x000614B0 File Offset: 0x0005F6B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 629001, RefRangeEnd = 629003, XrefRangeStart = 629001, XrefRangeEnd = 629003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Memory<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Memory_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00061508 File Offset: 0x0005F708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311202, XrefRangeEnd = 1311207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0006154C File Offset: 0x0005F74C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786824, RefRangeEnd = 786825, XrefRangeStart = 786824, XrefRangeEnd = 786825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int left, int right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00061598 File Offset: 0x0005F798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311207, XrefRangeEnd = 1311209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2, int h3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory<T>.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00005207 File Offset: 0x00003407
		public Memory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00005210 File Offset: 0x00003410
		public Memory()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Memory<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000615F4 File Offset: 0x0005F7F4
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00005222 File Offset: 0x00003422
		public unsafe Object _object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Memory<T>.NativeFieldInfoPtr__object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Memory<T>.NativeFieldInfoPtr__object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00061624 File Offset: 0x0005F824
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x00005241 File Offset: 0x00003441
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Memory<T>.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Memory<T>.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0006164C File Offset: 0x0005F84C
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x0000525C File Offset: 0x0000345C
		public unsafe int _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Memory<T>.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Memory<T>.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeFieldInfoPtr__object;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Int32_Int32_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Memory_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Memory_1_T_ArraySegment_1_T_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyMemory_1_T_Memory_1_T_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_Memory_1_T_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_Slice_Public_Memory_1_T_Int32_Int32_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_get_Span_Public_get_Span_1_T_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_Pin_Public_MemoryHandle_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Memory_1_T_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_Int32_0;
	}
}
