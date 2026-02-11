using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200047C RID: 1148
	public static class TimeSpanParse : Object
	{
		// Token: 0x06004535 RID: 17717 RVA: 0x00144E4C File Offset: 0x0014304C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanParse()
		{
			Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TimeSpanParse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr);
			TimeSpanParse.NativeMethodInfoPtr_Pow10_Internal_Static_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673485);
			TimeSpanParse.NativeMethodInfoPtr_TryTimeToTicks_Private_Static_Boolean_Boolean_TimeSpanToken_TimeSpanToken_TimeSpanToken_TimeSpanToken_TimeSpanToken_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673486);
			TimeSpanParse.NativeMethodInfoPtr_Parse_Internal_Static_TimeSpan_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673487);
			TimeSpanParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_IFormatProvider_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673488);
			TimeSpanParse.NativeMethodInfoPtr_TryParseTimeSpan_Private_Static_Boolean_ReadOnlySpan_1_Char_TimeSpanStandardStyles_IFormatProvider_byref_TimeSpanResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673489);
			TimeSpanParse.NativeMethodInfoPtr_ProcessTerminalState_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673490);
			TimeSpanParse.NativeMethodInfoPtr_ProcessTerminal_DHMSF_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673491);
			TimeSpanParse.NativeMethodInfoPtr_ProcessTerminal_HMS_F_D_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673492);
			TimeSpanParse.NativeMethodInfoPtr_ProcessTerminal_HM_S_D_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673493);
			TimeSpanParse.NativeMethodInfoPtr_ProcessTerminal_HM_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673494);
			TimeSpanParse.NativeMethodInfoPtr_ProcessTerminal_D_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100673495);
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x00144F58 File Offset: 0x00143158
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1409371, RefRangeEnd = 1409403, XrefRangeStart = 1409370, XrefRangeEnd = 1409371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Pow10(int pow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_Pow10_Internal_Static_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x00144F98 File Offset: 0x00143198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409403, XrefRangeEnd = 1409406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref positive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(days));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hours));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(minutes));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(seconds));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fraction));
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_TryTimeToTicks_Private_Static_Boolean_Boolean_TimeSpanToken_TimeSpanToken_TimeSpanToken_TimeSpanToken_TimeSpanToken_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x0014505C File Offset: 0x0014325C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1409407, RefRangeEnd = 1409409, XrefRangeStart = 1409406, XrefRangeEnd = 1409407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_Parse_Internal_Static_TimeSpan_ReadOnlySpan_1_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x001450B4 File Offset: 0x001432B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409410, RefRangeEnd = 1409411, XrefRangeStart = 1409409, XrefRangeEnd = 1409410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(ReadOnlySpan<char> input, IFormatProvider formatProvider, out TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_IFormatProvider_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x0014511C File Offset: 0x0014331C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1409548, RefRangeEnd = 1409550, XrefRangeStart = 1409411, XrefRangeEnd = 1409548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_TryParseTimeSpan_Private_Static_Boolean_ReadOnlySpan_1_Char_TimeSpanStandardStyles_IFormatProvider_byref_TimeSpanResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00145190 File Offset: 0x00143390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409550, XrefRangeEnd = 1409555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(raw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_ProcessTerminalState_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x001451F0 File Offset: 0x001433F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409577, RefRangeEnd = 1409578, XrefRangeStart = 1409555, XrefRangeEnd = 1409577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(raw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_ProcessTerminal_DHMSF_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00145250 File Offset: 0x00143450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409657, RefRangeEnd = 1409658, XrefRangeStart = 1409578, XrefRangeEnd = 1409657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(raw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_ProcessTerminal_HMS_F_D_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x001452B0 File Offset: 0x001434B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409727, RefRangeEnd = 1409728, XrefRangeStart = 1409658, XrefRangeEnd = 1409727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(raw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_ProcessTerminal_HM_S_D_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x00145310 File Offset: 0x00143510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409728, XrefRangeEnd = 1409748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(raw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_ProcessTerminal_HM_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00145370 File Offset: 0x00143570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409748, XrefRangeEnd = 1409768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(raw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.NativeMethodInfoPtr_ProcessTerminal_D_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x000191BB File Offset: 0x000173BB
		public TimeSpanParse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400392D RID: 14637
		private static readonly IntPtr NativeMethodInfoPtr_Pow10_Internal_Static_Int64_Int32_0;

		// Token: 0x0400392E RID: 14638
		private static readonly IntPtr NativeMethodInfoPtr_TryTimeToTicks_Private_Static_Boolean_Boolean_TimeSpanToken_TimeSpanToken_TimeSpanToken_TimeSpanToken_TimeSpanToken_byref_Int64_0;

		// Token: 0x0400392F RID: 14639
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_TimeSpan_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x04003930 RID: 14640
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_IFormatProvider_byref_TimeSpan_0;

		// Token: 0x04003931 RID: 14641
		private static readonly IntPtr NativeMethodInfoPtr_TryParseTimeSpan_Private_Static_Boolean_ReadOnlySpan_1_Char_TimeSpanStandardStyles_IFormatProvider_byref_TimeSpanResult_0;

		// Token: 0x04003932 RID: 14642
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTerminalState_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0;

		// Token: 0x04003933 RID: 14643
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTerminal_DHMSF_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0;

		// Token: 0x04003934 RID: 14644
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTerminal_HMS_F_D_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0;

		// Token: 0x04003935 RID: 14645
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTerminal_HM_S_D_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0;

		// Token: 0x04003936 RID: 14646
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTerminal_HM_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0;

		// Token: 0x04003937 RID: 14647
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTerminal_D_Private_Static_Boolean_byref_TimeSpanRawInfo_TimeSpanStandardStyles_byref_TimeSpanResult_0;

		// Token: 0x020006D1 RID: 1745
		public enum ParseFailureKind : byte
		{
			// Token: 0x04004B97 RID: 19351
			None,
			// Token: 0x04004B98 RID: 19352
			ArgumentNull,
			// Token: 0x04004B99 RID: 19353
			Format,
			// Token: 0x04004B9A RID: 19354
			FormatWithParameter,
			// Token: 0x04004B9B RID: 19355
			Overflow
		}

		// Token: 0x020006D2 RID: 1746
		[Flags]
		public enum TimeSpanStandardStyles : byte
		{
			// Token: 0x04004B9D RID: 19357
			None = 0,
			// Token: 0x04004B9E RID: 19358
			Invariant = 1,
			// Token: 0x04004B9F RID: 19359
			Localized = 2,
			// Token: 0x04004BA0 RID: 19360
			RequireFull = 4,
			// Token: 0x04004BA1 RID: 19361
			Any = 3
		}

		// Token: 0x020006D3 RID: 1747
		public enum TTT : byte
		{
			// Token: 0x04004BA3 RID: 19363
			None,
			// Token: 0x04004BA4 RID: 19364
			End,
			// Token: 0x04004BA5 RID: 19365
			Num,
			// Token: 0x04004BA6 RID: 19366
			Sep,
			// Token: 0x04004BA7 RID: 19367
			NumOverflow
		}

		// Token: 0x020006D4 RID: 1748
		public sealed class TimeSpanToken : ValueType
		{
			// Token: 0x06005CF8 RID: 23800 RVA: 0x001A5144 File Offset: 0x001A3344
			// Note: this type is marked as 'beforefieldinit'.
			static TimeSpanToken()
			{
				Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, "TimeSpanToken");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr);
				TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__ttt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, "_ttt");
				TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, "_num");
				TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__zeroes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, "_zeroes");
				TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__sep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, "_sep");
				TimeSpanParse.TimeSpanToken.NativeMethodInfoPtr__ctor_Public_Void_TTT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, 100673496);
				TimeSpanParse.TimeSpanToken.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, 100673497);
				TimeSpanParse.TimeSpanToken.NativeMethodInfoPtr__ctor_Public_Void_TTT_Int32_Int32_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, 100673498);
				TimeSpanParse.TimeSpanToken.NativeMethodInfoPtr_IsInvalidFraction_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, 100673499);
			}

			// Token: 0x06005CF9 RID: 23801 RVA: 0x001A5210 File Offset: 0x001A3410
			[CallerCount(0)]
			public unsafe TimeSpanToken(TimeSpanParse.TTT type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanToken.NativeMethodInfoPtr__ctor_Public_Void_TTT_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005CFA RID: 23802 RVA: 0x001A525C File Offset: 0x001A345C
			[CallerCount(0)]
			public unsafe TimeSpanToken(int number)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref number;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanToken.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005CFB RID: 23803 RVA: 0x001A52A8 File Offset: 0x001A34A8
			[CallerCount(0)]
			public unsafe TimeSpanToken(TimeSpanParse.TTT type, int number, int leadingZeroes, ReadOnlySpan<char> separator)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref number;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leadingZeroes;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(separator));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanToken.NativeMethodInfoPtr__ctor_Public_Void_TTT_Int32_Int32_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005CFC RID: 23804 RVA: 0x001A5328 File Offset: 0x001A3528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409086, XrefRangeEnd = 1409087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsInvalidFraction()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanToken.NativeMethodInfoPtr_IsInvalidFraction_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005CFD RID: 23805 RVA: 0x00021CDE File Offset: 0x0001FEDE
			public TimeSpanToken(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005CFE RID: 23806 RVA: 0x00021CE7 File Offset: 0x0001FEE7
			public TimeSpanToken()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr))
			{
			}

			// Token: 0x170017CC RID: 6092
			// (get) Token: 0x06005CFF RID: 23807 RVA: 0x001A536C File Offset: 0x001A356C
			// (set) Token: 0x06005D00 RID: 23808 RVA: 0x00021CF9 File Offset: 0x0001FEF9
			public unsafe TimeSpanParse.TTT _ttt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__ttt);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__ttt)) = value;
				}
			}

			// Token: 0x170017CD RID: 6093
			// (get) Token: 0x06005D01 RID: 23809 RVA: 0x001A5394 File Offset: 0x001A3594
			// (set) Token: 0x06005D02 RID: 23810 RVA: 0x00021D14 File Offset: 0x0001FF14
			public unsafe int _num
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__num);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__num)) = value;
				}
			}

			// Token: 0x170017CE RID: 6094
			// (get) Token: 0x06005D03 RID: 23811 RVA: 0x001A53BC File Offset: 0x001A35BC
			// (set) Token: 0x06005D04 RID: 23812 RVA: 0x00021D2F File Offset: 0x0001FF2F
			public unsafe int _zeroes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__zeroes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__zeroes)) = value;
				}
			}

			// Token: 0x170017CF RID: 6095
			// (get) Token: 0x06005D05 RID: 23813 RVA: 0x001A53E4 File Offset: 0x001A35E4
			// (set) Token: 0x06005D06 RID: 23814 RVA: 0x00021D4A File Offset: 0x0001FF4A
			public ReadOnlySpan<char> _sep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__sep);
					return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanToken.NativeFieldInfoPtr__sep), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004BA8 RID: 19368
			private static readonly IntPtr NativeFieldInfoPtr__ttt;

			// Token: 0x04004BA9 RID: 19369
			private static readonly IntPtr NativeFieldInfoPtr__num;

			// Token: 0x04004BAA RID: 19370
			private static readonly IntPtr NativeFieldInfoPtr__zeroes;

			// Token: 0x04004BAB RID: 19371
			private static readonly IntPtr NativeFieldInfoPtr__sep;

			// Token: 0x04004BAC RID: 19372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TTT_0;

			// Token: 0x04004BAD RID: 19373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004BAE RID: 19374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TTT_Int32_Int32_ReadOnlySpan_1_Char_0;

			// Token: 0x04004BAF RID: 19375
			private static readonly IntPtr NativeMethodInfoPtr_IsInvalidFraction_Public_Boolean_0;
		}

		// Token: 0x020006D5 RID: 1749
		public sealed class TimeSpanTokenizer : ValueType
		{
			// Token: 0x06005D07 RID: 23815 RVA: 0x001A5414 File Offset: 0x001A3614
			// Note: this type is marked as 'beforefieldinit'.
			static TimeSpanTokenizer()
			{
				Il2CppClassPointerStore<TimeSpanParse.TimeSpanTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, "TimeSpanTokenizer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanParse.TimeSpanTokenizer>.NativeClassPtr);
				TimeSpanParse.TimeSpanTokenizer.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanTokenizer>.NativeClassPtr, "_value");
				TimeSpanParse.TimeSpanTokenizer.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanTokenizer>.NativeClassPtr, "_pos");
				TimeSpanParse.TimeSpanTokenizer.NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanTokenizer>.NativeClassPtr, 100673500);
				TimeSpanParse.TimeSpanTokenizer.NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanTokenizer>.NativeClassPtr, 100673501);
				TimeSpanParse.TimeSpanTokenizer.NativeMethodInfoPtr_GetNextToken_Internal_TimeSpanToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanTokenizer>.NativeClassPtr, 100673502);
			}

			// Token: 0x06005D08 RID: 23816 RVA: 0x001A54A4 File Offset: 0x001A36A4
			[CallerCount(0)]
			public unsafe TimeSpanTokenizer(ReadOnlySpan<char> input)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanParse.TimeSpanTokenizer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanTokenizer.NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005D09 RID: 23817 RVA: 0x001A54FC File Offset: 0x001A36FC
			[CallerCount(0)]
			public unsafe TimeSpanTokenizer(ReadOnlySpan<char> input, int startPosition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanParse.TimeSpanTokenizer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanTokenizer.NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005D0A RID: 23818 RVA: 0x001A5560 File Offset: 0x001A3760
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1409093, RefRangeEnd = 1409095, XrefRangeStart = 1409087, XrefRangeEnd = 1409093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpanParse.TimeSpanToken GetNextToken()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanTokenizer.NativeMethodInfoPtr_GetNextToken_Internal_TimeSpanToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TimeSpanParse.TimeSpanToken(intPtr);
			}

			// Token: 0x06005D0B RID: 23819 RVA: 0x00021D78 File Offset: 0x0001FF78
			public TimeSpanTokenizer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005D0C RID: 23820 RVA: 0x00021D81 File Offset: 0x0001FF81
			public TimeSpanTokenizer()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanParse.TimeSpanTokenizer>.NativeClassPtr))
			{
			}

			// Token: 0x170017D0 RID: 6096
			// (get) Token: 0x06005D0D RID: 23821 RVA: 0x001A559C File Offset: 0x001A379C
			// (set) Token: 0x06005D0E RID: 23822 RVA: 0x00021D93 File Offset: 0x0001FF93
			public ReadOnlySpan<char> _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanTokenizer.NativeFieldInfoPtr__value);
					return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanTokenizer.NativeFieldInfoPtr__value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017D1 RID: 6097
			// (get) Token: 0x06005D0F RID: 23823 RVA: 0x001A55CC File Offset: 0x001A37CC
			// (set) Token: 0x06005D10 RID: 23824 RVA: 0x00021DC1 File Offset: 0x0001FFC1
			public unsafe int _pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanTokenizer.NativeFieldInfoPtr__pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanTokenizer.NativeFieldInfoPtr__pos)) = value;
				}
			}

			// Token: 0x04004BB0 RID: 19376
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x04004BB1 RID: 19377
			private static readonly IntPtr NativeFieldInfoPtr__pos;

			// Token: 0x04004BB2 RID: 19378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_0;

			// Token: 0x04004BB3 RID: 19379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_Int32_0;

			// Token: 0x04004BB4 RID: 19380
			private static readonly IntPtr NativeMethodInfoPtr_GetNextToken_Internal_TimeSpanToken_0;
		}

		// Token: 0x020006D6 RID: 1750
		public sealed class TimeSpanRawInfo : ValueType
		{
			// Token: 0x06005D11 RID: 23825 RVA: 0x001A55F4 File Offset: 0x001A37F4
			// Note: this type is marked as 'beforefieldinit'.
			static TimeSpanRawInfo()
			{
				Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, "TimeSpanRawInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr);
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__lastSeenTTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_lastSeenTTT");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__tokenCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_tokenCount");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__sepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_sepCount");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_numCount");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__posLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_posLoc");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__negLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_negLoc");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__posLocInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_posLocInit");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__negLocInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_negLocInit");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__fullPosPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_fullPosPattern");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__fullNegPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_fullNegPattern");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_numbers0");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_numbers1");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_numbers2");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_numbers3");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_numbers4");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_literals0");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_literals1");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_literals2");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_literals3");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_literals4");
				TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, "_literals5");
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_get_PositiveInvariant_Internal_get_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673503);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_get_NegativeInvariant_Internal_get_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673504);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_get_PositiveLocalized_Internal_get_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673505);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_get_NegativeLocalized_Internal_get_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673506);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullAppCompatMatch_Internal_Boolean_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673507);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_PartialAppCompatMatch_Internal_Boolean_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673508);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullMatch_Internal_Boolean_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673509);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullDMatch_Internal_Boolean_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673510);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullHMMatch_Internal_Boolean_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673511);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullDHMMatch_Internal_Boolean_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673512);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullHMSMatch_Internal_Boolean_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673513);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullDHMSMatch_Internal_Boolean_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673514);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullHMSFMatch_Internal_Boolean_FormatLiterals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673515);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_Init_Internal_Void_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673516);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_ProcessToken_Internal_Boolean_byref_TimeSpanToken_byref_TimeSpanResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673517);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_AddSep_Private_Boolean_ReadOnlySpan_1_Char_byref_TimeSpanResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673518);
				TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_AddNum_Private_Boolean_TimeSpanToken_byref_TimeSpanResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr, 100673519);
			}

			// Token: 0x170017E7 RID: 6119
			// (get) Token: 0x06005D12 RID: 23826 RVA: 0x001A5918 File Offset: 0x001A3B18
			public unsafe TimeSpanFormat.FormatLiterals PositiveInvariant
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409095, XrefRangeEnd = 1409099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_get_PositiveInvariant_Internal_get_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new TimeSpanFormat.FormatLiterals(intPtr);
				}
			}

			// Token: 0x170017E8 RID: 6120
			// (get) Token: 0x06005D13 RID: 23827 RVA: 0x001A5954 File Offset: 0x001A3B54
			public unsafe TimeSpanFormat.FormatLiterals NegativeInvariant
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409099, XrefRangeEnd = 1409103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_get_NegativeInvariant_Internal_get_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new TimeSpanFormat.FormatLiterals(intPtr);
				}
			}

			// Token: 0x170017E9 RID: 6121
			// (get) Token: 0x06005D14 RID: 23828 RVA: 0x001A5990 File Offset: 0x001A3B90
			public unsafe TimeSpanFormat.FormatLiterals PositiveLocalized
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 1409107, RefRangeEnd = 1409118, XrefRangeStart = 1409103, XrefRangeEnd = 1409107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_get_PositiveLocalized_Internal_get_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new TimeSpanFormat.FormatLiterals(intPtr);
				}
			}

			// Token: 0x170017EA RID: 6122
			// (get) Token: 0x06005D15 RID: 23829 RVA: 0x001A59CC File Offset: 0x001A3BCC
			public unsafe TimeSpanFormat.FormatLiterals NegativeLocalized
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 1409122, RefRangeEnd = 1409133, XrefRangeStart = 1409118, XrefRangeEnd = 1409122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_get_NegativeLocalized_Internal_get_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new TimeSpanFormat.FormatLiterals(intPtr);
				}
			}

			// Token: 0x06005D16 RID: 23830 RVA: 0x001A5A08 File Offset: 0x001A3C08
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1409154, RefRangeEnd = 1409158, XrefRangeStart = 1409133, XrefRangeEnd = 1409154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pattern));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullAppCompatMatch_Internal_Boolean_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005D17 RID: 23831 RVA: 0x001A5A60 File Offset: 0x001A3C60
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1409175, RefRangeEnd = 1409179, XrefRangeStart = 1409158, XrefRangeEnd = 1409175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pattern));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_PartialAppCompatMatch_Internal_Boolean_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005D18 RID: 23832 RVA: 0x001A5AB8 File Offset: 0x001A3CB8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1409204, RefRangeEnd = 1409208, XrefRangeStart = 1409179, XrefRangeEnd = 1409204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FullMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pattern));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullMatch_Internal_Boolean_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005D19 RID: 23833 RVA: 0x001A5B10 File Offset: 0x001A3D10
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1409216, RefRangeEnd = 1409220, XrefRangeStart = 1409208, XrefRangeEnd = 1409216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FullDMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pattern));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullDMatch_Internal_Boolean_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005D1A RID: 23834 RVA: 0x001A5B68 File Offset: 0x001A3D68
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1409233, RefRangeEnd = 1409237, XrefRangeStart = 1409220, XrefRangeEnd = 1409233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pattern));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullHMMatch_Internal_Boolean_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005D1B RID: 23835 RVA: 0x001A5BC0 File Offset: 0x001A3DC0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1409254, RefRangeEnd = 1409258, XrefRangeStart = 1409237, XrefRangeEnd = 1409254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pattern));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullDHMMatch_Internal_Boolean_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005D1C RID: 23836 RVA: 0x001A5C18 File Offset: 0x001A3E18
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1409275, RefRangeEnd = 1409279, XrefRangeStart = 1409258, XrefRangeEnd = 1409275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pattern));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullHMSMatch_Internal_Boolean_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005D1D RID: 23837 RVA: 0x001A5C70 File Offset: 0x001A3E70
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1409300, RefRangeEnd = 1409304, XrefRangeStart = 1409279, XrefRangeEnd = 1409300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pattern));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullDHMSMatch_Internal_Boolean_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005D1E RID: 23838 RVA: 0x001A5CC8 File Offset: 0x001A3EC8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1409325, RefRangeEnd = 1409329, XrefRangeStart = 1409304, XrefRangeEnd = 1409325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pattern));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_FullHMSFMatch_Internal_Boolean_FormatLiterals_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005D1F RID: 23839 RVA: 0x001A5D20 File Offset: 0x001A3F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409329, XrefRangeEnd = 1409331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(DateTimeFormatInfo dtfi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_Init_Internal_Void_DateTimeFormatInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005D20 RID: 23840 RVA: 0x001A5D68 File Offset: 0x001A3F68
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1409351, RefRangeEnd = 1409354, XrefRangeStart = 1409331, XrefRangeEnd = 1409351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(tok);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_ProcessToken_Internal_Boolean_byref_TimeSpanToken_byref_TimeSpanResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005D21 RID: 23841 RVA: 0x001A5DCC File Offset: 0x001A3FCC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1409355, RefRangeEnd = 1409357, XrefRangeStart = 1409354, XrefRangeEnd = 1409355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddSep(ReadOnlySpan<char> sep, ref TimeSpanParse.TimeSpanResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sep));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_AddSep_Private_Boolean_ReadOnlySpan_1_Char_byref_TimeSpanResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005D22 RID: 23842 RVA: 0x001A5E34 File Offset: 0x001A4034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409357, XrefRangeEnd = 1409358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(num));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanRawInfo.NativeMethodInfoPtr_AddNum_Private_Boolean_TimeSpanToken_byref_TimeSpanResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005D23 RID: 23843 RVA: 0x00021DDC File Offset: 0x0001FFDC
			public TimeSpanRawInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005D24 RID: 23844 RVA: 0x00021DE5 File Offset: 0x0001FFE5
			public TimeSpanRawInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanParse.TimeSpanRawInfo>.NativeClassPtr))
			{
			}

			// Token: 0x170017D2 RID: 6098
			// (get) Token: 0x06005D25 RID: 23845 RVA: 0x001A5E9C File Offset: 0x001A409C
			// (set) Token: 0x06005D26 RID: 23846 RVA: 0x00021DF7 File Offset: 0x0001FFF7
			public unsafe TimeSpanParse.TTT _lastSeenTTT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__lastSeenTTT);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__lastSeenTTT)) = value;
				}
			}

			// Token: 0x170017D3 RID: 6099
			// (get) Token: 0x06005D27 RID: 23847 RVA: 0x001A5EC4 File Offset: 0x001A40C4
			// (set) Token: 0x06005D28 RID: 23848 RVA: 0x00021E12 File Offset: 0x00020012
			public unsafe int _tokenCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__tokenCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__tokenCount)) = value;
				}
			}

			// Token: 0x170017D4 RID: 6100
			// (get) Token: 0x06005D29 RID: 23849 RVA: 0x001A5EEC File Offset: 0x001A40EC
			// (set) Token: 0x06005D2A RID: 23850 RVA: 0x00021E2D File Offset: 0x0002002D
			public unsafe int _sepCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__sepCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__sepCount)) = value;
				}
			}

			// Token: 0x170017D5 RID: 6101
			// (get) Token: 0x06005D2B RID: 23851 RVA: 0x001A5F14 File Offset: 0x001A4114
			// (set) Token: 0x06005D2C RID: 23852 RVA: 0x00021E48 File Offset: 0x00020048
			public unsafe int _numCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numCount)) = value;
				}
			}

			// Token: 0x170017D6 RID: 6102
			// (get) Token: 0x06005D2D RID: 23853 RVA: 0x001A5F3C File Offset: 0x001A413C
			// (set) Token: 0x06005D2E RID: 23854 RVA: 0x00021E63 File Offset: 0x00020063
			public TimeSpanFormat.FormatLiterals _posLoc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__posLoc);
					return new TimeSpanFormat.FormatLiterals(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__posLoc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017D7 RID: 6103
			// (get) Token: 0x06005D2F RID: 23855 RVA: 0x001A5F6C File Offset: 0x001A416C
			// (set) Token: 0x06005D30 RID: 23856 RVA: 0x00021E91 File Offset: 0x00020091
			public TimeSpanFormat.FormatLiterals _negLoc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__negLoc);
					return new TimeSpanFormat.FormatLiterals(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__negLoc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017D8 RID: 6104
			// (get) Token: 0x06005D31 RID: 23857 RVA: 0x001A5F9C File Offset: 0x001A419C
			// (set) Token: 0x06005D32 RID: 23858 RVA: 0x00021EBF File Offset: 0x000200BF
			public unsafe bool _posLocInit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__posLocInit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__posLocInit)) = value;
				}
			}

			// Token: 0x170017D9 RID: 6105
			// (get) Token: 0x06005D33 RID: 23859 RVA: 0x001A5FC4 File Offset: 0x001A41C4
			// (set) Token: 0x06005D34 RID: 23860 RVA: 0x00021EDA File Offset: 0x000200DA
			public unsafe bool _negLocInit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__negLocInit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__negLocInit)) = value;
				}
			}

			// Token: 0x170017DA RID: 6106
			// (get) Token: 0x06005D35 RID: 23861 RVA: 0x001A5FEC File Offset: 0x001A41EC
			// (set) Token: 0x06005D36 RID: 23862 RVA: 0x00021EF5 File Offset: 0x000200F5
			public unsafe string _fullPosPattern
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__fullPosPattern);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__fullPosPattern), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170017DB RID: 6107
			// (get) Token: 0x06005D37 RID: 23863 RVA: 0x001A6014 File Offset: 0x001A4214
			// (set) Token: 0x06005D38 RID: 23864 RVA: 0x00021F14 File Offset: 0x00020114
			public unsafe string _fullNegPattern
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__fullNegPattern);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__fullNegPattern), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170017DC RID: 6108
			// (get) Token: 0x06005D39 RID: 23865 RVA: 0x001A603C File Offset: 0x001A423C
			// (set) Token: 0x06005D3A RID: 23866 RVA: 0x00021F33 File Offset: 0x00020133
			public TimeSpanParse.TimeSpanToken _numbers0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers0);
					return new TimeSpanParse.TimeSpanToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017DD RID: 6109
			// (get) Token: 0x06005D3B RID: 23867 RVA: 0x001A606C File Offset: 0x001A426C
			// (set) Token: 0x06005D3C RID: 23868 RVA: 0x00021F61 File Offset: 0x00020161
			public TimeSpanParse.TimeSpanToken _numbers1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers1);
					return new TimeSpanParse.TimeSpanToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017DE RID: 6110
			// (get) Token: 0x06005D3D RID: 23869 RVA: 0x001A609C File Offset: 0x001A429C
			// (set) Token: 0x06005D3E RID: 23870 RVA: 0x00021F8F File Offset: 0x0002018F
			public TimeSpanParse.TimeSpanToken _numbers2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers2);
					return new TimeSpanParse.TimeSpanToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017DF RID: 6111
			// (get) Token: 0x06005D3F RID: 23871 RVA: 0x001A60CC File Offset: 0x001A42CC
			// (set) Token: 0x06005D40 RID: 23872 RVA: 0x00021FBD File Offset: 0x000201BD
			public TimeSpanParse.TimeSpanToken _numbers3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers3);
					return new TimeSpanParse.TimeSpanToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017E0 RID: 6112
			// (get) Token: 0x06005D41 RID: 23873 RVA: 0x001A60FC File Offset: 0x001A42FC
			// (set) Token: 0x06005D42 RID: 23874 RVA: 0x00021FEB File Offset: 0x000201EB
			public TimeSpanParse.TimeSpanToken _numbers4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers4);
					return new TimeSpanParse.TimeSpanToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__numbers4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanParse.TimeSpanToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017E1 RID: 6113
			// (get) Token: 0x06005D43 RID: 23875 RVA: 0x001A612C File Offset: 0x001A432C
			// (set) Token: 0x06005D44 RID: 23876 RVA: 0x00022019 File Offset: 0x00020219
			public ReadOnlySpan<char> _literals0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals0);
					return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017E2 RID: 6114
			// (get) Token: 0x06005D45 RID: 23877 RVA: 0x001A615C File Offset: 0x001A435C
			// (set) Token: 0x06005D46 RID: 23878 RVA: 0x00022047 File Offset: 0x00020247
			public ReadOnlySpan<char> _literals1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals1);
					return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017E3 RID: 6115
			// (get) Token: 0x06005D47 RID: 23879 RVA: 0x001A618C File Offset: 0x001A438C
			// (set) Token: 0x06005D48 RID: 23880 RVA: 0x00022075 File Offset: 0x00020275
			public ReadOnlySpan<char> _literals2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals2);
					return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017E4 RID: 6116
			// (get) Token: 0x06005D49 RID: 23881 RVA: 0x001A61BC File Offset: 0x001A43BC
			// (set) Token: 0x06005D4A RID: 23882 RVA: 0x000220A3 File Offset: 0x000202A3
			public ReadOnlySpan<char> _literals3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals3);
					return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017E5 RID: 6117
			// (get) Token: 0x06005D4B RID: 23883 RVA: 0x001A61EC File Offset: 0x001A43EC
			// (set) Token: 0x06005D4C RID: 23884 RVA: 0x000220D1 File Offset: 0x000202D1
			public ReadOnlySpan<char> _literals4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals4);
					return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017E6 RID: 6118
			// (get) Token: 0x06005D4D RID: 23885 RVA: 0x001A621C File Offset: 0x001A441C
			// (set) Token: 0x06005D4E RID: 23886 RVA: 0x000220FF File Offset: 0x000202FF
			public ReadOnlySpan<char> _literals5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals5);
					return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanParse.TimeSpanRawInfo.NativeFieldInfoPtr__literals5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004BB5 RID: 19381
			private static readonly IntPtr NativeFieldInfoPtr__lastSeenTTT;

			// Token: 0x04004BB6 RID: 19382
			private static readonly IntPtr NativeFieldInfoPtr__tokenCount;

			// Token: 0x04004BB7 RID: 19383
			private static readonly IntPtr NativeFieldInfoPtr__sepCount;

			// Token: 0x04004BB8 RID: 19384
			private static readonly IntPtr NativeFieldInfoPtr__numCount;

			// Token: 0x04004BB9 RID: 19385
			private static readonly IntPtr NativeFieldInfoPtr__posLoc;

			// Token: 0x04004BBA RID: 19386
			private static readonly IntPtr NativeFieldInfoPtr__negLoc;

			// Token: 0x04004BBB RID: 19387
			private static readonly IntPtr NativeFieldInfoPtr__posLocInit;

			// Token: 0x04004BBC RID: 19388
			private static readonly IntPtr NativeFieldInfoPtr__negLocInit;

			// Token: 0x04004BBD RID: 19389
			private static readonly IntPtr NativeFieldInfoPtr__fullPosPattern;

			// Token: 0x04004BBE RID: 19390
			private static readonly IntPtr NativeFieldInfoPtr__fullNegPattern;

			// Token: 0x04004BBF RID: 19391
			private static readonly IntPtr NativeFieldInfoPtr__numbers0;

			// Token: 0x04004BC0 RID: 19392
			private static readonly IntPtr NativeFieldInfoPtr__numbers1;

			// Token: 0x04004BC1 RID: 19393
			private static readonly IntPtr NativeFieldInfoPtr__numbers2;

			// Token: 0x04004BC2 RID: 19394
			private static readonly IntPtr NativeFieldInfoPtr__numbers3;

			// Token: 0x04004BC3 RID: 19395
			private static readonly IntPtr NativeFieldInfoPtr__numbers4;

			// Token: 0x04004BC4 RID: 19396
			private static readonly IntPtr NativeFieldInfoPtr__literals0;

			// Token: 0x04004BC5 RID: 19397
			private static readonly IntPtr NativeFieldInfoPtr__literals1;

			// Token: 0x04004BC6 RID: 19398
			private static readonly IntPtr NativeFieldInfoPtr__literals2;

			// Token: 0x04004BC7 RID: 19399
			private static readonly IntPtr NativeFieldInfoPtr__literals3;

			// Token: 0x04004BC8 RID: 19400
			private static readonly IntPtr NativeFieldInfoPtr__literals4;

			// Token: 0x04004BC9 RID: 19401
			private static readonly IntPtr NativeFieldInfoPtr__literals5;

			// Token: 0x04004BCA RID: 19402
			private static readonly IntPtr NativeMethodInfoPtr_get_PositiveInvariant_Internal_get_FormatLiterals_0;

			// Token: 0x04004BCB RID: 19403
			private static readonly IntPtr NativeMethodInfoPtr_get_NegativeInvariant_Internal_get_FormatLiterals_0;

			// Token: 0x04004BCC RID: 19404
			private static readonly IntPtr NativeMethodInfoPtr_get_PositiveLocalized_Internal_get_FormatLiterals_0;

			// Token: 0x04004BCD RID: 19405
			private static readonly IntPtr NativeMethodInfoPtr_get_NegativeLocalized_Internal_get_FormatLiterals_0;

			// Token: 0x04004BCE RID: 19406
			private static readonly IntPtr NativeMethodInfoPtr_FullAppCompatMatch_Internal_Boolean_FormatLiterals_0;

			// Token: 0x04004BCF RID: 19407
			private static readonly IntPtr NativeMethodInfoPtr_PartialAppCompatMatch_Internal_Boolean_FormatLiterals_0;

			// Token: 0x04004BD0 RID: 19408
			private static readonly IntPtr NativeMethodInfoPtr_FullMatch_Internal_Boolean_FormatLiterals_0;

			// Token: 0x04004BD1 RID: 19409
			private static readonly IntPtr NativeMethodInfoPtr_FullDMatch_Internal_Boolean_FormatLiterals_0;

			// Token: 0x04004BD2 RID: 19410
			private static readonly IntPtr NativeMethodInfoPtr_FullHMMatch_Internal_Boolean_FormatLiterals_0;

			// Token: 0x04004BD3 RID: 19411
			private static readonly IntPtr NativeMethodInfoPtr_FullDHMMatch_Internal_Boolean_FormatLiterals_0;

			// Token: 0x04004BD4 RID: 19412
			private static readonly IntPtr NativeMethodInfoPtr_FullHMSMatch_Internal_Boolean_FormatLiterals_0;

			// Token: 0x04004BD5 RID: 19413
			private static readonly IntPtr NativeMethodInfoPtr_FullDHMSMatch_Internal_Boolean_FormatLiterals_0;

			// Token: 0x04004BD6 RID: 19414
			private static readonly IntPtr NativeMethodInfoPtr_FullHMSFMatch_Internal_Boolean_FormatLiterals_0;

			// Token: 0x04004BD7 RID: 19415
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_DateTimeFormatInfo_0;

			// Token: 0x04004BD8 RID: 19416
			private static readonly IntPtr NativeMethodInfoPtr_ProcessToken_Internal_Boolean_byref_TimeSpanToken_byref_TimeSpanResult_0;

			// Token: 0x04004BD9 RID: 19417
			private static readonly IntPtr NativeMethodInfoPtr_AddSep_Private_Boolean_ReadOnlySpan_1_Char_byref_TimeSpanResult_0;

			// Token: 0x04004BDA RID: 19418
			private static readonly IntPtr NativeMethodInfoPtr_AddNum_Private_Boolean_TimeSpanToken_byref_TimeSpanResult_0;
		}

		// Token: 0x020006D7 RID: 1751
		[StructLayout(2)]
		public struct TimeSpanResult
		{
			// Token: 0x06005D4F RID: 23887 RVA: 0x001A624C File Offset: 0x001A444C
			// Note: this type is marked as 'beforefieldinit'.
			static TimeSpanResult()
			{
				Il2CppClassPointerStore<TimeSpanParse.TimeSpanResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, "TimeSpanResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanParse.TimeSpanResult>.NativeClassPtr);
				TimeSpanParse.TimeSpanResult.NativeFieldInfoPtr_parsedTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanResult>.NativeClassPtr, "parsedTimeSpan");
				TimeSpanParse.TimeSpanResult.NativeFieldInfoPtr__throwOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanParse.TimeSpanResult>.NativeClassPtr, "_throwOnFailure");
				TimeSpanParse.TimeSpanResult.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanResult>.NativeClassPtr, 100673520);
				TimeSpanParse.TimeSpanResult.NativeMethodInfoPtr_SetFailure_Internal_Boolean_ParseFailureKind_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse.TimeSpanResult>.NativeClassPtr, 100673521);
			}

			// Token: 0x06005D50 RID: 23888 RVA: 0x001A62C8 File Offset: 0x001A44C8
			[CallerCount(0)]
			public unsafe TimeSpanResult(bool throwOnFailure)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref throwOnFailure;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanResult.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005D51 RID: 23889 RVA: 0x001A62FC File Offset: 0x001A44FC
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1409360, RefRangeEnd = 1409370, XrefRangeStart = 1409358, XrefRangeEnd = 1409360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool SetFailure(TimeSpanParse.ParseFailureKind kind, string resourceKey, Object messageArgument = null, string argumentName = null)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref kind;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(resourceKey);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageArgument);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argumentName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanParse.TimeSpanResult.NativeMethodInfoPtr_SetFailure_Internal_Boolean_ParseFailureKind_String_Object_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005D52 RID: 23890 RVA: 0x0002212D File Offset: 0x0002032D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanParse.TimeSpanResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04004BDB RID: 19419
			private static readonly IntPtr NativeFieldInfoPtr_parsedTimeSpan;

			// Token: 0x04004BDC RID: 19420
			private static readonly IntPtr NativeFieldInfoPtr__throwOnFailure;

			// Token: 0x04004BDD RID: 19421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

			// Token: 0x04004BDE RID: 19422
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Boolean_ParseFailureKind_String_Object_String_0;

			// Token: 0x04004BDF RID: 19423
			[FieldOffset(0)]
			public TimeSpan parsedTimeSpan;

			// Token: 0x04004BE0 RID: 19424
			[FieldOffset(8)]
			[MarshalAs(4)]
			public readonly bool _throwOnFailure;
		}
	}
}
