using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001F9 RID: 505
	public sealed class XsdBuilder : SchemaBuilder
	{
		// Token: 0x06002AE8 RID: 10984 RVA: 0x000C8440 File Offset: 0x000C6640
		// Note: this type is marked as 'beforefieldinit'.
		static XsdBuilder()
		{
			Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr);
			XsdBuilder.NativeFieldInfoPtr_SchemaElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaElement");
			XsdBuilder.NativeFieldInfoPtr_SchemaSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaSubelements");
			XsdBuilder.NativeFieldInfoPtr_AttributeSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeSubelements");
			XsdBuilder.NativeFieldInfoPtr_ElementSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ElementSubelements");
			XsdBuilder.NativeFieldInfoPtr_ComplexTypeSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexTypeSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentExtensionSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentRestrictionSubelements");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentSubelements");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentExtensionSubelements");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentRestrictionSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeRestrictionSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeListSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeListSubelements");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeUnionSubelements");
			XsdBuilder.NativeFieldInfoPtr_RedefineSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "RedefineSubelements");
			XsdBuilder.NativeFieldInfoPtr_AttributeGroupSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeGroupSubelements");
			XsdBuilder.NativeFieldInfoPtr_GroupSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "GroupSubelements");
			XsdBuilder.NativeFieldInfoPtr_AllSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AllSubelements");
			XsdBuilder.NativeFieldInfoPtr_ChoiceSequenceSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ChoiceSequenceSubelements");
			XsdBuilder.NativeFieldInfoPtr_IdentityConstraintSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "IdentityConstraintSubelements");
			XsdBuilder.NativeFieldInfoPtr_AnnotationSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnnotationSubelements");
			XsdBuilder.NativeFieldInfoPtr_AnnotatedSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnnotatedSubelements");
			XsdBuilder.NativeFieldInfoPtr_SchemaAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaAttributes");
			XsdBuilder.NativeFieldInfoPtr_AttributeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeAttributes");
			XsdBuilder.NativeFieldInfoPtr_ElementAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ElementAttributes");
			XsdBuilder.NativeFieldInfoPtr_ComplexTypeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexTypeAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentExtensionAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentRestrictionAttributes");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentAttributes");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentExtensionAttributes");
			XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentRestrictionAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeRestrictionAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeUnionAttributes");
			XsdBuilder.NativeFieldInfoPtr_SimpleTypeListAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeListAttributes");
			XsdBuilder.NativeFieldInfoPtr_AttributeGroupAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeGroupAttributes");
			XsdBuilder.NativeFieldInfoPtr_AttributeGroupRefAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeGroupRefAttributes");
			XsdBuilder.NativeFieldInfoPtr_GroupAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "GroupAttributes");
			XsdBuilder.NativeFieldInfoPtr_GroupRefAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "GroupRefAttributes");
			XsdBuilder.NativeFieldInfoPtr_ParticleAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ParticleAttributes");
			XsdBuilder.NativeFieldInfoPtr_AnyAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnyAttributes");
			XsdBuilder.NativeFieldInfoPtr_IdentityConstraintAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "IdentityConstraintAttributes");
			XsdBuilder.NativeFieldInfoPtr_SelectorAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SelectorAttributes");
			XsdBuilder.NativeFieldInfoPtr_FieldAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "FieldAttributes");
			XsdBuilder.NativeFieldInfoPtr_NotationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "NotationAttributes");
			XsdBuilder.NativeFieldInfoPtr_IncludeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "IncludeAttributes");
			XsdBuilder.NativeFieldInfoPtr_ImportAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ImportAttributes");
			XsdBuilder.NativeFieldInfoPtr_FacetAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "FacetAttributes");
			XsdBuilder.NativeFieldInfoPtr_AnyAttributeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnyAttributeAttributes");
			XsdBuilder.NativeFieldInfoPtr_DocumentationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "DocumentationAttributes");
			XsdBuilder.NativeFieldInfoPtr_AppinfoAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AppinfoAttributes");
			XsdBuilder.NativeFieldInfoPtr_RedefineAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "RedefineAttributes");
			XsdBuilder.NativeFieldInfoPtr_AnnotationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnnotationAttributes");
			XsdBuilder.NativeFieldInfoPtr_SchemaEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaEntries");
			XsdBuilder.NativeFieldInfoPtr_DerivationMethodValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "DerivationMethodValues");
			XsdBuilder.NativeFieldInfoPtr_DerivationMethodStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "DerivationMethodStrings");
			XsdBuilder.NativeFieldInfoPtr_FormStringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "FormStringValues");
			XsdBuilder.NativeFieldInfoPtr_UseStringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "UseStringValues");
			XsdBuilder.NativeFieldInfoPtr_ProcessContentsStringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ProcessContentsStringValues");
			XsdBuilder.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "reader");
			XsdBuilder.NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "positionInfo");
			XsdBuilder.NativeFieldInfoPtr_currentEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "currentEntry");
			XsdBuilder.NativeFieldInfoPtr_nextEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "nextEntry");
			XsdBuilder.NativeFieldInfoPtr_hasChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "hasChild");
			XsdBuilder.NativeFieldInfoPtr_stateHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "stateHistory");
			XsdBuilder.NativeFieldInfoPtr_containerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "containerStack");
			XsdBuilder.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "nameTable");
			XsdBuilder.NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "schemaNames");
			XsdBuilder.NativeFieldInfoPtr_namespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "namespaceManager");
			XsdBuilder.NativeFieldInfoPtr_canIncludeImport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "canIncludeImport");
			XsdBuilder.NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "schema");
			XsdBuilder.NativeFieldInfoPtr_xso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "xso");
			XsdBuilder.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "element");
			XsdBuilder.NativeFieldInfoPtr_anyElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "anyElement");
			XsdBuilder.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "attribute");
			XsdBuilder.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "anyAttribute");
			XsdBuilder.NativeFieldInfoPtr_complexType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexType");
			XsdBuilder.NativeFieldInfoPtr_simpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleType");
			XsdBuilder.NativeFieldInfoPtr_complexContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexContent");
			XsdBuilder.NativeFieldInfoPtr_complexContentExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexContentExtension");
			XsdBuilder.NativeFieldInfoPtr_complexContentRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexContentRestriction");
			XsdBuilder.NativeFieldInfoPtr_simpleContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleContent");
			XsdBuilder.NativeFieldInfoPtr_simpleContentExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleContentExtension");
			XsdBuilder.NativeFieldInfoPtr_simpleContentRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleContentRestriction");
			XsdBuilder.NativeFieldInfoPtr_simpleTypeUnion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleTypeUnion");
			XsdBuilder.NativeFieldInfoPtr_simpleTypeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleTypeList");
			XsdBuilder.NativeFieldInfoPtr_simpleTypeRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleTypeRestriction");
			XsdBuilder.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "group");
			XsdBuilder.NativeFieldInfoPtr_groupRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "groupRef");
			XsdBuilder.NativeFieldInfoPtr_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "all");
			XsdBuilder.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "choice");
			XsdBuilder.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "sequence");
			XsdBuilder.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "particle");
			XsdBuilder.NativeFieldInfoPtr_attributeGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "attributeGroup");
			XsdBuilder.NativeFieldInfoPtr_attributeGroupRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "attributeGroupRef");
			XsdBuilder.NativeFieldInfoPtr_notation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "notation");
			XsdBuilder.NativeFieldInfoPtr_identityConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "identityConstraint");
			XsdBuilder.NativeFieldInfoPtr_xpath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "xpath");
			XsdBuilder.NativeFieldInfoPtr_include = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "include");
			XsdBuilder.NativeFieldInfoPtr_import = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "import");
			XsdBuilder.NativeFieldInfoPtr_annotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "annotation");
			XsdBuilder.NativeFieldInfoPtr_appInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "appInfo");
			XsdBuilder.NativeFieldInfoPtr_documentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "documentation");
			XsdBuilder.NativeFieldInfoPtr_facet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "facet");
			XsdBuilder.NativeFieldInfoPtr_markup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "markup");
			XsdBuilder.NativeFieldInfoPtr_redefine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "redefine");
			XsdBuilder.NativeFieldInfoPtr_validationEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "validationEventHandler");
			XsdBuilder.NativeFieldInfoPtr_unhandledAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "unhandledAttributes");
			XsdBuilder.NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "namespaces");
			XsdBuilder.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_XmlSchema_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669564);
			XsdBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669565);
			XsdBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669566);
			XsdBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669567);
			XsdBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669568);
			XsdBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669569);
			XsdBuilder.NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669570);
			XsdBuilder.NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669571);
			XsdBuilder.NativeMethodInfoPtr_Push_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669572);
			XsdBuilder.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669573);
			XsdBuilder.NativeMethodInfoPtr_get_CurrentElement_Private_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669574);
			XsdBuilder.NativeMethodInfoPtr_get_ParentElement_Private_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669575);
			XsdBuilder.NativeMethodInfoPtr_get_ParentContainer_Private_get_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669576);
			XsdBuilder.NativeMethodInfoPtr_GetContainer_Private_XmlSchemaObject_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669577);
			XsdBuilder.NativeMethodInfoPtr_SetContainer_Private_Void_State_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669578);
			XsdBuilder.NativeMethodInfoPtr_BuildAnnotated_Id_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669579);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_AttributeFormDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669580);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_ElementFormDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669581);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_TargetNamespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669582);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_Version_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669583);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_FinalDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669584);
			XsdBuilder.NativeMethodInfoPtr_BuildSchema_BlockDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669585);
			XsdBuilder.NativeMethodInfoPtr_InitSchema_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669586);
			XsdBuilder.NativeMethodInfoPtr_InitInclude_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669587);
			XsdBuilder.NativeMethodInfoPtr_BuildInclude_SchemaLocation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669588);
			XsdBuilder.NativeMethodInfoPtr_InitImport_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669589);
			XsdBuilder.NativeMethodInfoPtr_BuildImport_Namespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669590);
			XsdBuilder.NativeMethodInfoPtr_BuildImport_SchemaLocation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669591);
			XsdBuilder.NativeMethodInfoPtr_InitRedefine_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669592);
			XsdBuilder.NativeMethodInfoPtr_BuildRedefine_SchemaLocation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669593);
			XsdBuilder.NativeMethodInfoPtr_EndRedefine_Private_Static_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669594);
			XsdBuilder.NativeMethodInfoPtr_InitAttribute_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669595);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Default_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669596);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Fixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669597);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Form_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669598);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Use_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669599);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669600);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669601);
			XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Type_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669602);
			XsdBuilder.NativeMethodInfoPtr_InitElement_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669603);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Abstract_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669604);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Block_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669605);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Default_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669606);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Form_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669607);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_SubstitutionGroup_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669608);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Final_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669609);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Fixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669610);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_MaxOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669611);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_MinOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669612);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669613);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Nillable_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669614);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669615);
			XsdBuilder.NativeMethodInfoPtr_BuildElement_Type_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669616);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleType_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669617);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleType_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669618);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleType_Final_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669619);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeUnion_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669620);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeUnion_MemberTypes_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669621);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeList_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669622);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeList_ItemType_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669623);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeRestriction_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669624);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeRestriction_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669625);
			XsdBuilder.NativeMethodInfoPtr_InitComplexType_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669626);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Abstract_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669627);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Block_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669628);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Final_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669629);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Mixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669630);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669631);
			XsdBuilder.NativeMethodInfoPtr_InitComplexContent_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669632);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexContent_Mixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669633);
			XsdBuilder.NativeMethodInfoPtr_InitComplexContentExtension_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669634);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexContentExtension_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669635);
			XsdBuilder.NativeMethodInfoPtr_InitComplexContentRestriction_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669636);
			XsdBuilder.NativeMethodInfoPtr_BuildComplexContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669637);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleContent_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669638);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleContentExtension_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669639);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleContentExtension_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669640);
			XsdBuilder.NativeMethodInfoPtr_InitSimpleContentRestriction_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669641);
			XsdBuilder.NativeMethodInfoPtr_BuildSimpleContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669642);
			XsdBuilder.NativeMethodInfoPtr_InitAttributeGroup_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669643);
			XsdBuilder.NativeMethodInfoPtr_BuildAttributeGroup_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669644);
			XsdBuilder.NativeMethodInfoPtr_InitAttributeGroupRef_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669645);
			XsdBuilder.NativeMethodInfoPtr_BuildAttributeGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669646);
			XsdBuilder.NativeMethodInfoPtr_InitAnyAttribute_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669647);
			XsdBuilder.NativeMethodInfoPtr_BuildAnyAttribute_Namespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669648);
			XsdBuilder.NativeMethodInfoPtr_BuildAnyAttribute_ProcessContents_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669649);
			XsdBuilder.NativeMethodInfoPtr_InitGroup_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669650);
			XsdBuilder.NativeMethodInfoPtr_BuildGroup_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669651);
			XsdBuilder.NativeMethodInfoPtr_InitGroupRef_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669652);
			XsdBuilder.NativeMethodInfoPtr_BuildParticle_MaxOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669653);
			XsdBuilder.NativeMethodInfoPtr_BuildParticle_MinOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669654);
			XsdBuilder.NativeMethodInfoPtr_BuildGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669655);
			XsdBuilder.NativeMethodInfoPtr_InitAll_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669656);
			XsdBuilder.NativeMethodInfoPtr_InitChoice_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669657);
			XsdBuilder.NativeMethodInfoPtr_InitSequence_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669658);
			XsdBuilder.NativeMethodInfoPtr_InitAny_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669659);
			XsdBuilder.NativeMethodInfoPtr_BuildAny_Namespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669660);
			XsdBuilder.NativeMethodInfoPtr_BuildAny_ProcessContents_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669661);
			XsdBuilder.NativeMethodInfoPtr_InitNotation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669662);
			XsdBuilder.NativeMethodInfoPtr_BuildNotation_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669663);
			XsdBuilder.NativeMethodInfoPtr_BuildNotation_Public_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669664);
			XsdBuilder.NativeMethodInfoPtr_BuildNotation_System_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669665);
			XsdBuilder.NativeMethodInfoPtr_InitFacet_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669666);
			XsdBuilder.NativeMethodInfoPtr_BuildFacet_Fixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669667);
			XsdBuilder.NativeMethodInfoPtr_BuildFacet_Value_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669668);
			XsdBuilder.NativeMethodInfoPtr_InitIdentityConstraint_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669669);
			XsdBuilder.NativeMethodInfoPtr_BuildIdentityConstraint_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669670);
			XsdBuilder.NativeMethodInfoPtr_BuildIdentityConstraint_Refer_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669671);
			XsdBuilder.NativeMethodInfoPtr_InitSelector_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669672);
			XsdBuilder.NativeMethodInfoPtr_BuildSelector_XPath_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669673);
			XsdBuilder.NativeMethodInfoPtr_InitField_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669674);
			XsdBuilder.NativeMethodInfoPtr_BuildField_XPath_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669675);
			XsdBuilder.NativeMethodInfoPtr_InitAnnotation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669676);
			XsdBuilder.NativeMethodInfoPtr_InitAppinfo_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669677);
			XsdBuilder.NativeMethodInfoPtr_BuildAppinfo_Source_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669678);
			XsdBuilder.NativeMethodInfoPtr_EndAppinfo_Private_Static_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669679);
			XsdBuilder.NativeMethodInfoPtr_InitDocumentation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669680);
			XsdBuilder.NativeMethodInfoPtr_BuildDocumentation_Source_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669681);
			XsdBuilder.NativeMethodInfoPtr_BuildDocumentation_XmlLang_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669682);
			XsdBuilder.NativeMethodInfoPtr_EndDocumentation_Private_Static_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669683);
			XsdBuilder.NativeMethodInfoPtr_AddAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669684);
			XsdBuilder.NativeMethodInfoPtr_AddParticle_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669685);
			XsdBuilder.NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669686);
			XsdBuilder.NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669687);
			XsdBuilder.NativeMethodInfoPtr_SetMinOccurs_Private_Void_XmlSchemaParticle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669688);
			XsdBuilder.NativeMethodInfoPtr_SetMaxOccurs_Private_Void_XmlSchemaParticle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669689);
			XsdBuilder.NativeMethodInfoPtr_ParseBoolean_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669690);
			XsdBuilder.NativeMethodInfoPtr_ParseEnum_Private_Int32_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669691);
			XsdBuilder.NativeMethodInfoPtr_ParseQName_Private_XmlQualifiedName_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669692);
			XsdBuilder.NativeMethodInfoPtr_ParseBlockFinalEnum_Private_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669693);
			XsdBuilder.NativeMethodInfoPtr_ParseUriReference_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669694);
			XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669695);
			XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669696);
			XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669697);
			XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669698);
			XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669699);
			XsdBuilder.NativeMethodInfoPtr_RecordPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100669700);
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000C97D0 File Offset: 0x000C79D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422912, XrefRangeEnd = 422952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdBuilder(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curmgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventhandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_XmlSchema_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000C9878 File Offset: 0x000C7A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422952, XrefRangeEnd = 422960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ProcessElement(string prefix, string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000C98EC File Offset: 0x000C7AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422960, XrefRangeEnd = 422977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessAttribute(string prefix, string name, string ns, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x000C9968 File Offset: 0x000C7B68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 422977, RefRangeEnd = 422979, XrefRangeStart = 422977, XrefRangeEnd = 422977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsContentParsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x000C99A4 File Offset: 0x000C7BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422979, XrefRangeEnd = 422980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessMarkup(Il2CppReferenceArray<XmlNode> markup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(markup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000C99E8 File Offset: 0x000C7BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422980, XrefRangeEnd = 422983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessCData(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x000C9A2C File Offset: 0x000C7C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422983, XrefRangeEnd = 422995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x000C9A60 File Offset: 0x000C7C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422995, XrefRangeEnd = 423002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x000C9A94 File Offset: 0x000C7C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423002, XrefRangeEnd = 423037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_Push_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x000C9AC8 File Offset: 0x000C7CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423037, XrefRangeEnd = 423044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000C9AFC File Offset: 0x000C7CFC
		public unsafe SchemaNames.Token CurrentElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_get_CurrentElement_Private_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x000C9B38 File Offset: 0x000C7D38
		public unsafe SchemaNames.Token ParentElement
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 423047, RefRangeEnd = 423059, XrefRangeStart = 423044, XrefRangeEnd = 423047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_get_ParentElement_Private_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000C9B74 File Offset: 0x000C7D74
		public unsafe XmlSchemaObject ParentContainer
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 423061, RefRangeEnd = 423063, XrefRangeStart = 423059, XrefRangeEnd = 423061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_get_ParentContainer_Private_get_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
			}
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x000C9BB4 File Offset: 0x000C7DB4
		[CallerCount(0)]
		public unsafe XmlSchemaObject GetContainer(XsdBuilder.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_GetContainer_Private_XmlSchemaObject_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
			}
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x000C9C00 File Offset: 0x000C7E00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 423099, RefRangeEnd = 423101, XrefRangeStart = 423063, XrefRangeEnd = 423099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContainer(XsdBuilder.State state, Object container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SetContainer_Private_Void_State_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x000C9C50 File Offset: 0x000C7E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423101, XrefRangeEnd = 423102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAnnotated_Id(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAnnotated_Id_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x000C9C98 File Offset: 0x000C7E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423102, XrefRangeEnd = 423109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_AttributeFormDefault_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000C9CE0 File Offset: 0x000C7EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423109, XrefRangeEnd = 423116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_ElementFormDefault_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x000C9D28 File Offset: 0x000C7F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423116, XrefRangeEnd = 423118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSchema_TargetNamespace(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_TargetNamespace_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x000C9D70 File Offset: 0x000C7F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423118, XrefRangeEnd = 423120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSchema_Version(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_Version_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x000C9DB8 File Offset: 0x000C7FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423120, XrefRangeEnd = 423123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSchema_FinalDefault(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_FinalDefault_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x000C9E00 File Offset: 0x000C8000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423123, XrefRangeEnd = 423126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSchema_BlockDefault(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSchema_BlockDefault_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000C9E48 File Offset: 0x000C8048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423126, XrefRangeEnd = 423128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSchema(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSchema_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000C9E90 File Offset: 0x000C8090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423128, XrefRangeEnd = 423139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitInclude(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitInclude_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000C9ED8 File Offset: 0x000C80D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423139, XrefRangeEnd = 423141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildInclude_SchemaLocation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildInclude_SchemaLocation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000C9F20 File Offset: 0x000C8120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423141, XrefRangeEnd = 423152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitImport(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitImport_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000C9F68 File Offset: 0x000C8168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423152, XrefRangeEnd = 423154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildImport_Namespace(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildImport_Namespace_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000C9FB0 File Offset: 0x000C81B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423154, XrefRangeEnd = 423156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildImport_SchemaLocation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildImport_SchemaLocation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000C9FF8 File Offset: 0x000C81F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423156, XrefRangeEnd = 423167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitRedefine(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitRedefine_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x000CA040 File Offset: 0x000C8240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423167, XrefRangeEnd = 423169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildRedefine_SchemaLocation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x000CA088 File Offset: 0x000C8288
		[CallerCount(0)]
		public unsafe static void EndRedefine(XsdBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_EndRedefine_Private_Static_Void_XsdBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000CA0C0 File Offset: 0x000C82C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423169, XrefRangeEnd = 423177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAttribute(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAttribute_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000CA108 File Offset: 0x000C8308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423177, XrefRangeEnd = 423179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Default(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Default_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000CA150 File Offset: 0x000C8350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423179, XrefRangeEnd = 423181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Fixed(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Fixed_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x000CA198 File Offset: 0x000C8398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423181, XrefRangeEnd = 423188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Form(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Form_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x000CA1E0 File Offset: 0x000C83E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423188, XrefRangeEnd = 423195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Use(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Use_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x000CA228 File Offset: 0x000C8428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423195, XrefRangeEnd = 423200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Ref(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Ref_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x000CA270 File Offset: 0x000C8470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423200, XrefRangeEnd = 423202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x000CA2B8 File Offset: 0x000C84B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423202, XrefRangeEnd = 423207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttribute_Type(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttribute_Type_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x000CA300 File Offset: 0x000C8500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423207, XrefRangeEnd = 423215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitElement(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitElement_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x000CA348 File Offset: 0x000C8548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423215, XrefRangeEnd = 423220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Abstract(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Abstract_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x000CA390 File Offset: 0x000C8590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423220, XrefRangeEnd = 423223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Block(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Block_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x000CA3D8 File Offset: 0x000C85D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423223, XrefRangeEnd = 423225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Default(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Default_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x000CA420 File Offset: 0x000C8620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423225, XrefRangeEnd = 423232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Form(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Form_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000CA468 File Offset: 0x000C8668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423232, XrefRangeEnd = 423237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_SubstitutionGroup_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x000CA4B0 File Offset: 0x000C86B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423237, XrefRangeEnd = 423240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Final(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Final_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000CA4F8 File Offset: 0x000C86F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423240, XrefRangeEnd = 423242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Fixed(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Fixed_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000CA540 File Offset: 0x000C8740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423242, XrefRangeEnd = 423244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_MaxOccurs(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_MaxOccurs_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000CA588 File Offset: 0x000C8788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423244, XrefRangeEnd = 423246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_MinOccurs(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_MinOccurs_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x000CA5D0 File Offset: 0x000C87D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423246, XrefRangeEnd = 423248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000CA618 File Offset: 0x000C8818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423248, XrefRangeEnd = 423253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Nillable(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Nillable_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x000CA660 File Offset: 0x000C8860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423253, XrefRangeEnd = 423258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Ref(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Ref_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000CA6A8 File Offset: 0x000C88A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423258, XrefRangeEnd = 423263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildElement_Type(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildElement_Type_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000CA6F0 File Offset: 0x000C88F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423263, XrefRangeEnd = 423286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleType(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleType_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x000CA738 File Offset: 0x000C8938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423286, XrefRangeEnd = 423288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleType_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleType_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x000CA780 File Offset: 0x000C8980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423288, XrefRangeEnd = 423291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleType_Final(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleType_Final_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x000CA7C8 File Offset: 0x000C89C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423291, XrefRangeEnd = 423302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleTypeUnion(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeUnion_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x000CA810 File Offset: 0x000C8A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423302, XrefRangeEnd = 423310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeUnion_MemberTypes_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000CA858 File Offset: 0x000C8A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423310, XrefRangeEnd = 423321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleTypeList(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeList_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000CA8A0 File Offset: 0x000C8AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423321, XrefRangeEnd = 423326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeList_ItemType_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x000CA8E8 File Offset: 0x000C8AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423326, XrefRangeEnd = 423337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleTypeRestriction(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleTypeRestriction_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x000CA930 File Offset: 0x000C8B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423337, XrefRangeEnd = 423342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleTypeRestriction_Base_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000CA978 File Offset: 0x000C8B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423342, XrefRangeEnd = 423353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitComplexType(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitComplexType_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000CA9C0 File Offset: 0x000C8BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423353, XrefRangeEnd = 423358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexType_Abstract(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Abstract_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x000CAA08 File Offset: 0x000C8C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423358, XrefRangeEnd = 423361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexType_Block(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Block_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000CAA50 File Offset: 0x000C8C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423361, XrefRangeEnd = 423364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexType_Final(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Final_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x000CAA98 File Offset: 0x000C8C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423364, XrefRangeEnd = 423368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexType_Mixed(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Mixed_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x000CAAE0 File Offset: 0x000C8CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423368, XrefRangeEnd = 423370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexType_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexType_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000CAB28 File Offset: 0x000C8D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423370, XrefRangeEnd = 423385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitComplexContent(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitComplexContent_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x000CAB70 File Offset: 0x000C8D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423385, XrefRangeEnd = 423390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexContent_Mixed(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexContent_Mixed_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000CABB8 File Offset: 0x000C8DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423390, XrefRangeEnd = 423402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitComplexContentExtension(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitComplexContentExtension_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000CAC00 File Offset: 0x000C8E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423402, XrefRangeEnd = 423407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexContentExtension_Base(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexContentExtension_Base_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000CAC48 File Offset: 0x000C8E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423407, XrefRangeEnd = 423414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitComplexContentRestriction(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitComplexContentRestriction_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x000CAC90 File Offset: 0x000C8E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423414, XrefRangeEnd = 423419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildComplexContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000CACD8 File Offset: 0x000C8ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423419, XrefRangeEnd = 423434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleContent(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleContent_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x000CAD20 File Offset: 0x000C8F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423434, XrefRangeEnd = 423446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleContentExtension(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleContentExtension_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000CAD68 File Offset: 0x000C8F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423446, XrefRangeEnd = 423451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleContentExtension_Base_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x000CADB0 File Offset: 0x000C8FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423451, XrefRangeEnd = 423463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSimpleContentRestriction(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSimpleContentRestriction_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000CADF8 File Offset: 0x000C8FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423463, XrefRangeEnd = 423468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSimpleContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000CAE40 File Offset: 0x000C9040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423468, XrefRangeEnd = 423476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAttributeGroup(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAttributeGroup_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x000CAE88 File Offset: 0x000C9088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423476, XrefRangeEnd = 423478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttributeGroup_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttributeGroup_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000CAED0 File Offset: 0x000C90D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423478, XrefRangeEnd = 423486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAttributeGroupRef(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAttributeGroupRef_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x000CAF18 File Offset: 0x000C9118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423486, XrefRangeEnd = 423491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAttributeGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x000CAF60 File Offset: 0x000C9160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423491, XrefRangeEnd = 423505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAnyAttribute(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAnyAttribute_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x000CAFA8 File Offset: 0x000C91A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423505, XrefRangeEnd = 423507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAnyAttribute_Namespace_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x000CAFF0 File Offset: 0x000C91F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423507, XrefRangeEnd = 423514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAnyAttribute_ProcessContents_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000CB038 File Offset: 0x000C9238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423514, XrefRangeEnd = 423522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitGroup(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitGroup_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000CB080 File Offset: 0x000C9280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423522, XrefRangeEnd = 423524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildGroup_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildGroup_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x000CB0C8 File Offset: 0x000C92C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423524, XrefRangeEnd = 423533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitGroupRef(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitGroupRef_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000CB110 File Offset: 0x000C9310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423533, XrefRangeEnd = 423535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildParticle_MaxOccurs(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildParticle_MaxOccurs_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000CB158 File Offset: 0x000C9358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423535, XrefRangeEnd = 423537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildParticle_MinOccurs(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildParticle_MinOccurs_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000CB1A0 File Offset: 0x000C93A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423537, XrefRangeEnd = 423542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildGroupRef_Ref(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x000CB1E8 File Offset: 0x000C93E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423542, XrefRangeEnd = 423551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAll(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAll_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x000CB230 File Offset: 0x000C9430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423551, XrefRangeEnd = 423560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitChoice(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitChoice_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000CB278 File Offset: 0x000C9478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423560, XrefRangeEnd = 423569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSequence(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSequence_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000CB2C0 File Offset: 0x000C94C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423569, XrefRangeEnd = 423578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAny(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAny_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x000CB308 File Offset: 0x000C9508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423578, XrefRangeEnd = 423580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAny_Namespace(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAny_Namespace_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x000CB350 File Offset: 0x000C9550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423580, XrefRangeEnd = 423587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAny_ProcessContents(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAny_ProcessContents_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x000CB398 File Offset: 0x000C9598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423587, XrefRangeEnd = 423595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitNotation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitNotation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x000CB3E0 File Offset: 0x000C95E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423595, XrefRangeEnd = 423597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildNotation_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildNotation_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x000CB428 File Offset: 0x000C9628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423597, XrefRangeEnd = 423599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildNotation_Public(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildNotation_Public_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000CB470 File Offset: 0x000C9670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423599, XrefRangeEnd = 423601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildNotation_System(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildNotation_System_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000CB4B8 File Offset: 0x000C96B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423601, XrefRangeEnd = 423670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitFacet(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitFacet_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x000CB500 File Offset: 0x000C9700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423670, XrefRangeEnd = 423674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildFacet_Fixed(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildFacet_Fixed_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x000CB548 File Offset: 0x000C9748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423674, XrefRangeEnd = 423676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildFacet_Value(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildFacet_Value_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x000CB590 File Offset: 0x000C9790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423676, XrefRangeEnd = 423699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitIdentityConstraint(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitIdentityConstraint_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x000CB5D8 File Offset: 0x000C97D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423699, XrefRangeEnd = 423701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildIdentityConstraint_Name(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildIdentityConstraint_Name_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x000CB620 File Offset: 0x000C9820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423701, XrefRangeEnd = 423714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildIdentityConstraint_Refer_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x000CB668 File Offset: 0x000C9868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423714, XrefRangeEnd = 423725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitSelector(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitSelector_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x000CB6B0 File Offset: 0x000C98B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423725, XrefRangeEnd = 423727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildSelector_XPath(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildSelector_XPath_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x000CB6F8 File Offset: 0x000C98F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423727, XrefRangeEnd = 423738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitField(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitField_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000CB740 File Offset: 0x000C9940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildField_XPath(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildField_XPath_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000CB788 File Offset: 0x000C9988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423738, XrefRangeEnd = 423751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAnnotation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAnnotation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x000CB7D0 File Offset: 0x000C99D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423751, XrefRangeEnd = 423763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAppinfo(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitAppinfo_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x000CB818 File Offset: 0x000C9A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423763, XrefRangeEnd = 423768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildAppinfo_Source(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildAppinfo_Source_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x000CB860 File Offset: 0x000C9A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423768, XrefRangeEnd = 423770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndAppinfo(XsdBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_EndAppinfo_Private_Static_Void_XsdBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x000CB898 File Offset: 0x000C9A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423770, XrefRangeEnd = 423782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitDocumentation(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_InitDocumentation_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x000CB8E0 File Offset: 0x000C9AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423782, XrefRangeEnd = 423787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildDocumentation_Source(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildDocumentation_Source_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000CB928 File Offset: 0x000C9B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423787, XrefRangeEnd = 423791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildDocumentation_XmlLang(XsdBuilder builder, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_BuildDocumentation_XmlLang_Private_Static_Void_XsdBuilder_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x000CB970 File Offset: 0x000C9B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423791, XrefRangeEnd = 423793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndDocumentation(XsdBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_EndDocumentation_Private_Static_Void_XsdBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x000CB9A8 File Offset: 0x000C9BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 423800, RefRangeEnd = 423802, XrefRangeStart = 423793, XrefRangeEnd = 423800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttribute(XmlSchemaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_AddAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000CB9EC File Offset: 0x000C9BEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 423816, RefRangeEnd = 423821, XrefRangeStart = 423802, XrefRangeEnd = 423816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddParticle(XmlSchemaParticle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_AddParticle_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000CBA30 File Offset: 0x000C9C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 423830, RefRangeEnd = 423831, XrefRangeStart = 423821, XrefRangeEnd = 423830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNextState(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000CBA80 File Offset: 0x000C9C80
		[CallerCount(0)]
		public unsafe bool IsSkipableElement(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000CBAD0 File Offset: 0x000C9CD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 423835, RefRangeEnd = 423837, XrefRangeStart = 423831, XrefRangeEnd = 423835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMinOccurs(XmlSchemaParticle particle, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SetMinOccurs_Private_Void_XmlSchemaParticle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x000CBB24 File Offset: 0x000C9D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 423841, RefRangeEnd = 423843, XrefRangeStart = 423837, XrefRangeEnd = 423841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxOccurs(XmlSchemaParticle particle, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SetMaxOccurs_Private_Void_XmlSchemaParticle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000CBB78 File Offset: 0x000C9D78
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 423850, RefRangeEnd = 423856, XrefRangeStart = 423843, XrefRangeEnd = 423850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseBoolean(string value, string attributeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ParseBoolean_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000CBBD8 File Offset: 0x000C9DD8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 423860, RefRangeEnd = 423867, XrefRangeStart = 423856, XrefRangeEnd = 423860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseEnum(string value, string attributeName, Il2CppStringArray values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ParseEnum_Private_Int32_String_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000CBC4C File Offset: 0x000C9E4C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 423878, RefRangeEnd = 423892, XrefRangeStart = 423867, XrefRangeEnd = 423878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName ParseQName(string value, string attributeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ParseQName_Private_XmlQualifiedName_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x000CBCB0 File Offset: 0x000C9EB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 423915, RefRangeEnd = 423922, XrefRangeStart = 423892, XrefRangeEnd = 423915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseBlockFinalEnum(string value, string attributeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ParseBlockFinalEnum_Private_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000CBD10 File Offset: 0x000C9F10
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseUriReference(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_ParseUriReference_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x000CBD4C File Offset: 0x000C9F4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 423935, RefRangeEnd = 423938, XrefRangeStart = 423922, XrefRangeEnd = 423935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string arg0, string arg1, string arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x000CBDC8 File Offset: 0x000C9FC8
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 423944, RefRangeEnd = 423971, XrefRangeStart = 423938, XrefRangeEnd = 423944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x000CBE1C File Offset: 0x000CA01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 423977, RefRangeEnd = 423978, XrefRangeStart = 423971, XrefRangeEnd = 423977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x000CBE80 File Offset: 0x000CA080
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 423984, RefRangeEnd = 423990, XrefRangeStart = 423978, XrefRangeEnd = 423984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x000CBED0 File Offset: 0x000CA0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423990, XrefRangeEnd = 423991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000CBF14 File Offset: 0x000CA114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423991, XrefRangeEnd = 423994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.NativeMethodInfoPtr_RecordPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x00011AF5 File Offset: 0x0000FCF5
		public XsdBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x000CBF48 File Offset: 0x000CA148
		// (set) Token: 0x06002B74 RID: 11124 RVA: 0x00011AFE File Offset: 0x0000FCFE
		public unsafe static Il2CppStructArray<XsdBuilder.State> SchemaElement
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SchemaElement, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SchemaElement, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x000CBF70 File Offset: 0x000CA170
		// (set) Token: 0x06002B76 RID: 11126 RVA: 0x00011B10 File Offset: 0x0000FD10
		public unsafe static Il2CppStructArray<XsdBuilder.State> SchemaSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SchemaSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SchemaSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x000CBF98 File Offset: 0x000CA198
		// (set) Token: 0x06002B78 RID: 11128 RVA: 0x00011B22 File Offset: 0x0000FD22
		public unsafe static Il2CppStructArray<XsdBuilder.State> AttributeSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AttributeSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AttributeSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x000CBFC0 File Offset: 0x000CA1C0
		// (set) Token: 0x06002B7A RID: 11130 RVA: 0x00011B34 File Offset: 0x0000FD34
		public unsafe static Il2CppStructArray<XsdBuilder.State> ElementSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ElementSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ElementSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x000CBFE8 File Offset: 0x000CA1E8
		// (set) Token: 0x06002B7C RID: 11132 RVA: 0x00011B46 File Offset: 0x0000FD46
		public unsafe static Il2CppStructArray<XsdBuilder.State> ComplexTypeSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexTypeSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexTypeSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x000CC010 File Offset: 0x000CA210
		// (set) Token: 0x06002B7E RID: 11134 RVA: 0x00011B58 File Offset: 0x0000FD58
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleContentSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000CC038 File Offset: 0x000CA238
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x00011B6A File Offset: 0x0000FD6A
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleContentExtensionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000CC060 File Offset: 0x000CA260
		// (set) Token: 0x06002B82 RID: 11138 RVA: 0x00011B7C File Offset: 0x0000FD7C
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleContentRestrictionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000CC088 File Offset: 0x000CA288
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x00011B8E File Offset: 0x0000FD8E
		public unsafe static Il2CppStructArray<XsdBuilder.State> ComplexContentSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x000CC0B0 File Offset: 0x000CA2B0
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x00011BA0 File Offset: 0x0000FDA0
		public unsafe static Il2CppStructArray<XsdBuilder.State> ComplexContentExtensionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x000CC0D8 File Offset: 0x000CA2D8
		// (set) Token: 0x06002B88 RID: 11144 RVA: 0x00011BB2 File Offset: 0x0000FDB2
		public unsafe static Il2CppStructArray<XsdBuilder.State> ComplexContentRestrictionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000CC100 File Offset: 0x000CA300
		// (set) Token: 0x06002B8A RID: 11146 RVA: 0x00011BC4 File Offset: 0x0000FDC4
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleTypeSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002B8B RID: 11147 RVA: 0x000CC128 File Offset: 0x000CA328
		// (set) Token: 0x06002B8C RID: 11148 RVA: 0x00011BD6 File Offset: 0x0000FDD6
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleTypeRestrictionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x000CC150 File Offset: 0x000CA350
		// (set) Token: 0x06002B8E RID: 11150 RVA: 0x00011BE8 File Offset: 0x0000FDE8
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleTypeListSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeListSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeListSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002B8F RID: 11151 RVA: 0x000CC178 File Offset: 0x000CA378
		// (set) Token: 0x06002B90 RID: 11152 RVA: 0x00011BFA File Offset: 0x0000FDFA
		public unsafe static Il2CppStructArray<XsdBuilder.State> SimpleTypeUnionSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002B91 RID: 11153 RVA: 0x000CC1A0 File Offset: 0x000CA3A0
		// (set) Token: 0x06002B92 RID: 11154 RVA: 0x00011C0C File Offset: 0x0000FE0C
		public unsafe static Il2CppStructArray<XsdBuilder.State> RedefineSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_RedefineSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_RedefineSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x000CC1C8 File Offset: 0x000CA3C8
		// (set) Token: 0x06002B94 RID: 11156 RVA: 0x00011C1E File Offset: 0x0000FE1E
		public unsafe static Il2CppStructArray<XsdBuilder.State> AttributeGroupSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06002B95 RID: 11157 RVA: 0x000CC1F0 File Offset: 0x000CA3F0
		// (set) Token: 0x06002B96 RID: 11158 RVA: 0x00011C30 File Offset: 0x0000FE30
		public unsafe static Il2CppStructArray<XsdBuilder.State> GroupSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_GroupSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_GroupSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x000CC218 File Offset: 0x000CA418
		// (set) Token: 0x06002B98 RID: 11160 RVA: 0x00011C42 File Offset: 0x0000FE42
		public unsafe static Il2CppStructArray<XsdBuilder.State> AllSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AllSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AllSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x000CC240 File Offset: 0x000CA440
		// (set) Token: 0x06002B9A RID: 11162 RVA: 0x00011C54 File Offset: 0x0000FE54
		public unsafe static Il2CppStructArray<XsdBuilder.State> ChoiceSequenceSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ChoiceSequenceSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ChoiceSequenceSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x000CC268 File Offset: 0x000CA468
		// (set) Token: 0x06002B9C RID: 11164 RVA: 0x00011C66 File Offset: 0x0000FE66
		public unsafe static Il2CppStructArray<XsdBuilder.State> IdentityConstraintSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_IdentityConstraintSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_IdentityConstraintSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x000CC290 File Offset: 0x000CA490
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x00011C78 File Offset: 0x0000FE78
		public unsafe static Il2CppStructArray<XsdBuilder.State> AnnotationSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AnnotationSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AnnotationSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x000CC2B8 File Offset: 0x000CA4B8
		// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x00011C8A File Offset: 0x0000FE8A
		public unsafe static Il2CppStructArray<XsdBuilder.State> AnnotatedSubelements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AnnotatedSubelements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AnnotatedSubelements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x000CC2E0 File Offset: 0x000CA4E0
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x00011C9C File Offset: 0x0000FE9C
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SchemaAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SchemaAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SchemaAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x000CC308 File Offset: 0x000CA508
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x00011CAE File Offset: 0x0000FEAE
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AttributeAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AttributeAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AttributeAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x000CC330 File Offset: 0x000CA530
		// (set) Token: 0x06002BA6 RID: 11174 RVA: 0x00011CC0 File Offset: 0x0000FEC0
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ElementAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ElementAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ElementAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x000CC358 File Offset: 0x000CA558
		// (set) Token: 0x06002BA8 RID: 11176 RVA: 0x00011CD2 File Offset: 0x0000FED2
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ComplexTypeAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexTypeAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexTypeAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000CC380 File Offset: 0x000CA580
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleContentAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x000CC3A8 File Offset: 0x000CA5A8
		// (set) Token: 0x06002BAC RID: 11180 RVA: 0x00011CF6 File Offset: 0x0000FEF6
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleContentExtensionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentExtensionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x000CC3D0 File Offset: 0x000CA5D0
		// (set) Token: 0x06002BAE RID: 11182 RVA: 0x00011D08 File Offset: 0x0000FF08
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleContentRestrictionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleContentRestrictionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06002BAF RID: 11183 RVA: 0x000CC3F8 File Offset: 0x000CA5F8
		// (set) Token: 0x06002BB0 RID: 11184 RVA: 0x00011D1A File Offset: 0x0000FF1A
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ComplexContentAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x000CC420 File Offset: 0x000CA620
		// (set) Token: 0x06002BB2 RID: 11186 RVA: 0x00011D2C File Offset: 0x0000FF2C
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ComplexContentExtensionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentExtensionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x000CC448 File Offset: 0x000CA648
		// (set) Token: 0x06002BB4 RID: 11188 RVA: 0x00011D3E File Offset: 0x0000FF3E
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ComplexContentRestrictionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ComplexContentRestrictionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x000CC470 File Offset: 0x000CA670
		// (set) Token: 0x06002BB6 RID: 11190 RVA: 0x00011D50 File Offset: 0x0000FF50
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleTypeAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x000CC498 File Offset: 0x000CA698
		// (set) Token: 0x06002BB8 RID: 11192 RVA: 0x00011D62 File Offset: 0x0000FF62
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleTypeRestrictionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeRestrictionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x000CC4C0 File Offset: 0x000CA6C0
		// (set) Token: 0x06002BBA RID: 11194 RVA: 0x00011D74 File Offset: 0x0000FF74
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleTypeUnionAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeUnionAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x000CC4E8 File Offset: 0x000CA6E8
		// (set) Token: 0x06002BBC RID: 11196 RVA: 0x00011D86 File Offset: 0x0000FF86
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SimpleTypeListAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeListAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SimpleTypeListAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x000CC510 File Offset: 0x000CA710
		// (set) Token: 0x06002BBE RID: 11198 RVA: 0x00011D98 File Offset: 0x0000FF98
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AttributeGroupAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x000CC538 File Offset: 0x000CA738
		// (set) Token: 0x06002BC0 RID: 11200 RVA: 0x00011DAA File Offset: 0x0000FFAA
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AttributeGroupRefAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupRefAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AttributeGroupRefAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x000CC560 File Offset: 0x000CA760
		// (set) Token: 0x06002BC2 RID: 11202 RVA: 0x00011DBC File Offset: 0x0000FFBC
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> GroupAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_GroupAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_GroupAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x000CC588 File Offset: 0x000CA788
		// (set) Token: 0x06002BC4 RID: 11204 RVA: 0x00011DCE File Offset: 0x0000FFCE
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> GroupRefAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_GroupRefAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_GroupRefAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x000CC5B0 File Offset: 0x000CA7B0
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x00011DE0 File Offset: 0x0000FFE0
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ParticleAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ParticleAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ParticleAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x000CC5D8 File Offset: 0x000CA7D8
		// (set) Token: 0x06002BC8 RID: 11208 RVA: 0x00011DF2 File Offset: 0x0000FFF2
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AnyAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AnyAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AnyAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x000CC600 File Offset: 0x000CA800
		// (set) Token: 0x06002BCA RID: 11210 RVA: 0x00011E04 File Offset: 0x00010004
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> IdentityConstraintAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_IdentityConstraintAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_IdentityConstraintAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x000CC628 File Offset: 0x000CA828
		// (set) Token: 0x06002BCC RID: 11212 RVA: 0x00011E16 File Offset: 0x00010016
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> SelectorAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SelectorAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SelectorAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x000CC650 File Offset: 0x000CA850
		// (set) Token: 0x06002BCE RID: 11214 RVA: 0x00011E28 File Offset: 0x00010028
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> FieldAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_FieldAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_FieldAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x000CC678 File Offset: 0x000CA878
		// (set) Token: 0x06002BD0 RID: 11216 RVA: 0x00011E3A File Offset: 0x0001003A
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> NotationAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_NotationAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_NotationAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x000CC6A0 File Offset: 0x000CA8A0
		// (set) Token: 0x06002BD2 RID: 11218 RVA: 0x00011E4C File Offset: 0x0001004C
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> IncludeAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_IncludeAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_IncludeAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002BD3 RID: 11219 RVA: 0x000CC6C8 File Offset: 0x000CA8C8
		// (set) Token: 0x06002BD4 RID: 11220 RVA: 0x00011E5E File Offset: 0x0001005E
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> ImportAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ImportAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ImportAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x000CC6F0 File Offset: 0x000CA8F0
		// (set) Token: 0x06002BD6 RID: 11222 RVA: 0x00011E70 File Offset: 0x00010070
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> FacetAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_FacetAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_FacetAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x000CC718 File Offset: 0x000CA918
		// (set) Token: 0x06002BD8 RID: 11224 RVA: 0x00011E82 File Offset: 0x00010082
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AnyAttributeAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AnyAttributeAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AnyAttributeAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x000CC740 File Offset: 0x000CA940
		// (set) Token: 0x06002BDA RID: 11226 RVA: 0x00011E94 File Offset: 0x00010094
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> DocumentationAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_DocumentationAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_DocumentationAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002BDB RID: 11227 RVA: 0x000CC768 File Offset: 0x000CA968
		// (set) Token: 0x06002BDC RID: 11228 RVA: 0x00011EA6 File Offset: 0x000100A6
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AppinfoAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AppinfoAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AppinfoAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002BDD RID: 11229 RVA: 0x000CC790 File Offset: 0x000CA990
		// (set) Token: 0x06002BDE RID: 11230 RVA: 0x00011EB8 File Offset: 0x000100B8
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> RedefineAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_RedefineAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_RedefineAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x000CC7B8 File Offset: 0x000CA9B8
		// (set) Token: 0x06002BE0 RID: 11232 RVA: 0x00011ECA File Offset: 0x000100CA
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> AnnotationAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_AnnotationAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_AnnotationAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x000CC7E0 File Offset: 0x000CA9E0
		// (set) Token: 0x06002BE2 RID: 11234 RVA: 0x00011EDC File Offset: 0x000100DC
		public unsafe static Il2CppReferenceArray<XsdBuilder.XsdEntry> SchemaEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_SchemaEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_SchemaEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x000CC808 File Offset: 0x000CAA08
		// (set) Token: 0x06002BE4 RID: 11236 RVA: 0x00011EEE File Offset: 0x000100EE
		public unsafe static Il2CppStructArray<int> DerivationMethodValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_DerivationMethodValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_DerivationMethodValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06002BE5 RID: 11237 RVA: 0x000CC830 File Offset: 0x000CAA30
		// (set) Token: 0x06002BE6 RID: 11238 RVA: 0x00011F00 File Offset: 0x00010100
		public unsafe static Il2CppStringArray DerivationMethodStrings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_DerivationMethodStrings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_DerivationMethodStrings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x000CC858 File Offset: 0x000CAA58
		// (set) Token: 0x06002BE8 RID: 11240 RVA: 0x00011F12 File Offset: 0x00010112
		public unsafe static Il2CppStringArray FormStringValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_FormStringValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_FormStringValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002BE9 RID: 11241 RVA: 0x000CC880 File Offset: 0x000CAA80
		// (set) Token: 0x06002BEA RID: 11242 RVA: 0x00011F24 File Offset: 0x00010124
		public unsafe static Il2CppStringArray UseStringValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_UseStringValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_UseStringValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x000CC8A8 File Offset: 0x000CAAA8
		// (set) Token: 0x06002BEC RID: 11244 RVA: 0x00011F36 File Offset: 0x00010136
		public unsafe static Il2CppStringArray ProcessContentsStringValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdBuilder.NativeFieldInfoPtr_ProcessContentsStringValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdBuilder.NativeFieldInfoPtr_ProcessContentsStringValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x000CC8D0 File Offset: 0x000CAAD0
		// (set) Token: 0x06002BEE RID: 11246 RVA: 0x00011F48 File Offset: 0x00010148
		public unsafe XmlReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x000CC900 File Offset: 0x000CAB00
		// (set) Token: 0x06002BF0 RID: 11248 RVA: 0x00011F67 File Offset: 0x00010167
		public unsafe PositionInfo positionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_positionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_positionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x000CC930 File Offset: 0x000CAB30
		// (set) Token: 0x06002BF2 RID: 11250 RVA: 0x00011F86 File Offset: 0x00010186
		public unsafe XsdBuilder.XsdEntry currentEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_currentEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdBuilder.XsdEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_currentEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x000CC960 File Offset: 0x000CAB60
		// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x00011FA5 File Offset: 0x000101A5
		public unsafe XsdBuilder.XsdEntry nextEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_nextEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdBuilder.XsdEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_nextEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x000CC990 File Offset: 0x000CAB90
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x00011FC4 File Offset: 0x000101C4
		public unsafe bool hasChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_hasChild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_hasChild)) = value;
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x000CC9B8 File Offset: 0x000CABB8
		// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x00011FDF File Offset: 0x000101DF
		public unsafe HWStack stateHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_stateHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_stateHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x000CC9E8 File Offset: 0x000CABE8
		// (set) Token: 0x06002BFA RID: 11258 RVA: 0x00011FFE File Offset: 0x000101FE
		public unsafe Stack containerStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_containerStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_containerStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x000CCA18 File Offset: 0x000CAC18
		// (set) Token: 0x06002BFC RID: 11260 RVA: 0x0001201D File Offset: 0x0001021D
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x000CCA48 File Offset: 0x000CAC48
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x0001203C File Offset: 0x0001023C
		public unsafe SchemaNames schemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_schemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_schemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x000CCA78 File Offset: 0x000CAC78
		// (set) Token: 0x06002C00 RID: 11264 RVA: 0x0001205B File Offset: 0x0001025B
		public unsafe XmlNamespaceManager namespaceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_namespaceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_namespaceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x000CCAA8 File Offset: 0x000CACA8
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x0001207A File Offset: 0x0001027A
		public unsafe bool canIncludeImport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_canIncludeImport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_canIncludeImport)) = value;
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x000CCAD0 File Offset: 0x000CACD0
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x00012095 File Offset: 0x00010295
		public unsafe XmlSchema schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x000CCB00 File Offset: 0x000CAD00
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x000120B4 File Offset: 0x000102B4
		public unsafe XmlSchemaObject xso
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_xso);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_xso), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x000CCB30 File Offset: 0x000CAD30
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x000120D3 File Offset: 0x000102D3
		public unsafe XmlSchemaElement element
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_element);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_element), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x000CCB60 File Offset: 0x000CAD60
		// (set) Token: 0x06002C0A RID: 11274 RVA: 0x000120F2 File Offset: 0x000102F2
		public unsafe XmlSchemaAny anyElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_anyElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAny>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_anyElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x000CCB90 File Offset: 0x000CAD90
		// (set) Token: 0x06002C0C RID: 11276 RVA: 0x00012111 File Offset: 0x00010311
		public unsafe XmlSchemaAttribute attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x000CCBC0 File Offset: 0x000CADC0
		// (set) Token: 0x06002C0E RID: 11278 RVA: 0x00012130 File Offset: 0x00010330
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x000CCBF0 File Offset: 0x000CADF0
		// (set) Token: 0x06002C10 RID: 11280 RVA: 0x0001214F File Offset: 0x0001034F
		public unsafe XmlSchemaComplexType complexType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x000CCC20 File Offset: 0x000CAE20
		// (set) Token: 0x06002C12 RID: 11282 RVA: 0x0001216E File Offset: 0x0001036E
		public unsafe XmlSchemaSimpleType simpleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x000CCC50 File Offset: 0x000CAE50
		// (set) Token: 0x06002C14 RID: 11284 RVA: 0x0001218D File Offset: 0x0001038D
		public unsafe XmlSchemaComplexContent complexContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x000CCC80 File Offset: 0x000CAE80
		// (set) Token: 0x06002C16 RID: 11286 RVA: 0x000121AC File Offset: 0x000103AC
		public unsafe XmlSchemaComplexContentExtension complexContentExtension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContentExtension);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexContentExtension>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContentExtension), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x000CCCB0 File Offset: 0x000CAEB0
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x000121CB File Offset: 0x000103CB
		public unsafe XmlSchemaComplexContentRestriction complexContentRestriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContentRestriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexContentRestriction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_complexContentRestriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x000CCCE0 File Offset: 0x000CAEE0
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x000121EA File Offset: 0x000103EA
		public unsafe XmlSchemaSimpleContent simpleContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x000CCD10 File Offset: 0x000CAF10
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x00012209 File Offset: 0x00010409
		public unsafe XmlSchemaSimpleContentExtension simpleContentExtension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContentExtension);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleContentExtension>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContentExtension), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x000CCD40 File Offset: 0x000CAF40
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x00012228 File Offset: 0x00010428
		public unsafe XmlSchemaSimpleContentRestriction simpleContentRestriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContentRestriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleContentRestriction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleContentRestriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x000CCD70 File Offset: 0x000CAF70
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x00012247 File Offset: 0x00010447
		public unsafe XmlSchemaSimpleTypeUnion simpleTypeUnion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeUnion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeUnion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeUnion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x000CCDA0 File Offset: 0x000CAFA0
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x00012266 File Offset: 0x00010466
		public unsafe XmlSchemaSimpleTypeList simpleTypeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x000CCDD0 File Offset: 0x000CAFD0
		// (set) Token: 0x06002C24 RID: 11300 RVA: 0x00012285 File Offset: 0x00010485
		public unsafe XmlSchemaSimpleTypeRestriction simpleTypeRestriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeRestriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeRestriction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_simpleTypeRestriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000CCE00 File Offset: 0x000CB000
		// (set) Token: 0x06002C26 RID: 11302 RVA: 0x000122A4 File Offset: 0x000104A4
		public unsafe XmlSchemaGroup group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002C27 RID: 11303 RVA: 0x000CCE30 File Offset: 0x000CB030
		// (set) Token: 0x06002C28 RID: 11304 RVA: 0x000122C3 File Offset: 0x000104C3
		public unsafe XmlSchemaGroupRef groupRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_groupRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroupRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_groupRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002C29 RID: 11305 RVA: 0x000CCE60 File Offset: 0x000CB060
		// (set) Token: 0x06002C2A RID: 11306 RVA: 0x000122E2 File Offset: 0x000104E2
		public unsafe XmlSchemaAll all
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_all);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAll>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_all), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002C2B RID: 11307 RVA: 0x000CCE90 File Offset: 0x000CB090
		// (set) Token: 0x06002C2C RID: 11308 RVA: 0x00012301 File Offset: 0x00010501
		public unsafe XmlSchemaChoice choice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_choice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x000CCEC0 File Offset: 0x000CB0C0
		// (set) Token: 0x06002C2E RID: 11310 RVA: 0x00012320 File Offset: 0x00010520
		public unsafe XmlSchemaSequence sequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_sequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x000CCEF0 File Offset: 0x000CB0F0
		// (set) Token: 0x06002C30 RID: 11312 RVA: 0x0001233F File Offset: 0x0001053F
		public unsafe XmlSchemaParticle particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x000CCF20 File Offset: 0x000CB120
		// (set) Token: 0x06002C32 RID: 11314 RVA: 0x0001235E File Offset: 0x0001055E
		public unsafe XmlSchemaAttributeGroup attributeGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attributeGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttributeGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attributeGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x000CCF50 File Offset: 0x000CB150
		// (set) Token: 0x06002C34 RID: 11316 RVA: 0x0001237D File Offset: 0x0001057D
		public unsafe XmlSchemaAttributeGroupRef attributeGroupRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attributeGroupRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttributeGroupRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_attributeGroupRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x000CCF80 File Offset: 0x000CB180
		// (set) Token: 0x06002C36 RID: 11318 RVA: 0x0001239C File Offset: 0x0001059C
		public unsafe XmlSchemaNotation notation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_notation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaNotation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_notation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x000CCFB0 File Offset: 0x000CB1B0
		// (set) Token: 0x06002C38 RID: 11320 RVA: 0x000123BB File Offset: 0x000105BB
		public unsafe XmlSchemaIdentityConstraint identityConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_identityConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaIdentityConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_identityConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x000CCFE0 File Offset: 0x000CB1E0
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x000123DA File Offset: 0x000105DA
		public unsafe XmlSchemaXPath xpath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_xpath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaXPath>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_xpath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x000CD010 File Offset: 0x000CB210
		// (set) Token: 0x06002C3C RID: 11324 RVA: 0x000123F9 File Offset: 0x000105F9
		public unsafe XmlSchemaInclude include
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_include);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaInclude>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_include), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x000CD040 File Offset: 0x000CB240
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x00012418 File Offset: 0x00010618
		public unsafe XmlSchemaImport import
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_import);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaImport>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_import), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x000CD070 File Offset: 0x000CB270
		// (set) Token: 0x06002C40 RID: 11328 RVA: 0x00012437 File Offset: 0x00010637
		public unsafe XmlSchemaAnnotation annotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_annotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnnotation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_annotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x000CD0A0 File Offset: 0x000CB2A0
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x00012456 File Offset: 0x00010656
		public unsafe XmlSchemaAppInfo appInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_appInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAppInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_appInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x000CD0D0 File Offset: 0x000CB2D0
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x00012475 File Offset: 0x00010675
		public unsafe XmlSchemaDocumentation documentation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_documentation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDocumentation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_documentation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x000CD100 File Offset: 0x000CB300
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x00012494 File Offset: 0x00010694
		public unsafe XmlSchemaFacet facet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_facet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaFacet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_facet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x000CD130 File Offset: 0x000CB330
		// (set) Token: 0x06002C48 RID: 11336 RVA: 0x000124B3 File Offset: 0x000106B3
		public unsafe Il2CppReferenceArray<XmlNode> markup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_markup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_markup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x000CD160 File Offset: 0x000CB360
		// (set) Token: 0x06002C4A RID: 11338 RVA: 0x000124D2 File Offset: 0x000106D2
		public unsafe XmlSchemaRedefine redefine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_redefine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaRedefine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_redefine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x000CD190 File Offset: 0x000CB390
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x000124F1 File Offset: 0x000106F1
		public unsafe ValidationEventHandler validationEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_validationEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_validationEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x000CD1C0 File Offset: 0x000CB3C0
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00012510 File Offset: 0x00010710
		public unsafe ArrayList unhandledAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_unhandledAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_unhandledAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x000CD1F0 File Offset: 0x000CB3F0
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x0001252F File Offset: 0x0001072F
		public unsafe Hashtable namespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_namespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.NativeFieldInfoPtr_namespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020C9 RID: 8393
		private static readonly IntPtr NativeFieldInfoPtr_SchemaElement;

		// Token: 0x040020CA RID: 8394
		private static readonly IntPtr NativeFieldInfoPtr_SchemaSubelements;

		// Token: 0x040020CB RID: 8395
		private static readonly IntPtr NativeFieldInfoPtr_AttributeSubelements;

		// Token: 0x040020CC RID: 8396
		private static readonly IntPtr NativeFieldInfoPtr_ElementSubelements;

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeFieldInfoPtr_ComplexTypeSubelements;

		// Token: 0x040020CE RID: 8398
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentSubelements;

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentExtensionSubelements;

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentRestrictionSubelements;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentSubelements;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentExtensionSubelements;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentRestrictionSubelements;

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeSubelements;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeRestrictionSubelements;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeListSubelements;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeUnionSubelements;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeFieldInfoPtr_RedefineSubelements;

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeFieldInfoPtr_AttributeGroupSubelements;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeFieldInfoPtr_GroupSubelements;

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeFieldInfoPtr_AllSubelements;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceSequenceSubelements;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeFieldInfoPtr_IdentityConstraintSubelements;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeFieldInfoPtr_AnnotationSubelements;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeFieldInfoPtr_AnnotatedSubelements;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeFieldInfoPtr_SchemaAttributes;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeFieldInfoPtr_AttributeAttributes;

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeFieldInfoPtr_ElementAttributes;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeFieldInfoPtr_ComplexTypeAttributes;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentAttributes;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentExtensionAttributes;

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeFieldInfoPtr_SimpleContentRestrictionAttributes;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentAttributes;

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentExtensionAttributes;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeFieldInfoPtr_ComplexContentRestrictionAttributes;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeAttributes;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeRestrictionAttributes;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeUnionAttributes;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypeListAttributes;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeFieldInfoPtr_AttributeGroupAttributes;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeFieldInfoPtr_AttributeGroupRefAttributes;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeFieldInfoPtr_GroupAttributes;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeFieldInfoPtr_GroupRefAttributes;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeFieldInfoPtr_ParticleAttributes;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeFieldInfoPtr_AnyAttributes;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeFieldInfoPtr_IdentityConstraintAttributes;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeFieldInfoPtr_SelectorAttributes;

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeFieldInfoPtr_FieldAttributes;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeFieldInfoPtr_NotationAttributes;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeFieldInfoPtr_IncludeAttributes;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeFieldInfoPtr_ImportAttributes;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeFieldInfoPtr_FacetAttributes;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeFieldInfoPtr_AnyAttributeAttributes;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeFieldInfoPtr_DocumentationAttributes;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeFieldInfoPtr_AppinfoAttributes;

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeFieldInfoPtr_RedefineAttributes;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeFieldInfoPtr_AnnotationAttributes;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeFieldInfoPtr_SchemaEntries;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeFieldInfoPtr_DerivationMethodValues;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeFieldInfoPtr_DerivationMethodStrings;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeFieldInfoPtr_FormStringValues;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeFieldInfoPtr_UseStringValues;

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeFieldInfoPtr_ProcessContentsStringValues;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeFieldInfoPtr_positionInfo;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeFieldInfoPtr_currentEntry;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeFieldInfoPtr_nextEntry;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeFieldInfoPtr_hasChild;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeFieldInfoPtr_stateHistory;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeFieldInfoPtr_containerStack;

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeFieldInfoPtr_schemaNames;

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeFieldInfoPtr_namespaceManager;

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeFieldInfoPtr_canIncludeImport;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeFieldInfoPtr_schema;

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeFieldInfoPtr_xso;

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeFieldInfoPtr_element;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeFieldInfoPtr_anyElement;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeFieldInfoPtr_complexType;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeFieldInfoPtr_simpleType;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeFieldInfoPtr_complexContent;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeFieldInfoPtr_complexContentExtension;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeFieldInfoPtr_complexContentRestriction;

		// Token: 0x0400211C RID: 8476
		private static readonly IntPtr NativeFieldInfoPtr_simpleContent;

		// Token: 0x0400211D RID: 8477
		private static readonly IntPtr NativeFieldInfoPtr_simpleContentExtension;

		// Token: 0x0400211E RID: 8478
		private static readonly IntPtr NativeFieldInfoPtr_simpleContentRestriction;

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeFieldInfoPtr_simpleTypeUnion;

		// Token: 0x04002120 RID: 8480
		private static readonly IntPtr NativeFieldInfoPtr_simpleTypeList;

		// Token: 0x04002121 RID: 8481
		private static readonly IntPtr NativeFieldInfoPtr_simpleTypeRestriction;

		// Token: 0x04002122 RID: 8482
		private static readonly IntPtr NativeFieldInfoPtr_group;

		// Token: 0x04002123 RID: 8483
		private static readonly IntPtr NativeFieldInfoPtr_groupRef;

		// Token: 0x04002124 RID: 8484
		private static readonly IntPtr NativeFieldInfoPtr_all;

		// Token: 0x04002125 RID: 8485
		private static readonly IntPtr NativeFieldInfoPtr_choice;

		// Token: 0x04002126 RID: 8486
		private static readonly IntPtr NativeFieldInfoPtr_sequence;

		// Token: 0x04002127 RID: 8487
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x04002128 RID: 8488
		private static readonly IntPtr NativeFieldInfoPtr_attributeGroup;

		// Token: 0x04002129 RID: 8489
		private static readonly IntPtr NativeFieldInfoPtr_attributeGroupRef;

		// Token: 0x0400212A RID: 8490
		private static readonly IntPtr NativeFieldInfoPtr_notation;

		// Token: 0x0400212B RID: 8491
		private static readonly IntPtr NativeFieldInfoPtr_identityConstraint;

		// Token: 0x0400212C RID: 8492
		private static readonly IntPtr NativeFieldInfoPtr_xpath;

		// Token: 0x0400212D RID: 8493
		private static readonly IntPtr NativeFieldInfoPtr_include;

		// Token: 0x0400212E RID: 8494
		private static readonly IntPtr NativeFieldInfoPtr_import;

		// Token: 0x0400212F RID: 8495
		private static readonly IntPtr NativeFieldInfoPtr_annotation;

		// Token: 0x04002130 RID: 8496
		private static readonly IntPtr NativeFieldInfoPtr_appInfo;

		// Token: 0x04002131 RID: 8497
		private static readonly IntPtr NativeFieldInfoPtr_documentation;

		// Token: 0x04002132 RID: 8498
		private static readonly IntPtr NativeFieldInfoPtr_facet;

		// Token: 0x04002133 RID: 8499
		private static readonly IntPtr NativeFieldInfoPtr_markup;

		// Token: 0x04002134 RID: 8500
		private static readonly IntPtr NativeFieldInfoPtr_redefine;

		// Token: 0x04002135 RID: 8501
		private static readonly IntPtr NativeFieldInfoPtr_validationEventHandler;

		// Token: 0x04002136 RID: 8502
		private static readonly IntPtr NativeFieldInfoPtr_unhandledAttributes;

		// Token: 0x04002137 RID: 8503
		private static readonly IntPtr NativeFieldInfoPtr_namespaces;

		// Token: 0x04002138 RID: 8504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_XmlSchema_XmlNameTable_SchemaNames_ValidationEventHandler_0;

		// Token: 0x04002139 RID: 8505
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0;

		// Token: 0x0400213A RID: 8506
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0;

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0;

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0;

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_0;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentElement_Private_get_Token_0;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentElement_Private_get_Token_0;

		// Token: 0x04002144 RID: 8516
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentContainer_Private_get_XmlSchemaObject_0;

		// Token: 0x04002145 RID: 8517
		private static readonly IntPtr NativeMethodInfoPtr_GetContainer_Private_XmlSchemaObject_State_0;

		// Token: 0x04002146 RID: 8518
		private static readonly IntPtr NativeMethodInfoPtr_SetContainer_Private_Void_State_Object_0;

		// Token: 0x04002147 RID: 8519
		private static readonly IntPtr NativeMethodInfoPtr_BuildAnnotated_Id_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002148 RID: 8520
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_AttributeFormDefault_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002149 RID: 8521
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_ElementFormDefault_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400214A RID: 8522
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_TargetNamespace_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_Version_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_FinalDefault_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_BlockDefault_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeMethodInfoPtr_InitSchema_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeMethodInfoPtr_InitInclude_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeMethodInfoPtr_BuildInclude_SchemaLocation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002151 RID: 8529
		private static readonly IntPtr NativeMethodInfoPtr_InitImport_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002152 RID: 8530
		private static readonly IntPtr NativeMethodInfoPtr_BuildImport_Namespace_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002153 RID: 8531
		private static readonly IntPtr NativeMethodInfoPtr_BuildImport_SchemaLocation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002154 RID: 8532
		private static readonly IntPtr NativeMethodInfoPtr_InitRedefine_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002155 RID: 8533
		private static readonly IntPtr NativeMethodInfoPtr_BuildRedefine_SchemaLocation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002156 RID: 8534
		private static readonly IntPtr NativeMethodInfoPtr_EndRedefine_Private_Static_Void_XsdBuilder_0;

		// Token: 0x04002157 RID: 8535
		private static readonly IntPtr NativeMethodInfoPtr_InitAttribute_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002158 RID: 8536
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Default_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002159 RID: 8537
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Fixed_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Form_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400215B RID: 8539
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Use_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Ref_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttribute_Type_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeMethodInfoPtr_InitElement_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Abstract_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Block_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002162 RID: 8546
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Default_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002163 RID: 8547
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Form_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002164 RID: 8548
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_SubstitutionGroup_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002165 RID: 8549
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Final_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002166 RID: 8550
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Fixed_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002167 RID: 8551
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_MaxOccurs_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_MinOccurs_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Nillable_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Ref_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeMethodInfoPtr_BuildElement_Type_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleType_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleType_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleType_Final_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleTypeUnion_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleTypeUnion_MemberTypes_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleTypeList_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleTypeList_ItemType_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleTypeRestriction_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleTypeRestriction_Base_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeMethodInfoPtr_InitComplexType_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002177 RID: 8567
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexType_Abstract_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002178 RID: 8568
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexType_Block_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002179 RID: 8569
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexType_Final_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400217A RID: 8570
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexType_Mixed_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400217B RID: 8571
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexType_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeMethodInfoPtr_InitComplexContent_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexContent_Mixed_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeMethodInfoPtr_InitComplexContentExtension_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexContentExtension_Base_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeMethodInfoPtr_InitComplexContentRestriction_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeMethodInfoPtr_BuildComplexContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleContent_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002183 RID: 8579
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleContentExtension_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002184 RID: 8580
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleContentExtension_Base_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002185 RID: 8581
		private static readonly IntPtr NativeMethodInfoPtr_InitSimpleContentRestriction_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002186 RID: 8582
		private static readonly IntPtr NativeMethodInfoPtr_BuildSimpleContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeMethodInfoPtr_InitAttributeGroup_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttributeGroup_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeMethodInfoPtr_InitAttributeGroupRef_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr_BuildAttributeGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr_InitAnyAttribute_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_BuildAnyAttribute_Namespace_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_BuildAnyAttribute_ProcessContents_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_InitGroup_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeMethodInfoPtr_BuildGroup_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeMethodInfoPtr_InitGroupRef_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeMethodInfoPtr_BuildParticle_MaxOccurs_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeMethodInfoPtr_BuildParticle_MinOccurs_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002193 RID: 8595
		private static readonly IntPtr NativeMethodInfoPtr_BuildGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002194 RID: 8596
		private static readonly IntPtr NativeMethodInfoPtr_InitAll_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002195 RID: 8597
		private static readonly IntPtr NativeMethodInfoPtr_InitChoice_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002196 RID: 8598
		private static readonly IntPtr NativeMethodInfoPtr_InitSequence_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002197 RID: 8599
		private static readonly IntPtr NativeMethodInfoPtr_InitAny_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002198 RID: 8600
		private static readonly IntPtr NativeMethodInfoPtr_BuildAny_Namespace_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x04002199 RID: 8601
		private static readonly IntPtr NativeMethodInfoPtr_BuildAny_ProcessContents_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400219A RID: 8602
		private static readonly IntPtr NativeMethodInfoPtr_InitNotation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400219B RID: 8603
		private static readonly IntPtr NativeMethodInfoPtr_BuildNotation_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeMethodInfoPtr_BuildNotation_Public_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeMethodInfoPtr_BuildNotation_System_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeMethodInfoPtr_InitFacet_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeMethodInfoPtr_BuildFacet_Fixed_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeMethodInfoPtr_BuildFacet_Value_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeMethodInfoPtr_InitIdentityConstraint_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021A2 RID: 8610
		private static readonly IntPtr NativeMethodInfoPtr_BuildIdentityConstraint_Name_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021A3 RID: 8611
		private static readonly IntPtr NativeMethodInfoPtr_BuildIdentityConstraint_Refer_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021A4 RID: 8612
		private static readonly IntPtr NativeMethodInfoPtr_InitSelector_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021A5 RID: 8613
		private static readonly IntPtr NativeMethodInfoPtr_BuildSelector_XPath_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021A6 RID: 8614
		private static readonly IntPtr NativeMethodInfoPtr_InitField_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021A7 RID: 8615
		private static readonly IntPtr NativeMethodInfoPtr_BuildField_XPath_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021A8 RID: 8616
		private static readonly IntPtr NativeMethodInfoPtr_InitAnnotation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeMethodInfoPtr_InitAppinfo_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeMethodInfoPtr_BuildAppinfo_Source_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeMethodInfoPtr_EndAppinfo_Private_Static_Void_XsdBuilder_0;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeMethodInfoPtr_InitDocumentation_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeMethodInfoPtr_BuildDocumentation_Source_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeMethodInfoPtr_BuildDocumentation_XmlLang_Private_Static_Void_XsdBuilder_String_0;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeMethodInfoPtr_EndDocumentation_Private_Static_Void_XsdBuilder_0;

		// Token: 0x040021B0 RID: 8624
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_Void_XmlSchemaObject_0;

		// Token: 0x040021B1 RID: 8625
		private static readonly IntPtr NativeMethodInfoPtr_AddParticle_Private_Void_XmlSchemaParticle_0;

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeMethodInfoPtr_SetMinOccurs_Private_Void_XmlSchemaParticle_String_0;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxOccurs_Private_Void_XmlSchemaParticle_String_0;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeMethodInfoPtr_ParseBoolean_Private_Boolean_String_String_0;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeMethodInfoPtr_ParseEnum_Private_Int32_String_String_Il2CppStringArray_0;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeMethodInfoPtr_ParseQName_Private_XmlQualifiedName_String_String_0;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeMethodInfoPtr_ParseBlockFinalEnum_Private_Int32_String_String_0;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeMethodInfoPtr_ParseUriReference_Private_Static_String_String_0;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_String_0;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeMethodInfoPtr_RecordPosition_Private_Void_0;

		// Token: 0x02000274 RID: 628
		public enum State
		{
			// Token: 0x0400276D RID: 10093
			Root,
			// Token: 0x0400276E RID: 10094
			Schema,
			// Token: 0x0400276F RID: 10095
			Annotation,
			// Token: 0x04002770 RID: 10096
			Include,
			// Token: 0x04002771 RID: 10097
			Import,
			// Token: 0x04002772 RID: 10098
			Element,
			// Token: 0x04002773 RID: 10099
			Attribute,
			// Token: 0x04002774 RID: 10100
			AttributeGroup,
			// Token: 0x04002775 RID: 10101
			AttributeGroupRef,
			// Token: 0x04002776 RID: 10102
			AnyAttribute,
			// Token: 0x04002777 RID: 10103
			Group,
			// Token: 0x04002778 RID: 10104
			GroupRef,
			// Token: 0x04002779 RID: 10105
			All,
			// Token: 0x0400277A RID: 10106
			Choice,
			// Token: 0x0400277B RID: 10107
			Sequence,
			// Token: 0x0400277C RID: 10108
			Any,
			// Token: 0x0400277D RID: 10109
			Notation,
			// Token: 0x0400277E RID: 10110
			SimpleType,
			// Token: 0x0400277F RID: 10111
			ComplexType,
			// Token: 0x04002780 RID: 10112
			ComplexContent,
			// Token: 0x04002781 RID: 10113
			ComplexContentRestriction,
			// Token: 0x04002782 RID: 10114
			ComplexContentExtension,
			// Token: 0x04002783 RID: 10115
			SimpleContent,
			// Token: 0x04002784 RID: 10116
			SimpleContentExtension,
			// Token: 0x04002785 RID: 10117
			SimpleContentRestriction,
			// Token: 0x04002786 RID: 10118
			SimpleTypeUnion,
			// Token: 0x04002787 RID: 10119
			SimpleTypeList,
			// Token: 0x04002788 RID: 10120
			SimpleTypeRestriction,
			// Token: 0x04002789 RID: 10121
			Unique,
			// Token: 0x0400278A RID: 10122
			Key,
			// Token: 0x0400278B RID: 10123
			KeyRef,
			// Token: 0x0400278C RID: 10124
			Selector,
			// Token: 0x0400278D RID: 10125
			Field,
			// Token: 0x0400278E RID: 10126
			MinExclusive,
			// Token: 0x0400278F RID: 10127
			MinInclusive,
			// Token: 0x04002790 RID: 10128
			MaxExclusive,
			// Token: 0x04002791 RID: 10129
			MaxInclusive,
			// Token: 0x04002792 RID: 10130
			TotalDigits,
			// Token: 0x04002793 RID: 10131
			FractionDigits,
			// Token: 0x04002794 RID: 10132
			Length,
			// Token: 0x04002795 RID: 10133
			MinLength,
			// Token: 0x04002796 RID: 10134
			MaxLength,
			// Token: 0x04002797 RID: 10135
			Enumeration,
			// Token: 0x04002798 RID: 10136
			Pattern,
			// Token: 0x04002799 RID: 10137
			WhiteSpace,
			// Token: 0x0400279A RID: 10138
			AppInfo,
			// Token: 0x0400279B RID: 10139
			Documentation,
			// Token: 0x0400279C RID: 10140
			Redefine
		}

		// Token: 0x02000275 RID: 629
		public sealed class XsdBuildFunction : MulticastDelegate
		{
			// Token: 0x0600327D RID: 12925 RVA: 0x00015A09 File Offset: 0x00013C09
			// Note: this type is marked as 'beforefieldinit'.
			static XsdBuildFunction()
			{
				Il2CppClassPointerStore<XsdBuilder.XsdBuildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdBuildFunction");
				XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdBuildFunction>.NativeClassPtr, 100669702);
				XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdBuildFunction>.NativeClassPtr, 100669703);
			}

			// Token: 0x0600327E RID: 12926 RVA: 0x000DFEB8 File Offset: 0x000DE0B8
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 408089, RefRangeEnd = 408094, XrefRangeStart = 408089, XrefRangeEnd = 408094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XsdBuildFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.XsdBuildFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600327F RID: 12927 RVA: 0x000DFF14 File Offset: 0x000DE114
			[CallerCount(0)]
			public unsafe void Invoke(XsdBuilder builder, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdBuildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003280 RID: 12928 RVA: 0x00015A47 File Offset: 0x00013C47
			public XsdBuildFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003281 RID: 12929 RVA: 0x00015A50 File Offset: 0x00013C50
			public static implicit operator XsdBuilder.XsdBuildFunction(Action<XsdBuilder, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<XsdBuilder.XsdBuildFunction>(A_0);
			}

			// Token: 0x06003282 RID: 12930 RVA: 0x00015A58 File Offset: 0x00013C58
			public static XsdBuilder.XsdBuildFunction operator +(XsdBuilder.XsdBuildFunction A_0, XsdBuilder.XsdBuildFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XsdBuilder.XsdBuildFunction>();
			}

			// Token: 0x06003283 RID: 12931 RVA: 0x00015A66 File Offset: 0x00013C66
			public static XsdBuilder.XsdBuildFunction operator -(XsdBuilder.XsdBuildFunction A_0, XsdBuilder.XsdBuildFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XsdBuilder.XsdBuildFunction>();
				}
				return delegate2;
			}

			// Token: 0x0400279D RID: 10141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400279E RID: 10142
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0;
		}

		// Token: 0x02000276 RID: 630
		public sealed class XsdInitFunction : MulticastDelegate
		{
			// Token: 0x06003284 RID: 12932 RVA: 0x00015A77 File Offset: 0x00013C77
			// Note: this type is marked as 'beforefieldinit'.
			static XsdInitFunction()
			{
				Il2CppClassPointerStore<XsdBuilder.XsdInitFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdInitFunction");
				XsdBuilder.XsdInitFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdInitFunction>.NativeClassPtr, 100669704);
				XsdBuilder.XsdInitFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdInitFunction>.NativeClassPtr, 100669705);
			}

			// Token: 0x06003285 RID: 12933 RVA: 0x000DFF68 File Offset: 0x000DE168
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 408089, RefRangeEnd = 408094, XrefRangeStart = 408089, XrefRangeEnd = 408094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XsdInitFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.XsdInitFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdInitFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003286 RID: 12934 RVA: 0x000DFFC4 File Offset: 0x000DE1C4
			[CallerCount(0)]
			public unsafe void Invoke(XsdBuilder builder, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdInitFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003287 RID: 12935 RVA: 0x00015AB5 File Offset: 0x00013CB5
			public XsdInitFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003288 RID: 12936 RVA: 0x00015ABE File Offset: 0x00013CBE
			public static implicit operator XsdBuilder.XsdInitFunction(Action<XsdBuilder, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<XsdBuilder.XsdInitFunction>(A_0);
			}

			// Token: 0x06003289 RID: 12937 RVA: 0x00015AC6 File Offset: 0x00013CC6
			public static XsdBuilder.XsdInitFunction operator +(XsdBuilder.XsdInitFunction A_0, XsdBuilder.XsdInitFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XsdBuilder.XsdInitFunction>();
			}

			// Token: 0x0600328A RID: 12938 RVA: 0x00015AD4 File Offset: 0x00013CD4
			public static XsdBuilder.XsdInitFunction operator -(XsdBuilder.XsdInitFunction A_0, XsdBuilder.XsdInitFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XsdBuilder.XsdInitFunction>();
				}
				return delegate2;
			}

			// Token: 0x0400279F RID: 10143
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040027A0 RID: 10144
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0;
		}

		// Token: 0x02000277 RID: 631
		public sealed class XsdEndChildFunction : MulticastDelegate
		{
			// Token: 0x0600328B RID: 12939 RVA: 0x00015AE5 File Offset: 0x00013CE5
			// Note: this type is marked as 'beforefieldinit'.
			static XsdEndChildFunction()
			{
				Il2CppClassPointerStore<XsdBuilder.XsdEndChildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdEndChildFunction");
				XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdEndChildFunction>.NativeClassPtr, 100669706);
				XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdEndChildFunction>.NativeClassPtr, 100669707);
			}

			// Token: 0x0600328C RID: 12940 RVA: 0x000E0018 File Offset: 0x000DE218
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XsdEndChildFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.XsdEndChildFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600328D RID: 12941 RVA: 0x000E0074 File Offset: 0x000DE274
			[CallerCount(0)]
			public unsafe void Invoke(XsdBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdEndChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600328E RID: 12942 RVA: 0x00015B23 File Offset: 0x00013D23
			public XsdEndChildFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600328F RID: 12943 RVA: 0x00015B2C File Offset: 0x00013D2C
			public static implicit operator XsdBuilder.XsdEndChildFunction(Action<XsdBuilder> A_0)
			{
				return DelegateSupport.ConvertDelegate<XsdBuilder.XsdEndChildFunction>(A_0);
			}

			// Token: 0x06003290 RID: 12944 RVA: 0x00015B34 File Offset: 0x00013D34
			public static XsdBuilder.XsdEndChildFunction operator +(XsdBuilder.XsdEndChildFunction A_0, XsdBuilder.XsdEndChildFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XsdBuilder.XsdEndChildFunction>();
			}

			// Token: 0x06003291 RID: 12945 RVA: 0x00015B42 File Offset: 0x00013D42
			public static XsdBuilder.XsdEndChildFunction operator -(XsdBuilder.XsdEndChildFunction A_0, XsdBuilder.XsdEndChildFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XsdBuilder.XsdEndChildFunction>();
				}
				return delegate2;
			}

			// Token: 0x040027A1 RID: 10145
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040027A2 RID: 10146
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_0;
		}

		// Token: 0x02000278 RID: 632
		public sealed class XsdAttributeEntry : Object
		{
			// Token: 0x06003292 RID: 12946 RVA: 0x000E00B8 File Offset: 0x000DE2B8
			// Note: this type is marked as 'beforefieldinit'.
			static XsdAttributeEntry()
			{
				Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdAttributeEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr);
				XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr, "Attribute");
				XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_BuildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr, "BuildFunc");
				XsdBuilder.XsdAttributeEntry.NativeMethodInfoPtr__ctor_Public_Void_Token_XsdBuildFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr, 100669708);
			}

			// Token: 0x06003293 RID: 12947 RVA: 0x000E0120 File Offset: 0x000DE320
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422883, XrefRangeEnd = 422885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XsdAttributeEntry(SchemaNames.Token a, XsdBuilder.XsdBuildFunction build)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.XsdAttributeEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(build);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdAttributeEntry.NativeMethodInfoPtr__ctor_Public_Void_Token_XsdBuildFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003294 RID: 12948 RVA: 0x00015B53 File Offset: 0x00013D53
			public XsdAttributeEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010FC RID: 4348
			// (get) Token: 0x06003295 RID: 12949 RVA: 0x000E017C File Offset: 0x000DE37C
			// (set) Token: 0x06003296 RID: 12950 RVA: 0x00015B5C File Offset: 0x00013D5C
			public unsafe SchemaNames.Token Attribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_Attribute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_Attribute)) = value;
				}
			}

			// Token: 0x170010FD RID: 4349
			// (get) Token: 0x06003297 RID: 12951 RVA: 0x000E01A4 File Offset: 0x000DE3A4
			// (set) Token: 0x06003298 RID: 12952 RVA: 0x00015B77 File Offset: 0x00013D77
			public unsafe XsdBuilder.XsdBuildFunction BuildFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_BuildFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdBuilder.XsdBuildFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdAttributeEntry.NativeFieldInfoPtr_BuildFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027A3 RID: 10147
			private static readonly IntPtr NativeFieldInfoPtr_Attribute;

			// Token: 0x040027A4 RID: 10148
			private static readonly IntPtr NativeFieldInfoPtr_BuildFunc;

			// Token: 0x040027A5 RID: 10149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_XsdBuildFunction_0;
		}

		// Token: 0x02000279 RID: 633
		public sealed class XsdEntry : Object
		{
			// Token: 0x06003299 RID: 12953 RVA: 0x000E01D4 File Offset: 0x000DE3D4
			// Note: this type is marked as 'beforefieldinit'.
			static XsdEntry()
			{
				Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr);
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "Name");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "CurrentState");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_NextStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "NextStates");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "Attributes");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_InitFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "InitFunc");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_EndChildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "EndChildFunc");
				XsdBuilder.XsdEntry.NativeFieldInfoPtr_ParseContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, "ParseContent");
				XsdBuilder.XsdEntry.NativeMethodInfoPtr__ctor_Public_Void_Token_State_Il2CppStructArray_1_State_Il2CppReferenceArray_1_XsdAttributeEntry_XsdInitFunction_XsdEndChildFunction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr, 100669709);
			}

			// Token: 0x0600329A RID: 12954 RVA: 0x000E02A0 File Offset: 0x000DE4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422893, XrefRangeEnd = 422898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XsdEntry(SchemaNames.Token n, XsdBuilder.State state, Il2CppStructArray<XsdBuilder.State> nextStates, Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.XsdEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextStates);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(init);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseContent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.XsdEntry.NativeMethodInfoPtr__ctor_Public_Void_Token_State_Il2CppStructArray_1_State_Il2CppReferenceArray_1_XsdAttributeEntry_XsdInitFunction_XsdEndChildFunction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600329B RID: 12955 RVA: 0x00015B96 File Offset: 0x00013D96
			public XsdEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010FE RID: 4350
			// (get) Token: 0x0600329C RID: 12956 RVA: 0x000E0350 File Offset: 0x000DE550
			// (set) Token: 0x0600329D RID: 12957 RVA: 0x00015B9F File Offset: 0x00013D9F
			public unsafe SchemaNames.Token Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_Name);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_Name)) = value;
				}
			}

			// Token: 0x170010FF RID: 4351
			// (get) Token: 0x0600329E RID: 12958 RVA: 0x000E0378 File Offset: 0x000DE578
			// (set) Token: 0x0600329F RID: 12959 RVA: 0x00015BBA File Offset: 0x00013DBA
			public unsafe XsdBuilder.State CurrentState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_CurrentState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_CurrentState)) = value;
				}
			}

			// Token: 0x17001100 RID: 4352
			// (get) Token: 0x060032A0 RID: 12960 RVA: 0x000E03A0 File Offset: 0x000DE5A0
			// (set) Token: 0x060032A1 RID: 12961 RVA: 0x00015BD5 File Offset: 0x00013DD5
			public unsafe Il2CppStructArray<XsdBuilder.State> NextStates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_NextStates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XsdBuilder.State>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_NextStates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001101 RID: 4353
			// (get) Token: 0x060032A2 RID: 12962 RVA: 0x000E03D0 File Offset: 0x000DE5D0
			// (set) Token: 0x060032A3 RID: 12963 RVA: 0x00015BF4 File Offset: 0x00013DF4
			public unsafe Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry> Attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_Attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdBuilder.XsdAttributeEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001102 RID: 4354
			// (get) Token: 0x060032A4 RID: 12964 RVA: 0x000E0400 File Offset: 0x000DE600
			// (set) Token: 0x060032A5 RID: 12965 RVA: 0x00015C13 File Offset: 0x00013E13
			public unsafe XsdBuilder.XsdInitFunction InitFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_InitFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdBuilder.XsdInitFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_InitFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001103 RID: 4355
			// (get) Token: 0x060032A6 RID: 12966 RVA: 0x000E0430 File Offset: 0x000DE630
			// (set) Token: 0x060032A7 RID: 12967 RVA: 0x00015C32 File Offset: 0x00013E32
			public unsafe XsdBuilder.XsdEndChildFunction EndChildFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_EndChildFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XsdBuilder.XsdEndChildFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_EndChildFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001104 RID: 4356
			// (get) Token: 0x060032A8 RID: 12968 RVA: 0x000E0460 File Offset: 0x000DE660
			// (set) Token: 0x060032A9 RID: 12969 RVA: 0x00015C51 File Offset: 0x00013E51
			public unsafe bool ParseContent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_ParseContent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.XsdEntry.NativeFieldInfoPtr_ParseContent)) = value;
				}
			}

			// Token: 0x040027A6 RID: 10150
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x040027A7 RID: 10151
			private static readonly IntPtr NativeFieldInfoPtr_CurrentState;

			// Token: 0x040027A8 RID: 10152
			private static readonly IntPtr NativeFieldInfoPtr_NextStates;

			// Token: 0x040027A9 RID: 10153
			private static readonly IntPtr NativeFieldInfoPtr_Attributes;

			// Token: 0x040027AA RID: 10154
			private static readonly IntPtr NativeFieldInfoPtr_InitFunc;

			// Token: 0x040027AB RID: 10155
			private static readonly IntPtr NativeFieldInfoPtr_EndChildFunc;

			// Token: 0x040027AC RID: 10156
			private static readonly IntPtr NativeFieldInfoPtr_ParseContent;

			// Token: 0x040027AD RID: 10157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_State_Il2CppStructArray_1_State_Il2CppReferenceArray_1_XsdAttributeEntry_XsdInitFunction_XsdEndChildFunction_Boolean_0;
		}

		// Token: 0x0200027A RID: 634
		public class BuilderNamespaceManager : XmlNamespaceManager
		{
			// Token: 0x060032AA RID: 12970 RVA: 0x000E0488 File Offset: 0x000DE688
			// Note: this type is marked as 'beforefieldinit'.
			static BuilderNamespaceManager()
			{
				Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "BuilderNamespaceManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr);
				XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_nsMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr, "nsMgr");
				XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr, "reader");
				XsdBuilder.BuilderNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlNamespaceManager_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr, 100669710);
				XsdBuilder.BuilderNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr, 100669711);
			}

			// Token: 0x060032AB RID: 12971 RVA: 0x000E0504 File Offset: 0x000DE704
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 422911, RefRangeEnd = 422912, XrefRangeStart = 422898, XrefRangeEnd = 422911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BuilderNamespaceManager(XmlNamespaceManager nsMgr, XmlReader reader)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder.BuilderNamespaceManager>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nsMgr);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdBuilder.BuilderNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlNamespaceManager_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032AC RID: 12972 RVA: 0x000E0564 File Offset: 0x000DE764
			[CallerCount(0)]
			public unsafe override string LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdBuilder.BuilderNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060032AD RID: 12973 RVA: 0x00015C6C File Offset: 0x00013E6C
			public BuilderNamespaceManager(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001105 RID: 4357
			// (get) Token: 0x060032AE RID: 12974 RVA: 0x000E05B8 File Offset: 0x000DE7B8
			// (set) Token: 0x060032AF RID: 12975 RVA: 0x00015C75 File Offset: 0x00013E75
			public unsafe XmlNamespaceManager nsMgr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_nsMgr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_nsMgr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001106 RID: 4358
			// (get) Token: 0x060032B0 RID: 12976 RVA: 0x000E05E8 File Offset: 0x000DE7E8
			// (set) Token: 0x060032B1 RID: 12977 RVA: 0x00015C94 File Offset: 0x00013E94
			public unsafe XmlReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdBuilder.BuilderNamespaceManager.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027AE RID: 10158
			private static readonly IntPtr NativeFieldInfoPtr_nsMgr;

			// Token: 0x040027AF RID: 10159
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x040027B0 RID: 10160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNamespaceManager_XmlReader_0;

			// Token: 0x040027B1 RID: 10161
			private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;
		}
	}
}
