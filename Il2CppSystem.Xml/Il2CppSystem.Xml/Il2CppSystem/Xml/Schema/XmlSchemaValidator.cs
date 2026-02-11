using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001E8 RID: 488
	public sealed class XmlSchemaValidator : Object
	{
		// Token: 0x06002876 RID: 10358 RVA: 0x000BBED4 File Offset: 0x000BA0D4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaValidator()
		{
			Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr);
			XmlSchemaValidator.NativeFieldInfoPtr_schemaSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "schemaSet");
			XmlSchemaValidator.NativeFieldInfoPtr_validationFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "validationFlags");
			XmlSchemaValidator.NativeFieldInfoPtr_startIDConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "startIDConstraint");
			XmlSchemaValidator.NativeFieldInfoPtr_isRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "isRoot");
			XmlSchemaValidator.NativeFieldInfoPtr_rootHasSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "rootHasSchema");
			XmlSchemaValidator.NativeFieldInfoPtr_attrValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "attrValid");
			XmlSchemaValidator.NativeFieldInfoPtr_checkEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "checkEntity");
			XmlSchemaValidator.NativeFieldInfoPtr_compiledSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "compiledSchemaInfo");
			XmlSchemaValidator.NativeFieldInfoPtr_dtdSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "dtdSchemaInfo");
			XmlSchemaValidator.NativeFieldInfoPtr_validatedNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "validatedNamespaces");
			XmlSchemaValidator.NativeFieldInfoPtr_validationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "validationStack");
			XmlSchemaValidator.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "context");
			XmlSchemaValidator.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "currentState");
			XmlSchemaValidator.NativeFieldInfoPtr_attPresence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "attPresence");
			XmlSchemaValidator.NativeFieldInfoPtr_wildID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "wildID");
			XmlSchemaValidator.NativeFieldInfoPtr_IDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "IDs");
			XmlSchemaValidator.NativeFieldInfoPtr_idRefListHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "idRefListHead");
			XmlSchemaValidator.NativeFieldInfoPtr_contextQName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "contextQName");
			XmlSchemaValidator.NativeFieldInfoPtr_NsXs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "NsXs");
			XmlSchemaValidator.NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "NsXsi");
			XmlSchemaValidator.NativeFieldInfoPtr_NsXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "NsXmlNs");
			XmlSchemaValidator.NativeFieldInfoPtr_NsXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "NsXml");
			XmlSchemaValidator.NativeFieldInfoPtr_partialValidationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "partialValidationType");
			XmlSchemaValidator.NativeFieldInfoPtr_textValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "textValue");
			XmlSchemaValidator.NativeFieldInfoPtr_eventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "eventHandler");
			XmlSchemaValidator.NativeFieldInfoPtr_validationEventSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "validationEventSender");
			XmlSchemaValidator.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "nameTable");
			XmlSchemaValidator.NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "positionInfo");
			XmlSchemaValidator.NativeFieldInfoPtr_dummyPositionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "dummyPositionInfo");
			XmlSchemaValidator.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xmlResolver");
			XmlSchemaValidator.NativeFieldInfoPtr_sourceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "sourceUri");
			XmlSchemaValidator.NativeFieldInfoPtr_sourceUriString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "sourceUriString");
			XmlSchemaValidator.NativeFieldInfoPtr_nsResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "nsResolver");
			XmlSchemaValidator.NativeFieldInfoPtr_processContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "processContents");
			XmlSchemaValidator.NativeFieldInfoPtr_xsiTypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xsiTypeString");
			XmlSchemaValidator.NativeFieldInfoPtr_xsiNilString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xsiNilString");
			XmlSchemaValidator.NativeFieldInfoPtr_xsiSchemaLocationString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xsiSchemaLocationString");
			XmlSchemaValidator.NativeFieldInfoPtr_xsiNoNamespaceSchemaLocationString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xsiNoNamespaceSchemaLocationString");
			XmlSchemaValidator.NativeFieldInfoPtr_dtQName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "dtQName");
			XmlSchemaValidator.NativeFieldInfoPtr_dtCDATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "dtCDATA");
			XmlSchemaValidator.NativeFieldInfoPtr_dtStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "dtStringArray");
			XmlSchemaValidator.NativeFieldInfoPtr_EmptyParticleArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "EmptyParticleArray");
			XmlSchemaValidator.NativeFieldInfoPtr_EmptyAttributeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "EmptyAttributeArray");
			XmlSchemaValidator.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "xmlCharType");
			XmlSchemaValidator.NativeFieldInfoPtr_ValidStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "ValidStates");
			XmlSchemaValidator.NativeFieldInfoPtr_MethodNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, "MethodNames");
			XmlSchemaValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlSchemaSet_IXmlNamespaceResolver_XmlSchemaValidationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669139);
			XmlSchemaValidator.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669140);
			XmlSchemaValidator.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669141);
			XmlSchemaValidator.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669142);
			XmlSchemaValidator.NativeMethodInfoPtr_set_LineInfoProvider_Public_set_Void_IXmlLineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669143);
			XmlSchemaValidator.NativeMethodInfoPtr_set_SourceUri_Public_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669144);
			XmlSchemaValidator.NativeMethodInfoPtr_set_ValidationEventSender_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669145);
			XmlSchemaValidator.NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669146);
			XmlSchemaValidator.NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669147);
			XmlSchemaValidator.NativeMethodInfoPtr_AddSchema_Public_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669148);
			XmlSchemaValidator.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669149);
			XmlSchemaValidator.NativeMethodInfoPtr_Initialize_Public_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669150);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateElement_Public_Void_String_String_XmlSchemaInfo_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669151);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateAttribute_Public_Object_String_String_XmlValueGetter_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669152);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateAttribute_Private_Object_String_String_XmlValueGetter_String_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669153);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateEndOfAttributes_Public_Void_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669154);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateText_Public_Void_XmlValueGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669155);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateText_Private_Void_String_XmlValueGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669156);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateWhitespace_Public_Void_XmlValueGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669157);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateWhitespace_Private_Void_String_XmlValueGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669158);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateEndElement_Public_Object_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669159);
			XmlSchemaValidator.NativeMethodInfoPtr_SkipToEndElement_Public_Void_XmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669160);
			XmlSchemaValidator.NativeMethodInfoPtr_EndValidation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669161);
			XmlSchemaValidator.NativeMethodInfoPtr_GetUnspecifiedDefaultAttributes_Internal_Void_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669162);
			XmlSchemaValidator.NativeMethodInfoPtr_get_SchemaSet_Internal_get_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669163);
			XmlSchemaValidator.NativeMethodInfoPtr_get_ValidationFlags_Internal_get_XmlSchemaValidationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669164);
			XmlSchemaValidator.NativeMethodInfoPtr_get_CurrentContentType_Internal_get_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669165);
			XmlSchemaValidator.NativeMethodInfoPtr_SetDtdSchemaInfo_Internal_Void_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669166);
			XmlSchemaValidator.NativeMethodInfoPtr_get_StrictlyAssessed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669167);
			XmlSchemaValidator.NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669168);
			XmlSchemaValidator.NativeMethodInfoPtr_GetConcatenatedValue_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669169);
			XmlSchemaValidator.NativeMethodInfoPtr_InternalValidateEndElement_Private_Object_XmlSchemaInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669170);
			XmlSchemaValidator.NativeMethodInfoPtr_ProcessSchemaLocations_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669171);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateElementContext_Private_Object_XmlQualifiedName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669172);
			XmlSchemaValidator.NativeMethodInfoPtr_GetSubstitutionGroupHead_Private_XmlSchemaElement_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669173);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_String_byref_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669174);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_Object_byref_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669175);
			XmlSchemaValidator.NativeMethodInfoPtr_GetTypeName_Private_String_SchemaDeclBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669176);
			XmlSchemaValidator.NativeMethodInfoPtr_SaveTextValue_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669177);
			XmlSchemaValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669178);
			XmlSchemaValidator.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669179);
			XmlSchemaValidator.NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_XmlQualifiedName_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669180);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckXsiTypeAndNil_Private_SchemaElementDecl_SchemaElementDecl_String_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669181);
			XmlSchemaValidator.NativeMethodInfoPtr_ThrowDeclNotFoundWarningOrError_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669182);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckElementProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669183);
			XmlSchemaValidator.NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669184);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckIsXmlAttribute_Private_SchemaAttDef_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669185);
			XmlSchemaValidator.NativeMethodInfoPtr_AddXmlNamespaceSchema_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669186);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckMixedValueConstraint_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669187);
			XmlSchemaValidator.NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669188);
			XmlSchemaValidator.NativeMethodInfoPtr_RecompileSchemaSet_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669189);
			XmlSchemaValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669190);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckAttributeValue_Private_Object_Object_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669191);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckElementValue_Private_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669192);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckTokenizedTypes_Private_Void_XmlSchemaDatatype_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669193);
			XmlSchemaValidator.NativeMethodInfoPtr_FindId_Private_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669194);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669195);
			XmlSchemaValidator.NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669196);
			XmlSchemaValidator.NativeMethodInfoPtr_get_ProcessIdentityConstraints_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669197);
			XmlSchemaValidator.NativeMethodInfoPtr_get_ReportValidationWarnings_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669198);
			XmlSchemaValidator.NativeMethodInfoPtr_get_ProcessSchemaHints_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669199);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckStateTransition_Private_Void_ValidatorState_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669200);
			XmlSchemaValidator.NativeMethodInfoPtr_ClearPSVI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669201);
			XmlSchemaValidator.NativeMethodInfoPtr_CheckRequiredAttributes_Private_Void_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669202);
			XmlSchemaValidator.NativeMethodInfoPtr_GetSchemaElement_Private_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669203);
			XmlSchemaValidator.NativeMethodInfoPtr_GetDefaultAttributePrefix_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669204);
			XmlSchemaValidator.NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669205);
			XmlSchemaValidator.NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669206);
			XmlSchemaValidator.NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669207);
			XmlSchemaValidator.NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_Object_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669208);
			XmlSchemaValidator.NativeMethodInfoPtr_ElementValidationError_Internal_Static_Void_XmlQualifiedName_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669209);
			XmlSchemaValidator.NativeMethodInfoPtr_CompleteValidationError_Internal_Static_Void_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669210);
			XmlSchemaValidator.NativeMethodInfoPtr_PrintExpectedElements_Internal_Static_String_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669211);
			XmlSchemaValidator.NativeMethodInfoPtr_PrintNames_Private_Static_String_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669212);
			XmlSchemaValidator.NativeMethodInfoPtr_PrintNamesWithNS_Private_Static_Void_ArrayList_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669213);
			XmlSchemaValidator.NativeMethodInfoPtr_EnumerateAny_Private_Static_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669214);
			XmlSchemaValidator.NativeMethodInfoPtr_QNameString_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669215);
			XmlSchemaValidator.NativeMethodInfoPtr_BuildElementName_Internal_Static_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669216);
			XmlSchemaValidator.NativeMethodInfoPtr_BuildElementName_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669217);
			XmlSchemaValidator.NativeMethodInfoPtr_ProcessEntity_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669218);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669219);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669220);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669221);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669222);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669223);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669224);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669225);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669226);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669227);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669228);
			XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Internal_Static_Void_ValidationEventHandler_Object_XmlSchemaValidationException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr, 100669229);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x000BC9B8 File Offset: 0x000BABB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415067, RefRangeEnd = 415068, XrefRangeStart = 415011, XrefRangeEnd = 415067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaValidator(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemas);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceResolver);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validationFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlSchemaSet_IXmlNamespaceResolver_XmlSchemaValidationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x000BCA38 File Offset: 0x000BAC38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415128, RefRangeEnd = 415129, XrefRangeStart = 415068, XrefRangeEnd = 415128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000BCA6C File Offset: 0x000BAC6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 415132, RefRangeEnd = 415135, XrefRangeStart = 415129, XrefRangeEnd = 415132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E05 RID: 3589
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x000BCAA0 File Offset: 0x000BACA0
		public unsafe XmlResolver XmlResolver
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x000BCAE4 File Offset: 0x000BACE4
		public unsafe IXmlLineInfo LineInfoProvider
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 415136, RefRangeEnd = 415137, XrefRangeStart = 415135, XrefRangeEnd = 415136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_set_LineInfoProvider_Public_set_Void_IXmlLineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (set) Token: 0x0600287C RID: 10364 RVA: 0x000BCB28 File Offset: 0x000BAD28
		public unsafe Uri SourceUri
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 415140, RefRangeEnd = 415141, XrefRangeStart = 415137, XrefRangeEnd = 415140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_set_SourceUri_Public_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x000BCB6C File Offset: 0x000BAD6C
		public unsafe Object ValidationEventSender
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_set_ValidationEventSender_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x000BCBB0 File Offset: 0x000BADB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415149, RefRangeEnd = 415150, XrefRangeStart = 415141, XrefRangeEnd = 415149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValidationEventHandler(ValidationEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x000BCBF4 File Offset: 0x000BADF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415150, XrefRangeEnd = 415158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValidationEventHandler(ValidationEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x000BCC38 File Offset: 0x000BAE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415187, RefRangeEnd = 415188, XrefRangeStart = 415158, XrefRangeEnd = 415187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSchema(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_AddSchema_Public_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x000BCC7C File Offset: 0x000BAE7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415212, RefRangeEnd = 415213, XrefRangeStart = 415188, XrefRangeEnd = 415212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x000BCCB0 File Offset: 0x000BAEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415213, XrefRangeEnd = 415257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(XmlSchemaObject partialValidationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(partialValidationType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Initialize_Public_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000BCCF4 File Offset: 0x000BAEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415257, XrefRangeEnd = 415287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiNil);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiSchemaLocation);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiNoNamespaceSchemaLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateElement_Public_Void_String_String_XmlSchemaInfo_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000BCDA8 File Offset: 0x000BAFA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415288, RefRangeEnd = 415289, XrefRangeStart = 415287, XrefRangeEnd = 415288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateAttribute_Public_Object_String_String_XmlValueGetter_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000BCE30 File Offset: 0x000BB030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415369, RefRangeEnd = 415370, XrefRangeStart = 415289, XrefRangeEnd = 415369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeValueGetter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeStringValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateAttribute_Private_Object_String_String_XmlValueGetter_String_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000BCECC File Offset: 0x000BB0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415370, XrefRangeEnd = 415376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateEndOfAttributes_Public_Void_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000BCF10 File Offset: 0x000BB110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 415383, RefRangeEnd = 415385, XrefRangeStart = 415376, XrefRangeEnd = 415383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateText(XmlValueGetter elementValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateText_Public_Void_XmlValueGetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000BCF54 File Offset: 0x000BB154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415416, RefRangeEnd = 415417, XrefRangeStart = 415385, XrefRangeEnd = 415416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementStringValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementValueGetter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateText_Private_Void_String_XmlValueGetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000BCFA8 File Offset: 0x000BB1A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 415500, RefRangeEnd = 415502, XrefRangeStart = 415417, XrefRangeEnd = 415500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateWhitespace(XmlValueGetter elementValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateWhitespace_Public_Void_XmlValueGetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000BCFEC File Offset: 0x000BB1EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415518, RefRangeEnd = 415519, XrefRangeStart = 415502, XrefRangeEnd = 415518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementStringValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementValueGetter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateWhitespace_Private_Void_String_XmlValueGetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000BD040 File Offset: 0x000BB240
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 415520, RefRangeEnd = 415523, XrefRangeStart = 415519, XrefRangeEnd = 415520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateEndElement(XmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateEndElement_Public_Object_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000BD090 File Offset: 0x000BB290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415555, RefRangeEnd = 415556, XrefRangeStart = 415523, XrefRangeEnd = 415555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipToEndElement(XmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SkipToEndElement_Public_Void_XmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x000BD0D4 File Offset: 0x000BB2D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415579, RefRangeEnd = 415580, XrefRangeStart = 415556, XrefRangeEnd = 415579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_EndValidation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x000BD108 File Offset: 0x000BB308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415638, RefRangeEnd = 415639, XrefRangeStart = 415580, XrefRangeEnd = 415638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultAttributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createNodeData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetUnspecifiedDefaultAttributes_Internal_Void_ArrayList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x000BD158 File Offset: 0x000BB358
		public unsafe XmlSchemaSet SchemaSet
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_SchemaSet_Internal_get_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr3) : null;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x000BD198 File Offset: 0x000BB398
		public unsafe XmlSchemaValidationFlags ValidationFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_ValidationFlags_Internal_get_XmlSchemaValidationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x000BD1D4 File Offset: 0x000BB3D4
		public unsafe XmlSchemaContentType CurrentContentType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 415639, RefRangeEnd = 415641, XrefRangeStart = 415639, XrefRangeEnd = 415639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_CurrentContentType_Internal_get_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000BD210 File Offset: 0x000BB410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415642, RefRangeEnd = 415643, XrefRangeStart = 415641, XrefRangeEnd = 415642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtdSchemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SetDtdSchemaInfo_Internal_Void_IDtdInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x000BD254 File Offset: 0x000BB454
		public unsafe bool StrictlyAssessed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_StrictlyAssessed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x000BD290 File Offset: 0x000BB490
		public unsafe bool HasSchema
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415643, XrefRangeEnd = 415644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000BD2CC File Offset: 0x000BB4CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415645, RefRangeEnd = 415646, XrefRangeStart = 415644, XrefRangeEnd = 415645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetConcatenatedValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetConcatenatedValue_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000BD304 File Offset: 0x000BB504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415681, RefRangeEnd = 415682, XrefRangeStart = 415646, XrefRangeEnd = 415681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalValidateEndElement(XmlSchemaInfo schemaInfo, Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typedValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_InternalValidateEndElement_Private_Object_XmlSchemaInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000BD368 File Offset: 0x000BB568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415715, RefRangeEnd = 415716, XrefRangeStart = 415682, XrefRangeEnd = 415715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xsiSchemaLocation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiNoNamespaceSchemaLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ProcessSchemaLocations_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000BD3BC File Offset: 0x000BB5BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415730, RefRangeEnd = 415731, XrefRangeStart = 415716, XrefRangeEnd = 415730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &invalidElementInContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateElementContext_Private_Object_XmlQualifiedName_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x000BD41C File Offset: 0x000BB61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415731, XrefRangeEnd = 415745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetSubstitutionGroupHead_Private_XmlSchemaElement_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x000BD46C File Offset: 0x000BB66C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415772, RefRangeEnd = 415773, XrefRangeStart = 415745, XrefRangeEnd = 415772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_String_byref_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			memberType = ((intPtr4 == 0) ? null : new XmlSchemaSimpleType(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000BD4E0 File Offset: 0x000BB6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415793, RefRangeEnd = 415794, XrefRangeStart = 415773, XrefRangeEnd = 415793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateAtomicValue(Object parsedValue, out XmlSchemaSimpleType memberType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parsedValue);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_Object_byref_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			memberType = ((intPtr4 == 0) ? null : new XmlSchemaSimpleType(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x000BD554 File Offset: 0x000BB754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415794, XrefRangeEnd = 415796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeName(SchemaDeclBase decl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetTypeName_Private_String_SchemaDeclBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x000BD59C File Offset: 0x000BB79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415796, XrefRangeEnd = 415798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveTextValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SaveTextValue_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x000BD5E0 File Offset: 0x000BB7E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 415816, RefRangeEnd = 415818, XrefRangeStart = 415798, XrefRangeEnd = 415816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(XmlQualifiedName elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x000BD624 File Offset: 0x000BB824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 415827, RefRangeEnd = 415829, XrefRangeStart = 415818, XrefRangeEnd = 415827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x000BD658 File Offset: 0x000BB858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415838, RefRangeEnd = 415839, XrefRangeStart = 415829, XrefRangeEnd = 415838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_XmlQualifiedName_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x000BD6BC File Offset: 0x000BB8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415924, RefRangeEnd = 415925, XrefRangeStart = 415839, XrefRangeEnd = 415924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementDecl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiNil);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &declFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckXsiTypeAndNil_Private_SchemaElementDecl_SchemaElementDecl_String_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x000BD740 File Offset: 0x000BB940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 415943, RefRangeEnd = 415944, XrefRangeStart = 415925, XrefRangeEnd = 415943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowDeclNotFoundWarningOrError(bool declFound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref declFound;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ThrowDeclNotFoundWarningOrError_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x000BD780 File Offset: 0x000BB980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415944, XrefRangeEnd = 415953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckElementProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckElementProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x000BD7B4 File Offset: 0x000BB9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415953, XrefRangeEnd = 415955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateStartElementIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x000BD7E8 File Offset: 0x000BB9E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 415973, RefRangeEnd = 415976, XrefRangeStart = 415955, XrefRangeEnd = 415973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attQName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckIsXmlAttribute_Private_SchemaAttDef_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
			}
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x000BD838 File Offset: 0x000BBA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415976, XrefRangeEnd = 415990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXmlNamespaceSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_AddXmlNamespaceSchema_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x000BD86C File Offset: 0x000BBA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415990, XrefRangeEnd = 415995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CheckMixedValueConstraint(string elementValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckMixedValueConstraint_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x000BD8BC File Offset: 0x000BBABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 416020, RefRangeEnd = 416022, XrefRangeStart = 415995, XrefRangeEnd = 416020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchema(string uri, string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x000BD910 File Offset: 0x000BBB10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 416028, RefRangeEnd = 416033, XrefRangeStart = 416022, XrefRangeEnd = 416028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecompileSchemaSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_RecompileSchemaSet_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x000BD944 File Offset: 0x000BBB44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 416047, RefRangeEnd = 416049, XrefRangeStart = 416033, XrefRangeEnd = 416047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ttype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attrValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x000BD9A4 File Offset: 0x000BBBA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 416059, RefRangeEnd = 416060, XrefRangeStart = 416049, XrefRangeEnd = 416059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CheckAttributeValue(Object value, SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckAttributeValue_Private_Object_Object_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000BDA08 File Offset: 0x000BBC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 416072, RefRangeEnd = 416073, XrefRangeStart = 416060, XrefRangeEnd = 416072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CheckElementValue(string stringValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckElementValue_Private_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000BDA58 File Offset: 0x000BBC58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 416082, RefRangeEnd = 416086, XrefRangeStart = 416073, XrefRangeEnd = 416082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTokenizedTypes(XmlSchemaDatatype dtype, Object typedValue, bool attrValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typedValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attrValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckTokenizedTypes_Private_Void_XmlSchemaDatatype_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000BDABC File Offset: 0x000BBCBC
		[CallerCount(0)]
		public unsafe Object FindId(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_FindId_Private_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000BDB0C File Offset: 0x000BBD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416086, XrefRangeEnd = 416095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForwardRefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x000BDB40 File Offset: 0x000BBD40
		public unsafe bool HasIdentityConstraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000BDB7C File Offset: 0x000BBD7C
		public unsafe bool ProcessIdentityConstraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_ProcessIdentityConstraints_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x000BDBB8 File Offset: 0x000BBDB8
		public unsafe bool ReportValidationWarnings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_ReportValidationWarnings_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000BDBF4 File Offset: 0x000BBDF4
		public unsafe bool ProcessSchemaHints
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 416095, RefRangeEnd = 416096, XrefRangeStart = 416095, XrefRangeEnd = 416095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_get_ProcessSchemaHints_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000BDC30 File Offset: 0x000BBE30
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 416100, RefRangeEnd = 416108, XrefRangeStart = 416096, XrefRangeEnd = 416100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStateTransition(ValidatorState toState, string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckStateTransition_Private_Void_ValidatorState_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000BDC80 File Offset: 0x000BBE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416108, XrefRangeEnd = 416111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPSVI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ClearPSVI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000BDCB4 File Offset: 0x000BBEB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 416131, RefRangeEnd = 416133, XrefRangeStart = 416111, XrefRangeEnd = 416131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRequiredAttributes(SchemaElementDecl currentElementDecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentElementDecl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CheckRequiredAttributes_Private_Void_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000BDCF8 File Offset: 0x000BBEF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 416144, RefRangeEnd = 416147, XrefRangeStart = 416133, XrefRangeEnd = 416144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement GetSchemaElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetSchemaElement_Private_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000BDD38 File Offset: 0x000BBF38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 416172, RefRangeEnd = 416174, XrefRangeStart = 416147, XrefRangeEnd = 416172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDefaultAttributePrefix(string attributeNS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeNS);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_GetDefaultAttributePrefix_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x000BDD80 File Offset: 0x000BBF80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 416212, RefRangeEnd = 416214, XrefRangeStart = 416174, XrefRangeEnd = 416212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x000BDDB4 File Offset: 0x000BBFB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 416236, RefRangeEnd = 416238, XrefRangeStart = 416214, XrefRangeEnd = 416236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ElementIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x000BDDE8 File Offset: 0x000BBFE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 416259, RefRangeEnd = 416261, XrefRangeStart = 416238, XrefRangeEnd = 416259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttributeIdentityConstraints(string name, string ns, Object obj, string sobj, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sobj);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000BDE74 File Offset: 0x000BC074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 416344, RefRangeEnd = 416345, XrefRangeStart = 416261, XrefRangeEnd = 416344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndElementIdentityConstraints(Object typedValue, string stringValue, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typedValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_Object_String_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000BDEDC File Offset: 0x000BC0DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 416377, RefRangeEnd = 416382, XrefRangeStart = 416345, XrefRangeEnd = 416377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, Object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ElementValidationError_Internal_Static_Void_XmlQualifiedName_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000BDF8C File Offset: 0x000BC18C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 416407, RefRangeEnd = 416411, XrefRangeStart = 416382, XrefRangeEnd = 416407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, Object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_CompleteValidationError_Internal_Static_Void_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000BE028 File Offset: 0x000BC228
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 416453, RefRangeEnd = 416456, XrefRangeStart = 416411, XrefRangeEnd = 416453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PrintExpectedElements(ArrayList expected, bool getParticles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getParticles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_PrintExpectedElements_Internal_Static_String_ArrayList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000BE074 File Offset: 0x000BC274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 416472, RefRangeEnd = 416473, XrefRangeStart = 416456, XrefRangeEnd = 416472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PrintNames(ArrayList expected)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_PrintNames_Private_Static_String_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x000BE0B0 File Offset: 0x000BC2B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 416506, RefRangeEnd = 416508, XrefRangeStart = 416473, XrefRangeEnd = 416506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrintNamesWithNS(ArrayList expected, StringBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_PrintNamesWithNS_Private_Static_Void_ArrayList_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x000BE0F8 File Offset: 0x000BC2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416508, XrefRangeEnd = 416542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnumerateAny(StringBuilder builder, string namespaces)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaces);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_EnumerateAny_Private_Static_Void_StringBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x000BE140 File Offset: 0x000BC340
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 416545, RefRangeEnd = 416559, XrefRangeStart = 416542, XrefRangeEnd = 416545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QNameString(string localName, string ns)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_QNameString_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x000BE190 File Offset: 0x000BC390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416559, XrefRangeEnd = 416564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BuildElementName(XmlQualifiedName qname)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_BuildElementName_Internal_Static_String_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x000BE1CC File Offset: 0x000BC3CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 416588, RefRangeEnd = 416594, XrefRangeStart = 416564, XrefRangeEnd = 416588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BuildElementName(string localName, string ns)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_BuildElementName_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000BE21C File Offset: 0x000BC41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416594, XrefRangeEnd = 416607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEntity(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_ProcessEntity_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x000BE260 File Offset: 0x000BC460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 416610, RefRangeEnd = 416611, XrefRangeStart = 416607, XrefRangeEnd = 416610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000BE2A4 File Offset: 0x000BC4A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 416622, RefRangeEnd = 416628, XrefRangeStart = 416611, XrefRangeEnd = 416622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x000BE2F8 File Offset: 0x000BC4F8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 416639, RefRangeEnd = 416660, XrefRangeStart = 416628, XrefRangeEnd = 416639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000BE34C File Offset: 0x000BC54C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 416677, RefRangeEnd = 416678, XrefRangeStart = 416660, XrefRangeEnd = 416677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string arg1, string arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x000BE3B4 File Offset: 0x000BC5B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 416688, RefRangeEnd = 416689, XrefRangeStart = 416678, XrefRangeEnd = 416688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args, Exception innerException, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x000BE428 File Offset: 0x000BC628
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 416700, RefRangeEnd = 416704, XrefRangeStart = 416689, XrefRangeEnd = 416700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000BE490 File Offset: 0x000BC690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416704, XrefRangeEnd = 416705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaValidationException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000BE4D4 File Offset: 0x000BC6D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 416711, RefRangeEnd = 416713, XrefRangeStart = 416705, XrefRangeEnd = 416711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000BE518 File Offset: 0x000BC718
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 416723, RefRangeEnd = 416729, XrefRangeStart = 416713, XrefRangeEnd = 416723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string msg, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000BE57C File Offset: 0x000BC77C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 416737, RefRangeEnd = 416750, XrefRangeStart = 416729, XrefRangeEnd = 416737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000BE5CC File Offset: 0x000BC7CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 416755, RefRangeEnd = 416756, XrefRangeStart = 416750, XrefRangeEnd = 416755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendValidationEvent(ValidationEventHandler eventHandler, Object sender, XmlSchemaValidationException e, XmlSeverityType severity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaValidator.NativeMethodInfoPtr_SendValidationEvent_Internal_Static_Void_ValidationEventHandler_Object_XmlSchemaValidationException_XmlSeverityType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000111F3 File Offset: 0x0000F3F3
		public XmlSchemaValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x000BE634 File Offset: 0x000BC834
		// (set) Token: 0x060028D4 RID: 10452 RVA: 0x000111FC File Offset: 0x0000F3FC
		public unsafe XmlSchemaSet schemaSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_schemaSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_schemaSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x000BE664 File Offset: 0x000BC864
		// (set) Token: 0x060028D6 RID: 10454 RVA: 0x0001121B File Offset: 0x0000F41B
		public unsafe XmlSchemaValidationFlags validationFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationFlags)) = value;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x000BE68C File Offset: 0x000BC88C
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x00011236 File Offset: 0x0000F436
		public unsafe int startIDConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_startIDConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_startIDConstraint)) = value;
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x000BE6B4 File Offset: 0x000BC8B4
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x00011251 File Offset: 0x0000F451
		public unsafe bool isRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_isRoot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_isRoot)) = value;
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x000BE6DC File Offset: 0x000BC8DC
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x0001126C File Offset: 0x0000F46C
		public unsafe bool rootHasSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_rootHasSchema);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_rootHasSchema)) = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x000BE704 File Offset: 0x000BC904
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x00011287 File Offset: 0x0000F487
		public unsafe bool attrValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_attrValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_attrValid)) = value;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x000BE72C File Offset: 0x000BC92C
		// (set) Token: 0x060028E0 RID: 10464 RVA: 0x000112A2 File Offset: 0x0000F4A2
		public unsafe bool checkEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_checkEntity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_checkEntity)) = value;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x000BE754 File Offset: 0x000BC954
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x000112BD File Offset: 0x0000F4BD
		public unsafe SchemaInfo compiledSchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_compiledSchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_compiledSchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x000BE784 File Offset: 0x000BC984
		// (set) Token: 0x060028E4 RID: 10468 RVA: 0x000112DC File Offset: 0x0000F4DC
		public unsafe IDtdInfo dtdSchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_dtdSchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_dtdSchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x000BE7B4 File Offset: 0x000BC9B4
		// (set) Token: 0x060028E6 RID: 10470 RVA: 0x000112FB File Offset: 0x0000F4FB
		public unsafe Hashtable validatedNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validatedNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validatedNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000BE7E4 File Offset: 0x000BC9E4
		// (set) Token: 0x060028E8 RID: 10472 RVA: 0x0001131A File Offset: 0x0000F51A
		public unsafe HWStack validationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x000BE814 File Offset: 0x000BCA14
		// (set) Token: 0x060028EA RID: 10474 RVA: 0x00011339 File Offset: 0x0000F539
		public unsafe ValidationState context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x000BE844 File Offset: 0x000BCA44
		// (set) Token: 0x060028EC RID: 10476 RVA: 0x00011358 File Offset: 0x0000F558
		public unsafe ValidatorState currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x000BE86C File Offset: 0x000BCA6C
		// (set) Token: 0x060028EE RID: 10478 RVA: 0x00011373 File Offset: 0x0000F573
		public unsafe Hashtable attPresence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_attPresence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_attPresence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x000BE89C File Offset: 0x000BCA9C
		// (set) Token: 0x060028F0 RID: 10480 RVA: 0x00011392 File Offset: 0x0000F592
		public unsafe SchemaAttDef wildID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_wildID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_wildID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x000BE8CC File Offset: 0x000BCACC
		// (set) Token: 0x060028F2 RID: 10482 RVA: 0x000113B1 File Offset: 0x0000F5B1
		public unsafe Hashtable IDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_IDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_IDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x000BE8FC File Offset: 0x000BCAFC
		// (set) Token: 0x060028F4 RID: 10484 RVA: 0x000113D0 File Offset: 0x0000F5D0
		public unsafe IdRefNode idRefListHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_idRefListHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdRefNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_idRefListHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x000BE92C File Offset: 0x000BCB2C
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x000113EF File Offset: 0x0000F5EF
		public unsafe XmlQualifiedName contextQName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_contextQName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_contextQName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x000BE95C File Offset: 0x000BCB5C
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x0001140E File Offset: 0x0000F60E
		public unsafe string NsXs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x000BE984 File Offset: 0x000BCB84
		// (set) Token: 0x060028FA RID: 10490 RVA: 0x0001142D File Offset: 0x0000F62D
		public unsafe string NsXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXsi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXsi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x000BE9AC File Offset: 0x000BCBAC
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x0001144C File Offset: 0x0000F64C
		public unsafe string NsXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x000BE9D4 File Offset: 0x000BCBD4
		// (set) Token: 0x060028FE RID: 10494 RVA: 0x0001146B File Offset: 0x0000F66B
		public unsafe string NsXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_NsXml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x000BE9FC File Offset: 0x000BCBFC
		// (set) Token: 0x06002900 RID: 10496 RVA: 0x0001148A File Offset: 0x0000F68A
		public unsafe XmlSchemaObject partialValidationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_partialValidationType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_partialValidationType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x000BEA2C File Offset: 0x000BCC2C
		// (set) Token: 0x06002902 RID: 10498 RVA: 0x000114A9 File Offset: 0x0000F6A9
		public unsafe StringBuilder textValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_textValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_textValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x000BEA5C File Offset: 0x000BCC5C
		// (set) Token: 0x06002904 RID: 10500 RVA: 0x000114C8 File Offset: 0x0000F6C8
		public unsafe ValidationEventHandler eventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_eventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_eventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x000BEA8C File Offset: 0x000BCC8C
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x000114E7 File Offset: 0x0000F6E7
		public unsafe Object validationEventSender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationEventSender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_validationEventSender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x000BEABC File Offset: 0x000BCCBC
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x00011506 File Offset: 0x0000F706
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x000BEAEC File Offset: 0x000BCCEC
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x00011525 File Offset: 0x0000F725
		public unsafe IXmlLineInfo positionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_positionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_positionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x000BEB1C File Offset: 0x000BCD1C
		// (set) Token: 0x0600290C RID: 10508 RVA: 0x00011544 File Offset: 0x0000F744
		public unsafe IXmlLineInfo dummyPositionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_dummyPositionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_dummyPositionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x000BEB4C File Offset: 0x000BCD4C
		// (set) Token: 0x0600290E RID: 10510 RVA: 0x00011563 File Offset: 0x0000F763
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x000BEB7C File Offset: 0x000BCD7C
		// (set) Token: 0x06002910 RID: 10512 RVA: 0x00011582 File Offset: 0x0000F782
		public unsafe Uri sourceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_sourceUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_sourceUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x000BEBAC File Offset: 0x000BCDAC
		// (set) Token: 0x06002912 RID: 10514 RVA: 0x000115A1 File Offset: 0x0000F7A1
		public unsafe string sourceUriString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_sourceUriString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_sourceUriString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x000BEBD4 File Offset: 0x000BCDD4
		// (set) Token: 0x06002914 RID: 10516 RVA: 0x000115C0 File Offset: 0x0000F7C0
		public unsafe IXmlNamespaceResolver nsResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_nsResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_nsResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x000BEC04 File Offset: 0x000BCE04
		// (set) Token: 0x06002916 RID: 10518 RVA: 0x000115DF File Offset: 0x0000F7DF
		public unsafe XmlSchemaContentProcessing processContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_processContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_processContents)) = value;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000BEC2C File Offset: 0x000BCE2C
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x000115FA File Offset: 0x0000F7FA
		public unsafe string xsiTypeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiTypeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiTypeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x000BEC54 File Offset: 0x000BCE54
		// (set) Token: 0x0600291A RID: 10522 RVA: 0x00011619 File Offset: 0x0000F819
		public unsafe string xsiNilString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiNilString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiNilString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x000BEC7C File Offset: 0x000BCE7C
		// (set) Token: 0x0600291C RID: 10524 RVA: 0x00011638 File Offset: 0x0000F838
		public unsafe string xsiSchemaLocationString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiSchemaLocationString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiSchemaLocationString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x0600291D RID: 10525 RVA: 0x000BECA4 File Offset: 0x000BCEA4
		// (set) Token: 0x0600291E RID: 10526 RVA: 0x00011657 File Offset: 0x0000F857
		public unsafe string xsiNoNamespaceSchemaLocationString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiNoNamespaceSchemaLocationString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xsiNoNamespaceSchemaLocationString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x000BECCC File Offset: 0x000BCECC
		// (set) Token: 0x06002920 RID: 10528 RVA: 0x00011676 File Offset: 0x0000F876
		public unsafe static XmlSchemaDatatype dtQName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_dtQName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_dtQName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x000BECF4 File Offset: 0x000BCEF4
		// (set) Token: 0x06002922 RID: 10530 RVA: 0x00011688 File Offset: 0x0000F888
		public unsafe static XmlSchemaDatatype dtCDATA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_dtCDATA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_dtCDATA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x000BED1C File Offset: 0x000BCF1C
		// (set) Token: 0x06002924 RID: 10532 RVA: 0x0001169A File Offset: 0x0000F89A
		public unsafe static XmlSchemaDatatype dtStringArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_dtStringArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_dtStringArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x000BED44 File Offset: 0x000BCF44
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x000116AC File Offset: 0x0000F8AC
		public unsafe static Il2CppReferenceArray<XmlSchemaParticle> EmptyParticleArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_EmptyParticleArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaParticle>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_EmptyParticleArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x000BED6C File Offset: 0x000BCF6C
		// (set) Token: 0x06002928 RID: 10536 RVA: 0x000116BE File Offset: 0x0000F8BE
		public unsafe static Il2CppReferenceArray<XmlSchemaAttribute> EmptyAttributeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_EmptyAttributeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_EmptyAttributeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x000BED94 File Offset: 0x000BCF94
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x000116D0 File Offset: 0x0000F8D0
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaValidator.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x000BEDC4 File Offset: 0x000BCFC4
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x000116FE File Offset: 0x0000F8FE
		public unsafe static Il2CppObjectBase ValidStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_ValidStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_ValidStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x000BEDEC File Offset: 0x000BCFEC
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x00011710 File Offset: 0x0000F910
		public unsafe static Il2CppStringArray MethodNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaValidator.NativeFieldInfoPtr_MethodNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaValidator.NativeFieldInfoPtr_MethodNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeFieldInfoPtr_schemaSet;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeFieldInfoPtr_validationFlags;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeFieldInfoPtr_startIDConstraint;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeFieldInfoPtr_isRoot;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeFieldInfoPtr_rootHasSchema;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeFieldInfoPtr_attrValid;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeFieldInfoPtr_checkEntity;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeFieldInfoPtr_compiledSchemaInfo;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeFieldInfoPtr_dtdSchemaInfo;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeFieldInfoPtr_validatedNamespaces;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeFieldInfoPtr_validationStack;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeFieldInfoPtr_attPresence;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeFieldInfoPtr_wildID;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeFieldInfoPtr_IDs;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeFieldInfoPtr_idRefListHead;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeFieldInfoPtr_contextQName;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeFieldInfoPtr_NsXs;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeFieldInfoPtr_NsXsi;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeFieldInfoPtr_NsXmlNs;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeFieldInfoPtr_NsXml;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeFieldInfoPtr_partialValidationType;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeFieldInfoPtr_textValue;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeFieldInfoPtr_eventHandler;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeFieldInfoPtr_validationEventSender;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeFieldInfoPtr_positionInfo;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeFieldInfoPtr_dummyPositionInfo;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeFieldInfoPtr_sourceUri;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeFieldInfoPtr_sourceUriString;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeFieldInfoPtr_nsResolver;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeFieldInfoPtr_processContents;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeFieldInfoPtr_xsiTypeString;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeFieldInfoPtr_xsiNilString;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeFieldInfoPtr_xsiSchemaLocationString;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeFieldInfoPtr_xsiNoNamespaceSchemaLocationString;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeFieldInfoPtr_dtQName;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeFieldInfoPtr_dtCDATA;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeFieldInfoPtr_dtStringArray;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeFieldInfoPtr_EmptyParticleArray;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeFieldInfoPtr_EmptyAttributeArray;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeFieldInfoPtr_ValidStates;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeFieldInfoPtr_MethodNames;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlSchemaSet_IXmlNamespaceResolver_XmlSchemaValidationFlags_0;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_set_LineInfoProvider_Public_set_Void_IXmlLineInfo_0;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceUri_Public_set_Void_Uri_0;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeMethodInfoPtr_set_ValidationEventSender_Public_set_Void_Object_0;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeMethodInfoPtr_AddSchema_Public_Void_XmlSchema_0;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_XmlSchemaObject_0;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Public_Void_String_String_XmlSchemaInfo_String_String_String_String_0;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAttribute_Public_Object_String_String_XmlValueGetter_XmlSchemaInfo_0;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAttribute_Private_Object_String_String_XmlValueGetter_String_XmlSchemaInfo_0;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndOfAttributes_Public_Void_XmlSchemaInfo_0;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr_ValidateText_Public_Void_XmlValueGetter_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr_ValidateText_Private_Void_String_XmlValueGetter_0;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr_ValidateWhitespace_Public_Void_XmlValueGetter_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr_ValidateWhitespace_Private_Void_String_XmlValueGetter_0;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndElement_Public_Object_XmlSchemaInfo_0;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr_SkipToEndElement_Public_Void_XmlSchemaInfo_0;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeMethodInfoPtr_EndValidation_Public_Void_0;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeMethodInfoPtr_GetUnspecifiedDefaultAttributes_Internal_Void_ArrayList_Boolean_0;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaSet_Internal_get_XmlSchemaSet_0;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationFlags_Internal_get_XmlSchemaValidationFlags_0;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContentType_Internal_get_XmlSchemaContentType_0;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeMethodInfoPtr_SetDtdSchemaInfo_Internal_Void_IDtdInfo_0;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeMethodInfoPtr_get_StrictlyAssessed_Private_get_Boolean_0;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeMethodInfoPtr_GetConcatenatedValue_Internal_String_0;

		// Token: 0x04001EDA RID: 7898
		private static readonly IntPtr NativeMethodInfoPtr_InternalValidateEndElement_Private_Object_XmlSchemaInfo_Object_0;

		// Token: 0x04001EDB RID: 7899
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSchemaLocations_Private_Void_String_String_0;

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElementContext_Private_Object_XmlQualifiedName_byref_Boolean_0;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeMethodInfoPtr_GetSubstitutionGroupHead_Private_XmlSchemaElement_XmlQualifiedName_0;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_String_byref_XmlSchemaSimpleType_0;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAtomicValue_Private_Object_Object_byref_XmlSchemaSimpleType_0;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Private_String_SchemaDeclBase_0;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr_SaveTextValue_Private_Void_Object_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_XmlQualifiedName_Object_0;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeMethodInfoPtr_CheckXsiTypeAndNil_Private_SchemaElementDecl_SchemaElementDecl_String_String_byref_Boolean_0;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeMethodInfoPtr_ThrowDeclNotFoundWarningOrError_Private_Void_Boolean_0;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeMethodInfoPtr_CheckElementProperties_Private_Void_0;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsXmlAttribute_Private_SchemaAttDef_XmlQualifiedName_0;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeMethodInfoPtr_AddXmlNamespaceSchema_Private_Void_0;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr_CheckMixedValueConstraint_Internal_Object_String_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr_RecompileSchemaSet_Internal_Void_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_Boolean_0;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeMethodInfoPtr_CheckAttributeValue_Private_Object_Object_SchemaAttDef_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeMethodInfoPtr_CheckElementValue_Private_Object_String_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeMethodInfoPtr_CheckTokenizedTypes_Private_Void_XmlSchemaDatatype_Object_Boolean_0;

		// Token: 0x04001EF2 RID: 7922
		private static readonly IntPtr NativeMethodInfoPtr_FindId_Private_Object_String_0;

		// Token: 0x04001EF3 RID: 7923
		private static readonly IntPtr NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0;

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessIdentityConstraints_Internal_get_Boolean_0;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeMethodInfoPtr_get_ReportValidationWarnings_Internal_get_Boolean_0;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessSchemaHints_Internal_get_Boolean_0;

		// Token: 0x04001EF8 RID: 7928
		private static readonly IntPtr NativeMethodInfoPtr_CheckStateTransition_Private_Void_ValidatorState_String_0;

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeMethodInfoPtr_ClearPSVI_Private_Void_0;

		// Token: 0x04001EFA RID: 7930
		private static readonly IntPtr NativeMethodInfoPtr_CheckRequiredAttributes_Private_Void_SchemaElementDecl_0;

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaElement_Private_XmlSchemaElement_0;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultAttributePrefix_Internal_String_String_0;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0;

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_XmlSchemaDatatype_0;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_Object_String_XmlSchemaDatatype_0;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeMethodInfoPtr_ElementValidationError_Internal_Static_Void_XmlQualifiedName_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0;

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidationError_Internal_Static_Void_ValidationState_ValidationEventHandler_Object_String_Int32_Int32_XmlSchemaSet_0;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeMethodInfoPtr_PrintExpectedElements_Internal_Static_String_ArrayList_Boolean_0;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeMethodInfoPtr_PrintNames_Private_Static_String_ArrayList_0;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeMethodInfoPtr_PrintNamesWithNS_Private_Static_Void_ArrayList_StringBuilder_0;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateAny_Private_Static_Void_StringBuilder_String_0;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeMethodInfoPtr_QNameString_Internal_Static_String_String_String_0;

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeMethodInfoPtr_BuildElementName_Internal_Static_String_XmlQualifiedName_0;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeMethodInfoPtr_BuildElementName_Internal_Static_String_String_String_0;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEntity_Private_Void_String_0;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_0;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_XmlSeverityType_0;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_Exception_0;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_0;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_XmlSeverityType_0;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaValidationException_XmlSeverityType_0;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Internal_Static_Void_ValidationEventHandler_Object_XmlSchemaValidationException_XmlSeverityType_0;
	}
}
