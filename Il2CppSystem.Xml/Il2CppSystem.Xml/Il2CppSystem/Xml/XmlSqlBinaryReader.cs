using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000011 RID: 17
	public sealed class XmlSqlBinaryReader : XmlReader
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00018798 File Offset: 0x00016998
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSqlBinaryReader()
		{
			Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlSqlBinaryReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr);
			XmlSqlBinaryReader.NativeFieldInfoPtr_TypeOfObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "TypeOfObject");
			XmlSqlBinaryReader.NativeFieldInfoPtr_TypeOfString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "TypeOfString");
			XmlSqlBinaryReader.NativeFieldInfoPtr_TokenTypeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "TokenTypeMap");
			XmlSqlBinaryReader.NativeFieldInfoPtr_XsdKatmaiTimeScaleToValueLengthMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "XsdKatmaiTimeScaleToValueLengthMap");
			XmlSqlBinaryReader.NativeFieldInfoPtr_ScanState2ReadState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "ScanState2ReadState");
			XmlSqlBinaryReader.NativeFieldInfoPtr_inStrm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "inStrm");
			XmlSqlBinaryReader.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "data");
			XmlSqlBinaryReader.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "pos");
			XmlSqlBinaryReader.NativeFieldInfoPtr_mark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "mark");
			XmlSqlBinaryReader.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "end");
			XmlSqlBinaryReader.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "offset");
			XmlSqlBinaryReader.NativeFieldInfoPtr_eof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "eof");
			XmlSqlBinaryReader.NativeFieldInfoPtr_sniffed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "sniffed");
			XmlSqlBinaryReader.NativeFieldInfoPtr_isEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "isEmpty");
			XmlSqlBinaryReader.NativeFieldInfoPtr_docState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "docState");
			XmlSqlBinaryReader.NativeFieldInfoPtr_symbolTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "symbolTables");
			XmlSqlBinaryReader.NativeFieldInfoPtr_xnt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "xnt");
			XmlSqlBinaryReader.NativeFieldInfoPtr_xntFromSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "xntFromSettings");
			XmlSqlBinaryReader.NativeFieldInfoPtr_xml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "xml");
			XmlSqlBinaryReader.NativeFieldInfoPtr_xmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "xmlns");
			XmlSqlBinaryReader.NativeFieldInfoPtr_nsxmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "nsxmlns");
			XmlSqlBinaryReader.NativeFieldInfoPtr_baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "baseUri");
			XmlSqlBinaryReader.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "state");
			XmlSqlBinaryReader.NativeFieldInfoPtr_nodetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "nodetype");
			XmlSqlBinaryReader.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "token");
			XmlSqlBinaryReader.NativeFieldInfoPtr_attrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "attrIndex");
			XmlSqlBinaryReader.NativeFieldInfoPtr_qnameOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "qnameOther");
			XmlSqlBinaryReader.NativeFieldInfoPtr_qnameElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "qnameElement");
			XmlSqlBinaryReader.NativeFieldInfoPtr_parentNodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "parentNodeType");
			XmlSqlBinaryReader.NativeFieldInfoPtr_elementStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "elementStack");
			XmlSqlBinaryReader.NativeFieldInfoPtr_elemDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "elemDepth");
			XmlSqlBinaryReader.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "attributes");
			XmlSqlBinaryReader.NativeFieldInfoPtr_attrHashTbl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "attrHashTbl");
			XmlSqlBinaryReader.NativeFieldInfoPtr_attrCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "attrCount");
			XmlSqlBinaryReader.NativeFieldInfoPtr_posAfterAttrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "posAfterAttrs");
			XmlSqlBinaryReader.NativeFieldInfoPtr_xmlspacePreserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "xmlspacePreserve");
			XmlSqlBinaryReader.NativeFieldInfoPtr_tokLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "tokLen");
			XmlSqlBinaryReader.NativeFieldInfoPtr_tokDataPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "tokDataPos");
			XmlSqlBinaryReader.NativeFieldInfoPtr_hasTypedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "hasTypedValue");
			XmlSqlBinaryReader.NativeFieldInfoPtr_valueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "valueType");
			XmlSqlBinaryReader.NativeFieldInfoPtr_stringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "stringValue");
			XmlSqlBinaryReader.NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "namespaces");
			XmlSqlBinaryReader.NativeFieldInfoPtr_prevNameInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "prevNameInfo");
			XmlSqlBinaryReader.NativeFieldInfoPtr_textXmlReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "textXmlReader");
			XmlSqlBinaryReader.NativeFieldInfoPtr_closeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "closeInput");
			XmlSqlBinaryReader.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "checkCharacters");
			XmlSqlBinaryReader.NativeFieldInfoPtr_ignoreWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "ignoreWhitespace");
			XmlSqlBinaryReader.NativeFieldInfoPtr_ignorePIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "ignorePIs");
			XmlSqlBinaryReader.NativeFieldInfoPtr_ignoreComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "ignoreComments");
			XmlSqlBinaryReader.NativeFieldInfoPtr_dtdProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "dtdProcessing");
			XmlSqlBinaryReader.NativeFieldInfoPtr_hasher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "hasher");
			XmlSqlBinaryReader.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "xmlCharType");
			XmlSqlBinaryReader.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "unicode");
			XmlSqlBinaryReader.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "version");
			XmlSqlBinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Il2CppStructArray_1_Byte_Int32_String_Boolean_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663368);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663369);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663370);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663371);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663372);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663373);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663374);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663375);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663376);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663377);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663378);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663379);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663380);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663381);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663382);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663383);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663384);
			XmlSqlBinaryReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663385);
			XmlSqlBinaryReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663386);
			XmlSqlBinaryReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663387);
			XmlSqlBinaryReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663388);
			XmlSqlBinaryReader.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663389);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663390);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663391);
			XmlSqlBinaryReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663392);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663393);
			XmlSqlBinaryReader.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663394);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663395);
			XmlSqlBinaryReader.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663396);
			XmlSqlBinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663397);
			XmlSqlBinaryReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663398);
			XmlSqlBinaryReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663399);
			XmlSqlBinaryReader.NativeMethodInfoPtr_VerifyVersion_Private_Void_Int32_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663400);
			XmlSqlBinaryReader.NativeMethodInfoPtr_AddInitNamespace_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663401);
			XmlSqlBinaryReader.NativeMethodInfoPtr_AddName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663402);
			XmlSqlBinaryReader.NativeMethodInfoPtr_AddQName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663403);
			XmlSqlBinaryReader.NativeMethodInfoPtr_NameFlush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663404);
			XmlSqlBinaryReader.NativeMethodInfoPtr_SkipExtn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663405);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ReadQNameRef_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663406);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ReadNameRef_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663407);
			XmlSqlBinaryReader.NativeMethodInfoPtr_FillAllowEOF_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663408);
			XmlSqlBinaryReader.NativeMethodInfoPtr_Fill__Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663409);
			XmlSqlBinaryReader.NativeMethodInfoPtr_Fill_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663410);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ReadByte_Private_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663411);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ReadUShort_Private_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663412);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ParseMB32_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663413);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ParseMB32__Private_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663414);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ParseMB32_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663415);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ParseMB64_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663416);
			XmlSqlBinaryReader.NativeMethodInfoPtr_PeekToken_Private_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663417);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ReadToken_Private_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663418);
			XmlSqlBinaryReader.NativeMethodInfoPtr_NextToken2_Private_BinXmlToken_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663419);
			XmlSqlBinaryReader.NativeMethodInfoPtr_NextToken1_Private_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663420);
			XmlSqlBinaryReader.NativeMethodInfoPtr_NextToken_Private_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663421);
			XmlSqlBinaryReader.NativeMethodInfoPtr_PeekNextToken_Private_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663422);
			XmlSqlBinaryReader.NativeMethodInfoPtr_RescanNextToken_Private_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663423);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ParseText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663424);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ScanText_Private_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663425);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetString_Private_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663426);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetStringAligned_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663427);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetAttributeText_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663428);
			XmlSqlBinaryReader.NativeMethodInfoPtr_LocateAttribute_Private_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663429);
			XmlSqlBinaryReader.NativeMethodInfoPtr_LocateAttribute_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663430);
			XmlSqlBinaryReader.NativeMethodInfoPtr_PositionOnAttribute_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663431);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GrowElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663432);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GrowAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663433);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ClearAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663434);
			XmlSqlBinaryReader.NativeMethodInfoPtr_PushNamespace_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663435);
			XmlSqlBinaryReader.NativeMethodInfoPtr_PopNamespaces_Private_Void_NamespaceDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663436);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GenerateImpliedXmlnsAttrs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663437);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ReadInit_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663438);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ScanAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663439);
			XmlSqlBinaryReader.NativeMethodInfoPtr_SimpleCheckForDuplicateAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663440);
			XmlSqlBinaryReader.NativeMethodInfoPtr_HashCheckForDuplicateAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663441);
			XmlSqlBinaryReader.NativeMethodInfoPtr_XmlDeclValue_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663442);
			XmlSqlBinaryReader.NativeMethodInfoPtr_CDATAValue_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663443);
			XmlSqlBinaryReader.NativeMethodInfoPtr_FinishCDATA_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663444);
			XmlSqlBinaryReader.NativeMethodInfoPtr_FinishEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663445);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ReadDoc_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663446);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadData_Private_Void_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663447);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663448);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663449);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadDoctype_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663450);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadPI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663451);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadComment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663452);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadCDATA_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663453);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadNest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663454);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadEndNest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663455);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadXmlText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663456);
			XmlSqlBinaryReader.NativeMethodInfoPtr_UpdateFromTextReader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663457);
			XmlSqlBinaryReader.NativeMethodInfoPtr_UpdateFromTextReader_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663458);
			XmlSqlBinaryReader.NativeMethodInfoPtr_CheckAllowContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663459);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GenerateTokenTypeMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663460);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetValueType_Private_Type_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663461);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ReScanOverValue_Private_Void_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663462);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ScanOverValue_Private_XmlNodeType_BinXmlToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663463);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ScanOverAnyValue_Private_XmlNodeType_BinXmlToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663464);
			XmlSqlBinaryReader.NativeMethodInfoPtr_CheckText_Private_XmlNodeType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663465);
			XmlSqlBinaryReader.NativeMethodInfoPtr_CheckTextIsWS_Private_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663466);
			XmlSqlBinaryReader.NativeMethodInfoPtr_CheckValueTokenBounds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663467);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetXsdKatmaiTokenLength_Private_Int32_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663468);
			XmlSqlBinaryReader.NativeMethodInfoPtr_XsdKatmaiTimeScaleToValueLength_Private_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663469);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsLong_Private_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663470);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsULong_Private_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663471);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsDecimal_Private_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663472);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsDouble_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663473);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsDateTimeString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663474);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsString_Private_String_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663475);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetInt16_Private_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663476);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetUInt16_Private_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663477);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetInt32_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663478);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetUInt32_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663479);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetInt64_Private_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663480);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetUInt64_Private_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663481);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetSingle_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663482);
			XmlSqlBinaryReader.NativeMethodInfoPtr_GetDouble_Private_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663483);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Exception_BinXmlToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663484);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ThrowXmlException_Private_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663485);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ThrowXmlException_Private_Exception_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663486);
			XmlSqlBinaryReader.NativeMethodInfoPtr_ThrowNotSupported_Private_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, 100663487);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00019560 File Offset: 0x00017760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362902, RefRangeEnd = 362903, XrefRangeStart = 362824, XrefRangeEnd = 362902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSqlBinaryReader(Stream stream, Il2CppStructArray<byte> data, int len, string baseUri, bool closeInput, XmlReaderSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closeInput;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Il2CppStructArray_1_Byte_Int32_String_Boolean_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00019600 File Offset: 0x00017800
		public unsafe override XmlReaderSettings Settings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362903, XrefRangeEnd = 362916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00019640 File Offset: 0x00017840
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0001967C File Offset: 0x0001787C
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000196B4 File Offset: 0x000178B4
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000196EC File Offset: 0x000178EC
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00019724 File Offset: 0x00017924
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362916, XrefRangeEnd = 362919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0001975C File Offset: 0x0001795C
		public unsafe override int Depth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00019798 File Offset: 0x00017998
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000197D0 File Offset: 0x000179D0
		public unsafe override bool IsEmptyElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0001980C File Offset: 0x00017A0C
		public unsafe override XmlSpace XmlSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00019848 File Offset: 0x00017A48
		public unsafe override string XmlLang
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362919, XrefRangeEnd = 362921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00019880 File Offset: 0x00017A80
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000198C0 File Offset: 0x00017AC0
		public unsafe override int AttributeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000198FC File Offset: 0x00017AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362921, XrefRangeEnd = 362925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00019958 File Offset: 0x00017B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362925, XrefRangeEnd = 362926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000199A0 File Offset: 0x00017BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362926, XrefRangeEnd = 362934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000199E4 File Offset: 0x00017BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362934, XrefRangeEnd = 362936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00019A34 File Offset: 0x00017C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362936, XrefRangeEnd = 362938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveToAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00019A74 File Offset: 0x00017C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362938, XrefRangeEnd = 362939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00019AB0 File Offset: 0x00017CB0
		[CallerCount(0)]
		public unsafe override bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00019AEC File Offset: 0x00017CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362939, XrefRangeEnd = 362940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00019B28 File Offset: 0x00017D28
		public unsafe override bool EOF
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00019B64 File Offset: 0x00017D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362940, XrefRangeEnd = 362942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadAttributeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00019BA0 File Offset: 0x00017DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362942, XrefRangeEnd = 362945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00019BD4 File Offset: 0x00017DD4
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00019C14 File Offset: 0x00017E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362945, XrefRangeEnd = 362948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00019C5C File Offset: 0x00017E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362948, XrefRangeEnd = 362953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResolveEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00019C90 File Offset: 0x00017E90
		public unsafe override ReadState ReadState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362953, XrefRangeEnd = 362957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00019CCC File Offset: 0x00017ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362957, XrefRangeEnd = 362964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00019D08 File Offset: 0x00017F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362964, XrefRangeEnd = 362997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary<string, string> System_Xml_IXmlNamespaceResolver_GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00019D54 File Offset: 0x00017F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362997, XrefRangeEnd = 362998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00019D9C File Offset: 0x00017F9C
		[CallerCount(0)]
		public unsafe void VerifyVersion(int requiredVersion, BinXmlToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref requiredVersion;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_VerifyVersion_Private_Void_Int32_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00019DE8 File Offset: 0x00017FE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 363012, RefRangeEnd = 363015, XrefRangeStart = 362998, XrefRangeEnd = 363012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInitNamespace(string prefix, string uri)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_AddInitNamespace_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00019E3C File Offset: 0x0001803C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363015, XrefRangeEnd = 363028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_AddName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00019E70 File Offset: 0x00018070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363049, RefRangeEnd = 363050, XrefRangeStart = 363028, XrefRangeEnd = 363049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddQName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_AddQName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00019EA4 File Offset: 0x000180A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363050, XrefRangeEnd = 363053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NameFlush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_NameFlush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00019ED8 File Offset: 0x000180D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363053, XrefRangeEnd = 363058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipExtn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_SkipExtn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00019F0C File Offset: 0x0001810C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363061, RefRangeEnd = 363063, XrefRangeStart = 363058, XrefRangeEnd = 363061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadQNameRef()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ReadQNameRef_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00019F48 File Offset: 0x00018148
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 363066, RefRangeEnd = 363071, XrefRangeStart = 363063, XrefRangeEnd = 363066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadNameRef()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ReadNameRef_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00019F84 File Offset: 0x00018184
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 363080, RefRangeEnd = 363085, XrefRangeStart = 363071, XrefRangeEnd = 363080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FillAllowEOF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_FillAllowEOF_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00019FC0 File Offset: 0x000181C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363085, XrefRangeEnd = 363086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fill_(int require)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref require;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_Fill__Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001A000 File Offset: 0x00018200
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 363087, RefRangeEnd = 363113, XrefRangeStart = 363086, XrefRangeEnd = 363087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fill(int require)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref require;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_Fill_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001A040 File Offset: 0x00018240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363113, XrefRangeEnd = 363114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ReadByte_Private_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0001A07C File Offset: 0x0001827C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363114, XrefRangeEnd = 363115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort ReadUShort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ReadUShort_Private_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001A0B8 File Offset: 0x000182B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363116, RefRangeEnd = 363117, XrefRangeStart = 363115, XrefRangeEnd = 363116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseMB32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ParseMB32_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0001A0F4 File Offset: 0x000182F4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 363121, RefRangeEnd = 363131, XrefRangeStart = 363117, XrefRangeEnd = 363121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseMB32_(byte b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ParseMB32__Private_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001A140 File Offset: 0x00018340
		[CallerCount(0)]
		public unsafe int ParseMB32(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ParseMB32_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0001A18C File Offset: 0x0001838C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363116, RefRangeEnd = 363117, XrefRangeStart = 363116, XrefRangeEnd = 363117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseMB64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ParseMB64_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0001A1C8 File Offset: 0x000183C8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 363141, RefRangeEnd = 363152, XrefRangeStart = 363131, XrefRangeEnd = 363141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinXmlToken PeekToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_PeekToken_Private_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001A204 File Offset: 0x00018404
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 363162, RefRangeEnd = 363168, XrefRangeStart = 363152, XrefRangeEnd = 363162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinXmlToken ReadToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ReadToken_Private_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0001A240 File Offset: 0x00018440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363168, XrefRangeEnd = 363192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinXmlToken NextToken2(BinXmlToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_NextToken2_Private_BinXmlToken_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001A28C File Offset: 0x0001848C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363192, XrefRangeEnd = 363194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinXmlToken NextToken1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_NextToken1_Private_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001A2C8 File Offset: 0x000184C8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 363194, RefRangeEnd = 363203, XrefRangeStart = 363194, XrefRangeEnd = 363194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinXmlToken NextToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_NextToken_Private_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0001A304 File Offset: 0x00018504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363203, XrefRangeEnd = 363204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinXmlToken PeekNextToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_PeekNextToken_Private_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0001A340 File Offset: 0x00018540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363221, RefRangeEnd = 363222, XrefRangeStart = 363204, XrefRangeEnd = 363221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinXmlToken RescanNextToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_RescanNextToken_Private_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001A37C File Offset: 0x0001857C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 363225, RefRangeEnd = 363234, XrefRangeStart = 363222, XrefRangeEnd = 363225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ParseText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001A3B4 File Offset: 0x000185B4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 363239, RefRangeEnd = 363248, XrefRangeStart = 363234, XrefRangeEnd = 363239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ScanText(out int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ScanText_Private_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0001A400 File Offset: 0x00018600
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 363251, RefRangeEnd = 363254, XrefRangeStart = 363248, XrefRangeEnd = 363251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(int pos, int cch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetString_Private_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0001A454 File Offset: 0x00018654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363254, XrefRangeEnd = 363257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringAligned(Il2CppStructArray<byte> data, int offset, int cch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetStringAligned_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0001A4B8 File Offset: 0x000186B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 363264, RefRangeEnd = 363268, XrefRangeStart = 363257, XrefRangeEnd = 363264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAttributeText(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetAttributeText_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0001A4FC File Offset: 0x000186FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363268, XrefRangeEnd = 363270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LocateAttribute(string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_LocateAttribute_Private_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0001A55C File Offset: 0x0001875C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363276, RefRangeEnd = 363278, XrefRangeStart = 363270, XrefRangeEnd = 363276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LocateAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_LocateAttribute_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0001A5AC File Offset: 0x000187AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 363287, RefRangeEnd = 363290, XrefRangeStart = 363278, XrefRangeEnd = 363287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionOnAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_PositionOnAttribute_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0001A5EC File Offset: 0x000187EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363290, XrefRangeEnd = 363296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GrowElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0001A620 File Offset: 0x00018820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363302, RefRangeEnd = 363304, XrefRangeStart = 363296, XrefRangeEnd = 363302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GrowAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0001A654 File Offset: 0x00018854
		[CallerCount(0)]
		public unsafe void ClearAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ClearAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0001A688 File Offset: 0x00018888
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 363325, RefRangeEnd = 363329, XrefRangeStart = 363304, XrefRangeEnd = 363325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushNamespace(string prefix, string ns, bool implied)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref implied;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_PushNamespace_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0001A6EC File Offset: 0x000188EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363329, XrefRangeEnd = 363338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstInScopeChain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_PopNamespaces_Private_Void_NamespaceDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0001A730 File Offset: 0x00018930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363348, RefRangeEnd = 363349, XrefRangeStart = 363338, XrefRangeEnd = 363348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateImpliedXmlnsAttrs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GenerateImpliedXmlnsAttrs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0001A764 File Offset: 0x00018964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363401, RefRangeEnd = 363402, XrefRangeStart = 363349, XrefRangeEnd = 363401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadInit(bool skipXmlDecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipXmlDecl;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ReadInit_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0001A7B0 File Offset: 0x000189B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363447, RefRangeEnd = 363448, XrefRangeStart = 363402, XrefRangeEnd = 363447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ScanAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0001A7E4 File Offset: 0x000189E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363448, XrefRangeEnd = 363451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SimpleCheckForDuplicateAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_SimpleCheckForDuplicateAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0001A818 File Offset: 0x00018A18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363462, RefRangeEnd = 363463, XrefRangeStart = 363451, XrefRangeEnd = 363462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HashCheckForDuplicateAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_HashCheckForDuplicateAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001A84C File Offset: 0x00018A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363463, XrefRangeEnd = 363477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string XmlDeclValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_XmlDeclValue_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0001A884 File Offset: 0x00018A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363477, XrefRangeEnd = 363488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CDATAValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_CDATAValue_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0001A8BC File Offset: 0x00018ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363488, XrefRangeEnd = 363491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishCDATA()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_FinishCDATA_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0001A8F0 File Offset: 0x00018AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363501, RefRangeEnd = 363503, XrefRangeStart = 363491, XrefRangeEnd = 363501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_FinishEndElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0001A924 File Offset: 0x00018B24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363543, RefRangeEnd = 363545, XrefRangeStart = 363503, XrefRangeEnd = 363543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadDoc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ReadDoc_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0001A960 File Offset: 0x00018B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363545, XrefRangeEnd = 363554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImplReadData(BinXmlToken tokenType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tokenType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadData_Private_Void_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363554, XrefRangeEnd = 363581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImplReadElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001A9D4 File Offset: 0x00018BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363581, XrefRangeEnd = 363582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImplReadEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadEndElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0001AA08 File Offset: 0x00018C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363610, RefRangeEnd = 363611, XrefRangeStart = 363582, XrefRangeEnd = 363610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImplReadDoctype()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadDoctype_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0001AA3C File Offset: 0x00018C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363611, XrefRangeEnd = 363614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImplReadPI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadPI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0001AA70 File Offset: 0x00018C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363614, XrefRangeEnd = 363615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImplReadComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadComment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001AAA4 File Offset: 0x00018CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363615, XrefRangeEnd = 363616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImplReadCDATA()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadCDATA_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363616, XrefRangeEnd = 363624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImplReadNest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadNest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0001AB0C File Offset: 0x00018D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363624, XrefRangeEnd = 363627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImplReadEndNest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadEndNest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001AB40 File Offset: 0x00018D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363627, XrefRangeEnd = 363663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImplReadXmlText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ImplReadXmlText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001AB74 File Offset: 0x00018D74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 363667, RefRangeEnd = 363672, XrefRangeStart = 363663, XrefRangeEnd = 363667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFromTextReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_UpdateFromTextReader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001ABA8 File Offset: 0x00018DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363672, XrefRangeEnd = 363673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateFromTextReader(bool needUpdate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needUpdate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_UpdateFromTextReader_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0001ABF4 File Offset: 0x00018DF4
		[CallerCount(0)]
		public unsafe void CheckAllowContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_CheckAllowContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0001AC28 File Offset: 0x00018E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363829, RefRangeEnd = 363830, XrefRangeStart = 363673, XrefRangeEnd = 363829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTokenTypeMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GenerateTokenTypeMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0001AC5C File Offset: 0x00018E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363839, RefRangeEnd = 363841, XrefRangeStart = 363830, XrefRangeEnd = 363839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetValueType(BinXmlToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetValueType_Private_Type_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363841, XrefRangeEnd = 363842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReScanOverValue(BinXmlToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ReScanOverValue_Private_Void_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0001ACE8 File Offset: 0x00018EE8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 363844, RefRangeEnd = 363850, XrefRangeStart = 363842, XrefRangeEnd = 363844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ScanOverValue_Private_XmlNodeType_BinXmlToken_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0001AD50 File Offset: 0x00018F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363862, RefRangeEnd = 363863, XrefRangeStart = 363850, XrefRangeEnd = 363862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ScanOverAnyValue_Private_XmlNodeType_BinXmlToken_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363863, XrefRangeEnd = 363868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeType CheckText(bool attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_CheckText_Private_XmlNodeType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0001AE04 File Offset: 0x00019004
		[CallerCount(0)]
		public unsafe XmlNodeType CheckTextIsWS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_CheckTextIsWS_Private_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001AE40 File Offset: 0x00019040
		[CallerCount(0)]
		public unsafe void CheckValueTokenBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_CheckValueTokenBounds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0001AE74 File Offset: 0x00019074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363868, XrefRangeEnd = 363870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetXsdKatmaiTokenLength(BinXmlToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetXsdKatmaiTokenLength_Private_Int32_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0001AEC0 File Offset: 0x000190C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363874, RefRangeEnd = 363875, XrefRangeStart = 363870, XrefRangeEnd = 363874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int XsdKatmaiTimeScaleToValueLength(byte scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_XsdKatmaiTimeScaleToValueLength_Private_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001AF0C File Offset: 0x0001910C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363878, RefRangeEnd = 363879, XrefRangeStart = 363875, XrefRangeEnd = 363878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ValueAsLong()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsLong_Private_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001AF48 File Offset: 0x00019148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363887, RefRangeEnd = 363888, XrefRangeStart = 363879, XrefRangeEnd = 363887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong ValueAsULong()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsULong_Private_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001AF84 File Offset: 0x00019184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363888, XrefRangeEnd = 363891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal ValueAsDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsDecimal_Private_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001AFC0 File Offset: 0x000191C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363891, XrefRangeEnd = 363893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ValueAsDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsDouble_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0001AFFC File Offset: 0x000191FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363988, RefRangeEnd = 363989, XrefRangeStart = 363893, XrefRangeEnd = 363988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ValueAsDateTimeString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsDateTimeString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001B034 File Offset: 0x00019234
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 364055, RefRangeEnd = 364058, XrefRangeStart = 363989, XrefRangeEnd = 364055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ValueAsString(BinXmlToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ValueAsString_Private_String_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0001B078 File Offset: 0x00019278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 364058, RefRangeEnd = 364060, XrefRangeStart = 364058, XrefRangeEnd = 364058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short GetInt16(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetInt16_Private_Int16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0001B0C4 File Offset: 0x000192C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 364058, RefRangeEnd = 364060, XrefRangeStart = 364058, XrefRangeEnd = 364060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort GetUInt16(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetUInt16_Private_UInt16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0001B110 File Offset: 0x00019310
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 364060, RefRangeEnd = 364064, XrefRangeStart = 364060, XrefRangeEnd = 364060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt32(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetInt32_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001B15C File Offset: 0x0001935C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 364060, RefRangeEnd = 364064, XrefRangeStart = 364060, XrefRangeEnd = 364064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetUInt32(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetUInt32_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0001B1A8 File Offset: 0x000193A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 364064, RefRangeEnd = 364066, XrefRangeStart = 364064, XrefRangeEnd = 364064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetInt64(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetInt64_Private_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0001B1F4 File Offset: 0x000193F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 364064, RefRangeEnd = 364066, XrefRangeStart = 364064, XrefRangeEnd = 364066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetUInt64(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetUInt64_Private_UInt64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001B240 File Offset: 0x00019440
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 364066, RefRangeEnd = 364069, XrefRangeStart = 364066, XrefRangeEnd = 364066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSingle(int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetSingle_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001B28C File Offset: 0x0001948C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 364069, RefRangeEnd = 364070, XrefRangeStart = 364069, XrefRangeEnd = 364069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetDouble(int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_GetDouble_Private_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0001B2D8 File Offset: 0x000194D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 364076, RefRangeEnd = 364077, XrefRangeStart = 364070, XrefRangeEnd = 364076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception ThrowUnexpectedToken(BinXmlToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Exception_BinXmlToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0001B324 File Offset: 0x00019524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 364081, RefRangeEnd = 364082, XrefRangeStart = 364077, XrefRangeEnd = 364081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception ThrowXmlException(string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ThrowXmlException_Private_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001B374 File Offset: 0x00019574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364082, XrefRangeEnd = 364091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception ThrowXmlException(string res, string arg1, string arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ThrowXmlException_Private_Exception_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0001B3E8 File Offset: 0x000195E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364091, XrefRangeEnd = 364096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception ThrowNotSupported(string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NativeMethodInfoPtr_ThrowNotSupported_Private_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002444 File Offset: 0x00000644
		public XmlSqlBinaryReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0001B438 File Offset: 0x00019638
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000244D File Offset: 0x0000064D
		public unsafe static Type TypeOfObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSqlBinaryReader.NativeFieldInfoPtr_TypeOfObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSqlBinaryReader.NativeFieldInfoPtr_TypeOfObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0001B460 File Offset: 0x00019660
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000245F File Offset: 0x0000065F
		public unsafe static Type TypeOfString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSqlBinaryReader.NativeFieldInfoPtr_TypeOfString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSqlBinaryReader.NativeFieldInfoPtr_TypeOfString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0001B488 File Offset: 0x00019688
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002471 File Offset: 0x00000671
		public unsafe static Il2CppReferenceArray<Type> TokenTypeMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSqlBinaryReader.NativeFieldInfoPtr_TokenTypeMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSqlBinaryReader.NativeFieldInfoPtr_TokenTypeMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0001B4B0 File Offset: 0x000196B0
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002483 File Offset: 0x00000683
		public unsafe static Il2CppStructArray<byte> XsdKatmaiTimeScaleToValueLengthMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSqlBinaryReader.NativeFieldInfoPtr_XsdKatmaiTimeScaleToValueLengthMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSqlBinaryReader.NativeFieldInfoPtr_XsdKatmaiTimeScaleToValueLengthMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0001B4D8 File Offset: 0x000196D8
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002495 File Offset: 0x00000695
		public unsafe static Il2CppStructArray<ReadState> ScanState2ReadState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSqlBinaryReader.NativeFieldInfoPtr_ScanState2ReadState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ReadState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSqlBinaryReader.NativeFieldInfoPtr_ScanState2ReadState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0001B500 File Offset: 0x00019700
		// (set) Token: 0x0600012E RID: 302 RVA: 0x000024A7 File Offset: 0x000006A7
		public unsafe Stream inStrm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_inStrm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_inStrm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0001B530 File Offset: 0x00019730
		// (set) Token: 0x06000130 RID: 304 RVA: 0x000024C6 File Offset: 0x000006C6
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0001B560 File Offset: 0x00019760
		// (set) Token: 0x06000132 RID: 306 RVA: 0x000024E5 File Offset: 0x000006E5
		public unsafe int pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0001B588 File Offset: 0x00019788
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002500 File Offset: 0x00000700
		public unsafe int mark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_mark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_mark)) = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0001B5B0 File Offset: 0x000197B0
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000251B File Offset: 0x0000071B
		public unsafe int end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_end)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0001B5D8 File Offset: 0x000197D8
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002536 File Offset: 0x00000736
		public unsafe long offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0001B600 File Offset: 0x00019800
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002551 File Offset: 0x00000751
		public unsafe bool eof
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_eof);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_eof)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0001B628 File Offset: 0x00019828
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000256C File Offset: 0x0000076C
		public unsafe bool sniffed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_sniffed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_sniffed)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0001B650 File Offset: 0x00019850
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002587 File Offset: 0x00000787
		public unsafe bool isEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_isEmpty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_isEmpty)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0001B678 File Offset: 0x00019878
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000025A2 File Offset: 0x000007A2
		public unsafe int docState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_docState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_docState)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0001B6A0 File Offset: 0x000198A0
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000025BD File Offset: 0x000007BD
		public XmlSqlBinaryReader.SymbolTables symbolTables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_symbolTables);
				return new XmlSqlBinaryReader.SymbolTables(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_symbolTables), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0001B6D0 File Offset: 0x000198D0
		// (set) Token: 0x06000144 RID: 324 RVA: 0x000025EB File Offset: 0x000007EB
		public unsafe XmlNameTable xnt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xnt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xnt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0001B700 File Offset: 0x00019900
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000260A File Offset: 0x0000080A
		public unsafe bool xntFromSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xntFromSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xntFromSettings)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0001B728 File Offset: 0x00019928
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002625 File Offset: 0x00000825
		public unsafe string xml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0001B750 File Offset: 0x00019950
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002644 File Offset: 0x00000844
		public unsafe string xmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0001B778 File Offset: 0x00019978
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002663 File Offset: 0x00000863
		public unsafe string nsxmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_nsxmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_nsxmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0001B7A0 File Offset: 0x000199A0
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002682 File Offset: 0x00000882
		public unsafe string baseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_baseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_baseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0001B7C8 File Offset: 0x000199C8
		// (set) Token: 0x06000150 RID: 336 RVA: 0x000026A1 File Offset: 0x000008A1
		public unsafe XmlSqlBinaryReader.ScanState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0001B7F0 File Offset: 0x000199F0
		// (set) Token: 0x06000152 RID: 338 RVA: 0x000026BC File Offset: 0x000008BC
		public unsafe XmlNodeType nodetype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_nodetype);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_nodetype)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0001B818 File Offset: 0x00019A18
		// (set) Token: 0x06000154 RID: 340 RVA: 0x000026D7 File Offset: 0x000008D7
		public unsafe BinXmlToken token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_token)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0001B840 File Offset: 0x00019A40
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000026F2 File Offset: 0x000008F2
		public unsafe int attrIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_attrIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_attrIndex)) = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0001B868 File Offset: 0x00019A68
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0000270D File Offset: 0x0000090D
		public XmlSqlBinaryReader.QName qnameOther
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_qnameOther);
				return new XmlSqlBinaryReader.QName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_qnameOther), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0001B898 File Offset: 0x00019A98
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0000273B File Offset: 0x0000093B
		public XmlSqlBinaryReader.QName qnameElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_qnameElement);
				return new XmlSqlBinaryReader.QName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_qnameElement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0001B8C8 File Offset: 0x00019AC8
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002769 File Offset: 0x00000969
		public unsafe XmlNodeType parentNodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_parentNodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_parentNodeType)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0001B8F0 File Offset: 0x00019AF0
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002784 File Offset: 0x00000984
		public unsafe Il2CppReferenceArray<XmlSqlBinaryReader.ElemInfo> elementStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_elementStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSqlBinaryReader.ElemInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_elementStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0001B920 File Offset: 0x00019B20
		// (set) Token: 0x06000160 RID: 352 RVA: 0x000027A3 File Offset: 0x000009A3
		public unsafe int elemDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_elemDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_elemDepth)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0001B948 File Offset: 0x00019B48
		// (set) Token: 0x06000162 RID: 354 RVA: 0x000027BE File Offset: 0x000009BE
		public unsafe Il2CppReferenceArray<XmlSqlBinaryReader.AttrInfo> attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSqlBinaryReader.AttrInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0001B978 File Offset: 0x00019B78
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000027DD File Offset: 0x000009DD
		public unsafe Il2CppStructArray<int> attrHashTbl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_attrHashTbl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_attrHashTbl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0001B9A8 File Offset: 0x00019BA8
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000027FC File Offset: 0x000009FC
		public unsafe int attrCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_attrCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_attrCount)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0001B9D0 File Offset: 0x00019BD0
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002817 File Offset: 0x00000A17
		public unsafe int posAfterAttrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_posAfterAttrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_posAfterAttrs)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002832 File Offset: 0x00000A32
		public unsafe bool xmlspacePreserve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xmlspacePreserve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xmlspacePreserve)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0001BA20 File Offset: 0x00019C20
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0000284D File Offset: 0x00000A4D
		public unsafe int tokLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_tokLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_tokLen)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0001BA48 File Offset: 0x00019C48
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002868 File Offset: 0x00000A68
		public unsafe int tokDataPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_tokDataPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_tokDataPos)) = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0001BA70 File Offset: 0x00019C70
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002883 File Offset: 0x00000A83
		public unsafe bool hasTypedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_hasTypedValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_hasTypedValue)) = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0001BA98 File Offset: 0x00019C98
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000289E File Offset: 0x00000A9E
		public unsafe Type valueType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_valueType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_valueType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000028BD File Offset: 0x00000ABD
		public unsafe string stringValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_stringValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_stringValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0001BAF0 File Offset: 0x00019CF0
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000028DC File Offset: 0x00000ADC
		public unsafe Dictionary<string, XmlSqlBinaryReader.NamespaceDecl> namespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_namespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, XmlSqlBinaryReader.NamespaceDecl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_namespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0001BB20 File Offset: 0x00019D20
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000028FB File Offset: 0x00000AFB
		public unsafe XmlSqlBinaryReader.NestedBinXml prevNameInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_prevNameInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSqlBinaryReader.NestedBinXml>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_prevNameInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0001BB50 File Offset: 0x00019D50
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000291A File Offset: 0x00000B1A
		public unsafe XmlReader textXmlReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_textXmlReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_textXmlReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0001BB80 File Offset: 0x00019D80
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002939 File Offset: 0x00000B39
		public unsafe bool closeInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_closeInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_closeInput)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0001BBA8 File Offset: 0x00019DA8
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002954 File Offset: 0x00000B54
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000296F File Offset: 0x00000B6F
		public unsafe bool ignoreWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_ignoreWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_ignoreWhitespace)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0001BBF8 File Offset: 0x00019DF8
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000298A File Offset: 0x00000B8A
		public unsafe bool ignorePIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_ignorePIs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_ignorePIs)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0001BC20 File Offset: 0x00019E20
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000029A5 File Offset: 0x00000BA5
		public unsafe bool ignoreComments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_ignoreComments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_ignoreComments)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0001BC48 File Offset: 0x00019E48
		// (set) Token: 0x06000186 RID: 390 RVA: 0x000029C0 File Offset: 0x00000BC0
		public unsafe DtdProcessing dtdProcessing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_dtdProcessing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_dtdProcessing)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0001BC70 File Offset: 0x00019E70
		// (set) Token: 0x06000188 RID: 392 RVA: 0x000029DB File Offset: 0x00000BDB
		public unsafe SecureStringHasher hasher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_hasher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecureStringHasher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_hasher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0001BCA0 File Offset: 0x00019EA0
		// (set) Token: 0x0600018A RID: 394 RVA: 0x000029FA File Offset: 0x00000BFA
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0001BCD0 File Offset: 0x00019ED0
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002A28 File Offset: 0x00000C28
		public unsafe Encoding unicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_unicode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_unicode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0001BD00 File Offset: 0x00019F00
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002A47 File Offset: 0x00000C47
		public unsafe byte version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_TypeOfObject;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_TypeOfString;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_TokenTypeMap;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_XsdKatmaiTimeScaleToValueLengthMap;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_ScanState2ReadState;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_inStrm;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_mark;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_end;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_eof;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_sniffed;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_isEmpty;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_docState;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_symbolTables;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_xnt;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_xntFromSettings;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_xml;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_xmlns;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_nsxmlns;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_baseUri;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_nodetype;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_token;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_attrIndex;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_qnameOther;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_qnameElement;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_parentNodeType;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_elementStack;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_elemDepth;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_attrHashTbl;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_attrCount;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_posAfterAttrs;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_xmlspacePreserve;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_tokLen;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_tokDataPos;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_hasTypedValue;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_valueType;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_stringValue;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_namespaces;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_prevNameInfo;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_textXmlReader;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_closeInput;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_ignoreWhitespace;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_ignorePIs;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_ignoreComments;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_dtdProcessing;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_hasher;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_unicode;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Il2CppStructArray_1_Byte_Int32_String_Boolean_XmlReaderSettings_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_VerifyVersion_Private_Void_Int32_BinXmlToken_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_AddInitNamespace_Private_Void_String_String_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Private_Void_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_AddQName_Private_Void_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_NameFlush_Private_Void_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_SkipExtn_Private_Void_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_ReadQNameRef_Private_Int32_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_ReadNameRef_Private_Int32_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_FillAllowEOF_Private_Boolean_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_Fill__Private_Void_Int32_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_Fill_Private_Void_Int32_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Private_Byte_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_ReadUShort_Private_UInt16_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_ParseMB32_Private_Int32_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_ParseMB32__Private_Int32_Byte_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_ParseMB32_Private_Int32_Int32_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_ParseMB64_Private_Int32_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_PeekToken_Private_BinXmlToken_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_ReadToken_Private_BinXmlToken_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_NextToken2_Private_BinXmlToken_BinXmlToken_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_NextToken1_Private_BinXmlToken_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_NextToken_Private_BinXmlToken_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_PeekNextToken_Private_BinXmlToken_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_RescanNextToken_Private_BinXmlToken_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_ParseText_Private_String_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_ScanText_Private_Int32_byref_Int32_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Private_String_Int32_Int32_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_GetStringAligned_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeText_Private_String_Int32_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_LocateAttribute_Private_Int32_String_String_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_LocateAttribute_Private_Int32_String_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_PositionOnAttribute_Private_Void_Int32_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_GrowElements_Private_Void_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_GrowAttributes_Private_Void_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_ClearAttributes_Private_Void_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_PushNamespace_Private_Void_String_String_Boolean_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_PopNamespaces_Private_Void_NamespaceDecl_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_GenerateImpliedXmlnsAttrs_Private_Void_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_ReadInit_Private_Boolean_Boolean_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttributes_Private_Void_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_SimpleCheckForDuplicateAttributes_Private_Void_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_HashCheckForDuplicateAttributes_Private_Void_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_XmlDeclValue_Private_String_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_CDATAValue_Private_String_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_FinishCDATA_Private_Void_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_FinishEndElement_Private_Void_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_ReadDoc_Private_Boolean_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_ImplReadData_Private_Void_BinXmlToken_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_ImplReadElement_Private_Void_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_ImplReadEndElement_Private_Void_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_ImplReadDoctype_Private_Void_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_ImplReadPI_Private_Void_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_ImplReadComment_Private_Void_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_ImplReadCDATA_Private_Void_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_ImplReadNest_Private_Void_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_ImplReadEndNest_Private_Void_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_ImplReadXmlText_Private_Void_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFromTextReader_Private_Void_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFromTextReader_Private_Boolean_Boolean_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_CheckAllowContent_Private_Void_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTokenTypeMap_Private_Void_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_GetValueType_Private_Type_BinXmlToken_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_ReScanOverValue_Private_Void_BinXmlToken_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_ScanOverValue_Private_XmlNodeType_BinXmlToken_Boolean_Boolean_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_ScanOverAnyValue_Private_XmlNodeType_BinXmlToken_Boolean_Boolean_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_CheckText_Private_XmlNodeType_Boolean_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_CheckTextIsWS_Private_XmlNodeType_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueTokenBounds_Private_Void_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdKatmaiTokenLength_Private_Int32_BinXmlToken_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_XsdKatmaiTimeScaleToValueLength_Private_Int32_Byte_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_ValueAsLong_Private_Int64_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_ValueAsULong_Private_UInt64_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_ValueAsDecimal_Private_Decimal_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_ValueAsDouble_Private_Double_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_ValueAsDateTimeString_Private_String_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_ValueAsString_Private_String_BinXmlToken_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_GetInt16_Private_Int16_Int32_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_GetUInt16_Private_UInt16_Int32_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_GetInt32_Private_Int32_Int32_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_GetUInt32_Private_UInt32_Int32_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_GetInt64_Private_Int64_Int32_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_GetUInt64_Private_UInt64_Int32_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_GetSingle_Private_Single_Int32_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_GetDouble_Private_Double_Int32_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Exception_BinXmlToken_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_ThrowXmlException_Private_Exception_String_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_ThrowXmlException_Private_Exception_String_String_String_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNotSupported_Private_Exception_String_0;

		// Token: 0x02000210 RID: 528
		public enum ScanState
		{
			// Token: 0x0400235D RID: 9053
			Doc,
			// Token: 0x0400235E RID: 9054
			XmlText,
			// Token: 0x0400235F RID: 9055
			Attr,
			// Token: 0x04002360 RID: 9056
			AttrVal,
			// Token: 0x04002361 RID: 9057
			AttrValPseudoValue,
			// Token: 0x04002362 RID: 9058
			Init,
			// Token: 0x04002363 RID: 9059
			Error,
			// Token: 0x04002364 RID: 9060
			EOF,
			// Token: 0x04002365 RID: 9061
			Closed
		}

		// Token: 0x02000211 RID: 529
		public sealed class QName : ValueType
		{
			// Token: 0x06002E92 RID: 11922 RVA: 0x000D47C8 File Offset: 0x000D29C8
			// Note: this type is marked as 'beforefieldinit'.
			static QName()
			{
				Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "QName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr);
				XmlSqlBinaryReader.QName.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, "prefix");
				XmlSqlBinaryReader.QName.NativeFieldInfoPtr_localname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, "localname");
				XmlSqlBinaryReader.QName.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, "namespaceUri");
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663489);
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr_Set_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663490);
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663491);
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr_MatchNs_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663492);
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr_MatchPrefix_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663493);
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr_CheckPrefixNS_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663494);
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663495);
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr_GetNSHashCode_Public_Int32_SecureStringHasher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663496);
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663497);
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663498);
				XmlSqlBinaryReader.QName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_QName_QName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, 100663499);
			}

			// Token: 0x06002E93 RID: 11923 RVA: 0x000D490C File Offset: 0x000D2B0C
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 338072, RefRangeEnd = 338082, XrefRangeStart = 338072, XrefRangeEnd = 338082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QName(string prefix, string lname, string nsUri)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lname);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nsUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E94 RID: 11924 RVA: 0x000D4980 File Offset: 0x000D2B80
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 338072, RefRangeEnd = 338082, XrefRangeStart = 338072, XrefRangeEnd = 338082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string lname, string nsUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lname);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nsUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr_Set_Public_Void_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E95 RID: 11925 RVA: 0x000D49EC File Offset: 0x000D2BEC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 362765, RefRangeEnd = 362767, XrefRangeStart = 362760, XrefRangeEnd = 362765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E96 RID: 11926 RVA: 0x000D4A24 File Offset: 0x000D2C24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 362768, RefRangeEnd = 362769, XrefRangeStart = 362767, XrefRangeEnd = 362768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MatchNs(string lname, string nsUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(lname);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nsUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr_MatchNs_Public_Boolean_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002E97 RID: 11927 RVA: 0x000D4A88 File Offset: 0x000D2C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362769, XrefRangeEnd = 362770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MatchPrefix(string prefix, string lname)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr_MatchPrefix_Public_Boolean_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002E98 RID: 11928 RVA: 0x000D4AEC File Offset: 0x000D2CEC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 362772, RefRangeEnd = 362774, XrefRangeStart = 362770, XrefRangeEnd = 362772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckPrefixNS(string prefix, string namespaceUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr_CheckPrefixNS_Public_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E99 RID: 11929 RVA: 0x000D4B48 File Offset: 0x000D2D48
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002E9A RID: 11930 RVA: 0x000D4B8C File Offset: 0x000D2D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362774, XrefRangeEnd = 362776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetNSHashCode(SecureStringHasher hasher)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasher);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr_GetNSHashCode_Public_Int32_SecureStringHasher_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002E9B RID: 11931 RVA: 0x000D4BE0 File Offset: 0x000D2DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362776, XrefRangeEnd = 362782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002E9C RID: 11932 RVA: 0x000D4C34 File Offset: 0x000D2E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362782, XrefRangeEnd = 362785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06002E9D RID: 11933 RVA: 0x000D4C70 File Offset: 0x000D2E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362785, XrefRangeEnd = 362788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator ==(XmlSqlBinaryReader.QName a, XmlSqlBinaryReader.QName b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.QName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_QName_QName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002E9E RID: 11934 RVA: 0x00013381 File Offset: 0x00011581
			public QName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002E9F RID: 11935 RVA: 0x0001338A File Offset: 0x0001158A
			public QName()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr))
			{
			}

			// Token: 0x17000FAA RID: 4010
			// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x000D4CD0 File Offset: 0x000D2ED0
			// (set) Token: 0x06002EA1 RID: 11937 RVA: 0x0001339C File Offset: 0x0001159C
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.QName.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.QName.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FAB RID: 4011
			// (get) Token: 0x06002EA2 RID: 11938 RVA: 0x000D4CF8 File Offset: 0x000D2EF8
			// (set) Token: 0x06002EA3 RID: 11939 RVA: 0x000133BB File Offset: 0x000115BB
			public unsafe string localname
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.QName.NativeFieldInfoPtr_localname);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.QName.NativeFieldInfoPtr_localname), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FAC RID: 4012
			// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x000D4D20 File Offset: 0x000D2F20
			// (set) Token: 0x06002EA5 RID: 11941 RVA: 0x000133DA File Offset: 0x000115DA
			public unsafe string namespaceUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.QName.NativeFieldInfoPtr_namespaceUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.QName.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002366 RID: 9062
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04002367 RID: 9063
			private static readonly IntPtr NativeFieldInfoPtr_localname;

			// Token: 0x04002368 RID: 9064
			private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

			// Token: 0x04002369 RID: 9065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

			// Token: 0x0400236A RID: 9066
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_String_String_0;

			// Token: 0x0400236B RID: 9067
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x0400236C RID: 9068
			private static readonly IntPtr NativeMethodInfoPtr_MatchNs_Public_Boolean_String_String_0;

			// Token: 0x0400236D RID: 9069
			private static readonly IntPtr NativeMethodInfoPtr_MatchPrefix_Public_Boolean_String_String_0;

			// Token: 0x0400236E RID: 9070
			private static readonly IntPtr NativeMethodInfoPtr_CheckPrefixNS_Public_Void_String_String_0;

			// Token: 0x0400236F RID: 9071
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04002370 RID: 9072
			private static readonly IntPtr NativeMethodInfoPtr_GetNSHashCode_Public_Int32_SecureStringHasher_0;

			// Token: 0x04002371 RID: 9073
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04002372 RID: 9074
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04002373 RID: 9075
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_QName_QName_0;
		}

		// Token: 0x02000212 RID: 530
		public sealed class ElemInfo : ValueType
		{
			// Token: 0x06002EA6 RID: 11942 RVA: 0x000D4D48 File Offset: 0x000D2F48
			// Note: this type is marked as 'beforefieldinit'.
			static ElemInfo()
			{
				Il2CppClassPointerStore<XmlSqlBinaryReader.ElemInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "ElemInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSqlBinaryReader.ElemInfo>.NativeClassPtr);
				XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.ElemInfo>.NativeClassPtr, "name");
				XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.ElemInfo>.NativeClassPtr, "xmlLang");
				XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.ElemInfo>.NativeClassPtr, "xmlSpace");
				XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_xmlspacePreserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.ElemInfo>.NativeClassPtr, "xmlspacePreserve");
				XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_nsdecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.ElemInfo>.NativeClassPtr, "nsdecls");
				XmlSqlBinaryReader.ElemInfo.NativeMethodInfoPtr_Set_Public_Void_QName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.ElemInfo>.NativeClassPtr, 100663500);
				XmlSqlBinaryReader.ElemInfo.NativeMethodInfoPtr_Clear_Public_NamespaceDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.ElemInfo>.NativeClassPtr, 100663501);
			}

			// Token: 0x06002EA7 RID: 11943 RVA: 0x000D4E00 File Offset: 0x000D3000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362788, XrefRangeEnd = 362790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(XmlSqlBinaryReader.QName name, bool xmlspacePreserve)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(name));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmlspacePreserve;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.ElemInfo.NativeMethodInfoPtr_Set_Public_Void_QName_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EA8 RID: 11944 RVA: 0x000D4E5C File Offset: 0x000D305C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362790, XrefRangeEnd = 362791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlSqlBinaryReader.NamespaceDecl Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.ElemInfo.NativeMethodInfoPtr_Clear_Public_NamespaceDecl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSqlBinaryReader.NamespaceDecl>(intPtr3) : null;
			}

			// Token: 0x06002EA9 RID: 11945 RVA: 0x000133F9 File Offset: 0x000115F9
			public ElemInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002EAA RID: 11946 RVA: 0x00013402 File Offset: 0x00011602
			public ElemInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSqlBinaryReader.ElemInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17000FAD RID: 4013
			// (get) Token: 0x06002EAB RID: 11947 RVA: 0x000D4EA0 File Offset: 0x000D30A0
			// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00013414 File Offset: 0x00011614
			public XmlSqlBinaryReader.QName name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_name);
					return new XmlSqlBinaryReader.QName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_name), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FAE RID: 4014
			// (get) Token: 0x06002EAD RID: 11949 RVA: 0x000D4ED0 File Offset: 0x000D30D0
			// (set) Token: 0x06002EAE RID: 11950 RVA: 0x00013442 File Offset: 0x00011642
			public unsafe string xmlLang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_xmlLang);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FAF RID: 4015
			// (get) Token: 0x06002EAF RID: 11951 RVA: 0x000D4EF8 File Offset: 0x000D30F8
			// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00013461 File Offset: 0x00011661
			public unsafe XmlSpace xmlSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_xmlSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_xmlSpace)) = value;
				}
			}

			// Token: 0x17000FB0 RID: 4016
			// (get) Token: 0x06002EB1 RID: 11953 RVA: 0x000D4F20 File Offset: 0x000D3120
			// (set) Token: 0x06002EB2 RID: 11954 RVA: 0x0001347C File Offset: 0x0001167C
			public unsafe bool xmlspacePreserve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_xmlspacePreserve);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_xmlspacePreserve)) = value;
				}
			}

			// Token: 0x17000FB1 RID: 4017
			// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x000D4F48 File Offset: 0x000D3148
			// (set) Token: 0x06002EB4 RID: 11956 RVA: 0x00013497 File Offset: 0x00011697
			public unsafe XmlSqlBinaryReader.NamespaceDecl nsdecls
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_nsdecls);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSqlBinaryReader.NamespaceDecl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.ElemInfo.NativeFieldInfoPtr_nsdecls), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002374 RID: 9076
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04002375 RID: 9077
			private static readonly IntPtr NativeFieldInfoPtr_xmlLang;

			// Token: 0x04002376 RID: 9078
			private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

			// Token: 0x04002377 RID: 9079
			private static readonly IntPtr NativeFieldInfoPtr_xmlspacePreserve;

			// Token: 0x04002378 RID: 9080
			private static readonly IntPtr NativeFieldInfoPtr_nsdecls;

			// Token: 0x04002379 RID: 9081
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_QName_Boolean_0;

			// Token: 0x0400237A RID: 9082
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_NamespaceDecl_0;
		}

		// Token: 0x02000213 RID: 531
		public sealed class AttrInfo : ValueType
		{
			// Token: 0x06002EB5 RID: 11957 RVA: 0x000D4F78 File Offset: 0x000D3178
			// Note: this type is marked as 'beforefieldinit'.
			static AttrInfo()
			{
				Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "AttrInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr);
				XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, "name");
				XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, "val");
				XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_contentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, "contentPos");
				XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, "hashCode");
				XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_prevHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, "prevHash");
				XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_Set_Public_Void_QName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, 100663502);
				XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_Set_Public_Void_QName_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, 100663503);
				XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_GetLocalnameAndNamespaceUri_Public_Void_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, 100663504);
				XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_GetLocalnameAndNamespaceUriAndHash_Public_Int32_SecureStringHasher_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, 100663505);
				XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_MatchNS_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, 100663506);
				XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_MatchHashNS_Public_Boolean_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, 100663507);
				XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_AdjustPosition_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr, 100663508);
			}

			// Token: 0x06002EB6 RID: 11958 RVA: 0x000D5094 File Offset: 0x000D3294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362791, XrefRangeEnd = 362793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(XmlSqlBinaryReader.QName n, string v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(n));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_Set_Public_Void_QName_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EB7 RID: 11959 RVA: 0x000D50F4 File Offset: 0x000D32F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362793, XrefRangeEnd = 362795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(XmlSqlBinaryReader.QName n, int pos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(n));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_Set_Public_Void_QName_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EB8 RID: 11960 RVA: 0x000D5150 File Offset: 0x000D3350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362795, XrefRangeEnd = 362797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri)
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
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_GetLocalnameAndNamespaceUri_Public_Void_byref_String_byref_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				localname = IL2CPP.Il2CppStringToManaged(intPtr);
				namespaceUri = IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			// Token: 0x06002EB9 RID: 11961 RVA: 0x000D51BC File Offset: 0x000D33BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362797, XrefRangeEnd = 362801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasher);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_GetLocalnameAndNamespaceUriAndHash_Public_Int32_SecureStringHasher_byref_String_byref_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				localname = IL2CPP.Il2CppStringToManaged(intPtr);
				namespaceUri = IL2CPP.Il2CppStringToManaged(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06002EBA RID: 11962 RVA: 0x000D5244 File Offset: 0x000D3444
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 362768, RefRangeEnd = 362769, XrefRangeStart = 362768, XrefRangeEnd = 362769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MatchNS(string localname, string namespaceUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(localname);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_MatchNS_Public_Boolean_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002EBB RID: 11963 RVA: 0x000D52A8 File Offset: 0x000D34A8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 362802, RefRangeEnd = 362803, XrefRangeStart = 362801, XrefRangeEnd = 362802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MatchHashNS(int hash, string localname, string namespaceUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hash;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localname);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_MatchHashNS_Public_Boolean_Int32_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002EBC RID: 11964 RVA: 0x000D531C File Offset: 0x000D351C
			[CallerCount(0)]
			public unsafe void AdjustPosition(int adj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref adj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.AttrInfo.NativeMethodInfoPtr_AdjustPosition_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002EBD RID: 11965 RVA: 0x000134B6 File Offset: 0x000116B6
			public AttrInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002EBE RID: 11966 RVA: 0x000134BF File Offset: 0x000116BF
			public AttrInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSqlBinaryReader.AttrInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17000FB2 RID: 4018
			// (get) Token: 0x06002EBF RID: 11967 RVA: 0x000D5360 File Offset: 0x000D3560
			// (set) Token: 0x06002EC0 RID: 11968 RVA: 0x000134D1 File Offset: 0x000116D1
			public XmlSqlBinaryReader.QName name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_name);
					return new XmlSqlBinaryReader.QName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_name), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlSqlBinaryReader.QName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FB3 RID: 4019
			// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x000D5390 File Offset: 0x000D3590
			// (set) Token: 0x06002EC2 RID: 11970 RVA: 0x000134FF File Offset: 0x000116FF
			public unsafe string val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_val);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_val), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FB4 RID: 4020
			// (get) Token: 0x06002EC3 RID: 11971 RVA: 0x000D53B8 File Offset: 0x000D35B8
			// (set) Token: 0x06002EC4 RID: 11972 RVA: 0x0001351E File Offset: 0x0001171E
			public unsafe int contentPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_contentPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_contentPos)) = value;
				}
			}

			// Token: 0x17000FB5 RID: 4021
			// (get) Token: 0x06002EC5 RID: 11973 RVA: 0x000D53E0 File Offset: 0x000D35E0
			// (set) Token: 0x06002EC6 RID: 11974 RVA: 0x00013539 File Offset: 0x00011739
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x17000FB6 RID: 4022
			// (get) Token: 0x06002EC7 RID: 11975 RVA: 0x000D5408 File Offset: 0x000D3608
			// (set) Token: 0x06002EC8 RID: 11976 RVA: 0x00013554 File Offset: 0x00011754
			public unsafe int prevHash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_prevHash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.AttrInfo.NativeFieldInfoPtr_prevHash)) = value;
				}
			}

			// Token: 0x0400237B RID: 9083
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400237C RID: 9084
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x0400237D RID: 9085
			private static readonly IntPtr NativeFieldInfoPtr_contentPos;

			// Token: 0x0400237E RID: 9086
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x0400237F RID: 9087
			private static readonly IntPtr NativeFieldInfoPtr_prevHash;

			// Token: 0x04002380 RID: 9088
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_QName_String_0;

			// Token: 0x04002381 RID: 9089
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_QName_Int32_0;

			// Token: 0x04002382 RID: 9090
			private static readonly IntPtr NativeMethodInfoPtr_GetLocalnameAndNamespaceUri_Public_Void_byref_String_byref_String_0;

			// Token: 0x04002383 RID: 9091
			private static readonly IntPtr NativeMethodInfoPtr_GetLocalnameAndNamespaceUriAndHash_Public_Int32_SecureStringHasher_byref_String_byref_String_0;

			// Token: 0x04002384 RID: 9092
			private static readonly IntPtr NativeMethodInfoPtr_MatchNS_Public_Boolean_String_String_0;

			// Token: 0x04002385 RID: 9093
			private static readonly IntPtr NativeMethodInfoPtr_MatchHashNS_Public_Boolean_Int32_String_String_0;

			// Token: 0x04002386 RID: 9094
			private static readonly IntPtr NativeMethodInfoPtr_AdjustPosition_Public_Void_Int32_0;
		}

		// Token: 0x02000214 RID: 532
		public class NamespaceDecl : Object
		{
			// Token: 0x06002EC9 RID: 11977 RVA: 0x000D5430 File Offset: 0x000D3630
			// Note: this type is marked as 'beforefieldinit'.
			static NamespaceDecl()
			{
				Il2CppClassPointerStore<XmlSqlBinaryReader.NamespaceDecl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "NamespaceDecl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSqlBinaryReader.NamespaceDecl>.NativeClassPtr);
				XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.NamespaceDecl>.NativeClassPtr, "prefix");
				XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.NamespaceDecl>.NativeClassPtr, "uri");
				XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_scopeLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.NamespaceDecl>.NativeClassPtr, "scopeLink");
				XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_prevLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.NamespaceDecl>.NativeClassPtr, "prevLink");
				XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.NamespaceDecl>.NativeClassPtr, "scope");
				XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_implied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.NamespaceDecl>.NativeClassPtr, "implied");
				XmlSqlBinaryReader.NamespaceDecl.NativeMethodInfoPtr__ctor_Public_Void_String_String_NamespaceDecl_NamespaceDecl_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.NamespaceDecl>.NativeClassPtr, 100663509);
			}

			// Token: 0x06002ECA RID: 11978 RVA: 0x000D54E8 File Offset: 0x000D36E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362803, XrefRangeEnd = 362808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamespaceDecl(string prefix, string nsuri, XmlSqlBinaryReader.NamespaceDecl nextInScope, XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSqlBinaryReader.NamespaceDecl>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nsuri);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextInScope);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prevDecl);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scope;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref implied;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NamespaceDecl.NativeMethodInfoPtr__ctor_Public_Void_String_String_NamespaceDecl_NamespaceDecl_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ECB RID: 11979 RVA: 0x0001356F File Offset: 0x0001176F
			public NamespaceDecl(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FB7 RID: 4023
			// (get) Token: 0x06002ECC RID: 11980 RVA: 0x000D5588 File Offset: 0x000D3788
			// (set) Token: 0x06002ECD RID: 11981 RVA: 0x00013578 File Offset: 0x00011778
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FB8 RID: 4024
			// (get) Token: 0x06002ECE RID: 11982 RVA: 0x000D55B0 File Offset: 0x000D37B0
			// (set) Token: 0x06002ECF RID: 11983 RVA: 0x00013597 File Offset: 0x00011797
			public unsafe string uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_uri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_uri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000FB9 RID: 4025
			// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x000D55D8 File Offset: 0x000D37D8
			// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x000135B6 File Offset: 0x000117B6
			public unsafe XmlSqlBinaryReader.NamespaceDecl scopeLink
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_scopeLink);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSqlBinaryReader.NamespaceDecl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_scopeLink), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FBA RID: 4026
			// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x000D5608 File Offset: 0x000D3808
			// (set) Token: 0x06002ED3 RID: 11987 RVA: 0x000135D5 File Offset: 0x000117D5
			public unsafe XmlSqlBinaryReader.NamespaceDecl prevLink
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_prevLink);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSqlBinaryReader.NamespaceDecl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_prevLink), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FBB RID: 4027
			// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x000D5638 File Offset: 0x000D3838
			// (set) Token: 0x06002ED5 RID: 11989 RVA: 0x000135F4 File Offset: 0x000117F4
			public unsafe int scope
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_scope);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_scope)) = value;
				}
			}

			// Token: 0x17000FBC RID: 4028
			// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x000D5660 File Offset: 0x000D3860
			// (set) Token: 0x06002ED7 RID: 11991 RVA: 0x0001360F File Offset: 0x0001180F
			public unsafe bool implied
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_implied);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NamespaceDecl.NativeFieldInfoPtr_implied)) = value;
				}
			}

			// Token: 0x04002387 RID: 9095
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04002388 RID: 9096
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x04002389 RID: 9097
			private static readonly IntPtr NativeFieldInfoPtr_scopeLink;

			// Token: 0x0400238A RID: 9098
			private static readonly IntPtr NativeFieldInfoPtr_prevLink;

			// Token: 0x0400238B RID: 9099
			private static readonly IntPtr NativeFieldInfoPtr_scope;

			// Token: 0x0400238C RID: 9100
			private static readonly IntPtr NativeFieldInfoPtr_implied;

			// Token: 0x0400238D RID: 9101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_NamespaceDecl_NamespaceDecl_Int32_Boolean_0;
		}

		// Token: 0x02000215 RID: 533
		public sealed class SymbolTables : ValueType
		{
			// Token: 0x06002ED8 RID: 11992 RVA: 0x000D5688 File Offset: 0x000D3888
			// Note: this type is marked as 'beforefieldinit'.
			static SymbolTables()
			{
				Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "SymbolTables");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr);
				XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_symtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr, "symtable");
				XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_symCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr, "symCount");
				XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_qnametable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr, "qnametable");
				XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_qnameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr, "qnameCount");
				XmlSqlBinaryReader.SymbolTables.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr, 100663510);
			}

			// Token: 0x06002ED9 RID: 11993 RVA: 0x000D5718 File Offset: 0x000D3918
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 362819, RefRangeEnd = 362821, XrefRangeStart = 362808, XrefRangeEnd = 362819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.SymbolTables.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EDA RID: 11994 RVA: 0x0001362A File Offset: 0x0001182A
			public SymbolTables(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002EDB RID: 11995 RVA: 0x00013633 File Offset: 0x00011833
			public SymbolTables()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr))
			{
			}

			// Token: 0x17000FBD RID: 4029
			// (get) Token: 0x06002EDC RID: 11996 RVA: 0x000D5750 File Offset: 0x000D3950
			// (set) Token: 0x06002EDD RID: 11997 RVA: 0x00013645 File Offset: 0x00011845
			public unsafe Il2CppStringArray symtable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_symtable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_symtable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FBE RID: 4030
			// (get) Token: 0x06002EDE RID: 11998 RVA: 0x000D5780 File Offset: 0x000D3980
			// (set) Token: 0x06002EDF RID: 11999 RVA: 0x00013664 File Offset: 0x00011864
			public unsafe int symCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_symCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_symCount)) = value;
				}
			}

			// Token: 0x17000FBF RID: 4031
			// (get) Token: 0x06002EE0 RID: 12000 RVA: 0x000D57A8 File Offset: 0x000D39A8
			// (set) Token: 0x06002EE1 RID: 12001 RVA: 0x0001367F File Offset: 0x0001187F
			public unsafe Il2CppReferenceArray<XmlSqlBinaryReader.QName> qnametable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_qnametable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSqlBinaryReader.QName>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_qnametable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC0 RID: 4032
			// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x000D57D8 File Offset: 0x000D39D8
			// (set) Token: 0x06002EE3 RID: 12003 RVA: 0x0001369E File Offset: 0x0001189E
			public unsafe int qnameCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_qnameCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.SymbolTables.NativeFieldInfoPtr_qnameCount)) = value;
				}
			}

			// Token: 0x0400238E RID: 9102
			private static readonly IntPtr NativeFieldInfoPtr_symtable;

			// Token: 0x0400238F RID: 9103
			private static readonly IntPtr NativeFieldInfoPtr_symCount;

			// Token: 0x04002390 RID: 9104
			private static readonly IntPtr NativeFieldInfoPtr_qnametable;

			// Token: 0x04002391 RID: 9105
			private static readonly IntPtr NativeFieldInfoPtr_qnameCount;

			// Token: 0x04002392 RID: 9106
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;
		}

		// Token: 0x02000216 RID: 534
		public class NestedBinXml : Object
		{
			// Token: 0x06002EE4 RID: 12004 RVA: 0x000D5800 File Offset: 0x000D3A00
			// Note: this type is marked as 'beforefieldinit'.
			static NestedBinXml()
			{
				Il2CppClassPointerStore<XmlSqlBinaryReader.NestedBinXml>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSqlBinaryReader>.NativeClassPtr, "NestedBinXml");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSqlBinaryReader.NestedBinXml>.NativeClassPtr);
				XmlSqlBinaryReader.NestedBinXml.NativeFieldInfoPtr_symbolTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.NestedBinXml>.NativeClassPtr, "symbolTables");
				XmlSqlBinaryReader.NestedBinXml.NativeFieldInfoPtr_docState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.NestedBinXml>.NativeClassPtr, "docState");
				XmlSqlBinaryReader.NestedBinXml.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSqlBinaryReader.NestedBinXml>.NativeClassPtr, "next");
				XmlSqlBinaryReader.NestedBinXml.NativeMethodInfoPtr__ctor_Public_Void_SymbolTables_Int32_NestedBinXml_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSqlBinaryReader.NestedBinXml>.NativeClassPtr, 100663511);
			}

			// Token: 0x06002EE5 RID: 12005 RVA: 0x000D587C File Offset: 0x000D3A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362821, XrefRangeEnd = 362824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NestedBinXml(XmlSqlBinaryReader.SymbolTables symbolTables, int docState, XmlSqlBinaryReader.NestedBinXml next)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSqlBinaryReader.NestedBinXml>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(symbolTables));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref docState;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSqlBinaryReader.NestedBinXml.NativeMethodInfoPtr__ctor_Public_Void_SymbolTables_Int32_NestedBinXml_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EE6 RID: 12006 RVA: 0x000136B9 File Offset: 0x000118B9
			public NestedBinXml(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FC1 RID: 4033
			// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x000D58EC File Offset: 0x000D3AEC
			// (set) Token: 0x06002EE8 RID: 12008 RVA: 0x000136C2 File Offset: 0x000118C2
			public XmlSqlBinaryReader.SymbolTables symbolTables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NestedBinXml.NativeFieldInfoPtr_symbolTables);
					return new XmlSqlBinaryReader.SymbolTables(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NestedBinXml.NativeFieldInfoPtr_symbolTables), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlSqlBinaryReader.SymbolTables>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FC2 RID: 4034
			// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x000D591C File Offset: 0x000D3B1C
			// (set) Token: 0x06002EEA RID: 12010 RVA: 0x000136F0 File Offset: 0x000118F0
			public unsafe int docState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NestedBinXml.NativeFieldInfoPtr_docState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NestedBinXml.NativeFieldInfoPtr_docState)) = value;
				}
			}

			// Token: 0x17000FC3 RID: 4035
			// (get) Token: 0x06002EEB RID: 12011 RVA: 0x000D5944 File Offset: 0x000D3B44
			// (set) Token: 0x06002EEC RID: 12012 RVA: 0x0001370B File Offset: 0x0001190B
			public unsafe XmlSqlBinaryReader.NestedBinXml next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NestedBinXml.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSqlBinaryReader.NestedBinXml>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSqlBinaryReader.NestedBinXml.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002393 RID: 9107
			private static readonly IntPtr NativeFieldInfoPtr_symbolTables;

			// Token: 0x04002394 RID: 9108
			private static readonly IntPtr NativeFieldInfoPtr_docState;

			// Token: 0x04002395 RID: 9109
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04002396 RID: 9110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SymbolTables_Int32_NestedBinXml_0;
		}
	}
}
