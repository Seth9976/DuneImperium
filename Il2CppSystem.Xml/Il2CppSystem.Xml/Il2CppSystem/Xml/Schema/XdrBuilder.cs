using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000193 RID: 403
	public sealed class XdrBuilder : SchemaBuilder
	{
		// Token: 0x0600223D RID: 8765 RVA: 0x000A3FB8 File Offset: 0x000A21B8
		// Note: this type is marked as 'beforefieldinit'.
		static XdrBuilder()
		{
			Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XdrBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr);
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Root_Element");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Root_SubElements");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_ElementType_SubElements");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_AttributeType_SubElements");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Group_SubElements");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Root_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_ElementType_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_AttributeType_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Element_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Element_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Attribute_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Attribute_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Group_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_ElementDataType_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_AttributeDataType_Attributes");
			XdrBuilder.NativeFieldInfoPtr_S_SchemaEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_SchemaEntries");
			XdrBuilder.NativeFieldInfoPtr__SchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_SchemaInfo");
			XdrBuilder.NativeFieldInfoPtr__TargetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_TargetNamespace");
			XdrBuilder.NativeFieldInfoPtr__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_reader");
			XdrBuilder.NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "positionInfo");
			XdrBuilder.NativeFieldInfoPtr__contentValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_contentValidator");
			XdrBuilder.NativeFieldInfoPtr__CurState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_CurState");
			XdrBuilder.NativeFieldInfoPtr__NextState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_NextState");
			XdrBuilder.NativeFieldInfoPtr__StateHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_StateHistory");
			XdrBuilder.NativeFieldInfoPtr__GroupStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_GroupStack");
			XdrBuilder.NativeFieldInfoPtr__XdrName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_XdrName");
			XdrBuilder.NativeFieldInfoPtr__XdrPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_XdrPrefix");
			XdrBuilder.NativeFieldInfoPtr__ElementDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_ElementDef");
			XdrBuilder.NativeFieldInfoPtr__GroupDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_GroupDef");
			XdrBuilder.NativeFieldInfoPtr__AttributeDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_AttributeDef");
			XdrBuilder.NativeFieldInfoPtr__UndefinedAttributeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_UndefinedAttributeTypes");
			XdrBuilder.NativeFieldInfoPtr__BaseDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_BaseDecl");
			XdrBuilder.NativeFieldInfoPtr__NameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_NameTable");
			XdrBuilder.NativeFieldInfoPtr__SchemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_SchemaNames");
			XdrBuilder.NativeFieldInfoPtr__CurNsMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_CurNsMgr");
			XdrBuilder.NativeFieldInfoPtr__Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_Text");
			XdrBuilder.NativeFieldInfoPtr_validationEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "validationEventHandler");
			XdrBuilder.NativeFieldInfoPtr__UndeclaredElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_UndeclaredElements");
			XdrBuilder.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "xmlResolver");
			XdrBuilder.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_SchemaInfo_String_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668261);
			XdrBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668262);
			XdrBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668263);
			XdrBuilder.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668264);
			XdrBuilder.NativeMethodInfoPtr_LoadSchema_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668265);
			XdrBuilder.NativeMethodInfoPtr_IsXdrSchema_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668266);
			XdrBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668267);
			XdrBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668268);
			XdrBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668269);
			XdrBuilder.NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668270);
			XdrBuilder.NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668271);
			XdrBuilder.NativeMethodInfoPtr_Push_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668272);
			XdrBuilder.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668273);
			XdrBuilder.NativeMethodInfoPtr_PushGroupInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668274);
			XdrBuilder.NativeMethodInfoPtr_PopGroupInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668275);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitRoot_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668276);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildRoot_Name_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668277);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildRoot_ID_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668278);
			XdrBuilder.NativeMethodInfoPtr_XDR_BeginRoot_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668279);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndRoot_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668280);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitElementType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668281);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Name_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668282);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Content_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668283);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Model_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668284);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Order_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668285);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtType_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668286);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668287);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668288);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668289);
			XdrBuilder.NativeMethodInfoPtr_XDR_BeginElementType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668290);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndElementType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668291);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitAttributeType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668292);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Name_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668293);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Required_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668294);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Default_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668295);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtType_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668296);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668297);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668298);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668299);
			XdrBuilder.NativeMethodInfoPtr_XDR_BeginAttributeType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668300);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndAttributeType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668301);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitElement_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668302);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_Type_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668303);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668304);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668305);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndElement_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668306);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitAttribute_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668307);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Type_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668308);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Required_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668309);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Default_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668310);
			XdrBuilder.NativeMethodInfoPtr_XDR_BeginAttribute_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668311);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndAttribute_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668312);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitGroup_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668313);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_Order_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668314);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668315);
			XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668316);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndGroup_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668317);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitElementDtType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668318);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndElementDtType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668319);
			XdrBuilder.NativeMethodInfoPtr_XDR_InitAttributeDtType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668320);
			XdrBuilder.NativeMethodInfoPtr_XDR_EndAttributeDtType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668321);
			XdrBuilder.NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668322);
			XdrBuilder.NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668323);
			XdrBuilder.NativeMethodInfoPtr_IsSkipableAttribute_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668324);
			XdrBuilder.NativeMethodInfoPtr_GetOrder_Private_Int32_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668325);
			XdrBuilder.NativeMethodInfoPtr_AddOrder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668326);
			XdrBuilder.NativeMethodInfoPtr_IsYes_Private_Static_Boolean_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668327);
			XdrBuilder.NativeMethodInfoPtr_ParseMinOccurs_Private_Static_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668328);
			XdrBuilder.NativeMethodInfoPtr_ParseMaxOccurs_Private_Static_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668329);
			XdrBuilder.NativeMethodInfoPtr_HandleMinMax_Private_Static_Void_ParticleContentValidator_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668330);
			XdrBuilder.NativeMethodInfoPtr_ParseDtMaxLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668331);
			XdrBuilder.NativeMethodInfoPtr_ParseDtMinLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668332);
			XdrBuilder.NativeMethodInfoPtr_CompareMinMaxLength_Private_Static_Void_UInt32_UInt32_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668333);
			XdrBuilder.NativeMethodInfoPtr_ParseInteger_Private_Static_Boolean_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668334);
			XdrBuilder.NativeMethodInfoPtr_XDR_CheckAttributeDefault_Private_Void_DeclBaseInfo_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668335);
			XdrBuilder.NativeMethodInfoPtr_SetAttributePresence_Private_Void_SchemaAttDef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668336);
			XdrBuilder.NativeMethodInfoPtr_GetContent_Private_Int32_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668337);
			XdrBuilder.NativeMethodInfoPtr_GetModel_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668338);
			XdrBuilder.NativeMethodInfoPtr_CheckDatatype_Private_XmlSchemaDatatype_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668339);
			XdrBuilder.NativeMethodInfoPtr_CheckDefaultAttValue_Private_Void_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668340);
			XdrBuilder.NativeMethodInfoPtr_IsGlobal_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668341);
			XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668342);
			XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668343);
			XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668344);
			XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100668345);
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x000A4970 File Offset: 0x000A2B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 408216, RefRangeEnd = 408217, XrefRangeStart = 408168, XrefRangeEnd = 408216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrBuilder(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curmgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sinfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamspace);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventhandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_SchemaInfo_String_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x000A4A2C File Offset: 0x000A2C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408217, XrefRangeEnd = 408230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x000A4AA0 File Offset: 0x000A2CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408230, XrefRangeEnd = 408241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BA5 RID: 2981
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x000A4B1C File Offset: 0x000A2D1C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x000A4B60 File Offset: 0x000A2D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408241, XrefRangeEnd = 408273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadSchema(string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_LoadSchema_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x000A4BB0 File Offset: 0x000A2DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408273, XrefRangeEnd = 408279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsXdrSchema(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsXdrSchema_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x000A4BF4 File Offset: 0x000A2DF4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsContentParsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x000A4C30 File Offset: 0x000A2E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408279, XrefRangeEnd = 408286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessMarkup(Il2CppReferenceArray<XmlNode> markup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(markup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x000A4C74 File Offset: 0x000A2E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408286, XrefRangeEnd = 408291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessCData(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x000A4CB8 File Offset: 0x000A2EB8
		[CallerCount(0)]
		public unsafe override void StartChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x000A4CEC File Offset: 0x000A2EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408291, XrefRangeEnd = 408300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x000A4D20 File Offset: 0x000A2F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408300, XrefRangeEnd = 408304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_Push_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x000A4D54 File Offset: 0x000A2F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408304, XrefRangeEnd = 408313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x000A4D88 File Offset: 0x000A2F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408313, XrefRangeEnd = 408320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushGroupInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_PushGroupInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x000A4DBC File Offset: 0x000A2FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408320, XrefRangeEnd = 408329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopGroupInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_PopGroupInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x000A4DF0 File Offset: 0x000A2FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408329, XrefRangeEnd = 409174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitRoot(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitRoot_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x000A4E38 File Offset: 0x000A3038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409174, XrefRangeEnd = 409183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildRoot_Name(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildRoot_Name_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x000A4E94 File Offset: 0x000A3094
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildRoot_ID(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildRoot_ID_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x000A4EF0 File Offset: 0x000A30F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409183, XrefRangeEnd = 409194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BeginRoot(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BeginRoot_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x000A4F28 File Offset: 0x000A3128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409194, XrefRangeEnd = 409239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndRoot(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndRoot_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x000A4F60 File Offset: 0x000A3160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409239, XrefRangeEnd = 409254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitElementType(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitElementType_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x000A4FA8 File Offset: 0x000A31A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409254, XrefRangeEnd = 409270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_Name(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Name_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x000A5004 File Offset: 0x000A3204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409270, XrefRangeEnd = 409273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_Content(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Content_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x000A5060 File Offset: 0x000A3260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409273, XrefRangeEnd = 409279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_Model(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Model_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x000A50BC File Offset: 0x000A32BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409279, XrefRangeEnd = 409282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_Order(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_Order_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x000A5118 File Offset: 0x000A3318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409282, XrefRangeEnd = 409300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_DtType(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtType_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x000A5174 File Offset: 0x000A3374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409300, XrefRangeEnd = 409313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_DtValues(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x000A51D0 File Offset: 0x000A33D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409313, XrefRangeEnd = 409318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x000A522C File Offset: 0x000A342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409318, XrefRangeEnd = 409323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElementType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x000A5288 File Offset: 0x000A3488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409323, XrefRangeEnd = 409355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BeginElementType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BeginElementType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x000A52C0 File Offset: 0x000A34C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409355, XrefRangeEnd = 409402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndElementType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndElementType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x000A52F8 File Offset: 0x000A34F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409402, XrefRangeEnd = 409413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitAttributeType(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitAttributeType_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x000A5340 File Offset: 0x000A3540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409413, XrefRangeEnd = 409430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_Name(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Name_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x000A539C File Offset: 0x000A359C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409430, XrefRangeEnd = 409434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_Required(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Required_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x000A53F8 File Offset: 0x000A35F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409434, XrefRangeEnd = 409436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_Default(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_Default_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x000A5454 File Offset: 0x000A3654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409436, XrefRangeEnd = 409457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_DtType(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtType_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x000A54B0 File Offset: 0x000A36B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409457, XrefRangeEnd = 409470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x000A550C File Offset: 0x000A370C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409470, XrefRangeEnd = 409475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x000A5568 File Offset: 0x000A3768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409475, XrefRangeEnd = 409480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttributeType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x000A55C4 File Offset: 0x000A37C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409480, XrefRangeEnd = 409486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BeginAttributeType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BeginAttributeType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x000A55FC File Offset: 0x000A37FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409486, XrefRangeEnd = 409499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndAttributeType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndAttributeType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x000A5634 File Offset: 0x000A3834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409499, XrefRangeEnd = 409504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitElement(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitElement_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x000A567C File Offset: 0x000A387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409504, XrefRangeEnd = 409521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElement_Type(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_Type_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000A56D8 File Offset: 0x000A38D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409521, XrefRangeEnd = 409525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElement_MinOccurs(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x000A5734 File Offset: 0x000A3934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409525, XrefRangeEnd = 409529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildElement_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x000A5790 File Offset: 0x000A3990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409529, XrefRangeEnd = 409535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndElement(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndElement_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x000A57C8 File Offset: 0x000A39C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409535, XrefRangeEnd = 409541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitAttribute(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitAttribute_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x000A5810 File Offset: 0x000A3A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409541, XrefRangeEnd = 409550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttribute_Type(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Type_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x000A586C File Offset: 0x000A3A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409550, XrefRangeEnd = 409554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttribute_Required(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Required_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x000A58C8 File Offset: 0x000A3AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409554, XrefRangeEnd = 409556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildAttribute_Default(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildAttribute_Default_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x000A5924 File Offset: 0x000A3B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409556, XrefRangeEnd = 409603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BeginAttribute(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BeginAttribute_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x000A595C File Offset: 0x000A3B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409603, XrefRangeEnd = 409605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndAttribute(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndAttribute_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x000A5994 File Offset: 0x000A3B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409605, XrefRangeEnd = 409619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitGroup(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitGroup_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x000A59DC File Offset: 0x000A3BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409619, XrefRangeEnd = 409627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildGroup_Order(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_Order_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000A5A38 File Offset: 0x000A3C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409627, XrefRangeEnd = 409631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x000A5A94 File Offset: 0x000A3C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409631, XrefRangeEnd = 409635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, Object obj, string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_BuildGroup_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000A5AF0 File Offset: 0x000A3CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409635, XrefRangeEnd = 409662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndGroup(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndGroup_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000A5B28 File Offset: 0x000A3D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409662, XrefRangeEnd = 409672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitElementDtType(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitElementDtType_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x000A5B70 File Offset: 0x000A3D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409672, XrefRangeEnd = 409684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndElementDtType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndElementDtType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x000A5BA8 File Offset: 0x000A3DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409684, XrefRangeEnd = 409689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_InitAttributeDtType(XdrBuilder builder, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_InitAttributeDtType_Private_Static_Void_XdrBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x000A5BF0 File Offset: 0x000A3DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409689, XrefRangeEnd = 409700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XDR_EndAttributeDtType(XdrBuilder builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_EndAttributeDtType_Private_Static_Void_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x000A5C28 File Offset: 0x000A3E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409709, RefRangeEnd = 409710, XrefRangeStart = 409700, XrefRangeEnd = 409709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNextState(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x000A5C78 File Offset: 0x000A3E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409710, XrefRangeEnd = 409711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSkipableElement(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000A5CC8 File Offset: 0x000A3EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409711, XrefRangeEnd = 409714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSkipableAttribute(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsSkipableAttribute_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x000A5D18 File Offset: 0x000A3F18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409717, RefRangeEnd = 409719, XrefRangeStart = 409714, XrefRangeEnd = 409717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOrder(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_GetOrder_Private_Int32_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x000A5D68 File Offset: 0x000A3F68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409730, RefRangeEnd = 409732, XrefRangeStart = 409719, XrefRangeEnd = 409730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_AddOrder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x000A5D9C File Offset: 0x000A3F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409745, RefRangeEnd = 409747, XrefRangeStart = 409732, XrefRangeEnd = 409745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsYes(Object obj, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsYes_Private_Static_Boolean_Object_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x000A5DF0 File Offset: 0x000A3FF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409759, RefRangeEnd = 409761, XrefRangeStart = 409747, XrefRangeEnd = 409759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ParseMinOccurs(Object obj, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ParseMinOccurs_Private_Static_UInt32_Object_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x000A5E44 File Offset: 0x000A4044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409776, RefRangeEnd = 409778, XrefRangeStart = 409761, XrefRangeEnd = 409776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ParseMaxOccurs(Object obj, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ParseMaxOccurs_Private_Static_UInt32_Object_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x000A5E98 File Offset: 0x000A4098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409778, XrefRangeEnd = 409781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pContent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_HandleMinMax_Private_Static_Void_ParticleContentValidator_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x000A5EEC File Offset: 0x000A40EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409796, RefRangeEnd = 409798, XrefRangeStart = 409781, XrefRangeEnd = 409796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseDtMaxLength(ref uint cVal, Object obj, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cVal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ParseDtMaxLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x000A5F44 File Offset: 0x000A4144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409813, RefRangeEnd = 409815, XrefRangeStart = 409798, XrefRangeEnd = 409813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseDtMinLength(ref uint cVal, Object obj, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cVal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ParseDtMinLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x000A5F9C File Offset: 0x000A419C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409815, XrefRangeEnd = 409818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_CompareMinMaxLength_Private_Static_Void_UInt32_UInt32_XdrBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x000A5FF0 File Offset: 0x000A41F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409818, XrefRangeEnd = 409820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseInteger(string str, ref uint n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_ParseInteger_Private_Static_Boolean_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x000A6040 File Offset: 0x000A4240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409826, RefRangeEnd = 409828, XrefRangeStart = 409820, XrefRangeEnd = 409826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pAttdef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_XDR_CheckAttributeDefault_Private_Void_DeclBaseInfo_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x000A6094 File Offset: 0x000A4294
		[CallerCount(0)]
		public unsafe void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pAttdef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_SetAttributePresence_Private_Void_SchemaAttDef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000A60E4 File Offset: 0x000A42E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409831, RefRangeEnd = 409832, XrefRangeStart = 409828, XrefRangeEnd = 409831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetContent(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_GetContent_Private_Int32_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000A6134 File Offset: 0x000A4334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409832, XrefRangeEnd = 409835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetModel(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_GetModel_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000A6184 File Offset: 0x000A4384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409835, XrefRangeEnd = 409848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaDatatype CheckDatatype(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_CheckDatatype_Private_XmlSchemaDatatype_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x000A61D4 File Offset: 0x000A43D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409851, RefRangeEnd = 409853, XrefRangeStart = 409848, XrefRangeEnd = 409851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDefaultAttValue(SchemaAttDef attDef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attDef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_CheckDefaultAttValue_Private_Void_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x000A6218 File Offset: 0x000A4418
		[CallerCount(0)]
		public unsafe bool IsGlobal(int flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_IsGlobal_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000A6264 File Offset: 0x000A4464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409859, RefRangeEnd = 409860, XrefRangeStart = 409853, XrefRangeEnd = 409859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x000A62C8 File Offset: 0x000A44C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 409863, RefRangeEnd = 409866, XrefRangeStart = 409860, XrefRangeEnd = 409863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000A630C File Offset: 0x000A450C
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 409872, RefRangeEnd = 409910, XrefRangeStart = 409866, XrefRangeEnd = 409872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000A6360 File Offset: 0x000A4560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409919, RefRangeEnd = 409921, XrefRangeStart = 409910, XrefRangeEnd = 409919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x0000E8D7 File Offset: 0x0000CAD7
		public XdrBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x000A63B0 File Offset: 0x000A45B0
		// (set) Token: 0x06002295 RID: 8853 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		public unsafe static Il2CppStructArray<int> S_XDR_Root_Element
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Element, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Element, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x000A63D8 File Offset: 0x000A45D8
		// (set) Token: 0x06002297 RID: 8855 RVA: 0x0000E8F2 File Offset: 0x0000CAF2
		public unsafe static Il2CppStructArray<int> S_XDR_Root_SubElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_SubElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_SubElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x000A6400 File Offset: 0x000A4600
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x0000E904 File Offset: 0x0000CB04
		public unsafe static Il2CppStructArray<int> S_XDR_ElementType_SubElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_SubElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_SubElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x000A6428 File Offset: 0x000A4628
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x0000E916 File Offset: 0x0000CB16
		public unsafe static Il2CppStructArray<int> S_XDR_AttributeType_SubElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_SubElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_SubElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x000A6450 File Offset: 0x000A4650
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x0000E928 File Offset: 0x0000CB28
		public unsafe static Il2CppStructArray<int> S_XDR_Group_SubElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_SubElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_SubElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x000A6478 File Offset: 0x000A4678
		// (set) Token: 0x0600229F RID: 8863 RVA: 0x0000E93A File Offset: 0x0000CB3A
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_Root_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Root_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x000A64A0 File Offset: 0x000A46A0
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x0000E94C File Offset: 0x0000CB4C
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_ElementType_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementType_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x000A64C8 File Offset: 0x000A46C8
		// (set) Token: 0x060022A3 RID: 8867 RVA: 0x0000E95E File Offset: 0x0000CB5E
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_AttributeType_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeType_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x000A64F0 File Offset: 0x000A46F0
		// (set) Token: 0x060022A5 RID: 8869 RVA: 0x0000E970 File Offset: 0x0000CB70
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_Element_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Element_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Element_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x000A6518 File Offset: 0x000A4718
		// (set) Token: 0x060022A7 RID: 8871 RVA: 0x0000E982 File Offset: 0x0000CB82
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_Attribute_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Attribute_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Attribute_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x000A6540 File Offset: 0x000A4740
		// (set) Token: 0x060022A9 RID: 8873 RVA: 0x0000E994 File Offset: 0x0000CB94
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_Group_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_Group_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x000A6568 File Offset: 0x000A4768
		// (set) Token: 0x060022AB RID: 8875 RVA: 0x0000E9A6 File Offset: 0x0000CBA6
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_ElementDataType_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x000A6590 File Offset: 0x000A4790
		// (set) Token: 0x060022AD RID: 8877 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> S_XDR_AttributeDataType_Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x000A65B8 File Offset: 0x000A47B8
		// (set) Token: 0x060022AF RID: 8879 RVA: 0x0000E9CA File Offset: 0x0000CBCA
		public unsafe static Il2CppReferenceArray<XdrBuilder.XdrEntry> S_SchemaEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XdrBuilder.NativeFieldInfoPtr_S_SchemaEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XdrBuilder.NativeFieldInfoPtr_S_SchemaEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x000A65E0 File Offset: 0x000A47E0
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x0000E9DC File Offset: 0x0000CBDC
		public unsafe SchemaInfo _SchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__SchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__SchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x000A6610 File Offset: 0x000A4810
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x0000E9FB File Offset: 0x0000CBFB
		public unsafe string _TargetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__TargetNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__TargetNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x000A6638 File Offset: 0x000A4838
		// (set) Token: 0x060022B5 RID: 8885 RVA: 0x0000EA1A File Offset: 0x0000CC1A
		public unsafe XmlReader _reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x000A6668 File Offset: 0x000A4868
		// (set) Token: 0x060022B7 RID: 8887 RVA: 0x0000EA39 File Offset: 0x0000CC39
		public unsafe PositionInfo positionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_positionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_positionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x000A6698 File Offset: 0x000A4898
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x0000EA58 File Offset: 0x0000CC58
		public unsafe ParticleContentValidator _contentValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__contentValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleContentValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__contentValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x000A66C8 File Offset: 0x000A48C8
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x0000EA77 File Offset: 0x0000CC77
		public unsafe XdrBuilder.XdrEntry _CurState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__CurState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__CurState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x000A66F8 File Offset: 0x000A48F8
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x0000EA96 File Offset: 0x0000CC96
		public unsafe XdrBuilder.XdrEntry _NextState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__NextState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__NextState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x000A6728 File Offset: 0x000A4928
		// (set) Token: 0x060022BF RID: 8895 RVA: 0x0000EAB5 File Offset: 0x0000CCB5
		public unsafe HWStack _StateHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__StateHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__StateHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x000A6758 File Offset: 0x000A4958
		// (set) Token: 0x060022C1 RID: 8897 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		public unsafe HWStack _GroupStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__GroupStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__GroupStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x000A6788 File Offset: 0x000A4988
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x0000EAF3 File Offset: 0x0000CCF3
		public unsafe string _XdrName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__XdrName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__XdrName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x000A67B0 File Offset: 0x000A49B0
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x0000EB12 File Offset: 0x0000CD12
		public unsafe string _XdrPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__XdrPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__XdrPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x000A67D8 File Offset: 0x000A49D8
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x0000EB31 File Offset: 0x0000CD31
		public unsafe XdrBuilder.ElementContent _ElementDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__ElementDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.ElementContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__ElementDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x000A6808 File Offset: 0x000A4A08
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x0000EB50 File Offset: 0x0000CD50
		public unsafe XdrBuilder.GroupContent _GroupDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__GroupDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.GroupContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__GroupDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x000A6838 File Offset: 0x000A4A38
		// (set) Token: 0x060022CB RID: 8907 RVA: 0x0000EB6F File Offset: 0x0000CD6F
		public unsafe XdrBuilder.AttributeContent _AttributeDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__AttributeDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.AttributeContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__AttributeDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x000A6868 File Offset: 0x000A4A68
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x0000EB8E File Offset: 0x0000CD8E
		public unsafe XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__UndefinedAttributeTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.DeclBaseInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__UndefinedAttributeTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x000A6898 File Offset: 0x000A4A98
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x0000EBAD File Offset: 0x0000CDAD
		public unsafe XdrBuilder.DeclBaseInfo _BaseDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__BaseDecl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.DeclBaseInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__BaseDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x000A68C8 File Offset: 0x000A4AC8
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x0000EBCC File Offset: 0x0000CDCC
		public unsafe XmlNameTable _NameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__NameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__NameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x000A68F8 File Offset: 0x000A4AF8
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x0000EBEB File Offset: 0x0000CDEB
		public unsafe SchemaNames _SchemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__SchemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__SchemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x000A6928 File Offset: 0x000A4B28
		// (set) Token: 0x060022D5 RID: 8917 RVA: 0x0000EC0A File Offset: 0x0000CE0A
		public unsafe XmlNamespaceManager _CurNsMgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__CurNsMgr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__CurNsMgr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x000A6958 File Offset: 0x000A4B58
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x0000EC29 File Offset: 0x0000CE29
		public unsafe string _Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x000A6980 File Offset: 0x000A4B80
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x0000EC48 File Offset: 0x0000CE48
		public unsafe ValidationEventHandler validationEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_validationEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_validationEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x000A69B0 File Offset: 0x000A4BB0
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x0000EC67 File Offset: 0x0000CE67
		public unsafe Hashtable _UndeclaredElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__UndeclaredElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr__UndeclaredElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x000A69E0 File Offset: 0x000A4BE0
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x0000EC86 File Offset: 0x0000CE86
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Root_Element;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Root_SubElements;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_ElementType_SubElements;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_AttributeType_SubElements;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Group_SubElements;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Root_Attributes;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_ElementType_Attributes;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_AttributeType_Attributes;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Element_Attributes;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Attribute_Attributes;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_Group_Attributes;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeFieldInfoPtr_S_SchemaEntries;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeFieldInfoPtr__SchemaInfo;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeFieldInfoPtr__TargetNamespace;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeFieldInfoPtr__reader;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeFieldInfoPtr_positionInfo;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeFieldInfoPtr__contentValidator;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeFieldInfoPtr__CurState;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeFieldInfoPtr__NextState;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeFieldInfoPtr__StateHistory;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeFieldInfoPtr__GroupStack;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeFieldInfoPtr__XdrName;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeFieldInfoPtr__XdrPrefix;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeFieldInfoPtr__ElementDef;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeFieldInfoPtr__GroupDef;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeFieldInfoPtr__AttributeDef;

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeFieldInfoPtr__UndefinedAttributeTypes;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeFieldInfoPtr__BaseDecl;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeFieldInfoPtr__NameTable;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeFieldInfoPtr__SchemaNames;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeFieldInfoPtr__CurNsMgr;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeFieldInfoPtr__Text;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeFieldInfoPtr_validationEventHandler;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeFieldInfoPtr__UndeclaredElements;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_SchemaInfo_String_XmlNameTable_SchemaNames_ValidationEventHandler_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchema_Private_Boolean_String_0;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeMethodInfoPtr_IsXdrSchema_Internal_Static_Boolean_String_0;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_0;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr_PushGroupInfo_Private_Void_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr_PopGroupInfo_Private_Void_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitRoot_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildRoot_Name_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildRoot_ID_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BeginRoot_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndRoot_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitElementType_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Name_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Content_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Model_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Order_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtType_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BeginElementType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndElementType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitAttributeType_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_Name_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_Required_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_Default_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtType_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BeginAttributeType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndAttributeType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitElement_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElement_Type_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElement_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildElement_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndElement_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitAttribute_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttribute_Type_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttribute_Required_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildAttribute_Default_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BeginAttribute_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndAttribute_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitGroup_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildGroup_Order_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildGroup_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeMethodInfoPtr_XDR_BuildGroup_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndGroup_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitElementDtType_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndElementDtType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeMethodInfoPtr_XDR_InitAttributeDtType_Private_Static_Void_XdrBuilder_Object_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr_XDR_EndAttributeDtType_Private_Static_Void_XdrBuilder_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_IsSkipableAttribute_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr_GetOrder_Private_Int32_XmlQualifiedName_0;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeMethodInfoPtr_AddOrder_Private_Void_0;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeMethodInfoPtr_IsYes_Private_Static_Boolean_Object_XdrBuilder_0;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeMethodInfoPtr_ParseMinOccurs_Private_Static_UInt32_Object_XdrBuilder_0;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr_ParseMaxOccurs_Private_Static_UInt32_Object_XdrBuilder_0;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_HandleMinMax_Private_Static_Void_ParticleContentValidator_UInt32_UInt32_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtMaxLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtMinLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_CompareMinMaxLength_Private_Static_Void_UInt32_UInt32_XdrBuilder_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_ParseInteger_Private_Static_Boolean_String_byref_UInt32_0;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr_XDR_CheckAttributeDefault_Private_Void_DeclBaseInfo_SchemaAttDef_0;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributePresence_Private_Void_SchemaAttDef_Boolean_0;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_GetContent_Private_Int32_XmlQualifiedName_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_GetModel_Private_Boolean_XmlQualifiedName_0;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr_CheckDatatype_Private_XmlSchemaDatatype_String_0;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr_CheckDefaultAttValue_Private_Void_SchemaAttDef_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr_IsGlobal_Private_Boolean_Int32_0;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0;

		// Token: 0x02000260 RID: 608
		public sealed class DeclBaseInfo : Object
		{
			// Token: 0x060031A2 RID: 12706 RVA: 0x000DDD20 File Offset: 0x000DBF20
			// Note: this type is marked as 'beforefieldinit'.
			static DeclBaseInfo()
			{
				Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "DeclBaseInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr);
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Name");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Prefix");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_TypeName");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_TypePrefix");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Default");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Revises = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Revises");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MaxOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_MaxOccurs");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MinOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_MinOccurs");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Checking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Checking");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__ElementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_ElementDecl");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Attdef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Attdef");
				XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, "_Next");
				XdrBuilder.DeclBaseInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, 100668347);
				XdrBuilder.DeclBaseInfo.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr, 100668348);
			}

			// Token: 0x060031A3 RID: 12707 RVA: 0x000DDE64 File Offset: 0x000DC064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408057, XrefRangeEnd = 408059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeclBaseInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.DeclBaseInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.DeclBaseInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031A4 RID: 12708 RVA: 0x000DDEA0 File Offset: 0x000DC0A0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 408073, RefRangeEnd = 408077, XrefRangeStart = 408059, XrefRangeEnd = 408073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.DeclBaseInfo.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031A5 RID: 12709 RVA: 0x00015053 File Offset: 0x00013253
			public DeclBaseInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B2 RID: 4274
			// (get) Token: 0x060031A6 RID: 12710 RVA: 0x000DDED4 File Offset: 0x000DC0D4
			// (set) Token: 0x060031A7 RID: 12711 RVA: 0x0001505C File Offset: 0x0001325C
			public unsafe XmlQualifiedName _Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B3 RID: 4275
			// (get) Token: 0x060031A8 RID: 12712 RVA: 0x000DDF04 File Offset: 0x000DC104
			// (set) Token: 0x060031A9 RID: 12713 RVA: 0x0001507B File Offset: 0x0001327B
			public unsafe string _Prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170010B4 RID: 4276
			// (get) Token: 0x060031AA RID: 12714 RVA: 0x000DDF2C File Offset: 0x000DC12C
			// (set) Token: 0x060031AB RID: 12715 RVA: 0x0001509A File Offset: 0x0001329A
			public unsafe XmlQualifiedName _TypeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypeName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B5 RID: 4277
			// (get) Token: 0x060031AC RID: 12716 RVA: 0x000DDF5C File Offset: 0x000DC15C
			// (set) Token: 0x060031AD RID: 12717 RVA: 0x000150B9 File Offset: 0x000132B9
			public unsafe string _TypePrefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypePrefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__TypePrefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170010B6 RID: 4278
			// (get) Token: 0x060031AE RID: 12718 RVA: 0x000DDF84 File Offset: 0x000DC184
			// (set) Token: 0x060031AF RID: 12719 RVA: 0x000150D8 File Offset: 0x000132D8
			public unsafe Object _Default
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Default);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Default), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B7 RID: 4279
			// (get) Token: 0x060031B0 RID: 12720 RVA: 0x000DDFB4 File Offset: 0x000DC1B4
			// (set) Token: 0x060031B1 RID: 12721 RVA: 0x000150F7 File Offset: 0x000132F7
			public unsafe Object _Revises
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Revises);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Revises), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B8 RID: 4280
			// (get) Token: 0x060031B2 RID: 12722 RVA: 0x000DDFE4 File Offset: 0x000DC1E4
			// (set) Token: 0x060031B3 RID: 12723 RVA: 0x00015116 File Offset: 0x00013316
			public unsafe uint _MaxOccurs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MaxOccurs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MaxOccurs)) = value;
				}
			}

			// Token: 0x170010B9 RID: 4281
			// (get) Token: 0x060031B4 RID: 12724 RVA: 0x000DE00C File Offset: 0x000DC20C
			// (set) Token: 0x060031B5 RID: 12725 RVA: 0x00015131 File Offset: 0x00013331
			public unsafe uint _MinOccurs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MinOccurs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__MinOccurs)) = value;
				}
			}

			// Token: 0x170010BA RID: 4282
			// (get) Token: 0x060031B6 RID: 12726 RVA: 0x000DE034 File Offset: 0x000DC234
			// (set) Token: 0x060031B7 RID: 12727 RVA: 0x0001514C File Offset: 0x0001334C
			public unsafe bool _Checking
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Checking);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Checking)) = value;
				}
			}

			// Token: 0x170010BB RID: 4283
			// (get) Token: 0x060031B8 RID: 12728 RVA: 0x000DE05C File Offset: 0x000DC25C
			// (set) Token: 0x060031B9 RID: 12729 RVA: 0x00015167 File Offset: 0x00013367
			public unsafe SchemaElementDecl _ElementDecl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__ElementDecl);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__ElementDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010BC RID: 4284
			// (get) Token: 0x060031BA RID: 12730 RVA: 0x000DE08C File Offset: 0x000DC28C
			// (set) Token: 0x060031BB RID: 12731 RVA: 0x00015186 File Offset: 0x00013386
			public unsafe SchemaAttDef _Attdef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Attdef);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Attdef), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010BD RID: 4285
			// (get) Token: 0x060031BC RID: 12732 RVA: 0x000DE0BC File Offset: 0x000DC2BC
			// (set) Token: 0x060031BD RID: 12733 RVA: 0x000151A5 File Offset: 0x000133A5
			public unsafe XdrBuilder.DeclBaseInfo _Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.DeclBaseInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.DeclBaseInfo.NativeFieldInfoPtr__Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040026F0 RID: 9968
			private static readonly IntPtr NativeFieldInfoPtr__Name;

			// Token: 0x040026F1 RID: 9969
			private static readonly IntPtr NativeFieldInfoPtr__Prefix;

			// Token: 0x040026F2 RID: 9970
			private static readonly IntPtr NativeFieldInfoPtr__TypeName;

			// Token: 0x040026F3 RID: 9971
			private static readonly IntPtr NativeFieldInfoPtr__TypePrefix;

			// Token: 0x040026F4 RID: 9972
			private static readonly IntPtr NativeFieldInfoPtr__Default;

			// Token: 0x040026F5 RID: 9973
			private static readonly IntPtr NativeFieldInfoPtr__Revises;

			// Token: 0x040026F6 RID: 9974
			private static readonly IntPtr NativeFieldInfoPtr__MaxOccurs;

			// Token: 0x040026F7 RID: 9975
			private static readonly IntPtr NativeFieldInfoPtr__MinOccurs;

			// Token: 0x040026F8 RID: 9976
			private static readonly IntPtr NativeFieldInfoPtr__Checking;

			// Token: 0x040026F9 RID: 9977
			private static readonly IntPtr NativeFieldInfoPtr__ElementDecl;

			// Token: 0x040026FA RID: 9978
			private static readonly IntPtr NativeFieldInfoPtr__Attdef;

			// Token: 0x040026FB RID: 9979
			private static readonly IntPtr NativeFieldInfoPtr__Next;

			// Token: 0x040026FC RID: 9980
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040026FD RID: 9981
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;
		}

		// Token: 0x02000261 RID: 609
		public sealed class GroupContent : Object
		{
			// Token: 0x060031BE RID: 12734 RVA: 0x000DE0EC File Offset: 0x000DC2EC
			// Note: this type is marked as 'beforefieldinit'.
			static GroupContent()
			{
				Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "GroupContent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr);
				XdrBuilder.GroupContent.NativeFieldInfoPtr__MinVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, "_MinVal");
				XdrBuilder.GroupContent.NativeFieldInfoPtr__MaxVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, "_MaxVal");
				XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMaxAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, "_HasMaxAttr");
				XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMinAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, "_HasMinAttr");
				XdrBuilder.GroupContent.NativeFieldInfoPtr__Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, "_Order");
				XdrBuilder.GroupContent.NativeMethodInfoPtr_Copy_Internal_Static_Void_GroupContent_GroupContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, 100668349);
				XdrBuilder.GroupContent.NativeMethodInfoPtr_Copy_Internal_Static_GroupContent_GroupContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, 100668350);
				XdrBuilder.GroupContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr, 100668351);
			}

			// Token: 0x060031BF RID: 12735 RVA: 0x000DE1B8 File Offset: 0x000DC3B8
			[CallerCount(0)]
			public unsafe static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.GroupContent.NativeMethodInfoPtr_Copy_Internal_Static_Void_GroupContent_GroupContent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031C0 RID: 12736 RVA: 0x000DE200 File Offset: 0x000DC400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408077, XrefRangeEnd = 408081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static XdrBuilder.GroupContent Copy(XdrBuilder.GroupContent other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.GroupContent.NativeMethodInfoPtr_Copy_Internal_Static_GroupContent_GroupContent_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XdrBuilder.GroupContent>(intPtr3) : null;
				}
			}

			// Token: 0x060031C1 RID: 12737 RVA: 0x000DE244 File Offset: 0x000DC444
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GroupContent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.GroupContent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.GroupContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031C2 RID: 12738 RVA: 0x000151C4 File Offset: 0x000133C4
			public GroupContent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010BE RID: 4286
			// (get) Token: 0x060031C3 RID: 12739 RVA: 0x000DE280 File Offset: 0x000DC480
			// (set) Token: 0x060031C4 RID: 12740 RVA: 0x000151CD File Offset: 0x000133CD
			public unsafe uint _MinVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__MinVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__MinVal)) = value;
				}
			}

			// Token: 0x170010BF RID: 4287
			// (get) Token: 0x060031C5 RID: 12741 RVA: 0x000DE2A8 File Offset: 0x000DC4A8
			// (set) Token: 0x060031C6 RID: 12742 RVA: 0x000151E8 File Offset: 0x000133E8
			public unsafe uint _MaxVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__MaxVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__MaxVal)) = value;
				}
			}

			// Token: 0x170010C0 RID: 4288
			// (get) Token: 0x060031C7 RID: 12743 RVA: 0x000DE2D0 File Offset: 0x000DC4D0
			// (set) Token: 0x060031C8 RID: 12744 RVA: 0x00015203 File Offset: 0x00013403
			public unsafe bool _HasMaxAttr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMaxAttr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMaxAttr)) = value;
				}
			}

			// Token: 0x170010C1 RID: 4289
			// (get) Token: 0x060031C9 RID: 12745 RVA: 0x000DE2F8 File Offset: 0x000DC4F8
			// (set) Token: 0x060031CA RID: 12746 RVA: 0x0001521E File Offset: 0x0001341E
			public unsafe bool _HasMinAttr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMinAttr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__HasMinAttr)) = value;
				}
			}

			// Token: 0x170010C2 RID: 4290
			// (get) Token: 0x060031CB RID: 12747 RVA: 0x000DE320 File Offset: 0x000DC520
			// (set) Token: 0x060031CC RID: 12748 RVA: 0x00015239 File Offset: 0x00013439
			public unsafe int _Order
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__Order);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.GroupContent.NativeFieldInfoPtr__Order)) = value;
				}
			}

			// Token: 0x040026FE RID: 9982
			private static readonly IntPtr NativeFieldInfoPtr__MinVal;

			// Token: 0x040026FF RID: 9983
			private static readonly IntPtr NativeFieldInfoPtr__MaxVal;

			// Token: 0x04002700 RID: 9984
			private static readonly IntPtr NativeFieldInfoPtr__HasMaxAttr;

			// Token: 0x04002701 RID: 9985
			private static readonly IntPtr NativeFieldInfoPtr__HasMinAttr;

			// Token: 0x04002702 RID: 9986
			private static readonly IntPtr NativeFieldInfoPtr__Order;

			// Token: 0x04002703 RID: 9987
			private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_Static_Void_GroupContent_GroupContent_0;

			// Token: 0x04002704 RID: 9988
			private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_Static_GroupContent_GroupContent_0;

			// Token: 0x04002705 RID: 9989
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000262 RID: 610
		public sealed class ElementContent : Object
		{
			// Token: 0x060031CD RID: 12749 RVA: 0x000DE348 File Offset: 0x000DC548
			// Note: this type is marked as 'beforefieldinit'.
			static ElementContent()
			{
				Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "ElementContent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr);
				XdrBuilder.ElementContent.NativeFieldInfoPtr__ElementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_ElementDecl");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__ContentAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_ContentAttr");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__OrderAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_OrderAttr");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__MasterGroupRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_MasterGroupRequired");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__ExistTerminal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_ExistTerminal");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__AllowDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_AllowDataType");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__HasDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_HasDataType");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__HasType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_HasType");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__EnumerationRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_EnumerationRequired");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__MinVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_MinVal");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_MaxVal");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_MaxLength");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__MinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_MinLength");
				XdrBuilder.ElementContent.NativeFieldInfoPtr__AttDefList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, "_AttDefList");
				XdrBuilder.ElementContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr, 100668352);
			}

			// Token: 0x060031CE RID: 12750 RVA: 0x000DE4A0 File Offset: 0x000DC6A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ElementContent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.ElementContent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.ElementContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031CF RID: 12751 RVA: 0x00015254 File Offset: 0x00013454
			public ElementContent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010C3 RID: 4291
			// (get) Token: 0x060031D0 RID: 12752 RVA: 0x000DE4DC File Offset: 0x000DC6DC
			// (set) Token: 0x060031D1 RID: 12753 RVA: 0x0001525D File Offset: 0x0001345D
			public unsafe SchemaElementDecl _ElementDecl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ElementDecl);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ElementDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010C4 RID: 4292
			// (get) Token: 0x060031D2 RID: 12754 RVA: 0x000DE50C File Offset: 0x000DC70C
			// (set) Token: 0x060031D3 RID: 12755 RVA: 0x0001527C File Offset: 0x0001347C
			public unsafe int _ContentAttr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ContentAttr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ContentAttr)) = value;
				}
			}

			// Token: 0x170010C5 RID: 4293
			// (get) Token: 0x060031D4 RID: 12756 RVA: 0x000DE534 File Offset: 0x000DC734
			// (set) Token: 0x060031D5 RID: 12757 RVA: 0x00015297 File Offset: 0x00013497
			public unsafe int _OrderAttr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__OrderAttr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__OrderAttr)) = value;
				}
			}

			// Token: 0x170010C6 RID: 4294
			// (get) Token: 0x060031D6 RID: 12758 RVA: 0x000DE55C File Offset: 0x000DC75C
			// (set) Token: 0x060031D7 RID: 12759 RVA: 0x000152B2 File Offset: 0x000134B2
			public unsafe bool _MasterGroupRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MasterGroupRequired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MasterGroupRequired)) = value;
				}
			}

			// Token: 0x170010C7 RID: 4295
			// (get) Token: 0x060031D8 RID: 12760 RVA: 0x000DE584 File Offset: 0x000DC784
			// (set) Token: 0x060031D9 RID: 12761 RVA: 0x000152CD File Offset: 0x000134CD
			public unsafe bool _ExistTerminal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ExistTerminal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__ExistTerminal)) = value;
				}
			}

			// Token: 0x170010C8 RID: 4296
			// (get) Token: 0x060031DA RID: 12762 RVA: 0x000DE5AC File Offset: 0x000DC7AC
			// (set) Token: 0x060031DB RID: 12763 RVA: 0x000152E8 File Offset: 0x000134E8
			public unsafe bool _AllowDataType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__AllowDataType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__AllowDataType)) = value;
				}
			}

			// Token: 0x170010C9 RID: 4297
			// (get) Token: 0x060031DC RID: 12764 RVA: 0x000DE5D4 File Offset: 0x000DC7D4
			// (set) Token: 0x060031DD RID: 12765 RVA: 0x00015303 File Offset: 0x00013503
			public unsafe bool _HasDataType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__HasDataType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__HasDataType)) = value;
				}
			}

			// Token: 0x170010CA RID: 4298
			// (get) Token: 0x060031DE RID: 12766 RVA: 0x000DE5FC File Offset: 0x000DC7FC
			// (set) Token: 0x060031DF RID: 12767 RVA: 0x0001531E File Offset: 0x0001351E
			public unsafe bool _HasType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__HasType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__HasType)) = value;
				}
			}

			// Token: 0x170010CB RID: 4299
			// (get) Token: 0x060031E0 RID: 12768 RVA: 0x000DE624 File Offset: 0x000DC824
			// (set) Token: 0x060031E1 RID: 12769 RVA: 0x00015339 File Offset: 0x00013539
			public unsafe bool _EnumerationRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__EnumerationRequired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__EnumerationRequired)) = value;
				}
			}

			// Token: 0x170010CC RID: 4300
			// (get) Token: 0x060031E2 RID: 12770 RVA: 0x000DE64C File Offset: 0x000DC84C
			// (set) Token: 0x060031E3 RID: 12771 RVA: 0x00015354 File Offset: 0x00013554
			public unsafe uint _MinVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MinVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MinVal)) = value;
				}
			}

			// Token: 0x170010CD RID: 4301
			// (get) Token: 0x060031E4 RID: 12772 RVA: 0x000DE674 File Offset: 0x000DC874
			// (set) Token: 0x060031E5 RID: 12773 RVA: 0x0001536F File Offset: 0x0001356F
			public unsafe uint _MaxVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxVal)) = value;
				}
			}

			// Token: 0x170010CE RID: 4302
			// (get) Token: 0x060031E6 RID: 12774 RVA: 0x000DE69C File Offset: 0x000DC89C
			// (set) Token: 0x060031E7 RID: 12775 RVA: 0x0001538A File Offset: 0x0001358A
			public unsafe uint _MaxLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MaxLength)) = value;
				}
			}

			// Token: 0x170010CF RID: 4303
			// (get) Token: 0x060031E8 RID: 12776 RVA: 0x000DE6C4 File Offset: 0x000DC8C4
			// (set) Token: 0x060031E9 RID: 12777 RVA: 0x000153A5 File Offset: 0x000135A5
			public unsafe uint _MinLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MinLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__MinLength)) = value;
				}
			}

			// Token: 0x170010D0 RID: 4304
			// (get) Token: 0x060031EA RID: 12778 RVA: 0x000DE6EC File Offset: 0x000DC8EC
			// (set) Token: 0x060031EB RID: 12779 RVA: 0x000153C0 File Offset: 0x000135C0
			public unsafe Hashtable _AttDefList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__AttDefList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.ElementContent.NativeFieldInfoPtr__AttDefList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002706 RID: 9990
			private static readonly IntPtr NativeFieldInfoPtr__ElementDecl;

			// Token: 0x04002707 RID: 9991
			private static readonly IntPtr NativeFieldInfoPtr__ContentAttr;

			// Token: 0x04002708 RID: 9992
			private static readonly IntPtr NativeFieldInfoPtr__OrderAttr;

			// Token: 0x04002709 RID: 9993
			private static readonly IntPtr NativeFieldInfoPtr__MasterGroupRequired;

			// Token: 0x0400270A RID: 9994
			private static readonly IntPtr NativeFieldInfoPtr__ExistTerminal;

			// Token: 0x0400270B RID: 9995
			private static readonly IntPtr NativeFieldInfoPtr__AllowDataType;

			// Token: 0x0400270C RID: 9996
			private static readonly IntPtr NativeFieldInfoPtr__HasDataType;

			// Token: 0x0400270D RID: 9997
			private static readonly IntPtr NativeFieldInfoPtr__HasType;

			// Token: 0x0400270E RID: 9998
			private static readonly IntPtr NativeFieldInfoPtr__EnumerationRequired;

			// Token: 0x0400270F RID: 9999
			private static readonly IntPtr NativeFieldInfoPtr__MinVal;

			// Token: 0x04002710 RID: 10000
			private static readonly IntPtr NativeFieldInfoPtr__MaxVal;

			// Token: 0x04002711 RID: 10001
			private static readonly IntPtr NativeFieldInfoPtr__MaxLength;

			// Token: 0x04002712 RID: 10002
			private static readonly IntPtr NativeFieldInfoPtr__MinLength;

			// Token: 0x04002713 RID: 10003
			private static readonly IntPtr NativeFieldInfoPtr__AttDefList;

			// Token: 0x04002714 RID: 10004
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000263 RID: 611
		public sealed class AttributeContent : Object
		{
			// Token: 0x060031EC RID: 12780 RVA: 0x000DE71C File Offset: 0x000DC91C
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeContent()
			{
				Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "AttributeContent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr);
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__AttDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_AttDef");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_Name");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_Prefix");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__Required = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_Required");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_MinVal");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_MaxVal");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_MaxLength");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_MinLength");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__EnumerationRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_EnumerationRequired");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__HasDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_HasDataType");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_Global");
				XdrBuilder.AttributeContent.NativeFieldInfoPtr__Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, "_Default");
				XdrBuilder.AttributeContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr, 100668353);
			}

			// Token: 0x060031ED RID: 12781 RVA: 0x000DE84C File Offset: 0x000DCA4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeContent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.AttributeContent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.AttributeContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031EE RID: 12782 RVA: 0x000153DF File Offset: 0x000135DF
			public AttributeContent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010D1 RID: 4305
			// (get) Token: 0x060031EF RID: 12783 RVA: 0x000DE888 File Offset: 0x000DCA88
			// (set) Token: 0x060031F0 RID: 12784 RVA: 0x000153E8 File Offset: 0x000135E8
			public unsafe SchemaAttDef _AttDef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__AttDef);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__AttDef), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D2 RID: 4306
			// (get) Token: 0x060031F1 RID: 12785 RVA: 0x000DE8B8 File Offset: 0x000DCAB8
			// (set) Token: 0x060031F2 RID: 12786 RVA: 0x00015407 File Offset: 0x00013607
			public unsafe XmlQualifiedName _Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D3 RID: 4307
			// (get) Token: 0x060031F3 RID: 12787 RVA: 0x000DE8E8 File Offset: 0x000DCAE8
			// (set) Token: 0x060031F4 RID: 12788 RVA: 0x00015426 File Offset: 0x00013626
			public unsafe string _Prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170010D4 RID: 4308
			// (get) Token: 0x060031F5 RID: 12789 RVA: 0x000DE910 File Offset: 0x000DCB10
			// (set) Token: 0x060031F6 RID: 12790 RVA: 0x00015445 File Offset: 0x00013645
			public unsafe bool _Required
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Required);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Required)) = value;
				}
			}

			// Token: 0x170010D5 RID: 4309
			// (get) Token: 0x060031F7 RID: 12791 RVA: 0x000DE938 File Offset: 0x000DCB38
			// (set) Token: 0x060031F8 RID: 12792 RVA: 0x00015460 File Offset: 0x00013660
			public unsafe uint _MinVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinVal)) = value;
				}
			}

			// Token: 0x170010D6 RID: 4310
			// (get) Token: 0x060031F9 RID: 12793 RVA: 0x000DE960 File Offset: 0x000DCB60
			// (set) Token: 0x060031FA RID: 12794 RVA: 0x0001547B File Offset: 0x0001367B
			public unsafe uint _MaxVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxVal)) = value;
				}
			}

			// Token: 0x170010D7 RID: 4311
			// (get) Token: 0x060031FB RID: 12795 RVA: 0x000DE988 File Offset: 0x000DCB88
			// (set) Token: 0x060031FC RID: 12796 RVA: 0x00015496 File Offset: 0x00013696
			public unsafe uint _MaxLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MaxLength)) = value;
				}
			}

			// Token: 0x170010D8 RID: 4312
			// (get) Token: 0x060031FD RID: 12797 RVA: 0x000DE9B0 File Offset: 0x000DCBB0
			// (set) Token: 0x060031FE RID: 12798 RVA: 0x000154B1 File Offset: 0x000136B1
			public unsafe uint _MinLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__MinLength)) = value;
				}
			}

			// Token: 0x170010D9 RID: 4313
			// (get) Token: 0x060031FF RID: 12799 RVA: 0x000DE9D8 File Offset: 0x000DCBD8
			// (set) Token: 0x06003200 RID: 12800 RVA: 0x000154CC File Offset: 0x000136CC
			public unsafe bool _EnumerationRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__EnumerationRequired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__EnumerationRequired)) = value;
				}
			}

			// Token: 0x170010DA RID: 4314
			// (get) Token: 0x06003201 RID: 12801 RVA: 0x000DEA00 File Offset: 0x000DCC00
			// (set) Token: 0x06003202 RID: 12802 RVA: 0x000154E7 File Offset: 0x000136E7
			public unsafe bool _HasDataType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__HasDataType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__HasDataType)) = value;
				}
			}

			// Token: 0x170010DB RID: 4315
			// (get) Token: 0x06003203 RID: 12803 RVA: 0x000DEA28 File Offset: 0x000DCC28
			// (set) Token: 0x06003204 RID: 12804 RVA: 0x00015502 File Offset: 0x00013702
			public unsafe bool _Global
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Global);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Global)) = value;
				}
			}

			// Token: 0x170010DC RID: 4316
			// (get) Token: 0x06003205 RID: 12805 RVA: 0x000DEA50 File Offset: 0x000DCC50
			// (set) Token: 0x06003206 RID: 12806 RVA: 0x0001551D File Offset: 0x0001371D
			public unsafe Object _Default
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Default);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.AttributeContent.NativeFieldInfoPtr__Default), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002715 RID: 10005
			private static readonly IntPtr NativeFieldInfoPtr__AttDef;

			// Token: 0x04002716 RID: 10006
			private static readonly IntPtr NativeFieldInfoPtr__Name;

			// Token: 0x04002717 RID: 10007
			private static readonly IntPtr NativeFieldInfoPtr__Prefix;

			// Token: 0x04002718 RID: 10008
			private static readonly IntPtr NativeFieldInfoPtr__Required;

			// Token: 0x04002719 RID: 10009
			private static readonly IntPtr NativeFieldInfoPtr__MinVal;

			// Token: 0x0400271A RID: 10010
			private static readonly IntPtr NativeFieldInfoPtr__MaxVal;

			// Token: 0x0400271B RID: 10011
			private static readonly IntPtr NativeFieldInfoPtr__MaxLength;

			// Token: 0x0400271C RID: 10012
			private static readonly IntPtr NativeFieldInfoPtr__MinLength;

			// Token: 0x0400271D RID: 10013
			private static readonly IntPtr NativeFieldInfoPtr__EnumerationRequired;

			// Token: 0x0400271E RID: 10014
			private static readonly IntPtr NativeFieldInfoPtr__HasDataType;

			// Token: 0x0400271F RID: 10015
			private static readonly IntPtr NativeFieldInfoPtr__Global;

			// Token: 0x04002720 RID: 10016
			private static readonly IntPtr NativeFieldInfoPtr__Default;

			// Token: 0x04002721 RID: 10017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000264 RID: 612
		public sealed class XdrBuildFunction : MulticastDelegate
		{
			// Token: 0x06003207 RID: 12807 RVA: 0x0001553C File Offset: 0x0001373C
			// Note: this type is marked as 'beforefieldinit'.
			static XdrBuildFunction()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrBuildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrBuildFunction");
				XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBuildFunction>.NativeClassPtr, 100668354);
				XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBuildFunction>.NativeClassPtr, 100668355);
			}

			// Token: 0x06003208 RID: 12808 RVA: 0x000DEA80 File Offset: 0x000DCC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408081, XrefRangeEnd = 408085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrBuildFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrBuildFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003209 RID: 12809 RVA: 0x000DEADC File Offset: 0x000DCCDC
			[CallerCount(0)]
			public unsafe void Invoke(XdrBuilder builder, Object obj, string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBuildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600320A RID: 12810 RVA: 0x0001557A File Offset: 0x0001377A
			public XdrBuildFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600320B RID: 12811 RVA: 0x00015583 File Offset: 0x00013783
			public static implicit operator XdrBuilder.XdrBuildFunction(Action<XdrBuilder, Object, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<XdrBuilder.XdrBuildFunction>(A_0);
			}

			// Token: 0x0600320C RID: 12812 RVA: 0x0001558B File Offset: 0x0001378B
			public static XdrBuilder.XdrBuildFunction operator +(XdrBuilder.XdrBuildFunction A_0, XdrBuilder.XdrBuildFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XdrBuilder.XdrBuildFunction>();
			}

			// Token: 0x0600320D RID: 12813 RVA: 0x00015599 File Offset: 0x00013799
			public static XdrBuilder.XdrBuildFunction operator -(XdrBuilder.XdrBuildFunction A_0, XdrBuilder.XdrBuildFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XdrBuilder.XdrBuildFunction>();
				}
				return delegate2;
			}

			// Token: 0x04002722 RID: 10018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002723 RID: 10019
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_String_0;
		}

		// Token: 0x02000265 RID: 613
		public sealed class XdrInitFunction : MulticastDelegate
		{
			// Token: 0x0600320E RID: 12814 RVA: 0x000155AA File Offset: 0x000137AA
			// Note: this type is marked as 'beforefieldinit'.
			static XdrInitFunction()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrInitFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrInitFunction");
				XdrBuilder.XdrInitFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrInitFunction>.NativeClassPtr, 100668356);
				XdrBuilder.XdrInitFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrInitFunction>.NativeClassPtr, 100668357);
			}

			// Token: 0x0600320F RID: 12815 RVA: 0x000DEB44 File Offset: 0x000DCD44
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 408089, RefRangeEnd = 408094, XrefRangeStart = 408085, XrefRangeEnd = 408089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrInitFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrInitFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrInitFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003210 RID: 12816 RVA: 0x000DEBA0 File Offset: 0x000DCDA0
			[CallerCount(0)]
			public unsafe void Invoke(XdrBuilder builder, Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrInitFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003211 RID: 12817 RVA: 0x000155E8 File Offset: 0x000137E8
			public XdrInitFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003212 RID: 12818 RVA: 0x000155F1 File Offset: 0x000137F1
			public static implicit operator XdrBuilder.XdrInitFunction(Action<XdrBuilder, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<XdrBuilder.XdrInitFunction>(A_0);
			}

			// Token: 0x06003213 RID: 12819 RVA: 0x000155F9 File Offset: 0x000137F9
			public static XdrBuilder.XdrInitFunction operator +(XdrBuilder.XdrInitFunction A_0, XdrBuilder.XdrInitFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XdrBuilder.XdrInitFunction>();
			}

			// Token: 0x06003214 RID: 12820 RVA: 0x00015607 File Offset: 0x00013807
			public static XdrBuilder.XdrInitFunction operator -(XdrBuilder.XdrInitFunction A_0, XdrBuilder.XdrInitFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XdrBuilder.XdrInitFunction>();
				}
				return delegate2;
			}

			// Token: 0x04002724 RID: 10020
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002725 RID: 10021
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_0;
		}

		// Token: 0x02000266 RID: 614
		public sealed class XdrBeginChildFunction : MulticastDelegate
		{
			// Token: 0x06003215 RID: 12821 RVA: 0x00015618 File Offset: 0x00013818
			// Note: this type is marked as 'beforefieldinit'.
			static XdrBeginChildFunction()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrBeginChildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrBeginChildFunction");
				XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBeginChildFunction>.NativeClassPtr, 100668358);
				XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrBeginChildFunction>.NativeClassPtr, 100668359);
			}

			// Token: 0x06003216 RID: 12822 RVA: 0x000DEBF4 File Offset: 0x000DCDF4
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408094, XrefRangeEnd = 408098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrBeginChildFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrBeginChildFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003217 RID: 12823 RVA: 0x000DEC50 File Offset: 0x000DCE50
			[CallerCount(0)]
			public unsafe void Invoke(XdrBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrBeginChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003218 RID: 12824 RVA: 0x00015656 File Offset: 0x00013856
			public XdrBeginChildFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003219 RID: 12825 RVA: 0x0001565F File Offset: 0x0001385F
			public static implicit operator XdrBuilder.XdrBeginChildFunction(Action<XdrBuilder> A_0)
			{
				return DelegateSupport.ConvertDelegate<XdrBuilder.XdrBeginChildFunction>(A_0);
			}

			// Token: 0x0600321A RID: 12826 RVA: 0x00015667 File Offset: 0x00013867
			public static XdrBuilder.XdrBeginChildFunction operator +(XdrBuilder.XdrBeginChildFunction A_0, XdrBuilder.XdrBeginChildFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XdrBuilder.XdrBeginChildFunction>();
			}

			// Token: 0x0600321B RID: 12827 RVA: 0x00015675 File Offset: 0x00013875
			public static XdrBuilder.XdrBeginChildFunction operator -(XdrBuilder.XdrBeginChildFunction A_0, XdrBuilder.XdrBeginChildFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XdrBuilder.XdrBeginChildFunction>();
				}
				return delegate2;
			}

			// Token: 0x04002726 RID: 10022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002727 RID: 10023
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0;
		}

		// Token: 0x02000267 RID: 615
		public sealed class XdrEndChildFunction : MulticastDelegate
		{
			// Token: 0x0600321C RID: 12828 RVA: 0x00015686 File Offset: 0x00013886
			// Note: this type is marked as 'beforefieldinit'.
			static XdrEndChildFunction()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrEndChildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrEndChildFunction");
				XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrEndChildFunction>.NativeClassPtr, 100668360);
				XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrEndChildFunction>.NativeClassPtr, 100668361);
			}

			// Token: 0x0600321D RID: 12829 RVA: 0x000DEC94 File Offset: 0x000DCE94
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrEndChildFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrEndChildFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600321E RID: 12830 RVA: 0x000DECF0 File Offset: 0x000DCEF0
			[CallerCount(0)]
			public unsafe void Invoke(XdrBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrEndChildFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600321F RID: 12831 RVA: 0x000156C4 File Offset: 0x000138C4
			public XdrEndChildFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003220 RID: 12832 RVA: 0x000156CD File Offset: 0x000138CD
			public static implicit operator XdrBuilder.XdrEndChildFunction(Action<XdrBuilder> A_0)
			{
				return DelegateSupport.ConvertDelegate<XdrBuilder.XdrEndChildFunction>(A_0);
			}

			// Token: 0x06003221 RID: 12833 RVA: 0x000156D5 File Offset: 0x000138D5
			public static XdrBuilder.XdrEndChildFunction operator +(XdrBuilder.XdrEndChildFunction A_0, XdrBuilder.XdrEndChildFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XdrBuilder.XdrEndChildFunction>();
			}

			// Token: 0x06003222 RID: 12834 RVA: 0x000156E3 File Offset: 0x000138E3
			public static XdrBuilder.XdrEndChildFunction operator -(XdrBuilder.XdrEndChildFunction A_0, XdrBuilder.XdrEndChildFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XdrBuilder.XdrEndChildFunction>();
				}
				return delegate2;
			}

			// Token: 0x04002728 RID: 10024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002729 RID: 10025
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0;
		}

		// Token: 0x02000268 RID: 616
		public sealed class XdrAttributeEntry : Object
		{
			// Token: 0x06003223 RID: 12835 RVA: 0x000DED34 File Offset: 0x000DCF34
			// Note: this type is marked as 'beforefieldinit'.
			static XdrAttributeEntry()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrAttributeEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr);
				XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, "_Attribute");
				XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__SchemaFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, "_SchemaFlags");
				XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, "_Datatype");
				XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__BuildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, "_BuildFunc");
				XdrBuilder.XdrAttributeEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_XdrBuildFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, 100668362);
				XdrBuilder.XdrAttributeEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_Int32_XdrBuildFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr, 100668363);
			}

			// Token: 0x06003224 RID: 12836 RVA: 0x000DEDD8 File Offset: 0x000DCFD8
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 408121, RefRangeEnd = 408153, XrefRangeStart = 408114, XrefRangeEnd = 408121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrAttributeEntry(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ttype;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(build);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrAttributeEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_XdrBuildFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003225 RID: 12837 RVA: 0x000DEE40 File Offset: 0x000DD040
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 408160, RefRangeEnd = 408162, XrefRangeStart = 408153, XrefRangeEnd = 408160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrAttributeEntry(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuilder.XdrBuildFunction build)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrAttributeEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ttype;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref schemaFlags;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(build);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrAttributeEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_Int32_XdrBuildFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003226 RID: 12838 RVA: 0x000156F4 File Offset: 0x000138F4
			public XdrAttributeEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010DD RID: 4317
			// (get) Token: 0x06003227 RID: 12839 RVA: 0x000DEEB8 File Offset: 0x000DD0B8
			// (set) Token: 0x06003228 RID: 12840 RVA: 0x000156FD File Offset: 0x000138FD
			public unsafe SchemaNames.Token _Attribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Attribute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Attribute)) = value;
				}
			}

			// Token: 0x170010DE RID: 4318
			// (get) Token: 0x06003229 RID: 12841 RVA: 0x000DEEE0 File Offset: 0x000DD0E0
			// (set) Token: 0x0600322A RID: 12842 RVA: 0x00015718 File Offset: 0x00013918
			public unsafe int _SchemaFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__SchemaFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__SchemaFlags)) = value;
				}
			}

			// Token: 0x170010DF RID: 4319
			// (get) Token: 0x0600322B RID: 12843 RVA: 0x000DEF08 File Offset: 0x000DD108
			// (set) Token: 0x0600322C RID: 12844 RVA: 0x00015733 File Offset: 0x00013933
			public unsafe XmlSchemaDatatype _Datatype
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Datatype);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__Datatype), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E0 RID: 4320
			// (get) Token: 0x0600322D RID: 12845 RVA: 0x000DEF38 File Offset: 0x000DD138
			// (set) Token: 0x0600322E RID: 12846 RVA: 0x00015752 File Offset: 0x00013952
			public unsafe XdrBuilder.XdrBuildFunction _BuildFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__BuildFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrBuildFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrAttributeEntry.NativeFieldInfoPtr__BuildFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400272A RID: 10026
			private static readonly IntPtr NativeFieldInfoPtr__Attribute;

			// Token: 0x0400272B RID: 10027
			private static readonly IntPtr NativeFieldInfoPtr__SchemaFlags;

			// Token: 0x0400272C RID: 10028
			private static readonly IntPtr NativeFieldInfoPtr__Datatype;

			// Token: 0x0400272D RID: 10029
			private static readonly IntPtr NativeFieldInfoPtr__BuildFunc;

			// Token: 0x0400272E RID: 10030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_XdrBuildFunction_0;

			// Token: 0x0400272F RID: 10031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_Int32_XdrBuildFunction_0;
		}

		// Token: 0x02000269 RID: 617
		public sealed class XdrEntry : Object
		{
			// Token: 0x0600322F RID: 12847 RVA: 0x000DEF68 File Offset: 0x000DD168
			// Note: this type is marked as 'beforefieldinit'.
			static XdrEntry()
			{
				Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr);
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_Name");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__NextStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_NextStates");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_Attributes");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__InitFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_InitFunc");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__BeginChildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_BeginChildFunc");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__EndChildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_EndChildFunc");
				XdrBuilder.XdrEntry.NativeFieldInfoPtr__AllowText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, "_AllowText");
				XdrBuilder.XdrEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_XdrAttributeEntry_XdrInitFunction_XdrBeginChildFunction_XdrEndChildFunction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr, 100668364);
			}

			// Token: 0x06003230 RID: 12848 RVA: 0x000DF034 File Offset: 0x000DD234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408162, XrefRangeEnd = 408168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XdrEntry(SchemaNames.Token n, Il2CppStructArray<int> states, Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder.XdrEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(states);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(init);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(begin);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fText;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrBuilder.XdrEntry.NativeMethodInfoPtr__ctor_Internal_Void_Token_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_XdrAttributeEntry_XdrInitFunction_XdrBeginChildFunction_XdrEndChildFunction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003231 RID: 12849 RVA: 0x00015771 File Offset: 0x00013971
			public XdrEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010E1 RID: 4321
			// (get) Token: 0x06003232 RID: 12850 RVA: 0x000DF0E8 File Offset: 0x000DD2E8
			// (set) Token: 0x06003233 RID: 12851 RVA: 0x0001577A File Offset: 0x0001397A
			public unsafe SchemaNames.Token _Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__Name);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__Name)) = value;
				}
			}

			// Token: 0x170010E2 RID: 4322
			// (get) Token: 0x06003234 RID: 12852 RVA: 0x000DF110 File Offset: 0x000DD310
			// (set) Token: 0x06003235 RID: 12853 RVA: 0x00015795 File Offset: 0x00013995
			public unsafe Il2CppStructArray<int> _NextStates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__NextStates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__NextStates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E3 RID: 4323
			// (get) Token: 0x06003236 RID: 12854 RVA: 0x000DF140 File Offset: 0x000DD340
			// (set) Token: 0x06003237 RID: 12855 RVA: 0x000157B4 File Offset: 0x000139B4
			public unsafe Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry> _Attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__Attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrBuilder.XdrAttributeEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E4 RID: 4324
			// (get) Token: 0x06003238 RID: 12856 RVA: 0x000DF170 File Offset: 0x000DD370
			// (set) Token: 0x06003239 RID: 12857 RVA: 0x000157D3 File Offset: 0x000139D3
			public unsafe XdrBuilder.XdrInitFunction _InitFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__InitFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrInitFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__InitFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E5 RID: 4325
			// (get) Token: 0x0600323A RID: 12858 RVA: 0x000DF1A0 File Offset: 0x000DD3A0
			// (set) Token: 0x0600323B RID: 12859 RVA: 0x000157F2 File Offset: 0x000139F2
			public unsafe XdrBuilder.XdrBeginChildFunction _BeginChildFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__BeginChildFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrBeginChildFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__BeginChildFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E6 RID: 4326
			// (get) Token: 0x0600323C RID: 12860 RVA: 0x000DF1D0 File Offset: 0x000DD3D0
			// (set) Token: 0x0600323D RID: 12861 RVA: 0x00015811 File Offset: 0x00013A11
			public unsafe XdrBuilder.XdrEndChildFunction _EndChildFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__EndChildFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XdrBuilder.XdrEndChildFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__EndChildFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E7 RID: 4327
			// (get) Token: 0x0600323E RID: 12862 RVA: 0x000DF200 File Offset: 0x000DD400
			// (set) Token: 0x0600323F RID: 12863 RVA: 0x00015830 File Offset: 0x00013A30
			public unsafe bool _AllowText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__AllowText);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrBuilder.XdrEntry.NativeFieldInfoPtr__AllowText)) = value;
				}
			}

			// Token: 0x04002730 RID: 10032
			private static readonly IntPtr NativeFieldInfoPtr__Name;

			// Token: 0x04002731 RID: 10033
			private static readonly IntPtr NativeFieldInfoPtr__NextStates;

			// Token: 0x04002732 RID: 10034
			private static readonly IntPtr NativeFieldInfoPtr__Attributes;

			// Token: 0x04002733 RID: 10035
			private static readonly IntPtr NativeFieldInfoPtr__InitFunc;

			// Token: 0x04002734 RID: 10036
			private static readonly IntPtr NativeFieldInfoPtr__BeginChildFunc;

			// Token: 0x04002735 RID: 10037
			private static readonly IntPtr NativeFieldInfoPtr__EndChildFunc;

			// Token: 0x04002736 RID: 10038
			private static readonly IntPtr NativeFieldInfoPtr__AllowText;

			// Token: 0x04002737 RID: 10039
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_XdrAttributeEntry_XdrInitFunction_XdrBeginChildFunction_XdrEndChildFunction_Boolean_0;
		}
	}
}
