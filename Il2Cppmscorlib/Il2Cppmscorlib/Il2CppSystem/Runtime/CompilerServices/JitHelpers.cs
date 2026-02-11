using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003DD RID: 989
	public static class JitHelpers : Object
	{
		// Token: 0x06003A11 RID: 14865 RVA: 0x0011815C File Offset: 0x0011635C
		// Note: this type is marked as 'beforefieldinit'.
		static JitHelpers()
		{
			Il2CppClassPointerStore<JitHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "JitHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr);
			JitHelpers.NativeMethodInfoPtr_UnsafeCast_Internal_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr, 100671960);
			JitHelpers.NativeMethodInfoPtr_UnsafeEnumCast_Internal_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr, 100671961);
			JitHelpers.NativeMethodInfoPtr_UnsafeEnumCastLong_Internal_Static_Int64_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr, 100671962);
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x001181C8 File Offset: 0x001163C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395802, XrefRangeEnd = 1395804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T UnsafeCast<T>(Object o) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JitHelpers.MethodInfoStoreGeneric_UnsafeCast_Internal_Static_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x00118208 File Offset: 0x00116408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1395809, RefRangeEnd = 1395812, XrefRangeStart = 1395804, XrefRangeEnd = 1395809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UnsafeEnumCast<T>(T val) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = val;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref val;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JitHelpers.MethodInfoStoreGeneric_UnsafeEnumCast_Internal_Static_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00118280 File Offset: 0x00116480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395812, XrefRangeEnd = 1395815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long UnsafeEnumCastLong<T>(T val) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = val;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref val;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JitHelpers.MethodInfoStoreGeneric_UnsafeEnumCastLong_Internal_Static_Int64_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x000159B5 File Offset: 0x00013BB5
		public JitHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002F0A RID: 12042
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeCast_Internal_Static_T_Object_0;

		// Token: 0x04002F0B RID: 12043
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeEnumCast_Internal_Static_Int32_T_0;

		// Token: 0x04002F0C RID: 12044
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeEnumCastLong_Internal_Static_Int64_T_0;

		// Token: 0x0200069E RID: 1694
		private sealed class MethodInfoStoreGeneric_UnsafeCast_Internal_Static_T_Object_0<T>
		{
			// Token: 0x04004AED RID: 19181
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JitHelpers.NativeMethodInfoPtr_UnsafeCast_Internal_Static_T_Object_0, Il2CppClassPointerStore<JitHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200069F RID: 1695
		private sealed class MethodInfoStoreGeneric_UnsafeEnumCast_Internal_Static_Int32_T_0<T>
		{
			// Token: 0x04004AEE RID: 19182
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JitHelpers.NativeMethodInfoPtr_UnsafeEnumCast_Internal_Static_Int32_T_0, Il2CppClassPointerStore<JitHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006A0 RID: 1696
		private sealed class MethodInfoStoreGeneric_UnsafeEnumCastLong_Internal_Static_Int64_T_0<T>
		{
			// Token: 0x04004AEF RID: 19183
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JitHelpers.NativeMethodInfoPtr_UnsafeEnumCastLong_Internal_Static_Int64_T_0, Il2CppClassPointerStore<JitHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
