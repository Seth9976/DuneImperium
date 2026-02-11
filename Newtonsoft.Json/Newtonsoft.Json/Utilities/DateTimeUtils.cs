using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;
using Il2CppSystem.IO;
using Il2CppSystem.Xml;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004E RID: 78
	public static class DateTimeUtils : Object
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x00033884 File Offset: 0x00031A84
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeUtils()
		{
			Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "DateTimeUtils");
			DateTimeUtils.NativeFieldInfoPtr_InitialJavaScriptDateTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, "InitialJavaScriptDateTicks");
			DateTimeUtils.NativeFieldInfoPtr_IsoDateFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, "IsoDateFormat");
			DateTimeUtils.NativeFieldInfoPtr_DaysPer100Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, "DaysPer100Years");
			DateTimeUtils.NativeFieldInfoPtr_DaysPer400Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, "DaysPer400Years");
			DateTimeUtils.NativeFieldInfoPtr_DaysPer4Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, "DaysPer4Years");
			DateTimeUtils.NativeFieldInfoPtr_DaysPerYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, "DaysPerYear");
			DateTimeUtils.NativeFieldInfoPtr_TicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, "TicksPerDay");
			DateTimeUtils.NativeFieldInfoPtr_DaysToMonth365 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, "DaysToMonth365");
			DateTimeUtils.NativeFieldInfoPtr_DaysToMonth366 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, "DaysToMonth366");
			DateTimeUtils.NativeMethodInfoPtr_GetUtcOffset_Public_Static_TimeSpan_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664663);
			DateTimeUtils.NativeMethodInfoPtr_ToSerializationMode_Public_Static_XmlDateTimeSerializationMode_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664664);
			DateTimeUtils.NativeMethodInfoPtr_EnsureDateTime_Internal_Static_DateTime_DateTime_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664665);
			DateTimeUtils.NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664666);
			DateTimeUtils.NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664667);
			DateTimeUtils.NativeMethodInfoPtr_ToUniversalTicks_Private_Static_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664668);
			DateTimeUtils.NativeMethodInfoPtr_ToUniversalTicks_Private_Static_Int64_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664669);
			DateTimeUtils.NativeMethodInfoPtr_ConvertDateTimeToJavaScriptTicks_Internal_Static_Int64_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664670);
			DateTimeUtils.NativeMethodInfoPtr_ConvertDateTimeToJavaScriptTicks_Internal_Static_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664671);
			DateTimeUtils.NativeMethodInfoPtr_ConvertDateTimeToJavaScriptTicks_Internal_Static_Int64_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664672);
			DateTimeUtils.NativeMethodInfoPtr_UniversalTicksToJavaScriptTicks_Private_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664673);
			DateTimeUtils.NativeMethodInfoPtr_ConvertJavaScriptTicksToDateTime_Internal_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664674);
			DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeIso_Internal_Static_Boolean_StringReference_DateTimeZoneHandling_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664675);
			DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeOffsetIso_Internal_Static_Boolean_StringReference_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664676);
			DateTimeUtils.NativeMethodInfoPtr_CreateDateTime_Private_Static_DateTime_DateTimeParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664677);
			DateTimeUtils.NativeMethodInfoPtr_TryParseDateTime_Internal_Static_Boolean_StringReference_DateTimeZoneHandling_String_CultureInfo_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664678);
			DateTimeUtils.NativeMethodInfoPtr_TryParseDateTime_Internal_Static_Boolean_String_DateTimeZoneHandling_String_CultureInfo_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664679);
			DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeOffset_Internal_Static_Boolean_StringReference_String_CultureInfo_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664680);
			DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeOffset_Internal_Static_Boolean_String_String_CultureInfo_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664681);
			DateTimeUtils.NativeMethodInfoPtr_TryParseMicrosoftDate_Private_Static_Boolean_StringReference_byref_Int64_byref_TimeSpan_byref_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664682);
			DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeMicrosoft_Private_Static_Boolean_StringReference_DateTimeZoneHandling_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664683);
			DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeExact_Private_Static_Boolean_String_DateTimeZoneHandling_String_CultureInfo_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664684);
			DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeOffsetMicrosoft_Private_Static_Boolean_StringReference_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664685);
			DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeOffsetExact_Private_Static_Boolean_String_String_CultureInfo_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664686);
			DateTimeUtils.NativeMethodInfoPtr_TryReadOffset_Private_Static_Boolean_StringReference_Int32_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664687);
			DateTimeUtils.NativeMethodInfoPtr_WriteDateTimeString_Internal_Static_Void_TextWriter_DateTime_DateFormatHandling_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664688);
			DateTimeUtils.NativeMethodInfoPtr_WriteDateTimeString_Internal_Static_Int32_Il2CppStructArray_1_Char_Int32_DateTime_Nullable_1_TimeSpan_DateTimeKind_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664689);
			DateTimeUtils.NativeMethodInfoPtr_WriteDefaultIsoDate_Internal_Static_Int32_Il2CppStructArray_1_Char_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664690);
			DateTimeUtils.NativeMethodInfoPtr_CopyIntToCharArray_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664691);
			DateTimeUtils.NativeMethodInfoPtr_WriteDateTimeOffset_Internal_Static_Int32_Il2CppStructArray_1_Char_Int32_TimeSpan_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664692);
			DateTimeUtils.NativeMethodInfoPtr_WriteDateTimeOffsetString_Internal_Static_Void_TextWriter_DateTimeOffset_DateFormatHandling_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664693);
			DateTimeUtils.NativeMethodInfoPtr_GetDateValues_Private_Static_Void_DateTime_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeUtils>.NativeClassPtr, 100664694);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00033BE0 File Offset: 0x00031DE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 741335, RefRangeEnd = 741339, XrefRangeStart = 741329, XrefRangeEnd = 741335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan GetUtcOffset(this DateTime d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_GetUtcOffset_Public_Static_TimeSpan_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00033C20 File Offset: 0x00031E20
		[CallerCount(0)]
		public unsafe static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_ToSerializationMode_Public_Static_XmlDateTimeSerializationMode_DateTimeKind_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00033C60 File Offset: 0x00031E60
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 741346, RefRangeEnd = 741358, XrefRangeStart = 741339, XrefRangeEnd = 741346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_EnsureDateTime_Internal_Static_DateTime_DateTime_DateTimeZoneHandling_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00033CAC File Offset: 0x00031EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741358, XrefRangeEnd = 741362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime SwitchToLocalTime(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00033CEC File Offset: 0x00031EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741362, XrefRangeEnd = 741369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime SwitchToUtcTime(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00033D2C File Offset: 0x00031F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741369, XrefRangeEnd = 741382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToUniversalTicks(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_ToUniversalTicks_Private_Static_Int64_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00033D6C File Offset: 0x00031F6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 741400, RefRangeEnd = 741404, XrefRangeStart = 741382, XrefRangeEnd = 741400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_ToUniversalTicks_Private_Static_Int64_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00033DB8 File Offset: 0x00031FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741404, XrefRangeEnd = 741412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_ConvertDateTimeToJavaScriptTicks_Internal_Static_Int64_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00033E04 File Offset: 0x00032004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741416, RefRangeEnd = 741417, XrefRangeStart = 741412, XrefRangeEnd = 741416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_ConvertDateTimeToJavaScriptTicks_Internal_Static_Int64_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00033E44 File Offset: 0x00032044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741447, RefRangeEnd = 741448, XrefRangeStart = 741417, XrefRangeEnd = 741447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref convertToUtc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_ConvertDateTimeToJavaScriptTicks_Internal_Static_Int64_DateTime_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00033E90 File Offset: 0x00032090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741448, XrefRangeEnd = 741452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long UniversalTicksToJavaScriptTicks(long universalTicks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref universalTicks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_UniversalTicksToJavaScriptTicks_Private_Static_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00033ED0 File Offset: 0x000320D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 741457, RefRangeEnd = 741461, XrefRangeStart = 741452, XrefRangeEnd = 741457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref javaScriptTicks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_ConvertJavaScriptTicksToDateTime_Internal_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00033F10 File Offset: 0x00032110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741529, RefRangeEnd = 741530, XrefRangeStart = 741461, XrefRangeEnd = 741529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeZoneHandling;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeIso_Internal_Static_Boolean_StringReference_DateTimeZoneHandling_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00033F74 File Offset: 0x00032174
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741562, RefRangeEnd = 741564, XrefRangeStart = 741530, XrefRangeEnd = 741562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeOffsetIso_Internal_Static_Boolean_StringReference_byref_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00033FC8 File Offset: 0x000321C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741573, RefRangeEnd = 741575, XrefRangeStart = 741564, XrefRangeEnd = 741573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime CreateDateTime(DateTimeParser dateTimeParser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dateTimeParser));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_CreateDateTime_Private_Static_DateTime_DateTimeParser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00034010 File Offset: 0x00032210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741602, RefRangeEnd = 741603, XrefRangeStart = 741575, XrefRangeEnd = 741602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeZoneHandling;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dateFormatString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseDateTime_Internal_Static_Boolean_StringReference_DateTimeZoneHandling_String_CultureInfo_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00034098 File Offset: 0x00032298
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 741626, RefRangeEnd = 741629, XrefRangeStart = 741603, XrefRangeEnd = 741626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeZoneHandling;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dateFormatString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseDateTime_Internal_Static_Boolean_String_DateTimeZoneHandling_String_CultureInfo_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0003411C File Offset: 0x0003231C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741656, RefRangeEnd = 741657, XrefRangeStart = 741629, XrefRangeEnd = 741656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dateFormatString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeOffset_Internal_Static_Boolean_StringReference_String_CultureInfo_byref_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00034194 File Offset: 0x00032394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741696, RefRangeEnd = 741698, XrefRangeStart = 741657, XrefRangeEnd = 741696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dateFormatString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeOffset_Internal_Static_Boolean_String_String_CultureInfo_byref_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00034208 File Offset: 0x00032408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741716, RefRangeEnd = 741718, XrefRangeStart = 741698, XrefRangeEnd = 741716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ticks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseMicrosoftDate_Private_Static_Boolean_StringReference_byref_Int64_byref_TimeSpan_byref_DateTimeKind_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00034278 File Offset: 0x00032478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741738, RefRangeEnd = 741739, XrefRangeStart = 741718, XrefRangeEnd = 741738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeZoneHandling;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeMicrosoft_Private_Static_Boolean_StringReference_DateTimeZoneHandling_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000342DC File Offset: 0x000324DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741748, RefRangeEnd = 741749, XrefRangeStart = 741739, XrefRangeEnd = 741748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeZoneHandling;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dateFormatString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeExact_Private_Static_Boolean_String_DateTimeZoneHandling_String_CultureInfo_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00034360 File Offset: 0x00032560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741767, RefRangeEnd = 741769, XrefRangeStart = 741749, XrefRangeEnd = 741767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeOffsetMicrosoft_Private_Static_Boolean_StringReference_byref_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000343B4 File Offset: 0x000325B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741774, RefRangeEnd = 741776, XrefRangeStart = 741769, XrefRangeEnd = 741774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dateFormatString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryParseDateTimeOffsetExact_Private_Static_Boolean_String_String_CultureInfo_byref_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00034428 File Offset: 0x00032628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741791, RefRangeEnd = 741792, XrefRangeStart = 741776, XrefRangeEnd = 741791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(offsetText));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_TryReadOffset_Private_Static_Boolean_StringReference_Int32_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0003448C File Offset: 0x0003268C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741799, RefRangeEnd = 741800, XrefRangeStart = 741792, XrefRangeEnd = 741799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatString);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_WriteDateTimeString_Internal_Static_Void_TextWriter_DateTime_DateFormatHandling_String_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00034504 File Offset: 0x00032704
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 741854, RefRangeEnd = 741857, XrefRangeStart = 741800, XrefRangeEnd = 741854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteDateTimeString(Il2CppStructArray<char> chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(offset));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_WriteDateTimeString_Internal_Static_Int32_Il2CppStructArray_1_Char_Int32_DateTime_Nullable_1_TimeSpan_DateTimeKind_DateFormatHandling_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00034594 File Offset: 0x00032794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741870, RefRangeEnd = 741871, XrefRangeStart = 741857, XrefRangeEnd = 741870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteDefaultIsoDate(Il2CppStructArray<char> chars, int start, DateTime dt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_WriteDefaultIsoDate_Internal_Static_Int32_Il2CppStructArray_1_Char_Int32_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000345F4 File Offset: 0x000327F4
		[CallerCount(0)]
		public unsafe static void CopyIntToCharArray(Il2CppStructArray<char> chars, int start, int value, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_CopyIntToCharArray_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00034654 File Offset: 0x00032854
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741890, RefRangeEnd = 741892, XrefRangeStart = 741871, XrefRangeEnd = 741890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteDateTimeOffset(Il2CppStructArray<char> chars, int start, TimeSpan offset, DateFormatHandling format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_WriteDateTimeOffset_Internal_Static_Int32_Il2CppStructArray_1_Char_Int32_TimeSpan_DateFormatHandling_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000346C0 File Offset: 0x000328C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741917, RefRangeEnd = 741918, XrefRangeStart = 741892, XrefRangeEnd = 741917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatString);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_WriteDateTimeOffsetString_Internal_Static_Void_TextWriter_DateTimeOffset_DateFormatHandling_String_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00034738 File Offset: 0x00032938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741931, RefRangeEnd = 741932, XrefRangeStart = 741918, XrefRangeEnd = 741931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDateValues(DateTime td, out int year, out int month, out int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref td;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &year;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &month;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeUtils.NativeMethodInfoPtr_GetDateValues_Private_Static_Void_DateTime_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0000445D File Offset: 0x0000265D
		public DateTimeUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00034794 File Offset: 0x00032994
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00004466 File Offset: 0x00002666
		public unsafe static long InitialJavaScriptDateTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeUtils.NativeFieldInfoPtr_InitialJavaScriptDateTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeUtils.NativeFieldInfoPtr_InitialJavaScriptDateTicks, (void*)(&value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x000347B0 File Offset: 0x000329B0
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00004474 File Offset: 0x00002674
		public unsafe static string IsoDateFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeUtils.NativeFieldInfoPtr_IsoDateFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeUtils.NativeFieldInfoPtr_IsoDateFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x000347D0 File Offset: 0x000329D0
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00004486 File Offset: 0x00002686
		public unsafe static int DaysPer100Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeUtils.NativeFieldInfoPtr_DaysPer100Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeUtils.NativeFieldInfoPtr_DaysPer100Years, (void*)(&value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x000347EC File Offset: 0x000329EC
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00004494 File Offset: 0x00002694
		public unsafe static int DaysPer400Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeUtils.NativeFieldInfoPtr_DaysPer400Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeUtils.NativeFieldInfoPtr_DaysPer400Years, (void*)(&value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00034808 File Offset: 0x00032A08
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x000044A2 File Offset: 0x000026A2
		public unsafe static int DaysPer4Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeUtils.NativeFieldInfoPtr_DaysPer4Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeUtils.NativeFieldInfoPtr_DaysPer4Years, (void*)(&value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00034824 File Offset: 0x00032A24
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x000044B0 File Offset: 0x000026B0
		public unsafe static int DaysPerYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeUtils.NativeFieldInfoPtr_DaysPerYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeUtils.NativeFieldInfoPtr_DaysPerYear, (void*)(&value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00034840 File Offset: 0x00032A40
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x000044BE File Offset: 0x000026BE
		public unsafe static long TicksPerDay
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeUtils.NativeFieldInfoPtr_TicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeUtils.NativeFieldInfoPtr_TicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0003485C File Offset: 0x00032A5C
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x000044CC File Offset: 0x000026CC
		public unsafe static Il2CppStructArray<int> DaysToMonth365
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeUtils.NativeFieldInfoPtr_DaysToMonth365, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeUtils.NativeFieldInfoPtr_DaysToMonth365, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00034884 File Offset: 0x00032A84
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x000044DE File Offset: 0x000026DE
		public unsafe static Il2CppStructArray<int> DaysToMonth366
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeUtils.NativeFieldInfoPtr_DaysToMonth366, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeUtils.NativeFieldInfoPtr_DaysToMonth366, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeFieldInfoPtr_InitialJavaScriptDateTicks;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeFieldInfoPtr_IsoDateFormat;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer100Years;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer400Years;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer4Years;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeFieldInfoPtr_DaysPerYear;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerDay;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth365;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth366;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcOffset_Public_Static_TimeSpan_DateTime_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_ToSerializationMode_Public_Static_XmlDateTimeSerializationMode_DateTimeKind_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDateTime_Internal_Static_DateTime_DateTime_DateTimeZoneHandling_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_ToUniversalTicks_Private_Static_Int64_DateTime_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_ToUniversalTicks_Private_Static_Int64_DateTime_TimeSpan_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_ConvertDateTimeToJavaScriptTicks_Internal_Static_Int64_DateTime_TimeSpan_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_ConvertDateTimeToJavaScriptTicks_Internal_Static_Int64_DateTime_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_ConvertDateTimeToJavaScriptTicks_Internal_Static_Int64_DateTime_Boolean_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_UniversalTicksToJavaScriptTicks_Private_Static_Int64_Int64_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_ConvertJavaScriptTicksToDateTime_Internal_Static_DateTime_Int64_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDateTimeIso_Internal_Static_Boolean_StringReference_DateTimeZoneHandling_byref_DateTime_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDateTimeOffsetIso_Internal_Static_Boolean_StringReference_byref_DateTimeOffset_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_CreateDateTime_Private_Static_DateTime_DateTimeParser_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDateTime_Internal_Static_Boolean_StringReference_DateTimeZoneHandling_String_CultureInfo_byref_DateTime_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDateTime_Internal_Static_Boolean_String_DateTimeZoneHandling_String_CultureInfo_byref_DateTime_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDateTimeOffset_Internal_Static_Boolean_StringReference_String_CultureInfo_byref_DateTimeOffset_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDateTimeOffset_Internal_Static_Boolean_String_String_CultureInfo_byref_DateTimeOffset_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_TryParseMicrosoftDate_Private_Static_Boolean_StringReference_byref_Int64_byref_TimeSpan_byref_DateTimeKind_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDateTimeMicrosoft_Private_Static_Boolean_StringReference_DateTimeZoneHandling_byref_DateTime_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDateTimeExact_Private_Static_Boolean_String_DateTimeZoneHandling_String_CultureInfo_byref_DateTime_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDateTimeOffsetMicrosoft_Private_Static_Boolean_StringReference_byref_DateTimeOffset_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDateTimeOffsetExact_Private_Static_Boolean_String_String_CultureInfo_byref_DateTimeOffset_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_TryReadOffset_Private_Static_Boolean_StringReference_Int32_byref_TimeSpan_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_WriteDateTimeString_Internal_Static_Void_TextWriter_DateTime_DateFormatHandling_String_CultureInfo_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_WriteDateTimeString_Internal_Static_Int32_Il2CppStructArray_1_Char_Int32_DateTime_Nullable_1_TimeSpan_DateTimeKind_DateFormatHandling_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_WriteDefaultIsoDate_Internal_Static_Int32_Il2CppStructArray_1_Char_Int32_DateTime_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_CopyIntToCharArray_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_WriteDateTimeOffset_Internal_Static_Int32_Il2CppStructArray_1_Char_Int32_TimeSpan_DateFormatHandling_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_WriteDateTimeOffsetString_Internal_Static_Void_TextWriter_DateTimeOffset_DateFormatHandling_String_CultureInfo_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_GetDateValues_Private_Static_Void_DateTime_byref_Int32_byref_Int32_byref_Int32_0;
	}
}
