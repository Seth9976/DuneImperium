using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000066 RID: 102
	public class XmlDocument : XmlNode
	{
		// Token: 0x06000C06 RID: 3078 RVA: 0x0004A028 File Offset: 0x00048228
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDocument()
		{
			Il2CppClassPointerStore<XmlDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr);
			XmlDocument.NativeFieldInfoPtr_implementation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "implementation");
			XmlDocument.NativeFieldInfoPtr_domNameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "domNameTable");
			XmlDocument.NativeFieldInfoPtr_lastChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "lastChild");
			XmlDocument.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "entities");
			XmlDocument.NativeFieldInfoPtr_htElementIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "htElementIdMap");
			XmlDocument.NativeFieldInfoPtr_htElementIDAttrDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "htElementIDAttrDecl");
			XmlDocument.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "schemaInfo");
			XmlDocument.NativeFieldInfoPtr_schemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "schemas");
			XmlDocument.NativeFieldInfoPtr_reportValidity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "reportValidity");
			XmlDocument.NativeFieldInfoPtr_actualLoadingStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "actualLoadingStatus");
			XmlDocument.NativeFieldInfoPtr_onNodeInsertingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeInsertingDelegate");
			XmlDocument.NativeFieldInfoPtr_onNodeInsertedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeInsertedDelegate");
			XmlDocument.NativeFieldInfoPtr_onNodeRemovingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeRemovingDelegate");
			XmlDocument.NativeFieldInfoPtr_onNodeRemovedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeRemovedDelegate");
			XmlDocument.NativeFieldInfoPtr_onNodeChangingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeChangingDelegate");
			XmlDocument.NativeFieldInfoPtr_onNodeChangedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeChangedDelegate");
			XmlDocument.NativeFieldInfoPtr_fEntRefNodesPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "fEntRefNodesPresent");
			XmlDocument.NativeFieldInfoPtr_fCDataNodesPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "fCDataNodesPresent");
			XmlDocument.NativeFieldInfoPtr_preserveWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "preserveWhitespace");
			XmlDocument.NativeFieldInfoPtr_isLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "isLoading");
			XmlDocument.NativeFieldInfoPtr_strDocumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strDocumentName");
			XmlDocument.NativeFieldInfoPtr_strDocumentFragmentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strDocumentFragmentName");
			XmlDocument.NativeFieldInfoPtr_strCommentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strCommentName");
			XmlDocument.NativeFieldInfoPtr_strTextName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strTextName");
			XmlDocument.NativeFieldInfoPtr_strCDataSectionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strCDataSectionName");
			XmlDocument.NativeFieldInfoPtr_strEntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strEntityName");
			XmlDocument.NativeFieldInfoPtr_strID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strID");
			XmlDocument.NativeFieldInfoPtr_strXmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strXmlns");
			XmlDocument.NativeFieldInfoPtr_strXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strXml");
			XmlDocument.NativeFieldInfoPtr_strSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strSpace");
			XmlDocument.NativeFieldInfoPtr_strLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strLang");
			XmlDocument.NativeFieldInfoPtr_strEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strEmpty");
			XmlDocument.NativeFieldInfoPtr_strNonSignificantWhitespaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strNonSignificantWhitespaceName");
			XmlDocument.NativeFieldInfoPtr_strSignificantWhitespaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strSignificantWhitespaceName");
			XmlDocument.NativeFieldInfoPtr_strReservedXmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strReservedXmlns");
			XmlDocument.NativeFieldInfoPtr_strReservedXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strReservedXml");
			XmlDocument.NativeFieldInfoPtr_baseURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "baseURI");
			XmlDocument.NativeFieldInfoPtr_resolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "resolver");
			XmlDocument.NativeFieldInfoPtr_bSetResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "bSetResolver");
			XmlDocument.NativeFieldInfoPtr_objLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "objLock");
			XmlDocument.NativeFieldInfoPtr_EmptyEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "EmptyEnumerator");
			XmlDocument.NativeFieldInfoPtr_NotKnownSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "NotKnownSchemaInfo");
			XmlDocument.NativeFieldInfoPtr_ValidSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "ValidSchemaInfo");
			XmlDocument.NativeFieldInfoPtr_InvalidSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "InvalidSchemaInfo");
			XmlDocument.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665276);
			XmlDocument.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665277);
			XmlDocument.NativeMethodInfoPtr__ctor_FamOrAssem_Void_XmlImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665278);
			XmlDocument.NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665279);
			XmlDocument.NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665280);
			XmlDocument.NativeMethodInfoPtr_CheckName_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665281);
			XmlDocument.NativeMethodInfoPtr_AddXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665282);
			XmlDocument.NativeMethodInfoPtr_GetXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665283);
			XmlDocument.NativeMethodInfoPtr_AddAttrXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665284);
			XmlDocument.NativeMethodInfoPtr_AddIdInfo_Internal_Boolean_XmlName_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665285);
			XmlDocument.NativeMethodInfoPtr_GetIDInfoByElement__Private_XmlName_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665286);
			XmlDocument.NativeMethodInfoPtr_GetIDInfoByElement_Internal_XmlName_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665287);
			XmlDocument.NativeMethodInfoPtr_GetElement_Private_WeakReference_ArrayList_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665288);
			XmlDocument.NativeMethodInfoPtr_AddElementWithId_Internal_Void_String_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665289);
			XmlDocument.NativeMethodInfoPtr_RemoveElementWithId_Internal_Void_String_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665290);
			XmlDocument.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665291);
			XmlDocument.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665292);
			XmlDocument.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665293);
			XmlDocument.NativeMethodInfoPtr_get_DocumentType_Public_Virtual_New_get_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665294);
			XmlDocument.NativeMethodInfoPtr_get_Declaration_Internal_Virtual_New_get_XmlDeclaration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665295);
			XmlDocument.NativeMethodInfoPtr_get_Implementation_Public_get_XmlImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665296);
			XmlDocument.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665297);
			XmlDocument.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665298);
			XmlDocument.NativeMethodInfoPtr_get_DocumentElement_Public_get_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665299);
			XmlDocument.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665300);
			XmlDocument.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665301);
			XmlDocument.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665302);
			XmlDocument.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665303);
			XmlDocument.NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665304);
			XmlDocument.NativeMethodInfoPtr_get_CanReportValidity_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665305);
			XmlDocument.NativeMethodInfoPtr_get_HasSetResolver_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665306);
			XmlDocument.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665307);
			XmlDocument.NativeMethodInfoPtr_set_XmlResolver_Public_Virtual_New_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665308);
			XmlDocument.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665309);
			XmlDocument.NativeMethodInfoPtr_HasNodeTypeInPrevSiblings_Private_Boolean_XmlNodeType_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665310);
			XmlDocument.NativeMethodInfoPtr_HasNodeTypeInNextSiblings_Private_Boolean_XmlNodeType_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665311);
			XmlDocument.NativeMethodInfoPtr_CanInsertBefore_Internal_Virtual_Boolean_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665312);
			XmlDocument.NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_Boolean_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665313);
			XmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_XmlAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665314);
			XmlDocument.NativeMethodInfoPtr_SetDefaultNamespace_Internal_Void_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665315);
			XmlDocument.NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_New_XmlCDataSection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665316);
			XmlDocument.NativeMethodInfoPtr_CreateComment_Public_Virtual_New_XmlComment_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665317);
			XmlDocument.NativeMethodInfoPtr_CreateDocumentType_Public_Virtual_New_XmlDocumentType_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665318);
			XmlDocument.NativeMethodInfoPtr_CreateDocumentFragment_Public_Virtual_New_XmlDocumentFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665319);
			XmlDocument.NativeMethodInfoPtr_CreateElement_Public_XmlElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665320);
			XmlDocument.NativeMethodInfoPtr_AddDefaultAttributes_Internal_Void_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665321);
			XmlDocument.NativeMethodInfoPtr_GetSchemaElementDecl_Private_SchemaElementDecl_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665322);
			XmlDocument.NativeMethodInfoPtr_PrepareDefaultAttribute_Private_XmlAttribute_SchemaAttDef_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665323);
			XmlDocument.NativeMethodInfoPtr_CreateEntityReference_Public_Virtual_New_XmlEntityReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665324);
			XmlDocument.NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_New_XmlProcessingInstruction_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665325);
			XmlDocument.NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_New_XmlDeclaration_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665326);
			XmlDocument.NativeMethodInfoPtr_CreateTextNode_Public_Virtual_New_XmlText_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665327);
			XmlDocument.NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_New_XmlSignificantWhitespace_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665328);
			XmlDocument.NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_New_XmlWhitespace_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665329);
			XmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_XmlAttribute_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665330);
			XmlDocument.NativeMethodInfoPtr_CreateElement_Public_XmlElement_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665331);
			XmlDocument.NativeMethodInfoPtr_ImportNodeInternal_Private_XmlNode_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665332);
			XmlDocument.NativeMethodInfoPtr_ImportAttributes_Private_Void_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665333);
			XmlDocument.NativeMethodInfoPtr_ImportChildren_Private_Void_XmlNode_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665334);
			XmlDocument.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665335);
			XmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_New_XmlAttribute_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665336);
			XmlDocument.NativeMethodInfoPtr_CreateDefaultAttribute_FamOrAssem_Virtual_New_XmlAttribute_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665337);
			XmlDocument.NativeMethodInfoPtr_CreateElement_Public_Virtual_New_XmlElement_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665338);
			XmlDocument.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665339);
			XmlDocument.NativeMethodInfoPtr_get_Entities_Internal_get_XmlNamedNodeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665340);
			XmlDocument.NativeMethodInfoPtr_set_Entities_Internal_set_Void_XmlNamedNodeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665341);
			XmlDocument.NativeMethodInfoPtr_get_IsLoading_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665342);
			XmlDocument.NativeMethodInfoPtr_set_IsLoading_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665343);
			XmlDocument.NativeMethodInfoPtr_get_ActualLoadingStatus_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665344);
			XmlDocument.NativeMethodInfoPtr_ReadNode_Public_Virtual_New_XmlNode_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665345);
			XmlDocument.NativeMethodInfoPtr_SetupReader_Private_XmlTextReader_XmlTextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665346);
			XmlDocument.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665347);
			XmlDocument.NativeMethodInfoPtr_LoadXml_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665348);
			XmlDocument.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665349);
			XmlDocument.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665350);
			XmlDocument.NativeMethodInfoPtr_Save_Public_Virtual_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665351);
			XmlDocument.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665352);
			XmlDocument.NativeMethodInfoPtr_WriteContentTo_Public_Virtual_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665353);
			XmlDocument.NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665354);
			XmlDocument.NativeMethodInfoPtr_GetInsertEventArgsForLoad_Internal_XmlNodeChangedEventArgs_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665355);
			XmlDocument.NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665356);
			XmlDocument.NativeMethodInfoPtr_AfterEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665357);
			XmlDocument.NativeMethodInfoPtr_GetDefaultAttribute_Internal_XmlAttribute_XmlElement_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665358);
			XmlDocument.NativeMethodInfoPtr_get_Version_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665359);
			XmlDocument.NativeMethodInfoPtr_get_Encoding_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665360);
			XmlDocument.NativeMethodInfoPtr_get_Standalone_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665361);
			XmlDocument.NativeMethodInfoPtr_GetEntityNode_Internal_XmlEntity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665362);
			XmlDocument.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_get_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665363);
			XmlDocument.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665364);
			XmlDocument.NativeMethodInfoPtr_SetBaseURI_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665365);
			XmlDocument.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100665366);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0004AAE4 File Offset: 0x00048CE4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 373814, RefRangeEnd = 373830, XrefRangeStart = 373804, XrefRangeEnd = 373814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocument()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0004AB20 File Offset: 0x00048D20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373836, RefRangeEnd = 373838, XrefRangeStart = 373830, XrefRangeEnd = 373836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocument(XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0004AB6C File Offset: 0x00048D6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373908, RefRangeEnd = 373911, XrefRangeStart = 373838, XrefRangeEnd = 373908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocument(XmlImplementation imp)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(imp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr__ctor_FamOrAssem_Void_XmlImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0004ABB8 File Offset: 0x00048DB8
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x0004ABF8 File Offset: 0x00048DF8
		public unsafe SchemaInfo DtdSchemaInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0004AC3C File Offset: 0x00048E3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 373915, RefRangeEnd = 373919, XrefRangeStart = 373911, XrefRangeEnd = 373915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_CheckName_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0004AC74 File Offset: 0x00048E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373919, XrefRangeEnd = 373921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_AddXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0004ACFC File Offset: 0x00048EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373921, XrefRangeEnd = 373927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0004AD84 File Offset: 0x00048F84
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 373929, RefRangeEnd = 373936, XrefRangeStart = 373927, XrefRangeEnd = 373929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_AddAttrXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0004AE0C File Offset: 0x0004900C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373937, RefRangeEnd = 373938, XrefRangeStart = 373936, XrefRangeEnd = 373937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddIdInfo(XmlName eleName, XmlName attrName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_AddIdInfo_Internal_Boolean_XmlName_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0004AE6C File Offset: 0x0004906C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 373947, RefRangeEnd = 373952, XrefRangeStart = 373938, XrefRangeEnd = 373947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName GetIDInfoByElement_(XmlName eleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetIDInfoByElement__Private_XmlName_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0004AEBC File Offset: 0x000490BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373952, XrefRangeEnd = 373953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName GetIDInfoByElement(XmlName eleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetIDInfoByElement_Internal_XmlName_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0004AF0C File Offset: 0x0004910C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373969, RefRangeEnd = 373971, XrefRangeStart = 373953, XrefRangeEnd = 373969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference GetElement(ArrayList elementList, XmlElement elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetElement_Private_WeakReference_ArrayList_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr3) : null;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0004AF70 File Offset: 0x00049170
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373979, RefRangeEnd = 373982, XrefRangeStart = 373971, XrefRangeEnd = 373979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddElementWithId(string id, XmlElement elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_AddElementWithId_Internal_Void_String_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0004AFC4 File Offset: 0x000491C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373985, RefRangeEnd = 373988, XrefRangeStart = 373982, XrefRangeEnd = 373985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveElementWithId(string id, XmlElement elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_RemoveElementWithId_Internal_Void_String_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0004B018 File Offset: 0x00049218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373988, XrefRangeEnd = 373990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x0004B070 File Offset: 0x00049270
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0004B0B8 File Offset: 0x000492B8
		public unsafe override XmlNode ParentNode
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0004B104 File Offset: 0x00049304
		public unsafe virtual XmlDocumentType DocumentType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373990, XrefRangeEnd = 373992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_DocumentType_Public_Virtual_New_get_XmlDocumentType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocumentType>(intPtr3) : null;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0004B150 File Offset: 0x00049350
		public unsafe virtual XmlDeclaration Declaration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373992, XrefRangeEnd = 373993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_Declaration_Internal_Virtual_New_get_XmlDeclaration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDeclaration>(intPtr3) : null;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0004B19C File Offset: 0x0004939C
		public unsafe XmlImplementation Implementation
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_Implementation_Public_get_XmlImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0004B1DC File Offset: 0x000493DC
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0004B220 File Offset: 0x00049420
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0004B264 File Offset: 0x00049464
		public unsafe XmlElement DocumentElement
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 373995, RefRangeEnd = 374009, XrefRangeStart = 373993, XrefRangeEnd = 373995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_DocumentElement_Public_get_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0004B2A4 File Offset: 0x000494A4
		public unsafe override bool IsContainer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0004B2EC File Offset: 0x000494EC
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0004B338 File Offset: 0x00049538
		public unsafe override XmlLinkedNode LastNode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0004B388 File Offset: 0x00049588
		public unsafe override XmlDocument OwnerDocument
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x0004B3D4 File Offset: 0x000495D4
		public unsafe XmlSchemaSet Schemas
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0004B418 File Offset: 0x00049618
		public unsafe bool CanReportValidity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_CanReportValidity_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0004B454 File Offset: 0x00049654
		public unsafe bool HasSetResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_HasSetResolver_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0004B490 File Offset: 0x00049690
		[CallerCount(0)]
		public unsafe XmlResolver GetResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x1700041D RID: 1053
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0004B4D0 File Offset: 0x000496D0
		public unsafe virtual XmlResolver XmlResolver
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374009, XrefRangeEnd = 374018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_set_XmlResolver_Public_Virtual_New_set_Void_XmlResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0004B520 File Offset: 0x00049720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374018, XrefRangeEnd = 374020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValidChildType(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0004B574 File Offset: 0x00049774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374020, RefRangeEnd = 374021, XrefRangeStart = 374020, XrefRangeEnd = 374020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_HasNodeTypeInPrevSiblings_Private_Boolean_XmlNodeType_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0004B5D0 File Offset: 0x000497D0
		[CallerCount(0)]
		public unsafe bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_HasNodeTypeInNextSiblings_Private_Boolean_XmlNodeType_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0004B62C File Offset: 0x0004982C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374021, XrefRangeEnd = 374022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CanInsertBefore_Internal_Virtual_Boolean_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0004B698 File Offset: 0x00049898
		[CallerCount(0)]
		public unsafe override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_Boolean_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0004B704 File Offset: 0x00049904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374030, RefRangeEnd = 374031, XrefRangeStart = 374022, XrefRangeEnd = 374030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute CreateAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_XmlAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0004B754 File Offset: 0x00049954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374031, XrefRangeEnd = 374036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_SetDefaultNamespace_Internal_Void_String_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			namespaceURI = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0004B7C8 File Offset: 0x000499C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374036, XrefRangeEnd = 374042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlCDataSection CreateCDataSection(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_New_XmlCDataSection_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlCDataSection>(intPtr3) : null;
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0004B824 File Offset: 0x00049A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374042, XrefRangeEnd = 374048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlComment CreateComment(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateComment_Public_Virtual_New_XmlComment_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlComment>(intPtr3) : null;
			}
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0004B880 File Offset: 0x00049A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374048, XrefRangeEnd = 374063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateDocumentType_Public_Virtual_New_XmlDocumentType_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocumentType>(intPtr3) : null;
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0004B914 File Offset: 0x00049B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374063, XrefRangeEnd = 374068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlDocumentFragment CreateDocumentFragment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateDocumentFragment_Public_Virtual_New_XmlDocumentFragment_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocumentFragment>(intPtr3) : null;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0004B960 File Offset: 0x00049B60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 374072, RefRangeEnd = 374075, XrefRangeStart = 374068, XrefRangeEnd = 374072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElement CreateElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_CreateElement_Public_XmlElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0004B9B0 File Offset: 0x00049BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374098, RefRangeEnd = 374099, XrefRangeStart = 374075, XrefRangeEnd = 374098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultAttributes(XmlElement elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_AddDefaultAttributes_Internal_Void_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0004B9F4 File Offset: 0x00049BF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374107, RefRangeEnd = 374109, XrefRangeStart = 374099, XrefRangeEnd = 374107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl GetSchemaElementDecl(XmlElement elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetSchemaElementDecl_Private_SchemaElementDecl_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0004BA44 File Offset: 0x00049C44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374117, RefRangeEnd = 374119, XrefRangeStart = 374109, XrefRangeEnd = 374117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrPrefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrLocalname);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrNamespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_PrepareDefaultAttribute_Private_XmlAttribute_SchemaAttDef_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0004BACC File Offset: 0x00049CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374119, XrefRangeEnd = 374123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlEntityReference CreateEntityReference(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateEntityReference_Public_Virtual_New_XmlEntityReference_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlEntityReference>(intPtr3) : null;
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0004BB28 File Offset: 0x00049D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374123, XrefRangeEnd = 374127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_New_XmlProcessingInstruction_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlProcessingInstruction>(intPtr3) : null;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0004BB98 File Offset: 0x00049D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374127, XrefRangeEnd = 374131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standalone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_New_XmlDeclaration_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDeclaration>(intPtr3) : null;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0004BC18 File Offset: 0x00049E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374131, XrefRangeEnd = 374135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlText CreateTextNode(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateTextNode_Public_Virtual_New_XmlText_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlText>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0004BC74 File Offset: 0x00049E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374135, XrefRangeEnd = 374139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_New_XmlSignificantWhitespace_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSignificantWhitespace>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0004BCD0 File Offset: 0x00049ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374139, XrefRangeEnd = 374143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlWhitespace CreateWhitespace(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_New_XmlWhitespace_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlWhitespace>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0004BD2C File Offset: 0x00049F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374146, RefRangeEnd = 374147, XrefRangeStart = 374143, XrefRangeEnd = 374146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_XmlAttribute_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0004BD90 File Offset: 0x00049F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374150, RefRangeEnd = 374151, XrefRangeStart = 374147, XrefRangeEnd = 374150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElement CreateElement(string qualifiedName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_CreateElement_Public_XmlElement_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0004BDF4 File Offset: 0x00049FF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 374174, RefRangeEnd = 374178, XrefRangeStart = 374151, XrefRangeEnd = 374174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode ImportNodeInternal(XmlNode node, bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_ImportNodeInternal_Private_XmlNode_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0004BE54 File Offset: 0x0004A054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374178, XrefRangeEnd = 374181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportAttributes(XmlNode fromElem, XmlNode toElem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromElem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toElem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_ImportAttributes_Private_Void_XmlNode_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0004BEA8 File Offset: 0x0004A0A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 374182, RefRangeEnd = 374185, XrefRangeStart = 374181, XrefRangeEnd = 374182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toNode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_ImportChildren_Private_Void_XmlNode_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0004BF0C File Offset: 0x0004A10C
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 373350, RefRangeEnd = 373371, XrefRangeStart = 373350, XrefRangeEnd = 373371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0004BF4C File Offset: 0x0004A14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374185, XrefRangeEnd = 374190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_New_XmlAttribute_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0004BFCC File Offset: 0x0004A1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374190, XrefRangeEnd = 374194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateDefaultAttribute_FamOrAssem_Virtual_New_XmlAttribute_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0004C04C File Offset: 0x0004A24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374194, XrefRangeEnd = 374200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateElement_Public_Virtual_New_XmlElement_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0004C0CC File Offset: 0x0004A2CC
		public unsafe override bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x0004C114 File Offset: 0x0004A314
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x0004C154 File Offset: 0x0004A354
		public unsafe XmlNamedNodeMap Entities
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374200, XrefRangeEnd = 374205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_Entities_Internal_get_XmlNamedNodeMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_set_Entities_Internal_set_Void_XmlNamedNodeMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0004C198 File Offset: 0x0004A398
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x0004C1D4 File Offset: 0x0004A3D4
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_IsLoading_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_set_IsLoading_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0004C214 File Offset: 0x0004A414
		public unsafe bool ActualLoadingStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_ActualLoadingStatus_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0004C250 File Offset: 0x0004A450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374205, XrefRangeEnd = 374211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode ReadNode(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_ReadNode_Public_Virtual_New_XmlNode_XmlReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0004C2AC File Offset: 0x0004A4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374211, XrefRangeEnd = 374214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReader SetupReader(XmlTextReader tr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_SetupReader_Private_XmlTextReader_XmlTextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReader>(intPtr3) : null;
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0004C2FC File Offset: 0x0004A4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374214, XrefRangeEnd = 374220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_XmlReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0004C34C File Offset: 0x0004A54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374220, XrefRangeEnd = 374232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadXml(string xml)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xml);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_LoadXml_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000423 RID: 1059
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x0004C39C File Offset: 0x0004A59C
		public unsafe override string InnerText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374232, XrefRangeEnd = 374239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000424 RID: 1060
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x0004C3EC File Offset: 0x0004A5EC
		public unsafe override string InnerXml
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0004C43C File Offset: 0x0004A63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374239, XrefRangeEnd = 374250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Save(XmlWriter w)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_Save_Public_Virtual_New_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0004C48C File Offset: 0x0004A68C
		[CallerCount(0)]
		public unsafe override void WriteTo(XmlWriter w)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0004C4DC File Offset: 0x0004A6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374250, XrefRangeEnd = 374268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteContentTo(XmlWriter xw)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xw);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_WriteContentTo_Public_Virtual_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0004C52C File Offset: 0x0004A72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374268, XrefRangeEnd = 374272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldParent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventArgs>(intPtr3) : null;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0004C5E0 File Offset: 0x0004A7E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 374273, RefRangeEnd = 374278, XrefRangeStart = 374272, XrefRangeEnd = 374273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetInsertEventArgsForLoad_Internal_XmlNodeChangedEventArgs_XmlNode_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventArgs>(intPtr3) : null;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0004C644 File Offset: 0x0004A844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374278, XrefRangeEnd = 374280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BeforeEvent(XmlNodeChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0004C694 File Offset: 0x0004A894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374280, XrefRangeEnd = 374282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterEvent(XmlNodeChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_AfterEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0004C6E4 File Offset: 0x0004A8E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374302, RefRangeEnd = 374303, XrefRangeStart = 374282, XrefRangeEnd = 374302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrPrefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrLocalname);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrNamespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetDefaultAttribute_Internal_XmlAttribute_XmlElement_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0004C76C File Offset: 0x0004A96C
		public unsafe string Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 374303, RefRangeEnd = 374304, XrefRangeStart = 374303, XrefRangeEnd = 374303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_Version_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0004C7A4 File Offset: 0x0004A9A4
		public unsafe string Encoding
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 374304, RefRangeEnd = 374305, XrefRangeStart = 374304, XrefRangeEnd = 374304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_Encoding_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0004C7DC File Offset: 0x0004A9DC
		public unsafe string Standalone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 374305, RefRangeEnd = 374306, XrefRangeStart = 374305, XrefRangeEnd = 374305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_Standalone_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0004C814 File Offset: 0x0004AA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374306, XrefRangeEnd = 374310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEntity GetEntityNode(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetEntityNode_Internal_XmlEntity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlEntity>(intPtr3) : null;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0004C864 File Offset: 0x0004AA64
		public unsafe override IXmlSchemaInfo SchemaInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374310, XrefRangeEnd = 374318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_get_IXmlSchemaInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0004C8B0 File Offset: 0x0004AAB0
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0004C8F4 File Offset: 0x0004AAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBaseURI(string inBaseURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inBaseURI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_SetBaseURI_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0004C938 File Offset: 0x0004AB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374318, XrefRangeEnd = 374325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00005FAB File Offset: 0x000041AB
		public XmlDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0004C9A8 File Offset: 0x0004ABA8
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00005FB4 File Offset: 0x000041B4
		public unsafe XmlImplementation implementation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_implementation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlImplementation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_implementation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0004C9D8 File Offset: 0x0004ABD8
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00005FD3 File Offset: 0x000041D3
		public unsafe DomNameTable domNameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_domNameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DomNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_domNameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0004CA08 File Offset: 0x0004AC08
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x00005FF2 File Offset: 0x000041F2
		public unsafe XmlLinkedNode lastChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_lastChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_lastChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0004CA38 File Offset: 0x0004AC38
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x00006011 File Offset: 0x00004211
		public unsafe XmlNamedNodeMap entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0004CA68 File Offset: 0x0004AC68
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x00006030 File Offset: 0x00004230
		public unsafe Hashtable htElementIdMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_htElementIdMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_htElementIdMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0004CA98 File Offset: 0x0004AC98
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x0000604F File Offset: 0x0000424F
		public unsafe Hashtable htElementIDAttrDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_htElementIDAttrDecl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_htElementIDAttrDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0004CAC8 File Offset: 0x0004ACC8
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x0000606E File Offset: 0x0000426E
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0004CAF8 File Offset: 0x0004ACF8
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x0000608D File Offset: 0x0000428D
		public unsafe XmlSchemaSet schemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_schemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_schemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x0004CB28 File Offset: 0x0004AD28
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x000060AC File Offset: 0x000042AC
		public unsafe bool reportValidity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_reportValidity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_reportValidity)) = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0004CB50 File Offset: 0x0004AD50
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x000060C7 File Offset: 0x000042C7
		public unsafe bool actualLoadingStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_actualLoadingStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_actualLoadingStatus)) = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0004CB78 File Offset: 0x0004AD78
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x000060E2 File Offset: 0x000042E2
		public unsafe XmlNodeChangedEventHandler onNodeInsertingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeInsertingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeInsertingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0004CBA8 File Offset: 0x0004ADA8
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00006101 File Offset: 0x00004301
		public unsafe XmlNodeChangedEventHandler onNodeInsertedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeInsertedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeInsertedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0004CBD8 File Offset: 0x0004ADD8
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x00006120 File Offset: 0x00004320
		public unsafe XmlNodeChangedEventHandler onNodeRemovingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeRemovingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeRemovingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0004CC08 File Offset: 0x0004AE08
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x0000613F File Offset: 0x0000433F
		public unsafe XmlNodeChangedEventHandler onNodeRemovedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeRemovedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeRemovedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0004CC38 File Offset: 0x0004AE38
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x0000615E File Offset: 0x0000435E
		public unsafe XmlNodeChangedEventHandler onNodeChangingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeChangingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeChangingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0004CC68 File Offset: 0x0004AE68
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x0000617D File Offset: 0x0000437D
		public unsafe XmlNodeChangedEventHandler onNodeChangedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeChangedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeChangedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0004CC98 File Offset: 0x0004AE98
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x0000619C File Offset: 0x0000439C
		public unsafe bool fEntRefNodesPresent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_fEntRefNodesPresent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_fEntRefNodesPresent)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x0004CCC0 File Offset: 0x0004AEC0
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x000061B7 File Offset: 0x000043B7
		public unsafe bool fCDataNodesPresent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_fCDataNodesPresent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_fCDataNodesPresent)) = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0004CCE8 File Offset: 0x0004AEE8
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x000061D2 File Offset: 0x000043D2
		public unsafe bool preserveWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_preserveWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_preserveWhitespace)) = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x0004CD10 File Offset: 0x0004AF10
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x000061ED File Offset: 0x000043ED
		public unsafe bool isLoading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_isLoading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_isLoading)) = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0004CD38 File Offset: 0x0004AF38
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00006208 File Offset: 0x00004408
		public unsafe string strDocumentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strDocumentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strDocumentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0004CD60 File Offset: 0x0004AF60
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00006227 File Offset: 0x00004427
		public unsafe string strDocumentFragmentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strDocumentFragmentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strDocumentFragmentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0004CD88 File Offset: 0x0004AF88
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x00006246 File Offset: 0x00004446
		public unsafe string strCommentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strCommentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strCommentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0004CDB0 File Offset: 0x0004AFB0
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00006265 File Offset: 0x00004465
		public unsafe string strTextName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strTextName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strTextName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0004CDD8 File Offset: 0x0004AFD8
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00006284 File Offset: 0x00004484
		public unsafe string strCDataSectionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strCDataSectionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strCDataSectionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x0004CE00 File Offset: 0x0004B000
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x000062A3 File Offset: 0x000044A3
		public unsafe string strEntityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strEntityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strEntityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0004CE28 File Offset: 0x0004B028
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x000062C2 File Offset: 0x000044C2
		public unsafe string strID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0004CE50 File Offset: 0x0004B050
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x000062E1 File Offset: 0x000044E1
		public unsafe string strXmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strXmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strXmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x0004CE78 File Offset: 0x0004B078
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00006300 File Offset: 0x00004500
		public unsafe string strXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strXml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strXml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0004CEA0 File Offset: 0x0004B0A0
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x0000631F File Offset: 0x0000451F
		public unsafe string strSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strSpace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strSpace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0004CEC8 File Offset: 0x0004B0C8
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x0000633E File Offset: 0x0000453E
		public unsafe string strLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strLang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strLang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0004CEF0 File Offset: 0x0004B0F0
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x0000635D File Offset: 0x0000455D
		public unsafe string strEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strEmpty);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strEmpty), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0004CF18 File Offset: 0x0004B118
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x0000637C File Offset: 0x0000457C
		public unsafe string strNonSignificantWhitespaceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strNonSignificantWhitespaceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strNonSignificantWhitespaceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0004CF40 File Offset: 0x0004B140
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x0000639B File Offset: 0x0000459B
		public unsafe string strSignificantWhitespaceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strSignificantWhitespaceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strSignificantWhitespaceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0004CF68 File Offset: 0x0004B168
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x000063BA File Offset: 0x000045BA
		public unsafe string strReservedXmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strReservedXmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strReservedXmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0004CF90 File Offset: 0x0004B190
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x000063D9 File Offset: 0x000045D9
		public unsafe string strReservedXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strReservedXml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strReservedXml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0004CFB8 File Offset: 0x0004B1B8
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x000063F8 File Offset: 0x000045F8
		public unsafe string baseURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_baseURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_baseURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0004CFE0 File Offset: 0x0004B1E0
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00006417 File Offset: 0x00004617
		public unsafe XmlResolver resolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_resolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_resolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0004D010 File Offset: 0x0004B210
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00006436 File Offset: 0x00004636
		public unsafe bool bSetResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_bSetResolver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_bSetResolver)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0004D038 File Offset: 0x0004B238
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00006451 File Offset: 0x00004651
		public unsafe Object objLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_objLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_objLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0004D068 File Offset: 0x0004B268
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00006470 File Offset: 0x00004670
		public unsafe static EmptyEnumerator EmptyEnumerator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlDocument.NativeFieldInfoPtr_EmptyEnumerator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmptyEnumerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlDocument.NativeFieldInfoPtr_EmptyEnumerator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0004D090 File Offset: 0x0004B290
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00006482 File Offset: 0x00004682
		public unsafe static IXmlSchemaInfo NotKnownSchemaInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlDocument.NativeFieldInfoPtr_NotKnownSchemaInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlDocument.NativeFieldInfoPtr_NotKnownSchemaInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0004D0B8 File Offset: 0x0004B2B8
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00006494 File Offset: 0x00004694
		public unsafe static IXmlSchemaInfo ValidSchemaInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlDocument.NativeFieldInfoPtr_ValidSchemaInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlDocument.NativeFieldInfoPtr_ValidSchemaInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0004D0E0 File Offset: 0x0004B2E0
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x000064A6 File Offset: 0x000046A6
		public unsafe static IXmlSchemaInfo InvalidSchemaInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlDocument.NativeFieldInfoPtr_InvalidSchemaInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlDocument.NativeFieldInfoPtr_InvalidSchemaInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeFieldInfoPtr_implementation;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeFieldInfoPtr_domNameTable;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeFieldInfoPtr_lastChild;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeFieldInfoPtr_htElementIdMap;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeFieldInfoPtr_htElementIDAttrDecl;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_schemas;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr_reportValidity;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr_actualLoadingStatus;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr_onNodeInsertingDelegate;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr_onNodeInsertedDelegate;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeFieldInfoPtr_onNodeRemovingDelegate;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeFieldInfoPtr_onNodeRemovedDelegate;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeFieldInfoPtr_onNodeChangingDelegate;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_onNodeChangedDelegate;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeFieldInfoPtr_fEntRefNodesPresent;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeFieldInfoPtr_fCDataNodesPresent;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeFieldInfoPtr_preserveWhitespace;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeFieldInfoPtr_isLoading;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeFieldInfoPtr_strDocumentName;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeFieldInfoPtr_strDocumentFragmentName;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr_strCommentName;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeFieldInfoPtr_strTextName;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr_strCDataSectionName;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_strEntityName;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr_strID;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr_strXmlns;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr_strXml;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeFieldInfoPtr_strSpace;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeFieldInfoPtr_strLang;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeFieldInfoPtr_strEmpty;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeFieldInfoPtr_strNonSignificantWhitespaceName;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeFieldInfoPtr_strSignificantWhitespaceName;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeFieldInfoPtr_strReservedXmlns;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeFieldInfoPtr_strReservedXml;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeFieldInfoPtr_baseURI;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeFieldInfoPtr_resolver;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeFieldInfoPtr_bSetResolver;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeFieldInfoPtr_objLock;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeFieldInfoPtr_EmptyEnumerator;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeFieldInfoPtr_NotKnownSchemaInfo;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeFieldInfoPtr_ValidSchemaInfo;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeFieldInfoPtr_InvalidSchemaInfo;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_XmlImplementation_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_CheckName_Internal_Static_Void_String_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_AddXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_AddAttrXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_AddIdInfo_Internal_Boolean_XmlName_XmlName_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_GetIDInfoByElement__Private_XmlName_XmlName_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_GetIDInfoByElement_Internal_XmlName_XmlName_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Private_WeakReference_ArrayList_XmlElement_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_AddElementWithId_Internal_Void_String_XmlElement_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElementWithId_Internal_Void_String_XmlElement_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_get_DocumentType_Public_Virtual_New_get_XmlDocumentType_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_get_Declaration_Internal_Virtual_New_get_XmlDeclaration_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_get_Implementation_Public_get_XmlImplementation_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_get_DocumentElement_Public_get_XmlElement_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_get_CanReportValidity_Internal_get_Boolean_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSetResolver_Internal_get_Boolean_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_Virtual_New_set_Void_XmlResolver_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_HasNodeTypeInPrevSiblings_Private_Boolean_XmlNodeType_XmlNode_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_HasNodeTypeInNextSiblings_Private_Boolean_XmlNodeType_XmlNode_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_CanInsertBefore_Internal_Virtual_Boolean_XmlNode_XmlNode_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_Boolean_XmlNode_XmlNode_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_XmlAttribute_String_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultNamespace_Internal_Void_String_String_byref_String_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_New_XmlCDataSection_String_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_CreateComment_Public_Virtual_New_XmlComment_String_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_CreateDocumentType_Public_Virtual_New_XmlDocumentType_String_String_String_String_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_CreateDocumentFragment_Public_Virtual_New_XmlDocumentFragment_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_XmlElement_String_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributes_Internal_Void_XmlElement_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaElementDecl_Private_SchemaElementDecl_XmlElement_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDefaultAttribute_Private_XmlAttribute_SchemaAttDef_String_String_String_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntityReference_Public_Virtual_New_XmlEntityReference_String_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_New_XmlProcessingInstruction_String_String_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_New_XmlDeclaration_String_String_String_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextNode_Public_Virtual_New_XmlText_String_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_New_XmlSignificantWhitespace_String_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_New_XmlWhitespace_String_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_XmlAttribute_String_String_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_XmlElement_String_String_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_ImportNodeInternal_Private_XmlNode_XmlNode_Boolean_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_ImportAttributes_Private_Void_XmlNode_XmlNode_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_ImportChildren_Private_Void_XmlNode_XmlNode_Boolean_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_Virtual_New_XmlAttribute_String_String_String_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultAttribute_FamOrAssem_Virtual_New_XmlAttribute_String_String_String_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_Virtual_New_XmlElement_String_String_String_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_get_Entities_Internal_get_XmlNamedNodeMap_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_set_Entities_Internal_set_Void_XmlNamedNodeMap_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Internal_get_Boolean_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLoading_Internal_set_Void_Boolean_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualLoadingStatus_Internal_get_Boolean_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_ReadNode_Public_Virtual_New_XmlNode_XmlReader_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_SetupReader_Private_XmlTextReader_XmlTextReader_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_XmlReader_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_LoadXml_Public_Virtual_New_Void_String_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_New_Void_XmlWriter_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_WriteContentTo_Public_Virtual_Void_XmlWriter_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_GetInsertEventArgsForLoad_Internal_XmlNodeChangedEventArgs_XmlNode_XmlNode_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_AfterEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultAttribute_Internal_XmlAttribute_XmlElement_String_String_String_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Internal_get_String_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Internal_get_String_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_get_Standalone_Internal_get_String_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityNode_Internal_XmlEntity_String_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_get_IXmlSchemaInfo_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_SetBaseURI_Internal_Void_String_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0;
	}
}
