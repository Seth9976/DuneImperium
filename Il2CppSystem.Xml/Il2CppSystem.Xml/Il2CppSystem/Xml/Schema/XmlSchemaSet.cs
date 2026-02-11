using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D6 RID: 470
	public class XmlSchemaSet : Object
	{
		// Token: 0x06002754 RID: 10068 RVA: 0x000B7960 File Offset: 0x000B5B60
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSet()
		{
			Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr);
			XmlSchemaSet.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "nameTable");
			XmlSchemaSet.NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemaNames");
			XmlSchemaSet.NativeFieldInfoPtr_schemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemas");
			XmlSchemaSet.NativeFieldInfoPtr_internalEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "internalEventHandler");
			XmlSchemaSet.NativeFieldInfoPtr_eventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "eventHandler");
			XmlSchemaSet.NativeFieldInfoPtr_isCompiled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "isCompiled");
			XmlSchemaSet.NativeFieldInfoPtr_schemaLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemaLocations");
			XmlSchemaSet.NativeFieldInfoPtr_chameleonSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "chameleonSchemas");
			XmlSchemaSet.NativeFieldInfoPtr_targetNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "targetNamespaces");
			XmlSchemaSet.NativeFieldInfoPtr_compileAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "compileAll");
			XmlSchemaSet.NativeFieldInfoPtr_cachedCompiledInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "cachedCompiledInfo");
			XmlSchemaSet.NativeFieldInfoPtr_readerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "readerSettings");
			XmlSchemaSet.NativeFieldInfoPtr_schemaForSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemaForSchema");
			XmlSchemaSet.NativeFieldInfoPtr_compilationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "compilationSettings");
			XmlSchemaSet.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "elements");
			XmlSchemaSet.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "attributes");
			XmlSchemaSet.NativeFieldInfoPtr_schemaTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemaTypes");
			XmlSchemaSet.NativeFieldInfoPtr_substitutionGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "substitutionGroups");
			XmlSchemaSet.NativeFieldInfoPtr_typeExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "typeExtensions");
			XmlSchemaSet.NativeFieldInfoPtr_internalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "internalSyncObject");
			XmlSchemaSet.NativeMethodInfoPtr_get_InternalSyncObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668994);
			XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668995);
			XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668996);
			XmlSchemaSet.NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668997);
			XmlSchemaSet.NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668998);
			XmlSchemaSet.NativeMethodInfoPtr_get_IsCompiled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100668999);
			XmlSchemaSet.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669000);
			XmlSchemaSet.NativeMethodInfoPtr_get_CompilationSettings_Public_get_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669001);
			XmlSchemaSet.NativeMethodInfoPtr_set_CompilationSettings_Public_set_Void_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669002);
			XmlSchemaSet.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669003);
			XmlSchemaSet.NativeMethodInfoPtr_get_GlobalElements_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669004);
			XmlSchemaSet.NativeMethodInfoPtr_get_GlobalAttributes_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669005);
			XmlSchemaSet.NativeMethodInfoPtr_get_GlobalTypes_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669006);
			XmlSchemaSet.NativeMethodInfoPtr_get_SubstitutionGroups_Internal_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669007);
			XmlSchemaSet.NativeMethodInfoPtr_get_SchemaLocations_Internal_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669008);
			XmlSchemaSet.NativeMethodInfoPtr_get_TypeExtensions_Internal_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669009);
			XmlSchemaSet.NativeMethodInfoPtr_Add_Public_Void_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669010);
			XmlSchemaSet.NativeMethodInfoPtr_Add_Public_XmlSchema_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669011);
			XmlSchemaSet.NativeMethodInfoPtr_RemoveRecursive_Public_Boolean_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669012);
			XmlSchemaSet.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669013);
			XmlSchemaSet.NativeMethodInfoPtr_Compile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669014);
			XmlSchemaSet.NativeMethodInfoPtr_Reprocess_Public_XmlSchema_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669015);
			XmlSchemaSet.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_XmlSchema_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669016);
			XmlSchemaSet.NativeMethodInfoPtr_Schemas_Public_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669017);
			XmlSchemaSet.NativeMethodInfoPtr_Schemas_Public_ICollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669018);
			XmlSchemaSet.NativeMethodInfoPtr_Add_Private_XmlSchema_String_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669019);
			XmlSchemaSet.NativeMethodInfoPtr_Add_Internal_Void_String_XmlReader_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669020);
			XmlSchemaSet.NativeMethodInfoPtr_FindSchemaByNSAndUrl_Internal_XmlSchema_Uri_String_Il2CppReferenceArray_1_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669021);
			XmlSchemaSet.NativeMethodInfoPtr_AddSchemaToSet_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669022);
			XmlSchemaSet.NativeMethodInfoPtr_ProcessNewSubstitutionGroups_Private_Void_XmlSchemaObjectTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669023);
			XmlSchemaSet.NativeMethodInfoPtr_ResolveSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669024);
			XmlSchemaSet.NativeMethodInfoPtr_Remove_Internal_XmlSchema_XmlSchema_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669025);
			XmlSchemaSet.NativeMethodInfoPtr_ClearTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669026);
			XmlSchemaSet.NativeMethodInfoPtr_PreprocessSchema_Internal_Boolean_byref_XmlSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669027);
			XmlSchemaSet.NativeMethodInfoPtr_ParseSchema_Internal_XmlSchema_String_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669028);
			XmlSchemaSet.NativeMethodInfoPtr_CopyFromCompiledSet_Internal_Void_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669029);
			XmlSchemaSet.NativeMethodInfoPtr_get_CompiledInfo_Internal_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669030);
			XmlSchemaSet.NativeMethodInfoPtr_get_ReaderSettings_Internal_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669031);
			XmlSchemaSet.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669032);
			XmlSchemaSet.NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669033);
			XmlSchemaSet.NativeMethodInfoPtr_GetSchemaNames_Internal_SchemaNames_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669034);
			XmlSchemaSet.NativeMethodInfoPtr_IsSchemaLoaded_Internal_Boolean_Uri_String_byref_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669035);
			XmlSchemaSet.NativeMethodInfoPtr_GetSchemaByUri_Internal_Boolean_Uri_byref_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669036);
			XmlSchemaSet.NativeMethodInfoPtr_GetTargetNamespace_Internal_String_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669037);
			XmlSchemaSet.NativeMethodInfoPtr_get_SortedSchemas_Internal_get_SortedList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669038);
			XmlSchemaSet.NativeMethodInfoPtr_RemoveSchemaFromCaches_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669039);
			XmlSchemaSet.NativeMethodInfoPtr_RemoveSchemaFromGlobalTables_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669040);
			XmlSchemaSet.NativeMethodInfoPtr_AddToTable_Private_Boolean_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669041);
			XmlSchemaSet.NativeMethodInfoPtr_VerifyTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669042);
			XmlSchemaSet.NativeMethodInfoPtr_InternalValidationCallback_Private_Void_Object_ValidationEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669043);
			XmlSchemaSet.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100669044);
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x000B7F1C File Offset: 0x000B611C
		public unsafe Object InternalSyncObject
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 413323, RefRangeEnd = 413329, XrefRangeStart = 413318, XrefRangeEnd = 413323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_InternalSyncObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x000B7F5C File Offset: 0x000B615C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 413334, RefRangeEnd = 413338, XrefRangeStart = 413329, XrefRangeEnd = 413334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x000B7F98 File Offset: 0x000B6198
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 413388, RefRangeEnd = 413393, XrefRangeStart = 413338, XrefRangeEnd = 413388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSet(XmlNameTable nameTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x000B7FE4 File Offset: 0x000B61E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413393, XrefRangeEnd = 413405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValidationEventHandler(ValidationEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x000B8028 File Offset: 0x000B6228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413405, XrefRangeEnd = 413412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValidationEventHandler(ValidationEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x000B806C File Offset: 0x000B626C
		public unsafe bool IsCompiled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_IsCompiled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x000B80A8 File Offset: 0x000B62A8
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413412, XrefRangeEnd = 413414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x000B80EC File Offset: 0x000B62EC
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x000B812C File Offset: 0x000B632C
		public unsafe XmlSchemaCompilationSettings CompilationSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_CompilationSettings_Public_get_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaCompilationSettings>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_set_CompilationSettings_Public_set_Void_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x000B8170 File Offset: 0x000B6370
		public unsafe int Count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 413415, RefRangeEnd = 413417, XrefRangeStart = 413414, XrefRangeEnd = 413415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000B81AC File Offset: 0x000B63AC
		public unsafe XmlSchemaObjectTable GlobalElements
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 413422, RefRangeEnd = 413426, XrefRangeStart = 413417, XrefRangeEnd = 413422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_GlobalElements_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x000B81EC File Offset: 0x000B63EC
		public unsafe XmlSchemaObjectTable GlobalAttributes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 413431, RefRangeEnd = 413434, XrefRangeStart = 413426, XrefRangeEnd = 413431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_GlobalAttributes_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x000B822C File Offset: 0x000B642C
		public unsafe XmlSchemaObjectTable GlobalTypes
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 413439, RefRangeEnd = 413444, XrefRangeStart = 413434, XrefRangeEnd = 413439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_GlobalTypes_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000B826C File Offset: 0x000B646C
		public unsafe XmlSchemaObjectTable SubstitutionGroups
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 413449, RefRangeEnd = 413453, XrefRangeStart = 413444, XrefRangeEnd = 413449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_SubstitutionGroups_Internal_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x000B82AC File Offset: 0x000B64AC
		public unsafe Hashtable SchemaLocations
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_SchemaLocations_Internal_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000B82EC File Offset: 0x000B64EC
		public unsafe XmlSchemaObjectTable TypeExtensions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413453, XrefRangeEnd = 413458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_TypeExtensions_Internal_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000B832C File Offset: 0x000B652C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 413526, RefRangeEnd = 413529, XrefRangeStart = 413458, XrefRangeEnd = 413526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(XmlSchemaSet schemas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Add_Public_Void_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x000B8370 File Offset: 0x000B6570
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 413542, RefRangeEnd = 413550, XrefRangeStart = 413529, XrefRangeEnd = 413542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema Add(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Add_Public_XmlSchema_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000B83C0 File Offset: 0x000B65C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413618, RefRangeEnd = 413619, XrefRangeStart = 413550, XrefRangeEnd = 413618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveRecursive(XmlSchema schemaToRemove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaToRemove);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_RemoveRecursive_Public_Boolean_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x000B8410 File Offset: 0x000B6610
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 413621, RefRangeEnd = 413623, XrefRangeStart = 413619, XrefRangeEnd = 413621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x000B8460 File Offset: 0x000B6660
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 413684, RefRangeEnd = 413692, XrefRangeStart = 413623, XrefRangeEnd = 413684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Compile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Compile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000B8494 File Offset: 0x000B6694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413751, RefRangeEnd = 413752, XrefRangeStart = 413692, XrefRangeEnd = 413751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema Reprocess(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Reprocess_Public_XmlSchema_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x000B84E4 File Offset: 0x000B66E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413769, RefRangeEnd = 413770, XrefRangeStart = 413752, XrefRangeEnd = 413769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppReferenceArray<XmlSchema> schemas, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemas);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_XmlSchema_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x000B8534 File Offset: 0x000B6734
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 413771, RefRangeEnd = 413776, XrefRangeStart = 413770, XrefRangeEnd = 413771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ICollection Schemas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Schemas_Public_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x000B8574 File Offset: 0x000B6774
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 413789, RefRangeEnd = 413794, XrefRangeStart = 413776, XrefRangeEnd = 413789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ICollection Schemas(string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Schemas_Public_ICollection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x000B85C4 File Offset: 0x000B67C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413794, XrefRangeEnd = 413796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema Add(string targetNamespace, XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Add_Private_XmlSchema_String_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x000B8628 File Offset: 0x000B6828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413821, RefRangeEnd = 413822, XrefRangeStart = 413796, XrefRangeEnd = 413821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validatedNamespaces);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Add_Internal_Void_String_XmlReader_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x000B8690 File Offset: 0x000B6890
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 413845, RefRangeEnd = 413851, XrefRangeStart = 413822, XrefRangeEnd = 413845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, Il2CppReferenceArray<DictionaryEntry> locationsTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locationsTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_FindSchemaByNSAndUrl_Internal_XmlSchema_Uri_String_Il2CppReferenceArray_1_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000B8704 File Offset: 0x000B6904
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 413890, RefRangeEnd = 413894, XrefRangeStart = 413851, XrefRangeEnd = 413890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSchemaToSet(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_AddSchemaToSet_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x000B8748 File Offset: 0x000B6948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413920, RefRangeEnd = 413921, XrefRangeStart = 413894, XrefRangeEnd = 413920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(substitutionGroupsTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolve;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_ProcessNewSubstitutionGroups_Private_Void_XmlSchemaObjectTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x000B8798 File Offset: 0x000B6998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 413948, RefRangeEnd = 413950, XrefRangeStart = 413921, XrefRangeEnd = 413948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(substitutionGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(substTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_ResolveSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000B87EC File Offset: 0x000B69EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 413975, RefRangeEnd = 413978, XrefRangeStart = 413950, XrefRangeEnd = 413975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema Remove(XmlSchema schema, bool forceCompile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceCompile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_Remove_Internal_XmlSchema_XmlSchema_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000B884C File Offset: 0x000B6A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413978, XrefRangeEnd = 413993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_ClearTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000B8880 File Offset: 0x000B6A80
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 414005, RefRangeEnd = 414011, XrefRangeStart = 413993, XrefRangeEnd = 414005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PreprocessSchema(ref XmlSchema schema, string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_PreprocessSchema_Internal_Boolean_byref_XmlSchema_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			schema = ((intPtr4 == 0) ? null : new XmlSchema(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x000B88F8 File Offset: 0x000B6AF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414019, RefRangeEnd = 414020, XrefRangeStart = 414011, XrefRangeEnd = 414019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema ParseSchema(string targetNamespace, XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_ParseSchema_Internal_XmlSchema_String_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x000B895C File Offset: 0x000B6B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414200, RefRangeEnd = 414201, XrefRangeStart = 414020, XrefRangeEnd = 414200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFromCompiledSet(XmlSchemaSet otherSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_CopyFromCompiledSet_Internal_Void_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x000B89A0 File Offset: 0x000B6BA0
		public unsafe SchemaInfo CompiledInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_CompiledInfo_Internal_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x000B89E0 File Offset: 0x000B6BE0
		public unsafe XmlReaderSettings ReaderSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_ReaderSettings_Internal_get_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x000B8A20 File Offset: 0x000B6C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414201, XrefRangeEnd = 414203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlResolver GetResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000B8A60 File Offset: 0x000B6C60
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationEventHandler GetEventHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr3) : null;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000B8AA0 File Offset: 0x000B6CA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 414208, RefRangeEnd = 414211, XrefRangeStart = 414203, XrefRangeEnd = 414208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaNames GetSchemaNames(XmlNameTable nt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_GetSchemaNames_Internal_SchemaNames_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr3) : null;
			}
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000B8AF0 File Offset: 0x000B6CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414332, RefRangeEnd = 414333, XrefRangeStart = 414211, XrefRangeEnd = 414332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_IsSchemaLoaded_Internal_Boolean_Uri_String_byref_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			schema = ((intPtr4 == 0) ? null : new XmlSchema(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000B8B74 File Offset: 0x000B6D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414333, XrefRangeEnd = 414345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaUri);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_GetSchemaByUri_Internal_Boolean_Uri_byref_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			schema = ((intPtr4 == 0) ? null : new XmlSchema(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000B8BE4 File Offset: 0x000B6DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414345, XrefRangeEnd = 414347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTargetNamespace(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_GetTargetNamespace_Internal_String_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x000B8C2C File Offset: 0x000B6E2C
		public unsafe SortedList SortedSchemas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_get_SortedSchemas_Internal_get_SortedList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr3) : null;
			}
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000B8C6C File Offset: 0x000B6E6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 414392, RefRangeEnd = 414394, XrefRangeStart = 414347, XrefRangeEnd = 414392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSchemaFromCaches(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_RemoveSchemaFromCaches_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000B8CB0 File Offset: 0x000B6EB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 414481, RefRangeEnd = 414483, XrefRangeStart = 414394, XrefRangeEnd = 414481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSchemaFromGlobalTables(XmlSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_RemoveSchemaFromGlobalTables_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000B8CF4 File Offset: 0x000B6EF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 414496, RefRangeEnd = 414500, XrefRangeStart = 414483, XrefRangeEnd = 414496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_AddToTable_Private_Boolean_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000B8D68 File Offset: 0x000B6F68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 414517, RefRangeEnd = 414519, XrefRangeStart = 414500, XrefRangeEnd = 414517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_VerifyTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x000B8D9C File Offset: 0x000B6F9C
		[CallerCount(0)]
		public unsafe void InternalValidationCallback(Object sender, ValidationEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_InternalValidationCallback_Private_Void_Object_ValidationEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000B8DF0 File Offset: 0x000B6FF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 414526, RefRangeEnd = 414529, XrefRangeStart = 414519, XrefRangeEnd = 414526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00010A64 File Offset: 0x0000EC64
		public XmlSchemaSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x000B8E40 File Offset: 0x000B7040
		// (set) Token: 0x0600278A RID: 10122 RVA: 0x00010A6D File Offset: 0x0000EC6D
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x000B8E70 File Offset: 0x000B7070
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x00010A8C File Offset: 0x0000EC8C
		public unsafe SchemaNames schemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000B8EA0 File Offset: 0x000B70A0
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x00010AAB File Offset: 0x0000ECAB
		public unsafe SortedList schemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000B8ED0 File Offset: 0x000B70D0
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x00010ACA File Offset: 0x0000ECCA
		public unsafe ValidationEventHandler internalEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_internalEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_internalEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x000B8F00 File Offset: 0x000B7100
		// (set) Token: 0x06002792 RID: 10130 RVA: 0x00010AE9 File Offset: 0x0000ECE9
		public unsafe ValidationEventHandler eventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_eventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_eventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x000B8F30 File Offset: 0x000B7130
		// (set) Token: 0x06002794 RID: 10132 RVA: 0x00010B08 File Offset: 0x0000ED08
		public unsafe bool isCompiled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_isCompiled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_isCompiled)) = value;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000B8F58 File Offset: 0x000B7158
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x00010B23 File Offset: 0x0000ED23
		public unsafe Hashtable schemaLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x000B8F88 File Offset: 0x000B7188
		// (set) Token: 0x06002798 RID: 10136 RVA: 0x00010B42 File Offset: 0x0000ED42
		public unsafe Hashtable chameleonSchemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_chameleonSchemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_chameleonSchemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002799 RID: 10137 RVA: 0x000B8FB8 File Offset: 0x000B71B8
		// (set) Token: 0x0600279A RID: 10138 RVA: 0x00010B61 File Offset: 0x0000ED61
		public unsafe Hashtable targetNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_targetNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_targetNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x000B8FE8 File Offset: 0x000B71E8
		// (set) Token: 0x0600279C RID: 10140 RVA: 0x00010B80 File Offset: 0x0000ED80
		public unsafe bool compileAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compileAll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compileAll)) = value;
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x000B9010 File Offset: 0x000B7210
		// (set) Token: 0x0600279E RID: 10142 RVA: 0x00010B9B File Offset: 0x0000ED9B
		public unsafe SchemaInfo cachedCompiledInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_cachedCompiledInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_cachedCompiledInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x000B9040 File Offset: 0x000B7240
		// (set) Token: 0x060027A0 RID: 10144 RVA: 0x00010BBA File Offset: 0x0000EDBA
		public unsafe XmlReaderSettings readerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_readerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_readerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x000B9070 File Offset: 0x000B7270
		// (set) Token: 0x060027A2 RID: 10146 RVA: 0x00010BD9 File Offset: 0x0000EDD9
		public unsafe XmlSchema schemaForSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaForSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaForSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x000B90A0 File Offset: 0x000B72A0
		// (set) Token: 0x060027A4 RID: 10148 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		public unsafe XmlSchemaCompilationSettings compilationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compilationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaCompilationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compilationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x000B90D0 File Offset: 0x000B72D0
		// (set) Token: 0x060027A6 RID: 10150 RVA: 0x00010C17 File Offset: 0x0000EE17
		public unsafe XmlSchemaObjectTable elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x060027A7 RID: 10151 RVA: 0x000B9100 File Offset: 0x000B7300
		// (set) Token: 0x060027A8 RID: 10152 RVA: 0x00010C36 File Offset: 0x0000EE36
		public unsafe XmlSchemaObjectTable attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x000B9130 File Offset: 0x000B7330
		// (set) Token: 0x060027AA RID: 10154 RVA: 0x00010C55 File Offset: 0x0000EE55
		public unsafe XmlSchemaObjectTable schemaTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x060027AB RID: 10155 RVA: 0x000B9160 File Offset: 0x000B7360
		// (set) Token: 0x060027AC RID: 10156 RVA: 0x00010C74 File Offset: 0x0000EE74
		public unsafe XmlSchemaObjectTable substitutionGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_substitutionGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_substitutionGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x000B9190 File Offset: 0x000B7390
		// (set) Token: 0x060027AE RID: 10158 RVA: 0x00010C93 File Offset: 0x0000EE93
		public unsafe XmlSchemaObjectTable typeExtensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_typeExtensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_typeExtensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x000B91C0 File Offset: 0x000B73C0
		// (set) Token: 0x060027B0 RID: 10160 RVA: 0x00010CB2 File Offset: 0x0000EEB2
		public unsafe Object internalSyncObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_internalSyncObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_internalSyncObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeFieldInfoPtr_schemaNames;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeFieldInfoPtr_schemas;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeFieldInfoPtr_internalEventHandler;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeFieldInfoPtr_eventHandler;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeFieldInfoPtr_isCompiled;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeFieldInfoPtr_schemaLocations;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeFieldInfoPtr_chameleonSchemas;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespaces;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeFieldInfoPtr_compileAll;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeFieldInfoPtr_cachedCompiledInfo;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeFieldInfoPtr_readerSettings;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeFieldInfoPtr_schemaForSchema;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeFieldInfoPtr_compilationSettings;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeFieldInfoPtr_schemaTypes;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeFieldInfoPtr_substitutionGroups;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeFieldInfoPtr_typeExtensions;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeFieldInfoPtr_internalSyncObject;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Internal_get_Object_0;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompiled_Public_get_Boolean_0;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeMethodInfoPtr_get_CompilationSettings_Public_get_XmlSchemaCompilationSettings_0;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeMethodInfoPtr_set_CompilationSettings_Public_set_Void_XmlSchemaCompilationSettings_0;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalElements_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalAttributes_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalTypes_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeMethodInfoPtr_get_SubstitutionGroups_Internal_get_XmlSchemaObjectTable_0;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaLocations_Internal_get_Hashtable_0;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeExtensions_Internal_get_XmlSchemaObjectTable_0;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_XmlSchemaSet_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_XmlSchema_XmlSchema_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRecursive_Public_Boolean_XmlSchema_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Void_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr_Reprocess_Public_XmlSchema_XmlSchema_0;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_XmlSchema_Int32_0;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeMethodInfoPtr_Schemas_Public_ICollection_0;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeMethodInfoPtr_Schemas_Public_ICollection_String_0;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_XmlSchema_String_XmlSchema_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_String_XmlReader_Hashtable_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_FindSchemaByNSAndUrl_Internal_XmlSchema_Uri_String_Il2CppReferenceArray_1_DictionaryEntry_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_AddSchemaToSet_Private_Void_XmlSchema_0;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeMethodInfoPtr_ProcessNewSubstitutionGroups_Private_Void_XmlSchemaObjectTable_Boolean_0;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable_0;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_XmlSchema_XmlSchema_Boolean_0;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_ClearTables_Private_Void_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessSchema_Internal_Boolean_byref_XmlSchema_String_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_ParseSchema_Internal_XmlSchema_String_XmlReader_0;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeMethodInfoPtr_CopyFromCompiledSet_Internal_Void_XmlSchemaSet_0;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeMethodInfoPtr_get_CompiledInfo_Internal_get_SchemaInfo_0;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr_get_ReaderSettings_Internal_get_XmlReaderSettings_0;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaNames_Internal_SchemaNames_XmlNameTable_0;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeMethodInfoPtr_IsSchemaLoaded_Internal_Boolean_Uri_String_byref_XmlSchema_0;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaByUri_Internal_Boolean_Uri_byref_XmlSchema_0;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetNamespace_Internal_String_XmlSchema_0;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeMethodInfoPtr_get_SortedSchemas_Internal_get_SortedList_0;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSchemaFromCaches_Private_Void_XmlSchema_0;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSchemaFromGlobalTables_Private_Void_XmlSchema_0;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeMethodInfoPtr_AddToTable_Private_Boolean_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject_0;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeMethodInfoPtr_VerifyTables_Private_Void_0;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeMethodInfoPtr_InternalValidationCallback_Private_Void_Object_ValidationEventArgs_0;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0;
	}
}
