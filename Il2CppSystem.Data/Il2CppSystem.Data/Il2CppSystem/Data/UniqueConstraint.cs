using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000079 RID: 121
	public class UniqueConstraint : Constraint
	{
		// Token: 0x06000B52 RID: 2898 RVA: 0x00039E78 File Offset: 0x00038078
		// Note: this type is marked as 'beforefieldinit'.
		static UniqueConstraint()
		{
			Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "UniqueConstraint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr);
			UniqueConstraint.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, "_key");
			UniqueConstraint.NativeFieldInfoPtr__constraintIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, "_constraintIndex");
			UniqueConstraint.NativeFieldInfoPtr__bPrimaryKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, "_bPrimaryKey");
			UniqueConstraint.NativeFieldInfoPtr__constraintName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, "_constraintName");
			UniqueConstraint.NativeFieldInfoPtr__columnNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, "_columnNames");
			UniqueConstraint.NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665168);
			UniqueConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665169);
			UniqueConstraint.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665170);
			UniqueConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665171);
			UniqueConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665172);
			UniqueConstraint.NativeMethodInfoPtr_get_ColumnNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665173);
			UniqueConstraint.NativeMethodInfoPtr_get_ConstraintIndex_Internal_get_Index_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665174);
			UniqueConstraint.NativeMethodInfoPtr_ConstraintIndexClear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665175);
			UniqueConstraint.NativeMethodInfoPtr_ConstraintIndexInitialize_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665176);
			UniqueConstraint.NativeMethodInfoPtr_CheckState_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665177);
			UniqueConstraint.NativeMethodInfoPtr_NonVirtualCheckState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665178);
			UniqueConstraint.NativeMethodInfoPtr_CheckCanAddToCollection_Internal_Virtual_Void_ConstraintCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665179);
			UniqueConstraint.NativeMethodInfoPtr_CanBeRemovedFromCollection_Internal_Virtual_Boolean_ConstraintCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665180);
			UniqueConstraint.NativeMethodInfoPtr_CanEnableConstraint_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665181);
			UniqueConstraint.NativeMethodInfoPtr_IsConstraintViolated_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665182);
			UniqueConstraint.NativeMethodInfoPtr_CheckConstraint_Internal_Virtual_Void_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665183);
			UniqueConstraint.NativeMethodInfoPtr_ContainsColumn_Internal_Virtual_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665184);
			UniqueConstraint.NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665185);
			UniqueConstraint.NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665186);
			UniqueConstraint.NativeMethodInfoPtr_Clone_Internal_UniqueConstraint_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665187);
			UniqueConstraint.NativeMethodInfoPtr_get_Columns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665188);
			UniqueConstraint.NativeMethodInfoPtr_get_ColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665189);
			UniqueConstraint.NativeMethodInfoPtr_get_IsPrimaryKey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665190);
			UniqueConstraint.NativeMethodInfoPtr_Create_Private_Void_String_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665191);
			UniqueConstraint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665192);
			UniqueConstraint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665193);
			UniqueConstraint.NativeMethodInfoPtr_set_InCollection_Internal_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665194);
			UniqueConstraint.NativeMethodInfoPtr_get_Key_Internal_get_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665195);
			UniqueConstraint.NativeMethodInfoPtr_get_Table_Public_Virtual_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr, 100665196);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0003A150 File Offset: 0x00038350
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907729, RefRangeEnd = 907731, XrefRangeStart = 907718, XrefRangeEnd = 907729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniqueConstraint(DataColumn column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0003A19C File Offset: 0x0003839C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 907733, RefRangeEnd = 907736, XrefRangeStart = 907731, XrefRangeEnd = 907733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniqueConstraint(string name, Il2CppReferenceArray<DataColumn> columns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0003A1FC File Offset: 0x000383FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907738, RefRangeEnd = 907739, XrefRangeStart = 907736, XrefRangeEnd = 907738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniqueConstraint(Il2CppReferenceArray<DataColumn> columns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0003A248 File Offset: 0x00038448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907739, XrefRangeEnd = 907742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniqueConstraint(string name, Il2CppStringArray columnNames, bool isPrimaryKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columnNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPrimaryKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0003A2B4 File Offset: 0x000384B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907744, RefRangeEnd = 907745, XrefRangeStart = 907742, XrefRangeEnd = 907744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniqueConstraint(string name, Il2CppReferenceArray<DataColumn> columns, bool isPrimaryKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniqueConstraint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPrimaryKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0003A320 File Offset: 0x00038520
		public unsafe Il2CppStringArray ColumnNames
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 907746, RefRangeEnd = 907747, XrefRangeStart = 907745, XrefRangeEnd = 907746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr_get_ColumnNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0003A360 File Offset: 0x00038560
		public unsafe Index ConstraintIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr_get_ConstraintIndex_Internal_get_Index_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Index>(intPtr3) : null;
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0003A3A0 File Offset: 0x000385A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907749, RefRangeEnd = 907750, XrefRangeStart = 907747, XrefRangeEnd = 907749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConstraintIndexClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr_ConstraintIndexClear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0003A3D4 File Offset: 0x000385D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907753, RefRangeEnd = 907755, XrefRangeStart = 907750, XrefRangeEnd = 907753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConstraintIndexInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr_ConstraintIndexInitialize_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0003A408 File Offset: 0x00038608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907755, XrefRangeEnd = 907756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CheckState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_CheckState_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0003A444 File Offset: 0x00038644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NonVirtualCheckState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr_NonVirtualCheckState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0003A478 File Offset: 0x00038678
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CheckCanAddToCollection(ConstraintCollection constraints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraints);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_CheckCanAddToCollection_Internal_Virtual_Void_ConstraintCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0003A4C8 File Offset: 0x000386C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907756, XrefRangeEnd = 907765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_CanBeRemovedFromCollection_Internal_Virtual_Boolean_ConstraintCollection_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0003A530 File Offset: 0x00038730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907765, XrefRangeEnd = 907766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanEnableConstraint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_CanEnableConstraint_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0003A578 File Offset: 0x00038778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907766, XrefRangeEnd = 907786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsConstraintViolated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_IsConstraintViolated_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0003A5C0 File Offset: 0x000387C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907786, XrefRangeEnd = 907787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CheckConstraint(DataRow row, DataRowAction action)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_CheckConstraint_Internal_Virtual_Void_DataRow_DataRowAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0003A61C File Offset: 0x0003881C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907787, XrefRangeEnd = 907788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsColumn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_ContainsColumn_Internal_Virtual_Boolean_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0003A674 File Offset: 0x00038874
		[CallerCount(0)]
		public unsafe override Constraint Clone(DataSet destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constraint>(intPtr3) : null;
			}
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0003A6D0 File Offset: 0x000388D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907788, XrefRangeEnd = 907825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constraint>(intPtr3) : null;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0003A73C File Offset: 0x0003893C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907850, RefRangeEnd = 907852, XrefRangeStart = 907825, XrefRangeEnd = 907850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniqueConstraint Clone(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr_Clone_Internal_UniqueConstraint_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniqueConstraint>(intPtr3) : null;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0003A78C File Offset: 0x0003898C
		public unsafe virtual Il2CppReferenceArray<DataColumn> Columns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907852, XrefRangeEnd = 907853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_get_Columns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0003A7D8 File Offset: 0x000389D8
		public unsafe Il2CppReferenceArray<DataColumn> ColumnsReference
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr_get_ColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0003A818 File Offset: 0x00038A18
		public unsafe bool IsPrimaryKey
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 907853, RefRangeEnd = 907856, XrefRangeStart = 907853, XrefRangeEnd = 907853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr_get_IsPrimaryKey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0003A854 File Offset: 0x00038A54
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 907861, RefRangeEnd = 907867, XrefRangeStart = 907856, XrefRangeEnd = 907861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Create(string constraintName, Il2CppReferenceArray<DataColumn> columns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(constraintName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr_Create_Private_Void_String_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0003A8A8 File Offset: 0x00038AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907867, XrefRangeEnd = 907870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object key2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0003A900 File Offset: 0x00038B00
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002DA RID: 730
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x0003A948 File Offset: 0x00038B48
		public unsafe override bool InCollection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907870, XrefRangeEnd = 907871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_set_InCollection_Internal_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0003A994 File Offset: 0x00038B94
		public unsafe DataKey Key
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueConstraint.NativeMethodInfoPtr_get_Key_Internal_get_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DataKey(intPtr);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0003A9CC File Offset: 0x00038BCC
		public unsafe override DataTable Table
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907871, XrefRangeEnd = 907872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniqueConstraint.NativeMethodInfoPtr_get_Table_Public_Virtual_get_DataTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0000574F File Offset: 0x0000394F
		public UniqueConstraint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0003AA18 File Offset: 0x00038C18
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x00005758 File Offset: 0x00003958
		public DataKey _key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueConstraint.NativeFieldInfoPtr__key);
				return new DataKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataKey>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueConstraint.NativeFieldInfoPtr__key), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataKey>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0003AA48 File Offset: 0x00038C48
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x00005786 File Offset: 0x00003986
		public unsafe Index _constraintIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueConstraint.NativeFieldInfoPtr__constraintIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Index>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueConstraint.NativeFieldInfoPtr__constraintIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0003AA78 File Offset: 0x00038C78
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x000057A5 File Offset: 0x000039A5
		public unsafe bool _bPrimaryKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueConstraint.NativeFieldInfoPtr__bPrimaryKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueConstraint.NativeFieldInfoPtr__bPrimaryKey)) = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0003AAA0 File Offset: 0x00038CA0
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x000057C0 File Offset: 0x000039C0
		public unsafe string _constraintName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueConstraint.NativeFieldInfoPtr__constraintName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueConstraint.NativeFieldInfoPtr__constraintName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0003AAC8 File Offset: 0x00038CC8
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x000057DF File Offset: 0x000039DF
		public unsafe Il2CppStringArray _columnNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueConstraint.NativeFieldInfoPtr__columnNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueConstraint.NativeFieldInfoPtr__columnNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr__constraintIndex;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr__bPrimaryKey;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr__constraintName;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr__columnNames;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_Boolean_0;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_DataColumn_Boolean_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnNames_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstraintIndex_Internal_get_Index_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_ConstraintIndexClear_Internal_Void_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_ConstraintIndexInitialize_Internal_Void_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_CheckState_Internal_Virtual_Void_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_NonVirtualCheckState_Private_Void_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAddToCollection_Internal_Virtual_Void_ConstraintCollection_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_CanBeRemovedFromCollection_Internal_Virtual_Boolean_ConstraintCollection_Boolean_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_CanEnableConstraint_Internal_Virtual_Boolean_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_IsConstraintViolated_Internal_Virtual_Boolean_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_CheckConstraint_Internal_Virtual_Void_DataRow_DataRowAction_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_ContainsColumn_Internal_Virtual_Boolean_DataColumn_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_Constraint_DataSet_Boolean_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_UniqueConstraint_DataTable_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_get_Columns_Public_Virtual_New_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPrimaryKey_Public_get_Boolean_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Void_String_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_set_InCollection_Internal_Virtual_set_Void_Boolean_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Internal_get_DataKey_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Public_Virtual_get_DataTable_0;
	}
}
