using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	public class DataSet : MarshalByValueComponent
	{
		// Token: 0x06000248 RID: 584 RVA: 0x000128E0 File Offset: 0x00010AE0
		// Note: this type is marked as 'beforefieldinit'.
		static DataSet()
		{
			Il2CppClassPointerStore<DataSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataSet>.NativeClassPtr);
			DataSet.NativeFieldInfoPtr__defaultViewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_defaultViewManager");
			DataSet.NativeFieldInfoPtr__tableCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_tableCollection");
			DataSet.NativeFieldInfoPtr__relationCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_relationCollection");
			DataSet.NativeFieldInfoPtr__extendedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_extendedProperties");
			DataSet.NativeFieldInfoPtr__dataSetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_dataSetName");
			DataSet.NativeFieldInfoPtr__datasetPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_datasetPrefix");
			DataSet.NativeFieldInfoPtr__namespaceURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_namespaceURI");
			DataSet.NativeFieldInfoPtr__enforceConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_enforceConstraints");
			DataSet.NativeFieldInfoPtr__caseSensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_caseSensitive");
			DataSet.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_culture");
			DataSet.NativeFieldInfoPtr__cultureUserSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_cultureUserSet");
			DataSet.NativeFieldInfoPtr__fInReadXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_fInReadXml");
			DataSet.NativeFieldInfoPtr__fInLoadDiffgram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_fInLoadDiffgram");
			DataSet.NativeFieldInfoPtr__fTopLevelTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_fTopLevelTable");
			DataSet.NativeFieldInfoPtr__fInitInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_fInitInProgress");
			DataSet.NativeFieldInfoPtr__fEnableCascading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_fEnableCascading");
			DataSet.NativeFieldInfoPtr__fIsSchemaLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_fIsSchemaLoading");
			DataSet.NativeFieldInfoPtr__mainTableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_mainTableName");
			DataSet.NativeFieldInfoPtr__remotingFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_remotingFormat");
			DataSet.NativeFieldInfoPtr__defaultViewManagerLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_defaultViewManagerLock");
			DataSet.NativeFieldInfoPtr_s_objectTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "s_objectTypeCount");
			DataSet.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_objectID");
			DataSet.NativeFieldInfoPtr_s_schemaTypeForWSDL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "s_schemaTypeForWSDL");
			DataSet.NativeFieldInfoPtr__useDataSetSchemaOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_useDataSetSchemaOnly");
			DataSet.NativeFieldInfoPtr__udtIsWrapped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "_udtIsWrapped");
			DataSet.NativeFieldInfoPtr_PropertyChanging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "PropertyChanging");
			DataSet.NativeFieldInfoPtr_MergeFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "MergeFailed");
			DataSet.NativeFieldInfoPtr_DataRowCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "DataRowCreated");
			DataSet.NativeFieldInfoPtr_ClearFunctionCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "ClearFunctionCalled");
			DataSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663745);
			DataSet.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663746);
			DataSet.NativeMethodInfoPtr_get_RemotingFormat_Public_get_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663747);
			DataSet.NativeMethodInfoPtr_set_RemotingFormat_Public_set_Void_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663748);
			DataSet.NativeMethodInfoPtr_get_SchemaSerializationMode_Public_Virtual_New_get_SchemaSerializationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663749);
			DataSet.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663750);
			DataSet.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663751);
			DataSet.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663752);
			DataSet.NativeMethodInfoPtr_InitializeDerivedDataSet_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663753);
			DataSet.NativeMethodInfoPtr_SerializeDataSet_Private_Void_SerializationInfo_StreamingContext_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663754);
			DataSet.NativeMethodInfoPtr_DeserializeDataSet_Internal_Void_SerializationInfo_StreamingContext_SerializationFormat_SchemaSerializationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663755);
			DataSet.NativeMethodInfoPtr_DeserializeDataSetSchema_Private_Void_SerializationInfo_StreamingContext_SerializationFormat_SchemaSerializationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663756);
			DataSet.NativeMethodInfoPtr_DeserializeDataSetData_Private_Void_SerializationInfo_StreamingContext_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663757);
			DataSet.NativeMethodInfoPtr_SerializeDataSetProperties_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663758);
			DataSet.NativeMethodInfoPtr_DeserializeDataSetProperties_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663759);
			DataSet.NativeMethodInfoPtr_SerializeRelations_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663760);
			DataSet.NativeMethodInfoPtr_DeserializeRelations_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663761);
			DataSet.NativeMethodInfoPtr_FailedEnableConstraints_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663762);
			DataSet.NativeMethodInfoPtr_get_CaseSensitive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663763);
			DataSet.NativeMethodInfoPtr_set_CaseSensitive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663764);
			DataSet.NativeMethodInfoPtr_get_EnforceConstraints_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663765);
			DataSet.NativeMethodInfoPtr_set_EnforceConstraints_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663766);
			DataSet.NativeMethodInfoPtr_RestoreEnforceConstraints_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663767);
			DataSet.NativeMethodInfoPtr_EnableConstraints_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663768);
			DataSet.NativeMethodInfoPtr_get_DataSetName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663769);
			DataSet.NativeMethodInfoPtr_set_DataSetName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663770);
			DataSet.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663771);
			DataSet.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663772);
			DataSet.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663773);
			DataSet.NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663774);
			DataSet.NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663775);
			DataSet.NativeMethodInfoPtr_get_Locale_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663776);
			DataSet.NativeMethodInfoPtr_set_Locale_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663777);
			DataSet.NativeMethodInfoPtr_SetLocaleValue_Internal_Void_CultureInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663778);
			DataSet.NativeMethodInfoPtr_ShouldSerializeLocale_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663779);
			DataSet.NativeMethodInfoPtr_get_Site_Public_Virtual_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663780);
			DataSet.NativeMethodInfoPtr_get_Relations_Public_get_DataRelationCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663781);
			DataSet.NativeMethodInfoPtr_get_Tables_Public_get_DataTableCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663782);
			DataSet.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663783);
			DataSet.NativeMethodInfoPtr_Clone_Public_Virtual_New_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663784);
			DataSet.NativeMethodInfoPtr_EstimatedXmlStringSize_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663785);
			DataSet.NativeMethodInfoPtr_GetRemotingDiffGram_Internal_String_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663786);
			DataSet.NativeMethodInfoPtr_GetXmlSchemaForRemoting_Internal_String_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663787);
			DataSet.NativeMethodInfoPtr_ReadXmlSchema_Public_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663788);
			DataSet.NativeMethodInfoPtr_ReadXmlSchema_Internal_Void_XmlReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663789);
			DataSet.NativeMethodInfoPtr_MoveToElement_Internal_Boolean_XmlReader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663790);
			DataSet.NativeMethodInfoPtr_MoveToElement_Private_Static_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663791);
			DataSet.NativeMethodInfoPtr_ReadEndElement_Internal_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663792);
			DataSet.NativeMethodInfoPtr_ReadXSDSchema_Internal_Void_XmlReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663793);
			DataSet.NativeMethodInfoPtr_ReadXDRSchema_Internal_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663794);
			DataSet.NativeMethodInfoPtr_WriteXmlSchema_Private_Void_XmlWriter_SchemaFormat_Converter_2_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663795);
			DataSet.NativeMethodInfoPtr_ReadXml_Public_XmlReadMode_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663796);
			DataSet.NativeMethodInfoPtr_ReadXml_Internal_XmlReadMode_XmlReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663797);
			DataSet.NativeMethodInfoPtr_InferSchema_Internal_Void_XmlDocument_Il2CppStringArray_XmlReadMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663798);
			DataSet.NativeMethodInfoPtr_IsEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663799);
			DataSet.NativeMethodInfoPtr_ReadXmlDiffgram_Private_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663800);
			DataSet.NativeMethodInfoPtr_ReadXml_Public_XmlReadMode_XmlReader_XmlReadMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663801);
			DataSet.NativeMethodInfoPtr_ReadXml_Internal_XmlReadMode_XmlReader_XmlReadMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663802);
			DataSet.NativeMethodInfoPtr_WriteXml_Public_Void_XmlWriter_XmlWriteMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663803);
			DataSet.NativeMethodInfoPtr_Merge_Public_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663804);
			DataSet.NativeMethodInfoPtr_Merge_Public_Void_DataSet_Boolean_MissingSchemaAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663805);
			DataSet.NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_PropertyChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663806);
			DataSet.NativeMethodInfoPtr_OnMergeFailed_Internal_Void_MergeFailedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663807);
			DataSet.NativeMethodInfoPtr_RaiseMergeFailed_Internal_Void_DataTable_String_MissingSchemaAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663808);
			DataSet.NativeMethodInfoPtr_OnDataRowCreated_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663809);
			DataSet.NativeMethodInfoPtr_OnClearFunctionCalled_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663810);
			DataSet.NativeMethodInfoPtr_OnRemoveTable_FamOrAssem_Virtual_New_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663811);
			DataSet.NativeMethodInfoPtr_OnRemovedTable_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663812);
			DataSet.NativeMethodInfoPtr_OnRemoveRelation_Protected_Virtual_New_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663813);
			DataSet.NativeMethodInfoPtr_OnRemoveRelationHack_Internal_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663814);
			DataSet.NativeMethodInfoPtr_RaisePropertyChanging_FamOrAssem_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663815);
			DataSet.NativeMethodInfoPtr_TopLevelTables_Internal_Il2CppReferenceArray_1_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663816);
			DataSet.NativeMethodInfoPtr_TopLevelTables_Internal_Il2CppReferenceArray_1_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663817);
			DataSet.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663818);
			DataSet.NativeMethodInfoPtr_ValidateCaseConstraint_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663819);
			DataSet.NativeMethodInfoPtr_ValidateLocaleConstraint_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663820);
			DataSet.NativeMethodInfoPtr_FindTable_Internal_DataTable_DataTable_Il2CppReferenceArray_1_PropertyDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663821);
			DataSet.NativeMethodInfoPtr_ReadXmlSerializable_Protected_Virtual_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663822);
			DataSet.NativeMethodInfoPtr_GetDataSetSchema_Public_Static_XmlSchemaComplexType_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663823);
			DataSet.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663824);
			DataSet.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663825);
			DataSet.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663826);
			DataSet.NativeMethodInfoPtr_get_MainTableName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663827);
			DataSet.NativeMethodInfoPtr_set_MainTableName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663828);
			DataSet.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100663829);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000131F8 File Offset: 0x000113F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 891389, RefRangeEnd = 891396, XrefRangeStart = 891337, XrefRangeEnd = 891389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00013234 File Offset: 0x00011434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 891398, RefRangeEnd = 891399, XrefRangeStart = 891396, XrefRangeEnd = 891398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataSet(string dataSetName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dataSetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00013280 File Offset: 0x00011480
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000132BC File Offset: 0x000114BC
		public unsafe SerializationFormat RemotingFormat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_RemotingFormat_Public_get_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 891402, RefRangeEnd = 891405, XrefRangeStart = 891399, XrefRangeEnd = 891402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_set_RemotingFormat_Public_set_Void_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000132FC File Offset: 0x000114FC
		public unsafe virtual SchemaSerializationMode SchemaSerializationMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataSet.NativeMethodInfoPtr_get_SchemaSerializationMode_Public_Virtual_New_get_SchemaSerializationMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00013344 File Offset: 0x00011544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891405, XrefRangeEnd = 891406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataSet(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataSet>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000133A8 File Offset: 0x000115A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 891428, RefRangeEnd = 891429, XrefRangeStart = 891406, XrefRangeEnd = 891428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataSet(SerializationInfo info, StreamingContext context, bool ConstructSchema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataSet>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ConstructSchema;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00013418 File Offset: 0x00011618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891429, XrefRangeEnd = 891430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataSet.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001347C File Offset: 0x0001167C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeDerivedDataSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataSet.NativeMethodInfoPtr_InitializeDerivedDataSet_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000134B8 File Offset: 0x000116B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 891484, RefRangeEnd = 891485, XrefRangeStart = 891430, XrefRangeEnd = 891484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remotingFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_SerializeDataSet_Private_Void_SerializationInfo_StreamingContext_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00013520 File Offset: 0x00011720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891485, XrefRangeEnd = 891487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remotingFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref schemaSerializationMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_DeserializeDataSet_Internal_Void_SerializationInfo_StreamingContext_SerializationFormat_SchemaSerializationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00013598 File Offset: 0x00011798
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 891517, RefRangeEnd = 891519, XrefRangeStart = 891487, XrefRangeEnd = 891517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remotingFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref schemaSerializationMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_DeserializeDataSetSchema_Private_Void_SerializationInfo_StreamingContext_SerializationFormat_SchemaSerializationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00013610 File Offset: 0x00011810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 891539, RefRangeEnd = 891541, XrefRangeStart = 891519, XrefRangeEnd = 891539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remotingFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_DeserializeDataSetData_Private_Void_SerializationInfo_StreamingContext_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00013678 File Offset: 0x00011878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891541, XrefRangeEnd = 891568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeDataSetProperties(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_SerializeDataSetProperties_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000136D4 File Offset: 0x000118D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891568, XrefRangeEnd = 891618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_DeserializeDataSetProperties_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00013730 File Offset: 0x00011930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891618, XrefRangeEnd = 891655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeRelations(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_SerializeRelations_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001378C File Offset: 0x0001198C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891655, XrefRangeEnd = 891716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeRelations(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_DeserializeRelations_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000137E8 File Offset: 0x000119E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891716, XrefRangeEnd = 891720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FailedEnableConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_FailedEnableConstraints_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0001381C File Offset: 0x00011A1C
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00013858 File Offset: 0x00011A58
		public unsafe bool CaseSensitive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_CaseSensitive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 891739, RefRangeEnd = 891743, XrefRangeStart = 891720, XrefRangeEnd = 891739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_set_CaseSensitive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00013898 File Offset: 0x00011A98
		// (set) Token: 0x0600025E RID: 606 RVA: 0x000138D4 File Offset: 0x00011AD4
		public unsafe bool EnforceConstraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_EnforceConstraints_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 891759, RefRangeEnd = 891776, XrefRangeStart = 891743, XrefRangeEnd = 891759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_set_EnforceConstraints_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00013914 File Offset: 0x00011B14
		[CallerCount(0)]
		public unsafe void RestoreEnforceConstraints(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_RestoreEnforceConstraints_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00013954 File Offset: 0x00011B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 891827, RefRangeEnd = 891828, XrefRangeStart = 891776, XrefRangeEnd = 891827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_EnableConstraints_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00013988 File Offset: 0x00011B88
		// (set) Token: 0x06000262 RID: 610 RVA: 0x000139C0 File Offset: 0x00011BC0
		public unsafe string DataSetName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_DataSetName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 891843, RefRangeEnd = 891850, XrefRangeStart = 891828, XrefRangeEnd = 891843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_set_DataSetName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00013A04 File Offset: 0x00011C04
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00013A3C File Offset: 0x00011C3C
		public unsafe string Namespace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 891887, RefRangeEnd = 891895, XrefRangeStart = 891850, XrefRangeEnd = 891887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00013A80 File Offset: 0x00011C80
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00013AB8 File Offset: 0x00011CB8
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 891911, RefRangeEnd = 891913, XrefRangeStart = 891895, XrefRangeEnd = 891911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00013AFC File Offset: 0x00011CFC
		public unsafe PropertyCollection ExtendedProperties
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 891918, RefRangeEnd = 891920, XrefRangeStart = 891913, XrefRangeEnd = 891918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00013B3C File Offset: 0x00011D3C
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00013B7C File Offset: 0x00011D7C
		public unsafe CultureInfo Locale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_Locale_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 891936, RefRangeEnd = 891938, XrefRangeStart = 891920, XrefRangeEnd = 891936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_set_Locale_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00013BC0 File Offset: 0x00011DC0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 891977, RefRangeEnd = 891983, XrefRangeStart = 891938, XrefRangeEnd = 891977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocaleValue(CultureInfo value, bool userSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userSet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_SetLocaleValue_Internal_Void_CultureInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00013C10 File Offset: 0x00011E10
		[CallerCount(0)]
		public unsafe bool ShouldSerializeLocale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ShouldSerializeLocale_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00013C4C File Offset: 0x00011E4C
		public unsafe override ISite Site
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataSet.NativeMethodInfoPtr_get_Site_Public_Virtual_get_ISite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00013C98 File Offset: 0x00011E98
		public unsafe DataRelationCollection Relations
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_Relations_Public_get_DataRelationCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelationCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00013CD8 File Offset: 0x00011ED8
		public unsafe DataTableCollection Tables
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_Tables_Public_get_DataTableCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTableCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00013D18 File Offset: 0x00011F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892003, RefRangeEnd = 892004, XrefRangeStart = 891983, XrefRangeEnd = 892003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00013D4C File Offset: 0x00011F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892004, XrefRangeEnd = 892129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataSet Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataSet.NativeMethodInfoPtr_Clone_Public_Virtual_New_DataSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr3) : null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00013D98 File Offset: 0x00011F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892129, XrefRangeEnd = 892134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EstimatedXmlStringSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_EstimatedXmlStringSize_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00013DD4 File Offset: 0x00011FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892134, XrefRangeEnd = 892153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRemotingDiffGram(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_GetRemotingDiffGram_Internal_String_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00013E1C File Offset: 0x0001201C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892179, RefRangeEnd = 892180, XrefRangeStart = 892153, XrefRangeEnd = 892179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetXmlSchemaForRemoting(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_GetXmlSchemaForRemoting_Internal_String_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00013E64 File Offset: 0x00012064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892181, RefRangeEnd = 892182, XrefRangeStart = 892180, XrefRangeEnd = 892181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadXmlSchema(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ReadXmlSchema_Public_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00013EA8 File Offset: 0x000120A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 892266, RefRangeEnd = 892269, XrefRangeStart = 892182, XrefRangeEnd = 892266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadXmlSchema(XmlReader reader, bool denyResolving)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref denyResolving;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ReadXmlSchema_Internal_Void_XmlReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00013EF8 File Offset: 0x000120F8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 892270, RefRangeEnd = 892279, XrefRangeStart = 892269, XrefRangeEnd = 892270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToElement(XmlReader reader, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_MoveToElement_Internal_Boolean_XmlReader_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00013F54 File Offset: 0x00012154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892280, RefRangeEnd = 892281, XrefRangeStart = 892279, XrefRangeEnd = 892280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveToElement(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_MoveToElement_Private_Static_Void_XmlReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00013F8C File Offset: 0x0001218C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 892282, RefRangeEnd = 892292, XrefRangeStart = 892281, XrefRangeEnd = 892282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadEndElement(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ReadEndElement_Internal_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00013FD0 File Offset: 0x000121D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 892327, RefRangeEnd = 892334, XrefRangeStart = 892292, XrefRangeEnd = 892327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadXSDSchema(XmlReader reader, bool denyResolving)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref denyResolving;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ReadXSDSchema_Internal_Void_XmlReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00014020 File Offset: 0x00012220
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 892349, RefRangeEnd = 892355, XrefRangeStart = 892334, XrefRangeEnd = 892349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadXDRSchema(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ReadXDRSchema_Internal_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00014064 File Offset: 0x00012264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892379, RefRangeEnd = 892380, XrefRangeStart = 892355, XrefRangeEnd = 892379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref schemaFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(multipleTargetConverter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_WriteXmlSchema_Private_Void_XmlWriter_SchemaFormat_Converter_2_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000140C8 File Offset: 0x000122C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892380, XrefRangeEnd = 892381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReadMode ReadXml(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ReadXml_Public_XmlReadMode_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00014118 File Offset: 0x00012318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 892508, RefRangeEnd = 892510, XrefRangeStart = 892381, XrefRangeEnd = 892508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReadMode ReadXml(XmlReader reader, bool denyResolving)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref denyResolving;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ReadXml_Internal_XmlReadMode_XmlReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00014174 File Offset: 0x00012374
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 892544, RefRangeEnd = 892547, XrefRangeStart = 892510, XrefRangeEnd = 892544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InferSchema(XmlDocument xdoc, Il2CppStringArray excludedNamespaces, XmlReadMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xdoc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(excludedNamespaces);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_InferSchema_Internal_Void_XmlDocument_Il2CppStringArray_XmlReadMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000141D8 File Offset: 0x000123D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892556, RefRangeEnd = 892557, XrefRangeStart = 892547, XrefRangeEnd = 892556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_IsEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00014214 File Offset: 0x00012414
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 892690, RefRangeEnd = 892695, XrefRangeStart = 892557, XrefRangeEnd = 892690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadXmlDiffgram(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ReadXmlDiffgram_Private_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00014258 File Offset: 0x00012458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892696, RefRangeEnd = 892697, XrefRangeStart = 892695, XrefRangeEnd = 892696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ReadXml_Public_XmlReadMode_XmlReader_XmlReadMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000142B4 File Offset: 0x000124B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 892816, RefRangeEnd = 892819, XrefRangeStart = 892697, XrefRangeEnd = 892816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref denyResolving;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ReadXml_Internal_XmlReadMode_XmlReader_XmlReadMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00014320 File Offset: 0x00012520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 892849, RefRangeEnd = 892851, XrefRangeStart = 892819, XrefRangeEnd = 892849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteXml(XmlWriter writer, XmlWriteMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_WriteXml_Public_Void_XmlWriter_XmlWriteMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00014370 File Offset: 0x00012570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892868, RefRangeEnd = 892869, XrefRangeStart = 892851, XrefRangeEnd = 892868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(DataSet dataSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_Merge_Public_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000143B4 File Offset: 0x000125B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892890, RefRangeEnd = 892891, XrefRangeStart = 892869, XrefRangeEnd = 892890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveChanges;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref missingSchemaAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_Merge_Public_Void_DataSet_Boolean_MissingSchemaAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00014414 File Offset: 0x00012614
		[CallerCount(0)]
		public unsafe virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataSet.NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_PropertyChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00014464 File Offset: 0x00012664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892891, XrefRangeEnd = 892897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMergeFailed(MergeFailedEventArgs mfevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mfevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_OnMergeFailed_Internal_Void_MergeFailedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000144A8 File Offset: 0x000126A8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 892910, RefRangeEnd = 892919, XrefRangeStart = 892897, XrefRangeEnd = 892910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(conflict);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref missingSchemaAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_RaiseMergeFailed_Internal_Void_DataTable_String_MissingSchemaAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0001450C File Offset: 0x0001270C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 892919, RefRangeEnd = 892923, XrefRangeStart = 892919, XrefRangeEnd = 892919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDataRowCreated(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_OnDataRowCreated_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00014550 File Offset: 0x00012750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892923, RefRangeEnd = 892924, XrefRangeStart = 892923, XrefRangeEnd = 892923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClearFunctionCalled(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_OnClearFunctionCalled_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00014594 File Offset: 0x00012794
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemoveTable(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataSet.NativeMethodInfoPtr_OnRemoveTable_FamOrAssem_Virtual_New_Void_DataTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000145E4 File Offset: 0x000127E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 892925, RefRangeEnd = 892926, XrefRangeStart = 892924, XrefRangeEnd = 892925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRemovedTable(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_OnRemovedTable_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00014628 File Offset: 0x00012828
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemoveRelation(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataSet.NativeMethodInfoPtr_OnRemoveRelation_Protected_Virtual_New_Void_DataRelation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00014678 File Offset: 0x00012878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366152, RefRangeEnd = 366153, XrefRangeStart = 366152, XrefRangeEnd = 366153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRemoveRelationHack(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_OnRemoveRelationHack_Internal_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000146BC File Offset: 0x000128BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 892930, RefRangeEnd = 892934, XrefRangeStart = 892926, XrefRangeEnd = 892930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaisePropertyChanging(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_RaisePropertyChanging_FamOrAssem_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00014700 File Offset: 0x00012900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 892935, RefRangeEnd = 892937, XrefRangeStart = 892934, XrefRangeEnd = 892935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataTable> TopLevelTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_TopLevelTables_Internal_Il2CppReferenceArray_1_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataTable>>(intPtr3) : null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00014740 File Offset: 0x00012940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 892963, RefRangeEnd = 892966, XrefRangeStart = 892937, XrefRangeEnd = 892963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataTable> TopLevelTables(bool forSchema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forSchema;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_TopLevelTables_Internal_Il2CppReferenceArray_1_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataTable>>(intPtr3) : null;
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001478C File Offset: 0x0001298C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892966, XrefRangeEnd = 892992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataSet.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000147C8 File Offset: 0x000129C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 893020, RefRangeEnd = 893022, XrefRangeStart = 892992, XrefRangeEnd = 893020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateCaseConstraint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ValidateCaseConstraint_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00014804 File Offset: 0x00012A04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 893050, RefRangeEnd = 893052, XrefRangeStart = 893022, XrefRangeEnd = 893050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateLocaleConstraint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_ValidateLocaleConstraint_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00014840 File Offset: 0x00012A40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 893056, RefRangeEnd = 893059, XrefRangeStart = 893052, XrefRangeEnd = 893056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable FindTable(DataTable baseTable, Il2CppReferenceArray<PropertyDescriptor> props, int propStart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(props);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_FindTable_Internal_DataTable_DataTable_Il2CppReferenceArray_1_PropertyDescriptor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000148B0 File Offset: 0x00012AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893059, XrefRangeEnd = 893094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReadXmlSerializable(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataSet.NativeMethodInfoPtr_ReadXmlSerializable_Protected_Virtual_New_Void_XmlReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00014900 File Offset: 0x00012B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893094, XrefRangeEnd = 893133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_GetDataSetSchema_Public_Static_XmlSchemaComplexType_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00014944 File Offset: 0x00012B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893133, XrefRangeEnd = 893162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00014984 File Offset: 0x00012B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893162, XrefRangeEnd = 893179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000149C8 File Offset: 0x00012BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893179, XrefRangeEnd = 893181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00014A0C File Offset: 0x00012C0C
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00014A44 File Offset: 0x00012C44
		public unsafe string MainTableName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_MainTableName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_set_MainTableName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00014A88 File Offset: 0x00012C88
		public unsafe int ObjectID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002687 File Offset: 0x00000887
		public DataSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00014AC4 File Offset: 0x00012CC4
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00002690 File Offset: 0x00000890
		public unsafe DataViewManager _defaultViewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__defaultViewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__defaultViewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00014AF4 File Offset: 0x00012CF4
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000026AF File Offset: 0x000008AF
		public unsafe DataTableCollection _tableCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__tableCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTableCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__tableCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00014B24 File Offset: 0x00012D24
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x000026CE File Offset: 0x000008CE
		public unsafe DataRelationCollection _relationCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__relationCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRelationCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__relationCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00014B54 File Offset: 0x00012D54
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x000026ED File Offset: 0x000008ED
		public unsafe PropertyCollection _extendedProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__extendedProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__extendedProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00014B84 File Offset: 0x00012D84
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000270C File Offset: 0x0000090C
		public unsafe string _dataSetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__dataSetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__dataSetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00014BAC File Offset: 0x00012DAC
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0000272B File Offset: 0x0000092B
		public unsafe string _datasetPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__datasetPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__datasetPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00014BD4 File Offset: 0x00012DD4
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000274A File Offset: 0x0000094A
		public unsafe string _namespaceURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__namespaceURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__namespaceURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00014BFC File Offset: 0x00012DFC
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00002769 File Offset: 0x00000969
		public unsafe bool _enforceConstraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__enforceConstraints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__enforceConstraints)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00014C24 File Offset: 0x00012E24
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00002784 File Offset: 0x00000984
		public unsafe bool _caseSensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__caseSensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__caseSensitive)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00014C4C File Offset: 0x00012E4C
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x0000279F File Offset: 0x0000099F
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00014C7C File Offset: 0x00012E7C
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x000027BE File Offset: 0x000009BE
		public unsafe bool _cultureUserSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__cultureUserSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__cultureUserSet)) = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00014CA4 File Offset: 0x00012EA4
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x000027D9 File Offset: 0x000009D9
		public unsafe bool _fInReadXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fInReadXml);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fInReadXml)) = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00014CCC File Offset: 0x00012ECC
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x000027F4 File Offset: 0x000009F4
		public unsafe bool _fInLoadDiffgram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fInLoadDiffgram);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fInLoadDiffgram)) = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00014CF4 File Offset: 0x00012EF4
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000280F File Offset: 0x00000A0F
		public unsafe bool _fTopLevelTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fTopLevelTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fTopLevelTable)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00014D1C File Offset: 0x00012F1C
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0000282A File Offset: 0x00000A2A
		public unsafe bool _fInitInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fInitInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fInitInProgress)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00014D44 File Offset: 0x00012F44
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00002845 File Offset: 0x00000A45
		public unsafe bool _fEnableCascading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fEnableCascading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fEnableCascading)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00014D6C File Offset: 0x00012F6C
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00002860 File Offset: 0x00000A60
		public unsafe bool _fIsSchemaLoading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fIsSchemaLoading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__fIsSchemaLoading)) = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00014D94 File Offset: 0x00012F94
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0000287B File Offset: 0x00000A7B
		public unsafe string _mainTableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__mainTableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__mainTableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00014DBC File Offset: 0x00012FBC
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0000289A File Offset: 0x00000A9A
		public unsafe SerializationFormat _remotingFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__remotingFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__remotingFormat)) = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00014DE4 File Offset: 0x00012FE4
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x000028B5 File Offset: 0x00000AB5
		public unsafe Object _defaultViewManagerLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__defaultViewManagerLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__defaultViewManagerLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00014E14 File Offset: 0x00013014
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x000028D4 File Offset: 0x00000AD4
		public unsafe static int s_objectTypeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DataSet.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataSet.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00014E30 File Offset: 0x00013030
		// (set) Token: 0x060002CA RID: 714 RVA: 0x000028E2 File Offset: 0x00000AE2
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00014E58 File Offset: 0x00013058
		// (set) Token: 0x060002CC RID: 716 RVA: 0x000028FD File Offset: 0x00000AFD
		public unsafe static XmlSchemaComplexType s_schemaTypeForWSDL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataSet.NativeFieldInfoPtr_s_schemaTypeForWSDL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataSet.NativeFieldInfoPtr_s_schemaTypeForWSDL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00014E80 File Offset: 0x00013080
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0000290F File Offset: 0x00000B0F
		public unsafe bool _useDataSetSchemaOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__useDataSetSchemaOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__useDataSetSchemaOnly)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00014EA8 File Offset: 0x000130A8
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0000292A File Offset: 0x00000B2A
		public unsafe bool _udtIsWrapped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__udtIsWrapped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr__udtIsWrapped)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00014ED0 File Offset: 0x000130D0
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00002945 File Offset: 0x00000B45
		public unsafe PropertyChangedEventHandler PropertyChanging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_PropertyChanging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_PropertyChanging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00014F00 File Offset: 0x00013100
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00002964 File Offset: 0x00000B64
		public unsafe MergeFailedEventHandler MergeFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_MergeFailed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MergeFailedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_MergeFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00014F30 File Offset: 0x00013130
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002983 File Offset: 0x00000B83
		public unsafe DataRowCreatedEventHandler DataRowCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_DataRowCreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRowCreatedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_DataRowCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00014F60 File Offset: 0x00013160
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x000029A2 File Offset: 0x00000BA2
		public unsafe DataSetClearEventhandler ClearFunctionCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_ClearFunctionCalled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSetClearEventhandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_ClearFunctionCalled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr__defaultViewManager;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr__tableCollection;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr__relationCollection;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr__extendedProperties;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr__dataSetName;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr__datasetPrefix;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr__namespaceURI;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr__enforceConstraints;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr__caseSensitive;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr__cultureUserSet;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr__fInReadXml;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr__fInLoadDiffgram;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr__fTopLevelTable;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr__fInitInProgress;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr__fEnableCascading;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr__fIsSchemaLoading;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr__mainTableName;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr__remotingFormat;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr__defaultViewManagerLock;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_s_objectTypeCount;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_s_schemaTypeForWSDL;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr__useDataSetSchemaOnly;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr__udtIsWrapped;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_PropertyChanging;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_MergeFailed;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_DataRowCreated;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_ClearFunctionCalled;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_get_RemotingFormat_Public_get_SerializationFormat_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_set_RemotingFormat_Public_set_Void_SerializationFormat_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaSerializationMode_Public_Virtual_New_get_SchemaSerializationMode_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_Boolean_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDerivedDataSet_Protected_Virtual_New_Void_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_SerializeDataSet_Private_Void_SerializationInfo_StreamingContext_SerializationFormat_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeDataSet_Internal_Void_SerializationInfo_StreamingContext_SerializationFormat_SchemaSerializationMode_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeDataSetSchema_Private_Void_SerializationInfo_StreamingContext_SerializationFormat_SchemaSerializationMode_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeDataSetData_Private_Void_SerializationInfo_StreamingContext_SerializationFormat_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_SerializeDataSetProperties_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeDataSetProperties_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_SerializeRelations_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeRelations_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_FailedEnableConstraints_Internal_Void_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_get_CaseSensitive_Public_get_Boolean_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_set_CaseSensitive_Public_set_Void_Boolean_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_get_EnforceConstraints_Public_get_Boolean_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_set_EnforceConstraints_Public_set_Void_Boolean_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_RestoreEnforceConstraints_Internal_Void_Boolean_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_EnableConstraints_Internal_Void_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSetName_Public_get_String_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_set_DataSetName_Public_set_Void_String_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_get_Locale_Public_get_CultureInfo_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_set_Locale_Public_set_Void_CultureInfo_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_SetLocaleValue_Internal_Void_CultureInfo_Boolean_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeLocale_Internal_Boolean_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Virtual_get_ISite_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_get_Relations_Public_get_DataRelationCollection_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_get_Tables_Public_get_DataTableCollection_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_DataSet_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_EstimatedXmlStringSize_Internal_Int32_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_GetRemotingDiffGram_Internal_String_DataTable_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlSchemaForRemoting_Internal_String_DataTable_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlSchema_Public_Void_XmlReader_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlSchema_Internal_Void_XmlReader_Boolean_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Internal_Boolean_XmlReader_Int32_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Private_Static_Void_XmlReader_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_ReadEndElement_Internal_Void_XmlReader_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_ReadXSDSchema_Internal_Void_XmlReader_Boolean_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_ReadXDRSchema_Internal_Void_XmlReader_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlSchema_Private_Void_XmlWriter_SchemaFormat_Converter_2_Type_String_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_ReadXml_Public_XmlReadMode_XmlReader_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_ReadXml_Internal_XmlReadMode_XmlReader_Boolean_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_InferSchema_Internal_Void_XmlDocument_Il2CppStringArray_XmlReadMode_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Private_Boolean_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlDiffgram_Private_Void_XmlReader_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_ReadXml_Public_XmlReadMode_XmlReader_XmlReadMode_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_ReadXml_Internal_XmlReadMode_XmlReader_XmlReadMode_Boolean_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_WriteXml_Public_Void_XmlWriter_XmlWriteMode_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Void_DataSet_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Void_DataSet_Boolean_MissingSchemaAction_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_PropertyChangedEventArgs_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_OnMergeFailed_Internal_Void_MergeFailedEventArgs_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_RaiseMergeFailed_Internal_Void_DataTable_String_MissingSchemaAction_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_OnDataRowCreated_Internal_Void_DataRow_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_OnClearFunctionCalled_Internal_Void_DataTable_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_OnRemoveTable_FamOrAssem_Virtual_New_Void_DataTable_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedTable_Internal_Void_DataTable_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_OnRemoveRelation_Protected_Virtual_New_Void_DataRelation_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_OnRemoveRelationHack_Internal_Void_DataRelation_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_RaisePropertyChanging_FamOrAssem_Void_String_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_TopLevelTables_Internal_Il2CppReferenceArray_1_DataTable_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_TopLevelTables_Internal_Il2CppReferenceArray_1_DataTable_Boolean_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCaseConstraint_Internal_Boolean_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_ValidateLocaleConstraint_Internal_Boolean_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_FindTable_Internal_DataTable_DataTable_Il2CppReferenceArray_1_PropertyDescriptor_Int32_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlSerializable_Protected_Virtual_New_Void_XmlReader_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_GetDataSetSchema_Public_Static_XmlSchemaComplexType_XmlSchemaSet_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_get_MainTableName_Internal_get_String_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_set_MainTableName_Internal_set_Void_String_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0;
	}
}
