using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200010E RID: 270
	[StructLayout(2)]
	public struct LobbyDataUpdate_t
	{
		// Token: 0x06000FD8 RID: 4056 RVA: 0x0005E554 File Offset: 0x0005C754
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyDataUpdate_t()
		{
			Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LobbyDataUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr);
			LobbyDataUpdate_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "SteamIDLobby");
			LobbyDataUpdate_t.NativeFieldInfoPtr_SteamIDMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "SteamIDMember");
			LobbyDataUpdate_t.NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "Success");
			LobbyDataUpdate_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "_datasize");
			LobbyDataUpdate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, 100666870);
			LobbyDataUpdate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, 100666871);
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x0005E5FC File Offset: 0x0005C7FC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950323, XrefRangeEnd = 950327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyDataUpdate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0005E62C File Offset: 0x0005C82C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyDataUpdate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00004616 File Offset: 0x00002816
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0005E65C File Offset: 0x0005C85C
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00004628 File Offset: 0x00002828
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyDataUpdate_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyDataUpdate_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDMember;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeFieldInfoPtr_Success;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001617 RID: 5655
		[FieldOffset(0)]
		public ulong SteamIDLobby;

		// Token: 0x04001618 RID: 5656
		[FieldOffset(8)]
		public ulong SteamIDMember;

		// Token: 0x04001619 RID: 5657
		[FieldOffset(16)]
		public byte Success;
	}
}
