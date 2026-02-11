using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200047F RID: 1151
	[Serializable]
	public class Calendar : Object
	{
		// Token: 0x06004548 RID: 17736 RVA: 0x001454B8 File Offset: 0x001436B8
		// Note: this type is marked as 'beforefieldinit'.
		static Calendar()
		{
			Il2CppClassPointerStore<Calendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "Calendar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Calendar>.NativeClassPtr);
			Calendar.NativeFieldInfoPtr_TicksPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerMillisecond");
			Calendar.NativeFieldInfoPtr_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerSecond");
			Calendar.NativeFieldInfoPtr_TicksPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerMinute");
			Calendar.NativeFieldInfoPtr_TicksPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerHour");
			Calendar.NativeFieldInfoPtr_TicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "TicksPerDay");
			Calendar.NativeFieldInfoPtr_MillisPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerSecond");
			Calendar.NativeFieldInfoPtr_MillisPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerMinute");
			Calendar.NativeFieldInfoPtr_MillisPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerHour");
			Calendar.NativeFieldInfoPtr_MillisPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MillisPerDay");
			Calendar.NativeFieldInfoPtr_DaysPerYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPerYear");
			Calendar.NativeFieldInfoPtr_DaysPer4Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPer4Years");
			Calendar.NativeFieldInfoPtr_DaysPer100Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPer100Years");
			Calendar.NativeFieldInfoPtr_DaysPer400Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysPer400Years");
			Calendar.NativeFieldInfoPtr_DaysTo10000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "DaysTo10000");
			Calendar.NativeFieldInfoPtr_MaxMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "MaxMillis");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_US = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_US");
			Calendar.NativeFieldInfoPtr_CAL_JAPAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_JAPAN");
			Calendar.NativeFieldInfoPtr_CAL_TAIWAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_TAIWAN");
			Calendar.NativeFieldInfoPtr_CAL_KOREA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_KOREA");
			Calendar.NativeFieldInfoPtr_CAL_HIJRI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_HIJRI");
			Calendar.NativeFieldInfoPtr_CAL_THAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_THAI");
			Calendar.NativeFieldInfoPtr_CAL_HEBREW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_HEBREW");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_ME_FRENCH");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_ARABIC");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_XLIT_ENGLISH");
			Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_GREGORIAN_XLIT_FRENCH");
			Calendar.NativeFieldInfoPtr_CAL_JULIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_JULIAN");
			Calendar.NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_JAPANESELUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_CHINESELUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_CHINESELUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_SAKA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_SAKA");
			Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_LUNAR_ETO_CHN");
			Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_LUNAR_ETO_KOR");
			Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_LUNAR_ETO_ROKUYOU");
			Calendar.NativeFieldInfoPtr_CAL_KOREANLUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_KOREANLUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_TAIWANLUNISOLAR");
			Calendar.NativeFieldInfoPtr_CAL_PERSIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_PERSIAN");
			Calendar.NativeFieldInfoPtr_CAL_UMALQURA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CAL_UMALQURA");
			Calendar.NativeFieldInfoPtr_m_currentEraValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "m_currentEraValue");
			Calendar.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "m_isReadOnly");
			Calendar.NativeFieldInfoPtr_CurrentEra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "CurrentEra");
			Calendar.NativeFieldInfoPtr_twoDigitYearMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calendar>.NativeClassPtr, "twoDigitYearMax");
			Calendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673525);
			Calendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673526);
			Calendar.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673527);
			Calendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673528);
			Calendar.NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673529);
			Calendar.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673530);
			Calendar.NativeMethodInfoPtr_VerifyWritable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673531);
			Calendar.NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673532);
			Calendar.NativeMethodInfoPtr_get_CurrentEraValue_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673533);
			Calendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673534);
			Calendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Abstract_Virtual_New_DayOfWeek_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673535);
			Calendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673536);
			Calendar.NativeMethodInfoPtr_GetDaysInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673537);
			Calendar.NativeMethodInfoPtr_GetEra_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673538);
			Calendar.NativeMethodInfoPtr_get_Eras_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673539);
			Calendar.NativeMethodInfoPtr_GetMonth_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673540);
			Calendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673541);
			Calendar.NativeMethodInfoPtr_GetYear_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673542);
			Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673543);
			Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673544);
			Calendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673545);
			Calendar.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673546);
			Calendar.NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673547);
			Calendar.NativeMethodInfoPtr_IsValidYear_Internal_Virtual_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673548);
			Calendar.NativeMethodInfoPtr_IsValidMonth_Internal_Virtual_New_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673549);
			Calendar.NativeMethodInfoPtr_IsValidDay_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673550);
			Calendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673551);
			Calendar.NativeMethodInfoPtr_set_TwoDigitYearMax_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673552);
			Calendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673553);
			Calendar.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673554);
			Calendar.NativeMethodInfoPtr_GetSystemTwoDigitYearSetting_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calendar>.NativeClassPtr, 100673555);
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x00145A9C File Offset: 0x00143C9C
		public unsafe virtual DateTime MinSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409772, XrefRangeEnd = 1409776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x0600454A RID: 17738 RVA: 0x00145AE4 File Offset: 0x00143CE4
		public unsafe virtual DateTime MaxSupportedDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409776, XrefRangeEnd = 1409780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x00145B2C File Offset: 0x00143D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409780, XrefRangeEnd = 1409781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Calendar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Calendar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x0600454C RID: 17740 RVA: 0x00145B68 File Offset: 0x00143D68
		public unsafe virtual int ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_ID_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x00145BB0 File Offset: 0x00143DB0
		public unsafe virtual int BaseCalendarID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 373605, RefRangeEnd = 373608, XrefRangeStart = 373605, XrefRangeEnd = 373608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00145BF8 File Offset: 0x00143DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409781, XrefRangeEnd = 1409784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00145C44 File Offset: 0x00143E44
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1409784, RefRangeEnd = 1409791, XrefRangeStart = 1409784, XrefRangeEnd = 1409784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyWritable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr_VerifyWritable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x00145C78 File Offset: 0x00143E78
		[CallerCount(0)]
		public unsafe void SetReadOnlyState(bool readOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06004551 RID: 17745 RVA: 0x00145CB8 File Offset: 0x00143EB8
		public unsafe virtual int CurrentEraValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409791, XrefRangeEnd = 1409831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_CurrentEraValue_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00145D00 File Offset: 0x00143F00
		[CallerCount(0)]
		public unsafe virtual int GetDayOfMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDayOfMonth_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00145D54 File Offset: 0x00143F54
		[CallerCount(0)]
		public unsafe virtual DayOfWeek GetDayOfWeek(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDayOfWeek_Public_Abstract_Virtual_New_DayOfWeek_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00145DA8 File Offset: 0x00143FA8
		[CallerCount(0)]
		public unsafe virtual int GetDaysInMonth(int year, int month, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDaysInMonth_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00145E18 File Offset: 0x00144018
		[CallerCount(0)]
		public unsafe virtual int GetDaysInYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetDaysInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00145E7C File Offset: 0x0014407C
		[CallerCount(0)]
		public unsafe virtual int GetEra(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetEra_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06004557 RID: 17751 RVA: 0x00145ED0 File Offset: 0x001440D0
		public unsafe virtual Il2CppStructArray<int> Eras
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_Eras_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00145F1C File Offset: 0x0014411C
		[CallerCount(0)]
		public unsafe virtual int GetMonth(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetMonth_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00145F70 File Offset: 0x00144170
		[CallerCount(0)]
		public unsafe virtual int GetMonthsInYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetMonthsInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00145FD4 File Offset: 0x001441D4
		[CallerCount(0)]
		public unsafe virtual int GetYear(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_GetYear_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00146028 File Offset: 0x00144228
		[CallerCount(0)]
		public unsafe virtual bool IsLeapYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x0014607C File Offset: 0x0014427C
		[CallerCount(0)]
		public unsafe virtual bool IsLeapYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsLeapYear_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x001460E0 File Offset: 0x001442E0
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_ToDateTime_Public_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00146188 File Offset: 0x00144388
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x00146240 File Offset: 0x00144440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409831, XrefRangeEnd = 1409836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x00146308 File Offset: 0x00144508
		[CallerCount(0)]
		public unsafe virtual bool IsValidYear(int year, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsValidYear_Internal_Virtual_New_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x0014636C File Offset: 0x0014456C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409836, XrefRangeEnd = 1409837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidMonth(int year, int month, int era)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsValidMonth_Internal_Virtual_New_Boolean_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x001463DC File Offset: 0x001445DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409837, XrefRangeEnd = 1409838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidDay(int year, int month, int day, int era)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref era;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_IsValidDay_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06004563 RID: 17763 RVA: 0x0014645C File Offset: 0x0014465C
		// (set) Token: 0x06004564 RID: 17764 RVA: 0x001464A4 File Offset: 0x001446A4
		public unsafe virtual int TwoDigitYearMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409838, XrefRangeEnd = 1409839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_set_TwoDigitYearMax_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x001464F0 File Offset: 0x001446F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409839, RefRangeEnd = 1409840, XrefRangeStart = 1409839, XrefRangeEnd = 1409839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ToFourDigitYear(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Calendar.NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x00146544 File Offset: 0x00144744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1409844, RefRangeEnd = 1409846, XrefRangeStart = 1409840, XrefRangeEnd = 1409844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x001465AC File Offset: 0x001447AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409846, XrefRangeEnd = 1409849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref CalID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultYearValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Calendar.NativeMethodInfoPtr_GetSystemTwoDigitYearSetting_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x000191DB File Offset: 0x000173DB
		public Calendar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x001465F8 File Offset: 0x001447F8
		// (set) Token: 0x0600456A RID: 17770 RVA: 0x000191E4 File Offset: 0x000173E4
		public unsafe static long TicksPerMillisecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x0600456B RID: 17771 RVA: 0x00146614 File Offset: 0x00144814
		// (set) Token: 0x0600456C RID: 17772 RVA: 0x000191F2 File Offset: 0x000173F2
		public unsafe static long TicksPerSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x0600456D RID: 17773 RVA: 0x00146630 File Offset: 0x00144830
		// (set) Token: 0x0600456E RID: 17774 RVA: 0x00019200 File Offset: 0x00017400
		public unsafe static long TicksPerMinute
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerMinute, (void*)(&value));
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x0600456F RID: 17775 RVA: 0x0014664C File Offset: 0x0014484C
		// (set) Token: 0x06004570 RID: 17776 RVA: 0x0001920E File Offset: 0x0001740E
		public unsafe static long TicksPerHour
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerHour, (void*)(&value));
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06004571 RID: 17777 RVA: 0x00146668 File Offset: 0x00144868
		// (set) Token: 0x06004572 RID: 17778 RVA: 0x0001921C File Offset: 0x0001741C
		public unsafe static long TicksPerDay
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_TicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_TicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06004573 RID: 17779 RVA: 0x00146684 File Offset: 0x00144884
		// (set) Token: 0x06004574 RID: 17780 RVA: 0x0001922A File Offset: 0x0001742A
		public unsafe static int MillisPerSecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerSecond, (void*)(&value));
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06004575 RID: 17781 RVA: 0x001466A0 File Offset: 0x001448A0
		// (set) Token: 0x06004576 RID: 17782 RVA: 0x00019238 File Offset: 0x00017438
		public unsafe static int MillisPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerMinute, (void*)(&value));
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06004577 RID: 17783 RVA: 0x001466BC File Offset: 0x001448BC
		// (set) Token: 0x06004578 RID: 17784 RVA: 0x00019246 File Offset: 0x00017446
		public unsafe static int MillisPerHour
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerHour, (void*)(&value));
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x001466D8 File Offset: 0x001448D8
		// (set) Token: 0x0600457A RID: 17786 RVA: 0x00019254 File Offset: 0x00017454
		public unsafe static int MillisPerDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MillisPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MillisPerDay, (void*)(&value));
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x001466F4 File Offset: 0x001448F4
		// (set) Token: 0x0600457C RID: 17788 RVA: 0x00019262 File Offset: 0x00017462
		public unsafe static int DaysPerYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPerYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPerYear, (void*)(&value));
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x0600457D RID: 17789 RVA: 0x00146710 File Offset: 0x00144910
		// (set) Token: 0x0600457E RID: 17790 RVA: 0x00019270 File Offset: 0x00017470
		public unsafe static int DaysPer4Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPer4Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPer4Years, (void*)(&value));
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x0014672C File Offset: 0x0014492C
		// (set) Token: 0x06004580 RID: 17792 RVA: 0x0001927E File Offset: 0x0001747E
		public unsafe static int DaysPer100Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPer100Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPer100Years, (void*)(&value));
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06004581 RID: 17793 RVA: 0x00146748 File Offset: 0x00144948
		// (set) Token: 0x06004582 RID: 17794 RVA: 0x0001928C File Offset: 0x0001748C
		public unsafe static int DaysPer400Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysPer400Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysPer400Years, (void*)(&value));
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06004583 RID: 17795 RVA: 0x00146764 File Offset: 0x00144964
		// (set) Token: 0x06004584 RID: 17796 RVA: 0x0001929A File Offset: 0x0001749A
		public unsafe static int DaysTo10000
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_DaysTo10000, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_DaysTo10000, (void*)(&value));
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06004585 RID: 17797 RVA: 0x00146780 File Offset: 0x00144980
		// (set) Token: 0x06004586 RID: 17798 RVA: 0x000192A8 File Offset: 0x000174A8
		public unsafe static long MaxMillis
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_MaxMillis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_MaxMillis, (void*)(&value));
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06004587 RID: 17799 RVA: 0x0014679C File Offset: 0x0014499C
		// (set) Token: 0x06004588 RID: 17800 RVA: 0x000192B6 File Offset: 0x000174B6
		public unsafe static int CAL_GREGORIAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN, (void*)(&value));
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06004589 RID: 17801 RVA: 0x001467B8 File Offset: 0x001449B8
		// (set) Token: 0x0600458A RID: 17802 RVA: 0x000192C4 File Offset: 0x000174C4
		public unsafe static int CAL_GREGORIAN_US
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_US, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_US, (void*)(&value));
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x0600458B RID: 17803 RVA: 0x001467D4 File Offset: 0x001449D4
		// (set) Token: 0x0600458C RID: 17804 RVA: 0x000192D2 File Offset: 0x000174D2
		public unsafe static int CAL_JAPAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_JAPAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_JAPAN, (void*)(&value));
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x001467F0 File Offset: 0x001449F0
		// (set) Token: 0x0600458E RID: 17806 RVA: 0x000192E0 File Offset: 0x000174E0
		public unsafe static int CAL_TAIWAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_TAIWAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_TAIWAN, (void*)(&value));
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x0600458F RID: 17807 RVA: 0x0014680C File Offset: 0x00144A0C
		// (set) Token: 0x06004590 RID: 17808 RVA: 0x000192EE File Offset: 0x000174EE
		public unsafe static int CAL_KOREA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_KOREA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_KOREA, (void*)(&value));
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x00146828 File Offset: 0x00144A28
		// (set) Token: 0x06004592 RID: 17810 RVA: 0x000192FC File Offset: 0x000174FC
		public unsafe static int CAL_HIJRI
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_HIJRI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_HIJRI, (void*)(&value));
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x00146844 File Offset: 0x00144A44
		// (set) Token: 0x06004594 RID: 17812 RVA: 0x0001930A File Offset: 0x0001750A
		public unsafe static int CAL_THAI
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_THAI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_THAI, (void*)(&value));
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x00146860 File Offset: 0x00144A60
		// (set) Token: 0x06004596 RID: 17814 RVA: 0x00019318 File Offset: 0x00017518
		public unsafe static int CAL_HEBREW
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_HEBREW, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_HEBREW, (void*)(&value));
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x0014687C File Offset: 0x00144A7C
		// (set) Token: 0x06004598 RID: 17816 RVA: 0x00019326 File Offset: 0x00017526
		public unsafe static int CAL_GREGORIAN_ME_FRENCH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH, (void*)(&value));
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06004599 RID: 17817 RVA: 0x00146898 File Offset: 0x00144A98
		// (set) Token: 0x0600459A RID: 17818 RVA: 0x00019334 File Offset: 0x00017534
		public unsafe static int CAL_GREGORIAN_ARABIC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC, (void*)(&value));
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x0600459B RID: 17819 RVA: 0x001468B4 File Offset: 0x00144AB4
		// (set) Token: 0x0600459C RID: 17820 RVA: 0x00019342 File Offset: 0x00017542
		public unsafe static int CAL_GREGORIAN_XLIT_ENGLISH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH, (void*)(&value));
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x001468D0 File Offset: 0x00144AD0
		// (set) Token: 0x0600459E RID: 17822 RVA: 0x00019350 File Offset: 0x00017550
		public unsafe static int CAL_GREGORIAN_XLIT_FRENCH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH, (void*)(&value));
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x001468EC File Offset: 0x00144AEC
		// (set) Token: 0x060045A0 RID: 17824 RVA: 0x0001935E File Offset: 0x0001755E
		public unsafe static int CAL_JULIAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_JULIAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_JULIAN, (void*)(&value));
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x060045A1 RID: 17825 RVA: 0x00146908 File Offset: 0x00144B08
		// (set) Token: 0x060045A2 RID: 17826 RVA: 0x0001936C File Offset: 0x0001756C
		public unsafe static int CAL_JAPANESELUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x00146924 File Offset: 0x00144B24
		// (set) Token: 0x060045A4 RID: 17828 RVA: 0x0001937A File Offset: 0x0001757A
		public unsafe static int CAL_CHINESELUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_CHINESELUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_CHINESELUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x00146940 File Offset: 0x00144B40
		// (set) Token: 0x060045A6 RID: 17830 RVA: 0x00019388 File Offset: 0x00017588
		public unsafe static int CAL_SAKA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_SAKA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_SAKA, (void*)(&value));
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x060045A7 RID: 17831 RVA: 0x0014695C File Offset: 0x00144B5C
		// (set) Token: 0x060045A8 RID: 17832 RVA: 0x00019396 File Offset: 0x00017596
		public unsafe static int CAL_LUNAR_ETO_CHN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN, (void*)(&value));
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x00146978 File Offset: 0x00144B78
		// (set) Token: 0x060045AA RID: 17834 RVA: 0x000193A4 File Offset: 0x000175A4
		public unsafe static int CAL_LUNAR_ETO_KOR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR, (void*)(&value));
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x060045AB RID: 17835 RVA: 0x00146994 File Offset: 0x00144B94
		// (set) Token: 0x060045AC RID: 17836 RVA: 0x000193B2 File Offset: 0x000175B2
		public unsafe static int CAL_LUNAR_ETO_ROKUYOU
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU, (void*)(&value));
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x060045AD RID: 17837 RVA: 0x001469B0 File Offset: 0x00144BB0
		// (set) Token: 0x060045AE RID: 17838 RVA: 0x000193C0 File Offset: 0x000175C0
		public unsafe static int CAL_KOREANLUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_KOREANLUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_KOREANLUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x060045AF RID: 17839 RVA: 0x001469CC File Offset: 0x00144BCC
		// (set) Token: 0x060045B0 RID: 17840 RVA: 0x000193CE File Offset: 0x000175CE
		public unsafe static int CAL_TAIWANLUNISOLAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR, (void*)(&value));
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x060045B1 RID: 17841 RVA: 0x001469E8 File Offset: 0x00144BE8
		// (set) Token: 0x060045B2 RID: 17842 RVA: 0x000193DC File Offset: 0x000175DC
		public unsafe static int CAL_PERSIAN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_PERSIAN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_PERSIAN, (void*)(&value));
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x060045B3 RID: 17843 RVA: 0x00146A04 File Offset: 0x00144C04
		// (set) Token: 0x060045B4 RID: 17844 RVA: 0x000193EA File Offset: 0x000175EA
		public unsafe static int CAL_UMALQURA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CAL_UMALQURA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CAL_UMALQURA, (void*)(&value));
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x060045B5 RID: 17845 RVA: 0x00146A20 File Offset: 0x00144C20
		// (set) Token: 0x060045B6 RID: 17846 RVA: 0x000193F8 File Offset: 0x000175F8
		public unsafe int m_currentEraValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_currentEraValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_currentEraValue)) = value;
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x060045B7 RID: 17847 RVA: 0x00146A48 File Offset: 0x00144C48
		// (set) Token: 0x060045B8 RID: 17848 RVA: 0x00019413 File Offset: 0x00017613
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x060045B9 RID: 17849 RVA: 0x00146A70 File Offset: 0x00144C70
		// (set) Token: 0x060045BA RID: 17850 RVA: 0x0001942E File Offset: 0x0001762E
		public unsafe static int CurrentEra
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Calendar.NativeFieldInfoPtr_CurrentEra, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Calendar.NativeFieldInfoPtr_CurrentEra, (void*)(&value));
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x060045BB RID: 17851 RVA: 0x00146A8C File Offset: 0x00144C8C
		// (set) Token: 0x060045BC RID: 17852 RVA: 0x0001943C File Offset: 0x0001763C
		public unsafe int twoDigitYearMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_twoDigitYearMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Calendar.NativeFieldInfoPtr_twoDigitYearMax)) = value;
			}
		}

		// Token: 0x0400395A RID: 14682
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMillisecond;

		// Token: 0x0400395B RID: 14683
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerSecond;

		// Token: 0x0400395C RID: 14684
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMinute;

		// Token: 0x0400395D RID: 14685
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerHour;

		// Token: 0x0400395E RID: 14686
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerDay;

		// Token: 0x0400395F RID: 14687
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerSecond;

		// Token: 0x04003960 RID: 14688
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerMinute;

		// Token: 0x04003961 RID: 14689
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerHour;

		// Token: 0x04003962 RID: 14690
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerDay;

		// Token: 0x04003963 RID: 14691
		private static readonly IntPtr NativeFieldInfoPtr_DaysPerYear;

		// Token: 0x04003964 RID: 14692
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer4Years;

		// Token: 0x04003965 RID: 14693
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer100Years;

		// Token: 0x04003966 RID: 14694
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer400Years;

		// Token: 0x04003967 RID: 14695
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo10000;

		// Token: 0x04003968 RID: 14696
		private static readonly IntPtr NativeFieldInfoPtr_MaxMillis;

		// Token: 0x04003969 RID: 14697
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN;

		// Token: 0x0400396A RID: 14698
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_US;

		// Token: 0x0400396B RID: 14699
		private static readonly IntPtr NativeFieldInfoPtr_CAL_JAPAN;

		// Token: 0x0400396C RID: 14700
		private static readonly IntPtr NativeFieldInfoPtr_CAL_TAIWAN;

		// Token: 0x0400396D RID: 14701
		private static readonly IntPtr NativeFieldInfoPtr_CAL_KOREA;

		// Token: 0x0400396E RID: 14702
		private static readonly IntPtr NativeFieldInfoPtr_CAL_HIJRI;

		// Token: 0x0400396F RID: 14703
		private static readonly IntPtr NativeFieldInfoPtr_CAL_THAI;

		// Token: 0x04003970 RID: 14704
		private static readonly IntPtr NativeFieldInfoPtr_CAL_HEBREW;

		// Token: 0x04003971 RID: 14705
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_ME_FRENCH;

		// Token: 0x04003972 RID: 14706
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_ARABIC;

		// Token: 0x04003973 RID: 14707
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_ENGLISH;

		// Token: 0x04003974 RID: 14708
		private static readonly IntPtr NativeFieldInfoPtr_CAL_GREGORIAN_XLIT_FRENCH;

		// Token: 0x04003975 RID: 14709
		private static readonly IntPtr NativeFieldInfoPtr_CAL_JULIAN;

		// Token: 0x04003976 RID: 14710
		private static readonly IntPtr NativeFieldInfoPtr_CAL_JAPANESELUNISOLAR;

		// Token: 0x04003977 RID: 14711
		private static readonly IntPtr NativeFieldInfoPtr_CAL_CHINESELUNISOLAR;

		// Token: 0x04003978 RID: 14712
		private static readonly IntPtr NativeFieldInfoPtr_CAL_SAKA;

		// Token: 0x04003979 RID: 14713
		private static readonly IntPtr NativeFieldInfoPtr_CAL_LUNAR_ETO_CHN;

		// Token: 0x0400397A RID: 14714
		private static readonly IntPtr NativeFieldInfoPtr_CAL_LUNAR_ETO_KOR;

		// Token: 0x0400397B RID: 14715
		private static readonly IntPtr NativeFieldInfoPtr_CAL_LUNAR_ETO_ROKUYOU;

		// Token: 0x0400397C RID: 14716
		private static readonly IntPtr NativeFieldInfoPtr_CAL_KOREANLUNISOLAR;

		// Token: 0x0400397D RID: 14717
		private static readonly IntPtr NativeFieldInfoPtr_CAL_TAIWANLUNISOLAR;

		// Token: 0x0400397E RID: 14718
		private static readonly IntPtr NativeFieldInfoPtr_CAL_PERSIAN;

		// Token: 0x0400397F RID: 14719
		private static readonly IntPtr NativeFieldInfoPtr_CAL_UMALQURA;

		// Token: 0x04003980 RID: 14720
		private static readonly IntPtr NativeFieldInfoPtr_m_currentEraValue;

		// Token: 0x04003981 RID: 14721
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x04003982 RID: 14722
		private static readonly IntPtr NativeFieldInfoPtr_CurrentEra;

		// Token: 0x04003983 RID: 14723
		private static readonly IntPtr NativeFieldInfoPtr_twoDigitYearMax;

		// Token: 0x04003984 RID: 14724
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSupportedDateTime_Public_Virtual_New_get_DateTime_0;

		// Token: 0x04003985 RID: 14725
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSupportedDateTime_Public_Virtual_New_get_DateTime_0;

		// Token: 0x04003986 RID: 14726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003987 RID: 14727
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Internal_Virtual_New_get_Int32_0;

		// Token: 0x04003988 RID: 14728
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseCalendarID_Internal_Virtual_New_get_Int32_0;

		// Token: 0x04003989 RID: 14729
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x0400398A RID: 14730
		private static readonly IntPtr NativeMethodInfoPtr_VerifyWritable_Internal_Void_0;

		// Token: 0x0400398B RID: 14731
		private static readonly IntPtr NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0;

		// Token: 0x0400398C RID: 14732
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEraValue_Internal_Virtual_New_get_Int32_0;

		// Token: 0x0400398D RID: 14733
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfMonth_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x0400398E RID: 14734
		private static readonly IntPtr NativeMethodInfoPtr_GetDayOfWeek_Public_Abstract_Virtual_New_DayOfWeek_DateTime_0;

		// Token: 0x0400398F RID: 14735
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInMonth_Public_Abstract_Virtual_New_Int32_Int32_Int32_Int32_0;

		// Token: 0x04003990 RID: 14736
		private static readonly IntPtr NativeMethodInfoPtr_GetDaysInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x04003991 RID: 14737
		private static readonly IntPtr NativeMethodInfoPtr_GetEra_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x04003992 RID: 14738
		private static readonly IntPtr NativeMethodInfoPtr_get_Eras_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003993 RID: 14739
		private static readonly IntPtr NativeMethodInfoPtr_GetMonth_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x04003994 RID: 14740
		private static readonly IntPtr NativeMethodInfoPtr_GetMonthsInYear_Public_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x04003995 RID: 14741
		private static readonly IntPtr NativeMethodInfoPtr_GetYear_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x04003996 RID: 14742
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04003997 RID: 14743
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Abstract_Virtual_New_Boolean_Int32_Int32_0;

		// Token: 0x04003998 RID: 14744
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04003999 RID: 14745
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400399A RID: 14746
		private static readonly IntPtr NativeMethodInfoPtr_TryToDateTime_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0;

		// Token: 0x0400399B RID: 14747
		private static readonly IntPtr NativeMethodInfoPtr_IsValidYear_Internal_Virtual_New_Boolean_Int32_Int32_0;

		// Token: 0x0400399C RID: 14748
		private static readonly IntPtr NativeMethodInfoPtr_IsValidMonth_Internal_Virtual_New_Boolean_Int32_Int32_Int32_0;

		// Token: 0x0400399D RID: 14749
		private static readonly IntPtr NativeMethodInfoPtr_IsValidDay_Internal_Virtual_New_Boolean_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400399E RID: 14750
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoDigitYearMax_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400399F RID: 14751
		private static readonly IntPtr NativeMethodInfoPtr_set_TwoDigitYearMax_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x040039A0 RID: 14752
		private static readonly IntPtr NativeMethodInfoPtr_ToFourDigitYear_Public_Virtual_New_Int32_Int32_0;

		// Token: 0x040039A1 RID: 14753
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_Int32_0;

		// Token: 0x040039A2 RID: 14754
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTwoDigitYearSetting_Internal_Static_Int32_Int32_Int32_0;
	}
}
