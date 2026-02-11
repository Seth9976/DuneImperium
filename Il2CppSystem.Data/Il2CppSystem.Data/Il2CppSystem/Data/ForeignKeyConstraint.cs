using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000064 RID: 100
	public class ForeignKeyConstraint : Constraint
	{
		// Token: 0x060009A4 RID: 2468 RVA: 0x000323A4 File Offset: 0x000305A4
		// Note: this type is marked as 'beforefieldinit'.
		static ForeignKeyConstraint()
		{
			Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ForeignKeyConstraint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr);
			ForeignKeyConstraint.NativeFieldInfoPtr__deleteRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, "_deleteRule");
			ForeignKeyConstraint.NativeFieldInfoPtr__updateRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, "_updateRule");
			ForeignKeyConstraint.NativeFieldInfoPtr__acceptRejectRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, "_acceptRejectRule");
			ForeignKeyConstraint.NativeFieldInfoPtr__childKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, "_childKey");
			ForeignKeyConstraint.NativeFieldInfoPtr__parentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, "_parentKey");
			ForeignKeyConstraint.NativeFieldInfoPtr__constraintName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, "_constraintName");
			ForeignKeyConstraint.NativeFieldInfoPtr__parentColumnNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, "_parentColumnNames");
			ForeignKeyConstraint.NativeFieldInfoPtr__childColumnNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, "_childColumnNames");
			ForeignKeyConstraint.NativeFieldInfoPtr__parentTableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, "_parentTableName");
			ForeignKeyConstraint.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664885);
			ForeignKeyConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664886);
			ForeignKeyConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppStringArray_Il2CppStringArray_AcceptRejectRule_Rule_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664887);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_ChildKey_Internal_get_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664888);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_Columns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664889);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_Table_Public_Virtual_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664890);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_ParentColumnNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664891);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_ChildColumnNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664892);
			ForeignKeyConstraint.NativeMethodInfoPtr_CheckCanAddToCollection_Internal_Virtual_Void_ConstraintCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664893);
			ForeignKeyConstraint.NativeMethodInfoPtr_CanBeRemovedFromCollection_Internal_Virtual_Boolean_ConstraintCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664894);
			ForeignKeyConstraint.NativeMethodInfoPtr_IsKeyNull_Internal_Boolean_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664895);
			ForeignKeyConstraint.NativeMethodInfoPtr_IsConstraintViolated_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664896);
			ForeignKeyConstraint.NativeMethodInfoPtr_CanEnableConstraint_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664897);
			ForeignKeyConstraint.NativeMethodInfoPtr_CascadeCommit_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664898);
			ForeignKeyConstraint.NativeMethodInfoPtr_CascadeDelete_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664899);
			ForeignKeyConstraint.NativeMethodInfoPtr_CascadeRollback_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664900);
			ForeignKeyConstraint.NativeMethodInfoPtr_CascadeUpdate_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664901);
			ForeignKeyConstraint.NativeMethodInfoPtr_CheckCanClearParentTable_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664902);
			ForeignKeyConstraint.NativeMethodInfoPtr_CheckCanRemoveParentRow_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664903);
			ForeignKeyConstraint.NativeMethodInfoPtr_CheckCascade_Internal_Void_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664904);
			ForeignKeyConstraint.NativeMethodInfoPtr_CheckConstraint_Internal_Virtual_Void_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664905);
			ForeignKeyConstraint.NativeMethodInfoPtr_NonVirtualCheckState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664906);
			ForeignKeyConstraint.NativeMethodInfoPtr_CheckState_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664907);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_AcceptRejectRule_Public_Virtual_New_get_AcceptRejectRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664908);
			ForeignKeyConstraint.NativeMethodInfoPtr_set_AcceptRejectRule_Public_Virtual_New_set_Void_AcceptRejectRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664909);
			ForeignKeyConstraint.NativeMethodInfoPtr_ContainsColumn_Internal_Virtual_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664910);
			ForeignKeyConstraint.NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664911);
			ForeignKeyConstraint.NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664912);
			ForeignKeyConstraint.NativeMethodInfoPtr_Clone_Internal_ForeignKeyConstraint_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664913);
			ForeignKeyConstraint.NativeMethodInfoPtr_Create_Private_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664914);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_DeleteRule_Public_Virtual_New_get_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664915);
			ForeignKeyConstraint.NativeMethodInfoPtr_set_DeleteRule_Public_Virtual_New_set_Void_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664916);
			ForeignKeyConstraint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664917);
			ForeignKeyConstraint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664918);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_RelatedColumns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664919);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_RelatedColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664920);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_ParentKey_Internal_get_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664921);
			ForeignKeyConstraint.NativeMethodInfoPtr_FindParentRelation_Internal_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664922);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_RelatedTable_Public_Virtual_New_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664923);
			ForeignKeyConstraint.NativeMethodInfoPtr_get_UpdateRule_Public_Virtual_New_get_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664924);
			ForeignKeyConstraint.NativeMethodInfoPtr_set_UpdateRule_Public_Virtual_New_set_Void_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr, 100664925);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000327BC File Offset: 0x000309BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904850, RefRangeEnd = 904851, XrefRangeStart = 904848, XrefRangeEnd = 904850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForeignKeyConstraint(Il2CppReferenceArray<DataColumn> parentColumns, Il2CppReferenceArray<DataColumn> childColumns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentColumns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childColumns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0003281C File Offset: 0x00030A1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 904853, RefRangeEnd = 904856, XrefRangeStart = 904851, XrefRangeEnd = 904853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForeignKeyConstraint(string constraintName, Il2CppReferenceArray<DataColumn> parentColumns, Il2CppReferenceArray<DataColumn> childColumns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(constraintName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentColumns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childColumns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0003288C File Offset: 0x00030A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904856, XrefRangeEnd = 904861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForeignKeyConstraint(string constraintName, string parentTableName, Il2CppStringArray parentColumnNames, Il2CppStringArray childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForeignKeyConstraint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(constraintName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentTableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentColumnNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childColumnNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptRejectRule;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deleteRule;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateRule;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppStringArray_Il2CppStringArray_AcceptRejectRule_Rule_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00032938 File Offset: 0x00030B38
		public unsafe DataKey ChildKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 904862, RefRangeEnd = 904863, XrefRangeStart = 904861, XrefRangeEnd = 904862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_get_ChildKey_Internal_get_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DataKey(intPtr);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00032970 File Offset: 0x00030B70
		public unsafe virtual Il2CppReferenceArray<DataColumn> Columns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904863, XrefRangeEnd = 904865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_get_Columns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x000329BC File Offset: 0x00030BBC
		public unsafe override DataTable Table
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904865, XrefRangeEnd = 904867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_get_Table_Public_Virtual_get_DataTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00032A08 File Offset: 0x00030C08
		public unsafe Il2CppStringArray ParentColumnNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904867, XrefRangeEnd = 904868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_get_ParentColumnNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00032A48 File Offset: 0x00030C48
		public unsafe Il2CppStringArray ChildColumnNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904868, XrefRangeEnd = 904869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_get_ChildColumnNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00032A88 File Offset: 0x00030C88
		[CallerCount(0)]
		public unsafe override void CheckCanAddToCollection(ConstraintCollection constraints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraints);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_CheckCanAddToCollection_Internal_Virtual_Void_ConstraintCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00032AD8 File Offset: 0x00030CD8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fThrowException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_CanBeRemovedFromCollection_Internal_Virtual_Boolean_ConstraintCollection_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00032B40 File Offset: 0x00030D40
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 904874, RefRangeEnd = 904879, XrefRangeStart = 904869, XrefRangeEnd = 904874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsKeyNull(Il2CppReferenceArray<Object> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_IsKeyNull_Internal_Boolean_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00032B90 File Offset: 0x00030D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904879, XrefRangeEnd = 904902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsConstraintViolated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_IsConstraintViolated_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00032BD8 File Offset: 0x00030DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904902, XrefRangeEnd = 904916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanEnableConstraint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_CanEnableConstraint_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00032C20 File Offset: 0x00030E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904916, XrefRangeEnd = 904928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CascadeCommit(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_CascadeCommit_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00032C64 File Offset: 0x00030E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904966, RefRangeEnd = 904967, XrefRangeStart = 904928, XrefRangeEnd = 904966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CascadeDelete(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_CascadeDelete_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00032CA8 File Offset: 0x00030EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904985, RefRangeEnd = 904986, XrefRangeStart = 904967, XrefRangeEnd = 904985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CascadeRollback(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_CascadeRollback_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00032CEC File Offset: 0x00030EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905023, RefRangeEnd = 905024, XrefRangeStart = 904986, XrefRangeEnd = 905023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CascadeUpdate(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_CascadeUpdate_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00032D30 File Offset: 0x00030F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905024, RefRangeEnd = 905025, XrefRangeStart = 905024, XrefRangeEnd = 905024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCanClearParentTable(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_CheckCanClearParentTable_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00032D74 File Offset: 0x00030F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905028, RefRangeEnd = 905029, XrefRangeStart = 905025, XrefRangeEnd = 905028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCanRemoveParentRow(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_CheckCanRemoveParentRow_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00032DB8 File Offset: 0x00030FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905050, RefRangeEnd = 905051, XrefRangeStart = 905029, XrefRangeEnd = 905050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCascade(DataRow row, DataRowAction action)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_CheckCascade_Internal_Void_DataRow_DataRowAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00032E08 File Offset: 0x00031008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905051, XrefRangeEnd = 905070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CheckConstraint(DataRow childRow, DataRowAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childRow);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_CheckConstraint_Internal_Virtual_Void_DataRow_DataRowAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00032E64 File Offset: 0x00031064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 905086, RefRangeEnd = 905088, XrefRangeStart = 905070, XrefRangeEnd = 905086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NonVirtualCheckState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_NonVirtualCheckState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00032E98 File Offset: 0x00031098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905088, XrefRangeEnd = 905089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CheckState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_CheckState_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00032ED4 File Offset: 0x000310D4
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x00032F1C File Offset: 0x0003111C
		public unsafe virtual AcceptRejectRule AcceptRejectRule
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905089, XrefRangeEnd = 905090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_get_AcceptRejectRule_Public_Virtual_New_get_AcceptRejectRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_set_AcceptRejectRule_Public_Virtual_New_set_Void_AcceptRejectRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00032F68 File Offset: 0x00031168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905090, XrefRangeEnd = 905091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsColumn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_ContainsColumn_Internal_Virtual_Boolean_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00032FC0 File Offset: 0x000311C0
		[CallerCount(0)]
		public unsafe override Constraint Clone(DataSet destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constraint>(intPtr3) : null;
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0003301C File Offset: 0x0003121C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905091, XrefRangeEnd = 905138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Constraint Clone(DataSet destination, bool ignorNSforTableLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignorNSforTableLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constraint>(intPtr3) : null;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00033088 File Offset: 0x00031288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 905170, RefRangeEnd = 905172, XrefRangeStart = 905138, XrefRangeEnd = 905170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForeignKeyConstraint Clone(DataTable destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_Clone_Internal_ForeignKeyConstraint_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ForeignKeyConstraint>(intPtr3) : null;
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000330D8 File Offset: 0x000312D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 905180, RefRangeEnd = 905183, XrefRangeStart = 905172, XrefRangeEnd = 905180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Create(string relationName, Il2CppReferenceArray<DataColumn> parentColumns, Il2CppReferenceArray<DataColumn> childColumns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relationName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentColumns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childColumns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_Create_Private_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00033140 File Offset: 0x00031340
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00033188 File Offset: 0x00031388
		public unsafe virtual Rule DeleteRule
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905183, XrefRangeEnd = 905184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_get_DeleteRule_Public_Virtual_New_get_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_set_DeleteRule_Public_Virtual_New_set_Void_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000331D4 File Offset: 0x000313D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905184, XrefRangeEnd = 905192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0003322C File Offset: 0x0003142C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00033274 File Offset: 0x00031474
		public unsafe virtual Il2CppReferenceArray<DataColumn> RelatedColumns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905192, XrefRangeEnd = 905194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_get_RelatedColumns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x000332C0 File Offset: 0x000314C0
		public unsafe Il2CppReferenceArray<DataColumn> RelatedColumnsReference
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 905195, RefRangeEnd = 905204, XrefRangeStart = 905194, XrefRangeEnd = 905195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_get_RelatedColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00033300 File Offset: 0x00031500
		public unsafe DataKey ParentKey
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 905195, RefRangeEnd = 905204, XrefRangeStart = 905195, XrefRangeEnd = 905204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_get_ParentKey_Internal_get_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DataKey(intPtr);
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00033338 File Offset: 0x00031538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905206, RefRangeEnd = 905207, XrefRangeStart = 905204, XrefRangeEnd = 905206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRelation FindParentRelation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraint.NativeMethodInfoPtr_FindParentRelation_Internal_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr3) : null;
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00033378 File Offset: 0x00031578
		public unsafe virtual DataTable RelatedTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905207, XrefRangeEnd = 905209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_get_RelatedTable_Public_Virtual_New_get_DataTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x000333C4 File Offset: 0x000315C4
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x0003340C File Offset: 0x0003160C
		public unsafe virtual Rule UpdateRule
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905209, XrefRangeEnd = 905210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_get_UpdateRule_Public_Virtual_New_get_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraint.NativeMethodInfoPtr_set_UpdateRule_Public_Virtual_New_set_Void_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00004E59 File Offset: 0x00003059
		public ForeignKeyConstraint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00033458 File Offset: 0x00031658
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00004E62 File Offset: 0x00003062
		public unsafe Rule _deleteRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__deleteRule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__deleteRule)) = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00033480 File Offset: 0x00031680
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00004E7D File Offset: 0x0000307D
		public unsafe Rule _updateRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__updateRule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__updateRule)) = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x000334A8 File Offset: 0x000316A8
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00004E98 File Offset: 0x00003098
		public unsafe AcceptRejectRule _acceptRejectRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__acceptRejectRule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__acceptRejectRule)) = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x000334D0 File Offset: 0x000316D0
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00004EB3 File Offset: 0x000030B3
		public DataKey _childKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__childKey);
				return new DataKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataKey>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__childKey), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataKey>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00033500 File Offset: 0x00031700
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x00004EE1 File Offset: 0x000030E1
		public DataKey _parentKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__parentKey);
				return new DataKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataKey>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__parentKey), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataKey>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x00033530 File Offset: 0x00031730
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00004F0F File Offset: 0x0000310F
		public unsafe string _constraintName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__constraintName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__constraintName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x00033558 File Offset: 0x00031758
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x00004F2E File Offset: 0x0000312E
		public unsafe Il2CppStringArray _parentColumnNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__parentColumnNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__parentColumnNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00033588 File Offset: 0x00031788
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x00004F4D File Offset: 0x0000314D
		public unsafe Il2CppStringArray _childColumnNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__childColumnNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__childColumnNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000335B8 File Offset: 0x000317B8
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x00004F6C File Offset: 0x0000316C
		public unsafe string _parentTableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__parentTableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForeignKeyConstraint.NativeFieldInfoPtr__parentTableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeFieldInfoPtr__deleteRule;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeFieldInfoPtr__updateRule;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeFieldInfoPtr__acceptRejectRule;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeFieldInfoPtr__childKey;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeFieldInfoPtr__parentKey;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr__constraintName;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeFieldInfoPtr__parentColumnNames;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeFieldInfoPtr__childColumnNames;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr__parentTableName;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppStringArray_Il2CppStringArray_AcceptRejectRule_Rule_Rule_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildKey_Internal_get_DataKey_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_get_Columns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Public_Virtual_get_DataTable_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentColumnNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildColumnNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAddToCollection_Internal_Virtual_Void_ConstraintCollection_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_CanBeRemovedFromCollection_Internal_Virtual_Boolean_ConstraintCollection_Boolean_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_IsKeyNull_Internal_Boolean_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_IsConstraintViolated_Internal_Virtual_Boolean_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_CanEnableConstraint_Internal_Virtual_Boolean_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_CascadeCommit_Internal_Void_DataRow_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_CascadeDelete_Internal_Void_DataRow_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_CascadeRollback_Internal_Void_DataRow_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_CascadeUpdate_Internal_Void_DataRow_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanClearParentTable_Internal_Void_DataTable_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanRemoveParentRow_Internal_Void_DataRow_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_CheckCascade_Internal_Void_DataRow_DataRowAction_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_CheckConstraint_Internal_Virtual_Void_DataRow_DataRowAction_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_NonVirtualCheckState_Private_Void_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_CheckState_Internal_Virtual_Void_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_get_AcceptRejectRule_Public_Virtual_New_get_AcceptRejectRule_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_set_AcceptRejectRule_Public_Virtual_New_set_Void_AcceptRejectRule_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_ContainsColumn_Internal_Virtual_Boolean_DataColumn_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_Boolean_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_ForeignKeyConstraint_DataTable_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Void_String_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteRule_Public_Virtual_New_get_Rule_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteRule_Public_Virtual_New_set_Void_Rule_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_get_RelatedColumns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_get_RelatedColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentKey_Internal_get_DataKey_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_FindParentRelation_Internal_DataRelation_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_get_RelatedTable_Public_Virtual_New_get_DataTable_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateRule_Public_Virtual_New_get_Rule_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateRule_Public_Virtual_New_set_Void_Rule_0;
	}
}
