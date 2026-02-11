using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000049 RID: 73
	public sealed class DataViewManagerListItemTypeDescriptor : Object
	{
		// Token: 0x06000800 RID: 2048 RVA: 0x0002B44C File Offset: 0x0002964C
		// Note: this type is marked as 'beforefieldinit'.
		static DataViewManagerListItemTypeDescriptor()
		{
			Il2CppClassPointerStore<DataViewManagerListItemTypeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataViewManagerListItemTypeDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataViewManagerListItemTypeDescriptor>.NativeClassPtr);
			DataViewManagerListItemTypeDescriptor.NativeFieldInfoPtr__dataViewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewManagerListItemTypeDescriptor>.NativeClassPtr, "_dataViewManager");
			DataViewManagerListItemTypeDescriptor.NativeMethodInfoPtr_GetDataView_Internal_DataView_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewManagerListItemTypeDescriptor>.NativeClassPtr, 100664636);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0002B4A4 File Offset: 0x000296A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902760, XrefRangeEnd = 902768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataView GetDataView(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewManagerListItemTypeDescriptor.NativeMethodInfoPtr_GetDataView_Internal_DataView_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataView>(intPtr3) : null;
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0000461C File Offset: 0x0000281C
		public DataViewManagerListItemTypeDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x0002B4F4 File Offset: 0x000296F4
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00004625 File Offset: 0x00002825
		public unsafe DataViewManager _dataViewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewManagerListItemTypeDescriptor.NativeFieldInfoPtr__dataViewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewManagerListItemTypeDescriptor.NativeFieldInfoPtr__dataViewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr__dataViewManager;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_GetDataView_Internal_DataView_DataTable_0;
	}
}
