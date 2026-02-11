using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Data
{
	// Token: 0x0200004C RID: 76
	public class DataViewSettingCollection : Object
	{
		// Token: 0x0600081A RID: 2074 RVA: 0x0002B904 File Offset: 0x00029B04
		// Note: this type is marked as 'beforefieldinit'.
		static DataViewSettingCollection()
		{
			Il2CppClassPointerStore<DataViewSettingCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataViewSettingCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataViewSettingCollection>.NativeClassPtr);
			DataViewSettingCollection.NativeFieldInfoPtr__dataViewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewSettingCollection>.NativeClassPtr, "_dataViewManager");
			DataViewSettingCollection.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewSettingCollection>.NativeClassPtr, "_list");
			DataViewSettingCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_DataViewSetting_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewSettingCollection>.NativeClassPtr, 100664644);
			DataViewSettingCollection.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_DataTable_DataViewSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewSettingCollection>.NativeClassPtr, 100664645);
			DataViewSettingCollection.NativeMethodInfoPtr_Remove_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewSettingCollection>.NativeClassPtr, 100664646);
		}

		// Token: 0x17000222 RID: 546
		public unsafe virtual DataViewSetting this[DataTable table]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902775, XrefRangeEnd = 902785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataViewSettingCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_DataViewSetting_DataTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataViewSetting>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902785, XrefRangeEnd = 902792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataViewSettingCollection.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_DataTable_DataViewSetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0002BA54 File Offset: 0x00029C54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902793, RefRangeEnd = 902794, XrefRangeStart = 902792, XrefRangeEnd = 902793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewSettingCollection.NativeMethodInfoPtr_Remove_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000046FF File Offset: 0x000028FF
		public DataViewSettingCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0002BA98 File Offset: 0x00029C98
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00004708 File Offset: 0x00002908
		public unsafe DataViewManager _dataViewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSettingCollection.NativeFieldInfoPtr__dataViewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSettingCollection.NativeFieldInfoPtr__dataViewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0002BAC8 File Offset: 0x00029CC8
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00004727 File Offset: 0x00002927
		public unsafe Hashtable _list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSettingCollection.NativeFieldInfoPtr__list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewSettingCollection.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeFieldInfoPtr__dataViewManager;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeFieldInfoPtr__list;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_DataViewSetting_DataTable_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_DataTable_DataViewSetting_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_DataTable_0;
	}
}
