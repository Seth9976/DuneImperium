using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Data
{
	// Token: 0x02000048 RID: 72
	public class DataViewManager : MarshalByValueComponent
	{
		// Token: 0x060007F7 RID: 2039 RVA: 0x0002B30C File Offset: 0x0002950C
		// Note: this type is marked as 'beforefieldinit'.
		static DataViewManager()
		{
			Il2CppClassPointerStore<DataViewManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataViewManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataViewManager>.NativeClassPtr);
			DataViewManager.NativeFieldInfoPtr__dataViewSettingsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewManager>.NativeClassPtr, "_dataViewSettingsCollection");
			DataViewManager.NativeFieldInfoPtr__nViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewManager>.NativeClassPtr, "_nViews");
			DataViewManager.NativeFieldInfoPtr_s_notSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewManager>.NativeClassPtr, "s_notSupported");
			DataViewManager.NativeMethodInfoPtr_get_DataViewSettings_Public_get_DataViewSettingCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewManager>.NativeClassPtr, 100664634);
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0002B38C File Offset: 0x0002958C
		public unsafe DataViewSettingCollection DataViewSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewManager.NativeMethodInfoPtr_get_DataViewSettings_Public_get_DataViewSettingCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataViewSettingCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000045C7 File Offset: 0x000027C7
		public DataViewManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0002B3CC File Offset: 0x000295CC
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x000045D0 File Offset: 0x000027D0
		public unsafe DataViewSettingCollection _dataViewSettingsCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewManager.NativeFieldInfoPtr__dataViewSettingsCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataViewSettingCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewManager.NativeFieldInfoPtr__dataViewSettingsCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0002B3FC File Offset: 0x000295FC
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x000045EF File Offset: 0x000027EF
		public unsafe int _nViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewManager.NativeFieldInfoPtr__nViews);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewManager.NativeFieldInfoPtr__nViews)) = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0002B424 File Offset: 0x00029624
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0000460A File Offset: 0x0000280A
		public unsafe static NotSupportedException s_notSupported
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataViewManager.NativeFieldInfoPtr_s_notSupported, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotSupportedException>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataViewManager.NativeFieldInfoPtr_s_notSupported, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeFieldInfoPtr__dataViewSettingsCollection;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeFieldInfoPtr__nViews;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeFieldInfoPtr_s_notSupported;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_get_DataViewSettings_Public_get_DataViewSettingCollection_0;
	}
}
