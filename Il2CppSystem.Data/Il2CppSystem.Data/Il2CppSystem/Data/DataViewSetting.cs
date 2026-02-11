using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x0200004B RID: 75
	public class DataViewSetting : Object
	{
		// Token: 0x06000805 RID: 2053 RVA: 0x0002B524 File Offset: 0x00029724
		// Note: this type is marked as 'beforefieldinit'.
		static DataViewSetting()
		{
			Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataViewSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr);
			DataViewSetting.NativeFieldInfoPtr__dataViewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, "_dataViewManager");
			DataViewSetting.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, "_table");
			DataViewSetting.NativeFieldInfoPtr__sort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, "_sort");
			DataViewSetting.NativeFieldInfoPtr__rowFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, "_rowFilter");
			DataViewSetting.NativeFieldInfoPtr__rowStateFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, "_rowStateFilter");
			DataViewSetting.NativeFieldInfoPtr__applyDefaultSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, "_applyDefaultSort");
			DataViewSetting.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, 100664637);
			DataViewSetting.NativeMethodInfoPtr_get_ApplyDefaultSort_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, 100664638);
			DataViewSetting.NativeMethodInfoPtr_SetDataViewManager_Internal_Void_DataViewManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, 100664639);
			DataViewSetting.NativeMethodInfoPtr_SetDataTable_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, 100664640);
			DataViewSetting.NativeMethodInfoPtr_get_RowFilter_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, 100664641);
			DataViewSetting.NativeMethodInfoPtr_get_RowStateFilter_Public_get_DataViewRowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, 100664642);
			DataViewSetting.NativeMethodInfoPtr_get_Sort_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr, 100664643);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0002B658 File Offset: 0x00029858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902768, XrefRangeEnd = 902774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataViewSetting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataViewSetting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewSetting.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x0002B694 File Offset: 0x00029894
		public unsafe bool ApplyDefaultSort
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewSetting.NativeMethodInfoPtr_get_ApplyDefaultSort_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0002B6D0 File Offset: 0x000298D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDataViewManager(DataViewManager dataViewManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataViewManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewSetting.NativeMethodInfoPtr_SetDataViewManager_Internal_Void_DataViewManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0002B714 File Offset: 0x00029914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902774, XrefRangeEnd = 902775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDataTable(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewSetting.NativeMethodInfoPtr_SetDataTable_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0002B758 File Offset: 0x00029958
		public unsafe string RowFilter
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewSetting.NativeMethodInfoPtr_get_RowFilter_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0002B790 File Offset: 0x00029990
		public unsafe DataViewRowState RowStateFilter
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewSetting.NativeMethodInfoPtr_get_RowStateFilter_Public_get_DataViewRowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0002B7CC File Offset: 0x000299CC
		public unsafe string Sort
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewSetting.NativeMethodInfoPtr_get_Sort_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00004644 File Offset: 0x00002844
		public DataViewSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x0002B804 File Offset: 0x00029A04
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0000464D File Offset: 0x0000284D
		public unsafe DataViewManager _dataViewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__dataViewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__dataViewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x0002B834 File Offset: 0x00029A34
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x0000466C File Offset: 0x0000286C
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0002B864 File Offset: 0x00029A64
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x0000468B File Offset: 0x0000288B
		public unsafe string _sort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__sort);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__sort), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0002B88C File Offset: 0x00029A8C
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x000046AA File Offset: 0x000028AA
		public unsafe string _rowFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__rowFilter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__rowFilter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0002B8B4 File Offset: 0x00029AB4
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x000046C9 File Offset: 0x000028C9
		public unsafe DataViewRowState _rowStateFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__rowStateFilter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__rowStateFilter)) = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x0002B8DC File Offset: 0x00029ADC
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x000046E4 File Offset: 0x000028E4
		public unsafe bool _applyDefaultSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__applyDefaultSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSetting.NativeFieldInfoPtr__applyDefaultSort)) = value;
			}
		}

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeFieldInfoPtr__dataViewManager;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeFieldInfoPtr__sort;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeFieldInfoPtr__rowFilter;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr__rowStateFilter;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr__applyDefaultSort;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplyDefaultSort_Public_get_Boolean_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_SetDataViewManager_Internal_Void_DataViewManager_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_SetDataTable_Internal_Void_DataTable_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_get_RowFilter_Public_get_String_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_get_RowStateFilter_Public_get_DataViewRowState_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_get_Sort_Public_get_String_0;
	}
}
