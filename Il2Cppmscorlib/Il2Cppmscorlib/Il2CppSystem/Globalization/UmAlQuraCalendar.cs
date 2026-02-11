using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200048B RID: 1163
	[Serializable]
	public class UmAlQuraCalendar : Calendar
	{
		// Token: 0x0600477E RID: 18302 RVA: 0x0014DA90 File Offset: 0x0014BC90
		// Note: this type is marked as 'beforefieldinit'.
		static UmAlQuraCalendar()
		{
			Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "UmAlQuraCalendar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr);
			UmAlQuraCalendar.NativeFieldInfoPtr_HijriYearInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, "HijriYearInfo");
			UmAlQuraCalendar.NativeFieldInfoPtr_minDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, "minDate");
			UmAlQuraCalendar.NativeFieldInfoPtr_maxDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, "maxDate");
			UmAlQuraCalendar.NativeMethodInfoPtr_InitDateMapping_Private_Static_Il2CppStructArray_1_DateMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673780);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673781);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673782);
			UmAlQuraCalendar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673783);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673784);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673785);
			UmAlQuraCalendar.NativeMethodInfoPtr_ConvertHijriToGregorian_Private_Static_Void_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673786);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetAbsoluteDateUmAlQura_Private_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673787);
			UmAlQuraCalendar.NativeMethodInfoPtr_CheckTicksRange_Internal_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673788);
			UmAlQuraCalendar.NativeMethodInfoPtr_CheckEraRange_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673789);
			UmAlQuraCalendar.NativeMethodInfoPtr_CheckYearRange_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673790);
			UmAlQuraCalendar.NativeMethodInfoPtr_CheckYearMonthRange_Internal_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673791);
			UmAlQuraCalendar.NativeMethodInfoPtr_ConvertGregorianToHijri_Private_Static_Void_DateTime_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673792);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673793);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673794);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673795);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673796);
			UmAlQuraCalendar.NativeMethodInfoPtr_RealGetDaysInYear_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673797);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673798);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673799);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673800);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673801);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673802);
			UmAlQuraCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673803);
			UmAlQuraCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673804);
			UmAlQuraCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673805);
			UmAlQuraCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673806);
			UmAlQuraCalendar.NativeMethodInfoPtr_set_TwoDigitYearMax_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673807);
			UmAlQuraCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, 100673808);
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x0014DD40 File Offset: 0x0014BF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411351, XrefRangeEnd = 1411362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<UmAlQuraCalendar.DateMapping> InitDateMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_InitDateMapping_Private_Static_Il2CppStructArray_1_DateMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UmAlQuraCalendar.DateMapping>>(intPtr3) : null;
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x0014DD74 File Offset: 0x0014BF74
		public unsafe override DateTime MinSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411362, XrefRangeEnd = 1411366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06004781 RID: 18305 RVA: 0x0014DDBC File Offset: 0x0014BFBC
		public unsafe override DateTime MaxSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411366, XrefRangeEnd = 1411370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x0014DE04 File Offset: 0x0014C004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UmAlQuraCalendar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06004783 RID: 18307 RVA: 0x0014DE40 File Offset: 0x0014C040
		public unsafe override int BaseCalendarID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x0014DE88 File Offset: 0x0014C088
		public unsafe override int ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x0014DED0 File Offset: 0x0014C0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411370, XrefRangeEnd = 1411381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref HijriYear;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref HijriMonth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref HijriDay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &yg;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mg;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_ConvertHijriToGregorian_Private_Static_Void_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x0014DF4C File Offset: 0x0014C14C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1411402, RefRangeEnd = 1411405, XrefRangeStart = 1411381, XrefRangeEnd = 1411402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetAbsoluteDateUmAlQura(int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_GetAbsoluteDateUmAlQura_Private_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x0014DFA8 File Offset: 0x0014C1A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411419, RefRangeEnd = 1411421, XrefRangeStart = 1411405, XrefRangeEnd = 1411419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTicksRange(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_CheckTicksRange_Internal_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x0014DFDC File Offset: 0x0014C1DC
		[CallerCount(0)]
		public unsafe static void CheckEraRange(int era)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_CheckEraRange_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x0014E010 File Offset: 0x0014C210
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1411424, RefRangeEnd = 1411428, XrefRangeStart = 1411421, XrefRangeEnd = 1411424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckYearRange(int year, int era)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_CheckYearRange_Internal_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x0014E050 File Offset: 0x0014C250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411432, RefRangeEnd = 1411434, XrefRangeStart = 1411428, XrefRangeEnd = 1411432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckYearMonthRange(int year, int month, int era)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_CheckYearMonthRange_Internal_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x0014E0A0 File Offset: 0x0014C2A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411466, RefRangeEnd = 1411467, XrefRangeStart = 1411434, XrefRangeEnd = 1411466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &HijriYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &HijriMonth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &HijriDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_ConvertGregorianToHijri_Private_Static_Void_DateTime_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x0014E0FC File Offset: 0x0014C2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411467, XrefRangeEnd = 1411480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetDatePart(DateTime time, int part)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref part;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_DateTime_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x0014E160 File Offset: 0x0014C360
		[CallerCount(0)]
		public unsafe override int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x0014E1B4 File Offset: 0x0014C3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411480, XrefRangeEnd = 1411484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DayOfWeek GetDayOfWeek(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x0014E208 File Offset: 0x0014C408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411484, XrefRangeEnd = 1411489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDaysInMonth(int year, int month, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x0014E278 File Offset: 0x0014C478
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411493, RefRangeEnd = 1411495, XrefRangeStart = 1411489, XrefRangeEnd = 1411493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RealGetDaysInYear(int year)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.NativeMethodInfoPtr_RealGetDaysInYear_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x0014E2B8 File Offset: 0x0014C4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411495, XrefRangeEnd = 1411500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDaysInYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x0014E31C File Offset: 0x0014C51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411500, XrefRangeEnd = 1411508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x06004793 RID: 18323 RVA: 0x0014E370 File Offset: 0x0014C570
		public unsafe override Il2CppStructArray<int> Eras
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411508, XrefRangeEnd = 1411511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x0014E3BC File Offset: 0x0014C5BC
		[CallerCount(0)]
		public unsafe override int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x0014E410 File Offset: 0x0014C610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411511, XrefRangeEnd = 1411515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetMonthsInYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x0014E474 File Offset: 0x0014C674
		[CallerCount(0)]
		public unsafe override int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x0014E4C8 File Offset: 0x0014C6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411515, XrefRangeEnd = 1411520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsLeapYear(int year, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x0014E52C File Offset: 0x0014C72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411520, XrefRangeEnd = 1411530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x0014E5E4 File Offset: 0x0014C7E4
		// (set) Token: 0x0600479A RID: 18330 RVA: 0x0014E62C File Offset: 0x0014C82C
		public unsafe override int TwoDigitYearMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411530, XrefRangeEnd = 1411531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_set_TwoDigitYearMax_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x0014E678 File Offset: 0x0014C878
		[CallerCount(0)]
		public unsafe override int ToFourDigitYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UmAlQuraCalendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x00019FBE File Offset: 0x000181BE
		public UmAlQuraCalendar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x0600479D RID: 18333 RVA: 0x0014E6CC File Offset: 0x0014C8CC
		// (set) Token: 0x0600479E RID: 18334 RVA: 0x00019FC7 File Offset: 0x000181C7
		public unsafe static Il2CppStructArray<UmAlQuraCalendar.DateMapping> HijriYearInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UmAlQuraCalendar.NativeFieldInfoPtr_HijriYearInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UmAlQuraCalendar.DateMapping>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UmAlQuraCalendar.NativeFieldInfoPtr_HijriYearInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x0600479F RID: 18335 RVA: 0x0014E6F4 File Offset: 0x0014C8F4
		// (set) Token: 0x060047A0 RID: 18336 RVA: 0x00019FD9 File Offset: 0x000181D9
		public unsafe static DateTime minDate
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(UmAlQuraCalendar.NativeFieldInfoPtr_minDate, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UmAlQuraCalendar.NativeFieldInfoPtr_minDate, (void*)(&value));
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060047A1 RID: 18337 RVA: 0x0014E710 File Offset: 0x0014C910
		// (set) Token: 0x060047A2 RID: 18338 RVA: 0x00019FE7 File Offset: 0x000181E7
		public unsafe static DateTime maxDate
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(UmAlQuraCalendar.NativeFieldInfoPtr_maxDate, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UmAlQuraCalendar.NativeFieldInfoPtr_maxDate, (void*)(&value));
			}
		}

		// Token: 0x04003AED RID: 15085
		private static readonly IntPtr NativeFieldInfoPtr_HijriYearInfo;

		// Token: 0x04003AEE RID: 15086
		private static readonly IntPtr NativeFieldInfoPtr_minDate;

		// Token: 0x04003AEF RID: 15087
		private static readonly IntPtr NativeFieldInfoPtr_maxDate;

		// Token: 0x04003AF0 RID: 15088
		private static readonly IntPtr NativeMethodInfoPtr_InitDateMapping_Private_Static_Il2CppStructArray_1_DateMapping_0;

		// Token: 0x04003AF1 RID: 15089
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04003AF2 RID: 15090
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04003AF3 RID: 15091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003AF4 RID: 15092
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_get_Int32_0;

		// Token: 0x04003AF5 RID: 15093
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Internal_Virtual_get_Int32_0;

		// Token: 0x04003AF6 RID: 15094
		private static readonly IntPtr NativeMethodInfoPtr_ConvertHijriToGregorian_Private_Static_Void_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04003AF7 RID: 15095
		private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteDateUmAlQura_Private_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04003AF8 RID: 15096
		private static readonly IntPtr NativeMethodInfoPtr_CheckTicksRange_Internal_Static_Void_Int64_0;

		// Token: 0x04003AF9 RID: 15097
		private static readonly IntPtr NativeMethodInfoPtr_CheckEraRange_Internal_Static_Void_Int32_0;

		// Token: 0x04003AFA RID: 15098
		private static readonly IntPtr NativeMethodInfoPtr_CheckYearRange_Internal_Static_Void_Int32_Int32_0;

		// Token: 0x04003AFB RID: 15099
		private static readonly IntPtr NativeMethodInfoPtr_CheckYearMonthRange_Internal_Static_Void_Int32_Int32_Int32_0;

		// Token: 0x04003AFC RID: 15100
		private static readonly IntPtr NativeMethodInfoPtr_ConvertGregorianToHijri_Private_Static_Void_DateTime_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04003AFD RID: 15101
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_DateTime_Int32_0;

		// Token: 0x04003AFE RID: 15102
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04003AFF RID: 15103
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_Virtual_DayOfWeek_DateTime_0;

		// Token: 0x04003B00 RID: 15104
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Virtual_Int32_Int32_Int32_Int32_0;

		// Token: 0x04003B01 RID: 15105
		private static readonly IntPtr NativeMethodInfoPtr_RealGetDaysInYear_Internal_Static_Int32_Int32_0;

		// Token: 0x04003B02 RID: 15106
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04003B03 RID: 15107
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04003B04 RID: 15108
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003B05 RID: 15109
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04003B06 RID: 15110
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04003B07 RID: 15111
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04003B08 RID: 15112
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Virtual_Boolean_Int32_Int32_0;

		// Token: 0x04003B09 RID: 15113
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04003B0A RID: 15114
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_get_Int32_0;

		// Token: 0x04003B0B RID: 15115
		private static readonly IntPtr NativeMethodInfoPtr_set_TwoDigitYearMax_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04003B0C RID: 15116
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_Int32_Int32_0;

		// Token: 0x020006D8 RID: 1752
		[StructLayout(2)]
		public struct DateMapping
		{
			// Token: 0x06005D53 RID: 23891 RVA: 0x001A6370 File Offset: 0x001A4570
			// Note: this type is marked as 'beforefieldinit'.
			static DateMapping()
			{
				Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UmAlQuraCalendar>.NativeClassPtr, "DateMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr);
				UmAlQuraCalendar.DateMapping.NativeFieldInfoPtr_HijriMonthsLengthFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr, "HijriMonthsLengthFlags");
				UmAlQuraCalendar.DateMapping.NativeFieldInfoPtr_GregorianDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr, "GregorianDate");
				UmAlQuraCalendar.DateMapping.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr, 100673810);
			}

			// Token: 0x06005D54 RID: 23892 RVA: 0x001A63D8 File Offset: 0x001A45D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411350, XrefRangeEnd = 1411351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref MonthsLengthFlags;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref GYear;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref GMonth;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref GDay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UmAlQuraCalendar.DateMapping.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005D55 RID: 23893 RVA: 0x0002213F File Offset: 0x0002033F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UmAlQuraCalendar.DateMapping>.NativeClassPtr, ref this));
			}

			// Token: 0x04004BE1 RID: 19425
			private static readonly IntPtr NativeFieldInfoPtr_HijriMonthsLengthFlags;

			// Token: 0x04004BE2 RID: 19426
			private static readonly IntPtr NativeFieldInfoPtr_GregorianDate;

			// Token: 0x04004BE3 RID: 19427
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0;

			// Token: 0x04004BE4 RID: 19428
			[FieldOffset(0)]
			public int HijriMonthsLengthFlags;

			// Token: 0x04004BE5 RID: 19429
			[FieldOffset(8)]
			public DateTime GregorianDate;
		}
	}
}
