using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000086 RID: 134
	[Serializable]
	[StructLayout(2)]
	public struct DateTime
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x0004DAEC File Offset: 0x0004BCEC
		// Note: this type is marked as 'beforefieldinit'.
		static DateTime()
		{
			Il2CppClassPointerStore<DateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTime>.NativeClassPtr);
			DateTime.NativeFieldInfoPtr_TicksPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerMillisecond");
			DateTime.NativeFieldInfoPtr_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerSecond");
			DateTime.NativeFieldInfoPtr_TicksPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerMinute");
			DateTime.NativeFieldInfoPtr_TicksPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerHour");
			DateTime.NativeFieldInfoPtr_TicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerDay");
			DateTime.NativeFieldInfoPtr_MillisPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerSecond");
			DateTime.NativeFieldInfoPtr_MillisPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerMinute");
			DateTime.NativeFieldInfoPtr_MillisPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerHour");
			DateTime.NativeFieldInfoPtr_MillisPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerDay");
			DateTime.NativeFieldInfoPtr_DaysPerYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPerYear");
			DateTime.NativeFieldInfoPtr_DaysPer4Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPer4Years");
			DateTime.NativeFieldInfoPtr_DaysPer100Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPer100Years");
			DateTime.NativeFieldInfoPtr_DaysPer400Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPer400Years");
			DateTime.NativeFieldInfoPtr_DaysTo1601 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo1601");
			DateTime.NativeFieldInfoPtr_DaysTo1899 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo1899");
			DateTime.NativeFieldInfoPtr_DaysTo1970 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo1970");
			DateTime.NativeFieldInfoPtr_DaysTo10000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo10000");
			DateTime.NativeFieldInfoPtr_MinTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MinTicks");
			DateTime.NativeFieldInfoPtr_MaxTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MaxTicks");
			DateTime.NativeFieldInfoPtr_MaxMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MaxMillis");
			DateTime.NativeFieldInfoPtr_UnixEpochTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "UnixEpochTicks");
			DateTime.NativeFieldInfoPtr_FileTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "FileTimeOffset");
			DateTime.NativeFieldInfoPtr_DoubleDateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DoubleDateOffset");
			DateTime.NativeFieldInfoPtr_OADateMinAsTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "OADateMinAsTicks");
			DateTime.NativeFieldInfoPtr_OADateMinAsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "OADateMinAsDouble");
			DateTime.NativeFieldInfoPtr_OADateMaxAsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "OADateMaxAsDouble");
			DateTime.NativeFieldInfoPtr_DatePartYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartYear");
			DateTime.NativeFieldInfoPtr_DatePartDayOfYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartDayOfYear");
			DateTime.NativeFieldInfoPtr_DatePartMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartMonth");
			DateTime.NativeFieldInfoPtr_DatePartDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartDay");
			DateTime.NativeFieldInfoPtr_s_daysToMonth365 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "s_daysToMonth365");
			DateTime.NativeFieldInfoPtr_s_daysToMonth366 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "s_daysToMonth366");
			DateTime.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MinValue");
			DateTime.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MaxValue");
			DateTime.NativeFieldInfoPtr_UnixEpoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "UnixEpoch");
			DateTime.NativeFieldInfoPtr_TicksMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksMask");
			DateTime.NativeFieldInfoPtr_FlagsMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "FlagsMask");
			DateTime.NativeFieldInfoPtr_LocalMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "LocalMask");
			DateTime.NativeFieldInfoPtr_TicksCeiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksCeiling");
			DateTime.NativeFieldInfoPtr_KindUnspecified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindUnspecified");
			DateTime.NativeFieldInfoPtr_KindUtc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindUtc");
			DateTime.NativeFieldInfoPtr_KindLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindLocal");
			DateTime.NativeFieldInfoPtr_KindLocalAmbiguousDst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindLocalAmbiguousDst");
			DateTime.NativeFieldInfoPtr_KindShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindShift");
			DateTime.NativeFieldInfoPtr_TicksField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksField");
			DateTime.NativeFieldInfoPtr_DateDataField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DateDataField");
			DateTime.NativeFieldInfoPtr__dateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "_dateData");
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664838);
			DateTime.NativeMethodInfoPtr__ctor_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664839);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664840);
			DateTime.NativeMethodInfoPtr__ctor_Internal_Void_Int64_DateTimeKind_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664841);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664842);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664843);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664844);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664845);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664846);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664847);
			DateTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664848);
			DateTime.NativeMethodInfoPtr_get_InternalTicks_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664849);
			DateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664850);
			DateTime.NativeMethodInfoPtr_Add_Public_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664851);
			DateTime.NativeMethodInfoPtr_Add_Private_DateTime_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664852);
			DateTime.NativeMethodInfoPtr_AddDays_Public_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664853);
			DateTime.NativeMethodInfoPtr_AddHours_Public_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664854);
			DateTime.NativeMethodInfoPtr_AddMilliseconds_Public_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664855);
			DateTime.NativeMethodInfoPtr_AddMonths_Public_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664856);
			DateTime.NativeMethodInfoPtr_AddSeconds_Public_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664857);
			DateTime.NativeMethodInfoPtr_AddTicks_Public_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664858);
			DateTime.NativeMethodInfoPtr_AddYears_Public_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664859);
			DateTime.NativeMethodInfoPtr_Compare_Public_Static_Int32_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664860);
			DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664861);
			DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664862);
			DateTime.NativeMethodInfoPtr_DateToTicks_Private_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664863);
			DateTime.NativeMethodInfoPtr_TimeToTicks_Private_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664864);
			DateTime.NativeMethodInfoPtr_DaysInMonth_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664865);
			DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664866);
			DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664867);
			DateTime.NativeMethodInfoPtr_FromBinary_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664868);
			DateTime.NativeMethodInfoPtr_FromBinaryRaw_Internal_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664869);
			DateTime.NativeMethodInfoPtr_FromFileTime_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664870);
			DateTime.NativeMethodInfoPtr_FromFileTimeUtc_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664871);
			DateTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664872);
			DateTime.NativeMethodInfoPtr_SpecifyKind_Public_Static_DateTime_DateTime_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664873);
			DateTime.NativeMethodInfoPtr_get_Date_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664874);
			DateTime.NativeMethodInfoPtr_GetDatePart_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664875);
			DateTime.NativeMethodInfoPtr_GetDatePart_Internal_Void_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664876);
			DateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664877);
			DateTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664878);
			DateTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664879);
			DateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664880);
			DateTime.NativeMethodInfoPtr_IsAmbiguousDaylightSavingTime_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664881);
			DateTime.NativeMethodInfoPtr_get_Kind_Public_get_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664882);
			DateTime.NativeMethodInfoPtr_get_Millisecond_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664883);
			DateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664884);
			DateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664885);
			DateTime.NativeMethodInfoPtr_get_Now_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664886);
			DateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664887);
			DateTime.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664888);
			DateTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664889);
			DateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664890);
			DateTime.NativeMethodInfoPtr_IsLeapYear_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664891);
			DateTime.NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664892);
			DateTime.NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664893);
			DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664894);
			DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_Il2CppStringArray_IFormatProvider_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664895);
			DateTime.NativeMethodInfoPtr_Subtract_Public_TimeSpan_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664896);
			DateTime.NativeMethodInfoPtr_ToLocalTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664897);
			DateTime.NativeMethodInfoPtr_ToLocalTime_Internal_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664898);
			DateTime.NativeMethodInfoPtr_ToShortDateString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664899);
			DateTime.NativeMethodInfoPtr_ToShortTimeString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664900);
			DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664901);
			DateTime.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664902);
			DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664903);
			DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664904);
			DateTime.NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664905);
			DateTime.NativeMethodInfoPtr_ToUniversalTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664906);
			DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664907);
			DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664908);
			DateTime.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_String_IFormatProvider_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664909);
			DateTime.NativeMethodInfoPtr_op_Addition_Public_Static_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664910);
			DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664911);
			DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664912);
			DateTime.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664913);
			DateTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664914);
			DateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664915);
			DateTime.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664916);
			DateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664917);
			DateTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664918);
			DateTime.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664919);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664920);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664921);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664922);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664923);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664924);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664925);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664926);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664927);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664928);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664929);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664930);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664931);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664932);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664933);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664934);
			DateTime.NativeMethodInfoPtr_TryCreate_Internal_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664935);
			DateTime.NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664936);
			DateTime.NativeMethodInfoPtr_GetSystemTimeAsFileTime_Internal_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664937);
			DateTime.NativeMethodInfoPtr_ToBinaryRaw_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664938);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0004E6AC File Offset: 0x0004C8AC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1301753, RefRangeEnd = 1301762, XrefRangeStart = 1301753, XrefRangeEnd = 1301753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0004E6E0 File Offset: 0x0004C8E0
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(ulong dateData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Private_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0004E714 File Offset: 0x0004C914
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1301762, RefRangeEnd = 1301783, XrefRangeStart = 1301762, XrefRangeEnd = 1301762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(long ticks, DateTimeKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0004E754 File Offset: 0x0004C954
		[CallerCount(0)]
		public unsafe DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAmbiguousDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Internal_Void_Int64_DateTimeKind_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0004E7A4 File Offset: 0x0004C9A4
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1301787, RefRangeEnd = 1301820, XrefRangeStart = 1301783, XrefRangeEnd = 1301787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0004E7F4 File Offset: 0x0004C9F4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1301825, RefRangeEnd = 1301835, XrefRangeStart = 1301820, XrefRangeEnd = 1301825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0004E86C File Offset: 0x0004CA6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301840, RefRangeEnd = 1301842, XrefRangeStart = 1301835, XrefRangeEnd = 1301840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
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
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0004E8F4 File Offset: 0x0004CAF4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1301847, RefRangeEnd = 1301862, XrefRangeStart = 1301842, XrefRangeEnd = 1301847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
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
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0004E97C File Offset: 0x0004CB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1301862, XrefRangeEnd = 1301867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind)
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
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0004EA10 File Offset: 0x0004CC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301873, RefRangeEnd = 1301874, XrefRangeStart = 1301867, XrefRangeEnd = 1301873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar)
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
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(calendar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Calendar_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0004EAAC File Offset: 0x0004CCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1301874, XrefRangeEnd = 1301905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0004EAFC File Offset: 0x0004CCFC
		public unsafe long InternalTicks
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_InternalTicks_Internal_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0004EB2C File Offset: 0x0004CD2C
		public unsafe ulong InternalKind
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0004EB5C File Offset: 0x0004CD5C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1301909, RefRangeEnd = 1301917, XrefRangeStart = 1301905, XrefRangeEnd = 1301909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime Add(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Add_Public_DateTime_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0004EB9C File Offset: 0x0004CD9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1301929, RefRangeEnd = 1301933, XrefRangeStart = 1301917, XrefRangeEnd = 1301929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime Add(double value, int scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Add_Private_DateTime_Double_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0004EBE8 File Offset: 0x0004CDE8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1301937, RefRangeEnd = 1301943, XrefRangeStart = 1301933, XrefRangeEnd = 1301937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddDays(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddDays_Public_DateTime_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0004EC28 File Offset: 0x0004CE28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301947, RefRangeEnd = 1301948, XrefRangeStart = 1301943, XrefRangeEnd = 1301947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddHours(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddHours_Public_DateTime_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0004EC68 File Offset: 0x0004CE68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301952, RefRangeEnd = 1301954, XrefRangeStart = 1301948, XrefRangeEnd = 1301952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddMilliseconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddMilliseconds_Public_DateTime_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0004ECA8 File Offset: 0x0004CEA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301973, RefRangeEnd = 1301975, XrefRangeStart = 1301954, XrefRangeEnd = 1301973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddMonths(int months)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref months;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddMonths_Public_DateTime_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0004ECE8 File Offset: 0x0004CEE8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1301979, RefRangeEnd = 1301992, XrefRangeStart = 1301975, XrefRangeEnd = 1301979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddSeconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddSeconds_Public_DateTime_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0004ED28 File Offset: 0x0004CF28
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1301997, RefRangeEnd = 1302006, XrefRangeStart = 1301992, XrefRangeEnd = 1301997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddTicks(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddTicks_Public_DateTime_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0004ED68 File Offset: 0x0004CF68
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1302017, RefRangeEnd = 1302031, XrefRangeStart = 1302006, XrefRangeEnd = 1302017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddYears(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddYears_Public_DateTime_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0004EDA8 File Offset: 0x0004CFA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1302034, RefRangeEnd = 1302041, XrefRangeStart = 1302031, XrefRangeEnd = 1302034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Compare_Public_Static_Int32_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0004EDF4 File Offset: 0x0004CFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1302041, XrefRangeEnd = 1302047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0004EE38 File Offset: 0x0004D038
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1302051, RefRangeEnd = 1302054, XrefRangeStart = 1302047, XrefRangeEnd = 1302051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0004EE78 File Offset: 0x0004D078
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1302065, RefRangeEnd = 1302073, XrefRangeStart = 1302054, XrefRangeEnd = 1302065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_DateToTicks_Private_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0004EED4 File Offset: 0x0004D0D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1302083, RefRangeEnd = 1302089, XrefRangeStart = 1302073, XrefRangeEnd = 1302083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TimeToTicks(int hour, int minute, int second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hour;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TimeToTicks_Private_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0004EF30 File Offset: 0x0004D130
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1302100, RefRangeEnd = 1302104, XrefRangeStart = 1302089, XrefRangeEnd = 1302100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DaysInMonth(int year, int month)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_DaysInMonth_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0004EF7C File Offset: 0x0004D17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1302104, XrefRangeEnd = 1302109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0004EFC0 File Offset: 0x0004D1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1302109, XrefRangeEnd = 1302112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0004F000 File Offset: 0x0004D200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1302112, XrefRangeEnd = 1302117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromBinary(long dateData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromBinary_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0004F040 File Offset: 0x0004D240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1302117, RefRangeEnd = 1302119, XrefRangeStart = 1302117, XrefRangeEnd = 1302117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromBinaryRaw(long dateData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromBinaryRaw_Internal_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0004F080 File Offset: 0x0004D280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1302127, RefRangeEnd = 1302128, XrefRangeStart = 1302119, XrefRangeEnd = 1302127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromFileTime(long fileTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromFileTime_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0004F0C0 File Offset: 0x0004D2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1302128, XrefRangeEnd = 1302129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromFileTimeUtc(long fileTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromFileTimeUtc_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0004F100 File Offset: 0x0004D300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1302129, XrefRangeEnd = 1302144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0004F150 File Offset: 0x0004D350
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1302148, RefRangeEnd = 1302157, XrefRangeStart = 1302144, XrefRangeEnd = 1302148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime SpecifyKind(DateTime value, DateTimeKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_SpecifyKind_Public_Static_DateTime_DateTime_DateTimeKind_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0004F19C File Offset: 0x0004D39C
		public unsafe DateTime Date
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1302160, RefRangeEnd = 1302172, XrefRangeStart = 1302157, XrefRangeEnd = 1302160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Date_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0004F1CC File Offset: 0x0004D3CC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1302182, RefRangeEnd = 1302191, XrefRangeStart = 1302172, XrefRangeEnd = 1302182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDatePart(int part)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref part;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetDatePart_Private_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0004F20C File Offset: 0x0004D40C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1302202, RefRangeEnd = 1302205, XrefRangeStart = 1302191, XrefRangeEnd = 1302202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDatePart(out int year, out int month, out int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetDatePart_Internal_Void_byref_Int32_byref_Int32_byref_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0004F25C File Offset: 0x0004D45C
		public unsafe int Day
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1302209, RefRangeEnd = 1302225, XrefRangeStart = 1302205, XrefRangeEnd = 1302209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0004F28C File Offset: 0x0004D48C
		public unsafe DayOfWeek DayOfWeek
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1302228, RefRangeEnd = 1302230, XrefRangeStart = 1302225, XrefRangeEnd = 1302228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0004F2BC File Offset: 0x0004D4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1302233, RefRangeEnd = 1302234, XrefRangeStart = 1302230, XrefRangeEnd = 1302233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0004F2EC File Offset: 0x0004D4EC
		public unsafe int Hour
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 1302237, RefRangeEnd = 1302256, XrefRangeStart = 1302234, XrefRangeEnd = 1302237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0004F31C File Offset: 0x0004D51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1302259, RefRangeEnd = 1302260, XrefRangeStart = 1302256, XrefRangeEnd = 1302259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAmbiguousDaylightSavingTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_IsAmbiguousDaylightSavingTime_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0004F34C File Offset: 0x0004D54C
		public unsafe DateTimeKind Kind
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 1302263, RefRangeEnd = 1302300, XrefRangeStart = 1302260, XrefRangeEnd = 1302263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Kind_Public_get_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0004F37C File Offset: 0x0004D57C
		public unsafe int Millisecond
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1302303, RefRangeEnd = 1302308, XrefRangeStart = 1302300, XrefRangeEnd = 1302303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Millisecond_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x0004F3AC File Offset: 0x0004D5AC
		public unsafe int Minute
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1302311, RefRangeEnd = 1302327, XrefRangeStart = 1302308, XrefRangeEnd = 1302311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0004F3DC File Offset: 0x0004D5DC
		public unsafe int Month
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1302331, RefRangeEnd = 1302348, XrefRangeStart = 1302327, XrefRangeEnd = 1302331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x0004F40C File Offset: 0x0004D60C
		public unsafe static DateTime Now
		{
			[CallerCount(111)]
			[CachedScanResults(RefRangeStart = 1302365, RefRangeEnd = 1302476, XrefRangeStart = 1302348, XrefRangeEnd = 1302365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Now_Public_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0004F43C File Offset: 0x0004D63C
		public unsafe int Second
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1302479, RefRangeEnd = 1302494, XrefRangeStart = 1302476, XrefRangeEnd = 1302479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x0004F46C File Offset: 0x0004D66C
		public unsafe long Ticks
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 1302497, RefRangeEnd = 1302567, XrefRangeStart = 1302494, XrefRangeEnd = 1302497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0004F49C File Offset: 0x0004D69C
		public unsafe TimeSpan TimeOfDay
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1302570, RefRangeEnd = 1302574, XrefRangeStart = 1302567, XrefRangeEnd = 1302570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0004F4CC File Offset: 0x0004D6CC
		public unsafe int Year
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 1302578, RefRangeEnd = 1302627, XrefRangeStart = 1302574, XrefRangeEnd = 1302578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0004F4FC File Offset: 0x0004D6FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1302627, RefRangeEnd = 1302631, XrefRangeStart = 1302627, XrefRangeEnd = 1302627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLeapYear(int year)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_IsLeapYear_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0004F53C File Offset: 0x0004D73C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1302643, RefRangeEnd = 1302648, XrefRangeStart = 1302631, XrefRangeEnd = 1302643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime Parse(string s, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0004F590 File Offset: 0x0004D790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1302665, RefRangeEnd = 1302666, XrefRangeStart = 1302648, XrefRangeEnd = 1302665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0004F5F4 File Offset: 0x0004D7F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1302696, RefRangeEnd = 1302698, XrefRangeStart = 1302666, XrefRangeEnd = 1302696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0004F668 File Offset: 0x0004D868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1302719, RefRangeEnd = 1302721, XrefRangeStart = 1302698, XrefRangeEnd = 1302719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExact(string s, Il2CppStringArray formats, IFormatProvider provider, DateTimeStyles style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formats);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_Il2CppStringArray_IFormatProvider_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0004F6DC File Offset: 0x0004D8DC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1302724, RefRangeEnd = 1302733, XrefRangeStart = 1302721, XrefRangeEnd = 1302724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan Subtract(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Subtract_Public_TimeSpan_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0004F71C File Offset: 0x0004D91C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1302737, RefRangeEnd = 1302754, XrefRangeStart = 1302733, XrefRangeEnd = 1302737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToLocalTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToLocalTime_Public_DateTime_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0004F74C File Offset: 0x0004D94C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1302773, RefRangeEnd = 1302779, XrefRangeStart = 1302754, XrefRangeEnd = 1302773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToLocalTime(bool throwOnOverflow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnOverflow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToLocalTime_Internal_DateTime_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0004F78C File Offset: 0x0004D98C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1302785, RefRangeEnd = 1302786, XrefRangeStart = 1302779, XrefRangeEnd = 1302785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToShortDateString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToShortDateString_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0004F7B8 File Offset: 0x0004D9B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1302792, RefRangeEnd = 1302797, XrefRangeStart = 1302786, XrefRangeEnd = 1302792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToShortTimeString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToShortTimeString_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0004F7E4 File Offset: 0x0004D9E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1302805, RefRangeEnd = 1302807, XrefRangeStart = 1302797, XrefRangeEnd = 1302805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0004F810 File Offset: 0x0004DA10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1302811, RefRangeEnd = 1302813, XrefRangeStart = 1302807, XrefRangeEnd = 1302811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0004F84C File Offset: 0x0004DA4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1302817, RefRangeEnd = 1302821, XrefRangeStart = 1302813, XrefRangeEnd = 1302817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0004F888 File Offset: 0x0004DA88
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1302825, RefRangeEnd = 1302843, XrefRangeStart = 1302821, XrefRangeEnd = 1302825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0004F8D8 File Offset: 0x0004DAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1302843, XrefRangeEnd = 1302851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0004F958 File Offset: 0x0004DB58
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1302855, RefRangeEnd = 1302871, XrefRangeStart = 1302851, XrefRangeEnd = 1302855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToUniversalTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToUniversalTime_Public_DateTime_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0004F988 File Offset: 0x0004DB88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1302881, RefRangeEnd = 1302882, XrefRangeStart = 1302871, XrefRangeEnd = 1302881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0004F9D8 File Offset: 0x0004DBD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1302898, RefRangeEnd = 1302900, XrefRangeStart = 1302882, XrefRangeEnd = 1302898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0004FA48 File Offset: 0x0004DC48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1302936, RefRangeEnd = 1302939, XrefRangeStart = 1302900, XrefRangeEnd = 1302936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_String_IFormatProvider_DateTimeStyles_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0004FACC File Offset: 0x0004DCCC
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1302944, RefRangeEnd = 1302969, XrefRangeStart = 1302939, XrefRangeEnd = 1302944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime operator +(DateTime d, TimeSpan t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Addition_Public_Static_DateTime_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0004FB18 File Offset: 0x0004DD18
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1302974, RefRangeEnd = 1302990, XrefRangeStart = 1302969, XrefRangeEnd = 1302974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime operator -(DateTime d, TimeSpan t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_DateTime_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0004FB64 File Offset: 0x0004DD64
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1302993, RefRangeEnd = 1303038, XrefRangeStart = 1302990, XrefRangeEnd = 1302993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator -(DateTime d1, DateTime d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0004FBB0 File Offset: 0x0004DDB0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1303041, RefRangeEnd = 1303061, XrefRangeStart = 1303038, XrefRangeEnd = 1303041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(DateTime d1, DateTime d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0004FBFC File Offset: 0x0004DDFC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1303064, RefRangeEnd = 1303074, XrefRangeStart = 1303061, XrefRangeEnd = 1303064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(DateTime d1, DateTime d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0004FC48 File Offset: 0x0004DE48
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1303077, RefRangeEnd = 1303099, XrefRangeStart = 1303074, XrefRangeEnd = 1303077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0004FC94 File Offset: 0x0004DE94
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1303102, RefRangeEnd = 1303117, XrefRangeStart = 1303099, XrefRangeEnd = 1303102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0004FCE0 File Offset: 0x0004DEE0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1303120, RefRangeEnd = 1303141, XrefRangeStart = 1303117, XrefRangeEnd = 1303120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0004FD2C File Offset: 0x0004DF2C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1303144, RefRangeEnd = 1303158, XrefRangeStart = 1303141, XrefRangeEnd = 1303144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0004FD78 File Offset: 0x0004DF78
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0004FDA8 File Offset: 0x0004DFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303158, XrefRangeEnd = 1303167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0004FDEC File Offset: 0x0004DFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303167, XrefRangeEnd = 1303176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0004FE30 File Offset: 0x0004E030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303176, XrefRangeEnd = 1303185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0004FE74 File Offset: 0x0004E074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303185, XrefRangeEnd = 1303194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0004FEB8 File Offset: 0x0004E0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303194, XrefRangeEnd = 1303203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0004FEFC File Offset: 0x0004E0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303203, XrefRangeEnd = 1303212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0004FF40 File Offset: 0x0004E140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303212, XrefRangeEnd = 1303221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0004FF84 File Offset: 0x0004E184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303221, XrefRangeEnd = 1303230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0004FFC8 File Offset: 0x0004E1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303230, XrefRangeEnd = 1303239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0005000C File Offset: 0x0004E20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303239, XrefRangeEnd = 1303248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00050050 File Offset: 0x0004E250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303248, XrefRangeEnd = 1303257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00050094 File Offset: 0x0004E294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303257, XrefRangeEnd = 1303266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000500D8 File Offset: 0x0004E2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303266, XrefRangeEnd = 1303275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0005011C File Offset: 0x0004E31C
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00050160 File Offset: 0x0004E360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303275, XrefRangeEnd = 1303282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_IConvertible_ToType(Type type, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000501B8 File Offset: 0x0004E3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303282, XrefRangeEnd = 1303300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result)
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
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryCreate_Internal_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00050258 File Offset: 0x0004E458
		public unsafe static DateTime UtcNow
		{
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1303304, RefRangeEnd = 1303357, XrefRangeStart = 1303300, XrefRangeEnd = 1303304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00050288 File Offset: 0x0004E488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1303357, XrefRangeEnd = 1303358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetSystemTimeAsFileTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetSystemTimeAsFileTime_Internal_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000502B8 File Offset: 0x0004E4B8
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ToBinaryRaw()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToBinaryRaw_Internal_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00004397 File Offset: 0x00002597
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTime>.NativeClassPtr, ref this));
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x000502E8 File Offset: 0x0004E4E8
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x000043A9 File Offset: 0x000025A9
		public unsafe static long TicksPerMillisecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00050304 File Offset: 0x0004E504
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x000043B7 File Offset: 0x000025B7
		public unsafe static long TicksPerSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00050320 File Offset: 0x0004E520
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x000043C5 File Offset: 0x000025C5
		public unsafe static long TicksPerMinute
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerMinute, (void*)(&value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0005033C File Offset: 0x0004E53C
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x000043D3 File Offset: 0x000025D3
		public unsafe static long TicksPerHour
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerHour, (void*)(&value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00050358 File Offset: 0x0004E558
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x000043E1 File Offset: 0x000025E1
		public unsafe static long TicksPerDay
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00050374 File Offset: 0x0004E574
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x000043EF File Offset: 0x000025EF
		public unsafe static int MillisPerSecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerSecond, (void*)(&value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00050390 File Offset: 0x0004E590
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000043FD File Offset: 0x000025FD
		public unsafe static int MillisPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerMinute, (void*)(&value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x000503AC File Offset: 0x0004E5AC
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x0000440B File Offset: 0x0000260B
		public unsafe static int MillisPerHour
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerHour, (void*)(&value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x000503C8 File Offset: 0x0004E5C8
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x00004419 File Offset: 0x00002619
		public unsafe static int MillisPerDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerDay, (void*)(&value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x000503E4 File Offset: 0x0004E5E4
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00004427 File Offset: 0x00002627
		public unsafe static int DaysPerYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPerYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPerYear, (void*)(&value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00050400 File Offset: 0x0004E600
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x00004435 File Offset: 0x00002635
		public unsafe static int DaysPer4Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPer4Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPer4Years, (void*)(&value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0005041C File Offset: 0x0004E61C
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00004443 File Offset: 0x00002643
		public unsafe static int DaysPer100Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPer100Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPer100Years, (void*)(&value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00050438 File Offset: 0x0004E638
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00004451 File Offset: 0x00002651
		public unsafe static int DaysPer400Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPer400Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPer400Years, (void*)(&value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00050454 File Offset: 0x0004E654
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x0000445F File Offset: 0x0000265F
		public unsafe static int DaysTo1601
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo1601, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo1601, (void*)(&value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00050470 File Offset: 0x0004E670
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x0000446D File Offset: 0x0000266D
		public unsafe static int DaysTo1899
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo1899, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo1899, (void*)(&value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0005048C File Offset: 0x0004E68C
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x0000447B File Offset: 0x0000267B
		public unsafe static int DaysTo1970
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo1970, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo1970, (void*)(&value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x000504A8 File Offset: 0x0004E6A8
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x00004489 File Offset: 0x00002689
		public unsafe static int DaysTo10000
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo10000, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo10000, (void*)(&value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x000504C4 File Offset: 0x0004E6C4
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x00004497 File Offset: 0x00002697
		public unsafe static long MinTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MinTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MinTicks, (void*)(&value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x000504E0 File Offset: 0x0004E6E0
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x000044A5 File Offset: 0x000026A5
		public unsafe static long MaxTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MaxTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MaxTicks, (void*)(&value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x000504FC File Offset: 0x0004E6FC
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x000044B3 File Offset: 0x000026B3
		public unsafe static long MaxMillis
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MaxMillis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MaxMillis, (void*)(&value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00050518 File Offset: 0x0004E718
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x000044C1 File Offset: 0x000026C1
		public unsafe static long UnixEpochTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_UnixEpochTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_UnixEpochTicks, (void*)(&value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00050534 File Offset: 0x0004E734
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x000044CF File Offset: 0x000026CF
		public unsafe static long FileTimeOffset
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_FileTimeOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_FileTimeOffset, (void*)(&value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00050550 File Offset: 0x0004E750
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x000044DD File Offset: 0x000026DD
		public unsafe static long DoubleDateOffset
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DoubleDateOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DoubleDateOffset, (void*)(&value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0005056C File Offset: 0x0004E76C
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x000044EB File Offset: 0x000026EB
		public unsafe static long OADateMinAsTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_OADateMinAsTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_OADateMinAsTicks, (void*)(&value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00050588 File Offset: 0x0004E788
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x000044F9 File Offset: 0x000026F9
		public unsafe static double OADateMinAsDouble
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_OADateMinAsDouble, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_OADateMinAsDouble, (void*)(&value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x000505A4 File Offset: 0x0004E7A4
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x00004507 File Offset: 0x00002707
		public unsafe static double OADateMaxAsDouble
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_OADateMaxAsDouble, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_OADateMaxAsDouble, (void*)(&value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x000505C0 File Offset: 0x0004E7C0
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x00004515 File Offset: 0x00002715
		public unsafe static int DatePartYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartYear, (void*)(&value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x000505DC File Offset: 0x0004E7DC
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x00004523 File Offset: 0x00002723
		public unsafe static int DatePartDayOfYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartDayOfYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartDayOfYear, (void*)(&value));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x000505F8 File Offset: 0x0004E7F8
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x00004531 File Offset: 0x00002731
		public unsafe static int DatePartMonth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartMonth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartMonth, (void*)(&value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00050614 File Offset: 0x0004E814
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x0000453F File Offset: 0x0000273F
		public unsafe static int DatePartDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartDay, (void*)(&value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00050630 File Offset: 0x0004E830
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x0000454D File Offset: 0x0000274D
		public unsafe static Il2CppStructArray<int> s_daysToMonth365
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_s_daysToMonth365, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_s_daysToMonth365, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00050658 File Offset: 0x0004E858
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x0000455F File Offset: 0x0000275F
		public unsafe static Il2CppStructArray<int> s_daysToMonth366
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_s_daysToMonth366, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_s_daysToMonth366, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x00050680 File Offset: 0x0004E880
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00004571 File Offset: 0x00002771
		public unsafe static DateTime MinValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MinValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0005069C File Offset: 0x0004E89C
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x0000457F File Offset: 0x0000277F
		public unsafe static DateTime MaxValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MaxValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x000506B8 File Offset: 0x0004E8B8
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x0000458D File Offset: 0x0000278D
		public unsafe static DateTime UnixEpoch
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_UnixEpoch, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_UnixEpoch, (void*)(&value));
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x000506D4 File Offset: 0x0004E8D4
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x0000459B File Offset: 0x0000279B
		public unsafe static ulong TicksMask
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksMask, (void*)(&value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x000506F0 File Offset: 0x0004E8F0
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x000045A9 File Offset: 0x000027A9
		public unsafe static ulong FlagsMask
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_FlagsMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_FlagsMask, (void*)(&value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0005070C File Offset: 0x0004E90C
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x000045B7 File Offset: 0x000027B7
		public unsafe static ulong LocalMask
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_LocalMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_LocalMask, (void*)(&value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00050728 File Offset: 0x0004E928
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x000045C5 File Offset: 0x000027C5
		public unsafe static long TicksCeiling
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksCeiling, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksCeiling, (void*)(&value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00050744 File Offset: 0x0004E944
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x000045D3 File Offset: 0x000027D3
		public unsafe static ulong KindUnspecified
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindUnspecified, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindUnspecified, (void*)(&value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00050760 File Offset: 0x0004E960
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x000045E1 File Offset: 0x000027E1
		public unsafe static ulong KindUtc
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindUtc, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindUtc, (void*)(&value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0005077C File Offset: 0x0004E97C
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x000045EF File Offset: 0x000027EF
		public unsafe static ulong KindLocal
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindLocal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindLocal, (void*)(&value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00050798 File Offset: 0x0004E998
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x000045FD File Offset: 0x000027FD
		public unsafe static ulong KindLocalAmbiguousDst
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindLocalAmbiguousDst, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindLocalAmbiguousDst, (void*)(&value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000507B4 File Offset: 0x0004E9B4
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x0000460B File Offset: 0x0000280B
		public unsafe static int KindShift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindShift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindShift, (void*)(&value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x000507D0 File Offset: 0x0004E9D0
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00004619 File Offset: 0x00002819
		public unsafe static string TicksField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x000507F0 File Offset: 0x0004E9F0
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x0000462B File Offset: 0x0000282B
		public unsafe static string DateDataField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DateDataField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DateDataField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMillisecond;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerSecond;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMinute;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerHour;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerDay;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerSecond;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerMinute;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerHour;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerDay;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_DaysPerYear;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer4Years;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer100Years;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer400Years;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo1601;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo1899;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo1970;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo10000;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_MinTicks;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr_MaxTicks;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr_MaxMillis;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr_UnixEpochTicks;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_FileTimeOffset;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_DoubleDateOffset;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_OADateMinAsTicks;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_OADateMinAsDouble;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_OADateMaxAsDouble;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_DatePartYear;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_DatePartDayOfYear;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr_DatePartMonth;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_DatePartDay;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_s_daysToMonth365;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_s_daysToMonth366;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_UnixEpoch;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_TicksMask;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_FlagsMask;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_LocalMask;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr_TicksCeiling;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_KindUnspecified;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr_KindUtc;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr_KindLocal;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr_KindLocalAmbiguousDst;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr_KindShift;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr_TicksField;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr_DateDataField;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr__dateData;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_UInt64_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_DateTimeKind_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_DateTimeKind_Boolean_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Calendar_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalTicks_Internal_get_Int64_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalKind_Private_get_UInt64_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_DateTime_TimeSpan_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_DateTime_Double_Int32_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_AddDays_Public_DateTime_Double_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_AddHours_Public_DateTime_Double_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_AddMilliseconds_Public_DateTime_Double_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_AddMonths_Public_DateTime_Int32_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_AddSeconds_Public_DateTime_Double_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_AddTicks_Public_DateTime_Int64_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_AddYears_Public_DateTime_Int32_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_DateTime_DateTime_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTime_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_DateToTicks_Private_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Private_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_DaysInMonth_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTime_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_FromBinary_Public_Static_DateTime_Int64_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_FromBinaryRaw_Internal_Static_DateTime_Int64_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_FromFileTime_Public_Static_DateTime_Int64_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_FromFileTimeUtc_Public_Static_DateTime_Int64_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_SpecifyKind_Public_Static_DateTime_DateTime_DateTimeKind_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_get_Date_Public_get_DateTime_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Private_Int32_Int32_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Internal_Void_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_get_Hour_Public_get_Int32_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_IsAmbiguousDaylightSavingTime_Internal_Boolean_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_get_DateTimeKind_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_get_Millisecond_Public_get_Int32_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_get_Minute_Public_get_Int32_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_get_Now_Public_Static_get_DateTime_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_get_Second_Public_get_Int32_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Static_Boolean_Int32_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_DateTimeStyles_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_DateTimeStyles_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_Il2CppStringArray_IFormatProvider_DateTimeStyles_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_TimeSpan_DateTime_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_ToLocalTime_Public_DateTime_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_ToLocalTime_Internal_DateTime_Boolean_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_ToShortDateString_Public_String_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_ToShortTimeString_Public_String_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_ToUniversalTime_Public_DateTime_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_DateTime_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTime_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_String_IFormatProvider_DateTimeStyles_byref_DateTime_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DateTime_DateTime_TimeSpan_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DateTime_DateTime_TimeSpan_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTime_DateTime_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Internal_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTime_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeAsFileTime_Internal_Static_Int64_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_ToBinaryRaw_Internal_Int64_0;

		// Token: 0x04000751 RID: 1873
		[FieldOffset(0)]
		public readonly ulong _dateData;
	}
}
