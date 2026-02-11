using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000A0 RID: 160
	public sealed class DateTimeResult : ValueType
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x0005822C File Offset: 0x0005642C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeResult()
		{
			Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr);
			DateTimeResult.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Year");
			DateTimeResult.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Month");
			DateTimeResult.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Day");
			DateTimeResult.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Hour");
			DateTimeResult.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Minute");
			DateTimeResult.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Second");
			DateTimeResult.NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "fraction");
			DateTimeResult.NativeFieldInfoPtr_era = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "era");
			DateTimeResult.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "flags");
			DateTimeResult.NativeFieldInfoPtr_timeZoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "timeZoneOffset");
			DateTimeResult.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "calendar");
			DateTimeResult.NativeFieldInfoPtr_parsedDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "parsedDate");
			DateTimeResult.NativeFieldInfoPtr_failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failure");
			DateTimeResult.NativeFieldInfoPtr_failureMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failureMessageID");
			DateTimeResult.NativeFieldInfoPtr_failureMessageFormatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failureMessageFormatArgument");
			DateTimeResult.NativeFieldInfoPtr_failureArgumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failureArgumentName");
			DateTimeResult.NativeFieldInfoPtr_originalDateTimeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "originalDateTimeString");
			DateTimeResult.NativeFieldInfoPtr_failedFormatSpecifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failedFormatSpecifier");
			DateTimeResult.NativeMethodInfoPtr_Init_Internal_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665218);
			DateTimeResult.NativeMethodInfoPtr_SetDate_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665219);
			DateTimeResult.NativeMethodInfoPtr_SetBadFormatSpecifierFailure_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665220);
			DateTimeResult.NativeMethodInfoPtr_SetBadFormatSpecifierFailure_Internal_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665221);
			DateTimeResult.NativeMethodInfoPtr_SetBadDateTimeFailure_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665222);
			DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665223);
			DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665224);
			DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665225);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00058464 File Offset: 0x00056664
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1307376, RefRangeEnd = 1307395, XrefRangeStart = 1307376, XrefRangeEnd = 1307376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ReadOnlySpan<char> originalDateTimeString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(originalDateTimeString));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_Init_Internal_Void_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x000584B0 File Offset: 0x000566B0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 556229, RefRangeEnd = 556238, XrefRangeStart = 556229, XrefRangeEnd = 556238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDate(int year, int month, int day)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetDate_Internal_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00058510 File Offset: 0x00056710
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1307400, RefRangeEnd = 1307407, XrefRangeStart = 1307395, XrefRangeEnd = 1307400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBadFormatSpecifierFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetBadFormatSpecifierFailure_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00058548 File Offset: 0x00056748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307409, RefRangeEnd = 1307410, XrefRangeStart = 1307407, XrefRangeEnd = 1307409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBadFormatSpecifierFailure(ReadOnlySpan<char> failedFormatSpecifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(failedFormatSpecifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetBadFormatSpecifierFailure_Internal_Void_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00058594 File Offset: 0x00056794
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1307412, RefRangeEnd = 1307426, XrefRangeStart = 1307410, XrefRangeEnd = 1307412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBadDateTimeFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetBadDateTimeFailure_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x000585CC File Offset: 0x000567CC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1307426, RefRangeEnd = 1307436, XrefRangeStart = 1307426, XrefRangeEnd = 1307426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailure(ParseFailureKind failure, string failureMessageID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref failure;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00058624 File Offset: 0x00056824
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1307436, RefRangeEnd = 1307446, XrefRangeStart = 1307436, XrefRangeEnd = 1307436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailure(ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref failure;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0005868C File Offset: 0x0005688C
		[CallerCount(0)]
		public unsafe void SetFailure(ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument, string failureArgumentName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref failure;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureArgumentName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00004A6E File Offset: 0x00002C6E
		public DateTimeResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00004A77 File Offset: 0x00002C77
		public DateTimeResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr))
		{
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00058708 File Offset: 0x00056908
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00004A89 File Offset: 0x00002C89
		public unsafe int Year
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00058730 File Offset: 0x00056930
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00004AA4 File Offset: 0x00002CA4
		public unsafe int Month
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00058758 File Offset: 0x00056958
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00004ABF File Offset: 0x00002CBF
		public unsafe int Day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x00058780 File Offset: 0x00056980
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x00004ADA File Offset: 0x00002CDA
		public unsafe int Hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x000587A8 File Offset: 0x000569A8
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x00004AF5 File Offset: 0x00002CF5
		public unsafe int Minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x000587D0 File Offset: 0x000569D0
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00004B10 File Offset: 0x00002D10
		public unsafe int Second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x000587F8 File Offset: 0x000569F8
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00004B2B File Offset: 0x00002D2B
		public unsafe double fraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_fraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_fraction)) = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00058820 File Offset: 0x00056A20
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00004B46 File Offset: 0x00002D46
		public unsafe int era
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_era);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_era)) = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00058848 File Offset: 0x00056A48
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00004B61 File Offset: 0x00002D61
		public unsafe ParseFlags flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00058870 File Offset: 0x00056A70
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x00004B7C File Offset: 0x00002D7C
		public unsafe TimeSpan timeZoneOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_timeZoneOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_timeZoneOffset)) = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00058898 File Offset: 0x00056A98
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00004B97 File Offset: 0x00002D97
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x000588C8 File Offset: 0x00056AC8
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00004BB6 File Offset: 0x00002DB6
		public unsafe DateTime parsedDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_parsedDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_parsedDate)) = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x000588F0 File Offset: 0x00056AF0
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00004BD1 File Offset: 0x00002DD1
		public unsafe ParseFailureKind failure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failure)) = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00058918 File Offset: 0x00056B18
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x00004BEC File Offset: 0x00002DEC
		public unsafe string failureMessageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00058940 File Offset: 0x00056B40
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00004C0B File Offset: 0x00002E0B
		public unsafe Object failureMessageFormatArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageFormatArgument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageFormatArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00058970 File Offset: 0x00056B70
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00004C2A File Offset: 0x00002E2A
		public unsafe string failureArgumentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureArgumentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureArgumentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00058998 File Offset: 0x00056B98
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x00004C49 File Offset: 0x00002E49
		public ReadOnlySpan<char> originalDateTimeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_originalDateTimeString);
				return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_originalDateTimeString), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x000589C8 File Offset: 0x00056BC8
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x00004C77 File Offset: 0x00002E77
		public ReadOnlySpan<char> failedFormatSpecifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failedFormatSpecifier);
				return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failedFormatSpecifier), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_fraction;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_era;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_timeZoneOffset;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_parsedDate;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_failure;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_failureMessageID;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_failureMessageFormatArgument;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_failureArgumentName;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_originalDateTimeString;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeFieldInfoPtr_failedFormatSpecifier;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_ReadOnlySpan_1_Char_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_SetDate_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_SetBadFormatSpecifierFailure_Internal_Void_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_SetBadFormatSpecifierFailure_Internal_Void_ReadOnlySpan_1_Char_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_SetBadDateTimeFailure_Internal_Void_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_0;
	}
}
