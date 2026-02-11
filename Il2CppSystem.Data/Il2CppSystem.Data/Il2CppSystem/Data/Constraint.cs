using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000022 RID: 34
	public class Constraint : Object
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x0001D64C File Offset: 0x0001B84C
		// Note: this type is marked as 'beforefieldinit'.
		static Constraint()
		{
			Il2CppClassPointerStore<Constraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "Constraint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constraint>.NativeClassPtr);
			Constraint.NativeFieldInfoPtr__schemaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constraint>.NativeClassPtr, "_schemaName");
			Constraint.NativeFieldInfoPtr__inCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constraint>.NativeClassPtr, "_inCollection");
			Constraint.NativeFieldInfoPtr__dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constraint>.NativeClassPtr, "_dataSet");
			Constraint.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constraint>.NativeClassPtr, "_name");
			Constraint.NativeFieldInfoPtr__extendedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constraint>.NativeClassPtr, "_extendedProperties");
			Constraint.NativeMethodInfoPtr_get_ConstraintName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664113);
			Constraint.NativeMethodInfoPtr_set_ConstraintName_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664114);
			Constraint.NativeMethodInfoPtr_get_SchemaName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664115);
			Constraint.NativeMethodInfoPtr_set_SchemaName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664116);
			Constraint.NativeMethodInfoPtr_get_InCollection_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664117);
			Constraint.NativeMethodInfoPtr_set_InCollection_Internal_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664118);
			Constraint.NativeMethodInfoPtr_get_Table_Public_Abstract_Virtual_New_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664119);
			Constraint.NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664120);
			Constraint.NativeMethodInfoPtr_ContainsColumn_Internal_Abstract_Virtual_New_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664121);
			Constraint.NativeMethodInfoPtr_CanEnableConstraint_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664122);
			Constraint.NativeMethodInfoPtr_Clone_Internal_Abstract_Virtual_New_Constraint_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664123);
			Constraint.NativeMethodInfoPtr_Clone_Internal_Abstract_Virtual_New_Constraint_DataSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664124);
			Constraint.NativeMethodInfoPtr_CheckConstraint_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664125);
			Constraint.NativeMethodInfoPtr_CheckCanAddToCollection_Internal_Abstract_Virtual_New_Void_ConstraintCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664126);
			Constraint.NativeMethodInfoPtr_CanBeRemovedFromCollection_Internal_Abstract_Virtual_New_Boolean_ConstraintCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664127);
			Constraint.NativeMethodInfoPtr_CheckConstraint_Internal_Abstract_Virtual_New_Void_DataRow_DataRowAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664128);
			Constraint.NativeMethodInfoPtr_CheckState_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664129);
			Constraint.NativeMethodInfoPtr_CheckStateForProperty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664130);
			Constraint.NativeMethodInfoPtr_get__DataSet_Protected_Virtual_New_get_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664131);
			Constraint.NativeMethodInfoPtr_IsConstraintViolated_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664132);
			Constraint.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664133);
			Constraint.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constraint>.NativeClassPtr, 100664134);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0001D898 File Offset: 0x0001BA98
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x0001D8DC File Offset: 0x0001BADC
		public unsafe virtual string ConstraintName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_get_ConstraintName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898114, XrefRangeEnd = 898125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_set_ConstraintName_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0001D92C File Offset: 0x0001BB2C
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x0001D964 File Offset: 0x0001BB64
		public unsafe string SchemaName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898125, XrefRangeEnd = 898126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constraint.NativeMethodInfoPtr_get_SchemaName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 898128, RefRangeEnd = 898129, XrefRangeStart = 898126, XrefRangeEnd = 898128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constraint.NativeMethodInfoPtr_set_SchemaName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0001D9A8 File Offset: 0x0001BBA8
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
		public unsafe virtual bool InCollection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_get_InCollection_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 898132, RefRangeEnd = 898133, XrefRangeStart = 898129, XrefRangeEnd = 898132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_set_InCollection_Internal_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0001DA3C File Offset: 0x0001BC3C
		public unsafe virtual DataTable Table
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_get_Table_Public_Abstract_Virtual_New_get_DataTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0001DA88 File Offset: 0x0001BC88
		public unsafe PropertyCollection ExtendedProperties
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 898138, RefRangeEnd = 898159, XrefRangeStart = 898133, XrefRangeEnd = 898138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constraint.NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001DAC8 File Offset: 0x0001BCC8
		[CallerCount(0)]
		public unsafe virtual bool ContainsColumn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_ContainsColumn_Internal_Abstract_Virtual_New_Boolean_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001DB20 File Offset: 0x0001BD20
		[CallerCount(0)]
		public unsafe virtual bool CanEnableConstraint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_CanEnableConstraint_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0001DB68 File Offset: 0x0001BD68
		[CallerCount(0)]
		public unsafe virtual Constraint Clone(DataSet destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_Clone_Internal_Abstract_Virtual_New_Constraint_DataSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constraint>(intPtr3) : null;
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001DBC4 File Offset: 0x0001BDC4
		[CallerCount(0)]
		public unsafe virtual Constraint Clone(DataSet destination, bool ignoreNSforTableLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreNSforTableLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_Clone_Internal_Abstract_Virtual_New_Constraint_DataSet_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constraint>(intPtr3) : null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001DC30 File Offset: 0x0001BE30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898159, RefRangeEnd = 898160, XrefRangeStart = 898159, XrefRangeEnd = 898159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckConstraint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constraint.NativeMethodInfoPtr_CheckConstraint_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0001DC64 File Offset: 0x0001BE64
		[CallerCount(0)]
		public unsafe virtual void CheckCanAddToCollection(ConstraintCollection constraint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_CheckCanAddToCollection_Internal_Abstract_Virtual_New_Void_ConstraintCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0001DCB4 File Offset: 0x0001BEB4
		[CallerCount(0)]
		public unsafe virtual bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fThrowException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_CanBeRemovedFromCollection_Internal_Abstract_Virtual_New_Boolean_ConstraintCollection_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0001DD1C File Offset: 0x0001BF1C
		[CallerCount(0)]
		public unsafe virtual void CheckConstraint(DataRow row, DataRowAction action)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_CheckConstraint_Internal_Abstract_Virtual_New_Void_DataRow_DataRowAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001DD78 File Offset: 0x0001BF78
		[CallerCount(0)]
		public unsafe virtual void CheckState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_CheckState_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0001DDB4 File Offset: 0x0001BFB4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 898168, RefRangeEnd = 898189, XrefRangeStart = 898160, XrefRangeEnd = 898168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStateForProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constraint.NativeMethodInfoPtr_CheckStateForProperty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0001DDE8 File Offset: 0x0001BFE8
		public unsafe virtual DataSet _DataSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_get__DataSet_Protected_Virtual_New_get_DataSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr3) : null;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0001DE34 File Offset: 0x0001C034
		[CallerCount(0)]
		public unsafe virtual bool IsConstraintViolated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_IsConstraintViolated_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001DE7C File Offset: 0x0001C07C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 660290, RefRangeEnd = 660296, XrefRangeStart = 660290, XrefRangeEnd = 660296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constraint.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 898195, RefRangeEnd = 898206, XrefRangeStart = 898189, XrefRangeEnd = 898195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constraint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constraint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constraint.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000347A File Offset: 0x0000167A
		public Constraint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0001DEFC File Offset: 0x0001C0FC
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00003483 File Offset: 0x00001683
		public unsafe string _schemaName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constraint.NativeFieldInfoPtr__schemaName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constraint.NativeFieldInfoPtr__schemaName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0001DF24 File Offset: 0x0001C124
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x000034A2 File Offset: 0x000016A2
		public unsafe bool _inCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constraint.NativeFieldInfoPtr__inCollection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constraint.NativeFieldInfoPtr__inCollection)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0001DF4C File Offset: 0x0001C14C
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x000034BD File Offset: 0x000016BD
		public unsafe DataSet _dataSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constraint.NativeFieldInfoPtr__dataSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constraint.NativeFieldInfoPtr__dataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0001DF7C File Offset: 0x0001C17C
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x000034DC File Offset: 0x000016DC
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constraint.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constraint.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0001DFA4 File Offset: 0x0001C1A4
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x000034FB File Offset: 0x000016FB
		public unsafe PropertyCollection _extendedProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constraint.NativeFieldInfoPtr__extendedProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constraint.NativeFieldInfoPtr__extendedProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr__schemaName;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr__inCollection;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr__dataSet;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr__extendedProperties;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstraintName_Public_Virtual_New_get_String_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_set_ConstraintName_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaName_Internal_get_String_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaName_Internal_set_Void_String_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_get_InCollection_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_set_InCollection_Internal_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Public_Abstract_Virtual_New_get_DataTable_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtendedProperties_Public_get_PropertyCollection_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_ContainsColumn_Internal_Abstract_Virtual_New_Boolean_DataColumn_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_CanEnableConstraint_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Abstract_Virtual_New_Constraint_DataSet_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Abstract_Virtual_New_Constraint_DataSet_Boolean_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_CheckConstraint_Internal_Void_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAddToCollection_Internal_Abstract_Virtual_New_Void_ConstraintCollection_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_CanBeRemovedFromCollection_Internal_Abstract_Virtual_New_Boolean_ConstraintCollection_Boolean_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_CheckConstraint_Internal_Abstract_Virtual_New_Void_DataRow_DataRowAction_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_CheckState_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_CheckStateForProperty_Protected_Void_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_get__DataSet_Protected_Virtual_New_get_DataSet_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_IsConstraintViolated_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
