using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Dynamic.Utils
{
	// Token: 0x0200012D RID: 301
	public static class TypeUtils : Object
	{
		// Token: 0x06001181 RID: 4481 RVA: 0x0005B8AC File Offset: 0x00059AAC
		// Note: this type is marked as 'beforefieldinit'.
		static TypeUtils()
		{
			Il2CppClassPointerStore<TypeUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "TypeUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr);
			TypeUtils.NativeFieldInfoPtr_s_arrayAssignableInterfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, "s_arrayAssignableInterfaces");
			TypeUtils.NativeMethodInfoPtr_GetNonNullableType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666614);
			TypeUtils.NativeMethodInfoPtr_GetNullableType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666615);
			TypeUtils.NativeMethodInfoPtr_IsNullableType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666616);
			TypeUtils.NativeMethodInfoPtr_IsNullableOrReferenceType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666617);
			TypeUtils.NativeMethodInfoPtr_IsBool_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666618);
			TypeUtils.NativeMethodInfoPtr_IsNumeric_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666619);
			TypeUtils.NativeMethodInfoPtr_IsInteger_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666620);
			TypeUtils.NativeMethodInfoPtr_IsArithmetic_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666621);
			TypeUtils.NativeMethodInfoPtr_IsUnsignedInt_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666622);
			TypeUtils.NativeMethodInfoPtr_IsIntegerOrBool_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666623);
			TypeUtils.NativeMethodInfoPtr_IsNumericOrBool_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666624);
			TypeUtils.NativeMethodInfoPtr_IsValidInstanceType_Public_Static_Boolean_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666625);
			TypeUtils.NativeMethodInfoPtr_HasIdentityPrimitiveOrNullableConversionTo_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666626);
			TypeUtils.NativeMethodInfoPtr_HasReferenceConversionTo_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666627);
			TypeUtils.NativeMethodInfoPtr_StrictHasReferenceConversionTo_Private_Static_Boolean_Type_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666628);
			TypeUtils.NativeMethodInfoPtr_HasArrayToInterfaceConversion_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666629);
			TypeUtils.NativeMethodInfoPtr_HasInterfaceToArrayConversion_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666630);
			TypeUtils.NativeMethodInfoPtr_IsCovariant_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666631);
			TypeUtils.NativeMethodInfoPtr_IsContravariant_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666632);
			TypeUtils.NativeMethodInfoPtr_IsInvariant_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666633);
			TypeUtils.NativeMethodInfoPtr_IsDelegate_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666634);
			TypeUtils.NativeMethodInfoPtr_IsLegalExplicitVariantDelegateConversion_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666635);
			TypeUtils.NativeMethodInfoPtr_IsConvertible_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666636);
			TypeUtils.NativeMethodInfoPtr_HasReferenceEquality_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666637);
			TypeUtils.NativeMethodInfoPtr_HasBuiltInEqualityOperator_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666638);
			TypeUtils.NativeMethodInfoPtr_IsImplicitlyConvertibleTo_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666639);
			TypeUtils.NativeMethodInfoPtr_GetUserDefinedCoercionMethod_Public_Static_MethodInfo_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666640);
			TypeUtils.NativeMethodInfoPtr_FindConversionOperator_Private_Static_MethodInfo_Il2CppReferenceArray_1_MethodInfo_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666641);
			TypeUtils.NativeMethodInfoPtr_IsImplicitNumericConversion_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666642);
			TypeUtils.NativeMethodInfoPtr_IsImplicitReferenceConversion_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666643);
			TypeUtils.NativeMethodInfoPtr_IsImplicitBoxingConversion_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666644);
			TypeUtils.NativeMethodInfoPtr_IsImplicitNullableConversion_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666645);
			TypeUtils.NativeMethodInfoPtr_FindGenericType_Public_Static_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666646);
			TypeUtils.NativeMethodInfoPtr_GetBooleanOperator_Public_Static_MethodInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666647);
			TypeUtils.NativeMethodInfoPtr_GetNonRefType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666648);
			TypeUtils.NativeMethodInfoPtr_AreEquivalent_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666649);
			TypeUtils.NativeMethodInfoPtr_AreReferenceAssignable_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666650);
			TypeUtils.NativeMethodInfoPtr_IsSameOrSubclass_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666651);
			TypeUtils.NativeMethodInfoPtr_ValidateType_Public_Static_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666652);
			TypeUtils.NativeMethodInfoPtr_ValidateType_Public_Static_Void_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666653);
			TypeUtils.NativeMethodInfoPtr_ValidateType_Public_Static_Boolean_Type_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666654);
			TypeUtils.NativeMethodInfoPtr_GetInvokeMethod_Public_Static_MethodInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, 100666655);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0005BC38 File Offset: 0x00059E38
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 1030462, RefRangeEnd = 1030516, XrefRangeStart = 1030458, XrefRangeEnd = 1030462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetNonNullableType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_GetNonNullableType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0005BC7C File Offset: 0x00059E7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1030532, RefRangeEnd = 1030535, XrefRangeStart = 1030516, XrefRangeEnd = 1030532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetNullableType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_GetNullableType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0005BCC0 File Offset: 0x00059EC0
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 1030537, RefRangeEnd = 1030591, XrefRangeStart = 1030535, XrefRangeEnd = 1030537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullableType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsNullableType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0005BD04 File Offset: 0x00059F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1030593, RefRangeEnd = 1030595, XrefRangeStart = 1030591, XrefRangeEnd = 1030593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullableOrReferenceType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsNullableOrReferenceType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0005BD48 File Offset: 0x00059F48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1030611, RefRangeEnd = 1030614, XrefRangeStart = 1030595, XrefRangeEnd = 1030611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBool(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsBool_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0005BD8C File Offset: 0x00059F8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1030628, RefRangeEnd = 1030631, XrefRangeStart = 1030614, XrefRangeEnd = 1030628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNumeric(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsNumeric_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0005BDD0 File Offset: 0x00059FD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1030645, RefRangeEnd = 1030648, XrefRangeStart = 1030631, XrefRangeEnd = 1030645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInteger(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsInteger_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0005BE14 File Offset: 0x0005A014
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1030662, RefRangeEnd = 1030669, XrefRangeStart = 1030648, XrefRangeEnd = 1030662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsArithmetic(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsArithmetic_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0005BE58 File Offset: 0x0005A058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1030683, RefRangeEnd = 1030685, XrefRangeStart = 1030669, XrefRangeEnd = 1030683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUnsignedInt(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsUnsignedInt_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0005BE9C File Offset: 0x0005A09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030685, XrefRangeEnd = 1030699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIntegerOrBool(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsIntegerOrBool_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0005BEE0 File Offset: 0x0005A0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030699, XrefRangeEnd = 1030703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNumericOrBool(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsNumericOrBool_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0005BF24 File Offset: 0x0005A124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1030759, RefRangeEnd = 1030761, XrefRangeStart = 1030703, XrefRangeEnd = 1030759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidInstanceType(MemberInfo member, Type instanceType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instanceType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsValidInstanceType_Public_Static_Boolean_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0005BF78 File Offset: 0x0005A178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1030790, RefRangeEnd = 1030791, XrefRangeStart = 1030761, XrefRangeEnd = 1030790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasIdentityPrimitiveOrNullableConversionTo(this Type source, Type dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_HasIdentityPrimitiveOrNullableConversionTo_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0005BFCC File Offset: 0x0005A1CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1030815, RefRangeEnd = 1030816, XrefRangeStart = 1030791, XrefRangeEnd = 1030815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasReferenceConversionTo(this Type source, Type dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_HasReferenceConversionTo_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0005C020 File Offset: 0x0005A220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1030848, RefRangeEnd = 1030850, XrefRangeStart = 1030816, XrefRangeEnd = 1030848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StrictHasReferenceConversionTo(this Type source, Type dest, bool skipNonArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipNonArray;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_StrictHasReferenceConversionTo_Private_Static_Boolean_Type_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0005C084 File Offset: 0x0005A284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1030865, RefRangeEnd = 1030866, XrefRangeStart = 1030850, XrefRangeEnd = 1030865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasArrayToInterfaceConversion(Type source, Type dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_HasArrayToInterfaceConversion_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0005C0D8 File Offset: 0x0005A2D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1030881, RefRangeEnd = 1030882, XrefRangeStart = 1030866, XrefRangeEnd = 1030881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasInterfaceToArrayConversion(Type source, Type dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_HasInterfaceToArrayConversion_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0005C12C File Offset: 0x0005A32C
		[CallerCount(0)]
		public unsafe static bool IsCovariant(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsCovariant_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0005C170 File Offset: 0x0005A370
		[CallerCount(0)]
		public unsafe static bool IsContravariant(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsContravariant_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0005C1B4 File Offset: 0x0005A3B4
		[CallerCount(0)]
		public unsafe static bool IsInvariant(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsInvariant_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0005C1F8 File Offset: 0x0005A3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030882, XrefRangeEnd = 1030889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDelegate(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsDelegate_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0005C23C File Offset: 0x0005A43C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1030924, RefRangeEnd = 1030926, XrefRangeStart = 1030889, XrefRangeEnd = 1030924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsLegalExplicitVariantDelegateConversion_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0005C290 File Offset: 0x0005A490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030926, XrefRangeEnd = 1030940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsConvertible(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsConvertible_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0005C2D4 File Offset: 0x0005A4D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1030951, RefRangeEnd = 1030953, XrefRangeStart = 1030940, XrefRangeEnd = 1030951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasReferenceEquality(Type left, Type right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_HasReferenceEquality_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0005C328 File Offset: 0x0005A528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030953, XrefRangeEnd = 1030968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasBuiltInEqualityOperator(Type left, Type right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_HasBuiltInEqualityOperator_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0005C37C File Offset: 0x0005A57C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1030988, RefRangeEnd = 1030989, XrefRangeStart = 1030968, XrefRangeEnd = 1030988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsImplicitlyConvertibleTo(this Type source, Type destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsImplicitlyConvertibleTo_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0005C3D0 File Offset: 0x0005A5D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031017, RefRangeEnd = 1031019, XrefRangeStart = 1030989, XrefRangeEnd = 1031017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(convertFrom);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(convertToType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_GetUserDefinedCoercionMethod_Public_Static_MethodInfo_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0005C428 File Offset: 0x0005A628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031037, RefRangeEnd = 1031039, XrefRangeStart = 1031019, XrefRangeEnd = 1031037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo FindConversionOperator(Il2CppReferenceArray<MethodInfo> methods, Type typeFrom, Type typeTo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methods);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeTo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_FindConversionOperator_Private_Static_MethodInfo_Il2CppReferenceArray_1_MethodInfo_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0005C490 File Offset: 0x0005A690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031039, XrefRangeEnd = 1031050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsImplicitNumericConversion(Type source, Type destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsImplicitNumericConversion_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0005C4E4 File Offset: 0x0005A6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsImplicitReferenceConversion(Type source, Type destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsImplicitReferenceConversion_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0005C538 File Offset: 0x0005A738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031050, XrefRangeEnd = 1031065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsImplicitBoxingConversion(Type source, Type destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsImplicitBoxingConversion_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0005C58C File Offset: 0x0005A78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031065, XrefRangeEnd = 1031069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsImplicitNullableConversion(Type source, Type destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsImplicitNullableConversion_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0005C5E0 File Offset: 0x0005A7E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1031084, RefRangeEnd = 1031085, XrefRangeStart = 1031069, XrefRangeEnd = 1031084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type FindGenericType(Type definition, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_FindGenericType_Public_Static_Type_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0005C638 File Offset: 0x0005A838
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1031113, RefRangeEnd = 1031117, XrefRangeStart = 1031085, XrefRangeEnd = 1031113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetBooleanOperator(Type type, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_GetBooleanOperator_Public_Static_MethodInfo_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0005C690 File Offset: 0x0005A890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031117, XrefRangeEnd = 1031118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetNonRefType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_GetNonRefType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0005C6D4 File Offset: 0x0005A8D4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1031122, RefRangeEnd = 1031143, XrefRangeStart = 1031118, XrefRangeEnd = 1031122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreEquivalent(Type t1, Type t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_AreEquivalent_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0005C728 File Offset: 0x0005A928
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1031150, RefRangeEnd = 1031186, XrefRangeStart = 1031143, XrefRangeEnd = 1031150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreReferenceAssignable(Type dest, Type src)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_AreReferenceAssignable_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0005C77C File Offset: 0x0005A97C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1031193, RefRangeEnd = 1031194, XrefRangeStart = 1031186, XrefRangeEnd = 1031193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSameOrSubclass(Type type, Type subType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_IsSameOrSubclass_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0005C7D0 File Offset: 0x0005A9D0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1031198, RefRangeEnd = 1031211, XrefRangeStart = 1031194, XrefRangeEnd = 1031198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateType(Type type, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_ValidateType_Public_Static_Void_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0005C818 File Offset: 0x0005AA18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1031223, RefRangeEnd = 1031229, XrefRangeStart = 1031211, XrefRangeEnd = 1031223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowByRef;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPointer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_ValidateType_Public_Static_Void_Type_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0005C87C File Offset: 0x0005AA7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1031237, RefRangeEnd = 1031238, XrefRangeStart = 1031229, XrefRangeEnd = 1031237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidateType(Type type, string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_ValidateType_Public_Static_Boolean_Type_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0005C8E0 File Offset: 0x0005AAE0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1031242, RefRangeEnd = 1031255, XrefRangeStart = 1031238, XrefRangeEnd = 1031242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetInvokeMethod(this Type delegateType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.NativeMethodInfoPtr_GetInvokeMethod_Public_Static_MethodInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00007576 File Offset: 0x00005776
		public TypeUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x0005C924 File Offset: 0x0005AB24
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x0000757F File Offset: 0x0000577F
		public unsafe static Il2CppReferenceArray<Type> s_arrayAssignableInterfaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeUtils.NativeFieldInfoPtr_s_arrayAssignableInterfaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeUtils.NativeFieldInfoPtr_s_arrayAssignableInterfaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeFieldInfoPtr_s_arrayAssignableInterfaces;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_GetNonNullableType_Public_Static_Type_Type_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_GetNullableType_Public_Static_Type_Type_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_IsNullableType_Public_Static_Boolean_Type_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_IsNullableOrReferenceType_Public_Static_Boolean_Type_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_IsBool_Public_Static_Boolean_Type_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_IsNumeric_Public_Static_Boolean_Type_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_IsInteger_Public_Static_Boolean_Type_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_IsArithmetic_Public_Static_Boolean_Type_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_IsUnsignedInt_Public_Static_Boolean_Type_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_IsIntegerOrBool_Public_Static_Boolean_Type_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_IsNumericOrBool_Public_Static_Boolean_Type_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_IsValidInstanceType_Public_Static_Boolean_MemberInfo_Type_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_HasIdentityPrimitiveOrNullableConversionTo_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_HasReferenceConversionTo_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_StrictHasReferenceConversionTo_Private_Static_Boolean_Type_Type_Boolean_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_HasArrayToInterfaceConversion_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_HasInterfaceToArrayConversion_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_IsCovariant_Private_Static_Boolean_Type_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_IsContravariant_Private_Static_Boolean_Type_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_IsInvariant_Private_Static_Boolean_Type_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_IsDelegate_Private_Static_Boolean_Type_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_IsLegalExplicitVariantDelegateConversion_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_IsConvertible_Public_Static_Boolean_Type_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_HasReferenceEquality_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_HasBuiltInEqualityOperator_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_IsImplicitlyConvertibleTo_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_GetUserDefinedCoercionMethod_Public_Static_MethodInfo_Type_Type_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_FindConversionOperator_Private_Static_MethodInfo_Il2CppReferenceArray_1_MethodInfo_Type_Type_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_IsImplicitNumericConversion_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_IsImplicitReferenceConversion_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_IsImplicitBoxingConversion_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_IsImplicitNullableConversion_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_FindGenericType_Public_Static_Type_Type_Type_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_GetBooleanOperator_Public_Static_MethodInfo_Type_String_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_GetNonRefType_Public_Static_Type_Type_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_AreEquivalent_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_AreReferenceAssignable_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_IsSameOrSubclass_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_ValidateType_Public_Static_Void_Type_String_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_ValidateType_Public_Static_Void_Type_String_Boolean_Boolean_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_ValidateType_Public_Static_Boolean_Type_String_Int32_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_GetInvokeMethod_Public_Static_MethodInfo_Type_0;

		// Token: 0x02000356 RID: 854
		[ObfuscatedName("System.Dynamic.Utils.TypeUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C20 RID: 7200 RVA: 0x00084E20 File Offset: 0x00083020
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TypeUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeUtils.__c>.NativeClassPtr);
				TypeUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeUtils.__c>.NativeClassPtr, "<>9");
				TypeUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils.__c>.NativeClassPtr, 100666658);
				TypeUtils.__c.NativeMethodInfoPtr___cctor_b__44_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils.__c>.NativeClassPtr, 100666659);
				TypeUtils.__c.NativeMethodInfoPtr___cctor_b__44_1_Internal_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeUtils.__c>.NativeClassPtr, 100666660);
			}

			// Token: 0x06001C21 RID: 7201 RVA: 0x00084E9C File Offset: 0x0008309C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C22 RID: 7202 RVA: 0x00084ED8 File Offset: 0x000830D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030456, XrefRangeEnd = 1030457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__44_0(Type i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.__c.NativeMethodInfoPtr___cctor_b__44_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C23 RID: 7203 RVA: 0x00084F28 File Offset: 0x00083128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030457, XrefRangeEnd = 1030458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type __cctor_b__44_1(Type i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeUtils.__c.NativeMethodInfoPtr___cctor_b__44_1_Internal_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06001C24 RID: 7204 RVA: 0x0000AB83 File Offset: 0x00008D83
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x06001C25 RID: 7205 RVA: 0x00084F78 File Offset: 0x00083178
			// (set) Token: 0x06001C26 RID: 7206 RVA: 0x0000AB8C File Offset: 0x00008D8C
			public unsafe static TypeUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012FF RID: 4863
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001300 RID: 4864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001301 RID: 4865
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__44_0_Internal_Boolean_Type_0;

			// Token: 0x04001302 RID: 4866
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__44_1_Internal_Type_Type_0;
		}
	}
}
