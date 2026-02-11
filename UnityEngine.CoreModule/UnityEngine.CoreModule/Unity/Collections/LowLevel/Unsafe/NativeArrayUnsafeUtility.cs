using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000052 RID: 82
	public static class NativeArrayUnsafeUtility : Object
	{
		// Token: 0x06000298 RID: 664 RVA: 0x0001D070 File Offset: 0x0001B270
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayUnsafeUtility()
		{
			Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeArrayUnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663523);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663524);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663525);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeBufferPointerWithoutChecks_Public_Static_ptr_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663526);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001D0F0 File Offset: 0x0001B2F0
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 643962, RefRangeEnd = 644001, XrefRangeStart = 643962, XrefRangeEnd = 643962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dataPointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<T>(intPtr);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001D144 File Offset: 0x0001B344
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafePtr<T>(this NativeArray<T> nativeArray) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeArray));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001D180 File Offset: 0x0001B380
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeArray<T> nativeArray) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeArray));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001D1BC File Offset: 0x0001B3BC
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeArray));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_GetUnsafeBufferPointerWithoutChecks_Public_Static_ptr_Void_NativeArray_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000366C File Offset: 0x0000186C
		public NativeArrayUnsafeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001D1F8 File Offset: 0x0001B3F8
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T>.ReadOnly nativeArray) where T : struct
		{
			return nativeArray.m_Buffer;
		}

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafeBufferPointerWithoutChecks_Public_Static_ptr_Void_NativeArray_1_T_0;

		// Token: 0x020003CE RID: 974
		private sealed class MethodInfoStoreGeneric_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0<T>
		{
			// Token: 0x04002B01 RID: 11009
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003CF RID: 975
		private sealed class MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002B02 RID: 11010
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003D0 RID: 976
		private sealed class MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002B03 RID: 11011
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003D1 RID: 977
		private sealed class MethodInfoStoreGeneric_GetUnsafeBufferPointerWithoutChecks_Public_Static_ptr_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002B04 RID: 11012
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeBufferPointerWithoutChecks_Public_Static_ptr_Void_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
