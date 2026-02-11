using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000470 RID: 1136
	[Serializable]
	public sealed class DateTimeFormatInfo : Object
	{
		// Token: 0x060043F0 RID: 17392 RVA: 0x0014098C File Offset: 0x0013EB8C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormatInfo()
		{
			Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "DateTimeFormatInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr);
			DateTimeFormatInfo.NativeFieldInfoPtr_s_invariantInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_invariantInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr__cultureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_cultureData");
			DateTimeFormatInfo.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_name");
			DateTimeFormatInfo.NativeFieldInfoPtr__langName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_langName");
			DateTimeFormatInfo.NativeFieldInfoPtr__compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_compareInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr__cultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_cultureInfo");
			DateTimeFormatInfo.NativeFieldInfoPtr_amDesignator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "amDesignator");
			DateTimeFormatInfo.NativeFieldInfoPtr_pmDesignator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "pmDesignator");
			DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_generalShortTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "generalShortTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_generalLongTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "generalLongTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_timeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "timeSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_monthDayPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "monthDayPattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_dateTimeOffsetPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateTimeOffsetPattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_rfc1123Pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "rfc1123Pattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_sortableDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "sortableDateTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_universalSortableDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "universalSortableDateTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "calendar");
			DateTimeFormatInfo.NativeFieldInfoPtr_firstDayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "firstDayOfWeek");
			DateTimeFormatInfo.NativeFieldInfoPtr_calendarWeekRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "calendarWeekRule");
			DateTimeFormatInfo.NativeFieldInfoPtr_fullDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "fullDateTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "abbreviatedDayNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_superShortDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_superShortDayNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_dayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dayNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "abbreviatedMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_monthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "monthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_genitiveMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "genitiveMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_genitiveAbbreviatedMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_leapYearMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "leapYearMonthNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_longDatePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "longDatePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_shortDatePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "shortDatePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_yearMonthPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "yearMonthPattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_longTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "longTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_shortTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "shortTimePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_allYearMonthPatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allYearMonthPatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allShortDatePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allShortDatePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allLongDatePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allLongDatePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allShortTimePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allShortTimePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_allLongTimePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allLongTimePatterns");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_eraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_eraNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_abbrevEraNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEnglishEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_abbrevEnglishEraNames");
			DateTimeFormatInfo.NativeFieldInfoPtr_optionalCalendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "optionalCalendars");
			DateTimeFormatInfo.NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "DEFAULT_ALL_DATETIMES_SIZE");
			DateTimeFormatInfo.NativeFieldInfoPtr__isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_isReadOnly");
			DateTimeFormatInfo.NativeFieldInfoPtr_formatFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "formatFlags");
			DateTimeFormatInfo.NativeFieldInfoPtr_s_monthSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_monthSpaces");
			DateTimeFormatInfo.NativeFieldInfoPtr_RoundtripFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "RoundtripFormat");
			DateTimeFormatInfo.NativeFieldInfoPtr_RoundtripDateTimeUnfixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "RoundtripDateTimeUnfixed");
			DateTimeFormatInfo.NativeFieldInfoPtr__fullTimeSpanPositivePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_fullTimeSpanPositivePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr__fullTimeSpanNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_fullTimeSpanNegativePattern");
			DateTimeFormatInfo.NativeFieldInfoPtr_InvalidDateTimeStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "InvalidDateTimeStyles");
			DateTimeFormatInfo.NativeFieldInfoPtr__dtfiTokenHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_dtfiTokenHash");
			DateTimeFormatInfo.NativeFieldInfoPtr_TOKEN_HASH_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "TOKEN_HASH_SIZE");
			DateTimeFormatInfo.NativeFieldInfoPtr_SECOND_PRIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "SECOND_PRIME");
			DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateSeparatorOrTimeZoneOffset");
			DateTimeFormatInfo.NativeFieldInfoPtr_invariantDateSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "invariantDateSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_invariantTimeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "invariantTimeSeparator");
			DateTimeFormatInfo.NativeFieldInfoPtr_IgnorablePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "IgnorablePeriod");
			DateTimeFormatInfo.NativeFieldInfoPtr_IgnorableComma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "IgnorableComma");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKYearSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKYearSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKMonthSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKMonthSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKDaySuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKDaySuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanYearSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanYearSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMonthSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanMonthSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanDaySuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanDaySuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanHourSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMinuteSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanMinuteSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanSecondSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanSecondSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKHourSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_ChineseHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "ChineseHourSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKMinuteSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKMinuteSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_CJKSecondSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKSecondSuff");
			DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseEraStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "JapaneseEraStart");
			DateTimeFormatInfo.NativeFieldInfoPtr_LocalTimeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "LocalTimeMark");
			DateTimeFormatInfo.NativeFieldInfoPtr_GMTName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "GMTName");
			DateTimeFormatInfo.NativeFieldInfoPtr_ZuluName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "ZuluName");
			DateTimeFormatInfo.NativeFieldInfoPtr_KoreanLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanLangName");
			DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "JapaneseLangName");
			DateTimeFormatInfo.NativeFieldInfoPtr_EnglishLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "EnglishLangName");
			DateTimeFormatInfo.NativeFieldInfoPtr_s_jajpDTFI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_jajpDTFI");
			DateTimeFormatInfo.NativeFieldInfoPtr_s_zhtwDTFI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_zhtwDTFI");
			DateTimeFormatInfo.NativeMethodInfoPtr_get_CultureName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673345);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673346);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_LanguageName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673347);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673348);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNamesCore_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673349);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673350);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetDayOfWeekNamesCore_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673351);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673352);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedMonthNamesCore_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673353);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673354);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthNamesCore_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673355);
			DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673356);
			DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673357);
			DateTimeFormatInfo.NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673358);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673359);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673360);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673361);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673362);
			DateTimeFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673363);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673364);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673365);
			DateTimeFormatInfo.NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673366);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_CalendarId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673367);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673368);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetEraName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673369);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673370);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673371);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673372);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673373);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673374);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673375);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673376);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673377);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673378);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673379);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673380);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673381);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673382);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673383);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673384);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673385);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673386);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673387);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673388);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673389);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673390);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673391);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673392);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673393);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673394);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673395);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673396);
			DateTimeFormatInfo.NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673397);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673398);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673399);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673400);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673401);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673402);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673403);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673404);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673405);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673406);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673407);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673408);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673409);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673410);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673411);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673412);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673413);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673414);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673415);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673416);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673417);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673418);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673419);
			DateTimeFormatInfo.NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673420);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673421);
			DateTimeFormatInfo.NativeMethodInfoPtr_InitializeFormatFlags_Private_DateTimeFormatFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673422);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673423);
			DateTimeFormatInfo.NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673424);
			DateTimeFormatInfo.NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673425);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673426);
			DateTimeFormatInfo.NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673427);
			DateTimeFormatInfo.NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673428);
			DateTimeFormatInfo.NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673429);
			DateTimeFormatInfo.NativeMethodInfoPtr_PopulateSpecialTokenHashTable_Private_Void_Il2CppReferenceArray_1_TokenHashValue_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673430);
			DateTimeFormatInfo.NativeMethodInfoPtr_IsJapaneseCalendar_Private_Static_Boolean_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673431);
			DateTimeFormatInfo.NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673432);
			DateTimeFormatInfo.NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673433);
			DateTimeFormatInfo.NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673434);
			DateTimeFormatInfo.NativeMethodInfoPtr_IsAllowedJapaneseTokenFollowedByNonSpaceLetter_Private_Boolean_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673435);
			DateTimeFormatInfo.NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673436);
			DateTimeFormatInfo.NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673437);
			DateTimeFormatInfo.NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673438);
			DateTimeFormatInfo.NativeMethodInfoPtr_CompareStringIgnoreCaseOptimized_Private_Boolean_String_Int32_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100673439);
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x00141790 File Offset: 0x0013F990
		public unsafe string CultureName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407219, XrefRangeEnd = 1407220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_CultureName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x060043F2 RID: 17394 RVA: 0x001417C8 File Offset: 0x0013F9C8
		public unsafe CultureInfo Culture
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1407226, RefRangeEnd = 1407230, XrefRangeStart = 1407220, XrefRangeEnd = 1407226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x00141808 File Offset: 0x0013FA08
		public unsafe string LanguageName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1407231, RefRangeEnd = 1407232, XrefRangeStart = 1407230, XrefRangeEnd = 1407231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_LanguageName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x00141840 File Offset: 0x0013FA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407232, XrefRangeEnd = 1407233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetAbbreviatedDayOfWeekNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x00141880 File Offset: 0x0013FA80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1407235, RefRangeEnd = 1407239, XrefRangeStart = 1407233, XrefRangeEnd = 1407235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetAbbreviatedDayOfWeekNamesCore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNamesCore_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x001418C0 File Offset: 0x0013FAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407239, XrefRangeEnd = 1407240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetDayOfWeekNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x00141900 File Offset: 0x0013FB00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1407242, RefRangeEnd = 1407246, XrefRangeStart = 1407240, XrefRangeEnd = 1407242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetDayOfWeekNamesCore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetDayOfWeekNamesCore_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x00141940 File Offset: 0x0013FB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407246, XrefRangeEnd = 1407247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetAbbreviatedMonthNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x00141980 File Offset: 0x0013FB80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1407249, RefRangeEnd = 1407253, XrefRangeStart = 1407247, XrefRangeEnd = 1407249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetAbbreviatedMonthNamesCore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetAbbreviatedMonthNamesCore_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x001419C0 File Offset: 0x0013FBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407253, XrefRangeEnd = 1407254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetMonthNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x00141A00 File Offset: 0x0013FC00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1407256, RefRangeEnd = 1407260, XrefRangeStart = 1407254, XrefRangeEnd = 1407256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetMonthNamesCore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthNamesCore_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x00141A40 File Offset: 0x0013FC40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1407287, RefRangeEnd = 1407289, XrefRangeStart = 1407260, XrefRangeEnd = 1407287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeFormatInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x00141A7C File Offset: 0x0013FC7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1407292, RefRangeEnd = 1407293, XrefRangeStart = 1407289, XrefRangeEnd = 1407292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeFormatInfo(CultureData cultureData, Calendar cal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00141ADC File Offset: 0x0013FCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407293, XrefRangeEnd = 1407309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeOverridableProperties(CultureData cultureData, int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x060043FF RID: 17407 RVA: 0x00141B2C File Offset: 0x0013FD2C
		public unsafe static DateTimeFormatInfo InvariantInfo
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1407327, RefRangeEnd = 1407344, XrefRangeStart = 1407309, XrefRangeEnd = 1407327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06004400 RID: 17408 RVA: 0x00141B60 File Offset: 0x0013FD60
		public unsafe static DateTimeFormatInfo CurrentInfo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1407352, RefRangeEnd = 1407354, XrefRangeStart = 1407344, XrefRangeEnd = 1407352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x00141B94 File Offset: 0x0013FD94
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1407370, RefRangeEnd = 1407385, XrefRangeStart = 1407354, XrefRangeEnd = 1407370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeFormatInfo GetInstance(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x00141BD8 File Offset: 0x0013FDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407385, XrefRangeEnd = 1407392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x00141C28 File Offset: 0x0013FE28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1407400, RefRangeEnd = 1407404, XrefRangeStart = 1407392, XrefRangeEnd = 1407400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06004404 RID: 17412 RVA: 0x00141C68 File Offset: 0x0013FE68
		public unsafe string AMDesignator
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1407405, RefRangeEnd = 1407420, XrefRangeStart = 1407404, XrefRangeEnd = 1407405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x00141CA0 File Offset: 0x0013FEA0
		// (set) Token: 0x06004406 RID: 17414 RVA: 0x00141CE0 File Offset: 0x0013FEE0
		public unsafe Calendar Calendar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1407477, RefRangeEnd = 1407484, XrefRangeStart = 1407420, XrefRangeEnd = 1407477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x00141D24 File Offset: 0x0013FF24
		public unsafe Il2CppStructArray<CalendarId> OptionalCalendars
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407484, XrefRangeEnd = 1407486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_CalendarId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CalendarId>>(intPtr3) : null;
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x00141D64 File Offset: 0x0013FF64
		public unsafe Il2CppStringArray EraNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407486, XrefRangeEnd = 1407488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x00141DA4 File Offset: 0x0013FFA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1407490, RefRangeEnd = 1407496, XrefRangeStart = 1407488, XrefRangeEnd = 1407490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEraName(int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetEraName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x0600440A RID: 17418 RVA: 0x00141DE8 File Offset: 0x0013FFE8
		public unsafe Il2CppStringArray AbbreviatedEraNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407496, XrefRangeEnd = 1407498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00141E28 File Offset: 0x00140028
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1407500, RefRangeEnd = 1407503, XrefRangeStart = 1407498, XrefRangeEnd = 1407500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAbbreviatedEraName(int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x0600440C RID: 17420 RVA: 0x00141E6C File Offset: 0x0014006C
		public unsafe Il2CppStringArray AbbreviatedEnglishEraNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407503, XrefRangeEnd = 1407505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x00141EAC File Offset: 0x001400AC
		public unsafe string DateSeparator
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1407507, RefRangeEnd = 1407511, XrefRangeStart = 1407505, XrefRangeEnd = 1407507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x0600440E RID: 17422 RVA: 0x00141EE4 File Offset: 0x001400E4
		public unsafe string FullDateTimePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407511, XrefRangeEnd = 1407518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x0600440F RID: 17423 RVA: 0x00141F1C File Offset: 0x0014011C
		public unsafe string LongDatePattern
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1407520, RefRangeEnd = 1407521, XrefRangeStart = 1407518, XrefRangeEnd = 1407520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06004410 RID: 17424 RVA: 0x00141F54 File Offset: 0x00140154
		public unsafe string LongTimePattern
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1407524, RefRangeEnd = 1407529, XrefRangeStart = 1407521, XrefRangeEnd = 1407524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x00141F8C File Offset: 0x0014018C
		public unsafe string MonthDayPattern
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1407531, RefRangeEnd = 1407541, XrefRangeStart = 1407529, XrefRangeEnd = 1407531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06004412 RID: 17426 RVA: 0x00141FC4 File Offset: 0x001401C4
		public unsafe string PMDesignator
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1407542, RefRangeEnd = 1407556, XrefRangeStart = 1407541, XrefRangeEnd = 1407542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x00141FFC File Offset: 0x001401FC
		public unsafe string RFC1123Pattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407556, XrefRangeEnd = 1407558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06004414 RID: 17428 RVA: 0x00142034 File Offset: 0x00140234
		public unsafe string ShortDatePattern
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1407560, RefRangeEnd = 1407574, XrefRangeStart = 1407558, XrefRangeEnd = 1407560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x0014206C File Offset: 0x0014026C
		public unsafe string ShortTimePattern
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1407577, RefRangeEnd = 1407583, XrefRangeStart = 1407574, XrefRangeEnd = 1407577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06004416 RID: 17430 RVA: 0x001420A4 File Offset: 0x001402A4
		public unsafe string SortableDateTimePattern
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1407585, RefRangeEnd = 1407588, XrefRangeStart = 1407583, XrefRangeEnd = 1407585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06004417 RID: 17431 RVA: 0x001420DC File Offset: 0x001402DC
		public unsafe string GeneralShortTimePattern
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1407595, RefRangeEnd = 1407596, XrefRangeStart = 1407588, XrefRangeEnd = 1407595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06004418 RID: 17432 RVA: 0x00142114 File Offset: 0x00140314
		public unsafe string GeneralLongTimePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407596, XrefRangeEnd = 1407603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x0014214C File Offset: 0x0014034C
		public unsafe string DateTimeOffsetPattern
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1407624, RefRangeEnd = 1407625, XrefRangeStart = 1407603, XrefRangeEnd = 1407624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x0600441A RID: 17434 RVA: 0x00142184 File Offset: 0x00140384
		public unsafe string TimeSeparator
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1407626, RefRangeEnd = 1407629, XrefRangeStart = 1407625, XrefRangeEnd = 1407626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x001421BC File Offset: 0x001403BC
		public unsafe string UniversalSortableDateTimePattern
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1407631, RefRangeEnd = 1407632, XrefRangeStart = 1407629, XrefRangeEnd = 1407631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x0600441C RID: 17436 RVA: 0x001421F4 File Offset: 0x001403F4
		public unsafe string YearMonthPattern
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1407634, RefRangeEnd = 1407639, XrefRangeStart = 1407632, XrefRangeEnd = 1407634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x0014222C File Offset: 0x0014042C
		public unsafe Il2CppStringArray AbbreviatedDayNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407639, XrefRangeEnd = 1407643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x0600441E RID: 17438 RVA: 0x0014226C File Offset: 0x0014046C
		public unsafe Il2CppStringArray DayNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407643, XrefRangeEnd = 1407647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x001422AC File Offset: 0x001404AC
		public unsafe Il2CppStringArray AbbreviatedMonthNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1407651, RefRangeEnd = 1407653, XrefRangeStart = 1407647, XrefRangeEnd = 1407651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06004420 RID: 17440 RVA: 0x001422EC File Offset: 0x001404EC
		public unsafe Il2CppStringArray MonthNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1407657, RefRangeEnd = 1407659, XrefRangeStart = 1407653, XrefRangeEnd = 1407657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06004421 RID: 17441 RVA: 0x0014232C File Offset: 0x0014052C
		public unsafe bool HasSpacesInMonthNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1407659, RefRangeEnd = 1407661, XrefRangeStart = 1407659, XrefRangeEnd = 1407659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06004422 RID: 17442 RVA: 0x00142368 File Offset: 0x00140568
		public unsafe bool HasSpacesInDayNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1407661, RefRangeEnd = 1407663, XrefRangeStart = 1407661, XrefRangeEnd = 1407661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x001423A4 File Offset: 0x001405A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1407671, RefRangeEnd = 1407674, XrefRangeStart = 1407663, XrefRangeEnd = 1407671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref abbreviated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x00142404 File Offset: 0x00140604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1407676, RefRangeEnd = 1407677, XrefRangeStart = 1407674, XrefRangeEnd = 1407676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetGenitiveMonthNames(bool abbreviated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref abbreviated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x00142450 File Offset: 0x00140650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1407679, RefRangeEnd = 1407681, XrefRangeStart = 1407677, XrefRangeEnd = 1407679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray internalGetLeapYearMonthNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x00142490 File Offset: 0x00140690
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1407682, RefRangeEnd = 1407688, XrefRangeStart = 1407681, XrefRangeEnd = 1407682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAbbreviatedDayName(DayOfWeek dayofweek)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dayofweek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x001424D4 File Offset: 0x001406D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407688, XrefRangeEnd = 1407695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetCombinedPatterns(Il2CppStringArray patterns1, Il2CppStringArray patterns2, string connectString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patterns1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(patterns2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(connectString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x0014253C File Offset: 0x0014073C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407712, RefRangeEnd = 1407717, XrefRangeStart = 1407695, XrefRangeEnd = 1407712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAllDateTimePatterns(char format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x00142588 File Offset: 0x00140788
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407718, RefRangeEnd = 1407723, XrefRangeStart = 1407717, XrefRangeEnd = 1407718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDayName(DayOfWeek dayofweek)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dayofweek;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x001425CC File Offset: 0x001407CC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1407724, RefRangeEnd = 1407732, XrefRangeStart = 1407723, XrefRangeEnd = 1407724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAbbreviatedMonthName(int month)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x00142610 File Offset: 0x00140810
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1407733, RefRangeEnd = 1407743, XrefRangeStart = 1407732, XrefRangeEnd = 1407733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMonthName(int month)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref month;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00142654 File Offset: 0x00140854
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407756, RefRangeEnd = 1407761, XrefRangeStart = 1407743, XrefRangeEnd = 1407756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetMergedPatterns(Il2CppStringArray patterns, string defaultPattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patterns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultPattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x0600442D RID: 17453 RVA: 0x001426AC File Offset: 0x001408AC
		public unsafe Il2CppStringArray AllYearMonthPatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407761, XrefRangeEnd = 1407770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x001426EC File Offset: 0x001408EC
		public unsafe Il2CppStringArray AllShortDatePatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407770, XrefRangeEnd = 1407779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x0600442F RID: 17455 RVA: 0x0014272C File Offset: 0x0014092C
		public unsafe Il2CppStringArray AllShortTimePatterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1407787, RefRangeEnd = 1407788, XrefRangeStart = 1407779, XrefRangeEnd = 1407787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x0014276C File Offset: 0x0014096C
		public unsafe Il2CppStringArray AllLongDatePatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407788, XrefRangeEnd = 1407797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06004431 RID: 17457 RVA: 0x001427AC File Offset: 0x001409AC
		public unsafe Il2CppStringArray AllLongTimePatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407797, XrefRangeEnd = 1407805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x001427EC File Offset: 0x001409EC
		public unsafe Il2CppStringArray UnclonedYearMonthPatterns
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1407807, RefRangeEnd = 1407810, XrefRangeStart = 1407805, XrefRangeEnd = 1407807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06004433 RID: 17459 RVA: 0x0014282C File Offset: 0x00140A2C
		public unsafe Il2CppStringArray UnclonedShortDatePatterns
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1407812, RefRangeEnd = 1407818, XrefRangeStart = 1407810, XrefRangeEnd = 1407812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06004434 RID: 17460 RVA: 0x0014286C File Offset: 0x00140A6C
		public unsafe Il2CppStringArray UnclonedLongDatePatterns
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1407820, RefRangeEnd = 1407824, XrefRangeStart = 1407818, XrefRangeEnd = 1407820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06004435 RID: 17461 RVA: 0x001428AC File Offset: 0x00140AAC
		public unsafe Il2CppStringArray UnclonedShortTimePatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407824, XrefRangeEnd = 1407826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06004436 RID: 17462 RVA: 0x001428EC File Offset: 0x00140AEC
		public unsafe Il2CppStringArray UnclonedLongTimePatterns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407826, XrefRangeEnd = 1407828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x0014292C File Offset: 0x00140B2C
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407828, XrefRangeEnd = 1407835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x00142968 File Offset: 0x00140B68
		public unsafe Il2CppStringArray MonthGenitiveNames
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1407840, RefRangeEnd = 1407841, XrefRangeStart = 1407835, XrefRangeEnd = 1407840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x001429A8 File Offset: 0x00140BA8
		public unsafe string FullTimeSpanPositivePattern
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1407852, RefRangeEnd = 1407855, XrefRangeStart = 1407841, XrefRangeEnd = 1407852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600443A RID: 17466 RVA: 0x001429E0 File Offset: 0x00140BE0
		public unsafe string FullTimeSpanNegativePattern
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1407860, RefRangeEnd = 1407862, XrefRangeStart = 1407855, XrefRangeEnd = 1407860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x00142A18 File Offset: 0x00140C18
		public unsafe CompareInfo CompareInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1407871, RefRangeEnd = 1407872, XrefRangeStart = 1407862, XrefRangeEnd = 1407871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x00142A58 File Offset: 0x00140C58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407872, RefRangeEnd = 1407877, XrefRangeStart = 1407872, XrefRangeEnd = 1407872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateStyles(DateTimeStyles style, string parameterName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x00142A9C File Offset: 0x00140C9C
		public unsafe DateTimeFormatFlags FormatFlags
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1407877, RefRangeEnd = 1407884, XrefRangeStart = 1407877, XrefRangeEnd = 1407877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x00142AD8 File Offset: 0x00140CD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1407923, RefRangeEnd = 1407927, XrefRangeStart = 1407884, XrefRangeEnd = 1407923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeFormatFlags InitializeFormatFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InitializeFormatFlags_Private_DateTimeFormatFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x00142B14 File Offset: 0x00140D14
		public unsafe bool HasForceTwoDigitYears
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1407927, RefRangeEnd = 1407929, XrefRangeStart = 1407927, XrefRangeEnd = 1407927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x00142B50 File Offset: 0x00140D50
		public unsafe bool HasYearMonthAdjustment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00142B8C File Offset: 0x00140D8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407931, RefRangeEnd = 1407936, XrefRangeStart = 1407929, XrefRangeEnd = 1407931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parsedMonthName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x00142BF4 File Offset: 0x00140DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407936, XrefRangeEnd = 1407965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeFormatInfo GetJapaneseCalendarDTFI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x00142C28 File Offset: 0x00140E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407965, XrefRangeEnd = 1407994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeFormatInfo GetTaiwanCalendarDTFI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x00142C5C File Offset: 0x00140E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407994, XrefRangeEnd = 1407995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTokenHashTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x00142C90 File Offset: 0x00140E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407995, XrefRangeEnd = 1408132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DateTimeFormatInfo.TokenHashValue> CreateTokenHashTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DateTimeFormatInfo.TokenHashValue>>(intPtr3) : null;
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00142CD0 File Offset: 0x00140ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1408342, RefRangeEnd = 1408343, XrefRangeStart = 1408132, XrefRangeEnd = 1408342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateSpecialTokenHashTable(Il2CppReferenceArray<DateTimeFormatInfo.TokenHashValue> temp, ref bool useDateSepAsIgnorableSymbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(temp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &useDateSepAsIgnorableSymbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_PopulateSpecialTokenHashTable_Private_Void_Il2CppReferenceArray_1_TokenHashValue_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00142D20 File Offset: 0x00140F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408343, XrefRangeEnd = 1408364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsJapaneseCalendar(Calendar calendar)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calendar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_IsJapaneseCalendar_Private_Static_Boolean_Calendar_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x00142D64 File Offset: 0x00140F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408364, XrefRangeEnd = 1408369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMonthNames(Il2CppReferenceArray<DateTimeFormatInfo.TokenHashValue> temp, string monthPostfix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(temp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(monthPostfix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00142DB8 File Offset: 0x00140FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1408389, RefRangeEnd = 1408390, XrefRangeStart = 1408369, XrefRangeEnd = 1408389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &badFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x00142E18 File Offset: 0x00141018
		[CallerCount(0)]
		public unsafe static bool IsHebrewChar(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x00142E58 File Offset: 0x00141058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408390, XrefRangeEnd = 1408400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextCh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_IsAllowedJapaneseTokenFollowedByNonSpaceLetter_Private_Boolean_String_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x00142EB4 File Offset: 0x001410B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1408420, RefRangeEnd = 1408422, XrefRangeStart = 1408400, XrefRangeEnd = 1408420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref TokenMask;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tokenType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tokenValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x00142F30 File Offset: 0x00141130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408422, XrefRangeEnd = 1408433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertAtCurrentHashNode(Il2CppReferenceArray<DateTimeFormatInfo.TokenHashValue> hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashProbe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x00142FD8 File Offset: 0x001411D8
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 1408450, RefRangeEnd = 1408508, XrefRangeStart = 1408433, XrefRangeEnd = 1408450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertHash(Il2CppReferenceArray<DateTimeFormatInfo.TokenHashValue> hashTable, string str, TokenType tokenType, int tokenValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00143048 File Offset: 0x00141248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408508, XrefRangeEnd = 1408510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.NativeMethodInfoPtr_CompareStringIgnoreCaseOptimized_Private_Boolean_String_Int32_Int32_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x000188A8 File Offset: 0x00016AA8
		public DateTimeFormatInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06004451 RID: 17489 RVA: 0x001430E0 File Offset: 0x001412E0
		// (set) Token: 0x06004452 RID: 17490 RVA: 0x000188B1 File Offset: 0x00016AB1
		public unsafe static DateTimeFormatInfo s_invariantInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_invariantInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_invariantInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06004453 RID: 17491 RVA: 0x00143108 File Offset: 0x00141308
		// (set) Token: 0x06004454 RID: 17492 RVA: 0x000188C3 File Offset: 0x00016AC3
		public unsafe CultureData _cultureData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__cultureData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__cultureData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06004455 RID: 17493 RVA: 0x00143138 File Offset: 0x00141338
		// (set) Token: 0x06004456 RID: 17494 RVA: 0x000188E2 File Offset: 0x00016AE2
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06004457 RID: 17495 RVA: 0x00143160 File Offset: 0x00141360
		// (set) Token: 0x06004458 RID: 17496 RVA: 0x00018901 File Offset: 0x00016B01
		public unsafe string _langName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__langName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__langName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06004459 RID: 17497 RVA: 0x00143188 File Offset: 0x00141388
		// (set) Token: 0x0600445A RID: 17498 RVA: 0x00018920 File Offset: 0x00016B20
		public unsafe CompareInfo _compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x0600445B RID: 17499 RVA: 0x001431B8 File Offset: 0x001413B8
		// (set) Token: 0x0600445C RID: 17500 RVA: 0x0001893F File Offset: 0x00016B3F
		public unsafe CultureInfo _cultureInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__cultureInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__cultureInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x001431E8 File Offset: 0x001413E8
		// (set) Token: 0x0600445E RID: 17502 RVA: 0x0001895E File Offset: 0x00016B5E
		public unsafe string amDesignator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_amDesignator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_amDesignator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x00143210 File Offset: 0x00141410
		// (set) Token: 0x06004460 RID: 17504 RVA: 0x0001897D File Offset: 0x00016B7D
		public unsafe string pmDesignator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_pmDesignator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_pmDesignator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06004461 RID: 17505 RVA: 0x00143238 File Offset: 0x00141438
		// (set) Token: 0x06004462 RID: 17506 RVA: 0x0001899C File Offset: 0x00016B9C
		public unsafe string dateSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x00143260 File Offset: 0x00141460
		// (set) Token: 0x06004464 RID: 17508 RVA: 0x000189BB File Offset: 0x00016BBB
		public unsafe string generalShortTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalShortTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalShortTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06004465 RID: 17509 RVA: 0x00143288 File Offset: 0x00141488
		// (set) Token: 0x06004466 RID: 17510 RVA: 0x000189DA File Offset: 0x00016BDA
		public unsafe string generalLongTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalLongTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_generalLongTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x001432B0 File Offset: 0x001414B0
		// (set) Token: 0x06004468 RID: 17512 RVA: 0x000189F9 File Offset: 0x00016BF9
		public unsafe string timeSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_timeSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_timeSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x001432D8 File Offset: 0x001414D8
		// (set) Token: 0x0600446A RID: 17514 RVA: 0x00018A18 File Offset: 0x00016C18
		public unsafe string monthDayPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthDayPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthDayPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x00143300 File Offset: 0x00141500
		// (set) Token: 0x0600446C RID: 17516 RVA: 0x00018A37 File Offset: 0x00016C37
		public unsafe string dateTimeOffsetPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateTimeOffsetPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dateTimeOffsetPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x00143328 File Offset: 0x00141528
		// (set) Token: 0x0600446E RID: 17518 RVA: 0x00018A56 File Offset: 0x00016C56
		public unsafe static string rfc1123Pattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_rfc1123Pattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_rfc1123Pattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x00143348 File Offset: 0x00141548
		// (set) Token: 0x06004470 RID: 17520 RVA: 0x00018A68 File Offset: 0x00016C68
		public unsafe static string sortableDateTimePattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_sortableDateTimePattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_sortableDateTimePattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06004471 RID: 17521 RVA: 0x00143368 File Offset: 0x00141568
		// (set) Token: 0x06004472 RID: 17522 RVA: 0x00018A7A File Offset: 0x00016C7A
		public unsafe static string universalSortableDateTimePattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_universalSortableDateTimePattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_universalSortableDateTimePattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06004473 RID: 17523 RVA: 0x00143388 File Offset: 0x00141588
		// (set) Token: 0x06004474 RID: 17524 RVA: 0x00018A8C File Offset: 0x00016C8C
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06004475 RID: 17525 RVA: 0x001433B8 File Offset: 0x001415B8
		// (set) Token: 0x06004476 RID: 17526 RVA: 0x00018AAB File Offset: 0x00016CAB
		public unsafe int firstDayOfWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_firstDayOfWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_firstDayOfWeek)) = value;
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x001433E0 File Offset: 0x001415E0
		// (set) Token: 0x06004478 RID: 17528 RVA: 0x00018AC6 File Offset: 0x00016CC6
		public unsafe int calendarWeekRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendarWeekRule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_calendarWeekRule)) = value;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06004479 RID: 17529 RVA: 0x00143408 File Offset: 0x00141608
		// (set) Token: 0x0600447A RID: 17530 RVA: 0x00018AE1 File Offset: 0x00016CE1
		public unsafe string fullDateTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_fullDateTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_fullDateTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x00143430 File Offset: 0x00141630
		// (set) Token: 0x0600447C RID: 17532 RVA: 0x00018B00 File Offset: 0x00016D00
		public unsafe Il2CppStringArray abbreviatedDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x00143460 File Offset: 0x00141660
		// (set) Token: 0x0600447E RID: 17534 RVA: 0x00018B1F File Offset: 0x00016D1F
		public unsafe Il2CppStringArray m_superShortDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_superShortDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_superShortDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x00143490 File Offset: 0x00141690
		// (set) Token: 0x06004480 RID: 17536 RVA: 0x00018B3E File Offset: 0x00016D3E
		public unsafe Il2CppStringArray dayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_dayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06004481 RID: 17537 RVA: 0x001434C0 File Offset: 0x001416C0
		// (set) Token: 0x06004482 RID: 17538 RVA: 0x00018B5D File Offset: 0x00016D5D
		public unsafe Il2CppStringArray abbreviatedMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_abbreviatedMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06004483 RID: 17539 RVA: 0x001434F0 File Offset: 0x001416F0
		// (set) Token: 0x06004484 RID: 17540 RVA: 0x00018B7C File Offset: 0x00016D7C
		public unsafe Il2CppStringArray monthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_monthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06004485 RID: 17541 RVA: 0x00143520 File Offset: 0x00141720
		// (set) Token: 0x06004486 RID: 17542 RVA: 0x00018B9B File Offset: 0x00016D9B
		public unsafe Il2CppStringArray genitiveMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_genitiveMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_genitiveMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x00143550 File Offset: 0x00141750
		// (set) Token: 0x06004488 RID: 17544 RVA: 0x00018BBA File Offset: 0x00016DBA
		public unsafe Il2CppStringArray m_genitiveAbbreviatedMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x00143580 File Offset: 0x00141780
		// (set) Token: 0x0600448A RID: 17546 RVA: 0x00018BD9 File Offset: 0x00016DD9
		public unsafe Il2CppStringArray leapYearMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_leapYearMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_leapYearMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x001435B0 File Offset: 0x001417B0
		// (set) Token: 0x0600448C RID: 17548 RVA: 0x00018BF8 File Offset: 0x00016DF8
		public unsafe string longDatePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longDatePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longDatePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x001435D8 File Offset: 0x001417D8
		// (set) Token: 0x0600448E RID: 17550 RVA: 0x00018C17 File Offset: 0x00016E17
		public unsafe string shortDatePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortDatePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortDatePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x00143600 File Offset: 0x00141800
		// (set) Token: 0x06004490 RID: 17552 RVA: 0x00018C36 File Offset: 0x00016E36
		public unsafe string yearMonthPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_yearMonthPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_yearMonthPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x00143628 File Offset: 0x00141828
		// (set) Token: 0x06004492 RID: 17554 RVA: 0x00018C55 File Offset: 0x00016E55
		public unsafe string longTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_longTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x00143650 File Offset: 0x00141850
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x00018C74 File Offset: 0x00016E74
		public unsafe string shortTimePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortTimePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_shortTimePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x00143678 File Offset: 0x00141878
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x00018C93 File Offset: 0x00016E93
		public unsafe Il2CppStringArray allYearMonthPatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allYearMonthPatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allYearMonthPatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x001436A8 File Offset: 0x001418A8
		// (set) Token: 0x06004498 RID: 17560 RVA: 0x00018CB2 File Offset: 0x00016EB2
		public unsafe Il2CppStringArray allShortDatePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortDatePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortDatePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06004499 RID: 17561 RVA: 0x001436D8 File Offset: 0x001418D8
		// (set) Token: 0x0600449A RID: 17562 RVA: 0x00018CD1 File Offset: 0x00016ED1
		public unsafe Il2CppStringArray allLongDatePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongDatePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongDatePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x00143708 File Offset: 0x00141908
		// (set) Token: 0x0600449C RID: 17564 RVA: 0x00018CF0 File Offset: 0x00016EF0
		public unsafe Il2CppStringArray allShortTimePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortTimePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allShortTimePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x0600449D RID: 17565 RVA: 0x00143738 File Offset: 0x00141938
		// (set) Token: 0x0600449E RID: 17566 RVA: 0x00018D0F File Offset: 0x00016F0F
		public unsafe Il2CppStringArray allLongTimePatterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongTimePatterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_allLongTimePatterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x0600449F RID: 17567 RVA: 0x00143768 File Offset: 0x00141968
		// (set) Token: 0x060044A0 RID: 17568 RVA: 0x00018D2E File Offset: 0x00016F2E
		public unsafe Il2CppStringArray m_eraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_eraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_eraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x00143798 File Offset: 0x00141998
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x00018D4D File Offset: 0x00016F4D
		public unsafe Il2CppStringArray m_abbrevEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x001437C8 File Offset: 0x001419C8
		// (set) Token: 0x060044A4 RID: 17572 RVA: 0x00018D6C File Offset: 0x00016F6C
		public unsafe Il2CppStringArray m_abbrevEnglishEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEnglishEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_m_abbrevEnglishEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x001437F8 File Offset: 0x001419F8
		// (set) Token: 0x060044A6 RID: 17574 RVA: 0x00018D8B File Offset: 0x00016F8B
		public unsafe Il2CppStructArray<CalendarId> optionalCalendars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_optionalCalendars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CalendarId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_optionalCalendars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x00143828 File Offset: 0x00141A28
		// (set) Token: 0x060044A8 RID: 17576 RVA: 0x00018DAA File Offset: 0x00016FAA
		public unsafe static int DEFAULT_ALL_DATETIMES_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE, (void*)(&value));
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x060044A9 RID: 17577 RVA: 0x00143844 File Offset: 0x00141A44
		// (set) Token: 0x060044AA RID: 17578 RVA: 0x00018DB8 File Offset: 0x00016FB8
		public unsafe bool _isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__isReadOnly)) = value;
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x060044AB RID: 17579 RVA: 0x0014386C File Offset: 0x00141A6C
		// (set) Token: 0x060044AC RID: 17580 RVA: 0x00018DD3 File Offset: 0x00016FD3
		public unsafe DateTimeFormatFlags formatFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_formatFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr_formatFlags)) = value;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x060044AD RID: 17581 RVA: 0x00143894 File Offset: 0x00141A94
		// (set) Token: 0x060044AE RID: 17582 RVA: 0x00018DEE File Offset: 0x00016FEE
		public unsafe static Il2CppStructArray<char> s_monthSpaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_monthSpaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_monthSpaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x060044AF RID: 17583 RVA: 0x001438BC File Offset: 0x00141ABC
		// (set) Token: 0x060044B0 RID: 17584 RVA: 0x00018E00 File Offset: 0x00017000
		public unsafe static string RoundtripFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_RoundtripFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_RoundtripFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x060044B1 RID: 17585 RVA: 0x001438DC File Offset: 0x00141ADC
		// (set) Token: 0x060044B2 RID: 17586 RVA: 0x00018E12 File Offset: 0x00017012
		public unsafe static string RoundtripDateTimeUnfixed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_RoundtripDateTimeUnfixed, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_RoundtripDateTimeUnfixed, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x060044B3 RID: 17587 RVA: 0x001438FC File Offset: 0x00141AFC
		// (set) Token: 0x060044B4 RID: 17588 RVA: 0x00018E24 File Offset: 0x00017024
		public unsafe string _fullTimeSpanPositivePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__fullTimeSpanPositivePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__fullTimeSpanPositivePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x00143924 File Offset: 0x00141B24
		// (set) Token: 0x060044B6 RID: 17590 RVA: 0x00018E43 File Offset: 0x00017043
		public unsafe string _fullTimeSpanNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__fullTimeSpanNegativePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__fullTimeSpanNegativePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x060044B7 RID: 17591 RVA: 0x0014394C File Offset: 0x00141B4C
		// (set) Token: 0x060044B8 RID: 17592 RVA: 0x00018E62 File Offset: 0x00017062
		public unsafe static DateTimeStyles InvalidDateTimeStyles
		{
			get
			{
				DateTimeStyles dateTimeStyles;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_InvalidDateTimeStyles, (void*)(&dateTimeStyles));
				return dateTimeStyles;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_InvalidDateTimeStyles, (void*)(&value));
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x060044B9 RID: 17593 RVA: 0x00143968 File Offset: 0x00141B68
		// (set) Token: 0x060044BA RID: 17594 RVA: 0x00018E70 File Offset: 0x00017070
		public unsafe Il2CppReferenceArray<DateTimeFormatInfo.TokenHashValue> _dtfiTokenHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__dtfiTokenHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DateTimeFormatInfo.TokenHashValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.NativeFieldInfoPtr__dtfiTokenHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x060044BB RID: 17595 RVA: 0x00143998 File Offset: 0x00141B98
		// (set) Token: 0x060044BC RID: 17596 RVA: 0x00018E8F File Offset: 0x0001708F
		public unsafe static int TOKEN_HASH_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_TOKEN_HASH_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_TOKEN_HASH_SIZE, (void*)(&value));
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x060044BD RID: 17597 RVA: 0x001439B4 File Offset: 0x00141BB4
		// (set) Token: 0x060044BE RID: 17598 RVA: 0x00018E9D File Offset: 0x0001709D
		public unsafe static int SECOND_PRIME
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_SECOND_PRIME, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_SECOND_PRIME, (void*)(&value));
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x060044BF RID: 17599 RVA: 0x001439D0 File Offset: 0x00141BD0
		// (set) Token: 0x060044C0 RID: 17600 RVA: 0x00018EAB File Offset: 0x000170AB
		public unsafe static string dateSeparatorOrTimeZoneOffset
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x060044C1 RID: 17601 RVA: 0x001439F0 File Offset: 0x00141BF0
		// (set) Token: 0x060044C2 RID: 17602 RVA: 0x00018EBD File Offset: 0x000170BD
		public unsafe static string invariantDateSeparator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantDateSeparator, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantDateSeparator, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x060044C3 RID: 17603 RVA: 0x00143A10 File Offset: 0x00141C10
		// (set) Token: 0x060044C4 RID: 17604 RVA: 0x00018ECF File Offset: 0x000170CF
		public unsafe static string invariantTimeSeparator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantTimeSeparator, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_invariantTimeSeparator, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x060044C5 RID: 17605 RVA: 0x00143A30 File Offset: 0x00141C30
		// (set) Token: 0x060044C6 RID: 17606 RVA: 0x00018EE1 File Offset: 0x000170E1
		public unsafe static string IgnorablePeriod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorablePeriod, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorablePeriod, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x060044C7 RID: 17607 RVA: 0x00143A50 File Offset: 0x00141C50
		// (set) Token: 0x060044C8 RID: 17608 RVA: 0x00018EF3 File Offset: 0x000170F3
		public unsafe static string IgnorableComma
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorableComma, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_IgnorableComma, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x060044C9 RID: 17609 RVA: 0x00143A70 File Offset: 0x00141C70
		// (set) Token: 0x060044CA RID: 17610 RVA: 0x00018F05 File Offset: 0x00017105
		public unsafe static string CJKYearSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKYearSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKYearSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x060044CB RID: 17611 RVA: 0x00143A90 File Offset: 0x00141C90
		// (set) Token: 0x060044CC RID: 17612 RVA: 0x00018F17 File Offset: 0x00017117
		public unsafe static string CJKMonthSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMonthSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMonthSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x060044CD RID: 17613 RVA: 0x00143AB0 File Offset: 0x00141CB0
		// (set) Token: 0x060044CE RID: 17614 RVA: 0x00018F29 File Offset: 0x00017129
		public unsafe static string CJKDaySuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKDaySuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKDaySuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x060044CF RID: 17615 RVA: 0x00143AD0 File Offset: 0x00141CD0
		// (set) Token: 0x060044D0 RID: 17616 RVA: 0x00018F3B File Offset: 0x0001713B
		public unsafe static string KoreanYearSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanYearSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanYearSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x060044D1 RID: 17617 RVA: 0x00143AF0 File Offset: 0x00141CF0
		// (set) Token: 0x060044D2 RID: 17618 RVA: 0x00018F4D File Offset: 0x0001714D
		public unsafe static string KoreanMonthSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMonthSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMonthSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x060044D3 RID: 17619 RVA: 0x00143B10 File Offset: 0x00141D10
		// (set) Token: 0x060044D4 RID: 17620 RVA: 0x00018F5F File Offset: 0x0001715F
		public unsafe static string KoreanDaySuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanDaySuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanDaySuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x060044D5 RID: 17621 RVA: 0x00143B30 File Offset: 0x00141D30
		// (set) Token: 0x060044D6 RID: 17622 RVA: 0x00018F71 File Offset: 0x00017171
		public unsafe static string KoreanHourSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanHourSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanHourSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x060044D7 RID: 17623 RVA: 0x00143B50 File Offset: 0x00141D50
		// (set) Token: 0x060044D8 RID: 17624 RVA: 0x00018F83 File Offset: 0x00017183
		public unsafe static string KoreanMinuteSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMinuteSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanMinuteSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x060044D9 RID: 17625 RVA: 0x00143B70 File Offset: 0x00141D70
		// (set) Token: 0x060044DA RID: 17626 RVA: 0x00018F95 File Offset: 0x00017195
		public unsafe static string KoreanSecondSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanSecondSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanSecondSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x060044DB RID: 17627 RVA: 0x00143B90 File Offset: 0x00141D90
		// (set) Token: 0x060044DC RID: 17628 RVA: 0x00018FA7 File Offset: 0x000171A7
		public unsafe static string CJKHourSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKHourSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKHourSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x060044DD RID: 17629 RVA: 0x00143BB0 File Offset: 0x00141DB0
		// (set) Token: 0x060044DE RID: 17630 RVA: 0x00018FB9 File Offset: 0x000171B9
		public unsafe static string ChineseHourSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_ChineseHourSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_ChineseHourSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x060044DF RID: 17631 RVA: 0x00143BD0 File Offset: 0x00141DD0
		// (set) Token: 0x060044E0 RID: 17632 RVA: 0x00018FCB File Offset: 0x000171CB
		public unsafe static string CJKMinuteSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMinuteSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKMinuteSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x060044E1 RID: 17633 RVA: 0x00143BF0 File Offset: 0x00141DF0
		// (set) Token: 0x060044E2 RID: 17634 RVA: 0x00018FDD File Offset: 0x000171DD
		public unsafe static string CJKSecondSuff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKSecondSuff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_CJKSecondSuff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x00143C10 File Offset: 0x00141E10
		// (set) Token: 0x060044E4 RID: 17636 RVA: 0x00018FEF File Offset: 0x000171EF
		public unsafe static string JapaneseEraStart
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseEraStart, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseEraStart, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x00143C30 File Offset: 0x00141E30
		// (set) Token: 0x060044E6 RID: 17638 RVA: 0x00019001 File Offset: 0x00017201
		public unsafe static string LocalTimeMark
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_LocalTimeMark, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_LocalTimeMark, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x00143C50 File Offset: 0x00141E50
		// (set) Token: 0x060044E8 RID: 17640 RVA: 0x00019013 File Offset: 0x00017213
		public unsafe static string GMTName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_GMTName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_GMTName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x060044E9 RID: 17641 RVA: 0x00143C70 File Offset: 0x00141E70
		// (set) Token: 0x060044EA RID: 17642 RVA: 0x00019025 File Offset: 0x00017225
		public unsafe static string ZuluName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_ZuluName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_ZuluName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x00143C90 File Offset: 0x00141E90
		// (set) Token: 0x060044EC RID: 17644 RVA: 0x00019037 File Offset: 0x00017237
		public unsafe static string KoreanLangName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanLangName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_KoreanLangName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x060044ED RID: 17645 RVA: 0x00143CB0 File Offset: 0x00141EB0
		// (set) Token: 0x060044EE RID: 17646 RVA: 0x00019049 File Offset: 0x00017249
		public unsafe static string JapaneseLangName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseLangName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_JapaneseLangName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x060044EF RID: 17647 RVA: 0x00143CD0 File Offset: 0x00141ED0
		// (set) Token: 0x060044F0 RID: 17648 RVA: 0x0001905B File Offset: 0x0001725B
		public unsafe static string EnglishLangName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_EnglishLangName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_EnglishLangName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x060044F1 RID: 17649 RVA: 0x00143CF0 File Offset: 0x00141EF0
		// (set) Token: 0x060044F2 RID: 17650 RVA: 0x0001906D File Offset: 0x0001726D
		public unsafe static DateTimeFormatInfo s_jajpDTFI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_jajpDTFI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_jajpDTFI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x00143D18 File Offset: 0x00141F18
		// (set) Token: 0x060044F4 RID: 17652 RVA: 0x0001907F File Offset: 0x0001727F
		public unsafe static DateTimeFormatInfo s_zhtwDTFI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_zhtwDTFI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfo.NativeFieldInfoPtr_s_zhtwDTFI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003804 RID: 14340
		private static readonly IntPtr NativeFieldInfoPtr_s_invariantInfo;

		// Token: 0x04003805 RID: 14341
		private static readonly IntPtr NativeFieldInfoPtr__cultureData;

		// Token: 0x04003806 RID: 14342
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04003807 RID: 14343
		private static readonly IntPtr NativeFieldInfoPtr__langName;

		// Token: 0x04003808 RID: 14344
		private static readonly IntPtr NativeFieldInfoPtr__compareInfo;

		// Token: 0x04003809 RID: 14345
		private static readonly IntPtr NativeFieldInfoPtr__cultureInfo;

		// Token: 0x0400380A RID: 14346
		private static readonly IntPtr NativeFieldInfoPtr_amDesignator;

		// Token: 0x0400380B RID: 14347
		private static readonly IntPtr NativeFieldInfoPtr_pmDesignator;

		// Token: 0x0400380C RID: 14348
		private static readonly IntPtr NativeFieldInfoPtr_dateSeparator;

		// Token: 0x0400380D RID: 14349
		private static readonly IntPtr NativeFieldInfoPtr_generalShortTimePattern;

		// Token: 0x0400380E RID: 14350
		private static readonly IntPtr NativeFieldInfoPtr_generalLongTimePattern;

		// Token: 0x0400380F RID: 14351
		private static readonly IntPtr NativeFieldInfoPtr_timeSeparator;

		// Token: 0x04003810 RID: 14352
		private static readonly IntPtr NativeFieldInfoPtr_monthDayPattern;

		// Token: 0x04003811 RID: 14353
		private static readonly IntPtr NativeFieldInfoPtr_dateTimeOffsetPattern;

		// Token: 0x04003812 RID: 14354
		private static readonly IntPtr NativeFieldInfoPtr_rfc1123Pattern;

		// Token: 0x04003813 RID: 14355
		private static readonly IntPtr NativeFieldInfoPtr_sortableDateTimePattern;

		// Token: 0x04003814 RID: 14356
		private static readonly IntPtr NativeFieldInfoPtr_universalSortableDateTimePattern;

		// Token: 0x04003815 RID: 14357
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x04003816 RID: 14358
		private static readonly IntPtr NativeFieldInfoPtr_firstDayOfWeek;

		// Token: 0x04003817 RID: 14359
		private static readonly IntPtr NativeFieldInfoPtr_calendarWeekRule;

		// Token: 0x04003818 RID: 14360
		private static readonly IntPtr NativeFieldInfoPtr_fullDateTimePattern;

		// Token: 0x04003819 RID: 14361
		private static readonly IntPtr NativeFieldInfoPtr_abbreviatedDayNames;

		// Token: 0x0400381A RID: 14362
		private static readonly IntPtr NativeFieldInfoPtr_m_superShortDayNames;

		// Token: 0x0400381B RID: 14363
		private static readonly IntPtr NativeFieldInfoPtr_dayNames;

		// Token: 0x0400381C RID: 14364
		private static readonly IntPtr NativeFieldInfoPtr_abbreviatedMonthNames;

		// Token: 0x0400381D RID: 14365
		private static readonly IntPtr NativeFieldInfoPtr_monthNames;

		// Token: 0x0400381E RID: 14366
		private static readonly IntPtr NativeFieldInfoPtr_genitiveMonthNames;

		// Token: 0x0400381F RID: 14367
		private static readonly IntPtr NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames;

		// Token: 0x04003820 RID: 14368
		private static readonly IntPtr NativeFieldInfoPtr_leapYearMonthNames;

		// Token: 0x04003821 RID: 14369
		private static readonly IntPtr NativeFieldInfoPtr_longDatePattern;

		// Token: 0x04003822 RID: 14370
		private static readonly IntPtr NativeFieldInfoPtr_shortDatePattern;

		// Token: 0x04003823 RID: 14371
		private static readonly IntPtr NativeFieldInfoPtr_yearMonthPattern;

		// Token: 0x04003824 RID: 14372
		private static readonly IntPtr NativeFieldInfoPtr_longTimePattern;

		// Token: 0x04003825 RID: 14373
		private static readonly IntPtr NativeFieldInfoPtr_shortTimePattern;

		// Token: 0x04003826 RID: 14374
		private static readonly IntPtr NativeFieldInfoPtr_allYearMonthPatterns;

		// Token: 0x04003827 RID: 14375
		private static readonly IntPtr NativeFieldInfoPtr_allShortDatePatterns;

		// Token: 0x04003828 RID: 14376
		private static readonly IntPtr NativeFieldInfoPtr_allLongDatePatterns;

		// Token: 0x04003829 RID: 14377
		private static readonly IntPtr NativeFieldInfoPtr_allShortTimePatterns;

		// Token: 0x0400382A RID: 14378
		private static readonly IntPtr NativeFieldInfoPtr_allLongTimePatterns;

		// Token: 0x0400382B RID: 14379
		private static readonly IntPtr NativeFieldInfoPtr_m_eraNames;

		// Token: 0x0400382C RID: 14380
		private static readonly IntPtr NativeFieldInfoPtr_m_abbrevEraNames;

		// Token: 0x0400382D RID: 14381
		private static readonly IntPtr NativeFieldInfoPtr_m_abbrevEnglishEraNames;

		// Token: 0x0400382E RID: 14382
		private static readonly IntPtr NativeFieldInfoPtr_optionalCalendars;

		// Token: 0x0400382F RID: 14383
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE;

		// Token: 0x04003830 RID: 14384
		private static readonly IntPtr NativeFieldInfoPtr__isReadOnly;

		// Token: 0x04003831 RID: 14385
		private static readonly IntPtr NativeFieldInfoPtr_formatFlags;

		// Token: 0x04003832 RID: 14386
		private static readonly IntPtr NativeFieldInfoPtr_s_monthSpaces;

		// Token: 0x04003833 RID: 14387
		private static readonly IntPtr NativeFieldInfoPtr_RoundtripFormat;

		// Token: 0x04003834 RID: 14388
		private static readonly IntPtr NativeFieldInfoPtr_RoundtripDateTimeUnfixed;

		// Token: 0x04003835 RID: 14389
		private static readonly IntPtr NativeFieldInfoPtr__fullTimeSpanPositivePattern;

		// Token: 0x04003836 RID: 14390
		private static readonly IntPtr NativeFieldInfoPtr__fullTimeSpanNegativePattern;

		// Token: 0x04003837 RID: 14391
		private static readonly IntPtr NativeFieldInfoPtr_InvalidDateTimeStyles;

		// Token: 0x04003838 RID: 14392
		private static readonly IntPtr NativeFieldInfoPtr__dtfiTokenHash;

		// Token: 0x04003839 RID: 14393
		private static readonly IntPtr NativeFieldInfoPtr_TOKEN_HASH_SIZE;

		// Token: 0x0400383A RID: 14394
		private static readonly IntPtr NativeFieldInfoPtr_SECOND_PRIME;

		// Token: 0x0400383B RID: 14395
		private static readonly IntPtr NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset;

		// Token: 0x0400383C RID: 14396
		private static readonly IntPtr NativeFieldInfoPtr_invariantDateSeparator;

		// Token: 0x0400383D RID: 14397
		private static readonly IntPtr NativeFieldInfoPtr_invariantTimeSeparator;

		// Token: 0x0400383E RID: 14398
		private static readonly IntPtr NativeFieldInfoPtr_IgnorablePeriod;

		// Token: 0x0400383F RID: 14399
		private static readonly IntPtr NativeFieldInfoPtr_IgnorableComma;

		// Token: 0x04003840 RID: 14400
		private static readonly IntPtr NativeFieldInfoPtr_CJKYearSuff;

		// Token: 0x04003841 RID: 14401
		private static readonly IntPtr NativeFieldInfoPtr_CJKMonthSuff;

		// Token: 0x04003842 RID: 14402
		private static readonly IntPtr NativeFieldInfoPtr_CJKDaySuff;

		// Token: 0x04003843 RID: 14403
		private static readonly IntPtr NativeFieldInfoPtr_KoreanYearSuff;

		// Token: 0x04003844 RID: 14404
		private static readonly IntPtr NativeFieldInfoPtr_KoreanMonthSuff;

		// Token: 0x04003845 RID: 14405
		private static readonly IntPtr NativeFieldInfoPtr_KoreanDaySuff;

		// Token: 0x04003846 RID: 14406
		private static readonly IntPtr NativeFieldInfoPtr_KoreanHourSuff;

		// Token: 0x04003847 RID: 14407
		private static readonly IntPtr NativeFieldInfoPtr_KoreanMinuteSuff;

		// Token: 0x04003848 RID: 14408
		private static readonly IntPtr NativeFieldInfoPtr_KoreanSecondSuff;

		// Token: 0x04003849 RID: 14409
		private static readonly IntPtr NativeFieldInfoPtr_CJKHourSuff;

		// Token: 0x0400384A RID: 14410
		private static readonly IntPtr NativeFieldInfoPtr_ChineseHourSuff;

		// Token: 0x0400384B RID: 14411
		private static readonly IntPtr NativeFieldInfoPtr_CJKMinuteSuff;

		// Token: 0x0400384C RID: 14412
		private static readonly IntPtr NativeFieldInfoPtr_CJKSecondSuff;

		// Token: 0x0400384D RID: 14413
		private static readonly IntPtr NativeFieldInfoPtr_JapaneseEraStart;

		// Token: 0x0400384E RID: 14414
		private static readonly IntPtr NativeFieldInfoPtr_LocalTimeMark;

		// Token: 0x0400384F RID: 14415
		private static readonly IntPtr NativeFieldInfoPtr_GMTName;

		// Token: 0x04003850 RID: 14416
		private static readonly IntPtr NativeFieldInfoPtr_ZuluName;

		// Token: 0x04003851 RID: 14417
		private static readonly IntPtr NativeFieldInfoPtr_KoreanLangName;

		// Token: 0x04003852 RID: 14418
		private static readonly IntPtr NativeFieldInfoPtr_JapaneseLangName;

		// Token: 0x04003853 RID: 14419
		private static readonly IntPtr NativeFieldInfoPtr_EnglishLangName;

		// Token: 0x04003854 RID: 14420
		private static readonly IntPtr NativeFieldInfoPtr_s_jajpDTFI;

		// Token: 0x04003855 RID: 14421
		private static readonly IntPtr NativeFieldInfoPtr_s_zhtwDTFI;

		// Token: 0x04003856 RID: 14422
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Private_get_String_0;

		// Token: 0x04003857 RID: 14423
		private static readonly IntPtr NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0;

		// Token: 0x04003858 RID: 14424
		private static readonly IntPtr NativeMethodInfoPtr_get_LanguageName_Private_get_String_0;

		// Token: 0x04003859 RID: 14425
		private static readonly IntPtr NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0;

		// Token: 0x0400385A RID: 14426
		private static readonly IntPtr NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNamesCore_Private_Il2CppStringArray_0;

		// Token: 0x0400385B RID: 14427
		private static readonly IntPtr NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0;

		// Token: 0x0400385C RID: 14428
		private static readonly IntPtr NativeMethodInfoPtr_internalGetDayOfWeekNamesCore_Private_Il2CppStringArray_0;

		// Token: 0x0400385D RID: 14429
		private static readonly IntPtr NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0;

		// Token: 0x0400385E RID: 14430
		private static readonly IntPtr NativeMethodInfoPtr_internalGetAbbreviatedMonthNamesCore_Private_Il2CppStringArray_0;

		// Token: 0x0400385F RID: 14431
		private static readonly IntPtr NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0;

		// Token: 0x04003860 RID: 14432
		private static readonly IntPtr NativeMethodInfoPtr_internalGetMonthNamesCore_Private_Il2CppStringArray_0;

		// Token: 0x04003861 RID: 14433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003862 RID: 14434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0;

		// Token: 0x04003863 RID: 14435
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0;

		// Token: 0x04003864 RID: 14436
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0;

		// Token: 0x04003865 RID: 14437
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0;

		// Token: 0x04003866 RID: 14438
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0;

		// Token: 0x04003867 RID: 14439
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0;

		// Token: 0x04003868 RID: 14440
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04003869 RID: 14441
		private static readonly IntPtr NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0;

		// Token: 0x0400386A RID: 14442
		private static readonly IntPtr NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0;

		// Token: 0x0400386B RID: 14443
		private static readonly IntPtr NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0;

		// Token: 0x0400386C RID: 14444
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_CalendarId_0;

		// Token: 0x0400386D RID: 14445
		private static readonly IntPtr NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400386E RID: 14446
		private static readonly IntPtr NativeMethodInfoPtr_GetEraName_Public_String_Int32_0;

		// Token: 0x0400386F RID: 14447
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x04003870 RID: 14448
		private static readonly IntPtr NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0;

		// Token: 0x04003871 RID: 14449
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x04003872 RID: 14450
		private static readonly IntPtr NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0;

		// Token: 0x04003873 RID: 14451
		private static readonly IntPtr NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0;

		// Token: 0x04003874 RID: 14452
		private static readonly IntPtr NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0;

		// Token: 0x04003875 RID: 14453
		private static readonly IntPtr NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0;

		// Token: 0x04003876 RID: 14454
		private static readonly IntPtr NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0;

		// Token: 0x04003877 RID: 14455
		private static readonly IntPtr NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0;

		// Token: 0x04003878 RID: 14456
		private static readonly IntPtr NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0;

		// Token: 0x04003879 RID: 14457
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0;

		// Token: 0x0400387A RID: 14458
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0;

		// Token: 0x0400387B RID: 14459
		private static readonly IntPtr NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0;

		// Token: 0x0400387C RID: 14460
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0;

		// Token: 0x0400387D RID: 14461
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0;

		// Token: 0x0400387E RID: 14462
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0;

		// Token: 0x0400387F RID: 14463
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0;

		// Token: 0x04003880 RID: 14464
		private static readonly IntPtr NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0;

		// Token: 0x04003881 RID: 14465
		private static readonly IntPtr NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0;

		// Token: 0x04003882 RID: 14466
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04003883 RID: 14467
		private static readonly IntPtr NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04003884 RID: 14468
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04003885 RID: 14469
		private static readonly IntPtr NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04003886 RID: 14470
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0;

		// Token: 0x04003887 RID: 14471
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0;

		// Token: 0x04003888 RID: 14472
		private static readonly IntPtr NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0;

		// Token: 0x04003889 RID: 14473
		private static readonly IntPtr NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0;

		// Token: 0x0400388A RID: 14474
		private static readonly IntPtr NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0;

		// Token: 0x0400388B RID: 14475
		private static readonly IntPtr NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0;

		// Token: 0x0400388C RID: 14476
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x0400388D RID: 14477
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0;

		// Token: 0x0400388E RID: 14478
		private static readonly IntPtr NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0;

		// Token: 0x0400388F RID: 14479
		private static readonly IntPtr NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0;

		// Token: 0x04003890 RID: 14480
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0;

		// Token: 0x04003891 RID: 14481
		private static readonly IntPtr NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x04003892 RID: 14482
		private static readonly IntPtr NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04003893 RID: 14483
		private static readonly IntPtr NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04003894 RID: 14484
		private static readonly IntPtr NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04003895 RID: 14485
		private static readonly IntPtr NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04003896 RID: 14486
		private static readonly IntPtr NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04003897 RID: 14487
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04003898 RID: 14488
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x04003899 RID: 14489
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x0400389A RID: 14490
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x0400389B RID: 14491
		private static readonly IntPtr NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0;

		// Token: 0x0400389C RID: 14492
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x0400389D RID: 14493
		private static readonly IntPtr NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0;

		// Token: 0x0400389E RID: 14494
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0;

		// Token: 0x0400389F RID: 14495
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0;

		// Token: 0x040038A0 RID: 14496
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0;

		// Token: 0x040038A1 RID: 14497
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0;

		// Token: 0x040038A2 RID: 14498
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0;

		// Token: 0x040038A3 RID: 14499
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFormatFlags_Private_DateTimeFormatFlags_0;

		// Token: 0x040038A4 RID: 14500
		private static readonly IntPtr NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0;

		// Token: 0x040038A5 RID: 14501
		private static readonly IntPtr NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0;

		// Token: 0x040038A6 RID: 14502
		private static readonly IntPtr NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0;

		// Token: 0x040038A7 RID: 14503
		private static readonly IntPtr NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0;

		// Token: 0x040038A8 RID: 14504
		private static readonly IntPtr NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0;

		// Token: 0x040038A9 RID: 14505
		private static readonly IntPtr NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0;

		// Token: 0x040038AA RID: 14506
		private static readonly IntPtr NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0;

		// Token: 0x040038AB RID: 14507
		private static readonly IntPtr NativeMethodInfoPtr_PopulateSpecialTokenHashTable_Private_Void_Il2CppReferenceArray_1_TokenHashValue_byref_Boolean_0;

		// Token: 0x040038AC RID: 14508
		private static readonly IntPtr NativeMethodInfoPtr_IsJapaneseCalendar_Private_Static_Boolean_Calendar_0;

		// Token: 0x040038AD RID: 14509
		private static readonly IntPtr NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0;

		// Token: 0x040038AE RID: 14510
		private static readonly IntPtr NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0;

		// Token: 0x040038AF RID: 14511
		private static readonly IntPtr NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0;

		// Token: 0x040038B0 RID: 14512
		private static readonly IntPtr NativeMethodInfoPtr_IsAllowedJapaneseTokenFollowedByNonSpaceLetter_Private_Boolean_String_Char_0;

		// Token: 0x040038B1 RID: 14513
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0;

		// Token: 0x040038B2 RID: 14514
		private static readonly IntPtr NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0;

		// Token: 0x040038B3 RID: 14515
		private static readonly IntPtr NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0;

		// Token: 0x040038B4 RID: 14516
		private static readonly IntPtr NativeMethodInfoPtr_CompareStringIgnoreCaseOptimized_Private_Boolean_String_Int32_Int32_String_Int32_Int32_0;

		// Token: 0x020006CA RID: 1738
		public class TokenHashValue : Object
		{
			// Token: 0x06005CD3 RID: 23763 RVA: 0x001A4ACC File Offset: 0x001A2CCC
			// Note: this type is marked as 'beforefieldinit'.
			static TokenHashValue()
			{
				Il2CppClassPointerStore<DateTimeFormatInfo.TokenHashValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "TokenHashValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormatInfo.TokenHashValue>.NativeClassPtr);
				DateTimeFormatInfo.TokenHashValue.NativeFieldInfoPtr_tokenString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo.TokenHashValue>.NativeClassPtr, "tokenString");
				DateTimeFormatInfo.TokenHashValue.NativeFieldInfoPtr_tokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo.TokenHashValue>.NativeClassPtr, "tokenType");
				DateTimeFormatInfo.TokenHashValue.NativeFieldInfoPtr_tokenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo.TokenHashValue>.NativeClassPtr, "tokenValue");
				DateTimeFormatInfo.TokenHashValue.NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo.TokenHashValue>.NativeClassPtr, 100673441);
			}

			// Token: 0x06005CD4 RID: 23764 RVA: 0x001A4B48 File Offset: 0x001A2D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfo.TokenHashValue>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenString);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfo.TokenHashValue.NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005CD5 RID: 23765 RVA: 0x00021B8E File Offset: 0x0001FD8E
			public TokenHashValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017BC RID: 6076
			// (get) Token: 0x06005CD6 RID: 23766 RVA: 0x001A4BB0 File Offset: 0x001A2DB0
			// (set) Token: 0x06005CD7 RID: 23767 RVA: 0x00021B97 File Offset: 0x0001FD97
			public unsafe string tokenString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.TokenHashValue.NativeFieldInfoPtr_tokenString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.TokenHashValue.NativeFieldInfoPtr_tokenString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170017BD RID: 6077
			// (get) Token: 0x06005CD8 RID: 23768 RVA: 0x001A4BD8 File Offset: 0x001A2DD8
			// (set) Token: 0x06005CD9 RID: 23769 RVA: 0x00021BB6 File Offset: 0x0001FDB6
			public unsafe TokenType tokenType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.TokenHashValue.NativeFieldInfoPtr_tokenType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.TokenHashValue.NativeFieldInfoPtr_tokenType)) = value;
				}
			}

			// Token: 0x170017BE RID: 6078
			// (get) Token: 0x06005CDA RID: 23770 RVA: 0x001A4C00 File Offset: 0x001A2E00
			// (set) Token: 0x06005CDB RID: 23771 RVA: 0x00021BD1 File Offset: 0x0001FDD1
			public unsafe int tokenValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.TokenHashValue.NativeFieldInfoPtr_tokenValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfo.TokenHashValue.NativeFieldInfoPtr_tokenValue)) = value;
				}
			}

			// Token: 0x04004B54 RID: 19284
			private static readonly IntPtr NativeFieldInfoPtr_tokenString;

			// Token: 0x04004B55 RID: 19285
			private static readonly IntPtr NativeFieldInfoPtr_tokenType;

			// Token: 0x04004B56 RID: 19286
			private static readonly IntPtr NativeFieldInfoPtr_tokenValue;

			// Token: 0x04004B57 RID: 19287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0;
		}
	}
}
