using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dbgclient.data
{
	// Token: 0x020000C7 RID: 199
	[Serializable]
	public class DailyChallengeLeaderboard : Object
	{
		// Token: 0x0600086D RID: 2157 RVA: 0x00038208 File Offset: 0x00036408
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeLeaderboard()
		{
			Il2CppClassPointerStore<DailyChallengeLeaderboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "DailyChallengeLeaderboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeLeaderboard>.NativeClassPtr);
			DailyChallengeLeaderboard.NativeFieldInfoPtr_playerScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboard>.NativeClassPtr, "playerScores");
			DailyChallengeLeaderboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboard>.NativeClassPtr, 100664546);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00038260 File Offset: 0x00036460
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeLeaderboard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeLeaderboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00005E86 File Offset: 0x00004086
		public DailyChallengeLeaderboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0003829C File Offset: 0x0003649C
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00005E8F File Offset: 0x0000408F
		public unsafe Il2CppReferenceArray<DailyChallengeLeaderboardEntry> playerScores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboard.NativeFieldInfoPtr_playerScores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DailyChallengeLeaderboardEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboard.NativeFieldInfoPtr_playerScores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeFieldInfoPtr_playerScores;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
