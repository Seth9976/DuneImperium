using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000008 RID: 8
	public class FormatProvider : Object
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00005680 File Offset: 0x00003880
		// Note: this type is marked as 'beforefieldinit'.
		static FormatProvider()
		{
			Il2CppClassPointerStore<FormatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Numerics.dll", "System.Globalization", "FormatProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatProvider>.NativeClassPtr);
			FormatProvider.NativeMethodInfoPtr_FormatBigInteger_Internal_Static_Void_byref_ValueStringBuilder_Int32_Int32_Boolean_ReadOnlySpan_1_Char_NumberFormatInfo_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider>.NativeClassPtr, 100663414);
			FormatProvider.NativeMethodInfoPtr_TryStringToBigInteger_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_StringBuilder_byref_Int32_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider>.NativeClassPtr, 100663415);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000056D8 File Offset: 0x000038D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236688, XrefRangeEnd = 1236699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatBigInteger(ref Il2CppSystem.Text.ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, Il2CppStructArray<char> digits, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sign;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numberFormatInfo);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(digits);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.NativeMethodInfoPtr_FormatBigInteger_Internal_Static_Void_byref_ValueStringBuilder_Int32_Int32_Boolean_ReadOnlySpan_1_Char_NumberFormatInfo_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00005788 File Offset: 0x00003988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236699, XrefRangeEnd = 1236714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numberFormatInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(receiver);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &precision;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scale;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sign;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.NativeMethodInfoPtr_TryStringToBigInteger_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_StringBuilder_byref_Int32_byref_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000021BA File Offset: 0x000003BA
		public FormatProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_FormatBigInteger_Internal_Static_Void_byref_ValueStringBuilder_Int32_Int32_Boolean_ReadOnlySpan_1_Char_NumberFormatInfo_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_TryStringToBigInteger_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_StringBuilder_byref_Int32_byref_Int32_byref_Boolean_0;

		// Token: 0x0200000C RID: 12
		public class Number : Object
		{
			// Token: 0x060000BD RID: 189 RVA: 0x00005FC4 File Offset: 0x000041C4
			// Note: this type is marked as 'beforefieldinit'.
			static Number()
			{
				Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatProvider>.NativeClassPtr, "Number");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr);
				FormatProvider.Number.NativeFieldInfoPtr_s_posCurrencyFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, "s_posCurrencyFormats");
				FormatProvider.Number.NativeFieldInfoPtr_s_negCurrencyFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, "s_negCurrencyFormats");
				FormatProvider.Number.NativeFieldInfoPtr_s_posPercentFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, "s_posPercentFormats");
				FormatProvider.Number.NativeFieldInfoPtr_s_negPercentFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, "s_negPercentFormats");
				FormatProvider.Number.NativeFieldInfoPtr_s_negNumberFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, "s_negNumberFormats");
				FormatProvider.Number.NativeFieldInfoPtr_s_posNumberFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, "s_posNumberFormat");
				FormatProvider.Number.NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663416);
				FormatProvider.Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663417);
				FormatProvider.Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663418);
				FormatProvider.Number.NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_ptr_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663419);
				FormatProvider.Number.NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663420);
				FormatProvider.Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663421);
				FormatProvider.Number.NativeMethodInfoPtr_Int32ToDecChars_Internal_Static_Void_ptr_Char_byref_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663422);
				FormatProvider.Number.NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663423);
				FormatProvider.Number.NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663424);
				FormatProvider.Number.NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663425);
				FormatProvider.Number.NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663426);
				FormatProvider.Number.NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663427);
				FormatProvider.Number.NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663428);
				FormatProvider.Number.NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663429);
				FormatProvider.Number.NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663430);
				FormatProvider.Number.NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663431);
				FormatProvider.Number.NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663432);
				FormatProvider.Number.NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663433);
				FormatProvider.Number.NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663434);
				FormatProvider.Number.NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, 100663435);
			}

			// Token: 0x060000BE RID: 190 RVA: 0x000061F8 File Offset: 0x000043F8
			[CallerCount(0)]
			public unsafe static bool IsWhite(char ch)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000BF RID: 191 RVA: 0x00006238 File Offset: 0x00004438
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1236294, RefRangeEnd = 1236301, XrefRangeStart = 1236289, XrefRangeEnd = 1236294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static char* MatchChars(char* p, char* pEnd, string str)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = p;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x0000628C File Offset: 0x0000448C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236301, XrefRangeEnd = 1236302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static char* MatchChars(char* p, char* pEnd, char* str)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = p;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = str;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x000062D8 File Offset: 0x000044D8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1236392, RefRangeEnd = 1236395, XrefRangeStart = 1236302, XrefRangeEnd = 1236392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
			{
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(str);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = strEnd;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_ptr_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				str = ((intPtr4 == 0) ? null : new char*(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00006390 File Offset: 0x00004590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236395, XrefRangeEnd = 1236396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TrailingZeros(ReadOnlySpan<char> s, int index)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x000063E4 File Offset: 0x000045E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236396, XrefRangeEnd = 1236408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x0000647C File Offset: 0x0000467C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236408, XrefRangeEnd = 1236409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = buffer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_Int32ToDecChars_Internal_Static_Void_ptr_Char_byref_Int32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x000064D8 File Offset: 0x000046D8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1236414, RefRangeEnd = 1236416, XrefRangeStart = 1236409, XrefRangeEnd = 1236414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &digits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x0000652C File Offset: 0x0000472C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1236442, RefRangeEnd = 1236444, XrefRangeStart = 1236416, XrefRangeEnd = 1236442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void NumberToString(ref Il2CppSystem.Text.ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDecimal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000C7 RID: 199 RVA: 0x000065B0 File Offset: 0x000047B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236444, XrefRangeEnd = 1236463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void FormatCurrency(ref Il2CppSystem.Text.ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000C8 RID: 200 RVA: 0x00006624 File Offset: 0x00004824
			[CallerCount(0)]
			public unsafe static int wcslen(char* s)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x00006660 File Offset: 0x00004860
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1236495, RefRangeEnd = 1236499, XrefRangeStart = 1236463, XrefRangeEnd = 1236495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void FormatFixed(ref Il2CppSystem.Text.ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Il2CppStructArray<int> groupDigits, string sDecimal, string sGroup)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groupDigits);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sDecimal);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000CA RID: 202 RVA: 0x00006710 File Offset: 0x00004910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236499, XrefRangeEnd = 1236516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void FormatNumber(ref Il2CppSystem.Text.ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000CB RID: 203 RVA: 0x00006784 File Offset: 0x00004984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236516, XrefRangeEnd = 1236530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void FormatScientific(ref Il2CppSystem.Text.ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000CC RID: 204 RVA: 0x00006808 File Offset: 0x00004A08
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1236543, RefRangeEnd = 1236546, XrefRangeStart = 1236530, XrefRangeEnd = 1236543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void FormatExponent(ref Il2CppSystem.Text.ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expChar;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDigits;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positiveSign;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000CD RID: 205 RVA: 0x0000688C File Offset: 0x00004A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236546, XrefRangeEnd = 1236568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void FormatGeneral(ref Il2CppSystem.Text.ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expChar;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSuppressScientific;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000CE RID: 206 RVA: 0x0000691C File Offset: 0x00004B1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1236587, RefRangeEnd = 1236588, XrefRangeStart = 1236568, XrefRangeEnd = 1236587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void FormatPercent(ref Il2CppSystem.Text.ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000CF RID: 207 RVA: 0x00006990 File Offset: 0x00004B90
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1236588, RefRangeEnd = 1236591, XrefRangeStart = 1236588, XrefRangeEnd = 1236588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &number;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x000069D0 File Offset: 0x00004BD0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1236595, RefRangeEnd = 1236596, XrefRangeStart = 1236591, XrefRangeEnd = 1236595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int FindSection(ReadOnlySpan<char> format, int section)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref section;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x00006A24 File Offset: 0x00004C24
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1236686, RefRangeEnd = 1236688, XrefRangeStart = 1236596, XrefRangeEnd = 1236686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void NumberToStringFormat(ref Il2CppSystem.Text.ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x000022D1 File Offset: 0x000004D1
			public Number(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000D3 RID: 211 RVA: 0x00006A94 File Offset: 0x00004C94
			// (set) Token: 0x060000D4 RID: 212 RVA: 0x000022DA File Offset: 0x000004DA
			public unsafe static Il2CppStringArray s_posCurrencyFormats
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormatProvider.Number.NativeFieldInfoPtr_s_posCurrencyFormats, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormatProvider.Number.NativeFieldInfoPtr_s_posCurrencyFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000D5 RID: 213 RVA: 0x00006ABC File Offset: 0x00004CBC
			// (set) Token: 0x060000D6 RID: 214 RVA: 0x000022EC File Offset: 0x000004EC
			public unsafe static Il2CppStringArray s_negCurrencyFormats
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormatProvider.Number.NativeFieldInfoPtr_s_negCurrencyFormats, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormatProvider.Number.NativeFieldInfoPtr_s_negCurrencyFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000D7 RID: 215 RVA: 0x00006AE4 File Offset: 0x00004CE4
			// (set) Token: 0x060000D8 RID: 216 RVA: 0x000022FE File Offset: 0x000004FE
			public unsafe static Il2CppStringArray s_posPercentFormats
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormatProvider.Number.NativeFieldInfoPtr_s_posPercentFormats, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormatProvider.Number.NativeFieldInfoPtr_s_posPercentFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x00006B0C File Offset: 0x00004D0C
			// (set) Token: 0x060000DA RID: 218 RVA: 0x00002310 File Offset: 0x00000510
			public unsafe static Il2CppStringArray s_negPercentFormats
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormatProvider.Number.NativeFieldInfoPtr_s_negPercentFormats, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormatProvider.Number.NativeFieldInfoPtr_s_negPercentFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000DB RID: 219 RVA: 0x00006B34 File Offset: 0x00004D34
			// (set) Token: 0x060000DC RID: 220 RVA: 0x00002322 File Offset: 0x00000522
			public unsafe static Il2CppStringArray s_negNumberFormats
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormatProvider.Number.NativeFieldInfoPtr_s_negNumberFormats, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormatProvider.Number.NativeFieldInfoPtr_s_negNumberFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000DD RID: 221 RVA: 0x00006B5C File Offset: 0x00004D5C
			// (set) Token: 0x060000DE RID: 222 RVA: 0x00002334 File Offset: 0x00000534
			public unsafe static string s_posNumberFormat
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormatProvider.Number.NativeFieldInfoPtr_s_posNumberFormat, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormatProvider.Number.NativeFieldInfoPtr_s_posNumberFormat, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400009E RID: 158
			private static readonly IntPtr NativeFieldInfoPtr_s_posCurrencyFormats;

			// Token: 0x0400009F RID: 159
			private static readonly IntPtr NativeFieldInfoPtr_s_negCurrencyFormats;

			// Token: 0x040000A0 RID: 160
			private static readonly IntPtr NativeFieldInfoPtr_s_posPercentFormats;

			// Token: 0x040000A1 RID: 161
			private static readonly IntPtr NativeFieldInfoPtr_s_negPercentFormats;

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeFieldInfoPtr_s_negNumberFormats;

			// Token: 0x040000A3 RID: 163
			private static readonly IntPtr NativeFieldInfoPtr_s_posNumberFormat;

			// Token: 0x040000A4 RID: 164
			private static readonly IntPtr NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Char_0;

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_String_0;

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_ptr_Char_0;

			// Token: 0x040000A7 RID: 167
			private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_ptr_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0;

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0;

			// Token: 0x040000A9 RID: 169
			private static readonly IntPtr NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0;

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeMethodInfoPtr_Int32ToDecChars_Internal_Static_Void_ptr_Char_byref_Int32_UInt32_Int32_0;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0;

			// Token: 0x040000AC RID: 172
			private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0;

			// Token: 0x040000AD RID: 173
			private static readonly IntPtr NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

			// Token: 0x040000AE RID: 174
			private static readonly IntPtr NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0;

			// Token: 0x040000AF RID: 175
			private static readonly IntPtr NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0;

			// Token: 0x040000B0 RID: 176
			private static readonly IntPtr NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

			// Token: 0x040000B1 RID: 177
			private static readonly IntPtr NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0;

			// Token: 0x040000B2 RID: 178
			private static readonly IntPtr NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0;

			// Token: 0x040000B3 RID: 179
			private static readonly IntPtr NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0;

			// Token: 0x040000B4 RID: 180
			private static readonly IntPtr NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

			// Token: 0x040000B5 RID: 181
			private static readonly IntPtr NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0;

			// Token: 0x040000B6 RID: 182
			private static readonly IntPtr NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0;

			// Token: 0x040000B7 RID: 183
			private static readonly IntPtr NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0;

			// Token: 0x0200000D RID: 13
			[StructLayout(2)]
			public struct NumberBuffer
			{
				// Token: 0x060000DF RID: 223 RVA: 0x00006B7C File Offset: 0x00004D7C
				// Note: this type is marked as 'beforefieldinit'.
				static NumberBuffer()
				{
					Il2CppClassPointerStore<FormatProvider.Number.NumberBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatProvider.Number>.NativeClassPtr, "NumberBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatProvider.Number.NumberBuffer>.NativeClassPtr);
					FormatProvider.Number.NumberBuffer.NativeFieldInfoPtr_precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatProvider.Number.NumberBuffer>.NativeClassPtr, "precision");
					FormatProvider.Number.NumberBuffer.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatProvider.Number.NumberBuffer>.NativeClassPtr, "scale");
					FormatProvider.Number.NumberBuffer.NativeFieldInfoPtr_sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatProvider.Number.NumberBuffer>.NativeClassPtr, "sign");
					FormatProvider.Number.NumberBuffer.NativeFieldInfoPtr_overrideDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatProvider.Number.NumberBuffer>.NativeClassPtr, "overrideDigits");
					FormatProvider.Number.NumberBuffer.NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider.Number.NumberBuffer>.NativeClassPtr, 100663437);
				}

				// Token: 0x1700001D RID: 29
				// (get) Token: 0x060000E0 RID: 224 RVA: 0x00006C0C File Offset: 0x00004E0C
				public unsafe char* digits
				{
					[CallerCount(10)]
					[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatProvider.Number.NumberBuffer.NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return intPtr;
					}
				}

				// Token: 0x060000E1 RID: 225 RVA: 0x00002346 File Offset: 0x00000546
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FormatProvider.Number.NumberBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x040000B8 RID: 184
				private static readonly IntPtr NativeFieldInfoPtr_precision;

				// Token: 0x040000B9 RID: 185
				private static readonly IntPtr NativeFieldInfoPtr_scale;

				// Token: 0x040000BA RID: 186
				private static readonly IntPtr NativeFieldInfoPtr_sign;

				// Token: 0x040000BB RID: 187
				private static readonly IntPtr NativeFieldInfoPtr_overrideDigits;

				// Token: 0x040000BC RID: 188
				private static readonly IntPtr NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0;

				// Token: 0x040000BD RID: 189
				[FieldOffset(0)]
				public int precision;

				// Token: 0x040000BE RID: 190
				[FieldOffset(4)]
				public int scale;

				// Token: 0x040000BF RID: 191
				[FieldOffset(8)]
				[MarshalAs(4)]
				public bool sign;

				// Token: 0x040000C0 RID: 192
				[FieldOffset(16)]
				public IntPtr overrideDigits;
			}
		}
	}
}
