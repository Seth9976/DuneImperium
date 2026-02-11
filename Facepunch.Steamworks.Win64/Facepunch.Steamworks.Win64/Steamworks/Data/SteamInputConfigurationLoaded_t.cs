using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000168 RID: 360
	[StructLayout(2)]
	public struct SteamInputConfigurationLoaded_t
	{
		// Token: 0x060012A6 RID: 4774 RVA: 0x00065B88 File Offset: 0x00063D88
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInputConfigurationLoaded_t()
		{
			Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamInputConfigurationLoaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr);
			SteamInputConfigurationLoaded_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, "AppID");
			SteamInputConfigurationLoaded_t.NativeFieldInfoPtr_DeviceHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, "DeviceHandle");
			SteamInputConfigurationLoaded_t.NativeFieldInfoPtr_MappingCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, "MappingCreator");
			SteamInputConfigurationLoaded_t.NativeFieldInfoPtr_MajorRevision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, "MajorRevision");
			SteamInputConfigurationLoaded_t.NativeFieldInfoPtr_MinorRevision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, "MinorRevision");
			SteamInputConfigurationLoaded_t.NativeFieldInfoPtr_UsesSteamInputAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, "UsesSteamInputAPI");
			SteamInputConfigurationLoaded_t.NativeFieldInfoPtr_UsesGamepadAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, "UsesGamepadAPI");
			SteamInputConfigurationLoaded_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, "_datasize");
			SteamInputConfigurationLoaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, 100667151);
			SteamInputConfigurationLoaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, 100667152);
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x00065C80 File Offset: 0x00063E80
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950731, XrefRangeEnd = 950735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInputConfigurationLoaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00065CB0 File Offset: 0x00063EB0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInputConfigurationLoaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00005A3A File Offset: 0x00003C3A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInputConfigurationLoaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x00065CE0 File Offset: 0x00063EE0
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x00005A4C File Offset: 0x00003C4C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInputConfigurationLoaded_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInputConfigurationLoaded_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeFieldInfoPtr_DeviceHandle;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeFieldInfoPtr_MappingCreator;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeFieldInfoPtr_MajorRevision;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeFieldInfoPtr_MinorRevision;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeFieldInfoPtr_UsesSteamInputAPI;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeFieldInfoPtr_UsesGamepadAPI;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040018C1 RID: 6337
		[FieldOffset(0)]
		public AppId AppID;

		// Token: 0x040018C2 RID: 6338
		[FieldOffset(4)]
		public ulong DeviceHandle;

		// Token: 0x040018C3 RID: 6339
		[FieldOffset(12)]
		public ulong MappingCreator;

		// Token: 0x040018C4 RID: 6340
		[FieldOffset(20)]
		public uint MajorRevision;

		// Token: 0x040018C5 RID: 6341
		[FieldOffset(24)]
		public uint MinorRevision;

		// Token: 0x040018C6 RID: 6342
		[FieldOffset(28)]
		[MarshalAs(4)]
		public bool UsesSteamInputAPI;

		// Token: 0x040018C7 RID: 6343
		[FieldOffset(29)]
		[MarshalAs(4)]
		public bool UsesGamepadAPI;
	}
}
