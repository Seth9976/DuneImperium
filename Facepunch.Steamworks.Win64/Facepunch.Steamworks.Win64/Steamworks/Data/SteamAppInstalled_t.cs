using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200017C RID: 380
	[StructLayout(2)]
	public struct SteamAppInstalled_t
	{
		// Token: 0x0600133C RID: 4924 RVA: 0x000675A4 File Offset: 0x000657A4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAppInstalled_t()
		{
			Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamAppInstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr);
			SteamAppInstalled_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, "AppID");
			SteamAppInstalled_t.NativeFieldInfoPtr_InstallFolderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, "InstallFolderIndex");
			SteamAppInstalled_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, "_datasize");
			SteamAppInstalled_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, 100667212);
			SteamAppInstalled_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, 100667213);
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00067638 File Offset: 0x00065838
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950819, XrefRangeEnd = 950823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAppInstalled_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x00067668 File Offset: 0x00065868
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAppInstalled_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00005E4F File Offset: 0x0000404F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x00067698 File Offset: 0x00065898
		// (set) Token: 0x06001341 RID: 4929 RVA: 0x00005E61 File Offset: 0x00004061
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamAppInstalled_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAppInstalled_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeFieldInfoPtr_InstallFolderIndex;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400196E RID: 6510
		[FieldOffset(0)]
		public AppId AppID;

		// Token: 0x0400196F RID: 6511
		[FieldOffset(4)]
		public int InstallFolderIndex;
	}
}
