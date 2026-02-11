using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004F2 RID: 1266
	public static class EnumerableHelpers : Object
	{
		// Token: 0x06004E2E RID: 20014 RVA: 0x0016B1B0 File Offset: 0x001693B0
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerableHelpers()
		{
			Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "EnumerableHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr);
			EnumerableHelpers.NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr, 100675061);
			EnumerableHelpers.NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr, 100675062);
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x0016B208 File Offset: 0x00169408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425249, RefRangeEnd = 1425250, XrefRangeStart = 1425243, XrefRangeEnd = 1425249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ToArray<T>(IEnumerable<T> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableHelpers.MethodInfoStoreGeneric_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x0016B244 File Offset: 0x00169444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425276, RefRangeEnd = 1425277, XrefRangeStart = 1425250, XrefRangeEnd = 1425276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ToArray<T>(IEnumerable<T> source, out int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableHelpers.MethodInfoStoreGeneric_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x0001C396 File Offset: 0x0001A596
		public EnumerableHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003FE8 RID: 16360
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0;

		// Token: 0x04003FE9 RID: 16361
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0;

		// Token: 0x02000707 RID: 1799
		private sealed class MethodInfoStoreGeneric_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x04004DD2 RID: 19922
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumerableHelpers.NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000708 RID: 1800
		private sealed class MethodInfoStoreGeneric_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0<T>
		{
			// Token: 0x04004DD3 RID: 19923
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumerableHelpers.NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0, Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
