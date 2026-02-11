using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x02000092 RID: 146
	[Serializable]
	[StructLayout(2)]
	public struct SqlDateTime
	{
		// Token: 0x06000E1C RID: 3612 RVA: 0x00045F64 File Offset: 0x00044164
		// Note: this type is marked as 'beforefieldinit'.
		static SqlDateTime()
		{
			Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlDateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr);
			SqlDateTime.NativeFieldInfoPtr_m_fNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "m_fNotNull");
			SqlDateTime.NativeFieldInfoPtr_m_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "m_day");
			SqlDateTime.NativeFieldInfoPtr_m_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "m_time");
			SqlDateTime.NativeFieldInfoPtr_s_SQLTicksPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_SQLTicksPerMillisecond");
			SqlDateTime.NativeFieldInfoPtr_SQLTicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "SQLTicksPerSecond");
			SqlDateTime.NativeFieldInfoPtr_SQLTicksPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "SQLTicksPerMinute");
			SqlDateTime.NativeFieldInfoPtr_SQLTicksPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "SQLTicksPerHour");
			SqlDateTime.NativeFieldInfoPtr_s_SQLTicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_SQLTicksPerDay");
			SqlDateTime.NativeFieldInfoPtr_s_ticksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_ticksPerSecond");
			SqlDateTime.NativeFieldInfoPtr_s_SQLBaseDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_SQLBaseDate");
			SqlDateTime.NativeFieldInfoPtr_s_SQLBaseDateTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_SQLBaseDateTicks");
			SqlDateTime.NativeFieldInfoPtr_s_minYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_minYear");
			SqlDateTime.NativeFieldInfoPtr_s_maxYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_maxYear");
			SqlDateTime.NativeFieldInfoPtr_s_minDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_minDay");
			SqlDateTime.NativeFieldInfoPtr_s_maxDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_maxDay");
			SqlDateTime.NativeFieldInfoPtr_s_minTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_minTime");
			SqlDateTime.NativeFieldInfoPtr_s_maxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_maxTime");
			SqlDateTime.NativeFieldInfoPtr_s_dayBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_dayBase");
			SqlDateTime.NativeFieldInfoPtr_s_daysToMonth365 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_daysToMonth365");
			SqlDateTime.NativeFieldInfoPtr_s_daysToMonth366 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_daysToMonth366");
			SqlDateTime.NativeFieldInfoPtr_s_minDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_minDateTime");
			SqlDateTime.NativeFieldInfoPtr_s_maxDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_maxDateTime");
			SqlDateTime.NativeFieldInfoPtr_s_minTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_minTimeSpan");
			SqlDateTime.NativeFieldInfoPtr_s_maxTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_maxTimeSpan");
			SqlDateTime.NativeFieldInfoPtr_s_ISO8601_DateTimeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_ISO8601_DateTimeFormat");
			SqlDateTime.NativeFieldInfoPtr_s_dateTimeFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "s_dateTimeFormats");
			SqlDateTime.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "MinValue");
			SqlDateTime.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "MaxValue");
			SqlDateTime.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, "Null");
			SqlDateTime.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665609);
			SqlDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665610);
			SqlDateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665611);
			SqlDateTime.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665612);
			SqlDateTime.NativeMethodInfoPtr_ToTimeSpan_Private_Static_TimeSpan_SqlDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665613);
			SqlDateTime.NativeMethodInfoPtr_ToDateTime_Private_Static_DateTime_SqlDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665614);
			SqlDateTime.NativeMethodInfoPtr_FromTimeSpan_Private_Static_SqlDateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665615);
			SqlDateTime.NativeMethodInfoPtr_FromDateTime_Private_Static_SqlDateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665616);
			SqlDateTime.NativeMethodInfoPtr_get_Value_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665617);
			SqlDateTime.NativeMethodInfoPtr_get_DayTicks_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665618);
			SqlDateTime.NativeMethodInfoPtr_get_TimeTicks_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665619);
			SqlDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665620);
			SqlDateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665621);
			SqlDateTime.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665622);
			SqlDateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665623);
			SqlDateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665624);
			SqlDateTime.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665625);
			SqlDateTime.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665626);
			SqlDateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665627);
			SqlDateTime.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665628);
			SqlDateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665629);
			SqlDateTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665630);
			SqlDateTime.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665631);
			SqlDateTime.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665632);
			SqlDateTime.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665633);
			SqlDateTime.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, 100665634);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000463E0 File Offset: 0x000445E0
		[CallerCount(0)]
		public unsafe SqlDateTime(bool fNull)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00046414 File Offset: 0x00044614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916470, XrefRangeEnd = 916474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDateTime(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00046448 File Offset: 0x00044648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916484, RefRangeEnd = 916485, XrefRangeStart = 916474, XrefRangeEnd = 916484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDateTime(int dayTicks, int timeTicks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dayTicks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeTicks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00046488 File Offset: 0x00044688
		public unsafe bool IsNull
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000464B8 File Offset: 0x000446B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916485, XrefRangeEnd = 916489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan ToTimeSpan(SqlDateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_ToTimeSpan_Private_Static_TimeSpan_SqlDateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000464F8 File Offset: 0x000446F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 916501, RefRangeEnd = 916503, XrefRangeStart = 916489, XrefRangeEnd = 916501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(SqlDateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_ToDateTime_Private_Static_DateTime_SqlDateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00046538 File Offset: 0x00044738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916524, RefRangeEnd = 916525, XrefRangeStart = 916503, XrefRangeEnd = 916524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDateTime FromTimeSpan(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_FromTimeSpan_Private_Static_SqlDateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00046578 File Offset: 0x00044778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 916542, RefRangeEnd = 916544, XrefRangeStart = 916525, XrefRangeEnd = 916542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDateTime FromDateTime(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_FromDateTime_Private_Static_SqlDateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000465B8 File Offset: 0x000447B8
		public unsafe DateTime Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 916548, RefRangeEnd = 916549, XrefRangeStart = 916544, XrefRangeEnd = 916548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_get_Value_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x000465E8 File Offset: 0x000447E8
		public unsafe int DayTicks
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_get_DayTicks_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00046618 File Offset: 0x00044818
		public unsafe int TimeTicks
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_get_TimeTicks_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00046648 File Offset: 0x00044848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916553, RefRangeEnd = 916554, XrefRangeStart = 916549, XrefRangeEnd = 916553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDateTime(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00046688 File Offset: 0x00044888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916554, XrefRangeEnd = 916564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000466B4 File Offset: 0x000448B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916564, XrefRangeEnd = 916572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlDateTime x, SqlDateTime y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00046700 File Offset: 0x00044900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916581, RefRangeEnd = 916582, XrefRangeStart = 916572, XrefRangeEnd = 916581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator <(SqlDateTime x, SqlDateTime y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0004674C File Offset: 0x0004494C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916591, RefRangeEnd = 916592, XrefRangeStart = 916582, XrefRangeEnd = 916591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator >(SqlDateTime x, SqlDateTime y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00046798 File Offset: 0x00044998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916604, RefRangeEnd = 916605, XrefRangeStart = 916592, XrefRangeEnd = 916604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x000467E4 File Offset: 0x000449E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916617, RefRangeEnd = 916618, XrefRangeStart = 916605, XrefRangeEnd = 916617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00046830 File Offset: 0x00044A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916618, XrefRangeEnd = 916624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00046874 File Offset: 0x00044A74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 916642, RefRangeEnd = 916646, XrefRangeStart = 916624, XrefRangeEnd = 916642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlDateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlDateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x000468B4 File Offset: 0x00044AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916646, XrefRangeEnd = 916671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x000468F8 File Offset: 0x00044AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916671, XrefRangeEnd = 916676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00046928 File Offset: 0x00044B28
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0004695C File Offset: 0x00044B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916676, XrefRangeEnd = 916686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00046994 File Offset: 0x00044B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916686, XrefRangeEnd = 916706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000469CC File Offset: 0x00044BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916706, XrefRangeEnd = 916714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDateTime.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00006640 File Offset: 0x00004840
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlDateTime>.NativeClassPtr, ref this));
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00046A10 File Offset: 0x00044C10
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00006652 File Offset: 0x00004852
		public unsafe static double s_SQLTicksPerMillisecond
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_SQLTicksPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_SQLTicksPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00046A2C File Offset: 0x00044C2C
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00006660 File Offset: 0x00004860
		public unsafe static int SQLTicksPerSecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_SQLTicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_SQLTicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00046A48 File Offset: 0x00044C48
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x0000666E File Offset: 0x0000486E
		public unsafe static int SQLTicksPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_SQLTicksPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_SQLTicksPerMinute, (void*)(&value));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00046A64 File Offset: 0x00044C64
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x0000667C File Offset: 0x0000487C
		public unsafe static int SQLTicksPerHour
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_SQLTicksPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_SQLTicksPerHour, (void*)(&value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00046A80 File Offset: 0x00044C80
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x0000668A File Offset: 0x0000488A
		public unsafe static int s_SQLTicksPerDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_SQLTicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_SQLTicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00046A9C File Offset: 0x00044C9C
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00006698 File Offset: 0x00004898
		public unsafe static long s_ticksPerSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_ticksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_ticksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00046AB8 File Offset: 0x00044CB8
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x000066A6 File Offset: 0x000048A6
		public unsafe static DateTime s_SQLBaseDate
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_SQLBaseDate, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_SQLBaseDate, (void*)(&value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00046AD4 File Offset: 0x00044CD4
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x000066B4 File Offset: 0x000048B4
		public unsafe static long s_SQLBaseDateTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_SQLBaseDateTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_SQLBaseDateTicks, (void*)(&value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00046AF0 File Offset: 0x00044CF0
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x000066C2 File Offset: 0x000048C2
		public unsafe static int s_minYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_minYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_minYear, (void*)(&value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00046B0C File Offset: 0x00044D0C
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x000066D0 File Offset: 0x000048D0
		public unsafe static int s_maxYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_maxYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_maxYear, (void*)(&value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00046B28 File Offset: 0x00044D28
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x000066DE File Offset: 0x000048DE
		public unsafe static int s_minDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_minDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_minDay, (void*)(&value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00046B44 File Offset: 0x00044D44
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x000066EC File Offset: 0x000048EC
		public unsafe static int s_maxDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_maxDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_maxDay, (void*)(&value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00046B60 File Offset: 0x00044D60
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x000066FA File Offset: 0x000048FA
		public unsafe static int s_minTime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_minTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_minTime, (void*)(&value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00046B7C File Offset: 0x00044D7C
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x00006708 File Offset: 0x00004908
		public unsafe static int s_maxTime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_maxTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_maxTime, (void*)(&value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00046B98 File Offset: 0x00044D98
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00006716 File Offset: 0x00004916
		public unsafe static int s_dayBase
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_dayBase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_dayBase, (void*)(&value));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00046BB4 File Offset: 0x00044DB4
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00006724 File Offset: 0x00004924
		public unsafe static Il2CppStructArray<int> s_daysToMonth365
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_daysToMonth365, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_daysToMonth365, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00046BDC File Offset: 0x00044DDC
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00006736 File Offset: 0x00004936
		public unsafe static Il2CppStructArray<int> s_daysToMonth366
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_daysToMonth366, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_daysToMonth366, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00046C04 File Offset: 0x00044E04
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00006748 File Offset: 0x00004948
		public unsafe static DateTime s_minDateTime
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_minDateTime, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_minDateTime, (void*)(&value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00046C20 File Offset: 0x00044E20
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00006756 File Offset: 0x00004956
		public unsafe static DateTime s_maxDateTime
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_maxDateTime, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_maxDateTime, (void*)(&value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00046C3C File Offset: 0x00044E3C
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x00006764 File Offset: 0x00004964
		public unsafe static TimeSpan s_minTimeSpan
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_minTimeSpan, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_minTimeSpan, (void*)(&value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00046C58 File Offset: 0x00044E58
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00006772 File Offset: 0x00004972
		public unsafe static TimeSpan s_maxTimeSpan
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_maxTimeSpan, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_maxTimeSpan, (void*)(&value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00046C74 File Offset: 0x00044E74
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00006780 File Offset: 0x00004980
		public unsafe static string s_ISO8601_DateTimeFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_ISO8601_DateTimeFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_ISO8601_DateTimeFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00046C94 File Offset: 0x00044E94
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00006792 File Offset: 0x00004992
		public unsafe static Il2CppStringArray s_dateTimeFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_s_dateTimeFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_s_dateTimeFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00046CBC File Offset: 0x00044EBC
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x000067A4 File Offset: 0x000049A4
		public unsafe static SqlDateTime MinValue
		{
			get
			{
				SqlDateTime sqlDateTime;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_MinValue, (void*)(&sqlDateTime));
				return sqlDateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00046CD8 File Offset: 0x00044ED8
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x000067B2 File Offset: 0x000049B2
		public unsafe static SqlDateTime MaxValue
		{
			get
			{
				SqlDateTime sqlDateTime;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_MaxValue, (void*)(&sqlDateTime));
				return sqlDateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00046CF4 File Offset: 0x00044EF4
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x000067C0 File Offset: 0x000049C0
		public unsafe static SqlDateTime Null
		{
			get
			{
				SqlDateTime sqlDateTime;
				IL2CPP.il2cpp_field_static_get_value(SqlDateTime.NativeFieldInfoPtr_Null, (void*)(&sqlDateTime));
				return sqlDateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDateTime.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeFieldInfoPtr_m_fNotNull;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeFieldInfoPtr_m_day;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeFieldInfoPtr_m_time;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeFieldInfoPtr_s_SQLTicksPerMillisecond;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeFieldInfoPtr_SQLTicksPerSecond;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeFieldInfoPtr_SQLTicksPerMinute;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeFieldInfoPtr_SQLTicksPerHour;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeFieldInfoPtr_s_SQLTicksPerDay;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeFieldInfoPtr_s_ticksPerSecond;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeFieldInfoPtr_s_SQLBaseDate;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeFieldInfoPtr_s_SQLBaseDateTicks;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeFieldInfoPtr_s_minYear;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeFieldInfoPtr_s_maxYear;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeFieldInfoPtr_s_minDay;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeFieldInfoPtr_s_maxDay;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeFieldInfoPtr_s_minTime;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeFieldInfoPtr_s_maxTime;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_s_dayBase;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_s_daysToMonth365;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr_s_daysToMonth366;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr_s_minDateTime;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr_s_maxDateTime;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeFieldInfoPtr_s_minTimeSpan;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeFieldInfoPtr_s_maxTimeSpan;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr_s_ISO8601_DateTimeFormat;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr_s_dateTimeFormats;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_ToTimeSpan_Private_Static_TimeSpan_SqlDateTime_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Private_Static_DateTime_SqlDateTime_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_FromTimeSpan_Private_Static_SqlDateTime_TimeSpan_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_FromDateTime_Private_Static_SqlDateTime_DateTime_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_DateTime_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_get_DayTicks_Public_get_Int32_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeTicks_Public_get_Int32_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDateTime_DateTime_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlDateTime_SqlDateTime_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlDateTime_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000BE9 RID: 3049
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_fNotNull;

		// Token: 0x04000BEA RID: 3050
		[FieldOffset(4)]
		public int m_day;

		// Token: 0x04000BEB RID: 3051
		[FieldOffset(8)]
		public int m_time;
	}
}
