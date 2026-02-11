using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000483 RID: 1155
	[Serializable]
	public class GregorianCalendarHelper : Object
	{
		// Token: 0x0600462E RID: 17966 RVA: 0x001483DC File Offset: 0x001465DC
		// Note: this type is marked as 'beforefieldinit'.
		static GregorianCalendarHelper()
		{
			Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "GregorianCalendarHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr);
			GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth365 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "DaysToMonth365");
			GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth366 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "DaysToMonth366");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_maxYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_maxYear");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_minYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_minYear");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_Cal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_Cal");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_EraInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_EraInfo");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_eras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_eras");
			GregorianCalendarHelper.NativeFieldInfoPtr_m_minDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, "m_minDate");
			GregorianCalendarHelper.NativeMethodInfoPtr_get_MaxYear_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673595);
			GregorianCalendarHelper.NativeMethodInfoPtr__ctor_Internal_Void_Calendar_Il2CppReferenceArray_1_EraInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673596);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetYearOffset_Private_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673597);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetGregorianYear_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673598);
			GregorianCalendarHelper.NativeMethodInfoPtr_IsValidYear_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673599);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673600);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673601);
			GregorianCalendarHelper.NativeMethodInfoPtr_DateToTicks_Internal_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673602);
			GregorianCalendarHelper.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673603);
			GregorianCalendarHelper.NativeMethodInfoPtr_CheckTicksRange_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673604);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfMonth_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673605);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfWeek_Public_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673606);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInMonth_Public_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673607);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInYear_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673608);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetEra_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673609);
			GregorianCalendarHelper.NativeMethodInfoPtr_get_Eras_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673610);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetMonth_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673611);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetMonthsInYear_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673612);
			GregorianCalendarHelper.NativeMethodInfoPtr_GetYear_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673613);
			GregorianCalendarHelper.NativeMethodInfoPtr_IsLeapYear_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673614);
			GregorianCalendarHelper.NativeMethodInfoPtr_ToDateTime_Public_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673615);
			GregorianCalendarHelper.NativeMethodInfoPtr_ToFourDigitYear_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr, 100673616);
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x0600462F RID: 17967 RVA: 0x00148664 File Offset: 0x00146864
		public unsafe int MaxYear
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_get_MaxYear_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x001486A0 File Offset: 0x001468A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410233, RefRangeEnd = 1410236, XrefRangeStart = 1410230, XrefRangeEnd = 1410233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GregorianCalendarHelper(Calendar cal, Il2CppReferenceArray<EraInfo> eraInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GregorianCalendarHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eraInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr__ctor_Internal_Void_Calendar_Il2CppReferenceArray_1_EraInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00148700 File Offset: 0x00146900
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1410240, RefRangeEnd = 1410251, XrefRangeStart = 1410236, XrefRangeEnd = 1410240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetYearOffset(int year, int era, bool throwOnError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetYearOffset_Private_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x00148768 File Offset: 0x00146968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410251, XrefRangeEnd = 1410252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGregorianYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetGregorianYear_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x001487C0 File Offset: 0x001469C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410252, XrefRangeEnd = 1410253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_IsValidYear_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00148818 File Offset: 0x00146A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410253, XrefRangeEnd = 1410263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetDatePart(long ticks, int part)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref part;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GregorianCalendarHelper.NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x0014887C File Offset: 0x00146A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1410271, RefRangeEnd = 1410273, XrefRangeStart = 1410263, XrefRangeEnd = 1410271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetAbsoluteDate(int year, int month, int day)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x001488D8 File Offset: 0x00146AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410273, XrefRangeEnd = 1410277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DateToTicks(int year, int month, int day)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_DateToTicks_Internal_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x00148934 File Offset: 0x00146B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410281, RefRangeEnd = 1410282, XrefRangeStart = 1410277, XrefRangeEnd = 1410281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hour;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x0014899C File Offset: 0x00146B9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410289, RefRangeEnd = 1410292, XrefRangeStart = 1410282, XrefRangeEnd = 1410289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTicksRange(long ticks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_CheckTicksRange_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x001489DC File Offset: 0x00146BDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410296, RefRangeEnd = 1410299, XrefRangeStart = 1410292, XrefRangeEnd = 1410296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfMonth_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x00148A28 File Offset: 0x00146C28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410305, RefRangeEnd = 1410308, XrefRangeStart = 1410299, XrefRangeEnd = 1410305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DayOfWeek GetDayOfWeek(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDayOfWeek_Public_DayOfWeek_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x00148A74 File Offset: 0x00146C74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410317, RefRangeEnd = 1410320, XrefRangeStart = 1410308, XrefRangeEnd = 1410317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDaysInMonth(int year, int month, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInMonth_Public_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x00148ADC File Offset: 0x00146CDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410321, RefRangeEnd = 1410324, XrefRangeStart = 1410320, XrefRangeEnd = 1410321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDaysInYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetDaysInYear_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x00148B34 File Offset: 0x00146D34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410329, RefRangeEnd = 1410332, XrefRangeStart = 1410324, XrefRangeEnd = 1410329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetEra_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x0600463E RID: 17982 RVA: 0x00148B80 File Offset: 0x00146D80
		public unsafe Il2CppStructArray<int> Eras
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1410340, RefRangeEnd = 1410343, XrefRangeStart = 1410332, XrefRangeEnd = 1410340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_get_Eras_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x00148BC0 File Offset: 0x00146DC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410347, RefRangeEnd = 1410350, XrefRangeStart = 1410343, XrefRangeEnd = 1410347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetMonth_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x00148C0C File Offset: 0x00146E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410350, XrefRangeEnd = 1410351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMonthsInYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetMonthsInYear_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x00148C64 File Offset: 0x00146E64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410356, RefRangeEnd = 1410359, XrefRangeStart = 1410351, XrefRangeEnd = 1410356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_GetYear_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00148CB0 File Offset: 0x00146EB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410360, RefRangeEnd = 1410363, XrefRangeStart = 1410359, XrefRangeEnd = 1410360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLeapYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_IsLeapYear_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00148D08 File Offset: 0x00146F08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1410374, RefRangeEnd = 1410377, XrefRangeStart = 1410363, XrefRangeEnd = 1410374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_ToDateTime_Public_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00148DB4 File Offset: 0x00146FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410377, RefRangeEnd = 1410378, XrefRangeStart = 1410377, XrefRangeEnd = 1410377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ToFourDigitYear(int year, int twoDigitYearMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref twoDigitYearMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GregorianCalendarHelper.NativeMethodInfoPtr_ToFourDigitYear_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x0001982C File Offset: 0x00017A2C
		public GregorianCalendarHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06004646 RID: 17990 RVA: 0x00148E0C File Offset: 0x0014700C
		// (set) Token: 0x06004647 RID: 17991 RVA: 0x00019835 File Offset: 0x00017A35
		public unsafe static Il2CppStructArray<int> DaysToMonth365
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth365, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth365, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06004648 RID: 17992 RVA: 0x00148E34 File Offset: 0x00147034
		// (set) Token: 0x06004649 RID: 17993 RVA: 0x00019847 File Offset: 0x00017A47
		public unsafe static Il2CppStructArray<int> DaysToMonth366
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth366, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GregorianCalendarHelper.NativeFieldInfoPtr_DaysToMonth366, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x0600464A RID: 17994 RVA: 0x00148E5C File Offset: 0x0014705C
		// (set) Token: 0x0600464B RID: 17995 RVA: 0x00019859 File Offset: 0x00017A59
		public unsafe int m_maxYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_maxYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_maxYear)) = value;
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x0600464C RID: 17996 RVA: 0x00148E84 File Offset: 0x00147084
		// (set) Token: 0x0600464D RID: 17997 RVA: 0x00019874 File Offset: 0x00017A74
		public unsafe int m_minYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minYear)) = value;
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x0600464E RID: 17998 RVA: 0x00148EAC File Offset: 0x001470AC
		// (set) Token: 0x0600464F RID: 17999 RVA: 0x0001988F File Offset: 0x00017A8F
		public unsafe Calendar m_Cal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_Cal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_Cal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06004650 RID: 18000 RVA: 0x00148EDC File Offset: 0x001470DC
		// (set) Token: 0x06004651 RID: 18001 RVA: 0x000198AE File Offset: 0x00017AAE
		public unsafe Il2CppReferenceArray<EraInfo> m_EraInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_EraInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EraInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_EraInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06004652 RID: 18002 RVA: 0x00148F0C File Offset: 0x0014710C
		// (set) Token: 0x06004653 RID: 18003 RVA: 0x000198CD File Offset: 0x00017ACD
		public unsafe Il2CppStructArray<int> m_eras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_eras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_eras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06004654 RID: 18004 RVA: 0x00148F3C File Offset: 0x0014713C
		// (set) Token: 0x06004655 RID: 18005 RVA: 0x000198EC File Offset: 0x00017AEC
		public unsafe DateTime m_minDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GregorianCalendarHelper.NativeFieldInfoPtr_m_minDate)) = value;
			}
		}

		// Token: 0x040039EB RID: 14827
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth365;

		// Token: 0x040039EC RID: 14828
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth366;

		// Token: 0x040039ED RID: 14829
		private static readonly IntPtr NativeFieldInfoPtr_m_maxYear;

		// Token: 0x040039EE RID: 14830
		private static readonly IntPtr NativeFieldInfoPtr_m_minYear;

		// Token: 0x040039EF RID: 14831
		private static readonly IntPtr NativeFieldInfoPtr_m_Cal;

		// Token: 0x040039F0 RID: 14832
		private static readonly IntPtr NativeFieldInfoPtr_m_EraInfo;

		// Token: 0x040039F1 RID: 14833
		private static readonly IntPtr NativeFieldInfoPtr_m_eras;

		// Token: 0x040039F2 RID: 14834
		private static readonly IntPtr NativeFieldInfoPtr_m_minDate;

		// Token: 0x040039F3 RID: 14835
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxYear_Internal_get_Int32_0;

		// Token: 0x040039F4 RID: 14836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Calendar_Il2CppReferenceArray_1_EraInfo_0;

		// Token: 0x040039F5 RID: 14837
		private static readonly IntPtr NativeMethodInfoPtr_GetYearOffset_Private_Int32_Int32_Int32_Boolean_0;

		// Token: 0x040039F6 RID: 14838
		private static readonly IntPtr NativeMethodInfoPtr_GetGregorianYear_Internal_Int32_Int32_Int32_0;

		// Token: 0x040039F7 RID: 14839
		private static readonly IntPtr NativeMethodInfoPtr_IsValidYear_Internal_Boolean_Int32_Int32_0;

		// Token: 0x040039F8 RID: 14840
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Internal_Virtual_New_Int32_Int64_Int32_0;

		// Token: 0x040039F9 RID: 14841
		private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteDate_Internal_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x040039FA RID: 14842
		private static readonly IntPtr NativeMethodInfoPtr_DateToTicks_Internal_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x040039FB RID: 14843
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0;

		// Token: 0x040039FC RID: 14844
		private static readonly IntPtr NativeMethodInfoPtr_CheckTicksRange_Internal_Void_Int64_0;

		// Token: 0x040039FD RID: 14845
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Int32_DateTime_0;

		// Token: 0x040039FE RID: 14846
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_DayOfWeek_DateTime_0;

		// Token: 0x040039FF RID: 14847
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Int32_Int32_Int32_Int32_0;

		// Token: 0x04003A00 RID: 14848
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Int32_Int32_Int32_0;

		// Token: 0x04003A01 RID: 14849
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Int32_DateTime_0;

		// Token: 0x04003A02 RID: 14850
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003A03 RID: 14851
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Int32_DateTime_0;

		// Token: 0x04003A04 RID: 14852
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Int32_Int32_Int32_0;

		// Token: 0x04003A05 RID: 14853
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Int32_DateTime_0;

		// Token: 0x04003A06 RID: 14854
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Boolean_Int32_Int32_0;

		// Token: 0x04003A07 RID: 14855
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04003A08 RID: 14856
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Int32_Int32_Int32_0;
	}
}
