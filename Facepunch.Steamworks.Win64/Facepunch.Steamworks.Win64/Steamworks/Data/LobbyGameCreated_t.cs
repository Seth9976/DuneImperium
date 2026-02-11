using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000111 RID: 273
	[StructLayout(2)]
	public struct LobbyGameCreated_t
	{
		// Token: 0x06000FEA RID: 4074 RVA: 0x0005E8E8 File Offset: 0x0005CAE8
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGameCreated_t()
		{
			Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LobbyGameCreated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr);
			LobbyGameCreated_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "SteamIDLobby");
			LobbyGameCreated_t.NativeFieldInfoPtr_SteamIDGameServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "SteamIDGameServer");
			LobbyGameCreated_t.NativeFieldInfoPtr_IP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "IP");
			LobbyGameCreated_t.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "Port");
			LobbyGameCreated_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "_datasize");
			LobbyGameCreated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, 100666879);
			LobbyGameCreated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, 100666880);
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x0005E9A4 File Offset: 0x0005CBA4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950335, XrefRangeEnd = 950339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGameCreated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0005E9D4 File Offset: 0x0005CBD4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGameCreated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00004676 File Offset: 0x00002876
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0005EA04 File Offset: 0x0005CC04
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00004688 File Offset: 0x00002888
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyGameCreated_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyGameCreated_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDGameServer;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeFieldInfoPtr_IP;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeFieldInfoPtr_Port;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001637 RID: 5687
		[FieldOffset(0)]
		public ulong SteamIDLobby;

		// Token: 0x04001638 RID: 5688
		[FieldOffset(8)]
		public ulong SteamIDGameServer;

		// Token: 0x04001639 RID: 5689
		[FieldOffset(16)]
		public uint IP;

		// Token: 0x0400163A RID: 5690
		[FieldOffset(20)]
		public ushort Port;
	}
}
