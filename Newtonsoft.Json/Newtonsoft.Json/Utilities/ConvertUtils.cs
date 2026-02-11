using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Numerics;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004B RID: 75
	public static class ConvertUtils : Object
	{
		// Token: 0x060006D6 RID: 1750 RVA: 0x0003259C File Offset: 0x0003079C
		// Note: this type is marked as 'beforefieldinit'.
		static ConvertUtils()
		{
			Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "ConvertUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr);
			ConvertUtils.NativeFieldInfoPtr_TypeCodeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, "TypeCodeMap");
			ConvertUtils.NativeFieldInfoPtr_PrimitiveTypeCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, "PrimitiveTypeCodes");
			ConvertUtils.NativeFieldInfoPtr_CastConverters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, "CastConverters");
			ConvertUtils.NativeMethodInfoPtr_GetTypeCode_Public_Static_PrimitiveTypeCode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664630);
			ConvertUtils.NativeMethodInfoPtr_GetTypeCode_Public_Static_PrimitiveTypeCode_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664631);
			ConvertUtils.NativeMethodInfoPtr_GetTypeInformation_Public_Static_TypeInformation_IConvertible_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664632);
			ConvertUtils.NativeMethodInfoPtr_IsConvertible_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664633);
			ConvertUtils.NativeMethodInfoPtr_ParseTimeSpan_Public_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664634);
			ConvertUtils.NativeMethodInfoPtr_CreateCastConverter_Private_Static_Func_2_Object_Object_StructMultiKey_2_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664635);
			ConvertUtils.NativeMethodInfoPtr_ToBigInteger_Internal_Static_BigInteger_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664636);
			ConvertUtils.NativeMethodInfoPtr_FromBigInteger_Public_Static_Object_BigInteger_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664637);
			ConvertUtils.NativeMethodInfoPtr_Convert_Public_Static_Object_Object_CultureInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664638);
			ConvertUtils.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Object_CultureInfo_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664639);
			ConvertUtils.NativeMethodInfoPtr_TryConvertInternal_Private_Static_ConvertResult_Object_CultureInfo_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664640);
			ConvertUtils.NativeMethodInfoPtr_ConvertOrCast_Public_Static_Object_Object_CultureInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664641);
			ConvertUtils.NativeMethodInfoPtr_EnsureTypeAssignable_Private_Static_Object_Object_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664642);
			ConvertUtils.NativeMethodInfoPtr_VersionTryParse_Public_Static_Boolean_String_byref_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664643);
			ConvertUtils.NativeMethodInfoPtr_IsInteger_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664644);
			ConvertUtils.NativeMethodInfoPtr_Int32TryParse_Public_Static_ParseResult_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664645);
			ConvertUtils.NativeMethodInfoPtr_Int64TryParse_Public_Static_ParseResult_Il2CppStructArray_1_Char_Int32_Int32_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664646);
			ConvertUtils.NativeMethodInfoPtr_DecimalTryParse_Public_Static_ParseResult_Il2CppStructArray_1_Char_Int32_Int32_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664647);
			ConvertUtils.NativeMethodInfoPtr_TryConvertGuid_Public_Static_Boolean_String_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664648);
			ConvertUtils.NativeMethodInfoPtr_TryHexTextToInt_Public_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, 100664649);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00032798 File Offset: 0x00030998
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 740331, RefRangeEnd = 740339, XrefRangeStart = 740327, XrefRangeEnd = 740331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrimitiveTypeCode GetTypeCode(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_GetTypeCode_Public_Static_PrimitiveTypeCode_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000327DC File Offset: 0x000309DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 740369, RefRangeEnd = 740374, XrefRangeStart = 740339, XrefRangeEnd = 740369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isEnum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_GetTypeCode_Public_Static_PrimitiveTypeCode_Type_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0003282C File Offset: 0x00030A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 740381, RefRangeEnd = 740382, XrefRangeStart = 740374, XrefRangeEnd = 740381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(convertable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_GetTypeInformation_Public_Static_TypeInformation_IConvertible_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInformation>(intPtr3) : null;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00032870 File Offset: 0x00030A70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 740389, RefRangeEnd = 740392, XrefRangeStart = 740382, XrefRangeEnd = 740389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsConvertible(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_IsConvertible_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000328B4 File Offset: 0x00030AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 740400, RefRangeEnd = 740401, XrefRangeStart = 740392, XrefRangeEnd = 740400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan ParseTimeSpan(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_ParseTimeSpan_Public_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000328F8 File Offset: 0x00030AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740401, XrefRangeEnd = 740435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Object, Object> CreateCastConverter(StructMultiKey<Type, Type> t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(t));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_CreateCastConverter_Private_Static_Func_2_Object_Object_StructMultiKey_2_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00032944 File Offset: 0x00030B44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 740488, RefRangeEnd = 740493, XrefRangeStart = 740435, XrefRangeEnd = 740488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger ToBigInteger(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_ToBigInteger_Internal_Static_BigInteger_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00032980 File Offset: 0x00030B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 740544, RefRangeEnd = 740545, XrefRangeStart = 740493, XrefRangeEnd = 740544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FromBigInteger(BigInteger i, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(i));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_FromBigInteger_Public_Static_Object_BigInteger_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000329DC File Offset: 0x00030BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 740550, RefRangeEnd = 740551, XrefRangeStart = 740545, XrefRangeEnd = 740550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Convert(Object initialValue, CultureInfo culture, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_Convert_Public_Static_Object_Object_CultureInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00032A44 File Offset: 0x00030C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 740559, RefRangeEnd = 740560, XrefRangeStart = 740551, XrefRangeEnd = 740559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvert(Object initialValue, CultureInfo culture, Type targetType, out Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Object_CultureInfo_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00032ACC File Offset: 0x00030CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 740711, RefRangeEnd = 740713, XrefRangeStart = 740560, XrefRangeEnd = 740711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConvertUtils.ConvertResult TryConvertInternal(Object initialValue, CultureInfo culture, Type targetType, out Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_TryConvertInternal_Private_Static_ConvertResult_Object_CultureInfo_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00032B54 File Offset: 0x00030D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 740737, RefRangeEnd = 740739, XrefRangeStart = 740713, XrefRangeEnd = 740737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ConvertOrCast(Object initialValue, CultureInfo culture, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_ConvertOrCast_Public_Static_Object_Object_CultureInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00032BBC File Offset: 0x00030DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 740746, RefRangeEnd = 740747, XrefRangeStart = 740739, XrefRangeEnd = 740746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object EnsureTypeAssignable(Object value, Type initialType, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initialType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_EnsureTypeAssignable_Private_Static_Object_Object_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00032C24 File Offset: 0x00030E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740747, XrefRangeEnd = 741177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool VersionTryParse(string input, out Version result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_VersionTryParse_Public_Static_Boolean_String_byref_Version_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Version(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00032C88 File Offset: 0x00030E88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741185, RefRangeEnd = 741187, XrefRangeStart = 741177, XrefRangeEnd = 741185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInteger(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_IsInteger_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00032CCC File Offset: 0x00030ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741187, RefRangeEnd = 741188, XrefRangeStart = 741187, XrefRangeEnd = 741187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParseResult Int32TryParse(Il2CppStructArray<char> chars, int start, int length, out int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_Int32TryParse_Public_Static_ParseResult_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00032D38 File Offset: 0x00030F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741188, RefRangeEnd = 741189, XrefRangeStart = 741188, XrefRangeEnd = 741188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParseResult Int64TryParse(Il2CppStructArray<char> chars, int start, int length, out long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_Int64TryParse_Public_Static_ParseResult_Il2CppStructArray_1_Char_Int32_Int32_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00032DA4 File Offset: 0x00030FA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 741239, RefRangeEnd = 741242, XrefRangeStart = 741189, XrefRangeEnd = 741239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParseResult DecimalTryParse(Il2CppStructArray<char> chars, int start, int length, out Decimal value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_DecimalTryParse_Public_Static_ParseResult_Il2CppStructArray_1_Char_Int32_Int32_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00032E10 File Offset: 0x00031010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741245, RefRangeEnd = 741247, XrefRangeStart = 741242, XrefRangeEnd = 741245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertGuid(string s, out Guid g)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &g;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_TryConvertGuid_Public_Static_Boolean_String_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00032E60 File Offset: 0x00031060
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741249, RefRangeEnd = 741251, XrefRangeStart = 741247, XrefRangeEnd = 741249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryHexTextToInt(Il2CppStructArray<char> text, int start, int end, out int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.NativeMethodInfoPtr_TryHexTextToInt_Public_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000041E5 File Offset: 0x000023E5
		public ConvertUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00032ECC File Offset: 0x000310CC
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x000041EE File Offset: 0x000023EE
		public unsafe static Dictionary<Type, PrimitiveTypeCode> TypeCodeMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConvertUtils.NativeFieldInfoPtr_TypeCodeMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, PrimitiveTypeCode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConvertUtils.NativeFieldInfoPtr_TypeCodeMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00032EF4 File Offset: 0x000310F4
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00004200 File Offset: 0x00002400
		public unsafe static Il2CppReferenceArray<TypeInformation> PrimitiveTypeCodes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConvertUtils.NativeFieldInfoPtr_PrimitiveTypeCodes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TypeInformation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConvertUtils.NativeFieldInfoPtr_PrimitiveTypeCodes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00032F1C File Offset: 0x0003111C
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00004212 File Offset: 0x00002412
		public unsafe static ThreadSafeStore<StructMultiKey<Type, Type>, Func<Object, Object>> CastConverters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConvertUtils.NativeFieldInfoPtr_CastConverters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<StructMultiKey<Type, Type>, Func<Object, Object>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConvertUtils.NativeFieldInfoPtr_CastConverters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeFieldInfoPtr_TypeCodeMap;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeFieldInfoPtr_PrimitiveTypeCodes;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr_CastConverters;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Static_PrimitiveTypeCode_Type_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Static_PrimitiveTypeCode_Type_byref_Boolean_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInformation_Public_Static_TypeInformation_IConvertible_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_IsConvertible_Public_Static_Boolean_Type_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimeSpan_Public_Static_TimeSpan_String_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_CreateCastConverter_Private_Static_Func_2_Object_Object_StructMultiKey_2_Type_Type_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_ToBigInteger_Internal_Static_BigInteger_Object_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_FromBigInteger_Public_Static_Object_BigInteger_Type_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Static_Object_Object_CultureInfo_Type_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_TryConvert_Private_Static_Boolean_Object_CultureInfo_Type_byref_Object_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertInternal_Private_Static_ConvertResult_Object_CultureInfo_Type_byref_Object_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_ConvertOrCast_Public_Static_Object_Object_CultureInfo_Type_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_EnsureTypeAssignable_Private_Static_Object_Object_Type_Type_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_VersionTryParse_Public_Static_Boolean_String_byref_Version_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_IsInteger_Public_Static_Boolean_Object_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_Int32TryParse_Public_Static_ParseResult_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_Int64TryParse_Public_Static_ParseResult_Il2CppStructArray_1_Char_Int32_Int32_byref_Int64_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_DecimalTryParse_Public_Static_ParseResult_Il2CppStructArray_1_Char_Int32_Int32_byref_Decimal_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertGuid_Public_Static_Boolean_String_byref_Guid_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_TryHexTextToInt_Public_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x0200017D RID: 381
		public enum ConvertResult
		{
			// Token: 0x04001509 RID: 5385
			Success,
			// Token: 0x0400150A RID: 5386
			CannotConvertNull,
			// Token: 0x0400150B RID: 5387
			NotInstantiableType,
			// Token: 0x0400150C RID: 5388
			NoValidConversion
		}

		// Token: 0x0200017E RID: 382
		[ObfuscatedName("Newtonsoft.Json.Utilities.ConvertUtils+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06001C44 RID: 7236 RVA: 0x00085AE0 File Offset: 0x00083CE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ConvertUtils.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConvertUtils>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConvertUtils.__c__DisplayClass8_0>.NativeClassPtr);
				ConvertUtils.__c__DisplayClass8_0.NativeFieldInfoPtr_call = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertUtils.__c__DisplayClass8_0>.NativeClassPtr, "call");
				ConvertUtils.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils.__c__DisplayClass8_0>.NativeClassPtr, 100664651);
				ConvertUtils.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateCastConverter_b__0_Internal_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertUtils.__c__DisplayClass8_0>.NativeClassPtr, 100664652);
			}

			// Token: 0x06001C45 RID: 7237 RVA: 0x00085B48 File Offset: 0x00083D48
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConvertUtils.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C46 RID: 7238 RVA: 0x00085B84 File Offset: 0x00083D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740297, XrefRangeEnd = 740327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateCastConverter_b__0(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertUtils.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateCastConverter_b__0_Internal_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C47 RID: 7239 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007F9 RID: 2041
			// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00085BD4 File Offset: 0x00083DD4
			// (set) Token: 0x06001C49 RID: 7241 RVA: 0x0000DEA9 File Offset: 0x0000C0A9
			public unsafe MethodCall<Object, Object> call
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConvertUtils.__c__DisplayClass8_0.NativeFieldInfoPtr_call);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConvertUtils.__c__DisplayClass8_0.NativeFieldInfoPtr_call), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400150D RID: 5389
			private static readonly IntPtr NativeFieldInfoPtr_call;

			// Token: 0x0400150E RID: 5390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400150F RID: 5391
			private static readonly IntPtr NativeMethodInfoPtr__CreateCastConverter_b__0_Internal_Object_Object_0;
		}
	}
}
