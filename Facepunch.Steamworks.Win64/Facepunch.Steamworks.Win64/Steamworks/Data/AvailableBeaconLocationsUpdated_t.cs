using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000122 RID: 290
	[StructLayout(2)]
	public struct AvailableBeaconLocationsUpdated_t
	{
		// Token: 0x0600105A RID: 4186 RVA: 0x0005FDA8 File Offset: 0x0005DFA8
		// Note: this type is marked as 'beforefieldinit'.
		static AvailableBeaconLocationsUpdated_t()
		{
			Il2CppClassPointerStore<AvailableBeaconLocationsUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "AvailableBeaconLocationsUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvailableBeaconLocationsUpdated_t>.NativeClassPtr);
			AvailableBeaconLocationsUpdated_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvailableBeaconLocationsUpdated_t>.NativeClassPtr, "_datasize");
			AvailableBeaconLocationsUpdated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvailableBeaconLocationsUpdated_t>.NativeClassPtr, 100666931);
			AvailableBeaconLocationsUpdated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvailableBeaconLocationsUpdated_t>.NativeClassPtr, 100666932);
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x0005FE14 File Offset: 0x0005E014
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950408, XrefRangeEnd = 950412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvailableBeaconLocationsUpdated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0005FE44 File Offset: 0x0005E044
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvailableBeaconLocationsUpdated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0000490F File Offset: 0x00002B0F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AvailableBeaconLocationsUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x0005FE74 File Offset: 0x0005E074
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x00004921 File Offset: 0x00002B21
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AvailableBeaconLocationsUpdated_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvailableBeaconLocationsUpdated_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
