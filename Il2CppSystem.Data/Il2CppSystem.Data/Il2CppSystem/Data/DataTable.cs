using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	public class DataTable : MarshalByValueComponent
	{
		// Token: 0x060002D9 RID: 729 RVA: 0x00014F90 File Offset: 0x00013190
		// Note: this type is marked as 'beforefieldinit'.
		static DataTable()
		{
			Il2CppClassPointerStore<DataTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataTable>.NativeClassPtr);
			DataTable.NativeFieldInfoPtr__dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_dataSet");
			DataTable.NativeFieldInfoPtr__defaultView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_defaultView");
			DataTable.NativeFieldInfoPtr__nextRowID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_nextRowID");
			DataTable.NativeFieldInfoPtr__rowCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_rowCollection");
			DataTable.NativeFieldInfoPtr__columnCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_columnCollection");
			DataTable.NativeFieldInfoPtr__constraintCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_constraintCollection");
			DataTable.NativeFieldInfoPtr__elementColumnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_elementColumnCount");
			DataTable.NativeFieldInfoPtr__parentRelationsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_parentRelationsCollection");
			DataTable.NativeFieldInfoPtr__childRelationsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_childRelationsCollection");
			DataTable.NativeFieldInfoPtr__recordManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_recordManager");
			DataTable.NativeFieldInfoPtr__indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_indexes");
			DataTable.NativeFieldInfoPtr__shadowIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_shadowIndexes");
			DataTable.NativeFieldInfoPtr__shadowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_shadowCount");
			DataTable.NativeFieldInfoPtr__extendedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_extendedProperties");
			DataTable.NativeFieldInfoPtr__tableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_tableName");
			DataTable.NativeFieldInfoPtr__tableNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_tableNamespace");
			DataTable.NativeFieldInfoPtr__tablePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_tablePrefix");
			DataTable.NativeFieldInfoPtr__displayExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_displayExpression");
			DataTable.NativeFieldInfoPtr__fNestedInDataset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_fNestedInDataset");
			DataTable.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_culture");
			DataTable.NativeFieldInfoPtr__cultureUserSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_cultureUserSet");
			DataTable.NativeFieldInfoPtr__compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_compareInfo");
			DataTable.NativeFieldInfoPtr__compareFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_compareFlags");
			DataTable.NativeFieldInfoPtr__formatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_formatProvider");
			DataTable.NativeFieldInfoPtr__hashCodeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_hashCodeProvider");
			DataTable.NativeFieldInfoPtr__caseSensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_caseSensitive");
			DataTable.NativeFieldInfoPtr__caseSensitiveUserSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_caseSensitiveUserSet");
			DataTable.NativeFieldInfoPtr__encodedTableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_encodedTableName");
			DataTable.NativeFieldInfoPtr__xmlText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_xmlText");
			DataTable.NativeFieldInfoPtr__colUnique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_colUnique");
			DataTable.NativeFieldInfoPtr__minOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_minOccurs");
			DataTable.NativeFieldInfoPtr__maxOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_maxOccurs");
			DataTable.NativeFieldInfoPtr__repeatableElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_repeatableElement");
			DataTable.NativeFieldInfoPtr__typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_typeName");
			DataTable.NativeFieldInfoPtr__primaryKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_primaryKey");
			DataTable.NativeFieldInfoPtr__primaryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_primaryIndex");
			DataTable.NativeFieldInfoPtr__delayedSetPrimaryKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_delayedSetPrimaryKey");
			DataTable.NativeFieldInfoPtr__loadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_loadIndex");
			DataTable.NativeFieldInfoPtr__loadIndexwithOriginalAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_loadIndexwithOriginalAdded");
			DataTable.NativeFieldInfoPtr__loadIndexwithCurrentDeleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_loadIndexwithCurrentDeleted");
			DataTable.NativeFieldInfoPtr__suspendIndexEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_suspendIndexEvents");
			DataTable.NativeFieldInfoPtr__inDataLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_inDataLoad");
			DataTable.NativeFieldInfoPtr__schemaLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_schemaLoading");
			DataTable.NativeFieldInfoPtr__enforceConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_enforceConstraints");
			DataTable.NativeFieldInfoPtr__suspendEnforceConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_suspendEnforceConstraints");
			DataTable.NativeFieldInfoPtr_fInitInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "fInitInProgress");
			DataTable.NativeFieldInfoPtr__inLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_inLoad");
			DataTable.NativeFieldInfoPtr__fInLoadDiffgram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_fInLoadDiffgram");
			DataTable.NativeFieldInfoPtr__isTypedDataTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_isTypedDataTable");
			DataTable.NativeFieldInfoPtr__emptyDataRowArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_emptyDataRowArray");
			DataTable.NativeFieldInfoPtr__propertyDescriptorCollectionCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_propertyDescriptorCollectionCache");
			DataTable.NativeFieldInfoPtr__nestedParentRelations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_nestedParentRelations");
			DataTable.NativeFieldInfoPtr__dependentColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_dependentColumns");
			DataTable.NativeFieldInfoPtr__mergingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_mergingData");
			DataTable.NativeFieldInfoPtr__onRowChangedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_onRowChangedDelegate");
			DataTable.NativeFieldInfoPtr__onRowChangingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_onRowChangingDelegate");
			DataTable.NativeFieldInfoPtr__onRowDeletingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_onRowDeletingDelegate");
			DataTable.NativeFieldInfoPtr__onRowDeletedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_onRowDeletedDelegate");
			DataTable.NativeFieldInfoPtr__onColumnChangedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_onColumnChangedDelegate");
			DataTable.NativeFieldInfoPtr__onColumnChangingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_onColumnChangingDelegate");
			DataTable.NativeFieldInfoPtr__onTableClearingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_onTableClearingDelegate");
			DataTable.NativeFieldInfoPtr__onTableClearedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_onTableClearedDelegate");
			DataTable.NativeFieldInfoPtr__onTableNewRowDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_onTableNewRowDelegate");
			DataTable.NativeFieldInfoPtr__onPropertyChangingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_onPropertyChangingDelegate");
			DataTable.NativeFieldInfoPtr__rowBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_rowBuilder");
			DataTable.NativeFieldInfoPtr__delayedViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_delayedViews");
			DataTable.NativeFieldInfoPtr__dataViewListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_dataViewListeners");
			DataTable.NativeFieldInfoPtr__rowDiffId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_rowDiffId");
			DataTable.NativeFieldInfoPtr__indexesLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_indexesLock");
			DataTable.NativeFieldInfoPtr__ukColumnPositionForInference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_ukColumnPositionForInference");
			DataTable.NativeFieldInfoPtr__remotingFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_remotingFormat");
			DataTable.NativeFieldInfoPtr_s_objectTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "s_objectTypeCount");
			DataTable.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "_objectID");
			DataTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663830);
			DataTable.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663831);
			DataTable.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663832);
			DataTable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663833);
			DataTable.NativeMethodInfoPtr_SerializeDataTable_Private_Void_SerializationInfo_StreamingContext_Boolean_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663834);
			DataTable.NativeMethodInfoPtr_DeserializeDataTable_Internal_Void_SerializationInfo_StreamingContext_Boolean_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663835);
			DataTable.NativeMethodInfoPtr_SerializeTableSchema_Internal_Void_SerializationInfo_StreamingContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663836);
			DataTable.NativeMethodInfoPtr_DeserializeTableSchema_Internal_Void_SerializationInfo_StreamingContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663837);
			DataTable.NativeMethodInfoPtr_SerializeConstraints_Internal_Void_SerializationInfo_StreamingContext_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663838);
			DataTable.NativeMethodInfoPtr_DeserializeConstraints_Internal_Void_SerializationInfo_StreamingContext_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663839);
			DataTable.NativeMethodInfoPtr_SerializeExpressionColumns_Internal_Void_SerializationInfo_StreamingContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663840);
			DataTable.NativeMethodInfoPtr_DeserializeExpressionColumns_Internal_Void_SerializationInfo_StreamingContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663841);
			DataTable.NativeMethodInfoPtr_SerializeTableData_Internal_Void_SerializationInfo_StreamingContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663842);
			DataTable.NativeMethodInfoPtr_DeserializeTableData_Internal_Void_SerializationInfo_StreamingContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663843);
			DataTable.NativeMethodInfoPtr_ConvertToRowState_Private_DataRowState_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663844);
			DataTable.NativeMethodInfoPtr_GetRowAndColumnErrors_Internal_Void_Int32_Hashtable_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663845);
			DataTable.NativeMethodInfoPtr_ConvertToRowError_Private_Void_Int32_Hashtable_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663846);
			DataTable.NativeMethodInfoPtr_get_CaseSensitive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663847);
			DataTable.NativeMethodInfoPtr_set_CaseSensitive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663848);
			DataTable.NativeMethodInfoPtr_get_AreIndexEventsSuspended_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663849);
			DataTable.NativeMethodInfoPtr_RestoreIndexEvents_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663850);
			DataTable.NativeMethodInfoPtr_SuspendIndexEvents_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663851);
			DataTable.NativeMethodInfoPtr_get_IsTypedDataTable_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663852);
			DataTable.NativeMethodInfoPtr_SetCaseSensitiveValue_Internal_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663853);
			DataTable.NativeMethodInfoPtr_ShouldSerializeCaseSensitive_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663854);
			DataTable.NativeMethodInfoPtr_get_SelfNested_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663855);
			DataTable.NativeMethodInfoPtr_get_LiveIndexes_Internal_get_List_1_Index_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663856);
			DataTable.NativeMethodInfoPtr_get_RemotingFormat_Public_get_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663857);
			DataTable.NativeMethodInfoPtr_set_RemotingFormat_Public_set_Void_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663858);
			DataTable.NativeMethodInfoPtr_get_UKColumnPositionForInference_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663859);
			DataTable.NativeMethodInfoPtr_set_UKColumnPositionForInference_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663860);
			DataTable.NativeMethodInfoPtr_get_ChildRelations_Public_get_DataRelationCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663861);
			DataTable.NativeMethodInfoPtr_get_Columns_Public_get_DataColumnCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663862);
			DataTable.NativeMethodInfoPtr_get_CompareInfo_Private_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663863);
			DataTable.NativeMethodInfoPtr_get_Constraints_Public_get_ConstraintCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663864);
			DataTable.NativeMethodInfoPtr_ResetConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663865);
			DataTable.NativeMethodInfoPtr_get_DataSet_Public_get_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663866);
			DataTable.NativeMethodInfoPtr_SetDataSet_Internal_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663867);
			DataTable.NativeMethodInfoPtr_get_DisplayExpressionInternal_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663868);
			DataTable.NativeMethodInfoPtr_get_EnforceConstraints_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663869);
			DataTable.NativeMethodInfoPtr_set_EnforceConstraints_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663870);
			DataTable.NativeMethodInfoPtr_get_SuspendEnforceConstraints_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663871);
			DataTable.NativeMethodInfoPtr_set_SuspendEnforceConstraints_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663872);
			DataTable.NativeMethodInfoPtr_EnableConstraints_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663873);
			DataTable.NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663874);
			DataTable.NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663875);
			DataTable.NativeMethodInfoPtr_get_Locale_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663876);
			DataTable.NativeMethodInfoPtr_set_Locale_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663877);
			DataTable.NativeMethodInfoPtr_SetLocaleValue_Internal_Boolean_CultureInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663878);
			DataTable.NativeMethodInfoPtr_ShouldSerializeLocale_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663879);
			DataTable.NativeMethodInfoPtr_get_MinimumCapacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663880);
			DataTable.NativeMethodInfoPtr_set_MinimumCapacity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663881);
			DataTable.NativeMethodInfoPtr_get_RecordCapacity_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663882);
			DataTable.NativeMethodInfoPtr_get_ElementColumnCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663883);
			DataTable.NativeMethodInfoPtr_set_ElementColumnCount_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663884);
			DataTable.NativeMethodInfoPtr_get_ParentRelations_Public_get_DataRelationCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663885);
			DataTable.NativeMethodInfoPtr_get_MergingData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663886);
			DataTable.NativeMethodInfoPtr_set_MergingData_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663887);
			DataTable.NativeMethodInfoPtr_get_NestedParentRelations_Internal_get_Il2CppReferenceArray_1_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663888);
			DataTable.NativeMethodInfoPtr_get_SchemaLoading_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663889);
			DataTable.NativeMethodInfoPtr_CacheNestedParent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663890);
			DataTable.NativeMethodInfoPtr_FindNestedParentRelations_Private_Il2CppReferenceArray_1_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663891);
			DataTable.NativeMethodInfoPtr_get_NestedParentsCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663892);
			DataTable.NativeMethodInfoPtr_get_PrimaryKey_Public_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663893);
			DataTable.NativeMethodInfoPtr_set_PrimaryKey_Public_set_Void_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663894);
			DataTable.NativeMethodInfoPtr_get_Rows_Public_get_DataRowCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663895);
			DataTable.NativeMethodInfoPtr_get_TableName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663896);
			DataTable.NativeMethodInfoPtr_set_TableName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663897);
			DataTable.NativeMethodInfoPtr_get_EncodedTableName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663898);
			DataTable.NativeMethodInfoPtr_GetInheritedNamespace_Private_String_List_1_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663899);
			DataTable.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663900);
			DataTable.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663901);
			DataTable.NativeMethodInfoPtr_IsNamespaceInherited_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663902);
			DataTable.NativeMethodInfoPtr_CheckCascadingNamespaceConflict_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663903);
			DataTable.NativeMethodInfoPtr_CheckNamespaceValidityForNestedRelations_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663904);
			DataTable.NativeMethodInfoPtr_CheckNamespaceValidityForNestedParentRelations_Internal_Void_String_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663905);
			DataTable.NativeMethodInfoPtr_DoRaiseNamespaceChange_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663906);
			DataTable.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663907);
			DataTable.NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663908);
			DataTable.NativeMethodInfoPtr_get_XmlText_Internal_get_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663909);
			DataTable.NativeMethodInfoPtr_set_XmlText_Internal_set_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663910);
			DataTable.NativeMethodInfoPtr_get_MaxOccurs_Internal_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663911);
			DataTable.NativeMethodInfoPtr_set_MaxOccurs_Internal_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663912);
			DataTable.NativeMethodInfoPtr_get_MinOccurs_Internal_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663913);
			DataTable.NativeMethodInfoPtr_set_MinOccurs_Internal_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663914);
			DataTable.NativeMethodInfoPtr_SetKeyValues_Internal_Void_DataKey_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663915);
			DataTable.NativeMethodInfoPtr_FindByIndex_Internal_DataRow_Index_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663916);
			DataTable.NativeMethodInfoPtr_FindMergeTarget_Internal_DataRow_DataRow_DataKey_Index_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663917);
			DataTable.NativeMethodInfoPtr_SetMergeRecords_Private_Void_DataRow_Int32_Int32_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663918);
			DataTable.NativeMethodInfoPtr_MergeRow_Internal_DataRow_DataRow_DataRow_Boolean_Index_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663919);
			DataTable.NativeMethodInfoPtr_CreateInstance_Protected_Virtual_New_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663920);
			DataTable.NativeMethodInfoPtr_Clone_Public_Virtual_New_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663921);
			DataTable.NativeMethodInfoPtr_Clone_Internal_DataTable_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663922);
			DataTable.NativeMethodInfoPtr_IncrementalCloneTo_Private_DataTable_DataTable_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663923);
			DataTable.NativeMethodInfoPtr_CloneHierarchy_Private_DataTable_DataTable_DataSet_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663924);
			DataTable.NativeMethodInfoPtr_CloneTo_Private_DataTable_DataTable_DataSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663925);
			DataTable.NativeMethodInfoPtr_get_Site_Public_Virtual_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663926);
			DataTable.NativeMethodInfoPtr_AddRow_Internal_Void_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663927);
			DataTable.NativeMethodInfoPtr_InsertRow_Internal_Void_DataRow_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663928);
			DataTable.NativeMethodInfoPtr_InsertRow_Internal_Void_DataRow_Int64_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663929);
			DataTable.NativeMethodInfoPtr_CheckNotModifying_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663930);
			DataTable.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663931);
			DataTable.NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663932);
			DataTable.NativeMethodInfoPtr_CascadeAll_Internal_Void_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663933);
			DataTable.NativeMethodInfoPtr_CommitRow_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663934);
			DataTable.NativeMethodInfoPtr_Compare_Internal_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663935);
			DataTable.NativeMethodInfoPtr_Compare_Internal_Int32_String_String_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663936);
			DataTable.NativeMethodInfoPtr_IndexOf_Internal_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663937);
			DataTable.NativeMethodInfoPtr_IsSuffix_Internal_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663938);
			DataTable.NativeMethodInfoPtr_DeleteRow_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663939);
			DataTable.NativeMethodInfoPtr_FormatSortString_Internal_String_Il2CppReferenceArray_1_IndexField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663940);
			DataTable.NativeMethodInfoPtr_FreeRecord_Internal_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663941);
			DataTable.NativeMethodInfoPtr_GetIndex_Internal_Index_String_DataViewRowState_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663942);
			DataTable.NativeMethodInfoPtr_GetIndex_Internal_Index_Il2CppReferenceArray_1_IndexField_DataViewRowState_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663943);
			DataTable.NativeMethodInfoPtr_GetListeners_Internal_List_1_DataViewListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663944);
			DataTable.NativeMethodInfoPtr_GetSpecialHashCode_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663945);
			DataTable.NativeMethodInfoPtr_InsertRow_Internal_Void_DataRow_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663946);
			DataTable.NativeMethodInfoPtr_NewRecord_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663947);
			DataTable.NativeMethodInfoPtr_NewUninitializedRecord_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663948);
			DataTable.NativeMethodInfoPtr_NewRecord_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663949);
			DataTable.NativeMethodInfoPtr_NewEmptyRow_Internal_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663950);
			DataTable.NativeMethodInfoPtr_NewUninitializedRow_Private_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663951);
			DataTable.NativeMethodInfoPtr_NewRow_Public_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663952);
			DataTable.NativeMethodInfoPtr_CreateEmptyRow_Internal_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663953);
			DataTable.NativeMethodInfoPtr_NewRowCreated_Private_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663954);
			DataTable.NativeMethodInfoPtr_NewRow_Internal_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663955);
			DataTable.NativeMethodInfoPtr_NewRowFromBuilder_Protected_Virtual_New_DataRow_DataRowBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663956);
			DataTable.NativeMethodInfoPtr_GetRowType_Protected_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663957);
			DataTable.NativeMethodInfoPtr_NewRowArray_FamOrAssem_Il2CppReferenceArray_1_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663958);
			DataTable.NativeMethodInfoPtr_get_NeedColumnChangeEvents_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663959);
			DataTable.NativeMethodInfoPtr_OnColumnChanging_FamOrAssem_Virtual_New_Void_DataColumnChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663960);
			DataTable.NativeMethodInfoPtr_OnColumnChanged_FamOrAssem_Virtual_New_Void_DataColumnChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663961);
			DataTable.NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_PropertyChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663962);
			DataTable.NativeMethodInfoPtr_OnRemoveColumnInternal_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663963);
			DataTable.NativeMethodInfoPtr_OnRemoveColumn_Protected_Virtual_New_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663964);
			DataTable.NativeMethodInfoPtr_OnRowChanged_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663965);
			DataTable.NativeMethodInfoPtr_OnRowChanging_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663966);
			DataTable.NativeMethodInfoPtr_OnRowChanged_Protected_Virtual_New_Void_DataRowChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663967);
			DataTable.NativeMethodInfoPtr_OnRowChanging_Protected_Virtual_New_Void_DataRowChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663968);
			DataTable.NativeMethodInfoPtr_OnRowDeleting_Protected_Virtual_New_Void_DataRowChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663969);
			DataTable.NativeMethodInfoPtr_OnRowDeleted_Protected_Virtual_New_Void_DataRowChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663970);
			DataTable.NativeMethodInfoPtr_OnTableCleared_Protected_Virtual_New_Void_DataTableClearEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663971);
			DataTable.NativeMethodInfoPtr_OnTableClearing_Protected_Virtual_New_Void_DataTableClearEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663972);
			DataTable.NativeMethodInfoPtr_OnTableNewRow_Protected_Virtual_New_Void_DataTableNewRowEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663973);
			DataTable.NativeMethodInfoPtr_ParseSortString_Internal_Il2CppReferenceArray_1_IndexField_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663974);
			DataTable.NativeMethodInfoPtr_RaisePropertyChanging_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663975);
			DataTable.NativeMethodInfoPtr_RecordChanged_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663976);
			DataTable.NativeMethodInfoPtr_RecordChanged_Internal_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663977);
			DataTable.NativeMethodInfoPtr_RecordStateChanged_Internal_Void_Int32_DataViewRowState_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663978);
			DataTable.NativeMethodInfoPtr_RecordStateChanged_Internal_Void_Int32_DataViewRowState_DataViewRowState_Int32_DataViewRowState_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663979);
			DataTable.NativeMethodInfoPtr_RemoveRecordFromIndexes_Internal_Il2CppStructArray_1_Int32_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663980);
			DataTable.NativeMethodInfoPtr_InsertRecordToIndexes_Internal_Il2CppStructArray_1_Int32_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663981);
			DataTable.NativeMethodInfoPtr_SilentlySetValue_Internal_Void_DataRow_DataColumn_DataRowVersion_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663982);
			DataTable.NativeMethodInfoPtr_RemoveRow_Internal_Void_DataRow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663983);
			DataTable.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663984);
			DataTable.NativeMethodInfoPtr_ResetIndexes_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663985);
			DataTable.NativeMethodInfoPtr_ResetInternalIndexes_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663986);
			DataTable.NativeMethodInfoPtr_RollbackRow_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663987);
			DataTable.NativeMethodInfoPtr_RaiseRowChanged_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663988);
			DataTable.NativeMethodInfoPtr_RaiseRowChanging_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663989);
			DataTable.NativeMethodInfoPtr_RaiseRowChanging_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663990);
			DataTable.NativeMethodInfoPtr_SetNewRecord_Internal_Void_DataRow_Int32_DataRowAction_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663991);
			DataTable.NativeMethodInfoPtr_SetNewRecordWorker_Private_Void_DataRow_Int32_DataRowAction_Boolean_Boolean_Int32_Boolean_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663992);
			DataTable.NativeMethodInfoPtr_SetOldRecord_Internal_Void_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663993);
			DataTable.NativeMethodInfoPtr_RestoreShadowIndexes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663994);
			DataTable.NativeMethodInfoPtr_SetShadowIndexes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663995);
			DataTable.NativeMethodInfoPtr_ShadowIndexCopy_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663996);
			DataTable.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663997);
			DataTable.NativeMethodInfoPtr_UpdatingCurrent_Internal_Boolean_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663998);
			DataTable.NativeMethodInfoPtr_AddUniqueKey_Internal_DataColumn_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100663999);
			DataTable.NativeMethodInfoPtr_AddUniqueKey_Internal_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664000);
			DataTable.NativeMethodInfoPtr_AddForeignKey_Internal_DataColumn_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664001);
			DataTable.NativeMethodInfoPtr_UpdatePropertyDescriptorCollectionCache_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664002);
			DataTable.NativeMethodInfoPtr_GetPropertyDescriptorCollection_Internal_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664003);
			DataTable.NativeMethodInfoPtr_get_TypeName_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664004);
			DataTable.NativeMethodInfoPtr_set_TypeName_Internal_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664005);
			DataTable.NativeMethodInfoPtr_Merge_Public_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664006);
			DataTable.NativeMethodInfoPtr_Merge_Public_Void_DataTable_Boolean_MissingSchemaAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664007);
			DataTable.NativeMethodInfoPtr_WriteXml_Public_Void_XmlWriter_XmlWriteMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664008);
			DataTable.NativeMethodInfoPtr_CheckForClosureOnExpressions_Private_Boolean_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664009);
			DataTable.NativeMethodInfoPtr_CheckForClosureOnExpressionTables_Private_Boolean_List_1_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664010);
			DataTable.NativeMethodInfoPtr_WriteXmlSchema_Public_Void_XmlWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664011);
			DataTable.NativeMethodInfoPtr_RestoreConstraint_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664012);
			DataTable.NativeMethodInfoPtr_IsEmptyXml_Private_Boolean_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664013);
			DataTable.NativeMethodInfoPtr_ReadXml_Internal_XmlReadMode_XmlReader_XmlReadMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664014);
			DataTable.NativeMethodInfoPtr_ReadEndElement_Internal_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664015);
			DataTable.NativeMethodInfoPtr_ReadXDRSchema_Internal_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664016);
			DataTable.NativeMethodInfoPtr_MoveToElement_Internal_Boolean_XmlReader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664017);
			DataTable.NativeMethodInfoPtr_ReadXmlDiffgram_Private_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664018);
			DataTable.NativeMethodInfoPtr_ReadXSDSchema_Internal_Void_XmlReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664019);
			DataTable.NativeMethodInfoPtr_ReadXmlSchema_Internal_Void_XmlReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664020);
			DataTable.NativeMethodInfoPtr_CreateTableList_Private_Void_DataTable_List_1_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664021);
			DataTable.NativeMethodInfoPtr_CreateRelationList_Private_Void_List_1_DataTable_List_1_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664022);
			DataTable.NativeMethodInfoPtr_GetDataTableSchema_Public_Static_XmlSchemaComplexType_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664023);
			DataTable.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664024);
			DataTable.NativeMethodInfoPtr_GetSchema_Protected_Virtual_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664025);
			DataTable.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664026);
			DataTable.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664027);
			DataTable.NativeMethodInfoPtr_ReadXmlSerializable_Protected_Virtual_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664028);
			DataTable.NativeMethodInfoPtr_get_RowDiffId_Internal_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664029);
			DataTable.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664030);
			DataTable.NativeMethodInfoPtr_AddDependentColumn_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664031);
			DataTable.NativeMethodInfoPtr_RemoveDependentColumn_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664032);
			DataTable.NativeMethodInfoPtr_EvaluateExpressions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664033);
			DataTable.NativeMethodInfoPtr_EvaluateExpressions_Internal_Void_DataRow_DataRowAction_List_1_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664034);
			DataTable.NativeMethodInfoPtr_EvaluateExpressions_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664035);
			DataTable.NativeMethodInfoPtr_EvaluateDependentExpressions_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664036);
			DataTable.NativeMethodInfoPtr_EvaluateDependentExpressions_Internal_Void_List_1_DataColumn_DataRow_DataRowVersion_List_1_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable>.NativeClassPtr, 100664037);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000165B4 File Offset: 0x000147B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 893284, RefRangeEnd = 893289, XrefRangeStart = 893189, XrefRangeEnd = 893284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000165F0 File Offset: 0x000147F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 893294, RefRangeEnd = 893298, XrefRangeStart = 893289, XrefRangeEnd = 893294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable(string tableName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0001663C File Offset: 0x0001483C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893298, XrefRangeEnd = 893320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000166A0 File Offset: 0x000148A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893320, XrefRangeEnd = 893330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00016704 File Offset: 0x00014904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 893350, RefRangeEnd = 893351, XrefRangeStart = 893330, XrefRangeEnd = 893350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSingleTable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remotingFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SerializeDataTable_Private_Void_SerializationInfo_StreamingContext_Boolean_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001677C File Offset: 0x0001497C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 893396, RefRangeEnd = 893397, XrefRangeStart = 893351, XrefRangeEnd = 893396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSingleTable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remotingFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_DeserializeDataTable_Internal_Void_SerializationInfo_StreamingContext_Boolean_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000167F4 File Offset: 0x000149F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 893604, RefRangeEnd = 893605, XrefRangeStart = 893397, XrefRangeEnd = 893604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSingleTable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SerializeTableSchema_Internal_Void_SerializationInfo_StreamingContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001685C File Offset: 0x00014A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893605, XrefRangeEnd = 893863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSingleTable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_DeserializeTableSchema_Internal_Void_SerializationInfo_StreamingContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000168C4 File Offset: 0x00014AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 893920, RefRangeEnd = 893921, XrefRangeStart = 893863, XrefRangeEnd = 893920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allConstraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SerializeConstraints_Internal_Void_SerializationInfo_StreamingContext_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0001693C File Offset: 0x00014B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 894018, RefRangeEnd = 894019, XrefRangeStart = 893921, XrefRangeEnd = 894018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allConstraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_DeserializeConstraints_Internal_Void_SerializationInfo_StreamingContext_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000169B4 File Offset: 0x00014BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 894019, XrefRangeEnd = 894034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SerializeExpressionColumns_Internal_Void_SerializationInfo_StreamingContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00016A1C File Offset: 0x00014C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 894034, XrefRangeEnd = 894049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_DeserializeExpressionColumns_Internal_Void_SerializationInfo_StreamingContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00016A84 File Offset: 0x00014C84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 894130, RefRangeEnd = 894131, XrefRangeStart = 894049, XrefRangeEnd = 894130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SerializeTableData_Internal_Void_SerializationInfo_StreamingContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00016AEC File Offset: 0x00014CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 894131, XrefRangeEnd = 894234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_DeserializeTableData_Internal_Void_SerializationInfo_StreamingContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00016B54 File Offset: 0x00014D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 894234, XrefRangeEnd = 894236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowState ConvertToRowState(BitArray bitStates, int bitIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bitStates);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bitIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ConvertToRowState_Private_DataRowState_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00016BB0 File Offset: 0x00014DB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 894258, RefRangeEnd = 894259, XrefRangeStart = 894236, XrefRangeEnd = 894258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rowIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowErrors);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colErrors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_GetRowAndColumnErrors_Internal_Void_Int32_Hashtable_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00016C14 File Offset: 0x00014E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 894284, RefRangeEnd = 894285, XrefRangeStart = 894259, XrefRangeEnd = 894284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rowIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowErrors);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colErrors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ConvertToRowError_Private_Void_Int32_Hashtable_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00016C78 File Offset: 0x00014E78
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00016CB4 File Offset: 0x00014EB4
		public unsafe bool CaseSensitive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_CaseSensitive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 894287, RefRangeEnd = 894289, XrefRangeStart = 894285, XrefRangeEnd = 894287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_CaseSensitive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00016CF4 File Offset: 0x00014EF4
		public unsafe bool AreIndexEventsSuspended
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 894289, RefRangeEnd = 894295, XrefRangeStart = 894289, XrefRangeEnd = 894289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_AreIndexEventsSuspended_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00016D30 File Offset: 0x00014F30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 894326, RefRangeEnd = 894328, XrefRangeStart = 894295, XrefRangeEnd = 894326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreIndexEvents(bool forceReset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forceReset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RestoreIndexEvents_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00016D70 File Offset: 0x00014F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 894337, RefRangeEnd = 894338, XrefRangeStart = 894328, XrefRangeEnd = 894337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SuspendIndexEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SuspendIndexEvents_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00016DA4 File Offset: 0x00014FA4
		public unsafe bool IsTypedDataTable
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 894346, RefRangeEnd = 894358, XrefRangeStart = 894338, XrefRangeEnd = 894346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_IsTypedDataTable_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00016DE0 File Offset: 0x00014FE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 894378, RefRangeEnd = 894382, XrefRangeStart = 894358, XrefRangeEnd = 894378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isCaseSensitive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userSet;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetIndexes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SetCaseSensitiveValue_Internal_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00016E48 File Offset: 0x00015048
		[CallerCount(0)]
		public unsafe bool ShouldSerializeCaseSensitive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ShouldSerializeCaseSensitive_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00016E84 File Offset: 0x00015084
		public unsafe bool SelfNested
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 894392, RefRangeEnd = 894394, XrefRangeStart = 894382, XrefRangeEnd = 894392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_SelfNested_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00016EC0 File Offset: 0x000150C0
		public unsafe List<Index> LiveIndexes
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 894399, RefRangeEnd = 894407, XrefRangeStart = 894394, XrefRangeEnd = 894399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_LiveIndexes_Internal_get_List_1_Index_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Index>>(intPtr3) : null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00016F00 File Offset: 0x00015100
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00016F3C File Offset: 0x0001513C
		public unsafe SerializationFormat RemotingFormat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_RemotingFormat_Public_get_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 894407, RefRangeEnd = 894409, XrefRangeStart = 894407, XrefRangeEnd = 894407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_RemotingFormat_Public_set_Void_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00016F7C File Offset: 0x0001517C
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00016FB8 File Offset: 0x000151B8
		public unsafe int UKColumnPositionForInference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_UKColumnPositionForInference_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_UKColumnPositionForInference_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00016FF8 File Offset: 0x000151F8
		public unsafe DataRelationCollection ChildRelations
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 894414, RefRangeEnd = 894452, XrefRangeStart = 894409, XrefRangeEnd = 894414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_ChildRelations_Public_get_DataRelationCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelationCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00017038 File Offset: 0x00015238
		public unsafe DataColumnCollection Columns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_Columns_Public_get_DataColumnCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumnCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00017078 File Offset: 0x00015278
		public unsafe CompareInfo CompareInfo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 894453, RefRangeEnd = 894455, XrefRangeStart = 894452, XrefRangeEnd = 894453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_CompareInfo_Private_get_CompareInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002FC RID: 764 RVA: 0x000170B8 File Offset: 0x000152B8
		public unsafe ConstraintCollection Constraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_Constraints_Public_get_ConstraintCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstraintCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000170F8 File Offset: 0x000152F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 894455, XrefRangeEnd = 894457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ResetConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0001712C File Offset: 0x0001532C
		public unsafe DataSet DataSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_DataSet_Public_get_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr3) : null;
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0001716C File Offset: 0x0001536C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 894462, RefRangeEnd = 894464, XrefRangeStart = 894457, XrefRangeEnd = 894462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDataSet(DataSet dataSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SetDataSet_Internal_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000300 RID: 768 RVA: 0x000171B0 File Offset: 0x000153B0
		public unsafe string DisplayExpressionInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 894464, XrefRangeEnd = 894467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_DisplayExpressionInternal_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000301 RID: 769 RVA: 0x000171E8 File Offset: 0x000153E8
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00017224 File Offset: 0x00015424
		public unsafe bool EnforceConstraints
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 894467, RefRangeEnd = 894474, XrefRangeStart = 894467, XrefRangeEnd = 894467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_EnforceConstraints_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 894475, RefRangeEnd = 894477, XrefRangeStart = 894474, XrefRangeEnd = 894475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_EnforceConstraints_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00017264 File Offset: 0x00015464
		// (set) Token: 0x06000304 RID: 772 RVA: 0x000172A0 File Offset: 0x000154A0
		public unsafe bool SuspendEnforceConstraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_SuspendEnforceConstraints_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_SuspendEnforceConstraints_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000172E0 File Offset: 0x000154E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 894513, RefRangeEnd = 894517, XrefRangeStart = 894477, XrefRangeEnd = 894513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_EnableConstraints_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00017314 File Offset: 0x00015514
		public unsafe PropertyCollection ExtendedProperties
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 894522, RefRangeEnd = 894527, XrefRangeStart = 894517, XrefRangeEnd = 894522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00017354 File Offset: 0x00015554
		public unsafe IFormatProvider FormatProvider
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 894532, RefRangeEnd = 894555, XrefRangeStart = 894527, XrefRangeEnd = 894532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00017394 File Offset: 0x00015594
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000173D4 File Offset: 0x000155D4
		public unsafe CultureInfo Locale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_Locale_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 894578, RefRangeEnd = 894579, XrefRangeStart = 894555, XrefRangeEnd = 894578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_Locale_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00017418 File Offset: 0x00015618
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 894583, RefRangeEnd = 894590, XrefRangeStart = 894579, XrefRangeEnd = 894583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userSet;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetIndexes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SetLocaleValue_Internal_Boolean_CultureInfo_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00017484 File Offset: 0x00015684
		[CallerCount(0)]
		public unsafe bool ShouldSerializeLocale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ShouldSerializeLocale_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000174C0 File Offset: 0x000156C0
		// (set) Token: 0x0600030D RID: 781 RVA: 0x000174FC File Offset: 0x000156FC
		public unsafe int MinimumCapacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_MinimumCapacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 894590, XrefRangeEnd = 894591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_MinimumCapacity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0001753C File Offset: 0x0001573C
		public unsafe int RecordCapacity
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 894591, RefRangeEnd = 894596, XrefRangeStart = 894591, XrefRangeEnd = 894591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_RecordCapacity_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00017578 File Offset: 0x00015778
		// (set) Token: 0x06000310 RID: 784 RVA: 0x000175B4 File Offset: 0x000157B4
		public unsafe int ElementColumnCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_ElementColumnCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 894596, RefRangeEnd = 894604, XrefRangeStart = 894596, XrefRangeEnd = 894596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_ElementColumnCount_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000175F4 File Offset: 0x000157F4
		public unsafe DataRelationCollection ParentRelations
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 894609, RefRangeEnd = 894644, XrefRangeStart = 894604, XrefRangeEnd = 894609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_ParentRelations_Public_get_DataRelationCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelationCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00017634 File Offset: 0x00015834
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00017670 File Offset: 0x00015870
		public unsafe bool MergingData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_MergingData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_MergingData_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000176B0 File Offset: 0x000158B0
		public unsafe Il2CppReferenceArray<DataRelation> NestedParentRelations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_NestedParentRelations_Internal_get_Il2CppReferenceArray_1_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRelation>>(intPtr3) : null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000176F0 File Offset: 0x000158F0
		public unsafe bool SchemaLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_SchemaLoading_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0001772C File Offset: 0x0001592C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 894646, RefRangeEnd = 894650, XrefRangeStart = 894644, XrefRangeEnd = 894646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheNestedParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CacheNestedParent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00017760 File Offset: 0x00015960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 894682, RefRangeEnd = 894683, XrefRangeStart = 894650, XrefRangeEnd = 894682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataRelation> FindNestedParentRelations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_FindNestedParentRelations_Private_Il2CppReferenceArray_1_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRelation>>(intPtr3) : null;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000318 RID: 792 RVA: 0x000177A0 File Offset: 0x000159A0
		public unsafe int NestedParentsCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 894701, RefRangeEnd = 894706, XrefRangeStart = 894683, XrefRangeEnd = 894701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_NestedParentsCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000177DC File Offset: 0x000159DC
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0001781C File Offset: 0x00015A1C
		public unsafe Il2CppReferenceArray<DataColumn> PrimaryKey
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 894709, RefRangeEnd = 894711, XrefRangeStart = 894706, XrefRangeEnd = 894709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_PrimaryKey_Public_get_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 894715, RefRangeEnd = 894723, XrefRangeStart = 894711, XrefRangeEnd = 894715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_PrimaryKey_Public_set_Void_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00017860 File Offset: 0x00015A60
		public unsafe DataRowCollection Rows
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_Rows_Public_get_DataRowCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600031C RID: 796 RVA: 0x000178A0 File Offset: 0x00015AA0
		// (set) Token: 0x0600031D RID: 797 RVA: 0x000178D8 File Offset: 0x00015AD8
		public unsafe string TableName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_TableName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 894767, RefRangeEnd = 894770, XrefRangeStart = 894723, XrefRangeEnd = 894767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_TableName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001791C File Offset: 0x00015B1C
		public unsafe string EncodedTableName
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 894775, RefRangeEnd = 894793, XrefRangeStart = 894770, XrefRangeEnd = 894775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_EncodedTableName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00017954 File Offset: 0x00015B54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 894797, RefRangeEnd = 894801, XrefRangeStart = 894793, XrefRangeEnd = 894797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInheritedNamespace(List<DataTable> visitedTables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitedTables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_GetInheritedNamespace_Private_String_List_1_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001799C File Offset: 0x00015B9C
		// (set) Token: 0x06000321 RID: 801 RVA: 0x000179D4 File Offset: 0x00015BD4
		public unsafe string Namespace
		{
			[CallerCount(116)]
			[CachedScanResults(RefRangeStart = 894808, RefRangeEnd = 894924, XrefRangeStart = 894801, XrefRangeEnd = 894808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 894955, RefRangeEnd = 894963, XrefRangeStart = 894924, XrefRangeEnd = 894955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00017A18 File Offset: 0x00015C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 894963, RefRangeEnd = 894964, XrefRangeStart = 894963, XrefRangeEnd = 894963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNamespaceInherited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_IsNamespaceInherited_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00017A54 File Offset: 0x00015C54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 894982, RefRangeEnd = 894985, XrefRangeStart = 894964, XrefRangeEnd = 894982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCascadingNamespaceConflict(string realNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(realNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CheckCascadingNamespaceConflict_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00017A98 File Offset: 0x00015C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895019, RefRangeEnd = 895020, XrefRangeStart = 894985, XrefRangeEnd = 895019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNamespaceValidityForNestedRelations(string realNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(realNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CheckNamespaceValidityForNestedRelations_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00017ADC File Offset: 0x00015CDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 895038, RefRangeEnd = 895041, XrefRangeStart = 895020, XrefRangeEnd = 895038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CheckNamespaceValidityForNestedParentRelations_Internal_Void_String_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00017B30 File Offset: 0x00015D30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 895085, RefRangeEnd = 895088, XrefRangeStart = 895041, XrefRangeEnd = 895085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoRaiseNamespaceChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_DoRaiseNamespaceChange_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00017B64 File Offset: 0x00015D64
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00017B9C File Offset: 0x00015D9C
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 895113, RefRangeEnd = 895116, XrefRangeStart = 895088, XrefRangeEnd = 895113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00017BE0 File Offset: 0x00015DE0
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00017C20 File Offset: 0x00015E20
		public unsafe DataColumn XmlText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_XmlText_Internal_get_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 895121, RefRangeEnd = 895123, XrefRangeStart = 895116, XrefRangeEnd = 895121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_XmlText_Internal_set_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00017C64 File Offset: 0x00015E64
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00017CA0 File Offset: 0x00015EA0
		public unsafe Decimal MaxOccurs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_MaxOccurs_Internal_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_MaxOccurs_Internal_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00017CE0 File Offset: 0x00015EE0
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00017D1C File Offset: 0x00015F1C
		public unsafe Decimal MinOccurs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_MinOccurs_Internal_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_MinOccurs_Internal_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00017D5C File Offset: 0x00015F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895125, RefRangeEnd = 895126, XrefRangeStart = 895123, XrefRangeEnd = 895125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKeyValues(DataKey key, Il2CppReferenceArray<Object> keyValues, int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyValues);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref record;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SetKeyValues_Internal_Void_DataKey_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00017DC4 File Offset: 0x00015FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895126, XrefRangeEnd = 895128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow FindByIndex(Index ndx, Il2CppReferenceArray<Object> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ndx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_FindByIndex_Internal_DataRow_Index_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00017E28 File Offset: 0x00016028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895136, RefRangeEnd = 895137, XrefRangeStart = 895128, XrefRangeEnd = 895136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ndx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_FindMergeTarget_Internal_DataRow_DataRow_DataKey_Index_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00017EA4 File Offset: 0x000160A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 895142, RefRangeEnd = 895146, XrefRangeStart = 895137, XrefRangeEnd = 895142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRecord;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldRecord;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SetMergeRecords_Private_Void_DataRow_Int32_Int32_DataRowAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00017F10 File Offset: 0x00016110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895179, RefRangeEnd = 895180, XrefRangeStart = 895146, XrefRangeEnd = 895179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetRow);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveChanges;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idxSearch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_MergeRow_Internal_DataRow_DataRow_DataRow_Boolean_Index_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00017F94 File Offset: 0x00016194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895180, XrefRangeEnd = 895184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataTable CreateInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_CreateInstance_Protected_Virtual_New_DataTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00017FE0 File Offset: 0x000161E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895184, XrefRangeEnd = 895185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataTable Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_Clone_Public_Virtual_New_DataTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0001802C File Offset: 0x0001622C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 895202, RefRangeEnd = 895205, XrefRangeStart = 895185, XrefRangeEnd = 895202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable Clone(DataSet cloneDS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cloneDS);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_Clone_Internal_DataTable_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0001807C File Offset: 0x0001627C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895225, RefRangeEnd = 895226, XrefRangeStart = 895205, XrefRangeEnd = 895225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_IncrementalCloneTo_Private_DataTable_DataTable_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000180E0 File Offset: 0x000162E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895259, RefRangeEnd = 895261, XrefRangeStart = 895226, XrefRangeEnd = 895259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ds);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visitedMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CloneHierarchy_Private_DataTable_DataTable_DataSet_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00018154 File Offset: 0x00016354
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 895363, RefRangeEnd = 895367, XrefRangeStart = 895261, XrefRangeEnd = 895363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cloneDS);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipExpressionColumns;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CloneTo_Private_DataTable_DataTable_DataSet_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600033A RID: 826 RVA: 0x000181C4 File Offset: 0x000163C4
		public unsafe override ISite Site
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_get_Site_Public_Virtual_get_ISite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00018210 File Offset: 0x00016410
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895368, RefRangeEnd = 895370, XrefRangeStart = 895367, XrefRangeEnd = 895368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRow(DataRow row, int proposedID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proposedID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_AddRow_Internal_Void_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00018260 File Offset: 0x00016460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895371, RefRangeEnd = 895372, XrefRangeStart = 895370, XrefRangeEnd = 895371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertRow(DataRow row, int proposedID, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proposedID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_InsertRow_Internal_Void_DataRow_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000182C0 File Offset: 0x000164C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895385, RefRangeEnd = 895387, XrefRangeStart = 895372, XrefRangeEnd = 895385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proposedID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fireEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_InsertRow_Internal_Void_DataRow_Int64_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001832C File Offset: 0x0001652C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895387, XrefRangeEnd = 895388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNotModifying(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CheckNotModifying_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00018370 File Offset: 0x00016570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895389, RefRangeEnd = 895390, XrefRangeStart = 895388, XrefRangeEnd = 895389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000183A4 File Offset: 0x000165A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895458, RefRangeEnd = 895460, XrefRangeStart = 895390, XrefRangeEnd = 895458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool clearAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearAll;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000183E4 File Offset: 0x000165E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895468, RefRangeEnd = 895470, XrefRangeStart = 895460, XrefRangeEnd = 895468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CascadeAll(DataRow row, DataRowAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CascadeAll_Internal_Void_DataRow_DataRowAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00018434 File Offset: 0x00016634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895482, RefRangeEnd = 895483, XrefRangeStart = 895470, XrefRangeEnd = 895482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitRow(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CommitRow_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00018478 File Offset: 0x00016678
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 895491, RefRangeEnd = 895494, XrefRangeStart = 895483, XrefRangeEnd = 895491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(string s1, string s2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_Compare_Internal_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000184D8 File Offset: 0x000166D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895500, RefRangeEnd = 895501, XrefRangeStart = 895494, XrefRangeEnd = 895500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(string s1, string s2, CompareInfo comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_Compare_Internal_Int32_String_String_CompareInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001854C File Offset: 0x0001674C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895501, XrefRangeEnd = 895503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string s1, string s2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_IndexOf_Internal_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000185AC File Offset: 0x000167AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895503, XrefRangeEnd = 895505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSuffix(string s1, string s2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_IsSuffix_Internal_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001860C File Offset: 0x0001680C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895506, RefRangeEnd = 895508, XrefRangeStart = 895505, XrefRangeEnd = 895506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteRow(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_DeleteRow_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00018650 File Offset: 0x00016850
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895523, RefRangeEnd = 895525, XrefRangeStart = 895508, XrefRangeEnd = 895523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatSortString(Il2CppReferenceArray<IndexField> indexDesc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indexDesc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_FormatSortString_Internal_String_Il2CppReferenceArray_1_IndexField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00018698 File Offset: 0x00016898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895527, RefRangeEnd = 895528, XrefRangeStart = 895525, XrefRangeEnd = 895527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeRecord(ref int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_FreeRecord_Internal_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000186D8 File Offset: 0x000168D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 895530, RefRangeEnd = 895533, XrefRangeStart = 895528, XrefRangeEnd = 895530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sort);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordStates;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_GetIndex_Internal_Index_String_DataViewRowState_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Index>(intPtr3) : null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00018748 File Offset: 0x00016948
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 895541, RefRangeEnd = 895551, XrefRangeStart = 895533, XrefRangeEnd = 895541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Index GetIndex(Il2CppReferenceArray<IndexField> indexDesc, DataViewRowState recordStates, IFilter rowFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indexDesc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordStates;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_GetIndex_Internal_Index_Il2CppReferenceArray_1_IndexField_DataViewRowState_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Index>(intPtr3) : null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000187B8 File Offset: 0x000169B8
		[CallerCount(0)]
		public unsafe List<DataViewListener> GetListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_GetListeners_Internal_List_1_DataViewListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataViewListener>>(intPtr3) : null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000187F8 File Offset: 0x000169F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895554, RefRangeEnd = 895556, XrefRangeStart = 895551, XrefRangeEnd = 895554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpecialHashCode(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_GetSpecialHashCode_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00018848 File Offset: 0x00016A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895586, RefRangeEnd = 895587, XrefRangeStart = 895556, XrefRangeEnd = 895586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertRow(DataRow row, long proposedID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proposedID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_InsertRow_Internal_Void_DataRow_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00018898 File Offset: 0x00016A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895588, RefRangeEnd = 895590, XrefRangeStart = 895587, XrefRangeEnd = 895588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NewRecord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_NewRecord_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000188D4 File Offset: 0x00016AD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895592, RefRangeEnd = 895594, XrefRangeStart = 895590, XrefRangeEnd = 895592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NewUninitializedRecord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_NewUninitializedRecord_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00018910 File Offset: 0x00016B10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 895600, RefRangeEnd = 895603, XrefRangeStart = 895594, XrefRangeEnd = 895600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NewRecord(int sourceRecord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_NewRecord_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0001895C File Offset: 0x00016B5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 895604, RefRangeEnd = 895607, XrefRangeStart = 895603, XrefRangeEnd = 895604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow NewEmptyRow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_NewEmptyRow_Internal_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0001899C File Offset: 0x00016B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895607, XrefRangeEnd = 895610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow NewUninitializedRow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_NewUninitializedRow_Private_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000189DC File Offset: 0x00016BDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895617, RefRangeEnd = 895619, XrefRangeStart = 895610, XrefRangeEnd = 895617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow NewRow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_NewRow_Public_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00018A1C File Offset: 0x00016C1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895651, RefRangeEnd = 895653, XrefRangeStart = 895619, XrefRangeEnd = 895651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow CreateEmptyRow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CreateEmptyRow_Internal_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00018A5C File Offset: 0x00016C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895653, XrefRangeEnd = 895657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NewRowCreated(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_NewRowCreated_Private_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00018AA0 File Offset: 0x00016CA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 895660, RefRangeEnd = 895664, XrefRangeStart = 895657, XrefRangeEnd = 895660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow NewRow(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_NewRow_Internal_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00018AEC File Offset: 0x00016CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895664, XrefRangeEnd = 895668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_NewRowFromBuilder_Protected_Virtual_New_DataRow_DataRowBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00018B48 File Offset: 0x00016D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895668, XrefRangeEnd = 895674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type GetRowType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_GetRowType_Protected_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00018B94 File Offset: 0x00016D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 895683, RefRangeEnd = 895685, XrefRangeStart = 895674, XrefRangeEnd = 895683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataRow> NewRowArray(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_NewRowArray_FamOrAssem_Il2CppReferenceArray_1_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr3) : null;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00018BE0 File Offset: 0x00016DE0
		public unsafe bool NeedColumnChangeEvents
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 895686, RefRangeEnd = 895688, XrefRangeStart = 895685, XrefRangeEnd = 895686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_NeedColumnChangeEvents_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00018C1C File Offset: 0x00016E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895688, XrefRangeEnd = 895697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnColumnChanging(DataColumnChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnColumnChanging_FamOrAssem_Virtual_New_Void_DataColumnChangeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00018C6C File Offset: 0x00016E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895697, XrefRangeEnd = 895706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnColumnChanged(DataColumnChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnColumnChanged_FamOrAssem_Virtual_New_Void_DataColumnChangeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00018CBC File Offset: 0x00016EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895706, XrefRangeEnd = 895715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_PropertyChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00018D0C File Offset: 0x00016F0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895715, RefRangeEnd = 895716, XrefRangeStart = 895715, XrefRangeEnd = 895715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRemoveColumnInternal(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_OnRemoveColumnInternal_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00018D50 File Offset: 0x00016F50
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemoveColumn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnRemoveColumn_Protected_Virtual_New_Void_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00018DA0 File Offset: 0x00016FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895716, XrefRangeEnd = 895721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eRow);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_OnRowChanged_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowChangeEventArgs>(intPtr3) : null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00018E10 File Offset: 0x00017010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895721, XrefRangeEnd = 895726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eRow);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_OnRowChanging_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowChangeEventArgs>(intPtr3) : null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00018E80 File Offset: 0x00017080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895726, XrefRangeEnd = 895735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRowChanged(DataRowChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnRowChanged_Protected_Virtual_New_Void_DataRowChangeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00018ED0 File Offset: 0x000170D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895735, XrefRangeEnd = 895744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRowChanging(DataRowChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnRowChanging_Protected_Virtual_New_Void_DataRowChangeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00018F20 File Offset: 0x00017120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895744, XrefRangeEnd = 895753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRowDeleting(DataRowChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnRowDeleting_Protected_Virtual_New_Void_DataRowChangeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00018F70 File Offset: 0x00017170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895753, XrefRangeEnd = 895762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRowDeleted(DataRowChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnRowDeleted_Protected_Virtual_New_Void_DataRowChangeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00018FC0 File Offset: 0x000171C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895762, XrefRangeEnd = 895771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTableCleared(DataTableClearEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnTableCleared_Protected_Virtual_New_Void_DataTableClearEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00019010 File Offset: 0x00017210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895771, XrefRangeEnd = 895780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTableClearing(DataTableClearEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnTableClearing_Protected_Virtual_New_Void_DataTableClearEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00019060 File Offset: 0x00017260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895780, XrefRangeEnd = 895789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTableNewRow(DataTableNewRowEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_OnTableNewRow_Protected_Virtual_New_Void_DataTableNewRowEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000190B0 File Offset: 0x000172B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 895820, RefRangeEnd = 895823, XrefRangeStart = 895789, XrefRangeEnd = 895820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<IndexField> ParseSortString(string sortString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sortString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ParseSortString_Internal_Il2CppReferenceArray_1_IndexField_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IndexField>>(intPtr3) : null;
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00019100 File Offset: 0x00017300
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 895827, RefRangeEnd = 895830, XrefRangeStart = 895823, XrefRangeEnd = 895827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaisePropertyChanging(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RaisePropertyChanging_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00019144 File Offset: 0x00017344
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 895842, RefRangeEnd = 895854, XrefRangeStart = 895830, XrefRangeEnd = 895842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordChanged(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RecordChanged_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00019184 File Offset: 0x00017384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895866, RefRangeEnd = 895867, XrefRangeStart = 895854, XrefRangeEnd = 895866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordChanged(Il2CppStructArray<int> oldIndex, Il2CppStructArray<int> newIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldIndex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RecordChanged_Internal_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000191D8 File Offset: 0x000173D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895879, RefRangeEnd = 895880, XrefRangeStart = 895867, XrefRangeEnd = 895879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldState;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RecordStateChanged_Internal_Void_Int32_DataViewRowState_DataViewRowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00019234 File Offset: 0x00017434
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 895896, RefRangeEnd = 895899, XrefRangeStart = 895880, XrefRangeEnd = 895896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldState1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newState1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref record2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldState2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newState2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RecordStateChanged_Internal_Void_Int32_DataViewRowState_DataViewRowState_Int32_DataViewRowState_DataViewRowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000192B8 File Offset: 0x000174B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895921, RefRangeEnd = 895922, XrefRangeStart = 895899, XrefRangeEnd = 895921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> RemoveRecordFromIndexes(DataRow row, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RemoveRecordFromIndexes_Internal_Il2CppStructArray_1_Int32_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00019318 File Offset: 0x00017518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 895941, RefRangeEnd = 895942, XrefRangeStart = 895922, XrefRangeEnd = 895941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> InsertRecordToIndexes(DataRow row, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_InsertRecordToIndexes_Internal_Il2CppStructArray_1_Int32_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00019378 File Offset: 0x00017578
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 895957, RefRangeEnd = 895962, XrefRangeStart = 895942, XrefRangeEnd = 895957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, Object newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SilentlySetValue_Internal_Void_DataRow_DataColumn_DataRowVersion_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000193F0 File Offset: 0x000175F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895962, XrefRangeEnd = 895977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRow(DataRow row, bool check)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RemoveRow_Internal_Void_DataRow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00019440 File Offset: 0x00017640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 895977, XrefRangeEnd = 896008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0001947C File Offset: 0x0001767C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896009, RefRangeEnd = 896010, XrefRangeStart = 896008, XrefRangeEnd = 896009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetIndexes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ResetIndexes_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000194B0 File Offset: 0x000176B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 896025, RefRangeEnd = 896032, XrefRangeStart = 896010, XrefRangeEnd = 896025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetInternalIndexes(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ResetInternalIndexes_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000194F4 File Offset: 0x000176F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896034, RefRangeEnd = 896035, XrefRangeStart = 896032, XrefRangeEnd = 896034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RollbackRow(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RollbackRow_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00019538 File Offset: 0x00017738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 896055, RefRangeEnd = 896057, XrefRangeStart = 896035, XrefRangeEnd = 896055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eRow);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RaiseRowChanged_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowChangeEventArgs>(intPtr3) : null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000195A8 File Offset: 0x000177A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896070, RefRangeEnd = 896071, XrefRangeStart = 896057, XrefRangeEnd = 896070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eRow);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RaiseRowChanging_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowChangeEventArgs>(intPtr3) : null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00019618 File Offset: 0x00017818
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 896078, RefRangeEnd = 896080, XrefRangeStart = 896071, XrefRangeEnd = 896078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eRow);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fireEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RaiseRowChanging_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowChangeEventArgs>(intPtr3) : null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00019698 File Offset: 0x00017898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896081, RefRangeEnd = 896082, XrefRangeStart = 896080, XrefRangeEnd = 896081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = DataRowAction.Change, bool isInMerge = false, bool fireEvent = true, bool suppressEnsurePropertyChanged = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proposedRecord;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInMerge;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fireEvent;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressEnsurePropertyChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SetNewRecord_Internal_Void_DataRow_Int32_DataRowAction_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00019720 File Offset: 0x00017920
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 896094, RefRangeEnd = 896100, XrefRangeStart = 896082, XrefRangeEnd = 896094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proposedRecord;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInMerge;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressEnsurePropertyChanged;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fireEvent;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SetNewRecordWorker_Private_Void_DataRow_Int32_DataRowAction_Boolean_Boolean_Int32_Boolean_byref_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			deferredException = ((intPtr4 == 0) ? null : new Exception(intPtr4));
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000197D8 File Offset: 0x000179D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 896117, RefRangeEnd = 896120, XrefRangeStart = 896100, XrefRangeEnd = 896117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOldRecord(DataRow row, int proposedRecord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proposedRecord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SetOldRecord_Internal_Void_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00019828 File Offset: 0x00017A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 896120, XrefRangeEnd = 896121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreShadowIndexes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RestoreShadowIndexes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0001985C File Offset: 0x00017A5C
		[CallerCount(0)]
		public unsafe void SetShadowIndexes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_SetShadowIndexes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00019890 File Offset: 0x00017A90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 896128, RefRangeEnd = 896130, XrefRangeStart = 896121, XrefRangeEnd = 896128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShadowIndexCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ShadowIndexCopy_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000198C4 File Offset: 0x00017AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 896130, XrefRangeEnd = 896131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00019908 File Offset: 0x00017B08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896131, RefRangeEnd = 896132, XrefRangeStart = 896131, XrefRangeEnd = 896131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdatingCurrent(DataRow row, DataRowAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_UpdatingCurrent_Internal_Boolean_DataRow_DataRowAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00019964 File Offset: 0x00017B64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 896168, RefRangeEnd = 896170, XrefRangeStart = 896132, XrefRangeEnd = 896168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumn AddUniqueKey(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_AddUniqueKey_Internal_DataColumn_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000199B0 File Offset: 0x00017BB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 896171, RefRangeEnd = 896173, XrefRangeStart = 896170, XrefRangeEnd = 896171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumn AddUniqueKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_AddUniqueKey_Internal_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000199F0 File Offset: 0x00017BF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 896179, RefRangeEnd = 896181, XrefRangeStart = 896173, XrefRangeEnd = 896179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumn AddForeignKey(DataColumn parentKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_AddForeignKey_Internal_DataColumn_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00019A40 File Offset: 0x00017C40
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 896182, RefRangeEnd = 896191, XrefRangeStart = 896181, XrefRangeEnd = 896182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePropertyDescriptorCollectionCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_UpdatePropertyDescriptorCollectionCache_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00019A74 File Offset: 0x00017C74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 896218, RefRangeEnd = 896221, XrefRangeStart = 896191, XrefRangeEnd = 896218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDescriptorCollection GetPropertyDescriptorCollection(Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_GetPropertyDescriptorCollection_Internal_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00019AC4 File Offset: 0x00017CC4
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00019B04 File Offset: 0x00017D04
		public unsafe XmlQualifiedName TypeName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 896225, RefRangeEnd = 896229, XrefRangeStart = 896221, XrefRangeEnd = 896225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_TypeName_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_set_TypeName_Internal_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00019B48 File Offset: 0x00017D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 896229, XrefRangeEnd = 896230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_Merge_Public_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00019B8C File Offset: 0x00017D8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 896251, RefRangeEnd = 896253, XrefRangeStart = 896230, XrefRangeEnd = 896251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveChanges;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref missingSchemaAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_Merge_Public_Void_DataTable_Boolean_MissingSchemaAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00019BEC File Offset: 0x00017DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896304, RefRangeEnd = 896305, XrefRangeStart = 896253, XrefRangeEnd = 896304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeHierarchy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_WriteXml_Public_Void_XmlWriter_XmlWriteMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00019C4C File Offset: 0x00017E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 896305, XrefRangeEnd = 896320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeHierarchy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CheckForClosureOnExpressions_Private_Boolean_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00019CA8 File Offset: 0x00017EA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 896344, RefRangeEnd = 896347, XrefRangeStart = 896320, XrefRangeEnd = 896344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForClosureOnExpressionTables(List<DataTable> tableList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tableList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CheckForClosureOnExpressionTables_Private_Boolean_List_1_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00019CF8 File Offset: 0x00017EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896392, RefRangeEnd = 896393, XrefRangeStart = 896347, XrefRangeEnd = 896392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteXmlSchema(XmlWriter writer, bool writeHierarchy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeHierarchy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_WriteXmlSchema_Public_Void_XmlWriter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00019D48 File Offset: 0x00017F48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 896394, RefRangeEnd = 896399, XrefRangeStart = 896393, XrefRangeEnd = 896394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreConstraint(bool originalEnforceConstraint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalEnforceConstraint;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RestoreConstraint_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00019D88 File Offset: 0x00017F88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896414, RefRangeEnd = 896415, XrefRangeStart = 896399, XrefRangeEnd = 896414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEmptyXml(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_IsEmptyXml_Private_Boolean_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00019DD8 File Offset: 0x00017FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896540, RefRangeEnd = 896541, XrefRangeStart = 896415, XrefRangeEnd = 896540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ReadXml_Internal_XmlReadMode_XmlReader_XmlReadMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00019E44 File Offset: 0x00018044
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 892282, RefRangeEnd = 892292, XrefRangeStart = 892282, XrefRangeEnd = 892292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadEndElement(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ReadEndElement_Internal_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00019E88 File Offset: 0x00018088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 896546, RefRangeEnd = 896548, XrefRangeStart = 896541, XrefRangeEnd = 896546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadXDRSchema(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ReadXDRSchema_Internal_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00019ECC File Offset: 0x000180CC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 892270, RefRangeEnd = 892279, XrefRangeStart = 892270, XrefRangeEnd = 892279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_MoveToElement_Internal_Boolean_XmlReader_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00019F28 File Offset: 0x00018128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 896630, RefRangeEnd = 896632, XrefRangeStart = 896548, XrefRangeEnd = 896630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadXmlDiffgram(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ReadXmlDiffgram_Private_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00019F6C File Offset: 0x0001816C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896657, RefRangeEnd = 896658, XrefRangeStart = 896632, XrefRangeEnd = 896657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ReadXSDSchema_Internal_Void_XmlReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00019FBC File Offset: 0x000181BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 896827, RefRangeEnd = 896829, XrefRangeStart = 896658, XrefRangeEnd = 896827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_ReadXmlSchema_Internal_Void_XmlReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0001A00C File Offset: 0x0001820C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 896854, RefRangeEnd = 896859, XrefRangeStart = 896829, XrefRangeEnd = 896854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTableList(DataTable currentTable, List<DataTable> tableList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CreateTableList_Private_Void_DataTable_List_1_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0001A060 File Offset: 0x00018260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896894, RefRangeEnd = 896895, XrefRangeStart = 896859, XrefRangeEnd = 896894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tableList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relationList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_CreateRelationList_Private_Void_List_1_DataTable_List_1_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0001A0B4 File Offset: 0x000182B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 896895, XrefRangeEnd = 896928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_GetDataTableSchema_Public_Static_XmlSchemaComplexType_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0001A0F8 File Offset: 0x000182F8
		[CallerCount(0)]
		public unsafe virtual XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0001A138 File Offset: 0x00018338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 896928, XrefRangeEnd = 896957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlSchema GetSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_GetSchema_Protected_Virtual_New_XmlSchema_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0001A184 File Offset: 0x00018384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 896957, XrefRangeEnd = 896966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0001A1C8 File Offset: 0x000183C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 896966, XrefRangeEnd = 896968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0001A20C File Offset: 0x0001840C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 896968, XrefRangeEnd = 896969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReadXmlSerializable(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataTable.NativeMethodInfoPtr_ReadXmlSerializable_Protected_Virtual_New_Void_XmlReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0001A25C File Offset: 0x0001845C
		public unsafe Hashtable RowDiffId
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 896974, RefRangeEnd = 896982, XrefRangeStart = 896969, XrefRangeEnd = 896974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_RowDiffId_Internal_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0001A29C File Offset: 0x0001849C
		public unsafe int ObjectID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0001A2D8 File Offset: 0x000184D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 896995, RefRangeEnd = 896999, XrefRangeStart = 896982, XrefRangeEnd = 896995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDependentColumn(DataColumn expressionColumn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expressionColumn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_AddDependentColumn_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001A31C File Offset: 0x0001851C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 897005, RefRangeEnd = 897009, XrefRangeStart = 896999, XrefRangeEnd = 897005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDependentColumn(DataColumn expressionColumn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expressionColumn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_RemoveDependentColumn_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0001A360 File Offset: 0x00018560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 897030, RefRangeEnd = 897032, XrefRangeStart = 897009, XrefRangeEnd = 897030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateExpressions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_EvaluateExpressions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0001A394 File Offset: 0x00018594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 897081, RefRangeEnd = 897082, XrefRangeStart = 897032, XrefRangeEnd = 897081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedRows);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_EvaluateExpressions_Internal_Void_DataRow_DataRowAction_List_1_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0001A3F8 File Offset: 0x000185F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 897099, RefRangeEnd = 897102, XrefRangeStart = 897082, XrefRangeEnd = 897099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateExpressions(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_EvaluateExpressions_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0001A43C File Offset: 0x0001863C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 897117, RefRangeEnd = 897121, XrefRangeStart = 897102, XrefRangeEnd = 897117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateDependentExpressions(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_EvaluateDependentExpressions_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001A480 File Offset: 0x00018680
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 897184, RefRangeEnd = 897197, XrefRangeStart = 897121, XrefRangeEnd = 897184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(row);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedRows);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.NativeMethodInfoPtr_EvaluateDependentExpressions_Internal_Void_List_1_DataColumn_DataRow_DataRowVersion_List_1_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000029C1 File Offset: 0x00000BC1
		public DataTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0001A4F8 File Offset: 0x000186F8
		// (set) Token: 0x060003AC RID: 940 RVA: 0x000029CA File Offset: 0x00000BCA
		public unsafe DataSet _dataSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__dataSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__dataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0001A528 File Offset: 0x00018728
		// (set) Token: 0x060003AE RID: 942 RVA: 0x000029E9 File Offset: 0x00000BE9
		public unsafe DataView _defaultView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__defaultView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__defaultView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0001A558 File Offset: 0x00018758
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00002A08 File Offset: 0x00000C08
		public unsafe long _nextRowID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__nextRowID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__nextRowID)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0001A580 File Offset: 0x00018780
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00002A23 File Offset: 0x00000C23
		public unsafe DataRowCollection _rowCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__rowCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRowCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__rowCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0001A5B0 File Offset: 0x000187B0
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00002A42 File Offset: 0x00000C42
		public unsafe DataColumnCollection _columnCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__columnCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumnCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__columnCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0001A5E0 File Offset: 0x000187E0
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00002A61 File Offset: 0x00000C61
		public unsafe ConstraintCollection _constraintCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__constraintCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstraintCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__constraintCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0001A610 File Offset: 0x00018810
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00002A80 File Offset: 0x00000C80
		public unsafe int _elementColumnCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__elementColumnCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__elementColumnCount)) = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0001A638 File Offset: 0x00018838
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00002A9B File Offset: 0x00000C9B
		public unsafe DataRelationCollection _parentRelationsCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__parentRelationsCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRelationCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__parentRelationsCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0001A668 File Offset: 0x00018868
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00002ABA File Offset: 0x00000CBA
		public unsafe DataRelationCollection _childRelationsCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__childRelationsCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRelationCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__childRelationsCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0001A698 File Offset: 0x00018898
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00002AD9 File Offset: 0x00000CD9
		public unsafe RecordManager _recordManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__recordManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecordManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__recordManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0001A6C8 File Offset: 0x000188C8
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public unsafe List<Index> _indexes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__indexes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Index>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__indexes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0001A6F8 File Offset: 0x000188F8
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00002B17 File Offset: 0x00000D17
		public unsafe List<Index> _shadowIndexes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__shadowIndexes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Index>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__shadowIndexes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0001A728 File Offset: 0x00018928
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00002B36 File Offset: 0x00000D36
		public unsafe int _shadowCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__shadowCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__shadowCount)) = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0001A750 File Offset: 0x00018950
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00002B51 File Offset: 0x00000D51
		public unsafe PropertyCollection _extendedProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__extendedProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__extendedProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0001A780 File Offset: 0x00018980
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00002B70 File Offset: 0x00000D70
		public unsafe string _tableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__tableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__tableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0001A7A8 File Offset: 0x000189A8
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00002B8F File Offset: 0x00000D8F
		public unsafe string _tableNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__tableNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__tableNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0001A7D0 File Offset: 0x000189D0
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00002BAE File Offset: 0x00000DAE
		public unsafe string _tablePrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__tablePrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__tablePrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0001A7F8 File Offset: 0x000189F8
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00002BCD File Offset: 0x00000DCD
		public unsafe DataExpression _displayExpression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__displayExpression);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__displayExpression), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0001A828 File Offset: 0x00018A28
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00002BEC File Offset: 0x00000DEC
		public unsafe bool _fNestedInDataset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__fNestedInDataset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__fNestedInDataset)) = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0001A850 File Offset: 0x00018A50
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00002C07 File Offset: 0x00000E07
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0001A880 File Offset: 0x00018A80
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00002C26 File Offset: 0x00000E26
		public unsafe bool _cultureUserSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__cultureUserSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__cultureUserSet)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0001A8A8 File Offset: 0x00018AA8
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00002C41 File Offset: 0x00000E41
		public unsafe CompareInfo _compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00002C60 File Offset: 0x00000E60
		public unsafe CompareOptions _compareFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__compareFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__compareFlags)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0001A900 File Offset: 0x00018B00
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00002C7B File Offset: 0x00000E7B
		public unsafe IFormatProvider _formatProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__formatProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__formatProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0001A930 File Offset: 0x00018B30
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00002C9A File Offset: 0x00000E9A
		public unsafe StringComparer _hashCodeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__hashCodeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__hashCodeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0001A960 File Offset: 0x00018B60
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00002CB9 File Offset: 0x00000EB9
		public unsafe bool _caseSensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__caseSensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__caseSensitive)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0001A988 File Offset: 0x00018B88
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00002CD4 File Offset: 0x00000ED4
		public unsafe bool _caseSensitiveUserSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__caseSensitiveUserSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__caseSensitiveUserSet)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0001A9B0 File Offset: 0x00018BB0
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00002CEF File Offset: 0x00000EEF
		public unsafe string _encodedTableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__encodedTableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__encodedTableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0001A9D8 File Offset: 0x00018BD8
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00002D0E File Offset: 0x00000F0E
		public unsafe DataColumn _xmlText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__xmlText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__xmlText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0001AA08 File Offset: 0x00018C08
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00002D2D File Offset: 0x00000F2D
		public unsafe DataColumn _colUnique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__colUnique);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__colUnique), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0001AA38 File Offset: 0x00018C38
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00002D4C File Offset: 0x00000F4C
		public unsafe Decimal _minOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__minOccurs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__minOccurs)) = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0001AA60 File Offset: 0x00018C60
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00002D67 File Offset: 0x00000F67
		public unsafe Decimal _maxOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__maxOccurs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__maxOccurs)) = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0001AA88 File Offset: 0x00018C88
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00002D82 File Offset: 0x00000F82
		public unsafe bool _repeatableElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__repeatableElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__repeatableElement)) = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0001AAB0 File Offset: 0x00018CB0
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00002D9D File Offset: 0x00000F9D
		public unsafe Object _typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__typeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__typeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0001AAE0 File Offset: 0x00018CE0
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00002DBC File Offset: 0x00000FBC
		public unsafe UniqueConstraint _primaryKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__primaryKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniqueConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__primaryKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0001AB10 File Offset: 0x00018D10
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00002DDB File Offset: 0x00000FDB
		public unsafe Il2CppReferenceArray<IndexField> _primaryIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__primaryIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IndexField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__primaryIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0001AB40 File Offset: 0x00018D40
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00002DFA File Offset: 0x00000FFA
		public unsafe Il2CppReferenceArray<DataColumn> _delayedSetPrimaryKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__delayedSetPrimaryKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__delayedSetPrimaryKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0001AB70 File Offset: 0x00018D70
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00002E19 File Offset: 0x00001019
		public unsafe Index _loadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__loadIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Index>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__loadIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0001ABA0 File Offset: 0x00018DA0
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00002E38 File Offset: 0x00001038
		public unsafe Index _loadIndexwithOriginalAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__loadIndexwithOriginalAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Index>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__loadIndexwithOriginalAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0001ABD0 File Offset: 0x00018DD0
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00002E57 File Offset: 0x00001057
		public unsafe Index _loadIndexwithCurrentDeleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__loadIndexwithCurrentDeleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Index>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__loadIndexwithCurrentDeleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0001AC00 File Offset: 0x00018E00
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00002E76 File Offset: 0x00001076
		public unsafe int _suspendIndexEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__suspendIndexEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__suspendIndexEvents)) = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0001AC28 File Offset: 0x00018E28
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00002E91 File Offset: 0x00001091
		public unsafe bool _inDataLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__inDataLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__inDataLoad)) = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0001AC50 File Offset: 0x00018E50
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x00002EAC File Offset: 0x000010AC
		public unsafe bool _schemaLoading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__schemaLoading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__schemaLoading)) = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0001AC78 File Offset: 0x00018E78
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x00002EC7 File Offset: 0x000010C7
		public unsafe bool _enforceConstraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__enforceConstraints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__enforceConstraints)) = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0001ACA0 File Offset: 0x00018EA0
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x00002EE2 File Offset: 0x000010E2
		public unsafe bool _suspendEnforceConstraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__suspendEnforceConstraints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__suspendEnforceConstraints)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0001ACC8 File Offset: 0x00018EC8
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x00002EFD File Offset: 0x000010FD
		public unsafe bool fInitInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr_fInitInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr_fInitInProgress)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00002F18 File Offset: 0x00001118
		public unsafe bool _inLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__inLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__inLoad)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0001AD18 File Offset: 0x00018F18
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00002F33 File Offset: 0x00001133
		public unsafe bool _fInLoadDiffgram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__fInLoadDiffgram);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__fInLoadDiffgram)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0001AD40 File Offset: 0x00018F40
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00002F4E File Offset: 0x0000114E
		public unsafe byte _isTypedDataTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__isTypedDataTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__isTypedDataTable)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0001AD68 File Offset: 0x00018F68
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x00002F69 File Offset: 0x00001169
		public unsafe Il2CppReferenceArray<DataRow> _emptyDataRowArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__emptyDataRowArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__emptyDataRowArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0001AD98 File Offset: 0x00018F98
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x00002F88 File Offset: 0x00001188
		public unsafe PropertyDescriptorCollection _propertyDescriptorCollectionCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__propertyDescriptorCollectionCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__propertyDescriptorCollectionCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0001ADC8 File Offset: 0x00018FC8
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x00002FA7 File Offset: 0x000011A7
		public unsafe Il2CppReferenceArray<DataRelation> _nestedParentRelations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__nestedParentRelations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRelation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__nestedParentRelations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0001ADF8 File Offset: 0x00018FF8
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00002FC6 File Offset: 0x000011C6
		public unsafe List<DataColumn> _dependentColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__dependentColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataColumn>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__dependentColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0001AE28 File Offset: 0x00019028
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00002FE5 File Offset: 0x000011E5
		public unsafe bool _mergingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__mergingData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__mergingData)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0001AE50 File Offset: 0x00019050
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00003000 File Offset: 0x00001200
		public unsafe DataRowChangeEventHandler _onRowChangedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onRowChangedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRowChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onRowChangedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0001AE80 File Offset: 0x00019080
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x0000301F File Offset: 0x0000121F
		public unsafe DataRowChangeEventHandler _onRowChangingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onRowChangingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRowChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onRowChangingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0001AEB0 File Offset: 0x000190B0
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x0000303E File Offset: 0x0000123E
		public unsafe DataRowChangeEventHandler _onRowDeletingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onRowDeletingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRowChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onRowDeletingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0001AEE0 File Offset: 0x000190E0
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0000305D File Offset: 0x0000125D
		public unsafe DataRowChangeEventHandler _onRowDeletedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onRowDeletedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRowChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onRowDeletedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0001AF10 File Offset: 0x00019110
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0000307C File Offset: 0x0000127C
		public unsafe DataColumnChangeEventHandler _onColumnChangedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onColumnChangedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumnChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onColumnChangedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0001AF40 File Offset: 0x00019140
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0000309B File Offset: 0x0000129B
		public unsafe DataColumnChangeEventHandler _onColumnChangingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onColumnChangingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumnChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onColumnChangingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0001AF70 File Offset: 0x00019170
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x000030BA File Offset: 0x000012BA
		public unsafe DataTableClearEventHandler _onTableClearingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onTableClearingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTableClearEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onTableClearingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0001AFA0 File Offset: 0x000191A0
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x000030D9 File Offset: 0x000012D9
		public unsafe DataTableClearEventHandler _onTableClearedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onTableClearedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTableClearEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onTableClearedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0001AFD0 File Offset: 0x000191D0
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x000030F8 File Offset: 0x000012F8
		public unsafe DataTableNewRowEventHandler _onTableNewRowDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onTableNewRowDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTableNewRowEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onTableNewRowDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0001B000 File Offset: 0x00019200
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00003117 File Offset: 0x00001317
		public unsafe PropertyChangedEventHandler _onPropertyChangingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onPropertyChangingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__onPropertyChangingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0001B030 File Offset: 0x00019230
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00003136 File Offset: 0x00001336
		public unsafe DataRowBuilder _rowBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__rowBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRowBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__rowBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0001B060 File Offset: 0x00019260
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00003155 File Offset: 0x00001355
		public unsafe List<DataView> _delayedViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__delayedViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__delayedViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0001B090 File Offset: 0x00019290
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00003174 File Offset: 0x00001374
		public unsafe List<DataViewListener> _dataViewListeners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__dataViewListeners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataViewListener>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__dataViewListeners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0001B0C0 File Offset: 0x000192C0
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00003193 File Offset: 0x00001393
		public unsafe Hashtable _rowDiffId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__rowDiffId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__rowDiffId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0001B0F0 File Offset: 0x000192F0
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x000031B2 File Offset: 0x000013B2
		public unsafe ReaderWriterLockSlim _indexesLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__indexesLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReaderWriterLockSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__indexesLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0001B120 File Offset: 0x00019320
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x000031D1 File Offset: 0x000013D1
		public unsafe int _ukColumnPositionForInference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__ukColumnPositionForInference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__ukColumnPositionForInference)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0001B148 File Offset: 0x00019348
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x000031EC File Offset: 0x000013EC
		public unsafe SerializationFormat _remotingFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__remotingFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__remotingFormat)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0001B170 File Offset: 0x00019370
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00003207 File Offset: 0x00001407
		public unsafe static int s_objectTypeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DataTable.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataTable.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0001B18C File Offset: 0x0001938C
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00003215 File Offset: 0x00001415
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr__dataSet;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr__defaultView;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr__nextRowID;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr__rowCollection;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr__columnCollection;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr__constraintCollection;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr__elementColumnCount;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr__parentRelationsCollection;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr__childRelationsCollection;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr__recordManager;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr__indexes;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr__shadowIndexes;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr__shadowCount;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr__extendedProperties;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr__tableName;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr__tableNamespace;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr__tablePrefix;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr__displayExpression;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr__fNestedInDataset;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr__cultureUserSet;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr__compareInfo;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr__compareFlags;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr__formatProvider;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr__hashCodeProvider;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr__caseSensitive;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr__caseSensitiveUserSet;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr__encodedTableName;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr__xmlText;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr__colUnique;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr__minOccurs;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr__maxOccurs;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr__repeatableElement;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr__typeName;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr__primaryKey;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr__primaryIndex;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr__delayedSetPrimaryKey;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr__loadIndex;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr__loadIndexwithOriginalAdded;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr__loadIndexwithCurrentDeleted;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr__suspendIndexEvents;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr__inDataLoad;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr__schemaLoading;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr__enforceConstraints;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr__suspendEnforceConstraints;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_fInitInProgress;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr__inLoad;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr__fInLoadDiffgram;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr__isTypedDataTable;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr__emptyDataRowArray;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr__propertyDescriptorCollectionCache;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr__nestedParentRelations;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr__dependentColumns;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr__mergingData;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr__onRowChangedDelegate;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr__onRowChangingDelegate;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr__onRowDeletingDelegate;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr__onRowDeletedDelegate;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr__onColumnChangedDelegate;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr__onColumnChangingDelegate;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr__onTableClearingDelegate;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr__onTableClearedDelegate;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr__onTableNewRowDelegate;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr__onPropertyChangingDelegate;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr__rowBuilder;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr__delayedViews;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr__dataViewListeners;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr__rowDiffId;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr__indexesLock;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr__ukColumnPositionForInference;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr__remotingFormat;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_s_objectTypeCount;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_SerializeDataTable_Private_Void_SerializationInfo_StreamingContext_Boolean_SerializationFormat_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeDataTable_Internal_Void_SerializationInfo_StreamingContext_Boolean_SerializationFormat_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_SerializeTableSchema_Internal_Void_SerializationInfo_StreamingContext_Boolean_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeTableSchema_Internal_Void_SerializationInfo_StreamingContext_Boolean_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_SerializeConstraints_Internal_Void_SerializationInfo_StreamingContext_Int32_Boolean_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeConstraints_Internal_Void_SerializationInfo_StreamingContext_Int32_Boolean_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_SerializeExpressionColumns_Internal_Void_SerializationInfo_StreamingContext_Int32_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeExpressionColumns_Internal_Void_SerializationInfo_StreamingContext_Int32_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_SerializeTableData_Internal_Void_SerializationInfo_StreamingContext_Int32_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeTableData_Internal_Void_SerializationInfo_StreamingContext_Int32_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToRowState_Private_DataRowState_BitArray_Int32_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_GetRowAndColumnErrors_Internal_Void_Int32_Hashtable_Hashtable_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToRowError_Private_Void_Int32_Hashtable_Hashtable_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_get_CaseSensitive_Public_get_Boolean_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_set_CaseSensitive_Public_set_Void_Boolean_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_get_AreIndexEventsSuspended_Internal_get_Boolean_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_RestoreIndexEvents_Internal_Void_Boolean_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_SuspendIndexEvents_Internal_Void_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTypedDataTable_Private_get_Boolean_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_SetCaseSensitiveValue_Internal_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeCaseSensitive_Internal_Boolean_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_get_SelfNested_Internal_get_Boolean_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_get_LiveIndexes_Internal_get_List_1_Index_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_get_RemotingFormat_Public_get_SerializationFormat_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_set_RemotingFormat_Public_set_Void_SerializationFormat_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_get_UKColumnPositionForInference_Internal_get_Int32_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_set_UKColumnPositionForInference_Internal_set_Void_Int32_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildRelations_Public_get_DataRelationCollection_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_get_Columns_Public_get_DataColumnCollection_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareInfo_Private_get_CompareInfo_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_get_Constraints_Public_get_ConstraintCollection_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_ResetConstraints_Private_Void_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSet_Public_get_DataSet_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_SetDataSet_Internal_Void_DataSet_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayExpressionInternal_Internal_get_String_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_get_EnforceConstraints_Internal_get_Boolean_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_set_EnforceConstraints_Internal_set_Void_Boolean_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_get_SuspendEnforceConstraints_Internal_get_Boolean_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_set_SuspendEnforceConstraints_Internal_set_Void_Boolean_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_EnableConstraints_Internal_Void_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_get_Locale_Public_get_CultureInfo_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_set_Locale_Public_set_Void_CultureInfo_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_SetLocaleValue_Internal_Boolean_CultureInfo_Boolean_Boolean_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeLocale_Internal_Boolean_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_get_MinimumCapacity_Public_get_Int32_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_set_MinimumCapacity_Public_set_Void_Int32_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_get_RecordCapacity_Internal_get_Int32_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementColumnCount_Internal_get_Int32_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementColumnCount_Internal_set_Void_Int32_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentRelations_Public_get_DataRelationCollection_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_get_MergingData_Internal_get_Boolean_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_set_MergingData_Internal_set_Void_Boolean_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_get_NestedParentRelations_Internal_get_Il2CppReferenceArray_1_DataRelation_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaLoading_Internal_get_Boolean_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_CacheNestedParent_Internal_Void_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_FindNestedParentRelations_Private_Il2CppReferenceArray_1_DataRelation_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_get_NestedParentsCount_Internal_get_Int32_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimaryKey_Public_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_set_PrimaryKey_Public_set_Void_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_get_Rows_Public_get_DataRowCollection_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_get_TableName_Public_get_String_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_set_TableName_Public_set_Void_String_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodedTableName_Internal_get_String_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_GetInheritedNamespace_Private_String_List_1_DataTable_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_IsNamespaceInherited_Internal_Boolean_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_CheckCascadingNamespaceConflict_Internal_Void_String_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_CheckNamespaceValidityForNestedRelations_Internal_Void_String_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_CheckNamespaceValidityForNestedParentRelations_Internal_Void_String_DataTable_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_DoRaiseNamespaceChange_Internal_Void_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlText_Internal_get_DataColumn_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlText_Internal_set_Void_DataColumn_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxOccurs_Internal_get_Decimal_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxOccurs_Internal_set_Void_Decimal_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_get_MinOccurs_Internal_get_Decimal_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_set_MinOccurs_Internal_set_Void_Decimal_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyValues_Internal_Void_DataKey_Il2CppReferenceArray_1_Object_Int32_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_FindByIndex_Internal_DataRow_Index_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_FindMergeTarget_Internal_DataRow_DataRow_DataKey_Index_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_SetMergeRecords_Private_Void_DataRow_Int32_Int32_DataRowAction_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_MergeRow_Internal_DataRow_DataRow_DataRow_Boolean_Index_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Protected_Virtual_New_DataTable_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_DataTable_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_DataTable_DataSet_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_IncrementalCloneTo_Private_DataTable_DataTable_DataTable_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_CloneHierarchy_Private_DataTable_DataTable_DataSet_Hashtable_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_CloneTo_Private_DataTable_DataTable_DataSet_Boolean_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Virtual_get_ISite_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_AddRow_Internal_Void_DataRow_Int32_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_InsertRow_Internal_Void_DataRow_Int32_Int32_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_InsertRow_Internal_Void_DataRow_Int64_Int32_Boolean_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_CheckNotModifying_Internal_Void_DataRow_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_CascadeAll_Internal_Void_DataRow_DataRowAction_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_CommitRow_Internal_Void_DataRow_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Int32_String_String_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Int32_String_String_CompareInfo_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Int32_String_String_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Internal_Boolean_String_String_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_DeleteRow_Internal_Void_DataRow_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_FormatSortString_Internal_String_Il2CppReferenceArray_1_IndexField_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_FreeRecord_Internal_Void_byref_Int32_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_GetIndex_Internal_Index_String_DataViewRowState_IFilter_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_GetIndex_Internal_Index_Il2CppReferenceArray_1_IndexField_DataViewRowState_IFilter_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_GetListeners_Internal_List_1_DataViewListener_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialHashCode_Internal_Int32_String_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_InsertRow_Internal_Void_DataRow_Int64_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_NewRecord_Internal_Int32_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_NewUninitializedRecord_Internal_Int32_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_NewRecord_Internal_Int32_Int32_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_NewEmptyRow_Internal_DataRow_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_NewUninitializedRow_Private_DataRow_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_NewRow_Public_DataRow_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmptyRow_Internal_DataRow_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_NewRowCreated_Private_Void_DataRow_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_NewRow_Internal_DataRow_Int32_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_NewRowFromBuilder_Protected_Virtual_New_DataRow_DataRowBuilder_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_GetRowType_Protected_Virtual_New_Type_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_NewRowArray_FamOrAssem_Il2CppReferenceArray_1_DataRow_Int32_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedColumnChangeEvents_Internal_get_Boolean_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnChanging_FamOrAssem_Virtual_New_Void_DataColumnChangeEventArgs_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnChanged_FamOrAssem_Virtual_New_Void_DataColumnChangeEventArgs_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_PropertyChangedEventArgs_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_OnRemoveColumnInternal_Internal_Void_DataColumn_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_OnRemoveColumn_Protected_Virtual_New_Void_DataColumn_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_OnRowChanged_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_OnRowChanging_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_OnRowChanged_Protected_Virtual_New_Void_DataRowChangeEventArgs_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_OnRowChanging_Protected_Virtual_New_Void_DataRowChangeEventArgs_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_OnRowDeleting_Protected_Virtual_New_Void_DataRowChangeEventArgs_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_OnRowDeleted_Protected_Virtual_New_Void_DataRowChangeEventArgs_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_OnTableCleared_Protected_Virtual_New_Void_DataTableClearEventArgs_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_OnTableClearing_Protected_Virtual_New_Void_DataTableClearEventArgs_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_OnTableNewRow_Protected_Virtual_New_Void_DataTableNewRowEventArgs_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_ParseSortString_Internal_Il2CppReferenceArray_1_IndexField_String_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_RaisePropertyChanging_Internal_Void_String_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_RecordChanged_Internal_Void_Int32_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_RecordChanged_Internal_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_RecordStateChanged_Internal_Void_Int32_DataViewRowState_DataViewRowState_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_RecordStateChanged_Internal_Void_Int32_DataViewRowState_DataViewRowState_Int32_DataViewRowState_DataViewRowState_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRecordFromIndexes_Internal_Il2CppStructArray_1_Int32_DataRow_DataRowVersion_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_InsertRecordToIndexes_Internal_Il2CppStructArray_1_Int32_DataRow_DataRowVersion_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_SilentlySetValue_Internal_Void_DataRow_DataColumn_DataRowVersion_Object_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRow_Internal_Void_DataRow_Boolean_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_ResetIndexes_Internal_Void_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_ResetInternalIndexes_Internal_Void_DataColumn_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_RollbackRow_Internal_Void_DataRow_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRowChanged_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRowChanging_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRowChanging_Private_DataRowChangeEventArgs_DataRowChangeEventArgs_DataRow_DataRowAction_Boolean_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_SetNewRecord_Internal_Void_DataRow_Int32_DataRowAction_Boolean_Boolean_Boolean_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_SetNewRecordWorker_Private_Void_DataRow_Int32_DataRowAction_Boolean_Boolean_Int32_Boolean_byref_Exception_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_SetOldRecord_Internal_Void_DataRow_Int32_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_RestoreShadowIndexes_Private_Void_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_SetShadowIndexes_Private_Void_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_ShadowIndexCopy_Internal_Void_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_UpdatingCurrent_Internal_Boolean_DataRow_DataRowAction_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_AddUniqueKey_Internal_DataColumn_Int32_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_AddUniqueKey_Internal_DataColumn_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_AddForeignKey_Internal_DataColumn_DataColumn_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePropertyDescriptorCollectionCache_Internal_Void_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyDescriptorCollection_Internal_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Internal_get_XmlQualifiedName_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeName_Internal_set_Void_XmlQualifiedName_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Void_DataTable_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Void_DataTable_Boolean_MissingSchemaAction_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_WriteXml_Public_Void_XmlWriter_XmlWriteMode_Boolean_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_CheckForClosureOnExpressions_Private_Boolean_DataTable_Boolean_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_CheckForClosureOnExpressionTables_Private_Boolean_List_1_DataTable_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlSchema_Public_Void_XmlWriter_Boolean_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_RestoreConstraint_Private_Void_Boolean_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_IsEmptyXml_Private_Boolean_XmlReader_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_ReadXml_Internal_XmlReadMode_XmlReader_XmlReadMode_Boolean_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_ReadEndElement_Internal_Void_XmlReader_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_ReadXDRSchema_Internal_Void_XmlReader_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Internal_Boolean_XmlReader_Int32_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlDiffgram_Private_Void_XmlReader_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_ReadXSDSchema_Internal_Void_XmlReader_Boolean_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlSchema_Internal_Void_XmlReader_Boolean_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_CreateTableList_Private_Void_DataTable_List_1_DataTable_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_CreateRelationList_Private_Void_List_1_DataTable_List_1_DataRelation_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_GetDataTableSchema_Public_Static_XmlSchemaComplexType_XmlSchemaSet_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_GetSchema_Protected_Virtual_New_XmlSchema_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlSerializable_Protected_Virtual_New_Void_XmlReader_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_get_RowDiffId_Internal_get_Hashtable_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_AddDependentColumn_Internal_Void_DataColumn_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDependentColumn_Internal_Void_DataColumn_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateExpressions_Internal_Void_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateExpressions_Internal_Void_DataRow_DataRowAction_List_1_DataRow_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateExpressions_Internal_Void_DataColumn_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateDependentExpressions_Internal_Void_DataColumn_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateDependentExpressions_Internal_Void_List_1_DataColumn_DataRow_DataRowVersion_List_1_DataRow_0;

		// Token: 0x020000CE RID: 206
		public sealed class RowDiffIdUsageSection : ValueType
		{
			// Token: 0x0600143D RID: 5181 RVA: 0x00061100 File Offset: 0x0005F300
			// Note: this type is marked as 'beforefieldinit'.
			static RowDiffIdUsageSection()
			{
				Il2CppClassPointerStore<DataTable.RowDiffIdUsageSection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "RowDiffIdUsageSection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataTable.RowDiffIdUsageSection>.NativeClassPtr);
				DataTable.RowDiffIdUsageSection.NativeFieldInfoPtr__targetTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable.RowDiffIdUsageSection>.NativeClassPtr, "_targetTable");
				DataTable.RowDiffIdUsageSection.NativeMethodInfoPtr_Prepare_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable.RowDiffIdUsageSection>.NativeClassPtr, 100664038);
			}

			// Token: 0x0600143E RID: 5182 RVA: 0x00061154 File Offset: 0x0005F354
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 893184, RefRangeEnd = 893185, XrefRangeStart = 893181, XrefRangeEnd = 893184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Prepare(DataTable table)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.RowDiffIdUsageSection.NativeMethodInfoPtr_Prepare_Internal_Void_DataTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600143F RID: 5183 RVA: 0x000079C2 File Offset: 0x00005BC2
			public RowDiffIdUsageSection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001440 RID: 5184 RVA: 0x000079CB File Offset: 0x00005BCB
			public RowDiffIdUsageSection()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTable.RowDiffIdUsageSection>.NativeClassPtr))
			{
			}

			// Token: 0x17000497 RID: 1175
			// (get) Token: 0x06001441 RID: 5185 RVA: 0x0006119C File Offset: 0x0005F39C
			// (set) Token: 0x06001442 RID: 5186 RVA: 0x000079DD File Offset: 0x00005BDD
			public unsafe DataTable _targetTable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.RowDiffIdUsageSection.NativeFieldInfoPtr__targetTable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.RowDiffIdUsageSection.NativeFieldInfoPtr__targetTable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010E1 RID: 4321
			private static readonly IntPtr NativeFieldInfoPtr__targetTable;

			// Token: 0x040010E2 RID: 4322
			private static readonly IntPtr NativeMethodInfoPtr_Prepare_Internal_Void_DataTable_0;
		}

		// Token: 0x020000CF RID: 207
		public sealed class DSRowDiffIdUsageSection : ValueType
		{
			// Token: 0x06001443 RID: 5187 RVA: 0x000611CC File Offset: 0x0005F3CC
			// Note: this type is marked as 'beforefieldinit'.
			static DSRowDiffIdUsageSection()
			{
				Il2CppClassPointerStore<DataTable.DSRowDiffIdUsageSection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataTable>.NativeClassPtr, "DSRowDiffIdUsageSection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataTable.DSRowDiffIdUsageSection>.NativeClassPtr);
				DataTable.DSRowDiffIdUsageSection.NativeFieldInfoPtr__targetDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTable.DSRowDiffIdUsageSection>.NativeClassPtr, "_targetDS");
				DataTable.DSRowDiffIdUsageSection.NativeMethodInfoPtr_Prepare_Internal_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTable.DSRowDiffIdUsageSection>.NativeClassPtr, 100664039);
			}

			// Token: 0x06001444 RID: 5188 RVA: 0x00061220 File Offset: 0x0005F420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893185, XrefRangeEnd = 893189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Prepare(DataSet ds)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTable.DSRowDiffIdUsageSection.NativeMethodInfoPtr_Prepare_Internal_Void_DataSet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001445 RID: 5189 RVA: 0x000079FC File Offset: 0x00005BFC
			public DSRowDiffIdUsageSection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001446 RID: 5190 RVA: 0x00007A05 File Offset: 0x00005C05
			public DSRowDiffIdUsageSection()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTable.DSRowDiffIdUsageSection>.NativeClassPtr))
			{
			}

			// Token: 0x17000498 RID: 1176
			// (get) Token: 0x06001447 RID: 5191 RVA: 0x00061268 File Offset: 0x0005F468
			// (set) Token: 0x06001448 RID: 5192 RVA: 0x00007A17 File Offset: 0x00005C17
			public unsafe DataSet _targetDS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.DSRowDiffIdUsageSection.NativeFieldInfoPtr__targetDS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTable.DSRowDiffIdUsageSection.NativeFieldInfoPtr__targetDS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010E3 RID: 4323
			private static readonly IntPtr NativeFieldInfoPtr__targetDS;

			// Token: 0x040010E4 RID: 4324
			private static readonly IntPtr NativeMethodInfoPtr_Prepare_Internal_Void_DataSet_0;
		}
	}
}
