using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000088 RID: 136
	public class DtdParser : Object
	{
		// Token: 0x06000F82 RID: 3970 RVA: 0x00059E4C File Offset: 0x0005804C
		// Note: this type is marked as 'beforefieldinit'.
		static DtdParser()
		{
			Il2CppClassPointerStore<DtdParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "DtdParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdParser>.NativeClassPtr);
			DtdParser.NativeFieldInfoPtr_readerAdapter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "readerAdapter");
			DtdParser.NativeFieldInfoPtr_readerAdapterWithValidation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "readerAdapterWithValidation");
			DtdParser.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "nameTable");
			DtdParser.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "schemaInfo");
			DtdParser.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "xmlCharType");
			DtdParser.NativeFieldInfoPtr_systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "systemId");
			DtdParser.NativeFieldInfoPtr_publicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "publicId");
			DtdParser.NativeFieldInfoPtr_normalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "normalize");
			DtdParser.NativeFieldInfoPtr_validate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "validate");
			DtdParser.NativeFieldInfoPtr_supportNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "supportNamespaces");
			DtdParser.NativeFieldInfoPtr_v1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "v1Compat");
			DtdParser.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "chars");
			DtdParser.NativeFieldInfoPtr_charsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "charsUsed");
			DtdParser.NativeFieldInfoPtr_curPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "curPos");
			DtdParser.NativeFieldInfoPtr_scanningFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "scanningFunction");
			DtdParser.NativeFieldInfoPtr_nextScaningFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "nextScaningFunction");
			DtdParser.NativeFieldInfoPtr_savedScanningFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "savedScanningFunction");
			DtdParser.NativeFieldInfoPtr_whitespaceSeen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "whitespaceSeen");
			DtdParser.NativeFieldInfoPtr_tokenStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "tokenStartPos");
			DtdParser.NativeFieldInfoPtr_colonPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "colonPos");
			DtdParser.NativeFieldInfoPtr_internalSubsetValueSb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "internalSubsetValueSb");
			DtdParser.NativeFieldInfoPtr_externalEntitiesDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "externalEntitiesDepth");
			DtdParser.NativeFieldInfoPtr_currentEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "currentEntityId");
			DtdParser.NativeFieldInfoPtr_freeFloatingDtd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "freeFloatingDtd");
			DtdParser.NativeFieldInfoPtr_hasFreeFloatingInternalSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "hasFreeFloatingInternalSubset");
			DtdParser.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "stringBuilder");
			DtdParser.NativeFieldInfoPtr_condSectionDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "condSectionDepth");
			DtdParser.NativeFieldInfoPtr_literalLineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "literalLineInfo");
			DtdParser.NativeFieldInfoPtr_literalQuoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "literalQuoteChar");
			DtdParser.NativeFieldInfoPtr_documentBaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "documentBaseUri");
			DtdParser.NativeFieldInfoPtr_externalDtdBaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "externalDtdBaseUri");
			DtdParser.NativeFieldInfoPtr_undeclaredNotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "undeclaredNotations");
			DtdParser.NativeFieldInfoPtr_condSectionEntityIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "condSectionEntityIds");
			DtdParser.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665846);
			DtdParser.NativeMethodInfoPtr_Create_Internal_Static_IDtdParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665847);
			DtdParser.NativeMethodInfoPtr_Initialize_Private_Void_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665848);
			DtdParser.NativeMethodInfoPtr_InitializeFreeFloatingDtd_Private_Void_String_String_String_String_String_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665849);
			DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseInternalDtd_Private_Virtual_Final_New_IDtdInfo_IDtdParserAdapter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665850);
			DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseFreeFloatingDtd_Private_Virtual_Final_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665851);
			DtdParser.NativeMethodInfoPtr_get_ParsingInternalSubset_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665852);
			DtdParser.NativeMethodInfoPtr_get_IgnoreEntityReferences_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665853);
			DtdParser.NativeMethodInfoPtr_get_SaveInternalSubsetValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665854);
			DtdParser.NativeMethodInfoPtr_get_ParsingTopLevelMarkup_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665855);
			DtdParser.NativeMethodInfoPtr_get_SupportNamespaces_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665856);
			DtdParser.NativeMethodInfoPtr_get_Normalize_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665857);
			DtdParser.NativeMethodInfoPtr_Parse_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665858);
			DtdParser.NativeMethodInfoPtr_ParseInDocumentDtd_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665859);
			DtdParser.NativeMethodInfoPtr_ParseFreeFloatingDtd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665860);
			DtdParser.NativeMethodInfoPtr_ParseInternalSubset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665861);
			DtdParser.NativeMethodInfoPtr_ParseExternalSubset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665862);
			DtdParser.NativeMethodInfoPtr_ParseSubset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665863);
			DtdParser.NativeMethodInfoPtr_ParseAttlistDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665864);
			DtdParser.NativeMethodInfoPtr_ParseAttlistType_Private_Void_SchemaAttDef_SchemaElementDecl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665865);
			DtdParser.NativeMethodInfoPtr_ParseAttlistDefault_Private_Void_SchemaAttDef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665866);
			DtdParser.NativeMethodInfoPtr_ParseElementDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665867);
			DtdParser.NativeMethodInfoPtr_ParseElementOnlyContent_Private_Void_ParticleContentValidator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665868);
			DtdParser.NativeMethodInfoPtr_ParseHowMany_Private_Void_ParticleContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665869);
			DtdParser.NativeMethodInfoPtr_ParseElementMixedContent_Private_Void_ParticleContentValidator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665870);
			DtdParser.NativeMethodInfoPtr_ParseEntityDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665871);
			DtdParser.NativeMethodInfoPtr_ParseNotationDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665872);
			DtdParser.NativeMethodInfoPtr_AddUndeclaredNotation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665873);
			DtdParser.NativeMethodInfoPtr_ParseComment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665874);
			DtdParser.NativeMethodInfoPtr_ParsePI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665875);
			DtdParser.NativeMethodInfoPtr_ParseCondSection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665876);
			DtdParser.NativeMethodInfoPtr_ParseExternalId_Private_Void_Token_Token_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665877);
			DtdParser.NativeMethodInfoPtr_GetToken_Private_Token_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665878);
			DtdParser.NativeMethodInfoPtr_ScanSubsetContent_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665879);
			DtdParser.NativeMethodInfoPtr_ScanNameExpected_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665880);
			DtdParser.NativeMethodInfoPtr_ScanQNameExpected_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665881);
			DtdParser.NativeMethodInfoPtr_ScanNmtokenExpected_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665882);
			DtdParser.NativeMethodInfoPtr_ScanDoctype1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665883);
			DtdParser.NativeMethodInfoPtr_ScanDoctype2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665884);
			DtdParser.NativeMethodInfoPtr_ScanClosingTag_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665885);
			DtdParser.NativeMethodInfoPtr_ScanElement1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665886);
			DtdParser.NativeMethodInfoPtr_ScanElement2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665887);
			DtdParser.NativeMethodInfoPtr_ScanElement3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665888);
			DtdParser.NativeMethodInfoPtr_ScanElement4_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665889);
			DtdParser.NativeMethodInfoPtr_ScanElement5_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665890);
			DtdParser.NativeMethodInfoPtr_ScanElement6_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665891);
			DtdParser.NativeMethodInfoPtr_ScanElement7_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665892);
			DtdParser.NativeMethodInfoPtr_ScanAttlist1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665893);
			DtdParser.NativeMethodInfoPtr_ScanAttlist2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665894);
			DtdParser.NativeMethodInfoPtr_ScanAttlist3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665895);
			DtdParser.NativeMethodInfoPtr_ScanAttlist4_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665896);
			DtdParser.NativeMethodInfoPtr_ScanAttlist5_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665897);
			DtdParser.NativeMethodInfoPtr_ScanAttlist6_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665898);
			DtdParser.NativeMethodInfoPtr_ScanAttlist7_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665899);
			DtdParser.NativeMethodInfoPtr_ScanLiteral_Private_Token_LiteralType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665900);
			DtdParser.NativeMethodInfoPtr_ScanEntityName_Private_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665901);
			DtdParser.NativeMethodInfoPtr_ScanNotation1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665902);
			DtdParser.NativeMethodInfoPtr_ScanSystemId_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665903);
			DtdParser.NativeMethodInfoPtr_ScanEntity1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665904);
			DtdParser.NativeMethodInfoPtr_ScanEntity2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665905);
			DtdParser.NativeMethodInfoPtr_ScanEntity3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665906);
			DtdParser.NativeMethodInfoPtr_ScanPublicId1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665907);
			DtdParser.NativeMethodInfoPtr_ScanPublicId2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665908);
			DtdParser.NativeMethodInfoPtr_ScanCondSection1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665909);
			DtdParser.NativeMethodInfoPtr_ScanCondSection2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665910);
			DtdParser.NativeMethodInfoPtr_ScanCondSection3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665911);
			DtdParser.NativeMethodInfoPtr_ScanName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665912);
			DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665913);
			DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665914);
			DtdParser.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665915);
			DtdParser.NativeMethodInfoPtr_ScanNmtoken_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665916);
			DtdParser.NativeMethodInfoPtr_EatPublicKeyword_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665917);
			DtdParser.NativeMethodInfoPtr_EatSystemKeyword_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665918);
			DtdParser.NativeMethodInfoPtr_GetNameQualified_Private_XmlQualifiedName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665919);
			DtdParser.NativeMethodInfoPtr_GetNameString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665920);
			DtdParser.NativeMethodInfoPtr_GetNmtokenString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665921);
			DtdParser.NativeMethodInfoPtr_GetValue_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665922);
			DtdParser.NativeMethodInfoPtr_GetValueWithStrippedSpaces_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665923);
			DtdParser.NativeMethodInfoPtr_ReadData_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665924);
			DtdParser.NativeMethodInfoPtr_LoadParsingBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665925);
			DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665926);
			DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665927);
			DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665928);
			DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_XmlQualifiedName_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665929);
			DtdParser.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665930);
			DtdParser.NativeMethodInfoPtr_VerifyEntityReference_Private_SchemaEntity_XmlQualifiedName_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665931);
			DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_Int32_XmlSeverityType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665932);
			DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665933);
			DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665934);
			DtdParser.NativeMethodInfoPtr_IsAttributeValueType_Private_Boolean_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665935);
			DtdParser.NativeMethodInfoPtr_get_LineNo_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665936);
			DtdParser.NativeMethodInfoPtr_get_LinePos_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665937);
			DtdParser.NativeMethodInfoPtr_get_BaseUriStr_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665938);
			DtdParser.NativeMethodInfoPtr_OnUnexpectedError_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665939);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665940);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665941);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665942);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665943);
			DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665944);
			DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665945);
			DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665946);
			DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665947);
			DtdParser.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665948);
			DtdParser.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100665949);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0005A930 File Offset: 0x00058B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378277, XrefRangeEnd = 378289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0005A96C File Offset: 0x00058B6C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 378304, RefRangeEnd = 378310, XrefRangeStart = 378289, XrefRangeEnd = 378304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDtdParser Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Create_Internal_Static_IDtdParser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdParser>(intPtr3) : null;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0005A9A0 File Offset: 0x00058BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 378351, RefRangeEnd = 378353, XrefRangeStart = 378310, XrefRangeEnd = 378351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(IDtdParserAdapter readerAdapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(readerAdapter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Initialize_Private_Void_IDtdParserAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0005A9E4 File Offset: 0x00058BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378386, RefRangeEnd = 378387, XrefRangeStart = 378353, XrefRangeEnd = 378386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_InitializeFreeFloatingDtd_Private_Void_String_String_String_String_String_IDtdParserAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0005AA84 File Offset: 0x00058C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378387, XrefRangeEnd = 378389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdInfo System_Xml_IDtdParser_ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveInternalSubset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseInternalDtd_Private_Virtual_Final_New_IDtdInfo_IDtdParserAdapter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0005AAE4 File Offset: 0x00058CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378389, XrefRangeEnd = 378391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdInfo System_Xml_IDtdParser_ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseFreeFloatingDtd_Private_Virtual_Final_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x0005AB94 File Offset: 0x00058D94
		public unsafe bool ParsingInternalSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_ParsingInternalSubset_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0005ABD0 File Offset: 0x00058DD0
		public unsafe bool IgnoreEntityReferences
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_IgnoreEntityReferences_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x0005AC0C File Offset: 0x00058E0C
		public unsafe bool SaveInternalSubsetValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378391, XrefRangeEnd = 378394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_SaveInternalSubsetValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0005AC48 File Offset: 0x00058E48
		public unsafe bool ParsingTopLevelMarkup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_ParsingTopLevelMarkup_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x0005AC84 File Offset: 0x00058E84
		public unsafe bool SupportNamespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_SupportNamespaces_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0005ACC0 File Offset: 0x00058EC0
		public unsafe bool Normalize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_Normalize_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0005ACFC File Offset: 0x00058EFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 378441, RefRangeEnd = 378443, XrefRangeStart = 378394, XrefRangeEnd = 378441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref saveInternalSubset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Parse_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0005AD3C File Offset: 0x00058F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378443, XrefRangeEnd = 378462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseInDocumentDtd(bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref saveInternalSubset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseInDocumentDtd_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0005AD7C File Offset: 0x00058F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378462, XrefRangeEnd = 378466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseFreeFloatingDtd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseFreeFloatingDtd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0005ADB0 File Offset: 0x00058FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378466, XrefRangeEnd = 378467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseInternalSubset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseInternalSubset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0005ADE4 File Offset: 0x00058FE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 378479, RefRangeEnd = 378482, XrefRangeStart = 378467, XrefRangeEnd = 378479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseExternalSubset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseExternalSubset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0005AE18 File Offset: 0x00059018
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 378573, RefRangeEnd = 378578, XrefRangeStart = 378482, XrefRangeEnd = 378573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSubset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseSubset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0005AE4C File Offset: 0x0005904C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378654, RefRangeEnd = 378655, XrefRangeStart = 378578, XrefRangeEnd = 378654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttlistDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseAttlistDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0005AE80 File Offset: 0x00059080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378689, RefRangeEnd = 378690, XrefRangeStart = 378655, XrefRangeEnd = 378689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrDef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementDecl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseAttlistType_Private_Void_SchemaAttDef_SchemaElementDecl_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0005AEE4 File Offset: 0x000590E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378710, RefRangeEnd = 378711, XrefRangeStart = 378690, XrefRangeEnd = 378710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrDef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseAttlistDefault_Private_Void_SchemaAttDef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0005AF34 File Offset: 0x00059134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378768, RefRangeEnd = 378769, XrefRangeStart = 378711, XrefRangeEnd = 378768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElementDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseElementDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0005AF68 File Offset: 0x00059168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378846, RefRangeEnd = 378847, XrefRangeStart = 378769, XrefRangeEnd = 378846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcv);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startParenEntityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseElementOnlyContent_Private_Void_ParticleContentValidator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0005AFB8 File Offset: 0x000591B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378847, XrefRangeEnd = 378849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseHowMany(ParticleContentValidator pcv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcv);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseHowMany_Private_Void_ParticleContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0005AFFC File Offset: 0x000591FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378882, RefRangeEnd = 378883, XrefRangeStart = 378849, XrefRangeEnd = 378882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcv);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startParenEntityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseElementMixedContent_Private_Void_ParticleContentValidator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0005B04C File Offset: 0x0005924C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378932, RefRangeEnd = 378933, XrefRangeStart = 378883, XrefRangeEnd = 378932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseEntityDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseEntityDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0005B080 File Offset: 0x00059280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378963, RefRangeEnd = 378964, XrefRangeStart = 378933, XrefRangeEnd = 378963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseNotationDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseNotationDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0005B0B4 File Offset: 0x000592B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378987, RefRangeEnd = 378988, XrefRangeStart = 378964, XrefRangeEnd = 378987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUndeclaredNotation(string notationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(notationName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_AddUndeclaredNotation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0005B0F8 File Offset: 0x000592F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379014, RefRangeEnd = 379015, XrefRangeStart = 378988, XrefRangeEnd = 379014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseComment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0005B12C File Offset: 0x0005932C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379015, XrefRangeEnd = 379030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParsePI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParsePI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0005B160 File Offset: 0x00059360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379042, RefRangeEnd = 379043, XrefRangeStart = 379030, XrefRangeEnd = 379042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseCondSection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseCondSection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0005B194 File Offset: 0x00059394
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 379075, RefRangeEnd = 379079, XrefRangeStart = 379043, XrefRangeEnd = 379075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idTokenType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseExternalId_Private_Void_Token_Token_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			publicId = IL2CPP.Il2CppStringToManaged(intPtr);
			systemId = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0005B218 File Offset: 0x00059418
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 379128, RefRangeEnd = 379173, XrefRangeStart = 379079, XrefRangeEnd = 379128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token GetToken(bool needWhiteSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needWhiteSpace;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetToken_Private_Token_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0005B264 File Offset: 0x00059464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379178, RefRangeEnd = 379179, XrefRangeStart = 379173, XrefRangeEnd = 379178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanSubsetContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanSubsetContent_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0005B2A0 File Offset: 0x000594A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379179, XrefRangeEnd = 379180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanNameExpected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNameExpected_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0005B2DC File Offset: 0x000594DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379180, XrefRangeEnd = 379181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanQNameExpected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanQNameExpected_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0005B318 File Offset: 0x00059518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379181, XrefRangeEnd = 379182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanNmtokenExpected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNmtokenExpected_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0005B354 File Offset: 0x00059554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379182, XrefRangeEnd = 379186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanDoctype1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanDoctype1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0005B390 File Offset: 0x00059590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379186, XrefRangeEnd = 379187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanDoctype2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanDoctype2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x0005B3CC File Offset: 0x000595CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379187, XrefRangeEnd = 379190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanClosingTag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanClosingTag_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x0005B408 File Offset: 0x00059608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379190, XrefRangeEnd = 379192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0005B444 File Offset: 0x00059644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379192, XrefRangeEnd = 379201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0005B480 File Offset: 0x00059680
		[CallerCount(0)]
		public unsafe DtdParser.Token ScanElement3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0005B4BC File Offset: 0x000596BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379201, XrefRangeEnd = 379208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement4_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0005B4F8 File Offset: 0x000596F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379208, XrefRangeEnd = 379209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement5_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0005B534 File Offset: 0x00059734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379209, XrefRangeEnd = 379211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement6_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0005B570 File Offset: 0x00059770
		[CallerCount(0)]
		public unsafe DtdParser.Token ScanElement7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement7_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0005B5AC File Offset: 0x000597AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379211, XrefRangeEnd = 379216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0005B5E8 File Offset: 0x000597E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379216, XrefRangeEnd = 379224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0005B624 File Offset: 0x00059824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379224, XrefRangeEnd = 379227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0005B660 File Offset: 0x00059860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379227, XrefRangeEnd = 379229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist4_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0005B69C File Offset: 0x0005989C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379229, XrefRangeEnd = 379231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist5_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0005B6D8 File Offset: 0x000598D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379231, XrefRangeEnd = 379235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist6_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0005B714 File Offset: 0x00059914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379235, XrefRangeEnd = 379240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist7_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0005B750 File Offset: 0x00059950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379265, RefRangeEnd = 379267, XrefRangeStart = 379240, XrefRangeEnd = 379265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref literalType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanLiteral_Private_Token_LiteralType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0005B79C File Offset: 0x0005999C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379276, RefRangeEnd = 379278, XrefRangeStart = 379267, XrefRangeEnd = 379276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName ScanEntityName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntityName_Private_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0005B7DC File Offset: 0x000599DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379278, XrefRangeEnd = 379283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanNotation1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNotation1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0005B818 File Offset: 0x00059A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379283, XrefRangeEnd = 379289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanSystemId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanSystemId_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0005B854 File Offset: 0x00059A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379289, XrefRangeEnd = 379290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanEntity1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntity1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0005B890 File Offset: 0x00059A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379290, XrefRangeEnd = 379295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanEntity2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntity2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0005B8CC File Offset: 0x00059ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379295, XrefRangeEnd = 379296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanEntity3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntity3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0005B908 File Offset: 0x00059B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379296, XrefRangeEnd = 379302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanPublicId1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanPublicId1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0005B944 File Offset: 0x00059B44
		[CallerCount(0)]
		public unsafe DtdParser.Token ScanPublicId2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanPublicId2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0005B980 File Offset: 0x00059B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379302, XrefRangeEnd = 379319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanCondSection1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanCondSection1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0005B9BC File Offset: 0x00059BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379319, XrefRangeEnd = 379322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanCondSection2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanCondSection2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0005B9F8 File Offset: 0x00059BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379322, XrefRangeEnd = 379353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanCondSection3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanCondSection3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0005BA34 File Offset: 0x00059C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379353, XrefRangeEnd = 379354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0005BA68 File Offset: 0x00059C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379354, XrefRangeEnd = 379355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanQName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0005BA9C File Offset: 0x00059C9C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 379372, RefRangeEnd = 379381, XrefRangeStart = 379355, XrefRangeEnd = 379372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanQName(bool isQName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isQName;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0005BADC File Offset: 0x00059CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379381, XrefRangeEnd = 379382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadDataInName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0005BB18 File Offset: 0x00059D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379395, RefRangeEnd = 379396, XrefRangeStart = 379382, XrefRangeEnd = 379395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanNmtoken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNmtoken_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0005BB4C File Offset: 0x00059D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379397, RefRangeEnd = 379399, XrefRangeStart = 379396, XrefRangeEnd = 379397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EatPublicKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_EatPublicKeyword_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0005BB88 File Offset: 0x00059D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379400, RefRangeEnd = 379401, XrefRangeStart = 379399, XrefRangeEnd = 379400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EatSystemKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_EatSystemKeyword_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0005BBC4 File Offset: 0x00059DC4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 379406, RefRangeEnd = 379417, XrefRangeStart = 379401, XrefRangeEnd = 379406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName GetNameQualified(bool canHavePrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canHavePrefix;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetNameQualified_Private_XmlQualifiedName_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0005BC10 File Offset: 0x00059E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379417, XrefRangeEnd = 379418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNameString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetNameString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0005BC48 File Offset: 0x00059E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNmtokenString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetNmtokenString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0005BC80 File Offset: 0x00059E80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 379420, RefRangeEnd = 379424, XrefRangeStart = 379418, XrefRangeEnd = 379420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetValue_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0005BCB8 File Offset: 0x00059EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379424, XrefRangeEnd = 379429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetValueWithStrippedSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetValueWithStrippedSpaces_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0005BCF0 File Offset: 0x00059EF0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 379434, RefRangeEnd = 379440, XrefRangeStart = 379429, XrefRangeEnd = 379434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ReadData_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0005BD2C File Offset: 0x00059F2C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 379448, RefRangeEnd = 379465, XrefRangeStart = 379440, XrefRangeEnd = 379448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadParsingBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_LoadParsingBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0005BD60 File Offset: 0x00059F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379465, XrefRangeEnd = 379466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveParsingBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0005BD94 File Offset: 0x00059F94
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 379476, RefRangeEnd = 379493, XrefRangeStart = 379466, XrefRangeEnd = 379476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveParsingBuffer(int internalSubsetValueEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref internalSubsetValueEndPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0005BDD4 File Offset: 0x00059FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379493, XrefRangeEnd = 379495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref paramEntity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLiteral;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0005BE3C File Offset: 0x0005A03C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379508, RefRangeEnd = 379510, XrefRangeStart = 379495, XrefRangeEnd = 379508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramEntity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLiteral;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_XmlQualifiedName_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0005BEB4 File Offset: 0x0005A0B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379518, RefRangeEnd = 379520, XrefRangeStart = 379510, XrefRangeEnd = 379518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityEnd(bool inLiteral)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLiteral;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0005BF00 File Offset: 0x0005A100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379535, RefRangeEnd = 379536, XrefRangeStart = 379520, XrefRangeEnd = 379535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramEntity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustBeDeclared;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_VerifyEntityReference_Private_SchemaEntity_XmlQualifiedName_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaEntity>(intPtr3) : null;
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0005BF7C File Offset: 0x0005A17C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 379549, RefRangeEnd = 379560, XrefRangeStart = 379536, XrefRangeEnd = 379549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_Int32_XmlSeverityType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0005BFF0 File Offset: 0x0005A1F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379573, RefRangeEnd = 379575, XrefRangeStart = 379560, XrefRangeEnd = 379573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, string code, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0005C054 File Offset: 0x0005A254
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 379581, RefRangeEnd = 379585, XrefRangeStart = 379575, XrefRangeEnd = 379581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0005C0A4 File Offset: 0x0005A2A4
		[CallerCount(0)]
		public unsafe bool IsAttributeValueType(DtdParser.Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_IsAttributeValueType_Private_Boolean_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0005C0F0 File Offset: 0x0005A2F0
		public unsafe int LineNo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379585, XrefRangeEnd = 379589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_LineNo_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0005C12C File Offset: 0x0005A32C
		public unsafe int LinePos
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379589, XrefRangeEnd = 379592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_LinePos_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0005C168 File Offset: 0x0005A368
		public unsafe string BaseUriStr
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 379601, RefRangeEnd = 379606, XrefRangeStart = 379592, XrefRangeEnd = 379601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_BaseUriStr_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0005C1A0 File Offset: 0x0005A3A0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 379611, RefRangeEnd = 379621, XrefRangeStart = 379606, XrefRangeEnd = 379611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUnexpectedError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_OnUnexpectedError_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0005C1D4 File Offset: 0x0005A3D4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 379624, RefRangeEnd = 379635, XrefRangeStart = 379621, XrefRangeEnd = 379624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int curPos, string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0005C224 File Offset: 0x0005A424
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 379656, RefRangeEnd = 379681, XrefRangeStart = 379635, XrefRangeEnd = 379656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int curPos, string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0005C288 File Offset: 0x0005A488
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 379702, RefRangeEnd = 379709, XrefRangeStart = 379681, XrefRangeEnd = 379702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int curPos, string res, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0005C2EC File Offset: 0x0005A4EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 379724, RefRangeEnd = 379728, XrefRangeStart = 379709, XrefRangeEnd = 379724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, string arg, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0005C35C File Offset: 0x0005A55C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 379732, RefRangeEnd = 379735, XrefRangeStart = 379728, XrefRangeEnd = 379732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInvalidChar(int pos, string data, int invCharPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0005C3BC File Offset: 0x0005A5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379735, XrefRangeEnd = 379739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInvalidChar(Il2CppStructArray<char> data, int length, int invCharPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0005C41C File Offset: 0x0005A61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379739, XrefRangeEnd = 379740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(int pos, string expectedToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0005C46C File Offset: 0x0005A66C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 379750, RefRangeEnd = 379763, XrefRangeStart = 379740, XrefRangeEnd = 379750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0005C4D0 File Offset: 0x0005A6D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 379765, RefRangeEnd = 379768, XrefRangeStart = 379763, XrefRangeEnd = 379765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseUnexpectedToken(int startPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0005C514 File Offset: 0x0005A714
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 379783, RefRangeEnd = 379786, XrefRangeStart = 379768, XrefRangeEnd = 379783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripSpaces(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0000709B File Offset: 0x0000529B
		public DtdParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0005C550 File Offset: 0x0005A750
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x000070A4 File Offset: 0x000052A4
		public unsafe IDtdParserAdapter readerAdapter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdParserAdapter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0005C580 File Offset: 0x0005A780
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x000070C3 File Offset: 0x000052C3
		public unsafe IDtdParserAdapterWithValidation readerAdapterWithValidation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapterWithValidation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdParserAdapterWithValidation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapterWithValidation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0005C5B0 File Offset: 0x0005A7B0
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x000070E2 File Offset: 0x000052E2
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0005C5E0 File Offset: 0x0005A7E0
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00007101 File Offset: 0x00005301
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0005C610 File Offset: 0x0005A810
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00007120 File Offset: 0x00005320
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0005C640 File Offset: 0x0005A840
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x0000714E File Offset: 0x0000534E
		public unsafe string systemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_systemId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_systemId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0005C668 File Offset: 0x0005A868
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x0000716D File Offset: 0x0000536D
		public unsafe string publicId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_publicId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_publicId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x0005C690 File Offset: 0x0005A890
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x0000718C File Offset: 0x0000538C
		public unsafe bool normalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_normalize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_normalize)) = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x0005C6B8 File Offset: 0x0005A8B8
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x000071A7 File Offset: 0x000053A7
		public unsafe bool validate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_validate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_validate)) = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0005C6E0 File Offset: 0x0005A8E0
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x000071C2 File Offset: 0x000053C2
		public unsafe bool supportNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_supportNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_supportNamespaces)) = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0005C708 File Offset: 0x0005A908
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x000071DD File Offset: 0x000053DD
		public unsafe bool v1Compat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_v1Compat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_v1Compat)) = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x0005C730 File Offset: 0x0005A930
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x000071F8 File Offset: 0x000053F8
		public unsafe Il2CppStructArray<char> chars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_chars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x0005C760 File Offset: 0x0005A960
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x00007217 File Offset: 0x00005417
		public unsafe int charsUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_charsUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_charsUsed)) = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x0005C788 File Offset: 0x0005A988
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x00007232 File Offset: 0x00005432
		public unsafe int curPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_curPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_curPos)) = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x0005C7B0 File Offset: 0x0005A9B0
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x0000724D File Offset: 0x0000544D
		public unsafe DtdParser.ScanningFunction scanningFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_scanningFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_scanningFunction)) = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x0005C7D8 File Offset: 0x0005A9D8
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x00007268 File Offset: 0x00005468
		public unsafe DtdParser.ScanningFunction nextScaningFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nextScaningFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nextScaningFunction)) = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x0005C800 File Offset: 0x0005AA00
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x00007283 File Offset: 0x00005483
		public unsafe DtdParser.ScanningFunction savedScanningFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_savedScanningFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_savedScanningFunction)) = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x0005C828 File Offset: 0x0005AA28
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x0000729E File Offset: 0x0000549E
		public unsafe bool whitespaceSeen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_whitespaceSeen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_whitespaceSeen)) = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0005C850 File Offset: 0x0005AA50
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x000072B9 File Offset: 0x000054B9
		public unsafe int tokenStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_tokenStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_tokenStartPos)) = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0005C878 File Offset: 0x0005AA78
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x000072D4 File Offset: 0x000054D4
		public unsafe int colonPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_colonPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_colonPos)) = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0005C8A0 File Offset: 0x0005AAA0
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x000072EF File Offset: 0x000054EF
		public unsafe StringBuilder internalSubsetValueSb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_internalSubsetValueSb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_internalSubsetValueSb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0005C8D0 File Offset: 0x0005AAD0
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x0000730E File Offset: 0x0000550E
		public unsafe int externalEntitiesDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalEntitiesDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalEntitiesDepth)) = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0005C8F8 File Offset: 0x0005AAF8
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x00007329 File Offset: 0x00005529
		public unsafe int currentEntityId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_currentEntityId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_currentEntityId)) = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0005C920 File Offset: 0x0005AB20
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x00007344 File Offset: 0x00005544
		public unsafe bool freeFloatingDtd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_freeFloatingDtd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_freeFloatingDtd)) = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0005C948 File Offset: 0x0005AB48
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x0000735F File Offset: 0x0000555F
		public unsafe bool hasFreeFloatingInternalSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_hasFreeFloatingInternalSubset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_hasFreeFloatingInternalSubset)) = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0005C970 File Offset: 0x0005AB70
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x0000737A File Offset: 0x0000557A
		public unsafe StringBuilder stringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_stringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0005C9A0 File Offset: 0x0005ABA0
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x00007399 File Offset: 0x00005599
		public unsafe int condSectionDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionDepth)) = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0005C9C8 File Offset: 0x0005ABC8
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x000073B4 File Offset: 0x000055B4
		public unsafe LineInfo literalLineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalLineInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalLineInfo)) = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x0005C9F0 File Offset: 0x0005ABF0
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x000073CF File Offset: 0x000055CF
		public unsafe char literalQuoteChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalQuoteChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalQuoteChar)) = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x0005CA18 File Offset: 0x0005AC18
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x000073EA File Offset: 0x000055EA
		public unsafe string documentBaseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_documentBaseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_documentBaseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0005CA40 File Offset: 0x0005AC40
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x00007409 File Offset: 0x00005609
		public unsafe string externalDtdBaseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalDtdBaseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalDtdBaseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x0005CA68 File Offset: 0x0005AC68
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x00007428 File Offset: 0x00005628
		public unsafe Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_undeclaredNotations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DtdParser.UndeclaredNotation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_undeclaredNotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x0005CA98 File Offset: 0x0005AC98
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00007447 File Offset: 0x00005647
		public unsafe Il2CppStructArray<int> condSectionEntityIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionEntityIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionEntityIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeFieldInfoPtr_readerAdapter;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeFieldInfoPtr_readerAdapterWithValidation;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeFieldInfoPtr_systemId;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeFieldInfoPtr_publicId;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeFieldInfoPtr_normalize;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeFieldInfoPtr_validate;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeFieldInfoPtr_supportNamespaces;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeFieldInfoPtr_v1Compat;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr_chars;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_charsUsed;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeFieldInfoPtr_curPos;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeFieldInfoPtr_scanningFunction;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeFieldInfoPtr_nextScaningFunction;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeFieldInfoPtr_savedScanningFunction;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeFieldInfoPtr_whitespaceSeen;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeFieldInfoPtr_tokenStartPos;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeFieldInfoPtr_colonPos;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeFieldInfoPtr_internalSubsetValueSb;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeFieldInfoPtr_externalEntitiesDepth;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeFieldInfoPtr_currentEntityId;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeFieldInfoPtr_freeFloatingDtd;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeFieldInfoPtr_hasFreeFloatingInternalSubset;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeFieldInfoPtr_condSectionDepth;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeFieldInfoPtr_literalLineInfo;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeFieldInfoPtr_literalQuoteChar;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeFieldInfoPtr_documentBaseUri;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeFieldInfoPtr_externalDtdBaseUri;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeFieldInfoPtr_undeclaredNotations;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeFieldInfoPtr_condSectionEntityIds;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_IDtdParser_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_IDtdParserAdapter_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFreeFloatingDtd_Private_Void_String_String_String_String_String_IDtdParserAdapter_0;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParser_ParseInternalDtd_Private_Virtual_Final_New_IDtdInfo_IDtdParserAdapter_Boolean_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParser_ParseFreeFloatingDtd_Private_Virtual_Final_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingInternalSubset_Private_get_Boolean_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreEntityReferences_Private_get_Boolean_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveInternalSubsetValue_Private_get_Boolean_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingTopLevelMarkup_Private_get_Boolean_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportNamespaces_Private_get_Boolean_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_get_Normalize_Private_get_Boolean_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Void_Boolean_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_ParseInDocumentDtd_Private_Void_Boolean_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_ParseFreeFloatingDtd_Private_Void_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_ParseInternalSubset_Private_Void_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_ParseExternalSubset_Private_Void_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_ParseSubset_Private_Void_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttlistDecl_Private_Void_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttlistType_Private_Void_SchemaAttDef_SchemaElementDecl_Boolean_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttlistDefault_Private_Void_SchemaAttDef_Boolean_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementDecl_Private_Void_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementOnlyContent_Private_Void_ParticleContentValidator_Int32_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_ParseHowMany_Private_Void_ParticleContentValidator_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementMixedContent_Private_Void_ParticleContentValidator_Int32_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_ParseEntityDecl_Private_Void_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_ParseNotationDecl_Private_Void_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_AddUndeclaredNotation_Private_Void_String_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_ParseComment_Private_Void_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Private_Void_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_ParseCondSection_Private_Void_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_ParseExternalId_Private_Void_Token_Token_byref_String_byref_String_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_GetToken_Private_Token_Boolean_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_ScanSubsetContent_Private_Token_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_ScanNameExpected_Private_Token_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_ScanQNameExpected_Private_Token_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_ScanNmtokenExpected_Private_Token_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_ScanDoctype1_Private_Token_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_ScanDoctype2_Private_Token_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_ScanClosingTag_Private_Token_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement1_Private_Token_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement2_Private_Token_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement3_Private_Token_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement4_Private_Token_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement5_Private_Token_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement6_Private_Token_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement7_Private_Token_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist1_Private_Token_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist2_Private_Token_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist3_Private_Token_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist4_Private_Token_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist5_Private_Token_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist6_Private_Token_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist7_Private_Token_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_ScanLiteral_Private_Token_LiteralType_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntityName_Private_XmlQualifiedName_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_ScanNotation1_Private_Token_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_ScanSystemId_Private_Token_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntity1_Private_Token_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntity2_Private_Token_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntity3_Private_Token_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_ScanPublicId1_Private_Token_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_ScanPublicId2_Private_Token_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_ScanCondSection1_Private_Token_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_ScanCondSection2_Private_Token_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_ScanCondSection3_Private_Token_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_ScanName_Private_Void_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_ScanQName_Private_Void_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_ScanQName_Private_Void_Boolean_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_ReadDataInName_Private_Boolean_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_ScanNmtoken_Private_Void_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_EatPublicKeyword_Private_Boolean_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_EatSystemKeyword_Private_Boolean_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_GetNameQualified_Private_XmlQualifiedName_Boolean_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_GetNameString_Private_String_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_GetNmtokenString_Private_String_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Private_String_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_GetValueWithStrippedSpaces_Private_String_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Private_Int32_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_LoadParsingBuffer_Private_Void_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_Int32_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_XmlQualifiedName_Boolean_Boolean_Boolean_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_VerifyEntityReference_Private_SchemaEntity_XmlQualifiedName_Boolean_Boolean_Boolean_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_Int32_XmlSeverityType_String_String_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_IsAttributeValueType_Private_Boolean_Token_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Private_get_Int32_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePos_Private_get_Int32_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUriStr_Private_get_String_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_OnUnexpectedError_Private_Void_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Int32_String_Int32_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0;

		// Token: 0x0200023F RID: 575
		public enum Token
		{
			// Token: 0x04002564 RID: 9572
			CDATA,
			// Token: 0x04002565 RID: 9573
			ID,
			// Token: 0x04002566 RID: 9574
			IDREF,
			// Token: 0x04002567 RID: 9575
			IDREFS,
			// Token: 0x04002568 RID: 9576
			ENTITY,
			// Token: 0x04002569 RID: 9577
			ENTITIES,
			// Token: 0x0400256A RID: 9578
			NMTOKEN,
			// Token: 0x0400256B RID: 9579
			NMTOKENS,
			// Token: 0x0400256C RID: 9580
			NOTATION,
			// Token: 0x0400256D RID: 9581
			None,
			// Token: 0x0400256E RID: 9582
			PERef,
			// Token: 0x0400256F RID: 9583
			AttlistDecl,
			// Token: 0x04002570 RID: 9584
			ElementDecl,
			// Token: 0x04002571 RID: 9585
			EntityDecl,
			// Token: 0x04002572 RID: 9586
			NotationDecl,
			// Token: 0x04002573 RID: 9587
			Comment,
			// Token: 0x04002574 RID: 9588
			PI,
			// Token: 0x04002575 RID: 9589
			CondSectionStart,
			// Token: 0x04002576 RID: 9590
			CondSectionEnd,
			// Token: 0x04002577 RID: 9591
			Eof,
			// Token: 0x04002578 RID: 9592
			REQUIRED,
			// Token: 0x04002579 RID: 9593
			IMPLIED,
			// Token: 0x0400257A RID: 9594
			FIXED,
			// Token: 0x0400257B RID: 9595
			QName,
			// Token: 0x0400257C RID: 9596
			Name,
			// Token: 0x0400257D RID: 9597
			Nmtoken,
			// Token: 0x0400257E RID: 9598
			Quote,
			// Token: 0x0400257F RID: 9599
			LeftParen,
			// Token: 0x04002580 RID: 9600
			RightParen,
			// Token: 0x04002581 RID: 9601
			GreaterThan,
			// Token: 0x04002582 RID: 9602
			Or,
			// Token: 0x04002583 RID: 9603
			LeftBracket,
			// Token: 0x04002584 RID: 9604
			RightBracket,
			// Token: 0x04002585 RID: 9605
			PUBLIC,
			// Token: 0x04002586 RID: 9606
			SYSTEM,
			// Token: 0x04002587 RID: 9607
			Literal,
			// Token: 0x04002588 RID: 9608
			DOCTYPE,
			// Token: 0x04002589 RID: 9609
			NData,
			// Token: 0x0400258A RID: 9610
			Percent,
			// Token: 0x0400258B RID: 9611
			Star,
			// Token: 0x0400258C RID: 9612
			QMark,
			// Token: 0x0400258D RID: 9613
			Plus,
			// Token: 0x0400258E RID: 9614
			PCDATA,
			// Token: 0x0400258F RID: 9615
			Comma,
			// Token: 0x04002590 RID: 9616
			ANY,
			// Token: 0x04002591 RID: 9617
			EMPTY,
			// Token: 0x04002592 RID: 9618
			IGNORE,
			// Token: 0x04002593 RID: 9619
			INCLUDE
		}

		// Token: 0x02000240 RID: 576
		public enum ScanningFunction
		{
			// Token: 0x04002595 RID: 9621
			SubsetContent,
			// Token: 0x04002596 RID: 9622
			Name,
			// Token: 0x04002597 RID: 9623
			QName,
			// Token: 0x04002598 RID: 9624
			Nmtoken,
			// Token: 0x04002599 RID: 9625
			Doctype1,
			// Token: 0x0400259A RID: 9626
			Doctype2,
			// Token: 0x0400259B RID: 9627
			Element1,
			// Token: 0x0400259C RID: 9628
			Element2,
			// Token: 0x0400259D RID: 9629
			Element3,
			// Token: 0x0400259E RID: 9630
			Element4,
			// Token: 0x0400259F RID: 9631
			Element5,
			// Token: 0x040025A0 RID: 9632
			Element6,
			// Token: 0x040025A1 RID: 9633
			Element7,
			// Token: 0x040025A2 RID: 9634
			Attlist1,
			// Token: 0x040025A3 RID: 9635
			Attlist2,
			// Token: 0x040025A4 RID: 9636
			Attlist3,
			// Token: 0x040025A5 RID: 9637
			Attlist4,
			// Token: 0x040025A6 RID: 9638
			Attlist5,
			// Token: 0x040025A7 RID: 9639
			Attlist6,
			// Token: 0x040025A8 RID: 9640
			Attlist7,
			// Token: 0x040025A9 RID: 9641
			Entity1,
			// Token: 0x040025AA RID: 9642
			Entity2,
			// Token: 0x040025AB RID: 9643
			Entity3,
			// Token: 0x040025AC RID: 9644
			Notation1,
			// Token: 0x040025AD RID: 9645
			CondSection1,
			// Token: 0x040025AE RID: 9646
			CondSection2,
			// Token: 0x040025AF RID: 9647
			CondSection3,
			// Token: 0x040025B0 RID: 9648
			Literal,
			// Token: 0x040025B1 RID: 9649
			SystemId,
			// Token: 0x040025B2 RID: 9650
			PublicId1,
			// Token: 0x040025B3 RID: 9651
			PublicId2,
			// Token: 0x040025B4 RID: 9652
			ClosingTag,
			// Token: 0x040025B5 RID: 9653
			ParamEntitySpace,
			// Token: 0x040025B6 RID: 9654
			None
		}

		// Token: 0x02000241 RID: 577
		public enum LiteralType
		{
			// Token: 0x040025B8 RID: 9656
			AttributeValue,
			// Token: 0x040025B9 RID: 9657
			EntityReplText,
			// Token: 0x040025BA RID: 9658
			SystemOrPublicID
		}

		// Token: 0x02000242 RID: 578
		public class UndeclaredNotation : Object
		{
			// Token: 0x0600307A RID: 12410 RVA: 0x000DA74C File Offset: 0x000D894C
			// Note: this type is marked as 'beforefieldinit'.
			static UndeclaredNotation()
			{
				Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "UndeclaredNotation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr);
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "name");
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_lineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "lineNo");
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "linePos");
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "next");
				DtdParser.UndeclaredNotation.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, 100665950);
			}

			// Token: 0x0600307B RID: 12411 RVA: 0x000DA7DC File Offset: 0x000D89DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 378273, RefRangeEnd = 378274, XrefRangeStart = 378270, XrefRangeEnd = 378273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UndeclaredNotation(string name, int lineNo, int linePos)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.UndeclaredNotation.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600307C RID: 12412 RVA: 0x0001450A File Offset: 0x0001270A
			public UndeclaredNotation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700104F RID: 4175
			// (get) Token: 0x0600307D RID: 12413 RVA: 0x000DA844 File Offset: 0x000D8A44
			// (set) Token: 0x0600307E RID: 12414 RVA: 0x00014513 File Offset: 0x00012713
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001050 RID: 4176
			// (get) Token: 0x0600307F RID: 12415 RVA: 0x000DA86C File Offset: 0x000D8A6C
			// (set) Token: 0x06003080 RID: 12416 RVA: 0x00014532 File Offset: 0x00012732
			public unsafe int lineNo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_lineNo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_lineNo)) = value;
				}
			}

			// Token: 0x17001051 RID: 4177
			// (get) Token: 0x06003081 RID: 12417 RVA: 0x000DA894 File Offset: 0x000D8A94
			// (set) Token: 0x06003082 RID: 12418 RVA: 0x0001454D File Offset: 0x0001274D
			public unsafe int linePos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_linePos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_linePos)) = value;
				}
			}

			// Token: 0x17001052 RID: 4178
			// (get) Token: 0x06003083 RID: 12419 RVA: 0x000DA8BC File Offset: 0x000D8ABC
			// (set) Token: 0x06003084 RID: 12420 RVA: 0x00014568 File Offset: 0x00012768
			public unsafe DtdParser.UndeclaredNotation next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DtdParser.UndeclaredNotation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040025BB RID: 9659
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040025BC RID: 9660
			private static readonly IntPtr NativeFieldInfoPtr_lineNo;

			// Token: 0x040025BD RID: 9661
			private static readonly IntPtr NativeFieldInfoPtr_linePos;

			// Token: 0x040025BE RID: 9662
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x040025BF RID: 9663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0;
		}

		// Token: 0x02000243 RID: 579
		public class ParseElementOnlyContent_LocalFrame : Object
		{
			// Token: 0x06003085 RID: 12421 RVA: 0x000DA8EC File Offset: 0x000D8AEC
			// Note: this type is marked as 'beforefieldinit'.
			static ParseElementOnlyContent_LocalFrame()
			{
				Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "ParseElementOnlyContent_LocalFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr);
				DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_startParenEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr, "startParenEntityId");
				DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_parsingSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr, "parsingSchema");
				DtdParser.ParseElementOnlyContent_LocalFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr, 100665951);
			}

			// Token: 0x06003086 RID: 12422 RVA: 0x000DA954 File Offset: 0x000D8B54
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 378275, RefRangeEnd = 378277, XrefRangeStart = 378274, XrefRangeEnd = 378275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref startParentEntityIdParam;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.ParseElementOnlyContent_LocalFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003087 RID: 12423 RVA: 0x00014587 File Offset: 0x00012787
			public ParseElementOnlyContent_LocalFrame(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001053 RID: 4179
			// (get) Token: 0x06003088 RID: 12424 RVA: 0x000DA99C File Offset: 0x000D8B9C
			// (set) Token: 0x06003089 RID: 12425 RVA: 0x00014590 File Offset: 0x00012790
			public unsafe int startParenEntityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_startParenEntityId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_startParenEntityId)) = value;
				}
			}

			// Token: 0x17001054 RID: 4180
			// (get) Token: 0x0600308A RID: 12426 RVA: 0x000DA9C4 File Offset: 0x000D8BC4
			// (set) Token: 0x0600308B RID: 12427 RVA: 0x000145AB File Offset: 0x000127AB
			public unsafe DtdParser.Token parsingSchema
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_parsingSchema);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_parsingSchema)) = value;
				}
			}

			// Token: 0x040025C0 RID: 9664
			private static readonly IntPtr NativeFieldInfoPtr_startParenEntityId;

			// Token: 0x040025C1 RID: 9665
			private static readonly IntPtr NativeFieldInfoPtr_parsingSchema;

			// Token: 0x040025C2 RID: 9666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
