using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000053 RID: 83
	public static class NativeSliceUnsafeUtility : Object
	{
		// Token: 0x0600029F RID: 671 RVA: 0x0001D210 File Offset: 0x0001B410
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSliceUnsafeUtility()
		{
			Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeSliceUnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr);
			NativeSliceUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr, 100663527);
			NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr, 100663528);
			NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr, 100663529);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001D27C File Offset: 0x0001B47C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 644001, RefRangeEnd = 644003, XrefRangeStart = 644001, XrefRangeEnd = 644001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dataPointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSliceUnsafeUtility.MethodInfoStoreGeneric_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeSlice<T>(intPtr);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafePtr<T>(this NativeSlice<T> nativeSlice) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeSlice));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSliceUnsafeUtility.MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0001D30C File Offset: 0x0001B50C
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeSlice<T> nativeSlice) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeSlice));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSliceUnsafeUtility.MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00003675 File Offset: 0x00001875
		public NativeSliceUnsafeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0;

		// Token: 0x020003D2 RID: 978
		private sealed class MethodInfoStoreGeneric_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0<T>
		{
			// Token: 0x04002B05 RID: 11013
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003D3 RID: 979
		private sealed class MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>
		{
			// Token: 0x04002B06 RID: 11014
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0, Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003D4 RID: 980
		private sealed class MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>
		{
			// Token: 0x04002B07 RID: 11015
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0, Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
