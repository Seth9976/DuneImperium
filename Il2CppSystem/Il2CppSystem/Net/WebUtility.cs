using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Configuration;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x020001CA RID: 458
	public static class WebUtility : Object
	{
		// Token: 0x06001C55 RID: 7253 RVA: 0x0008AD98 File Offset: 0x00088F98
		// Note: this type is marked as 'beforefieldinit'.
		static WebUtility()
		{
			Il2CppClassPointerStore<WebUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebUtility>.NativeClassPtr);
			WebUtility.NativeFieldInfoPtr__htmlEntityEndingChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, "_htmlEntityEndingChars");
			WebUtility.NativeFieldInfoPtr__htmlDecodeConformance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, "_htmlDecodeConformance");
			WebUtility.NativeFieldInfoPtr__htmlEncodeConformance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, "_htmlEncodeConformance");
			WebUtility.NativeMethodInfoPtr_HtmlEncode_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, 100667650);
			WebUtility.NativeMethodInfoPtr_HtmlEncode_Public_Static_Void_String_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, 100667651);
			WebUtility.NativeMethodInfoPtr_IndexOfHtmlEncodingChars_Private_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, 100667652);
			WebUtility.NativeMethodInfoPtr_get_HtmlEncodeConformance_Private_Static_get_UnicodeEncodingConformance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, 100667653);
			WebUtility.NativeMethodInfoPtr_UrlDecodeInternal_Private_Static_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, 100667654);
			WebUtility.NativeMethodInfoPtr_UrlDecode_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, 100667655);
			WebUtility.NativeMethodInfoPtr_GetNextUnicodeScalarValueFromUtf16Surrogate_Private_Static_Int32_byref_ptr_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, 100667656);
			WebUtility.NativeMethodInfoPtr_HexToInt_Private_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, 100667657);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0008AEA4 File Offset: 0x000890A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475917, XrefRangeEnd = 475933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string HtmlEncode(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.NativeMethodInfoPtr_HtmlEncode_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0008AEE0 File Offset: 0x000890E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 475977, RefRangeEnd = 475978, XrefRangeStart = 475933, XrefRangeEnd = 475977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HtmlEncode(string value, TextWriter output)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.NativeMethodInfoPtr_HtmlEncode_Public_Static_Void_String_TextWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0008AF28 File Offset: 0x00089128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 475987, RefRangeEnd = 475989, XrefRangeStart = 475978, XrefRangeEnd = 475987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfHtmlEncodingChars(string s, int startPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.NativeMethodInfoPtr_IndexOfHtmlEncodingChars_Private_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0008AF78 File Offset: 0x00089178
		public unsafe static UnicodeEncodingConformance HtmlEncodeConformance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 476004, RefRangeEnd = 476006, XrefRangeStart = 475989, XrefRangeEnd = 476004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.NativeMethodInfoPtr_get_HtmlEncodeConformance_Private_Static_get_UnicodeEncodingConformance_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0008AFA8 File Offset: 0x000891A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476031, RefRangeEnd = 476032, XrefRangeStart = 476006, XrefRangeEnd = 476031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UrlDecodeInternal(string value, Encoding encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.NativeMethodInfoPtr_UrlDecodeInternal_Private_Static_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0008AFF8 File Offset: 0x000891F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 476037, RefRangeEnd = 476043, XrefRangeStart = 476032, XrefRangeEnd = 476037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UrlDecode(string encodedValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(encodedValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.NativeMethodInfoPtr_UrlDecode_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0008B034 File Offset: 0x00089234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476043, XrefRangeEnd = 476047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNextUnicodeScalarValueFromUtf16Surrogate(ref char* pch, ref int charsRemaining)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pch);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsRemaining;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebUtility.NativeMethodInfoPtr_GetNextUnicodeScalarValueFromUtf16Surrogate_Private_Static_Int32_byref_ptr_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pch = ((intPtr4 == 0) ? null : new char*(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0008B09C File Offset: 0x0008929C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476047, RefRangeEnd = 476048, XrefRangeStart = 476047, XrefRangeEnd = 476047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HexToInt(char h)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.NativeMethodInfoPtr_HexToInt_Private_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0000C0A6 File Offset: 0x0000A2A6
		public WebUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0008B0DC File Offset: 0x000892DC
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x0000C0AF File Offset: 0x0000A2AF
		public unsafe static Il2CppStructArray<char> _htmlEntityEndingChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebUtility.NativeFieldInfoPtr__htmlEntityEndingChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebUtility.NativeFieldInfoPtr__htmlEntityEndingChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0008B104 File Offset: 0x00089304
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x0000C0C1 File Offset: 0x0000A2C1
		public unsafe static UnicodeDecodingConformance _htmlDecodeConformance
		{
			get
			{
				UnicodeDecodingConformance unicodeDecodingConformance;
				IL2CPP.il2cpp_field_static_get_value(WebUtility.NativeFieldInfoPtr__htmlDecodeConformance, (void*)(&unicodeDecodingConformance));
				return unicodeDecodingConformance;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebUtility.NativeFieldInfoPtr__htmlDecodeConformance, (void*)(&value));
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x0008B120 File Offset: 0x00089320
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x0000C0CF File Offset: 0x0000A2CF
		public unsafe static UnicodeEncodingConformance _htmlEncodeConformance
		{
			get
			{
				UnicodeEncodingConformance unicodeEncodingConformance;
				IL2CPP.il2cpp_field_static_get_value(WebUtility.NativeFieldInfoPtr__htmlEncodeConformance, (void*)(&unicodeEncodingConformance));
				return unicodeEncodingConformance;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebUtility.NativeFieldInfoPtr__htmlEncodeConformance, (void*)(&value));
			}
		}

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeFieldInfoPtr__htmlEntityEndingChars;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeFieldInfoPtr__htmlDecodeConformance;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeFieldInfoPtr__htmlEncodeConformance;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr_HtmlEncode_Public_Static_String_String_0;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeMethodInfoPtr_HtmlEncode_Public_Static_Void_String_TextWriter_0;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfHtmlEncodingChars_Private_Static_Int32_String_Int32_0;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr_get_HtmlEncodeConformance_Private_Static_get_UnicodeEncodingConformance_0;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr_UrlDecodeInternal_Private_Static_String_String_Encoding_0;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr_UrlDecode_Public_Static_String_String_0;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr_GetNextUnicodeScalarValueFromUtf16Surrogate_Private_Static_Int32_byref_ptr_Char_byref_Int32_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr_HexToInt_Private_Static_Int32_Char_0;

		// Token: 0x02000322 RID: 802
		public class UrlDecoder : Object
		{
			// Token: 0x06002ED2 RID: 11986 RVA: 0x000CCC2C File Offset: 0x000CAE2C
			// Note: this type is marked as 'beforefieldinit'.
			static UrlDecoder()
			{
				Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebUtility>.NativeClassPtr, "UrlDecoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr);
				WebUtility.UrlDecoder.NativeFieldInfoPtr__bufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, "_bufferSize");
				WebUtility.UrlDecoder.NativeFieldInfoPtr__numChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, "_numChars");
				WebUtility.UrlDecoder.NativeFieldInfoPtr__charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, "_charBuffer");
				WebUtility.UrlDecoder.NativeFieldInfoPtr__numBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, "_numBytes");
				WebUtility.UrlDecoder.NativeFieldInfoPtr__byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, "_byteBuffer");
				WebUtility.UrlDecoder.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, "_encoding");
				WebUtility.UrlDecoder.NativeMethodInfoPtr_FlushBytes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, 100667659);
				WebUtility.UrlDecoder.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, 100667660);
				WebUtility.UrlDecoder.NativeMethodInfoPtr_AddChar_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, 100667661);
				WebUtility.UrlDecoder.NativeMethodInfoPtr_AddByte_Internal_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, 100667662);
				WebUtility.UrlDecoder.NativeMethodInfoPtr_GetString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr, 100667663);
			}

			// Token: 0x06002ED3 RID: 11987 RVA: 0x000CCD34 File Offset: 0x000CAF34
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 475898, RefRangeEnd = 475901, XrefRangeStart = 475898, XrefRangeEnd = 475898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void FlushBytes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.UrlDecoder.NativeMethodInfoPtr_FlushBytes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ED4 RID: 11988 RVA: 0x000CCD68 File Offset: 0x000CAF68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475901, XrefRangeEnd = 475907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UrlDecoder(int bufferSize, Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebUtility.UrlDecoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bufferSize;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.UrlDecoder.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ED5 RID: 11989 RVA: 0x000CCDC4 File Offset: 0x000CAFC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 475908, RefRangeEnd = 475909, XrefRangeStart = 475907, XrefRangeEnd = 475908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddChar(char ch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.UrlDecoder.NativeMethodInfoPtr_AddChar_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002ED6 RID: 11990 RVA: 0x000CCE04 File Offset: 0x000CB004
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 475913, RefRangeEnd = 475914, XrefRangeStart = 475909, XrefRangeEnd = 475913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddByte(byte b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.UrlDecoder.NativeMethodInfoPtr_AddByte_Internal_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002ED7 RID: 11991 RVA: 0x000CCE44 File Offset: 0x000CB044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475914, XrefRangeEnd = 475917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebUtility.UrlDecoder.NativeMethodInfoPtr_GetString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06002ED8 RID: 11992 RVA: 0x00014F48 File Offset: 0x00013148
			public UrlDecoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EA5 RID: 3749
			// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x000CCE7C File Offset: 0x000CB07C
			// (set) Token: 0x06002EDA RID: 11994 RVA: 0x00014F51 File Offset: 0x00013151
			public unsafe int _bufferSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__bufferSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__bufferSize)) = value;
				}
			}

			// Token: 0x17000EA6 RID: 3750
			// (get) Token: 0x06002EDB RID: 11995 RVA: 0x000CCEA4 File Offset: 0x000CB0A4
			// (set) Token: 0x06002EDC RID: 11996 RVA: 0x00014F6C File Offset: 0x0001316C
			public unsafe int _numChars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__numChars);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__numChars)) = value;
				}
			}

			// Token: 0x17000EA7 RID: 3751
			// (get) Token: 0x06002EDD RID: 11997 RVA: 0x000CCECC File Offset: 0x000CB0CC
			// (set) Token: 0x06002EDE RID: 11998 RVA: 0x00014F87 File Offset: 0x00013187
			public unsafe Il2CppStructArray<char> _charBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__charBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EA8 RID: 3752
			// (get) Token: 0x06002EDF RID: 11999 RVA: 0x000CCEFC File Offset: 0x000CB0FC
			// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x00014FA6 File Offset: 0x000131A6
			public unsafe int _numBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__numBytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__numBytes)) = value;
				}
			}

			// Token: 0x17000EA9 RID: 3753
			// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x000CCF24 File Offset: 0x000CB124
			// (set) Token: 0x06002EE2 RID: 12002 RVA: 0x00014FC1 File Offset: 0x000131C1
			public unsafe Il2CppStructArray<byte> _byteBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__byteBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EAA RID: 3754
			// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x000CCF54 File Offset: 0x000CB154
			// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x00014FE0 File Offset: 0x000131E0
			public unsafe Encoding _encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebUtility.UrlDecoder.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040024C9 RID: 9417
			private static readonly IntPtr NativeFieldInfoPtr__bufferSize;

			// Token: 0x040024CA RID: 9418
			private static readonly IntPtr NativeFieldInfoPtr__numChars;

			// Token: 0x040024CB RID: 9419
			private static readonly IntPtr NativeFieldInfoPtr__charBuffer;

			// Token: 0x040024CC RID: 9420
			private static readonly IntPtr NativeFieldInfoPtr__numBytes;

			// Token: 0x040024CD RID: 9421
			private static readonly IntPtr NativeFieldInfoPtr__byteBuffer;

			// Token: 0x040024CE RID: 9422
			private static readonly IntPtr NativeFieldInfoPtr__encoding;

			// Token: 0x040024CF RID: 9423
			private static readonly IntPtr NativeMethodInfoPtr_FlushBytes_Private_Void_0;

			// Token: 0x040024D0 RID: 9424
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Encoding_0;

			// Token: 0x040024D1 RID: 9425
			private static readonly IntPtr NativeMethodInfoPtr_AddChar_Internal_Void_Char_0;

			// Token: 0x040024D2 RID: 9426
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Void_Byte_0;

			// Token: 0x040024D3 RID: 9427
			private static readonly IntPtr NativeMethodInfoPtr_GetString_Internal_String_0;
		}
	}
}
