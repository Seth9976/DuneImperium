using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x02000099 RID: 153
	public sealed class __DTString : ValueType
	{
		// Token: 0x06000AB0 RID: 2736 RVA: 0x000572FC File Offset: 0x000554FC
		// Note: this type is marked as 'beforefieldinit'.
		static __DTString()
		{
			Il2CppClassPointerStore<__DTString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__DTString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__DTString>.NativeClassPtr);
			__DTString.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "Value");
			__DTString.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "Index");
			__DTString.NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "m_current");
			__DTString.NativeFieldInfoPtr_m_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "m_info");
			__DTString.NativeFieldInfoPtr_m_checkDigitToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "m_checkDigitToken");
			__DTString.NativeFieldInfoPtr_WhiteSpaceChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "WhiteSpaceChecks");
			__DTString.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665188);
			__DTString.NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_DateTimeFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665189);
			__DTString.NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665190);
			__DTString.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665191);
			__DTString.NativeMethodInfoPtr_GetNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665192);
			__DTString.NativeMethodInfoPtr_AtEnd_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665193);
			__DTString.NativeMethodInfoPtr_Advance_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665194);
			__DTString.NativeMethodInfoPtr_GetRegularToken_Internal_Void_byref_TokenType_byref_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665195);
			__DTString.NativeMethodInfoPtr_GetSeparatorToken_Internal_TokenType_DateTimeFormatInfo_byref_Int32_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665196);
			__DTString.NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665197);
			__DTString.NativeMethodInfoPtr_MatchSpecifiedWords_Internal_Boolean_String_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665198);
			__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665199);
			__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665200);
			__DTString.NativeMethodInfoPtr_MatchLongestWords_Internal_Int32_Il2CppStringArray_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665201);
			__DTString.NativeMethodInfoPtr_GetRepeatCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665202);
			__DTString.NativeMethodInfoPtr_GetNextDigit_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665203);
			__DTString.NativeMethodInfoPtr_GetChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665204);
			__DTString.NativeMethodInfoPtr_GetDigit_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665205);
			__DTString.NativeMethodInfoPtr_SkipWhiteSpaces_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665206);
			__DTString.NativeMethodInfoPtr_SkipWhiteSpaceCurrent_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665207);
			__DTString.NativeMethodInfoPtr_TrimTail_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665208);
			__DTString.NativeMethodInfoPtr_RemoveTrailingInQuoteSpaces_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665209);
			__DTString.NativeMethodInfoPtr_RemoveLeadingInQuoteSpaces_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665210);
			__DTString.NativeMethodInfoPtr_GetSubString_Internal_DTSubString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665211);
			__DTString.NativeMethodInfoPtr_ConsumeSubString_Internal_Void_DTSubString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665212);
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x00057598 File Offset: 0x00055798
		public unsafe int Length
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1306993, RefRangeEnd = 1307000, XrefRangeStart = 1306992, XrefRangeEnd = 1306993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000575DC File Offset: 0x000557DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1307010, RefRangeEnd = 1307012, XrefRangeStart = 1307000, XrefRangeEnd = 1307010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi, bool checkDigitToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__DTString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkDigitToken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_DateTimeFormatInfo_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00057654 File Offset: 0x00055854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307016, RefRangeEnd = 1307017, XrefRangeStart = 1307012, XrefRangeEnd = 1307016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__DTString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_DateTimeFormatInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x000576BC File Offset: 0x000558BC
		public unsafe CompareInfo CompareInfo
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00057700 File Offset: 0x00055900
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1307021, RefRangeEnd = 1307040, XrefRangeStart = 1307017, XrefRangeEnd = 1307021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetNext_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00057744 File Offset: 0x00055944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307044, RefRangeEnd = 1307045, XrefRangeStart = 1307040, XrefRangeEnd = 1307044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AtEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_AtEnd_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00057788 File Offset: 0x00055988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307049, RefRangeEnd = 1307050, XrefRangeStart = 1307045, XrefRangeEnd = 1307049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Advance(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_Advance_Internal_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000577D8 File Offset: 0x000559D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307079, RefRangeEnd = 1307080, XrefRangeStart = 1307050, XrefRangeEnd = 1307079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &tokenType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tokenValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetRegularToken_Internal_Void_byref_TokenType_byref_Int32_DateTimeFormatInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0005783C File Offset: 0x00055A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307101, RefRangeEnd = 1307102, XrefRangeStart = 1307080, XrefRangeEnd = 1307101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexBeforeSeparator;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charBeforeSeparator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetSeparatorToken_Internal_TokenType_DateTimeFormatInfo_byref_Int32_byref_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x000578AC File Offset: 0x00055AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307102, XrefRangeEnd = 1307107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchSpecifiedWord(string target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00057900 File Offset: 0x00055B00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1307147, RefRangeEnd = 1307152, XrefRangeStart = 1307107, XrefRangeEnd = 1307147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkWordBoundary;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matchLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchSpecifiedWords_Internal_Boolean_String_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00057970 File Offset: 0x00055B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307162, RefRangeEnd = 1307163, XrefRangeStart = 1307152, XrefRangeEnd = 1307162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Match(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x000579C4 File Offset: 0x00055BC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1307167, RefRangeEnd = 1307172, XrefRangeStart = 1307163, XrefRangeEnd = 1307167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Match(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00057A14 File Offset: 0x00055C14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1307177, RefRangeEnd = 1307180, XrefRangeStart = 1307172, XrefRangeEnd = 1307177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchLongestWords(Il2CppStringArray words, ref int maxMatchStrLen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(words);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxMatchStrLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchLongestWords_Internal_Int32_Il2CppStringArray_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00057A74 File Offset: 0x00055C74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1307185, RefRangeEnd = 1307188, XrefRangeStart = 1307180, XrefRangeEnd = 1307185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRepeatCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetRepeatCount_Internal_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00057AB8 File Offset: 0x00055CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307188, XrefRangeEnd = 1307193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNextDigit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetNextDigit_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00057AFC File Offset: 0x00055CFC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1307193, RefRangeEnd = 1307202, XrefRangeStart = 1307193, XrefRangeEnd = 1307193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char GetChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetChar_Internal_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00057B40 File Offset: 0x00055D40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1307202, RefRangeEnd = 1307205, XrefRangeStart = 1307202, XrefRangeEnd = 1307202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDigit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetDigit_Internal_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00057B84 File Offset: 0x00055D84
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1307214, RefRangeEnd = 1307225, XrefRangeStart = 1307205, XrefRangeEnd = 1307214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhiteSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_SkipWhiteSpaces_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00057BBC File Offset: 0x00055DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307225, XrefRangeEnd = 1307239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SkipWhiteSpaceCurrent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_SkipWhiteSpaceCurrent_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00057C00 File Offset: 0x00055E00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1307251, RefRangeEnd = 1307253, XrefRangeStart = 1307239, XrefRangeEnd = 1307251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrimTail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_TrimTail_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00057C38 File Offset: 0x00055E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307280, RefRangeEnd = 1307281, XrefRangeStart = 1307253, XrefRangeEnd = 1307280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrailingInQuoteSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_RemoveTrailingInQuoteSpaces_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00057C70 File Offset: 0x00055E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307314, RefRangeEnd = 1307315, XrefRangeStart = 1307281, XrefRangeEnd = 1307314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLeadingInQuoteSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_RemoveLeadingInQuoteSpaces_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00057CA8 File Offset: 0x00055EA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1307319, RefRangeEnd = 1307323, XrefRangeStart = 1307315, XrefRangeEnd = 1307319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DTSubString GetSubString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetSubString_Internal_DTSubString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new DTSubString(intPtr);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00057CE4 File Offset: 0x00055EE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1307327, RefRangeEnd = 1307331, XrefRangeStart = 1307323, XrefRangeEnd = 1307327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeSubString(DTSubString sub)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sub));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_ConsumeSubString_Internal_Void_DTSubString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x000048CA File Offset: 0x00002ACA
		public __DTString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000048D3 File Offset: 0x00002AD3
		public __DTString()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__DTString>.NativeClassPtr))
		{
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00057D30 File Offset: 0x00055F30
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x000048E5 File Offset: 0x00002AE5
		public ReadOnlySpan<char> Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Value);
				return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00057D60 File Offset: 0x00055F60
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x00004913 File Offset: 0x00002B13
		public unsafe int Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Index)) = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00057D88 File Offset: 0x00055F88
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x0000492E File Offset: 0x00002B2E
		public unsafe char m_current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_current)) = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00057DB0 File Offset: 0x00055FB0
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00004949 File Offset: 0x00002B49
		public unsafe CompareInfo m_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00057DE0 File Offset: 0x00055FE0
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00004968 File Offset: 0x00002B68
		public unsafe bool m_checkDigitToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_checkDigitToken);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_checkDigitToken)) = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x00057E08 File Offset: 0x00056008
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x00004983 File Offset: 0x00002B83
		public unsafe static Il2CppStructArray<char> WhiteSpaceChecks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(__DTString.NativeFieldInfoPtr_WhiteSpaceChecks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(__DTString.NativeFieldInfoPtr_WhiteSpaceChecks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeFieldInfoPtr_Index;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeFieldInfoPtr_m_current;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeFieldInfoPtr_m_info;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeFieldInfoPtr_m_checkDigitToken;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeFieldInfoPtr_WhiteSpaceChecks;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_DateTimeFormatInfo_Boolean_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlySpan_1_Char_DateTimeFormatInfo_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Internal_Boolean_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_AtEnd_Internal_Boolean_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Internal_Boolean_Int32_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_GetRegularToken_Internal_Void_byref_TokenType_byref_Int32_DateTimeFormatInfo_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_GetSeparatorToken_Internal_TokenType_DateTimeFormatInfo_byref_Int32_byref_Char_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_MatchSpecifiedWords_Internal_Boolean_String_Boolean_byref_Int32_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_Match_Internal_Boolean_String_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_Match_Internal_Boolean_Char_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_MatchLongestWords_Internal_Int32_Il2CppStringArray_byref_Int32_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_GetRepeatCount_Internal_Int32_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_GetNextDigit_Internal_Boolean_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_GetChar_Internal_Char_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_GetDigit_Internal_Int32_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhiteSpaces_Internal_Void_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhiteSpaceCurrent_Internal_Boolean_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_TrimTail_Internal_Void_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrailingInQuoteSpaces_Internal_Void_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLeadingInQuoteSpaces_Internal_Void_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_GetSubString_Internal_DTSubString_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeSubString_Internal_Void_DTSubString_0;
	}
}
