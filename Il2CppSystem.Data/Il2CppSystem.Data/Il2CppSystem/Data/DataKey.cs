using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x0200002E RID: 46
	public sealed class DataKey : ValueType
	{
		// Token: 0x06000597 RID: 1431 RVA: 0x000214E0 File Offset: 0x0001F6E0
		// Note: this type is marked as 'beforefieldinit'.
		static DataKey()
		{
			Il2CppClassPointerStore<DataKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataKey>.NativeClassPtr);
			DataKey.NativeFieldInfoPtr__columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataKey>.NativeClassPtr, "_columns");
			DataKey.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_DataColumn_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664252);
			DataKey.NativeMethodInfoPtr_get_ColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664253);
			DataKey.NativeMethodInfoPtr_get_HasValue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664254);
			DataKey.NativeMethodInfoPtr_get_Table_Internal_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664255);
			DataKey.NativeMethodInfoPtr_CheckState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664256);
			DataKey.NativeMethodInfoPtr_ColumnsEqual_Internal_Boolean_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664257);
			DataKey.NativeMethodInfoPtr_ColumnsEqual_Internal_Static_Boolean_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664258);
			DataKey.NativeMethodInfoPtr_ContainsColumn_Internal_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664259);
			DataKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664260);
			DataKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664261);
			DataKey.NativeMethodInfoPtr_Equals_Internal_Boolean_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664262);
			DataKey.NativeMethodInfoPtr_GetColumnNames_Internal_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664263);
			DataKey.NativeMethodInfoPtr_GetIndexDesc_Internal_Il2CppReferenceArray_1_IndexField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664264);
			DataKey.NativeMethodInfoPtr_GetKeyValues_Internal_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664265);
			DataKey.NativeMethodInfoPtr_GetSortIndex_Internal_Index_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664266);
			DataKey.NativeMethodInfoPtr_GetSortIndex_Internal_Index_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664267);
			DataKey.NativeMethodInfoPtr_RecordsEqual_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664268);
			DataKey.NativeMethodInfoPtr_ToArray_Internal_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKey>.NativeClassPtr, 100664269);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0002168C File Offset: 0x0001F88C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 899275, RefRangeEnd = 899287, XrefRangeStart = 899239, XrefRangeEnd = 899275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataKey(Il2CppReferenceArray<DataColumn> columns, bool copyColumns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyColumns;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_DataColumn_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x000216EC File Offset: 0x0001F8EC
		public unsafe Il2CppReferenceArray<DataColumn> ColumnsReference
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_get_ColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00021730 File Offset: 0x0001F930
		public unsafe bool HasValue
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 608772, RefRangeEnd = 608784, XrefRangeStart = 608772, XrefRangeEnd = 608784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_get_HasValue_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00021774 File Offset: 0x0001F974
		public unsafe DataTable Table
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 899287, RefRangeEnd = 899308, XrefRangeStart = 899287, XrefRangeEnd = 899287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_get_Table_Internal_get_DataTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000217B8 File Offset: 0x0001F9B8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 899309, RefRangeEnd = 899317, XrefRangeStart = 899308, XrefRangeEnd = 899309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_CheckState_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000217F0 File Offset: 0x0001F9F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 899320, RefRangeEnd = 899328, XrefRangeStart = 899317, XrefRangeEnd = 899320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ColumnsEqual(DataKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_ColumnsEqual_Internal_Boolean_DataKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00021848 File Offset: 0x0001FA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899328, XrefRangeEnd = 899331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ColumnsEqual(Il2CppReferenceArray<DataColumn> column1, Il2CppReferenceArray<DataColumn> column2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_ColumnsEqual_Internal_Static_Boolean_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0002189C File Offset: 0x0001FA9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 899332, RefRangeEnd = 899338, XrefRangeStart = 899331, XrefRangeEnd = 899332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsColumn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_ContainsColumn_Internal_Boolean_DataColumn_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000218F0 File Offset: 0x0001FAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899338, XrefRangeEnd = 899342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00021934 File Offset: 0x0001FB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899342, XrefRangeEnd = 899348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00021988 File Offset: 0x0001FB88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 899349, RefRangeEnd = 899350, XrefRangeStart = 899348, XrefRangeEnd = 899349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DataKey value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_Equals_Internal_Boolean_DataKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000219E0 File Offset: 0x0001FBE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 899355, RefRangeEnd = 899360, XrefRangeStart = 899350, XrefRangeEnd = 899355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetColumnNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_GetColumnNames_Internal_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00021A24 File Offset: 0x0001FC24
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 899366, RefRangeEnd = 899374, XrefRangeStart = 899360, XrefRangeEnd = 899366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<IndexField> GetIndexDesc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_GetIndexDesc_Internal_Il2CppReferenceArray_1_IndexField_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IndexField>>(intPtr3) : null;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00021A68 File Offset: 0x0001FC68
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 899381, RefRangeEnd = 899393, XrefRangeStart = 899374, XrefRangeEnd = 899381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetKeyValues(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_GetKeyValues_Internal_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00021ABC File Offset: 0x0001FCBC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 899395, RefRangeEnd = 899403, XrefRangeStart = 899393, XrefRangeEnd = 899395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Index GetSortIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_GetSortIndex_Internal_Index_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Index>(intPtr3) : null;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00021B00 File Offset: 0x0001FD00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 899405, RefRangeEnd = 899410, XrefRangeStart = 899403, XrefRangeEnd = 899405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Index GetSortIndex(DataViewRowState recordStates)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordStates;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_GetSortIndex_Internal_Index_DataViewRowState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Index>(intPtr3) : null;
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00021B54 File Offset: 0x0001FD54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 899412, RefRangeEnd = 899415, XrefRangeStart = 899410, XrefRangeEnd = 899412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RecordsEqual(int record1, int record2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_RecordsEqual_Internal_Boolean_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00021BB0 File Offset: 0x0001FDB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 899421, RefRangeEnd = 899428, XrefRangeStart = 899415, XrefRangeEnd = 899421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataColumn> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataKey.NativeMethodInfoPtr_ToArray_Internal_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000392A File Offset: 0x00001B2A
		public DataKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00003933 File Offset: 0x00001B33
		public DataKey()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataKey>.NativeClassPtr))
		{
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00021BF4 File Offset: 0x0001FDF4
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00003945 File Offset: 0x00001B45
		public unsafe Il2CppReferenceArray<DataColumn> _columns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataKey.NativeFieldInfoPtr__columns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataKey.NativeFieldInfoPtr__columns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeFieldInfoPtr__columns;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_DataColumn_Boolean_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnsReference_Internal_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValue_Internal_get_Boolean_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Internal_get_DataTable_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_CheckState_Internal_Void_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_ColumnsEqual_Internal_Boolean_DataKey_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_ColumnsEqual_Internal_Static_Boolean_Il2CppReferenceArray_1_DataColumn_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_ContainsColumn_Internal_Boolean_DataColumn_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Internal_Boolean_DataKey_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnNames_Internal_Il2CppStringArray_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexDesc_Internal_Il2CppReferenceArray_1_IndexField_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyValues_Internal_Il2CppReferenceArray_1_Object_Int32_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_GetSortIndex_Internal_Index_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_GetSortIndex_Internal_Index_DataViewRowState_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_RecordsEqual_Internal_Boolean_Int32_Int32_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Internal_Il2CppReferenceArray_1_DataColumn_0;
	}
}
