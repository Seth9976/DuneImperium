using System;
using boardgames.ranked.networking.responses;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.ranked.networking.notifications
{
	// Token: 0x02000018 RID: 24
	public class RankedSeasonEnded : NetworkMessageEvent
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x000050B8 File Offset: 0x000032B8
		// Note: this type is marked as 'beforefieldinit'.
		static RankedSeasonEnded()
		{
			Il2CppClassPointerStore<RankedSeasonEnded>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.notifications", "RankedSeasonEnded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedSeasonEnded>.NativeClassPtr);
			RankedSeasonEnded.NativeFieldInfoPtr_OldRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonEnded>.NativeClassPtr, "OldRank");
			RankedSeasonEnded.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonEnded>.NativeClassPtr, "Rank");
			RankedSeasonEnded.NativeFieldInfoPtr_EndedSeasonLeaderboardPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonEnded>.NativeClassPtr, "EndedSeasonLeaderboardPosition");
			RankedSeasonEnded.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedSeasonEnded>.NativeClassPtr, 100663329);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005138 File Offset: 0x00003338
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedSeasonEnded()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedSeasonEnded>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedSeasonEnded.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002808 File Offset: 0x00000A08
		public RankedSeasonEnded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00005174 File Offset: 0x00003374
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002811 File Offset: 0x00000A11
		public unsafe RankName OldRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEnded.NativeFieldInfoPtr_OldRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEnded.NativeFieldInfoPtr_OldRank)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000519C File Offset: 0x0000339C
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000282C File Offset: 0x00000A2C
		public unsafe RankName Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEnded.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEnded.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000051C4 File Offset: 0x000033C4
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002847 File Offset: 0x00000A47
		public unsafe RankedLeaderboardEntry EndedSeasonLeaderboardPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEnded.NativeFieldInfoPtr_EndedSeasonLeaderboardPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedLeaderboardEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEnded.NativeFieldInfoPtr_EndedSeasonLeaderboardPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_OldRank;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_EndedSeasonLeaderboardPosition;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
