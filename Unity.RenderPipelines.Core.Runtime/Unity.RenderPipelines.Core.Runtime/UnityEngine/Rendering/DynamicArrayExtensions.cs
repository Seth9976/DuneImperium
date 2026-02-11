using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x02000040 RID: 64
	public static class DynamicArrayExtensions : Object
	{
		// Token: 0x06000516 RID: 1302 RVA: 0x000209D8 File Offset: 0x0001EBD8
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicArrayExtensions()
		{
			Il2CppClassPointerStore<DynamicArrayExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DynamicArrayExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicArrayExtensions>.NativeClassPtr);
			DynamicArrayExtensions.NativeMethodInfoPtr_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArrayExtensions>.NativeClassPtr, 100663958);
			DynamicArrayExtensions.NativeMethodInfoPtr_QuickSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArrayExtensions>.NativeClassPtr, 100663959);
			DynamicArrayExtensions.NativeMethodInfoPtr_QuickSort_Public_Static_Void_DynamicArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArrayExtensions>.NativeClassPtr, 100663960);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00020A44 File Offset: 0x0001EC44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959814, RefRangeEnd = 959815, XrefRangeStart = 959804, XrefRangeEnd = 959814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Partition<T>(Il2CppArrayBase<T> data, int left, int right) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArrayExtensions.MethodInfoStoreGeneric_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00020AA4 File Offset: 0x0001ECA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959819, RefRangeEnd = 959820, XrefRangeStart = 959815, XrefRangeEnd = 959819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuickSort<T>(Il2CppArrayBase<T> data, int left, int right) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArrayExtensions.MethodInfoStoreGeneric_QuickSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 959830, RefRangeEnd = 959834, XrefRangeStart = 959820, XrefRangeEnd = 959830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuickSort<T>(this DynamicArray<T> array) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArrayExtensions.MethodInfoStoreGeneric_QuickSort_Public_Static_Void_DynamicArray_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000040C5 File Offset: 0x000022C5
		public DynamicArrayExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_DynamicArray_1_T_0;

		// Token: 0x02000179 RID: 377
		private sealed class MethodInfoStoreGeneric_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04001028 RID: 4136
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicArrayExtensions.NativeMethodInfoPtr_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<DynamicArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017A RID: 378
		private sealed class MethodInfoStoreGeneric_QuickSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04001029 RID: 4137
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicArrayExtensions.NativeMethodInfoPtr_QuickSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<DynamicArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017B RID: 379
		private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_DynamicArray_1_T_0<T>
		{
			// Token: 0x0400102A RID: 4138
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicArrayExtensions.NativeMethodInfoPtr_QuickSort_Public_Static_Void_DynamicArray_1_T_0, Il2CppClassPointerStore<DynamicArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
