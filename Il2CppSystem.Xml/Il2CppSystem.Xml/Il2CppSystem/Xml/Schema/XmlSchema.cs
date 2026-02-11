using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000196 RID: 406
	public class XmlSchema : XmlSchemaObject
	{
		// Token: 0x0600232D RID: 9005 RVA: 0x000A7FC4 File Offset: 0x000A61C4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchema()
		{
			Il2CppClassPointerStore<XmlSchema>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchema");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr);
			XmlSchema.NativeFieldInfoPtr_attributeFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "attributeFormDefault");
			XmlSchema.NativeFieldInfoPtr_elementFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "elementFormDefault");
			XmlSchema.NativeFieldInfoPtr_blockDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "blockDefault");
			XmlSchema.NativeFieldInfoPtr_finalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "finalDefault");
			XmlSchema.NativeFieldInfoPtr_targetNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "targetNs");
			XmlSchema.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "version");
			XmlSchema.NativeFieldInfoPtr_includes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "includes");
			XmlSchema.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "items");
			XmlSchema.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "id");
			XmlSchema.NativeFieldInfoPtr_moreAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "moreAttributes");
			XmlSchema.NativeFieldInfoPtr_isCompiled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "isCompiled");
			XmlSchema.NativeFieldInfoPtr_isCompiledBySet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "isCompiledBySet");
			XmlSchema.NativeFieldInfoPtr_isPreprocessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "isPreprocessed");
			XmlSchema.NativeFieldInfoPtr_isRedefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "isRedefined");
			XmlSchema.NativeFieldInfoPtr_errorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "errorCount");
			XmlSchema.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "attributes");
			XmlSchema.NativeFieldInfoPtr_attributeGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "attributeGroups");
			XmlSchema.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "elements");
			XmlSchema.NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "types");
			XmlSchema.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "groups");
			XmlSchema.NativeFieldInfoPtr_notations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "notations");
			XmlSchema.NativeFieldInfoPtr_identityConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "identityConstraints");
			XmlSchema.NativeFieldInfoPtr_globalIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "globalIdCounter");
			XmlSchema.NativeFieldInfoPtr_importedSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "importedSchemas");
			XmlSchema.NativeFieldInfoPtr_importedNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "importedNamespaces");
			XmlSchema.NativeFieldInfoPtr_schemaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "schemaId");
			XmlSchema.NativeFieldInfoPtr_baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "baseUri");
			XmlSchema.NativeFieldInfoPtr_isChameleon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "isChameleon");
			XmlSchema.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "ids");
			XmlSchema.NativeFieldInfoPtr_document = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, "document");
			XmlSchema.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668418);
			XmlSchema.NativeMethodInfoPtr_Read_Public_Static_XmlSchema_XmlReader_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668419);
			XmlSchema.NativeMethodInfoPtr_CompileSchema_Internal_Boolean_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668420);
			XmlSchema.NativeMethodInfoPtr_CompileSchemaInSet_Internal_Void_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668421);
			XmlSchema.NativeMethodInfoPtr_get_AttributeFormDefault_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668422);
			XmlSchema.NativeMethodInfoPtr_set_AttributeFormDefault_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668423);
			XmlSchema.NativeMethodInfoPtr_get_BlockDefault_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668424);
			XmlSchema.NativeMethodInfoPtr_set_BlockDefault_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668425);
			XmlSchema.NativeMethodInfoPtr_get_FinalDefault_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668426);
			XmlSchema.NativeMethodInfoPtr_set_FinalDefault_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668427);
			XmlSchema.NativeMethodInfoPtr_get_ElementFormDefault_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668428);
			XmlSchema.NativeMethodInfoPtr_set_ElementFormDefault_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668429);
			XmlSchema.NativeMethodInfoPtr_get_TargetNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668430);
			XmlSchema.NativeMethodInfoPtr_set_TargetNamespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668431);
			XmlSchema.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668432);
			XmlSchema.NativeMethodInfoPtr_set_Version_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668433);
			XmlSchema.NativeMethodInfoPtr_get_Includes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668434);
			XmlSchema.NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668435);
			XmlSchema.NativeMethodInfoPtr_get_IsCompiledBySet_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668436);
			XmlSchema.NativeMethodInfoPtr_set_IsCompiledBySet_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668437);
			XmlSchema.NativeMethodInfoPtr_get_IsPreprocessed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668438);
			XmlSchema.NativeMethodInfoPtr_set_IsPreprocessed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668439);
			XmlSchema.NativeMethodInfoPtr_get_IsRedefined_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668440);
			XmlSchema.NativeMethodInfoPtr_set_IsRedefined_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668441);
			XmlSchema.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668442);
			XmlSchema.NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668443);
			XmlSchema.NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668444);
			XmlSchema.NativeMethodInfoPtr_get_Elements_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668445);
			XmlSchema.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668446);
			XmlSchema.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668447);
			XmlSchema.NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668448);
			XmlSchema.NativeMethodInfoPtr_get_Notations_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668449);
			XmlSchema.NativeMethodInfoPtr_get_IdentityConstraints_Internal_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668450);
			XmlSchema.NativeMethodInfoPtr_get_BaseUri_Internal_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668451);
			XmlSchema.NativeMethodInfoPtr_set_BaseUri_Internal_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668452);
			XmlSchema.NativeMethodInfoPtr_get_SchemaId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668453);
			XmlSchema.NativeMethodInfoPtr_get_IsChameleon_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668454);
			XmlSchema.NativeMethodInfoPtr_set_IsChameleon_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668455);
			XmlSchema.NativeMethodInfoPtr_get_Ids_Internal_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668456);
			XmlSchema.NativeMethodInfoPtr_get_Document_Internal_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668457);
			XmlSchema.NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668458);
			XmlSchema.NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668459);
			XmlSchema.NativeMethodInfoPtr_Clone_Internal_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668460);
			XmlSchema.NativeMethodInfoPtr_DeepClone_Internal_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668461);
			XmlSchema.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668462);
			XmlSchema.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668463);
			XmlSchema.NativeMethodInfoPtr_SetIsCompiled_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668464);
			XmlSchema.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668465);
			XmlSchema.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668466);
			XmlSchema.NativeMethodInfoPtr_get_ImportedSchemas_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668467);
			XmlSchema.NativeMethodInfoPtr_get_ImportedNamespaces_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668468);
			XmlSchema.NativeMethodInfoPtr_GetExternalSchemasList_Internal_Void_IList_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr, 100668469);
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x000A865C File Offset: 0x000A685C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 410553, RefRangeEnd = 410559, XrefRangeStart = 410513, XrefRangeEnd = 410553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchema>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x000A8698 File Offset: 0x000A6898
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 410568, RefRangeEnd = 410572, XrefRangeStart = 410559, XrefRangeEnd = 410568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validationEventHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_Read_Public_Static_XmlSchema_XmlReader_ValidationEventHandler_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x000A86F0 File Offset: 0x000A68F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410589, RefRangeEnd = 410591, XrefRangeStart = 410572, XrefRangeEnd = 410589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xsc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validationEventHandler);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CompileContentModel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_CompileSchema_Internal_Boolean_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x000A87A8 File Offset: 0x000A69A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410597, RefRangeEnd = 410598, XrefRangeStart = 410591, XrefRangeEnd = 410597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compilationSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_CompileSchemaInSet_Internal_Void_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000A8810 File Offset: 0x000A6A10
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x000A884C File Offset: 0x000A6A4C
		public unsafe XmlSchemaForm AttributeFormDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_AttributeFormDefault_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_AttributeFormDefault_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000A888C File Offset: 0x000A6A8C
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x000A88C8 File Offset: 0x000A6AC8
		public unsafe XmlSchemaDerivationMethod BlockDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_BlockDefault_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_BlockDefault_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000A8908 File Offset: 0x000A6B08
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x000A8944 File Offset: 0x000A6B44
		public unsafe XmlSchemaDerivationMethod FinalDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_FinalDefault_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_FinalDefault_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x000A8984 File Offset: 0x000A6B84
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x000A89C0 File Offset: 0x000A6BC0
		public unsafe XmlSchemaForm ElementFormDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_ElementFormDefault_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_ElementFormDefault_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000A8A00 File Offset: 0x000A6C00
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x000A8A38 File Offset: 0x000A6C38
		public unsafe string TargetNamespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_TargetNamespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_TargetNamespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x000A8A7C File Offset: 0x000A6C7C
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x000A8AB4 File Offset: 0x000A6CB4
		public unsafe string Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_Version_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x000A8AF8 File Offset: 0x000A6CF8
		public unsafe XmlSchemaObjectCollection Includes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Includes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000A8B38 File Offset: 0x000A6D38
		public unsafe XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x000A8B78 File Offset: 0x000A6D78
		// (set) Token: 0x06002341 RID: 9025 RVA: 0x000A8BB4 File Offset: 0x000A6DB4
		public unsafe bool IsCompiledBySet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_IsCompiledBySet_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_IsCompiledBySet_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x000A8BF4 File Offset: 0x000A6DF4
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x000A8C30 File Offset: 0x000A6E30
		public unsafe bool IsPreprocessed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_IsPreprocessed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_IsPreprocessed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x000A8C70 File Offset: 0x000A6E70
		// (set) Token: 0x06002345 RID: 9029 RVA: 0x000A8CAC File Offset: 0x000A6EAC
		public unsafe bool IsRedefined
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_IsRedefined_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_IsRedefined_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x000A8CEC File Offset: 0x000A6EEC
		public unsafe XmlSchemaObjectTable Attributes
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 410603, RefRangeEnd = 410619, XrefRangeStart = 410598, XrefRangeEnd = 410603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000A8D2C File Offset: 0x000A6F2C
		public unsafe XmlSchemaObjectTable AttributeGroups
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 410624, RefRangeEnd = 410643, XrefRangeStart = 410619, XrefRangeEnd = 410624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x000A8D6C File Offset: 0x000A6F6C
		public unsafe XmlSchemaObjectTable SchemaTypes
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 410648, RefRangeEnd = 410688, XrefRangeStart = 410643, XrefRangeEnd = 410648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x000A8DAC File Offset: 0x000A6FAC
		public unsafe XmlSchemaObjectTable Elements
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 410693, RefRangeEnd = 410715, XrefRangeStart = 410688, XrefRangeEnd = 410693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Elements_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x000A8DEC File Offset: 0x000A6FEC
		// (set) Token: 0x0600234B RID: 9035 RVA: 0x000A8E24 File Offset: 0x000A7024
		public unsafe string Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x000A8E68 File Offset: 0x000A7068
		public unsafe XmlSchemaObjectTable Groups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x000A8EA8 File Offset: 0x000A70A8
		public unsafe XmlSchemaObjectTable Notations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Notations_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x000A8EE8 File Offset: 0x000A70E8
		public unsafe XmlSchemaObjectTable IdentityConstraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_IdentityConstraints_Internal_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x000A8F28 File Offset: 0x000A7128
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x000A8F68 File Offset: 0x000A7168
		public unsafe Uri BaseUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_BaseUri_Internal_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_BaseUri_Internal_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x000A8FAC File Offset: 0x000A71AC
		public unsafe int SchemaId
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 410720, RefRangeEnd = 410745, XrefRangeStart = 410715, XrefRangeEnd = 410720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_SchemaId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x000A8FE8 File Offset: 0x000A71E8
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x000A9024 File Offset: 0x000A7224
		public unsafe bool IsChameleon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_IsChameleon_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_IsChameleon_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x000A9064 File Offset: 0x000A7264
		public unsafe Hashtable Ids
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Ids_Internal_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x000A90A4 File Offset: 0x000A72A4
		public unsafe XmlDocument Document
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410745, XrefRangeEnd = 410750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_Document_Internal_get_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x000A90E4 File Offset: 0x000A72E4
		// (set) Token: 0x06002357 RID: 9047 RVA: 0x000A9120 File Offset: 0x000A7320
		public unsafe int ErrorCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x000A9160 File Offset: 0x000A7360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410766, RefRangeEnd = 410767, XrefRangeStart = 410750, XrefRangeEnd = 410766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe XmlSchema Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_Clone_Internal_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x000A91A0 File Offset: 0x000A73A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410806, RefRangeEnd = 410807, XrefRangeStart = 410767, XrefRangeEnd = 410806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema DeepClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_DeepClone_Internal_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x000A91E0 File Offset: 0x000A73E0
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x000A9224 File Offset: 0x000A7424
		public unsafe override string IdAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchema.NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchema.NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x000A9274 File Offset: 0x000A7474
		[CallerCount(0)]
		public unsafe void SetIsCompiled(bool isCompiled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isCompiled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_SetIsCompiled_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x000A92B4 File Offset: 0x000A74B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetUnhandledAttributes(Il2CppReferenceArray<XmlAttribute> moreAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moreAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchema.NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x000A9304 File Offset: 0x000A7504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410807, XrefRangeEnd = 410812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchema.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x000A9354 File Offset: 0x000A7554
		public unsafe ArrayList ImportedSchemas
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 410817, RefRangeEnd = 410835, XrefRangeStart = 410812, XrefRangeEnd = 410817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_ImportedSchemas_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x000A9394 File Offset: 0x000A7594
		public unsafe ArrayList ImportedNamespaces
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 410840, RefRangeEnd = 410849, XrefRangeStart = 410835, XrefRangeEnd = 410840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_get_ImportedNamespaces_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x000A93D4 File Offset: 0x000A75D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410860, RefRangeEnd = 410862, XrefRangeStart = 410849, XrefRangeEnd = 410860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetExternalSchemasList(IList extList, XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchema.NativeMethodInfoPtr_GetExternalSchemasList_Internal_Void_IList_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x0000EE3E File Offset: 0x0000D03E
		public XmlSchema(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x000A9428 File Offset: 0x000A7628
		// (set) Token: 0x06002364 RID: 9060 RVA: 0x0000EE47 File Offset: 0x0000D047
		public unsafe XmlSchemaForm attributeFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributeFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributeFormDefault)) = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x000A9450 File Offset: 0x000A7650
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x0000EE62 File Offset: 0x0000D062
		public unsafe XmlSchemaForm elementFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_elementFormDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_elementFormDefault)) = value;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x000A9478 File Offset: 0x000A7678
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x0000EE7D File Offset: 0x0000D07D
		public unsafe XmlSchemaDerivationMethod blockDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_blockDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_blockDefault)) = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x000A94A0 File Offset: 0x000A76A0
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x0000EE98 File Offset: 0x0000D098
		public unsafe XmlSchemaDerivationMethod finalDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_finalDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_finalDefault)) = value;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x000A94C8 File Offset: 0x000A76C8
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x0000EEB3 File Offset: 0x0000D0B3
		public unsafe string targetNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_targetNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_targetNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000A94F0 File Offset: 0x000A76F0
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x0000EED2 File Offset: 0x0000D0D2
		public unsafe string version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x000A9518 File Offset: 0x000A7718
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x0000EEF1 File Offset: 0x0000D0F1
		public unsafe XmlSchemaObjectCollection includes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_includes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_includes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x000A9548 File Offset: 0x000A7748
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x0000EF10 File Offset: 0x0000D110
		public unsafe XmlSchemaObjectCollection items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x000A9578 File Offset: 0x000A7778
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x0000EF2F File Offset: 0x0000D12F
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x000A95A0 File Offset: 0x000A77A0
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x0000EF4E File Offset: 0x0000D14E
		public unsafe Il2CppReferenceArray<XmlAttribute> moreAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_moreAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_moreAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x000A95D0 File Offset: 0x000A77D0
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x0000EF6D File Offset: 0x0000D16D
		public unsafe bool isCompiled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isCompiled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isCompiled)) = value;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x000A95F8 File Offset: 0x000A77F8
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x0000EF88 File Offset: 0x0000D188
		public unsafe bool isCompiledBySet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isCompiledBySet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isCompiledBySet)) = value;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x000A9620 File Offset: 0x000A7820
		// (set) Token: 0x0600237C RID: 9084 RVA: 0x0000EFA3 File Offset: 0x0000D1A3
		public unsafe bool isPreprocessed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isPreprocessed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isPreprocessed)) = value;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x000A9648 File Offset: 0x000A7848
		// (set) Token: 0x0600237E RID: 9086 RVA: 0x0000EFBE File Offset: 0x0000D1BE
		public unsafe bool isRedefined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isRedefined);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isRedefined)) = value;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x000A9670 File Offset: 0x000A7870
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x0000EFD9 File Offset: 0x0000D1D9
		public unsafe int errorCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_errorCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_errorCount)) = value;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x000A9698 File Offset: 0x000A7898
		// (set) Token: 0x06002382 RID: 9090 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
		public unsafe XmlSchemaObjectTable attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x000A96C8 File Offset: 0x000A78C8
		// (set) Token: 0x06002384 RID: 9092 RVA: 0x0000F013 File Offset: 0x0000D213
		public unsafe XmlSchemaObjectTable attributeGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributeGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_attributeGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x000A96F8 File Offset: 0x000A78F8
		// (set) Token: 0x06002386 RID: 9094 RVA: 0x0000F032 File Offset: 0x0000D232
		public unsafe XmlSchemaObjectTable elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x000A9728 File Offset: 0x000A7928
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x0000F051 File Offset: 0x0000D251
		public unsafe XmlSchemaObjectTable types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x000A9758 File Offset: 0x000A7958
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x0000F070 File Offset: 0x0000D270
		public unsafe XmlSchemaObjectTable groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x000A9788 File Offset: 0x000A7988
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x0000F08F File Offset: 0x0000D28F
		public unsafe XmlSchemaObjectTable notations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_notations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_notations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x000A97B8 File Offset: 0x000A79B8
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x0000F0AE File Offset: 0x0000D2AE
		public unsafe XmlSchemaObjectTable identityConstraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_identityConstraints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_identityConstraints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x000A97E8 File Offset: 0x000A79E8
		// (set) Token: 0x06002390 RID: 9104 RVA: 0x0000F0CD File Offset: 0x0000D2CD
		public unsafe static int globalIdCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XmlSchema.NativeFieldInfoPtr_globalIdCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchema.NativeFieldInfoPtr_globalIdCounter, (void*)(&value));
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x000A9804 File Offset: 0x000A7A04
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x0000F0DB File Offset: 0x0000D2DB
		public unsafe ArrayList importedSchemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_importedSchemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_importedSchemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x000A9834 File Offset: 0x000A7A34
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x0000F0FA File Offset: 0x0000D2FA
		public unsafe ArrayList importedNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_importedNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_importedNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x000A9864 File Offset: 0x000A7A64
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x0000F119 File Offset: 0x0000D319
		public unsafe int schemaId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_schemaId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_schemaId)) = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x000A988C File Offset: 0x000A7A8C
		// (set) Token: 0x06002398 RID: 9112 RVA: 0x0000F134 File Offset: 0x0000D334
		public unsafe Uri baseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_baseUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_baseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x000A98BC File Offset: 0x000A7ABC
		// (set) Token: 0x0600239A RID: 9114 RVA: 0x0000F153 File Offset: 0x0000D353
		public unsafe bool isChameleon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isChameleon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_isChameleon)) = value;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x000A98E4 File Offset: 0x000A7AE4
		// (set) Token: 0x0600239C RID: 9116 RVA: 0x0000F16E File Offset: 0x0000D36E
		public unsafe Hashtable ids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_ids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x000A9914 File Offset: 0x000A7B14
		// (set) Token: 0x0600239E RID: 9118 RVA: 0x0000F18D File Offset: 0x0000D38D
		public unsafe XmlDocument document
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_document);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchema.NativeFieldInfoPtr_document), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeFieldInfoPtr_attributeFormDefault;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeFieldInfoPtr_elementFormDefault;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeFieldInfoPtr_blockDefault;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr_finalDefault;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeFieldInfoPtr_targetNs;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeFieldInfoPtr_includes;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeFieldInfoPtr_moreAttributes;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeFieldInfoPtr_isCompiled;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeFieldInfoPtr_isCompiledBySet;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeFieldInfoPtr_isPreprocessed;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeFieldInfoPtr_isRedefined;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeFieldInfoPtr_errorCount;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeFieldInfoPtr_attributeGroups;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeFieldInfoPtr_types;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeFieldInfoPtr_notations;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeFieldInfoPtr_identityConstraints;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeFieldInfoPtr_globalIdCounter;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeFieldInfoPtr_importedSchemas;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeFieldInfoPtr_importedNamespaces;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeFieldInfoPtr_schemaId;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeFieldInfoPtr_baseUri;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeFieldInfoPtr_isChameleon;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeFieldInfoPtr_ids;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeFieldInfoPtr_document;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_XmlSchema_XmlReader_ValidationEventHandler_0;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeMethodInfoPtr_CompileSchema_Internal_Boolean_XmlSchemaCollection_XmlResolver_SchemaInfo_String_ValidationEventHandler_XmlNameTable_Boolean_0;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeMethodInfoPtr_CompileSchemaInSet_Internal_Void_XmlNameTable_ValidationEventHandler_XmlSchemaCompilationSettings_0;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeFormDefault_Public_get_XmlSchemaForm_0;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeMethodInfoPtr_set_AttributeFormDefault_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockDefault_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockDefault_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalDefault_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_set_FinalDefault_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementFormDefault_Public_get_XmlSchemaForm_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementFormDefault_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetNamespace_Public_get_String_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetNamespace_Public_set_Void_String_0;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Public_set_Void_String_0;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeMethodInfoPtr_get_Includes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompiledBySet_Internal_get_Boolean_0;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCompiledBySet_Internal_set_Void_Boolean_0;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPreprocessed_Internal_get_Boolean_0;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPreprocessed_Internal_set_Void_Boolean_0;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRedefined_Internal_get_Boolean_0;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRedefined_Internal_set_Void_Boolean_0;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_get_Elements_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_get_Notations_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr_get_IdentityConstraints_Internal_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Internal_get_Uri_0;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseUri_Internal_set_Void_Uri_0;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaId_Internal_get_Int32_0;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChameleon_Internal_get_Boolean_0;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_set_IsChameleon_Internal_set_Void_Boolean_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_get_Ids_Internal_get_Hashtable_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Internal_get_XmlDocument_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_XmlSchema_0;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Internal_XmlSchema_0;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr_get_IdAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_set_IdAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_SetIsCompiled_Internal_Void_Boolean_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr_SetUnhandledAttributes_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlAttribute_0;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr_get_ImportedSchemas_Internal_get_ArrayList_0;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr_get_ImportedNamespaces_Internal_get_ArrayList_0;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr_GetExternalSchemasList_Internal_Void_IList_XmlSchema_0;
	}
}
