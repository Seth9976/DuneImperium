using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200037C RID: 892
	public static class MemoryMarshal : Object
	{
		// Token: 0x06003775 RID: 14197 RVA: 0x0010F684 File Offset: 0x0010D884
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryMarshal()
		{
			Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "MemoryMarshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr);
			MemoryMarshal.NativeMethodInfoPtr_AsBytes_Public_Static_Span_1_Byte_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr, 100671607);
			MemoryMarshal.NativeMethodInfoPtr_AsBytes_Public_Static_ReadOnlySpan_1_Byte_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr, 100671608);
			MemoryMarshal.NativeMethodInfoPtr_AsMemory_Public_Static_Memory_1_T_ReadOnlyMemory_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr, 100671609);
			MemoryMarshal.NativeMethodInfoPtr_GetReference_Public_Static_byref_T_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr, 100671610);
			MemoryMarshal.NativeMethodInfoPtr_GetReference_Public_Static_byref_T_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr, 100671611);
			MemoryMarshal.NativeMethodInfoPtr_GetNonNullPinnableReference_Internal_Static_byref_T_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr, 100671612);
			MemoryMarshal.NativeMethodInfoPtr_GetNonNullPinnableReference_Internal_Static_byref_T_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr, 100671613);
			MemoryMarshal.NativeMethodInfoPtr_CreateReadOnlySpan_Public_Static_ReadOnlySpan_1_T_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr, 100671614);
			MemoryMarshal.NativeMethodInfoPtr_TryGetArray_Public_Static_Boolean_ReadOnlyMemory_1_T_byref_ArraySegment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr, 100671615);
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x0010F768 File Offset: 0x0010D968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391270, XrefRangeEnd = 1391272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Span<byte> AsBytes<T>(Span<T> span) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryMarshal.MethodInfoStoreGeneric_AsBytes_Public_Static_Span_1_Byte_Span_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Span<byte>(intPtr);
			}
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x0010F7AC File Offset: 0x0010D9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391272, XrefRangeEnd = 1391274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryMarshal.MethodInfoStoreGeneric_AsBytes_Public_Static_ReadOnlySpan_1_Byte_ReadOnlySpan_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<byte>(intPtr);
			}
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x0010F7F0 File Offset: 0x0010D9F0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Memory<T> AsMemory<T>(ReadOnlyMemory<T> memory)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(memory));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryMarshal.MethodInfoStoreGeneric_AsMemory_Public_Static_Memory_1_T_ReadOnlyMemory_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Memory<T>(intPtr);
			}
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x0010F834 File Offset: 0x0010DA34
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T GetReference<T>(Span<T> span)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryMarshal.MethodInfoStoreGeneric_GetReference_Public_Static_byref_T_Span_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x0010F870 File Offset: 0x0010DA70
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T GetReference<T>(ReadOnlySpan<T> span)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryMarshal.MethodInfoStoreGeneric_GetReference_Public_Static_byref_T_ReadOnlySpan_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x0010F8AC File Offset: 0x0010DAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391274, XrefRangeEnd = 1391275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T GetNonNullPinnableReference<T>(Span<T> span)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryMarshal.MethodInfoStoreGeneric_GetNonNullPinnableReference_Internal_Static_byref_T_Span_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x0010F8E8 File Offset: 0x0010DAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T GetNonNullPinnableReference<T>(ReadOnlySpan<T> span)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryMarshal.MethodInfoStoreGeneric_GetNonNullPinnableReference_Internal_Static_byref_T_ReadOnlySpan_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x0010F924 File Offset: 0x0010DB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391275, XrefRangeEnd = 1391276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(reference);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MemoryMarshal.MethodInfoStoreGeneric_CreateReadOnlySpan_Public_Static_ReadOnlySpan_1_T_byref_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			reference = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return new ReadOnlySpan<T>(intPtr2);
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0010F988 File Offset: 0x0010DB88
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1391282, RefRangeEnd = 1391290, XrefRangeStart = 1391276, XrefRangeEnd = 1391282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(memory));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MemoryMarshal.MethodInfoStoreGeneric_TryGetArray_Public_Static_Boolean_ReadOnlyMemory_1_T_byref_ArraySegment_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			segment = ((intPtr4 == 0) ? null : new ArraySegment<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x0001445F File Offset: 0x0001265F
		public MemoryMarshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D0A RID: 11530
		private static readonly IntPtr NativeMethodInfoPtr_AsBytes_Public_Static_Span_1_Byte_Span_1_T_0;

		// Token: 0x04002D0B RID: 11531
		private static readonly IntPtr NativeMethodInfoPtr_AsBytes_Public_Static_ReadOnlySpan_1_Byte_ReadOnlySpan_1_T_0;

		// Token: 0x04002D0C RID: 11532
		private static readonly IntPtr NativeMethodInfoPtr_AsMemory_Public_Static_Memory_1_T_ReadOnlyMemory_1_T_0;

		// Token: 0x04002D0D RID: 11533
		private static readonly IntPtr NativeMethodInfoPtr_GetReference_Public_Static_byref_T_Span_1_T_0;

		// Token: 0x04002D0E RID: 11534
		private static readonly IntPtr NativeMethodInfoPtr_GetReference_Public_Static_byref_T_ReadOnlySpan_1_T_0;

		// Token: 0x04002D0F RID: 11535
		private static readonly IntPtr NativeMethodInfoPtr_GetNonNullPinnableReference_Internal_Static_byref_T_Span_1_T_0;

		// Token: 0x04002D10 RID: 11536
		private static readonly IntPtr NativeMethodInfoPtr_GetNonNullPinnableReference_Internal_Static_byref_T_ReadOnlySpan_1_T_0;

		// Token: 0x04002D11 RID: 11537
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadOnlySpan_Public_Static_ReadOnlySpan_1_T_byref_T_Int32_0;

		// Token: 0x04002D12 RID: 11538
		private static readonly IntPtr NativeMethodInfoPtr_TryGetArray_Public_Static_Boolean_ReadOnlyMemory_1_T_byref_ArraySegment_1_T_0;

		// Token: 0x02000672 RID: 1650
		private sealed class MethodInfoStoreGeneric_AsBytes_Public_Static_Span_1_Byte_Span_1_T_0<T>
		{
			// Token: 0x04004A81 RID: 19073
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryMarshal.NativeMethodInfoPtr_AsBytes_Public_Static_Span_1_Byte_Span_1_T_0, Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000673 RID: 1651
		private sealed class MethodInfoStoreGeneric_AsBytes_Public_Static_ReadOnlySpan_1_Byte_ReadOnlySpan_1_T_0<T>
		{
			// Token: 0x04004A82 RID: 19074
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryMarshal.NativeMethodInfoPtr_AsBytes_Public_Static_ReadOnlySpan_1_Byte_ReadOnlySpan_1_T_0, Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000674 RID: 1652
		private sealed class MethodInfoStoreGeneric_AsMemory_Public_Static_Memory_1_T_ReadOnlyMemory_1_T_0<T>
		{
			// Token: 0x04004A83 RID: 19075
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryMarshal.NativeMethodInfoPtr_AsMemory_Public_Static_Memory_1_T_ReadOnlyMemory_1_T_0, Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000675 RID: 1653
		private sealed class MethodInfoStoreGeneric_GetReference_Public_Static_byref_T_Span_1_T_0<T>
		{
			// Token: 0x04004A84 RID: 19076
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryMarshal.NativeMethodInfoPtr_GetReference_Public_Static_byref_T_Span_1_T_0, Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000676 RID: 1654
		private sealed class MethodInfoStoreGeneric_GetReference_Public_Static_byref_T_ReadOnlySpan_1_T_0<T>
		{
			// Token: 0x04004A85 RID: 19077
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryMarshal.NativeMethodInfoPtr_GetReference_Public_Static_byref_T_ReadOnlySpan_1_T_0, Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000677 RID: 1655
		private sealed class MethodInfoStoreGeneric_GetNonNullPinnableReference_Internal_Static_byref_T_Span_1_T_0<T>
		{
			// Token: 0x04004A86 RID: 19078
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryMarshal.NativeMethodInfoPtr_GetNonNullPinnableReference_Internal_Static_byref_T_Span_1_T_0, Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000678 RID: 1656
		private sealed class MethodInfoStoreGeneric_GetNonNullPinnableReference_Internal_Static_byref_T_ReadOnlySpan_1_T_0<T>
		{
			// Token: 0x04004A87 RID: 19079
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryMarshal.NativeMethodInfoPtr_GetNonNullPinnableReference_Internal_Static_byref_T_ReadOnlySpan_1_T_0, Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000679 RID: 1657
		private sealed class MethodInfoStoreGeneric_CreateReadOnlySpan_Public_Static_ReadOnlySpan_1_T_byref_T_Int32_0<T>
		{
			// Token: 0x04004A88 RID: 19080
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryMarshal.NativeMethodInfoPtr_CreateReadOnlySpan_Public_Static_ReadOnlySpan_1_T_byref_T_Int32_0, Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200067A RID: 1658
		private sealed class MethodInfoStoreGeneric_TryGetArray_Public_Static_Boolean_ReadOnlyMemory_1_T_byref_ArraySegment_1_T_0<T>
		{
			// Token: 0x04004A89 RID: 19081
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryMarshal.NativeMethodInfoPtr_TryGetArray_Public_Static_Boolean_ReadOnlyMemory_1_T_byref_ArraySegment_1_T_0, Il2CppClassPointerStore<MemoryMarshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
