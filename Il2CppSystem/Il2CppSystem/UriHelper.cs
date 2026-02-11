using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000065 RID: 101
	public static class UriHelper : Object
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x00033EFC File Offset: 0x000320FC
		// Note: this type is marked as 'beforefieldinit'.
		static UriHelper()
		{
			Il2CppClassPointerStore<UriHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriHelper>.NativeClassPtr);
			UriHelper.NativeFieldInfoPtr_HexUpperChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, "HexUpperChars");
			UriHelper.NativeMethodInfoPtr_TestForSubPath_Internal_Static_Boolean_ptr_Char_UInt16_ptr_Char_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664345);
			UriHelper.NativeMethodInfoPtr_EscapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Boolean_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664346);
			UriHelper.NativeMethodInfoPtr_EnsureDestinationSize_Private_Static_Il2CppStructArray_1_Char_ptr_Char_Il2CppStructArray_1_Char_Int32_Int16_Int16_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664347);
			UriHelper.NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664348);
			UriHelper.NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_ptr_Char_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664349);
			UriHelper.NativeMethodInfoPtr_MatchUTF8Sequence_Internal_Static_Void_ptr_Char_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664350);
			UriHelper.NativeMethodInfoPtr_EscapeAsciiChar_Internal_Static_Void_Char_Il2CppStructArray_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664351);
			UriHelper.NativeMethodInfoPtr_EscapedAscii_Internal_Static_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664352);
			UriHelper.NativeMethodInfoPtr_IsNotSafeForUnescape_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664353);
			UriHelper.NativeMethodInfoPtr_IsReservedUnreservedOrHash_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664354);
			UriHelper.NativeMethodInfoPtr_IsUnreserved_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664355);
			UriHelper.NativeMethodInfoPtr_Is3986Unreserved_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664356);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00034030 File Offset: 0x00032230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436096, RefRangeEnd = 436097, XrefRangeStart = 436084, XrefRangeEnd = 436096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pMe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pShe;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sheLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_TestForSubPath_Internal_Static_Boolean_ptr_Char_UInt16_ptr_Char_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000340A4 File Offset: 0x000322A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 436140, RefRangeEnd = 436147, XrefRangeStart = 436097, XrefRangeEnd = 436140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> EscapeString(string input, int start, int end, Il2CppStructArray<char> dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destPos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUriString;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force1;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force2;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_EscapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Boolean_Char_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00034160 File Offset: 0x00032360
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 436151, RefRangeEnd = 436154, XrefRangeStart = 436147, XrefRangeEnd = 436151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> EnsureDestinationSize(char* pStr, Il2CppStructArray<char> dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pStr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentInputPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charsToAdd;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minReallocateChars;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destPos;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevInputPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_EnsureDestinationSize_Private_Static_Il2CppStructArray_1_Char_ptr_Char_Il2CppStructArray_1_Char_Int32_Int16_Int16_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000341F8 File Offset: 0x000323F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 436159, RefRangeEnd = 436166, XrefRangeStart = 436154, XrefRangeEnd = 436159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> UnescapeString(string input, int start, int end, Il2CppStructArray<char> dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destPosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd1;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd2;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd3;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unescapeMode;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isQuery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000342D8 File Offset: 0x000324D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436237, RefRangeEnd = 436238, XrefRangeStart = 436166, XrefRangeEnd = 436237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> UnescapeString(char* pStr, int start, int end, Il2CppStructArray<char> dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pStr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destPosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd1;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd2;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rsvd3;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unescapeMode;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isQuery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_ptr_Char_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000343B0 File Offset: 0x000325B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 436271, RefRangeEnd = 436273, XrefRangeStart = 436238, XrefRangeEnd = 436271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MatchUTF8Sequence(char* pDest, Il2CppStructArray<char> dest, ref int destOffset, Il2CppStructArray<char> unescapedChars, int charCount, Il2CppStructArray<byte> bytes, int byteCount, bool isQuery, bool iriParsing)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unescapedChars);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isQuery;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iriParsing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_MatchUTF8Sequence_Internal_Static_Void_ptr_Char_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00034460 File Offset: 0x00032660
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 436278, RefRangeEnd = 436286, XrefRangeStart = 436273, XrefRangeEnd = 436278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EscapeAsciiChar(char ch, Il2CppStructArray<char> to, ref int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_EscapeAsciiChar_Internal_Static_Void_Char_Il2CppStructArray_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000344B4 File Offset: 0x000326B4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 436287, RefRangeEnd = 436296, XrefRangeStart = 436286, XrefRangeEnd = 436287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char EscapedAscii(char digit, char next)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digit;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref next;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_EscapedAscii_Internal_Static_Char_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00034500 File Offset: 0x00032700
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 436296, RefRangeEnd = 436299, XrefRangeStart = 436296, XrefRangeEnd = 436296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNotSafeForUnescape(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_IsNotSafeForUnescape_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00034540 File Offset: 0x00032740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436314, RefRangeEnd = 436315, XrefRangeStart = 436299, XrefRangeEnd = 436314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsReservedUnreservedOrHash(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_IsReservedUnreservedOrHash_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00034580 File Offset: 0x00032780
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 436330, RefRangeEnd = 436332, XrefRangeStart = 436315, XrefRangeEnd = 436330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUnreserved(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_IsUnreserved_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000345C0 File Offset: 0x000327C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436339, RefRangeEnd = 436340, XrefRangeStart = 436332, XrefRangeEnd = 436339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is3986Unreserved(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriHelper.NativeMethodInfoPtr_Is3986Unreserved_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00003EC0 File Offset: 0x000020C0
		public UriHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00034600 File Offset: 0x00032800
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00003EC9 File Offset: 0x000020C9
		public unsafe static Il2CppStructArray<char> HexUpperChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriHelper.NativeFieldInfoPtr_HexUpperChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriHelper.NativeFieldInfoPtr_HexUpperChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeFieldInfoPtr_HexUpperChars;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_TestForSubPath_Internal_Static_Boolean_ptr_Char_UInt16_ptr_Char_UInt16_Boolean_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_EscapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Boolean_Char_Char_Char_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDestinationSize_Private_Static_Il2CppStructArray_1_Char_ptr_Char_Il2CppStructArray_1_Char_Int32_Int16_Int16_byref_Int32_Int32_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_ptr_Char_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_MatchUTF8Sequence_Internal_Static_Void_ptr_Char_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_EscapeAsciiChar_Internal_Static_Void_Char_Il2CppStructArray_1_Char_byref_Int32_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_EscapedAscii_Internal_Static_Char_Char_Char_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_IsNotSafeForUnescape_Internal_Static_Boolean_Char_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_IsReservedUnreservedOrHash_Private_Static_Boolean_Char_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_IsUnreserved_Internal_Static_Boolean_Char_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_Is3986Unreserved_Internal_Static_Boolean_Char_0;
	}
}
