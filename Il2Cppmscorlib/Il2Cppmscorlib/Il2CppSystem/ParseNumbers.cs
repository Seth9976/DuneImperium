using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000D7 RID: 215
	public static class ParseNumbers : Object
	{
		// Token: 0x06000DE8 RID: 3560 RVA: 0x00066E48 File Offset: 0x00065048
		// Note: this type is marked as 'beforefieldinit'.
		static ParseNumbers()
		{
			Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParseNumbers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr);
			ParseNumbers.NativeMethodInfoPtr_StringToLong_Public_Static_Int64_ReadOnlySpan_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665736);
			ParseNumbers.NativeMethodInfoPtr_StringToLong_Public_Static_Int64_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665737);
			ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665738);
			ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665739);
			ParseNumbers.NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665740);
			ParseNumbers.NativeMethodInfoPtr_LongToString_Public_Static_String_Int64_Int32_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665741);
			ParseNumbers.NativeMethodInfoPtr_EatWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665742);
			ParseNumbers.NativeMethodInfoPtr_GrabLongs_Private_Static_Int64_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665743);
			ParseNumbers.NativeMethodInfoPtr_GrabInts_Private_Static_Int32_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665744);
			ParseNumbers.NativeMethodInfoPtr_ThrowOverflowInt32Exception_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665745);
			ParseNumbers.NativeMethodInfoPtr_ThrowOverflowInt64Exception_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665746);
			ParseNumbers.NativeMethodInfoPtr_ThrowOverflowUInt32Exception_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665747);
			ParseNumbers.NativeMethodInfoPtr_ThrowOverflowUInt64Exception_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665748);
			ParseNumbers.NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665749);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00066F90 File Offset: 0x00065190
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1318362, RefRangeEnd = 1318364, XrefRangeStart = 1318361, XrefRangeEnd = 1318362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long StringToLong(ReadOnlySpan<char> s, int radix, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_StringToLong_Public_Static_Int64_ReadOnlySpan_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00066FF4 File Offset: 0x000651F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1318373, RefRangeEnd = 1318375, XrefRangeStart = 1318364, XrefRangeEnd = 1318373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long StringToLong(ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_StringToLong_Public_Static_Int64_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00067064 File Offset: 0x00065264
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1318376, RefRangeEnd = 1318382, XrefRangeStart = 1318375, XrefRangeEnd = 1318376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringToInt(ReadOnlySpan<char> s, int radix, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000670C8 File Offset: 0x000652C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1318392, RefRangeEnd = 1318394, XrefRangeStart = 1318382, XrefRangeEnd = 1318392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringToInt(ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00067138 File Offset: 0x00065338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1318410, RefRangeEnd = 1318412, XrefRangeStart = 1318394, XrefRangeEnd = 1318410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(int n, int radix, int width, char paddingChar, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000671A8 File Offset: 0x000653A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1318430, RefRangeEnd = 1318431, XrefRangeStart = 1318412, XrefRangeEnd = 1318430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LongToString(long n, int radix, int width, char paddingChar, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_LongToString_Public_Static_String_Int64_Int32_Int32_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00067218 File Offset: 0x00065418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318431, XrefRangeEnd = 1318436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EatWhiteSpace(ReadOnlySpan<char> s, ref int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_EatWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00067264 File Offset: 0x00065464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1318444, RefRangeEnd = 1318445, XrefRangeStart = 1318436, XrefRangeEnd = 1318444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GrabLongs(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &i;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUnsigned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_GrabLongs_Private_Static_Int64_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000672D4 File Offset: 0x000654D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1318453, RefRangeEnd = 1318454, XrefRangeStart = 1318445, XrefRangeEnd = 1318453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GrabInts(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &i;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUnsigned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_GrabInts_Private_Static_Int32_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00067344 File Offset: 0x00065544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318454, XrefRangeEnd = 1318460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOverflowInt32Exception()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_ThrowOverflowInt32Exception_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0006736C File Offset: 0x0006556C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318460, XrefRangeEnd = 1318466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOverflowInt64Exception()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_ThrowOverflowInt64Exception_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00067394 File Offset: 0x00065594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318466, XrefRangeEnd = 1318472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOverflowUInt32Exception()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_ThrowOverflowUInt32Exception_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000673BC File Offset: 0x000655BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318472, XrefRangeEnd = 1318478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOverflowUInt64Exception()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_ThrowOverflowUInt64Exception_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x000673E4 File Offset: 0x000655E4
		[CallerCount(0)]
		public unsafe static bool IsDigit(char c, int radix, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x000055F0 File Offset: 0x000037F0
		public ParseNumbers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_StringToLong_Public_Static_Int64_ReadOnlySpan_1_Char_Int32_Int32_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_StringToLong_Public_Static_Int64_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_LongToString_Public_Static_String_Int64_Int32_Int32_Char_Int32_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_EatWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_byref_Int32_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_GrabLongs_Private_Static_Int64_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_GrabInts_Private_Static_Int32_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOverflowInt32Exception_Private_Static_Void_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOverflowInt64Exception_Private_Static_Void_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOverflowUInt32Exception_Private_Static_Void_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOverflowUInt64Exception_Private_Static_Void_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Char_Int32_byref_Int32_0;
	}
}
