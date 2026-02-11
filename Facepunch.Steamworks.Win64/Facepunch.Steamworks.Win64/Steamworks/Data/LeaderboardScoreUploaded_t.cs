using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000142 RID: 322
	[StructLayout(2)]
	public struct LeaderboardScoreUploaded_t
	{
		// Token: 0x060011A5 RID: 4517 RVA: 0x0006316C File Offset: 0x0006136C
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardScoreUploaded_t()
		{
			Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LeaderboardScoreUploaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr);
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "Success");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_SteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "SteamLeaderboard");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "Score");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_ScoreChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "ScoreChanged");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_GlobalRankNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "GlobalRankNew");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_GlobalRankPrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "GlobalRankPrevious");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "_datasize");
			LeaderboardScoreUploaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, 100667035);
			LeaderboardScoreUploaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, 100667036);
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00063250 File Offset: 0x00061450
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950570, XrefRangeEnd = 950574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardScoreUploaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00063280 File Offset: 0x00061480
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardScoreUploaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0000540F File Offset: 0x0000360F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000632B0 File Offset: 0x000614B0
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x00005421 File Offset: 0x00003621
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardScoreUploaded_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardScoreUploaded_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeFieldInfoPtr_Success;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeFieldInfoPtr_SteamLeaderboard;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeFieldInfoPtr_Score;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeFieldInfoPtr_ScoreChanged;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeFieldInfoPtr_GlobalRankNew;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeFieldInfoPtr_GlobalRankPrevious;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040017E2 RID: 6114
		[FieldOffset(0)]
		public byte Success;

		// Token: 0x040017E3 RID: 6115
		[FieldOffset(8)]
		public ulong SteamLeaderboard;

		// Token: 0x040017E4 RID: 6116
		[FieldOffset(16)]
		public int Score;

		// Token: 0x040017E5 RID: 6117
		[FieldOffset(20)]
		public byte ScoreChanged;

		// Token: 0x040017E6 RID: 6118
		[FieldOffset(24)]
		public int GlobalRankNew;

		// Token: 0x040017E7 RID: 6119
		[FieldOffset(28)]
		public int GlobalRankPrevious;
	}
}
