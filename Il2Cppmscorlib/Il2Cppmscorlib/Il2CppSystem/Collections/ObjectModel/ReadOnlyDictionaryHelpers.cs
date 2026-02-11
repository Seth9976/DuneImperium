using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Collections.ObjectModel
{
	// Token: 0x020004DB RID: 1243
	public static class ReadOnlyDictionaryHelpers : Object
	{
		// Token: 0x06004D1D RID: 19741 RVA: 0x0001BF84 File Offset: 0x0001A184
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyDictionaryHelpers()
		{
			Il2CppClassPointerStore<ReadOnlyDictionaryHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.ObjectModel", "ReadOnlyDictionaryHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyDictionaryHelpers>.NativeClassPtr);
			ReadOnlyDictionaryHelpers.NativeMethodInfoPtr_CopyToNonGenericICollectionHelper_Internal_Static_Void_ICollection_1_T_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionaryHelpers>.NativeClassPtr, 100674832);
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x00165444 File Offset: 0x00163644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1419402, RefRangeEnd = 1419404, XrefRangeStart = 1419369, XrefRangeEnd = 1419402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyToNonGenericICollectionHelper<T>(ICollection<T> collection, Array array, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionaryHelpers.MethodInfoStoreGeneric_CopyToNonGenericICollectionHelper_Internal_Static_Void_ICollection_1_T_Array_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x0001BFBD File Offset: 0x0001A1BD
		public ReadOnlyDictionaryHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003F1D RID: 16157
		private static readonly IntPtr NativeMethodInfoPtr_CopyToNonGenericICollectionHelper_Internal_Static_Void_ICollection_1_T_Array_Int32_0;

		// Token: 0x02000701 RID: 1793
		private sealed class MethodInfoStoreGeneric_CopyToNonGenericICollectionHelper_Internal_Static_Void_ICollection_1_T_Array_Int32_0<T>
		{
			// Token: 0x04004D94 RID: 19860
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReadOnlyDictionaryHelpers.NativeMethodInfoPtr_CopyToNonGenericICollectionHelper_Internal_Static_Void_ICollection_1_T_Array_Int32_0, Il2CppClassPointerStore<ReadOnlyDictionaryHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
