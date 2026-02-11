using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200005D RID: 93
	[Serializable]
	public class Uri : Object
	{
		// Token: 0x06000542 RID: 1346 RVA: 0x0003037C File Offset: 0x0002E57C
		// Note: this type is marked as 'beforefieldinit'.
		static Uri()
		{
			Il2CppClassPointerStore<Uri>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "Uri");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri>.NativeClassPtr);
			Uri.NativeFieldInfoPtr_UriSchemeFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeFile");
			Uri.NativeFieldInfoPtr_UriSchemeFtp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeFtp");
			Uri.NativeFieldInfoPtr_UriSchemeGopher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeGopher");
			Uri.NativeFieldInfoPtr_UriSchemeHttp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeHttp");
			Uri.NativeFieldInfoPtr_UriSchemeHttps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeHttps");
			Uri.NativeFieldInfoPtr_UriSchemeWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeWs");
			Uri.NativeFieldInfoPtr_UriSchemeWss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeWss");
			Uri.NativeFieldInfoPtr_UriSchemeMailto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeMailto");
			Uri.NativeFieldInfoPtr_UriSchemeNews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNews");
			Uri.NativeFieldInfoPtr_UriSchemeNntp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNntp");
			Uri.NativeFieldInfoPtr_UriSchemeNetTcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNetTcp");
			Uri.NativeFieldInfoPtr_UriSchemeNetPipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNetPipe");
			Uri.NativeFieldInfoPtr_SchemeDelimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "SchemeDelimiter");
			Uri.NativeFieldInfoPtr_c_Max16BitUtf8SequenceLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "c_Max16BitUtf8SequenceLength");
			Uri.NativeFieldInfoPtr_c_MaxUriBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "c_MaxUriBufferSize");
			Uri.NativeFieldInfoPtr_c_MaxUriSchemeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "c_MaxUriSchemeName");
			Uri.NativeFieldInfoPtr_m_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_String");
			Uri.NativeFieldInfoPtr_m_originalUnicodeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_originalUnicodeString");
			Uri.NativeFieldInfoPtr_m_Syntax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Syntax");
			Uri.NativeFieldInfoPtr_m_DnsSafeHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_DnsSafeHost");
			Uri.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Flags");
			Uri.NativeFieldInfoPtr_m_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Info");
			Uri.NativeFieldInfoPtr_m_iriParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_iriParsing");
			Uri.NativeFieldInfoPtr_s_ConfigInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_ConfigInitialized");
			Uri.NativeFieldInfoPtr_s_ConfigInitializing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_ConfigInitializing");
			Uri.NativeFieldInfoPtr_s_IdnScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_IdnScope");
			Uri.NativeFieldInfoPtr_s_IriParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_IriParsing");
			Uri.NativeFieldInfoPtr_useDotNetRelativeOrAbsolute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "useDotNetRelativeOrAbsolute");
			Uri.NativeFieldInfoPtr_DotNetRelativeOrAbsolute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "DotNetRelativeOrAbsolute");
			Uri.NativeFieldInfoPtr_IsWindowsFileSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "IsWindowsFileSystem");
			Uri.NativeFieldInfoPtr_s_initLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_initLock");
			Uri.NativeFieldInfoPtr_V1ToStringUnescape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "V1ToStringUnescape");
			Uri.NativeFieldInfoPtr_c_DummyChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "c_DummyChar");
			Uri.NativeFieldInfoPtr_c_EOL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "c_EOL");
			Uri.NativeFieldInfoPtr_HexLowerChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "HexLowerChars");
			Uri.NativeFieldInfoPtr__WSchars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "_WSchars");
			Uri.NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664210);
			Uri.NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664211);
			Uri.NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664212);
			Uri.NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664213);
			Uri.NativeMethodInfoPtr_get_HostType_Private_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664214);
			Uri.NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664215);
			Uri.NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664216);
			Uri.NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664217);
			Uri.NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664218);
			Uri.NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664219);
			Uri.NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664220);
			Uri.NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664221);
			Uri.NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664222);
			Uri.NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664223);
			Uri.NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664224);
			Uri.NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664225);
			Uri.NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664226);
			Uri.NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664227);
			Uri.NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664228);
			Uri.NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664229);
			Uri.NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664230);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664231);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664232);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664233);
			Uri.NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664234);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664235);
			Uri.NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664236);
			Uri.NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664237);
			Uri.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664238);
			Uri.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664239);
			Uri.NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664240);
			Uri.NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664241);
			Uri.NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664242);
			Uri.NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664243);
			Uri.NativeMethodInfoPtr_get_LocalPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664244);
			Uri.NativeMethodInfoPtr_get_Authority_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664245);
			Uri.NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664246);
			Uri.NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664247);
			Uri.NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664248);
			Uri.NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664249);
			Uri.NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664250);
			Uri.NativeMethodInfoPtr_get_Segments_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664251);
			Uri.NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664252);
			Uri.NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664253);
			Uri.NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664254);
			Uri.NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664255);
			Uri.NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664256);
			Uri.NativeMethodInfoPtr_GetLocalPath_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664257);
			Uri.NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664258);
			Uri.NativeMethodInfoPtr_get_Query_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664259);
			Uri.NativeMethodInfoPtr_get_Fragment_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664260);
			Uri.NativeMethodInfoPtr_get_Scheme_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664261);
			Uri.NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664262);
			Uri.NativeMethodInfoPtr_get_OriginalString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664263);
			Uri.NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664264);
			Uri.NativeMethodInfoPtr_get_IdnHost_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664265);
			Uri.NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664266);
			Uri.NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664267);
			Uri.NativeMethodInfoPtr_get_UserInfo_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664268);
			Uri.NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664269);
			Uri.NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664270);
			Uri.NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664271);
			Uri.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664272);
			Uri.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664273);
			Uri.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664274);
			Uri.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664275);
			Uri.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664276);
			Uri.NativeMethodInfoPtr_CheckForColonInFirstPathSegment_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664277);
			Uri.NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664278);
			Uri.NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664279);
			Uri.NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664280);
			Uri.NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664281);
			Uri.NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664282);
			Uri.NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664283);
			Uri.NativeMethodInfoPtr_CreateHostString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664284);
			Uri.NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664285);
			Uri.NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664286);
			Uri.NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664287);
			Uri.NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664288);
			Uri.NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664289);
			Uri.NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664290);
			Uri.NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664291);
			Uri.NativeMethodInfoPtr_ParseRemaining_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664292);
			Uri.NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664293);
			Uri.NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664294);
			Uri.NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664295);
			Uri.NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664296);
			Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664297);
			Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664298);
			Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664299);
			Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664300);
			Uri.NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664301);
			Uri.NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664302);
			Uri.NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664303);
			Uri.NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664304);
			Uri.NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664305);
			Uri.NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664306);
			Uri.NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664307);
			Uri.NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664308);
			Uri.NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664309);
			Uri.NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664310);
			Uri.NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664311);
			Uri.NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664312);
			Uri.NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664313);
			Uri.NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664314);
			Uri.NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664315);
			Uri.NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664316);
			Uri.NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664317);
			Uri.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664318);
			Uri.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_String_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664319);
			Uri.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_Uri_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664320);
			Uri.NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664321);
			Uri.NativeMethodInfoPtr_IsWellFormedOriginalString_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664322);
			Uri.NativeMethodInfoPtr_IsWellFormedUriString_Public_Static_Boolean_String_UriKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664323);
			Uri.NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664324);
			Uri.NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664325);
			Uri.NativeMethodInfoPtr_EscapeUriString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664326);
			Uri.NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664327);
			Uri.NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664328);
			Uri.NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664329);
			Uri.NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664330);
			Uri.NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664331);
			Uri.NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664332);
			Uri.NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664333);
			Uri.NativeMethodInfoPtr_IsBaseOf_Public_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664334);
			Uri.NativeMethodInfoPtr_IsBaseOfHelper_Internal_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664335);
			Uri.NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664336);
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00031068 File Offset: 0x0002F268
		public unsafe bool IsImplicitFile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x000310A4 File Offset: 0x0002F2A4
		public unsafe bool IsUncOrDosPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x000310E0 File Offset: 0x0002F2E0
		public unsafe bool IsDosPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0003111C File Offset: 0x0002F31C
		public unsafe bool IsUncPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00031158 File Offset: 0x0002F358
		public unsafe Uri.Flags HostType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_HostType_Private_get_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00031194 File Offset: 0x0002F394
		public unsafe UriParser Syntax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x000311D4 File Offset: 0x0002F3D4
		public unsafe bool IsNotAbsoluteUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00031210 File Offset: 0x0002F410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 434232, RefRangeEnd = 434233, XrefRangeStart = 434227, XrefRangeEnd = 434232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IriParsingStatic(UriParser syntax)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00031254 File Offset: 0x0002F454
		public unsafe bool AllowIdn
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 434238, RefRangeEnd = 434246, XrefRangeStart = 434233, XrefRangeEnd = 434238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00031290 File Offset: 0x0002F490
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 434251, RefRangeEnd = 434255, XrefRangeStart = 434246, XrefRangeEnd = 434251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AllowIdnStatic(UriParser syntax, Uri.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000312EC File Offset: 0x0002F4EC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIntranet(string schemeHost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(schemeHost);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0003133C File Offset: 0x0002F53C
		public unsafe bool UserDrivenParsing
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 434255, RefRangeEnd = 434257, XrefRangeStart = 434255, XrefRangeEnd = 434255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00031378 File Offset: 0x0002F578
		[CallerCount(0)]
		public unsafe void SetUserDrivenParsing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x000313AC File Offset: 0x0002F5AC
		public unsafe ushort SecuredPathIndex
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 434257, RefRangeEnd = 434260, XrefRangeStart = 434257, XrefRangeEnd = 434257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000313E8 File Offset: 0x0002F5E8
		[CallerCount(0)]
		public unsafe bool NotAny(Uri.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00031434 File Offset: 0x0002F634
		[CallerCount(0)]
		public unsafe bool InFact(Uri.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00031480 File Offset: 0x0002F680
		[CallerCount(0)]
		public unsafe static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000314CC File Offset: 0x0002F6CC
		[CallerCount(0)]
		public unsafe static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00031518 File Offset: 0x0002F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434260, XrefRangeEnd = 434261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri.UriInfo EnsureUriInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri.UriInfo>(intPtr3) : null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00031558 File Offset: 0x0002F758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434261, XrefRangeEnd = 434262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureParseRemaining()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0003158C File Offset: 0x0002F78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434262, XrefRangeEnd = 434264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureHostString(bool allowDnsOptimization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowDnsOptimization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000315CC File Offset: 0x0002F7CC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 434272, RefRangeEnd = 434300, XrefRangeStart = 434264, XrefRangeEnd = 434272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(string uriString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00031618 File Offset: 0x0002F818
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 434302, RefRangeEnd = 434312, XrefRangeStart = 434300, XrefRangeEnd = 434302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(string uriString, UriKind uriKind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00031674 File Offset: 0x0002F874
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 434314, RefRangeEnd = 434317, XrefRangeStart = 434312, XrefRangeEnd = 434314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(Uri baseUri, string relativeUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000316D4 File Offset: 0x0002F8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 434346, RefRangeEnd = 434347, XrefRangeStart = 434317, XrefRangeEnd = 434346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUri(Uri baseUri, string relativeUri, bool dontEscape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00031738 File Offset: 0x0002F938
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 434361, RefRangeEnd = 434365, XrefRangeStart = 434347, XrefRangeEnd = 434361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(Uri baseUri, Uri relativeUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00031798 File Offset: 0x0002F998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434365, XrefRangeEnd = 434379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(result);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			result = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0003181C File Offset: 0x0002FA1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 434391, RefRangeEnd = 434393, XrefRangeStart = 434379, XrefRangeEnd = 434391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UriFormatException GetException(ParsingError err)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref err;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriFormatException>(intPtr3) : null;
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0003185C File Offset: 0x0002FA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434393, XrefRangeEnd = 434415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000318C0 File Offset: 0x0002FAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434415, XrefRangeEnd = 434428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0003191C File Offset: 0x0002FB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00031978 File Offset: 0x0002FB78
		public unsafe string AbsolutePath
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 434431, RefRangeEnd = 434441, XrefRangeStart = 434428, XrefRangeEnd = 434431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x000319B0 File Offset: 0x0002FBB0
		public unsafe string PrivateAbsolutePath
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 434449, RefRangeEnd = 434451, XrefRangeStart = 434441, XrefRangeEnd = 434449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x000319E8 File Offset: 0x0002FBE8
		public unsafe string AbsoluteUri
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 434459, RefRangeEnd = 434478, XrefRangeStart = 434451, XrefRangeEnd = 434459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00031A20 File Offset: 0x0002FC20
		public unsafe string LocalPath
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 434486, RefRangeEnd = 434490, XrefRangeStart = 434478, XrefRangeEnd = 434486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_LocalPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00031A58 File Offset: 0x0002FC58
		public unsafe string Authority
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 434498, RefRangeEnd = 434501, XrefRangeStart = 434490, XrefRangeEnd = 434498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Authority_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00031A90 File Offset: 0x0002FC90
		public unsafe UriHostNameType HostNameType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 434506, RefRangeEnd = 434509, XrefRangeStart = 434501, XrefRangeEnd = 434506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00031ACC File Offset: 0x0002FCCC
		public unsafe bool IsDefaultPort
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 434512, RefRangeEnd = 434517, XrefRangeStart = 434509, XrefRangeEnd = 434512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00031B08 File Offset: 0x0002FD08
		public unsafe bool IsFile
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 434521, RefRangeEnd = 434522, XrefRangeStart = 434517, XrefRangeEnd = 434521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00031B44 File Offset: 0x0002FD44
		public unsafe bool IsLoopback
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 434524, RefRangeEnd = 434527, XrefRangeStart = 434522, XrefRangeEnd = 434524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00031B80 File Offset: 0x0002FD80
		public unsafe string PathAndQuery
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 434530, RefRangeEnd = 434539, XrefRangeStart = 434527, XrefRangeEnd = 434530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00031BB8 File Offset: 0x0002FDB8
		public unsafe Il2CppStringArray Segments
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 434559, RefRangeEnd = 434561, XrefRangeStart = 434539, XrefRangeEnd = 434559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Segments_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00031BF8 File Offset: 0x0002FDF8
		public unsafe bool IsUnc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00031C34 File Offset: 0x0002FE34
		public unsafe string Host
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 434569, RefRangeEnd = 434594, XrefRangeStart = 434561, XrefRangeEnd = 434569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00031C6C File Offset: 0x0002FE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434594, XrefRangeEnd = 434596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StaticIsFile(UriParser syntax)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00031CB0 File Offset: 0x0002FEB0
		public unsafe static Object InitializeLock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434596, XrefRangeEnd = 434611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00031CE4 File Offset: 0x0002FEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 434651, RefRangeEnd = 434652, XrefRangeStart = 434611, XrefRangeEnd = 434651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeUriConfig()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00031D0C File Offset: 0x0002FF0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 434678, RefRangeEnd = 434679, XrefRangeStart = 434652, XrefRangeEnd = 434678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetLocalPath_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00031D44 File Offset: 0x0002FF44
		public unsafe int Port
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 434684, RefRangeEnd = 434698, XrefRangeStart = 434679, XrefRangeEnd = 434684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00031D80 File Offset: 0x0002FF80
		public unsafe string Query
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 434706, RefRangeEnd = 434712, XrefRangeStart = 434698, XrefRangeEnd = 434706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Query_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00031DB8 File Offset: 0x0002FFB8
		public unsafe string Fragment
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 434720, RefRangeEnd = 434723, XrefRangeStart = 434712, XrefRangeEnd = 434720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Fragment_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00031DF0 File Offset: 0x0002FFF0
		public unsafe string Scheme
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 434723, RefRangeEnd = 434762, XrefRangeStart = 434723, XrefRangeEnd = 434723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Scheme_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00031E28 File Offset: 0x00030028
		public unsafe bool OriginalStringSwitched
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434762, XrefRangeEnd = 434763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00031E64 File Offset: 0x00030064
		public unsafe string OriginalString
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 434764, RefRangeEnd = 434793, XrefRangeStart = 434763, XrefRangeEnd = 434764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_OriginalString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00031E9C File Offset: 0x0003009C
		public unsafe string DnsSafeHost
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 434798, RefRangeEnd = 434799, XrefRangeStart = 434793, XrefRangeEnd = 434798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00031ED4 File Offset: 0x000300D4
		public unsafe string IdnHost
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 434801, RefRangeEnd = 434802, XrefRangeStart = 434799, XrefRangeEnd = 434801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IdnHost_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00031F0C File Offset: 0x0003010C
		public unsafe bool IsAbsoluteUri
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 434802, RefRangeEnd = 434827, XrefRangeStart = 434802, XrefRangeEnd = 434802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00031F48 File Offset: 0x00030148
		public unsafe bool UserEscaped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00031F84 File Offset: 0x00030184
		public unsafe string UserInfo
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 434835, RefRangeEnd = 434840, XrefRangeStart = 434827, XrefRangeEnd = 434835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_UserInfo_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00031FBC File Offset: 0x000301BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 434840, RefRangeEnd = 434841, XrefRangeStart = 434840, XrefRangeEnd = 434840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenDelim(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00031FFC File Offset: 0x000301FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 434841, RefRangeEnd = 434844, XrefRangeStart = 434841, XrefRangeEnd = 434841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHexDigit(char character)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0003203C File Offset: 0x0003023C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 434844, RefRangeEnd = 434845, XrefRangeStart = 434844, XrefRangeEnd = 434844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FromHex(char digit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0003207C File Offset: 0x0003027C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434845, XrefRangeEnd = 434856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Uri.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000320C4 File Offset: 0x000302C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434856, XrefRangeEnd = 434862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Uri.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00032108 File Offset: 0x00030308
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 434862, RefRangeEnd = 434909, XrefRangeStart = 434862, XrefRangeEnd = 434862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Uri uri1, Uri uri2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0003215C File Offset: 0x0003035C
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 434909, RefRangeEnd = 434939, XrefRangeStart = 434909, XrefRangeEnd = 434909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Uri uri1, Uri uri2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000321B0 File Offset: 0x000303B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434939, XrefRangeEnd = 434959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Uri.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00032208 File Offset: 0x00030408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434959, XrefRangeEnd = 434966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckForColonInFirstPathSegment(string uriString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckForColonInFirstPathSegment_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0003224C File Offset: 0x0003044C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 434972, RefRangeEnd = 434973, XrefRangeStart = 434966, XrefRangeEnd = 434972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalEscapeString(string rawString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rawString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00032288 File Offset: 0x00030488
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 434978, RefRangeEnd = 434984, XrefRangeStart = 434973, XrefRangeEnd = 434978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00032300 File Offset: 0x00030500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 434989, RefRangeEnd = 434990, XrefRangeStart = 434984, XrefRangeEnd = 434989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriFormatException ParseMinimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriFormatException>(intPtr3) : null;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00032340 File Offset: 0x00030540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435015, RefRangeEnd = 435016, XrefRangeStart = 434990, XrefRangeEnd = 435015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParsingError PrivateParseMinimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0003237C File Offset: 0x0003057C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435016, XrefRangeEnd = 435022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrivateParseMinimalIri(string newHost, ushort idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000323CC File Offset: 0x000305CC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 435058, RefRangeEnd = 435080, XrefRangeStart = 435022, XrefRangeEnd = 435058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUriInfo(Uri.Flags cF)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cF;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0003240C File Offset: 0x0003060C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 435110, RefRangeEnd = 435119, XrefRangeStart = 435080, XrefRangeEnd = 435110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateHostString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateHostString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00032440 File Offset: 0x00030640
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435128, RefRangeEnd = 435130, XrefRangeStart = 435119, XrefRangeEnd = 435128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000324CC File Offset: 0x000306CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435146, RefRangeEnd = 435147, XrefRangeStart = 435130, XrefRangeEnd = 435146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetHostViaCustomSyntax()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00032500 File Offset: 0x00030700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435147, XrefRangeEnd = 435148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetParts(UriComponents uriParts, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00032554 File Offset: 0x00030754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435148, XrefRangeEnd = 435152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEscapedParts(UriComponents uriParts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00032598 File Offset: 0x00030798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435156, RefRangeEnd = 435157, XrefRangeStart = 435152, XrefRangeEnd = 435156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000325EC File Offset: 0x000307EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435217, RefRangeEnd = 435219, XrefRangeStart = 435157, XrefRangeEnd = 435217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref parts;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonCanonical;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0003264C File Offset: 0x0003084C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435222, RefRangeEnd = 435224, XrefRangeStart = 435219, XrefRangeEnd = 435222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUriPartsFromUserString(UriComponents uriParts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00032690 File Offset: 0x00030890
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 435307, RefRangeEnd = 435311, XrefRangeStart = 435224, XrefRangeEnd = 435307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseRemaining()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseRemaining_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000326C4 File Offset: 0x000308C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435356, RefRangeEnd = 435358, XrefRangeStart = 435311, XrefRangeEnd = 435356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = uriString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00032758 File Offset: 0x00030958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435415, RefRangeEnd = 435416, XrefRangeStart = 435358, XrefRangeEnd = 435415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = lptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChars;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000327CC File Offset: 0x000309CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435423, RefRangeEnd = 435425, XrefRangeStart = 435416, XrefRangeEnd = 435423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00032840 File Offset: 0x00030A40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435550, RefRangeEnd = 435551, XrefRangeStart = 435425, XrefRangeEnd = 435550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newHost = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000328F8 File Offset: 0x00030AF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435602, RefRangeEnd = 435603, XrefRangeStart = 435551, XrefRangeEnd = 435602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startInput;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iriParsing;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasUnicode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userInfoString);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &justNormalized;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newHost = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000329F4 File Offset: 0x00030BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435603, XrefRangeEnd = 435626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startInput;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iriParsing;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasUnicode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newHost = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00032ABC File Offset: 0x00030CBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435628, RefRangeEnd = 435630, XrefRangeStart = 435626, XrefRangeEnd = 435628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00032B28 File Offset: 0x00030D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435630, XrefRangeEnd = 435631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00032B90 File Offset: 0x00030D90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 435653, RefRangeEnd = 435659, XrefRangeStart = 435631, XrefRangeEnd = 435653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00032C04 File Offset: 0x00030E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435692, RefRangeEnd = 435693, XrefRangeStart = 435659, XrefRangeEnd = 435692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<char> GetCanonicalPath(Il2CppStructArray<char> dest, ref int pos, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00032C70 File Offset: 0x00030E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435700, RefRangeEnd = 435701, XrefRangeStart = 435693, XrefRangeEnd = 435700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00032CE8 File Offset: 0x00030EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435722, RefRangeEnd = 435723, XrefRangeStart = 435701, XrefRangeEnd = 435722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> Compress(Il2CppStructArray<char> dest, ushort start, ref int destLength, UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00032D5C File Offset: 0x00030F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435731, RefRangeEnd = 435732, XrefRangeStart = 435723, XrefRangeEnd = 435731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CalculateCaseInsensitiveHashCode(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00032DA0 File Offset: 0x00030FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435732, XrefRangeEnd = 435754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(basePart);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativePart);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00032DFC File Offset: 0x00030FFC
		public unsafe bool HasAuthority
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 435754, RefRangeEnd = 435756, XrefRangeStart = 435754, XrefRangeEnd = 435754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00032E38 File Offset: 0x00031038
		[CallerCount(0)]
		public unsafe static bool IsLWS(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00032E78 File Offset: 0x00031078
		[CallerCount(0)]
		public unsafe static bool IsAsciiLetter(char character)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00032EB8 File Offset: 0x000310B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435759, RefRangeEnd = 435761, XrefRangeStart = 435756, XrefRangeEnd = 435759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAsciiLetterOrDigit(char character)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00032EF8 File Offset: 0x000310F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435761, RefRangeEnd = 435763, XrefRangeStart = 435761, XrefRangeEnd = 435761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBidiControlCharacter(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00032F38 File Offset: 0x00031138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435771, RefRangeEnd = 435773, XrefRangeStart = 435763, XrefRangeEnd = 435771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripBidiControlCharacter(char* strToClean, int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = strToClean;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00032F8C File Offset: 0x0003118C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435781, RefRangeEnd = 435783, XrefRangeStart = 435773, XrefRangeEnd = 435781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateThis(string uri, bool dontEscape, UriKind uriKind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00032FEC File Offset: 0x000311EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 435790, RefRangeEnd = 435797, XrefRangeStart = 435783, XrefRangeEnd = 435790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref err;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			e = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0003305C File Offset: 0x0003125C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435797, XrefRangeEnd = 435798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForConfigLoad(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000330AC File Offset: 0x000312AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435798, XrefRangeEnd = 435805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForUnicode(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000330FC File Offset: 0x000312FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435805, XrefRangeEnd = 435819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForEscapedUnreserved(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0003314C File Offset: 0x0003134C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 435826, RefRangeEnd = 435835, XrefRangeStart = 435819, XrefRangeEnd = 435826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreate(string uriString, UriKind uriKind, out Uri result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000331C0 File Offset: 0x000313C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435867, RefRangeEnd = 435868, XrefRangeStart = 435835, XrefRangeEnd = 435867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreate(Uri baseUri, string relativeUri, out Uri result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_String_byref_Uri_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00033238 File Offset: 0x00031438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435868, XrefRangeEnd = 435884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result)
		{
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_Uri_byref_Uri_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000332B0 File Offset: 0x000314B0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 435886, RefRangeEnd = 435906, XrefRangeStart = 435884, XrefRangeEnd = 435886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetComponents(UriComponents components, UriFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref components;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00033304 File Offset: 0x00031504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435906, XrefRangeEnd = 435910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWellFormedOriginalString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsWellFormedOriginalString_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00033340 File Offset: 0x00031540
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435922, RefRangeEnd = 435924, XrefRangeStart = 435910, XrefRangeEnd = 435922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWellFormedUriString(string uriString, UriKind uriKind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsWellFormedUriString_Public_Static_Boolean_String_UriKind_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00033390 File Offset: 0x00031590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 435935, RefRangeEnd = 435937, XrefRangeStart = 435924, XrefRangeEnd = 435935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalIsWellFormedOriginalString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000333CC File Offset: 0x000315CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 435948, RefRangeEnd = 435954, XrefRangeStart = 435937, XrefRangeEnd = 435948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnescapeDataString(string stringToUnescape)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToUnescape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00033408 File Offset: 0x00031608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 435960, RefRangeEnd = 435961, XrefRangeStart = 435954, XrefRangeEnd = 435960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeUriString(string stringToEscape)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToEscape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EscapeUriString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00033444 File Offset: 0x00031644
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 435967, RefRangeEnd = 435974, XrefRangeStart = 435961, XrefRangeEnd = 435967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeDataString(string stringToEscape)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToEscape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00033480 File Offset: 0x00031680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435974, XrefRangeEnd = 435976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EscapeUnescapeIri(string input, int start, int end, UriComponents component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref component;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000334F4 File Offset: 0x000316F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435976, XrefRangeEnd = 435979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(Uri.Flags flags, UriParser uriParser, string uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uriParser);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00033560 File Offset: 0x00031760
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 435998, RefRangeEnd = 436004, XrefRangeStart = 435979, XrefRangeEnd = 435998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			e = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000335EC File Offset: 0x000317EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 436018, RefRangeEnd = 436024, XrefRangeStart = 436004, XrefRangeEnd = 436018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeUri);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newUriString);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &userEscaped;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			newUriString = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			e = ((intPtr5 == 0) ? null : new UriFormatException(intPtr5));
			IntPtr intPtr6 = intPtr3;
			return (intPtr6 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr6) : null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00033698 File Offset: 0x00031898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436024, XrefRangeEnd = 436034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRelativeSerializationString(UriFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000336DC File Offset: 0x000318DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 436041, RefRangeEnd = 436043, XrefRangeStart = 436034, XrefRangeEnd = 436041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriComponents;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00033730 File Offset: 0x00031930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436046, RefRangeEnd = 436047, XrefRangeStart = 436043, XrefRangeEnd = 436046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBaseOf(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsBaseOf_Public_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00033780 File Offset: 0x00031980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 436064, RefRangeEnd = 436066, XrefRangeStart = 436047, XrefRangeEnd = 436064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBaseOfHelper(Uri uriLink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uriLink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsBaseOfHelper_Internal_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000337D0 File Offset: 0x000319D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 436076, RefRangeEnd = 436078, XrefRangeStart = 436066, XrefRangeEnd = 436076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateThisFromUri(Uri otherUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00003C07 File Offset: 0x00001E07
		public Uri(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00033814 File Offset: 0x00031A14
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00003C10 File Offset: 0x00001E10
		public unsafe static string UriSchemeFile
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeFile, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeFile, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00033834 File Offset: 0x00031A34
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00003C22 File Offset: 0x00001E22
		public unsafe static string UriSchemeFtp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeFtp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeFtp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00033854 File Offset: 0x00031A54
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00003C34 File Offset: 0x00001E34
		public unsafe static string UriSchemeGopher
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeGopher, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeGopher, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00033874 File Offset: 0x00031A74
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00003C46 File Offset: 0x00001E46
		public unsafe static string UriSchemeHttp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeHttp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeHttp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00033894 File Offset: 0x00031A94
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00003C58 File Offset: 0x00001E58
		public unsafe static string UriSchemeHttps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeHttps, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeHttps, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x000338B4 File Offset: 0x00031AB4
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00003C6A File Offset: 0x00001E6A
		public unsafe static string UriSchemeWs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeWs, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeWs, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x000338D4 File Offset: 0x00031AD4
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00003C7C File Offset: 0x00001E7C
		public unsafe static string UriSchemeWss
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeWss, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeWss, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x000338F4 File Offset: 0x00031AF4
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00003C8E File Offset: 0x00001E8E
		public unsafe static string UriSchemeMailto
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeMailto, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeMailto, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00033914 File Offset: 0x00031B14
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00003CA0 File Offset: 0x00001EA0
		public unsafe static string UriSchemeNews
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNews, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNews, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00033934 File Offset: 0x00031B34
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00003CB2 File Offset: 0x00001EB2
		public unsafe static string UriSchemeNntp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNntp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNntp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00033954 File Offset: 0x00031B54
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00003CC4 File Offset: 0x00001EC4
		public unsafe static string UriSchemeNetTcp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNetTcp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNetTcp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00033974 File Offset: 0x00031B74
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00003CD6 File Offset: 0x00001ED6
		public unsafe static string UriSchemeNetPipe
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNetPipe, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNetPipe, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00033994 File Offset: 0x00031B94
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00003CE8 File Offset: 0x00001EE8
		public unsafe static string SchemeDelimiter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_SchemeDelimiter, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_SchemeDelimiter, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x000339B4 File Offset: 0x00031BB4
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00003CFA File Offset: 0x00001EFA
		public unsafe static int c_Max16BitUtf8SequenceLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_c_Max16BitUtf8SequenceLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_c_Max16BitUtf8SequenceLength, (void*)(&value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x000339D0 File Offset: 0x00031BD0
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00003D08 File Offset: 0x00001F08
		public unsafe static int c_MaxUriBufferSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_c_MaxUriBufferSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_c_MaxUriBufferSize, (void*)(&value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x000339EC File Offset: 0x00031BEC
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00003D16 File Offset: 0x00001F16
		public unsafe static int c_MaxUriSchemeName
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_c_MaxUriSchemeName, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_c_MaxUriSchemeName, (void*)(&value));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00033A08 File Offset: 0x00031C08
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00003D24 File Offset: 0x00001F24
		public unsafe string m_String
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_String);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_String), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00033A30 File Offset: 0x00031C30
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00003D43 File Offset: 0x00001F43
		public unsafe string m_originalUnicodeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_originalUnicodeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_originalUnicodeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00033A58 File Offset: 0x00031C58
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00003D62 File Offset: 0x00001F62
		public unsafe UriParser m_Syntax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Syntax);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Syntax), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00033A88 File Offset: 0x00031C88
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00003D81 File Offset: 0x00001F81
		public unsafe string m_DnsSafeHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_DnsSafeHost);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_DnsSafeHost), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00033AB0 File Offset: 0x00031CB0
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public unsafe Uri.Flags m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00033AD8 File Offset: 0x00031CD8
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00003DBB File Offset: 0x00001FBB
		public unsafe Uri.UriInfo m_Info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri.UriInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00033B08 File Offset: 0x00031D08
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00003DDA File Offset: 0x00001FDA
		public unsafe bool m_iriParsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_iriParsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_iriParsing)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00033B30 File Offset: 0x00031D30
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00003DF5 File Offset: 0x00001FF5
		public unsafe static bool s_ConfigInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_ConfigInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_ConfigInitialized, (void*)(&value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00033B4C File Offset: 0x00031D4C
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00003E03 File Offset: 0x00002003
		public unsafe static bool s_ConfigInitializing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_ConfigInitializing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_ConfigInitializing, (void*)(&value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00033B68 File Offset: 0x00031D68
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00003E11 File Offset: 0x00002011
		public unsafe static UriIdnScope s_IdnScope
		{
			get
			{
				UriIdnScope uriIdnScope;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_IdnScope, (void*)(&uriIdnScope));
				return uriIdnScope;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_IdnScope, (void*)(&value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00033B84 File Offset: 0x00031D84
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00003E1F File Offset: 0x0000201F
		public unsafe static bool s_IriParsing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_IriParsing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_IriParsing, (void*)(&value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00033BA0 File Offset: 0x00031DA0
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00003E2D File Offset: 0x0000202D
		public unsafe static bool useDotNetRelativeOrAbsolute
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_useDotNetRelativeOrAbsolute, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_useDotNetRelativeOrAbsolute, (void*)(&value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00033BBC File Offset: 0x00031DBC
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00003E3B File Offset: 0x0000203B
		public unsafe static UriKind DotNetRelativeOrAbsolute
		{
			get
			{
				UriKind uriKind;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_DotNetRelativeOrAbsolute, (void*)(&uriKind));
				return uriKind;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_DotNetRelativeOrAbsolute, (void*)(&value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00033BD8 File Offset: 0x00031DD8
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00003E49 File Offset: 0x00002049
		public unsafe static bool IsWindowsFileSystem
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_IsWindowsFileSystem, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_IsWindowsFileSystem, (void*)(&value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00033BF4 File Offset: 0x00031DF4
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00003E57 File Offset: 0x00002057
		public unsafe static Object s_initLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_initLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_initLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00033C1C File Offset: 0x00031E1C
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00003E69 File Offset: 0x00002069
		public unsafe static UriFormat V1ToStringUnescape
		{
			get
			{
				UriFormat uriFormat;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_V1ToStringUnescape, (void*)(&uriFormat));
				return uriFormat;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_V1ToStringUnescape, (void*)(&value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00033C38 File Offset: 0x00031E38
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00003E77 File Offset: 0x00002077
		public unsafe static char c_DummyChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_c_DummyChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_c_DummyChar, (void*)(&value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00033C54 File Offset: 0x00031E54
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00003E85 File Offset: 0x00002085
		public unsafe static char c_EOL
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_c_EOL, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_c_EOL, (void*)(&value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00033C70 File Offset: 0x00031E70
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00003E93 File Offset: 0x00002093
		public unsafe static Il2CppStructArray<char> HexLowerChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_HexLowerChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_HexLowerChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00033C98 File Offset: 0x00031E98
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00003EA5 File Offset: 0x000020A5
		public unsafe static Il2CppStructArray<char> _WSchars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr__WSchars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr__WSchars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeFile;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeFtp;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeGopher;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeHttp;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeHttps;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeWs;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeWss;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeMailto;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNews;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNntp;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNetTcp;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNetPipe;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr_SchemeDelimiter;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr_c_Max16BitUtf8SequenceLength;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeFieldInfoPtr_c_MaxUriBufferSize;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeFieldInfoPtr_c_MaxUriSchemeName;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeFieldInfoPtr_m_String;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeFieldInfoPtr_m_originalUnicodeString;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr_m_Syntax;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr_m_DnsSafeHost;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_m_Info;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_m_iriParsing;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_s_ConfigInitialized;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_s_ConfigInitializing;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_s_IdnScope;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeFieldInfoPtr_s_IriParsing;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr_useDotNetRelativeOrAbsolute;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr_DotNetRelativeOrAbsolute;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_IsWindowsFileSystem;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_s_initLock;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_V1ToStringUnescape;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_c_DummyChar;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr_c_EOL;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr_HexLowerChars;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr__WSchars;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_get_HostType_Private_get_Flags_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPath_Public_get_String_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_get_Authority_Public_get_String_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_get_Segments_Public_get_Il2CppStringArray_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalPath_Private_String_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_get_Query_Public_get_String_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_get_Fragment_Public_get_String_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_get_Scheme_Public_get_String_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalString_Public_get_String_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_get_IdnHost_Public_get_String_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_get_UserInfo_Public_get_String_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_CheckForColonInFirstPathSegment_Private_Static_Boolean_String_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_CreateHostString_Private_Void_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_ParseRemaining_Private_Void_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_String_byref_Uri_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_Uri_byref_Uri_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_IsWellFormedOriginalString_Public_Boolean_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_IsWellFormedUriString_Public_Static_Boolean_String_UriKind_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_EscapeUriString_Public_Static_String_String_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_IsBaseOf_Public_Boolean_Uri_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_IsBaseOfHelper_Internal_Boolean_Uri_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0;

		// Token: 0x020002C1 RID: 705
		[Flags]
		public enum Flags : ulong
		{
			// Token: 0x040021FA RID: 8698
			Zero = 0UL,
			// Token: 0x040021FB RID: 8699
			SchemeNotCanonical = 1UL,
			// Token: 0x040021FC RID: 8700
			UserNotCanonical = 2UL,
			// Token: 0x040021FD RID: 8701
			HostNotCanonical = 4UL,
			// Token: 0x040021FE RID: 8702
			PortNotCanonical = 8UL,
			// Token: 0x040021FF RID: 8703
			PathNotCanonical = 16UL,
			// Token: 0x04002200 RID: 8704
			QueryNotCanonical = 32UL,
			// Token: 0x04002201 RID: 8705
			FragmentNotCanonical = 64UL,
			// Token: 0x04002202 RID: 8706
			CannotDisplayCanonical = 127UL,
			// Token: 0x04002203 RID: 8707
			E_UserNotCanonical = 128UL,
			// Token: 0x04002204 RID: 8708
			E_HostNotCanonical = 256UL,
			// Token: 0x04002205 RID: 8709
			E_PortNotCanonical = 512UL,
			// Token: 0x04002206 RID: 8710
			E_PathNotCanonical = 1024UL,
			// Token: 0x04002207 RID: 8711
			E_QueryNotCanonical = 2048UL,
			// Token: 0x04002208 RID: 8712
			E_FragmentNotCanonical = 4096UL,
			// Token: 0x04002209 RID: 8713
			E_CannotDisplayCanonical = 8064UL,
			// Token: 0x0400220A RID: 8714
			ShouldBeCompressed = 8192UL,
			// Token: 0x0400220B RID: 8715
			FirstSlashAbsent = 16384UL,
			// Token: 0x0400220C RID: 8716
			BackslashInPath = 32768UL,
			// Token: 0x0400220D RID: 8717
			IndexMask = 65535UL,
			// Token: 0x0400220E RID: 8718
			HostTypeMask = 458752UL,
			// Token: 0x0400220F RID: 8719
			HostNotParsed = 0UL,
			// Token: 0x04002210 RID: 8720
			IPv6HostType = 65536UL,
			// Token: 0x04002211 RID: 8721
			IPv4HostType = 131072UL,
			// Token: 0x04002212 RID: 8722
			DnsHostType = 196608UL,
			// Token: 0x04002213 RID: 8723
			UncHostType = 262144UL,
			// Token: 0x04002214 RID: 8724
			BasicHostType = 327680UL,
			// Token: 0x04002215 RID: 8725
			UnusedHostType = 393216UL,
			// Token: 0x04002216 RID: 8726
			UnknownHostType = 458752UL,
			// Token: 0x04002217 RID: 8727
			UserEscaped = 524288UL,
			// Token: 0x04002218 RID: 8728
			AuthorityFound = 1048576UL,
			// Token: 0x04002219 RID: 8729
			HasUserInfo = 2097152UL,
			// Token: 0x0400221A RID: 8730
			LoopbackHost = 4194304UL,
			// Token: 0x0400221B RID: 8731
			NotDefaultPort = 8388608UL,
			// Token: 0x0400221C RID: 8732
			UserDrivenParsing = 16777216UL,
			// Token: 0x0400221D RID: 8733
			CanonicalDnsHost = 33554432UL,
			// Token: 0x0400221E RID: 8734
			ErrorOrParsingRecursion = 67108864UL,
			// Token: 0x0400221F RID: 8735
			DosPath = 134217728UL,
			// Token: 0x04002220 RID: 8736
			UncPath = 268435456UL,
			// Token: 0x04002221 RID: 8737
			ImplicitFile = 536870912UL,
			// Token: 0x04002222 RID: 8738
			MinimalUriInfoSet = 1073741824UL,
			// Token: 0x04002223 RID: 8739
			AllUriInfoSet = 2147483648UL,
			// Token: 0x04002224 RID: 8740
			IdnHost = 4294967296UL,
			// Token: 0x04002225 RID: 8741
			HasUnicode = 8589934592UL,
			// Token: 0x04002226 RID: 8742
			HostUnicodeNormalized = 17179869184UL,
			// Token: 0x04002227 RID: 8743
			RestUnicodeNormalized = 34359738368UL,
			// Token: 0x04002228 RID: 8744
			UnicodeHost = 68719476736UL,
			// Token: 0x04002229 RID: 8745
			IntranetUri = 137438953472UL,
			// Token: 0x0400222A RID: 8746
			UseOrigUncdStrOffset = 274877906944UL,
			// Token: 0x0400222B RID: 8747
			UserIriCanonical = 549755813888UL,
			// Token: 0x0400222C RID: 8748
			PathIriCanonical = 1099511627776UL,
			// Token: 0x0400222D RID: 8749
			QueryIriCanonical = 2199023255552UL,
			// Token: 0x0400222E RID: 8750
			FragmentIriCanonical = 4398046511104UL,
			// Token: 0x0400222F RID: 8751
			IriCanonical = 8246337208320UL,
			// Token: 0x04002230 RID: 8752
			CompressedSlashes = 17592186044416UL
		}

		// Token: 0x020002C2 RID: 706
		public class UriInfo : Object
		{
			// Token: 0x06002B56 RID: 11094 RVA: 0x000C049C File Offset: 0x000BE69C
			// Note: this type is marked as 'beforefieldinit'.
			static UriInfo()
			{
				Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr);
				Uri.UriInfo.NativeFieldInfoPtr_Host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "Host");
				Uri.UriInfo.NativeFieldInfoPtr_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "ScopeId");
				Uri.UriInfo.NativeFieldInfoPtr_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "String");
				Uri.UriInfo.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "Offset");
				Uri.UriInfo.NativeFieldInfoPtr_DnsSafeHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "DnsSafeHost");
				Uri.UriInfo.NativeFieldInfoPtr_MoreInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "MoreInfo");
				Uri.UriInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, 100664338);
			}

			// Token: 0x06002B57 RID: 11095 RVA: 0x000C0554 File Offset: 0x000BE754
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UriInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.UriInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B58 RID: 11096 RVA: 0x000136DF File Offset: 0x000118DF
			public UriInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D9A RID: 3482
			// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000C0590 File Offset: 0x000BE790
			// (set) Token: 0x06002B5A RID: 11098 RVA: 0x000136E8 File Offset: 0x000118E8
			public unsafe string Host
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Host);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Host), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D9B RID: 3483
			// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000C05B8 File Offset: 0x000BE7B8
			// (set) Token: 0x06002B5C RID: 11100 RVA: 0x00013707 File Offset: 0x00011907
			public unsafe string ScopeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_ScopeId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_ScopeId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D9C RID: 3484
			// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000C05E0 File Offset: 0x000BE7E0
			// (set) Token: 0x06002B5E RID: 11102 RVA: 0x00013726 File Offset: 0x00011926
			public unsafe string String
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_String);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_String), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D9D RID: 3485
			// (get) Token: 0x06002B5F RID: 11103 RVA: 0x000C0608 File Offset: 0x000BE808
			// (set) Token: 0x06002B60 RID: 11104 RVA: 0x00013745 File Offset: 0x00011945
			public unsafe Uri.Offset Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x17000D9E RID: 3486
			// (get) Token: 0x06002B61 RID: 11105 RVA: 0x000C0630 File Offset: 0x000BE830
			// (set) Token: 0x06002B62 RID: 11106 RVA: 0x00013760 File Offset: 0x00011960
			public unsafe string DnsSafeHost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_DnsSafeHost);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_DnsSafeHost), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D9F RID: 3487
			// (get) Token: 0x06002B63 RID: 11107 RVA: 0x000C0658 File Offset: 0x000BE858
			// (set) Token: 0x06002B64 RID: 11108 RVA: 0x0001377F File Offset: 0x0001197F
			public unsafe Uri.MoreInfo MoreInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_MoreInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri.MoreInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_MoreInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002231 RID: 8753
			private static readonly IntPtr NativeFieldInfoPtr_Host;

			// Token: 0x04002232 RID: 8754
			private static readonly IntPtr NativeFieldInfoPtr_ScopeId;

			// Token: 0x04002233 RID: 8755
			private static readonly IntPtr NativeFieldInfoPtr_String;

			// Token: 0x04002234 RID: 8756
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x04002235 RID: 8757
			private static readonly IntPtr NativeFieldInfoPtr_DnsSafeHost;

			// Token: 0x04002236 RID: 8758
			private static readonly IntPtr NativeFieldInfoPtr_MoreInfo;

			// Token: 0x04002237 RID: 8759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C3 RID: 707
		[StructLayout(2)]
		public struct Offset
		{
			// Token: 0x06002B65 RID: 11109 RVA: 0x000C0688 File Offset: 0x000BE888
			// Note: this type is marked as 'beforefieldinit'.
			static Offset()
			{
				Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "Offset");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr);
				Uri.Offset.NativeFieldInfoPtr_Scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Scheme");
				Uri.Offset.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "User");
				Uri.Offset.NativeFieldInfoPtr_Host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Host");
				Uri.Offset.NativeFieldInfoPtr_PortValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "PortValue");
				Uri.Offset.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Path");
				Uri.Offset.NativeFieldInfoPtr_Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Query");
				Uri.Offset.NativeFieldInfoPtr_Fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Fragment");
				Uri.Offset.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "End");
			}

			// Token: 0x06002B66 RID: 11110 RVA: 0x0001379E File Offset: 0x0001199E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, ref this));
			}

			// Token: 0x04002238 RID: 8760
			private static readonly IntPtr NativeFieldInfoPtr_Scheme;

			// Token: 0x04002239 RID: 8761
			private static readonly IntPtr NativeFieldInfoPtr_User;

			// Token: 0x0400223A RID: 8762
			private static readonly IntPtr NativeFieldInfoPtr_Host;

			// Token: 0x0400223B RID: 8763
			private static readonly IntPtr NativeFieldInfoPtr_PortValue;

			// Token: 0x0400223C RID: 8764
			private static readonly IntPtr NativeFieldInfoPtr_Path;

			// Token: 0x0400223D RID: 8765
			private static readonly IntPtr NativeFieldInfoPtr_Query;

			// Token: 0x0400223E RID: 8766
			private static readonly IntPtr NativeFieldInfoPtr_Fragment;

			// Token: 0x0400223F RID: 8767
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x04002240 RID: 8768
			[FieldOffset(0)]
			public ushort Scheme;

			// Token: 0x04002241 RID: 8769
			[FieldOffset(2)]
			public ushort User;

			// Token: 0x04002242 RID: 8770
			[FieldOffset(4)]
			public ushort Host;

			// Token: 0x04002243 RID: 8771
			[FieldOffset(6)]
			public ushort PortValue;

			// Token: 0x04002244 RID: 8772
			[FieldOffset(8)]
			public ushort Path;

			// Token: 0x04002245 RID: 8773
			[FieldOffset(10)]
			public ushort Query;

			// Token: 0x04002246 RID: 8774
			[FieldOffset(12)]
			public ushort Fragment;

			// Token: 0x04002247 RID: 8775
			[FieldOffset(14)]
			public ushort End;
		}

		// Token: 0x020002C4 RID: 708
		public class MoreInfo : Object
		{
			// Token: 0x06002B67 RID: 11111 RVA: 0x000C0754 File Offset: 0x000BE954
			// Note: this type is marked as 'beforefieldinit'.
			static MoreInfo()
			{
				Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "MoreInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr);
				Uri.MoreInfo.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Path");
				Uri.MoreInfo.NativeFieldInfoPtr_Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Query");
				Uri.MoreInfo.NativeFieldInfoPtr_Fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Fragment");
				Uri.MoreInfo.NativeFieldInfoPtr_AbsoluteUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "AbsoluteUri");
				Uri.MoreInfo.NativeFieldInfoPtr_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Hash");
				Uri.MoreInfo.NativeFieldInfoPtr_RemoteUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "RemoteUrl");
				Uri.MoreInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, 100664339);
			}

			// Token: 0x06002B68 RID: 11112 RVA: 0x000C080C File Offset: 0x000BEA0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MoreInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.MoreInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B69 RID: 11113 RVA: 0x000137B0 File Offset: 0x000119B0
			public MoreInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DA0 RID: 3488
			// (get) Token: 0x06002B6A RID: 11114 RVA: 0x000C0848 File Offset: 0x000BEA48
			// (set) Token: 0x06002B6B RID: 11115 RVA: 0x000137B9 File Offset: 0x000119B9
			public unsafe string Path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DA1 RID: 3489
			// (get) Token: 0x06002B6C RID: 11116 RVA: 0x000C0870 File Offset: 0x000BEA70
			// (set) Token: 0x06002B6D RID: 11117 RVA: 0x000137D8 File Offset: 0x000119D8
			public unsafe string Query
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Query);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Query), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DA2 RID: 3490
			// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000C0898 File Offset: 0x000BEA98
			// (set) Token: 0x06002B6F RID: 11119 RVA: 0x000137F7 File Offset: 0x000119F7
			public unsafe string Fragment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Fragment);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Fragment), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DA3 RID: 3491
			// (get) Token: 0x06002B70 RID: 11120 RVA: 0x000C08C0 File Offset: 0x000BEAC0
			// (set) Token: 0x06002B71 RID: 11121 RVA: 0x00013816 File Offset: 0x00011A16
			public unsafe string AbsoluteUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_AbsoluteUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_AbsoluteUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DA4 RID: 3492
			// (get) Token: 0x06002B72 RID: 11122 RVA: 0x000C08E8 File Offset: 0x000BEAE8
			// (set) Token: 0x06002B73 RID: 11123 RVA: 0x00013835 File Offset: 0x00011A35
			public unsafe int Hash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Hash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Hash)) = value;
				}
			}

			// Token: 0x17000DA5 RID: 3493
			// (get) Token: 0x06002B74 RID: 11124 RVA: 0x000C0910 File Offset: 0x000BEB10
			// (set) Token: 0x06002B75 RID: 11125 RVA: 0x00013850 File Offset: 0x00011A50
			public unsafe string RemoteUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_RemoteUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_RemoteUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002248 RID: 8776
			private static readonly IntPtr NativeFieldInfoPtr_Path;

			// Token: 0x04002249 RID: 8777
			private static readonly IntPtr NativeFieldInfoPtr_Query;

			// Token: 0x0400224A RID: 8778
			private static readonly IntPtr NativeFieldInfoPtr_Fragment;

			// Token: 0x0400224B RID: 8779
			private static readonly IntPtr NativeFieldInfoPtr_AbsoluteUri;

			// Token: 0x0400224C RID: 8780
			private static readonly IntPtr NativeFieldInfoPtr_Hash;

			// Token: 0x0400224D RID: 8781
			private static readonly IntPtr NativeFieldInfoPtr_RemoteUrl;

			// Token: 0x0400224E RID: 8782
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C5 RID: 709
		[Flags]
		public enum Check
		{
			// Token: 0x04002250 RID: 8784
			None = 0,
			// Token: 0x04002251 RID: 8785
			EscapedCanonical = 1,
			// Token: 0x04002252 RID: 8786
			DisplayCanonical = 2,
			// Token: 0x04002253 RID: 8787
			DotSlashAttn = 4,
			// Token: 0x04002254 RID: 8788
			DotSlashEscaped = 128,
			// Token: 0x04002255 RID: 8789
			BackslashInPath = 16,
			// Token: 0x04002256 RID: 8790
			ReservedFound = 32,
			// Token: 0x04002257 RID: 8791
			NotIriCanonical = 64,
			// Token: 0x04002258 RID: 8792
			FoundNonAscii = 8
		}
	}
}
