using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200017D RID: 381
	[StructLayout(2)]
	public struct SteamAppUninstalled_t
	{
		// Token: 0x06001342 RID: 4930 RVA: 0x000676B4 File Offset: 0x000658B4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAppUninstalled_t()
		{
			Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamAppUninstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr);
			SteamAppUninstalled_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, "AppID");
			SteamAppUninstalled_t.NativeFieldInfoPtr_InstallFolderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, "InstallFolderIndex");
			SteamAppUninstalled_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, "_datasize");
			SteamAppUninstalled_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, 100667215);
			SteamAppUninstalled_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, 100667216);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x00067748 File Offset: 0x00065948
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950823, XrefRangeEnd = 950827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAppUninstalled_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x00067778 File Offset: 0x00065978
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAppUninstalled_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00005E6F File Offset: 0x0000406F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x000677A8 File Offset: 0x000659A8
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x00005E81 File Offset: 0x00004081
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamAppUninstalled_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAppUninstalled_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeFieldInfoPtr_InstallFolderIndex;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001975 RID: 6517
		[FieldOffset(0)]
		public AppId AppID;

		// Token: 0x04001976 RID: 6518
		[FieldOffset(4)]
		public int InstallFolderIndex;
	}
}
