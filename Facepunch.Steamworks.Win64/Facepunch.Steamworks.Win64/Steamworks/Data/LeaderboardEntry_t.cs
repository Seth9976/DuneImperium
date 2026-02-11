using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001C0 RID: 448
	[StructLayout(2)]
	public struct LeaderboardEntry_t
	{
		// Token: 0x060016A3 RID: 5795 RVA: 0x00070194 File Offset: 0x0006E394
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardEntry_t()
		{
			Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LeaderboardEntry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr);
			LeaderboardEntry_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "SteamIDUser");
			LeaderboardEntry_t.NativeFieldInfoPtr_GlobalRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "GlobalRank");
			LeaderboardEntry_t.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "Score");
			LeaderboardEntry_t.NativeFieldInfoPtr_CDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "CDetails");
			LeaderboardEntry_t.NativeFieldInfoPtr_UGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "UGC");
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00007790 File Offset: 0x00005990
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeFieldInfoPtr_GlobalRank;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeFieldInfoPtr_Score;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeFieldInfoPtr_CDetails;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeFieldInfoPtr_UGC;

		// Token: 0x04001C20 RID: 7200
		[FieldOffset(0)]
		public ulong SteamIDUser;

		// Token: 0x04001C21 RID: 7201
		[FieldOffset(8)]
		public int GlobalRank;

		// Token: 0x04001C22 RID: 7202
		[FieldOffset(12)]
		public int Score;

		// Token: 0x04001C23 RID: 7203
		[FieldOffset(16)]
		public int CDetails;

		// Token: 0x04001C24 RID: 7204
		[FieldOffset(24)]
		public ulong UGC;
	}
}
