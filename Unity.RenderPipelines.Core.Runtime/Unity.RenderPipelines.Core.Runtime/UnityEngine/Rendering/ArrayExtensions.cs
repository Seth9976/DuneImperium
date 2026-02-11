using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using UnityEngine.Jobs;

namespace UnityEngine.Rendering
{
	// Token: 0x020000C4 RID: 196
	public static class ArrayExtensions : Object
	{
		// Token: 0x06000E49 RID: 3657 RVA: 0x00041A30 File Offset: 0x0003FC30
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayExtensions()
		{
			Il2CppClassPointerStore<ArrayExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ArrayExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayExtensions>.NativeClassPtr);
			ArrayExtensions.NativeMethodInfoPtr_ResizeArray_Public_Static_Void_byref_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayExtensions>.NativeClassPtr, 100665342);
			ArrayExtensions.NativeMethodInfoPtr_ResizeArray_Public_Static_Void_byref_TransformAccessArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayExtensions>.NativeClassPtr, 100665343);
			ArrayExtensions.NativeMethodInfoPtr_ResizeArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayExtensions>.NativeClassPtr, 100665344);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00041A9C File Offset: 0x0003FC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973921, RefRangeEnd = 973922, XrefRangeStart = 973917, XrefRangeEnd = 973921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeArray<T>(this NativeArray<T> array, int capacity) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayExtensions.MethodInfoStoreGeneric_ResizeArray_Public_Static_Void_byref_NativeArray_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00041AE4 File Offset: 0x0003FCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973922, XrefRangeEnd = 973929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeArray(this TransformAccessArray array, int capacity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayExtensions.NativeMethodInfoPtr_ResizeArray_Public_Static_Void_byref_TransformAccessArray_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00041B24 File Offset: 0x0003FD24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 973938, RefRangeEnd = 973943, XrefRangeStart = 973929, XrefRangeEnd = 973938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeArray<T>(ref Il2CppArrayBase<T> array, int capacity)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayExtensions.MethodInfoStoreGeneric_ResizeArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0000839C File Offset: 0x0000659C
		public ArrayExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_ResizeArray_Public_Static_Void_byref_NativeArray_1_T_Int32_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_ResizeArray_Public_Static_Void_byref_TransformAccessArray_Int32_0;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr_ResizeArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x020001F0 RID: 496
		private sealed class MethodInfoStoreGeneric_ResizeArray_Public_Static_Void_byref_NativeArray_1_T_Int32_0<T>
		{
			// Token: 0x04001345 RID: 4933
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayExtensions.NativeMethodInfoPtr_ResizeArray_Public_Static_Void_byref_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<ArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F1 RID: 497
		private sealed class MethodInfoStoreGeneric_ResizeArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04001346 RID: 4934
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayExtensions.NativeMethodInfoPtr_ResizeArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<ArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
