using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000141 RID: 321
	[StructLayout(2)]
	public struct LeaderboardScoresDownloaded_t
	{
		// Token: 0x0600119F RID: 4511 RVA: 0x00063048 File Offset: 0x00061248
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardScoresDownloaded_t()
		{
			Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LeaderboardScoresDownloaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr);
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_SteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "SteamLeaderboard");
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_SteamLeaderboardEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "SteamLeaderboardEntries");
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_CEntryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "CEntryCount");
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "_datasize");
			LeaderboardScoresDownloaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, 100667032);
			LeaderboardScoresDownloaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, 100667033);
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x000630F0 File Offset: 0x000612F0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950566, XrefRangeEnd = 950570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardScoresDownloaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00063120 File Offset: 0x00061320
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardScoresDownloaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000053EF File Offset: 0x000035EF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00063150 File Offset: 0x00061350
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x00005401 File Offset: 0x00003601
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardScoresDownloaded_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardScoresDownloaded_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeFieldInfoPtr_SteamLeaderboard;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeFieldInfoPtr_SteamLeaderboardEntries;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeFieldInfoPtr_CEntryCount;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040017D6 RID: 6102
		[FieldOffset(0)]
		public ulong SteamLeaderboard;

		// Token: 0x040017D7 RID: 6103
		[FieldOffset(8)]
		public ulong SteamLeaderboardEntries;

		// Token: 0x040017D8 RID: 6104
		[FieldOffset(16)]
		public int CEntryCount;
	}
}
