using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000088 RID: 136
	[Serializable]
	[StructLayout(2)]
	public struct DateTimeOffset
	{
		// Token: 0x06000971 RID: 2417 RVA: 0x00050810 File Offset: 0x0004EA10
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeOffset()
		{
			Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeOffset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr);
			DateTimeOffset.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "MinValue");
			DateTimeOffset.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "MaxValue");
			DateTimeOffset.NativeFieldInfoPtr_UnixEpoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "UnixEpoch");
			DateTimeOffset.NativeFieldInfoPtr__dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "_dateTime");
			DateTimeOffset.NativeFieldInfoPtr__offsetMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "_offsetMinutes");
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int64_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664940);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664941);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664942);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664943);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664944);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Calendar_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664945);
			DateTimeOffset.NativeMethodInfoPtr_get_Now_Public_Static_get_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664946);
			DateTimeOffset.NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664947);
			DateTimeOffset.NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664948);
			DateTimeOffset.NativeMethodInfoPtr_get_UtcDateTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664949);
			DateTimeOffset.NativeMethodInfoPtr_get_LocalDateTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664950);
			DateTimeOffset.NativeMethodInfoPtr_get_ClockDateTime_Private_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664951);
			DateTimeOffset.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664952);
			DateTimeOffset.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664953);
			DateTimeOffset.NativeMethodInfoPtr_get_Millisecond_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664954);
			DateTimeOffset.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664955);
			DateTimeOffset.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664956);
			DateTimeOffset.NativeMethodInfoPtr_get_Offset_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664957);
			DateTimeOffset.NativeMethodInfoPtr_get_Second_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664958);
			DateTimeOffset.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664959);
			DateTimeOffset.NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664960);
			DateTimeOffset.NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664961);
			DateTimeOffset.NativeMethodInfoPtr_Compare_Public_Static_Int32_DateTimeOffset_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664962);
			DateTimeOffset.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664963);
			DateTimeOffset.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664964);
			DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664965);
			DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664966);
			DateTimeOffset.NativeMethodInfoPtr_FromFileTime_Public_Static_DateTimeOffset_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664967);
			DateTimeOffset.NativeMethodInfoPtr_FromUnixTimeSeconds_Public_Static_DateTimeOffset_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664968);
			DateTimeOffset.NativeMethodInfoPtr_FromUnixTimeMilliseconds_Public_Static_DateTimeOffset_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664969);
			DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664970);
			DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664971);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664972);
			DateTimeOffset.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664973);
			DateTimeOffset.NativeMethodInfoPtr_Parse_Public_Static_DateTimeOffset_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664974);
			DateTimeOffset.NativeMethodInfoPtr_Parse_Public_Static_DateTimeOffset_String_IFormatProvider_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664975);
			DateTimeOffset.NativeMethodInfoPtr_ParseExact_Public_Static_DateTimeOffset_String_String_IFormatProvider_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664976);
			DateTimeOffset.NativeMethodInfoPtr_ToUnixTimeSeconds_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664977);
			DateTimeOffset.NativeMethodInfoPtr_ToUnixTimeMilliseconds_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664978);
			DateTimeOffset.NativeMethodInfoPtr_ToLocalTime_Public_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664979);
			DateTimeOffset.NativeMethodInfoPtr_ToLocalTime_Internal_DateTimeOffset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664980);
			DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664981);
			DateTimeOffset.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664982);
			DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664983);
			DateTimeOffset.NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664984);
			DateTimeOffset.NativeMethodInfoPtr_ToUniversalTime_Public_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664985);
			DateTimeOffset.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664986);
			DateTimeOffset.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_String_IFormatProvider_DateTimeStyles_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664987);
			DateTimeOffset.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_Il2CppStringArray_IFormatProvider_DateTimeStyles_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664988);
			DateTimeOffset.NativeMethodInfoPtr_ValidateOffset_Private_Static_Int16_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664989);
			DateTimeOffset.NativeMethodInfoPtr_ValidateDate_Private_Static_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664990);
			DateTimeOffset.NativeMethodInfoPtr_ValidateStyles_Private_Static_DateTimeStyles_DateTimeStyles_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664991);
			DateTimeOffset.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664992);
			DateTimeOffset.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTimeOffset_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664993);
			DateTimeOffset.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTimeOffset_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664994);
			DateTimeOffset.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTimeOffset_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664995);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00050D04 File Offset: 0x0004EF04
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1303366, RefRangeEnd = 1303375, XrefRangeStart = 1303358, XrefRangeEnd = 1303366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(long ticks, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int64_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00050D44 File Offset: 0x0004EF44
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1303394, RefRangeEnd = 1303405, XrefRangeStart = 1303375, XrefRangeEnd = 1303394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00050D78 File Offset: 0x0004EF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1303434, RefRangeEnd = 1303436, XrefRangeStart = 1303405, XrefRangeEnd = 1303434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(DateTime dateTime, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00050DB8 File Offset: 0x0004EFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303436, XrefRangeEnd = 1303446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
		{
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
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00050E40 File Offset: 0x0004F040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303446, XrefRangeEnd = 1303452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset)
		{
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
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00050ED4 File Offset: 0x0004F0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303452, XrefRangeEnd = 1303458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset)
		{
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
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(calendar);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Calendar_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00050F7C File Offset: 0x0004F17C
		public unsafe static DateTimeOffset Now
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1303463, RefRangeEnd = 1303466, XrefRangeStart = 1303458, XrefRangeEnd = 1303463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Now_Public_Static_get_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00050FAC File Offset: 0x0004F1AC
		public unsafe static DateTimeOffset UtcNow
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1303474, RefRangeEnd = 1303483, XrefRangeStart = 1303466, XrefRangeEnd = 1303474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00050FDC File Offset: 0x0004F1DC
		public unsafe DateTime DateTime
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1303487, RefRangeEnd = 1303493, XrefRangeStart = 1303483, XrefRangeEnd = 1303487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0005100C File Offset: 0x0004F20C
		public unsafe DateTime UtcDateTime
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 1303500, RefRangeEnd = 1303527, XrefRangeStart = 1303493, XrefRangeEnd = 1303500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_UtcDateTime_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0005103C File Offset: 0x0004F23C
		public unsafe DateTime LocalDateTime
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1303538, RefRangeEnd = 1303541, XrefRangeStart = 1303527, XrefRangeEnd = 1303538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_LocalDateTime_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0005106C File Offset: 0x0004F26C
		public unsafe DateTime ClockDateTime
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1303557, RefRangeEnd = 1303572, XrefRangeStart = 1303541, XrefRangeEnd = 1303557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_ClockDateTime_Private_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0005109C File Offset: 0x0004F29C
		public unsafe int Day
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1303583, RefRangeEnd = 1303588, XrefRangeStart = 1303572, XrefRangeEnd = 1303583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000510CC File Offset: 0x0004F2CC
		public unsafe int Hour
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1303598, RefRangeEnd = 1303603, XrefRangeStart = 1303588, XrefRangeEnd = 1303598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x000510FC File Offset: 0x0004F2FC
		public unsafe int Millisecond
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1303613, RefRangeEnd = 1303614, XrefRangeStart = 1303603, XrefRangeEnd = 1303613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Millisecond_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0005112C File Offset: 0x0004F32C
		public unsafe int Minute
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1303624, RefRangeEnd = 1303629, XrefRangeStart = 1303614, XrefRangeEnd = 1303624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0005115C File Offset: 0x0004F35C
		public unsafe int Month
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1303640, RefRangeEnd = 1303645, XrefRangeStart = 1303629, XrefRangeEnd = 1303640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0005118C File Offset: 0x0004F38C
		public unsafe TimeSpan Offset
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1303646, RefRangeEnd = 1303655, XrefRangeStart = 1303645, XrefRangeEnd = 1303646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Offset_Public_get_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x000511BC File Offset: 0x0004F3BC
		public unsafe int Second
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1303665, RefRangeEnd = 1303670, XrefRangeStart = 1303655, XrefRangeEnd = 1303665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Second_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x000511EC File Offset: 0x0004F3EC
		public unsafe long Ticks
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1303680, RefRangeEnd = 1303683, XrefRangeStart = 1303670, XrefRangeEnd = 1303680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x0005121C File Offset: 0x0004F41C
		public unsafe TimeSpan TimeOfDay
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1303693, RefRangeEnd = 1303695, XrefRangeStart = 1303683, XrefRangeEnd = 1303693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0005124C File Offset: 0x0004F44C
		public unsafe int Year
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1303706, RefRangeEnd = 1303711, XrefRangeStart = 1303695, XrefRangeEnd = 1303706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Year_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0005127C File Offset: 0x0004F47C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1303720, RefRangeEnd = 1303724, XrefRangeStart = 1303711, XrefRangeEnd = 1303720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(DateTimeOffset first, DateTimeOffset second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_Compare_Public_Static_Int32_DateTimeOffset_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000512C8 File Offset: 0x0004F4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303724, XrefRangeEnd = 1303738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IComparable_CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0005130C File Offset: 0x0004F50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303738, XrefRangeEnd = 1303754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(DateTimeOffset other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTimeOffset_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0005134C File Offset: 0x0004F54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303754, XrefRangeEnd = 1303773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00051390 File Offset: 0x0004F590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303773, XrefRangeEnd = 1303784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DateTimeOffset other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTimeOffset_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000513D0 File Offset: 0x0004F5D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1303796, RefRangeEnd = 1303797, XrefRangeStart = 1303784, XrefRangeEnd = 1303796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset FromFileTime(long fileTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_FromFileTime_Public_Static_DateTimeOffset_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00051410 File Offset: 0x0004F610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303797, XrefRangeEnd = 1303802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset FromUnixTimeSeconds(long seconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_FromUnixTimeSeconds_Public_Static_DateTimeOffset_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00051450 File Offset: 0x0004F650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1303807, RefRangeEnd = 1303808, XrefRangeStart = 1303802, XrefRangeEnd = 1303807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset FromUnixTimeMilliseconds(long milliseconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref milliseconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_FromUnixTimeMilliseconds_Public_Static_DateTimeOffset_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00051490 File Offset: 0x0004F690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303808, XrefRangeEnd = 1303816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x000514C8 File Offset: 0x0004F6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303816, XrefRangeEnd = 1303828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00051518 File Offset: 0x0004F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303828, XrefRangeEnd = 1303849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00051568 File Offset: 0x0004F768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303849, XrefRangeEnd = 1303859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00051598 File Offset: 0x0004F798
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1303864, RefRangeEnd = 1303869, XrefRangeStart = 1303859, XrefRangeEnd = 1303864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset Parse(string input, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_Parse_Public_Static_DateTimeOffset_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000515EC File Offset: 0x0004F7EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1303898, RefRangeEnd = 1303900, XrefRangeStart = 1303869, XrefRangeEnd = 1303898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_Parse_Public_Static_DateTimeOffset_String_IFormatProvider_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00051650 File Offset: 0x0004F850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1303941, RefRangeEnd = 1303942, XrefRangeStart = 1303900, XrefRangeEnd = 1303941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ParseExact_Public_Static_DateTimeOffset_String_String_IFormatProvider_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000516C4 File Offset: 0x0004F8C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1303952, RefRangeEnd = 1303953, XrefRangeStart = 1303942, XrefRangeEnd = 1303952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ToUnixTimeSeconds()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToUnixTimeSeconds_Public_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000516F4 File Offset: 0x0004F8F4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1303963, RefRangeEnd = 1303972, XrefRangeStart = 1303953, XrefRangeEnd = 1303963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ToUnixTimeMilliseconds()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToUnixTimeMilliseconds_Public_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00051724 File Offset: 0x0004F924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1303984, RefRangeEnd = 1303985, XrefRangeStart = 1303972, XrefRangeEnd = 1303984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset ToLocalTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToLocalTime_Public_DateTimeOffset_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00051754 File Offset: 0x0004F954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303985, XrefRangeEnd = 1303994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset ToLocalTime(bool throwOnOverflow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnOverflow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToLocalTime_Internal_DateTimeOffset_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00051794 File Offset: 0x0004F994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303994, XrefRangeEnd = 1304003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000517C0 File Offset: 0x0004F9C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304012, RefRangeEnd = 1304013, XrefRangeStart = 1304003, XrefRangeEnd = 1304012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider formatProvider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000517FC File Offset: 0x0004F9FC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1304022, RefRangeEnd = 1304032, XrefRangeStart = 1304013, XrefRangeEnd = 1304022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0005184C File Offset: 0x0004FA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1304032, XrefRangeEnd = 1304041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider formatProvider = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000518CC File Offset: 0x0004FACC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1304046, RefRangeEnd = 1304049, XrefRangeStart = 1304041, XrefRangeEnd = 1304046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset ToUniversalTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToUniversalTime_Public_DateTimeOffset_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000518FC File Offset: 0x0004FAFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304085, RefRangeEnd = 1304086, XrefRangeStart = 1304049, XrefRangeEnd = 1304085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0005196C File Offset: 0x0004FB6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1304134, RefRangeEnd = 1304136, XrefRangeStart = 1304086, XrefRangeEnd = 1304134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_String_IFormatProvider_DateTimeStyles_byref_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000519F0 File Offset: 0x0004FBF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304172, RefRangeEnd = 1304173, XrefRangeStart = 1304136, XrefRangeEnd = 1304172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(string input, Il2CppStringArray formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formats);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_Il2CppStringArray_IFormatProvider_DateTimeStyles_byref_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00051A74 File Offset: 0x0004FC74
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1304178, RefRangeEnd = 1304185, XrefRangeStart = 1304173, XrefRangeEnd = 1304178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ValidateOffset(TimeSpan offset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ValidateOffset_Private_Static_Int16_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00051AB4 File Offset: 0x0004FCB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1304195, RefRangeEnd = 1304202, XrefRangeStart = 1304185, XrefRangeEnd = 1304195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ValidateDate_Private_Static_DateTime_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00051B00 File Offset: 0x0004FD00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1304202, RefRangeEnd = 1304207, XrefRangeStart = 1304202, XrefRangeEnd = 1304202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ValidateStyles_Private_Static_DateTimeStyles_DateTimeStyles_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00051B50 File Offset: 0x0004FD50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1304208, RefRangeEnd = 1304211, XrefRangeStart = 1304207, XrefRangeEnd = 1304208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DateTimeOffset(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00051B90 File Offset: 0x0004FD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304222, RefRangeEnd = 1304223, XrefRangeStart = 1304211, XrefRangeEnd = 1304222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTimeOffset_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00051BDC File Offset: 0x0004FDDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1304234, RefRangeEnd = 1304241, XrefRangeStart = 1304223, XrefRangeEnd = 1304234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(DateTimeOffset left, DateTimeOffset right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTimeOffset_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00051C28 File Offset: 0x0004FE28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304252, RefRangeEnd = 1304253, XrefRangeStart = 1304241, XrefRangeEnd = 1304252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(DateTimeOffset left, DateTimeOffset right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTimeOffset_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0000463D File Offset: 0x0000283D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, ref this));
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00051C74 File Offset: 0x0004FE74
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0000464F File Offset: 0x0000284F
		public unsafe static DateTimeOffset MinValue
		{
			get
			{
				DateTimeOffset dateTimeOffset;
				IL2CPP.il2cpp_field_static_get_value(DateTimeOffset.NativeFieldInfoPtr_MinValue, (void*)(&dateTimeOffset));
				return dateTimeOffset;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeOffset.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00051C90 File Offset: 0x0004FE90
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x0000465D File Offset: 0x0000285D
		public unsafe static DateTimeOffset MaxValue
		{
			get
			{
				DateTimeOffset dateTimeOffset;
				IL2CPP.il2cpp_field_static_get_value(DateTimeOffset.NativeFieldInfoPtr_MaxValue, (void*)(&dateTimeOffset));
				return dateTimeOffset;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeOffset.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00051CAC File Offset: 0x0004FEAC
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x0000466B File Offset: 0x0000286B
		public unsafe static DateTimeOffset UnixEpoch
		{
			get
			{
				DateTimeOffset dateTimeOffset;
				IL2CPP.il2cpp_field_static_get_value(DateTimeOffset.NativeFieldInfoPtr_UnixEpoch, (void*)(&dateTimeOffset));
				return dateTimeOffset;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeOffset.NativeFieldInfoPtr_UnixEpoch, (void*)(&value));
			}
		}

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeFieldInfoPtr_UnixEpoch;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr__dateTime;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeFieldInfoPtr__offsetMinutes;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_TimeSpan_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_TimeSpan_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_TimeSpan_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_TimeSpan_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Calendar_TimeSpan_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_get_Now_Public_Static_get_DateTimeOffset_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTimeOffset_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_get_UtcDateTime_Public_get_DateTime_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalDateTime_Public_get_DateTime_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_get_ClockDateTime_Private_get_DateTime_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_get_Hour_Public_get_Int32_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_get_Millisecond_Public_get_Int32_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_get_Minute_Public_get_Int32_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_get_TimeSpan_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_get_Second_Public_get_Int32_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_DateTimeOffset_DateTimeOffset_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTimeOffset_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTimeOffset_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_FromFileTime_Public_Static_DateTimeOffset_Int64_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_FromUnixTimeSeconds_Public_Static_DateTimeOffset_Int64_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_FromUnixTimeMilliseconds_Public_Static_DateTimeOffset_Int64_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_DateTimeOffset_String_IFormatProvider_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_DateTimeOffset_String_IFormatProvider_DateTimeStyles_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Public_Static_DateTimeOffset_String_String_IFormatProvider_DateTimeStyles_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_ToUnixTimeSeconds_Public_Int64_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_ToUnixTimeMilliseconds_Public_Int64_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_ToLocalTime_Public_DateTimeOffset_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_ToLocalTime_Internal_DateTimeOffset_Boolean_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_ToUniversalTime_Public_DateTimeOffset_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTimeOffset_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_String_IFormatProvider_DateTimeStyles_byref_DateTimeOffset_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_Il2CppStringArray_IFormatProvider_DateTimeStyles_byref_DateTimeOffset_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_ValidateOffset_Private_Static_Int16_TimeSpan_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDate_Private_Static_DateTime_DateTime_TimeSpan_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStyles_Private_Static_DateTimeStyles_DateTimeStyles_String_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_DateTime_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTimeOffset_DateTimeOffset_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTimeOffset_DateTimeOffset_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTimeOffset_DateTimeOffset_0;

		// Token: 0x04000793 RID: 1939
		[FieldOffset(0)]
		public readonly DateTime _dateTime;

		// Token: 0x04000794 RID: 1940
		[FieldOffset(8)]
		public readonly short _offsetMinutes;
	}
}
