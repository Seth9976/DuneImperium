using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Data
{
	// Token: 0x02000076 RID: 118
	public sealed class Index : Object
	{
		// Token: 0x06000AAF RID: 2735 RVA: 0x000371BC File Offset: 0x000353BC
		// Note: this type is marked as 'beforefieldinit'.
		static Index()
		{
			Il2CppClassPointerStore<Index>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "Index");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Index>.NativeClassPtr);
			Index.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_table");
			Index.NativeFieldInfoPtr__indexFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_indexFields");
			Index.NativeFieldInfoPtr__comparison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_comparison");
			Index.NativeFieldInfoPtr__recordStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_recordStates");
			Index.NativeFieldInfoPtr__rowFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_rowFilter");
			Index.NativeFieldInfoPtr__records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_records");
			Index.NativeFieldInfoPtr__recordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_recordCount");
			Index.NativeFieldInfoPtr__refCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_refCount");
			Index.NativeFieldInfoPtr__listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_listeners");
			Index.NativeFieldInfoPtr__suspendEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_suspendEvents");
			Index.NativeFieldInfoPtr__isSharable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_isSharable");
			Index.NativeFieldInfoPtr__hasRemoteAggregate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_hasRemoteAggregate");
			Index.NativeFieldInfoPtr_s_objectTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "s_objectTypeCount");
			Index.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "_objectID");
			Index.NativeMethodInfoPtr__ctor_Public_Void_DataTable_Il2CppReferenceArray_1_IndexField_DataViewRowState_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665062);
			Index.NativeMethodInfoPtr__ctor_Public_Void_DataTable_Comparison_1_DataRow_DataViewRowState_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665063);
			Index.NativeMethodInfoPtr_GetAllFields_Private_Static_Il2CppReferenceArray_1_IndexField_DataColumnCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665064);
			Index.NativeMethodInfoPtr__ctor_Private_Void_DataTable_Il2CppReferenceArray_1_IndexField_Comparison_1_DataRow_DataViewRowState_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665065);
			Index.NativeMethodInfoPtr_Equal_Public_Boolean_Il2CppReferenceArray_1_IndexField_DataViewRowState_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665066);
			Index.NativeMethodInfoPtr_get_HasRemoteAggregate_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665067);
			Index.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665068);
			Index.NativeMethodInfoPtr_get_RecordStates_Public_get_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665069);
			Index.NativeMethodInfoPtr_get_RowFilter_Public_get_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665070);
			Index.NativeMethodInfoPtr_GetRecord_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665071);
			Index.NativeMethodInfoPtr_get_HasDuplicates_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665072);
			Index.NativeMethodInfoPtr_get_RecordCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665073);
			Index.NativeMethodInfoPtr_AcceptRecord_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665074);
			Index.NativeMethodInfoPtr_AcceptRecord_Private_Boolean_Int32_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665075);
			Index.NativeMethodInfoPtr_ListChangedAdd_Internal_Void_DataViewListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665076);
			Index.NativeMethodInfoPtr_ListChangedRemove_Internal_Void_DataViewListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665077);
			Index.NativeMethodInfoPtr_get_RefCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665078);
			Index.NativeMethodInfoPtr_AddRef_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665079);
			Index.NativeMethodInfoPtr_RemoveRef_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665080);
			Index.NativeMethodInfoPtr_ApplyChangeAction_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665081);
			Index.NativeMethodInfoPtr_CheckUnique_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665082);
			Index.NativeMethodInfoPtr_CompareRecords_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665083);
			Index.NativeMethodInfoPtr_CompareDataRows_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665084);
			Index.NativeMethodInfoPtr_CompareDuplicateRecords_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665085);
			Index.NativeMethodInfoPtr_CompareRecordToKey_Private_Int32_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665086);
			Index.NativeMethodInfoPtr_DeleteRecordFromIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665087);
			Index.NativeMethodInfoPtr_DeleteRecord_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665088);
			Index.NativeMethodInfoPtr_DeleteRecord_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665089);
			Index.NativeMethodInfoPtr_GetEnumerator_Public_RBTreeEnumerator_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665090);
			Index.NativeMethodInfoPtr_GetIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665091);
			Index.NativeMethodInfoPtr_GetIndex_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665092);
			Index.NativeMethodInfoPtr_GetUniqueKeyValues_Public_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665093);
			Index.NativeMethodInfoPtr_FindNodeByKey_Private_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665094);
			Index.NativeMethodInfoPtr_FindNodeByKeys_Private_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665095);
			Index.NativeMethodInfoPtr_FindNodeByKeyRecord_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665096);
			Index.NativeMethodInfoPtr_GetRangeFromNode_Private_Range_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665097);
			Index.NativeMethodInfoPtr_FindRecords_Public_Range_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665098);
			Index.NativeMethodInfoPtr_FindRecords_Public_Range_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665099);
			Index.NativeMethodInfoPtr_FireResetEvent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665100);
			Index.NativeMethodInfoPtr_GetChangeAction_Private_Int32_DataViewRowState_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665101);
			Index.NativeMethodInfoPtr_GetReplaceAction_Private_Static_Int32_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665102);
			Index.NativeMethodInfoPtr_GetRow_Public_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665103);
			Index.NativeMethodInfoPtr_GetRows_Public_Il2CppReferenceArray_1_DataRow_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665104);
			Index.NativeMethodInfoPtr_GetRows_Public_Il2CppReferenceArray_1_DataRow_Range_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665105);
			Index.NativeMethodInfoPtr_InitRecords_Private_Void_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665106);
			Index.NativeMethodInfoPtr_InsertRecordToIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665107);
			Index.NativeMethodInfoPtr_InsertRecord_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665108);
			Index.NativeMethodInfoPtr_IsKeyInIndex_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665109);
			Index.NativeMethodInfoPtr_IsKeyInIndex_Public_Boolean_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665110);
			Index.NativeMethodInfoPtr_IsKeyRecordInIndex_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665111);
			Index.NativeMethodInfoPtr_get_DoListChanged_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665112);
			Index.NativeMethodInfoPtr_OnListChanged_Private_Void_ListChangedType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665113);
			Index.NativeMethodInfoPtr_OnListChanged_Private_Void_ListChangedType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665114);
			Index.NativeMethodInfoPtr_OnListChanged_Private_Void_ListChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665115);
			Index.NativeMethodInfoPtr_MaintainDataView_Private_Void_ListChangedType_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665116);
			Index.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665117);
			Index.NativeMethodInfoPtr_RecordChanged_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665118);
			Index.NativeMethodInfoPtr_RecordChanged_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665119);
			Index.NativeMethodInfoPtr_RecordStateChanged_Public_Void_Int32_DataViewRowState_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665120);
			Index.NativeMethodInfoPtr_RecordStateChanged_Public_Void_Int32_DataViewRowState_DataViewRowState_Int32_DataViewRowState_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665121);
			Index.NativeMethodInfoPtr_get_Table_Internal_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665122);
			Index.NativeMethodInfoPtr_GetUniqueKeyValues_Private_Void_List_1_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665123);
			Index.NativeMethodInfoPtr_IndexOfReference_Internal_Static_Int32_List_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100665124);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x000377F0 File Offset: 0x000359F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906492, XrefRangeEnd = 906493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Index(DataTable table, Il2CppReferenceArray<IndexField> indexFields, DataViewRowState recordStates, IFilter rowFilter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Index>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexFields);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordStates;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr__ctor_Public_Void_DataTable_Il2CppReferenceArray_1_IndexField_DataViewRowState_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00037870 File Offset: 0x00035A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906501, RefRangeEnd = 906502, XrefRangeStart = 906493, XrefRangeEnd = 906501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Index(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Index>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparison);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordStates;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr__ctor_Public_Void_DataTable_Comparison_1_DataRow_DataViewRowState_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000378F0 File Offset: 0x00035AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906502, XrefRangeEnd = 906509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<IndexField> GetAllFields(DataColumnCollection columns)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetAllFields_Private_Static_Il2CppReferenceArray_1_IndexField_DataColumnCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IndexField>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00037934 File Offset: 0x00035B34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906562, RefRangeEnd = 906564, XrefRangeStart = 906509, XrefRangeEnd = 906562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Index(DataTable table, Il2CppReferenceArray<IndexField> indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Index>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexFields);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparison);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordStates;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr__ctor_Private_Void_DataTable_Il2CppReferenceArray_1_IndexField_Comparison_1_DataRow_DataViewRowState_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x000379C4 File Offset: 0x00035BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906565, RefRangeEnd = 906566, XrefRangeStart = 906564, XrefRangeEnd = 906565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equal(Il2CppReferenceArray<IndexField> indexDesc, DataViewRowState recordStates, IFilter rowFilter)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_Equal_Public_Boolean_Il2CppReferenceArray_1_IndexField_DataViewRowState_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00037A34 File Offset: 0x00035C34
		public unsafe bool HasRemoteAggregate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_get_HasRemoteAggregate_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00037A70 File Offset: 0x00035C70
		public unsafe int ObjectID
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00037AAC File Offset: 0x00035CAC
		public unsafe DataViewRowState RecordStates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_get_RecordStates_Public_get_DataViewRowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00037AE8 File Offset: 0x00035CE8
		public unsafe IFilter RowFilter
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 906570, RefRangeEnd = 906575, XrefRangeStart = 906566, XrefRangeEnd = 906570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_get_RowFilter_Public_get_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFilter>(intPtr3) : null;
			}
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00037B28 File Offset: 0x00035D28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 906579, RefRangeEnd = 906583, XrefRangeStart = 906575, XrefRangeEnd = 906579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRecord(int recordIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetRecord_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00037B74 File Offset: 0x00035D74
		public unsafe bool HasDuplicates
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906583, XrefRangeEnd = 906587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_get_HasDuplicates_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00037BB0 File Offset: 0x00035DB0
		public unsafe int RecordCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_get_RecordCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00037BEC File Offset: 0x00035DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906587, XrefRangeEnd = 906589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AcceptRecord(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_AcceptRecord_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00037C38 File Offset: 0x00035E38
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 906603, RefRangeEnd = 906608, XrefRangeStart = 906589, XrefRangeEnd = 906603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AcceptRecord(int record, IFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_AcceptRecord_Private_Boolean_Int32_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00037C94 File Offset: 0x00035E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906612, RefRangeEnd = 906613, XrefRangeStart = 906608, XrefRangeEnd = 906612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListChangedAdd(DataViewListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_ListChangedAdd_Internal_Void_DataViewListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00037CD8 File Offset: 0x00035ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906617, RefRangeEnd = 906618, XrefRangeStart = 906613, XrefRangeEnd = 906617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListChangedRemove(DataViewListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_ListChangedRemove_Internal_Void_DataViewListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00037D1C File Offset: 0x00035F1C
		public unsafe int RefCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_get_RefCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00037D58 File Offset: 0x00035F58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 906637, RefRangeEnd = 906644, XrefRangeStart = 906618, XrefRangeEnd = 906637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRef()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_AddRef_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00037D8C File Offset: 0x00035F8C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 906661, RefRangeEnd = 906679, XrefRangeStart = 906644, XrefRangeEnd = 906661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RemoveRef()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_RemoveRef_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00037DC8 File Offset: 0x00035FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906688, RefRangeEnd = 906689, XrefRangeStart = 906679, XrefRangeEnd = 906688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyChangeAction(int record, int action, int changeRecord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeRecord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_ApplyChangeAction_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00037E24 File Offset: 0x00036024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906692, RefRangeEnd = 906694, XrefRangeStart = 906689, XrefRangeEnd = 906692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckUnique()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_CheckUnique_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00037E60 File Offset: 0x00036060
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 906697, RefRangeEnd = 906701, XrefRangeStart = 906694, XrefRangeEnd = 906697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareRecords(int record1, int record2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_CompareRecords_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00037EB8 File Offset: 0x000360B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906701, XrefRangeEnd = 906703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareDataRows(int record1, int record2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_CompareDataRows_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00037F10 File Offset: 0x00036110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906707, RefRangeEnd = 906708, XrefRangeStart = 906703, XrefRangeEnd = 906707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareDuplicateRecords(int record1, int record2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_CompareDuplicateRecords_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00037F68 File Offset: 0x00036168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906708, XrefRangeEnd = 906710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareRecordToKey(int record1, Il2CppReferenceArray<Object> vals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vals);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_CompareRecordToKey_Private_Int32_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00037FC4 File Offset: 0x000361C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906711, RefRangeEnd = 906712, XrefRangeStart = 906710, XrefRangeEnd = 906711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteRecordFromIndex(int recordIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_DeleteRecordFromIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00038004 File Offset: 0x00036204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906712, XrefRangeEnd = 906713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteRecord(int recordIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_DeleteRecord_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00038044 File Offset: 0x00036244
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 906727, RefRangeEnd = 906730, XrefRangeStart = 906713, XrefRangeEnd = 906727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteRecord(int recordIndex, bool fireEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fireEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_DeleteRecord_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00038090 File Offset: 0x00036290
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 906733, RefRangeEnd = 906736, XrefRangeStart = 906730, XrefRangeEnd = 906733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RBTree<int>.RBTreeEnumerator GetEnumerator(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetEnumerator_Public_RBTreeEnumerator_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RBTree<int>.RBTreeEnumerator(intPtr);
			}
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000380D4 File Offset: 0x000362D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 906740, RefRangeEnd = 906746, XrefRangeStart = 906736, XrefRangeEnd = 906740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndex(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00038120 File Offset: 0x00036320
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906753, RefRangeEnd = 906755, XrefRangeStart = 906746, XrefRangeEnd = 906753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndex(int record, int changeRecord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeRecord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetIndex_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00038178 File Offset: 0x00036378
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 906769, RefRangeEnd = 906772, XrefRangeStart = 906755, XrefRangeEnd = 906769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetUniqueKeyValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetUniqueKeyValues_Public_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x000381B8 File Offset: 0x000363B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906784, RefRangeEnd = 906786, XrefRangeStart = 906772, XrefRangeEnd = 906784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNodeByKey(Object originalKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_FindNodeByKey_Private_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00038208 File Offset: 0x00036408
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 906805, RefRangeEnd = 906824, XrefRangeStart = 906786, XrefRangeEnd = 906805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNodeByKeys(Il2CppReferenceArray<Object> originalKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_FindNodeByKeys_Private_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00038258 File Offset: 0x00036458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906824, XrefRangeEnd = 906835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNodeByKeyRecord(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_FindNodeByKeyRecord_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x000382A4 File Offset: 0x000364A4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 906847, RefRangeEnd = 906863, XrefRangeStart = 906835, XrefRangeEnd = 906847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Range GetRangeFromNode(int nodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetRangeFromNode_Private_Range_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x000382F0 File Offset: 0x000364F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906865, RefRangeEnd = 906867, XrefRangeStart = 906863, XrefRangeEnd = 906865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Range FindRecords(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_FindRecords_Public_Range_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00038340 File Offset: 0x00036540
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 906869, RefRangeEnd = 906872, XrefRangeStart = 906867, XrefRangeEnd = 906869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Range FindRecords(Il2CppReferenceArray<Object> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_FindRecords_Public_Range_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00038390 File Offset: 0x00036590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906890, RefRangeEnd = 906891, XrefRangeStart = 906872, XrefRangeEnd = 906890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FireResetEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_FireResetEvent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000383C4 File Offset: 0x000365C4
		[CallerCount(0)]
		public unsafe int GetChangeAction(DataViewRowState oldState, DataViewRowState newState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetChangeAction_Private_Int32_DataViewRowState_DataViewRowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0003841C File Offset: 0x0003661C
		[CallerCount(0)]
		public unsafe static int GetReplaceAction(DataViewRowState oldState)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetReplaceAction_Private_Static_Int32_DataViewRowState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0003845C File Offset: 0x0003665C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906894, RefRangeEnd = 906896, XrefRangeStart = 906891, XrefRangeEnd = 906894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow GetRow(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetRow_Public_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x000384A8 File Offset: 0x000366A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 906899, RefRangeEnd = 906903, XrefRangeStart = 906896, XrefRangeEnd = 906899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataRow> GetRows(Il2CppReferenceArray<Object> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetRows_Public_Il2CppReferenceArray_1_DataRow_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr3) : null;
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000384F8 File Offset: 0x000366F8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 906915, RefRangeEnd = 906928, XrefRangeStart = 906903, XrefRangeEnd = 906915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataRow> GetRows(Range range)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref range;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetRows_Public_Il2CppReferenceArray_1_DataRow_Range_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr3) : null;
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00038544 File Offset: 0x00036744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906961, RefRangeEnd = 906963, XrefRangeStart = 906928, XrefRangeEnd = 906961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitRecords(IFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_InitRecords_Private_Void_IFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00038588 File Offset: 0x00036788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906966, RefRangeEnd = 906967, XrefRangeStart = 906963, XrefRangeEnd = 906966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InsertRecordToIndex(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_InsertRecordToIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000385D4 File Offset: 0x000367D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906984, RefRangeEnd = 906986, XrefRangeStart = 906967, XrefRangeEnd = 906984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InsertRecord(int record, bool fireEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fireEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_InsertRecord_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0003862C File Offset: 0x0003682C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906987, RefRangeEnd = 906988, XrefRangeStart = 906986, XrefRangeEnd = 906987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsKeyInIndex(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_IsKeyInIndex_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0003867C File Offset: 0x0003687C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906988, XrefRangeEnd = 906989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsKeyInIndex(Il2CppReferenceArray<Object> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_IsKeyInIndex_Public_Boolean_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000386CC File Offset: 0x000368CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906989, XrefRangeEnd = 907000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsKeyRecordInIndex(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_IsKeyRecordInIndex_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00038718 File Offset: 0x00036918
		public unsafe bool DoListChanged
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907000, XrefRangeEnd = 907004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_get_DoListChanged_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00038754 File Offset: 0x00036954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907013, RefRangeEnd = 907015, XrefRangeStart = 907004, XrefRangeEnd = 907013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref changedType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_OnListChanged_Private_Void_ListChangedType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x000387B0 File Offset: 0x000369B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907024, RefRangeEnd = 907026, XrefRangeStart = 907015, XrefRangeEnd = 907024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnListChanged(ListChangedType changedType, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref changedType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_OnListChanged_Private_Void_ListChangedType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000387FC File Offset: 0x000369FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 907053, RefRangeEnd = 907057, XrefRangeStart = 907026, XrefRangeEnd = 907053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnListChanged(ListChangedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_OnListChanged_Private_Void_ListChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00038840 File Offset: 0x00036A40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 907071, RefRangeEnd = 907074, XrefRangeStart = 907057, XrefRangeEnd = 907071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref changedType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref record;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackAddRemove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_MaintainDataView_Private_Void_ListChangedType_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0003889C File Offset: 0x00036A9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 907104, RefRangeEnd = 907110, XrefRangeStart = 907074, XrefRangeEnd = 907104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000388D0 File Offset: 0x00036AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907127, RefRangeEnd = 907128, XrefRangeStart = 907110, XrefRangeEnd = 907127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordChanged(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_RecordChanged_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00038910 File Offset: 0x00036B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907138, RefRangeEnd = 907139, XrefRangeStart = 907128, XrefRangeEnd = 907138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordChanged(int oldIndex, int newIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_RecordChanged_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0003895C File Offset: 0x00036B5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 907151, RefRangeEnd = 907154, XrefRangeStart = 907139, XrefRangeEnd = 907151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_RecordStateChanged_Public_Void_Int32_DataViewRowState_DataViewRowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x000389B8 File Offset: 0x00036BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907177, RefRangeEnd = 907178, XrefRangeStart = 907154, XrefRangeEnd = 907177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldRecord;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldOldState;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldNewState;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRecord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newOldState;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newNewState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_RecordStateChanged_Public_Void_Int32_DataViewRowState_DataViewRowState_Int32_DataViewRowState_DataViewRowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00038A3C File Offset: 0x00036C3C
		public unsafe DataTable Table
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_get_Table_Internal_get_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00038A7C File Offset: 0x00036C7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907201, RefRangeEnd = 907203, XrefRangeStart = 907178, XrefRangeEnd = 907201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUniqueKeyValues(List<Il2CppReferenceArray<Object>> list, int curNodeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref curNodeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.NativeMethodInfoPtr_GetUniqueKeyValues_Private_Void_List_1_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00038ACC File Offset: 0x00036CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907207, RefRangeEnd = 907209, XrefRangeStart = 907203, XrefRangeEnd = 907207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfReference<T>(List<T> list, T item) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Index.MethodInfoStoreGeneric_IndexOfReference_Internal_Static_Int32_List_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00005395 File Offset: 0x00003595
		public Index(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00038B58 File Offset: 0x00036D58
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x0000539E File Offset: 0x0000359E
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00038B88 File Offset: 0x00036D88
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x000053BD File Offset: 0x000035BD
		public unsafe Il2CppReferenceArray<IndexField> _indexFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__indexFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IndexField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__indexFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00038BB8 File Offset: 0x00036DB8
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x000053DC File Offset: 0x000035DC
		public unsafe Comparison<DataRow> _comparison
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__comparison);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<DataRow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__comparison), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00038BE8 File Offset: 0x00036DE8
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x000053FB File Offset: 0x000035FB
		public unsafe DataViewRowState _recordStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__recordStates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__recordStates)) = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00038C10 File Offset: 0x00036E10
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00005416 File Offset: 0x00003616
		public unsafe WeakReference _rowFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__rowFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__rowFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00038C40 File Offset: 0x00036E40
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00005435 File Offset: 0x00003635
		public unsafe Index.IndexTree _records
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__records);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Index.IndexTree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__records), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00038C70 File Offset: 0x00036E70
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00005454 File Offset: 0x00003654
		public unsafe int _recordCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__recordCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__recordCount)) = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x00038C98 File Offset: 0x00036E98
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x0000546F File Offset: 0x0000366F
		public unsafe int _refCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__refCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__refCount)) = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x00038CC0 File Offset: 0x00036EC0
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x0000548A File Offset: 0x0000368A
		public unsafe Listeners<DataViewListener> _listeners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__listeners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listeners<DataViewListener>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__listeners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00038CF0 File Offset: 0x00036EF0
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x000054A9 File Offset: 0x000036A9
		public unsafe bool _suspendEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__suspendEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__suspendEvents)) = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00038D18 File Offset: 0x00036F18
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x000054C4 File Offset: 0x000036C4
		public unsafe bool _isSharable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__isSharable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__isSharable)) = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00038D40 File Offset: 0x00036F40
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x000054DF File Offset: 0x000036DF
		public unsafe bool _hasRemoteAggregate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__hasRemoteAggregate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__hasRemoteAggregate)) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00038D68 File Offset: 0x00036F68
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x000054FA File Offset: 0x000036FA
		public unsafe static int s_objectTypeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Index.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Index.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00038D84 File Offset: 0x00036F84
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x00005508 File Offset: 0x00003708
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr__indexFields;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr__comparison;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeFieldInfoPtr__recordStates;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeFieldInfoPtr__rowFilter;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr__records;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr__recordCount;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeFieldInfoPtr__refCount;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeFieldInfoPtr__listeners;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeFieldInfoPtr__suspendEvents;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr__isSharable;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeFieldInfoPtr__hasRemoteAggregate;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_s_objectTypeCount;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataTable_Il2CppReferenceArray_1_IndexField_DataViewRowState_IFilter_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataTable_Comparison_1_DataRow_DataViewRowState_IFilter_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFields_Private_Static_Il2CppReferenceArray_1_IndexField_DataColumnCollection_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DataTable_Il2CppReferenceArray_1_IndexField_Comparison_1_DataRow_DataViewRowState_IFilter_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_Equal_Public_Boolean_Il2CppReferenceArray_1_IndexField_DataViewRowState_IFilter_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRemoteAggregate_Internal_get_Boolean_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_get_RecordStates_Public_get_DataViewRowState_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_get_RowFilter_Public_get_IFilter_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_GetRecord_Public_Int32_Int32_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDuplicates_Public_get_Boolean_0;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr_get_RecordCount_Public_get_Int32_0;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeMethodInfoPtr_AcceptRecord_Private_Boolean_Int32_0;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeMethodInfoPtr_AcceptRecord_Private_Boolean_Int32_IFilter_0;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeMethodInfoPtr_ListChangedAdd_Internal_Void_DataViewListener_0;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr_ListChangedRemove_Internal_Void_DataViewListener_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_get_RefCount_Public_get_Int32_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_AddRef_Public_Void_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRef_Public_Int32_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_ApplyChangeAction_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_CheckUnique_Public_Boolean_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_CompareRecords_Private_Int32_Int32_Int32_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_CompareDataRows_Private_Int32_Int32_Int32_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_CompareDuplicateRecords_Private_Int32_Int32_Int32_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_CompareRecordToKey_Private_Int32_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_DeleteRecordFromIndex_Public_Void_Int32_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_DeleteRecord_Private_Void_Int32_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_DeleteRecord_Private_Void_Int32_Boolean_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_RBTreeEnumerator_Int32_Int32_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_GetIndex_Public_Int32_Int32_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_GetIndex_Private_Int32_Int32_Int32_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_GetUniqueKeyValues_Public_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_FindNodeByKey_Private_Int32_Object_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_FindNodeByKeys_Private_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_FindNodeByKeyRecord_Private_Int32_Int32_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_GetRangeFromNode_Private_Range_Int32_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_FindRecords_Public_Range_Object_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_FindRecords_Public_Range_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_FireResetEvent_Internal_Void_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_GetChangeAction_Private_Int32_DataViewRowState_DataViewRowState_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_GetReplaceAction_Private_Static_Int32_DataViewRowState_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_GetRow_Public_DataRow_Int32_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_GetRows_Public_Il2CppReferenceArray_1_DataRow_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_GetRows_Public_Il2CppReferenceArray_1_DataRow_Range_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_InitRecords_Private_Void_IFilter_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_InsertRecordToIndex_Public_Int32_Int32_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_InsertRecord_Private_Int32_Int32_Boolean_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_IsKeyInIndex_Public_Boolean_Object_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_IsKeyInIndex_Public_Boolean_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_IsKeyRecordInIndex_Public_Boolean_Int32_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_get_DoListChanged_Private_get_Boolean_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_OnListChanged_Private_Void_ListChangedType_Int32_Int32_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_OnListChanged_Private_Void_ListChangedType_Int32_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_OnListChanged_Private_Void_ListChangedEventArgs_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_MaintainDataView_Private_Void_ListChangedType_Int32_Boolean_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_RecordChanged_Public_Void_Int32_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_RecordChanged_Public_Void_Int32_Int32_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_RecordStateChanged_Public_Void_Int32_DataViewRowState_DataViewRowState_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_RecordStateChanged_Public_Void_Int32_DataViewRowState_DataViewRowState_Int32_DataViewRowState_DataViewRowState_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Internal_get_DataTable_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr_GetUniqueKeyValues_Private_Void_List_1_Il2CppReferenceArray_1_Object_Int32_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfReference_Internal_Static_Int32_List_1_T_T_0;

		// Token: 0x020000E8 RID: 232
		public sealed class IndexTree : RBTree<int>
		{
			// Token: 0x060014EE RID: 5358 RVA: 0x0006368C File Offset: 0x0006188C
			// Note: this type is marked as 'beforefieldinit'.
			static IndexTree()
			{
				Il2CppClassPointerStore<Index.IndexTree>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Index>.NativeClassPtr, "IndexTree");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Index.IndexTree>.NativeClassPtr);
				Index.IndexTree.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index.IndexTree>.NativeClassPtr, "_index");
				Index.IndexTree.NativeMethodInfoPtr__ctor_Internal_Void_Index_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index.IndexTree>.NativeClassPtr, 100665125);
				Index.IndexTree.NativeMethodInfoPtr_CompareNode_Protected_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index.IndexTree>.NativeClassPtr, 100665126);
				Index.IndexTree.NativeMethodInfoPtr_CompareSateliteTreeNode_Protected_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index.IndexTree>.NativeClassPtr, 100665127);
			}

			// Token: 0x060014EF RID: 5359 RVA: 0x00063708 File Offset: 0x00061908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906473, XrefRangeEnd = 906477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IndexTree(Index index)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Index.IndexTree>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(index);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.IndexTree.NativeMethodInfoPtr__ctor_Internal_Void_Index_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060014F0 RID: 5360 RVA: 0x00063754 File Offset: 0x00061954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906477, XrefRangeEnd = 906479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int CompareNode(int record1, int record2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.IndexTree.NativeMethodInfoPtr_CompareNode_Protected_Virtual_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060014F1 RID: 5361 RVA: 0x000637AC File Offset: 0x000619AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906479, XrefRangeEnd = 906481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int CompareSateliteTreeNode(int record1, int record2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.IndexTree.NativeMethodInfoPtr_CompareSateliteTreeNode_Protected_Virtual_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060014F2 RID: 5362 RVA: 0x00007F01 File Offset: 0x00006101
			public IndexTree(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004CA RID: 1226
			// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00063804 File Offset: 0x00061A04
			// (set) Token: 0x060014F4 RID: 5364 RVA: 0x00007F0A File Offset: 0x0000610A
			public unsafe Index _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.IndexTree.NativeFieldInfoPtr__index);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Index>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.IndexTree.NativeFieldInfoPtr__index), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400116C RID: 4460
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x0400116D RID: 4461
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Index_0;

			// Token: 0x0400116E RID: 4462
			private static readonly IntPtr NativeMethodInfoPtr_CompareNode_Protected_Virtual_Int32_Int32_Int32_0;

			// Token: 0x0400116F RID: 4463
			private static readonly IntPtr NativeMethodInfoPtr_CompareSateliteTreeNode_Protected_Virtual_Int32_Int32_Int32_0;
		}

		// Token: 0x020000E9 RID: 233
		[ObfuscatedName("System.Data.Index+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060014F5 RID: 5365 RVA: 0x00063834 File Offset: 0x00061A34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Index.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Index>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Index.__c>.NativeClassPtr);
				Index.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index.__c>.NativeClassPtr, "<>9");
				Index.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index.__c>.NativeClassPtr, "<>9__22_0");
				Index.__c.NativeFieldInfoPtr___9__85_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index.__c>.NativeClassPtr, "<>9__85_0");
				Index.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index.__c>.NativeClassPtr, 100665129);
				Index.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_Boolean_DataViewListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index.__c>.NativeClassPtr, 100665130);
				Index.__c.NativeMethodInfoPtr__OnListChanged_b__85_0_Internal_Void_DataViewListener_ListChangedEventArgs_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index.__c>.NativeClassPtr, 100665131);
			}

			// Token: 0x060014F6 RID: 5366 RVA: 0x000638D8 File Offset: 0x00061AD8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Index.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014F7 RID: 5367 RVA: 0x00063914 File Offset: 0x00061B14
			[CallerCount(0)]
			public unsafe bool __ctor_b__22_0(DataViewListener listener)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_Boolean_DataViewListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060014F8 RID: 5368 RVA: 0x00063964 File Offset: 0x00061B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906481, XrefRangeEnd = 906483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnListChanged_b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.__c.NativeMethodInfoPtr__OnListChanged_b__85_0_Internal_Void_DataViewListener_ListChangedEventArgs_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014F9 RID: 5369 RVA: 0x00007F29 File Offset: 0x00006129
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004CB RID: 1227
			// (get) Token: 0x060014FA RID: 5370 RVA: 0x000639D4 File Offset: 0x00061BD4
			// (set) Token: 0x060014FB RID: 5371 RVA: 0x00007F32 File Offset: 0x00006132
			public unsafe static Index.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Index.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Index.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Index.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004CC RID: 1228
			// (get) Token: 0x060014FC RID: 5372 RVA: 0x000639FC File Offset: 0x00061BFC
			// (set) Token: 0x060014FD RID: 5373 RVA: 0x00007F44 File Offset: 0x00006144
			public unsafe static Listeners<DataViewListener>.Func<DataViewListener, bool> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Index.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listeners<DataViewListener>.Func<DataViewListener, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Index.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004CD RID: 1229
			// (get) Token: 0x060014FE RID: 5374 RVA: 0x00063A24 File Offset: 0x00061C24
			// (set) Token: 0x060014FF RID: 5375 RVA: 0x00007F56 File Offset: 0x00006156
			public unsafe static Listeners<DataViewListener>.Action<DataViewListener, ListChangedEventArgs, bool, bool> __9__85_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Index.__c.NativeFieldInfoPtr___9__85_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listeners<DataViewListener>.Action<DataViewListener, ListChangedEventArgs, bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Index.__c.NativeFieldInfoPtr___9__85_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001170 RID: 4464
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001171 RID: 4465
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04001172 RID: 4466
			private static readonly IntPtr NativeFieldInfoPtr___9__85_0;

			// Token: 0x04001173 RID: 4467
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001174 RID: 4468
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__22_0_Internal_Boolean_DataViewListener_0;

			// Token: 0x04001175 RID: 4469
			private static readonly IntPtr NativeMethodInfoPtr__OnListChanged_b__85_0_Internal_Void_DataViewListener_ListChangedEventArgs_Boolean_Boolean_0;
		}

		// Token: 0x020000EA RID: 234
		[ObfuscatedName("System.Data.Index+<>c__DisplayClass86_0")]
		public sealed class __c__DisplayClass86_0 : Object
		{
			// Token: 0x06001500 RID: 5376 RVA: 0x00063A4C File Offset: 0x00061C4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass86_0()
			{
				Il2CppClassPointerStore<Index.__c__DisplayClass86_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Index>.NativeClassPtr, "<>c__DisplayClass86_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Index.__c__DisplayClass86_0>.NativeClassPtr);
				Index.__c__DisplayClass86_0.NativeFieldInfoPtr_changedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index.__c__DisplayClass86_0>.NativeClassPtr, "changedType");
				Index.__c__DisplayClass86_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index.__c__DisplayClass86_0>.NativeClassPtr, 100665132);
				Index.__c__DisplayClass86_0.NativeMethodInfoPtr__MaintainDataView_b__0_Internal_Void_DataViewListener_ListChangedType_DataRow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index.__c__DisplayClass86_0>.NativeClassPtr, 100665133);
			}

			// Token: 0x06001501 RID: 5377 RVA: 0x00063AB4 File Offset: 0x00061CB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass86_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Index.__c__DisplayClass86_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.__c__DisplayClass86_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001502 RID: 5378 RVA: 0x00063AF0 File Offset: 0x00061CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906483, XrefRangeEnd = 906492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MaintainDataView_b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(row);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref track;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Index.__c__DisplayClass86_0.NativeMethodInfoPtr__MaintainDataView_b__0_Internal_Void_DataViewListener_ListChangedType_DataRow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001503 RID: 5379 RVA: 0x00007F68 File Offset: 0x00006168
			public __c__DisplayClass86_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004CE RID: 1230
			// (get) Token: 0x06001504 RID: 5380 RVA: 0x00063B60 File Offset: 0x00061D60
			// (set) Token: 0x06001505 RID: 5381 RVA: 0x00007F71 File Offset: 0x00006171
			public unsafe ListChangedType changedType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.__c__DisplayClass86_0.NativeFieldInfoPtr_changedType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Index.__c__DisplayClass86_0.NativeFieldInfoPtr_changedType)) = value;
				}
			}

			// Token: 0x04001176 RID: 4470
			private static readonly IntPtr NativeFieldInfoPtr_changedType;

			// Token: 0x04001177 RID: 4471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001178 RID: 4472
			private static readonly IntPtr NativeMethodInfoPtr__MaintainDataView_b__0_Internal_Void_DataViewListener_ListChangedType_DataRow_Boolean_0;
		}

		// Token: 0x020000EB RID: 235
		private sealed class MethodInfoStoreGeneric_IndexOfReference_Internal_Static_Int32_List_1_T_T_0<T>
		{
			// Token: 0x04001179 RID: 4473
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Index.NativeMethodInfoPtr_IndexOfReference_Internal_Static_Int32_List_1_T_T_0, Il2CppClassPointerStore<Index>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
