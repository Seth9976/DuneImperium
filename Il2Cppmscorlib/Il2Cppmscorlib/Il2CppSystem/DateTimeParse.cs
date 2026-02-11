using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000098 RID: 152
	public static class DateTimeParse : Object
	{
		// Token: 0x06000A59 RID: 2649 RVA: 0x00054B7C File Offset: 0x00052D7C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeParse()
		{
			Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeParse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr);
			DateTimeParse.NativeFieldInfoPtr_m_hebrewNumberParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "m_hebrewNumberParser");
			DateTimeParse.NativeFieldInfoPtr_dateParsingStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "dateParsingStates");
			DateTimeParse.NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665101);
			DateTimeParse.NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665102);
			DateTimeParse.NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665103);
			DateTimeParse.NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665104);
			DateTimeParse.NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665105);
			DateTimeParse.NativeMethodInfoPtr_ParseExactMultiple_Internal_Static_DateTime_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665106);
			DateTimeParse.NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665107);
			DateTimeParse.NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665108);
			DateTimeParse.NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665109);
			DateTimeParse.NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665110);
			DateTimeParse.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665111);
			DateTimeParse.NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665112);
			DateTimeParse.NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665113);
			DateTimeParse.NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665114);
			DateTimeParse.NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665115);
			DateTimeParse.NativeMethodInfoPtr_GetJapaneseCalendarDefaultInstance_Private_Static_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665116);
			DateTimeParse.NativeMethodInfoPtr_GetTaiwanCalendarDefaultInstance_Internal_Static_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665117);
			DateTimeParse.NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665118);
			DateTimeParse.NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665119);
			DateTimeParse.NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665120);
			DateTimeParse.NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665121);
			DateTimeParse.NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665122);
			DateTimeParse.NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665123);
			DateTimeParse.NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665124);
			DateTimeParse.NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665125);
			DateTimeParse.NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665126);
			DateTimeParse.NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665127);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665128);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665129);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665130);
			DateTimeParse.NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665131);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665132);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665133);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665134);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665135);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665136);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665137);
			DateTimeParse.NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665138);
			DateTimeParse.NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665139);
			DateTimeParse.NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665140);
			DateTimeParse.NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665141);
			DateTimeParse.NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665142);
			DateTimeParse.NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665143);
			DateTimeParse.NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665144);
			DateTimeParse.NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665145);
			DateTimeParse.NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665146);
			DateTimeParse.NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665147);
			DateTimeParse.NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665148);
			DateTimeParse.NativeMethodInfoPtr_ProcessTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665149);
			DateTimeParse.NativeMethodInfoPtr_Parse_Internal_Static_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665150);
			DateTimeParse.NativeMethodInfoPtr_Parse_Internal_Static_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665151);
			DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665152);
			DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665153);
			DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665154);
			DateTimeParse.NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665155);
			DateTimeParse.NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665156);
			DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665157);
			DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665158);
			DateTimeParse.NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665159);
			DateTimeParse.NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665160);
			DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665161);
			DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665162);
			DateTimeParse.NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665163);
			DateTimeParse.NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665164);
			DateTimeParse.NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665165);
			DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665166);
			DateTimeParse.NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665167);
			DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665168);
			DateTimeParse.NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665169);
			DateTimeParse.NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665170);
			DateTimeParse.NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665171);
			DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665172);
			DateTimeParse.NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665173);
			DateTimeParse.NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665174);
			DateTimeParse.NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665175);
			DateTimeParse.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_ReadOnlySpan_1_Char_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665176);
			DateTimeParse.NativeMethodInfoPtr_ParseJapaneseEraStart_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665177);
			DateTimeParse.NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665178);
			DateTimeParse.NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_ReadOnlySpan_1_Char_Int32_StringBuilder_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665179);
			DateTimeParse.NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665180);
			DateTimeParse.NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665181);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00055228 File Offset: 0x00053428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305359, XrefRangeEnd = 1305369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000552A8 File Offset: 0x000534A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305369, XrefRangeEnd = 1305383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00055334 File Offset: 0x00053534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305383, XrefRangeEnd = 1305402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000553C0 File Offset: 0x000535C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305402, XrefRangeEnd = 1305425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0005545C File Offset: 0x0005365C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305425, XrefRangeEnd = 1305436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x000554F0 File Offset: 0x000536F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305436, XrefRangeEnd = 1305441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExactMultiple(ReadOnlySpan<char> s, Il2CppStringArray formats, DateTimeFormatInfo dtfi, DateTimeStyles style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formats);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseExactMultiple_Internal_Static_DateTime_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00055568 File Offset: 0x00053768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305441, XrefRangeEnd = 1305455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExactMultiple(ReadOnlySpan<char> s, Il2CppStringArray formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formats);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00055600 File Offset: 0x00053800
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1305479, RefRangeEnd = 1305483, XrefRangeStart = 1305455, XrefRangeEnd = 1305479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExactMultiple(ReadOnlySpan<char> s, Il2CppStringArray formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formats);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0005568C File Offset: 0x0005388C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305499, RefRangeEnd = 1305501, XrefRangeStart = 1305483, XrefRangeEnd = 1305499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchWord(ref __DTString str, string target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x000556E0 File Offset: 0x000538E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305501, XrefRangeEnd = 1305512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeZoneName(ref __DTString str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00055724 File Offset: 0x00053924
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 380097, RefRangeEnd = 380109, XrefRangeStart = 380097, XrefRangeEnd = 380109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00055764 File Offset: 0x00053964
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305520, RefRangeEnd = 1305522, XrefRangeStart = 1305512, XrefRangeEnd = 1305520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseFraction(ref __DTString str, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x000557B4 File Offset: 0x000539B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305550, RefRangeEnd = 1305552, XrefRangeStart = 1305522, XrefRangeEnd = 1305550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseTimeZone(ref __DTString str, ref TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00055804 File Offset: 0x00053A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305570, RefRangeEnd = 1305571, XrefRangeStart = 1305552, XrefRangeEnd = 1305570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0005585C File Offset: 0x00053A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305599, RefRangeEnd = 1305600, XrefRangeStart = 1305571, XrefRangeEnd = 1305599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dtok;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dtfi = ((intPtr4 == 0) ? null : new DateTimeFormatInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00055918 File Offset: 0x00053B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305600, XrefRangeEnd = 1305616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Calendar GetJapaneseCalendarDefaultInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetJapaneseCalendarDefaultInstance_Private_Static_Calendar_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0005594C File Offset: 0x00053B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305616, XrefRangeEnd = 1305632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Calendar GetTaiwanCalendarDefaultInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTaiwanCalendarDefaultInstance_Internal_Static_Calendar_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00055980 File Offset: 0x00053B80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305642, RefRangeEnd = 1305644, XrefRangeStart = 1305632, XrefRangeEnd = 1305642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool VerifyValidPunctuation(ref __DTString str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x000559C4 File Offset: 0x00053BC4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1305653, RefRangeEnd = 1305659, XrefRangeStart = 1305644, XrefRangeEnd = 1305653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(datePattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00055A28 File Offset: 0x00053C28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305665, RefRangeEnd = 1305667, XrefRangeStart = 1305659, XrefRangeEnd = 1305665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00055A8C File Offset: 0x00053C8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1305674, RefRangeEnd = 1305679, XrefRangeStart = 1305667, XrefRangeEnd = 1305674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00055AF0 File Offset: 0x00053CF0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1305680, RefRangeEnd = 1305694, XrefRangeStart = 1305679, XrefRangeEnd = 1305680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &adjustedYear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00055B50 File Offset: 0x00053D50
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1305694, RefRangeEnd = 1305709, XrefRangeStart = 1305694, XrefRangeEnd = 1305694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00055BBC File Offset: 0x00053DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305709, XrefRangeEnd = 1305713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00055C28 File Offset: 0x00053E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305713, XrefRangeEnd = 1305717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00055C94 File Offset: 0x00053E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305717, XrefRangeEnd = 1305721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00055D00 File Offset: 0x00053F00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1305725, RefRangeEnd = 1305729, XrefRangeStart = 1305721, XrefRangeEnd = 1305725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00055D48 File Offset: 0x00053F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305749, RefRangeEnd = 1305750, XrefRangeStart = 1305729, XrefRangeEnd = 1305749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00055DB8 File Offset: 0x00053FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305798, RefRangeEnd = 1305799, XrefRangeStart = 1305750, XrefRangeEnd = 1305798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00055E1C File Offset: 0x0005401C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305831, RefRangeEnd = 1305832, XrefRangeStart = 1305799, XrefRangeEnd = 1305831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00055E8C File Offset: 0x0005408C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305832, XrefRangeEnd = 1305840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00055EF0 File Offset: 0x000540F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1305872, RefRangeEnd = 1305873, XrefRangeStart = 1305840, XrefRangeEnd = 1305872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00055F60 File Offset: 0x00054160
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305906, RefRangeEnd = 1305908, XrefRangeStart = 1305873, XrefRangeEnd = 1305906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00055FC4 File Offset: 0x000541C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305908, XrefRangeEnd = 1305923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00056028 File Offset: 0x00054228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305942, RefRangeEnd = 1305944, XrefRangeStart = 1305923, XrefRangeEnd = 1305942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0005608C File Offset: 0x0005428C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305949, RefRangeEnd = 1305951, XrefRangeStart = 1305944, XrefRangeEnd = 1305949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000560DC File Offset: 0x000542DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305951, XrefRangeEnd = 1305956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0005612C File Offset: 0x0005432C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305960, RefRangeEnd = 1305962, XrefRangeStart = 1305956, XrefRangeEnd = 1305960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0005617C File Offset: 0x0005437C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305962, XrefRangeEnd = 1305968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x000561C0 File Offset: 0x000543C0
		[CallerCount(0)]
		public unsafe static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hour;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0005620C File Offset: 0x0005440C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305969, RefRangeEnd = 1305971, XrefRangeStart = 1305968, XrefRangeEnd = 1305969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0005625C File Offset: 0x0005445C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305973, RefRangeEnd = 1305975, XrefRangeStart = 1305971, XrefRangeEnd = 1305973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000562AC File Offset: 0x000544AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1305978, RefRangeEnd = 1305980, XrefRangeStart = 1305975, XrefRangeEnd = 1305978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000562FC File Offset: 0x000544FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305980, XrefRangeEnd = 1305981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0005634C File Offset: 0x0005454C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305981, XrefRangeEnd = 1305986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0005639C File Offset: 0x0005459C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306006, RefRangeEnd = 1306007, XrefRangeStart = 1305986, XrefRangeEnd = 1306006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00056400 File Offset: 0x00054600
		[CallerCount(0)]
		public unsafe static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dtok;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00056460 File Offset: 0x00054660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306069, RefRangeEnd = 1306070, XrefRangeStart = 1306007, XrefRangeEnd = 1306069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000564F4 File Offset: 0x000546F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306155, RefRangeEnd = 1306156, XrefRangeStart = 1306070, XrefRangeEnd = 1306155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &raw;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ProcessTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00056588 File Offset: 0x00054788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1306161, RefRangeEnd = 1306163, XrefRangeStart = 1306156, XrefRangeEnd = 1306161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_Parse_Internal_Static_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000565F0 File Offset: 0x000547F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306163, XrefRangeEnd = 1306168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_Parse_Internal_Static_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00056664 File Offset: 0x00054864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1306178, RefRangeEnd = 1306180, XrefRangeStart = 1306168, XrefRangeEnd = 1306178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000566D8 File Offset: 0x000548D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306180, XrefRangeEnd = 1306194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0005675C File Offset: 0x0005495C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1306283, RefRangeEnd = 1306289, XrefRangeStart = 1306194, XrefRangeEnd = 1306283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x000567D8 File Offset: 0x000549D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1306324, RefRangeEnd = 1306326, XrefRangeStart = 1306289, XrefRangeEnd = 1306324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bTimeOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0005684C File Offset: 0x00054A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306352, RefRangeEnd = 1306353, XrefRangeStart = 1306326, XrefRangeEnd = 1306352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x000568B0 File Offset: 0x00054AB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1306364, RefRangeEnd = 1306366, XrefRangeStart = 1306353, XrefRangeEnd = 1306364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AdjustTimeZoneToUniversal(ref DateTimeResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000568F4 File Offset: 0x00054AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306400, RefRangeEnd = 1306401, XrefRangeStart = 1306366, XrefRangeEnd = 1306400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bTimeOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00056944 File Offset: 0x00054B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306501, RefRangeEnd = 1306502, XrefRangeStart = 1306401, XrefRangeEnd = 1306501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &raw;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000569B8 File Offset: 0x00054BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306502, XrefRangeEnd = 1306514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00056A18 File Offset: 0x00054C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306520, RefRangeEnd = 1306521, XrefRangeStart = 1306514, XrefRangeEnd = 1306520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseDigits(ref __DTString str, int digitLen, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00056A78 File Offset: 0x00054C78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1306530, RefRangeEnd = 1306537, XrefRangeStart = 1306521, XrefRangeEnd = 1306530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDigitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDigitLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00056AE4 File Offset: 0x00054CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306537, XrefRangeEnd = 1306552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDigitLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00056B44 File Offset: 0x00054D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306552, XrefRangeEnd = 1306559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseSign(ref __DTString str, ref bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00056B94 File Offset: 0x00054D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306589, RefRangeEnd = 1306590, XrefRangeStart = 1306559, XrefRangeEnd = 1306589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00056BF4 File Offset: 0x00054DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306590, XrefRangeEnd = 1306609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00056C58 File Offset: 0x00054E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306609, XrefRangeEnd = 1306633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00056CBC File Offset: 0x00054EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306633, XrefRangeEnd = 1306646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00056D20 File Offset: 0x00054F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306646, XrefRangeEnd = 1306659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00056D84 File Offset: 0x00054F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306659, XrefRangeEnd = 1306673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00056DE8 File Offset: 0x00054FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306673, XrefRangeEnd = 1306683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00056E4C File Offset: 0x0005504C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306683, XrefRangeEnd = 1306699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00056EB0 File Offset: 0x000550B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306706, RefRangeEnd = 1306707, XrefRangeStart = 1306699, XrefRangeEnd = 1306706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref patternChar;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00056F1C File Offset: 0x0005511C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306721, RefRangeEnd = 1306722, XrefRangeStart = 1306707, XrefRangeEnd = 1306721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00056F6C File Offset: 0x0005516C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306727, RefRangeEnd = 1306728, XrefRangeStart = 1306722, XrefRangeEnd = 1306727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cal);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cal = ((intPtr4 == 0) ? null : new Calendar(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00056FE8 File Offset: 0x000551E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306793, RefRangeEnd = 1306794, XrefRangeStart = 1306728, XrefRangeEnd = 1306793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_ReadOnlySpan_1_Char_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dtfi = ((intPtr4 == 0) ? null : new DateTimeFormatInfo(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00057078 File Offset: 0x00055278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306794, XrefRangeEnd = 1306803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseJapaneseEraStart_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000570CC File Offset: 0x000552CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1306894, RefRangeEnd = 1306895, XrefRangeStart = 1306803, XrefRangeEnd = 1306894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0005715C File Offset: 0x0005535C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306895, XrefRangeEnd = 1306898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result, out int returnValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_ReadOnlySpan_1_Char_Int32_StringBuilder_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x000571D0 File Offset: 0x000553D0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1306976, RefRangeEnd = 1306986, XrefRangeStart = 1306898, XrefRangeEnd = 1306976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoStrictParse(ReadOnlySpan<char> s, ReadOnlySpan<char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(formatParam));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00057264 File Offset: 0x00055464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1306986, XrefRangeEnd = 1306992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetDateTimeParseException(ref DateTimeResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0000489D File Offset: 0x00002A9D
		public DateTimeParse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x000572AC File Offset: 0x000554AC
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x000048A6 File Offset: 0x00002AA6
		public unsafe static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParse.NativeFieldInfoPtr_m_hebrewNumberParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeParse.MatchNumberDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParse.NativeFieldInfoPtr_m_hebrewNumberParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000572D4 File Offset: 0x000554D4
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x000048B8 File Offset: 0x00002AB8
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<DateTimeParse.DS>> dateParsingStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParse.NativeFieldInfoPtr_dateParsingStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<DateTimeParse.DS>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParse.NativeFieldInfoPtr_dateParsingStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr_m_hebrewNumberParser;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeFieldInfoPtr_dateParsingStates;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_TimeSpan_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_byref_TimeSpan_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_ParseExactMultiple_Internal_Static_DateTime_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_byref_TimeSpan_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_GetJapaneseCalendarDefaultInstance_Private_Static_Calendar_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_GetTaiwanCalendarDefaultInstance_Internal_Static_Calendar_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_TimeSpan_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_byref_TimeSpan_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_Boolean_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_ReadOnlySpan_1_Char_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_ParseJapaneseEraStart_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_ReadOnlySpan_1_Char_Int32_StringBuilder_byref_Int32_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0;

		// Token: 0x02000584 RID: 1412
		public sealed class MatchNumberDelegate : MulticastDelegate
		{
			// Token: 0x06005688 RID: 22152 RVA: 0x0001EC60 File Offset: 0x0001CE60
			// Note: this type is marked as 'beforefieldinit'.
			static MatchNumberDelegate()
			{
				Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "MatchNumberDelegate");
				DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr, 100665183);
				DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr, 100665184);
			}

			// Token: 0x06005689 RID: 22153 RVA: 0x0018F564 File Offset: 0x0018D764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305346, XrefRangeEnd = 1305350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatchNumberDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeParse.MatchNumberDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600568A RID: 22154 RVA: 0x0018F5C0 File Offset: 0x0018D7C0
			[CallerCount(0)]
			public unsafe bool Invoke(ref __DTString str, int digitLen, out int result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitLen;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.MatchNumberDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600568B RID: 22155 RVA: 0x0001EC9E File Offset: 0x0001CE9E
			public MatchNumberDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400469D RID: 18077
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400469E RID: 18078
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0;
		}

		// Token: 0x02000585 RID: 1413
		public enum DTT
		{
			// Token: 0x040046A0 RID: 18080
			End,
			// Token: 0x040046A1 RID: 18081
			NumEnd,
			// Token: 0x040046A2 RID: 18082
			NumAmpm,
			// Token: 0x040046A3 RID: 18083
			NumSpace,
			// Token: 0x040046A4 RID: 18084
			NumDatesep,
			// Token: 0x040046A5 RID: 18085
			NumTimesep,
			// Token: 0x040046A6 RID: 18086
			MonthEnd,
			// Token: 0x040046A7 RID: 18087
			MonthSpace,
			// Token: 0x040046A8 RID: 18088
			MonthDatesep,
			// Token: 0x040046A9 RID: 18089
			NumDatesuff,
			// Token: 0x040046AA RID: 18090
			NumTimesuff,
			// Token: 0x040046AB RID: 18091
			DayOfWeek,
			// Token: 0x040046AC RID: 18092
			YearSpace,
			// Token: 0x040046AD RID: 18093
			YearDateSep,
			// Token: 0x040046AE RID: 18094
			YearEnd,
			// Token: 0x040046AF RID: 18095
			TimeZone,
			// Token: 0x040046B0 RID: 18096
			Era,
			// Token: 0x040046B1 RID: 18097
			NumUTCTimeMark,
			// Token: 0x040046B2 RID: 18098
			Unk,
			// Token: 0x040046B3 RID: 18099
			NumLocalTimeMark,
			// Token: 0x040046B4 RID: 18100
			Max
		}

		// Token: 0x02000586 RID: 1414
		public enum TM
		{
			// Token: 0x040046B6 RID: 18102
			NotSet = -1,
			// Token: 0x040046B7 RID: 18103
			AM,
			// Token: 0x040046B8 RID: 18104
			PM
		}

		// Token: 0x02000587 RID: 1415
		public enum DS
		{
			// Token: 0x040046BA RID: 18106
			BEGIN,
			// Token: 0x040046BB RID: 18107
			N,
			// Token: 0x040046BC RID: 18108
			NN,
			// Token: 0x040046BD RID: 18109
			D_Nd,
			// Token: 0x040046BE RID: 18110
			D_NN,
			// Token: 0x040046BF RID: 18111
			D_NNd,
			// Token: 0x040046C0 RID: 18112
			D_M,
			// Token: 0x040046C1 RID: 18113
			D_MN,
			// Token: 0x040046C2 RID: 18114
			D_NM,
			// Token: 0x040046C3 RID: 18115
			D_MNd,
			// Token: 0x040046C4 RID: 18116
			D_NDS,
			// Token: 0x040046C5 RID: 18117
			D_Y,
			// Token: 0x040046C6 RID: 18118
			D_YN,
			// Token: 0x040046C7 RID: 18119
			D_YNd,
			// Token: 0x040046C8 RID: 18120
			D_YM,
			// Token: 0x040046C9 RID: 18121
			D_YMd,
			// Token: 0x040046CA RID: 18122
			D_S,
			// Token: 0x040046CB RID: 18123
			T_S,
			// Token: 0x040046CC RID: 18124
			T_Nt,
			// Token: 0x040046CD RID: 18125
			T_NNt,
			// Token: 0x040046CE RID: 18126
			ERROR,
			// Token: 0x040046CF RID: 18127
			DX_NN,
			// Token: 0x040046D0 RID: 18128
			DX_NNN,
			// Token: 0x040046D1 RID: 18129
			DX_MN,
			// Token: 0x040046D2 RID: 18130
			DX_NM,
			// Token: 0x040046D3 RID: 18131
			DX_MNN,
			// Token: 0x040046D4 RID: 18132
			DX_DS,
			// Token: 0x040046D5 RID: 18133
			DX_DSN,
			// Token: 0x040046D6 RID: 18134
			DX_NDS,
			// Token: 0x040046D7 RID: 18135
			DX_NNDS,
			// Token: 0x040046D8 RID: 18136
			DX_YNN,
			// Token: 0x040046D9 RID: 18137
			DX_YMN,
			// Token: 0x040046DA RID: 18138
			DX_YN,
			// Token: 0x040046DB RID: 18139
			DX_YM,
			// Token: 0x040046DC RID: 18140
			TX_N,
			// Token: 0x040046DD RID: 18141
			TX_NN,
			// Token: 0x040046DE RID: 18142
			TX_NNN,
			// Token: 0x040046DF RID: 18143
			TX_TS,
			// Token: 0x040046E0 RID: 18144
			DX_NNY
		}

		// Token: 0x02000588 RID: 1416
		[ObfuscatedName("System.DateTimeParse+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600568C RID: 22156 RVA: 0x0018F62C File Offset: 0x0018D82C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DateTimeParse.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeParse.__c>.NativeClassPtr);
				DateTimeParse.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParse.__c>.NativeClassPtr, "<>9");
				DateTimeParse.__c.NativeFieldInfoPtr___9__98_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParse.__c>.NativeClassPtr, "<>9__98_0");
				DateTimeParse.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse.__c>.NativeClassPtr, 100665186);
				DateTimeParse.__c.NativeMethodInfoPtr__DoStrictParse_b__98_0_Internal_MatchNumberDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse.__c>.NativeClassPtr, 100665187);
			}

			// Token: 0x0600568D RID: 22157 RVA: 0x0018F6A8 File Offset: 0x0018D8A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeParse.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600568E RID: 22158 RVA: 0x0018F6E4 File Offset: 0x0018D8E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1305350, XrefRangeEnd = 1305359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateTimeParse.MatchNumberDelegate _DoStrictParse_b__98_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParse.__c.NativeMethodInfoPtr__DoStrictParse_b__98_0_Internal_MatchNumberDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeParse.MatchNumberDelegate>(intPtr3) : null;
			}

			// Token: 0x0600568F RID: 22159 RVA: 0x0001ECA7 File Offset: 0x0001CEA7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001620 RID: 5664
			// (get) Token: 0x06005690 RID: 22160 RVA: 0x0018F724 File Offset: 0x0018D924
			// (set) Token: 0x06005691 RID: 22161 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
			public unsafe static DateTimeParse.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DateTimeParse.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeParse.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DateTimeParse.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001621 RID: 5665
			// (get) Token: 0x06005692 RID: 22162 RVA: 0x0018F74C File Offset: 0x0018D94C
			// (set) Token: 0x06005693 RID: 22163 RVA: 0x0001ECC2 File Offset: 0x0001CEC2
			public unsafe static Func<DateTimeParse.MatchNumberDelegate> __9__98_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DateTimeParse.__c.NativeFieldInfoPtr___9__98_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DateTimeParse.MatchNumberDelegate>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DateTimeParse.__c.NativeFieldInfoPtr___9__98_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040046E1 RID: 18145
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040046E2 RID: 18146
			private static readonly IntPtr NativeFieldInfoPtr___9__98_0;

			// Token: 0x040046E3 RID: 18147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040046E4 RID: 18148
			private static readonly IntPtr NativeMethodInfoPtr__DoStrictParse_b__98_0_Internal_MatchNumberDelegate_0;
		}
	}
}
