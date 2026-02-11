using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Data
{
	// Token: 0x0200002F RID: 47
	public class DataRelation : Object
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x00021C24 File Offset: 0x0001FE24
		// Note: this type is marked as 'beforefieldinit'.
		static DataRelation()
		{
			Il2CppClassPointerStore<DataRelation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataRelation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRelation>.NativeClassPtr);
			DataRelation.NativeFieldInfoPtr__dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_dataSet");
			DataRelation.NativeFieldInfoPtr__extendedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_extendedProperties");
			DataRelation.NativeFieldInfoPtr__relationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_relationName");
			DataRelation.NativeFieldInfoPtr__childKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_childKey");
			DataRelation.NativeFieldInfoPtr__parentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_parentKey");
			DataRelation.NativeFieldInfoPtr__parentKeyConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_parentKeyConstraint");
			DataRelation.NativeFieldInfoPtr__childKeyConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_childKeyConstraint");
			DataRelation.NativeFieldInfoPtr__parentColumnNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_parentColumnNames");
			DataRelation.NativeFieldInfoPtr__childColumnNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_childColumnNames");
			DataRelation.NativeFieldInfoPtr__parentTableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_parentTableName");
			DataRelation.NativeFieldInfoPtr__childTableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_childTableName");
			DataRelation.NativeFieldInfoPtr__parentTableNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_parentTableNamespace");
			DataRelation.NativeFieldInfoPtr__childTableNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_childTableNamespace");
			DataRelation.NativeFieldInfoPtr__nested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_nested");
			DataRelation.NativeFieldInfoPtr__createConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_createConstraints");
			DataRelation.NativeFieldInfoPtr__checkMultipleNested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_checkMultipleNested");
			DataRelation.NativeFieldInfoPtr_s_objectTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "s_objectTypeCount");
			DataRelation.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "_objectID");
			DataRelation.NativeFieldInfoPtr_PropertyChanging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, "PropertyChanging");
			DataRelation.NativeMethodInfoPtr__ctor_Public_Void_String_DataColumn_DataColumn_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664270);
			DataRelation.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664271);
			DataRelation.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664272);
			DataRelation.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Il2CppStringArray_Il2CppStringArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664273);
			DataRelation.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_Il2CppStringArray_Il2CppStringArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664274);
			DataRelation.NativeMethodInfoPtr_get_ChildColumns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664275);
			DataRelation.NativeMethodInfoPtr_get_ChildColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664276);
			DataRelation.NativeMethodInfoPtr_get_ChildKey_Internal_get_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664277);
			DataRelation.NativeMethodInfoPtr_get_ChildTable_Public_Virtual_New_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664278);
			DataRelation.NativeMethodInfoPtr_get_DataSet_Public_Virtual_New_get_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664279);
			DataRelation.NativeMethodInfoPtr_get_ParentColumnNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664280);
			DataRelation.NativeMethodInfoPtr_get_ChildColumnNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664281);
			DataRelation.NativeMethodInfoPtr_IsKeyNull_Private_Static_Boolean_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664282);
			DataRelation.NativeMethodInfoPtr_GetChildRows_Internal_Static_Il2CppReferenceArray_1_DataRow_DataKey_DataKey_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664283);
			DataRelation.NativeMethodInfoPtr_GetParentRows_Internal_Static_Il2CppReferenceArray_1_DataRow_DataKey_DataKey_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664284);
			DataRelation.NativeMethodInfoPtr_GetParentRow_Internal_Static_DataRow_DataKey_DataKey_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664285);
			DataRelation.NativeMethodInfoPtr_SetDataSet_Internal_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664286);
			DataRelation.NativeMethodInfoPtr_get_ParentColumns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664287);
			DataRelation.NativeMethodInfoPtr_get_ParentColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664288);
			DataRelation.NativeMethodInfoPtr_get_ParentKey_Internal_get_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664289);
			DataRelation.NativeMethodInfoPtr_get_ParentTable_Public_Virtual_New_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664290);
			DataRelation.NativeMethodInfoPtr_get_RelationName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664291);
			DataRelation.NativeMethodInfoPtr_CheckNamespaceValidityForNestedRelations_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664292);
			DataRelation.NativeMethodInfoPtr_CheckNestedRelations_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664293);
			DataRelation.NativeMethodInfoPtr_get_Nested_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664294);
			DataRelation.NativeMethodInfoPtr_set_Nested_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664295);
			DataRelation.NativeMethodInfoPtr_get_ParentKeyConstraint_Public_Virtual_New_get_UniqueConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664296);
			DataRelation.NativeMethodInfoPtr_SetParentKeyConstraint_Internal_Void_UniqueConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664297);
			DataRelation.NativeMethodInfoPtr_get_ChildKeyConstraint_Public_Virtual_New_get_ForeignKeyConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664298);
			DataRelation.NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664299);
			DataRelation.NativeMethodInfoPtr_get_CheckMultipleNested_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664300);
			DataRelation.NativeMethodInfoPtr_set_CheckMultipleNested_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664301);
			DataRelation.NativeMethodInfoPtr_SetChildKeyConstraint_Internal_Void_ForeignKeyConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664302);
			DataRelation.NativeMethodInfoPtr_CheckState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664303);
			DataRelation.NativeMethodInfoPtr_CheckStateForProperty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664304);
			DataRelation.NativeMethodInfoPtr_Create_Private_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664305);
			DataRelation.NativeMethodInfoPtr_Clone_Internal_DataRelation_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664306);
			DataRelation.NativeMethodInfoPtr_OnPropertyChanging_FamOrAssem_Void_PropertyChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664307);
			DataRelation.NativeMethodInfoPtr_RaisePropertyChanging_FamOrAssem_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664308);
			DataRelation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664309);
			DataRelation.NativeMethodInfoPtr_ValidateMultipleNestedRelations_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664310);
			DataRelation.NativeMethodInfoPtr_IsAutoGenerated_Private_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664311);
			DataRelation.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelation>.NativeClassPtr, 100664312);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0002212C File Offset: 0x0002032C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 899462, RefRangeEnd = 899464, XrefRangeStart = 899428, XrefRangeEnd = 899462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRelation(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRelation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relationName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentColumn);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childColumn);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createConstraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr__ctor_Public_Void_String_DataColumn_DataColumn_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000221AC File Offset: 0x000203AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 899465, RefRangeEnd = 899466, XrefRangeStart = 899464, XrefRangeEnd = 899465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRelation(string relationName, Il2CppReferenceArray<DataColumn> parentColumns, Il2CppReferenceArray<DataColumn> childColumns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRelation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relationName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentColumns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childColumns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0002221C File Offset: 0x0002041C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 899474, RefRangeEnd = 899479, XrefRangeStart = 899466, XrefRangeEnd = 899474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRelation(string relationName, Il2CppReferenceArray<DataColumn> parentColumns, Il2CppReferenceArray<DataColumn> childColumns, bool createConstraints)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRelation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relationName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentColumns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childColumns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createConstraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0002229C File Offset: 0x0002049C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899479, XrefRangeEnd = 899491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRelation(string relationName, string parentTableName, string childTableName, Il2CppStringArray parentColumnNames, Il2CppStringArray childColumnNames, bool nested)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRelation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relationName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentTableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(childTableName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentColumnNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childColumnNames);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nested;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Il2CppStringArray_Il2CppStringArray_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00022340 File Offset: 0x00020540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899491, XrefRangeEnd = 899505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, Il2CppStringArray parentColumnNames, Il2CppStringArray childColumnNames, bool nested)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRelation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relationName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentTableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentTableNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(childTableName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(childTableNamespace);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentColumnNames);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childColumnNames);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nested;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_Il2CppStringArray_Il2CppStringArray_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0002240C File Offset: 0x0002060C
		public unsafe virtual Il2CppReferenceArray<DataColumn> ChildColumns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899505, XrefRangeEnd = 899507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_get_ChildColumns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00022458 File Offset: 0x00020658
		public unsafe Il2CppReferenceArray<DataColumn> ChildColumnsReference
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 899508, RefRangeEnd = 899527, XrefRangeStart = 899507, XrefRangeEnd = 899508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_get_ChildColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00022498 File Offset: 0x00020698
		public unsafe DataKey ChildKey
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 899508, RefRangeEnd = 899527, XrefRangeStart = 899508, XrefRangeEnd = 899527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_get_ChildKey_Internal_get_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DataKey(intPtr);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x000224D0 File Offset: 0x000206D0
		public unsafe virtual DataTable ChildTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899527, XrefRangeEnd = 899528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_get_ChildTable_Public_Virtual_New_get_DataTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0002251C File Offset: 0x0002071C
		public unsafe virtual DataSet DataSet
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899528, XrefRangeEnd = 899529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_get_DataSet_Public_Virtual_New_get_DataSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr3) : null;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00022568 File Offset: 0x00020768
		public unsafe Il2CppStringArray ParentColumnNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 899530, RefRangeEnd = 899532, XrefRangeStart = 899529, XrefRangeEnd = 899530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_get_ParentColumnNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x000225A8 File Offset: 0x000207A8
		public unsafe Il2CppStringArray ChildColumnNames
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 899533, RefRangeEnd = 899535, XrefRangeStart = 899532, XrefRangeEnd = 899533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_get_ChildColumnNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000225E8 File Offset: 0x000207E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899535, XrefRangeEnd = 899540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsKeyNull(Il2CppReferenceArray<Object> values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_IsKeyNull_Private_Static_Boolean_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0002262C File Offset: 0x0002082C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 899550, RefRangeEnd = 899551, XrefRangeStart = 899540, XrefRangeEnd = 899550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<DataRow> GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parentKey));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(childKey));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentRow);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_GetChildRows_Internal_Static_Il2CppReferenceArray_1_DataRow_DataKey_DataKey_DataRow_DataRowVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr3) : null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000226AC File Offset: 0x000208AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899551, XrefRangeEnd = 899561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<DataRow> GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parentKey));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(childKey));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childRow);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_GetParentRows_Internal_Static_Il2CppReferenceArray_1_DataRow_DataKey_DataKey_DataRow_DataRowVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr3) : null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0002272C File Offset: 0x0002092C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 899576, RefRangeEnd = 899578, XrefRangeStart = 899561, XrefRangeEnd = 899576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parentKey));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(childKey));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childRow);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_GetParentRow_Internal_Static_DataRow_DataKey_DataKey_DataRow_DataRowVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000227AC File Offset: 0x000209AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899578, XrefRangeEnd = 899579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDataSet(DataSet dataSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_SetDataSet_Internal_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x000227F0 File Offset: 0x000209F0
		public unsafe virtual Il2CppReferenceArray<DataColumn> ParentColumns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899579, XrefRangeEnd = 899581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_get_ParentColumns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0002283C File Offset: 0x00020A3C
		public unsafe Il2CppReferenceArray<DataColumn> ParentColumnsReference
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_get_ParentColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0002287C File Offset: 0x00020A7C
		public unsafe DataKey ParentKey
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 899582, RefRangeEnd = 899603, XrefRangeStart = 899581, XrefRangeEnd = 899582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_get_ParentKey_Internal_get_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DataKey(intPtr);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x000228B4 File Offset: 0x00020AB4
		public unsafe virtual DataTable ParentTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899603, XrefRangeEnd = 899604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_get_ParentTable_Public_Virtual_New_get_DataTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00022900 File Offset: 0x00020B00
		public unsafe virtual string RelationName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899604, XrefRangeEnd = 899605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_get_RelationName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00022944 File Offset: 0x00020B44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 899624, RefRangeEnd = 899626, XrefRangeStart = 899605, XrefRangeEnd = 899624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNamespaceValidityForNestedRelations(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_CheckNamespaceValidityForNestedRelations_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00022988 File Offset: 0x00020B88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 899656, RefRangeEnd = 899658, XrefRangeStart = 899626, XrefRangeEnd = 899656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNestedRelations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_CheckNestedRelations_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x000229BC File Offset: 0x00020BBC
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00022A04 File Offset: 0x00020C04
		public unsafe virtual bool Nested
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899658, XrefRangeEnd = 899659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_get_Nested_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899659, XrefRangeEnd = 899759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_set_Nested_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00022A50 File Offset: 0x00020C50
		public unsafe virtual UniqueConstraint ParentKeyConstraint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899759, XrefRangeEnd = 899760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_get_ParentKeyConstraint_Public_Virtual_New_get_UniqueConstraint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniqueConstraint>(intPtr3) : null;
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00022A9C File Offset: 0x00020C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParentKeyConstraint(UniqueConstraint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_SetParentKeyConstraint_Internal_Void_UniqueConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00022AE0 File Offset: 0x00020CE0
		public unsafe virtual ForeignKeyConstraint ChildKeyConstraint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899760, XrefRangeEnd = 899761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_get_ChildKeyConstraint_Public_Virtual_New_get_ForeignKeyConstraint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ForeignKeyConstraint>(intPtr3) : null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00022B2C File Offset: 0x00020D2C
		public unsafe PropertyCollection ExtendedProperties
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 899766, RefRangeEnd = 899771, XrefRangeStart = 899761, XrefRangeEnd = 899766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00022B6C File Offset: 0x00020D6C
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00022BA8 File Offset: 0x00020DA8
		public unsafe bool CheckMultipleNested
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_get_CheckMultipleNested_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_set_CheckMultipleNested_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00022BE8 File Offset: 0x00020DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildKeyConstraint(ForeignKeyConstraint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_SetChildKeyConstraint_Internal_Void_ForeignKeyConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00022C2C File Offset: 0x00020E2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 899785, RefRangeEnd = 899789, XrefRangeStart = 899771, XrefRangeEnd = 899785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_CheckState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00022C60 File Offset: 0x00020E60
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 899798, RefRangeEnd = 899843, XrefRangeStart = 899789, XrefRangeEnd = 899798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStateForProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_CheckStateForProperty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00022C94 File Offset: 0x00020E94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 899867, RefRangeEnd = 899869, XrefRangeStart = 899843, XrefRangeEnd = 899867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Create(string relationName, Il2CppReferenceArray<DataColumn> parentColumns, Il2CppReferenceArray<DataColumn> childColumns, bool createConstraints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relationName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentColumns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childColumns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createConstraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_Create_Private_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00022D08 File Offset: 0x00020F08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 899924, RefRangeEnd = 899926, XrefRangeStart = 899869, XrefRangeEnd = 899924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRelation Clone(DataSet destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_Clone_Internal_DataRelation_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr3) : null;
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00022D58 File Offset: 0x00020F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899926, XrefRangeEnd = 899935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_OnPropertyChanging_FamOrAssem_Void_PropertyChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00022D9C File Offset: 0x00020F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899935, XrefRangeEnd = 899948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaisePropertyChanging(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_RaisePropertyChanging_FamOrAssem_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00022DE0 File Offset: 0x00020FE0
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 285957, RefRangeEnd = 285998, XrefRangeStart = 285957, XrefRangeEnd = 285998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00022E24 File Offset: 0x00021024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 899972, RefRangeEnd = 899974, XrefRangeStart = 899948, XrefRangeEnd = 899972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateMultipleNestedRelations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_ValidateMultipleNestedRelations_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00022E58 File Offset: 0x00021058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 899995, RefRangeEnd = 899996, XrefRangeStart = 899974, XrefRangeEnd = 899995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAutoGenerated(DataColumn col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_IsAutoGenerated_Private_Boolean_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00022EA8 File Offset: 0x000210A8
		public unsafe int ObjectID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelation.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00003964 File Offset: 0x00001B64
		public DataRelation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00022EE4 File Offset: 0x000210E4
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x0000396D File Offset: 0x00001B6D
		public unsafe DataSet _dataSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__dataSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__dataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00022F14 File Offset: 0x00021114
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x0000398C File Offset: 0x00001B8C
		public unsafe PropertyCollection _extendedProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__extendedProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__extendedProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00022F44 File Offset: 0x00021144
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x000039AB File Offset: 0x00001BAB
		public unsafe string _relationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__relationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__relationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00022F6C File Offset: 0x0002116C
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x000039CA File Offset: 0x00001BCA
		public DataKey _childKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__childKey);
				return new DataKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataKey>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__childKey), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataKey>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00022F9C File Offset: 0x0002119C
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x000039F8 File Offset: 0x00001BF8
		public DataKey _parentKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__parentKey);
				return new DataKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataKey>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__parentKey), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataKey>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00022FCC File Offset: 0x000211CC
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00003A26 File Offset: 0x00001C26
		public unsafe UniqueConstraint _parentKeyConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__parentKeyConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniqueConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__parentKeyConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00022FFC File Offset: 0x000211FC
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00003A45 File Offset: 0x00001C45
		public unsafe ForeignKeyConstraint _childKeyConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__childKeyConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ForeignKeyConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__childKeyConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0002302C File Offset: 0x0002122C
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00003A64 File Offset: 0x00001C64
		public unsafe Il2CppStringArray _parentColumnNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__parentColumnNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__parentColumnNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0002305C File Offset: 0x0002125C
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00003A83 File Offset: 0x00001C83
		public unsafe Il2CppStringArray _childColumnNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__childColumnNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__childColumnNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0002308C File Offset: 0x0002128C
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00003AA2 File Offset: 0x00001CA2
		public unsafe string _parentTableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__parentTableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__parentTableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x000230B4 File Offset: 0x000212B4
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00003AC1 File Offset: 0x00001CC1
		public unsafe string _childTableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__childTableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__childTableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x000230DC File Offset: 0x000212DC
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public unsafe string _parentTableNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__parentTableNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__parentTableNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00023104 File Offset: 0x00021304
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00003AFF File Offset: 0x00001CFF
		public unsafe string _childTableNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__childTableNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__childTableNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0002312C File Offset: 0x0002132C
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00003B1E File Offset: 0x00001D1E
		public unsafe bool _nested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__nested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__nested)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00023154 File Offset: 0x00021354
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00003B39 File Offset: 0x00001D39
		public unsafe bool _createConstraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__createConstraints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__createConstraints)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0002317C File Offset: 0x0002137C
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00003B54 File Offset: 0x00001D54
		public unsafe bool _checkMultipleNested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__checkMultipleNested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__checkMultipleNested)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x000231A4 File Offset: 0x000213A4
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00003B6F File Offset: 0x00001D6F
		public unsafe static int s_objectTypeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DataRelation.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataRelation.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x000231C0 File Offset: 0x000213C0
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00003B7D File Offset: 0x00001D7D
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x000231E8 File Offset: 0x000213E8
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00003B98 File Offset: 0x00001D98
		public unsafe PropertyChangedEventHandler PropertyChanging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr_PropertyChanging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelation.NativeFieldInfoPtr_PropertyChanging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr__dataSet;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr__extendedProperties;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr__relationName;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr__childKey;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr__parentKey;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr__parentKeyConstraint;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr__childKeyConstraint;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr__parentColumnNames;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr__childColumnNames;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr__parentTableName;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr__childTableName;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr__parentTableNamespace;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr__childTableNamespace;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeFieldInfoPtr__nested;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr__createConstraints;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeFieldInfoPtr__checkMultipleNested;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr_s_objectTypeCount;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_PropertyChanging;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DataColumn_DataColumn_Boolean_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_Boolean_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Il2CppStringArray_Il2CppStringArray_Boolean_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_Il2CppStringArray_Il2CppStringArray_Boolean_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildColumns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildKey_Internal_get_DataKey_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildTable_Public_Virtual_New_get_DataTable_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSet_Public_Virtual_New_get_DataSet_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentColumnNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildColumnNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_IsKeyNull_Private_Static_Boolean_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_GetChildRows_Internal_Static_Il2CppReferenceArray_1_DataRow_DataKey_DataKey_DataRow_DataRowVersion_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_GetParentRows_Internal_Static_Il2CppReferenceArray_1_DataRow_DataKey_DataKey_DataRow_DataRowVersion_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_GetParentRow_Internal_Static_DataRow_DataKey_DataKey_DataRow_DataRowVersion_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_SetDataSet_Internal_Void_DataSet_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentColumns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentKey_Internal_get_DataKey_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentTable_Public_Virtual_New_get_DataTable_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_get_RelationName_Public_Virtual_New_get_String_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_CheckNamespaceValidityForNestedRelations_Internal_Void_String_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_CheckNestedRelations_Internal_Void_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_get_Nested_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_set_Nested_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentKeyConstraint_Public_Virtual_New_get_UniqueConstraint_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_SetParentKeyConstraint_Internal_Void_UniqueConstraint_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildKeyConstraint_Public_Virtual_New_get_ForeignKeyConstraint_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckMultipleNested_Internal_get_Boolean_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckMultipleNested_Internal_set_Void_Boolean_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_SetChildKeyConstraint_Internal_Void_ForeignKeyConstraint_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_CheckState_Internal_Void_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_CheckStateForProperty_Protected_Void_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_Boolean_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_DataRelation_DataSet_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_OnPropertyChanging_FamOrAssem_Void_PropertyChangedEventArgs_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_RaisePropertyChanging_FamOrAssem_Void_String_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_ValidateMultipleNestedRelations_Internal_Void_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoGenerated_Private_Boolean_DataColumn_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0;
	}
}
