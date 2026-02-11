using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004D RID: 77
	public sealed class DateTimeParser : ValueType
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x00032F44 File Offset: 0x00031144
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeParser()
		{
			Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "DateTimeParser");
			DateTimeParser.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Year");
			DateTimeParser.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Month");
			DateTimeParser.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Day");
			DateTimeParser.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Hour");
			DateTimeParser.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Minute");
			DateTimeParser.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Second");
			DateTimeParser.NativeFieldInfoPtr_Fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Fraction");
			DateTimeParser.NativeFieldInfoPtr_ZoneHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "ZoneHour");
			DateTimeParser.NativeFieldInfoPtr_ZoneMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "ZoneMinute");
			DateTimeParser.NativeFieldInfoPtr_Zone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Zone");
			DateTimeParser.NativeFieldInfoPtr__text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "_text");
			DateTimeParser.NativeFieldInfoPtr__end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "_end");
			DateTimeParser.NativeFieldInfoPtr_Power10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Power10");
			DateTimeParser.NativeFieldInfoPtr_Lzyyyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Lzyyyy");
			DateTimeParser.NativeFieldInfoPtr_Lzyyyy_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Lzyyyy_");
			DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Lzyyyy_MM");
			DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Lzyyyy_MM_");
			DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Lzyyyy_MM_dd");
			DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM_ddT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Lzyyyy_MM_ddT");
			DateTimeParser.NativeFieldInfoPtr_LzHH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "LzHH");
			DateTimeParser.NativeFieldInfoPtr_LzHH_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "LzHH_");
			DateTimeParser.NativeFieldInfoPtr_LzHH_mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "LzHH_mm");
			DateTimeParser.NativeFieldInfoPtr_LzHH_mm_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "LzHH_mm_");
			DateTimeParser.NativeFieldInfoPtr_LzHH_mm_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "LzHH_mm_ss");
			DateTimeParser.NativeFieldInfoPtr_Lz_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Lz_");
			DateTimeParser.NativeFieldInfoPtr_Lz_zz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "Lz_zz");
			DateTimeParser.NativeFieldInfoPtr_MaxFractionDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, "MaxFractionDigits");
			DateTimeParser.NativeMethodInfoPtr_Parse_Public_Boolean_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, 100664654);
			DateTimeParser.NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, 100664655);
			DateTimeParser.NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, 100664656);
			DateTimeParser.NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, 100664657);
			DateTimeParser.NativeMethodInfoPtr_ParseZone_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, 100664658);
			DateTimeParser.NativeMethodInfoPtr_Parse4Digit_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, 100664659);
			DateTimeParser.NativeMethodInfoPtr_Parse2Digit_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, 100664660);
			DateTimeParser.NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr, 100664661);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00033228 File Offset: 0x00031428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 741263, RefRangeEnd = 741265, XrefRangeStart = 741251, XrefRangeEnd = 741263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse(Il2CppStructArray<char> text, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParser.NativeMethodInfoPtr_Parse_Public_Boolean_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00033298 File Offset: 0x00031498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741283, RefRangeEnd = 741284, XrefRangeStart = 741265, XrefRangeEnd = 741283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseDate(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParser.NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000332E8 File Offset: 0x000314E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741288, RefRangeEnd = 741289, XrefRangeStart = 741284, XrefRangeEnd = 741288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseTimeAndZoneAndWhitespace(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParser.NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00033338 File Offset: 0x00031538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741308, RefRangeEnd = 741309, XrefRangeStart = 741289, XrefRangeEnd = 741308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseTime(ref int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParser.NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00033388 File Offset: 0x00031588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741309, XrefRangeEnd = 741327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseZone(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParser.NativeMethodInfoPtr_ParseZone_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000333D8 File Offset: 0x000315D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741327, RefRangeEnd = 741328, XrefRangeStart = 741327, XrefRangeEnd = 741327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse4Digit(int start, out int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParser.NativeMethodInfoPtr_Parse4Digit_Private_Boolean_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00033434 File Offset: 0x00031634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 741328, RefRangeEnd = 741329, XrefRangeStart = 741328, XrefRangeEnd = 741328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse2Digit(int start, out int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParser.NativeMethodInfoPtr_Parse2Digit_Private_Boolean_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00033490 File Offset: 0x00031690
		[CallerCount(0)]
		public unsafe bool ParseChar(int start, char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeParser.NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00004224 File Offset: 0x00002424
		public DateTimeParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0000422D File Offset: 0x0000242D
		public DateTimeParser()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeParser>.NativeClassPtr))
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x000334EC File Offset: 0x000316EC
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x0000423F File Offset: 0x0000243F
		public unsafe int Year
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00033514 File Offset: 0x00031714
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x0000425A File Offset: 0x0000245A
		public unsafe int Month
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0003353C File Offset: 0x0003173C
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00004275 File Offset: 0x00002475
		public unsafe int Day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00033564 File Offset: 0x00031764
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00004290 File Offset: 0x00002490
		public unsafe int Hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0003358C File Offset: 0x0003178C
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x000042AB File Offset: 0x000024AB
		public unsafe int Minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x000335B4 File Offset: 0x000317B4
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x000042C6 File Offset: 0x000024C6
		public unsafe int Second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x000335DC File Offset: 0x000317DC
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x000042E1 File Offset: 0x000024E1
		public unsafe int Fraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Fraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Fraction)) = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00033604 File Offset: 0x00031804
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x000042FC File Offset: 0x000024FC
		public unsafe int ZoneHour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_ZoneHour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_ZoneHour)) = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0003362C File Offset: 0x0003182C
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00004317 File Offset: 0x00002517
		public unsafe int ZoneMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_ZoneMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_ZoneMinute)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00033654 File Offset: 0x00031854
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00004332 File Offset: 0x00002532
		public unsafe ParserTimeZone Zone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Zone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr_Zone)) = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0003367C File Offset: 0x0003187C
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x0000434D File Offset: 0x0000254D
		public unsafe Il2CppStructArray<char> _text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr__text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr__text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x000336AC File Offset: 0x000318AC
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x0000436C File Offset: 0x0000256C
		public unsafe int _end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr__end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeParser.NativeFieldInfoPtr__end)) = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x000336D4 File Offset: 0x000318D4
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00004387 File Offset: 0x00002587
		public unsafe static Il2CppStructArray<int> Power10
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_Power10, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_Power10, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x000336FC File Offset: 0x000318FC
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00004399 File Offset: 0x00002599
		public unsafe static int Lzyyyy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy, (void*)(&value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00033718 File Offset: 0x00031918
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x000043A7 File Offset: 0x000025A7
		public unsafe static int Lzyyyy_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy_, (void*)(&value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00033734 File Offset: 0x00031934
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x000043B5 File Offset: 0x000025B5
		public unsafe static int Lzyyyy_MM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM, (void*)(&value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00033750 File Offset: 0x00031950
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x000043C3 File Offset: 0x000025C3
		public unsafe static int Lzyyyy_MM_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM_, (void*)(&value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x0003376C File Offset: 0x0003196C
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x000043D1 File Offset: 0x000025D1
		public unsafe static int Lzyyyy_MM_dd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM_dd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM_dd, (void*)(&value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00033788 File Offset: 0x00031988
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x000043DF File Offset: 0x000025DF
		public unsafe static int Lzyyyy_MM_ddT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM_ddT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_Lzyyyy_MM_ddT, (void*)(&value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x000337A4 File Offset: 0x000319A4
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x000043ED File Offset: 0x000025ED
		public unsafe static int LzHH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_LzHH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_LzHH, (void*)(&value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x000337C0 File Offset: 0x000319C0
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x000043FB File Offset: 0x000025FB
		public unsafe static int LzHH_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_LzHH_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_LzHH_, (void*)(&value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x000337DC File Offset: 0x000319DC
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00004409 File Offset: 0x00002609
		public unsafe static int LzHH_mm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_LzHH_mm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_LzHH_mm, (void*)(&value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x000337F8 File Offset: 0x000319F8
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00004417 File Offset: 0x00002617
		public unsafe static int LzHH_mm_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_LzHH_mm_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_LzHH_mm_, (void*)(&value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00033814 File Offset: 0x00031A14
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00004425 File Offset: 0x00002625
		public unsafe static int LzHH_mm_ss
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_LzHH_mm_ss, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_LzHH_mm_ss, (void*)(&value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00033830 File Offset: 0x00031A30
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00004433 File Offset: 0x00002633
		public unsafe static int Lz_
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_Lz_, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_Lz_, (void*)(&value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0003384C File Offset: 0x00031A4C
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00004441 File Offset: 0x00002641
		public unsafe static int Lz_zz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_Lz_zz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_Lz_zz, (void*)(&value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00033868 File Offset: 0x00031A68
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x0000444F File Offset: 0x0000264F
		public unsafe static short MaxFractionDigits
		{
			get
			{
				short num;
				IL2CPP.il2cpp_field_static_get_value(DateTimeParser.NativeFieldInfoPtr_MaxFractionDigits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeParser.NativeFieldInfoPtr_MaxFractionDigits, (void*)(&value));
			}
		}

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeFieldInfoPtr_Fraction;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeFieldInfoPtr_ZoneHour;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeFieldInfoPtr_ZoneMinute;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeFieldInfoPtr_Zone;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeFieldInfoPtr__text;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr__end;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeFieldInfoPtr_Power10;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_dd;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr_Lzyyyy_MM_ddT;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr_LzHH;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm_;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr_LzHH_mm_ss;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr_Lz_;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeFieldInfoPtr_Lz_zz;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeFieldInfoPtr_MaxFractionDigits;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Boolean_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_ParseZone_Private_Boolean_Int32_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_Parse4Digit_Private_Boolean_Int32_byref_Int32_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_Parse2Digit_Private_Boolean_Int32_byref_Int32_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0;
	}
}
