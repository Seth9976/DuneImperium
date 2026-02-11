using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200047B RID: 1147
	public static class TimeSpanFormat : Object
	{
		// Token: 0x06004529 RID: 17705 RVA: 0x00144A6C File Offset: 0x00142C6C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanFormat()
		{
			Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TimeSpanFormat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr);
			TimeSpanFormat.NativeFieldInfoPtr_PositiveInvariantFormatLiterals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "PositiveInvariantFormatLiterals");
			TimeSpanFormat.NativeFieldInfoPtr_NegativeInvariantFormatLiterals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "NegativeInvariantFormatLiterals");
			TimeSpanFormat.NativeMethodInfoPtr_AppendNonNegativeInt32_Private_Static_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100673470);
			TimeSpanFormat.NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100673471);
			TimeSpanFormat.NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_TimeSpan_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100673472);
			TimeSpanFormat.NativeMethodInfoPtr_FormatToBuilder_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100673473);
			TimeSpanFormat.NativeMethodInfoPtr_FormatStandard_Private_Static_StringBuilder_TimeSpan_Boolean_ReadOnlySpan_1_Char_Pattern_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100673474);
			TimeSpanFormat.NativeMethodInfoPtr_FormatCustomized_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_DateTimeFormatInfo_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100673475);
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x00144B3C File Offset: 0x00142D3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1408949, RefRangeEnd = 1408953, XrefRangeStart = 1408947, XrefRangeEnd = 1408949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_AppendNonNegativeInt32_Private_Static_Void_StringBuilder_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x00144B90 File Offset: 0x00142D90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1408961, RefRangeEnd = 1408963, XrefRangeStart = 1408953, XrefRangeEnd = 1408961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(TimeSpan value, string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x00144BEC File Offset: 0x00142DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1408970, RefRangeEnd = 1408971, XrefRangeStart = 1408963, XrefRangeEnd = 1408970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormat(TimeSpan value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_TimeSpan_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x00144C78 File Offset: 0x00142E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1408986, RefRangeEnd = 1408988, XrefRangeStart = 1408971, XrefRangeEnd = 1408986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<char> format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_FormatToBuilder_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x00144CE4 File Offset: 0x00142EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408988, XrefRangeEnd = 1409038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<char> format, TimeSpanFormat.Pattern pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInvariant;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pattern;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_FormatStandard_Private_Static_StringBuilder_TimeSpan_Boolean_ReadOnlySpan_1_Char_Pattern_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x00144D58 File Offset: 0x00142F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409085, RefRangeEnd = 1409086, XrefRangeStart = 1409038, XrefRangeEnd = 1409085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, StringBuilder result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_FormatCustomized_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_DateTimeFormatInfo_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x00019184 File Offset: 0x00017384
		public TimeSpanFormat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06004531 RID: 17713 RVA: 0x00144DD4 File Offset: 0x00142FD4
		// (set) Token: 0x06004532 RID: 17714 RVA: 0x0001918D File Offset: 0x0001738D
		public unsafe static TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TimeSpanFormat.NativeFieldInfoPtr_PositiveInvariantFormatLiterals, intPtr);
				return new TimeSpanFormat.FormatLiterals(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanFormat.NativeFieldInfoPtr_PositiveInvariantFormatLiterals, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x00144E10 File Offset: 0x00143010
		// (set) Token: 0x06004534 RID: 17716 RVA: 0x000191A4 File Offset: 0x000173A4
		public unsafe static TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TimeSpanFormat.NativeFieldInfoPtr_NegativeInvariantFormatLiterals, intPtr);
				return new TimeSpanFormat.FormatLiterals(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanFormat.NativeFieldInfoPtr_NegativeInvariantFormatLiterals, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x04003925 RID: 14629
		private static readonly IntPtr NativeFieldInfoPtr_PositiveInvariantFormatLiterals;

		// Token: 0x04003926 RID: 14630
		private static readonly IntPtr NativeFieldInfoPtr_NegativeInvariantFormatLiterals;

		// Token: 0x04003927 RID: 14631
		private static readonly IntPtr NativeMethodInfoPtr_AppendNonNegativeInt32_Private_Static_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x04003928 RID: 14632
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0;

		// Token: 0x04003929 RID: 14633
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_TimeSpan_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x0400392A RID: 14634
		private static readonly IntPtr NativeMethodInfoPtr_FormatToBuilder_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x0400392B RID: 14635
		private static readonly IntPtr NativeMethodInfoPtr_FormatStandard_Private_Static_StringBuilder_TimeSpan_Boolean_ReadOnlySpan_1_Char_Pattern_0;

		// Token: 0x0400392C RID: 14636
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomized_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_DateTimeFormatInfo_StringBuilder_0;

		// Token: 0x020006CF RID: 1743
		public enum Pattern
		{
			// Token: 0x04004B84 RID: 19332
			None,
			// Token: 0x04004B85 RID: 19333
			Minimum,
			// Token: 0x04004B86 RID: 19334
			Full
		}

		// Token: 0x020006D0 RID: 1744
		public sealed class FormatLiterals : ValueType
		{
			// Token: 0x06005CDF RID: 23775 RVA: 0x001A4CD0 File Offset: 0x001A2ED0
			// Note: this type is marked as 'beforefieldinit'.
			static FormatLiterals()
			{
				Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "FormatLiterals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr);
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_AppCompatLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "AppCompatLiteral");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "dd");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_hh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "hh");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "mm");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "ss");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "ff");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr__literals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "_literals");
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_Start_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100673477);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100673478);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100673479);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100673480);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100673481);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_End_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100673482);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100673483);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_Init_Internal_Void_ReadOnlySpan_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100673484);
			}

			// Token: 0x170017C6 RID: 6086
			// (get) Token: 0x06005CE0 RID: 23776 RVA: 0x001A4E28 File Offset: 0x001A3028
			public unsafe string Start
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 478929, RefRangeEnd = 478930, XrefRangeStart = 478929, XrefRangeEnd = 478930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_Start_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170017C7 RID: 6087
			// (get) Token: 0x06005CE1 RID: 23777 RVA: 0x001A4E64 File Offset: 0x001A3064
			public unsafe string DayHourSep
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 478930, RefRangeEnd = 478931, XrefRangeStart = 478930, XrefRangeEnd = 478931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170017C8 RID: 6088
			// (get) Token: 0x06005CE2 RID: 23778 RVA: 0x001A4EA0 File Offset: 0x001A30A0
			public unsafe string HourMinuteSep
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 478931, RefRangeEnd = 478932, XrefRangeStart = 478931, XrefRangeEnd = 478932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170017C9 RID: 6089
			// (get) Token: 0x06005CE3 RID: 23779 RVA: 0x001A4EDC File Offset: 0x001A30DC
			public unsafe string MinuteSecondSep
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 478932, RefRangeEnd = 478933, XrefRangeStart = 478932, XrefRangeEnd = 478933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170017CA RID: 6090
			// (get) Token: 0x06005CE4 RID: 23780 RVA: 0x001A4F18 File Offset: 0x001A3118
			public unsafe string SecondFractionSep
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 478933, RefRangeEnd = 478935, XrefRangeStart = 478933, XrefRangeEnd = 478935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170017CB RID: 6091
			// (get) Token: 0x06005CE5 RID: 23781 RVA: 0x001A4F54 File Offset: 0x001A3154
			public unsafe string End
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1408892, RefRangeEnd = 1408893, XrefRangeStart = 1408892, XrefRangeEnd = 1408892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_End_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005CE6 RID: 23782 RVA: 0x001A4F90 File Offset: 0x001A3190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408893, XrefRangeEnd = 1408919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isNegative;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new TimeSpanFormat.FormatLiterals(intPtr);
				}
			}

			// Token: 0x06005CE7 RID: 23783 RVA: 0x001A4FC8 File Offset: 0x001A31C8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1408944, RefRangeEnd = 1408947, XrefRangeStart = 1408919, XrefRangeEnd = 1408944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(ReadOnlySpan<char> format, bool useInvariantFieldLengths)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInvariantFieldLengths;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_Init_Internal_Void_ReadOnlySpan_1_Char_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005CE8 RID: 23784 RVA: 0x00021BFE File Offset: 0x0001FDFE
			public FormatLiterals(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005CE9 RID: 23785 RVA: 0x00021C07 File Offset: 0x0001FE07
			public FormatLiterals()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr))
			{
			}

			// Token: 0x170017BF RID: 6079
			// (get) Token: 0x06005CEA RID: 23786 RVA: 0x001A5024 File Offset: 0x001A3224
			// (set) Token: 0x06005CEB RID: 23787 RVA: 0x00021C19 File Offset: 0x0001FE19
			public unsafe string AppCompatLiteral
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_AppCompatLiteral);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_AppCompatLiteral), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170017C0 RID: 6080
			// (get) Token: 0x06005CEC RID: 23788 RVA: 0x001A504C File Offset: 0x001A324C
			// (set) Token: 0x06005CED RID: 23789 RVA: 0x00021C38 File Offset: 0x0001FE38
			public unsafe int dd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_dd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_dd)) = value;
				}
			}

			// Token: 0x170017C1 RID: 6081
			// (get) Token: 0x06005CEE RID: 23790 RVA: 0x001A5074 File Offset: 0x001A3274
			// (set) Token: 0x06005CEF RID: 23791 RVA: 0x00021C53 File Offset: 0x0001FE53
			public unsafe int hh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_hh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_hh)) = value;
				}
			}

			// Token: 0x170017C2 RID: 6082
			// (get) Token: 0x06005CF0 RID: 23792 RVA: 0x001A509C File Offset: 0x001A329C
			// (set) Token: 0x06005CF1 RID: 23793 RVA: 0x00021C6E File Offset: 0x0001FE6E
			public unsafe int mm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_mm);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_mm)) = value;
				}
			}

			// Token: 0x170017C3 RID: 6083
			// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x001A50C4 File Offset: 0x001A32C4
			// (set) Token: 0x06005CF3 RID: 23795 RVA: 0x00021C89 File Offset: 0x0001FE89
			public unsafe int ss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ss);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ss)) = value;
				}
			}

			// Token: 0x170017C4 RID: 6084
			// (get) Token: 0x06005CF4 RID: 23796 RVA: 0x001A50EC File Offset: 0x001A32EC
			// (set) Token: 0x06005CF5 RID: 23797 RVA: 0x00021CA4 File Offset: 0x0001FEA4
			public unsafe int ff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ff);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ff)) = value;
				}
			}

			// Token: 0x170017C5 RID: 6085
			// (get) Token: 0x06005CF6 RID: 23798 RVA: 0x001A5114 File Offset: 0x001A3314
			// (set) Token: 0x06005CF7 RID: 23799 RVA: 0x00021CBF File Offset: 0x0001FEBF
			public unsafe Il2CppStringArray _literals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr__literals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr__literals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004B87 RID: 19335
			private static readonly IntPtr NativeFieldInfoPtr_AppCompatLiteral;

			// Token: 0x04004B88 RID: 19336
			private static readonly IntPtr NativeFieldInfoPtr_dd;

			// Token: 0x04004B89 RID: 19337
			private static readonly IntPtr NativeFieldInfoPtr_hh;

			// Token: 0x04004B8A RID: 19338
			private static readonly IntPtr NativeFieldInfoPtr_mm;

			// Token: 0x04004B8B RID: 19339
			private static readonly IntPtr NativeFieldInfoPtr_ss;

			// Token: 0x04004B8C RID: 19340
			private static readonly IntPtr NativeFieldInfoPtr_ff;

			// Token: 0x04004B8D RID: 19341
			private static readonly IntPtr NativeFieldInfoPtr__literals;

			// Token: 0x04004B8E RID: 19342
			private static readonly IntPtr NativeMethodInfoPtr_get_Start_Internal_get_String_0;

			// Token: 0x04004B8F RID: 19343
			private static readonly IntPtr NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0;

			// Token: 0x04004B90 RID: 19344
			private static readonly IntPtr NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0;

			// Token: 0x04004B91 RID: 19345
			private static readonly IntPtr NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0;

			// Token: 0x04004B92 RID: 19346
			private static readonly IntPtr NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0;

			// Token: 0x04004B93 RID: 19347
			private static readonly IntPtr NativeMethodInfoPtr_get_End_Internal_get_String_0;

			// Token: 0x04004B94 RID: 19348
			private static readonly IntPtr NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0;

			// Token: 0x04004B95 RID: 19349
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_ReadOnlySpan_1_Char_Boolean_0;
		}
	}
}
