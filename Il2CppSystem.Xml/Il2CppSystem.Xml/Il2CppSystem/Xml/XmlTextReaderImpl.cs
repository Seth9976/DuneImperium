using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200004B RID: 75
	public class XmlTextReaderImpl : XmlReader
	{
		// Token: 0x06000653 RID: 1619 RVA: 0x00031864 File Offset: 0x0002FA64
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextReaderImpl()
		{
			Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlTextReaderImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr);
			XmlTextReaderImpl.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "useAsync");
			XmlTextReaderImpl.NativeFieldInfoPtr_laterInitParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "laterInitParam");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlCharType");
			XmlTextReaderImpl.NativeFieldInfoPtr_ps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ps");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingFunction");
			XmlTextReaderImpl.NativeFieldInfoPtr_nextParsingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nextParsingFunction");
			XmlTextReaderImpl.NativeFieldInfoPtr_nextNextParsingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nextNextParsingFunction");
			XmlTextReaderImpl.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nodes");
			XmlTextReaderImpl.NativeFieldInfoPtr_curNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "curNode");
			XmlTextReaderImpl.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "index");
			XmlTextReaderImpl.NativeFieldInfoPtr_curAttrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "curAttrIndex");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrCount");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrHashtable");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplWalkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrDuplWalkCount");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrNeedNamespaceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrNeedNamespaceLookup");
			XmlTextReaderImpl.NativeFieldInfoPtr_fullAttrCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fullAttrCleanup");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplSortingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrDuplSortingArray");
			XmlTextReaderImpl.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nameTable");
			XmlTextReaderImpl.NativeFieldInfoPtr_nameTableFromSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nameTableFromSettings");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlResolver");
			XmlTextReaderImpl.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "url");
			XmlTextReaderImpl.NativeFieldInfoPtr_normalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "normalize");
			XmlTextReaderImpl.NativeFieldInfoPtr_supportNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "supportNamespaces");
			XmlTextReaderImpl.NativeFieldInfoPtr_whitespaceHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "whitespaceHandling");
			XmlTextReaderImpl.NativeFieldInfoPtr_dtdProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "dtdProcessing");
			XmlTextReaderImpl.NativeFieldInfoPtr_entityHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "entityHandling");
			XmlTextReaderImpl.NativeFieldInfoPtr_ignorePIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ignorePIs");
			XmlTextReaderImpl.NativeFieldInfoPtr_ignoreComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ignoreComments");
			XmlTextReaderImpl.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "checkCharacters");
			XmlTextReaderImpl.NativeFieldInfoPtr_lineNumberOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "lineNumberOffset");
			XmlTextReaderImpl.NativeFieldInfoPtr_linePositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "linePositionOffset");
			XmlTextReaderImpl.NativeFieldInfoPtr_closeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "closeInput");
			XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersInDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "maxCharactersInDocument");
			XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersFromEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "maxCharactersFromEntities");
			XmlTextReaderImpl.NativeFieldInfoPtr_v1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "v1Compat");
			XmlTextReaderImpl.NativeFieldInfoPtr_namespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "namespaceManager");
			XmlTextReaderImpl.NativeFieldInfoPtr_lastPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "lastPrefix");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlContext");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingStatesStack");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStackTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingStatesStackTop");
			XmlTextReaderImpl.NativeFieldInfoPtr_reportedBaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "reportedBaseUri");
			XmlTextReaderImpl.NativeFieldInfoPtr_reportedEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "reportedEncoding");
			XmlTextReaderImpl.NativeFieldInfoPtr_dtdInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "dtdInfo");
			XmlTextReaderImpl.NativeFieldInfoPtr_fragmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fragmentType");
			XmlTextReaderImpl.NativeFieldInfoPtr_fragmentParserContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fragmentParserContext");
			XmlTextReaderImpl.NativeFieldInfoPtr_fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fragment");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadDecoder");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadState");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadLineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadLineInfo");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadDepth");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadLeftStartPos");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftEndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadLeftEndPos");
			XmlTextReaderImpl.NativeFieldInfoPtr_attributeValueBaseEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attributeValueBaseEntityId");
			XmlTextReaderImpl.NativeFieldInfoPtr_emptyEntityInAttributeResolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "emptyEntityInAttributeResolved");
			XmlTextReaderImpl.NativeFieldInfoPtr_validationEventHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "validationEventHandling");
			XmlTextReaderImpl.NativeFieldInfoPtr_onDefaultAttributeUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "onDefaultAttributeUse");
			XmlTextReaderImpl.NativeFieldInfoPtr_validatingReaderCompatFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "validatingReaderCompatFlag");
			XmlTextReaderImpl.NativeFieldInfoPtr_addDefaultAttributesAndNormalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "addDefaultAttributesAndNormalize");
			XmlTextReaderImpl.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "stringBuilder");
			XmlTextReaderImpl.NativeFieldInfoPtr_rootElementParsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "rootElementParsed");
			XmlTextReaderImpl.NativeFieldInfoPtr_standalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "standalone");
			XmlTextReaderImpl.NativeFieldInfoPtr_nextEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nextEntityId");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingMode");
			XmlTextReaderImpl.NativeFieldInfoPtr_readState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "readState");
			XmlTextReaderImpl.NativeFieldInfoPtr_lastEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "lastEntity");
			XmlTextReaderImpl.NativeFieldInfoPtr_afterResetState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "afterResetState");
			XmlTextReaderImpl.NativeFieldInfoPtr_documentStartBytePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "documentStartBytePos");
			XmlTextReaderImpl.NativeFieldInfoPtr_readValueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "readValueOffset");
			XmlTextReaderImpl.NativeFieldInfoPtr_charactersInDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "charactersInDocument");
			XmlTextReaderImpl.NativeFieldInfoPtr_charactersFromEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "charactersFromEntities");
			XmlTextReaderImpl.NativeFieldInfoPtr_currentEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "currentEntities");
			XmlTextReaderImpl.NativeFieldInfoPtr_disableUndeclaredEntityCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "disableUndeclaredEntityCheck");
			XmlTextReaderImpl.NativeFieldInfoPtr_outerReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "outerReader");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolverIsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlResolverIsSet");
			XmlTextReaderImpl.NativeFieldInfoPtr_Xml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "Xml");
			XmlTextReaderImpl.NativeFieldInfoPtr_XmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "XmlNs");
			XmlTextReaderImpl.NativeFieldInfoPtr_parseText_dummyTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parseText_dummyTask");
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664295);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Private_Void_XmlResolver_XmlReaderSettings_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664296);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664297);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_Stream_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664298);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664299);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664300);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_TextReader_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664301);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlNodeType_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664302);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664303);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitUriString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664304);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Il2CppStructArray_1_Byte_Int32_XmlReaderSettings_Uri_String_XmlParserContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664305);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitStream_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664306);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlReaderSettings_String_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664307);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitTextReader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664308);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664309);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664310);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664311);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664312);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664313);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664314);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664315);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664316);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664317);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664318);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664319);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664320);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664321);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664322);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664323);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664324);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664325);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664326);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664327);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664328);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664329);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664330);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664331);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664332);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664333);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664334);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664335);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664336);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664337);
			XmlTextReaderImpl.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664338);
			XmlTextReaderImpl.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664339);
			XmlTextReaderImpl.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664340);
			XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664341);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664342);
			XmlTextReaderImpl.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664343);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_OuterReader_Internal_set_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664344);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveOffEntityReference_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664345);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664346);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_CanReadValueChunk_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664347);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadValueChunk_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664348);
			XmlTextReaderImpl.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664349);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664350);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664351);
			XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664352);
			XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664353);
			XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664354);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664355);
			XmlTextReaderImpl.NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664356);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Namespaces_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664357);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664358);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Normalization_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664359);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_Normalization_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664360);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_WhitespaceHandling_Internal_set_Void_WhitespaceHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664361);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_EntityHandling_Internal_set_Void_EntityHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664362);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsResolverSet_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664363);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664364);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NameTable_Internal_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664365);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NamespaceResolver_Internal_get_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664366);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_DtdValidation_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664367);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Normalization_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664368);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Namespaces_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664369);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_V1CompatibilityMode_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664370);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_BaseUri_Internal_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664371);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEof_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664372);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBuffer_Internal_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664373);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBufferLength_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664374);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_CurrentPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664375);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_DtdParserProxy_CurrentPosition_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664376);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_EntityStackLength_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664377);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEntityEolNormalized_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664378);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ValidationEventHandling_Internal_get_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664379);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnNewLine_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664380);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineNo_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664381);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineStartPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664382);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ReadData_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664383);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNumericCharRef_Internal_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664384);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNamedCharRef_Internal_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664385);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParsePI_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664386);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseComment_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664387);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsResolverNull_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664388);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetTempResolver_Private_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664389);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushEntity_Internal_Boolean_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664390);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PopEntity_Internal_Boolean_byref_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664391);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushExternalSubset_Internal_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664392);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushInternalDtd_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664393);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_Throw_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664394);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnSystemId_Internal_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664395);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnPublicId_Internal_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664396);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664397);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664398);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664399);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664400);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664401);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664402);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664403);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664404);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664405);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664406);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664407);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReThrow_Private_Void_Exception_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664408);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664409);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664410);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_Il2CppStringArray_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664411);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664412);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetErrorState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664413);
			XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664414);
			XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664415);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_InAttributeValueIterator_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664416);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishAttributeValueIterator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664417);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdValidation_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664418);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664419);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_String_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664420);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664421);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664422);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Il2CppStructArray_1_Byte_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664423);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664424);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_Uri_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664425);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStringInput_Private_Void_String_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664426);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitFragmentReader_Private_Void_XmlNodeType_XmlParserContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664427);
			XmlTextReaderImpl.NativeMethodInfoPtr_ProcessDtdFromParserContext_Private_Void_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664428);
			XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664429);
			XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrlDelegate_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664430);
			XmlTextReaderImpl.NativeMethodInfoPtr_DetectEncoding_Private_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664431);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupEncoding_Private_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664432);
			XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncoding_Private_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664433);
			XmlTextReaderImpl.NativeMethodInfoPtr_CheckEncoding_Private_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664434);
			XmlTextReaderImpl.NativeMethodInfoPtr_UnDecodeChars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664435);
			XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncodingToUTF8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664436);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadData_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664437);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetChars_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664438);
			XmlTextReaderImpl.NativeMethodInfoPtr_InvalidCharRecovery_Private_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664439);
			XmlTextReaderImpl.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664440);
			XmlTextReaderImpl.NativeMethodInfoPtr_ShiftBuffer_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664441);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclaration_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664442);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDocumentContent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664443);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseElementContent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664444);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnclosedElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664445);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664446);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributesAndNormalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664447);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664448);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowTagMismatch_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664449);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664450);
			XmlTextReaderImpl.NativeMethodInfoPtr_ElementNamespaceLookup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664451);
			XmlTextReaderImpl.NativeMethodInfoPtr_AttributeNamespaceLookup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664452);
			XmlTextReaderImpl.NativeMethodInfoPtr_AttributeDuplCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664453);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnDefaultNamespaceDecl_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664454);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnNamespaceDecl_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664455);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnXmlReservedAttribute_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664456);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueSlow_Private_Void_Int32_Char_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664457);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeChunkToList_Private_Void_NodeData_NodeData_byref_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664458);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664459);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664460);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishPartialValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664461);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishOtherValueIterator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664462);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipPartialTextValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664463);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadValueChunk_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664464);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadContentAsBinary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664465);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadElementContentAsBinary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664466);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseRootLevelWhitespace_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664467);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityReference_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664468);
			XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityReference_Private_EntityType_Boolean_EntityExpandType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664469);
			XmlTextReaderImpl.NativeMethodInfoPtr_HandleGeneralEntityReference_Private_EntityType_String_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664470);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_InEntity_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664471);
			XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664472);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664473);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664474);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664475);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664476);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParsePIValue_Private_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664477);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseComment_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664478);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664479);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664480);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Boolean_XmlNodeType_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664481);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDoctypeDecl_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664482);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664483);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipDtd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664484);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipPublicOrSystemIdLiteral_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664485);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipUntil_Private_Void_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664486);
			XmlTextReaderImpl.NativeMethodInfoPtr_EatWhitespaces_Private_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664487);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCharRefInline_Private_Int32_Int32_byref_Int32_byref_EntityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664488);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRef_Private_Int32_Boolean_StringBuilder_byref_EntityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664489);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_byref_Int32_byref_EntityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664490);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRef_Private_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664491);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664492);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseName_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664493);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664494);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664495);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664496);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664497);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddNode_Private_NodeData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664498);
			XmlTextReaderImpl.NativeMethodInfoPtr_AllocNode_Private_NodeData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664499);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeNoChecks_Private_NodeData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664500);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664501);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664502);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopElementContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664503);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664504);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnEof_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664505);
			XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Private_String_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664506);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664507);
			XmlTextReaderImpl.NativeMethodInfoPtr_ResetAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664508);
			XmlTextReaderImpl.NativeMethodInfoPtr_FullAttributeCleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664509);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushXmlContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664510);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopXmlContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664511);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetWhitespaceType_Private_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664512);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetTextNodeType_Private_XmlNodeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664513);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntityOrSubset_Private_Void_String_String_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664514);
			XmlTextReaderImpl.NativeMethodInfoPtr_OpenAndPush_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664515);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntity_Private_Boolean_IDtdEntityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664516);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushInternalEntity_Private_Void_IDtdEntityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664517);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopEntity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664518);
			XmlTextReaderImpl.NativeMethodInfoPtr_RegisterEntity_Private_Void_IDtdEntityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664519);
			XmlTextReaderImpl.NativeMethodInfoPtr_UnregisterEntity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664520);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushParsingState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664521);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopParsingState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664522);
			XmlTextReaderImpl.NativeMethodInfoPtr_IncrementalRead_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664523);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishIncrementalRead_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664524);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseFragmentAttribute_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664525);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueChunk_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664526);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclarationFragment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664527);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664528);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664529);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664530);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664531);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664532);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664533);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowExpectingWhitespace_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664534);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithoutPrefix_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664535);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithPrefix_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664536);
			XmlTextReaderImpl.NativeMethodInfoPtr_ZeroEndingStream_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664537);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664538);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664539);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupFromParserContext_Private_Void_XmlParserContext_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664540);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664541);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetDtdInfo_Internal_Void_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664542);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_ValidationEventHandling_Internal_set_Void_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664543);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_OnDefaultAttributeUse_Internal_set_Void_OnDefaultAttributeUseDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664544);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664545);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_FragmentType_Internal_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664546);
			XmlTextReaderImpl.NativeMethodInfoPtr_ChangeCurrentNodeType_Internal_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664547);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664548);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_InternalSchemaType_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664549);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_InternalTypedValue_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664550);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_InternalTypedValue_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664551);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_StandAlone_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664552);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NamespaceManager_Internal_Virtual_get_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664553);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_V1Compat_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664554);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeDtd_Private_Boolean_IDtdDefaultAttributeInfo_Boolean_Il2CppReferenceArray_1_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664555);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeNonDtd_Internal_Boolean_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664556);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeInternal_Private_NodeData_String_String_String_String_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664557);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_DisableUndeclaredEntityCheck_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664558);
			XmlTextReaderImpl.NativeMethodInfoPtr_UriEqual_Private_Boolean_Uri_String_String_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664559);
			XmlTextReaderImpl.NativeMethodInfoPtr_RegisterConsumedCharacters_Private_Void_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664560);
			XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664561);
			XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664562);
			XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopyChars_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664563);
			XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100664564);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000333B0 File Offset: 0x000315B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 367678, RefRangeEnd = 367683, XrefRangeStart = 367617, XrefRangeEnd = 367678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000333FC File Offset: 0x000315FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 367754, RefRangeEnd = 367757, XrefRangeStart = 367683, XrefRangeEnd = 367754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Private_Void_XmlResolver_XmlReaderSettings_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0003346C File Offset: 0x0003166C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367774, RefRangeEnd = 367775, XrefRangeStart = 367757, XrefRangeEnd = 367774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(Stream input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000334B8 File Offset: 0x000316B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367786, RefRangeEnd = 367787, XrefRangeStart = 367775, XrefRangeEnd = 367786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string url, Stream input, XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_Stream_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00033528 File Offset: 0x00031728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367794, RefRangeEnd = 367795, XrefRangeStart = 367787, XrefRangeEnd = 367794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(TextReader input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00033574 File Offset: 0x00031774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367798, RefRangeEnd = 367799, XrefRangeStart = 367795, XrefRangeEnd = 367798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(TextReader input, XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000335D4 File Offset: 0x000317D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 367810, RefRangeEnd = 367812, XrefRangeStart = 367799, XrefRangeEnd = 367810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_TextReader_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00033644 File Offset: 0x00031844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 367826, RefRangeEnd = 367828, XrefRangeStart = 367812, XrefRangeEnd = 367826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fragType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlNodeType_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000336B0 File Offset: 0x000318B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367839, RefRangeEnd = 367840, XrefRangeStart = 367828, XrefRangeEnd = 367839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string xmlFragment, XmlParserContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00033710 File Offset: 0x00031910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367885, RefRangeEnd = 367886, XrefRangeStart = 367840, XrefRangeEnd = 367885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitUriString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitUriString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00033744 File Offset: 0x00031944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 367904, RefRangeEnd = 367907, XrefRangeStart = 367886, XrefRangeEnd = 367904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(Stream stream, Il2CppStructArray<byte> bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closeInput;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Il2CppStructArray_1_Byte_Int32_XmlReaderSettings_Uri_String_XmlParserContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0003380C File Offset: 0x00031A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367914, RefRangeEnd = 367915, XrefRangeStart = 367907, XrefRangeEnd = 367914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitStream_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00033840 File Offset: 0x00031A40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 367924, RefRangeEnd = 367926, XrefRangeStart = 367915, XrefRangeEnd = 367924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlReaderSettings_String_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000338C4 File Offset: 0x00031AC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 367932, RefRangeEnd = 367934, XrefRangeStart = 367926, XrefRangeEnd = 367932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitTextReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitTextReader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000338F8 File Offset: 0x00031AF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367941, RefRangeEnd = 367942, XrefRangeStart = 367934, XrefRangeEnd = 367941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string xmlFragment, XmlParserContext context, XmlReaderSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00033968 File Offset: 0x00031B68
		public unsafe override XmlReaderSettings Settings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367942, XrefRangeEnd = 367961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x000339B4 File Offset: 0x00031BB4
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x000339FC File Offset: 0x00031BFC
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367961, XrefRangeEnd = 367963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00033A40 File Offset: 0x00031C40
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00033A84 File Offset: 0x00031C84
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00033AC8 File Offset: 0x00031CC8
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00033B0C File Offset: 0x00031D0C
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367963, XrefRangeEnd = 367978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00033B50 File Offset: 0x00031D50
		public unsafe override int Depth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00033B98 File Offset: 0x00031D98
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00033BDC File Offset: 0x00031DDC
		public unsafe override bool IsEmptyElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367978, XrefRangeEnd = 367980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00033C24 File Offset: 0x00031E24
		public unsafe override bool IsDefault
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367980, XrefRangeEnd = 367982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00033C6C File Offset: 0x00031E6C
		public unsafe override char QuoteChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00033CB4 File Offset: 0x00031EB4
		public unsafe override XmlSpace XmlSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00033CFC File Offset: 0x00031EFC
		public unsafe override string XmlLang
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00033D40 File Offset: 0x00031F40
		public unsafe override ReadState ReadState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00033D88 File Offset: 0x00031F88
		public unsafe override bool EOF
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00033DD0 File Offset: 0x00031FD0
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00033E1C File Offset: 0x0003201C
		public unsafe override bool CanResolveEntity
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00033E64 File Offset: 0x00032064
		public unsafe override int AttributeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00033EAC File Offset: 0x000320AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367982, XrefRangeEnd = 367987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00033F00 File Offset: 0x00032100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367987, XrefRangeEnd = 367992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00033F68 File Offset: 0x00032168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367992, XrefRangeEnd = 368001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00033FB8 File Offset: 0x000321B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368001, XrefRangeEnd = 368005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00034010 File Offset: 0x00032210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368005, XrefRangeEnd = 368015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveToAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0003405C File Offset: 0x0003225C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368015, XrefRangeEnd = 368017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000340A4 File Offset: 0x000322A4
		[CallerCount(0)]
		public unsafe override bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x000340EC File Offset: 0x000322EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368017, XrefRangeEnd = 368019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00034134 File Offset: 0x00032334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368019, XrefRangeEnd = 368020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00034168 File Offset: 0x00032368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368020, XrefRangeEnd = 368096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000341B0 File Offset: 0x000323B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368096, XrefRangeEnd = 368105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000341EC File Offset: 0x000323EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368105, XrefRangeEnd = 368117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00034228 File Offset: 0x00032428
		[CallerCount(0)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0003427C File Offset: 0x0003247C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368117, XrefRangeEnd = 368122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadAttributeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000342C4 File Offset: 0x000324C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368122, XrefRangeEnd = 368132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResolveEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000241 RID: 577
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00034300 File Offset: 0x00032500
		public unsafe XmlReader OuterReader
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368132, XrefRangeEnd = 368133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_OuterReader_Internal_set_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00034344 File Offset: 0x00032544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368133, RefRangeEnd = 368134, XrefRangeStart = 368133, XrefRangeEnd = 368133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveOffEntityReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_MoveOffEntityReference_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00034378 File Offset: 0x00032578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368134, XrefRangeEnd = 368143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_ReadString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x000343BC File Offset: 0x000325BC
		public unsafe override bool CanReadValueChunk
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_CanReadValueChunk_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00034404 File Offset: 0x00032604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368143, XrefRangeEnd = 368158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ReadValueChunk(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_ReadValueChunk_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00034478 File Offset: 0x00032678
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x000344B4 File Offset: 0x000326B4
		public unsafe virtual int LineNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368160, RefRangeEnd = 368161, XrefRangeStart = 368158, XrefRangeEnd = 368160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x000344F0 File Offset: 0x000326F0
		public unsafe virtual int LinePosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368163, RefRangeEnd = 368164, XrefRangeStart = 368161, XrefRangeEnd = 368163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0003452C File Offset: 0x0003272C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368165, RefRangeEnd = 368166, XrefRangeStart = 368164, XrefRangeEnd = 368165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary<string, string> System_Xml_IXmlNamespaceResolver_GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00034578 File Offset: 0x00032778
		[CallerCount(0)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000345C0 File Offset: 0x000327C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368167, RefRangeEnd = 368168, XrefRangeStart = 368166, XrefRangeEnd = 368167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00034608 File Offset: 0x00032808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368165, RefRangeEnd = 368166, XrefRangeStart = 368165, XrefRangeEnd = 368166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00034654 File Offset: 0x00032854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368167, RefRangeEnd = 368168, XrefRangeStart = 368167, XrefRangeEnd = 368168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0003469C File Offset: 0x0003289C
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x000346D8 File Offset: 0x000328D8
		public unsafe bool Namespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_Namespaces_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 368193, RefRangeEnd = 368195, XrefRangeStart = 368168, XrefRangeEnd = 368193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00034718 File Offset: 0x00032918
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00034754 File Offset: 0x00032954
		public unsafe bool Normalization
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_Normalization_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368198, RefRangeEnd = 368199, XrefRangeStart = 368195, XrefRangeEnd = 368198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_Normalization_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000247 RID: 583
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00034794 File Offset: 0x00032994
		public unsafe WhitespaceHandling WhitespaceHandling
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368199, RefRangeEnd = 368200, XrefRangeStart = 368199, XrefRangeEnd = 368199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_WhitespaceHandling_Internal_set_Void_WhitespaceHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000248 RID: 584
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x000347D4 File Offset: 0x000329D4
		public unsafe EntityHandling EntityHandling
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368200, RefRangeEnd = 368201, XrefRangeStart = 368200, XrefRangeEnd = 368200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_EntityHandling_Internal_set_Void_EntityHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00034814 File Offset: 0x00032A14
		public unsafe bool IsResolverSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_IsResolverSet_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024A RID: 586
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x00034850 File Offset: 0x00032A50
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 368204, RefRangeEnd = 368207, XrefRangeStart = 368201, XrefRangeEnd = 368204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00034894 File Offset: 0x00032A94
		public unsafe XmlNameTable DtdParserProxy_NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NameTable_Internal_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x000348D4 File Offset: 0x00032AD4
		public unsafe IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NamespaceResolver_Internal_get_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr3) : null;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00034914 File Offset: 0x00032B14
		public unsafe bool DtdParserProxy_DtdValidation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368207, RefRangeEnd = 368208, XrefRangeStart = 368207, XrefRangeEnd = 368207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_DtdValidation_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00034950 File Offset: 0x00032B50
		public unsafe bool DtdParserProxy_Normalization
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Normalization_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0003498C File Offset: 0x00032B8C
		public unsafe bool DtdParserProxy_Namespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Namespaces_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x000349C8 File Offset: 0x00032BC8
		public unsafe bool DtdParserProxy_V1CompatibilityMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_V1CompatibilityMode_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00034A04 File Offset: 0x00032C04
		public unsafe Uri DtdParserProxy_BaseUri
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368213, RefRangeEnd = 368214, XrefRangeStart = 368208, XrefRangeEnd = 368213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_BaseUri_Internal_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00034A44 File Offset: 0x00032C44
		public unsafe bool DtdParserProxy_IsEof
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 311955, RefRangeEnd = 311956, XrefRangeStart = 311955, XrefRangeEnd = 311956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEof_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00034A80 File Offset: 0x00032C80
		public unsafe Il2CppStructArray<char> DtdParserProxy_ParsingBuffer
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBuffer_Internal_get_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00034AC0 File Offset: 0x00032CC0
		public unsafe int DtdParserProxy_ParsingBufferLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBufferLength_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00034AFC File Offset: 0x00032CFC
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00034B38 File Offset: 0x00032D38
		public unsafe int DtdParserProxy_CurrentPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_CurrentPosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_DtdParserProxy_CurrentPosition_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00034B78 File Offset: 0x00032D78
		public unsafe int DtdParserProxy_EntityStackLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368214, RefRangeEnd = 368215, XrefRangeStart = 368214, XrefRangeEnd = 368214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_EntityStackLength_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00034BB4 File Offset: 0x00032DB4
		public unsafe bool DtdParserProxy_IsEntityEolNormalized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368215, RefRangeEnd = 368216, XrefRangeStart = 368215, XrefRangeEnd = 368215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEntityEolNormalized_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00034BF0 File Offset: 0x00032DF0
		public unsafe IValidationEventHandling DtdParserProxy_ValidationEventHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ValidationEventHandling_Internal_get_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr3) : null;
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00034C30 File Offset: 0x00032E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368216, RefRangeEnd = 368217, XrefRangeStart = 368216, XrefRangeEnd = 368216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_OnNewLine(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnNewLine_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00034C70 File Offset: 0x00032E70
		public unsafe int DtdParserProxy_LineNo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368217, RefRangeEnd = 368218, XrefRangeStart = 368217, XrefRangeEnd = 368217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineNo_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00034CAC File Offset: 0x00032EAC
		public unsafe int DtdParserProxy_LineStartPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368218, RefRangeEnd = 368219, XrefRangeStart = 368218, XrefRangeEnd = 368218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineStartPosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00034CE8 File Offset: 0x00032EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368220, RefRangeEnd = 368221, XrefRangeStart = 368219, XrefRangeEnd = 368220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DtdParserProxy_ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ReadData_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00034D24 File Offset: 0x00032F24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368225, RefRangeEnd = 368226, XrefRangeStart = 368221, XrefRangeEnd = 368225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNumericCharRef_Internal_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00034D74 File Offset: 0x00032F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368227, RefRangeEnd = 368228, XrefRangeStart = 368226, XrefRangeEnd = 368227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNamedCharRef_Internal_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00034DD0 File Offset: 0x00032FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368230, RefRangeEnd = 368231, XrefRangeStart = 368228, XrefRangeEnd = 368230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_ParsePI(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParsePI_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00034E14 File Offset: 0x00033014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368255, RefRangeEnd = 368256, XrefRangeStart = 368231, XrefRangeEnd = 368255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_ParseComment(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseComment_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00034E58 File Offset: 0x00033058
		public unsafe bool IsResolverNull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_IsResolverNull_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00034E94 File Offset: 0x00033094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368256, XrefRangeEnd = 368260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlResolver GetTempResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetTempResolver_Private_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00034ED4 File Offset: 0x000330D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368267, RefRangeEnd = 368268, XrefRangeStart = 368260, XrefRangeEnd = 368267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushEntity_Internal_Boolean_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00034F30 File Offset: 0x00033130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368270, RefRangeEnd = 368271, XrefRangeStart = 368268, XrefRangeEnd = 368270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &newEntityId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PopEntity_Internal_Boolean_byref_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			oldEntity = ((intPtr4 == 0) ? null : new IDtdEntityInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00034F9C File Offset: 0x0003319C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368282, RefRangeEnd = 368283, XrefRangeStart = 368271, XrefRangeEnd = 368282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DtdParserProxy_PushExternalSubset(string systemId, string publicId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushExternalSubset_Internal_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00034FFC File Offset: 0x000331FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368288, RefRangeEnd = 368289, XrefRangeStart = 368283, XrefRangeEnd = 368288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalDtd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushInternalDtd_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00035050 File Offset: 0x00033250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368290, RefRangeEnd = 368291, XrefRangeStart = 368289, XrefRangeEnd = 368290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_Throw(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_Throw_Internal_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00035094 File Offset: 0x00033294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368296, RefRangeEnd = 368297, XrefRangeStart = 368291, XrefRangeEnd = 368296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref systemLiteralLineInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnSystemId_Internal_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000350F4 File Offset: 0x000332F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368302, RefRangeEnd = 368303, XrefRangeStart = 368297, XrefRangeEnd = 368302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publicLiteralLineInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnPublicId_Internal_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00035154 File Offset: 0x00033354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368304, RefRangeEnd = 368306, XrefRangeStart = 368303, XrefRangeEnd = 368304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int pos, string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000351B8 File Offset: 0x000333B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368307, RefRangeEnd = 368308, XrefRangeStart = 368306, XrefRangeEnd = 368307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int pos, string res, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0003521C File Offset: 0x0003341C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368312, RefRangeEnd = 368314, XrefRangeStart = 368308, XrefRangeEnd = 368312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int pos, string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0003526C File Offset: 0x0003346C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368318, RefRangeEnd = 368320, XrefRangeStart = 368314, XrefRangeEnd = 368318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000352B0 File Offset: 0x000334B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368320, XrefRangeEnd = 368328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00035310 File Offset: 0x00033510
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 368335, RefRangeEnd = 368339, XrefRangeStart = 368328, XrefRangeEnd = 368335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00035364 File Offset: 0x00033564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368339, XrefRangeEnd = 368344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000353D4 File Offset: 0x000335D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 368351, RefRangeEnd = 368355, XrefRangeStart = 368344, XrefRangeEnd = 368351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00035428 File Offset: 0x00033628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368355, XrefRangeEnd = 368361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, string arg, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00035490 File Offset: 0x00033690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368368, RefRangeEnd = 368369, XrefRangeStart = 368361, XrefRangeEnd = 368368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, Il2CppStringArray args, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000354F8 File Offset: 0x000336F8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 368380, RefRangeEnd = 368390, XrefRangeStart = 368369, XrefRangeEnd = 368380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0003553C File Offset: 0x0003373C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368390, XrefRangeEnd = 368397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReThrow(Exception e, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ReThrow_Private_Void_Exception_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0003559C File Offset: 0x0003379C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368397, XrefRangeEnd = 368405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowWithoutLineInfo(string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000355E0 File Offset: 0x000337E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368410, RefRangeEnd = 368411, XrefRangeStart = 368405, XrefRangeEnd = 368410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowWithoutLineInfo(string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00035634 File Offset: 0x00033834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368411, XrefRangeEnd = 368416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowWithoutLineInfo(string res, Il2CppStringArray args, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_Il2CppStringArray_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0003569C File Offset: 0x0003389C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368416, XrefRangeEnd = 368420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000356FC File Offset: 0x000338FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368420, RefRangeEnd = 368422, XrefRangeStart = 368420, XrefRangeEnd = 368420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetErrorState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetErrorState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00035730 File Offset: 0x00033930
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368429, RefRangeEnd = 368432, XrefRangeStart = 368422, XrefRangeEnd = 368429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000357B0 File Offset: 0x000339B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368432, XrefRangeEnd = 368435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00035800 File Offset: 0x00033A00
		public unsafe bool InAttributeValueIterator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_InAttributeValueIterator_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0003583C File Offset: 0x00033A3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 368447, RefRangeEnd = 368451, XrefRangeStart = 368435, XrefRangeEnd = 368447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishAttributeValueIterator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishAttributeValueIterator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00035870 File Offset: 0x00033A70
		public unsafe bool DtdValidation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368207, RefRangeEnd = 368208, XrefRangeStart = 368207, XrefRangeEnd = 368208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdValidation_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x000358AC File Offset: 0x00033AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368451, XrefRangeEnd = 368454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Stream stream, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00035900 File Offset: 0x00033B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368454, XrefRangeEnd = 368455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_String_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00035968 File Offset: 0x00033B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368455, XrefRangeEnd = 368456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000359D0 File Offset: 0x00033BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368456, XrefRangeEnd = 368457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00035A4C File Offset: 0x00033C4C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 368481, RefRangeEnd = 368491, XrefRangeStart = 368457, XrefRangeEnd = 368481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Il2CppStructArray<byte> bytes, int byteCount, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Il2CppStructArray_1_Byte_Int32_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00035AE8 File Offset: 0x00033CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368491, XrefRangeEnd = 368492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitTextReaderInput(string baseUriStr, TextReader input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00035B3C File Offset: 0x00033D3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 368502, RefRangeEnd = 368506, XrefRangeStart = 368492, XrefRangeEnd = 368502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_Uri_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00035BA4 File Offset: 0x00033DA4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 368514, RefRangeEnd = 368519, XrefRangeStart = 368506, XrefRangeEnd = 368514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStringInput(string baseUriStr, Encoding originalEncoding, string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalEncoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStringInput_Private_Void_String_Encoding_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00035C0C File Offset: 0x00033E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368545, RefRangeEnd = 368547, XrefRangeStart = 368519, XrefRangeEnd = 368545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fragmentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parserContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowXmlDeclFragment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitFragmentReader_Private_Void_XmlNodeType_XmlParserContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00035C6C File Offset: 0x00033E6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368549, RefRangeEnd = 368552, XrefRangeStart = 368547, XrefRangeEnd = 368549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDtdFromParserContext(XmlParserContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ProcessDtdFromParserContext_Private_Void_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00035CB0 File Offset: 0x00033EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368591, RefRangeEnd = 368592, XrefRangeStart = 368552, XrefRangeEnd = 368591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenUrl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00035CE4 File Offset: 0x00033EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368592, XrefRangeEnd = 368611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenUrlDelegate(Object xmlResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlResolver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrlDelegate_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00035D28 File Offset: 0x00033F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368623, RefRangeEnd = 368624, XrefRangeStart = 368611, XrefRangeEnd = 368623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding DetectEncoding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DetectEncoding_Private_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00035D68 File Offset: 0x00033F68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368648, RefRangeEnd = 368651, XrefRangeStart = 368624, XrefRangeEnd = 368648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEncoding(Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupEncoding_Private_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00035DAC File Offset: 0x00033FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368656, RefRangeEnd = 368657, XrefRangeStart = 368651, XrefRangeEnd = 368656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchEncoding(Encoding newEncoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEncoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncoding_Private_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00035DF0 File Offset: 0x00033FF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368682, RefRangeEnd = 368683, XrefRangeStart = 368657, XrefRangeEnd = 368682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding CheckEncoding(string newEncodingName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newEncodingName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_CheckEncoding_Private_Encoding_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00035E40 File Offset: 0x00034040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368683, RefRangeEnd = 368684, XrefRangeStart = 368683, XrefRangeEnd = 368683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnDecodeChars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_UnDecodeChars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00035E74 File Offset: 0x00034074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368689, RefRangeEnd = 368691, XrefRangeStart = 368684, XrefRangeEnd = 368689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchEncodingToUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncodingToUTF8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00035EA8 File Offset: 0x000340A8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 368717, RefRangeEnd = 368750, XrefRangeStart = 368691, XrefRangeEnd = 368717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ReadData_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00035EE4 File Offset: 0x000340E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368752, RefRangeEnd = 368753, XrefRangeStart = 368750, XrefRangeEnd = 368752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetChars(int maxCharsCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxCharsCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetChars_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00035F30 File Offset: 0x00034130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368756, RefRangeEnd = 368757, XrefRangeStart = 368753, XrefRangeEnd = 368756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvalidCharRecovery(ref int bytesCount, out int charsCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &bytesCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InvalidCharRecovery_Private_Void_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00035F7C File Offset: 0x0003417C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368757, XrefRangeEnd = 368766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool closeInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeInput;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00035FBC File Offset: 0x000341BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368766, XrefRangeEnd = 368767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShiftBuffer(int sourcePos, int destPos, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourcePos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ShiftBuffer_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00036018 File Offset: 0x00034218
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 368900, RefRangeEnd = 368904, XrefRangeStart = 368767, XrefRangeEnd = 368900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseXmlDeclaration(bool isTextDecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isTextDecl;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclaration_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00036064 File Offset: 0x00034264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368916, RefRangeEnd = 368917, XrefRangeStart = 368904, XrefRangeEnd = 368916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseDocumentContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDocumentContent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000360A0 File Offset: 0x000342A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368936, RefRangeEnd = 368937, XrefRangeStart = 368917, XrefRangeEnd = 368936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseElementContent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000360DC File Offset: 0x000342DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368937, XrefRangeEnd = 368963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnclosedElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnclosedElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00036110 File Offset: 0x00034310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368963, XrefRangeEnd = 368985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00036144 File Offset: 0x00034344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369059, RefRangeEnd = 369061, XrefRangeStart = 368985, XrefRangeEnd = 369059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultAttributesAndNormalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributesAndNormalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00036178 File Offset: 0x00034378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369061, XrefRangeEnd = 369083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseEndElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000361AC File Offset: 0x000343AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369083, XrefRangeEnd = 369115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startTag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowTagMismatch_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000361F0 File Offset: 0x000343F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369115, XrefRangeEnd = 369155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00036224 File Offset: 0x00034424
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369159, RefRangeEnd = 369161, XrefRangeStart = 369155, XrefRangeEnd = 369159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ElementNamespaceLookup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ElementNamespaceLookup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00036258 File Offset: 0x00034458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369163, RefRangeEnd = 369165, XrefRangeStart = 369161, XrefRangeEnd = 369163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttributeNamespaceLookup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AttributeNamespaceLookup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0003628C File Offset: 0x0003448C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369176, RefRangeEnd = 369177, XrefRangeStart = 369165, XrefRangeEnd = 369176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttributeDuplCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AttributeDuplCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000362C0 File Offset: 0x000344C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369186, RefRangeEnd = 369187, XrefRangeStart = 369177, XrefRangeEnd = 369186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnDefaultNamespaceDecl_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00036304 File Offset: 0x00034504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369190, RefRangeEnd = 369191, XrefRangeStart = 369187, XrefRangeEnd = 369190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnNamespaceDecl_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00036348 File Offset: 0x00034548
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369206, RefRangeEnd = 369209, XrefRangeStart = 369191, XrefRangeEnd = 369206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnXmlReservedAttribute_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0003638C File Offset: 0x0003458C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369309, RefRangeEnd = 369312, XrefRangeStart = 369209, XrefRangeEnd = 369309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoteChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueSlow_Private_Void_Int32_Char_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000363EC File Offset: 0x000345EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369312, XrefRangeEnd = 369317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chunk);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lastChunk);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeChunkToList_Private_Void_NodeData_NodeData_byref_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lastChunk = ((intPtr4 == 0) ? null : new XmlTextReaderImpl.NodeData(intPtr4));
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00036468 File Offset: 0x00034668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369331, RefRangeEnd = 369333, XrefRangeStart = 369317, XrefRangeEnd = 369331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000364A4 File Offset: 0x000346A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 369358, RefRangeEnd = 369365, XrefRangeStart = 369333, XrefRangeEnd = 369358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseText(out int startPos, out int endPos, ref int outOrChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outOrChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0003650C File Offset: 0x0003470C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 369373, RefRangeEnd = 369377, XrefRangeStart = 369365, XrefRangeEnd = 369373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishPartialValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishPartialValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00036540 File Offset: 0x00034740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369377, XrefRangeEnd = 369381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishOtherValueIterator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishOtherValueIterator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00036574 File Offset: 0x00034774
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 369382, RefRangeEnd = 369387, XrefRangeStart = 369381, XrefRangeEnd = 369382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipPartialTextValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipPartialTextValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000365A8 File Offset: 0x000347A8
		[CallerCount(0)]
		public unsafe void FinishReadValueChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadValueChunk_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000365DC File Offset: 0x000347DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 369390, RefRangeEnd = 369395, XrefRangeStart = 369387, XrefRangeEnd = 369390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishReadContentAsBinary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadContentAsBinary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00036610 File Offset: 0x00034810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369405, RefRangeEnd = 369407, XrefRangeStart = 369395, XrefRangeEnd = 369405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishReadElementContentAsBinary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadElementContentAsBinary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00036644 File Offset: 0x00034844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369407, XrefRangeEnd = 369416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseRootLevelWhitespace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseRootLevelWhitespace_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00036680 File Offset: 0x00034880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369421, RefRangeEnd = 369422, XrefRangeStart = 369416, XrefRangeEnd = 369421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseEntityReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityReference_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000366B4 File Offset: 0x000348B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369433, RefRangeEnd = 369436, XrefRangeStart = 369422, XrefRangeEnd = 369433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isInAttributeValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expandType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charRefEndPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityReference_Private_EntityType_Boolean_EntityExpandType_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0003671C File Offset: 0x0003491C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369474, RefRangeEnd = 369477, XrefRangeStart = 369436, XrefRangeEnd = 369474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInAttributeValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pushFakeEntityIfNullResolver;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entityStartLinePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_HandleGeneralEntityReference_Private_EntityType_String_Boolean_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00036794 File Offset: 0x00034994
		public unsafe bool InEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_InEntity_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000367D0 File Offset: 0x000349D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369482, RefRangeEnd = 369485, XrefRangeStart = 369477, XrefRangeEnd = 369482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityEnd(bool checkEntityNesting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref checkEntityNesting;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0003681C File Offset: 0x00034A1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369494, RefRangeEnd = 369496, XrefRangeStart = 369485, XrefRangeEnd = 369494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEndEntityNodeInContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00036850 File Offset: 0x00034A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369496, XrefRangeEnd = 369497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEndEntityNodeInAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00036884 File Offset: 0x00034A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369497, XrefRangeEnd = 369498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000368C0 File Offset: 0x00034AC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369521, RefRangeEnd = 369524, XrefRangeStart = 369498, XrefRangeEnd = 369521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePI(StringBuilder piInDtdStringBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(piInDtdStringBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00036910 File Offset: 0x00034B10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369539, RefRangeEnd = 369542, XrefRangeStart = 369524, XrefRangeEnd = 369539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePIValue(out int outStartPos, out int outEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outStartPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outEndPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParsePIValue_Private_Boolean_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00036968 File Offset: 0x00034B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369543, RefRangeEnd = 369544, XrefRangeStart = 369542, XrefRangeEnd = 369543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseComment_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000369A4 File Offset: 0x00034BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369544, XrefRangeEnd = 369545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000369D8 File Offset: 0x00034BD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369546, RefRangeEnd = 369547, XrefRangeStart = 369545, XrefRangeEnd = 369546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseCDataOrComment(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00036A18 File Offset: 0x00034C18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 369563, RefRangeEnd = 369569, XrefRangeStart = 369547, XrefRangeEnd = 369563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outStartPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outEndPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Boolean_XmlNodeType_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00036A80 File Offset: 0x00034C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369569, XrefRangeEnd = 369586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseDoctypeDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDoctypeDecl_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00036ABC File Offset: 0x00034CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369586, XrefRangeEnd = 369611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDtd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00036AF0 File Offset: 0x00034CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369646, RefRangeEnd = 369647, XrefRangeStart = 369611, XrefRangeEnd = 369646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipDtd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipDtd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00036B24 File Offset: 0x00034D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369655, RefRangeEnd = 369657, XrefRangeStart = 369647, XrefRangeEnd = 369655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipPublicOrSystemIdLiteral()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipPublicOrSystemIdLiteral_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00036B58 File Offset: 0x00034D58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369673, RefRangeEnd = 369675, XrefRangeStart = 369657, XrefRangeEnd = 369673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipUntil(char stopChar, bool recognizeLiterals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recognizeLiterals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipUntil_Private_Void_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00036BA4 File Offset: 0x00034DA4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 369685, RefRangeEnd = 369701, XrefRangeStart = 369675, XrefRangeEnd = 369685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EatWhitespaces(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_EatWhitespaces_Private_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00036BF4 File Offset: 0x00034DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369701, XrefRangeEnd = 369703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCharRefInline_Private_Int32_Int32_byref_Int32_byref_EntityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00036C5C File Offset: 0x00034E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369703, XrefRangeEnd = 369707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRef_Private_Int32_Boolean_StringBuilder_byref_EntityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00036CC8 File Offset: 0x00034EC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 369723, RefRangeEnd = 369727, XrefRangeStart = 369707, XrefRangeEnd = 369723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expand;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_byref_Int32_byref_EntityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00036D50 File Offset: 0x00034F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369729, RefRangeEnd = 369731, XrefRangeStart = 369727, XrefRangeEnd = 369729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRef_Private_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00036DAC File Offset: 0x00034FAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369733, RefRangeEnd = 369736, XrefRangeStart = 369731, XrefRangeEnd = 369733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expand;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00036E18 File Offset: 0x00035018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369736, XrefRangeEnd = 369737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseName_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00036E54 File Offset: 0x00035054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369738, RefRangeEnd = 369739, XrefRangeStart = 369737, XrefRangeEnd = 369738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseQName(out int colonPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &colonPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00036EA0 File Offset: 0x000350A0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 369750, RefRangeEnd = 369759, XrefRangeStart = 369739, XrefRangeEnd = 369750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseQName(bool isQName, int startOffset, out int colonPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isQName;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &colonPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_Boolean_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00036F08 File Offset: 0x00035108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369759, XrefRangeEnd = 369760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadDataInName(ref int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00036F54 File Offset: 0x00035154
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 369762, RefRangeEnd = 369766, XrefRangeStart = 369760, XrefRangeEnd = 369762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseEntityName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00036F8C File Offset: 0x0003518C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 369777, RefRangeEnd = 369786, XrefRangeStart = 369766, XrefRangeEnd = 369777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddNode_Private_NodeData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00036FE8 File Offset: 0x000351E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369786, XrefRangeEnd = 369797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AllocNode_Private_NodeData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00037044 File Offset: 0x00035244
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369799, RefRangeEnd = 369802, XrefRangeStart = 369797, XrefRangeEnd = 369799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attrDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeNoChecks_Private_NodeData_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000370A4 File Offset: 0x000352A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369809, RefRangeEnd = 369810, XrefRangeStart = 369802, XrefRangeEnd = 369809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref endNamePos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colonPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00037100 File Offset: 0x00035300
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369816, RefRangeEnd = 369819, XrefRangeStart = 369810, XrefRangeEnd = 369816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameWPrefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00037174 File Offset: 0x00035374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369820, RefRangeEnd = 369821, XrefRangeStart = 369819, XrefRangeEnd = 369820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopElementContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopElementContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000371A8 File Offset: 0x000353A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368216, RefRangeEnd = 368217, XrefRangeStart = 368216, XrefRangeEnd = 368217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNewLine(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000371E8 File Offset: 0x000353E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369828, RefRangeEnd = 369830, XrefRangeStart = 369821, XrefRangeEnd = 369828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEof()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnEof_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0003721C File Offset: 0x0003541C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369831, RefRangeEnd = 369833, XrefRangeStart = 369830, XrefRangeEnd = 369831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupNamespace(XmlTextReaderImpl.NodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Private_String_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00037264 File Offset: 0x00035464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369846, RefRangeEnd = 369848, XrefRangeStart = 369833, XrefRangeEnd = 369846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000372CC File Offset: 0x000354CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369849, RefRangeEnd = 369852, XrefRangeStart = 369848, XrefRangeEnd = 369849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ResetAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00037300 File Offset: 0x00035500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369852, XrefRangeEnd = 369853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullAttributeCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FullAttributeCleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00037334 File Offset: 0x00035534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369858, RefRangeEnd = 369860, XrefRangeStart = 369853, XrefRangeEnd = 369858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushXmlContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushXmlContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00037368 File Offset: 0x00035568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369860, XrefRangeEnd = 369861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopXmlContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopXmlContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0003739C File Offset: 0x0003559C
		[CallerCount(0)]
		public unsafe XmlNodeType GetWhitespaceType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetWhitespaceType_Private_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000373D8 File Offset: 0x000355D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369861, RefRangeEnd = 369862, XrefRangeStart = 369861, XrefRangeEnd = 369861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeType GetTextNodeType(int orChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref orChars;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetTextNodeType_Private_XmlNodeType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00037424 File Offset: 0x00035624
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369875, RefRangeEnd = 369877, XrefRangeStart = 369862, XrefRangeEnd = 369875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entityName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntityOrSubset_Private_Void_String_String_Uri_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000374A0 File Offset: 0x000356A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369900, RefRangeEnd = 369902, XrefRangeStart = 369877, XrefRangeEnd = 369900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OpenAndPush(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OpenAndPush_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000374F0 File Offset: 0x000356F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369920, RefRangeEnd = 369921, XrefRangeStart = 369902, XrefRangeEnd = 369920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PushExternalEntity(IDtdEntityInfo entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntity_Private_Boolean_IDtdEntityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00037540 File Offset: 0x00035740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369943, RefRangeEnd = 369945, XrefRangeStart = 369921, XrefRangeEnd = 369943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushInternalEntity(IDtdEntityInfo entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushInternalEntity_Private_Void_IDtdEntityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00037584 File Offset: 0x00035784
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 369949, RefRangeEnd = 369956, XrefRangeStart = 369945, XrefRangeEnd = 369949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopEntity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000375B8 File Offset: 0x000357B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369973, RefRangeEnd = 369975, XrefRangeStart = 369956, XrefRangeEnd = 369973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEntity(IDtdEntityInfo entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_RegisterEntity_Private_Void_IDtdEntityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000375FC File Offset: 0x000357FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369975, XrefRangeEnd = 369978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_UnregisterEntity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00037630 File Offset: 0x00035830
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 369990, RefRangeEnd = 369994, XrefRangeStart = 369978, XrefRangeEnd = 369990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushParsingState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushParsingState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00037664 File Offset: 0x00035864
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 369998, RefRangeEnd = 370001, XrefRangeStart = 369994, XrefRangeEnd = 369998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopParsingState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopParsingState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00037698 File Offset: 0x00035898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370004, RefRangeEnd = 370005, XrefRangeStart = 370001, XrefRangeEnd = 370004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IncrementalRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_IncrementalRead_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000376D4 File Offset: 0x000358D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370012, RefRangeEnd = 370014, XrefRangeStart = 370005, XrefRangeEnd = 370012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishIncrementalRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishIncrementalRead_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00037708 File Offset: 0x00035908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370014, XrefRangeEnd = 370017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseFragmentAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseFragmentAttribute_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00037744 File Offset: 0x00035944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370044, RefRangeEnd = 370045, XrefRangeStart = 370017, XrefRangeEnd = 370044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseAttributeValueChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueChunk_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00037780 File Offset: 0x00035980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370046, RefRangeEnd = 370047, XrefRangeStart = 370045, XrefRangeEnd = 370046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseXmlDeclarationFragment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclarationFragment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000377B4 File Offset: 0x000359B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370047, XrefRangeEnd = 370048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00037804 File Offset: 0x00035A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370048, XrefRangeEnd = 370049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(string expectedToken1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expectedToken1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00037848 File Offset: 0x00035A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370050, RefRangeEnd = 370051, XrefRangeStart = 370049, XrefRangeEnd = 370050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000378AC File Offset: 0x00035AAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370075, RefRangeEnd = 370078, XrefRangeStart = 370051, XrefRangeEnd = 370075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(string expectedToken1, string expectedToken2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expectedToken1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00037900 File Offset: 0x00035B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370078, XrefRangeEnd = 370079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseUnexpectedToken(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00037944 File Offset: 0x00035B44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370081, RefRangeEnd = 370084, XrefRangeStart = 370079, XrefRangeEnd = 370081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseUnexpectedToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0003797C File Offset: 0x00035B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370084, XrefRangeEnd = 370091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowExpectingWhitespace(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowExpectingWhitespace_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000379BC File Offset: 0x00035BBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370092, RefRangeEnd = 370094, XrefRangeStart = 370091, XrefRangeEnd = 370092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndexOfAttributeWithoutPrefix(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithoutPrefix_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00037A0C File Offset: 0x00035C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370096, RefRangeEnd = 370098, XrefRangeStart = 370094, XrefRangeEnd = 370096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndexOfAttributeWithPrefix(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithPrefix_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00037A5C File Offset: 0x00035C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370099, RefRangeEnd = 370100, XrefRangeStart = 370098, XrefRangeEnd = 370099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ZeroEndingStream(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ZeroEndingStream_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00037AA8 File Offset: 0x00035CA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370114, RefRangeEnd = 370116, XrefRangeStart = 370100, XrefRangeEnd = 370114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDtdFromParserContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00037ADC File Offset: 0x00035CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370116, XrefRangeEnd = 370117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToNextContentNode(bool moveIfOnContentNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveIfOnContentNode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00037B28 File Offset: 0x00035D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370149, RefRangeEnd = 370150, XrefRangeStart = 370117, XrefRangeEnd = 370149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupFromParserContext_Private_Void_XmlParserContext_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00037B7C File Offset: 0x00035D7C
		public unsafe override IDtdInfo DtdInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00037BC8 File Offset: 0x00035DC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370156, RefRangeEnd = 370159, XrefRangeStart = 370150, XrefRangeEnd = 370156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDtdInfo(IDtdInfo newDtdInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newDtdInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetDtdInfo_Internal_Void_IDtdInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000260 RID: 608
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00037C0C File Offset: 0x00035E0C
		public unsafe IValidationEventHandling ValidationEventHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370159, XrefRangeEnd = 370160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_ValidationEventHandling_Internal_set_Void_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000261 RID: 609
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00037C50 File Offset: 0x00035E50
		public unsafe XmlTextReaderImpl.OnDefaultAttributeUseDelegate OnDefaultAttributeUse
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370160, XrefRangeEnd = 370161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_OnDefaultAttributeUse_Internal_set_Void_OnDefaultAttributeUseDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000262 RID: 610
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00037C94 File Offset: 0x00035E94
		public unsafe bool XmlValidatingReaderCompatibilityMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 370167, RefRangeEnd = 370170, XrefRangeStart = 370161, XrefRangeEnd = 370167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00037CD4 File Offset: 0x00035ED4
		public unsafe XmlNodeType FragmentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_FragmentType_Internal_get_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00037D10 File Offset: 0x00035F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370170, RefRangeEnd = 370171, XrefRangeStart = 370170, XrefRangeEnd = 370170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCurrentNodeType(XmlNodeType newNodeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newNodeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ChangeCurrentNodeType_Internal_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00037D50 File Offset: 0x00035F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370172, RefRangeEnd = 370173, XrefRangeStart = 370171, XrefRangeEnd = 370172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlResolver GetResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x17000264 RID: 612
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00037D90 File Offset: 0x00035F90
		public unsafe Object InternalSchemaType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 370175, RefRangeEnd = 370177, XrefRangeStart = 370173, XrefRangeEnd = 370175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_InternalSchemaType_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00037DD4 File Offset: 0x00035FD4
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00037E14 File Offset: 0x00036014
		public unsafe Object InternalTypedValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 370177, RefRangeEnd = 370178, XrefRangeStart = 370177, XrefRangeEnd = 370177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_InternalTypedValue_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 370180, RefRangeEnd = 370182, XrefRangeStart = 370178, XrefRangeEnd = 370180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_InternalTypedValue_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00037E58 File Offset: 0x00036058
		public unsafe bool StandAlone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_StandAlone_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00037E94 File Offset: 0x00036094
		public unsafe override XmlNamespaceManager NamespaceManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NamespaceManager_Internal_Virtual_get_XmlNamespaceManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00037EE0 File Offset: 0x000360E0
		public unsafe bool V1Compat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_V1Compat_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00037F1C File Offset: 0x0003611C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370226, RefRangeEnd = 370227, XrefRangeStart = 370182, XrefRangeEnd = 370226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, Il2CppReferenceArray<XmlTextReaderImpl.NodeData> nameSortedNodeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defAttrInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref definedInDtd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameSortedNodeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeDtd_Private_Boolean_IDtdDefaultAttributeInfo_Boolean_Il2CppReferenceArray_1_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00037F8C File Offset: 0x0003618C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370233, RefRangeEnd = 370234, XrefRangeStart = 370227, XrefRangeEnd = 370233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrDef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeNonDtd_Internal_Boolean_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00037FDC File Offset: 0x000361DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370241, RefRangeEnd = 370242, XrefRangeStart = 370234, XrefRangeEnd = 370241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLineNo;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLinePos;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isXmlAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeInternal_Private_NodeData_String_String_String_String_Int32_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x17000269 RID: 617
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x000380AC File Offset: 0x000362AC
		public unsafe bool DisableUndeclaredEntityCheck
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_DisableUndeclaredEntityCheck_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000380EC File Offset: 0x000362EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370242, XrefRangeEnd = 370248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri1Str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri2Str);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_UriEqual_Private_Boolean_Uri_String_String_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00038170 File Offset: 0x00036370
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370251, RefRangeEnd = 370254, XrefRangeStart = 370248, XrefRangeEnd = 370251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterConsumedCharacters(long characters, bool inEntityReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref characters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inEntityReference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_RegisterConsumedCharacters_Private_Void_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000381BC File Offset: 0x000363BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370269, RefRangeEnd = 370270, XrefRangeStart = 370254, XrefRangeEnd = 370269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripSpaces(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000381F8 File Offset: 0x000363F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370270, RefRangeEnd = 370271, XrefRangeStart = 370270, XrefRangeEnd = 370270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StripSpaces(Il2CppStructArray<char> value, int index, ref int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0003824C File Offset: 0x0003644C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370271, XrefRangeEnd = 370272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockCopyChars(Il2CppStructArray<char> src, int srcOffset, Il2CppStructArray<char> dst, int dstOffset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopyChars_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000382C0 File Offset: 0x000364C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370272, XrefRangeEnd = 370273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockCopy(Il2CppStructArray<byte> src, int srcOffset, Il2CppStructArray<byte> dst, int dstOffset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00003FC2 File Offset: 0x000021C2
		public XmlTextReaderImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00038334 File Offset: 0x00036534
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00003FCB File Offset: 0x000021CB
		public unsafe bool useAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_useAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_useAsync)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0003835C File Offset: 0x0003655C
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00003FE6 File Offset: 0x000021E6
		public unsafe XmlTextReaderImpl.LaterInitParam laterInitParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_laterInitParam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.LaterInitParam>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_laterInitParam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x0003838C File Offset: 0x0003658C
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00004005 File Offset: 0x00002205
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x000383BC File Offset: 0x000365BC
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00004033 File Offset: 0x00002233
		public XmlTextReaderImpl.ParsingState ps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ps);
				return new XmlTextReaderImpl.ParsingState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ps), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x000383EC File Offset: 0x000365EC
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00004061 File Offset: 0x00002261
		public unsafe XmlTextReaderImpl.ParsingFunction parsingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingFunction)) = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00038414 File Offset: 0x00036614
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x0000407C File Offset: 0x0000227C
		public unsafe XmlTextReaderImpl.ParsingFunction nextParsingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextParsingFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextParsingFunction)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x0003843C File Offset: 0x0003663C
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00004097 File Offset: 0x00002297
		public unsafe XmlTextReaderImpl.ParsingFunction nextNextParsingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextNextParsingFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextNextParsingFunction)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00038464 File Offset: 0x00036664
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x000040B2 File Offset: 0x000022B2
		public unsafe Il2CppReferenceArray<XmlTextReaderImpl.NodeData> nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextReaderImpl.NodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00038494 File Offset: 0x00036694
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x000040D1 File Offset: 0x000022D1
		public unsafe XmlTextReaderImpl.NodeData curNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x000384C4 File Offset: 0x000366C4
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x000040F0 File Offset: 0x000022F0
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x000384EC File Offset: 0x000366EC
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x0000410B File Offset: 0x0000230B
		public unsafe int curAttrIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curAttrIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curAttrIndex)) = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00038514 File Offset: 0x00036714
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00004126 File Offset: 0x00002326
		public unsafe int attrCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrCount)) = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x0003853C File Offset: 0x0003673C
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00004141 File Offset: 0x00002341
		public unsafe int attrHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrHashtable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrHashtable)) = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00038564 File Offset: 0x00036764
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x0000415C File Offset: 0x0000235C
		public unsafe int attrDuplWalkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplWalkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplWalkCount)) = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0003858C File Offset: 0x0003678C
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00004177 File Offset: 0x00002377
		public unsafe bool attrNeedNamespaceLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrNeedNamespaceLookup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrNeedNamespaceLookup)) = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x000385B4 File Offset: 0x000367B4
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00004192 File Offset: 0x00002392
		public unsafe bool fullAttrCleanup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fullAttrCleanup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fullAttrCleanup)) = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x000385DC File Offset: 0x000367DC
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x000041AD File Offset: 0x000023AD
		public unsafe Il2CppReferenceArray<XmlTextReaderImpl.NodeData> attrDuplSortingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplSortingArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextReaderImpl.NodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplSortingArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x0003860C File Offset: 0x0003680C
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x000041CC File Offset: 0x000023CC
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0003863C File Offset: 0x0003683C
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x000041EB File Offset: 0x000023EB
		public unsafe bool nameTableFromSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTableFromSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTableFromSettings)) = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00038664 File Offset: 0x00036864
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00004206 File Offset: 0x00002406
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00038694 File Offset: 0x00036894
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00004225 File Offset: 0x00002425
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x000386BC File Offset: 0x000368BC
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x00004244 File Offset: 0x00002444
		public unsafe bool normalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_normalize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_normalize)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x000386E4 File Offset: 0x000368E4
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x0000425F File Offset: 0x0000245F
		public unsafe bool supportNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_supportNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_supportNamespaces)) = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0003870C File Offset: 0x0003690C
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x0000427A File Offset: 0x0000247A
		public unsafe WhitespaceHandling whitespaceHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_whitespaceHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_whitespaceHandling)) = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00038734 File Offset: 0x00036934
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00004295 File Offset: 0x00002495
		public unsafe DtdProcessing dtdProcessing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdProcessing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdProcessing)) = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0003875C File Offset: 0x0003695C
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x000042B0 File Offset: 0x000024B0
		public unsafe EntityHandling entityHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_entityHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_entityHandling)) = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00038784 File Offset: 0x00036984
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x000042CB File Offset: 0x000024CB
		public unsafe bool ignorePIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignorePIs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignorePIs)) = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x000387AC File Offset: 0x000369AC
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x000042E6 File Offset: 0x000024E6
		public unsafe bool ignoreComments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignoreComments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignoreComments)) = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x000387D4 File Offset: 0x000369D4
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00004301 File Offset: 0x00002501
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x000387FC File Offset: 0x000369FC
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x0000431C File Offset: 0x0000251C
		public unsafe int lineNumberOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lineNumberOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lineNumberOffset)) = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00038824 File Offset: 0x00036A24
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00004337 File Offset: 0x00002537
		public unsafe int linePositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_linePositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_linePositionOffset)) = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0003884C File Offset: 0x00036A4C
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00004352 File Offset: 0x00002552
		public unsafe bool closeInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_closeInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_closeInput)) = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00038874 File Offset: 0x00036A74
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x0000436D File Offset: 0x0000256D
		public unsafe long maxCharactersInDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersInDocument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersInDocument)) = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0003889C File Offset: 0x00036A9C
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00004388 File Offset: 0x00002588
		public unsafe long maxCharactersFromEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersFromEntities);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersFromEntities)) = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x000388C4 File Offset: 0x00036AC4
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x000043A3 File Offset: 0x000025A3
		public unsafe bool v1Compat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_v1Compat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_v1Compat)) = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x000388EC File Offset: 0x00036AEC
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x000043BE File Offset: 0x000025BE
		public unsafe XmlNamespaceManager namespaceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_namespaceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_namespaceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x0003891C File Offset: 0x00036B1C
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x000043DD File Offset: 0x000025DD
		public unsafe string lastPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x00038944 File Offset: 0x00036B44
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x000043FC File Offset: 0x000025FC
		public unsafe XmlTextReaderImpl.XmlContext xmlContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.XmlContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00038974 File Offset: 0x00036B74
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x0000441B File Offset: 0x0000261B
		public unsafe Il2CppReferenceArray<XmlTextReaderImpl.ParsingState> parsingStatesStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextReaderImpl.ParsingState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x000389A4 File Offset: 0x00036BA4
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x0000443A File Offset: 0x0000263A
		public unsafe int parsingStatesStackTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStackTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStackTop)) = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x000389CC File Offset: 0x00036BCC
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x00004455 File Offset: 0x00002655
		public unsafe string reportedBaseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedBaseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedBaseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x000389F4 File Offset: 0x00036BF4
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00004474 File Offset: 0x00002674
		public unsafe Encoding reportedEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedEncoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedEncoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00038A24 File Offset: 0x00036C24
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00004493 File Offset: 0x00002693
		public unsafe IDtdInfo dtdInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00038A54 File Offset: 0x00036C54
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x000044B2 File Offset: 0x000026B2
		public unsafe XmlNodeType fragmentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentType)) = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00038A7C File Offset: 0x00036C7C
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x000044CD File Offset: 0x000026CD
		public unsafe XmlParserContext fragmentParserContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentParserContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlParserContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentParserContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00038AAC File Offset: 0x00036CAC
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x000044EC File Offset: 0x000026EC
		public unsafe bool fragment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragment)) = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00038AD4 File Offset: 0x00036CD4
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00004507 File Offset: 0x00002707
		public unsafe IncrementalReadDecoder incReadDecoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDecoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncrementalReadDecoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDecoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00038B04 File Offset: 0x00036D04
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00004526 File Offset: 0x00002726
		public unsafe XmlTextReaderImpl.IncrementalReadState incReadState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadState)) = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00038B2C File Offset: 0x00036D2C
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00004541 File Offset: 0x00002741
		public unsafe LineInfo incReadLineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLineInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLineInfo)) = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00038B54 File Offset: 0x00036D54
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x0000455C File Offset: 0x0000275C
		public unsafe int incReadDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDepth)) = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00038B7C File Offset: 0x00036D7C
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00004577 File Offset: 0x00002777
		public unsafe int incReadLeftStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftStartPos)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00038BA4 File Offset: 0x00036DA4
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00004592 File Offset: 0x00002792
		public unsafe int incReadLeftEndPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftEndPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftEndPos)) = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00038BCC File Offset: 0x00036DCC
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x000045AD File Offset: 0x000027AD
		public unsafe int attributeValueBaseEntityId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attributeValueBaseEntityId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attributeValueBaseEntityId)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00038BF4 File Offset: 0x00036DF4
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x000045C8 File Offset: 0x000027C8
		public unsafe bool emptyEntityInAttributeResolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_emptyEntityInAttributeResolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_emptyEntityInAttributeResolved)) = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00038C1C File Offset: 0x00036E1C
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x000045E3 File Offset: 0x000027E3
		public unsafe IValidationEventHandling validationEventHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validationEventHandling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validationEventHandling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00038C4C File Offset: 0x00036E4C
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x00004602 File Offset: 0x00002802
		public unsafe XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_onDefaultAttributeUse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_onDefaultAttributeUse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00038C7C File Offset: 0x00036E7C
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00004621 File Offset: 0x00002821
		public unsafe bool validatingReaderCompatFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validatingReaderCompatFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validatingReaderCompatFlag)) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00038CA4 File Offset: 0x00036EA4
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x0000463C File Offset: 0x0000283C
		public unsafe bool addDefaultAttributesAndNormalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_addDefaultAttributesAndNormalize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_addDefaultAttributesAndNormalize)) = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00038CCC File Offset: 0x00036ECC
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00004657 File Offset: 0x00002857
		public unsafe StringBuilder stringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_stringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00038CFC File Offset: 0x00036EFC
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x00004676 File Offset: 0x00002876
		public unsafe bool rootElementParsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_rootElementParsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_rootElementParsed)) = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00038D24 File Offset: 0x00036F24
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x00004691 File Offset: 0x00002891
		public unsafe bool standalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_standalone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_standalone)) = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00038D4C File Offset: 0x00036F4C
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x000046AC File Offset: 0x000028AC
		public unsafe int nextEntityId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextEntityId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextEntityId)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00038D74 File Offset: 0x00036F74
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x000046C7 File Offset: 0x000028C7
		public unsafe XmlTextReaderImpl.ParsingMode parsingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingMode)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00038D9C File Offset: 0x00036F9C
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x000046E2 File Offset: 0x000028E2
		public unsafe ReadState readState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readState)) = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00038DC4 File Offset: 0x00036FC4
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x000046FD File Offset: 0x000028FD
		public unsafe IDtdEntityInfo lastEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00038DF4 File Offset: 0x00036FF4
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x0000471C File Offset: 0x0000291C
		public unsafe bool afterResetState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_afterResetState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_afterResetState)) = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00038E1C File Offset: 0x0003701C
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00004737 File Offset: 0x00002937
		public unsafe int documentStartBytePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_documentStartBytePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_documentStartBytePos)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00038E44 File Offset: 0x00037044
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00004752 File Offset: 0x00002952
		public unsafe int readValueOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readValueOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readValueOffset)) = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00038E6C File Offset: 0x0003706C
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x0000476D File Offset: 0x0000296D
		public unsafe long charactersInDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersInDocument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersInDocument)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00038E94 File Offset: 0x00037094
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00004788 File Offset: 0x00002988
		public unsafe long charactersFromEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersFromEntities);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersFromEntities)) = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00038EBC File Offset: 0x000370BC
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x000047A3 File Offset: 0x000029A3
		public unsafe Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_currentEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IDtdEntityInfo, IDtdEntityInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_currentEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00038EEC File Offset: 0x000370EC
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x000047C2 File Offset: 0x000029C2
		public unsafe bool disableUndeclaredEntityCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_disableUndeclaredEntityCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_disableUndeclaredEntityCheck)) = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00038F14 File Offset: 0x00037114
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x000047DD File Offset: 0x000029DD
		public unsafe XmlReader outerReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_outerReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_outerReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00038F44 File Offset: 0x00037144
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x000047FC File Offset: 0x000029FC
		public unsafe bool xmlResolverIsSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolverIsSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolverIsSet)) = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00038F6C File Offset: 0x0003716C
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00004817 File Offset: 0x00002A17
		public unsafe string Xml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_Xml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_Xml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00038F94 File Offset: 0x00037194
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x00004836 File Offset: 0x00002A36
		public unsafe string XmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_XmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_XmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00038FBC File Offset: 0x000371BC
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x00004855 File Offset: 0x00002A55
		public unsafe Task<Tuple<int, int, int, bool>> parseText_dummyTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parseText_dummyTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<Tuple<int, int, int, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parseText_dummyTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_useAsync;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_laterInitParam;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_ps;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_parsingFunction;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_nextParsingFunction;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr_nextNextParsingFunction;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_nodes;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_curNode;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_curAttrIndex;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr_attrCount;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_attrHashtable;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_attrDuplWalkCount;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_attrNeedNamespaceLookup;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr_fullAttrCleanup;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_attrDuplSortingArray;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_nameTableFromSettings;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr_normalize;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_supportNamespaces;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr_whitespaceHandling;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_dtdProcessing;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr_entityHandling;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeFieldInfoPtr_ignorePIs;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeFieldInfoPtr_ignoreComments;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeFieldInfoPtr_lineNumberOffset;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeFieldInfoPtr_linePositionOffset;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr_closeInput;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersInDocument;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersFromEntities;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeFieldInfoPtr_v1Compat;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_namespaceManager;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeFieldInfoPtr_lastPrefix;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr_xmlContext;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr_parsingStatesStack;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr_parsingStatesStackTop;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeFieldInfoPtr_reportedBaseUri;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeFieldInfoPtr_reportedEncoding;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeFieldInfoPtr_dtdInfo;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeFieldInfoPtr_fragmentType;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeFieldInfoPtr_fragmentParserContext;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_fragment;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_incReadDecoder;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_incReadState;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr_incReadLineInfo;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr_incReadDepth;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeFieldInfoPtr_incReadLeftStartPos;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr_incReadLeftEndPos;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr_attributeValueBaseEntityId;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr_emptyEntityInAttributeResolved;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeFieldInfoPtr_validationEventHandling;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeFieldInfoPtr_onDefaultAttributeUse;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeFieldInfoPtr_validatingReaderCompatFlag;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr_addDefaultAttributesAndNormalize;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr_rootElementParsed;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeFieldInfoPtr_standalone;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeFieldInfoPtr_nextEntityId;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeFieldInfoPtr_parsingMode;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr_readState;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr_lastEntity;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_afterResetState;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_documentStartBytePos;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_readValueOffset;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeFieldInfoPtr_charactersInDocument;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeFieldInfoPtr_charactersFromEntities;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeFieldInfoPtr_currentEntities;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeFieldInfoPtr_disableUndeclaredEntityCheck;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeFieldInfoPtr_outerReader;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolverIsSet;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr_Xml;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeFieldInfoPtr_XmlNs;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeFieldInfoPtr_parseText_dummyTask;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlNameTable_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_XmlResolver_XmlReaderSettings_XmlParserContext_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Stream_XmlNameTable_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlNameTable_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_TextReader_XmlNameTable_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_XmlNodeType_XmlParserContext_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitUriString_Private_Void_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_Il2CppStructArray_1_Byte_Int32_XmlReaderSettings_Uri_String_XmlParserContext_Boolean_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitStream_Private_Void_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlReaderSettings_String_XmlParserContext_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitTextReader_Private_Void_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_XmlReaderSettings_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_FinishInit_Private_Void_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_Skip_Public_Virtual_Void_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_set_OuterReader_Internal_set_Void_XmlReader_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_MoveOffEntityReference_Internal_Void_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Public_Virtual_String_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_get_CanReadValueChunk_Public_Virtual_get_Boolean_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_ReadValueChunk_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespaces_Internal_get_Boolean_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Boolean_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_get_Normalization_Internal_get_Boolean_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_set_Normalization_Internal_set_Void_Boolean_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_set_WhitespaceHandling_Internal_set_Void_WhitespaceHandling_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityHandling_Internal_set_Void_EntityHandling_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_get_IsResolverSet_Internal_get_Boolean_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_NameTable_Internal_get_XmlNameTable_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_NamespaceResolver_Internal_get_IXmlNamespaceResolver_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_DtdValidation_Internal_get_Boolean_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_Normalization_Internal_get_Boolean_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_Namespaces_Internal_get_Boolean_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_V1CompatibilityMode_Internal_get_Boolean_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_BaseUri_Internal_get_Uri_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_IsEof_Internal_get_Boolean_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_ParsingBuffer_Internal_get_Il2CppStructArray_1_Char_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_ParsingBufferLength_Internal_get_Int32_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_CurrentPosition_Internal_get_Int32_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdParserProxy_CurrentPosition_Internal_set_Void_Int32_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_EntityStackLength_Internal_get_Int32_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_IsEntityEolNormalized_Internal_get_Boolean_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_ValidationEventHandling_Internal_get_IValidationEventHandling_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_OnNewLine_Internal_Void_Int32_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_LineNo_Internal_get_Int32_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_LineStartPosition_Internal_get_Int32_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ReadData_Internal_Int32_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParseNumericCharRef_Internal_Int32_StringBuilder_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParseNamedCharRef_Internal_Int32_Boolean_StringBuilder_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParsePI_Internal_Void_StringBuilder_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParseComment_Internal_Void_StringBuilder_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_get_IsResolverNull_Private_get_Boolean_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_GetTempResolver_Private_XmlResolver_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PushEntity_Internal_Boolean_IDtdEntityInfo_byref_Int32_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PopEntity_Internal_Boolean_byref_IDtdEntityInfo_byref_Int32_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PushExternalSubset_Internal_Boolean_String_String_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PushInternalDtd_Internal_Void_String_String_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_Throw_Internal_Void_Exception_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_OnSystemId_Internal_Void_String_LineInfo_LineInfo_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_OnPublicId_Internal_Void_String_LineInfo_LineInfo_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_Int32_Int32_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_Exception_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_Exception_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Exception_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_ReThrow_Private_Void_Exception_Int32_Int32_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_String_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_Il2CppStringArray_Exception_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_SetErrorState_Private_Void_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_Int32_Int32_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_get_InAttributeValueIterator_Private_get_Boolean_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_FinishAttributeValueIterator_Private_Void_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdValidation_Private_get_Boolean_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Stream_Encoding_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_String_Stream_Encoding_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_Stream_Encoding_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Encoding_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Il2CppStructArray_1_Byte_Int32_Encoding_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_TextReader_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_Uri_TextReader_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_InitStringInput_Private_Void_String_Encoding_String_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_InitFragmentReader_Private_Void_XmlNodeType_XmlParserContext_Boolean_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDtdFromParserContext_Private_Void_XmlParserContext_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_OpenUrl_Private_Void_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_OpenUrlDelegate_Private_Void_Object_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_DetectEncoding_Private_Encoding_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_SetupEncoding_Private_Void_Encoding_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_SwitchEncoding_Private_Void_Encoding_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_CheckEncoding_Private_Encoding_String_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_UnDecodeChars_Private_Void_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_SwitchEncodingToUTF8_Private_Void_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Private_Int32_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Private_Int32_Int32_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_InvalidCharRecovery_Private_Void_byref_Int32_byref_Int32_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_Close_Internal_Void_Boolean_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_ShiftBuffer_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_ParseXmlDeclaration_Private_Boolean_Boolean_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_ParseDocumentContent_Private_Boolean_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementContent_Private_Boolean_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnclosedElements_Private_Void_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_ParseElement_Private_Void_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributesAndNormalize_Private_Void_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_ParseEndElement_Private_Void_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_ThrowTagMismatch_Private_Void_NodeData_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttributes_Private_Void_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_ElementNamespaceLookup_Private_Void_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_AttributeNamespaceLookup_Private_Void_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_AttributeDuplCheck_Private_Void_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_OnDefaultNamespaceDecl_Private_Void_NodeData_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_OnNamespaceDecl_Private_Void_NodeData_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_OnXmlReservedAttribute_Private_Void_NodeData_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttributeValueSlow_Private_Void_Int32_Char_NodeData_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributeChunkToList_Private_Void_NodeData_NodeData_byref_NodeData_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_ParseText_Private_Boolean_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_ParseText_Private_Boolean_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_FinishPartialValue_Private_Void_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_FinishOtherValueIterator_Private_Void_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_SkipPartialTextValue_Private_Void_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadValueChunk_Private_Void_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadContentAsBinary_Private_Void_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadElementContentAsBinary_Private_Void_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_ParseRootLevelWhitespace_Private_Boolean_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_ParseEntityReference_Private_Void_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityReference_Private_EntityType_Boolean_EntityExpandType_byref_Int32_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_HandleGeneralEntityReference_Private_EntityType_String_Boolean_Boolean_Int32_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_get_InEntity_Private_get_Boolean_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_SetupEndEntityNodeInContent_Private_Void_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_SetupEndEntityNodeInAttribute_Private_Void_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Private_Boolean_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Private_Boolean_StringBuilder_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_ParsePIValue_Private_Boolean_byref_Int32_byref_Int32_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_ParseComment_Private_Boolean_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_ParseCData_Private_Void_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_ParseCDataOrComment_Private_Void_XmlNodeType_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_ParseCDataOrComment_Private_Boolean_XmlNodeType_byref_Int32_byref_Int32_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_ParseDoctypeDecl_Private_Boolean_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtd_Private_Void_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_SkipDtd_Private_Void_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_SkipPublicOrSystemIdLiteral_Private_Void_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_SkipUntil_Private_Void_Char_Boolean_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_EatWhitespaces_Private_Int32_StringBuilder_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_ParseCharRefInline_Private_Int32_Int32_byref_Int32_byref_EntityType_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumericCharRef_Private_Int32_Boolean_StringBuilder_byref_EntityType_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumericCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_byref_Int32_byref_EntityType_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_ParseNamedCharRef_Private_Int32_Boolean_StringBuilder_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_ParseNamedCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_ParseName_Private_Int32_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_ParseQName_Private_Int32_byref_Int32_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_ParseQName_Private_Int32_Boolean_Int32_byref_Int32_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_ReadDataInName_Private_Boolean_byref_Int32_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_ParseEntityName_Private_String_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_AddNode_Private_NodeData_Int32_Int32_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_AllocNode_Private_NodeData_Int32_Int32_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributeNoChecks_Private_NodeData_String_Int32_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_NodeData_Int32_Int32_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_NodeData_String_String_String_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_PopElementContext_Private_Void_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_OnEof_Private_Void_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Private_String_NodeData_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NodeData_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_ResetAttributes_Private_Void_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_FullAttributeCleanup_Private_Void_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_PushXmlContext_Private_Void_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_PopXmlContext_Private_Void_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_GetWhitespaceType_Private_XmlNodeType_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_GetTextNodeType_Private_XmlNodeType_Int32_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_PushExternalEntityOrSubset_Private_Void_String_String_Uri_String_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_OpenAndPush_Private_Boolean_Uri_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_PushExternalEntity_Private_Boolean_IDtdEntityInfo_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_PushInternalEntity_Private_Void_IDtdEntityInfo_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_PopEntity_Private_Void_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEntity_Private_Void_IDtdEntityInfo_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEntity_Private_Void_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_PushParsingState_Private_Void_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_PopParsingState_Private_Void_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_IncrementalRead_Private_Int32_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_FinishIncrementalRead_Private_Void_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_ParseFragmentAttribute_Private_Boolean_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttributeValueChunk_Private_Boolean_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_ParseXmlDeclarationFragment_Private_Void_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_String_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_ThrowExpectingWhitespace_Private_Void_Int32_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexOfAttributeWithoutPrefix_Private_Int32_String_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexOfAttributeWithPrefix_Private_Int32_String_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_ZeroEndingStream_Private_Boolean_Int32_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_SetupFromParserContext_Private_Void_XmlParserContext_XmlReaderSettings_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_SetDtdInfo_Internal_Void_IDtdInfo_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_set_ValidationEventHandling_Internal_set_Void_IValidationEventHandling_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_set_OnDefaultAttributeUse_Internal_set_Void_OnDefaultAttributeUseDelegate_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_get_FragmentType_Internal_get_XmlNodeType_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCurrentNodeType_Internal_Void_XmlNodeType_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalSchemaType_Internal_set_Void_Object_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalTypedValue_Internal_get_Object_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalTypedValue_Internal_set_Void_Object_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_get_StandAlone_Internal_get_Boolean_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceManager_Internal_Virtual_get_XmlNamespaceManager_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_get_V1Compat_Internal_get_Boolean_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributeDtd_Private_Boolean_IDtdDefaultAttributeInfo_Boolean_Il2CppReferenceArray_1_NodeData_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributeNonDtd_Internal_Boolean_SchemaAttDef_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributeInternal_Private_NodeData_String_String_String_String_Int32_Int32_Int32_Int32_Boolean_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_set_DisableUndeclaredEntityCheck_Internal_set_Void_Boolean_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_UriEqual_Private_Boolean_Uri_String_String_XmlResolver_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConsumedCharacters_Private_Void_Int64_Boolean_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_StripSpaces_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_byref_Int32_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_BlockCopyChars_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_BlockCopy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0200021B RID: 539
		public enum ParsingFunction
		{
			// Token: 0x040023C9 RID: 9161
			ElementContent,
			// Token: 0x040023CA RID: 9162
			NoData,
			// Token: 0x040023CB RID: 9163
			OpenUrl,
			// Token: 0x040023CC RID: 9164
			SwitchToInteractive,
			// Token: 0x040023CD RID: 9165
			SwitchToInteractiveXmlDecl,
			// Token: 0x040023CE RID: 9166
			DocumentContent,
			// Token: 0x040023CF RID: 9167
			MoveToElementContent,
			// Token: 0x040023D0 RID: 9168
			PopElementContext,
			// Token: 0x040023D1 RID: 9169
			PopEmptyElementContext,
			// Token: 0x040023D2 RID: 9170
			ResetAttributesRootLevel,
			// Token: 0x040023D3 RID: 9171
			Error,
			// Token: 0x040023D4 RID: 9172
			Eof,
			// Token: 0x040023D5 RID: 9173
			ReaderClosed,
			// Token: 0x040023D6 RID: 9174
			EntityReference,
			// Token: 0x040023D7 RID: 9175
			InIncrementalRead,
			// Token: 0x040023D8 RID: 9176
			FragmentAttribute,
			// Token: 0x040023D9 RID: 9177
			ReportEndEntity,
			// Token: 0x040023DA RID: 9178
			AfterResolveEntityInContent,
			// Token: 0x040023DB RID: 9179
			AfterResolveEmptyEntityInContent,
			// Token: 0x040023DC RID: 9180
			XmlDeclarationFragment,
			// Token: 0x040023DD RID: 9181
			GoToEof,
			// Token: 0x040023DE RID: 9182
			PartialTextValue,
			// Token: 0x040023DF RID: 9183
			InReadAttributeValue,
			// Token: 0x040023E0 RID: 9184
			InReadValueChunk,
			// Token: 0x040023E1 RID: 9185
			InReadContentAsBinary,
			// Token: 0x040023E2 RID: 9186
			InReadElementContentAsBinary
		}

		// Token: 0x0200021C RID: 540
		public enum ParsingMode
		{
			// Token: 0x040023E4 RID: 9188
			Full,
			// Token: 0x040023E5 RID: 9189
			SkipNode,
			// Token: 0x040023E6 RID: 9190
			SkipContent
		}

		// Token: 0x0200021D RID: 541
		public enum EntityType
		{
			// Token: 0x040023E8 RID: 9192
			CharacterDec,
			// Token: 0x040023E9 RID: 9193
			CharacterHex,
			// Token: 0x040023EA RID: 9194
			CharacterNamed,
			// Token: 0x040023EB RID: 9195
			Expanded,
			// Token: 0x040023EC RID: 9196
			Skipped,
			// Token: 0x040023ED RID: 9197
			FakeExpanded,
			// Token: 0x040023EE RID: 9198
			Unexpanded,
			// Token: 0x040023EF RID: 9199
			ExpandedInAttribute
		}

		// Token: 0x0200021E RID: 542
		public enum EntityExpandType
		{
			// Token: 0x040023F1 RID: 9201
			All,
			// Token: 0x040023F2 RID: 9202
			OnlyGeneral,
			// Token: 0x040023F3 RID: 9203
			OnlyCharacter
		}

		// Token: 0x0200021F RID: 543
		public enum IncrementalReadState
		{
			// Token: 0x040023F5 RID: 9205
			Text,
			// Token: 0x040023F6 RID: 9206
			StartTag,
			// Token: 0x040023F7 RID: 9207
			PI,
			// Token: 0x040023F8 RID: 9208
			CDATA,
			// Token: 0x040023F9 RID: 9209
			Comment,
			// Token: 0x040023FA RID: 9210
			Attributes,
			// Token: 0x040023FB RID: 9211
			AttributeValue,
			// Token: 0x040023FC RID: 9212
			ReadData,
			// Token: 0x040023FD RID: 9213
			EndElement,
			// Token: 0x040023FE RID: 9214
			End,
			// Token: 0x040023FF RID: 9215
			ReadValueChunk_OnCachedValue,
			// Token: 0x04002400 RID: 9216
			ReadValueChunk_OnPartialValue,
			// Token: 0x04002401 RID: 9217
			ReadContentAsBinary_OnCachedValue,
			// Token: 0x04002402 RID: 9218
			ReadContentAsBinary_OnPartialValue,
			// Token: 0x04002403 RID: 9219
			ReadContentAsBinary_End
		}

		// Token: 0x02000220 RID: 544
		public class LaterInitParam : Object
		{
			// Token: 0x06002F0C RID: 12044 RVA: 0x000D601C File Offset: 0x000D421C
			// Note: this type is marked as 'beforefieldinit'.
			static LaterInitParam()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "LaterInitParam");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr);
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "useAsync");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputStream");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputBytes");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputByteCount");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputbaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputbaseUri");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputUriStr");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputUriResolver");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputContext");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputTextReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputTextReader");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_initType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "initType");
				XmlTextReaderImpl.LaterInitParam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, 100664565);
			}

			// Token: 0x06002F0D RID: 12045 RVA: 0x000D6124 File Offset: 0x000D4324
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 367191, RefRangeEnd = 367193, XrefRangeStart = 367190, XrefRangeEnd = 367191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LaterInitParam()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.LaterInitParam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F0E RID: 12046 RVA: 0x0001384A File Offset: 0x00011A4A
			public LaterInitParam(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FCE RID: 4046
			// (get) Token: 0x06002F0F RID: 12047 RVA: 0x000D6160 File Offset: 0x000D4360
			// (set) Token: 0x06002F10 RID: 12048 RVA: 0x00013853 File Offset: 0x00011A53
			public unsafe bool useAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_useAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_useAsync)) = value;
				}
			}

			// Token: 0x17000FCF RID: 4047
			// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000D6188 File Offset: 0x000D4388
			// (set) Token: 0x06002F12 RID: 12050 RVA: 0x0001386E File Offset: 0x00011A6E
			public unsafe Stream inputStream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputStream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputStream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD0 RID: 4048
			// (get) Token: 0x06002F13 RID: 12051 RVA: 0x000D61B8 File Offset: 0x000D43B8
			// (set) Token: 0x06002F14 RID: 12052 RVA: 0x0001388D File Offset: 0x00011A8D
			public unsafe Il2CppStructArray<byte> inputBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputBytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD1 RID: 4049
			// (get) Token: 0x06002F15 RID: 12053 RVA: 0x000D61E8 File Offset: 0x000D43E8
			// (set) Token: 0x06002F16 RID: 12054 RVA: 0x000138AC File Offset: 0x00011AAC
			public unsafe int inputByteCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputByteCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputByteCount)) = value;
				}
			}

			// Token: 0x17000FD2 RID: 4050
			// (get) Token: 0x06002F17 RID: 12055 RVA: 0x000D6210 File Offset: 0x000D4410
			// (set) Token: 0x06002F18 RID: 12056 RVA: 0x000138C7 File Offset: 0x00011AC7
			public unsafe Uri inputbaseUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputbaseUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputbaseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD3 RID: 4051
			// (get) Token: 0x06002F19 RID: 12057 RVA: 0x000D6240 File Offset: 0x000D4440
			// (set) Token: 0x06002F1A RID: 12058 RVA: 0x000138E6 File Offset: 0x00011AE6
			public unsafe string inputUriStr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriStr);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriStr), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FD4 RID: 4052
			// (get) Token: 0x06002F1B RID: 12059 RVA: 0x000D6268 File Offset: 0x000D4468
			// (set) Token: 0x06002F1C RID: 12060 RVA: 0x00013905 File Offset: 0x00011B05
			public unsafe XmlResolver inputUriResolver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriResolver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD5 RID: 4053
			// (get) Token: 0x06002F1D RID: 12061 RVA: 0x000D6298 File Offset: 0x000D4498
			// (set) Token: 0x06002F1E RID: 12062 RVA: 0x00013924 File Offset: 0x00011B24
			public unsafe XmlParserContext inputContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlParserContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD6 RID: 4054
			// (get) Token: 0x06002F1F RID: 12063 RVA: 0x000D62C8 File Offset: 0x000D44C8
			// (set) Token: 0x06002F20 RID: 12064 RVA: 0x00013943 File Offset: 0x00011B43
			public unsafe TextReader inputTextReader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputTextReader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputTextReader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD7 RID: 4055
			// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000D62F8 File Offset: 0x000D44F8
			// (set) Token: 0x06002F22 RID: 12066 RVA: 0x00013962 File Offset: 0x00011B62
			public unsafe XmlTextReaderImpl.InitInputType initType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_initType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_initType)) = value;
				}
			}

			// Token: 0x04002404 RID: 9220
			private static readonly IntPtr NativeFieldInfoPtr_useAsync;

			// Token: 0x04002405 RID: 9221
			private static readonly IntPtr NativeFieldInfoPtr_inputStream;

			// Token: 0x04002406 RID: 9222
			private static readonly IntPtr NativeFieldInfoPtr_inputBytes;

			// Token: 0x04002407 RID: 9223
			private static readonly IntPtr NativeFieldInfoPtr_inputByteCount;

			// Token: 0x04002408 RID: 9224
			private static readonly IntPtr NativeFieldInfoPtr_inputbaseUri;

			// Token: 0x04002409 RID: 9225
			private static readonly IntPtr NativeFieldInfoPtr_inputUriStr;

			// Token: 0x0400240A RID: 9226
			private static readonly IntPtr NativeFieldInfoPtr_inputUriResolver;

			// Token: 0x0400240B RID: 9227
			private static readonly IntPtr NativeFieldInfoPtr_inputContext;

			// Token: 0x0400240C RID: 9228
			private static readonly IntPtr NativeFieldInfoPtr_inputTextReader;

			// Token: 0x0400240D RID: 9229
			private static readonly IntPtr NativeFieldInfoPtr_initType;

			// Token: 0x0400240E RID: 9230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000221 RID: 545
		public enum InitInputType
		{
			// Token: 0x04002410 RID: 9232
			UriString,
			// Token: 0x04002411 RID: 9233
			Stream,
			// Token: 0x04002412 RID: 9234
			TextReader,
			// Token: 0x04002413 RID: 9235
			Invalid
		}

		// Token: 0x02000222 RID: 546
		public sealed class ParsingState : ValueType
		{
			// Token: 0x06002F23 RID: 12067 RVA: 0x000D6320 File Offset: 0x000D4520
			// Note: this type is marked as 'beforefieldinit'.
			static ParsingState()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ParsingState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr);
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "chars");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "charPos");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "charsUsed");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "encoding");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_appendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "appendMode");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "stream");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "decoder");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "bytes");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "bytePos");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytesUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "bytesUsed");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_textReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "textReader");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "lineNo");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "lineStartPos");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUriStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "baseUriStr");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "baseUri");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isEof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "isEof");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isStreamEof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "isStreamEof");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "entity");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "entityId");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_eolNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "eolNormalized");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityResolvedManually = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "entityResolvedManually");
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100664566);
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100664567);
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100664568);
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100664569);
			}

			// Token: 0x06002F24 RID: 12068 RVA: 0x000D6540 File Offset: 0x000D4740
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 367203, RefRangeEnd = 367204, XrefRangeStart = 367193, XrefRangeEnd = 367203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F25 RID: 12069 RVA: 0x000D6578 File Offset: 0x000D4778
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 367204, RefRangeEnd = 367207, XrefRangeStart = 367204, XrefRangeEnd = 367204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Close(bool closeInput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref closeInput;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000FED RID: 4077
			// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000D65BC File Offset: 0x000D47BC
			public unsafe int LineNo
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000FEE RID: 4078
			// (get) Token: 0x06002F27 RID: 12071 RVA: 0x000D6600 File Offset: 0x000D4800
			public unsafe int LinePos
			{
				[CallerCount(27)]
				[CachedScanResults(RefRangeStart = 367207, RefRangeEnd = 367234, XrefRangeStart = 367207, XrefRangeEnd = 367207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002F28 RID: 12072 RVA: 0x0001397D File Offset: 0x00011B7D
			public ParsingState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F29 RID: 12073 RVA: 0x00013986 File Offset: 0x00011B86
			public ParsingState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr))
			{
			}

			// Token: 0x17000FD8 RID: 4056
			// (get) Token: 0x06002F2A RID: 12074 RVA: 0x000D6644 File Offset: 0x000D4844
			// (set) Token: 0x06002F2B RID: 12075 RVA: 0x00013998 File Offset: 0x00011B98
			public unsafe Il2CppStructArray<char> chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_chars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD9 RID: 4057
			// (get) Token: 0x06002F2C RID: 12076 RVA: 0x000D6674 File Offset: 0x000D4874
			// (set) Token: 0x06002F2D RID: 12077 RVA: 0x000139B7 File Offset: 0x00011BB7
			public unsafe int charPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charPos)) = value;
				}
			}

			// Token: 0x17000FDA RID: 4058
			// (get) Token: 0x06002F2E RID: 12078 RVA: 0x000D669C File Offset: 0x000D489C
			// (set) Token: 0x06002F2F RID: 12079 RVA: 0x000139D2 File Offset: 0x00011BD2
			public unsafe int charsUsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charsUsed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charsUsed)) = value;
				}
			}

			// Token: 0x17000FDB RID: 4059
			// (get) Token: 0x06002F30 RID: 12080 RVA: 0x000D66C4 File Offset: 0x000D48C4
			// (set) Token: 0x06002F31 RID: 12081 RVA: 0x000139ED File Offset: 0x00011BED
			public unsafe Encoding encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FDC RID: 4060
			// (get) Token: 0x06002F32 RID: 12082 RVA: 0x000D66F4 File Offset: 0x000D48F4
			// (set) Token: 0x06002F33 RID: 12083 RVA: 0x00013A0C File Offset: 0x00011C0C
			public unsafe bool appendMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_appendMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_appendMode)) = value;
				}
			}

			// Token: 0x17000FDD RID: 4061
			// (get) Token: 0x06002F34 RID: 12084 RVA: 0x000D671C File Offset: 0x000D491C
			// (set) Token: 0x06002F35 RID: 12085 RVA: 0x00013A27 File Offset: 0x00011C27
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FDE RID: 4062
			// (get) Token: 0x06002F36 RID: 12086 RVA: 0x000D674C File Offset: 0x000D494C
			// (set) Token: 0x06002F37 RID: 12087 RVA: 0x00013A46 File Offset: 0x00011C46
			public unsafe Decoder decoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_decoder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FDF RID: 4063
			// (get) Token: 0x06002F38 RID: 12088 RVA: 0x000D677C File Offset: 0x000D497C
			// (set) Token: 0x06002F39 RID: 12089 RVA: 0x00013A65 File Offset: 0x00011C65
			public unsafe Il2CppStructArray<byte> bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE0 RID: 4064
			// (get) Token: 0x06002F3A RID: 12090 RVA: 0x000D67AC File Offset: 0x000D49AC
			// (set) Token: 0x06002F3B RID: 12091 RVA: 0x00013A84 File Offset: 0x00011C84
			public unsafe int bytePos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytePos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytePos)) = value;
				}
			}

			// Token: 0x17000FE1 RID: 4065
			// (get) Token: 0x06002F3C RID: 12092 RVA: 0x000D67D4 File Offset: 0x000D49D4
			// (set) Token: 0x06002F3D RID: 12093 RVA: 0x00013A9F File Offset: 0x00011C9F
			public unsafe int bytesUsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytesUsed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytesUsed)) = value;
				}
			}

			// Token: 0x17000FE2 RID: 4066
			// (get) Token: 0x06002F3E RID: 12094 RVA: 0x000D67FC File Offset: 0x000D49FC
			// (set) Token: 0x06002F3F RID: 12095 RVA: 0x00013ABA File Offset: 0x00011CBA
			public unsafe TextReader textReader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_textReader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_textReader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE3 RID: 4067
			// (get) Token: 0x06002F40 RID: 12096 RVA: 0x000D682C File Offset: 0x000D4A2C
			// (set) Token: 0x06002F41 RID: 12097 RVA: 0x00013AD9 File Offset: 0x00011CD9
			public unsafe int lineNo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineNo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineNo)) = value;
				}
			}

			// Token: 0x17000FE4 RID: 4068
			// (get) Token: 0x06002F42 RID: 12098 RVA: 0x000D6854 File Offset: 0x000D4A54
			// (set) Token: 0x06002F43 RID: 12099 RVA: 0x00013AF4 File Offset: 0x00011CF4
			public unsafe int lineStartPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineStartPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineStartPos)) = value;
				}
			}

			// Token: 0x17000FE5 RID: 4069
			// (get) Token: 0x06002F44 RID: 12100 RVA: 0x000D687C File Offset: 0x000D4A7C
			// (set) Token: 0x06002F45 RID: 12101 RVA: 0x00013B0F File Offset: 0x00011D0F
			public unsafe string baseUriStr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUriStr);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUriStr), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FE6 RID: 4070
			// (get) Token: 0x06002F46 RID: 12102 RVA: 0x000D68A4 File Offset: 0x000D4AA4
			// (set) Token: 0x06002F47 RID: 12103 RVA: 0x00013B2E File Offset: 0x00011D2E
			public unsafe Uri baseUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE7 RID: 4071
			// (get) Token: 0x06002F48 RID: 12104 RVA: 0x000D68D4 File Offset: 0x000D4AD4
			// (set) Token: 0x06002F49 RID: 12105 RVA: 0x00013B4D File Offset: 0x00011D4D
			public unsafe bool isEof
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isEof);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isEof)) = value;
				}
			}

			// Token: 0x17000FE8 RID: 4072
			// (get) Token: 0x06002F4A RID: 12106 RVA: 0x000D68FC File Offset: 0x000D4AFC
			// (set) Token: 0x06002F4B RID: 12107 RVA: 0x00013B68 File Offset: 0x00011D68
			public unsafe bool isStreamEof
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isStreamEof);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isStreamEof)) = value;
				}
			}

			// Token: 0x17000FE9 RID: 4073
			// (get) Token: 0x06002F4C RID: 12108 RVA: 0x000D6924 File Offset: 0x000D4B24
			// (set) Token: 0x06002F4D RID: 12109 RVA: 0x00013B83 File Offset: 0x00011D83
			public unsafe IDtdEntityInfo entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FEA RID: 4074
			// (get) Token: 0x06002F4E RID: 12110 RVA: 0x000D6954 File Offset: 0x000D4B54
			// (set) Token: 0x06002F4F RID: 12111 RVA: 0x00013BA2 File Offset: 0x00011DA2
			public unsafe int entityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityId)) = value;
				}
			}

			// Token: 0x17000FEB RID: 4075
			// (get) Token: 0x06002F50 RID: 12112 RVA: 0x000D697C File Offset: 0x000D4B7C
			// (set) Token: 0x06002F51 RID: 12113 RVA: 0x00013BBD File Offset: 0x00011DBD
			public unsafe bool eolNormalized
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_eolNormalized);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_eolNormalized)) = value;
				}
			}

			// Token: 0x17000FEC RID: 4076
			// (get) Token: 0x06002F52 RID: 12114 RVA: 0x000D69A4 File Offset: 0x000D4BA4
			// (set) Token: 0x06002F53 RID: 12115 RVA: 0x00013BD8 File Offset: 0x00011DD8
			public unsafe bool entityResolvedManually
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityResolvedManually);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityResolvedManually)) = value;
				}
			}

			// Token: 0x04002414 RID: 9236
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x04002415 RID: 9237
			private static readonly IntPtr NativeFieldInfoPtr_charPos;

			// Token: 0x04002416 RID: 9238
			private static readonly IntPtr NativeFieldInfoPtr_charsUsed;

			// Token: 0x04002417 RID: 9239
			private static readonly IntPtr NativeFieldInfoPtr_encoding;

			// Token: 0x04002418 RID: 9240
			private static readonly IntPtr NativeFieldInfoPtr_appendMode;

			// Token: 0x04002419 RID: 9241
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x0400241A RID: 9242
			private static readonly IntPtr NativeFieldInfoPtr_decoder;

			// Token: 0x0400241B RID: 9243
			private static readonly IntPtr NativeFieldInfoPtr_bytes;

			// Token: 0x0400241C RID: 9244
			private static readonly IntPtr NativeFieldInfoPtr_bytePos;

			// Token: 0x0400241D RID: 9245
			private static readonly IntPtr NativeFieldInfoPtr_bytesUsed;

			// Token: 0x0400241E RID: 9246
			private static readonly IntPtr NativeFieldInfoPtr_textReader;

			// Token: 0x0400241F RID: 9247
			private static readonly IntPtr NativeFieldInfoPtr_lineNo;

			// Token: 0x04002420 RID: 9248
			private static readonly IntPtr NativeFieldInfoPtr_lineStartPos;

			// Token: 0x04002421 RID: 9249
			private static readonly IntPtr NativeFieldInfoPtr_baseUriStr;

			// Token: 0x04002422 RID: 9250
			private static readonly IntPtr NativeFieldInfoPtr_baseUri;

			// Token: 0x04002423 RID: 9251
			private static readonly IntPtr NativeFieldInfoPtr_isEof;

			// Token: 0x04002424 RID: 9252
			private static readonly IntPtr NativeFieldInfoPtr_isStreamEof;

			// Token: 0x04002425 RID: 9253
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x04002426 RID: 9254
			private static readonly IntPtr NativeFieldInfoPtr_entityId;

			// Token: 0x04002427 RID: 9255
			private static readonly IntPtr NativeFieldInfoPtr_eolNormalized;

			// Token: 0x04002428 RID: 9256
			private static readonly IntPtr NativeFieldInfoPtr_entityResolvedManually;

			// Token: 0x04002429 RID: 9257
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

			// Token: 0x0400242A RID: 9258
			private static readonly IntPtr NativeMethodInfoPtr_Close_Internal_Void_Boolean_0;

			// Token: 0x0400242B RID: 9259
			private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0;

			// Token: 0x0400242C RID: 9260
			private static readonly IntPtr NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0;
		}

		// Token: 0x02000223 RID: 547
		public class XmlContext : Object
		{
			// Token: 0x06002F54 RID: 12116 RVA: 0x000D69CC File Offset: 0x000D4BCC
			// Note: this type is marked as 'beforefieldinit'.
			static XmlContext()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "XmlContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr);
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "xmlSpace");
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "xmlLang");
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_defaultNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "defaultNamespace");
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_previousContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "previousContext");
				XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, 100664570);
				XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_XmlContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, 100664571);
			}

			// Token: 0x06002F55 RID: 12117 RVA: 0x000D6A70 File Offset: 0x000D4C70
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 367241, RefRangeEnd = 367243, XrefRangeStart = 367234, XrefRangeEnd = 367241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlContext()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F56 RID: 12118 RVA: 0x000D6AAC File Offset: 0x000D4CAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 367248, RefRangeEnd = 367249, XrefRangeStart = 367243, XrefRangeEnd = 367248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlContext(XmlTextReaderImpl.XmlContext previousContext)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousContext);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_XmlContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F57 RID: 12119 RVA: 0x00013BF3 File Offset: 0x00011DF3
			public XmlContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FEF RID: 4079
			// (get) Token: 0x06002F58 RID: 12120 RVA: 0x000D6AF8 File Offset: 0x000D4CF8
			// (set) Token: 0x06002F59 RID: 12121 RVA: 0x00013BFC File Offset: 0x00011DFC
			public unsafe XmlSpace xmlSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlSpace)) = value;
				}
			}

			// Token: 0x17000FF0 RID: 4080
			// (get) Token: 0x06002F5A RID: 12122 RVA: 0x000D6B20 File Offset: 0x000D4D20
			// (set) Token: 0x06002F5B RID: 12123 RVA: 0x00013C17 File Offset: 0x00011E17
			public unsafe string xmlLang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlLang);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FF1 RID: 4081
			// (get) Token: 0x06002F5C RID: 12124 RVA: 0x000D6B48 File Offset: 0x000D4D48
			// (set) Token: 0x06002F5D RID: 12125 RVA: 0x00013C36 File Offset: 0x00011E36
			public unsafe string defaultNamespace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_defaultNamespace);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_defaultNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FF2 RID: 4082
			// (get) Token: 0x06002F5E RID: 12126 RVA: 0x000D6B70 File Offset: 0x000D4D70
			// (set) Token: 0x06002F5F RID: 12127 RVA: 0x00013C55 File Offset: 0x00011E55
			public unsafe XmlTextReaderImpl.XmlContext previousContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_previousContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.XmlContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_previousContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400242D RID: 9261
			private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

			// Token: 0x0400242E RID: 9262
			private static readonly IntPtr NativeFieldInfoPtr_xmlLang;

			// Token: 0x0400242F RID: 9263
			private static readonly IntPtr NativeFieldInfoPtr_defaultNamespace;

			// Token: 0x04002430 RID: 9264
			private static readonly IntPtr NativeFieldInfoPtr_previousContext;

			// Token: 0x04002431 RID: 9265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04002432 RID: 9266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlContext_0;
		}

		// Token: 0x02000224 RID: 548
		public class NoNamespaceManager : XmlNamespaceManager
		{
			// Token: 0x06002F60 RID: 12128 RVA: 0x000D6BA0 File Offset: 0x000D4DA0
			// Note: this type is marked as 'beforefieldinit'.
			static NoNamespaceManager()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "NoNamespaceManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664572);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664573);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664574);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664575);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664576);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_RemoveNamespace_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664577);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664578);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664579);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664580);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100664581);
			}

			// Token: 0x06002F61 RID: 12129 RVA: 0x000D6C94 File Offset: 0x000D4E94
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoNamespaceManager()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FF3 RID: 4083
			// (get) Token: 0x06002F62 RID: 12130 RVA: 0x000D6CD0 File Offset: 0x000D4ED0
			public unsafe override string DefaultNamespace
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367249, XrefRangeEnd = 367251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002F63 RID: 12131 RVA: 0x000D6D14 File Offset: 0x000D4F14
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PushScope()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F64 RID: 12132 RVA: 0x000D6D50 File Offset: 0x000D4F50
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool PopScope()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F65 RID: 12133 RVA: 0x000D6D98 File Offset: 0x000D4F98
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void AddNamespace(string prefix, string uri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F66 RID: 12134 RVA: 0x000D6DF8 File Offset: 0x000D4FF8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveNamespace(string prefix, string uri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_RemoveNamespace_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F67 RID: 12135 RVA: 0x000D6E58 File Offset: 0x000D5058
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002F68 RID: 12136 RVA: 0x000D6EA4 File Offset: 0x000D50A4
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref scope;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_IDictionary_2_String_String_XmlNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
				}
			}

			// Token: 0x06002F69 RID: 12137 RVA: 0x000D6EFC File Offset: 0x000D50FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367251, XrefRangeEnd = 367253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002F6A RID: 12138 RVA: 0x000D6F50 File Offset: 0x000D5150
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string LookupPrefix(string uri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002F6B RID: 12139 RVA: 0x00013C74 File Offset: 0x00011E74
			public NoNamespaceManager(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002433 RID: 9267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002434 RID: 9268
			private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_get_String_0;

			// Token: 0x04002435 RID: 9269
			private static readonly IntPtr NativeMethodInfoPtr_PushScope_Public_Virtual_Void_0;

			// Token: 0x04002436 RID: 9270
			private static readonly IntPtr NativeMethodInfoPtr_PopScope_Public_Virtual_Boolean_0;

			// Token: 0x04002437 RID: 9271
			private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Public_Virtual_Void_String_String_0;

			// Token: 0x04002438 RID: 9272
			private static readonly IntPtr NativeMethodInfoPtr_RemoveNamespace_Public_Virtual_Void_String_String_0;

			// Token: 0x04002439 RID: 9273
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

			// Token: 0x0400243A RID: 9274
			private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_IDictionary_2_String_String_XmlNamespaceScope_0;

			// Token: 0x0400243B RID: 9275
			private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

			// Token: 0x0400243C RID: 9276
			private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0;
		}

		// Token: 0x02000225 RID: 549
		public class DtdParserProxy : Object
		{
			// Token: 0x06002F6C RID: 12140 RVA: 0x000D6FA4 File Offset: 0x000D51A4
			// Note: this type is marked as 'beforefieldinit'.
			static DtdParserProxy()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "DtdParserProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr);
				XmlTextReaderImpl.DtdParserProxy.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, "reader");
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr__ctor_Internal_Void_XmlTextReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664582);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NameTable_Private_Virtual_Final_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664583);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NamespaceResolver_Private_Virtual_Final_New_get_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664584);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_BaseUri_Private_Virtual_Final_New_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664585);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEof_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664586);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBuffer_Private_Virtual_Final_New_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664587);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBufferLength_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664588);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_CurrentPosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664589);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_set_CurrentPosition_Private_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664590);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_EntityStackLength_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664591);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEntityEolNormalized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664592);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnNewLine_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664593);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineNo_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664594);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineStartPosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664595);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ReadData_Private_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664596);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNumericCharRef_Private_Virtual_Final_New_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664597);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNamedCharRef_Private_Virtual_Final_New_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664598);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParsePI_Private_Virtual_Final_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664599);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseComment_Private_Virtual_Final_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664600);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushEntity_Private_Virtual_Final_New_Boolean_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664601);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PopEntity_Private_Virtual_Final_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664602);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushExternalSubset_Private_Virtual_Final_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664603);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushInternalDtd_Private_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664604);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_Throw_Private_Virtual_Final_New_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664605);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnSystemId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664606);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnPublicId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664607);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_DtdValidation_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664608);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_ValidationEventHandling_Private_Virtual_Final_New_get_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664609);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Normalization_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664610);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Namespaces_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664611);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_V1CompatibilityMode_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100664612);
			}

			// Token: 0x06002F6D RID: 12141 RVA: 0x000D7250 File Offset: 0x000D5450
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DtdParserProxy(XmlTextReaderImpl reader)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr__ctor_Internal_Void_XmlTextReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000FF5 RID: 4085
			// (get) Token: 0x06002F6E RID: 12142 RVA: 0x000D729C File Offset: 0x000D549C
			public unsafe virtual XmlNameTable System.Xml.IDtdParserAdapter.NameTable
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NameTable_Private_Virtual_Final_New_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
				}
			}

			// Token: 0x17000FF6 RID: 4086
			// (get) Token: 0x06002F6F RID: 12143 RVA: 0x000D72DC File Offset: 0x000D54DC
			public unsafe virtual IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NamespaceResolver_Private_Virtual_Final_New_get_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr3) : null;
				}
			}

			// Token: 0x17000FF7 RID: 4087
			// (get) Token: 0x06002F70 RID: 12144 RVA: 0x000D731C File Offset: 0x000D551C
			public unsafe virtual Uri System.Xml.IDtdParserAdapter.BaseUri
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367253, XrefRangeEnd = 367255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_BaseUri_Private_Virtual_Final_New_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
				}
			}

			// Token: 0x17000FF8 RID: 4088
			// (get) Token: 0x06002F71 RID: 12145 RVA: 0x000D735C File Offset: 0x000D555C
			public unsafe virtual bool System.Xml.IDtdParserAdapter.IsEof
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367255, XrefRangeEnd = 367257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEof_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000FF9 RID: 4089
			// (get) Token: 0x06002F72 RID: 12146 RVA: 0x000D7398 File Offset: 0x000D5598
			public unsafe virtual Il2CppStructArray<char> System.Xml.IDtdParserAdapter.ParsingBuffer
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367257, XrefRangeEnd = 367259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBuffer_Private_Virtual_Final_New_get_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
				}
			}

			// Token: 0x17000FFA RID: 4090
			// (get) Token: 0x06002F73 RID: 12147 RVA: 0x000D73D8 File Offset: 0x000D55D8
			public unsafe virtual int System.Xml.IDtdParserAdapter.ParsingBufferLength
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367259, XrefRangeEnd = 367261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBufferLength_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000FFB RID: 4091
			// (get) Token: 0x06002F74 RID: 12148 RVA: 0x000D7414 File Offset: 0x000D5614
			// (set) Token: 0x06002F75 RID: 12149 RVA: 0x000D7450 File Offset: 0x000D5650
			public unsafe virtual int System.Xml.IDtdParserAdapter.CurrentPosition
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367261, XrefRangeEnd = 367263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_CurrentPosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367263, XrefRangeEnd = 367265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_set_CurrentPosition_Private_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000FFC RID: 4092
			// (get) Token: 0x06002F76 RID: 12150 RVA: 0x000D7490 File Offset: 0x000D5690
			public unsafe virtual int System.Xml.IDtdParserAdapter.EntityStackLength
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367265, XrefRangeEnd = 367267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_EntityStackLength_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000FFD RID: 4093
			// (get) Token: 0x06002F77 RID: 12151 RVA: 0x000D74CC File Offset: 0x000D56CC
			public unsafe virtual bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367267, XrefRangeEnd = 367269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEntityEolNormalized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002F78 RID: 12152 RVA: 0x000D7508 File Offset: 0x000D5708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367269, XrefRangeEnd = 367271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_OnNewLine(int pos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref pos;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnNewLine_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000FFE RID: 4094
			// (get) Token: 0x06002F79 RID: 12153 RVA: 0x000D7548 File Offset: 0x000D5748
			public unsafe virtual int System.Xml.IDtdParserAdapter.LineNo
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367271, XrefRangeEnd = 367273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineNo_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000FFF RID: 4095
			// (get) Token: 0x06002F7A RID: 12154 RVA: 0x000D7584 File Offset: 0x000D5784
			public unsafe virtual int System.Xml.IDtdParserAdapter.LineStartPosition
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367273, XrefRangeEnd = 367275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineStartPosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002F7B RID: 12155 RVA: 0x000D75C0 File Offset: 0x000D57C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367275, XrefRangeEnd = 367277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Xml_IDtdParserAdapter_ReadData()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ReadData_Private_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F7C RID: 12156 RVA: 0x000D75FC File Offset: 0x000D57FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367277, XrefRangeEnd = 367279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Xml_IDtdParserAdapter_ParseNumericCharRef(StringBuilder internalSubsetBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNumericCharRef_Private_Virtual_Final_New_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002F7D RID: 12157 RVA: 0x000D764C File Offset: 0x000D584C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367279, XrefRangeEnd = 367281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Xml_IDtdParserAdapter_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref expand;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNamedCharRef_Private_Virtual_Final_New_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F7E RID: 12158 RVA: 0x000D76A8 File Offset: 0x000D58A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367281, XrefRangeEnd = 367283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_ParsePI(StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParsePI_Private_Virtual_Final_New_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F7F RID: 12159 RVA: 0x000D76EC File Offset: 0x000D58EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367283, XrefRangeEnd = 367285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_ParseComment(StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseComment_Private_Virtual_Final_New_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F80 RID: 12160 RVA: 0x000D7730 File Offset: 0x000D5930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367285, XrefRangeEnd = 367287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Xml_IDtdParserAdapter_PushEntity(IDtdEntityInfo entity, out int entityId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushEntity_Private_Virtual_Final_New_Boolean_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F81 RID: 12161 RVA: 0x000D778C File Offset: 0x000D598C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367287, XrefRangeEnd = 367289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Xml_IDtdParserAdapter_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &newEntityId;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PopEntity_Private_Virtual_Final_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				oldEntity = ((intPtr4 == 0) ? null : new IDtdEntityInfo(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06002F82 RID: 12162 RVA: 0x000D77F8 File Offset: 0x000D59F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367289, XrefRangeEnd = 367291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Xml_IDtdParserAdapter_PushExternalSubset(string systemId, string publicId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushExternalSubset_Private_Virtual_Final_New_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F83 RID: 12163 RVA: 0x000D7858 File Offset: 0x000D5A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367291, XrefRangeEnd = 367293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_PushInternalDtd(string baseUri, string internalDtd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalDtd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushInternalDtd_Private_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F84 RID: 12164 RVA: 0x000D78AC File Offset: 0x000D5AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367293, XrefRangeEnd = 367295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_Throw(Exception e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_Throw_Private_Virtual_Final_New_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F85 RID: 12165 RVA: 0x000D78F0 File Offset: 0x000D5AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367295, XrefRangeEnd = 367297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref systemLiteralLineInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnSystemId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F86 RID: 12166 RVA: 0x000D7950 File Offset: 0x000D5B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367297, XrefRangeEnd = 367299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publicLiteralLineInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnPublicId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001000 RID: 4096
			// (get) Token: 0x06002F87 RID: 12167 RVA: 0x000D79B0 File Offset: 0x000D5BB0
			public unsafe virtual bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367299, XrefRangeEnd = 367301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_DtdValidation_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001001 RID: 4097
			// (get) Token: 0x06002F88 RID: 12168 RVA: 0x000D79EC File Offset: 0x000D5BEC
			public unsafe virtual IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_ValidationEventHandling_Private_Virtual_Final_New_get_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr3) : null;
				}
			}

			// Token: 0x17001002 RID: 4098
			// (get) Token: 0x06002F89 RID: 12169 RVA: 0x000D7A2C File Offset: 0x000D5C2C
			public unsafe virtual bool System.Xml.IDtdParserAdapterV1.Normalization
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 367158, RefRangeEnd = 367159, XrefRangeStart = 367158, XrefRangeEnd = 367159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Normalization_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001003 RID: 4099
			// (get) Token: 0x06002F8A RID: 12170 RVA: 0x000D7A68 File Offset: 0x000D5C68
			public unsafe virtual bool System.Xml.IDtdParserAdapterV1.Namespaces
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Namespaces_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001004 RID: 4100
			// (get) Token: 0x06002F8B RID: 12171 RVA: 0x000D7AA4 File Offset: 0x000D5CA4
			public unsafe virtual bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_V1CompatibilityMode_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002F8C RID: 12172 RVA: 0x00013C7D File Offset: 0x00011E7D
			public DtdParserProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FF4 RID: 4084
			// (get) Token: 0x06002F8D RID: 12173 RVA: 0x000D7AE0 File Offset: 0x000D5CE0
			// (set) Token: 0x06002F8E RID: 12174 RVA: 0x00013C86 File Offset: 0x00011E86
			public unsafe XmlTextReaderImpl reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.DtdParserProxy.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.DtdParserProxy.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400243D RID: 9277
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x0400243E RID: 9278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlTextReaderImpl_0;

			// Token: 0x0400243F RID: 9279
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NameTable_Private_Virtual_Final_New_get_XmlNameTable_0;

			// Token: 0x04002440 RID: 9280
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NamespaceResolver_Private_Virtual_Final_New_get_IXmlNamespaceResolver_0;

			// Token: 0x04002441 RID: 9281
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_BaseUri_Private_Virtual_Final_New_get_Uri_0;

			// Token: 0x04002442 RID: 9282
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEof_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04002443 RID: 9283
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBuffer_Private_Virtual_Final_New_get_Il2CppStructArray_1_Char_0;

			// Token: 0x04002444 RID: 9284
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBufferLength_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002445 RID: 9285
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_CurrentPosition_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002446 RID: 9286
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_set_CurrentPosition_Private_Virtual_Final_New_set_Void_Int32_0;

			// Token: 0x04002447 RID: 9287
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_EntityStackLength_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002448 RID: 9288
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEntityEolNormalized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04002449 RID: 9289
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnNewLine_Private_Virtual_Final_New_Void_Int32_0;

			// Token: 0x0400244A RID: 9290
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineNo_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x0400244B RID: 9291
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineStartPosition_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x0400244C RID: 9292
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ReadData_Private_Virtual_Final_New_Int32_0;

			// Token: 0x0400244D RID: 9293
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNumericCharRef_Private_Virtual_Final_New_Int32_StringBuilder_0;

			// Token: 0x0400244E RID: 9294
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNamedCharRef_Private_Virtual_Final_New_Int32_Boolean_StringBuilder_0;

			// Token: 0x0400244F RID: 9295
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParsePI_Private_Virtual_Final_New_Void_StringBuilder_0;

			// Token: 0x04002450 RID: 9296
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseComment_Private_Virtual_Final_New_Void_StringBuilder_0;

			// Token: 0x04002451 RID: 9297
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushEntity_Private_Virtual_Final_New_Boolean_IDtdEntityInfo_byref_Int32_0;

			// Token: 0x04002452 RID: 9298
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PopEntity_Private_Virtual_Final_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0;

			// Token: 0x04002453 RID: 9299
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushExternalSubset_Private_Virtual_Final_New_Boolean_String_String_0;

			// Token: 0x04002454 RID: 9300
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushInternalDtd_Private_Virtual_Final_New_Void_String_String_0;

			// Token: 0x04002455 RID: 9301
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_Throw_Private_Virtual_Final_New_Void_Exception_0;

			// Token: 0x04002456 RID: 9302
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnSystemId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0;

			// Token: 0x04002457 RID: 9303
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnPublicId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0;

			// Token: 0x04002458 RID: 9304
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_DtdValidation_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04002459 RID: 9305
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_ValidationEventHandling_Private_Virtual_Final_New_get_IValidationEventHandling_0;

			// Token: 0x0400245A RID: 9306
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Normalization_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400245B RID: 9307
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Namespaces_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400245C RID: 9308
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_V1CompatibilityMode_Private_Virtual_Final_New_get_Boolean_0;
		}

		// Token: 0x02000226 RID: 550
		public class NodeData : Object
		{
			// Token: 0x06002F8F RID: 12175 RVA: 0x000D7B10 File Offset: 0x000D5D10
			// Note: this type is marked as 'beforefieldinit'.
			static NodeData()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "NodeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr);
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_s_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "s_None");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "type");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "localName");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "prefix");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "ns");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nameWPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "nameWPrefix");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "value");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "chars");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "valueStartPos");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "valueLength");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "lineInfo");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "lineInfo2");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_quoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "quoteChar");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "depth");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_isEmptyOrDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "isEmptyOrDefault");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_entityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "entityId");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_xmlContextPushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "xmlContextPushed");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nextAttrValueChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "nextAttrValueChunk");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "schemaType");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_typedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "typedValue");
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_None_Internal_Static_get_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664613);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664614);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664615);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664616);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsEmptyElement_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664617);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsEmptyElement_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664618);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsDefaultAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664619);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsDefaultAttribute_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664620);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_ValueBuffered_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664621);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_StringValue_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664622);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_TrimSpacesInValue_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664623);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664624);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_ClearName_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664625);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664626);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo2_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664627);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664628);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664629);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664630);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664631);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664632);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664633);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_OnBufferInvalidated_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664634);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CopyTo_Internal_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664635);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CopyTo_Internal_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664636);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_GetNameWPrefix_Internal_String_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664637);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CreateNameWPrefix_Internal_String_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664638);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100664639);
			}

			// Token: 0x17001019 RID: 4121
			// (get) Token: 0x06002F90 RID: 12176 RVA: 0x000D7EE8 File Offset: 0x000D60E8
			public unsafe static XmlTextReaderImpl.NodeData None
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 367321, RefRangeEnd = 367323, XrefRangeStart = 367301, XrefRangeEnd = 367321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_None_Internal_Static_get_NodeData_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
				}
			}

			// Token: 0x06002F91 RID: 12177 RVA: 0x000D7F1C File Offset: 0x000D611C
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 367332, RefRangeEnd = 367341, XrefRangeStart = 367323, XrefRangeEnd = 367332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700101A RID: 4122
			// (get) Token: 0x06002F92 RID: 12178 RVA: 0x000D7F58 File Offset: 0x000D6158
			public unsafe int LineNo
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700101B RID: 4123
			// (get) Token: 0x06002F93 RID: 12179 RVA: 0x000D7F94 File Offset: 0x000D6194
			public unsafe int LinePos
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700101C RID: 4124
			// (get) Token: 0x06002F94 RID: 12180 RVA: 0x000D7FD0 File Offset: 0x000D61D0
			// (set) Token: 0x06002F95 RID: 12181 RVA: 0x000D800C File Offset: 0x000D620C
			public unsafe bool IsEmptyElement
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 367341, RefRangeEnd = 367343, XrefRangeStart = 367341, XrefRangeEnd = 367341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsEmptyElement_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsEmptyElement_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700101D RID: 4125
			// (get) Token: 0x06002F96 RID: 12182 RVA: 0x000D804C File Offset: 0x000D624C
			// (set) Token: 0x06002F97 RID: 12183 RVA: 0x000D8088 File Offset: 0x000D6288
			public unsafe bool IsDefaultAttribute
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 367343, RefRangeEnd = 367344, XrefRangeStart = 367343, XrefRangeEnd = 367343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsDefaultAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsDefaultAttribute_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700101E RID: 4126
			// (get) Token: 0x06002F98 RID: 12184 RVA: 0x000D80C8 File Offset: 0x000D62C8
			public unsafe bool ValueBuffered
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_ValueBuffered_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700101F RID: 4127
			// (get) Token: 0x06002F99 RID: 12185 RVA: 0x000D8104 File Offset: 0x000D6304
			public unsafe string StringValue
			{
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 367346, RefRangeEnd = 367355, XrefRangeStart = 367344, XrefRangeEnd = 367346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_StringValue_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002F9A RID: 12186 RVA: 0x000D813C File Offset: 0x000D633C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 367358, RefRangeEnd = 367360, XrefRangeStart = 367355, XrefRangeEnd = 367358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void TrimSpacesInValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_TrimSpacesInValue_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F9B RID: 12187 RVA: 0x000D8170 File Offset: 0x000D6370
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 367368, RefRangeEnd = 367369, XrefRangeStart = 367360, XrefRangeEnd = 367368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear(XmlNodeType type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F9C RID: 12188 RVA: 0x000D81B0 File Offset: 0x000D63B0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 367378, RefRangeEnd = 367383, XrefRangeStart = 367369, XrefRangeEnd = 367378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearName()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_ClearName_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F9D RID: 12189 RVA: 0x000D81E4 File Offset: 0x000D63E4
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 367384, RefRangeEnd = 367398, XrefRangeStart = 367383, XrefRangeEnd = 367384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetLineInfo(int lineNo, int linePos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lineNo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F9E RID: 12190 RVA: 0x000D8230 File Offset: 0x000D6430
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 367399, RefRangeEnd = 367401, XrefRangeStart = 367398, XrefRangeEnd = 367399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetLineInfo2(int lineNo, int linePos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lineNo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo2_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F9F RID: 12191 RVA: 0x000D827C File Offset: 0x000D647C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 367403, RefRangeEnd = 367410, XrefRangeStart = 367401, XrefRangeEnd = 367403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValueNode(XmlNodeType type, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA0 RID: 12192 RVA: 0x000D82CC File Offset: 0x000D64CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 367413, RefRangeEnd = 367414, XrefRangeStart = 367410, XrefRangeEnd = 367413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValueNode(XmlNodeType type, Il2CppStructArray<char> chars, int startPos, int len)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA1 RID: 12193 RVA: 0x000D8338 File Offset: 0x000D6538
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 367424, RefRangeEnd = 367435, XrefRangeStart = 367414, XrefRangeEnd = 367424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNamedNode(XmlNodeType type, string localName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA2 RID: 12194 RVA: 0x000D8388 File Offset: 0x000D6588
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 367443, RefRangeEnd = 367447, XrefRangeStart = 367435, XrefRangeEnd = 367443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameWPrefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA3 RID: 12195 RVA: 0x000D8400 File Offset: 0x000D6600
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 367448, RefRangeEnd = 367463, XrefRangeStart = 367447, XrefRangeEnd = 367448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValue(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FA4 RID: 12196 RVA: 0x000D8444 File Offset: 0x000D6644
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 367465, RefRangeEnd = 367469, XrefRangeStart = 367463, XrefRangeEnd = 367465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValue(Il2CppStructArray<char> chars, int startPos, int len)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA5 RID: 12197 RVA: 0x000D84A4 File Offset: 0x000D66A4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 367471, RefRangeEnd = 367473, XrefRangeStart = 367469, XrefRangeEnd = 367471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnBufferInvalidated()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_OnBufferInvalidated_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA6 RID: 12198 RVA: 0x000D84D8 File Offset: 0x000D66D8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 367474, RefRangeEnd = 367476, XrefRangeStart = 367473, XrefRangeEnd = 367474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(int valueOffset, StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref valueOffset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CopyTo_Internal_Void_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA7 RID: 12199 RVA: 0x000D8528 File Offset: 0x000D6728
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 367477, RefRangeEnd = 367478, XrefRangeStart = 367476, XrefRangeEnd = 367477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int CopyTo(int valueOffset, Il2CppStructArray<char> buffer, int offset, int length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref valueOffset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CopyTo_Internal_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002FA8 RID: 12200 RVA: 0x000D85A0 File Offset: 0x000D67A0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 367483, RefRangeEnd = 367488, XrefRangeStart = 367478, XrefRangeEnd = 367483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetNameWPrefix(XmlNameTable nt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_GetNameWPrefix_Internal_String_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002FA9 RID: 12201 RVA: 0x000D85E8 File Offset: 0x000D67E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367488, XrefRangeEnd = 367493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string CreateNameWPrefix(XmlNameTable nt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CreateNameWPrefix_Internal_String_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002FAA RID: 12202 RVA: 0x000D8630 File Offset: 0x000D6830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367493, XrefRangeEnd = 367500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_IComparable_CompareTo(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002FAB RID: 12203 RVA: 0x00013CA5 File Offset: 0x00011EA5
			public NodeData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001005 RID: 4101
			// (get) Token: 0x06002FAC RID: 12204 RVA: 0x000D8680 File Offset: 0x000D6880
			// (set) Token: 0x06002FAD RID: 12205 RVA: 0x00013CAE File Offset: 0x00011EAE
			public unsafe static XmlTextReaderImpl.NodeData s_None
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_s_None, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_s_None, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001006 RID: 4102
			// (get) Token: 0x06002FAE RID: 12206 RVA: 0x000D86A8 File Offset: 0x000D68A8
			// (set) Token: 0x06002FAF RID: 12207 RVA: 0x00013CC0 File Offset: 0x00011EC0
			public unsafe XmlNodeType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x17001007 RID: 4103
			// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x000D86D0 File Offset: 0x000D68D0
			// (set) Token: 0x06002FB1 RID: 12209 RVA: 0x00013CDB File Offset: 0x00011EDB
			public unsafe string localName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_localName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001008 RID: 4104
			// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x000D86F8 File Offset: 0x000D68F8
			// (set) Token: 0x06002FB3 RID: 12211 RVA: 0x00013CFA File Offset: 0x00011EFA
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001009 RID: 4105
			// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x000D8720 File Offset: 0x000D6920
			// (set) Token: 0x06002FB5 RID: 12213 RVA: 0x00013D19 File Offset: 0x00011F19
			public unsafe string ns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_ns);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700100A RID: 4106
			// (get) Token: 0x06002FB6 RID: 12214 RVA: 0x000D8748 File Offset: 0x000D6948
			// (set) Token: 0x06002FB7 RID: 12215 RVA: 0x00013D38 File Offset: 0x00011F38
			public unsafe string nameWPrefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nameWPrefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nameWPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700100B RID: 4107
			// (get) Token: 0x06002FB8 RID: 12216 RVA: 0x000D8770 File Offset: 0x000D6970
			// (set) Token: 0x06002FB9 RID: 12217 RVA: 0x00013D57 File Offset: 0x00011F57
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700100C RID: 4108
			// (get) Token: 0x06002FBA RID: 12218 RVA: 0x000D8798 File Offset: 0x000D6998
			// (set) Token: 0x06002FBB RID: 12219 RVA: 0x00013D76 File Offset: 0x00011F76
			public unsafe Il2CppStructArray<char> chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_chars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700100D RID: 4109
			// (get) Token: 0x06002FBC RID: 12220 RVA: 0x000D87C8 File Offset: 0x000D69C8
			// (set) Token: 0x06002FBD RID: 12221 RVA: 0x00013D95 File Offset: 0x00011F95
			public unsafe int valueStartPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueStartPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueStartPos)) = value;
				}
			}

			// Token: 0x1700100E RID: 4110
			// (get) Token: 0x06002FBE RID: 12222 RVA: 0x000D87F0 File Offset: 0x000D69F0
			// (set) Token: 0x06002FBF RID: 12223 RVA: 0x00013DB0 File Offset: 0x00011FB0
			public unsafe int valueLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueLength)) = value;
				}
			}

			// Token: 0x1700100F RID: 4111
			// (get) Token: 0x06002FC0 RID: 12224 RVA: 0x000D8818 File Offset: 0x000D6A18
			// (set) Token: 0x06002FC1 RID: 12225 RVA: 0x00013DCB File Offset: 0x00011FCB
			public unsafe LineInfo lineInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo)) = value;
				}
			}

			// Token: 0x17001010 RID: 4112
			// (get) Token: 0x06002FC2 RID: 12226 RVA: 0x000D8840 File Offset: 0x000D6A40
			// (set) Token: 0x06002FC3 RID: 12227 RVA: 0x00013DE6 File Offset: 0x00011FE6
			public unsafe LineInfo lineInfo2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo2)) = value;
				}
			}

			// Token: 0x17001011 RID: 4113
			// (get) Token: 0x06002FC4 RID: 12228 RVA: 0x000D8868 File Offset: 0x000D6A68
			// (set) Token: 0x06002FC5 RID: 12229 RVA: 0x00013E01 File Offset: 0x00012001
			public unsafe char quoteChar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_quoteChar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_quoteChar)) = value;
				}
			}

			// Token: 0x17001012 RID: 4114
			// (get) Token: 0x06002FC6 RID: 12230 RVA: 0x000D8890 File Offset: 0x000D6A90
			// (set) Token: 0x06002FC7 RID: 12231 RVA: 0x00013E1C File Offset: 0x0001201C
			public unsafe int depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_depth)) = value;
				}
			}

			// Token: 0x17001013 RID: 4115
			// (get) Token: 0x06002FC8 RID: 12232 RVA: 0x000D88B8 File Offset: 0x000D6AB8
			// (set) Token: 0x06002FC9 RID: 12233 RVA: 0x00013E37 File Offset: 0x00012037
			public unsafe bool isEmptyOrDefault
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_isEmptyOrDefault);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_isEmptyOrDefault)) = value;
				}
			}

			// Token: 0x17001014 RID: 4116
			// (get) Token: 0x06002FCA RID: 12234 RVA: 0x000D88E0 File Offset: 0x000D6AE0
			// (set) Token: 0x06002FCB RID: 12235 RVA: 0x00013E52 File Offset: 0x00012052
			public unsafe int entityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_entityId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_entityId)) = value;
				}
			}

			// Token: 0x17001015 RID: 4117
			// (get) Token: 0x06002FCC RID: 12236 RVA: 0x000D8908 File Offset: 0x000D6B08
			// (set) Token: 0x06002FCD RID: 12237 RVA: 0x00013E6D File Offset: 0x0001206D
			public unsafe bool xmlContextPushed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_xmlContextPushed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_xmlContextPushed)) = value;
				}
			}

			// Token: 0x17001016 RID: 4118
			// (get) Token: 0x06002FCE RID: 12238 RVA: 0x000D8930 File Offset: 0x000D6B30
			// (set) Token: 0x06002FCF RID: 12239 RVA: 0x00013E88 File Offset: 0x00012088
			public unsafe XmlTextReaderImpl.NodeData nextAttrValueChunk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nextAttrValueChunk);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nextAttrValueChunk), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001017 RID: 4119
			// (get) Token: 0x06002FD0 RID: 12240 RVA: 0x000D8960 File Offset: 0x000D6B60
			// (set) Token: 0x06002FD1 RID: 12241 RVA: 0x00013EA7 File Offset: 0x000120A7
			public unsafe Object schemaType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_schemaType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001018 RID: 4120
			// (get) Token: 0x06002FD2 RID: 12242 RVA: 0x000D8990 File Offset: 0x000D6B90
			// (set) Token: 0x06002FD3 RID: 12243 RVA: 0x00013EC6 File Offset: 0x000120C6
			public unsafe Object typedValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_typedValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_typedValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400245D RID: 9309
			private static readonly IntPtr NativeFieldInfoPtr_s_None;

			// Token: 0x0400245E RID: 9310
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400245F RID: 9311
			private static readonly IntPtr NativeFieldInfoPtr_localName;

			// Token: 0x04002460 RID: 9312
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04002461 RID: 9313
			private static readonly IntPtr NativeFieldInfoPtr_ns;

			// Token: 0x04002462 RID: 9314
			private static readonly IntPtr NativeFieldInfoPtr_nameWPrefix;

			// Token: 0x04002463 RID: 9315
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04002464 RID: 9316
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x04002465 RID: 9317
			private static readonly IntPtr NativeFieldInfoPtr_valueStartPos;

			// Token: 0x04002466 RID: 9318
			private static readonly IntPtr NativeFieldInfoPtr_valueLength;

			// Token: 0x04002467 RID: 9319
			private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

			// Token: 0x04002468 RID: 9320
			private static readonly IntPtr NativeFieldInfoPtr_lineInfo2;

			// Token: 0x04002469 RID: 9321
			private static readonly IntPtr NativeFieldInfoPtr_quoteChar;

			// Token: 0x0400246A RID: 9322
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x0400246B RID: 9323
			private static readonly IntPtr NativeFieldInfoPtr_isEmptyOrDefault;

			// Token: 0x0400246C RID: 9324
			private static readonly IntPtr NativeFieldInfoPtr_entityId;

			// Token: 0x0400246D RID: 9325
			private static readonly IntPtr NativeFieldInfoPtr_xmlContextPushed;

			// Token: 0x0400246E RID: 9326
			private static readonly IntPtr NativeFieldInfoPtr_nextAttrValueChunk;

			// Token: 0x0400246F RID: 9327
			private static readonly IntPtr NativeFieldInfoPtr_schemaType;

			// Token: 0x04002470 RID: 9328
			private static readonly IntPtr NativeFieldInfoPtr_typedValue;

			// Token: 0x04002471 RID: 9329
			private static readonly IntPtr NativeMethodInfoPtr_get_None_Internal_Static_get_NodeData_0;

			// Token: 0x04002472 RID: 9330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04002473 RID: 9331
			private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0;

			// Token: 0x04002474 RID: 9332
			private static readonly IntPtr NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0;

			// Token: 0x04002475 RID: 9333
			private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Internal_get_Boolean_0;

			// Token: 0x04002476 RID: 9334
			private static readonly IntPtr NativeMethodInfoPtr_set_IsEmptyElement_Internal_set_Void_Boolean_0;

			// Token: 0x04002477 RID: 9335
			private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultAttribute_Internal_get_Boolean_0;

			// Token: 0x04002478 RID: 9336
			private static readonly IntPtr NativeMethodInfoPtr_set_IsDefaultAttribute_Internal_set_Void_Boolean_0;

			// Token: 0x04002479 RID: 9337
			private static readonly IntPtr NativeMethodInfoPtr_get_ValueBuffered_Internal_get_Boolean_0;

			// Token: 0x0400247A RID: 9338
			private static readonly IntPtr NativeMethodInfoPtr_get_StringValue_Internal_get_String_0;

			// Token: 0x0400247B RID: 9339
			private static readonly IntPtr NativeMethodInfoPtr_TrimSpacesInValue_Internal_Void_0;

			// Token: 0x0400247C RID: 9340
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0;

			// Token: 0x0400247D RID: 9341
			private static readonly IntPtr NativeMethodInfoPtr_ClearName_Internal_Void_0;

			// Token: 0x0400247E RID: 9342
			private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0;

			// Token: 0x0400247F RID: 9343
			private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo2_Internal_Void_Int32_Int32_0;

			// Token: 0x04002480 RID: 9344
			private static readonly IntPtr NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_String_0;

			// Token: 0x04002481 RID: 9345
			private static readonly IntPtr NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04002482 RID: 9346
			private static readonly IntPtr NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_0;

			// Token: 0x04002483 RID: 9347
			private static readonly IntPtr NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_String_String_0;

			// Token: 0x04002484 RID: 9348
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_String_0;

			// Token: 0x04002485 RID: 9349
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04002486 RID: 9350
			private static readonly IntPtr NativeMethodInfoPtr_OnBufferInvalidated_Internal_Void_0;

			// Token: 0x04002487 RID: 9351
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Internal_Void_Int32_StringBuilder_0;

			// Token: 0x04002488 RID: 9352
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Internal_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04002489 RID: 9353
			private static readonly IntPtr NativeMethodInfoPtr_GetNameWPrefix_Internal_String_XmlNameTable_0;

			// Token: 0x0400248A RID: 9354
			private static readonly IntPtr NativeMethodInfoPtr_CreateNameWPrefix_Internal_String_XmlNameTable_0;

			// Token: 0x0400248B RID: 9355
			private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;
		}

		// Token: 0x02000227 RID: 551
		public class DtdDefaultAttributeInfoToNodeDataComparer : Object
		{
			// Token: 0x06002FD4 RID: 12244 RVA: 0x000D89C0 File Offset: 0x000D6BC0
			// Note: this type is marked as 'beforefieldinit'.
			static DtdDefaultAttributeInfoToNodeDataComparer()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "DtdDefaultAttributeInfoToNodeDataComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr);
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, "s_instance");
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_get_Instance_Internal_Static_get_IComparer_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, 100664640);
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, 100664641);
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, 100664642);
			}

			// Token: 0x17001021 RID: 4129
			// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x000D8A3C File Offset: 0x000D6C3C
			public unsafe static IComparer<Object> Instance
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367500, XrefRangeEnd = 367504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_get_Instance_Internal_Static_get_IComparer_1_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<Object>>(intPtr3) : null;
				}
			}

			// Token: 0x06002FD6 RID: 12246 RVA: 0x000D8A70 File Offset: 0x000D6C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367504, XrefRangeEnd = 367525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002FD7 RID: 12247 RVA: 0x000D8AD0 File Offset: 0x000D6CD0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DtdDefaultAttributeInfoToNodeDataComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FD8 RID: 12248 RVA: 0x00013EE5 File Offset: 0x000120E5
			public DtdDefaultAttributeInfoToNodeDataComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001020 RID: 4128
			// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x000D8B0C File Offset: 0x000D6D0C
			// (set) Token: 0x06002FDA RID: 12250 RVA: 0x00013EEE File Offset: 0x000120EE
			public unsafe static IComparer<Object> s_instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeFieldInfoPtr_s_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400248C RID: 9356
			private static readonly IntPtr NativeFieldInfoPtr_s_instance;

			// Token: 0x0400248D RID: 9357
			private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Internal_Static_get_IComparer_1_Object_0;

			// Token: 0x0400248E RID: 9358
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

			// Token: 0x0400248F RID: 9359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000228 RID: 552
		public sealed class OnDefaultAttributeUseDelegate : MulticastDelegate
		{
			// Token: 0x06002FDB RID: 12251 RVA: 0x00013F00 File Offset: 0x00012100
			// Note: this type is marked as 'beforefieldinit'.
			static OnDefaultAttributeUseDelegate()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "OnDefaultAttributeUseDelegate");
				XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr, 100664644);
				XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr, 100664645);
			}

			// Token: 0x06002FDC RID: 12252 RVA: 0x000D8B34 File Offset: 0x000D6D34
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367525, XrefRangeEnd = 367534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnDefaultAttributeUseDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FDD RID: 12253 RVA: 0x000D8B90 File Offset: 0x000D6D90
			[CallerCount(0)]
			public unsafe void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultAttribute);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coreReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FDE RID: 12254 RVA: 0x00013F3E File Offset: 0x0001213E
			public OnDefaultAttributeUseDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FDF RID: 12255 RVA: 0x00013F47 File Offset: 0x00012147
			public static implicit operator XmlTextReaderImpl.OnDefaultAttributeUseDelegate(Action<IDtdDefaultAttributeInfo, XmlTextReaderImpl> A_0)
			{
				return DelegateSupport.ConvertDelegate<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>(A_0);
			}

			// Token: 0x06002FE0 RID: 12256 RVA: 0x00013F4F File Offset: 0x0001214F
			public static XmlTextReaderImpl.OnDefaultAttributeUseDelegate operator +(XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_0, XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>();
			}

			// Token: 0x06002FE1 RID: 12257 RVA: 0x00013F5D File Offset: 0x0001215D
			public static XmlTextReaderImpl.OnDefaultAttributeUseDelegate operator -(XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_0, XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002490 RID: 9360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002491 RID: 9361
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0;
		}
	}
}
