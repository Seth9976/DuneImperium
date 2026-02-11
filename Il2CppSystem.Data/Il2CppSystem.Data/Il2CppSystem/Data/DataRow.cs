using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Data
{
	// Token: 0x02000032 RID: 50
	public class DataRow : Object
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x00024010 File Offset: 0x00022210
		// Note: this type is marked as 'beforefieldinit'.
		static DataRow()
		{
			Il2CppClassPointerStore<DataRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataRow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRow>.NativeClassPtr);
			DataRow.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_table");
			DataRow.NativeFieldInfoPtr__columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_columns");
			DataRow.NativeFieldInfoPtr__oldRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_oldRecord");
			DataRow.NativeFieldInfoPtr__newRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_newRecord");
			DataRow.NativeFieldInfoPtr__tempRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_tempRecord");
			DataRow.NativeFieldInfoPtr__rowID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_rowID");
			DataRow.NativeFieldInfoPtr__action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_action");
			DataRow.NativeFieldInfoPtr__inChangingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_inChangingEvent");
			DataRow.NativeFieldInfoPtr__inDeletingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_inDeletingEvent");
			DataRow.NativeFieldInfoPtr__inCascade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_inCascade");
			DataRow.NativeFieldInfoPtr__lastChangedColumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_lastChangedColumn");
			DataRow.NativeFieldInfoPtr__countColumnChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_countColumnChange");
			DataRow.NativeFieldInfoPtr__error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_error");
			DataRow.NativeFieldInfoPtr__rbTreeNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_rbTreeNodeId");
			DataRow.NativeFieldInfoPtr_s_objectTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "s_objectTypeCount");
			DataRow.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRow>.NativeClassPtr, "_objectID");
			DataRow.NativeMethodInfoPtr__ctor_FamOrAssem_Void_DataRowBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664366);
			DataRow.NativeMethodInfoPtr_get_LastChangedColumn_Internal_get_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664367);
			DataRow.NativeMethodInfoPtr_set_LastChangedColumn_Internal_set_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664368);
			DataRow.NativeMethodInfoPtr_get_HasPropertyChanged_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664369);
			DataRow.NativeMethodInfoPtr_get_RBTreeNodeId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664370);
			DataRow.NativeMethodInfoPtr_set_RBTreeNodeId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664371);
			DataRow.NativeMethodInfoPtr_get_RowError_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664372);
			DataRow.NativeMethodInfoPtr_set_RowError_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664373);
			DataRow.NativeMethodInfoPtr_RowErrorChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664374);
			DataRow.NativeMethodInfoPtr_get_rowID_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664375);
			DataRow.NativeMethodInfoPtr_set_rowID_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664376);
			DataRow.NativeMethodInfoPtr_get_RowState_Public_get_DataRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664377);
			DataRow.NativeMethodInfoPtr_get_Table_Public_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664378);
			DataRow.NativeMethodInfoPtr_CheckForLoops_Internal_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664379);
			DataRow.NativeMethodInfoPtr_GetNestedParentCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664380);
			DataRow.NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664381);
			DataRow.NativeMethodInfoPtr_get_Item_Public_get_Object_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664382);
			DataRow.NativeMethodInfoPtr_set_Item_Public_set_Void_DataColumn_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664383);
			DataRow.NativeMethodInfoPtr_get_Item_Public_get_Object_DataColumn_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664384);
			DataRow.NativeMethodInfoPtr_set_ItemArray_Public_set_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664385);
			DataRow.NativeMethodInfoPtr_AcceptChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664386);
			DataRow.NativeMethodInfoPtr_BeginEdit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664387);
			DataRow.NativeMethodInfoPtr_BeginEditInternal_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664388);
			DataRow.NativeMethodInfoPtr_CancelEdit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664389);
			DataRow.NativeMethodInfoPtr_CheckColumn_Private_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664390);
			DataRow.NativeMethodInfoPtr_CheckInTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664391);
			DataRow.NativeMethodInfoPtr_Delete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664392);
			DataRow.NativeMethodInfoPtr_EndEdit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664393);
			DataRow.NativeMethodInfoPtr_SetColumnError_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664394);
			DataRow.NativeMethodInfoPtr_SetColumnError_Public_Void_DataColumn_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664395);
			DataRow.NativeMethodInfoPtr_GetColumnError_Public_String_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664396);
			DataRow.NativeMethodInfoPtr_ClearErrors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664397);
			DataRow.NativeMethodInfoPtr_ClearError_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664398);
			DataRow.NativeMethodInfoPtr_get_HasErrors_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664399);
			DataRow.NativeMethodInfoPtr_GetColumnsInError_Public_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664400);
			DataRow.NativeMethodInfoPtr_GetChildRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664401);
			DataRow.NativeMethodInfoPtr_GetChildRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664402);
			DataRow.NativeMethodInfoPtr_GetDataColumn_Internal_DataColumn_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664403);
			DataRow.NativeMethodInfoPtr_GetParentRow_Public_DataRow_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664404);
			DataRow.NativeMethodInfoPtr_GetParentRow_Public_DataRow_DataRelation_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664405);
			DataRow.NativeMethodInfoPtr_GetNestedParentRow_Internal_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664406);
			DataRow.NativeMethodInfoPtr_GetParentRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664407);
			DataRow.NativeMethodInfoPtr_GetParentRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664408);
			DataRow.NativeMethodInfoPtr_GetColumnValues_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664409);
			DataRow.NativeMethodInfoPtr_GetColumnValues_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_DataColumn_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664410);
			DataRow.NativeMethodInfoPtr_GetKeyValues_Internal_Il2CppReferenceArray_1_Object_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664411);
			DataRow.NativeMethodInfoPtr_GetKeyValues_Internal_Il2CppReferenceArray_1_Object_DataKey_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664412);
			DataRow.NativeMethodInfoPtr_GetCurrentRecordNo_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664413);
			DataRow.NativeMethodInfoPtr_GetDefaultRecord_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664414);
			DataRow.NativeMethodInfoPtr_GetOriginalRecordNo_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664415);
			DataRow.NativeMethodInfoPtr_GetProposedRecordNo_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664416);
			DataRow.NativeMethodInfoPtr_GetRecordFromVersion_Internal_Int32_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664417);
			DataRow.NativeMethodInfoPtr_GetDefaultRowVersion_Internal_DataRowVersion_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664418);
			DataRow.NativeMethodInfoPtr_GetRecordState_Internal_DataViewRowState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664419);
			DataRow.NativeMethodInfoPtr_HasKeyChanged_Internal_Boolean_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664420);
			DataRow.NativeMethodInfoPtr_HasKeyChanged_Internal_Boolean_DataKey_DataRowVersion_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664421);
			DataRow.NativeMethodInfoPtr_HasVersion_Public_Boolean_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664422);
			DataRow.NativeMethodInfoPtr_HaveValuesChanged_Internal_Boolean_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664423);
			DataRow.NativeMethodInfoPtr_HaveValuesChanged_Internal_Boolean_Il2CppReferenceArray_1_DataColumn_DataRowVersion_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664424);
			DataRow.NativeMethodInfoPtr_RejectChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664425);
			DataRow.NativeMethodInfoPtr_ResetLastChangedColumn_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664426);
			DataRow.NativeMethodInfoPtr_SetKeyValues_Internal_Void_DataKey_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664427);
			DataRow.NativeMethodInfoPtr_SetNestedParentRow_Internal_Void_DataRow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664428);
			DataRow.NativeMethodInfoPtr_SetParentRowToDBNull_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664429);
			DataRow.NativeMethodInfoPtr_SetParentRowToDBNull_Internal_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664430);
			DataRow.NativeMethodInfoPtr_CopyValuesIntoStore_Internal_Int32_ArrayList_ArrayList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRow>.NativeClassPtr, 100664431);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000246A8 File Offset: 0x000228A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900422, RefRangeEnd = 900423, XrefRangeStart = 900415, XrefRangeEnd = 900422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow(DataRowBuilder builder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr__ctor_FamOrAssem_Void_DataRowBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x000246F4 File Offset: 0x000228F4
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00024734 File Offset: 0x00022934
		public unsafe DataColumn LastChangedColumn
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 900423, RefRangeEnd = 900424, XrefRangeStart = 900423, XrefRangeEnd = 900423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_get_LastChangedColumn_Internal_get_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 900425, RefRangeEnd = 900427, XrefRangeStart = 900424, XrefRangeEnd = 900425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_set_LastChangedColumn_Internal_set_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00024778 File Offset: 0x00022978
		public unsafe bool HasPropertyChanged
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 900427, RefRangeEnd = 900428, XrefRangeStart = 900427, XrefRangeEnd = 900427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_get_HasPropertyChanged_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x000247B4 File Offset: 0x000229B4
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x000247F0 File Offset: 0x000229F0
		public unsafe int RBTreeNodeId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_get_RBTreeNodeId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 900437, RefRangeEnd = 900441, XrefRangeStart = 900428, XrefRangeEnd = 900437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_set_RBTreeNodeId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00024830 File Offset: 0x00022A30
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00024868 File Offset: 0x00022A68
		public unsafe string RowError
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 900443, RefRangeEnd = 900447, XrefRangeStart = 900441, XrefRangeEnd = 900443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_get_RowError_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 900463, RefRangeEnd = 900470, XrefRangeStart = 900447, XrefRangeEnd = 900463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_set_RowError_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000248AC File Offset: 0x00022AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900470, XrefRangeEnd = 900472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RowErrorChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_RowErrorChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x000248E0 File Offset: 0x00022AE0
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x0002491C File Offset: 0x00022B1C
		public unsafe long rowID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_get_rowID_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 900473, RefRangeEnd = 900478, XrefRangeStart = 900472, XrefRangeEnd = 900473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_set_rowID_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0002495C File Offset: 0x00022B5C
		public unsafe DataRowState RowState
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 900480, RefRangeEnd = 900523, XrefRangeStart = 900478, XrefRangeEnd = 900480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_get_RowState_Public_get_DataRowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00024998 File Offset: 0x00022B98
		public unsafe DataTable Table
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_get_Table_Public_get_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000249D8 File Offset: 0x00022BD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 900525, RefRangeEnd = 900531, XrefRangeStart = 900523, XrefRangeEnd = 900525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForLoops(DataRelation rel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_CheckForLoops_Internal_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00024A1C File Offset: 0x00022C1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 900534, RefRangeEnd = 900536, XrefRangeStart = 900531, XrefRangeEnd = 900534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNestedParentCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetNestedParentCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001AB RID: 427
		public unsafe string this[string columnName]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 900544, RefRangeEnd = 900545, XrefRangeStart = 900536, XrefRangeEnd = 900544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AC RID: 428
		public unsafe Object this[DataColumn column]
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 900563, RefRangeEnd = 900574, XrefRangeStart = 900545, XrefRangeEnd = 900563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_get_Item_Public_get_Object_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 900594, RefRangeEnd = 900605, XrefRangeStart = 900574, XrefRangeEnd = 900594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_set_Item_Public_set_Void_DataColumn_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AD RID: 429
		public unsafe Object this[DataColumn column, DataRowVersion version]
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 900618, RefRangeEnd = 900622, XrefRangeStart = 900605, XrefRangeEnd = 900618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_get_Item_Public_get_Object_DataColumn_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001AE RID: 430
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00024BB0 File Offset: 0x00022DB0
		public unsafe Il2CppReferenceArray<Object> ItemArray
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 900689, RefRangeEnd = 900690, XrefRangeStart = 900622, XrefRangeEnd = 900689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_set_ItemArray_Public_set_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00024BF4 File Offset: 0x00022DF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 900722, RefRangeEnd = 900724, XrefRangeStart = 900690, XrefRangeEnd = 900722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcceptChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_AcceptChanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00024C28 File Offset: 0x00022E28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 900725, RefRangeEnd = 900729, XrefRangeStart = 900724, XrefRangeEnd = 900725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_BeginEdit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00024C5C File Offset: 0x00022E5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 900730, RefRangeEnd = 900736, XrefRangeStart = 900729, XrefRangeEnd = 900730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BeginEditInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_BeginEditInternal_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00024C98 File Offset: 0x00022E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 900738, RefRangeEnd = 900741, XrefRangeStart = 900736, XrefRangeEnd = 900738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_CancelEdit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00024CCC File Offset: 0x00022ECC
		[CallerCount(0)]
		public unsafe void CheckColumn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_CheckColumn_Private_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00024D10 File Offset: 0x00022F10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 900741, RefRangeEnd = 900743, XrefRangeStart = 900741, XrefRangeEnd = 900741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_CheckInTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00024D44 File Offset: 0x00022F44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 900744, RefRangeEnd = 900747, XrefRangeStart = 900743, XrefRangeEnd = 900744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_Delete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00024D78 File Offset: 0x00022F78
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 900751, RefRangeEnd = 900763, XrefRangeStart = 900747, XrefRangeEnd = 900751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_EndEdit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00024DAC File Offset: 0x00022FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900769, RefRangeEnd = 900770, XrefRangeStart = 900763, XrefRangeEnd = 900769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColumnError(int columnIndex, string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref columnIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_SetColumnError_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00024DFC File Offset: 0x00022FFC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 900798, RefRangeEnd = 900804, XrefRangeStart = 900770, XrefRangeEnd = 900798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColumnError(DataColumn column, string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_SetColumnError_Public_Void_DataColumn_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00024E50 File Offset: 0x00023050
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 900814, RefRangeEnd = 900818, XrefRangeStart = 900804, XrefRangeEnd = 900814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetColumnError(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetColumnError_Public_String_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00024E98 File Offset: 0x00023098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900823, RefRangeEnd = 900824, XrefRangeStart = 900818, XrefRangeEnd = 900823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearErrors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_ClearErrors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00024ECC File Offset: 0x000230CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900824, XrefRangeEnd = 900827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearError(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_ClearError_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00024F10 File Offset: 0x00023110
		public unsafe bool HasErrors
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 900827, RefRangeEnd = 900831, XrefRangeStart = 900827, XrefRangeEnd = 900827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_get_HasErrors_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00024F4C File Offset: 0x0002314C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900839, RefRangeEnd = 900840, XrefRangeStart = 900831, XrefRangeEnd = 900839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataColumn> GetColumnsInError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetColumnsInError_Public_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00024F8C File Offset: 0x0002318C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900841, RefRangeEnd = 900842, XrefRangeStart = 900840, XrefRangeEnd = 900841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataRow> GetChildRows(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetChildRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr3) : null;
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00024FDC File Offset: 0x000231DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 900855, RefRangeEnd = 900858, XrefRangeStart = 900842, XrefRangeEnd = 900855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataRow> GetChildRows(DataRelation relation, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetChildRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr3) : null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0002503C File Offset: 0x0002323C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900858, XrefRangeEnd = 900859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumn GetDataColumn(string columnName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetDataColumn_Internal_DataColumn_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0002508C File Offset: 0x0002328C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900859, XrefRangeEnd = 900860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow GetParentRow(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetParentRow_Public_DataRow_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000250DC File Offset: 0x000232DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 900864, RefRangeEnd = 900872, XrefRangeStart = 900860, XrefRangeEnd = 900864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow GetParentRow(DataRelation relation, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetParentRow_Public_DataRow_DataRelation_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0002513C File Offset: 0x0002333C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900875, RefRangeEnd = 900876, XrefRangeStart = 900872, XrefRangeEnd = 900875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow GetNestedParentRow(DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref version;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetNestedParentRow_Internal_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00025188 File Offset: 0x00023388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900876, XrefRangeEnd = 900877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataRow> GetParentRows(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetParentRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr3) : null;
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000251D8 File Offset: 0x000233D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 900890, RefRangeEnd = 900892, XrefRangeStart = 900877, XrefRangeEnd = 900890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataRow> GetParentRows(DataRelation relation, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetParentRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr3) : null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00025238 File Offset: 0x00023438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900892, XrefRangeEnd = 900895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetColumnValues(Il2CppReferenceArray<DataColumn> columns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetColumnValues_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00025288 File Offset: 0x00023488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900895, XrefRangeEnd = 900898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetColumnValues(Il2CppReferenceArray<DataColumn> columns, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetColumnValues_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_DataColumn_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000252E8 File Offset: 0x000234E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 900899, RefRangeEnd = 900902, XrefRangeStart = 900898, XrefRangeEnd = 900899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetKeyValues(DataKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetKeyValues_Internal_Il2CppReferenceArray_1_Object_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00025340 File Offset: 0x00023540
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 900904, RefRangeEnd = 900913, XrefRangeStart = 900902, XrefRangeEnd = 900904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetKeyValues(DataKey key, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetKeyValues_Internal_Il2CppReferenceArray_1_Object_DataKey_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000253A4 File Offset: 0x000235A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900913, RefRangeEnd = 900914, XrefRangeStart = 900913, XrefRangeEnd = 900913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCurrentRecordNo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetCurrentRecordNo_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000253E0 File Offset: 0x000235E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 900914, RefRangeEnd = 900920, XrefRangeStart = 900914, XrefRangeEnd = 900914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDefaultRecord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetDefaultRecord_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0002541C File Offset: 0x0002361C
		[CallerCount(0)]
		public unsafe int GetOriginalRecordNo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetOriginalRecordNo_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00025458 File Offset: 0x00023658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900920, RefRangeEnd = 900921, XrefRangeStart = 900920, XrefRangeEnd = 900920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetProposedRecordNo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetProposedRecordNo_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00025494 File Offset: 0x00023694
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 900921, RefRangeEnd = 900946, XrefRangeStart = 900921, XrefRangeEnd = 900921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRecordFromVersion(DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref version;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetRecordFromVersion_Internal_Int32_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x000254E0 File Offset: 0x000236E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 900946, RefRangeEnd = 900948, XrefRangeStart = 900946, XrefRangeEnd = 900946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowVersion GetDefaultRowVersion(DataViewRowState viewState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetDefaultRowVersion_Internal_DataRowVersion_DataViewRowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0002552C File Offset: 0x0002372C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 900948, RefRangeEnd = 900960, XrefRangeStart = 900948, XrefRangeEnd = 900948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataViewRowState GetRecordState(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_GetRecordState_Internal_DataViewRowState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00025578 File Offset: 0x00023778
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 900961, RefRangeEnd = 900964, XrefRangeStart = 900960, XrefRangeEnd = 900961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasKeyChanged(DataKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_HasKeyChanged_Internal_Boolean_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000255CC File Offset: 0x000237CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900969, RefRangeEnd = 900970, XrefRangeStart = 900964, XrefRangeEnd = 900969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_HasKeyChanged_Internal_Boolean_DataKey_DataRowVersion_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0002563C File Offset: 0x0002383C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 900970, RefRangeEnd = 900985, XrefRangeStart = 900970, XrefRangeEnd = 900970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasVersion(DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref version;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_HasVersion_Public_Boolean_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00025688 File Offset: 0x00023888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900985, XrefRangeEnd = 900986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HaveValuesChanged(Il2CppReferenceArray<DataColumn> columns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_HaveValuesChanged_Internal_Boolean_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000256D8 File Offset: 0x000238D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900993, RefRangeEnd = 900994, XrefRangeStart = 900986, XrefRangeEnd = 900993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HaveValuesChanged(Il2CppReferenceArray<DataColumn> columns, DataRowVersion version1, DataRowVersion version2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_HaveValuesChanged_Internal_Boolean_Il2CppReferenceArray_1_DataColumn_DataRowVersion_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00025744 File Offset: 0x00023944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901048, RefRangeEnd = 901049, XrefRangeStart = 900994, XrefRangeEnd = 901048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RejectChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_RejectChanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00025778 File Offset: 0x00023978
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901050, RefRangeEnd = 901053, XrefRangeStart = 901049, XrefRangeEnd = 901050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetLastChangedColumn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_ResetLastChangedColumn_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000257AC File Offset: 0x000239AC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 901058, RefRangeEnd = 901066, XrefRangeStart = 901053, XrefRangeEnd = 901058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKeyValues(DataKey key, Il2CppReferenceArray<Object> keyValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyValues);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_SetKeyValues_Internal_Void_DataKey_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00025808 File Offset: 0x00023A08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901094, RefRangeEnd = 901097, XrefRangeStart = 901066, XrefRangeEnd = 901094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNestedParentRow(DataRow parentRow, bool setNonNested)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentRow);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setNonNested;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_SetNestedParentRow_Internal_Void_DataRow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00025858 File Offset: 0x00023A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901116, RefRangeEnd = 901117, XrefRangeStart = 901097, XrefRangeEnd = 901116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParentRowToDBNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_SetParentRowToDBNull_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0002588C File Offset: 0x00023A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901143, RefRangeEnd = 901144, XrefRangeStart = 901117, XrefRangeEnd = 901143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParentRowToDBNull(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_SetParentRowToDBNull_Internal_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000258D0 File Offset: 0x00023AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901158, RefRangeEnd = 901159, XrefRangeStart = 901144, XrefRangeEnd = 901158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullbitList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRow.NativeMethodInfoPtr_CopyValuesIntoStore_Internal_Int32_ArrayList_ArrayList_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00003C89 File Offset: 0x00001E89
		public DataRow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00025940 File Offset: 0x00023B40
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00003C92 File Offset: 0x00001E92
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00025970 File Offset: 0x00023B70
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00003CB1 File Offset: 0x00001EB1
		public unsafe DataColumnCollection _columns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__columns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumnCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__columns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x000259A0 File Offset: 0x00023BA0
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public unsafe int _oldRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__oldRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__oldRecord)) = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000259C8 File Offset: 0x00023BC8
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00003CEB File Offset: 0x00001EEB
		public unsafe int _newRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__newRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__newRecord)) = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x000259F0 File Offset: 0x00023BF0
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00003D06 File Offset: 0x00001F06
		public unsafe int _tempRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__tempRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__tempRecord)) = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00025A18 File Offset: 0x00023C18
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00003D21 File Offset: 0x00001F21
		public unsafe long _rowID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__rowID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__rowID)) = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00025A40 File Offset: 0x00023C40
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00003D3C File Offset: 0x00001F3C
		public unsafe DataRowAction _action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__action);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__action)) = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00025A68 File Offset: 0x00023C68
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00003D57 File Offset: 0x00001F57
		public unsafe bool _inChangingEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__inChangingEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__inChangingEvent)) = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00025A90 File Offset: 0x00023C90
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00003D72 File Offset: 0x00001F72
		public unsafe bool _inDeletingEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__inDeletingEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__inDeletingEvent)) = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00025AB8 File Offset: 0x00023CB8
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00003D8D File Offset: 0x00001F8D
		public unsafe bool _inCascade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__inCascade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__inCascade)) = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00025AE0 File Offset: 0x00023CE0
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public unsafe DataColumn _lastChangedColumn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__lastChangedColumn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__lastChangedColumn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00025B10 File Offset: 0x00023D10
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00003DC7 File Offset: 0x00001FC7
		public unsafe int _countColumnChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__countColumnChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__countColumnChange)) = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00025B38 File Offset: 0x00023D38
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00003DE2 File Offset: 0x00001FE2
		public unsafe DataError _error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataError>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00025B68 File Offset: 0x00023D68
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00003E01 File Offset: 0x00002001
		public unsafe int _rbTreeNodeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__rbTreeNodeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__rbTreeNodeId)) = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00025B90 File Offset: 0x00023D90
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00003E1C File Offset: 0x0000201C
		public unsafe static int s_objectTypeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DataRow.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataRow.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00025BAC File Offset: 0x00023DAC
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00003E2A File Offset: 0x0000202A
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRow.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeFieldInfoPtr__columns;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeFieldInfoPtr__oldRecord;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeFieldInfoPtr__newRecord;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeFieldInfoPtr__tempRecord;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeFieldInfoPtr__rowID;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeFieldInfoPtr__action;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeFieldInfoPtr__inChangingEvent;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeFieldInfoPtr__inDeletingEvent;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeFieldInfoPtr__inCascade;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeFieldInfoPtr__lastChangedColumn;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeFieldInfoPtr__countColumnChange;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeFieldInfoPtr__error;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeFieldInfoPtr__rbTreeNodeId;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeFieldInfoPtr_s_objectTypeCount;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_DataRowBuilder_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_get_LastChangedColumn_Internal_get_DataColumn_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_set_LastChangedColumn_Internal_set_Void_DataColumn_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPropertyChanged_Internal_get_Boolean_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_get_RBTreeNodeId_Internal_get_Int32_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_set_RBTreeNodeId_Internal_set_Void_Int32_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_get_RowError_Public_get_String_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_set_RowError_Public_set_Void_String_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_RowErrorChanged_Private_Void_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_get_rowID_Internal_get_Int64_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_set_rowID_Internal_set_Void_Int64_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_get_RowState_Public_get_DataRowState_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Public_get_DataTable_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_CheckForLoops_Internal_Void_DataRelation_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedParentCount_Internal_Int32_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_DataColumn_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_DataColumn_Object_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_DataColumn_DataRowVersion_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemArray_Public_set_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_AcceptChanges_Public_Void_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_BeginEdit_Public_Void_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_BeginEditInternal_Private_Boolean_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_CancelEdit_Public_Void_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_CheckColumn_Private_Void_DataColumn_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_CheckInTable_Internal_Void_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_EndEdit_Public_Void_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_SetColumnError_Public_Void_Int32_String_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_SetColumnError_Public_Void_DataColumn_String_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnError_Public_String_DataColumn_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_ClearErrors_Public_Void_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_ClearError_Internal_Void_DataColumn_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_get_HasErrors_Public_get_Boolean_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnsInError_Public_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_GetChildRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_GetChildRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_DataRowVersion_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_GetDataColumn_Internal_DataColumn_String_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_GetParentRow_Public_DataRow_DataRelation_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_GetParentRow_Public_DataRow_DataRelation_DataRowVersion_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedParentRow_Internal_DataRow_DataRowVersion_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_GetParentRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_GetParentRows_Public_Il2CppReferenceArray_1_DataRow_DataRelation_DataRowVersion_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnValues_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnValues_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_DataColumn_DataRowVersion_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyValues_Internal_Il2CppReferenceArray_1_Object_DataKey_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyValues_Internal_Il2CppReferenceArray_1_Object_DataKey_DataRowVersion_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentRecordNo_Internal_Int32_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultRecord_Internal_Int32_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalRecordNo_Internal_Int32_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_GetProposedRecordNo_Private_Int32_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_GetRecordFromVersion_Internal_Int32_DataRowVersion_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultRowVersion_Internal_DataRowVersion_DataViewRowState_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_GetRecordState_Internal_DataViewRowState_Int32_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_HasKeyChanged_Internal_Boolean_DataKey_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_HasKeyChanged_Internal_Boolean_DataKey_DataRowVersion_DataRowVersion_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_HasVersion_Public_Boolean_DataRowVersion_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_HaveValuesChanged_Internal_Boolean_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_HaveValuesChanged_Internal_Boolean_Il2CppReferenceArray_1_DataColumn_DataRowVersion_DataRowVersion_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_RejectChanges_Public_Void_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_ResetLastChangedColumn_Internal_Void_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyValues_Internal_Void_DataKey_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_SetNestedParentRow_Internal_Void_DataRow_Boolean_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_SetParentRowToDBNull_Internal_Void_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_SetParentRowToDBNull_Internal_Void_DataRelation_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_CopyValuesIntoStore_Internal_Int32_ArrayList_ArrayList_Int32_0;
	}
}
