using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000F0 RID: 240
	[Serializable]
	[StructLayout(2)]
	public struct TimeSpan
	{
		// Token: 0x06000F3B RID: 3899 RVA: 0x0006CFBC File Offset: 0x0006B1BC
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpan()
		{
			Il2CppClassPointerStore<TimeSpan>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeSpan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr);
			TimeSpan.NativeFieldInfoPtr_TicksPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerMillisecond");
			TimeSpan.NativeFieldInfoPtr_MillisecondsPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MillisecondsPerTick");
			TimeSpan.NativeFieldInfoPtr_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerSecond");
			TimeSpan.NativeFieldInfoPtr_SecondsPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "SecondsPerTick");
			TimeSpan.NativeFieldInfoPtr_TicksPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerMinute");
			TimeSpan.NativeFieldInfoPtr_MinutesPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MinutesPerTick");
			TimeSpan.NativeFieldInfoPtr_TicksPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerHour");
			TimeSpan.NativeFieldInfoPtr_HoursPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "HoursPerTick");
			TimeSpan.NativeFieldInfoPtr_TicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerDay");
			TimeSpan.NativeFieldInfoPtr_DaysPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "DaysPerTick");
			TimeSpan.NativeFieldInfoPtr_MillisPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MillisPerSecond");
			TimeSpan.NativeFieldInfoPtr_MillisPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MillisPerMinute");
			TimeSpan.NativeFieldInfoPtr_MillisPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MillisPerHour");
			TimeSpan.NativeFieldInfoPtr_MillisPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MillisPerDay");
			TimeSpan.NativeFieldInfoPtr_MaxSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MaxSeconds");
			TimeSpan.NativeFieldInfoPtr_MinSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MinSeconds");
			TimeSpan.NativeFieldInfoPtr_MaxMilliSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MaxMilliSeconds");
			TimeSpan.NativeFieldInfoPtr_MinMilliSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MinMilliSeconds");
			TimeSpan.NativeFieldInfoPtr_TicksPerTenthSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerTenthSecond");
			TimeSpan.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "Zero");
			TimeSpan.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MaxValue");
			TimeSpan.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MinValue");
			TimeSpan.NativeFieldInfoPtr__ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "_ticks");
			TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665957);
			TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665958);
			TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665959);
			TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665960);
			TimeSpan.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665961);
			TimeSpan.NativeMethodInfoPtr_get_Days_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665962);
			TimeSpan.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665963);
			TimeSpan.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665964);
			TimeSpan.NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665965);
			TimeSpan.NativeMethodInfoPtr_get_TotalDays_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665966);
			TimeSpan.NativeMethodInfoPtr_get_TotalHours_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665967);
			TimeSpan.NativeMethodInfoPtr_get_TotalMilliseconds_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665968);
			TimeSpan.NativeMethodInfoPtr_get_TotalMinutes_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665969);
			TimeSpan.NativeMethodInfoPtr_get_TotalSeconds_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665970);
			TimeSpan.NativeMethodInfoPtr_Add_Public_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665971);
			TimeSpan.NativeMethodInfoPtr_Compare_Public_Static_Int32_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665972);
			TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665973);
			TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665974);
			TimeSpan.NativeMethodInfoPtr_FromDays_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665975);
			TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665976);
			TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665977);
			TimeSpan.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665978);
			TimeSpan.NativeMethodInfoPtr_FromHours_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665979);
			TimeSpan.NativeMethodInfoPtr_Interval_Private_Static_TimeSpan_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665980);
			TimeSpan.NativeMethodInfoPtr_FromMilliseconds_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665981);
			TimeSpan.NativeMethodInfoPtr_FromMinutes_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665982);
			TimeSpan.NativeMethodInfoPtr_Negate_Public_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665983);
			TimeSpan.NativeMethodInfoPtr_FromSeconds_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665984);
			TimeSpan.NativeMethodInfoPtr_Subtract_Public_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665985);
			TimeSpan.NativeMethodInfoPtr_FromTicks_Public_Static_TimeSpan_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665986);
			TimeSpan.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665987);
			TimeSpan.NativeMethodInfoPtr_Parse_Public_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665988);
			TimeSpan.NativeMethodInfoPtr_Parse_Public_Static_TimeSpan_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665989);
			TimeSpan.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665990);
			TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665991);
			TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665992);
			TimeSpan.NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665993);
			TimeSpan.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665994);
			TimeSpan.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665995);
			TimeSpan.NativeMethodInfoPtr_op_Addition_Public_Static_TimeSpan_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665996);
			TimeSpan.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665997);
			TimeSpan.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665998);
			TimeSpan.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100665999);
			TimeSpan.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666000);
			TimeSpan.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666001);
			TimeSpan.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666002);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0006D550 File Offset: 0x0006B750
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0006D584 File Offset: 0x0006B784
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1321172, RefRangeEnd = 1321198, XrefRangeStart = 1321169, XrefRangeEnd = 1321172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan(int hours, int minutes, int seconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hours;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0006D5D4 File Offset: 0x0006B7D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1321202, RefRangeEnd = 1321205, XrefRangeStart = 1321198, XrefRangeEnd = 1321202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan(int days, int hours, int minutes, int seconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref days;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hours;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0006D630 File Offset: 0x0006B830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1321205, RefRangeEnd = 1321207, XrefRangeStart = 1321205, XrefRangeEnd = 1321205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref days;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hours;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref milliseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0006D69C File Offset: 0x0006B89C
		public unsafe long Ticks
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x0006D6CC File Offset: 0x0006B8CC
		public unsafe int Days
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1321207, RefRangeEnd = 1321208, XrefRangeStart = 1321207, XrefRangeEnd = 1321207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Days_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0006D6FC File Offset: 0x0006B8FC
		public unsafe int Hours
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1321208, RefRangeEnd = 1321215, XrefRangeStart = 1321208, XrefRangeEnd = 1321208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x0006D72C File Offset: 0x0006B92C
		public unsafe int Minutes
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1321215, RefRangeEnd = 1321222, XrefRangeStart = 1321215, XrefRangeEnd = 1321215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0006D75C File Offset: 0x0006B95C
		public unsafe int Seconds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1321222, RefRangeEnd = 1321224, XrefRangeStart = 1321222, XrefRangeEnd = 1321222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x0006D78C File Offset: 0x0006B98C
		public unsafe double TotalDays
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1321224, RefRangeEnd = 1321231, XrefRangeStart = 1321224, XrefRangeEnd = 1321224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalDays_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x0006D7BC File Offset: 0x0006B9BC
		public unsafe double TotalHours
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1321231, RefRangeEnd = 1321237, XrefRangeStart = 1321231, XrefRangeEnd = 1321231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalHours_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x0006D7EC File Offset: 0x0006B9EC
		public unsafe double TotalMilliseconds
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 1321237, RefRangeEnd = 1321267, XrefRangeStart = 1321237, XrefRangeEnd = 1321237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalMilliseconds_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x0006D81C File Offset: 0x0006BA1C
		public unsafe double TotalMinutes
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1321267, RefRangeEnd = 1321274, XrefRangeStart = 1321267, XrefRangeEnd = 1321267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalMinutes_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x0006D84C File Offset: 0x0006BA4C
		public unsafe double TotalSeconds
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 1321274, RefRangeEnd = 1321316, XrefRangeStart = 1321274, XrefRangeEnd = 1321274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalSeconds_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0006D87C File Offset: 0x0006BA7C
		[CallerCount(0)]
		public unsafe TimeSpan Add(TimeSpan ts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Add_Public_TimeSpan_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0006D8BC File Offset: 0x0006BABC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1321316, RefRangeEnd = 1321321, XrefRangeStart = 1321316, XrefRangeEnd = 1321316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Compare_Public_Static_Int32_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0006D908 File Offset: 0x0006BB08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1321324, RefRangeEnd = 1321325, XrefRangeStart = 1321321, XrefRangeEnd = 1321324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0006D94C File Offset: 0x0006BB4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1321325, RefRangeEnd = 1321327, XrefRangeStart = 1321325, XrefRangeEnd = 1321325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0006D98C File Offset: 0x0006BB8C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1321331, RefRangeEnd = 1321338, XrefRangeStart = 1321327, XrefRangeEnd = 1321331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromDays(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromDays_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0006D9CC File Offset: 0x0006BBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321338, XrefRangeEnd = 1321341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0006DA10 File Offset: 0x0006BC10
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1309270, RefRangeEnd = 1309279, XrefRangeStart = 1309270, XrefRangeEnd = 1309279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TimeSpan obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0006DA50 File Offset: 0x0006BC50
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1309279, RefRangeEnd = 1309289, XrefRangeStart = 1309279, XrefRangeEnd = 1309289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0006DA80 File Offset: 0x0006BC80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1321345, RefRangeEnd = 1321348, XrefRangeStart = 1321341, XrefRangeEnd = 1321345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromHours(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromHours_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0006DAC0 File Offset: 0x0006BCC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1321349, RefRangeEnd = 1321354, XrefRangeStart = 1321348, XrefRangeEnd = 1321349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan Interval(double value, int scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Interval_Private_Static_TimeSpan_Double_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0006DB0C File Offset: 0x0006BD0C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1321358, RefRangeEnd = 1321374, XrefRangeStart = 1321354, XrefRangeEnd = 1321358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromMilliseconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromMilliseconds_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0006DB4C File Offset: 0x0006BD4C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1321378, RefRangeEnd = 1321387, XrefRangeStart = 1321374, XrefRangeEnd = 1321378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromMinutes(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromMinutes_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0006DB8C File Offset: 0x0006BD8C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1321391, RefRangeEnd = 1321397, XrefRangeStart = 1321387, XrefRangeEnd = 1321391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan Negate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Negate_Public_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0006DBBC File Offset: 0x0006BDBC
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1321401, RefRangeEnd = 1321436, XrefRangeStart = 1321397, XrefRangeEnd = 1321401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromSeconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromSeconds_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0006DBFC File Offset: 0x0006BDFC
		[CallerCount(0)]
		public unsafe TimeSpan Subtract(TimeSpan ts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Subtract_Public_TimeSpan_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0006DC3C File Offset: 0x0006BE3C
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromTicks(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromTicks_Public_Static_TimeSpan_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0006DC7C File Offset: 0x0006BE7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1321436, RefRangeEnd = 1321439, XrefRangeStart = 1321436, XrefRangeEnd = 1321436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0006DCD8 File Offset: 0x0006BED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321439, XrefRangeEnd = 1321442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan Parse(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Parse_Public_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0006DD1C File Offset: 0x0006BF1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1321445, RefRangeEnd = 1321448, XrefRangeStart = 1321442, XrefRangeEnd = 1321445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan Parse(string input, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Parse_Public_Static_TimeSpan_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0006DD70 File Offset: 0x0006BF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1321451, RefRangeEnd = 1321452, XrefRangeStart = 1321448, XrefRangeEnd = 1321451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, out TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0006DDC0 File Offset: 0x0006BFC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1321456, RefRangeEnd = 1321459, XrefRangeStart = 1321452, XrefRangeEnd = 1321456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0006DDEC File Offset: 0x0006BFEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1321463, RefRangeEnd = 1321465, XrefRangeStart = 1321459, XrefRangeEnd = 1321463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0006DE3C File Offset: 0x0006C03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321465, XrefRangeEnd = 1321469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0006DEBC File Offset: 0x0006C0BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1321473, RefRangeEnd = 1321474, XrefRangeStart = 1321469, XrefRangeEnd = 1321473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator -(TimeSpan t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0006DEFC File Offset: 0x0006C0FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1321477, RefRangeEnd = 1321480, XrefRangeStart = 1321474, XrefRangeEnd = 1321477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0006DF48 File Offset: 0x0006C148
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1321483, RefRangeEnd = 1321509, XrefRangeStart = 1321480, XrefRangeEnd = 1321483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Addition_Public_Static_TimeSpan_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0006DF94 File Offset: 0x0006C194
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0006DFE0 File Offset: 0x0006C1E0
		[CallerCount(736)]
		[CachedScanResults(RefRangeStart = 974210, RefRangeEnd = 974946, XrefRangeStart = 974210, XrefRangeEnd = 974946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0006E02C File Offset: 0x0006C22C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1321509, RefRangeEnd = 1321520, XrefRangeStart = 1321509, XrefRangeEnd = 1321509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0006E078 File Offset: 0x0006C278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1321520, RefRangeEnd = 1321522, XrefRangeStart = 1321520, XrefRangeEnd = 1321520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0006E0C4 File Offset: 0x0006C2C4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1321522, RefRangeEnd = 1321531, XrefRangeStart = 1321522, XrefRangeEnd = 1321522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0006E110 File Offset: 0x0006C310
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1321531, RefRangeEnd = 1321533, XrefRangeStart = 1321531, XrefRangeEnd = 1321531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00005ACA File Offset: 0x00003CCA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, ref this));
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x0006E15C File Offset: 0x0006C35C
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x00005ADC File Offset: 0x00003CDC
		public unsafe static long TicksPerMillisecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x0006E178 File Offset: 0x0006C378
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x00005AEA File Offset: 0x00003CEA
		public unsafe static double MillisecondsPerTick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MillisecondsPerTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MillisecondsPerTick, (void*)(&value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x0006E194 File Offset: 0x0006C394
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00005AF8 File Offset: 0x00003CF8
		public unsafe static long TicksPerSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x0006E1B0 File Offset: 0x0006C3B0
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x00005B06 File Offset: 0x00003D06
		public unsafe static double SecondsPerTick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_SecondsPerTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_SecondsPerTick, (void*)(&value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x0006E1CC File Offset: 0x0006C3CC
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00005B14 File Offset: 0x00003D14
		public unsafe static long TicksPerMinute
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerMinute, (void*)(&value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x0006E1E8 File Offset: 0x0006C3E8
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x00005B22 File Offset: 0x00003D22
		public unsafe static double MinutesPerTick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MinutesPerTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MinutesPerTick, (void*)(&value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x0006E204 File Offset: 0x0006C404
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x00005B30 File Offset: 0x00003D30
		public unsafe static long TicksPerHour
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerHour, (void*)(&value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x0006E220 File Offset: 0x0006C420
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x00005B3E File Offset: 0x00003D3E
		public unsafe static double HoursPerTick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_HoursPerTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_HoursPerTick, (void*)(&value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x0006E23C File Offset: 0x0006C43C
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x00005B4C File Offset: 0x00003D4C
		public unsafe static long TicksPerDay
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x0006E258 File Offset: 0x0006C458
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x00005B5A File Offset: 0x00003D5A
		public unsafe static double DaysPerTick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_DaysPerTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_DaysPerTick, (void*)(&value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x0006E274 File Offset: 0x0006C474
		// (set) Token: 0x06000F80 RID: 3968 RVA: 0x00005B68 File Offset: 0x00003D68
		public unsafe static int MillisPerSecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MillisPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MillisPerSecond, (void*)(&value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0006E290 File Offset: 0x0006C490
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x00005B76 File Offset: 0x00003D76
		public unsafe static int MillisPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MillisPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MillisPerMinute, (void*)(&value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0006E2AC File Offset: 0x0006C4AC
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x00005B84 File Offset: 0x00003D84
		public unsafe static int MillisPerHour
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MillisPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MillisPerHour, (void*)(&value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x0006E2C8 File Offset: 0x0006C4C8
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x00005B92 File Offset: 0x00003D92
		public unsafe static int MillisPerDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MillisPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MillisPerDay, (void*)(&value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x0006E2E4 File Offset: 0x0006C4E4
		// (set) Token: 0x06000F88 RID: 3976 RVA: 0x00005BA0 File Offset: 0x00003DA0
		public unsafe static long MaxSeconds
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MaxSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MaxSeconds, (void*)(&value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x0006E300 File Offset: 0x0006C500
		// (set) Token: 0x06000F8A RID: 3978 RVA: 0x00005BAE File Offset: 0x00003DAE
		public unsafe static long MinSeconds
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MinSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MinSeconds, (void*)(&value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x0006E31C File Offset: 0x0006C51C
		// (set) Token: 0x06000F8C RID: 3980 RVA: 0x00005BBC File Offset: 0x00003DBC
		public unsafe static long MaxMilliSeconds
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MaxMilliSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MaxMilliSeconds, (void*)(&value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x0006E338 File Offset: 0x0006C538
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x00005BCA File Offset: 0x00003DCA
		public unsafe static long MinMilliSeconds
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MinMilliSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MinMilliSeconds, (void*)(&value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x0006E354 File Offset: 0x0006C554
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public unsafe static long TicksPerTenthSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerTenthSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerTenthSecond, (void*)(&value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x0006E370 File Offset: 0x0006C570
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x00005BE6 File Offset: 0x00003DE6
		public unsafe static TimeSpan Zero
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_Zero, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x0006E38C File Offset: 0x0006C58C
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00005BF4 File Offset: 0x00003DF4
		public unsafe static TimeSpan MaxValue
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MaxValue, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0006E3A8 File Offset: 0x0006C5A8
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00005C02 File Offset: 0x00003E02
		public unsafe static TimeSpan MinValue
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MinValue, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMillisecond;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeFieldInfoPtr_MillisecondsPerTick;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerSecond;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeFieldInfoPtr_SecondsPerTick;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMinute;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeFieldInfoPtr_MinutesPerTick;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerHour;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeFieldInfoPtr_HoursPerTick;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerDay;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeFieldInfoPtr_DaysPerTick;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerSecond;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerMinute;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerHour;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerDay;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeFieldInfoPtr_MaxSeconds;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeFieldInfoPtr_MinSeconds;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeFieldInfoPtr_MaxMilliSeconds;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeFieldInfoPtr_MinMilliSeconds;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerTenthSecond;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeFieldInfoPtr__ticks;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_get_Days_Public_get_Int32_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_get_Hours_Public_get_Int32_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDays_Public_get_Double_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalHours_Public_get_Double_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalMilliseconds_Public_get_Double_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalMinutes_Public_get_Double_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalSeconds_Public_get_Double_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_TimeSpan_TimeSpan_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_TimeSpan_TimeSpan_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TimeSpan_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_FromDays_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeSpan_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_FromHours_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_Interval_Private_Static_TimeSpan_Double_Int32_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_FromMilliseconds_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_FromMinutes_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_Negate_Public_TimeSpan_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_FromSeconds_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_TimeSpan_TimeSpan_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_FromTicks_Public_Static_TimeSpan_Int64_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_TimeSpan_String_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_TimeSpan_String_IFormatProvider_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TimeSpan_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_TimeSpan_TimeSpan_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_TimeSpan_TimeSpan_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_TimeSpan_TimeSpan_TimeSpan_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000CB4 RID: 3252
		[FieldOffset(0)]
		public readonly long _ticks;
	}
}
