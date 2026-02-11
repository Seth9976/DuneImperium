using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000F5 RID: 245
	public static class NativeArrayExtensions : Object
	{
		// Token: 0x0600139F RID: 5023 RVA: 0x0005964C File Offset: 0x0005784C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayExtensions()
		{
			Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "NativeArrayExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr);
			NativeArrayExtensions.NativeMethodInfoPtr_UnsafeElementAt_Public_Static_byref_T_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr, 100665765);
			NativeArrayExtensions.NativeMethodInfoPtr_UnsafeElementAtMutable_Public_Static_byref_T_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr, 100665766);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x000596A4 File Offset: 0x000578A4
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 622417, RefRangeEnd = 622437, XrefRangeStart = 622416, XrefRangeEnd = 622417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T UnsafeElementAt<T>(this NativeArray<T> array, int index) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayExtensions.MethodInfoStoreGeneric_UnsafeElementAt_Public_Static_byref_T_NativeArray_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x000596F0 File Offset: 0x000578F0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 622417, RefRangeEnd = 622437, XrefRangeStart = 622417, XrefRangeEnd = 622437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T UnsafeElementAtMutable<T>(this NativeArray<T> array, int index) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayExtensions.MethodInfoStoreGeneric_UnsafeElementAtMutable_Public_Static_byref_T_NativeArray_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0000B6FD File Offset: 0x000098FD
		public NativeArrayExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeElementAt_Public_Static_byref_T_NativeArray_1_T_Int32_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeElementAtMutable_Public_Static_byref_T_NativeArray_1_T_Int32_0;

		// Token: 0x020001D5 RID: 469
		private sealed class MethodInfoStoreGeneric_UnsafeElementAt_Public_Static_byref_T_NativeArray_1_T_Int32_0<T>
		{
			// Token: 0x04001766 RID: 5990
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayExtensions.NativeMethodInfoPtr_UnsafeElementAt_Public_Static_byref_T_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001D6 RID: 470
		private sealed class MethodInfoStoreGeneric_UnsafeElementAtMutable_Public_Static_byref_T_NativeArray_1_T_Int32_0<T>
		{
			// Token: 0x04001767 RID: 5991
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayExtensions.NativeMethodInfoPtr_UnsafeElementAtMutable_Public_Static_byref_T_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
