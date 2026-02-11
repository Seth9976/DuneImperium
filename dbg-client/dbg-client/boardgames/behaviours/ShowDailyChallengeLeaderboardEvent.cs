using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002B0 RID: 688
	public class ShowDailyChallengeLeaderboardEvent : MonoBehaviour
	{
		// Token: 0x06002099 RID: 8345 RVA: 0x0008A274 File Offset: 0x00088474
		// Note: this type is marked as 'beforefieldinit'.
		static ShowDailyChallengeLeaderboardEvent()
		{
			Il2CppClassPointerStore<ShowDailyChallengeLeaderboardEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "ShowDailyChallengeLeaderboardEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowDailyChallengeLeaderboardEvent>.NativeClassPtr);
			ShowDailyChallengeLeaderboardEvent.NativeFieldInfoPtr_showLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowDailyChallengeLeaderboardEvent>.NativeClassPtr, "showLeaderboard");
			ShowDailyChallengeLeaderboardEvent.NativeMethodInfoPtr_Event_ShowLeaderboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDailyChallengeLeaderboardEvent>.NativeClassPtr, 100668715);
			ShowDailyChallengeLeaderboardEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDailyChallengeLeaderboardEvent>.NativeClassPtr, 100668716);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0008A2E0 File Offset: 0x000884E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542624, XrefRangeEnd = 542630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowLeaderboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowDailyChallengeLeaderboardEvent.NativeMethodInfoPtr_Event_ShowLeaderboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0008A314 File Offset: 0x00088514
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowDailyChallengeLeaderboardEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowDailyChallengeLeaderboardEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowDailyChallengeLeaderboardEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0001112C File Offset: 0x0000F32C
		public ShowDailyChallengeLeaderboardEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x0008A350 File Offset: 0x00088550
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x00011135 File Offset: 0x0000F335
		public unsafe Command showLeaderboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowDailyChallengeLeaderboardEvent.NativeFieldInfoPtr_showLeaderboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowDailyChallengeLeaderboardEvent.NativeFieldInfoPtr_showLeaderboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeFieldInfoPtr_showLeaderboard;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowLeaderboard_Public_Void_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
