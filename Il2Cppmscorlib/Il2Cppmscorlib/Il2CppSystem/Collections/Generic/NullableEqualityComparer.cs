using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000508 RID: 1288
	[Serializable]
	public class NullableEqualityComparer<T> : EqualityComparer<Nullable<T>> where T : new()
	{
		// Token: 0x06004F30 RID: 20272 RVA: 0x001704FC File Offset: 0x0016E6FC
		// Note: this type is marked as 'beforefieldinit'.
		static NullableEqualityComparer()
		{
			Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "NullableEqualityComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Nullable_1_T_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100675236);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100675237);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100675238);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100675239);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100675240);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100675241);
			NullableEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100675242);
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x001705F4 File Offset: 0x0016E7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426397, XrefRangeEnd = 1426398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Nullable<T> x, Nullable<T> y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Nullable_1_T_Nullable_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x00170668 File Offset: 0x0016E868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426398, XrefRangeEnd = 1426403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode(Nullable<T> obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Nullable_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x001706C8 File Offset: 0x0016E8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426403, XrefRangeEnd = 1426407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int IndexOf(Il2CppReferenceArray<Nullable<T>> array, Nullable<T> value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x00170754 File Offset: 0x0016E954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426407, XrefRangeEnd = 1426411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int LastIndexOf(Il2CppReferenceArray<Nullable<T>> array, Nullable<T> value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x001707E0 File Offset: 0x0016E9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426411, XrefRangeEnd = 1426412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x00170838 File Offset: 0x0016EA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x00170880 File Offset: 0x0016EA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426412, XrefRangeEnd = 1426415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullableEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x0001C7C3 File Offset: 0x0001A9C3
		public NullableEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400409C RID: 16540
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Nullable_1_T_Nullable_1_T_0;

		// Token: 0x0400409D RID: 16541
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Nullable_1_T_0;

		// Token: 0x0400409E RID: 16542
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0;

		// Token: 0x0400409F RID: 16543
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0;

		// Token: 0x040040A0 RID: 16544
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040040A1 RID: 16545
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040040A2 RID: 16546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
