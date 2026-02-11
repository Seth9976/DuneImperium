using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Data.Common;
using Il2CppSystem.Globalization;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Serialization;

namespace Il2CppSystem.Data
{
	// Token: 0x02000008 RID: 8
	public class DataColumn : MarshalByValueComponent
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000088C0 File Offset: 0x00006AC0
		// Note: this type is marked as 'beforefieldinit'.
		static DataColumn()
		{
			Il2CppClassPointerStore<DataColumn>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataColumn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataColumn>.NativeClassPtr);
			DataColumn.NativeFieldInfoPtr__allowNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_allowNull");
			DataColumn.NativeFieldInfoPtr__caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_caption");
			DataColumn.NativeFieldInfoPtr__columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_columnName");
			DataColumn.NativeFieldInfoPtr__dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_dataType");
			DataColumn.NativeFieldInfoPtr__storageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_storageType");
			DataColumn.NativeFieldInfoPtr__defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_defaultValue");
			DataColumn.NativeFieldInfoPtr__dateTimeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_dateTimeMode");
			DataColumn.NativeFieldInfoPtr__expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_expression");
			DataColumn.NativeFieldInfoPtr__maxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_maxLength");
			DataColumn.NativeFieldInfoPtr__ordinal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_ordinal");
			DataColumn.NativeFieldInfoPtr__readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_readOnly");
			DataColumn.NativeFieldInfoPtr__sortIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_sortIndex");
			DataColumn.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_table");
			DataColumn.NativeFieldInfoPtr__unique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_unique");
			DataColumn.NativeFieldInfoPtr__columnMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_columnMapping");
			DataColumn.NativeFieldInfoPtr__hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_hashCode");
			DataColumn.NativeFieldInfoPtr__errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_errors");
			DataColumn.NativeFieldInfoPtr__isSqlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_isSqlType");
			DataColumn.NativeFieldInfoPtr__implementsINullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_implementsINullable");
			DataColumn.NativeFieldInfoPtr__implementsIChangeTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_implementsIChangeTracking");
			DataColumn.NativeFieldInfoPtr__implementsIRevertibleChangeTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_implementsIRevertibleChangeTracking");
			DataColumn.NativeFieldInfoPtr__implementsIXMLSerializable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_implementsIXMLSerializable");
			DataColumn.NativeFieldInfoPtr__defaultValueIsNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_defaultValueIsNull");
			DataColumn.NativeFieldInfoPtr__dependentColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_dependentColumns");
			DataColumn.NativeFieldInfoPtr__extendedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_extendedProperties");
			DataColumn.NativeFieldInfoPtr__storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_storage");
			DataColumn.NativeFieldInfoPtr__autoInc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_autoInc");
			DataColumn.NativeFieldInfoPtr__columnUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_columnUri");
			DataColumn.NativeFieldInfoPtr__columnPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_columnPrefix");
			DataColumn.NativeFieldInfoPtr__encodedColumnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_encodedColumnName");
			DataColumn.NativeFieldInfoPtr__simpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_simpleType");
			DataColumn.NativeFieldInfoPtr_s_objectTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "s_objectTypeCount");
			DataColumn.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "_objectID");
			DataColumn.NativeFieldInfoPtr__XmlDataType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "<XmlDataType>k__BackingField");
			DataColumn.NativeFieldInfoPtr_PropertyChanging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, "PropertyChanging");
			DataColumn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663311);
			DataColumn.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663312);
			DataColumn.NativeMethodInfoPtr__ctor_Public_Void_String_Type_String_MappingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663313);
			DataColumn.NativeMethodInfoPtr_UpdateColumnType_Private_Void_Type_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663314);
			DataColumn.NativeMethodInfoPtr_get_AllowDBNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663315);
			DataColumn.NativeMethodInfoPtr_set_AllowDBNull_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663316);
			DataColumn.NativeMethodInfoPtr_get_AutoIncrement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663317);
			DataColumn.NativeMethodInfoPtr_set_AutoIncrement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663318);
			DataColumn.NativeMethodInfoPtr_get_AutoIncrementCurrent_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663319);
			DataColumn.NativeMethodInfoPtr_set_AutoIncrementCurrent_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663320);
			DataColumn.NativeMethodInfoPtr_get_AutoInc_Internal_get_AutoIncrementValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663321);
			DataColumn.NativeMethodInfoPtr_get_AutoIncrementSeed_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663322);
			DataColumn.NativeMethodInfoPtr_set_AutoIncrementSeed_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663323);
			DataColumn.NativeMethodInfoPtr_get_AutoIncrementStep_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663324);
			DataColumn.NativeMethodInfoPtr_set_AutoIncrementStep_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663325);
			DataColumn.NativeMethodInfoPtr_get_Caption_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663326);
			DataColumn.NativeMethodInfoPtr_set_Caption_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663327);
			DataColumn.NativeMethodInfoPtr_get_ColumnName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663328);
			DataColumn.NativeMethodInfoPtr_set_ColumnName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663329);
			DataColumn.NativeMethodInfoPtr_get_EncodedColumnName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663330);
			DataColumn.NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663331);
			DataColumn.NativeMethodInfoPtr_get_Locale_Internal_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663332);
			DataColumn.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663333);
			DataColumn.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663334);
			DataColumn.NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663335);
			DataColumn.NativeMethodInfoPtr_GetColumnValueAsString_Internal_String_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663336);
			DataColumn.NativeMethodInfoPtr_get_Computed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663337);
			DataColumn.NativeMethodInfoPtr_get_DataExpression_Internal_get_DataExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663338);
			DataColumn.NativeMethodInfoPtr_get_DataType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663339);
			DataColumn.NativeMethodInfoPtr_set_DataType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663340);
			DataColumn.NativeMethodInfoPtr_get_DateTimeMode_Public_get_DataSetDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663341);
			DataColumn.NativeMethodInfoPtr_set_DateTimeMode_Public_set_Void_DataSetDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663342);
			DataColumn.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663343);
			DataColumn.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663344);
			DataColumn.NativeMethodInfoPtr_get_DefaultValueIsNull_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663345);
			DataColumn.NativeMethodInfoPtr_get_Expression_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663346);
			DataColumn.NativeMethodInfoPtr_set_Expression_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663347);
			DataColumn.NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663348);
			DataColumn.NativeMethodInfoPtr_get_HasData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663349);
			DataColumn.NativeMethodInfoPtr_get_ImplementsINullable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663350);
			DataColumn.NativeMethodInfoPtr_get_ImplementsIChangeTracking_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663351);
			DataColumn.NativeMethodInfoPtr_get_ImplementsIRevertibleChangeTracking_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663352);
			DataColumn.NativeMethodInfoPtr_get_IsValueType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663353);
			DataColumn.NativeMethodInfoPtr_get_IsSqlType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663354);
			DataColumn.NativeMethodInfoPtr_SetMaxLengthSimpleType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663355);
			DataColumn.NativeMethodInfoPtr_get_MaxLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663356);
			DataColumn.NativeMethodInfoPtr_set_MaxLength_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663357);
			DataColumn.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663358);
			DataColumn.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663359);
			DataColumn.NativeMethodInfoPtr_get_Ordinal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663360);
			DataColumn.NativeMethodInfoPtr_SetOrdinalInternal_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663361);
			DataColumn.NativeMethodInfoPtr_get_ReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663362);
			DataColumn.NativeMethodInfoPtr_set_ReadOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663363);
			DataColumn.NativeMethodInfoPtr_get_SortIndex_Private_get_Index_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663364);
			DataColumn.NativeMethodInfoPtr_get_Table_Public_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663365);
			DataColumn.NativeMethodInfoPtr_SetTable_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663366);
			DataColumn.NativeMethodInfoPtr_GetDataRow_Private_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663367);
			DataColumn.NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663368);
			DataColumn.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663369);
			DataColumn.NativeMethodInfoPtr_InitializeRecord_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663370);
			DataColumn.NativeMethodInfoPtr_SetValue_Internal_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663371);
			DataColumn.NativeMethodInfoPtr_FreeRecord_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663372);
			DataColumn.NativeMethodInfoPtr_get_Unique_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663373);
			DataColumn.NativeMethodInfoPtr_set_Unique_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663374);
			DataColumn.NativeMethodInfoPtr_InternalUnique_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663375);
			DataColumn.NativeMethodInfoPtr_get_XmlDataType_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663376);
			DataColumn.NativeMethodInfoPtr_set_XmlDataType_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663377);
			DataColumn.NativeMethodInfoPtr_get_SimpleType_Internal_get_SimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663378);
			DataColumn.NativeMethodInfoPtr_set_SimpleType_Internal_set_Void_SimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663379);
			DataColumn.NativeMethodInfoPtr_get_ColumnMapping_Public_Virtual_New_get_MappingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663380);
			DataColumn.NativeMethodInfoPtr_set_ColumnMapping_Public_Virtual_New_set_Void_MappingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663381);
			DataColumn.NativeMethodInfoPtr_CheckColumnConstraint_Internal_Void_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663382);
			DataColumn.NativeMethodInfoPtr_CheckMaxLength_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663383);
			DataColumn.NativeMethodInfoPtr_CheckMaxLength_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663384);
			DataColumn.NativeMethodInfoPtr_CheckNotAllowNull_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663385);
			DataColumn.NativeMethodInfoPtr_CheckNullable_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663386);
			DataColumn.NativeMethodInfoPtr_CheckUnique_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663387);
			DataColumn.NativeMethodInfoPtr_Compare_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663388);
			DataColumn.NativeMethodInfoPtr_CompareValueTo_Internal_Boolean_Int32_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663389);
			DataColumn.NativeMethodInfoPtr_CompareValueTo_Internal_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663390);
			DataColumn.NativeMethodInfoPtr_ConvertValue_Internal_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663391);
			DataColumn.NativeMethodInfoPtr_Copy_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663392);
			DataColumn.NativeMethodInfoPtr_Clone_Internal_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663393);
			DataColumn.NativeMethodInfoPtr_GetAggregateValue_Internal_Object_Il2CppStructArray_1_Int32_AggregateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663394);
			DataColumn.NativeMethodInfoPtr_GetStringLength_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663395);
			DataColumn.NativeMethodInfoPtr_Init_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663396);
			DataColumn.NativeMethodInfoPtr_IsAutoIncrementType_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663397);
			DataColumn.NativeMethodInfoPtr_get_IsCustomType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663398);
			DataColumn.NativeMethodInfoPtr_IsValueCustomTypeInstance_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663399);
			DataColumn.NativeMethodInfoPtr_get_ImplementsIXMLSerializable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663400);
			DataColumn.NativeMethodInfoPtr_IsInRelation_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663401);
			DataColumn.NativeMethodInfoPtr_IsMaxLengthViolated_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663402);
			DataColumn.NativeMethodInfoPtr_IsNotAllowDBNullViolated_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663403);
			DataColumn.NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_PropertyChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663404);
			DataColumn.NativeMethodInfoPtr_RaisePropertyChanging_FamOrAssem_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663405);
			DataColumn.NativeMethodInfoPtr_InsureStorage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663406);
			DataColumn.NativeMethodInfoPtr_SetCapacity_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663407);
			DataColumn.NativeMethodInfoPtr_OnSetDataSet_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663408);
			DataColumn.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663409);
			DataColumn.NativeMethodInfoPtr_ConvertXmlToObject_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663410);
			DataColumn.NativeMethodInfoPtr_ConvertXmlToObject_Internal_Object_XmlReader_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663411);
			DataColumn.NativeMethodInfoPtr_ConvertObjectToXml_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663412);
			DataColumn.NativeMethodInfoPtr_ConvertObjectToXml_Internal_Void_Object_XmlWriter_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663413);
			DataColumn.NativeMethodInfoPtr_GetEmptyColumnStore_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663414);
			DataColumn.NativeMethodInfoPtr_CopyValueIntoStore_Internal_Void_Int32_Object_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663415);
			DataColumn.NativeMethodInfoPtr_SetStorage_Internal_Void_Object_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663416);
			DataColumn.NativeMethodInfoPtr_AddDependentColumn_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663417);
			DataColumn.NativeMethodInfoPtr_RemoveDependentColumn_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663418);
			DataColumn.NativeMethodInfoPtr_HandleDependentColumnList_Internal_Void_DataExpression_DataExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumn>.NativeClassPtr, 100663419);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00009430 File Offset: 0x00007630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 887056, RefRangeEnd = 887057, XrefRangeStart = 887049, XrefRangeEnd = 887056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumn()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataColumn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000946C File Offset: 0x0000766C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 887058, RefRangeEnd = 887059, XrefRangeStart = 887057, XrefRangeEnd = 887058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumn(string columnName, Type dataType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataColumn>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000094CC File Offset: 0x000076CC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 887106, RefRangeEnd = 887117, XrefRangeStart = 887059, XrefRangeEnd = 887106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumn(string columnName, Type dataType, string expr, MappingType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataColumn>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr__ctor_Public_Void_String_Type_String_MappingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000954C File Offset: 0x0000774C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 887127, RefRangeEnd = 887129, XrefRangeStart = 887117, XrefRangeEnd = 887127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColumnType(Type type, StorageType typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_UpdateColumnType_Private_Void_Type_StorageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000959C File Offset: 0x0000779C
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000095D8 File Offset: 0x000077D8
		public unsafe bool AllowDBNull
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_AllowDBNull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 887146, RefRangeEnd = 887160, XrefRangeStart = 887129, XrefRangeEnd = 887146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_AllowDBNull_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00009618 File Offset: 0x00007818
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00009654 File Offset: 0x00007854
		public unsafe bool AutoIncrement
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 887160, RefRangeEnd = 887166, XrefRangeStart = 887160, XrefRangeEnd = 887160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_AutoIncrement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 887185, RefRangeEnd = 887188, XrefRangeStart = 887166, XrefRangeEnd = 887185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_AutoIncrement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00009694 File Offset: 0x00007894
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000096D4 File Offset: 0x000078D4
		public unsafe Object AutoIncrementCurrent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 887191, RefRangeEnd = 887192, XrefRangeStart = 887188, XrefRangeEnd = 887191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_AutoIncrementCurrent_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 887212, RefRangeEnd = 887213, XrefRangeStart = 887192, XrefRangeEnd = 887212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_AutoIncrementCurrent_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00009718 File Offset: 0x00007918
		public unsafe AutoIncrementValue AutoInc
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 887230, RefRangeEnd = 887239, XrefRangeStart = 887213, XrefRangeEnd = 887230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_AutoInc_Internal_get_AutoIncrementValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AutoIncrementValue>(intPtr3) : null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00009758 File Offset: 0x00007958
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00009794 File Offset: 0x00007994
		public unsafe long AutoIncrementSeed
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 887239, RefRangeEnd = 887242, XrefRangeStart = 887239, XrefRangeEnd = 887239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_AutoIncrementSeed_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 887253, RefRangeEnd = 887254, XrefRangeStart = 887242, XrefRangeEnd = 887253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_AutoIncrementSeed_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000097D4 File Offset: 0x000079D4
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00009810 File Offset: 0x00007A10
		public unsafe long AutoIncrementStep
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 887254, RefRangeEnd = 887257, XrefRangeStart = 887254, XrefRangeEnd = 887254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_AutoIncrementStep_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 887268, RefRangeEnd = 887269, XrefRangeStart = 887257, XrefRangeEnd = 887268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_AutoIncrementStep_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00009850 File Offset: 0x00007A50
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00009888 File Offset: 0x00007A88
		public unsafe string Caption
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 887269, RefRangeEnd = 887272, XrefRangeStart = 887269, XrefRangeEnd = 887269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_Caption_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 887281, RefRangeEnd = 887282, XrefRangeStart = 887272, XrefRangeEnd = 887281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_Caption_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000098CC File Offset: 0x00007ACC
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00009904 File Offset: 0x00007B04
		public unsafe string ColumnName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_ColumnName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 887332, RefRangeEnd = 887337, XrefRangeStart = 887282, XrefRangeEnd = 887332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_ColumnName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00009948 File Offset: 0x00007B48
		public unsafe string EncodedColumnName
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 887342, RefRangeEnd = 887360, XrefRangeStart = 887337, XrefRangeEnd = 887342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_EncodedColumnName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00009980 File Offset: 0x00007B80
		public unsafe IFormatProvider FormatProvider
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 887365, RefRangeEnd = 887369, XrefRangeStart = 887360, XrefRangeEnd = 887365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000099C0 File Offset: 0x00007BC0
		public unsafe CultureInfo Locale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887369, XrefRangeEnd = 887370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_Locale_Internal_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00009A00 File Offset: 0x00007C00
		public unsafe int ObjectID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00009A3C File Offset: 0x00007C3C
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00009A74 File Offset: 0x00007C74
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 887395, RefRangeEnd = 887402, XrefRangeStart = 887370, XrefRangeEnd = 887395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00009AB8 File Offset: 0x00007CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 887408, RefRangeEnd = 887409, XrefRangeStart = 887402, XrefRangeEnd = 887408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetColumnValueAsString(DataRow row, DataRowVersion version)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_GetColumnValueAsString_Internal_String_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00009B10 File Offset: 0x00007D10
		public unsafe bool Computed
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 344393, RefRangeEnd = 344406, XrefRangeStart = 344393, XrefRangeEnd = 344406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_Computed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00009B4C File Offset: 0x00007D4C
		public unsafe DataExpression DataExpression
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_DataExpression_Internal_get_DataExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataExpression>(intPtr3) : null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00009B8C File Offset: 0x00007D8C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00009BCC File Offset: 0x00007DCC
		public unsafe Type DataType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_DataType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 887514, RefRangeEnd = 887518, XrefRangeStart = 887409, XrefRangeEnd = 887514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_DataType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00009C10 File Offset: 0x00007E10
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00009C4C File Offset: 0x00007E4C
		public unsafe DataSetDateTime DateTimeMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_DateTimeMode_Public_get_DataSetDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 887527, RefRangeEnd = 887528, XrefRangeStart = 887518, XrefRangeEnd = 887527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_DateTimeMode_Public_set_Void_DataSetDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00009C8C File Offset: 0x00007E8C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00009CCC File Offset: 0x00007ECC
		public unsafe Object DefaultValue
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 887537, RefRangeEnd = 887556, XrefRangeStart = 887528, XrefRangeEnd = 887537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 887590, RefRangeEnd = 887598, XrefRangeStart = 887556, XrefRangeEnd = 887590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00009D10 File Offset: 0x00007F10
		public unsafe bool DefaultValueIsNull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_DefaultValueIsNull_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00009D4C File Offset: 0x00007F4C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00009D84 File Offset: 0x00007F84
		public unsafe string Expression
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 887600, RefRangeEnd = 887620, XrefRangeStart = 887598, XrefRangeEnd = 887600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_Expression_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 887688, RefRangeEnd = 887699, XrefRangeStart = 887620, XrefRangeEnd = 887688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_Expression_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00009DC8 File Offset: 0x00007FC8
		public unsafe PropertyCollection ExtendedProperties
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 887704, RefRangeEnd = 887706, XrefRangeStart = 887699, XrefRangeEnd = 887704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00009E08 File Offset: 0x00008008
		public unsafe bool HasData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_HasData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00009E44 File Offset: 0x00008044
		public unsafe bool ImplementsINullable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_ImplementsINullable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00009E80 File Offset: 0x00008080
		public unsafe bool ImplementsIChangeTracking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_ImplementsIChangeTracking_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00009EBC File Offset: 0x000080BC
		public unsafe bool ImplementsIRevertibleChangeTracking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_ImplementsIRevertibleChangeTracking_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00009EF8 File Offset: 0x000080F8
		public unsafe bool IsValueType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 887706, RefRangeEnd = 887708, XrefRangeStart = 887706, XrefRangeEnd = 887706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_IsValueType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00009F34 File Offset: 0x00008134
		public unsafe bool IsSqlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_IsSqlType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00009F70 File Offset: 0x00008170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887708, XrefRangeEnd = 887711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxLengthSimpleType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_SetMaxLengthSimpleType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00009FA4 File Offset: 0x000081A4
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00009FE0 File Offset: 0x000081E0
		public unsafe int MaxLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_MaxLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 887754, RefRangeEnd = 887756, XrefRangeStart = 887711, XrefRangeEnd = 887754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_MaxLength_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000A020 File Offset: 0x00008220
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000A058 File Offset: 0x00008258
		public unsafe string Namespace
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 887757, RefRangeEnd = 887791, XrefRangeStart = 887756, XrefRangeEnd = 887757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 887812, RefRangeEnd = 887818, XrefRangeStart = 887791, XrefRangeEnd = 887812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000A09C File Offset: 0x0000829C
		public unsafe int Ordinal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_Ordinal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000A0D8 File Offset: 0x000082D8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 887828, RefRangeEnd = 887837, XrefRangeStart = 887818, XrefRangeEnd = 887828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOrdinalInternal(int ordinal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ordinal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_SetOrdinalInternal_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000A118 File Offset: 0x00008318
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000A154 File Offset: 0x00008354
		public unsafe bool ReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_ReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 887846, RefRangeEnd = 887848, XrefRangeStart = 887837, XrefRangeEnd = 887846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_ReadOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000A194 File Offset: 0x00008394
		public unsafe Index SortIndex
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 887856, RefRangeEnd = 887859, XrefRangeStart = 887848, XrefRangeEnd = 887856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_SortIndex_Private_get_Index_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Index>(intPtr3) : null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000A1D4 File Offset: 0x000083D4
		public unsafe DataTable Table
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_Table_Public_get_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000A214 File Offset: 0x00008414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 887864, RefRangeEnd = 887866, XrefRangeStart = 887859, XrefRangeEnd = 887864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTable(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_SetTable_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000A258 File Offset: 0x00008458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887866, XrefRangeEnd = 887868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow GetDataRow(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_GetDataRow_Private_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
			}
		}

		// Token: 0x1700004D RID: 77
		public unsafe Object this[int record]
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 887869, RefRangeEnd = 887877, XrefRangeStart = 887868, XrefRangeEnd = 887869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref record;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 887880, RefRangeEnd = 887899, XrefRangeStart = 887877, XrefRangeEnd = 887880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref record;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000A340 File Offset: 0x00008540
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 887901, RefRangeEnd = 887903, XrefRangeStart = 887899, XrefRangeEnd = 887901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeRecord(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_InitializeRecord_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000A380 File Offset: 0x00008580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 887905, RefRangeEnd = 887906, XrefRangeStart = 887903, XrefRangeEnd = 887905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(int record, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_SetValue_Internal_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000A3D0 File Offset: 0x000085D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 887907, RefRangeEnd = 887908, XrefRangeStart = 887906, XrefRangeEnd = 887907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeRecord(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_FreeRecord_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000A410 File Offset: 0x00008610
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000A44C File Offset: 0x0000864C
		public unsafe bool Unique
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_Unique_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 887948, RefRangeEnd = 887949, XrefRangeStart = 887908, XrefRangeEnd = 887948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_Unique_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000A48C File Offset: 0x0000868C
		[CallerCount(0)]
		public unsafe void InternalUnique(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_InternalUnique_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000A4CC File Offset: 0x000086CC
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000A504 File Offset: 0x00008704
		public unsafe string XmlDataType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_XmlDataType_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_XmlDataType_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000A548 File Offset: 0x00008748
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000A588 File Offset: 0x00008788
		public unsafe SimpleType SimpleType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_SimpleType_Internal_get_SimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleType>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 887951, RefRangeEnd = 887957, XrefRangeStart = 887949, XrefRangeEnd = 887951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_set_SimpleType_Internal_set_Void_SimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000A5CC File Offset: 0x000087CC
		// (set) Token: 0x0600006B RID: 107 RVA: 0x0000A614 File Offset: 0x00008814
		public unsafe virtual MappingType ColumnMapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataColumn.NativeMethodInfoPtr_get_ColumnMapping_Public_Virtual_New_get_MappingType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887957, XrefRangeEnd = 887981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataColumn.NativeMethodInfoPtr_set_ColumnMapping_Public_Virtual_New_set_Void_MappingType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000A660 File Offset: 0x00008860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 887984, RefRangeEnd = 887986, XrefRangeStart = 887981, XrefRangeEnd = 887984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckColumnConstraint(DataRow row, DataRowAction action)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_CheckColumnConstraint_Internal_Void_DataRow_DataRowAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 887997, RefRangeEnd = 887998, XrefRangeStart = 887986, XrefRangeEnd = 887997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckMaxLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_CheckMaxLength_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000A6EC File Offset: 0x000088EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887998, XrefRangeEnd = 887999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckMaxLength(DataRow dr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_CheckMaxLength_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000A730 File Offset: 0x00008930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 888028, RefRangeEnd = 888029, XrefRangeStart = 887999, XrefRangeEnd = 888028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNotAllowNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_CheckNotAllowNull_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000A764 File Offset: 0x00008964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888029, XrefRangeEnd = 888030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNullable(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_CheckNullable_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000A7A8 File Offset: 0x000089A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888030, XrefRangeEnd = 888032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUnique()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_CheckUnique_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000A7DC File Offset: 0x000089DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 888033, RefRangeEnd = 888034, XrefRangeStart = 888032, XrefRangeEnd = 888033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(int record1, int record2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref record2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_Compare_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000A834 File Offset: 0x00008A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 888051, RefRangeEnd = 888052, XrefRangeStart = 888034, XrefRangeEnd = 888051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareValueTo(int record1, Object value, bool checkType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_CompareValueTo_Internal_Boolean_Int32_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000A8A0 File Offset: 0x00008AA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 888053, RefRangeEnd = 888057, XrefRangeStart = 888052, XrefRangeEnd = 888053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareValueTo(int record1, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_CompareValueTo_Internal_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A8FC File Offset: 0x00008AFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 888058, RefRangeEnd = 888061, XrefRangeStart = 888057, XrefRangeEnd = 888058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConvertValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_ConvertValue_Internal_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000A94C File Offset: 0x00008B4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 888062, RefRangeEnd = 888063, XrefRangeStart = 888061, XrefRangeEnd = 888062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Copy(int srcRecordNo, int dstRecordNo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref srcRecordNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstRecordNo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_Copy_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000A998 File Offset: 0x00008B98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 888118, RefRangeEnd = 888121, XrefRangeStart = 888063, XrefRangeEnd = 888118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumn Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_Clone_Internal_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 888125, RefRangeEnd = 888127, XrefRangeStart = 888121, XrefRangeEnd = 888125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetAggregateValue(Il2CppStructArray<int> records, AggregateType kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(records);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_GetAggregateValue_Internal_Object_Il2CppStructArray_1_Int32_AggregateType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000AA38 File Offset: 0x00008C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888127, XrefRangeEnd = 888128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStringLength(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_GetStringLength_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000AA84 File Offset: 0x00008C84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 888130, RefRangeEnd = 888134, XrefRangeStart = 888128, XrefRangeEnd = 888130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_Init_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000AAC4 File Offset: 0x00008CC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 888189, RefRangeEnd = 888191, XrefRangeStart = 888134, XrefRangeEnd = 888189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAutoIncrementType(Type dataType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_IsAutoIncrementType_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000AB08 File Offset: 0x00008D08
		public unsafe bool IsCustomType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 888192, RefRangeEnd = 888197, XrefRangeStart = 888191, XrefRangeEnd = 888192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_IsCustomType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000AB44 File Offset: 0x00008D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 888203, RefRangeEnd = 888205, XrefRangeStart = 888197, XrefRangeEnd = 888203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValueCustomTypeInstance(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_IsValueCustomTypeInstance_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000AB94 File Offset: 0x00008D94
		public unsafe bool ImplementsIXMLSerializable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_get_ImplementsIXMLSerializable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000ABD0 File Offset: 0x00008DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888205, XrefRangeEnd = 888213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInRelation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_IsInRelation_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000AC0C File Offset: 0x00008E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 888253, RefRangeEnd = 888255, XrefRangeStart = 888213, XrefRangeEnd = 888253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMaxLengthViolated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_IsMaxLengthViolated_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000AC48 File Offset: 0x00008E48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 888272, RefRangeEnd = 888274, XrefRangeStart = 888255, XrefRangeEnd = 888272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNotAllowDBNullViolated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_IsNotAllowDBNullViolated_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000AC84 File Offset: 0x00008E84
		[CallerCount(0)]
		public unsafe virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataColumn.NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_PropertyChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000ACD4 File Offset: 0x00008ED4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 888278, RefRangeEnd = 888283, XrefRangeStart = 888274, XrefRangeEnd = 888278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaisePropertyChanging(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_RaisePropertyChanging_FamOrAssem_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000AD18 File Offset: 0x00008F18
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 888288, RefRangeEnd = 888296, XrefRangeStart = 888283, XrefRangeEnd = 888288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsureStorage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_InsureStorage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000AD4C File Offset: 0x00008F4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 888298, RefRangeEnd = 888301, XrefRangeStart = 888296, XrefRangeEnd = 888298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_SetCapacity_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000AD8C File Offset: 0x00008F8C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSetDataSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_OnSetDataSet_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888301, XrefRangeEnd = 888302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataColumn.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000AE04 File Offset: 0x00009004
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 888304, RefRangeEnd = 888322, XrefRangeStart = 888302, XrefRangeEnd = 888304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConvertXmlToObject(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_ConvertXmlToObject_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000AE54 File Offset: 0x00009054
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 888324, RefRangeEnd = 888328, XrefRangeStart = 888322, XrefRangeEnd = 888324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlReader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlAttrib);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_ConvertXmlToObject_Internal_Object_XmlReader_XmlRootAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000AEB8 File Offset: 0x000090B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 888330, RefRangeEnd = 888337, XrefRangeStart = 888328, XrefRangeEnd = 888330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConvertObjectToXml(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_ConvertObjectToXml_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000AF00 File Offset: 0x00009100
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 888339, RefRangeEnd = 888342, XrefRangeStart = 888337, XrefRangeEnd = 888339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConvertObjectToXml(Object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlWriter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlAttrib);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_ConvertObjectToXml_Internal_Void_Object_XmlWriter_XmlRootAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000AF68 File Offset: 0x00009168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 888345, RefRangeEnd = 888346, XrefRangeStart = 888342, XrefRangeEnd = 888345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetEmptyColumnStore(int recordCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_GetEmptyColumnStore_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000AFB4 File Offset: 0x000091B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 888348, RefRangeEnd = 888351, XrefRangeStart = 888346, XrefRangeEnd = 888348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyValueIntoStore(int record, Object store, BitArray nullbits, int storeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(store);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullbits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_CopyValueIntoStore_Internal_Void_Int32_Object_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000B024 File Offset: 0x00009224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 888354, RefRangeEnd = 888355, XrefRangeStart = 888351, XrefRangeEnd = 888354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStorage(Object store, BitArray nullbits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullbits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_SetStorage_Internal_Void_Object_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000B078 File Offset: 0x00009278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888355, XrefRangeEnd = 888370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDependentColumn(DataColumn expressionColumn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expressionColumn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_AddDependentColumn_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000B0BC File Offset: 0x000092BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888370, XrefRangeEnd = 888378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDependentColumn(DataColumn expressionColumn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expressionColumn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_RemoveDependentColumn_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000B100 File Offset: 0x00009300
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 888404, RefRangeEnd = 888406, XrefRangeStart = 888378, XrefRangeEnd = 888404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldExpression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newExpression);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumn.NativeMethodInfoPtr_HandleDependentColumnList_Internal_Void_DataExpression_DataExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002135 File Offset: 0x00000335
		public DataColumn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000B154 File Offset: 0x00009354
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000213E File Offset: 0x0000033E
		public unsafe bool _allowNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__allowNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__allowNull)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000B17C File Offset: 0x0000937C
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002159 File Offset: 0x00000359
		public unsafe string _caption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__caption);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__caption), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000B1A4 File Offset: 0x000093A4
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002178 File Offset: 0x00000378
		public unsafe string _columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000B1CC File Offset: 0x000093CC
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002197 File Offset: 0x00000397
		public unsafe Type _dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000B1FC File Offset: 0x000093FC
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000021B6 File Offset: 0x000003B6
		public unsafe StorageType _storageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__storageType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__storageType)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000B224 File Offset: 0x00009424
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000021D1 File Offset: 0x000003D1
		public unsafe Object _defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__defaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000B254 File Offset: 0x00009454
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000021F0 File Offset: 0x000003F0
		public unsafe DataSetDateTime _dateTimeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__dateTimeMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__dateTimeMode)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000B27C File Offset: 0x0000947C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000220B File Offset: 0x0000040B
		public unsafe DataExpression _expression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__expression);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__expression), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000B2AC File Offset: 0x000094AC
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000222A File Offset: 0x0000042A
		public unsafe int _maxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__maxLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__maxLength)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000B2D4 File Offset: 0x000094D4
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002245 File Offset: 0x00000445
		public unsafe int _ordinal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__ordinal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__ordinal)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000B2FC File Offset: 0x000094FC
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002260 File Offset: 0x00000460
		public unsafe bool _readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__readOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__readOnly)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000B324 File Offset: 0x00009524
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000227B File Offset: 0x0000047B
		public unsafe Index _sortIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__sortIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Index>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__sortIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000B354 File Offset: 0x00009554
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000229A File Offset: 0x0000049A
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000B384 File Offset: 0x00009584
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000022B9 File Offset: 0x000004B9
		public unsafe bool _unique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__unique);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__unique)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000B3AC File Offset: 0x000095AC
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000022D4 File Offset: 0x000004D4
		public unsafe MappingType _columnMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__columnMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__columnMapping)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000B3D4 File Offset: 0x000095D4
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x000022EF File Offset: 0x000004EF
		public unsafe int _hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__hashCode)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000B3FC File Offset: 0x000095FC
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000230A File Offset: 0x0000050A
		public unsafe int _errors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__errors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__errors)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000B424 File Offset: 0x00009624
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002325 File Offset: 0x00000525
		public unsafe bool _isSqlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__isSqlType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__isSqlType)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000B44C File Offset: 0x0000964C
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002340 File Offset: 0x00000540
		public unsafe bool _implementsINullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__implementsINullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__implementsINullable)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000B474 File Offset: 0x00009674
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000235B File Offset: 0x0000055B
		public unsafe bool _implementsIChangeTracking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__implementsIChangeTracking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__implementsIChangeTracking)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000B49C File Offset: 0x0000969C
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002376 File Offset: 0x00000576
		public unsafe bool _implementsIRevertibleChangeTracking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__implementsIRevertibleChangeTracking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__implementsIRevertibleChangeTracking)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000B4C4 File Offset: 0x000096C4
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002391 File Offset: 0x00000591
		public unsafe bool _implementsIXMLSerializable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__implementsIXMLSerializable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__implementsIXMLSerializable)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000B4EC File Offset: 0x000096EC
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x000023AC File Offset: 0x000005AC
		public unsafe bool _defaultValueIsNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__defaultValueIsNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__defaultValueIsNull)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000B514 File Offset: 0x00009714
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x000023C7 File Offset: 0x000005C7
		public unsafe List<DataColumn> _dependentColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__dependentColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataColumn>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__dependentColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000B544 File Offset: 0x00009744
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x000023E6 File Offset: 0x000005E6
		public unsafe PropertyCollection _extendedProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__extendedProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__extendedProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000B574 File Offset: 0x00009774
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002405 File Offset: 0x00000605
		public unsafe DataStorage _storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataStorage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000B5A4 File Offset: 0x000097A4
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002424 File Offset: 0x00000624
		public unsafe AutoIncrementValue _autoInc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__autoInc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoIncrementValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__autoInc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000B5D4 File Offset: 0x000097D4
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002443 File Offset: 0x00000643
		public unsafe string _columnUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__columnUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__columnUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000B5FC File Offset: 0x000097FC
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002462 File Offset: 0x00000662
		public unsafe string _columnPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__columnPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__columnPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000B624 File Offset: 0x00009824
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002481 File Offset: 0x00000681
		public unsafe string _encodedColumnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__encodedColumnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__encodedColumnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000B64C File Offset: 0x0000984C
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000024A0 File Offset: 0x000006A0
		public unsafe SimpleType _simpleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__simpleType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__simpleType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000B67C File Offset: 0x0000987C
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000024BF File Offset: 0x000006BF
		public unsafe static int s_objectTypeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DataColumn.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataColumn.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000B698 File Offset: 0x00009898
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000024CD File Offset: 0x000006CD
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000B6C0 File Offset: 0x000098C0
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000024E8 File Offset: 0x000006E8
		public unsafe string _XmlDataType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__XmlDataType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr__XmlDataType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000B6E8 File Offset: 0x000098E8
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002507 File Offset: 0x00000707
		public unsafe PropertyChangedEventHandler PropertyChanging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr_PropertyChanging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumn.NativeFieldInfoPtr_PropertyChanging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr__allowNull;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr__caption;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr__columnName;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__dataType;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr__storageType;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr__defaultValue;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr__dateTimeMode;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr__expression;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr__maxLength;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr__ordinal;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr__readOnly;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr__sortIndex;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr__unique;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr__columnMapping;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr__hashCode;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr__errors;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr__isSqlType;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr__implementsINullable;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr__implementsIChangeTracking;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr__implementsIRevertibleChangeTracking;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr__implementsIXMLSerializable;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr__defaultValueIsNull;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr__dependentColumns;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr__extendedProperties;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr__storage;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr__autoInc;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr__columnUri;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr__columnPrefix;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr__encodedColumnName;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr__simpleType;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_s_objectTypeCount;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr__XmlDataType_k__BackingField;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_PropertyChanging;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_String_MappingType_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColumnType_Private_Void_Type_StorageType_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowDBNull_Public_get_Boolean_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowDBNull_Public_set_Void_Boolean_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoIncrement_Public_get_Boolean_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoIncrement_Public_set_Void_Boolean_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoIncrementCurrent_Internal_get_Object_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoIncrementCurrent_Internal_set_Void_Object_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoInc_Internal_get_AutoIncrementValue_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoIncrementSeed_Public_get_Int64_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoIncrementSeed_Public_set_Void_Int64_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoIncrementStep_Public_get_Int64_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoIncrementStep_Public_set_Void_Int64_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_Caption_Public_get_String_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_set_Caption_Public_set_Void_String_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_get_String_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_set_ColumnName_Public_set_Void_String_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodedColumnName_Internal_get_String_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_get_Locale_Internal_get_CultureInfo_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnValueAsString_Internal_String_DataRow_DataRowVersion_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_Computed_Internal_get_Boolean_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_DataExpression_Internal_get_DataExpression_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_Type_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_set_DataType_Public_set_Void_Type_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeMode_Public_get_DataSetDateTime_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeMode_Public_set_Void_DataSetDateTime_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueIsNull_Internal_get_Boolean_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_get_Expression_Public_get_String_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_set_Expression_Public_set_Void_String_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_HasData_Internal_get_Boolean_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementsINullable_Internal_get_Boolean_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementsIChangeTracking_Internal_get_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementsIRevertibleChangeTracking_Internal_get_Boolean_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValueType_Internal_get_Boolean_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSqlType_Internal_get_Boolean_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxLengthSimpleType_Private_Void_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxLength_Public_get_Int32_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxLength_Public_set_Void_Int32_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_Ordinal_Public_get_Int32_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_SetOrdinalInternal_Internal_Void_Int32_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadOnly_Public_get_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadOnly_Public_set_Void_Boolean_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_SortIndex_Private_get_Index_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Public_get_DataTable_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_SetTable_Internal_Void_DataTable_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GetDataRow_Private_DataRow_Int32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_InitializeRecord_Internal_Void_Int32_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_Int32_Object_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_FreeRecord_Internal_Void_Int32_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_Unique_Public_get_Boolean_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_Unique_Public_set_Void_Boolean_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnique_Internal_Void_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlDataType_Internal_get_String_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlDataType_Internal_set_Void_String_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_SimpleType_Internal_get_SimpleType_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_set_SimpleType_Internal_set_Void_SimpleType_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnMapping_Public_Virtual_New_get_MappingType_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_set_ColumnMapping_Public_Virtual_New_set_Void_MappingType_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_CheckColumnConstraint_Internal_Void_DataRow_DataRowAction_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_CheckMaxLength_Internal_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_CheckMaxLength_Internal_Void_DataRow_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_CheckNotAllowNull_FamOrAssem_Void_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_CheckNullable_Internal_Void_DataRow_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_CheckUnique_Protected_Void_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Int32_Int32_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_CompareValueTo_Internal_Boolean_Int32_Object_Boolean_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_CompareValueTo_Internal_Int32_Int32_Object_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValue_Internal_Object_Object_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_Void_Int32_Int32_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_DataColumn_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetAggregateValue_Internal_Object_Il2CppStructArray_1_Int32_AggregateType_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetStringLength_Private_Int32_Int32_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Int32_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoIncrementType_Internal_Static_Boolean_Type_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCustomType_Internal_get_Boolean_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_IsValueCustomTypeInstance_Internal_Boolean_Object_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementsIXMLSerializable_Internal_get_Boolean_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_IsInRelation_Internal_Boolean_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_IsMaxLengthViolated_Internal_Boolean_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_IsNotAllowDBNullViolated_Internal_Boolean_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_PropertyChangedEventArgs_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_RaisePropertyChanging_FamOrAssem_Void_String_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_InsureStorage_Private_Void_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Internal_Void_Int32_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_OnSetDataSet_Internal_Void_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Internal_Object_String_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Internal_Object_XmlReader_XmlRootAttribute_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Internal_String_Object_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Internal_Void_Object_XmlWriter_XmlRootAttribute_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyColumnStore_Internal_Object_Int32_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_CopyValueIntoStore_Internal_Void_Int32_Object_BitArray_Int32_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_SetStorage_Internal_Void_Object_BitArray_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_AddDependentColumn_Internal_Void_DataColumn_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDependentColumn_Internal_Void_DataColumn_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_HandleDependentColumnList_Internal_Void_DataExpression_DataExpression_0;
	}
}
