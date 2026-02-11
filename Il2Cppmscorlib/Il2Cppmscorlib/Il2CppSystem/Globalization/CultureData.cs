using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200048E RID: 1166
	public class CultureData : Object
	{
		// Token: 0x060047BF RID: 18367 RVA: 0x0014F0D0 File Offset: 0x0014D2D0
		// Note: this type is marked as 'beforefieldinit'.
		static CultureData()
		{
			Il2CppClassPointerStore<CultureData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureData>.NativeClassPtr);
			CultureData.NativeFieldInfoPtr_sAM1159 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sAM1159");
			CultureData.NativeFieldInfoPtr_sPM2359 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sPM2359");
			CultureData.NativeFieldInfoPtr_sTimeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sTimeSeparator");
			CultureData.NativeFieldInfoPtr_saLongTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "saLongTimes");
			CultureData.NativeFieldInfoPtr_saShortTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "saShortTimes");
			CultureData.NativeFieldInfoPtr_iFirstDayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iFirstDayOfWeek");
			CultureData.NativeFieldInfoPtr_iFirstWeekOfYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iFirstWeekOfYear");
			CultureData.NativeFieldInfoPtr_waCalendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "waCalendars");
			CultureData.NativeFieldInfoPtr_calendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "calendars");
			CultureData.NativeFieldInfoPtr_sISO639Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sISO639Language");
			CultureData.NativeFieldInfoPtr_sRealName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sRealName");
			CultureData.NativeFieldInfoPtr_bUseOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "bUseOverrides");
			CultureData.NativeFieldInfoPtr_calendarId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "calendarId");
			CultureData.NativeFieldInfoPtr_numberIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "numberIndex");
			CultureData.NativeFieldInfoPtr_iDefaultAnsiCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultAnsiCodePage");
			CultureData.NativeFieldInfoPtr_iDefaultOemCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultOemCodePage");
			CultureData.NativeFieldInfoPtr_iDefaultMacCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultMacCodePage");
			CultureData.NativeFieldInfoPtr_iDefaultEbcdicCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultEbcdicCodePage");
			CultureData.NativeFieldInfoPtr_isRightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "isRightToLeft");
			CultureData.NativeFieldInfoPtr_sListSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sListSeparator");
			CultureData.NativeFieldInfoPtr_s_Invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "s_Invariant");
			CultureData.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673827);
			CultureData.NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673828);
			CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673829);
			CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673830);
			CultureData.NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673831);
			CultureData.NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673832);
			CultureData.NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673833);
			CultureData.NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673834);
			CultureData.NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673835);
			CultureData.NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673836);
			CultureData.NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673837);
			CultureData.NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673838);
			CultureData.NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673839);
			CultureData.NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673840);
			CultureData.NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673841);
			CultureData.NativeMethodInfoPtr_GetCalendarIds_Internal_Il2CppStructArray_1_CalendarId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673842);
			CultureData.NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673843);
			CultureData.NativeMethodInfoPtr_get_CultureName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673844);
			CultureData.NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673845);
			CultureData.NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673846);
			CultureData.NativeMethodInfoPtr_get_SLIST_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673847);
			CultureData.NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673848);
			CultureData.NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673849);
			CultureData.NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673850);
			CultureData.NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673851);
			CultureData.NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673852);
			CultureData.NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673853);
			CultureData.NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673854);
			CultureData.NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673855);
			CultureData.NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673856);
			CultureData.NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673857);
			CultureData.NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673858);
			CultureData.NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673859);
			CultureData.NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673860);
			CultureData.NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673861);
			CultureData.NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673862);
			CultureData.NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673863);
			CultureData.NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673864);
			CultureData.NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673865);
			CultureData.NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673866);
			CultureData.NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673867);
			CultureData.NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673868);
			CultureData.NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673869);
			CultureData.NativeMethodInfoPtr_strlen_Private_Static_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673870);
			CultureData.NativeMethodInfoPtr_idx2string_Private_Static_String_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673871);
			CultureData.NativeMethodInfoPtr_create_group_sizes_array_Private_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673872);
			CultureData.NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673873);
			CultureData.NativeMethodInfoPtr_fill_number_data_Private_Static_ptr_Byte_Int32_byref_NumberFormatEntryManaged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673874);
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x0014F664 File Offset: 0x0014D864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411581, XrefRangeEnd = 1411583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureData(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x0014F6B0 File Offset: 0x0014D8B0
		public unsafe static CultureData Invariant
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1411652, RefRangeEnd = 1411654, XrefRangeStart = 1411583, XrefRangeEnd = 1411652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
			}
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x0014F6E4 File Offset: 0x0014D8E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411659, RefRangeEnd = 1411660, XrefRangeStart = 1411654, XrefRangeEnd = 1411659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureData GetCultureData(string cultureName, bool useUserOverride)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x0014F738 File Offset: 0x0014D938
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1411671, RefRangeEnd = 1411675, XrefRangeStart = 1411660, XrefRangeEnd = 1411671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref datetimeIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numberIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(iso2lang);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ansiCodePage;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oemCodePage;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref macCodePage;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ebcdicCodePage;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightToLeft;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(listSeparator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr3) : null;
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x0014F824 File Offset: 0x0014DA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411675, XrefRangeEnd = 1411676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void fill_culture_data(int datetimeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref datetimeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x0014F864 File Offset: 0x0014DA64
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1411686, RefRangeEnd = 1411702, XrefRangeStart = 1411676, XrefRangeEnd = 1411686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalendarData GetCalendar(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CalendarData>(intPtr3) : null;
			}
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x060047C6 RID: 18374 RVA: 0x0014F8B0 File Offset: 0x0014DAB0
		public unsafe Il2CppStringArray LongTimes
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1353001, RefRangeEnd = 1353009, XrefRangeStart = 1353001, XrefRangeEnd = 1353009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x0014F8F0 File Offset: 0x0014DAF0
		public unsafe Il2CppStringArray ShortTimes
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1352515, RefRangeEnd = 1352521, XrefRangeStart = 1352515, XrefRangeEnd = 1352521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x060047C8 RID: 18376 RVA: 0x0014F930 File Offset: 0x0014DB30
		public unsafe string SISO639LANGNAME
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x060047C9 RID: 18377 RVA: 0x0014F968 File Offset: 0x0014DB68
		public unsafe int IFIRSTDAYOFWEEK
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x060047CA RID: 18378 RVA: 0x0014F9A4 File Offset: 0x0014DBA4
		public unsafe int IFIRSTWEEKOFYEAR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x0014F9E0 File Offset: 0x0014DBE0
		public unsafe string SAM1159
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x0014FA18 File Offset: 0x0014DC18
		public unsafe string SPM2359
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x0014FA50 File Offset: 0x0014DC50
		public unsafe string TimeSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x0014FA88 File Offset: 0x0014DC88
		public unsafe Il2CppStructArray<int> CalendarIds
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1411714, RefRangeEnd = 1411717, XrefRangeStart = 1411702, XrefRangeEnd = 1411714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x0014FAC8 File Offset: 0x0014DCC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411748, RefRangeEnd = 1411750, XrefRangeStart = 1411717, XrefRangeEnd = 1411748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<CalendarId> GetCalendarIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetCalendarIds_Internal_Il2CppStructArray_1_CalendarId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CalendarId>>(intPtr3) : null;
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x0014FB08 File Offset: 0x0014DD08
		public unsafe bool IsInvariantCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411750, XrefRangeEnd = 1411751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x060047D1 RID: 18385 RVA: 0x0014FB44 File Offset: 0x0014DD44
		public unsafe string CultureName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_CultureName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x0014FB7C File Offset: 0x0014DD7C
		public unsafe string SCOMPAREINFO
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1411753, RefRangeEnd = 1411754, XrefRangeStart = 1411751, XrefRangeEnd = 1411753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x060047D3 RID: 18387 RVA: 0x0014FBB4 File Offset: 0x0014DDB4
		public unsafe string STEXTINFO
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x060047D4 RID: 18388 RVA: 0x0014FBEC File Offset: 0x0014DDEC
		public unsafe string SLIST
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_SLIST_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x060047D5 RID: 18389 RVA: 0x0014FC24 File Offset: 0x0014DE24
		public unsafe bool UseUserOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x0014FC60 File Offset: 0x0014DE60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411755, RefRangeEnd = 1411757, XrefRangeStart = 1411754, XrefRangeEnd = 1411755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray EraNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x0014FCAC File Offset: 0x0014DEAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411758, RefRangeEnd = 1411760, XrefRangeStart = 1411757, XrefRangeEnd = 1411758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbrevEraNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x0014FCF8 File Offset: 0x0014DEF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1411761, RefRangeEnd = 1411764, XrefRangeStart = 1411760, XrefRangeEnd = 1411761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedEnglishEraNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x0014FD44 File Offset: 0x0014DF44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1411765, RefRangeEnd = 1411769, XrefRangeStart = 1411764, XrefRangeEnd = 1411765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray ShortDates(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x0014FD90 File Offset: 0x0014DF90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1411770, RefRangeEnd = 1411774, XrefRangeStart = 1411769, XrefRangeEnd = 1411770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray LongDates(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x0014FDDC File Offset: 0x0014DFDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1411775, RefRangeEnd = 1411779, XrefRangeStart = 1411774, XrefRangeEnd = 1411775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray YearMonths(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x0014FE28 File Offset: 0x0014E028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411780, RefRangeEnd = 1411781, XrefRangeStart = 1411779, XrefRangeEnd = 1411780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray DayNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x0014FE74 File Offset: 0x0014E074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411782, RefRangeEnd = 1411783, XrefRangeStart = 1411781, XrefRangeEnd = 1411782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedDayNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x0014FEC0 File Offset: 0x0014E0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411784, RefRangeEnd = 1411785, XrefRangeStart = 1411783, XrefRangeEnd = 1411784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray MonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x0014FF0C File Offset: 0x0014E10C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1411786, RefRangeEnd = 1411790, XrefRangeStart = 1411785, XrefRangeEnd = 1411786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GenitiveMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x0014FF58 File Offset: 0x0014E158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411791, RefRangeEnd = 1411792, XrefRangeStart = 1411790, XrefRangeEnd = 1411791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x0014FFA4 File Offset: 0x0014E1A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411793, RefRangeEnd = 1411795, XrefRangeStart = 1411792, XrefRangeEnd = 1411793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray AbbreviatedGenitiveMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x0014FFF0 File Offset: 0x0014E1F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411796, RefRangeEnd = 1411798, XrefRangeStart = 1411795, XrefRangeEnd = 1411796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray LeapYearMonthNames(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x0015003C File Offset: 0x0014E23C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411799, RefRangeEnd = 1411801, XrefRangeStart = 1411798, XrefRangeEnd = 1411799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string MonthDay(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x00150080 File Offset: 0x0014E280
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1411805, RefRangeEnd = 1411809, XrefRangeStart = 1411801, XrefRangeEnd = 1411805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DateSeparator(int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x001500C4 File Offset: 0x0014E2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411809, XrefRangeEnd = 1411812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDateSeparator(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x00150100 File Offset: 0x0014E300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411828, RefRangeEnd = 1411829, XrefRangeStart = 1411812, XrefRangeEnd = 1411828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSeparator(string format, string timeParts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timeParts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x00150150 File Offset: 0x0014E350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411829, XrefRangeEnd = 1411835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfTimePart(string format, int startIndex, string timeParts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timeParts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x001501B4 File Offset: 0x0014E3B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411849, RefRangeEnd = 1411850, XrefRangeStart = 1411835, XrefRangeEnd = 1411849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnescapeNlsString(string str, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x0015020C File Offset: 0x0014E40C
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ReescapeWin32Strings(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x00150250 File Offset: 0x0014E450
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReescapeWin32String(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x0015028C File Offset: 0x0014E48C
		[CallerCount(0)]
		public unsafe static int strlen(byte* s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_strlen_Private_Static_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x001502C8 File Offset: 0x0014E4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411850, XrefRangeEnd = 1411853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string idx2string(byte* data, int idx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_idx2string_Private_Static_String_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x00150310 File Offset: 0x0014E510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411857, RefRangeEnd = 1411859, XrefRangeStart = 1411853, XrefRangeEnd = 1411857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> create_group_sizes_array(int gs0, int gs1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gs0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gs1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_create_group_sizes_array_Private_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x0015036C File Offset: 0x0014E56C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411905, RefRangeEnd = 1411906, XrefRangeStart = 1411859, XrefRangeEnd = 1411905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNFIValues(NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x001503B0 File Offset: 0x0014E5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411906, XrefRangeEnd = 1411907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte* fill_number_data(int index, ref CultureData.NumberFormatEntryManaged nfe)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nfe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureData.NativeMethodInfoPtr_fill_number_data_Private_Static_ptr_Byte_Int32_byref_NumberFormatEntryManaged_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x0001A07B File Offset: 0x0001827B
		public CultureData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060047F1 RID: 18417 RVA: 0x001503F4 File Offset: 0x0014E5F4
		// (set) Token: 0x060047F2 RID: 18418 RVA: 0x0001A084 File Offset: 0x00018284
		public unsafe string sAM1159
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sAM1159);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sAM1159), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060047F3 RID: 18419 RVA: 0x0015041C File Offset: 0x0014E61C
		// (set) Token: 0x060047F4 RID: 18420 RVA: 0x0001A0A3 File Offset: 0x000182A3
		public unsafe string sPM2359
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sPM2359);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sPM2359), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060047F5 RID: 18421 RVA: 0x00150444 File Offset: 0x0014E644
		// (set) Token: 0x060047F6 RID: 18422 RVA: 0x0001A0C2 File Offset: 0x000182C2
		public unsafe string sTimeSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sTimeSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sTimeSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x0015046C File Offset: 0x0014E66C
		// (set) Token: 0x060047F8 RID: 18424 RVA: 0x0001A0E1 File Offset: 0x000182E1
		public unsafe Il2CppStringArray saLongTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saLongTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saLongTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x060047F9 RID: 18425 RVA: 0x0015049C File Offset: 0x0014E69C
		// (set) Token: 0x060047FA RID: 18426 RVA: 0x0001A100 File Offset: 0x00018300
		public unsafe Il2CppStringArray saShortTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saShortTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_saShortTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x060047FB RID: 18427 RVA: 0x001504CC File Offset: 0x0014E6CC
		// (set) Token: 0x060047FC RID: 18428 RVA: 0x0001A11F File Offset: 0x0001831F
		public unsafe int iFirstDayOfWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstDayOfWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstDayOfWeek)) = value;
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060047FD RID: 18429 RVA: 0x001504F4 File Offset: 0x0014E6F4
		// (set) Token: 0x060047FE RID: 18430 RVA: 0x0001A13A File Offset: 0x0001833A
		public unsafe int iFirstWeekOfYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstWeekOfYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iFirstWeekOfYear)) = value;
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x0015051C File Offset: 0x0014E71C
		// (set) Token: 0x06004800 RID: 18432 RVA: 0x0001A155 File Offset: 0x00018355
		public unsafe Il2CppStructArray<int> waCalendars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_waCalendars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_waCalendars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x0015054C File Offset: 0x0014E74C
		// (set) Token: 0x06004802 RID: 18434 RVA: 0x0001A174 File Offset: 0x00018374
		public unsafe Il2CppReferenceArray<CalendarData> calendars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CalendarData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x0015057C File Offset: 0x0014E77C
		// (set) Token: 0x06004804 RID: 18436 RVA: 0x0001A193 File Offset: 0x00018393
		public unsafe string sISO639Language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sISO639Language);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sISO639Language), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x001505A4 File Offset: 0x0014E7A4
		// (set) Token: 0x06004806 RID: 18438 RVA: 0x0001A1B2 File Offset: 0x000183B2
		public unsafe string sRealName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sRealName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sRealName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06004807 RID: 18439 RVA: 0x001505CC File Offset: 0x0014E7CC
		// (set) Token: 0x06004808 RID: 18440 RVA: 0x0001A1D1 File Offset: 0x000183D1
		public unsafe bool bUseOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_bUseOverrides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_bUseOverrides)) = value;
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x001505F4 File Offset: 0x0014E7F4
		// (set) Token: 0x0600480A RID: 18442 RVA: 0x0001A1EC File Offset: 0x000183EC
		public unsafe int calendarId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendarId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_calendarId)) = value;
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x0015061C File Offset: 0x0014E81C
		// (set) Token: 0x0600480C RID: 18444 RVA: 0x0001A207 File Offset: 0x00018407
		public unsafe int numberIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_numberIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_numberIndex)) = value;
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x00150644 File Offset: 0x0014E844
		// (set) Token: 0x0600480E RID: 18446 RVA: 0x0001A222 File Offset: 0x00018422
		public unsafe int iDefaultAnsiCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultAnsiCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultAnsiCodePage)) = value;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x0015066C File Offset: 0x0014E86C
		// (set) Token: 0x06004810 RID: 18448 RVA: 0x0001A23D File Offset: 0x0001843D
		public unsafe int iDefaultOemCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultOemCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultOemCodePage)) = value;
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x00150694 File Offset: 0x0014E894
		// (set) Token: 0x06004812 RID: 18450 RVA: 0x0001A258 File Offset: 0x00018458
		public unsafe int iDefaultMacCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultMacCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultMacCodePage)) = value;
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x001506BC File Offset: 0x0014E8BC
		// (set) Token: 0x06004814 RID: 18452 RVA: 0x0001A273 File Offset: 0x00018473
		public unsafe int iDefaultEbcdicCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultEbcdicCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_iDefaultEbcdicCodePage)) = value;
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06004815 RID: 18453 RVA: 0x001506E4 File Offset: 0x0014E8E4
		// (set) Token: 0x06004816 RID: 18454 RVA: 0x0001A28E File Offset: 0x0001848E
		public unsafe bool isRightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_isRightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_isRightToLeft)) = value;
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x0015070C File Offset: 0x0014E90C
		// (set) Token: 0x06004818 RID: 18456 RVA: 0x0001A2A9 File Offset: 0x000184A9
		public unsafe string sListSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sListSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureData.NativeFieldInfoPtr_sListSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x00150734 File Offset: 0x0014E934
		// (set) Token: 0x0600481A RID: 18458 RVA: 0x0001A2C8 File Offset: 0x000184C8
		public unsafe static CultureData s_Invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureData.NativeFieldInfoPtr_s_Invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureData.NativeFieldInfoPtr_s_Invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B21 RID: 15137
		private static readonly IntPtr NativeFieldInfoPtr_sAM1159;

		// Token: 0x04003B22 RID: 15138
		private static readonly IntPtr NativeFieldInfoPtr_sPM2359;

		// Token: 0x04003B23 RID: 15139
		private static readonly IntPtr NativeFieldInfoPtr_sTimeSeparator;

		// Token: 0x04003B24 RID: 15140
		private static readonly IntPtr NativeFieldInfoPtr_saLongTimes;

		// Token: 0x04003B25 RID: 15141
		private static readonly IntPtr NativeFieldInfoPtr_saShortTimes;

		// Token: 0x04003B26 RID: 15142
		private static readonly IntPtr NativeFieldInfoPtr_iFirstDayOfWeek;

		// Token: 0x04003B27 RID: 15143
		private static readonly IntPtr NativeFieldInfoPtr_iFirstWeekOfYear;

		// Token: 0x04003B28 RID: 15144
		private static readonly IntPtr NativeFieldInfoPtr_waCalendars;

		// Token: 0x04003B29 RID: 15145
		private static readonly IntPtr NativeFieldInfoPtr_calendars;

		// Token: 0x04003B2A RID: 15146
		private static readonly IntPtr NativeFieldInfoPtr_sISO639Language;

		// Token: 0x04003B2B RID: 15147
		private static readonly IntPtr NativeFieldInfoPtr_sRealName;

		// Token: 0x04003B2C RID: 15148
		private static readonly IntPtr NativeFieldInfoPtr_bUseOverrides;

		// Token: 0x04003B2D RID: 15149
		private static readonly IntPtr NativeFieldInfoPtr_calendarId;

		// Token: 0x04003B2E RID: 15150
		private static readonly IntPtr NativeFieldInfoPtr_numberIndex;

		// Token: 0x04003B2F RID: 15151
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultAnsiCodePage;

		// Token: 0x04003B30 RID: 15152
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultOemCodePage;

		// Token: 0x04003B31 RID: 15153
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultMacCodePage;

		// Token: 0x04003B32 RID: 15154
		private static readonly IntPtr NativeFieldInfoPtr_iDefaultEbcdicCodePage;

		// Token: 0x04003B33 RID: 15155
		private static readonly IntPtr NativeFieldInfoPtr_isRightToLeft;

		// Token: 0x04003B34 RID: 15156
		private static readonly IntPtr NativeFieldInfoPtr_sListSeparator;

		// Token: 0x04003B35 RID: 15157
		private static readonly IntPtr NativeFieldInfoPtr_s_Invariant;

		// Token: 0x04003B36 RID: 15158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

		// Token: 0x04003B37 RID: 15159
		private static readonly IntPtr NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0;

		// Token: 0x04003B38 RID: 15160
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0;

		// Token: 0x04003B39 RID: 15161
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0;

		// Token: 0x04003B3A RID: 15162
		private static readonly IntPtr NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0;

		// Token: 0x04003B3B RID: 15163
		private static readonly IntPtr NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0;

		// Token: 0x04003B3C RID: 15164
		private static readonly IntPtr NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0;

		// Token: 0x04003B3D RID: 15165
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0;

		// Token: 0x04003B3E RID: 15166
		private static readonly IntPtr NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0;

		// Token: 0x04003B3F RID: 15167
		private static readonly IntPtr NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0;

		// Token: 0x04003B40 RID: 15168
		private static readonly IntPtr NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0;

		// Token: 0x04003B41 RID: 15169
		private static readonly IntPtr NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0;

		// Token: 0x04003B42 RID: 15170
		private static readonly IntPtr NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0;

		// Token: 0x04003B43 RID: 15171
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0;

		// Token: 0x04003B44 RID: 15172
		private static readonly IntPtr NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003B45 RID: 15173
		private static readonly IntPtr NativeMethodInfoPtr_GetCalendarIds_Internal_Il2CppStructArray_1_CalendarId_0;

		// Token: 0x04003B46 RID: 15174
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0;

		// Token: 0x04003B47 RID: 15175
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Internal_get_String_0;

		// Token: 0x04003B48 RID: 15176
		private static readonly IntPtr NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0;

		// Token: 0x04003B49 RID: 15177
		private static readonly IntPtr NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0;

		// Token: 0x04003B4A RID: 15178
		private static readonly IntPtr NativeMethodInfoPtr_get_SLIST_Internal_get_String_0;

		// Token: 0x04003B4B RID: 15179
		private static readonly IntPtr NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0;

		// Token: 0x04003B4C RID: 15180
		private static readonly IntPtr NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B4D RID: 15181
		private static readonly IntPtr NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B4E RID: 15182
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B4F RID: 15183
		private static readonly IntPtr NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B50 RID: 15184
		private static readonly IntPtr NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B51 RID: 15185
		private static readonly IntPtr NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B52 RID: 15186
		private static readonly IntPtr NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B53 RID: 15187
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B54 RID: 15188
		private static readonly IntPtr NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B55 RID: 15189
		private static readonly IntPtr NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B56 RID: 15190
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B57 RID: 15191
		private static readonly IntPtr NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B58 RID: 15192
		private static readonly IntPtr NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0;

		// Token: 0x04003B59 RID: 15193
		private static readonly IntPtr NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0;

		// Token: 0x04003B5A RID: 15194
		private static readonly IntPtr NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0;

		// Token: 0x04003B5B RID: 15195
		private static readonly IntPtr NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0;

		// Token: 0x04003B5C RID: 15196
		private static readonly IntPtr NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0;

		// Token: 0x04003B5D RID: 15197
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0;

		// Token: 0x04003B5E RID: 15198
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0;

		// Token: 0x04003B5F RID: 15199
		private static readonly IntPtr NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04003B60 RID: 15200
		private static readonly IntPtr NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0;

		// Token: 0x04003B61 RID: 15201
		private static readonly IntPtr NativeMethodInfoPtr_strlen_Private_Static_Int32_ptr_Byte_0;

		// Token: 0x04003B62 RID: 15202
		private static readonly IntPtr NativeMethodInfoPtr_idx2string_Private_Static_String_ptr_Byte_Int32_0;

		// Token: 0x04003B63 RID: 15203
		private static readonly IntPtr NativeMethodInfoPtr_create_group_sizes_array_Private_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04003B64 RID: 15204
		private static readonly IntPtr NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0;

		// Token: 0x04003B65 RID: 15205
		private static readonly IntPtr NativeMethodInfoPtr_fill_number_data_Private_Static_ptr_Byte_Int32_byref_NumberFormatEntryManaged_0;

		// Token: 0x020006D9 RID: 1753
		[StructLayout(2)]
		public struct NumberFormatEntryManaged
		{
			// Token: 0x06005D56 RID: 23894 RVA: 0x001A6434 File Offset: 0x001A4634
			// Note: this type is marked as 'beforefieldinit'.
			static NumberFormatEntryManaged()
			{
				Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "NumberFormatEntryManaged");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr);
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_currency_decimal_digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "currency_decimal_digits");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_currency_decimal_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "currency_decimal_separator");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_currency_group_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "currency_group_separator");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_currency_group_sizes0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "currency_group_sizes0");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_currency_group_sizes1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "currency_group_sizes1");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_currency_negative_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "currency_negative_pattern");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_currency_positive_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "currency_positive_pattern");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_currency_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "currency_symbol");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_nan_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "nan_symbol");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_negative_infinity_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "negative_infinity_symbol");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_negative_sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "negative_sign");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_number_decimal_digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "number_decimal_digits");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_number_decimal_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "number_decimal_separator");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_number_group_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "number_group_separator");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_number_group_sizes0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "number_group_sizes0");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_number_group_sizes1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "number_group_sizes1");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_number_negative_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "number_negative_pattern");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_per_mille_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "per_mille_symbol");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_percent_negative_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "percent_negative_pattern");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_percent_positive_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "percent_positive_pattern");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_percent_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "percent_symbol");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_positive_infinity_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "positive_infinity_symbol");
				CultureData.NumberFormatEntryManaged.NativeFieldInfoPtr_positive_sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, "positive_sign");
			}

			// Token: 0x06005D57 RID: 23895 RVA: 0x00022151 File Offset: 0x00020351
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CultureData.NumberFormatEntryManaged>.NativeClassPtr, ref this));
			}

			// Token: 0x04004BE6 RID: 19430
			private static readonly IntPtr NativeFieldInfoPtr_currency_decimal_digits;

			// Token: 0x04004BE7 RID: 19431
			private static readonly IntPtr NativeFieldInfoPtr_currency_decimal_separator;

			// Token: 0x04004BE8 RID: 19432
			private static readonly IntPtr NativeFieldInfoPtr_currency_group_separator;

			// Token: 0x04004BE9 RID: 19433
			private static readonly IntPtr NativeFieldInfoPtr_currency_group_sizes0;

			// Token: 0x04004BEA RID: 19434
			private static readonly IntPtr NativeFieldInfoPtr_currency_group_sizes1;

			// Token: 0x04004BEB RID: 19435
			private static readonly IntPtr NativeFieldInfoPtr_currency_negative_pattern;

			// Token: 0x04004BEC RID: 19436
			private static readonly IntPtr NativeFieldInfoPtr_currency_positive_pattern;

			// Token: 0x04004BED RID: 19437
			private static readonly IntPtr NativeFieldInfoPtr_currency_symbol;

			// Token: 0x04004BEE RID: 19438
			private static readonly IntPtr NativeFieldInfoPtr_nan_symbol;

			// Token: 0x04004BEF RID: 19439
			private static readonly IntPtr NativeFieldInfoPtr_negative_infinity_symbol;

			// Token: 0x04004BF0 RID: 19440
			private static readonly IntPtr NativeFieldInfoPtr_negative_sign;

			// Token: 0x04004BF1 RID: 19441
			private static readonly IntPtr NativeFieldInfoPtr_number_decimal_digits;

			// Token: 0x04004BF2 RID: 19442
			private static readonly IntPtr NativeFieldInfoPtr_number_decimal_separator;

			// Token: 0x04004BF3 RID: 19443
			private static readonly IntPtr NativeFieldInfoPtr_number_group_separator;

			// Token: 0x04004BF4 RID: 19444
			private static readonly IntPtr NativeFieldInfoPtr_number_group_sizes0;

			// Token: 0x04004BF5 RID: 19445
			private static readonly IntPtr NativeFieldInfoPtr_number_group_sizes1;

			// Token: 0x04004BF6 RID: 19446
			private static readonly IntPtr NativeFieldInfoPtr_number_negative_pattern;

			// Token: 0x04004BF7 RID: 19447
			private static readonly IntPtr NativeFieldInfoPtr_per_mille_symbol;

			// Token: 0x04004BF8 RID: 19448
			private static readonly IntPtr NativeFieldInfoPtr_percent_negative_pattern;

			// Token: 0x04004BF9 RID: 19449
			private static readonly IntPtr NativeFieldInfoPtr_percent_positive_pattern;

			// Token: 0x04004BFA RID: 19450
			private static readonly IntPtr NativeFieldInfoPtr_percent_symbol;

			// Token: 0x04004BFB RID: 19451
			private static readonly IntPtr NativeFieldInfoPtr_positive_infinity_symbol;

			// Token: 0x04004BFC RID: 19452
			private static readonly IntPtr NativeFieldInfoPtr_positive_sign;

			// Token: 0x04004BFD RID: 19453
			[FieldOffset(0)]
			public int currency_decimal_digits;

			// Token: 0x04004BFE RID: 19454
			[FieldOffset(4)]
			public int currency_decimal_separator;

			// Token: 0x04004BFF RID: 19455
			[FieldOffset(8)]
			public int currency_group_separator;

			// Token: 0x04004C00 RID: 19456
			[FieldOffset(12)]
			public int currency_group_sizes0;

			// Token: 0x04004C01 RID: 19457
			[FieldOffset(16)]
			public int currency_group_sizes1;

			// Token: 0x04004C02 RID: 19458
			[FieldOffset(20)]
			public int currency_negative_pattern;

			// Token: 0x04004C03 RID: 19459
			[FieldOffset(24)]
			public int currency_positive_pattern;

			// Token: 0x04004C04 RID: 19460
			[FieldOffset(28)]
			public int currency_symbol;

			// Token: 0x04004C05 RID: 19461
			[FieldOffset(32)]
			public int nan_symbol;

			// Token: 0x04004C06 RID: 19462
			[FieldOffset(36)]
			public int negative_infinity_symbol;

			// Token: 0x04004C07 RID: 19463
			[FieldOffset(40)]
			public int negative_sign;

			// Token: 0x04004C08 RID: 19464
			[FieldOffset(44)]
			public int number_decimal_digits;

			// Token: 0x04004C09 RID: 19465
			[FieldOffset(48)]
			public int number_decimal_separator;

			// Token: 0x04004C0A RID: 19466
			[FieldOffset(52)]
			public int number_group_separator;

			// Token: 0x04004C0B RID: 19467
			[FieldOffset(56)]
			public int number_group_sizes0;

			// Token: 0x04004C0C RID: 19468
			[FieldOffset(60)]
			public int number_group_sizes1;

			// Token: 0x04004C0D RID: 19469
			[FieldOffset(64)]
			public int number_negative_pattern;

			// Token: 0x04004C0E RID: 19470
			[FieldOffset(68)]
			public int per_mille_symbol;

			// Token: 0x04004C0F RID: 19471
			[FieldOffset(72)]
			public int percent_negative_pattern;

			// Token: 0x04004C10 RID: 19472
			[FieldOffset(76)]
			public int percent_positive_pattern;

			// Token: 0x04004C11 RID: 19473
			[FieldOffset(80)]
			public int percent_symbol;

			// Token: 0x04004C12 RID: 19474
			[FieldOffset(84)]
			public int positive_infinity_symbol;

			// Token: 0x04004C13 RID: 19475
			[FieldOffset(88)]
			public int positive_sign;
		}
	}
}
