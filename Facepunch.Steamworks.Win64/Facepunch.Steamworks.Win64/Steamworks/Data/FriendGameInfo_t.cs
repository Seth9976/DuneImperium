using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001BD RID: 445
	[StructLayout(2)]
	public struct FriendGameInfo_t
	{
		// Token: 0x0600169D RID: 5789 RVA: 0x00070050 File Offset: 0x0006E250
		// Note: this type is marked as 'beforefieldinit'.
		static FriendGameInfo_t()
		{
			Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FriendGameInfo_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr);
			FriendGameInfo_t.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "GameID");
			FriendGameInfo_t.NativeFieldInfoPtr_GameIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "GameIP");
			FriendGameInfo_t.NativeFieldInfoPtr_GamePort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "GamePort");
			FriendGameInfo_t.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "QueryPort");
			FriendGameInfo_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "SteamIDLobby");
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0000775A File Offset: 0x0000595A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeFieldInfoPtr_GameIP;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeFieldInfoPtr_GamePort;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeFieldInfoPtr_QueryPort;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x04001C0E RID: 7182
		[FieldOffset(0)]
		public GameId GameID;

		// Token: 0x04001C0F RID: 7183
		[FieldOffset(8)]
		public uint GameIP;

		// Token: 0x04001C10 RID: 7184
		[FieldOffset(12)]
		public ushort GamePort;

		// Token: 0x04001C11 RID: 7185
		[FieldOffset(14)]
		public ushort QueryPort;

		// Token: 0x04001C12 RID: 7186
		[FieldOffset(16)]
		public ulong SteamIDLobby;
	}
}
