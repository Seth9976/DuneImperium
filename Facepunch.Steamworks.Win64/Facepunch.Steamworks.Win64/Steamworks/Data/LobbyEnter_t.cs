using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200010D RID: 269
	[StructLayout(2)]
	public struct LobbyEnter_t
	{
		// Token: 0x06000FD2 RID: 4050 RVA: 0x0005E41C File Offset: 0x0005C61C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyEnter_t()
		{
			Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LobbyEnter_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr);
			LobbyEnter_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "SteamIDLobby");
			LobbyEnter_t.NativeFieldInfoPtr_GfChatPermissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "GfChatPermissions");
			LobbyEnter_t.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "Locked");
			LobbyEnter_t.NativeFieldInfoPtr_EChatRoomEnterResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "EChatRoomEnterResponse");
			LobbyEnter_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "_datasize");
			LobbyEnter_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, 100666867);
			LobbyEnter_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, 100666868);
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x0005E4D8 File Offset: 0x0005C6D8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950319, XrefRangeEnd = 950323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyEnter_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0005E508 File Offset: 0x0005C708
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyEnter_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000045F6 File Offset: 0x000027F6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0005E538 File Offset: 0x0005C738
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00004608 File Offset: 0x00002808
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyEnter_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyEnter_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeFieldInfoPtr_GfChatPermissions;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeFieldInfoPtr_Locked;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeFieldInfoPtr_EChatRoomEnterResponse;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400160D RID: 5645
		[FieldOffset(0)]
		public ulong SteamIDLobby;

		// Token: 0x0400160E RID: 5646
		[FieldOffset(8)]
		public uint GfChatPermissions;

		// Token: 0x0400160F RID: 5647
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool Locked;

		// Token: 0x04001610 RID: 5648
		[FieldOffset(16)]
		public uint EChatRoomEnterResponse;
	}
}
