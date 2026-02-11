using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using JsonFx.IO;
using JsonFx.Serialization;

namespace JsonFx.Json
{
	// Token: 0x0200002B RID: 43
	public sealed class JsonTokenizer : Object
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0000B398 File Offset: 0x00009598
		// Note: this type is marked as 'beforefieldinit'.
		static JsonTokenizer()
		{
			Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Json", "JsonTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr);
			JsonTokenizer.NativeFieldInfoPtr_ErrorUnrecognizedToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, "ErrorUnrecognizedToken");
			JsonTokenizer.NativeFieldInfoPtr_ErrorUnterminatedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, "ErrorUnterminatedString");
			JsonTokenizer.NativeFieldInfoPtr_ErrorIllegalNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, "ErrorIllegalNumber");
			JsonTokenizer.NativeFieldInfoPtr_ErrorMissingValueDelim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, "ErrorMissingValueDelim");
			JsonTokenizer.NativeFieldInfoPtr_ErrorExtraValueDelim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, "ErrorExtraValueDelim");
			JsonTokenizer.NativeFieldInfoPtr_Scanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, "Scanner");
			JsonTokenizer.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, "buffer");
			JsonTokenizer.NativeMethodInfoPtr_get_Column_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663604);
			JsonTokenizer.NativeMethodInfoPtr_get_Line_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663605);
			JsonTokenizer.NativeMethodInfoPtr_get_Index_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663606);
			JsonTokenizer.NativeMethodInfoPtr_GetTokens_Private_IEnumerable_1_Token_TextStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663607);
			JsonTokenizer.NativeMethodInfoPtr_SkipWhitespace_Private_Static_Void_TextStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663608);
			JsonTokenizer.NativeMethodInfoPtr_ScanNumber_Private_Static_Boolean_TextStream_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663609);
			JsonTokenizer.NativeMethodInfoPtr_ScanString_Private_Static_String_TextStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663610);
			JsonTokenizer.NativeMethodInfoPtr_ScanKeywords_Private_Static_Boolean_TextStream_String_Char_byref_NeedsValueDelim_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663611);
			JsonTokenizer.NativeMethodInfoPtr_ScanIdentifier_Private_Static_String_TextStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663612);
			JsonTokenizer.NativeMethodInfoPtr_GetTokens_Public_IEnumerable_1_Token_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663613);
			JsonTokenizer.NativeMethodInfoPtr_GetTokens_Public_IEnumerable_1_Token_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663614);
			JsonTokenizer.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663615);
			JsonTokenizer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663616);
			JsonTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, 100663617);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000B56C File Offset: 0x0000976C
		public unsafe int Column
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 320461, RefRangeEnd = 320500, XrefRangeStart = 320461, XrefRangeEnd = 320500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_get_Column_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000B5A8 File Offset: 0x000097A8
		public unsafe int Line
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_get_Line_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000B5E4 File Offset: 0x000097E4
		public unsafe long Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_get_Index_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000B620 File Offset: 0x00009820
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1192787, RefRangeEnd = 1192793, XrefRangeStart = 1192780, XrefRangeEnd = 1192787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Token> GetTokens(TextStream scanner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scanner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_GetTokens_Private_IEnumerable_1_Token_TextStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000B670 File Offset: 0x00009870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192793, XrefRangeEnd = 1192794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SkipWhitespace(TextStream scanner)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scanner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_SkipWhitespace_Private_Static_Void_TextStream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000B6A8 File Offset: 0x000098A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1192820, RefRangeEnd = 1192821, XrefRangeStart = 1192794, XrefRangeEnd = 1192820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScanNumber(TextStream scanner, out Token token)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scanner);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_ScanNumber_Private_Static_Boolean_TextStream_byref_Token_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			token = ((intPtr4 == 0) ? null : new Token(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000B70C File Offset: 0x0000990C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192821, XrefRangeEnd = 1192887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ScanString(TextStream scanner)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scanner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_ScanString_Private_Static_String_TextStream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000B748 File Offset: 0x00009948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1192901, RefRangeEnd = 1192902, XrefRangeStart = 1192887, XrefRangeEnd = 1192901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScanKeywords(TextStream scanner, string ident, char unary, out JsonTokenizer.NeedsValueDelim needsValueDelim, out Token token)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scanner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ident);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unary;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &needsValueDelim;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_ScanKeywords_Private_Static_Boolean_TextStream_String_Char_byref_NeedsValueDelim_byref_Token_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			token = ((intPtr4 == 0) ? null : new Token(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000B7DC File Offset: 0x000099DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1192904, RefRangeEnd = 1192905, XrefRangeStart = 1192902, XrefRangeEnd = 1192904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ScanIdentifier(TextStream scanner)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scanner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_ScanIdentifier_Private_Static_String_TextStream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000B818 File Offset: 0x00009A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192905, XrefRangeEnd = 1192912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Token> GetTokens(TextReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_GetTokens_Public_IEnumerable_1_Token_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000B868 File Offset: 0x00009A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192912, XrefRangeEnd = 1192917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Token> GetTokens(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_GetTokens_Public_IEnumerable_1_Token_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		[CallerCount(0)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000B8EC File Offset: 0x00009AEC
		[CallerCount(0)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000B92C File Offset: 0x00009B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192917, XrefRangeEnd = 1192923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonTokenizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002DB7 File Offset: 0x00000FB7
		public JsonTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000B968 File Offset: 0x00009B68
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public unsafe static string ErrorUnrecognizedToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTokenizer.NativeFieldInfoPtr_ErrorUnrecognizedToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTokenizer.NativeFieldInfoPtr_ErrorUnrecognizedToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000B988 File Offset: 0x00009B88
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00002DD2 File Offset: 0x00000FD2
		public unsafe static string ErrorUnterminatedString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTokenizer.NativeFieldInfoPtr_ErrorUnterminatedString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTokenizer.NativeFieldInfoPtr_ErrorUnterminatedString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public unsafe static string ErrorIllegalNumber
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTokenizer.NativeFieldInfoPtr_ErrorIllegalNumber, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTokenizer.NativeFieldInfoPtr_ErrorIllegalNumber, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002DF6 File Offset: 0x00000FF6
		public unsafe static string ErrorMissingValueDelim
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTokenizer.NativeFieldInfoPtr_ErrorMissingValueDelim, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTokenizer.NativeFieldInfoPtr_ErrorMissingValueDelim, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002E08 File Offset: 0x00001008
		public unsafe static string ErrorExtraValueDelim
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTokenizer.NativeFieldInfoPtr_ErrorExtraValueDelim, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTokenizer.NativeFieldInfoPtr_ErrorExtraValueDelim, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000BA08 File Offset: 0x00009C08
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002E1A File Offset: 0x0000101A
		public unsafe TextStream Scanner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer.NativeFieldInfoPtr_Scanner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer.NativeFieldInfoPtr_Scanner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000BA38 File Offset: 0x00009C38
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002E39 File Offset: 0x00001039
		public unsafe static StringBuilder buffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTokenizer.NativeFieldInfoPtr_buffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTokenizer.NativeFieldInfoPtr_buffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_ErrorUnrecognizedToken;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_ErrorUnterminatedString;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_ErrorIllegalNumber;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_ErrorMissingValueDelim;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_ErrorExtraValueDelim;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_Scanner;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_Column_Public_get_Int32_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_get_Line_Public_get_Int32_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int64_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Private_IEnumerable_1_Token_TextStream_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhitespace_Private_Static_Void_TextStream_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_ScanNumber_Private_Static_Boolean_TextStream_byref_Token_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_ScanString_Private_Static_String_TextStream_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_ScanKeywords_Private_Static_Boolean_TextStream_String_Char_byref_NeedsValueDelim_byref_Token_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_ScanIdentifier_Private_Static_String_TextStream_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Public_IEnumerable_1_Token_TextReader_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Public_IEnumerable_1_Token_String_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200004C RID: 76
		public enum NeedsValueDelim
		{
			// Token: 0x040002B2 RID: 690
			Forbidden,
			// Token: 0x040002B3 RID: 691
			CurrentIsDelim,
			// Token: 0x040002B4 RID: 692
			Required
		}

		// Token: 0x0200004D RID: 77
		[ObfuscatedName("JsonFx.Json.JsonTokenizer+<GetTokens>d__13")]
		public sealed class _GetTokens_d__13 : Object
		{
			// Token: 0x06000416 RID: 1046 RVA: 0x000126FC File Offset: 0x000108FC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetTokens_d__13()
			{
				Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTokenizer>.NativeClassPtr, "<GetTokens>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr);
				JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, "<>1__state");
				JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, "<>2__current");
				JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, "<>l__initialThreadId");
				JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr_scanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, "scanner");
				JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___3__scanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, "<>3__scanner");
				JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, "<>4__this");
				JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr__depth_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, "<depth>5__2");
				JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr__needsValueDelim_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, "<needsValueDelim>5__3");
				JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, 100663618);
				JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, 100663619);
				JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, 100663620);
				JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_JsonFx_Serialization_Token__get_Current_Private_Virtual_Final_New_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, 100663621);
				JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, 100663622);
				JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, 100663623);
				JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, 100663624);
				JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr, 100663625);
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x00012868 File Offset: 0x00010A68
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 937091, RefRangeEnd = 937095, XrefRangeStart = 937091, XrefRangeEnd = 937095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetTokens_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTokenizer._GetTokens_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000418 RID: 1048 RVA: 0x000128B0 File Offset: 0x00010AB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x000128E4 File Offset: 0x00010AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192750, XrefRangeEnd = 1192763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x0600041A RID: 1050 RVA: 0x00012920 File Offset: 0x00010B20
			public unsafe Token System.Collections.Generic.IEnumerator<JsonFx.Serialization.Token>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_JsonFx_Serialization_Token__get_Current_Private_Virtual_Final_New_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Token(intPtr);
				}
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x00012958 File Offset: 0x00010B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192763, XrefRangeEnd = 1192768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001298C File Offset: 0x00010B8C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192768, XrefRangeEnd = 1192771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x000129CC File Offset: 0x00010BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192771, XrefRangeEnd = 1192780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Token> System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Token>>(intPtr3) : null;
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x00012A0C File Offset: 0x00010C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenizer._GetTokens_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x00003A2C File Offset: 0x00001C2C
			public _GetTokens_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000420 RID: 1056 RVA: 0x00012A4C File Offset: 0x00010C4C
			// (set) Token: 0x06000421 RID: 1057 RVA: 0x00003A35 File Offset: 0x00001C35
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000422 RID: 1058 RVA: 0x00012A74 File Offset: 0x00010C74
			// (set) Token: 0x06000423 RID: 1059 RVA: 0x00003A50 File Offset: 0x00001C50
			public Token __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___2__current);
					return new Token(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Token>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Token>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000424 RID: 1060 RVA: 0x00012AA4 File Offset: 0x00010CA4
			// (set) Token: 0x06000425 RID: 1061 RVA: 0x00003A7E File Offset: 0x00001C7E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000426 RID: 1062 RVA: 0x00012ACC File Offset: 0x00010CCC
			// (set) Token: 0x06000427 RID: 1063 RVA: 0x00003A99 File Offset: 0x00001C99
			public unsafe TextStream scanner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr_scanner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr_scanner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000428 RID: 1064 RVA: 0x00012AFC File Offset: 0x00010CFC
			// (set) Token: 0x06000429 RID: 1065 RVA: 0x00003AB8 File Offset: 0x00001CB8
			public unsafe TextStream __3__scanner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___3__scanner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___3__scanner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600042A RID: 1066 RVA: 0x00012B2C File Offset: 0x00010D2C
			// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003AD7 File Offset: 0x00001CD7
			public unsafe JsonTokenizer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTokenizer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x0600042C RID: 1068 RVA: 0x00012B5C File Offset: 0x00010D5C
			// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003AF6 File Offset: 0x00001CF6
			public unsafe int _depth_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr__depth_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr__depth_5__2)) = value;
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x0600042E RID: 1070 RVA: 0x00012B84 File Offset: 0x00010D84
			// (set) Token: 0x0600042F RID: 1071 RVA: 0x00003B11 File Offset: 0x00001D11
			public unsafe JsonTokenizer.NeedsValueDelim _needsValueDelim_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr__needsValueDelim_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTokenizer._GetTokens_d__13.NativeFieldInfoPtr__needsValueDelim_5__3)) = value;
				}
			}

			// Token: 0x040002B5 RID: 693
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002B6 RID: 694
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002B7 RID: 695
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040002B8 RID: 696
			private static readonly IntPtr NativeFieldInfoPtr_scanner;

			// Token: 0x040002B9 RID: 697
			private static readonly IntPtr NativeFieldInfoPtr___3__scanner;

			// Token: 0x040002BA RID: 698
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002BB RID: 699
			private static readonly IntPtr NativeFieldInfoPtr__depth_5__2;

			// Token: 0x040002BC RID: 700
			private static readonly IntPtr NativeFieldInfoPtr__needsValueDelim_5__3;

			// Token: 0x040002BD RID: 701
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002BE RID: 702
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002BF RID: 703
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002C0 RID: 704
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_JsonFx_Serialization_Token__get_Current_Private_Virtual_Final_New_get_Token_0;

			// Token: 0x040002C1 RID: 705
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002C2 RID: 706
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002C3 RID: 707
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_JsonFx_Serialization_Token__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Token_0;

			// Token: 0x040002C4 RID: 708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
