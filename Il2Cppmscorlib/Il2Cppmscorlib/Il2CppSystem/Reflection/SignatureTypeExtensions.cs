using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200042D RID: 1069
	public static class SignatureTypeExtensions : Object
	{
		// Token: 0x06003D98 RID: 15768 RVA: 0x00127668 File Offset: 0x00125868
		// Note: this type is marked as 'beforefieldinit'.
		static SignatureTypeExtensions()
		{
			Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "SignatureTypeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr);
			SignatureTypeExtensions.NativeMethodInfoPtr_MatchesParameterTypeExactly_Public_Static_Boolean_Type_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672548);
			SignatureTypeExtensions.NativeMethodInfoPtr_MatchesExactly_Internal_Static_Boolean_SignatureType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672549);
			SignatureTypeExtensions.NativeMethodInfoPtr_TryResolveAgainstGenericMethod_Internal_Static_Type_SignatureType_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672550);
			SignatureTypeExtensions.NativeMethodInfoPtr_TryResolve_Private_Static_Type_SignatureType_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672551);
			SignatureTypeExtensions.NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672552);
			SignatureTypeExtensions.NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672553);
			SignatureTypeExtensions.NativeMethodInfoPtr_TryMakeByRefType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672554);
			SignatureTypeExtensions.NativeMethodInfoPtr_TryMakePointerType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672555);
			SignatureTypeExtensions.NativeMethodInfoPtr_TryMakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672556);
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x0012774C File Offset: 0x0012594C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1399573, RefRangeEnd = 1399575, XrefRangeStart = 1399569, XrefRangeEnd = 1399573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchesParameterTypeExactly(this Type pattern, ParameterInfo parameter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureTypeExtensions.NativeMethodInfoPtr_MatchesParameterTypeExactly_Public_Static_Boolean_Type_ParameterInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x001277A0 File Offset: 0x001259A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1399593, RefRangeEnd = 1399595, XrefRangeStart = 1399575, XrefRangeEnd = 1399593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchesExactly(this SignatureType pattern, Type actual)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureTypeExtensions.NativeMethodInfoPtr_MatchesExactly_Internal_Static_Boolean_SignatureType_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x001277F4 File Offset: 0x001259F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1399597, RefRangeEnd = 1399598, XrefRangeStart = 1399595, XrefRangeEnd = 1399597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type TryResolveAgainstGenericMethod(this SignatureType signatureType, MethodInfo genericMethod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(signatureType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericMethod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureTypeExtensions.NativeMethodInfoPtr_TryResolveAgainstGenericMethod_Internal_Static_Type_SignatureType_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x0012784C File Offset: 0x00125A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1399603, RefRangeEnd = 1399604, XrefRangeStart = 1399598, XrefRangeEnd = 1399603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type TryResolve(this SignatureType signatureType, Il2CppReferenceArray<Type> genericMethodParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(signatureType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericMethodParameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureTypeExtensions.NativeMethodInfoPtr_TryResolve_Private_Static_Type_SignatureType_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x001278A4 File Offset: 0x00125AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399604, XrefRangeEnd = 1399605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type TryMakeArrayType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureTypeExtensions.NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x001278E8 File Offset: 0x00125AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399605, XrefRangeEnd = 1399606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type TryMakeArrayType(this Type type, int rank)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureTypeExtensions.NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x0012793C File Offset: 0x00125B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399606, XrefRangeEnd = 1399607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type TryMakeByRefType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureTypeExtensions.NativeMethodInfoPtr_TryMakeByRefType_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00127980 File Offset: 0x00125B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399607, XrefRangeEnd = 1399608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type TryMakePointerType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureTypeExtensions.NativeMethodInfoPtr_TryMakePointerType_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x001279C4 File Offset: 0x00125BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399608, XrefRangeEnd = 1399609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type TryMakeGenericType(this Type type, Il2CppReferenceArray<Type> instantiation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instantiation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureTypeExtensions.NativeMethodInfoPtr_TryMakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x0001696F File Offset: 0x00014B6F
		public SignatureTypeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003253 RID: 12883
		private static readonly IntPtr NativeMethodInfoPtr_MatchesParameterTypeExactly_Public_Static_Boolean_Type_ParameterInfo_0;

		// Token: 0x04003254 RID: 12884
		private static readonly IntPtr NativeMethodInfoPtr_MatchesExactly_Internal_Static_Boolean_SignatureType_Type_0;

		// Token: 0x04003255 RID: 12885
		private static readonly IntPtr NativeMethodInfoPtr_TryResolveAgainstGenericMethod_Internal_Static_Type_SignatureType_MethodInfo_0;

		// Token: 0x04003256 RID: 12886
		private static readonly IntPtr NativeMethodInfoPtr_TryResolve_Private_Static_Type_SignatureType_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003257 RID: 12887
		private static readonly IntPtr NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_0;

		// Token: 0x04003258 RID: 12888
		private static readonly IntPtr NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_Int32_0;

		// Token: 0x04003259 RID: 12889
		private static readonly IntPtr NativeMethodInfoPtr_TryMakeByRefType_Private_Static_Type_Type_0;

		// Token: 0x0400325A RID: 12890
		private static readonly IntPtr NativeMethodInfoPtr_TryMakePointerType_Private_Static_Type_Type_0;

		// Token: 0x0400325B RID: 12891
		private static readonly IntPtr NativeMethodInfoPtr_TryMakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0;
	}
}
