using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x020000DC RID: 220
	public sealed class ReadOnlySpan<T> : ValueType
	{
		// Token: 0x06000E34 RID: 3636 RVA: 0x00068278 File Offset: 0x00066478
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlySpan()
		{
			Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ReadOnlySpan`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr);
			ReadOnlySpan<T>.NativeFieldInfoPtr__pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, "_pointer");
			ReadOnlySpan<T>.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, "_length");
			ReadOnlySpan<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665780);
			ReadOnlySpan<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665781);
			ReadOnlySpan<T>.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665782);
			ReadOnlySpan<T>.NativeMethodInfoPtr__ctor_Internal_Void_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665783);
			ReadOnlySpan<T>.NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665784);
			ReadOnlySpan<T>.NativeMethodInfoPtr_GetPinnableReference_Public_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665785);
			ReadOnlySpan<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665786);
			ReadOnlySpan<T>.NativeMethodInfoPtr_TryCopyTo_Public_Boolean_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665787);
			ReadOnlySpan<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665788);
			ReadOnlySpan<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665789);
			ReadOnlySpan<T>.NativeMethodInfoPtr_Slice_Public_ReadOnlySpan_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665790);
			ReadOnlySpan<T>.NativeMethodInfoPtr_Slice_Public_ReadOnlySpan_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665791);
			ReadOnlySpan<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665792);
			ReadOnlySpan<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665793);
			ReadOnlySpan<T>.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665794);
			ReadOnlySpan<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665795);
			ReadOnlySpan<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665796);
			ReadOnlySpan<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665797);
			ReadOnlySpan<T>.NativeMethodInfoPtr_get_Empty_Public_Static_get_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr, 100665798);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00068488 File Offset: 0x00066688
		[CallerCount(0)]
		public unsafe ReadOnlySpan(Il2CppArrayBase<T> array)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000684D8 File Offset: 0x000666D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318835, XrefRangeEnd = 1318838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlySpan(Il2CppArrayBase<T> array, int start, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00068544 File Offset: 0x00066744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318838, XrefRangeEnd = 1318839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlySpan(void* pointer, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000685A0 File Offset: 0x000667A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 643457, RefRangeEnd = 643459, XrefRangeStart = 643457, XrefRangeEnd = 643459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlySpan(ref T ptr, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr))
		{
			IntPtr* ptr2;
			IntPtr intPtr;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr3 = ref *ptr2;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(ptr);
				ptr3 = &intPtr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr__ctor_Internal_Void_byref_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ptr = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x1700023E RID: 574
		public unsafe ref T this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318839, XrefRangeEnd = 1318840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0006865C File Offset: 0x0006685C
		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 1318840, RefRangeEnd = 1318911, XrefRangeStart = 1318840, XrefRangeEnd = 1318840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ref T GetPinnableReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_GetPinnableReference_Public_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00068694 File Offset: 0x00066894
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1318916, RefRangeEnd = 1318927, XrefRangeStart = 1318911, XrefRangeEnd = 1318916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Span<T> destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Span_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000686E0 File Offset: 0x000668E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318927, XrefRangeEnd = 1318931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryCopyTo(Span<T> destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_TryCopyTo_Public_Boolean_Span_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00068738 File Offset: 0x00066938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1318931, RefRangeEnd = 1318933, XrefRangeStart = 1318931, XrefRangeEnd = 1318931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ReadOnlySpan<T> left, ReadOnlySpan<T> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00068798 File Offset: 0x00066998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318933, XrefRangeEnd = 1318952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x000687D4 File Offset: 0x000669D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318952, XrefRangeEnd = 1318954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlySpan<T> Slice(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_Slice_Public_ReadOnlySpan_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<T>(intPtr);
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00068820 File Offset: 0x00066A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318954, XrefRangeEnd = 1318956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlySpan<T> Slice(int start, int length)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_Slice_Public_ReadOnlySpan_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ReadOnlySpan<T>(intPtr);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00068878 File Offset: 0x00066A78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1318961, RefRangeEnd = 1318965, XrefRangeStart = 1318956, XrefRangeEnd = 1318961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x000688B4 File Offset: 0x00066AB4
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x000688F8 File Offset: 0x00066AF8
		public unsafe bool IsEmpty
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1318965, RefRangeEnd = 1318973, XrefRangeStart = 1318965, XrefRangeEnd = 1318965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0006893C File Offset: 0x00066B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318973, XrefRangeEnd = 1318978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00068990 File Offset: 0x00066B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318978, XrefRangeEnd = 1318983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x000689D4 File Offset: 0x00066BD4
		[CallerCount(110)]
		[CachedScanResults(RefRangeStart = 1318984, RefRangeEnd = 1319094, XrefRangeStart = 1318983, XrefRangeEnd = 1318984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ReadOnlySpan<T>(Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_T_Il2CppArrayBase_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<T>(intPtr);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00068A10 File Offset: 0x00066C10
		public unsafe static ReadOnlySpan<T> Empty
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1063114, RefRangeEnd = 1063118, XrefRangeStart = 1063114, XrefRangeEnd = 1063118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlySpan<T>.NativeMethodInfoPtr_get_Empty_Public_Static_get_ReadOnlySpan_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<T>(intPtr);
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00005727 File Offset: 0x00003927
		public ReadOnlySpan(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00005730 File Offset: 0x00003930
		public ReadOnlySpan()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlySpan<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00068A3C File Offset: 0x00066C3C
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00005742 File Offset: 0x00003942
		public ByReference<T> _pointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlySpan<T>.NativeFieldInfoPtr__pointer);
				return new ByReference<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ByReference<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlySpan<T>.NativeFieldInfoPtr__pointer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ByReference<T>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00068A6C File Offset: 0x00066C6C
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00005770 File Offset: 0x00003970
		public unsafe int _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlySpan<T>.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlySpan<T>.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeFieldInfoPtr__pointer;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_T_Int32_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_GetPinnableReference_Public_byref_T_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Span_1_T_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_TryCopyTo_Public_Boolean_Span_1_T_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_Slice_Public_ReadOnlySpan_1_T_Int32_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_Slice_Public_ReadOnlySpan_1_T_Int32_Int32_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_ReadOnlySpan_1_T_0;
	}
}
