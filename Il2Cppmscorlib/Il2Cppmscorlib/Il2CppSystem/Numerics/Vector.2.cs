using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Numerics
{
	// Token: 0x02000467 RID: 1127
	public static class Vector : Object
	{
		// Token: 0x0600436F RID: 17263 RVA: 0x0013DD20 File Offset: 0x0013BF20
		// Note: this type is marked as 'beforefieldinit'.
		static Vector()
		{
			Il2CppClassPointerStore<Vector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Numerics", "Vector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector>.NativeClassPtr);
			Vector.NativeMethodInfoPtr_Equals_Public_Static_Vector_1_T_Vector_1_T_Vector_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector>.NativeClassPtr, 100673256);
			Vector.NativeMethodInfoPtr_get_IsHardwareAccelerated_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector>.NativeClassPtr, 100673257);
			Vector.NativeMethodInfoPtr_AsVectorUInt64_Public_Static_Vector_1_UInt64_Vector_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector>.NativeClassPtr, 100673258);
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x0013DD8C File Offset: 0x0013BF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406412, XrefRangeEnd = 1406416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector.MethodInfoStoreGeneric_Equals_Public_Static_Vector_1_T_Vector_1_T_Vector_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Vector<T>(intPtr);
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06004371 RID: 17265 RVA: 0x0013DDE4 File Offset: 0x0013BFE4
		public unsafe static bool IsHardwareAccelerated
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector.NativeMethodInfoPtr_get_IsHardwareAccelerated_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x0013DE14 File Offset: 0x0013C014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406416, XrefRangeEnd = 1406420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector.MethodInfoStoreGeneric_AsVectorUInt64_Public_Static_Vector_1_UInt64_Vector_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Vector<ulong>(intPtr);
			}
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x00018711 File Offset: 0x00016911
		public Vector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400377D RID: 14205
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Vector_1_T_Vector_1_T_Vector_1_T_0;

		// Token: 0x0400377E RID: 14206
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHardwareAccelerated_Public_Static_get_Boolean_0;

		// Token: 0x0400377F RID: 14207
		private static readonly IntPtr NativeMethodInfoPtr_AsVectorUInt64_Public_Static_Vector_1_UInt64_Vector_1_T_0;

		// Token: 0x020006C8 RID: 1736
		private sealed class MethodInfoStoreGeneric_Equals_Public_Static_Vector_1_T_Vector_1_T_Vector_1_T_0<T>
		{
			// Token: 0x04004B52 RID: 19282
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Vector.NativeMethodInfoPtr_Equals_Public_Static_Vector_1_T_Vector_1_T_Vector_1_T_0, Il2CppClassPointerStore<Vector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006C9 RID: 1737
		private sealed class MethodInfoStoreGeneric_AsVectorUInt64_Public_Static_Vector_1_UInt64_Vector_1_T_0<T>
		{
			// Token: 0x04004B53 RID: 19283
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Vector.NativeMethodInfoPtr_AsVectorUInt64_Public_Static_Vector_1_UInt64_Vector_1_T_0, Il2CppClassPointerStore<Vector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
