using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data
{
	// Token: 0x0200007E RID: 126
	public sealed class XSDSchema : XMLSchema
	{
		// Token: 0x06000BBC RID: 3004 RVA: 0x0003BCB4 File Offset: 0x00039EB4
		// Note: this type is marked as 'beforefieldinit'.
		static XSDSchema()
		{
			Il2CppClassPointerStore<XSDSchema>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "XSDSchema");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr);
			XSDSchema.NativeFieldInfoPtr__schemaSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_schemaSet");
			XSDSchema.NativeFieldInfoPtr__dsElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_dsElement");
			XSDSchema.NativeFieldInfoPtr__ds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_ds");
			XSDSchema.NativeFieldInfoPtr__schemaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_schemaName");
			XSDSchema.NativeFieldInfoPtr__columnExpressions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_columnExpressions");
			XSDSchema.NativeFieldInfoPtr__constraintNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_constraintNodes");
			XSDSchema.NativeFieldInfoPtr__refTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_refTables");
			XSDSchema.NativeFieldInfoPtr__complexTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_complexTypes");
			XSDSchema.NativeFieldInfoPtr__annotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_annotations");
			XSDSchema.NativeFieldInfoPtr__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_elements");
			XSDSchema.NativeFieldInfoPtr__attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_attributes");
			XSDSchema.NativeFieldInfoPtr__elementsTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_elementsTable");
			XSDSchema.NativeFieldInfoPtr__attributeGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_attributeGroups");
			XSDSchema.NativeFieldInfoPtr__schemaTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_schemaTypes");
			XSDSchema.NativeFieldInfoPtr__expressions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_expressions");
			XSDSchema.NativeFieldInfoPtr__tableDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_tableDictionary");
			XSDSchema.NativeFieldInfoPtr__udSimpleTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_udSimpleTypes");
			XSDSchema.NativeFieldInfoPtr__existingSimpleTypeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_existingSimpleTypeMap");
			XSDSchema.NativeFieldInfoPtr__fromInference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "_fromInference");
			XSDSchema.NativeFieldInfoPtr_s_mapNameTypeXsd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "s_mapNameTypeXsd");
			XSDSchema.NativeMethodInfoPtr_get_FromInference_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665233);
			XSDSchema.NativeMethodInfoPtr_set_FromInference_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665234);
			XSDSchema.NativeMethodInfoPtr_CollectElementsAnnotations_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665235);
			XSDSchema.NativeMethodInfoPtr_CollectElementsAnnotations_Private_Void_XmlSchema_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665236);
			XSDSchema.NativeMethodInfoPtr_QualifiedName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665237);
			XSDSchema.NativeMethodInfoPtr_SetProperties_Internal_Static_Void_Object_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665238);
			XSDSchema.NativeMethodInfoPtr_SetExtProperties_Private_Static_Void_Object_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665239);
			XSDSchema.NativeMethodInfoPtr_HandleColumnExpression_Private_Void_Object_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665240);
			XSDSchema.NativeMethodInfoPtr_GetMsdataAttribute_Internal_Static_String_XmlSchemaAnnotated_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665241);
			XSDSchema.NativeMethodInfoPtr_SetExtProperties_Private_Static_Void_Object_XmlAttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665242);
			XSDSchema.NativeMethodInfoPtr_HandleRefTableProperties_Internal_Void_ArrayList_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665243);
			XSDSchema.NativeMethodInfoPtr_HandleRelation_Internal_Void_XmlElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665244);
			XSDSchema.NativeMethodInfoPtr_HasAttributes_Private_Boolean_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665245);
			XSDSchema.NativeMethodInfoPtr_IsDatasetParticle_Private_Boolean_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665246);
			XSDSchema.NativeMethodInfoPtr_DatasetElementCount_Private_Int32_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665247);
			XSDSchema.NativeMethodInfoPtr_FindDatasetElement_Private_XmlSchemaElement_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665248);
			XSDSchema.NativeMethodInfoPtr_LoadSchema_Public_Void_XmlSchemaSet_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665249);
			XSDSchema.NativeMethodInfoPtr_LoadSchema_Public_Void_XmlSchemaSet_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665250);
			XSDSchema.NativeMethodInfoPtr_HandleRelations_Private_Void_XmlSchemaAnnotation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665251);
			XSDSchema.NativeMethodInfoPtr_GetParticleItems_Internal_XmlSchemaObjectCollection_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665252);
			XSDSchema.NativeMethodInfoPtr_HandleParticle_Internal_Void_XmlSchemaParticle_DataTable_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665253);
			XSDSchema.NativeMethodInfoPtr_HandleAttributes_Internal_Void_XmlSchemaObjectCollection_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665254);
			XSDSchema.NativeMethodInfoPtr_HandleAttributeGroup_Private_Void_XmlSchemaAttributeGroup_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665255);
			XSDSchema.NativeMethodInfoPtr_HandleComplexType_Internal_Void_XmlSchemaComplexType_DataTable_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665256);
			XSDSchema.NativeMethodInfoPtr_GetParticle_Internal_XmlSchemaParticle_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665257);
			XSDSchema.NativeMethodInfoPtr_FindField_Internal_DataColumn_DataTable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665258);
			XSDSchema.NativeMethodInfoPtr_BuildKey_Internal_Il2CppReferenceArray_1_DataColumn_XmlSchemaIdentityConstraint_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665259);
			XSDSchema.NativeMethodInfoPtr_GetBooleanAttribute_Internal_Boolean_XmlSchemaAnnotated_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665260);
			XSDSchema.NativeMethodInfoPtr_GetStringAttribute_Internal_String_XmlSchemaAnnotated_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665261);
			XSDSchema.NativeMethodInfoPtr_TranslateAcceptRejectRule_Internal_Static_AcceptRejectRule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665262);
			XSDSchema.NativeMethodInfoPtr_TranslateRule_Internal_Static_Rule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665263);
			XSDSchema.NativeMethodInfoPtr_HandleKeyref_Internal_Void_XmlSchemaKeyref_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665264);
			XSDSchema.NativeMethodInfoPtr_HandleConstraint_Internal_Void_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665265);
			XSDSchema.NativeMethodInfoPtr_InstantiateSimpleTable_Internal_DataTable_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665266);
			XSDSchema.NativeMethodInfoPtr_GetInstanceName_Internal_String_XmlSchemaAnnotated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665267);
			XSDSchema.NativeMethodInfoPtr_InstantiateTable_Internal_DataTable_XmlSchemaElement_XmlSchemaComplexType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665268);
			XSDSchema.NativeMethodInfoPtr_XsdtoClr_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665269);
			XSDSchema.NativeMethodInfoPtr_FindNameType_Private_Static_NameType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665270);
			XSDSchema.NativeMethodInfoPtr_ParseDataType_Private_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665271);
			XSDSchema.NativeMethodInfoPtr_IsXsdType_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665272);
			XSDSchema.NativeMethodInfoPtr_FindTypeNode_Internal_XmlSchemaAnnotated_XmlSchemaAnnotated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665273);
			XSDSchema.NativeMethodInfoPtr_HandleSimpleTypeSimpleContentColumn_Internal_Void_XmlSchemaSimpleType_String_DataTable_Boolean_Il2CppReferenceArray_1_XmlAttribute_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665274);
			XSDSchema.NativeMethodInfoPtr_HandleSimpleContentColumn_Internal_Void_String_DataTable_Boolean_Il2CppReferenceArray_1_XmlAttribute_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665275);
			XSDSchema.NativeMethodInfoPtr_HandleAttributeColumn_Internal_Void_XmlSchemaAttribute_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665276);
			XSDSchema.NativeMethodInfoPtr_HandleElementColumn_Internal_Void_XmlSchemaElement_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665277);
			XSDSchema.NativeMethodInfoPtr_HandleDataSet_Internal_Void_XmlSchemaElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665278);
			XSDSchema.NativeMethodInfoPtr_AddTablesToList_Private_Void_List_1_DataTable_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665279);
			XSDSchema.NativeMethodInfoPtr_GetPrefix_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665280);
			XSDSchema.NativeMethodInfoPtr_GetNamespaceFromPrefix_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665281);
			XSDSchema.NativeMethodInfoPtr_GetTableNamespace_Private_String_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665282);
			XSDSchema.NativeMethodInfoPtr_GetTableName_Private_String_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665283);
			XSDSchema.NativeMethodInfoPtr_IsTable_Internal_Boolean_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665284);
			XSDSchema.NativeMethodInfoPtr_HandleTable_Internal_DataTable_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665285);
			XSDSchema.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, 100665286);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0003C2AC File Offset: 0x0003A4AC
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0003C2E8 File Offset: 0x0003A4E8
		public unsafe bool FromInference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_get_FromInference_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_set_FromInference_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0003C328 File Offset: 0x0003A528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 908745, RefRangeEnd = 908746, XrefRangeStart = 908739, XrefRangeEnd = 908745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollectElementsAnnotations(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_CollectElementsAnnotations_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0003C36C File Offset: 0x0003A56C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 908810, RefRangeEnd = 908812, XrefRangeStart = 908746, XrefRangeEnd = 908810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_CollectElementsAnnotations_Private_Void_XmlSchema_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0003C3C0 File Offset: 0x0003A5C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 908814, RefRangeEnd = 908818, XrefRangeStart = 908812, XrefRangeEnd = 908814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QualifiedName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_QualifiedName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0003C3FC File Offset: 0x0003A5FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 908887, RefRangeEnd = 908895, XrefRangeStart = 908818, XrefRangeEnd = 908887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProperties(Object instance, Il2CppReferenceArray<XmlAttribute> attrs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_SetProperties_Internal_Static_Void_Object_Il2CppReferenceArray_1_XmlAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0003C444 File Offset: 0x0003A644
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 908927, RefRangeEnd = 908939, XrefRangeStart = 908895, XrefRangeEnd = 908927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetExtProperties(Object instance, Il2CppReferenceArray<XmlAttribute> attrs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_SetExtProperties_Private_Static_Void_Object_Il2CppReferenceArray_1_XmlAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0003C48C File Offset: 0x0003A68C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 908954, RefRangeEnd = 908958, XrefRangeStart = 908939, XrefRangeEnd = 908954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleColumnExpression(Object instance, Il2CppReferenceArray<XmlAttribute> attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleColumnExpression_Private_Void_Object_Il2CppReferenceArray_1_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0003C4E0 File Offset: 0x0003A6E0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 908963, RefRangeEnd = 908986, XrefRangeStart = 908958, XrefRangeEnd = 908963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ln);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_GetMsdataAttribute_Internal_Static_String_XmlSchemaAnnotated_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0003C530 File Offset: 0x0003A730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 909005, RefRangeEnd = 909006, XrefRangeStart = 908986, XrefRangeEnd = 909005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetExtProperties(Object instance, XmlAttributeCollection attrs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_SetExtProperties_Private_Static_Void_Object_XmlAttributeCollection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0003C578 File Offset: 0x0003A778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 909018, RefRangeEnd = 909019, XrefRangeStart = 909006, XrefRangeEnd = 909018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(RefTables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleRefTableProperties_Internal_Void_ArrayList_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0003C5CC File Offset: 0x0003A7CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 909095, RefRangeEnd = 909096, XrefRangeStart = 909019, XrefRangeEnd = 909095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleRelation(XmlElement node, bool fNested)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNested;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleRelation_Internal_Void_XmlElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0003C61C File Offset: 0x0003A81C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 909111, RefRangeEnd = 909113, XrefRangeStart = 909096, XrefRangeEnd = 909111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAttributes(XmlSchemaObjectCollection attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HasAttributes_Private_Boolean_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0003C66C File Offset: 0x0003A86C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 909158, RefRangeEnd = 909160, XrefRangeStart = 909113, XrefRangeEnd = 909158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDatasetParticle(XmlSchemaParticle pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_IsDatasetParticle_Private_Boolean_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0003C6BC File Offset: 0x0003A8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 909177, RefRangeEnd = 909178, XrefRangeStart = 909160, XrefRangeEnd = 909177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DatasetElementCount(XmlSchemaObjectCollection elements)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_DatasetElementCount_Private_Int32_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0003C70C File Offset: 0x0003A90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 909219, RefRangeEnd = 909220, XrefRangeStart = 909178, XrefRangeEnd = 909219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_FindDatasetElement_Private_XmlSchemaElement_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0003C75C File Offset: 0x0003A95C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 909221, RefRangeEnd = 909222, XrefRangeStart = 909220, XrefRangeEnd = 909221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchema(XmlSchemaSet schemaSet, DataTable dt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_LoadSchema_Public_Void_XmlSchemaSet_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0003C7B0 File Offset: 0x0003A9B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 909476, RefRangeEnd = 909479, XrefRangeStart = 909222, XrefRangeEnd = 909476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchema(XmlSchemaSet schemaSet, DataSet ds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_LoadSchema_Public_Void_XmlSchemaSet_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0003C804 File Offset: 0x0003AA04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 909500, RefRangeEnd = 909502, XrefRangeStart = 909479, XrefRangeEnd = 909500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleRelations(XmlSchemaAnnotation ann, bool fNested)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ann);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNested;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleRelations_Private_Void_XmlSchemaAnnotation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0003C854 File Offset: 0x0003AA54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 909520, RefRangeEnd = 909524, XrefRangeStart = 909502, XrefRangeEnd = 909520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_GetParticleItems_Internal_XmlSchemaObjectCollection_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 909584, RefRangeEnd = 909588, XrefRangeStart = 909524, XrefRangeEnd = 909584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tableChildren);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleParticle_Internal_Void_XmlSchemaParticle_DataTable_ArrayList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0003C918 File Offset: 0x0003AB18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 909610, RefRangeEnd = 909616, XrefRangeStart = 909588, XrefRangeEnd = 909610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleAttributes_Internal_Void_XmlSchemaObjectCollection_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0003C97C File Offset: 0x0003AB7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 909644, RefRangeEnd = 909646, XrefRangeStart = 909616, XrefRangeEnd = 909644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleAttributeGroup_Private_Void_XmlSchemaAttributeGroup_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0003C9E0 File Offset: 0x0003ABE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 909713, RefRangeEnd = 909716, XrefRangeStart = 909646, XrefRangeEnd = 909713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ct);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tableChildren);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNillable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleComplexType_Internal_Void_XmlSchemaComplexType_DataTable_ArrayList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0003CA54 File Offset: 0x0003AC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 909719, RefRangeEnd = 909720, XrefRangeStart = 909716, XrefRangeEnd = 909719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaParticle GetParticle(XmlSchemaComplexType ct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ct);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_GetParticle_Internal_XmlSchemaParticle_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0003CAA4 File Offset: 0x0003ACA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 909730, RefRangeEnd = 909731, XrefRangeStart = 909720, XrefRangeEnd = 909730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumn FindField(DataTable table, string field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_FindField_Internal_DataColumn_DataTable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0003CB08 File Offset: 0x0003AD08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 909752, RefRangeEnd = 909755, XrefRangeStart = 909731, XrefRangeEnd = 909752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataColumn> BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_BuildKey_Internal_Il2CppReferenceArray_1_DataColumn_XmlSchemaIdentityConstraint_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0003CB6C File Offset: 0x0003AD6C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 909771, RefRangeEnd = 909781, XrefRangeStart = 909755, XrefRangeEnd = 909771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_GetBooleanAttribute_Internal_Boolean_XmlSchemaAnnotated_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0003CBDC File Offset: 0x0003ADDC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 909785, RefRangeEnd = 909794, XrefRangeStart = 909781, XrefRangeEnd = 909785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_GetStringAttribute_Internal_String_XmlSchemaAnnotated_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0003CC48 File Offset: 0x0003AE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 909794, XrefRangeEnd = 909800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AcceptRejectRule TranslateAcceptRejectRule(string strRule)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strRule);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_TranslateAcceptRejectRule_Internal_Static_AcceptRejectRule_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0003CC8C File Offset: 0x0003AE8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 909812, RefRangeEnd = 909814, XrefRangeStart = 909800, XrefRangeEnd = 909812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rule TranslateRule(string strRule)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strRule);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_TranslateRule_Internal_Static_Rule_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0003CCD0 File Offset: 0x0003AED0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 909907, RefRangeEnd = 909910, XrefRangeStart = 909814, XrefRangeEnd = 909907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleKeyref(XmlSchemaKeyref keyref)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyref);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleKeyref_Internal_Void_XmlSchemaKeyref_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0003CD14 File Offset: 0x0003AF14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 909956, RefRangeEnd = 909958, XrefRangeStart = 909910, XrefRangeEnd = 909956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleConstraint(XmlSchemaIdentityConstraint keyNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleConstraint_Internal_Void_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0003CD58 File Offset: 0x0003AF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 910038, RefRangeEnd = 910039, XrefRangeStart = 909958, XrefRangeEnd = 910038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable InstantiateSimpleTable(XmlSchemaElement node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_InstantiateSimpleTable_Internal_DataTable_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0003CDA8 File Offset: 0x0003AFA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 910042, RefRangeEnd = 910049, XrefRangeStart = 910039, XrefRangeEnd = 910042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInstanceName(XmlSchemaAnnotated node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_GetInstanceName_Internal_String_XmlSchemaAnnotated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0003CDF0 File Offset: 0x0003AFF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 910237, RefRangeEnd = 910238, XrefRangeStart = 910049, XrefRangeEnd = 910237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_InstantiateTable_Internal_DataTable_XmlSchemaElement_XmlSchemaComplexType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0003CE60 File Offset: 0x0003B060
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 910246, RefRangeEnd = 910248, XrefRangeStart = 910238, XrefRangeEnd = 910246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type XsdtoClr(string xsdTypeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xsdTypeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_XsdtoClr_Public_Static_Type_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0003CEA4 File Offset: 0x0003B0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 910248, XrefRangeEnd = 910256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XSDSchema.NameType FindNameType(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_FindNameType_Private_Static_NameType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XSDSchema.NameType>(intPtr3) : null;
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0003CEE8 File Offset: 0x0003B0E8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 910272, RefRangeEnd = 910285, XrefRangeStart = 910256, XrefRangeEnd = 910272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type ParseDataType(string dt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_ParseDataType_Private_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0003CF38 File Offset: 0x0003B138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 910290, RefRangeEnd = 910291, XrefRangeStart = 910285, XrefRangeEnd = 910290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsXsdType(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_IsXsdType_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0003CF7C File Offset: 0x0003B17C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 910314, RefRangeEnd = 910321, XrefRangeStart = 910291, XrefRangeEnd = 910314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_FindTypeNode_Internal_XmlSchemaAnnotated_XmlSchemaAnnotated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnnotated>(intPtr3) : null;
			}
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0003CFCC File Offset: 0x0003B1CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 910430, RefRangeEnd = 910431, XrefRangeStart = 910321, XrefRangeEnd = 910430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, Il2CppReferenceArray<XmlAttribute> attrs, bool isNillable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBase;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNillable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleSimpleTypeSimpleContentColumn_Internal_Void_XmlSchemaSimpleType_String_DataTable_Boolean_Il2CppReferenceArray_1_XmlAttribute_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0003D064 File Offset: 0x0003B264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 910507, RefRangeEnd = 910509, XrefRangeStart = 910431, XrefRangeEnd = 910507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, Il2CppReferenceArray<XmlAttribute> attrs, bool isNillable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNillable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleSimpleContentColumn_Internal_Void_String_DataTable_Boolean_Il2CppReferenceArray_1_XmlAttribute_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0003D0E8 File Offset: 0x0003B2E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 910627, RefRangeEnd = 910629, XrefRangeStart = 910509, XrefRangeEnd = 910627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrib);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleAttributeColumn_Internal_Void_XmlSchemaAttribute_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0003D14C File Offset: 0x0003B34C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 910802, RefRangeEnd = 910804, XrefRangeStart = 910629, XrefRangeEnd = 910802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleElementColumn_Internal_Void_XmlSchemaElement_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0003D1B0 File Offset: 0x0003B3B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 910972, RefRangeEnd = 910973, XrefRangeStart = 910804, XrefRangeEnd = 910972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleDataSet(XmlSchemaElement node, bool isNewDataSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNewDataSet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleDataSet_Internal_Void_XmlSchemaElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0003D200 File Offset: 0x0003B400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 910997, RefRangeEnd = 910999, XrefRangeStart = 910973, XrefRangeEnd = 910997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTablesToList(List<DataTable> tableList, DataTable dt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tableList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_AddTablesToList_Private_Void_List_1_DataTable_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0003D254 File Offset: 0x0003B454
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 911016, RefRangeEnd = 911023, XrefRangeStart = 910999, XrefRangeEnd = 911016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPrefix(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_GetPrefix_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0003D29C File Offset: 0x0003B49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911023, XrefRangeEnd = 911040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNamespaceFromPrefix(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_GetNamespaceFromPrefix_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0003D2E4 File Offset: 0x0003B4E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 911050, RefRangeEnd = 911053, XrefRangeStart = 911040, XrefRangeEnd = 911050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTableNamespace(XmlSchemaIdentityConstraint key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_GetTableNamespace_Private_String_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0003D32C File Offset: 0x0003B52C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 911066, RefRangeEnd = 911071, XrefRangeStart = 911053, XrefRangeEnd = 911066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTableName(XmlSchemaIdentityConstraint key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_GetTableName_Private_String_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0003D374 File Offset: 0x0003B574
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 911092, RefRangeEnd = 911095, XrefRangeStart = 911071, XrefRangeEnd = 911092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTable(XmlSchemaElement node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_IsTable_Internal_Boolean_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0003D3C4 File Offset: 0x0003B5C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 911110, RefRangeEnd = 911115, XrefRangeStart = 911095, XrefRangeEnd = 911110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable HandleTable(XmlSchemaElement node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr_HandleTable_Internal_DataTable_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0003D414 File Offset: 0x0003B614
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XSDSchema()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0000596F File Offset: 0x00003B6F
		public XSDSchema(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0003D450 File Offset: 0x0003B650
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x00005978 File Offset: 0x00003B78
		public unsafe XmlSchemaSet _schemaSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__schemaSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__schemaSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0003D480 File Offset: 0x0003B680
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x00005997 File Offset: 0x00003B97
		public unsafe XmlSchemaElement _dsElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__dsElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__dsElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0003D4B0 File Offset: 0x0003B6B0
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x000059B6 File Offset: 0x00003BB6
		public unsafe DataSet _ds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__ds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__ds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0003D4E0 File Offset: 0x0003B6E0
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x000059D5 File Offset: 0x00003BD5
		public unsafe string _schemaName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__schemaName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__schemaName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0003D508 File Offset: 0x0003B708
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x000059F4 File Offset: 0x00003BF4
		public unsafe ArrayList _columnExpressions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__columnExpressions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__columnExpressions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0003D538 File Offset: 0x0003B738
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x00005A13 File Offset: 0x00003C13
		public unsafe Hashtable _constraintNodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__constraintNodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__constraintNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x0003D568 File Offset: 0x0003B768
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x00005A32 File Offset: 0x00003C32
		public unsafe ArrayList _refTables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__refTables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__refTables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0003D598 File Offset: 0x0003B798
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x00005A51 File Offset: 0x00003C51
		public unsafe ArrayList _complexTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__complexTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__complexTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0003D5C8 File Offset: 0x0003B7C8
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x00005A70 File Offset: 0x00003C70
		public unsafe XmlSchemaObjectCollection _annotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__annotations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__annotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0003D5F8 File Offset: 0x0003B7F8
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00005A8F File Offset: 0x00003C8F
		public unsafe XmlSchemaObjectCollection _elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0003D628 File Offset: 0x0003B828
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x00005AAE File Offset: 0x00003CAE
		public unsafe Hashtable _attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0003D658 File Offset: 0x0003B858
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x00005ACD File Offset: 0x00003CCD
		public unsafe Hashtable _elementsTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__elementsTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__elementsTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0003D688 File Offset: 0x0003B888
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00005AEC File Offset: 0x00003CEC
		public unsafe Hashtable _attributeGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__attributeGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__attributeGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0003D6B8 File Offset: 0x0003B8B8
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00005B0B File Offset: 0x00003D0B
		public unsafe Hashtable _schemaTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__schemaTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__schemaTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0003D6E8 File Offset: 0x0003B8E8
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00005B2A File Offset: 0x00003D2A
		public unsafe Hashtable _expressions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__expressions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__expressions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0003D718 File Offset: 0x0003B918
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00005B49 File Offset: 0x00003D49
		public unsafe Dictionary<DataTable, List<DataTable>> _tableDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__tableDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DataTable, List<DataTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__tableDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0003D748 File Offset: 0x0003B948
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00005B68 File Offset: 0x00003D68
		public unsafe Hashtable _udSimpleTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__udSimpleTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__udSimpleTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0003D778 File Offset: 0x0003B978
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00005B87 File Offset: 0x00003D87
		public unsafe Hashtable _existingSimpleTypeMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__existingSimpleTypeMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__existingSimpleTypeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0003D7A8 File Offset: 0x0003B9A8
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x00005BA6 File Offset: 0x00003DA6
		public unsafe bool _fromInference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__fromInference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NativeFieldInfoPtr__fromInference)) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0003D7D0 File Offset: 0x0003B9D0
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x00005BC1 File Offset: 0x00003DC1
		public unsafe static Il2CppReferenceArray<XSDSchema.NameType> s_mapNameTypeXsd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XSDSchema.NativeFieldInfoPtr_s_mapNameTypeXsd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XSDSchema.NameType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XSDSchema.NativeFieldInfoPtr_s_mapNameTypeXsd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr__schemaSet;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr__dsElement;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr__ds;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeFieldInfoPtr__schemaName;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeFieldInfoPtr__columnExpressions;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeFieldInfoPtr__constraintNodes;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeFieldInfoPtr__refTables;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeFieldInfoPtr__complexTypes;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeFieldInfoPtr__annotations;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeFieldInfoPtr__elements;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeFieldInfoPtr__attributes;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeFieldInfoPtr__elementsTable;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeFieldInfoPtr__attributeGroups;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeFieldInfoPtr__schemaTypes;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeFieldInfoPtr__expressions;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeFieldInfoPtr__tableDictionary;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeFieldInfoPtr__udSimpleTypes;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeFieldInfoPtr__existingSimpleTypeMap;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr__fromInference;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_s_mapNameTypeXsd;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_get_FromInference_Internal_get_Boolean_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_set_FromInference_Internal_set_Void_Boolean_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_CollectElementsAnnotations_Private_Void_XmlSchema_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_CollectElementsAnnotations_Private_Void_XmlSchema_ArrayList_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_QualifiedName_Internal_Static_String_String_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Internal_Static_Void_Object_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_SetExtProperties_Private_Static_Void_Object_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_HandleColumnExpression_Private_Void_Object_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_GetMsdataAttribute_Internal_Static_String_XmlSchemaAnnotated_String_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_SetExtProperties_Private_Static_Void_Object_XmlAttributeCollection_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_HandleRefTableProperties_Internal_Void_ArrayList_XmlSchemaElement_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_HandleRelation_Internal_Void_XmlElement_Boolean_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_HasAttributes_Private_Boolean_XmlSchemaObjectCollection_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_IsDatasetParticle_Private_Boolean_XmlSchemaParticle_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_DatasetElementCount_Private_Int32_XmlSchemaObjectCollection_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_FindDatasetElement_Private_XmlSchemaElement_XmlSchemaObjectCollection_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchema_Public_Void_XmlSchemaSet_DataTable_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchema_Public_Void_XmlSchemaSet_DataSet_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_HandleRelations_Private_Void_XmlSchemaAnnotation_Boolean_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_GetParticleItems_Internal_XmlSchemaObjectCollection_XmlSchemaParticle_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_HandleParticle_Internal_Void_XmlSchemaParticle_DataTable_ArrayList_Boolean_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_HandleAttributes_Internal_Void_XmlSchemaObjectCollection_DataTable_Boolean_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_HandleAttributeGroup_Private_Void_XmlSchemaAttributeGroup_DataTable_Boolean_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_HandleComplexType_Internal_Void_XmlSchemaComplexType_DataTable_ArrayList_Boolean_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_GetParticle_Internal_XmlSchemaParticle_XmlSchemaComplexType_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_FindField_Internal_DataColumn_DataTable_String_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_BuildKey_Internal_Il2CppReferenceArray_1_DataColumn_XmlSchemaIdentityConstraint_DataTable_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_GetBooleanAttribute_Internal_Boolean_XmlSchemaAnnotated_String_Boolean_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_GetStringAttribute_Internal_String_XmlSchemaAnnotated_String_String_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_TranslateAcceptRejectRule_Internal_Static_AcceptRejectRule_String_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_TranslateRule_Internal_Static_Rule_String_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_HandleKeyref_Internal_Void_XmlSchemaKeyref_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_HandleConstraint_Internal_Void_XmlSchemaIdentityConstraint_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateSimpleTable_Internal_DataTable_XmlSchemaElement_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceName_Internal_String_XmlSchemaAnnotated_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTable_Internal_DataTable_XmlSchemaElement_XmlSchemaComplexType_Boolean_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_XsdtoClr_Public_Static_Type_String_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_FindNameType_Private_Static_NameType_String_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_ParseDataType_Private_Type_String_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_IsXsdType_Internal_Static_Boolean_String_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_FindTypeNode_Internal_XmlSchemaAnnotated_XmlSchemaAnnotated_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_HandleSimpleTypeSimpleContentColumn_Internal_Void_XmlSchemaSimpleType_String_DataTable_Boolean_Il2CppReferenceArray_1_XmlAttribute_Boolean_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_HandleSimpleContentColumn_Internal_Void_String_DataTable_Boolean_Il2CppReferenceArray_1_XmlAttribute_Boolean_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_HandleAttributeColumn_Internal_Void_XmlSchemaAttribute_DataTable_Boolean_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_HandleElementColumn_Internal_Void_XmlSchemaElement_DataTable_Boolean_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_HandleDataSet_Internal_Void_XmlSchemaElement_Boolean_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_AddTablesToList_Private_Void_List_1_DataTable_DataTable_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefix_Private_String_String_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespaceFromPrefix_Private_String_String_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_GetTableNamespace_Private_String_XmlSchemaIdentityConstraint_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_GetTableName_Private_String_XmlSchemaIdentityConstraint_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_IsTable_Internal_Boolean_XmlSchemaElement_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_HandleTable_Internal_DataTable_XmlSchemaElement_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000F0 RID: 240
		public sealed class NameType : Object
		{
			// Token: 0x0600151E RID: 5406 RVA: 0x000641D8 File Offset: 0x000623D8
			// Note: this type is marked as 'beforefieldinit'.
			static NameType()
			{
				Il2CppClassPointerStore<XSDSchema.NameType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XSDSchema>.NativeClassPtr, "NameType");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XSDSchema.NameType>.NativeClassPtr);
				XSDSchema.NameType.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema.NameType>.NativeClassPtr, "name");
				XSDSchema.NameType.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XSDSchema.NameType>.NativeClassPtr, "type");
				XSDSchema.NameType.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema.NameType>.NativeClassPtr, 100665288);
				XSDSchema.NameType.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XSDSchema.NameType>.NativeClassPtr, 100665289);
			}

			// Token: 0x0600151F RID: 5407 RVA: 0x00064254 File Offset: 0x00062454
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameType(string n, Type t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XSDSchema.NameType>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NameType.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001520 RID: 5408 RVA: 0x000642B4 File Offset: 0x000624B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 908735, XrefRangeEnd = 908739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int CompareTo(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XSDSchema.NameType.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001521 RID: 5409 RVA: 0x00008033 File Offset: 0x00006233
			public NameType(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004D1 RID: 1233
			// (get) Token: 0x06001522 RID: 5410 RVA: 0x00064304 File Offset: 0x00062504
			// (set) Token: 0x06001523 RID: 5411 RVA: 0x0000803C File Offset: 0x0000623C
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NameType.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NameType.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170004D2 RID: 1234
			// (get) Token: 0x06001524 RID: 5412 RVA: 0x0006432C File Offset: 0x0006252C
			// (set) Token: 0x06001525 RID: 5413 RVA: 0x0000805B File Offset: 0x0000625B
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NameType.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XSDSchema.NameType.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001183 RID: 4483
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04001184 RID: 4484
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001185 RID: 4485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_0;

			// Token: 0x04001186 RID: 4486
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;
		}
	}
}
