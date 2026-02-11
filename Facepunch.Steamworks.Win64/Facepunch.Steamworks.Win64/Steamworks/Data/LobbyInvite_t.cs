using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200010C RID: 268
	[StructLayout(2)]
	public struct LobbyInvite_t
	{
		// Token: 0x06000FCC RID: 4044 RVA: 0x0005E2F8 File Offset: 0x0005C4F8
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyInvite_t()
		{
			Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LobbyInvite_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr);
			LobbyInvite_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "SteamIDUser");
			LobbyInvite_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "SteamIDLobby");
			LobbyInvite_t.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "GameID");
			LobbyInvite_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "_datasize");
			LobbyInvite_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, 100666864);
			LobbyInvite_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, 100666865);
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0005E3A0 File Offset: 0x0005C5A0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950315, XrefRangeEnd = 950319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInvite_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0005E3D0 File Offset: 0x0005C5D0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInvite_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x000045D6 File Offset: 0x000027D6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0005E400 File Offset: 0x0005C600
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x000045E8 File Offset: 0x000027E8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyInvite_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyInvite_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001603 RID: 5635
		[FieldOffset(0)]
		public ulong SteamIDUser;

		// Token: 0x04001604 RID: 5636
		[FieldOffset(8)]
		public ulong SteamIDLobby;

		// Token: 0x04001605 RID: 5637
		[FieldOffset(16)]
		public ulong GameID;
	}
}
