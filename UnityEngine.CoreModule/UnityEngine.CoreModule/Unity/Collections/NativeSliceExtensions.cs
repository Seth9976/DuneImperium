using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections
{
	// Token: 0x02000041 RID: 65
	public static class NativeSliceExtensions : Object
	{
		// Token: 0x06000243 RID: 579 RVA: 0x0001C2C4 File Offset: 0x0001A4C4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSliceExtensions()
		{
			Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeSliceExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr);
			NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr, 100663484);
			NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr, 100663485);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0001C31C File Offset: 0x0001A51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643781, RefRangeEnd = 643782, XrefRangeStart = 643779, XrefRangeEnd = 643781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeSlice<T> Slice<T>(this NativeArray<T> thisArray, int start, int length) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(thisArray));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSliceExtensions.MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeSlice<T>(intPtr);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0001C37C File Offset: 0x0001A57C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 643784, RefRangeEnd = 643788, XrefRangeStart = 643782, XrefRangeEnd = 643784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeSlice<T> Slice<T>(this NativeSlice<T> thisSlice, int start, int length) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(thisSlice));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSliceExtensions.MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeSlice<T>(intPtr);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000032BD File Offset: 0x000014BD
		public NativeSliceExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001C3DC File Offset: 0x0001A5DC
		public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray) where T : struct
		{
			return new NativeSlice<T>(thisArray);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
		public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray, int start) where T : struct
		{
			return new NativeSlice<T>(thisArray, start);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001C410 File Offset: 0x0001A610
		public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice) where T : struct
		{
			return thisSlice;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001C424 File Offset: 0x0001A624
		public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice, int start) where T : struct
		{
			return new NativeSlice<T>(thisSlice, start);
		}

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0;

		// Token: 0x020003C6 RID: 966
		private sealed class MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04002AF0 RID: 10992
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003C7 RID: 967
		private sealed class MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04002AF1 RID: 10993
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
