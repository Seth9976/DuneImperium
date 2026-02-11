using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200019E RID: 414
	[StructLayout(2)]
	public struct SteamRemotePlaySessionConnected_t
	{
		// Token: 0x06001494 RID: 5268 RVA: 0x0006A924 File Offset: 0x00068B24
		// Note: this type is marked as 'beforefieldinit'.
		static SteamRemotePlaySessionConnected_t()
		{
			Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamRemotePlaySessionConnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr);
			SteamRemotePlaySessionConnected_t.NativeFieldInfoPtr_SessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr, "SessionID");
			SteamRemotePlaySessionConnected_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr, "_datasize");
			SteamRemotePlaySessionConnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr, 100667316);
			SteamRemotePlaySessionConnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr, 100667317);
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0006A9A4 File Offset: 0x00068BA4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950964, XrefRangeEnd = 950968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlaySessionConnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x0006A9D4 File Offset: 0x00068BD4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlaySessionConnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000069E6 File Offset: 0x00004BE6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0006AA04 File Offset: 0x00068C04
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x000069F8 File Offset: 0x00004BF8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamRemotePlaySessionConnected_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamRemotePlaySessionConnected_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeFieldInfoPtr_SessionID;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A64 RID: 6756
		[FieldOffset(0)]
		public uint SessionID;
	}
}
