using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000132 RID: 306
	[Serializable]
	[StructLayout(2)]
	public struct Enum
	{
		// Token: 0x06001442 RID: 5186 RVA: 0x00087FF0 File Offset: 0x000861F0
		// Note: this type is marked as 'beforefieldinit'.
		static Enum()
		{
			Il2CppClassPointerStore<Enum>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Enum");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enum>.NativeClassPtr);
			Enum.NativeFieldInfoPtr_enumSeperatorCharArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum>.NativeClassPtr, "enumSeperatorCharArray");
			Enum.NativeFieldInfoPtr_enumSeperator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum>.NativeClassPtr, "enumSeperator");
			Enum.NativeMethodInfoPtr_GetCachedValuesAndNames_Private_Static_ValuesAndNames_RuntimeType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666894);
			Enum.NativeMethodInfoPtr_InternalFormattedHexString_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666895);
			Enum.NativeMethodInfoPtr_InternalFormat_Private_Static_String_RuntimeType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666896);
			Enum.NativeMethodInfoPtr_InternalFlagsFormat_Private_Static_String_RuntimeType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666897);
			Enum.NativeMethodInfoPtr_ToUInt64_Internal_Static_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666898);
			Enum.NativeMethodInfoPtr_InternalCompareTo_Private_Static_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666899);
			Enum.NativeMethodInfoPtr_InternalGetUnderlyingType_Internal_Static_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666900);
			Enum.NativeMethodInfoPtr_GetEnumValuesAndNames_Private_Static_Boolean_RuntimeType_byref_Il2CppStructArray_1_UInt64_byref_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666901);
			Enum.NativeMethodInfoPtr_InternalBoxEnum_Private_Static_Object_RuntimeType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666902);
			Enum.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666903);
			Enum.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_Boolean_byref_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666904);
			Enum.NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666905);
			Enum.NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666906);
			Enum.NativeMethodInfoPtr_TryParseEnum_Private_Static_Boolean_Type_String_Boolean_byref_EnumResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666907);
			Enum.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666908);
			Enum.NativeMethodInfoPtr_GetValues_Public_Static_Array_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666909);
			Enum.NativeMethodInfoPtr_InternalGetValues_Internal_Static_Il2CppStructArray_1_UInt64_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666910);
			Enum.NativeMethodInfoPtr_GetName_Public_Static_String_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666911);
			Enum.NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666912);
			Enum.NativeMethodInfoPtr_InternalGetNames_Internal_Static_Il2CppStringArray_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666913);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666914);
			Enum.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666915);
			Enum.NativeMethodInfoPtr_Format_Public_Static_String_Type_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666916);
			Enum.NativeMethodInfoPtr_get_value_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666917);
			Enum.NativeMethodInfoPtr_GetValue_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666918);
			Enum.NativeMethodInfoPtr_InternalHasFlag_Private_Boolean_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666919);
			Enum.NativeMethodInfoPtr_get_hashcode_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666920);
			Enum.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666921);
			Enum.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666922);
			Enum.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666923);
			Enum.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666924);
			Enum.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666925);
			Enum.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666926);
			Enum.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666927);
			Enum.NativeMethodInfoPtr_HasFlag_Public_Boolean_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666928);
			Enum.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666929);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666930);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666931);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666932);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666933);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666934);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666935);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666936);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666937);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666938);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666939);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666940);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666941);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666942);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666943);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666944);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666945);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666946);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666947);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666948);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666949);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666950);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666951);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666952);
			Enum.NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666953);
			Enum.NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666954);
			Enum.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_Type_String_Boolean_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666955);
			Enum.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_Type_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666956);
			Enum.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100666957);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00088548 File Offset: 0x00086748
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1339631, RefRangeEnd = 1339638, XrefRangeStart = 1339612, XrefRangeEnd = 1339631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Enum.ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getNames;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetCachedValuesAndNames_Private_Static_ValuesAndNames_RuntimeType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enum.ValuesAndNames>(intPtr3) : null;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0008859C File Offset: 0x0008679C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1339663, RefRangeEnd = 1339664, XrefRangeStart = 1339638, XrefRangeEnd = 1339663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalFormattedHexString(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalFormattedHexString_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000885D8 File Offset: 0x000867D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1339674, RefRangeEnd = 1339675, XrefRangeStart = 1339664, XrefRangeEnd = 1339674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalFormat(RuntimeType eT, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eT);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalFormat_Private_Static_String_RuntimeType_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00088628 File Offset: 0x00086828
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1339689, RefRangeEnd = 1339693, XrefRangeStart = 1339675, XrefRangeEnd = 1339689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalFlagsFormat(RuntimeType eT, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eT);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalFlagsFormat_Private_Static_String_RuntimeType_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00088678 File Offset: 0x00086878
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1339710, RefRangeEnd = 1339719, XrefRangeStart = 1339693, XrefRangeEnd = 1339710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToUInt64_Internal_Static_UInt64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000886BC File Offset: 0x000868BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339719, XrefRangeEnd = 1339720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalCompareTo(Object o1, Object o2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalCompareTo_Private_Static_Int32_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00088710 File Offset: 0x00086910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339720, XrefRangeEnd = 1339721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType InternalGetUnderlyingType(RuntimeType enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalGetUnderlyingType_Internal_Static_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00088754 File Offset: 0x00086954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339721, XrefRangeEnd = 1339722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetEnumValuesAndNames(RuntimeType enumType, out Il2CppStructArray<ulong> values, out Il2CppStringArray names)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetEnumValuesAndNames_Private_Static_Boolean_RuntimeType_byref_Il2CppStructArray_1_UInt64_byref_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			values = ((intPtr5 == 0) ? null : new Il2CppStructArray<ulong>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			names = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x000887DC File Offset: 0x000869DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339722, XrefRangeEnd = 1339723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InternalBoxEnum(RuntimeType enumType, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalBoxEnum_Private_Static_Object_RuntimeType_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00088830 File Offset: 0x00086A30
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1339739, RefRangeEnd = 1339749, XrefRangeStart = 1339723, XrefRangeEnd = 1339739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TEnum).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref result;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Enum.MethodInfoStoreGeneric_TryParse_Public_Static_Boolean_String_byref_TEnum_0<TEnum>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TEnum).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TEnum>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x000888C0 File Offset: 0x00086AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339749, XrefRangeEnd = 1339761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TEnum).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref result;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Enum.MethodInfoStoreGeneric_TryParse_Public_Static_Boolean_String_Boolean_byref_TEnum_0<TEnum>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TEnum).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TEnum>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00088960 File Offset: 0x00086B60
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1339772, RefRangeEnd = 1339778, XrefRangeStart = 1339761, XrefRangeEnd = 1339772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Parse(Type enumType, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000889B8 File Offset: 0x00086BB8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1339786, RefRangeEnd = 1339797, XrefRangeStart = 1339778, XrefRangeEnd = 1339786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Parse(Type enumType, string value, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00088A1C File Offset: 0x00086C1C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1339848, RefRangeEnd = 1339854, XrefRangeStart = 1339797, XrefRangeEnd = 1339848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref Enum.EnumResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_TryParseEnum_Private_Static_Boolean_Type_String_Boolean_byref_EnumResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00088A90 File Offset: 0x00086C90
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1339865, RefRangeEnd = 1339882, XrefRangeStart = 1339854, XrefRangeEnd = 1339865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetUnderlyingType(Type enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00088AD4 File Offset: 0x00086CD4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1339893, RefRangeEnd = 1339904, XrefRangeStart = 1339882, XrefRangeEnd = 1339893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array GetValues(Type enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetValues_Public_Static_Array_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00088B18 File Offset: 0x00086D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1339908, RefRangeEnd = 1339909, XrefRangeStart = 1339904, XrefRangeEnd = 1339908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<ulong> InternalGetValues(RuntimeType enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalGetValues_Internal_Static_Il2CppStructArray_1_UInt64_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr3) : null;
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00088B5C File Offset: 0x00086D5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1339920, RefRangeEnd = 1339924, XrefRangeStart = 1339909, XrefRangeEnd = 1339920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(Type enumType, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetName_Public_Static_String_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00088BAC File Offset: 0x00086DAC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1339935, RefRangeEnd = 1339941, XrefRangeStart = 1339924, XrefRangeEnd = 1339935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetNames(Type enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00088BF0 File Offset: 0x00086DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339941, XrefRangeEnd = 1339945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray InternalGetNames(RuntimeType enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalGetNames_Internal_Static_Il2CppStringArray_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00088C34 File Offset: 0x00086E34
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1340034, RefRangeEnd = 1340044, XrefRangeStart = 1339945, XrefRangeEnd = 1340034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00088C8C File Offset: 0x00086E8C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1340055, RefRangeEnd = 1340068, XrefRangeStart = 1340044, XrefRangeEnd = 1340055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefined(Type enumType, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00088CE0 File Offset: 0x00086EE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1340094, RefRangeEnd = 1340099, XrefRangeStart = 1340068, XrefRangeEnd = 1340094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(Type enumType, Object value, string format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_Format_Public_Static_String_Type_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00088D40 File Offset: 0x00086F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1340100, RefRangeEnd = 1340101, XrefRangeStart = 1340099, XrefRangeEnd = 1340100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object get_value()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_get_value_Private_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00088D74 File Offset: 0x00086F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1340100, RefRangeEnd = 1340101, XrefRangeStart = 1340100, XrefRangeEnd = 1340101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetValue_Internal_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00088DA8 File Offset: 0x00086FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340101, XrefRangeEnd = 1340102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalHasFlag(Enum flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalHasFlag_Private_Boolean_Enum_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00088DE8 File Offset: 0x00086FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340102, XrefRangeEnd = 1340103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int get_hashcode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_get_hashcode_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00088E18 File Offset: 0x00087018
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1340104, RefRangeEnd = 1340134, XrefRangeStart = 1340103, XrefRangeEnd = 1340104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00088E5C File Offset: 0x0008705C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00088E8C File Offset: 0x0008708C
		[CallerCount(253)]
		[CachedScanResults(RefRangeStart = 1340143, RefRangeEnd = 1340396, XrefRangeStart = 1340134, XrefRangeEnd = 1340143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00088EB8 File Offset: 0x000870B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340396, XrefRangeEnd = 1340397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00088F08 File Offset: 0x00087108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340397, XrefRangeEnd = 1340402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(Object target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00088F4C File Offset: 0x0008714C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1340437, RefRangeEnd = 1340442, XrefRangeStart = 1340402, XrefRangeEnd = 1340437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00088F88 File Offset: 0x00087188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1017349, RefRangeEnd = 1017351, XrefRangeStart = 1017349, XrefRangeEnd = 1017351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00088FC4 File Offset: 0x000871C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340442, XrefRangeEnd = 1340470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasFlag(Enum flag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_HasFlag_Public_Boolean_Enum_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00089004 File Offset: 0x00087204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340470, XrefRangeEnd = 1340536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00089034 File Offset: 0x00087234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340536, XrefRangeEnd = 1340545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00089078 File Offset: 0x00087278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340545, XrefRangeEnd = 1340554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x000890BC File Offset: 0x000872BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340554, XrefRangeEnd = 1340563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00089100 File Offset: 0x00087300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340563, XrefRangeEnd = 1340572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00089144 File Offset: 0x00087344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340572, XrefRangeEnd = 1340581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00089188 File Offset: 0x00087388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340581, XrefRangeEnd = 1340590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000891CC File Offset: 0x000873CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1340599, RefRangeEnd = 1340601, XrefRangeStart = 1340590, XrefRangeEnd = 1340599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00089210 File Offset: 0x00087410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340601, XrefRangeEnd = 1340610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00089254 File Offset: 0x00087454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340610, XrefRangeEnd = 1340619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00089298 File Offset: 0x00087498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340619, XrefRangeEnd = 1340628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x000892DC File Offset: 0x000874DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340628, XrefRangeEnd = 1340637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00089320 File Offset: 0x00087520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340637, XrefRangeEnd = 1340646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00089364 File Offset: 0x00087564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340646, XrefRangeEnd = 1340655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x000893A8 File Offset: 0x000875A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340655, XrefRangeEnd = 1340674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x000893EC File Offset: 0x000875EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340674, XrefRangeEnd = 1340678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_IConvertible_ToType(Type type, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00089444 File Offset: 0x00087644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1340713, RefRangeEnd = 1340715, XrefRangeStart = 1340678, XrefRangeEnd = 1340713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, sbyte value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00089498 File Offset: 0x00087698
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1340750, RefRangeEnd = 1340752, XrefRangeStart = 1340715, XrefRangeEnd = 1340750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, short value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x000894EC File Offset: 0x000876EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1340787, RefRangeEnd = 1340794, XrefRangeStart = 1340752, XrefRangeEnd = 1340787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00089540 File Offset: 0x00087740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1340829, RefRangeEnd = 1340831, XrefRangeStart = 1340794, XrefRangeEnd = 1340829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, byte value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00089594 File Offset: 0x00087794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1340866, RefRangeEnd = 1340868, XrefRangeStart = 1340831, XrefRangeEnd = 1340866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, ushort value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x000895E8 File Offset: 0x000877E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1340903, RefRangeEnd = 1340905, XrefRangeStart = 1340868, XrefRangeEnd = 1340903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0008963C File Offset: 0x0008783C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1340940, RefRangeEnd = 1340943, XrefRangeStart = 1340905, XrefRangeEnd = 1340940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00089690 File Offset: 0x00087890
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1340978, RefRangeEnd = 1340984, XrefRangeStart = 1340943, XrefRangeEnd = 1340978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, ulong value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000896E4 File Offset: 0x000878E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1341019, RefRangeEnd = 1341020, XrefRangeStart = 1340984, XrefRangeEnd = 1341019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, char value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00089738 File Offset: 0x00087938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1341055, RefRangeEnd = 1341056, XrefRangeStart = 1341020, XrefRangeEnd = 1341055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0008978C File Offset: 0x0008798C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1341062, RefRangeEnd = 1341063, XrefRangeStart = 1341056, XrefRangeEnd = 1341062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(Type enumType, string value, bool ignoreCase, out Object result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_Type_String_Boolean_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00089810 File Offset: 0x00087A10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1341071, RefRangeEnd = 1341073, XrefRangeStart = 1341063, XrefRangeEnd = 1341071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(Type enumType, string value, out Object result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_Type_String_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00089888 File Offset: 0x00087A88
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Enum()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr__ctor_Protected_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000066B8 File Offset: 0x000048B8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Enum>.NativeClassPtr, ref this));
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x000898B0 File Offset: 0x00087AB0
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x000066CA File Offset: 0x000048CA
		public unsafe static Il2CppStructArray<char> enumSeperatorCharArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Enum.NativeFieldInfoPtr_enumSeperatorCharArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Enum.NativeFieldInfoPtr_enumSeperatorCharArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x000898D8 File Offset: 0x00087AD8
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x000066DC File Offset: 0x000048DC
		public unsafe static string enumSeperator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Enum.NativeFieldInfoPtr_enumSeperator, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Enum.NativeFieldInfoPtr_enumSeperator, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeFieldInfoPtr_enumSeperatorCharArray;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeFieldInfoPtr_enumSeperator;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedValuesAndNames_Private_Static_ValuesAndNames_RuntimeType_Boolean_0;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeMethodInfoPtr_InternalFormattedHexString_Private_Static_String_Object_0;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr_InternalFormat_Private_Static_String_RuntimeType_Object_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr_InternalFlagsFormat_Private_Static_String_RuntimeType_Object_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Internal_Static_UInt64_Object_0;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr_InternalCompareTo_Private_Static_Int32_Object_Object_0;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUnderlyingType_Internal_Static_RuntimeType_RuntimeType_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumValuesAndNames_Private_Static_Boolean_RuntimeType_byref_Il2CppStructArray_1_UInt64_byref_Il2CppStringArray_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr_InternalBoxEnum_Private_Static_Object_RuntimeType_Int64_0;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TEnum_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_Boolean_byref_TEnum_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_Boolean_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_TryParseEnum_Private_Static_Boolean_Type_String_Boolean_byref_EnumResult_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_Static_Array_Type_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetValues_Internal_Static_Il2CppStructArray_1_UInt64_RuntimeType_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_Type_Object_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_Type_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetNames_Internal_Static_Il2CppStringArray_RuntimeType_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Object_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_Type_Object_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_Type_Object_String_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Private_Object_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Internal_Object_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_InternalHasFlag_Private_Boolean_Enum_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_get_hashcode_Private_Int32_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Public_Boolean_Enum_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_SByte_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int16_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int32_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Byte_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt16_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt32_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int64_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt64_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Char_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Boolean_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_Type_String_Boolean_byref_Object_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_Type_String_byref_Object_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020005E9 RID: 1513
		public enum ParseFailureKind
		{
			// Token: 0x040047BD RID: 18365
			None,
			// Token: 0x040047BE RID: 18366
			Argument,
			// Token: 0x040047BF RID: 18367
			ArgumentNull,
			// Token: 0x040047C0 RID: 18368
			ArgumentWithParameter,
			// Token: 0x040047C1 RID: 18369
			UnhandledException
		}

		// Token: 0x020005EA RID: 1514
		public sealed class EnumResult : ValueType
		{
			// Token: 0x06005764 RID: 22372 RVA: 0x00192FBC File Offset: 0x001911BC
			// Note: this type is marked as 'beforefieldinit'.
			static EnumResult()
			{
				Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enum>.NativeClassPtr, "EnumResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr);
				Enum.EnumResult.NativeFieldInfoPtr_parsedEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "parsedEnum");
				Enum.EnumResult.NativeFieldInfoPtr_canThrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "canThrow");
				Enum.EnumResult.NativeFieldInfoPtr_m_failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "m_failure");
				Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "m_failureMessageID");
				Enum.EnumResult.NativeFieldInfoPtr_m_failureParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "m_failureParameter");
				Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageFormatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "m_failureMessageFormatArgument");
				Enum.EnumResult.NativeFieldInfoPtr_m_innerException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "m_innerException");
				Enum.EnumResult.NativeMethodInfoPtr_Init_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, 100666959);
				Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, 100666960);
				Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, 100666961);
				Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, 100666962);
				Enum.EnumResult.NativeMethodInfoPtr_GetEnumParseException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, 100666963);
			}

			// Token: 0x06005765 RID: 22373 RVA: 0x001930D8 File Offset: 0x001912D8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1339596, RefRangeEnd = 1339598, XrefRangeStart = 1339592, XrefRangeEnd = 1339596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(bool canMethodThrow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref canMethodThrow;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.EnumResult.NativeMethodInfoPtr_Init_Internal_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005766 RID: 22374 RVA: 0x0019311C File Offset: 0x0019131C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339598, XrefRangeEnd = 1339599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Exception unhandledException)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(unhandledException);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005767 RID: 22375 RVA: 0x00193164 File Offset: 0x00191364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339599, XrefRangeEnd = 1339600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Enum.ParseFailureKind failure, string failureParameter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureParameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005768 RID: 22376 RVA: 0x001931BC File Offset: 0x001913BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1339602, RefRangeEnd = 1339603, XrefRangeStart = 1339600, XrefRangeEnd = 1339602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Enum.ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005769 RID: 22377 RVA: 0x00193224 File Offset: 0x00191424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339603, XrefRangeEnd = 1339612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Exception GetEnumParseException()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.EnumResult.NativeMethodInfoPtr_GetEnumParseException_Internal_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}

			// Token: 0x0600576A RID: 22378 RVA: 0x0001F071 File Offset: 0x0001D271
			public EnumResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600576B RID: 22379 RVA: 0x0001F07A File Offset: 0x0001D27A
			public EnumResult()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr))
			{
			}

			// Token: 0x17001644 RID: 5700
			// (get) Token: 0x0600576C RID: 22380 RVA: 0x00193268 File Offset: 0x00191468
			// (set) Token: 0x0600576D RID: 22381 RVA: 0x0001F08C File Offset: 0x0001D28C
			public unsafe Object parsedEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_parsedEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_parsedEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001645 RID: 5701
			// (get) Token: 0x0600576E RID: 22382 RVA: 0x00193298 File Offset: 0x00191498
			// (set) Token: 0x0600576F RID: 22383 RVA: 0x0001F0AB File Offset: 0x0001D2AB
			public unsafe bool canThrow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_canThrow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_canThrow)) = value;
				}
			}

			// Token: 0x17001646 RID: 5702
			// (get) Token: 0x06005770 RID: 22384 RVA: 0x001932C0 File Offset: 0x001914C0
			// (set) Token: 0x06005771 RID: 22385 RVA: 0x0001F0C6 File Offset: 0x0001D2C6
			public unsafe Enum.ParseFailureKind m_failure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failure)) = value;
				}
			}

			// Token: 0x17001647 RID: 5703
			// (get) Token: 0x06005772 RID: 22386 RVA: 0x001932E8 File Offset: 0x001914E8
			// (set) Token: 0x06005773 RID: 22387 RVA: 0x0001F0E1 File Offset: 0x0001D2E1
			public unsafe string m_failureMessageID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001648 RID: 5704
			// (get) Token: 0x06005774 RID: 22388 RVA: 0x00193310 File Offset: 0x00191510
			// (set) Token: 0x06005775 RID: 22389 RVA: 0x0001F100 File Offset: 0x0001D300
			public unsafe string m_failureParameter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureParameter);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureParameter), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001649 RID: 5705
			// (get) Token: 0x06005776 RID: 22390 RVA: 0x00193338 File Offset: 0x00191538
			// (set) Token: 0x06005777 RID: 22391 RVA: 0x0001F11F File Offset: 0x0001D31F
			public unsafe Object m_failureMessageFormatArgument
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageFormatArgument);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageFormatArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700164A RID: 5706
			// (get) Token: 0x06005778 RID: 22392 RVA: 0x00193368 File Offset: 0x00191568
			// (set) Token: 0x06005779 RID: 22393 RVA: 0x0001F13E File Offset: 0x0001D33E
			public unsafe Exception m_innerException
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_innerException);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_innerException), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040047C2 RID: 18370
			private static readonly IntPtr NativeFieldInfoPtr_parsedEnum;

			// Token: 0x040047C3 RID: 18371
			private static readonly IntPtr NativeFieldInfoPtr_canThrow;

			// Token: 0x040047C4 RID: 18372
			private static readonly IntPtr NativeFieldInfoPtr_m_failure;

			// Token: 0x040047C5 RID: 18373
			private static readonly IntPtr NativeFieldInfoPtr_m_failureMessageID;

			// Token: 0x040047C6 RID: 18374
			private static readonly IntPtr NativeFieldInfoPtr_m_failureParameter;

			// Token: 0x040047C7 RID: 18375
			private static readonly IntPtr NativeFieldInfoPtr_m_failureMessageFormatArgument;

			// Token: 0x040047C8 RID: 18376
			private static readonly IntPtr NativeFieldInfoPtr_m_innerException;

			// Token: 0x040047C9 RID: 18377
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Boolean_0;

			// Token: 0x040047CA RID: 18378
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0;

			// Token: 0x040047CB RID: 18379
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0;

			// Token: 0x040047CC RID: 18380
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0;

			// Token: 0x040047CD RID: 18381
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumParseException_Internal_Exception_0;
		}

		// Token: 0x020005EB RID: 1515
		public class ValuesAndNames : Object
		{
			// Token: 0x0600577A RID: 22394 RVA: 0x00193398 File Offset: 0x00191598
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesAndNames()
			{
				Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enum>.NativeClassPtr, "ValuesAndNames");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr);
				Enum.ValuesAndNames.NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr, "Values");
				Enum.ValuesAndNames.NativeFieldInfoPtr_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr, "Names");
				Enum.ValuesAndNames.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt64_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr, 100666964);
			}

			// Token: 0x0600577B RID: 22395 RVA: 0x00193400 File Offset: 0x00191600
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesAndNames(Il2CppStructArray<ulong> values, Il2CppStringArray names)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.ValuesAndNames.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt64_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600577C RID: 22396 RVA: 0x0001F15D File Offset: 0x0001D35D
			public ValuesAndNames(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700164B RID: 5707
			// (get) Token: 0x0600577D RID: 22397 RVA: 0x00193460 File Offset: 0x00191660
			// (set) Token: 0x0600577E RID: 22398 RVA: 0x0001F166 File Offset: 0x0001D366
			public unsafe Il2CppStructArray<ulong> Values
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.ValuesAndNames.NativeFieldInfoPtr_Values);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.ValuesAndNames.NativeFieldInfoPtr_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700164C RID: 5708
			// (get) Token: 0x0600577F RID: 22399 RVA: 0x00193490 File Offset: 0x00191690
			// (set) Token: 0x06005780 RID: 22400 RVA: 0x0001F185 File Offset: 0x0001D385
			public unsafe Il2CppStringArray Names
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.ValuesAndNames.NativeFieldInfoPtr_Names);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.ValuesAndNames.NativeFieldInfoPtr_Names), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040047CE RID: 18382
			private static readonly IntPtr NativeFieldInfoPtr_Values;

			// Token: 0x040047CF RID: 18383
			private static readonly IntPtr NativeFieldInfoPtr_Names;

			// Token: 0x040047D0 RID: 18384
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt64_Il2CppStringArray_0;
		}

		// Token: 0x020005EC RID: 1516
		private sealed class MethodInfoStoreGeneric_TryParse_Public_Static_Boolean_String_byref_TEnum_0<TEnum>
		{
			// Token: 0x040047D1 RID: 18385
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enum.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TEnum_0, Il2CppClassPointerStore<Enum>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) }))));
		}

		// Token: 0x020005ED RID: 1517
		private sealed class MethodInfoStoreGeneric_TryParse_Public_Static_Boolean_String_Boolean_byref_TEnum_0<TEnum>
		{
			// Token: 0x040047D2 RID: 18386
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enum.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_Boolean_byref_TEnum_0, Il2CppClassPointerStore<Enum>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) }))));
		}
	}
}
