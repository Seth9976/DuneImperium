using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Data
{
	// Token: 0x02000046 RID: 70
	public class DataView : MarshalByValueComponent
	{
		// Token: 0x06000753 RID: 1875 RVA: 0x0002889C File Offset: 0x00026A9C
		// Note: this type is marked as 'beforefieldinit'.
		static DataView()
		{
			Il2CppClassPointerStore<DataView>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataView>.NativeClassPtr);
			DataView.NativeFieldInfoPtr__dataViewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_dataViewManager");
			DataView.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_table");
			DataView.NativeFieldInfoPtr__locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_locked");
			DataView.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_index");
			DataView.NativeFieldInfoPtr__findIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_findIndexes");
			DataView.NativeFieldInfoPtr__sort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_sort");
			DataView.NativeFieldInfoPtr__comparison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_comparison");
			DataView.NativeFieldInfoPtr__rowFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_rowFilter");
			DataView.NativeFieldInfoPtr__recordStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_recordStates");
			DataView.NativeFieldInfoPtr__shouldOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_shouldOpen");
			DataView.NativeFieldInfoPtr__open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_open");
			DataView.NativeFieldInfoPtr__allowNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_allowNew");
			DataView.NativeFieldInfoPtr__allowEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_allowEdit");
			DataView.NativeFieldInfoPtr__allowDelete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_allowDelete");
			DataView.NativeFieldInfoPtr__applyDefaultSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_applyDefaultSort");
			DataView.NativeFieldInfoPtr__addNewRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_addNewRow");
			DataView.NativeFieldInfoPtr__addNewMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_addNewMoved");
			DataView.NativeFieldInfoPtr__onListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_onListChanged");
			DataView.NativeFieldInfoPtr_s_resetEventArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "s_resetEventArgs");
			DataView.NativeFieldInfoPtr__delayedSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_delayedSort");
			DataView.NativeFieldInfoPtr__delayedRecordStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_delayedRecordStates");
			DataView.NativeFieldInfoPtr__fInitInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_fInitInProgress");
			DataView.NativeFieldInfoPtr__fEndInitInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_fEndInitInProgress");
			DataView.NativeFieldInfoPtr__rowViewCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_rowViewCache");
			DataView.NativeFieldInfoPtr__rowViewBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_rowViewBuffer");
			DataView.NativeFieldInfoPtr__dvListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_dvListener");
			DataView.NativeFieldInfoPtr_s_objectTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "s_objectTypeCount");
			DataView.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView>.NativeClassPtr, "_objectID");
			DataView.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664533);
			DataView.NativeMethodInfoPtr__ctor_Public_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664534);
			DataView.NativeMethodInfoPtr_get_AllowDelete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664535);
			DataView.NativeMethodInfoPtr_get_AllowEdit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664536);
			DataView.NativeMethodInfoPtr_get_AllowNew_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664537);
			DataView.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664538);
			DataView.NativeMethodInfoPtr_get_CountFromIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664539);
			DataView.NativeMethodInfoPtr_get_DataViewManager_Public_get_DataViewManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664540);
			DataView.NativeMethodInfoPtr_get_IsOpen_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664541);
			DataView.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664542);
			DataView.NativeMethodInfoPtr_get_RowStateFilter_Public_get_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664543);
			DataView.NativeMethodInfoPtr_get_Sort_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664544);
			DataView.NativeMethodInfoPtr_set_Sort_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664545);
			DataView.NativeMethodInfoPtr_get_SortComparison_Internal_get_Comparison_1_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664546);
			DataView.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664547);
			DataView.NativeMethodInfoPtr_get_Table_Public_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664548);
			DataView.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664549);
			DataView.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664550);
			DataView.NativeMethodInfoPtr_get_Item_Public_get_DataRowView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664551);
			DataView.NativeMethodInfoPtr_AddNew_Public_Virtual_New_DataRowView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664552);
			DataView.NativeMethodInfoPtr_CheckOpen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664553);
			DataView.NativeMethodInfoPtr_CheckSort_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664554);
			DataView.NativeMethodInfoPtr_Close_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664555);
			DataView.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664556);
			DataView.NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_DataRowView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664557);
			DataView.NativeMethodInfoPtr_Delete_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664558);
			DataView.NativeMethodInfoPtr_Delete_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664559);
			DataView.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664560);
			DataView.NativeMethodInfoPtr_FinishAddNew_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664561);
			DataView.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664562);
			DataView.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664563);
			DataView.NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664564);
			DataView.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664565);
			DataView.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664566);
			DataView.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664567);
			DataView.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664568);
			DataView.NativeMethodInfoPtr_IndexOf_Internal_Int32_DataRowView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664569);
			DataView.NativeMethodInfoPtr_IndexOfDataRowView_Private_Int32_DataRowView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664570);
			DataView.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664571);
			DataView.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664572);
			DataView.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664573);
			DataView.NativeMethodInfoPtr_GetFindIndex_Internal_Index_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664574);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowNew_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664575);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddNew_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664576);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowEdit_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664577);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowRemove_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664578);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsChangeNotification_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664579);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSearching_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664580);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSorting_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664581);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_IsSorted_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664582);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortProperty_Private_Virtual_Final_New_get_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664583);
			DataView.NativeMethodInfoPtr_GetSortProperty_Internal_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664584);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortDirection_Private_Virtual_Final_New_get_ListSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664585);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664586);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_ApplySort_Private_Virtual_Final_New_Void_PropertyDescriptor_ListSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664587);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_Find_Private_Virtual_Final_New_Int32_PropertyDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664588);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664589);
			DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveSort_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664590);
			DataView.NativeMethodInfoPtr_CreateSortString_Private_String_PropertyDescriptor_ListSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664591);
			DataView.NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetListName_Private_Virtual_Final_New_String_Il2CppReferenceArray_1_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664592);
			DataView.NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetItemProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664593);
			DataView.NativeMethodInfoPtr_GetFilter_Internal_Virtual_New_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664594);
			DataView.NativeMethodInfoPtr_GetRecord_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664595);
			DataView.NativeMethodInfoPtr_GetRow_Internal_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664596);
			DataView.NativeMethodInfoPtr_GetRowView_Private_DataRowView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664597);
			DataView.NativeMethodInfoPtr_GetRowView_Private_DataRowView_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664598);
			DataView.NativeMethodInfoPtr_IndexListChanged_Protected_Virtual_New_Void_Object_ListChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664599);
			DataView.NativeMethodInfoPtr_IndexListChangedInternal_Internal_Void_ListChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664600);
			DataView.NativeMethodInfoPtr_MaintainDataView_Internal_Void_ListChangedType_DataRow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664601);
			DataView.NativeMethodInfoPtr_OnListChanged_Protected_Virtual_New_Void_ListChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664602);
			DataView.NativeMethodInfoPtr_Reset_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664603);
			DataView.NativeMethodInfoPtr_ResetRowViewCache_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664604);
			DataView.NativeMethodInfoPtr_SetDataViewManager_Internal_Void_DataViewManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664605);
			DataView.NativeMethodInfoPtr_SetIndex_Internal_Virtual_New_Void_String_DataViewRowState_IFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664606);
			DataView.NativeMethodInfoPtr_SetIndex2_Internal_Void_String_DataViewRowState_IFilter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664607);
			DataView.NativeMethodInfoPtr_UpdateIndex_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664608);
			DataView.NativeMethodInfoPtr_UpdateIndex_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664609);
			DataView.NativeMethodInfoPtr_UpdateIndex_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664610);
			DataView.NativeMethodInfoPtr_ChildRelationCollectionChanged_Internal_Void_Object_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664611);
			DataView.NativeMethodInfoPtr_ParentRelationCollectionChanged_Internal_Void_Object_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664612);
			DataView.NativeMethodInfoPtr_ColumnCollectionChanged_Protected_Virtual_New_Void_Object_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664613);
			DataView.NativeMethodInfoPtr_ColumnCollectionChangedInternal_Internal_Void_Object_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664614);
			DataView.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView>.NativeClassPtr, 100664615);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00029178 File Offset: 0x00027378
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 901962, RefRangeEnd = 901967, XrefRangeStart = 901906, XrefRangeEnd = 901962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataView(DataTable table, bool locked)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataView>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000291D4 File Offset: 0x000273D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901967, XrefRangeEnd = 901971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataView(DataTable table)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataView>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr__ctor_Public_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00029220 File Offset: 0x00027420
		public unsafe bool AllowDelete
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_AllowDelete_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x0002925C File Offset: 0x0002745C
		public unsafe bool AllowEdit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_AllowEdit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00029298 File Offset: 0x00027498
		public unsafe bool AllowNew
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_AllowNew_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x000292D4 File Offset: 0x000274D4
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901971, XrefRangeEnd = 901975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00029310 File Offset: 0x00027510
		public unsafe int CountFromIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_CountFromIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x0002934C File Offset: 0x0002754C
		public unsafe DataViewManager DataViewManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_DataViewManager_Public_get_DataViewManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataViewManager>(intPtr3) : null;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0002938C File Offset: 0x0002758C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_IsOpen_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x000293C8 File Offset: 0x000275C8
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00029404 File Offset: 0x00027604
		public unsafe DataViewRowState RowStateFilter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_RowStateFilter_Public_get_DataViewRowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00029440 File Offset: 0x00027640
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00029478 File Offset: 0x00027678
		public unsafe string Sort
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 901976, RefRangeEnd = 901977, XrefRangeStart = 901975, XrefRangeEnd = 901976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_Sort_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 901996, RefRangeEnd = 901998, XrefRangeStart = 901977, XrefRangeEnd = 901996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_set_Sort_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x000294BC File Offset: 0x000276BC
		public unsafe Comparison<DataRow> SortComparison
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_SortComparison_Internal_get_Comparison_1_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Comparison<DataRow>>(intPtr3) : null;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x000294FC File Offset: 0x000276FC
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0002953C File Offset: 0x0002773C
		public unsafe DataTable Table
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_Table_Public_get_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0002957C File Offset: 0x0002777C
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x000295C8 File Offset: 0x000277C8
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901998, XrefRangeEnd = 902003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref recordIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902003, XrefRangeEnd = 902006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref recordIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000200 RID: 512
		public unsafe DataRowView this[int recordIndex]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref recordIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_Item_Public_get_DataRowView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowView>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00029664 File Offset: 0x00027864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902039, RefRangeEnd = 902040, XrefRangeStart = 902006, XrefRangeEnd = 902039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataRowView AddNew()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataView.NativeMethodInfoPtr_AddNew_Public_Virtual_New_DataRowView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowView>(intPtr3) : null;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x000296B0 File Offset: 0x000278B0
		[CallerCount(0)]
		public unsafe void CheckOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_CheckOpen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000296E4 File Offset: 0x000278E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902040, XrefRangeEnd = 902041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSort(string sort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sort);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_CheckSort_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00029728 File Offset: 0x00027928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902041, XrefRangeEnd = 902043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_Close_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0002975C File Offset: 0x0002795C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902043, XrefRangeEnd = 902057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000297AC File Offset: 0x000279AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902075, RefRangeEnd = 902076, XrefRangeStart = 902057, XrefRangeEnd = 902075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppReferenceArray<DataRowView> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_DataRowView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000297FC File Offset: 0x000279FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902076, XrefRangeEnd = 902078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_Delete_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0002983C File Offset: 0x00027A3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 902100, RefRangeEnd = 902102, XrefRangeStart = 902078, XrefRangeEnd = 902100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_Delete_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00029880 File Offset: 0x00027A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902102, XrefRangeEnd = 902105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataView.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000298CC File Offset: 0x00027ACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 902130, RefRangeEnd = 902132, XrefRangeStart = 902105, XrefRangeEnd = 902130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishAddNew(bool success)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref success;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_FinishAddNew_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0002990C File Offset: 0x00027B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902132, XrefRangeEnd = 902141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0002994C File Offset: 0x00027B4C
		public unsafe virtual bool System.Collections.IList.IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00029988 File Offset: 0x00027B88
		public unsafe virtual bool System.Collections.IList.IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000299C4 File Offset: 0x00027BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902141, XrefRangeEnd = 902144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00029A14 File Offset: 0x00027C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902144, XrefRangeEnd = 902147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00029A48 File Offset: 0x00027C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902147, XrefRangeEnd = 902152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00029A98 File Offset: 0x00027C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902152, XrefRangeEnd = 902157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00029AE8 File Offset: 0x00027CE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 902169, RefRangeEnd = 902173, XrefRangeStart = 902157, XrefRangeEnd = 902169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(DataRowView rowview)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rowview);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_IndexOf_Internal_Int32_DataRowView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00029B38 File Offset: 0x00027D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902173, XrefRangeEnd = 902177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfDataRowView(DataRowView rowview)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rowview);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_IndexOfDataRowView_Private_Int32_DataRowView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00029B88 File Offset: 0x00027D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902177, XrefRangeEnd = 902180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Insert(int index, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00029BD8 File Offset: 0x00027DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902180, XrefRangeEnd = 902192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00029C1C File Offset: 0x00027E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00029C5C File Offset: 0x00027E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 902213, RefRangeEnd = 902215, XrefRangeStart = 902192, XrefRangeEnd = 902213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Index GetFindIndex(string column, bool keepIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_GetFindIndex_Internal_Index_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Index>(intPtr3) : null;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00029CBC File Offset: 0x00027EBC
		public unsafe virtual bool System.ComponentModel.IBindingList.AllowNew
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowNew_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00029CF8 File Offset: 0x00027EF8
		[CallerCount(0)]
		public unsafe virtual Object System_ComponentModel_IBindingList_AddNew()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddNew_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00029D38 File Offset: 0x00027F38
		public unsafe virtual bool System.ComponentModel.IBindingList.AllowEdit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowEdit_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00029D74 File Offset: 0x00027F74
		public unsafe virtual bool System.ComponentModel.IBindingList.AllowRemove
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowRemove_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00029DB0 File Offset: 0x00027FB0
		public unsafe virtual bool System.ComponentModel.IBindingList.SupportsChangeNotification
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsChangeNotification_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00029DEC File Offset: 0x00027FEC
		public unsafe virtual bool System.ComponentModel.IBindingList.SupportsSearching
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSearching_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00029E28 File Offset: 0x00028028
		public unsafe virtual bool System.ComponentModel.IBindingList.SupportsSorting
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSorting_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00029E64 File Offset: 0x00028064
		public unsafe virtual bool System.ComponentModel.IBindingList.IsSorted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902215, XrefRangeEnd = 902217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_IsSorted_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00029EA0 File Offset: 0x000280A0
		public unsafe virtual PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902217, XrefRangeEnd = 902221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortProperty_Private_Virtual_Final_New_get_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00029EE0 File Offset: 0x000280E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902221, XrefRangeEnd = 902225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDescriptor GetSortProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_GetSortProperty_Internal_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00029F20 File Offset: 0x00028120
		public unsafe virtual ListSortDirection System.ComponentModel.IBindingList.SortDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortDirection_Private_Virtual_Final_New_get_ListSortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00029F5C File Offset: 0x0002815C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902225, XrefRangeEnd = 902227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_ComponentModel_IBindingList_AddIndex(PropertyDescriptor property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00029FA0 File Offset: 0x000281A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902227, XrefRangeEnd = 902239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_ComponentModel_IBindingList_ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_ApplySort_Private_Virtual_Final_New_Void_PropertyDescriptor_ListSortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00029FF0 File Offset: 0x000281F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902239, XrefRangeEnd = 902256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_ComponentModel_IBindingList_Find(PropertyDescriptor property, Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_Find_Private_Virtual_Final_New_Int32_PropertyDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0002A050 File Offset: 0x00028250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902256, XrefRangeEnd = 902258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_ComponentModel_IBindingList_RemoveIndex(PropertyDescriptor property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0002A094 File Offset: 0x00028294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902258, XrefRangeEnd = 902271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_ComponentModel_IBindingList_RemoveSort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveSort_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0002A0C8 File Offset: 0x000282C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902271, XrefRangeEnd = 902282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateSortString(PropertyDescriptor property, ListSortDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_CreateSortString_Private_String_PropertyDescriptor_ListSortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0002A120 File Offset: 0x00028320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902282, XrefRangeEnd = 902284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_ComponentModel_ITypedList_GetListName(Il2CppReferenceArray<PropertyDescriptor> listAccessors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listAccessors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetListName_Private_Virtual_Final_New_String_Il2CppReferenceArray_1_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0002A168 File Offset: 0x00028368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902284, XrefRangeEnd = 902291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptorCollection System_ComponentModel_ITypedList_GetItemProperties(Il2CppReferenceArray<PropertyDescriptor> listAccessors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listAccessors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetItemProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0002A1B8 File Offset: 0x000283B8
		[CallerCount(0)]
		public unsafe virtual IFilter GetFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataView.NativeMethodInfoPtr_GetFilter_Internal_Virtual_New_IFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFilter>(intPtr3) : null;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0002A204 File Offset: 0x00028404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902291, XrefRangeEnd = 902300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRecord(int recordIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_GetRecord_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0002A250 File Offset: 0x00028450
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 902303, RefRangeEnd = 902309, XrefRangeStart = 902300, XrefRangeEnd = 902303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow GetRow(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_GetRow_Internal_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0002A29C File Offset: 0x0002849C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 902314, RefRangeEnd = 902317, XrefRangeStart = 902309, XrefRangeEnd = 902314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowView GetRowView(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_GetRowView_Private_DataRowView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowView>(intPtr3) : null;
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0002A2E8 File Offset: 0x000284E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902317, XrefRangeEnd = 902321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowView GetRowView(DataRow dr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_GetRowView_Private_DataRowView_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRowView>(intPtr3) : null;
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0002A338 File Offset: 0x00028538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902321, XrefRangeEnd = 902322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void IndexListChanged(Object sender, ListChangedEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataView.NativeMethodInfoPtr_IndexListChanged_Protected_Virtual_New_Void_Object_ListChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0002A398 File Offset: 0x00028598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902322, XrefRangeEnd = 902327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IndexListChangedInternal(ListChangedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_IndexListChangedInternal_Internal_Void_ListChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0002A3DC File Offset: 0x000285DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902335, RefRangeEnd = 902336, XrefRangeStart = 902327, XrefRangeEnd = 902335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref changedType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(row);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackAddRemove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_MaintainDataView_Internal_Void_ListChangedType_DataRow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0002A43C File Offset: 0x0002863C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902336, XrefRangeEnd = 902373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnListChanged(ListChangedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataView.NativeMethodInfoPtr_OnListChanged_Protected_Virtual_New_Void_ListChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0002A48C File Offset: 0x0002868C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902374, RefRangeEnd = 902375, XrefRangeStart = 902373, XrefRangeEnd = 902374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_Reset_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0002A4C0 File Offset: 0x000286C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 902410, RefRangeEnd = 902414, XrefRangeStart = 902375, XrefRangeEnd = 902410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetRowViewCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_ResetRowViewCache_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0002A4F4 File Offset: 0x000286F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 902428, RefRangeEnd = 902431, XrefRangeStart = 902414, XrefRangeEnd = 902428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDataViewManager(DataViewManager dataViewManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataViewManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_SetDataViewManager_Internal_Void_DataViewManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0002A538 File Offset: 0x00028738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902431, XrefRangeEnd = 902432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newSort);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRowStates;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newRowFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataView.NativeMethodInfoPtr_SetIndex_Internal_Virtual_New_Void_String_DataViewRowState_IFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0002A5A8 File Offset: 0x000287A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 902462, RefRangeEnd = 902467, XrefRangeStart = 902432, XrefRangeEnd = 902462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newSort);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRowStates;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newRowFilter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fireEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_SetIndex2_Internal_Void_String_DataViewRowState_IFilter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0002A618 File Offset: 0x00028818
		[CallerCount(0)]
		public unsafe void UpdateIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_UpdateIndex_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0002A64C File Offset: 0x0002884C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902467, XrefRangeEnd = 902476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateIndex(bool force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataView.NativeMethodInfoPtr_UpdateIndex_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0002A698 File Offset: 0x00028898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 902512, RefRangeEnd = 902514, XrefRangeStart = 902476, XrefRangeEnd = 902512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIndex(bool force, bool fireEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fireEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_UpdateIndex_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0002A6E4 File Offset: 0x000288E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902540, RefRangeEnd = 902541, XrefRangeStart = 902514, XrefRangeEnd = 902540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChildRelationCollectionChanged(Object sender, CollectionChangeEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_ChildRelationCollectionChanged_Internal_Void_Object_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0002A738 File Offset: 0x00028938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902567, RefRangeEnd = 902568, XrefRangeStart = 902541, XrefRangeEnd = 902567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParentRelationCollectionChanged(Object sender, CollectionChangeEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_ParentRelationCollectionChanged_Internal_Void_Object_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0002A78C File Offset: 0x0002898C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902568, XrefRangeEnd = 902594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ColumnCollectionChanged(Object sender, CollectionChangeEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataView.NativeMethodInfoPtr_ColumnCollectionChanged_Protected_Virtual_New_Void_Object_CollectionChangeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0002A7EC File Offset: 0x000289EC
		[CallerCount(0)]
		public unsafe void ColumnCollectionChangedInternal(Object sender, CollectionChangeEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_ColumnCollectionChangedInternal_Internal_Void_Object_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0002A840 File Offset: 0x00028A40
		public unsafe int ObjectID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00004227 File Offset: 0x00002427
		public DataView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0002A87C File Offset: 0x00028A7C
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00004230 File Offset: 0x00002430
		public unsafe DataViewManager _dataViewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__dataViewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__dataViewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0002A8AC File Offset: 0x00028AAC
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x0000424F File Offset: 0x0000244F
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0002A8DC File Offset: 0x00028ADC
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x0000426E File Offset: 0x0000246E
		public unsafe bool _locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__locked)) = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x0002A904 File Offset: 0x00028B04
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00004289 File Offset: 0x00002489
		public unsafe Index _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__index);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Index>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__index), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0002A934 File Offset: 0x00028B34
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x000042A8 File Offset: 0x000024A8
		public unsafe Dictionary<string, Index> _findIndexes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__findIndexes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Index>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__findIndexes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0002A964 File Offset: 0x00028B64
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x000042C7 File Offset: 0x000024C7
		public unsafe string _sort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__sort);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__sort), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0002A98C File Offset: 0x00028B8C
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x000042E6 File Offset: 0x000024E6
		public unsafe Comparison<DataRow> _comparison
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__comparison);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<DataRow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__comparison), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0002A9BC File Offset: 0x00028BBC
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00004305 File Offset: 0x00002505
		public unsafe IFilter _rowFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__rowFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__rowFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0002A9EC File Offset: 0x00028BEC
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00004324 File Offset: 0x00002524
		public unsafe DataViewRowState _recordStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__recordStates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__recordStates)) = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0002AA14 File Offset: 0x00028C14
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x0000433F File Offset: 0x0000253F
		public unsafe bool _shouldOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__shouldOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__shouldOpen)) = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0002AA3C File Offset: 0x00028C3C
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x0000435A File Offset: 0x0000255A
		public unsafe bool _open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__open)) = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0002AA64 File Offset: 0x00028C64
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00004375 File Offset: 0x00002575
		public unsafe bool _allowNew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__allowNew);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__allowNew)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0002AA8C File Offset: 0x00028C8C
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00004390 File Offset: 0x00002590
		public unsafe bool _allowEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__allowEdit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__allowEdit)) = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0002AAB4 File Offset: 0x00028CB4
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x000043AB File Offset: 0x000025AB
		public unsafe bool _allowDelete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__allowDelete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__allowDelete)) = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0002AADC File Offset: 0x00028CDC
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x000043C6 File Offset: 0x000025C6
		public unsafe bool _applyDefaultSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__applyDefaultSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__applyDefaultSort)) = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0002AB04 File Offset: 0x00028D04
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x000043E1 File Offset: 0x000025E1
		public unsafe DataRow _addNewRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__addNewRow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__addNewRow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0002AB34 File Offset: 0x00028D34
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00004400 File Offset: 0x00002600
		public unsafe ListChangedEventArgs _addNewMoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__addNewMoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListChangedEventArgs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__addNewMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0002AB64 File Offset: 0x00028D64
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x0000441F File Offset: 0x0000261F
		public unsafe ListChangedEventHandler _onListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__onListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__onListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0002AB94 File Offset: 0x00028D94
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x0000443E File Offset: 0x0000263E
		public unsafe static ListChangedEventArgs s_resetEventArgs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataView.NativeFieldInfoPtr_s_resetEventArgs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListChangedEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataView.NativeFieldInfoPtr_s_resetEventArgs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x0002ABBC File Offset: 0x00028DBC
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00004450 File Offset: 0x00002650
		public unsafe string _delayedSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__delayedSort);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__delayedSort), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0002ABE4 File Offset: 0x00028DE4
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x0000446F File Offset: 0x0000266F
		public unsafe DataViewRowState _delayedRecordStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__delayedRecordStates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__delayedRecordStates)) = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0002AC0C File Offset: 0x00028E0C
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0000448A File Offset: 0x0000268A
		public unsafe bool _fInitInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__fInitInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__fInitInProgress)) = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0002AC34 File Offset: 0x00028E34
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x000044A5 File Offset: 0x000026A5
		public unsafe bool _fEndInitInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__fEndInitInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__fEndInitInProgress)) = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0002AC5C File Offset: 0x00028E5C
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x000044C0 File Offset: 0x000026C0
		public unsafe Dictionary<DataRow, DataRowView> _rowViewCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__rowViewCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DataRow, DataRowView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__rowViewCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0002AC8C File Offset: 0x00028E8C
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x000044DF File Offset: 0x000026DF
		public unsafe Dictionary<DataRow, DataRowView> _rowViewBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__rowViewBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DataRow, DataRowView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__rowViewBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0002ACBC File Offset: 0x00028EBC
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x000044FE File Offset: 0x000026FE
		public unsafe DataViewListener _dvListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__dvListener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataViewListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__dvListener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0002ACEC File Offset: 0x00028EEC
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x0000451D File Offset: 0x0000271D
		public unsafe static int s_objectTypeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DataView.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataView.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x0002AD08 File Offset: 0x00028F08
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0000452B File Offset: 0x0000272B
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataView.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr__dataViewManager;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr__locked;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr__findIndexes;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr__sort;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr__comparison;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr__rowFilter;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr__recordStates;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr__shouldOpen;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr__open;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr__allowNew;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeFieldInfoPtr__allowEdit;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeFieldInfoPtr__allowDelete;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr__applyDefaultSort;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr__addNewRow;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr__addNewMoved;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr__onListChanged;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_s_resetEventArgs;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr__delayedSort;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr__delayedRecordStates;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeFieldInfoPtr__fInitInProgress;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr__fEndInitInProgress;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeFieldInfoPtr__rowViewCache;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeFieldInfoPtr__rowViewBuffer;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeFieldInfoPtr__dvListener;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeFieldInfoPtr_s_objectTypeCount;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataTable_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowDelete_Public_get_Boolean_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowEdit_Public_get_Boolean_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowNew_Public_get_Boolean_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_get_CountFromIndex_Private_get_Int32_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_get_DataViewManager_Public_get_DataViewManager_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Protected_get_Boolean_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_get_RowStateFilter_Public_get_DataViewRowState_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_get_Sort_Public_get_String_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_set_Sort_Public_set_Void_String_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_get_SortComparison_Internal_get_Comparison_1_DataRow_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Public_get_DataTable_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_DataRowView_Int32_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_AddNew_Public_Virtual_New_DataRowView_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_CheckOpen_Private_Void_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_CheckSort_Private_Void_String_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Void_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_DataRowView_Int32_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_Int32_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Internal_Void_DataRow_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_FinishAddNew_Internal_Void_Boolean_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Int32_DataRowView_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfDataRowView_Private_Int32_DataRowView_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_GetFindIndex_Internal_Index_String_Boolean_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowNew_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddNew_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowEdit_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowRemove_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsChangeNotification_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSearching_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSorting_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_IsSorted_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortProperty_Private_Virtual_Final_New_get_PropertyDescriptor_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_GetSortProperty_Internal_PropertyDescriptor_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortDirection_Private_Virtual_Final_New_get_ListSortDirection_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_ApplySort_Private_Virtual_Final_New_Void_PropertyDescriptor_ListSortDirection_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_Find_Private_Virtual_Final_New_Int32_PropertyDescriptor_Object_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveSort_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_CreateSortString_Private_String_PropertyDescriptor_ListSortDirection_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetListName_Private_Virtual_Final_New_String_Il2CppReferenceArray_1_PropertyDescriptor_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetItemProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_PropertyDescriptor_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_GetFilter_Internal_Virtual_New_IFilter_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_GetRecord_Private_Int32_Int32_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_GetRow_Internal_DataRow_Int32_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_GetRowView_Private_DataRowView_Int32_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_GetRowView_Private_DataRowView_DataRow_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_IndexListChanged_Protected_Virtual_New_Void_Object_ListChangedEventArgs_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_IndexListChangedInternal_Internal_Void_ListChangedEventArgs_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_MaintainDataView_Internal_Void_ListChangedType_DataRow_Boolean_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_OnListChanged_Protected_Virtual_New_Void_ListChangedEventArgs_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Protected_Void_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_ResetRowViewCache_Internal_Void_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_SetDataViewManager_Internal_Void_DataViewManager_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Internal_Virtual_New_Void_String_DataViewRowState_IFilter_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex2_Internal_Void_String_DataViewRowState_IFilter_Boolean_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIndex_Protected_Void_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIndex_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIndex_Internal_Void_Boolean_Boolean_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_ChildRelationCollectionChanged_Internal_Void_Object_CollectionChangeEventArgs_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_ParentRelationCollectionChanged_Internal_Void_Object_CollectionChangeEventArgs_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_ColumnCollectionChanged_Protected_Virtual_New_Void_Object_CollectionChangeEventArgs_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_ColumnCollectionChangedInternal_Internal_Void_Object_CollectionChangeEventArgs_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0;

		// Token: 0x020000E0 RID: 224
		public sealed class DataRowReferenceComparer : Object
		{
			// Token: 0x0600149C RID: 5276 RVA: 0x000626F8 File Offset: 0x000608F8
			// Note: this type is marked as 'beforefieldinit'.
			static DataRowReferenceComparer()
			{
				Il2CppClassPointerStore<DataView.DataRowReferenceComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataView>.NativeClassPtr, "DataRowReferenceComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataView.DataRowReferenceComparer>.NativeClassPtr);
				DataView.DataRowReferenceComparer.NativeFieldInfoPtr_s_default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataView.DataRowReferenceComparer>.NativeClassPtr, "s_default");
				DataView.DataRowReferenceComparer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView.DataRowReferenceComparer>.NativeClassPtr, 100664617);
				DataView.DataRowReferenceComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DataRow_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView.DataRowReferenceComparer>.NativeClassPtr, 100664618);
				DataView.DataRowReferenceComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataView.DataRowReferenceComparer>.NativeClassPtr, 100664619);
			}

			// Token: 0x0600149D RID: 5277 RVA: 0x00062774 File Offset: 0x00060974
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataRowReferenceComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataView.DataRowReferenceComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.DataRowReferenceComparer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600149E RID: 5278 RVA: 0x000627B0 File Offset: 0x000609B0
			[CallerCount(0)]
			public unsafe bool Equals(DataRow x, DataRow y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.DataRowReferenceComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DataRow_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600149F RID: 5279 RVA: 0x00062810 File Offset: 0x00060A10
			[CallerCount(0)]
			public unsafe int GetHashCode(DataRow obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataView.DataRowReferenceComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060014A0 RID: 5280 RVA: 0x00007C17 File Offset: 0x00005E17
			public DataRowReferenceComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004AE RID: 1198
			// (get) Token: 0x060014A1 RID: 5281 RVA: 0x00062860 File Offset: 0x00060A60
			// (set) Token: 0x060014A2 RID: 5282 RVA: 0x00007C20 File Offset: 0x00005E20
			public unsafe static DataView.DataRowReferenceComparer s_default
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataView.DataRowReferenceComparer.NativeFieldInfoPtr_s_default, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataView.DataRowReferenceComparer>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataView.DataRowReferenceComparer.NativeFieldInfoPtr_s_default, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400111C RID: 4380
			private static readonly IntPtr NativeFieldInfoPtr_s_default;

			// Token: 0x0400111D RID: 4381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x0400111E RID: 4382
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DataRow_DataRow_0;

			// Token: 0x0400111F RID: 4383
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_DataRow_0;
		}
	}
}
