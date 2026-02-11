using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x020001AE RID: 430
	public sealed class HttpListenerRequestUriBuilder : Object
	{
		// Token: 0x06001AB7 RID: 6839 RVA: 0x00085038 File Offset: 0x00083238
		// Note: this type is marked as 'beforefieldinit'.
		static HttpListenerRequestUriBuilder()
		{
			Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpListenerRequestUriBuilder");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_useCookedRequestUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "useCookedRequestUrl");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_utf8Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "utf8Encoding");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_ansiEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "ansiEncoding");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_rawUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "rawUri");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "cookedUriScheme");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "cookedUriHost");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "cookedUriPath");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "cookedUriQuery");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_requestUriString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "requestUriString");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_rawOctets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "rawOctets");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_rawPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "rawPath");
			HttpListenerRequestUriBuilder.NativeFieldInfoPtr_requestUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, "requestUri");
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667456);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_GetRequestUri_Public_Static_Uri_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667457);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_Build_Private_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667458);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_BuildRequestUriUsingCookedPath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667459);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_BuildRequestUriUsingRawPath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667460);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_GetEncoding_Private_Static_Encoding_EncodingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667461);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_BuildRequestUriUsingRawPath_Private_ParsingResult_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667462);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_ParseRawPath_Private_ParsingResult_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667463);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_AppendUnicodeCodePointValuePercentEncoded_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667464);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_AddPercentEncodedOctetToRawOctetsList_Private_Boolean_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667465);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_EmptyDecodeAndAppendRawOctetsList_Private_Boolean_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667466);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_AppendOctetsPercentEncoded_Private_Static_Void_StringBuilder_IEnumerable_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667467);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_GetOctetsAsString_Private_Static_String_IEnumerable_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667468);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_GetPath_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667469);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_AddSlashToAsteriskOnlyPath_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667470);
			HttpListenerRequestUriBuilder.NativeMethodInfoPtr_LogWarning_Private_Void_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr, 100667471);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x00085290 File Offset: 0x00083490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474065, XrefRangeEnd = 474080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerRequestUriBuilder(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpListenerRequestUriBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rawUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cookedUriScheme);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cookedUriHost);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cookedUriPath);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cookedUriQuery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00085328 File Offset: 0x00083528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474080, XrefRangeEnd = 474113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri GetRequestUri(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rawUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cookedUriScheme);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cookedUriHost);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cookedUriPath);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cookedUriQuery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_GetRequestUri_Public_Static_Uri_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000853B8 File Offset: 0x000835B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474113, XrefRangeEnd = 474123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_Build_Private_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000853F8 File Offset: 0x000835F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 474151, RefRangeEnd = 474154, XrefRangeStart = 474123, XrefRangeEnd = 474151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildRequestUriUsingCookedPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_BuildRequestUriUsingCookedPath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0008542C File Offset: 0x0008362C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 474209, RefRangeEnd = 474212, XrefRangeStart = 474154, XrefRangeEnd = 474209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildRequestUriUsingRawPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_BuildRequestUriUsingRawPath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00085460 File Offset: 0x00083660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474212, XrefRangeEnd = 474216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncoding(HttpListenerRequestUriBuilder.EncodingType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_GetEncoding_Private_Static_Encoding_EncodingType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x000854A0 File Offset: 0x000836A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474250, RefRangeEnd = 474252, XrefRangeStart = 474216, XrefRangeEnd = 474250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerRequestUriBuilder.ParsingResult BuildRequestUriUsingRawPath(Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_BuildRequestUriUsingRawPath_Private_ParsingResult_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x000854F0 File Offset: 0x000836F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474264, RefRangeEnd = 474265, XrefRangeStart = 474252, XrefRangeEnd = 474264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerRequestUriBuilder.ParsingResult ParseRawPath(Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_ParseRawPath_Private_ParsingResult_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00085540 File Offset: 0x00083740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474278, RefRangeEnd = 474279, XrefRangeStart = 474265, XrefRangeEnd = 474278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AppendUnicodeCodePointValuePercentEncoded(string codePoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(codePoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_AppendUnicodeCodePointValuePercentEncoded_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00085590 File Offset: 0x00083790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474286, RefRangeEnd = 474287, XrefRangeStart = 474279, XrefRangeEnd = 474286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddPercentEncodedOctetToRawOctetsList(Encoding encoding, string escapedCharacter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(escapedCharacter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_AddPercentEncodedOctetToRawOctetsList_Private_Boolean_Encoding_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000855F0 File Offset: 0x000837F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474324, RefRangeEnd = 474326, XrefRangeStart = 474287, XrefRangeEnd = 474324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EmptyDecodeAndAppendRawOctetsList(Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_EmptyDecodeAndAppendRawOctetsList_Private_Boolean_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00085640 File Offset: 0x00083840
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 474352, RefRangeEnd = 474355, XrefRangeStart = 474326, XrefRangeEnd = 474352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendOctetsPercentEncoded(StringBuilder target, IEnumerable<byte> octets)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(octets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_AppendOctetsPercentEncoded_Private_Static_Void_StringBuilder_IEnumerable_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00085688 File Offset: 0x00083888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474388, RefRangeEnd = 474389, XrefRangeStart = 474355, XrefRangeEnd = 474388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetOctetsAsString(IEnumerable<byte> octets)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(octets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_GetOctetsAsString_Private_Static_String_IEnumerable_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x000856C4 File Offset: 0x000838C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474410, RefRangeEnd = 474411, XrefRangeStart = 474389, XrefRangeEnd = 474410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPath(string uriString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_GetPath_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00085700 File Offset: 0x00083900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474411, XrefRangeEnd = 474414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string AddSlashToAsteriskOnlyPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_AddSlashToAsteriskOnlyPath_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0008573C File Offset: 0x0008393C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474414, XrefRangeEnd = 474415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogWarning(string methodName, string message, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerRequestUriBuilder.NativeMethodInfoPtr_LogWarning_Private_Void_String_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0000B6CE File Offset: 0x000098CE
		public void LogWarning(string methodName, string message, params Object[] args)
		{
			this.LogWarning(methodName, message, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0000B6DE File Offset: 0x000098DE
		public HttpListenerRequestUriBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x000857B0 File Offset: 0x000839B0
		// (set) Token: 0x06001ACB RID: 6859 RVA: 0x0000B6E7 File Offset: 0x000098E7
		public unsafe static bool useCookedRequestUrl
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_useCookedRequestUrl, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_useCookedRequestUrl, (void*)(&value));
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x000857CC File Offset: 0x000839CC
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x0000B6F5 File Offset: 0x000098F5
		public unsafe static Encoding utf8Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_utf8Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_utf8Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x000857F4 File Offset: 0x000839F4
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x0000B707 File Offset: 0x00009907
		public unsafe static Encoding ansiEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_ansiEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_ansiEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0008581C File Offset: 0x00083A1C
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x0000B719 File Offset: 0x00009919
		public unsafe string rawUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_rawUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_rawUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x00085844 File Offset: 0x00083A44
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x0000B738 File Offset: 0x00009938
		public unsafe string cookedUriScheme
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriScheme);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriScheme), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0008586C File Offset: 0x00083A6C
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x0000B757 File Offset: 0x00009957
		public unsafe string cookedUriHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriHost);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriHost), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x00085894 File Offset: 0x00083A94
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x0000B776 File Offset: 0x00009976
		public unsafe string cookedUriPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x000858BC File Offset: 0x00083ABC
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0000B795 File Offset: 0x00009995
		public unsafe string cookedUriQuery
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriQuery);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_cookedUriQuery), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x000858E4 File Offset: 0x00083AE4
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0000B7B4 File Offset: 0x000099B4
		public unsafe StringBuilder requestUriString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_requestUriString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_requestUriString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x00085914 File Offset: 0x00083B14
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0000B7D3 File Offset: 0x000099D3
		public unsafe List<byte> rawOctets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_rawOctets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_rawOctets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x00085944 File Offset: 0x00083B44
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0000B7F2 File Offset: 0x000099F2
		public unsafe string rawPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_rawPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_rawPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x0008596C File Offset: 0x00083B6C
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0000B811 File Offset: 0x00009A11
		public unsafe Uri requestUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_requestUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerRequestUriBuilder.NativeFieldInfoPtr_requestUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeFieldInfoPtr_useCookedRequestUrl;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeFieldInfoPtr_utf8Encoding;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeFieldInfoPtr_ansiEncoding;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeFieldInfoPtr_rawUri;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeFieldInfoPtr_cookedUriScheme;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeFieldInfoPtr_cookedUriHost;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeFieldInfoPtr_cookedUriPath;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeFieldInfoPtr_cookedUriQuery;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeFieldInfoPtr_requestUriString;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeFieldInfoPtr_rawOctets;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeFieldInfoPtr_rawPath;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeFieldInfoPtr_requestUri;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_String_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestUri_Public_Static_Uri_String_String_String_String_String_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_Build_Private_Uri_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_BuildRequestUriUsingCookedPath_Private_Void_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_BuildRequestUriUsingRawPath_Private_Void_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Private_Static_Encoding_EncodingType_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_BuildRequestUriUsingRawPath_Private_ParsingResult_Encoding_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_ParseRawPath_Private_ParsingResult_Encoding_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_AppendUnicodeCodePointValuePercentEncoded_Private_Boolean_String_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_AddPercentEncodedOctetToRawOctetsList_Private_Boolean_Encoding_String_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_EmptyDecodeAndAppendRawOctetsList_Private_Boolean_Encoding_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_AppendOctetsPercentEncoded_Private_Static_Void_StringBuilder_IEnumerable_1_Byte_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr_GetOctetsAsString_Private_Static_String_IEnumerable_1_Byte_0;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Private_Static_String_String_0;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr_AddSlashToAsteriskOnlyPath_Private_Static_String_String_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Private_Void_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0200031C RID: 796
		public enum ParsingResult
		{
			// Token: 0x040024B0 RID: 9392
			Success,
			// Token: 0x040024B1 RID: 9393
			InvalidString,
			// Token: 0x040024B2 RID: 9394
			EncodingError
		}

		// Token: 0x0200031D RID: 797
		public enum EncodingType
		{
			// Token: 0x040024B4 RID: 9396
			Primary,
			// Token: 0x040024B5 RID: 9397
			Secondary
		}
	}
}
