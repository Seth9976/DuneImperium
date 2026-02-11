using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000480 RID: 1152
	public class CalendarData : Object
	{
		// Token: 0x060045BD RID: 17853 RVA: 0x00146AB4 File Offset: 0x00144CB4
		// Note: this type is marked as 'beforefieldinit'.
		static CalendarData()
		{
			Il2CppClassPointerStore<CalendarData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CalendarData");
			CalendarData.NativeFieldInfoPtr_MAX_CALENDARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "MAX_CALENDARS");
			CalendarData.NativeFieldInfoPtr_sNativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "sNativeName");
			CalendarData.NativeFieldInfoPtr_saShortDates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saShortDates");
			CalendarData.NativeFieldInfoPtr_saYearMonths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saYearMonths");
			CalendarData.NativeFieldInfoPtr_saLongDates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saLongDates");
			CalendarData.NativeFieldInfoPtr_sMonthDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "sMonthDay");
			CalendarData.NativeFieldInfoPtr_saEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saEraNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevEraNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevEnglishEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevEnglishEraNames");
			CalendarData.NativeFieldInfoPtr_saDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saDayNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevDayNames");
			CalendarData.NativeFieldInfoPtr_saSuperShortDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saSuperShortDayNames");
			CalendarData.NativeFieldInfoPtr_saMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saMonthNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevMonthNames");
			CalendarData.NativeFieldInfoPtr_saMonthGenitiveNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saMonthGenitiveNames");
			CalendarData.NativeFieldInfoPtr_saAbbrevMonthGenitiveNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saAbbrevMonthGenitiveNames");
			CalendarData.NativeFieldInfoPtr_saLeapYearMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "saLeapYearMonthNames");
			CalendarData.NativeFieldInfoPtr_iTwoDigitYearMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "iTwoDigitYearMax");
			CalendarData.NativeFieldInfoPtr_iCurrentEra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "iCurrentEra");
			CalendarData.NativeFieldInfoPtr_bUseUserOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "bUseUserOverrides");
			CalendarData.NativeFieldInfoPtr_Invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "Invariant");
			CalendarData.NativeFieldInfoPtr_HEBREW_MONTH_NAMES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "HEBREW_MONTH_NAMES");
			CalendarData.NativeFieldInfoPtr_HEBREW_LEAP_MONTH_NAMES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, "HEBREW_LEAP_MONTH_NAMES");
			CalendarData.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673556);
			CalendarData.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673558);
			CalendarData.NativeMethodInfoPtr_InitializeEraNames_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673559);
			CalendarData.NativeMethodInfoPtr_GetJapaneseEraNames_Private_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673560);
			CalendarData.NativeMethodInfoPtr_GetJapaneseEnglishEraNames_Private_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673561);
			CalendarData.NativeMethodInfoPtr_InitializeAbbreviatedEraNames_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673562);
			CalendarData.NativeMethodInfoPtr_GetCalendarData_Internal_Static_CalendarData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673563);
			CalendarData.NativeMethodInfoPtr_CalendarIdToCultureName_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673564);
			CalendarData.NativeMethodInfoPtr_nativeGetTwoDigitYearMax_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673565);
			CalendarData.NativeMethodInfoPtr_nativeGetCalendarData_Private_Static_Boolean_CalendarData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673566);
			CalendarData.NativeMethodInfoPtr_fill_calendar_data_Private_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalendarData>.NativeClassPtr, 100673567);
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00146D84 File Offset: 0x00144F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409849, XrefRangeEnd = 1409850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalendarData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalendarData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x00146DC0 File Offset: 0x00144FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409971, RefRangeEnd = 1409972, XrefRangeStart = 1409850, XrefRangeEnd = 1409971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalendarData(string localeName, int calendarId, bool bUseUserOverrides)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalendarData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseUserOverrides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00146E28 File Offset: 0x00145028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409993, RefRangeEnd = 1409994, XrefRangeStart = 1409972, XrefRangeEnd = 1409993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeEraNames(string localeName, int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_InitializeEraNames_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x00146E78 File Offset: 0x00145078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409994, XrefRangeEnd = 1410013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetJapaneseEraNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_GetJapaneseEraNames_Private_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00146EAC File Offset: 0x001450AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410013, XrefRangeEnd = 1410032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetJapaneseEnglishEraNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_GetJapaneseEnglishEraNames_Private_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00146EE0 File Offset: 0x001450E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410040, RefRangeEnd = 1410041, XrefRangeStart = 1410032, XrefRangeEnd = 1410040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeAbbreviatedEraNames(string localeName, int calendarId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_InitializeAbbreviatedEraNames_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00146F30 File Offset: 0x00145130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410041, XrefRangeEnd = 1410079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CalendarData GetCalendarData(int calendarId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_GetCalendarData_Internal_Static_CalendarData_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CalendarData>(intPtr3) : null;
			}
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x00146F70 File Offset: 0x00145170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410079, XrefRangeEnd = 1410090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CalendarIdToCultureName(int calendarId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_CalendarIdToCultureName_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x00146FA8 File Offset: 0x001451A8
		[CallerCount(0)]
		public unsafe static int nativeGetTwoDigitYearMax(int calID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_nativeGetTwoDigitYearMax_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00146FE8 File Offset: 0x001451E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410090, XrefRangeEnd = 1410093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calendarId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_nativeGetCalendarData_Private_Static_Boolean_CalendarData_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x0014704C File Offset: 0x0014524C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410093, XrefRangeEnd = 1410094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool fill_calendar_data(string localeName, int datetimeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref datetimeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalendarData.NativeMethodInfoPtr_fill_calendar_data_Private_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00019457 File Offset: 0x00017657
		public CalendarData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x001470A8 File Offset: 0x001452A8
		// (set) Token: 0x060045CB RID: 17867 RVA: 0x00019460 File Offset: 0x00017660
		public unsafe static int MAX_CALENDARS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CalendarData.NativeFieldInfoPtr_MAX_CALENDARS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalendarData.NativeFieldInfoPtr_MAX_CALENDARS, (void*)(&value));
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x060045CC RID: 17868 RVA: 0x001470C4 File Offset: 0x001452C4
		// (set) Token: 0x060045CD RID: 17869 RVA: 0x0001946E File Offset: 0x0001766E
		public unsafe string sNativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sNativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sNativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x060045CE RID: 17870 RVA: 0x001470EC File Offset: 0x001452EC
		// (set) Token: 0x060045CF RID: 17871 RVA: 0x0001948D File Offset: 0x0001768D
		public unsafe Il2CppStringArray saShortDates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saShortDates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saShortDates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x0014711C File Offset: 0x0014531C
		// (set) Token: 0x060045D1 RID: 17873 RVA: 0x000194AC File Offset: 0x000176AC
		public unsafe Il2CppStringArray saYearMonths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saYearMonths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saYearMonths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x0014714C File Offset: 0x0014534C
		// (set) Token: 0x060045D3 RID: 17875 RVA: 0x000194CB File Offset: 0x000176CB
		public unsafe Il2CppStringArray saLongDates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLongDates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLongDates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x060045D4 RID: 17876 RVA: 0x0014717C File Offset: 0x0014537C
		// (set) Token: 0x060045D5 RID: 17877 RVA: 0x000194EA File Offset: 0x000176EA
		public unsafe string sMonthDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sMonthDay);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_sMonthDay), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x060045D6 RID: 17878 RVA: 0x001471A4 File Offset: 0x001453A4
		// (set) Token: 0x060045D7 RID: 17879 RVA: 0x00019509 File Offset: 0x00017709
		public unsafe Il2CppStringArray saEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x060045D8 RID: 17880 RVA: 0x001471D4 File Offset: 0x001453D4
		// (set) Token: 0x060045D9 RID: 17881 RVA: 0x00019528 File Offset: 0x00017728
		public unsafe Il2CppStringArray saAbbrevEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x060045DA RID: 17882 RVA: 0x00147204 File Offset: 0x00145404
		// (set) Token: 0x060045DB RID: 17883 RVA: 0x00019547 File Offset: 0x00017747
		public unsafe Il2CppStringArray saAbbrevEnglishEraNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEnglishEraNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevEnglishEraNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x060045DC RID: 17884 RVA: 0x00147234 File Offset: 0x00145434
		// (set) Token: 0x060045DD RID: 17885 RVA: 0x00019566 File Offset: 0x00017766
		public unsafe Il2CppStringArray saDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x060045DE RID: 17886 RVA: 0x00147264 File Offset: 0x00145464
		// (set) Token: 0x060045DF RID: 17887 RVA: 0x00019585 File Offset: 0x00017785
		public unsafe Il2CppStringArray saAbbrevDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x060045E0 RID: 17888 RVA: 0x00147294 File Offset: 0x00145494
		// (set) Token: 0x060045E1 RID: 17889 RVA: 0x000195A4 File Offset: 0x000177A4
		public unsafe Il2CppStringArray saSuperShortDayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saSuperShortDayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saSuperShortDayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x060045E2 RID: 17890 RVA: 0x001472C4 File Offset: 0x001454C4
		// (set) Token: 0x060045E3 RID: 17891 RVA: 0x000195C3 File Offset: 0x000177C3
		public unsafe Il2CppStringArray saMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x060045E4 RID: 17892 RVA: 0x001472F4 File Offset: 0x001454F4
		// (set) Token: 0x060045E5 RID: 17893 RVA: 0x000195E2 File Offset: 0x000177E2
		public unsafe Il2CppStringArray saAbbrevMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x00147324 File Offset: 0x00145524
		// (set) Token: 0x060045E7 RID: 17895 RVA: 0x00019601 File Offset: 0x00017801
		public unsafe Il2CppStringArray saMonthGenitiveNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthGenitiveNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saMonthGenitiveNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x00147354 File Offset: 0x00145554
		// (set) Token: 0x060045E9 RID: 17897 RVA: 0x00019620 File Offset: 0x00017820
		public unsafe Il2CppStringArray saAbbrevMonthGenitiveNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthGenitiveNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saAbbrevMonthGenitiveNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x060045EA RID: 17898 RVA: 0x00147384 File Offset: 0x00145584
		// (set) Token: 0x060045EB RID: 17899 RVA: 0x0001963F File Offset: 0x0001783F
		public unsafe Il2CppStringArray saLeapYearMonthNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLeapYearMonthNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_saLeapYearMonthNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x060045EC RID: 17900 RVA: 0x001473B4 File Offset: 0x001455B4
		// (set) Token: 0x060045ED RID: 17901 RVA: 0x0001965E File Offset: 0x0001785E
		public unsafe int iTwoDigitYearMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iTwoDigitYearMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iTwoDigitYearMax)) = value;
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x001473DC File Offset: 0x001455DC
		// (set) Token: 0x060045EF RID: 17903 RVA: 0x00019679 File Offset: 0x00017879
		public unsafe int iCurrentEra
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iCurrentEra);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_iCurrentEra)) = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x060045F0 RID: 17904 RVA: 0x00147404 File Offset: 0x00145604
		// (set) Token: 0x060045F1 RID: 17905 RVA: 0x00019694 File Offset: 0x00017894
		public unsafe bool bUseUserOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_bUseUserOverrides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalendarData.NativeFieldInfoPtr_bUseUserOverrides)) = value;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x060045F2 RID: 17906 RVA: 0x0014742C File Offset: 0x0014562C
		// (set) Token: 0x060045F3 RID: 17907 RVA: 0x000196AF File Offset: 0x000178AF
		public unsafe static CalendarData Invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CalendarData.NativeFieldInfoPtr_Invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CalendarData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalendarData.NativeFieldInfoPtr_Invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x00147454 File Offset: 0x00145654
		// (set) Token: 0x060045F5 RID: 17909 RVA: 0x000196C1 File Offset: 0x000178C1
		public unsafe static Il2CppStringArray HEBREW_MONTH_NAMES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CalendarData.NativeFieldInfoPtr_HEBREW_MONTH_NAMES, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalendarData.NativeFieldInfoPtr_HEBREW_MONTH_NAMES, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x0014747C File Offset: 0x0014567C
		// (set) Token: 0x060045F7 RID: 17911 RVA: 0x000196D3 File Offset: 0x000178D3
		public unsafe static Il2CppStringArray HEBREW_LEAP_MONTH_NAMES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CalendarData.NativeFieldInfoPtr_HEBREW_LEAP_MONTH_NAMES, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalendarData.NativeFieldInfoPtr_HEBREW_LEAP_MONTH_NAMES, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039A3 RID: 14755
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CALENDARS;

		// Token: 0x040039A4 RID: 14756
		private static readonly IntPtr NativeFieldInfoPtr_sNativeName;

		// Token: 0x040039A5 RID: 14757
		private static readonly IntPtr NativeFieldInfoPtr_saShortDates;

		// Token: 0x040039A6 RID: 14758
		private static readonly IntPtr NativeFieldInfoPtr_saYearMonths;

		// Token: 0x040039A7 RID: 14759
		private static readonly IntPtr NativeFieldInfoPtr_saLongDates;

		// Token: 0x040039A8 RID: 14760
		private static readonly IntPtr NativeFieldInfoPtr_sMonthDay;

		// Token: 0x040039A9 RID: 14761
		private static readonly IntPtr NativeFieldInfoPtr_saEraNames;

		// Token: 0x040039AA RID: 14762
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevEraNames;

		// Token: 0x040039AB RID: 14763
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevEnglishEraNames;

		// Token: 0x040039AC RID: 14764
		private static readonly IntPtr NativeFieldInfoPtr_saDayNames;

		// Token: 0x040039AD RID: 14765
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevDayNames;

		// Token: 0x040039AE RID: 14766
		private static readonly IntPtr NativeFieldInfoPtr_saSuperShortDayNames;

		// Token: 0x040039AF RID: 14767
		private static readonly IntPtr NativeFieldInfoPtr_saMonthNames;

		// Token: 0x040039B0 RID: 14768
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevMonthNames;

		// Token: 0x040039B1 RID: 14769
		private static readonly IntPtr NativeFieldInfoPtr_saMonthGenitiveNames;

		// Token: 0x040039B2 RID: 14770
		private static readonly IntPtr NativeFieldInfoPtr_saAbbrevMonthGenitiveNames;

		// Token: 0x040039B3 RID: 14771
		private static readonly IntPtr NativeFieldInfoPtr_saLeapYearMonthNames;

		// Token: 0x040039B4 RID: 14772
		private static readonly IntPtr NativeFieldInfoPtr_iTwoDigitYearMax;

		// Token: 0x040039B5 RID: 14773
		private static readonly IntPtr NativeFieldInfoPtr_iCurrentEra;

		// Token: 0x040039B6 RID: 14774
		private static readonly IntPtr NativeFieldInfoPtr_bUseUserOverrides;

		// Token: 0x040039B7 RID: 14775
		private static readonly IntPtr NativeFieldInfoPtr_Invariant;

		// Token: 0x040039B8 RID: 14776
		private static readonly IntPtr NativeFieldInfoPtr_HEBREW_MONTH_NAMES;

		// Token: 0x040039B9 RID: 14777
		private static readonly IntPtr NativeFieldInfoPtr_HEBREW_LEAP_MONTH_NAMES;

		// Token: 0x040039BA RID: 14778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040039BB RID: 14779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0;

		// Token: 0x040039BC RID: 14780
		private static readonly IntPtr NativeMethodInfoPtr_InitializeEraNames_Private_Void_String_Int32_0;

		// Token: 0x040039BD RID: 14781
		private static readonly IntPtr NativeMethodInfoPtr_GetJapaneseEraNames_Private_Static_Il2CppStringArray_0;

		// Token: 0x040039BE RID: 14782
		private static readonly IntPtr NativeMethodInfoPtr_GetJapaneseEnglishEraNames_Private_Static_Il2CppStringArray_0;

		// Token: 0x040039BF RID: 14783
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAbbreviatedEraNames_Private_Void_String_Int32_0;

		// Token: 0x040039C0 RID: 14784
		private static readonly IntPtr NativeMethodInfoPtr_GetCalendarData_Internal_Static_CalendarData_Int32_0;

		// Token: 0x040039C1 RID: 14785
		private static readonly IntPtr NativeMethodInfoPtr_CalendarIdToCultureName_Private_Static_String_Int32_0;

		// Token: 0x040039C2 RID: 14786
		private static readonly IntPtr NativeMethodInfoPtr_nativeGetTwoDigitYearMax_Public_Static_Int32_Int32_0;

		// Token: 0x040039C3 RID: 14787
		private static readonly IntPtr NativeMethodInfoPtr_nativeGetCalendarData_Private_Static_Boolean_CalendarData_String_Int32_0;

		// Token: 0x040039C4 RID: 14788
		private static readonly IntPtr NativeMethodInfoPtr_fill_calendar_data_Private_Boolean_String_Int32_0;
	}
}
