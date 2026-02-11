using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005D RID: 93
	public static class JavaScriptUtils : Object
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x00039414 File Offset: 0x00037614
		// Note: this type is marked as 'beforefieldinit'.
		static JavaScriptUtils()
		{
			Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "JavaScriptUtils");
			JavaScriptUtils.NativeFieldInfoPtr_SingleQuoteCharEscapeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, "SingleQuoteCharEscapeFlags");
			JavaScriptUtils.NativeFieldInfoPtr_DoubleQuoteCharEscapeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, "DoubleQuoteCharEscapeFlags");
			JavaScriptUtils.NativeFieldInfoPtr_HtmlCharEscapeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, "HtmlCharEscapeFlags");
			JavaScriptUtils.NativeFieldInfoPtr_UnicodeTextLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, "UnicodeTextLength");
			JavaScriptUtils.NativeFieldInfoPtr_EscapedUnicodeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, "EscapedUnicodeText");
			JavaScriptUtils.NativeMethodInfoPtr_GetCharEscapeFlags_Public_Static_Il2CppStructArray_1_Boolean_StringEscapeHandling_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664904);
			JavaScriptUtils.NativeMethodInfoPtr_ShouldEscapeJavaScriptString_Public_Static_Boolean_String_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664905);
			JavaScriptUtils.NativeMethodInfoPtr_WriteEscapedJavaScriptString_Public_Static_Void_TextWriter_String_Char_Boolean_Il2CppStructArray_1_Boolean_StringEscapeHandling_IArrayPool_1_Char_byref_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664906);
			JavaScriptUtils.NativeMethodInfoPtr_ToEscapedJavaScriptString_Public_Static_String_String_Char_Boolean_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664907);
			JavaScriptUtils.NativeMethodInfoPtr_FirstCharToEscape_Private_Static_Int32_String_Il2CppStructArray_1_Boolean_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664908);
			JavaScriptUtils.NativeMethodInfoPtr_WriteEscapedJavaScriptStringAsync_Public_Static_Task_TextWriter_String_Char_Boolean_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664909);
			JavaScriptUtils.NativeMethodInfoPtr_WriteEscapedJavaScriptStringWithDelimitersAsync_Private_Static_Task_TextWriter_String_Char_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664910);
			JavaScriptUtils.NativeMethodInfoPtr_WriteEscapedJavaScriptStringWithDelimitersAsync_Private_Static_Task_Task_TextWriter_String_Char_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664911);
			JavaScriptUtils.NativeMethodInfoPtr_WriteCharAsync_Public_Static_Task_Task_TextWriter_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664912);
			JavaScriptUtils.NativeMethodInfoPtr_WriteEscapedJavaScriptStringWithoutDelimitersAsync_Private_Static_Task_TextWriter_String_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664913);
			JavaScriptUtils.NativeMethodInfoPtr_WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_Private_Static_Task_TextWriter_String_Int32_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664914);
			JavaScriptUtils.NativeMethodInfoPtr_TryGetDateFromConstructorJson_Public_Static_Boolean_JsonReader_byref_DateTime_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664915);
			JavaScriptUtils.NativeMethodInfoPtr_TryGetDateConstructorValue_Private_Static_Boolean_JsonReader_byref_Nullable_1_Int64_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, 100664916);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000395A4 File Offset: 0x000377A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 744091, RefRangeEnd = 744092, XrefRangeStart = 744087, XrefRangeEnd = 744091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stringEscapeHandling;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoteChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_GetCharEscapeFlags_Public_Static_Il2CppStructArray_1_Boolean_StringEscapeHandling_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000395F4 File Offset: 0x000377F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 744094, RefRangeEnd = 744095, XrefRangeStart = 744092, XrefRangeEnd = 744094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldEscapeJavaScriptString(string s, Il2CppStructArray<bool> charEscapeFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charEscapeFlags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_ShouldEscapeJavaScriptString_Public_Static_Boolean_String_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00039648 File Offset: 0x00037848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 744190, RefRangeEnd = 744192, XrefRangeStart = 744095, XrefRangeEnd = 744190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, Il2CppStructArray<bool> charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref Il2CppStructArray<char> writeBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delimiter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendDelimiters;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charEscapeFlags);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringEscapeHandling;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bufferPool);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_WriteEscapedJavaScriptString_Public_Static_Void_TextWriter_String_Char_Boolean_Il2CppStructArray_1_Boolean_StringEscapeHandling_IArrayPool_1_Char_byref_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			writeBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0003970C File Offset: 0x0003790C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 744217, RefRangeEnd = 744222, XrefRangeStart = 744192, XrefRangeEnd = 744217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delimiter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendDelimiters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringEscapeHandling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_ToEscapedJavaScriptString_Public_Static_String_String_Char_Boolean_StringEscapeHandling_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00039774 File Offset: 0x00037974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744222, XrefRangeEnd = 744223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FirstCharToEscape(string s, Il2CppStructArray<bool> charEscapeFlags, StringEscapeHandling stringEscapeHandling)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charEscapeFlags);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringEscapeHandling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_FirstCharToEscape_Private_Static_Int32_String_Il2CppStructArray_1_Boolean_StringEscapeHandling_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000397D8 File Offset: 0x000379D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 744255, RefRangeEnd = 744256, XrefRangeStart = 744223, XrefRangeEnd = 744255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteEscapedJavaScriptStringAsync(TextWriter writer, string s, char delimiter, bool appendDelimiters, Il2CppStructArray<bool> charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Il2CppStructArray<char> writeBuffer, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delimiter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendDelimiters;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charEscapeFlags);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringEscapeHandling;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(client);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_WriteEscapedJavaScriptStringAsync_Public_Static_Task_TextWriter_String_Char_Boolean_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000398AC File Offset: 0x00037AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 744287, RefRangeEnd = 744288, XrefRangeStart = 744256, XrefRangeEnd = 744287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteEscapedJavaScriptStringWithDelimitersAsync(TextWriter writer, string s, char delimiter, Il2CppStructArray<bool> charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Il2CppStructArray<char> writeBuffer, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delimiter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charEscapeFlags);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringEscapeHandling;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(client);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_WriteEscapedJavaScriptStringWithDelimitersAsync_Private_Static_Task_TextWriter_String_Char_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00039970 File Offset: 0x00037B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744288, XrefRangeEnd = 744304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteEscapedJavaScriptStringWithDelimitersAsync(Task task, TextWriter writer, string s, char delimiter, Il2CppStructArray<bool> charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Il2CppStructArray<char> writeBuffer, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delimiter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charEscapeFlags);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringEscapeHandling;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(client);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_WriteEscapedJavaScriptStringWithDelimitersAsync_Private_Static_Task_Task_TextWriter_String_Char_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00039A48 File Offset: 0x00037C48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 744316, RefRangeEnd = 744317, XrefRangeStart = 744304, XrefRangeEnd = 744316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteCharAsync(Task task, TextWriter writer, char c, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_WriteCharAsync_Public_Static_Task_Task_TextWriter_Char_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00039AC4 File Offset: 0x00037CC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 744339, RefRangeEnd = 744342, XrefRangeStart = 744317, XrefRangeEnd = 744339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, Il2CppStructArray<bool> charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Il2CppStructArray<char> writeBuffer, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charEscapeFlags);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringEscapeHandling;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(client);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_WriteEscapedJavaScriptStringWithoutDelimitersAsync_Private_Static_Task_TextWriter_String_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00039B78 File Offset: 0x00037D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744342, XrefRangeEnd = 744357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, int lastWritePosition, Il2CppStructArray<bool> charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Il2CppStructArray<char> writeBuffer, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastWritePosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charEscapeFlags);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringEscapeHandling;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(client);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_Private_Static_Task_TextWriter_String_Int32_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00039C3C File Offset: 0x00037E3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 744423, RefRangeEnd = 744426, XrefRangeStart = 744357, XrefRangeEnd = 744423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dateTime;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_TryGetDateFromConstructorJson_Public_Static_Boolean_JsonReader_byref_DateTime_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			errorMessage = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00039CA8 File Offset: 0x00037EA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 744436, RefRangeEnd = 744439, XrefRangeStart = 744426, XrefRangeEnd = 744436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetDateConstructorValue(JsonReader reader, out Nullable<long> integer, out string errorMessage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils.NativeMethodInfoPtr_TryGetDateConstructorValue_Private_Static_Boolean_JsonReader_byref_Nullable_1_Int64_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			integer = ((intPtr5 == 0) ? null : new Nullable<long>(intPtr5));
			errorMessage = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00004B34 File Offset: 0x00002D34
		public JavaScriptUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00039D28 File Offset: 0x00037F28
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00004B3D File Offset: 0x00002D3D
		public unsafe static Il2CppStructArray<bool> SingleQuoteCharEscapeFlags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JavaScriptUtils.NativeFieldInfoPtr_SingleQuoteCharEscapeFlags, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JavaScriptUtils.NativeFieldInfoPtr_SingleQuoteCharEscapeFlags, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00039D50 File Offset: 0x00037F50
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00004B4F File Offset: 0x00002D4F
		public unsafe static Il2CppStructArray<bool> DoubleQuoteCharEscapeFlags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JavaScriptUtils.NativeFieldInfoPtr_DoubleQuoteCharEscapeFlags, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JavaScriptUtils.NativeFieldInfoPtr_DoubleQuoteCharEscapeFlags, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00039D78 File Offset: 0x00037F78
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00004B61 File Offset: 0x00002D61
		public unsafe static Il2CppStructArray<bool> HtmlCharEscapeFlags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JavaScriptUtils.NativeFieldInfoPtr_HtmlCharEscapeFlags, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JavaScriptUtils.NativeFieldInfoPtr_HtmlCharEscapeFlags, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00039DA0 File Offset: 0x00037FA0
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00004B73 File Offset: 0x00002D73
		public unsafe static int UnicodeTextLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(JavaScriptUtils.NativeFieldInfoPtr_UnicodeTextLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JavaScriptUtils.NativeFieldInfoPtr_UnicodeTextLength, (void*)(&value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00039DBC File Offset: 0x00037FBC
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00004B81 File Offset: 0x00002D81
		public unsafe static string EscapedUnicodeText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JavaScriptUtils.NativeFieldInfoPtr_EscapedUnicodeText, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JavaScriptUtils.NativeFieldInfoPtr_EscapedUnicodeText, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_SingleQuoteCharEscapeFlags;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_DoubleQuoteCharEscapeFlags;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_HtmlCharEscapeFlags;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_UnicodeTextLength;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_EscapedUnicodeText;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_GetCharEscapeFlags_Public_Static_Il2CppStructArray_1_Boolean_StringEscapeHandling_Char_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_ShouldEscapeJavaScriptString_Public_Static_Boolean_String_Il2CppStructArray_1_Boolean_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_WriteEscapedJavaScriptString_Public_Static_Void_TextWriter_String_Char_Boolean_Il2CppStructArray_1_Boolean_StringEscapeHandling_IArrayPool_1_Char_byref_Il2CppStructArray_1_Char_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_ToEscapedJavaScriptString_Public_Static_String_String_Char_Boolean_StringEscapeHandling_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_FirstCharToEscape_Private_Static_Int32_String_Il2CppStructArray_1_Boolean_StringEscapeHandling_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_WriteEscapedJavaScriptStringAsync_Public_Static_Task_TextWriter_String_Char_Boolean_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_WriteEscapedJavaScriptStringWithDelimitersAsync_Private_Static_Task_TextWriter_String_Char_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_WriteEscapedJavaScriptStringWithDelimitersAsync_Private_Static_Task_Task_TextWriter_String_Char_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharAsync_Public_Static_Task_Task_TextWriter_Char_CancellationToken_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_WriteEscapedJavaScriptStringWithoutDelimitersAsync_Private_Static_Task_TextWriter_String_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_Private_Static_Task_TextWriter_String_Int32_Il2CppStructArray_1_Boolean_StringEscapeHandling_JsonTextWriter_Il2CppStructArray_1_Char_CancellationToken_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDateFromConstructorJson_Public_Static_Boolean_JsonReader_byref_DateTime_byref_String_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDateConstructorValue_Private_Static_Boolean_JsonReader_byref_Nullable_1_Int64_byref_String_0;

		// Token: 0x0200019C RID: 412
		[ObfuscatedName("Newtonsoft.Json.Utilities.JavaScriptUtils+<WriteCharAsync>d__14")]
		public sealed class _WriteCharAsync_d__14 : ValueType
		{
			// Token: 0x06001D50 RID: 7504 RVA: 0x00089008 File Offset: 0x00087208
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteCharAsync_d__14()
			{
				Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, "<WriteCharAsync>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr);
				JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr, "<>1__state");
				JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr, "<>t__builder");
				JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr, "task");
				JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr, "writer");
				JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr, "c");
				JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr, "cancellationToken");
				JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr, "<>u__1");
				JavaScriptUtils._WriteCharAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr, 100664917);
				JavaScriptUtils._WriteCharAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr, 100664918);
			}

			// Token: 0x06001D51 RID: 7505 RVA: 0x000890E8 File Offset: 0x000872E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743896, XrefRangeEnd = 743913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils._WriteCharAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D52 RID: 7506 RVA: 0x00089120 File Offset: 0x00087320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743913, XrefRangeEnd = 743917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils._WriteCharAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D53 RID: 7507 RVA: 0x0000E6B1 File Offset: 0x0000C8B1
			public _WriteCharAsync_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D54 RID: 7508 RVA: 0x0000E6BA File Offset: 0x0000C8BA
			public _WriteCharAsync_d__14()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JavaScriptUtils._WriteCharAsync_d__14>.NativeClassPtr))
			{
			}

			// Token: 0x17000842 RID: 2114
			// (get) Token: 0x06001D55 RID: 7509 RVA: 0x00089168 File Offset: 0x00087368
			// (set) Token: 0x06001D56 RID: 7510 RVA: 0x0000E6CC File Offset: 0x0000C8CC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000843 RID: 2115
			// (get) Token: 0x06001D57 RID: 7511 RVA: 0x00089190 File Offset: 0x00087390
			// (set) Token: 0x06001D58 RID: 7512 RVA: 0x0000E6E7 File Offset: 0x0000C8E7
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000844 RID: 2116
			// (get) Token: 0x06001D59 RID: 7513 RVA: 0x000891C0 File Offset: 0x000873C0
			// (set) Token: 0x06001D5A RID: 7514 RVA: 0x0000E715 File Offset: 0x0000C915
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000845 RID: 2117
			// (get) Token: 0x06001D5B RID: 7515 RVA: 0x000891F0 File Offset: 0x000873F0
			// (set) Token: 0x06001D5C RID: 7516 RVA: 0x0000E734 File Offset: 0x0000C934
			public unsafe TextWriter writer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_writer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000846 RID: 2118
			// (get) Token: 0x06001D5D RID: 7517 RVA: 0x00089220 File Offset: 0x00087420
			// (set) Token: 0x06001D5E RID: 7518 RVA: 0x0000E753 File Offset: 0x0000C953
			public unsafe char c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x17000847 RID: 2119
			// (get) Token: 0x06001D5F RID: 7519 RVA: 0x00089248 File Offset: 0x00087448
			// (set) Token: 0x06001D60 RID: 7520 RVA: 0x0000E76E File Offset: 0x0000C96E
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000848 RID: 2120
			// (get) Token: 0x06001D61 RID: 7521 RVA: 0x00089278 File Offset: 0x00087478
			// (set) Token: 0x06001D62 RID: 7522 RVA: 0x0000E79C File Offset: 0x0000C99C
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteCharAsync_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400159A RID: 5530
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400159B RID: 5531
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400159C RID: 5532
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x0400159D RID: 5533
			private static readonly IntPtr NativeFieldInfoPtr_writer;

			// Token: 0x0400159E RID: 5534
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x0400159F RID: 5535
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015A0 RID: 5536
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015A1 RID: 5537
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015A2 RID: 5538
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200019D RID: 413
		[ObfuscatedName("Newtonsoft.Json.Utilities.JavaScriptUtils+<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16")]
		public sealed class _WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16 : ValueType
		{
			// Token: 0x06001D63 RID: 7523 RVA: 0x000892A8 File Offset: 0x000874A8
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16()
			{
				Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, "<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr);
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "<>1__state");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "<>t__builder");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_writeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "writeBuffer");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_lastWritePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "lastWritePosition");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "client");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "s");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "writer");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "cancellationToken");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_charEscapeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "charEscapeFlags");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_stringEscapeHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "stringEscapeHandling");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr__isEscapedUnicodeText_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "<isEscapedUnicodeText>5__2");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr__escapedValue_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "<escapedValue>5__3");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "<>u__1");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, "<i>5__4");
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, 100664919);
				JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr, 100664920);
			}

			// Token: 0x06001D64 RID: 7524 RVA: 0x00089414 File Offset: 0x00087614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743917, XrefRangeEnd = 744052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D65 RID: 7525 RVA: 0x0008944C File Offset: 0x0008764C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744052, XrefRangeEnd = 744056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D66 RID: 7526 RVA: 0x0000E7CA File Offset: 0x0000C9CA
			public _WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D67 RID: 7527 RVA: 0x0000E7D3 File Offset: 0x0000C9D3
			public _WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x17000849 RID: 2121
			// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00089494 File Offset: 0x00087694
			// (set) Token: 0x06001D69 RID: 7529 RVA: 0x0000E7E5 File Offset: 0x0000C9E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700084A RID: 2122
			// (get) Token: 0x06001D6A RID: 7530 RVA: 0x000894BC File Offset: 0x000876BC
			// (set) Token: 0x06001D6B RID: 7531 RVA: 0x0000E800 File Offset: 0x0000CA00
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700084B RID: 2123
			// (get) Token: 0x06001D6C RID: 7532 RVA: 0x000894EC File Offset: 0x000876EC
			// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0000E82E File Offset: 0x0000CA2E
			public unsafe Il2CppStructArray<char> writeBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_writeBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_writeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084C RID: 2124
			// (get) Token: 0x06001D6E RID: 7534 RVA: 0x0008951C File Offset: 0x0008771C
			// (set) Token: 0x06001D6F RID: 7535 RVA: 0x0000E84D File Offset: 0x0000CA4D
			public unsafe int lastWritePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_lastWritePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_lastWritePosition)) = value;
				}
			}

			// Token: 0x1700084D RID: 2125
			// (get) Token: 0x06001D70 RID: 7536 RVA: 0x00089544 File Offset: 0x00087744
			// (set) Token: 0x06001D71 RID: 7537 RVA: 0x0000E868 File Offset: 0x0000CA68
			public unsafe JsonTextWriter client
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_client);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_client), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00089574 File Offset: 0x00087774
			// (set) Token: 0x06001D73 RID: 7539 RVA: 0x0000E887 File Offset: 0x0000CA87
			public unsafe string s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_s);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_s), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0008959C File Offset: 0x0008779C
			// (set) Token: 0x06001D75 RID: 7541 RVA: 0x0000E8A6 File Offset: 0x0000CAA6
			public unsafe TextWriter writer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_writer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000850 RID: 2128
			// (get) Token: 0x06001D76 RID: 7542 RVA: 0x000895CC File Offset: 0x000877CC
			// (set) Token: 0x06001D77 RID: 7543 RVA: 0x0000E8C5 File Offset: 0x0000CAC5
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000851 RID: 2129
			// (get) Token: 0x06001D78 RID: 7544 RVA: 0x000895FC File Offset: 0x000877FC
			// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0000E8F3 File Offset: 0x0000CAF3
			public unsafe Il2CppStructArray<bool> charEscapeFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_charEscapeFlags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_charEscapeFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000852 RID: 2130
			// (get) Token: 0x06001D7A RID: 7546 RVA: 0x0008962C File Offset: 0x0008782C
			// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0000E912 File Offset: 0x0000CB12
			public unsafe StringEscapeHandling stringEscapeHandling
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_stringEscapeHandling);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr_stringEscapeHandling)) = value;
				}
			}

			// Token: 0x17000853 RID: 2131
			// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00089654 File Offset: 0x00087854
			// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0000E92D File Offset: 0x0000CB2D
			public unsafe bool _isEscapedUnicodeText_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr__isEscapedUnicodeText_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr__isEscapedUnicodeText_5__2)) = value;
				}
			}

			// Token: 0x17000854 RID: 2132
			// (get) Token: 0x06001D7E RID: 7550 RVA: 0x0008967C File Offset: 0x0008787C
			// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0000E948 File Offset: 0x0000CB48
			public unsafe string _escapedValue_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr__escapedValue_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr__escapedValue_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000855 RID: 2133
			// (get) Token: 0x06001D80 RID: 7552 RVA: 0x000896A4 File Offset: 0x000878A4
			// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0000E967 File Offset: 0x0000CB67
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000856 RID: 2134
			// (get) Token: 0x06001D82 RID: 7554 RVA: 0x000896D4 File Offset: 0x000878D4
			// (set) Token: 0x06001D83 RID: 7555 RVA: 0x0000E995 File Offset: 0x0000CB95
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync_d__16.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040015A3 RID: 5539
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015A4 RID: 5540
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015A5 RID: 5541
			private static readonly IntPtr NativeFieldInfoPtr_writeBuffer;

			// Token: 0x040015A6 RID: 5542
			private static readonly IntPtr NativeFieldInfoPtr_lastWritePosition;

			// Token: 0x040015A7 RID: 5543
			private static readonly IntPtr NativeFieldInfoPtr_client;

			// Token: 0x040015A8 RID: 5544
			private static readonly IntPtr NativeFieldInfoPtr_s;

			// Token: 0x040015A9 RID: 5545
			private static readonly IntPtr NativeFieldInfoPtr_writer;

			// Token: 0x040015AA RID: 5546
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015AB RID: 5547
			private static readonly IntPtr NativeFieldInfoPtr_charEscapeFlags;

			// Token: 0x040015AC RID: 5548
			private static readonly IntPtr NativeFieldInfoPtr_stringEscapeHandling;

			// Token: 0x040015AD RID: 5549
			private static readonly IntPtr NativeFieldInfoPtr__isEscapedUnicodeText_5__2;

			// Token: 0x040015AE RID: 5550
			private static readonly IntPtr NativeFieldInfoPtr__escapedValue_5__3;

			// Token: 0x040015AF RID: 5551
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015B0 RID: 5552
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040015B1 RID: 5553
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015B2 RID: 5554
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200019E RID: 414
		[ObfuscatedName("Newtonsoft.Json.Utilities.JavaScriptUtils+<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13")]
		public sealed class _WriteEscapedJavaScriptStringWithDelimitersAsync_d__13 : ValueType
		{
			// Token: 0x06001D84 RID: 7556 RVA: 0x000896FC File Offset: 0x000878FC
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteEscapedJavaScriptStringWithDelimitersAsync_d__13()
			{
				Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JavaScriptUtils>.NativeClassPtr, "<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr);
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "<>1__state");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "<>t__builder");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "task");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "s");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "writer");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_charEscapeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "charEscapeFlags");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_stringEscapeHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "stringEscapeHandling");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "client");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_writeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "writeBuffer");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "cancellationToken");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_delimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "delimiter");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, "<>u__1");
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, 100664921);
				JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr, 100664922);
			}

			// Token: 0x06001D85 RID: 7557 RVA: 0x00089840 File Offset: 0x00087A40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744056, XrefRangeEnd = 744083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D86 RID: 7558 RVA: 0x00089878 File Offset: 0x00087A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744083, XrefRangeEnd = 744087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D87 RID: 7559 RVA: 0x0000E9B0 File Offset: 0x0000CBB0
			public _WriteEscapedJavaScriptStringWithDelimitersAsync_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001D88 RID: 7560 RVA: 0x0000E9B9 File Offset: 0x0000CBB9
			public _WriteEscapedJavaScriptStringWithDelimitersAsync_d__13()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13>.NativeClassPtr))
			{
			}

			// Token: 0x17000857 RID: 2135
			// (get) Token: 0x06001D89 RID: 7561 RVA: 0x000898C0 File Offset: 0x00087AC0
			// (set) Token: 0x06001D8A RID: 7562 RVA: 0x0000E9CB File Offset: 0x0000CBCB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000858 RID: 2136
			// (get) Token: 0x06001D8B RID: 7563 RVA: 0x000898E8 File Offset: 0x00087AE8
			// (set) Token: 0x06001D8C RID: 7564 RVA: 0x0000E9E6 File Offset: 0x0000CBE6
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000859 RID: 2137
			// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00089918 File Offset: 0x00087B18
			// (set) Token: 0x06001D8E RID: 7566 RVA: 0x0000EA14 File Offset: 0x0000CC14
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085A RID: 2138
			// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00089948 File Offset: 0x00087B48
			// (set) Token: 0x06001D90 RID: 7568 RVA: 0x0000EA33 File Offset: 0x0000CC33
			public unsafe string s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_s);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_s), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700085B RID: 2139
			// (get) Token: 0x06001D91 RID: 7569 RVA: 0x00089970 File Offset: 0x00087B70
			// (set) Token: 0x06001D92 RID: 7570 RVA: 0x0000EA52 File Offset: 0x0000CC52
			public unsafe TextWriter writer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_writer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085C RID: 2140
			// (get) Token: 0x06001D93 RID: 7571 RVA: 0x000899A0 File Offset: 0x00087BA0
			// (set) Token: 0x06001D94 RID: 7572 RVA: 0x0000EA71 File Offset: 0x0000CC71
			public unsafe Il2CppStructArray<bool> charEscapeFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_charEscapeFlags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_charEscapeFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x06001D95 RID: 7573 RVA: 0x000899D0 File Offset: 0x00087BD0
			// (set) Token: 0x06001D96 RID: 7574 RVA: 0x0000EA90 File Offset: 0x0000CC90
			public unsafe StringEscapeHandling stringEscapeHandling
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_stringEscapeHandling);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_stringEscapeHandling)) = value;
				}
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x06001D97 RID: 7575 RVA: 0x000899F8 File Offset: 0x00087BF8
			// (set) Token: 0x06001D98 RID: 7576 RVA: 0x0000EAAB File Offset: 0x0000CCAB
			public unsafe JsonTextWriter client
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_client);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_client), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x06001D99 RID: 7577 RVA: 0x00089A28 File Offset: 0x00087C28
			// (set) Token: 0x06001D9A RID: 7578 RVA: 0x0000EACA File Offset: 0x0000CCCA
			public unsafe Il2CppStructArray<char> writeBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_writeBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_writeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00089A58 File Offset: 0x00087C58
			// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0000EAE9 File Offset: 0x0000CCE9
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x06001D9D RID: 7581 RVA: 0x00089A88 File Offset: 0x00087C88
			// (set) Token: 0x06001D9E RID: 7582 RVA: 0x0000EB17 File Offset: 0x0000CD17
			public unsafe char delimiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_delimiter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr_delimiter)) = value;
				}
			}

			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x06001D9F RID: 7583 RVA: 0x00089AB0 File Offset: 0x00087CB0
			// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0000EB32 File Offset: 0x0000CD32
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaScriptUtils._WriteEscapedJavaScriptStringWithDelimitersAsync_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015B3 RID: 5555
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015B4 RID: 5556
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040015B5 RID: 5557
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x040015B6 RID: 5558
			private static readonly IntPtr NativeFieldInfoPtr_s;

			// Token: 0x040015B7 RID: 5559
			private static readonly IntPtr NativeFieldInfoPtr_writer;

			// Token: 0x040015B8 RID: 5560
			private static readonly IntPtr NativeFieldInfoPtr_charEscapeFlags;

			// Token: 0x040015B9 RID: 5561
			private static readonly IntPtr NativeFieldInfoPtr_stringEscapeHandling;

			// Token: 0x040015BA RID: 5562
			private static readonly IntPtr NativeFieldInfoPtr_client;

			// Token: 0x040015BB RID: 5563
			private static readonly IntPtr NativeFieldInfoPtr_writeBuffer;

			// Token: 0x040015BC RID: 5564
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040015BD RID: 5565
			private static readonly IntPtr NativeFieldInfoPtr_delimiter;

			// Token: 0x040015BE RID: 5566
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040015BF RID: 5567
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015C0 RID: 5568
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
