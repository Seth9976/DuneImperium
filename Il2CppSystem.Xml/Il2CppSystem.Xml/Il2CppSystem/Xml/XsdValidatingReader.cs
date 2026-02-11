using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005C RID: 92
	public class XsdValidatingReader : XmlReader
	{
		// Token: 0x06000AC7 RID: 2759 RVA: 0x00044980 File Offset: 0x00042B80
		// Note: this type is marked as 'beforefieldinit'.
		static XsdValidatingReader()
		{
			Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XsdValidatingReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr);
			XsdValidatingReader.NativeFieldInfoPtr_coreReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "coreReader");
			XsdValidatingReader.NativeFieldInfoPtr_coreReaderNSResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "coreReaderNSResolver");
			XsdValidatingReader.NativeFieldInfoPtr_thisNSResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "thisNSResolver");
			XsdValidatingReader.NativeFieldInfoPtr_validator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "validator");
			XsdValidatingReader.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "xmlResolver");
			XsdValidatingReader.NativeFieldInfoPtr_validationEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "validationEvent");
			XsdValidatingReader.NativeFieldInfoPtr_validationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "validationState");
			XsdValidatingReader.NativeFieldInfoPtr_valueGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "valueGetter");
			XsdValidatingReader.NativeFieldInfoPtr_nsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "nsManager");
			XsdValidatingReader.NativeFieldInfoPtr_manageNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "manageNamespaces");
			XsdValidatingReader.NativeFieldInfoPtr_processInlineSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "processInlineSchema");
			XsdValidatingReader.NativeFieldInfoPtr_replayCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "replayCache");
			XsdValidatingReader.NativeFieldInfoPtr_cachedNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "cachedNode");
			XsdValidatingReader.NativeFieldInfoPtr_attributePSVI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "attributePSVI");
			XsdValidatingReader.NativeFieldInfoPtr_attributeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "attributeCount");
			XsdValidatingReader.NativeFieldInfoPtr_coreReaderAttributeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "coreReaderAttributeCount");
			XsdValidatingReader.NativeFieldInfoPtr_currentAttrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "currentAttrIndex");
			XsdValidatingReader.NativeFieldInfoPtr_attributePSVINodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "attributePSVINodes");
			XsdValidatingReader.NativeFieldInfoPtr_defaultAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "defaultAttributes");
			XsdValidatingReader.NativeFieldInfoPtr_inlineSchemaParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "inlineSchemaParser");
			XsdValidatingReader.NativeFieldInfoPtr_atomicValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "atomicValue");
			XsdValidatingReader.NativeFieldInfoPtr_xmlSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "xmlSchemaInfo");
			XsdValidatingReader.NativeFieldInfoPtr_originalAtomicValueString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "originalAtomicValueString");
			XsdValidatingReader.NativeFieldInfoPtr_coreReaderNameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "coreReaderNameTable");
			XsdValidatingReader.NativeFieldInfoPtr_cachingReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "cachingReader");
			XsdValidatingReader.NativeFieldInfoPtr_textNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "textNode");
			XsdValidatingReader.NativeFieldInfoPtr_NsXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "NsXmlNs");
			XsdValidatingReader.NativeFieldInfoPtr_NsXs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "NsXs");
			XsdValidatingReader.NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "NsXsi");
			XsdValidatingReader.NativeFieldInfoPtr_XsiType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "XsiType");
			XsdValidatingReader.NativeFieldInfoPtr_XsiNil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "XsiNil");
			XsdValidatingReader.NativeFieldInfoPtr_XsdSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "XsdSchema");
			XsdValidatingReader.NativeFieldInfoPtr_XsiSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "XsiSchemaLocation");
			XsdValidatingReader.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "XsiNoNamespaceSchemaLocation");
			XsdValidatingReader.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "xmlCharType");
			XsdValidatingReader.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "lineInfo");
			XsdValidatingReader.NativeFieldInfoPtr_readBinaryHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "readBinaryHelper");
			XsdValidatingReader.NativeFieldInfoPtr_savedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "savedState");
			XsdValidatingReader.NativeFieldInfoPtr_TypeOfString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, "TypeOfString");
			XsdValidatingReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665085);
			XsdValidatingReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665086);
			XsdValidatingReader.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665087);
			XsdValidatingReader.NativeMethodInfoPtr_SetupValidator_Private_Void_XmlReaderSettings_XmlReader_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665088);
			XsdValidatingReader.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665089);
			XsdValidatingReader.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665090);
			XsdValidatingReader.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665091);
			XsdValidatingReader.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665092);
			XsdValidatingReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665093);
			XsdValidatingReader.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665094);
			XsdValidatingReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665095);
			XsdValidatingReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665096);
			XsdValidatingReader.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665097);
			XsdValidatingReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665098);
			XsdValidatingReader.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665099);
			XsdValidatingReader.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665100);
			XsdValidatingReader.NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665101);
			XsdValidatingReader.NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665102);
			XsdValidatingReader.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_get_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665103);
			XsdValidatingReader.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665104);
			XsdValidatingReader.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665105);
			XsdValidatingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665106);
			XsdValidatingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665107);
			XsdValidatingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665108);
			XsdValidatingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665109);
			XsdValidatingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665110);
			XsdValidatingReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665111);
			XsdValidatingReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665112);
			XsdValidatingReader.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665113);
			XsdValidatingReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665114);
			XsdValidatingReader.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665115);
			XsdValidatingReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665116);
			XsdValidatingReader.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665117);
			XsdValidatingReader.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665118);
			XsdValidatingReader.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665119);
			XsdValidatingReader.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665120);
			XsdValidatingReader.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665121);
			XsdValidatingReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665122);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665123);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665124);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665125);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665126);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665127);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665128);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665129);
			XsdValidatingReader.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665130);
			XsdValidatingReader.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665131);
			XsdValidatingReader.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665132);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665133);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665134);
			XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665135);
			XsdValidatingReader.NativeMethodInfoPtr_GetStringValue_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665136);
			XsdValidatingReader.NativeMethodInfoPtr_get_AttributeSchemaInfo_Private_get_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665137);
			XsdValidatingReader.NativeMethodInfoPtr_ProcessReaderEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665138);
			XsdValidatingReader.NativeMethodInfoPtr_ProcessElementEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665139);
			XsdValidatingReader.NativeMethodInfoPtr_ProcessEndElementEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665140);
			XsdValidatingReader.NativeMethodInfoPtr_ValidateAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665141);
			XsdValidatingReader.NativeMethodInfoPtr_ClearAttributesInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665142);
			XsdValidatingReader.NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665143);
			XsdValidatingReader.NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665144);
			XsdValidatingReader.NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665145);
			XsdValidatingReader.NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665146);
			XsdValidatingReader.NativeMethodInfoPtr_AddAttributePSVI_Private_AttributePSVIInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665147);
			XsdValidatingReader.NativeMethodInfoPtr_IsXSDRoot_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665148);
			XsdValidatingReader.NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665149);
			XsdValidatingReader.NativeMethodInfoPtr_ReadAheadForMemberType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665150);
			XsdValidatingReader.NativeMethodInfoPtr_GetIsDefault_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665151);
			XsdValidatingReader.NativeMethodInfoPtr_GetMemberType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665152);
			XsdValidatingReader.NativeMethodInfoPtr_GetCachingReader_Private_XsdCachingReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665153);
			XsdValidatingReader.NativeMethodInfoPtr_CreateDummyTextNode_Internal_ValidatingReaderNodeData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665154);
			XsdValidatingReader.NativeMethodInfoPtr_CachingCallBack_Internal_Void_XsdCachingReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665155);
			XsdValidatingReader.NativeMethodInfoPtr_GetOriginalAtomicValueStringOfElement_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr, 100665156);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0004525C File Offset: 0x0004345C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372919, RefRangeEnd = 372920, XrefRangeStart = 372888, XrefRangeEnd = 372919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlResolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readerSettings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partialValidationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x000452E0 File Offset: 0x000434E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372921, RefRangeEnd = 372922, XrefRangeStart = 372920, XrefRangeEnd = 372921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdValidatingReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlResolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readerSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00045350 File Offset: 0x00043550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372979, RefRangeEnd = 372980, XrefRangeStart = 372922, XrefRangeEnd = 372979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00045384 File Offset: 0x00043584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372999, RefRangeEnd = 373000, XrefRangeStart = 372980, XrefRangeEnd = 372999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(readerSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partialValidationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_SetupValidator_Private_Void_XmlReaderSettings_XmlReader_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x000453EC File Offset: 0x000435EC
		public unsafe override XmlReaderSettings Settings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373000, XrefRangeEnd = 373008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00045438 File Offset: 0x00043638
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373008, XrefRangeEnd = 373010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00045480 File Offset: 0x00043680
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373010, XrefRangeEnd = 373019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x000454C4 File Offset: 0x000436C4
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00045508 File Offset: 0x00043708
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0004554C File Offset: 0x0004374C
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00045590 File Offset: 0x00043790
		public unsafe override string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x000455D4 File Offset: 0x000437D4
		public unsafe override int Depth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0004561C File Offset: 0x0004381C
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00045660 File Offset: 0x00043860
		public unsafe override bool IsEmptyElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x000456A8 File Offset: 0x000438A8
		public unsafe override bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x000456F0 File Offset: 0x000438F0
		public unsafe override char QuoteChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00045738 File Offset: 0x00043938
		public unsafe override XmlSpace XmlSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00045780 File Offset: 0x00043980
		public unsafe override string XmlLang
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x000457C4 File Offset: 0x000439C4
		public unsafe override IXmlSchemaInfo SchemaInfo
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_get_IXmlSchemaInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00045810 File Offset: 0x00043A10
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373019, XrefRangeEnd = 373023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0004585C File Offset: 0x00043A5C
		public unsafe override int AttributeCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368217, RefRangeEnd = 368218, XrefRangeStart = 368217, XrefRangeEnd = 368218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000458A4 File Offset: 0x00043AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373023, XrefRangeEnd = 373024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000458F8 File Offset: 0x00043AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373024, XrefRangeEnd = 373028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(string name, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00045960 File Offset: 0x00043B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373028, XrefRangeEnd = 373030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000459B0 File Offset: 0x00043BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373030, XrefRangeEnd = 373033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00045A08 File Offset: 0x00043C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373033, XrefRangeEnd = 373042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveToAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00045A54 File Offset: 0x00043C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373042, XrefRangeEnd = 373043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00045A9C File Offset: 0x00043C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373043, XrefRangeEnd = 373044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00045AE4 File Offset: 0x00043CE4
		[CallerCount(0)]
		public unsafe override bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00045B2C File Offset: 0x00043D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373044, XrefRangeEnd = 373045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00045B74 File Offset: 0x00043D74
		public unsafe override bool EOF
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00045BBC File Offset: 0x00043DBC
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00045BF8 File Offset: 0x00043DF8
		public unsafe override ReadState ReadState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00045C40 File Offset: 0x00043E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373045, XrefRangeEnd = 373051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00045C7C File Offset: 0x00043E7C
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00045CC8 File Offset: 0x00043EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373051, XrefRangeEnd = 373055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00045D1C File Offset: 0x00043F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373055, XrefRangeEnd = 373060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResolveEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00045D58 File Offset: 0x00043F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373060, XrefRangeEnd = 373061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadAttributeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdValidatingReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00045DA0 File Offset: 0x00043FA0
		public unsafe virtual bool System.Xml.Schema.IXmlSchemaInfo.IsDefault
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373061, XrefRangeEnd = 373062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00045DDC File Offset: 0x00043FDC
		public unsafe virtual bool System.Xml.Schema.IXmlSchemaInfo.IsNil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00045E18 File Offset: 0x00044018
		public unsafe virtual XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00045E54 File Offset: 0x00044054
		public unsafe virtual XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373062, XrefRangeEnd = 373068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00045E94 File Offset: 0x00044094
		public unsafe virtual XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00045ED4 File Offset: 0x000440D4
		public unsafe virtual XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00045F14 File Offset: 0x00044114
		public unsafe virtual XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00045F54 File Offset: 0x00044154
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00045F90 File Offset: 0x00044190
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373068, XrefRangeEnd = 373069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00045FCC File Offset: 0x000441CC
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373069, XrefRangeEnd = 373070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00046008 File Offset: 0x00044208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373070, XrefRangeEnd = 373075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary<string, string> System_Xml_IXmlNamespaceResolver_GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00046054 File Offset: 0x00044254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373075, XrefRangeEnd = 373079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0004609C File Offset: 0x0004429C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373079, XrefRangeEnd = 373083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000460E4 File Offset: 0x000442E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetStringValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetStringValue_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00046124 File Offset: 0x00044324
		public unsafe XmlSchemaInfo AttributeSchemaInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_get_AttributeSchemaInfo_Private_get_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00046164 File Offset: 0x00044364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373083, XrefRangeEnd = 373086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessReaderEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ProcessReaderEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00046198 File Offset: 0x00044398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373098, RefRangeEnd = 373099, XrefRangeStart = 373086, XrefRangeEnd = 373098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessElementEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ProcessElementEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000461CC File Offset: 0x000443CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373099, XrefRangeEnd = 373103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEndElementEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ProcessEndElementEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00046200 File Offset: 0x00044400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373103, XrefRangeEnd = 373110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ValidateAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00046234 File Offset: 0x00044434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373110, XrefRangeEnd = 373112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAttributesInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ClearAttributesInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00046268 File Offset: 0x00044468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373112, XrefRangeEnd = 373124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributePSVIInfo GetAttributePSVI(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000462B8 File Offset: 0x000444B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373124, XrefRangeEnd = 373126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributePSVIInfo GetAttributePSVI(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr3) : null;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0004631C File Offset: 0x0004451C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373137, RefRangeEnd = 373139, XrefRangeStart = 373126, XrefRangeEnd = 373137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updatePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr3) : null;
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0004637C File Offset: 0x0004457C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373144, RefRangeEnd = 373146, XrefRangeStart = 373139, XrefRangeEnd = 373144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attrLocalName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updatePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr3) : null;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000463EC File Offset: 0x000445EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373162, RefRangeEnd = 373163, XrefRangeStart = 373146, XrefRangeEnd = 373162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributePSVIInfo AddAttributePSVI(int attIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_AddAttributePSVI_Private_AttributePSVIInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00046438 File Offset: 0x00044638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373163, XrefRangeEnd = 373164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsXSDRoot(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_IsXSDRoot_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00046498 File Offset: 0x00044698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373164, XrefRangeEnd = 373169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInlineSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x000464CC File Offset: 0x000446CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373190, RefRangeEnd = 373193, XrefRangeStart = 373169, XrefRangeEnd = 373190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAheadForMemberType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_ReadAheadForMemberType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00046500 File Offset: 0x00044700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373222, RefRangeEnd = 373223, XrefRangeStart = 373193, XrefRangeEnd = 373222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIsDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetIsDefault_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00046534 File Offset: 0x00044734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373223, XrefRangeEnd = 373229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMemberType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetMemberType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00046568 File Offset: 0x00044768
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373268, RefRangeEnd = 373271, XrefRangeStart = 373229, XrefRangeEnd = 373268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdCachingReader GetCachingReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetCachingReader_Private_XsdCachingReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XsdCachingReader>(intPtr3) : null;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x000465A8 File Offset: 0x000447A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373271, XrefRangeEnd = 373277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_CreateDummyTextNode_Internal_ValidatingReaderNodeData_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr3) : null;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00046608 File Offset: 0x00044808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373277, XrefRangeEnd = 373279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CachingCallBack(XsdCachingReader cachingReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachingReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_CachingCallBack_Internal_Void_XsdCachingReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0004664C File Offset: 0x0004484C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373282, RefRangeEnd = 373285, XrefRangeStart = 373279, XrefRangeEnd = 373282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOriginalAtomicValueStringOfElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidatingReader.NativeMethodInfoPtr_GetOriginalAtomicValueStringOfElement_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x000058F1 File Offset: 0x00003AF1
		public XsdValidatingReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00046684 File Offset: 0x00044884
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x000058FA File Offset: 0x00003AFA
		public unsafe XmlReader coreReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x000466B4 File Offset: 0x000448B4
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00005919 File Offset: 0x00003B19
		public unsafe IXmlNamespaceResolver coreReaderNSResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderNSResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderNSResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x000466E4 File Offset: 0x000448E4
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00005938 File Offset: 0x00003B38
		public unsafe IXmlNamespaceResolver thisNSResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_thisNSResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_thisNSResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00046714 File Offset: 0x00044914
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00005957 File Offset: 0x00003B57
		public unsafe XmlSchemaValidator validator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00046744 File Offset: 0x00044944
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00005976 File Offset: 0x00003B76
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00046774 File Offset: 0x00044974
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00005995 File Offset: 0x00003B95
		public unsafe ValidationEventHandler validationEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validationEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validationEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x000467A4 File Offset: 0x000449A4
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x000059B4 File Offset: 0x00003BB4
		public unsafe XsdValidatingReader.ValidatingReaderState validationState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validationState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_validationState)) = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000467CC File Offset: 0x000449CC
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x000059CF File Offset: 0x00003BCF
		public unsafe XmlValueGetter valueGetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_valueGetter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueGetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_valueGetter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000467FC File Offset: 0x000449FC
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x000059EE File Offset: 0x00003BEE
		public unsafe XmlNamespaceManager nsManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_nsManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_nsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x0004682C File Offset: 0x00044A2C
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00005A0D File Offset: 0x00003C0D
		public unsafe bool manageNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_manageNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_manageNamespaces)) = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00046854 File Offset: 0x00044A54
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x00005A28 File Offset: 0x00003C28
		public unsafe bool processInlineSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_processInlineSchema);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_processInlineSchema)) = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0004687C File Offset: 0x00044A7C
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00005A43 File Offset: 0x00003C43
		public unsafe bool replayCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_replayCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_replayCache)) = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000468A4 File Offset: 0x00044AA4
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00005A5E File Offset: 0x00003C5E
		public unsafe ValidatingReaderNodeData cachedNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_cachedNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_cachedNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x000468D4 File Offset: 0x00044AD4
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x00005A7D File Offset: 0x00003C7D
		public unsafe AttributePSVIInfo attributePSVI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributePSVI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributePSVI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00046904 File Offset: 0x00044B04
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x00005A9C File Offset: 0x00003C9C
		public unsafe int attributeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributeCount)) = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0004692C File Offset: 0x00044B2C
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x00005AB7 File Offset: 0x00003CB7
		public unsafe int coreReaderAttributeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderAttributeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderAttributeCount)) = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00046954 File Offset: 0x00044B54
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00005AD2 File Offset: 0x00003CD2
		public unsafe int currentAttrIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_currentAttrIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_currentAttrIndex)) = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0004697C File Offset: 0x00044B7C
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00005AED File Offset: 0x00003CED
		public unsafe Il2CppReferenceArray<AttributePSVIInfo> attributePSVINodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributePSVINodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AttributePSVIInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_attributePSVINodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x000469AC File Offset: 0x00044BAC
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x00005B0C File Offset: 0x00003D0C
		public unsafe ArrayList defaultAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_defaultAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_defaultAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x000469DC File Offset: 0x00044BDC
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00005B2B File Offset: 0x00003D2B
		public unsafe Parser inlineSchemaParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_inlineSchemaParser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_inlineSchemaParser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00046A0C File Offset: 0x00044C0C
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x00005B4A File Offset: 0x00003D4A
		public unsafe Object atomicValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_atomicValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_atomicValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00046A3C File Offset: 0x00044C3C
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00005B69 File Offset: 0x00003D69
		public unsafe XmlSchemaInfo xmlSchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlSchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlSchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00046A6C File Offset: 0x00044C6C
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00005B88 File Offset: 0x00003D88
		public unsafe string originalAtomicValueString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_originalAtomicValueString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_originalAtomicValueString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00046A94 File Offset: 0x00044C94
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00005BA7 File Offset: 0x00003DA7
		public unsafe XmlNameTable coreReaderNameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderNameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_coreReaderNameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00046AC4 File Offset: 0x00044CC4
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00005BC6 File Offset: 0x00003DC6
		public unsafe XsdCachingReader cachingReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_cachingReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdCachingReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_cachingReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00046AF4 File Offset: 0x00044CF4
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00005BE5 File Offset: 0x00003DE5
		public unsafe ValidatingReaderNodeData textNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_textNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_textNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00046B24 File Offset: 0x00044D24
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00005C04 File Offset: 0x00003E04
		public unsafe string NsXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00046B4C File Offset: 0x00044D4C
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00005C23 File Offset: 0x00003E23
		public unsafe string NsXs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x00046B74 File Offset: 0x00044D74
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00005C42 File Offset: 0x00003E42
		public unsafe string NsXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXsi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_NsXsi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00046B9C File Offset: 0x00044D9C
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00005C61 File Offset: 0x00003E61
		public unsafe string XsiType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00046BC4 File Offset: 0x00044DC4
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00005C80 File Offset: 0x00003E80
		public unsafe string XsiNil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiNil);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiNil), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00046BEC File Offset: 0x00044DEC
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00005C9F File Offset: 0x00003E9F
		public unsafe string XsdSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsdSchema);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsdSchema), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00046C14 File Offset: 0x00044E14
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00005CBE File Offset: 0x00003EBE
		public unsafe string XsiSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00046C3C File Offset: 0x00044E3C
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x00005CDD File Offset: 0x00003EDD
		public unsafe string XsiNoNamespaceSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00046C64 File Offset: 0x00044E64
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x00005CFC File Offset: 0x00003EFC
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00046C94 File Offset: 0x00044E94
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x00005D2A File Offset: 0x00003F2A
		public unsafe IXmlLineInfo lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_lineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_lineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00046CC4 File Offset: 0x00044EC4
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00005D49 File Offset: 0x00003F49
		public unsafe ReadContentAsBinaryHelper readBinaryHelper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_readBinaryHelper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadContentAsBinaryHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_readBinaryHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00046CF4 File Offset: 0x00044EF4
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00005D68 File Offset: 0x00003F68
		public unsafe XsdValidatingReader.ValidatingReaderState savedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_savedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidatingReader.NativeFieldInfoPtr_savedState)) = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00046D1C File Offset: 0x00044F1C
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00005D83 File Offset: 0x00003F83
		public unsafe static Type TypeOfString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdValidatingReader.NativeFieldInfoPtr_TypeOfString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdValidatingReader.NativeFieldInfoPtr_TypeOfString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_coreReader;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_coreReaderNSResolver;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_thisNSResolver;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_validator;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr_validationEvent;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_validationState;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr_valueGetter;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr_nsManager;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_manageNamespaces;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_processInlineSchema;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_replayCache;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_cachedNode;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_attributePSVI;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_attributeCount;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr_coreReaderAttributeCount;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_currentAttrIndex;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr_attributePSVINodes;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr_defaultAttributes;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeFieldInfoPtr_inlineSchemaParser;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeFieldInfoPtr_atomicValue;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr_xmlSchemaInfo;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr_originalAtomicValueString;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeFieldInfoPtr_coreReaderNameTable;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeFieldInfoPtr_cachingReader;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeFieldInfoPtr_textNode;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_NsXmlNs;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeFieldInfoPtr_NsXs;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_NsXsi;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr_XsiType;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeFieldInfoPtr_XsiNil;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeFieldInfoPtr_XsdSchema;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeFieldInfoPtr_XsiSchemaLocation;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeFieldInfoPtr_readBinaryHelper;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeFieldInfoPtr_savedState;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeFieldInfoPtr_TypeOfString;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_XmlSchemaObject_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlResolver_XmlReaderSettings_0;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeMethodInfoPtr_SetupValidator_Private_Void_XmlReaderSettings_XmlReader_XmlSchemaObject_0;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_get_IXmlSchemaInfo_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_Skip_Public_Virtual_Void_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_GetStringValue_Private_Object_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeSchemaInfo_Private_get_XmlSchemaInfo_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_ProcessReaderEvent_Private_Void_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElementEvent_Private_Void_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEndElementEvent_Private_Void_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAttributes_Private_Void_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_ClearAttributesInfo_Private_Void_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributePSVI_Private_AttributePSVIInfo_String_String_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_Boolean_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultAttribute_Private_ValidatingReaderNodeData_String_String_Boolean_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributePSVI_Private_AttributePSVIInfo_Int32_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_IsXSDRoot_Private_Boolean_String_String_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_ReadAheadForMemberType_Private_Void_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_GetIsDefault_Private_Void_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberType_Private_Void_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_GetCachingReader_Private_XsdCachingReader_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_CreateDummyTextNode_Internal_ValidatingReaderNodeData_String_Int32_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_CachingCallBack_Internal_Void_XsdCachingReader_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalAtomicValueStringOfElement_Private_String_0;

		// Token: 0x0200023B RID: 571
		public enum ValidatingReaderState
		{
			// Token: 0x04002548 RID: 9544
			None,
			// Token: 0x04002549 RID: 9545
			Init,
			// Token: 0x0400254A RID: 9546
			Read,
			// Token: 0x0400254B RID: 9547
			OnDefaultAttribute = -1,
			// Token: 0x0400254C RID: 9548
			OnReadAttributeValue = -2,
			// Token: 0x0400254D RID: 9549
			OnAttribute = 3,
			// Token: 0x0400254E RID: 9550
			ClearAttributes,
			// Token: 0x0400254F RID: 9551
			ParseInlineSchema,
			// Token: 0x04002550 RID: 9552
			ReadAhead,
			// Token: 0x04002551 RID: 9553
			OnReadBinaryContent,
			// Token: 0x04002552 RID: 9554
			ReaderClosed,
			// Token: 0x04002553 RID: 9555
			EOF,
			// Token: 0x04002554 RID: 9556
			Error
		}
	}
}
