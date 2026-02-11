using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000010 RID: 16
	public class BinXmlDateTime : Object
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00017858 File Offset: 0x00015A58
		// Note: this type is marked as 'beforefieldinit'.
		static BinXmlDateTime()
		{
			Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinXmlDateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr);
			BinXmlDateTime.NativeFieldInfoPtr_KatmaiTimeScaleMultiplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, "KatmaiTimeScaleMultiplicator");
			BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, "SQLTicksPerMillisecond");
			BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, "SQLTicksPerSecond");
			BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, "SQLTicksPerMinute");
			BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, "SQLTicksPerHour");
			BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, "SQLTicksPerDay");
			BinXmlDateTime.NativeMethodInfoPtr_Write2Dig_Private_Static_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663332);
			BinXmlDateTime.NativeMethodInfoPtr_Write4DigNeg_Private_Static_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663333);
			BinXmlDateTime.NativeMethodInfoPtr_Write3Dec_Private_Static_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663334);
			BinXmlDateTime.NativeMethodInfoPtr_WriteDate_Private_Static_Void_StringBuilder_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663335);
			BinXmlDateTime.NativeMethodInfoPtr_WriteTime_Private_Static_Void_StringBuilder_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663336);
			BinXmlDateTime.NativeMethodInfoPtr_WriteTimeFullPrecision_Private_Static_Void_StringBuilder_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663337);
			BinXmlDateTime.NativeMethodInfoPtr_WriteTimeZone_Private_Static_Void_StringBuilder_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663338);
			BinXmlDateTime.NativeMethodInfoPtr_WriteTimeZone_Private_Static_Void_StringBuilder_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663339);
			BinXmlDateTime.NativeMethodInfoPtr_BreakDownXsdDateTime_Private_Static_Void_Int64_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663340);
			BinXmlDateTime.NativeMethodInfoPtr_BreakDownXsdDate_Private_Static_Void_Int64_byref_Int32_byref_Int32_byref_Int32_byref_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663341);
			BinXmlDateTime.NativeMethodInfoPtr_BreakDownXsdTime_Private_Static_Void_Int64_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663342);
			BinXmlDateTime.NativeMethodInfoPtr_XsdDateTimeToString_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663343);
			BinXmlDateTime.NativeMethodInfoPtr_XsdDateToString_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663344);
			BinXmlDateTime.NativeMethodInfoPtr_XsdTimeToString_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663345);
			BinXmlDateTime.NativeMethodInfoPtr_SqlDateTimeToString_Public_Static_String_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663346);
			BinXmlDateTime.NativeMethodInfoPtr_SqlDateTimeToDateTime_Public_Static_DateTime_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663347);
			BinXmlDateTime.NativeMethodInfoPtr_SqlSmallDateTimeToString_Public_Static_String_Int16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663348);
			BinXmlDateTime.NativeMethodInfoPtr_SqlSmallDateTimeToDateTime_Public_Static_DateTime_Int16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663349);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateToDateTime_Public_Static_DateTime_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663350);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateTimeToDateTime_Public_Static_DateTime_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663351);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiTimeToDateTime_Public_Static_DateTime_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663352);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateOffsetToDateTimeOffset_Public_Static_DateTimeOffset_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663353);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateTimeOffsetToDateTimeOffset_Public_Static_DateTimeOffset_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663354);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiTimeOffsetToDateTimeOffset_Public_Static_DateTimeOffset_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663355);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663356);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateTimeToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663357);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiTimeToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663358);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateOffsetToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663359);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateTimeOffsetToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663360);
			BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiTimeOffsetToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663361);
			BinXmlDateTime.NativeMethodInfoPtr_GetKatmaiDateTicks_Private_Static_Int64_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663362);
			BinXmlDateTime.NativeMethodInfoPtr_GetKatmaiTimeTicks_Private_Static_Int64_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663363);
			BinXmlDateTime.NativeMethodInfoPtr_GetKatmaiTimeZoneTicks_Private_Static_Int64_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663364);
			BinXmlDateTime.NativeMethodInfoPtr_GetFractions_Private_Static_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663365);
			BinXmlDateTime.NativeMethodInfoPtr_GetFractions_Private_Static_Int32_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlDateTime>.NativeClassPtr, 100663366);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00017BBC File Offset: 0x00015DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362332, XrefRangeEnd = 362335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write2Dig(StringBuilder sb, int val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_Write2Dig_Private_Static_Void_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00017C00 File Offset: 0x00015E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362344, RefRangeEnd = 362345, XrefRangeStart = 362335, XrefRangeEnd = 362344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write4DigNeg(StringBuilder sb, int val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_Write4DigNeg_Private_Static_Void_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00017C44 File Offset: 0x00015E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362345, XrefRangeEnd = 362350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write3Dec(StringBuilder sb, int val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_Write3Dec_Private_Static_Void_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00017C88 File Offset: 0x00015E88
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 362361, RefRangeEnd = 362368, XrefRangeStart = 362350, XrefRangeEnd = 362361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteDate(StringBuilder sb, int yr, int mnth, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mnth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_WriteDate_Private_Static_Void_StringBuilder_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00017CE8 File Offset: 0x00015EE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362385, RefRangeEnd = 362387, XrefRangeStart = 362368, XrefRangeEnd = 362385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sec;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ms;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_WriteTime_Private_Static_Void_StringBuilder_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00017D58 File Offset: 0x00015F58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 362403, RefRangeEnd = 362408, XrefRangeStart = 362387, XrefRangeEnd = 362403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sec;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_WriteTimeFullPrecision_Private_Static_Void_StringBuilder_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00017DC8 File Offset: 0x00015FC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 362422, RefRangeEnd = 362427, XrefRangeStart = 362408, XrefRangeEnd = 362422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteTimeZone(StringBuilder sb, TimeSpan zone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_WriteTimeZone_Private_Static_Void_StringBuilder_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00017E0C File Offset: 0x0001600C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362438, RefRangeEnd = 362440, XrefRangeStart = 362427, XrefRangeEnd = 362438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negTimeZone;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_WriteTimeZone_Private_Static_Void_StringBuilder_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00017E6C File Offset: 0x0001606C
		[CallerCount(0)]
		public unsafe static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &yr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mnth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &day;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sec;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ms;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_BreakDownXsdDateTime_Private_Static_Void_Int64_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00017F04 File Offset: 0x00016104
		[CallerCount(0)]
		public unsafe static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &yr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mnth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &day;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &negTimeZone;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_BreakDownXsdDate_Private_Static_Void_Int64_byref_Int32_byref_Int32_byref_Int32_byref_Boolean_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00017F90 File Offset: 0x00016190
		[CallerCount(0)]
		public unsafe static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sec;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ms;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_BreakDownXsdTime_Private_Static_Void_Int64_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00017FFC File Offset: 0x000161FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362440, XrefRangeEnd = 362458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XsdDateTimeToString(long val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdDateTimeToString_Public_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00018034 File Offset: 0x00016234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362458, XrefRangeEnd = 362474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XsdDateToString(long val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdDateToString_Public_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0001806C File Offset: 0x0001626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362474, XrefRangeEnd = 362505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XsdTimeToString(long val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdTimeToString_Public_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000180A4 File Offset: 0x000162A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362505, XrefRangeEnd = 362524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SqlDateTimeToString(int dateticks, uint timeticks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeticks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_SqlDateTimeToString_Public_Static_String_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000180EC File Offset: 0x000162EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 362533, RefRangeEnd = 362538, XrefRangeStart = 362524, XrefRangeEnd = 362533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeticks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_SqlDateTimeToDateTime_Public_Static_DateTime_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00018138 File Offset: 0x00016338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362538, XrefRangeEnd = 362556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SqlSmallDateTimeToString(short dateticks, ushort timeticks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeticks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_SqlSmallDateTimeToString_Public_Static_String_Int16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00018180 File Offset: 0x00016380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362556, XrefRangeEnd = 362561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeticks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_SqlSmallDateTimeToDateTime_Public_Static_DateTime_Int16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000181CC File Offset: 0x000163CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362561, XrefRangeEnd = 362565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime XsdKatmaiDateToDateTime(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateToDateTime_Public_Static_DateTime_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0001821C File Offset: 0x0001641C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 362570, RefRangeEnd = 362573, XrefRangeStart = 362565, XrefRangeEnd = 362570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime XsdKatmaiDateTimeToDateTime(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateTimeToDateTime_Public_Static_DateTime_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0001826C File Offset: 0x0001646C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362573, XrefRangeEnd = 362577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime XsdKatmaiTimeToDateTime(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiTimeToDateTime_Public_Static_DateTime_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000182BC File Offset: 0x000164BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362577, XrefRangeEnd = 362581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateOffsetToDateTimeOffset_Public_Static_DateTimeOffset_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0001830C File Offset: 0x0001650C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 362586, RefRangeEnd = 362593, XrefRangeStart = 362581, XrefRangeEnd = 362586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateTimeOffsetToDateTimeOffset_Public_Static_DateTimeOffset_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0001835C File Offset: 0x0001655C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362593, XrefRangeEnd = 362597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiTimeOffsetToDateTimeOffset_Public_Static_DateTimeOffset_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000183AC File Offset: 0x000165AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362597, XrefRangeEnd = 362615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XsdKatmaiDateToString(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000183F8 File Offset: 0x000165F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362615, XrefRangeEnd = 362636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XsdKatmaiDateTimeToString(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateTimeToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00018444 File Offset: 0x00016644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362636, XrefRangeEnd = 362655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XsdKatmaiTimeToString(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiTimeToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00018490 File Offset: 0x00016690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362655, XrefRangeEnd = 362675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XsdKatmaiDateOffsetToString(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateOffsetToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000184DC File Offset: 0x000166DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362698, RefRangeEnd = 362699, XrefRangeStart = 362675, XrefRangeEnd = 362698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XsdKatmaiDateTimeOffsetToString(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiDateTimeOffsetToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00018528 File Offset: 0x00016728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362699, XrefRangeEnd = 362720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XsdKatmaiTimeOffsetToString(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_XsdKatmaiTimeOffsetToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00018574 File Offset: 0x00016774
		[CallerCount(0)]
		public unsafe static long GetKatmaiDateTicks(Il2CppStructArray<byte> data, ref int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_GetKatmaiDateTicks_Private_Static_Int64_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000185C4 File Offset: 0x000167C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362726, RefRangeEnd = 362728, XrefRangeStart = 362720, XrefRangeEnd = 362726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetKatmaiTimeTicks(Il2CppStructArray<byte> data, ref int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_GetKatmaiTimeTicks_Private_Static_Int64_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00018614 File Offset: 0x00016814
		[CallerCount(0)]
		public unsafe static long GetKatmaiTimeZoneTicks(Il2CppStructArray<byte> data, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_GetKatmaiTimeZoneTicks_Private_Static_Int64_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00018664 File Offset: 0x00016864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362740, RefRangeEnd = 362742, XrefRangeStart = 362728, XrefRangeEnd = 362740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFractions(DateTime dt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_GetFractions_Private_Static_Int32_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000186A4 File Offset: 0x000168A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 362757, RefRangeEnd = 362760, XrefRangeStart = 362742, XrefRangeEnd = 362757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFractions(DateTimeOffset dt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlDateTime.NativeMethodInfoPtr_GetFractions_Private_Static_Int32_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000023E3 File Offset: 0x000005E3
		public BinXmlDateTime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000186E4 File Offset: 0x000168E4
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000023EC File Offset: 0x000005EC
		public unsafe static Il2CppStructArray<int> KatmaiTimeScaleMultiplicator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinXmlDateTime.NativeFieldInfoPtr_KatmaiTimeScaleMultiplicator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlDateTime.NativeFieldInfoPtr_KatmaiTimeScaleMultiplicator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0001870C File Offset: 0x0001690C
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000023FE File Offset: 0x000005FE
		public unsafe static double SQLTicksPerMillisecond
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00018728 File Offset: 0x00016928
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000240C File Offset: 0x0000060C
		public unsafe static int SQLTicksPerSecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00018744 File Offset: 0x00016944
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000241A File Offset: 0x0000061A
		public unsafe static int SQLTicksPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerMinute, (void*)(&value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00018760 File Offset: 0x00016960
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002428 File Offset: 0x00000628
		public unsafe static int SQLTicksPerHour
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerHour, (void*)(&value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0001877C File Offset: 0x0001697C
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002436 File Offset: 0x00000636
		public unsafe static int SQLTicksPerDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinXmlDateTime.NativeFieldInfoPtr_SQLTicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_KatmaiTimeScaleMultiplicator;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_SQLTicksPerMillisecond;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_SQLTicksPerSecond;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_SQLTicksPerMinute;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_SQLTicksPerHour;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_SQLTicksPerDay;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_Write2Dig_Private_Static_Void_StringBuilder_Int32_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_Write4DigNeg_Private_Static_Void_StringBuilder_Int32_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_Write3Dec_Private_Static_Void_StringBuilder_Int32_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_WriteDate_Private_Static_Void_StringBuilder_Int32_Int32_Int32_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_WriteTime_Private_Static_Void_StringBuilder_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_WriteTimeFullPrecision_Private_Static_Void_StringBuilder_Int32_Int32_Int32_Int32_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_WriteTimeZone_Private_Static_Void_StringBuilder_TimeSpan_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_WriteTimeZone_Private_Static_Void_StringBuilder_Boolean_Int32_Int32_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_BreakDownXsdDateTime_Private_Static_Void_Int64_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_BreakDownXsdDate_Private_Static_Void_Int64_byref_Int32_byref_Int32_byref_Int32_byref_Boolean_byref_Int32_byref_Int32_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_BreakDownXsdTime_Private_Static_Void_Int64_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_XsdDateTimeToString_Public_Static_String_Int64_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_XsdDateToString_Public_Static_String_Int64_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_XsdTimeToString_Public_Static_String_Int64_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_SqlDateTimeToString_Public_Static_String_Int32_UInt32_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_SqlDateTimeToDateTime_Public_Static_DateTime_Int32_UInt32_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_SqlSmallDateTimeToString_Public_Static_String_Int16_UInt16_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_SqlSmallDateTimeToDateTime_Public_Static_DateTime_Int16_UInt16_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiDateToDateTime_Public_Static_DateTime_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiDateTimeToDateTime_Public_Static_DateTime_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiTimeToDateTime_Public_Static_DateTime_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiDateOffsetToDateTimeOffset_Public_Static_DateTimeOffset_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiDateTimeOffsetToDateTimeOffset_Public_Static_DateTimeOffset_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiTimeOffsetToDateTimeOffset_Public_Static_DateTimeOffset_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiDateToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiDateTimeToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiTimeToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiDateOffsetToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiDateTimeOffsetToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiTimeOffsetToString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_GetKatmaiDateTicks_Private_Static_Int64_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_GetKatmaiTimeTicks_Private_Static_Int64_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_GetKatmaiTimeZoneTicks_Private_Static_Int64_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_GetFractions_Private_Static_Int32_DateTime_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_GetFractions_Private_Static_Int32_DateTimeOffset_0;
	}
}
