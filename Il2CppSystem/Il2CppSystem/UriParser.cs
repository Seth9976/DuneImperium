using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem
{
	// Token: 0x02000067 RID: 103
	public class UriParser : Object
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00034628 File Offset: 0x00032828
		// Note: this type is marked as 'beforefieldinit'.
		static UriParser()
		{
			Il2CppClassPointerStore<UriParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriParser");
			UriParser.NativeFieldInfoPtr_SchemeOnlyFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "SchemeOnlyFlags");
			UriParser.NativeFieldInfoPtr_m_Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Table");
			UriParser.NativeFieldInfoPtr_m_TempTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_TempTable");
			UriParser.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Flags");
			UriParser.NativeFieldInfoPtr_m_UpdatableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_UpdatableFlags");
			UriParser.NativeFieldInfoPtr_m_UpdatableFlagsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_UpdatableFlagsUsed");
			UriParser.NativeFieldInfoPtr_c_UpdatableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "c_UpdatableFlags");
			UriParser.NativeFieldInfoPtr_m_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Port");
			UriParser.NativeFieldInfoPtr_m_Scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Scheme");
			UriParser.NativeFieldInfoPtr_NoDefaultPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NoDefaultPort");
			UriParser.NativeFieldInfoPtr_c_InitialTableSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "c_InitialTableSize");
			UriParser.NativeFieldInfoPtr_HttpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "HttpUri");
			UriParser.NativeFieldInfoPtr_HttpsUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "HttpsUri");
			UriParser.NativeFieldInfoPtr_WsUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "WsUri");
			UriParser.NativeFieldInfoPtr_WssUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "WssUri");
			UriParser.NativeFieldInfoPtr_FtpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "FtpUri");
			UriParser.NativeFieldInfoPtr_FileUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "FileUri");
			UriParser.NativeFieldInfoPtr_GopherUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "GopherUri");
			UriParser.NativeFieldInfoPtr_NntpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NntpUri");
			UriParser.NativeFieldInfoPtr_NewsUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NewsUri");
			UriParser.NativeFieldInfoPtr_MailToUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "MailToUri");
			UriParser.NativeFieldInfoPtr_UuidUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "UuidUri");
			UriParser.NativeFieldInfoPtr_TelnetUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "TelnetUri");
			UriParser.NativeFieldInfoPtr_LdapUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "LdapUri");
			UriParser.NativeFieldInfoPtr_NetTcpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NetTcpUri");
			UriParser.NativeFieldInfoPtr_NetPipeUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NetPipeUri");
			UriParser.NativeFieldInfoPtr_VsMacrosUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "VsMacrosUri");
			UriParser.NativeFieldInfoPtr_s_QuirksVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "s_QuirksVersion");
			UriParser.NativeFieldInfoPtr_c_MaxCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "c_MaxCapacity");
			UriParser.NativeFieldInfoPtr_UnknownV1SyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "UnknownV1SyntaxFlags");
			UriParser.NativeFieldInfoPtr_HttpSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "HttpSyntaxFlags");
			UriParser.NativeFieldInfoPtr_FtpSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "FtpSyntaxFlags");
			UriParser.NativeFieldInfoPtr_FileSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "FileSyntaxFlags");
			UriParser.NativeFieldInfoPtr_VsmacrosSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "VsmacrosSyntaxFlags");
			UriParser.NativeFieldInfoPtr_GopherSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "GopherSyntaxFlags");
			UriParser.NativeFieldInfoPtr_NewsSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NewsSyntaxFlags");
			UriParser.NativeFieldInfoPtr_NntpSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NntpSyntaxFlags");
			UriParser.NativeFieldInfoPtr_TelnetSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "TelnetSyntaxFlags");
			UriParser.NativeFieldInfoPtr_LdapSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "LdapSyntaxFlags");
			UriParser.NativeFieldInfoPtr_MailtoSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "MailtoSyntaxFlags");
			UriParser.NativeFieldInfoPtr_NetPipeSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NetPipeSyntaxFlags");
			UriParser.NativeFieldInfoPtr_NetTcpSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NetTcpSyntaxFlags");
			UriParser.NativeMethodInfoPtr_get_SchemeName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664358);
			UriParser.NativeMethodInfoPtr_get_DefaultPort_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664359);
			UriParser.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664360);
			UriParser.NativeMethodInfoPtr_OnNewUri_Protected_Virtual_New_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664361);
			UriParser.NativeMethodInfoPtr_InitializeAndValidate_Protected_Virtual_New_Void_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664362);
			UriParser.NativeMethodInfoPtr_Resolve_Protected_Virtual_New_String_Uri_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664363);
			UriParser.NativeMethodInfoPtr_IsBaseOf_Protected_Virtual_New_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664364);
			UriParser.NativeMethodInfoPtr_GetComponents_Protected_Virtual_New_String_Uri_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664365);
			UriParser.NativeMethodInfoPtr_IsWellFormedOriginalString_Protected_Virtual_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664366);
			UriParser.NativeMethodInfoPtr_get_ShouldUseLegacyV2Quirks_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664367);
			UriParser.NativeMethodInfoPtr_get_Flags_Internal_get_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664369);
			UriParser.NativeMethodInfoPtr_NotAny_Internal_Boolean_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664370);
			UriParser.NativeMethodInfoPtr_InFact_Internal_Boolean_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664371);
			UriParser.NativeMethodInfoPtr_IsAllSet_Internal_Boolean_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664372);
			UriParser.NativeMethodInfoPtr_IsFullMatch_Private_Boolean_UriSyntaxFlags_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664373);
			UriParser.NativeMethodInfoPtr__ctor_Internal_Void_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664374);
			UriParser.NativeMethodInfoPtr_FindOrFetchAsUnknownV1Syntax_Internal_Static_UriParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664375);
			UriParser.NativeMethodInfoPtr_GetSyntax_Internal_Static_UriParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664376);
			UriParser.NativeMethodInfoPtr_get_IsSimple_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664377);
			UriParser.NativeMethodInfoPtr_InternalOnNewUri_Internal_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664378);
			UriParser.NativeMethodInfoPtr_InternalValidate_Internal_Void_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664379);
			UriParser.NativeMethodInfoPtr_InternalResolve_Internal_String_Uri_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664380);
			UriParser.NativeMethodInfoPtr_InternalIsBaseOf_Internal_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664381);
			UriParser.NativeMethodInfoPtr_InternalGetComponents_Internal_String_Uri_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664382);
			UriParser.NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664383);
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00034B8C File Offset: 0x00032D8C
		public unsafe string SchemeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_get_SchemeName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00034BC4 File Offset: 0x00032DC4
		public unsafe int DefaultPort
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_get_DefaultPort_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00034C00 File Offset: 0x00032E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436346, XrefRangeEnd = 436350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00034C3C File Offset: 0x00032E3C
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual UriParser OnNewUri()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriParser.NativeMethodInfoPtr_OnNewUri_Protected_Virtual_New_UriParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00034C88 File Offset: 0x00032E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436350, XrefRangeEnd = 436353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriParser.NativeMethodInfoPtr_InitializeAndValidate_Protected_Virtual_New_Void_Uri_byref_UriFormatException_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsingError = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00034CF8 File Offset: 0x00032EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436353, XrefRangeEnd = 436362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeUri);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriParser.NativeMethodInfoPtr_Resolve_Protected_Virtual_New_String_Uri_Uri_byref_UriFormatException_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsingError = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00034D80 File Offset: 0x00032F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436362, XrefRangeEnd = 436364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsBaseOf(Uri baseUri, Uri relativeUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriParser.NativeMethodInfoPtr_IsBaseOf_Protected_Virtual_New_Boolean_Uri_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00034DEC File Offset: 0x00032FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436364, XrefRangeEnd = 436406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetComponents(Uri uri, UriComponents components, UriFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref components;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriParser.NativeMethodInfoPtr_GetComponents_Protected_Virtual_New_String_Uri_UriComponents_UriFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00034E5C File Offset: 0x0003305C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436406, XrefRangeEnd = 436408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsWellFormedOriginalString(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriParser.NativeMethodInfoPtr_IsWellFormedOriginalString_Protected_Virtual_New_Boolean_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00034EB4 File Offset: 0x000330B4
		public unsafe static bool ShouldUseLegacyV2Quirks
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 436412, RefRangeEnd = 436418, XrefRangeStart = 436408, XrefRangeEnd = 436412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_get_ShouldUseLegacyV2Quirks_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00034EE4 File Offset: 0x000330E4
		public unsafe UriSyntaxFlags Flags
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_get_Flags_Internal_get_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00034F20 File Offset: 0x00033120
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 436421, RefRangeEnd = 436424, XrefRangeStart = 436418, XrefRangeEnd = 436421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NotAny(UriSyntaxFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_NotAny_Internal_Boolean_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00034F6C File Offset: 0x0003316C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 436427, RefRangeEnd = 436462, XrefRangeStart = 436424, XrefRangeEnd = 436427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InFact(UriSyntaxFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InFact_Internal_Boolean_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00034FB8 File Offset: 0x000331B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436465, RefRangeEnd = 436466, XrefRangeStart = 436462, XrefRangeEnd = 436465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAllSet(UriSyntaxFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_IsAllSet_Internal_Boolean_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00035004 File Offset: 0x00033204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436466, XrefRangeEnd = 436469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_IsFullMatch_Private_Boolean_UriSyntaxFlags_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0003505C File Offset: 0x0003325C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436473, RefRangeEnd = 436474, XrefRangeStart = 436469, XrefRangeEnd = 436473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriParser(UriSyntaxFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr__ctor_Internal_Void_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000350A4 File Offset: 0x000332A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436520, RefRangeEnd = 436521, XrefRangeStart = 436474, XrefRangeEnd = 436520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lwrCaseScheme);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_FindOrFetchAsUnknownV1Syntax_Internal_Static_UriParser_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000350E8 File Offset: 0x000332E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436521, XrefRangeEnd = 436533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UriParser GetSyntax(string lwrCaseScheme)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lwrCaseScheme);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_GetSyntax_Internal_Static_UriParser_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0003512C File Offset: 0x0003332C
		public unsafe bool IsSimple
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 436533, RefRangeEnd = 436548, XrefRangeStart = 436533, XrefRangeEnd = 436533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_get_IsSimple_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00035168 File Offset: 0x00033368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436548, XrefRangeEnd = 436549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriParser InternalOnNewUri()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InternalOnNewUri_Internal_UriParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000351A8 File Offset: 0x000333A8
		[CallerCount(0)]
		public unsafe void InternalValidate(Uri thisUri, out UriFormatException parsingError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisUri);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InternalValidate_Internal_Void_Uri_byref_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsingError = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0003520C File Offset: 0x0003340C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 436549, RefRangeEnd = 436553, XrefRangeStart = 436549, XrefRangeEnd = 436549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisBaseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uriLink);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InternalResolve_Internal_String_Uri_Uri_byref_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsingError = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0003528C File Offset: 0x0003348C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436553, RefRangeEnd = 436554, XrefRangeStart = 436553, XrefRangeEnd = 436553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisBaseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uriLink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InternalIsBaseOf_Internal_Boolean_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000352EC File Offset: 0x000334EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 436554, RefRangeEnd = 436557, XrefRangeStart = 436554, XrefRangeEnd = 436554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriComponents;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InternalGetComponents_Internal_String_Uri_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00035350 File Offset: 0x00033550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 436557, RefRangeEnd = 436559, XrefRangeStart = 436557, XrefRangeEnd = 436557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalIsWellFormedOriginalString(Uri thisUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00003EDB File Offset: 0x000020DB
		public UriParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x000353A0 File Offset: 0x000335A0
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00003EE4 File Offset: 0x000020E4
		public unsafe static UriSyntaxFlags SchemeOnlyFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_SchemeOnlyFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_SchemeOnlyFlags, (void*)(&value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x000353BC File Offset: 0x000335BC
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00003EF2 File Offset: 0x000020F2
		public unsafe static Dictionary<string, UriParser> m_Table
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_m_Table, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, UriParser>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_m_Table, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x000353E4 File Offset: 0x000335E4
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00003F04 File Offset: 0x00002104
		public unsafe static Dictionary<string, UriParser> m_TempTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_m_TempTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, UriParser>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_m_TempTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x0003540C File Offset: 0x0003360C
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00003F16 File Offset: 0x00002116
		public unsafe UriSyntaxFlags m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00035434 File Offset: 0x00033634
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00003F31 File Offset: 0x00002131
		public unsafe UriSyntaxFlags m_UpdatableFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_UpdatableFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_UpdatableFlags)) = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0003545C File Offset: 0x0003365C
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00003F4C File Offset: 0x0000214C
		public unsafe bool m_UpdatableFlagsUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_UpdatableFlagsUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_UpdatableFlagsUsed)) = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00035484 File Offset: 0x00033684
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00003F67 File Offset: 0x00002167
		public unsafe static UriSyntaxFlags c_UpdatableFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_c_UpdatableFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_c_UpdatableFlags, (void*)(&value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000354A0 File Offset: 0x000336A0
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00003F75 File Offset: 0x00002175
		public unsafe int m_Port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Port)) = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x000354C8 File Offset: 0x000336C8
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00003F90 File Offset: 0x00002190
		public unsafe string m_Scheme
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Scheme);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Scheme), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000354F0 File Offset: 0x000336F0
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00003FAF File Offset: 0x000021AF
		public unsafe static int NoDefaultPort
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NoDefaultPort, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NoDefaultPort, (void*)(&value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0003550C File Offset: 0x0003370C
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00003FBD File Offset: 0x000021BD
		public unsafe static int c_InitialTableSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_c_InitialTableSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_c_InitialTableSize, (void*)(&value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00035528 File Offset: 0x00033728
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00003FCB File Offset: 0x000021CB
		public unsafe static UriParser HttpUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_HttpUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_HttpUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00035550 File Offset: 0x00033750
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00003FDD File Offset: 0x000021DD
		public unsafe static UriParser HttpsUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_HttpsUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_HttpsUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00035578 File Offset: 0x00033778
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x00003FEF File Offset: 0x000021EF
		public unsafe static UriParser WsUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_WsUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_WsUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x000355A0 File Offset: 0x000337A0
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00004001 File Offset: 0x00002201
		public unsafe static UriParser WssUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_WssUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_WssUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000355C8 File Offset: 0x000337C8
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00004013 File Offset: 0x00002213
		public unsafe static UriParser FtpUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_FtpUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_FtpUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x000355F0 File Offset: 0x000337F0
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00004025 File Offset: 0x00002225
		public unsafe static UriParser FileUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_FileUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_FileUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00035618 File Offset: 0x00033818
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x00004037 File Offset: 0x00002237
		public unsafe static UriParser GopherUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_GopherUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_GopherUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00035640 File Offset: 0x00033840
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x00004049 File Offset: 0x00002249
		public unsafe static UriParser NntpUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NntpUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NntpUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00035668 File Offset: 0x00033868
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x0000405B File Offset: 0x0000225B
		public unsafe static UriParser NewsUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NewsUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NewsUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00035690 File Offset: 0x00033890
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x0000406D File Offset: 0x0000226D
		public unsafe static UriParser MailToUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_MailToUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_MailToUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x000356B8 File Offset: 0x000338B8
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0000407F File Offset: 0x0000227F
		public unsafe static UriParser UuidUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_UuidUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_UuidUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x000356E0 File Offset: 0x000338E0
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00004091 File Offset: 0x00002291
		public unsafe static UriParser TelnetUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_TelnetUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_TelnetUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00035708 File Offset: 0x00033908
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x000040A3 File Offset: 0x000022A3
		public unsafe static UriParser LdapUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_LdapUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_LdapUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00035730 File Offset: 0x00033930
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x000040B5 File Offset: 0x000022B5
		public unsafe static UriParser NetTcpUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NetTcpUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NetTcpUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00035758 File Offset: 0x00033958
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x000040C7 File Offset: 0x000022C7
		public unsafe static UriParser NetPipeUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NetPipeUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NetPipeUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00035780 File Offset: 0x00033980
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x000040D9 File Offset: 0x000022D9
		public unsafe static UriParser VsMacrosUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_VsMacrosUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_VsMacrosUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x000357A8 File Offset: 0x000339A8
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x000040EB File Offset: 0x000022EB
		public unsafe static UriParser.UriQuirksVersion s_QuirksVersion
		{
			get
			{
				UriParser.UriQuirksVersion uriQuirksVersion;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_s_QuirksVersion, (void*)(&uriQuirksVersion));
				return uriQuirksVersion;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_s_QuirksVersion, (void*)(&value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x000357C4 File Offset: 0x000339C4
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x000040F9 File Offset: 0x000022F9
		public unsafe static int c_MaxCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_c_MaxCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_c_MaxCapacity, (void*)(&value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x000357E0 File Offset: 0x000339E0
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00004107 File Offset: 0x00002307
		public unsafe static UriSyntaxFlags UnknownV1SyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_UnknownV1SyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_UnknownV1SyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x000357FC File Offset: 0x000339FC
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00004115 File Offset: 0x00002315
		public unsafe static UriSyntaxFlags HttpSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_HttpSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_HttpSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00035818 File Offset: 0x00033A18
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00004123 File Offset: 0x00002323
		public unsafe static UriSyntaxFlags FtpSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_FtpSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_FtpSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00035834 File Offset: 0x00033A34
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00004131 File Offset: 0x00002331
		public unsafe static UriSyntaxFlags FileSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_FileSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_FileSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00035850 File Offset: 0x00033A50
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x0000413F File Offset: 0x0000233F
		public unsafe static UriSyntaxFlags VsmacrosSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_VsmacrosSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_VsmacrosSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0003586C File Offset: 0x00033A6C
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x0000414D File Offset: 0x0000234D
		public unsafe static UriSyntaxFlags GopherSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_GopherSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_GopherSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00035888 File Offset: 0x00033A88
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x0000415B File Offset: 0x0000235B
		public unsafe static UriSyntaxFlags NewsSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NewsSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NewsSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000358A4 File Offset: 0x00033AA4
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00004169 File Offset: 0x00002369
		public unsafe static UriSyntaxFlags NntpSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NntpSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NntpSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x000358C0 File Offset: 0x00033AC0
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00004177 File Offset: 0x00002377
		public unsafe static UriSyntaxFlags TelnetSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_TelnetSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_TelnetSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x000358DC File Offset: 0x00033ADC
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00004185 File Offset: 0x00002385
		public unsafe static UriSyntaxFlags LdapSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_LdapSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_LdapSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x000358F8 File Offset: 0x00033AF8
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00004193 File Offset: 0x00002393
		public unsafe static UriSyntaxFlags MailtoSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_MailtoSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_MailtoSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00035914 File Offset: 0x00033B14
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x000041A1 File Offset: 0x000023A1
		public unsafe static UriSyntaxFlags NetPipeSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NetPipeSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NetPipeSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00035930 File Offset: 0x00033B30
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x000041AF File Offset: 0x000023AF
		public unsafe static UriSyntaxFlags NetTcpSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NetTcpSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NetTcpSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_SchemeOnlyFlags;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_m_Table;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_m_TempTable;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdatableFlags;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdatableFlagsUsed;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_c_UpdatableFlags;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_m_Port;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheme;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_NoDefaultPort;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_c_InitialTableSize;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_HttpUri;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_HttpsUri;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_WsUri;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_WssUri;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_FtpUri;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_FileUri;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_GopherUri;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_NntpUri;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_NewsUri;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_MailToUri;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_UuidUri;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_TelnetUri;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr_LdapUri;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_NetTcpUri;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_NetPipeUri;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_VsMacrosUri;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_s_QuirksVersion;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr_c_MaxCapacity;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_UnknownV1SyntaxFlags;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_HttpSyntaxFlags;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_FtpSyntaxFlags;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr_FileSyntaxFlags;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_VsmacrosSyntaxFlags;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_GopherSyntaxFlags;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_NewsSyntaxFlags;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_NntpSyntaxFlags;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_TelnetSyntaxFlags;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr_LdapSyntaxFlags;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_MailtoSyntaxFlags;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr_NetPipeSyntaxFlags;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_NetTcpSyntaxFlags;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemeName_Internal_get_String_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPort_Internal_get_Int32_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_OnNewUri_Protected_Virtual_New_UriParser_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAndValidate_Protected_Virtual_New_Void_Uri_byref_UriFormatException_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Protected_Virtual_New_String_Uri_Uri_byref_UriFormatException_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_IsBaseOf_Protected_Virtual_New_Boolean_Uri_Uri_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Protected_Virtual_New_String_Uri_UriComponents_UriFormat_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_IsWellFormedOriginalString_Protected_Virtual_New_Boolean_Uri_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldUseLegacyV2Quirks_Internal_Static_get_Boolean_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Internal_get_UriSyntaxFlags_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_NotAny_Internal_Boolean_UriSyntaxFlags_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_InFact_Internal_Boolean_UriSyntaxFlags_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_IsAllSet_Internal_Boolean_UriSyntaxFlags_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_IsFullMatch_Private_Boolean_UriSyntaxFlags_UriSyntaxFlags_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UriSyntaxFlags_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_FindOrFetchAsUnknownV1Syntax_Internal_Static_UriParser_String_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_GetSyntax_Internal_Static_UriParser_String_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSimple_Internal_get_Boolean_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnNewUri_Internal_UriParser_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_InternalValidate_Internal_Void_Uri_byref_UriFormatException_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_InternalResolve_Internal_String_Uri_Uri_byref_UriFormatException_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsBaseOf_Internal_Boolean_Uri_Uri_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetComponents_Internal_String_Uri_UriComponents_UriFormat_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_Uri_0;

		// Token: 0x020002C6 RID: 710
		public enum UriQuirksVersion
		{
			// Token: 0x0400225A RID: 8794
			V2 = 2,
			// Token: 0x0400225B RID: 8795
			V3
		}

		// Token: 0x020002C7 RID: 711
		public class BuiltInUriParser : UriParser
		{
			// Token: 0x06002B76 RID: 11126 RVA: 0x0001386F File Offset: 0x00011A6F
			// Note: this type is marked as 'beforefieldinit'.
			static BuiltInUriParser()
			{
				Il2CppClassPointerStore<UriParser.BuiltInUriParser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "BuiltInUriParser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriParser.BuiltInUriParser>.NativeClassPtr);
				UriParser.BuiltInUriParser.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser.BuiltInUriParser>.NativeClassPtr, 100664384);
			}

			// Token: 0x06002B77 RID: 11127 RVA: 0x000C0938 File Offset: 0x000BEB38
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 436345, RefRangeEnd = 436346, XrefRangeStart = 436340, XrefRangeEnd = 436345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriParser.BuiltInUriParser>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(lwrCaseScheme);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultPort;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref syntaxFlags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.BuiltInUriParser.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B78 RID: 11128 RVA: 0x000138A3 File Offset: 0x00011AA3
			public BuiltInUriParser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400225C RID: 8796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_UriSyntaxFlags_0;
		}
	}
}
