using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000097 RID: 151
	public static class DateTimeFormat : Object
	{
		// Token: 0x06000A30 RID: 2608 RVA: 0x00053D1C File Offset: 0x00051F1C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormat()
		{
			Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeFormat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr);
			DateTimeFormat.NativeFieldInfoPtr_NullOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "NullOffset");
			DateTimeFormat.NativeFieldInfoPtr_allStandardFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "allStandardFormats");
			DateTimeFormat.NativeFieldInfoPtr_InvariantFormatInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "InvariantFormatInfo");
			DateTimeFormat.NativeFieldInfoPtr_InvariantAbbreviatedMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "InvariantAbbreviatedMonthNames");
			DateTimeFormat.NativeFieldInfoPtr_InvariantAbbreviatedDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "InvariantAbbreviatedDayNames");
			DateTimeFormat.NativeFieldInfoPtr_fixedNumberFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, "fixedNumberFormats");
			DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665073);
			DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665074);
			DateTimeFormat.NativeMethodInfoPtr_HebrewFormatDigits_Private_Static_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665075);
			DateTimeFormat.NativeMethodInfoPtr_ParseRepeatPattern_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665076);
			DateTimeFormat.NativeMethodInfoPtr_FormatDayOfWeek_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665077);
			DateTimeFormat.NativeMethodInfoPtr_FormatMonth_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665078);
			DateTimeFormat.NativeMethodInfoPtr_FormatHebrewMonthName_Private_Static_String_DateTime_Int32_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665079);
			DateTimeFormat.NativeMethodInfoPtr_ParseQuoteString_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665080);
			DateTimeFormat.NativeMethodInfoPtr_ParseNextChar_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665081);
			DateTimeFormat.NativeMethodInfoPtr_IsUseGenitiveForm_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665082);
			DateTimeFormat.NativeMethodInfoPtr_FormatCustomized_Private_Static_StringBuilder_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_TimeSpan_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665083);
			DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedTimeZone_Private_Static_Void_DateTime_TimeSpan_ReadOnlySpan_1_Char_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665084);
			DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedRoundripTimeZone_Private_Static_Void_DateTime_TimeSpan_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665085);
			DateTimeFormat.NativeMethodInfoPtr_Append2DigitNumber_Private_Static_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665086);
			DateTimeFormat.NativeMethodInfoPtr_GetRealFormat_Internal_Static_String_ReadOnlySpan_1_Char_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665087);
			DateTimeFormat.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_ReadOnlySpan_1_Char_byref_DateTime_byref_DateTimeFormatInfo_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665088);
			DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665089);
			DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_IFormatProvider_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665090);
			DateTimeFormat.NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_DateTime_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665091);
			DateTimeFormat.NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_DateTime_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665092);
			DateTimeFormat.NativeMethodInfoPtr_FormatStringBuilder_Private_Static_StringBuilder_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665093);
			DateTimeFormat.NativeMethodInfoPtr_TryFormatO_Private_Static_Boolean_DateTime_TimeSpan_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665094);
			DateTimeFormat.NativeMethodInfoPtr_TryFormatR_Private_Static_Boolean_DateTime_TimeSpan_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665095);
			DateTimeFormat.NativeMethodInfoPtr_WriteTwoDecimalDigits_Private_Static_Void_UInt32_Span_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665096);
			DateTimeFormat.NativeMethodInfoPtr_WriteFourDecimalDigits_Private_Static_Void_UInt32_Span_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665097);
			DateTimeFormat.NativeMethodInfoPtr_WriteDigits_Private_Static_Void_UInt64_Span_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665098);
			DateTimeFormat.NativeMethodInfoPtr_InvalidFormatForLocal_Internal_Static_Void_ReadOnlySpan_1_Char_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormat>.NativeClassPtr, 100665099);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00053FE0 File Offset: 0x000521E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1304687, RefRangeEnd = 1304695, XrefRangeStart = 1304683, XrefRangeEnd = 1304687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatDigits(StringBuilder outputBuffer, int value, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00054034 File Offset: 0x00052234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304696, RefRangeEnd = 1304697, XrefRangeStart = 1304695, XrefRangeEnd = 1304696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideLengthLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00054094 File Offset: 0x00052294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1304697, XrefRangeEnd = 1304703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HebrewFormatDigits(StringBuilder outputBuffer, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_HebrewFormatDigits_Private_Static_Void_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000540D8 File Offset: 0x000522D8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1304704, RefRangeEnd = 1304719, XrefRangeStart = 1304703, XrefRangeEnd = 1304704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseRepeatPattern(ReadOnlySpan<char> format, int pos, char patternChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref patternChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ParseRepeatPattern_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0005413C File Offset: 0x0005233C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1304719, XrefRangeEnd = 1304722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dayOfWeek;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatDayOfWeek_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00054194 File Offset: 0x00052394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1304722, XrefRangeEnd = 1304725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatMonth_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000541EC File Offset: 0x000523EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304726, RefRangeEnd = 1304727, XrefRangeStart = 1304725, XrefRangeEnd = 1304726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatHebrewMonthName_Private_Static_String_DateTime_Int32_Int32_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00054254 File Offset: 0x00052454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304731, RefRangeEnd = 1304732, XrefRangeStart = 1304727, XrefRangeEnd = 1304731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ParseQuoteString_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000542BC File Offset: 0x000524BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304733, RefRangeEnd = 1304734, XrefRangeStart = 1304732, XrefRangeEnd = 1304733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNextChar(ReadOnlySpan<char> format, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ParseNextChar_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00054310 File Offset: 0x00052510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304736, RefRangeEnd = 1304737, XrefRangeStart = 1304734, XrefRangeEnd = 1304736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUseGenitiveForm(ReadOnlySpan<char> format, int index, int tokenLen, char patternToMatch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref patternToMatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_IsUseGenitiveForm_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00054380 File Offset: 0x00052580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1304970, RefRangeEnd = 1304972, XrefRangeStart = 1304737, XrefRangeEnd = 1304970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder FormatCustomized(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatCustomized_Private_Static_StringBuilder_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_TimeSpan_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0005440C File Offset: 0x0005260C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305042, RefRangeEnd = 1305043, XrefRangeStart = 1304972, XrefRangeEnd = 1305042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, ReadOnlySpan<char> format, int tokenLen, bool timeOnly, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenLen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOnly;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedTimeZone_Private_Static_Void_DateTime_TimeSpan_ReadOnlySpan_1_Char_Int32_Boolean_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00054494 File Offset: 0x00052694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305061, RefRangeEnd = 1305062, XrefRangeStart = 1305043, XrefRangeEnd = 1305061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatCustomizedRoundripTimeZone_Private_Static_Void_DateTime_TimeSpan_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000544E8 File Offset: 0x000526E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Append2DigitNumber(StringBuilder result, int val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_Append2DigitNumber_Private_Static_Void_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0005452C File Offset: 0x0005272C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305062, XrefRangeEnd = 1305076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRealFormat(ReadOnlySpan<char> format, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_GetRealFormat_Internal_Static_String_ReadOnlySpan_1_Char_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00054580 File Offset: 0x00052780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305131, RefRangeEnd = 1305132, XrefRangeStart = 1305076, XrefRangeEnd = 1305131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dateTime;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_ReadOnlySpan_1_Char_byref_DateTime_byref_DateTimeFormatInfo_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dtfi = ((intPtr4 == 0) ? null : new DateTimeFormatInfo(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00054608 File Offset: 0x00052808
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1305137, RefRangeEnd = 1305142, XrefRangeStart = 1305132, XrefRangeEnd = 1305137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(DateTime dateTime, string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00054664 File Offset: 0x00052864
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1305174, RefRangeEnd = 1305179, XrefRangeStart = 1305142, XrefRangeEnd = 1305174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(DateTime dateTime, string format, IFormatProvider provider, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_IFormatProvider_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000546D0 File Offset: 0x000528D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305179, XrefRangeEnd = 1305184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormat(DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_DateTime_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0005475C File Offset: 0x0005295C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1305199, RefRangeEnd = 1305202, XrefRangeStart = 1305184, XrefRangeEnd = 1305199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormat(DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_DateTime_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000547F8 File Offset: 0x000529F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305242, RefRangeEnd = 1305244, XrefRangeStart = 1305202, XrefRangeEnd = 1305242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder FormatStringBuilder(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_FormatStringBuilder_Private_Static_StringBuilder_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00054870 File Offset: 0x00052A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305308, RefRangeEnd = 1305309, XrefRangeStart = 1305244, XrefRangeEnd = 1305308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormatO(DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_TryFormatO_Private_Static_Boolean_DateTime_TimeSpan_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000548E0 File Offset: 0x00052AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305342, RefRangeEnd = 1305343, XrefRangeStart = 1305309, XrefRangeEnd = 1305342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormatR(DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_TryFormatR_Private_Static_Boolean_DateTime_TimeSpan_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00054950 File Offset: 0x00052B50
		[CallerCount(0)]
		public unsafe static void WriteTwoDecimalDigits(uint value, Span<char> destination, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_WriteTwoDecimalDigits_Private_Static_Void_UInt32_Span_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000549A8 File Offset: 0x00052BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305343, RefRangeEnd = 1305345, XrefRangeStart = 1305343, XrefRangeEnd = 1305343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteFourDecimalDigits(uint value, Span<char> buffer, int startingIndex = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startingIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_WriteFourDecimalDigits_Private_Static_Void_UInt32_Span_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00054A00 File Offset: 0x00052C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305345, XrefRangeEnd = 1305346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteDigits(ulong value, Span<char> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_WriteDigits_Private_Static_Void_UInt64_Span_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00054A4C File Offset: 0x00052C4C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvalidFormatForLocal(ReadOnlySpan<char> format, DateTime dateTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormat.NativeMethodInfoPtr_InvalidFormatForLocal_Internal_Static_Void_ReadOnlySpan_1_Char_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0000482C File Offset: 0x00002A2C
		public DateTimeFormat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00054A98 File Offset: 0x00052C98
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00004835 File Offset: 0x00002A35
		public unsafe static TimeSpan NullOffset
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_NullOffset, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_NullOffset, (void*)(&value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00054AB4 File Offset: 0x00052CB4
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00004843 File Offset: 0x00002A43
		public unsafe static Il2CppStructArray<char> allStandardFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_allStandardFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_allStandardFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00054ADC File Offset: 0x00052CDC
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x00004855 File Offset: 0x00002A55
		public unsafe static DateTimeFormatInfo InvariantFormatInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_InvariantFormatInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_InvariantFormatInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00054B04 File Offset: 0x00052D04
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00004867 File Offset: 0x00002A67
		public unsafe static Il2CppStringArray InvariantAbbreviatedMonthNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_InvariantAbbreviatedMonthNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_InvariantAbbreviatedMonthNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00054B2C File Offset: 0x00052D2C
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00004879 File Offset: 0x00002A79
		public unsafe static Il2CppStringArray InvariantAbbreviatedDayNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_InvariantAbbreviatedDayNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_InvariantAbbreviatedDayNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00054B54 File Offset: 0x00052D54
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0000488B File Offset: 0x00002A8B
		public unsafe static Il2CppStringArray fixedNumberFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormat.NativeFieldInfoPtr_fixedNumberFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormat.NativeFieldInfoPtr_fixedNumberFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeFieldInfoPtr_NullOffset;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeFieldInfoPtr_allStandardFormats;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeFieldInfoPtr_InvariantFormatInfo;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr_InvariantAbbreviatedMonthNames;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_InvariantAbbreviatedDayNames;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_fixedNumberFormats;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_FormatDigits_Internal_Static_Void_StringBuilder_Int32_Int32_Boolean_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_HebrewFormatDigits_Private_Static_Void_StringBuilder_Int32_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_ParseRepeatPattern_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_Char_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_FormatDayOfWeek_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_FormatMonth_Private_Static_String_Int32_Int32_DateTimeFormatInfo_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_FormatHebrewMonthName_Private_Static_String_DateTime_Int32_Int32_DateTimeFormatInfo_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_ParseQuoteString_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_StringBuilder_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_ParseNextChar_Internal_Static_Int32_ReadOnlySpan_1_Char_Int32_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_IsUseGenitiveForm_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_Char_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomized_Private_Static_StringBuilder_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_TimeSpan_StringBuilder_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomizedTimeZone_Private_Static_Void_DateTime_TimeSpan_ReadOnlySpan_1_Char_Int32_Boolean_StringBuilder_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomizedRoundripTimeZone_Private_Static_Void_DateTime_TimeSpan_StringBuilder_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_Append2DigitNumber_Private_Static_Void_StringBuilder_Int32_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_GetRealFormat_Internal_Static_String_ReadOnlySpan_1_Char_DateTimeFormatInfo_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_ReadOnlySpan_1_Char_byref_DateTime_byref_DateTimeFormatInfo_byref_TimeSpan_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_IFormatProvider_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_DateTime_String_IFormatProvider_TimeSpan_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_DateTime_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_DateTime_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_TimeSpan_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_FormatStringBuilder_Private_Static_StringBuilder_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_TimeSpan_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_TryFormatO_Private_Static_Boolean_DateTime_TimeSpan_Span_1_Char_byref_Int32_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_TryFormatR_Private_Static_Boolean_DateTime_TimeSpan_Span_1_Char_byref_Int32_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_WriteTwoDecimalDigits_Private_Static_Void_UInt32_Span_1_Char_Int32_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_WriteFourDecimalDigits_Private_Static_Void_UInt32_Span_1_Char_Int32_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_WriteDigits_Private_Static_Void_UInt64_Span_1_Char_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_InvalidFormatForLocal_Internal_Static_Void_ReadOnlySpan_1_Char_DateTime_0;
	}
}
