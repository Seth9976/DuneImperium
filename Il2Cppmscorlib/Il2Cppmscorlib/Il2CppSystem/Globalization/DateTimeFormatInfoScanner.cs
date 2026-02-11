using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000473 RID: 1139
	public class DateTimeFormatInfoScanner : Object
	{
		// Token: 0x060044F5 RID: 17653 RVA: 0x00143D40 File Offset: 0x00141F40
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormatInfoScanner()
		{
			Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "DateTimeFormatInfoScanner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr);
			DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_dateWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "m_dateWords");
			DateTimeFormatInfoScanner.NativeFieldInfoPtr_s_knownWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "s_knownWords");
			DateTimeFormatInfoScanner.NativeFieldInfoPtr__ymdFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "_ymdFlags");
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673442);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673443);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673444);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673445);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673446);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673447);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673448);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673449);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673450);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673451);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673452);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673453);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673454);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673455);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673456);
			DateTimeFormatInfoScanner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100673457);
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x00143EEC File Offset: 0x001420EC
		public unsafe static Dictionary<string, string> KnownWords
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1408607, RefRangeEnd = 1408608, XrefRangeStart = 1408510, XrefRangeEnd = 1408607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00143F20 File Offset: 0x00142120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408608, XrefRangeEnd = 1408615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00143F70 File Offset: 0x00142170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1408645, RefRangeEnd = 1408647, XrefRangeStart = 1408615, XrefRangeEnd = 1408645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDateWordOrPostfix(string formatPostfix, string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(formatPostfix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00143FC4 File Offset: 0x001421C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1408672, RefRangeEnd = 1408674, XrefRangeStart = 1408647, XrefRangeEnd = 1408672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddDateWords(string pattern, int index, string formatPostfix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatPostfix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x00144034 File Offset: 0x00142234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408674, XrefRangeEnd = 1408676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ScanRepeatChar(string pattern, char ch, int index, out int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x001440A0 File Offset: 0x001422A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1408692, RefRangeEnd = 1408693, XrefRangeStart = 1408676, XrefRangeEnd = 1408692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIgnorableSymbols(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x001440E4 File Offset: 0x001422E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1408718, RefRangeEnd = 1408724, XrefRangeStart = 1408693, XrefRangeEnd = 1408718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanDateWord(string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00144128 File Offset: 0x00142328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1408751, RefRangeEnd = 1408752, XrefRangeStart = 1408724, XrefRangeEnd = 1408751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetDateWordsOfDTFI(DateTimeFormatInfo dtfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00144178 File Offset: 0x00142378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408752, XrefRangeEnd = 1408757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FORMATFLAGS GetFormatFlagGenitiveMonth(Il2CppStringArray monthNames, Il2CppStringArray genitveMonthNames, Il2CppStringArray abbrevMonthNames, Il2CppStringArray genetiveAbbrevMonthNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(monthNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genitveMonthNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbrevMonthNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genetiveAbbrevMonthNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x001441F0 File Offset: 0x001423F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408757, XrefRangeEnd = 1408765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(Il2CppStringArray monthNames, Il2CppStringArray genitveMonthNames, Il2CppStringArray abbrevMonthNames, Il2CppStringArray genetiveAbbrevMonthNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(monthNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genitveMonthNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbrevMonthNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genetiveAbbrevMonthNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00144268 File Offset: 0x00142468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408765, XrefRangeEnd = 1408767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(Il2CppStringArray dayNames, Il2CppStringArray abbrevDayNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dayNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abbrevDayNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x001442BC File Offset: 0x001424BC
		[CallerCount(0)]
		public unsafe static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x001442FC File Offset: 0x001424FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408767, XrefRangeEnd = 1408769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualStringArrays(Il2CppStringArray array1, Il2CppStringArray array2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00144350 File Offset: 0x00142550
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1408776, RefRangeEnd = 1408788, XrefRangeStart = 1408769, XrefRangeEnd = 1408776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ArrayElementsHaveSpace(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00144394 File Offset: 0x00142594
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1408799, RefRangeEnd = 1408807, XrefRangeStart = 1408788, XrefRangeEnd = 1408799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ArrayElementsBeginWithDigit(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x001443D8 File Offset: 0x001425D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408807, XrefRangeEnd = 1408815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeFormatInfoScanner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeFormatInfoScanner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x00019091 File Offset: 0x00017291
		public DateTimeFormatInfoScanner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06004507 RID: 17671 RVA: 0x00144414 File Offset: 0x00142614
		// (set) Token: 0x06004508 RID: 17672 RVA: 0x0001909A File Offset: 0x0001729A
		public unsafe List<string> m_dateWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_dateWords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr_m_dateWords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06004509 RID: 17673 RVA: 0x00144444 File Offset: 0x00142644
		// (set) Token: 0x0600450A RID: 17674 RVA: 0x000190B9 File Offset: 0x000172B9
		public unsafe static Dictionary<string, string> s_knownWords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTimeFormatInfoScanner.NativeFieldInfoPtr_s_knownWords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeFormatInfoScanner.NativeFieldInfoPtr_s_knownWords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x0600450B RID: 17675 RVA: 0x0014446C File Offset: 0x0014266C
		// (set) Token: 0x0600450C RID: 17676 RVA: 0x000190CB File Offset: 0x000172CB
		public unsafe DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr__ymdFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeFormatInfoScanner.NativeFieldInfoPtr__ymdFlags)) = value;
			}
		}

		// Token: 0x040038D7 RID: 14551
		private static readonly IntPtr NativeFieldInfoPtr_m_dateWords;

		// Token: 0x040038D8 RID: 14552
		private static readonly IntPtr NativeFieldInfoPtr_s_knownWords;

		// Token: 0x040038D9 RID: 14553
		private static readonly IntPtr NativeFieldInfoPtr__ymdFlags;

		// Token: 0x040038DA RID: 14554
		private static readonly IntPtr NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x040038DB RID: 14555
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0;

		// Token: 0x040038DC RID: 14556
		private static readonly IntPtr NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0;

		// Token: 0x040038DD RID: 14557
		private static readonly IntPtr NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0;

		// Token: 0x040038DE RID: 14558
		private static readonly IntPtr NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0;

		// Token: 0x040038DF RID: 14559
		private static readonly IntPtr NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0;

		// Token: 0x040038E0 RID: 14560
		private static readonly IntPtr NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0;

		// Token: 0x040038E1 RID: 14561
		private static readonly IntPtr NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0;

		// Token: 0x040038E2 RID: 14562
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x040038E3 RID: 14563
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x040038E4 RID: 14564
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x040038E5 RID: 14565
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0;

		// Token: 0x040038E6 RID: 14566
		private static readonly IntPtr NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x040038E7 RID: 14567
		private static readonly IntPtr NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0;

		// Token: 0x040038E8 RID: 14568
		private static readonly IntPtr NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0;

		// Token: 0x040038E9 RID: 14569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006CB RID: 1739
		public enum FoundDatePattern
		{
			// Token: 0x04004B59 RID: 19289
			None,
			// Token: 0x04004B5A RID: 19290
			FoundYearPatternFlag,
			// Token: 0x04004B5B RID: 19291
			FoundMonthPatternFlag,
			// Token: 0x04004B5C RID: 19292
			FoundDayPatternFlag = 4,
			// Token: 0x04004B5D RID: 19293
			FoundYMDPatternFlag = 7
		}
	}
}
