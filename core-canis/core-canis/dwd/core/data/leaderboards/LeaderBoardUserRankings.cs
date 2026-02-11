using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.data.leaderboards
{
	// Token: 0x020001D6 RID: 470
	public class LeaderBoardUserRankings : NetworkMessageEvent
	{
		// Token: 0x060019E7 RID: 6631 RVA: 0x0007ADCC File Offset: 0x00078FCC
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderBoardUserRankings()
		{
			Il2CppClassPointerStore<LeaderBoardUserRankings>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.leaderboards", "LeaderBoardUserRankings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderBoardUserRankings>.NativeClassPtr);
			LeaderBoardUserRankings.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardUserRankings>.NativeClassPtr, "Entries");
			LeaderBoardUserRankings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderBoardUserRankings>.NativeClassPtr, 100667401);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0007AE24 File Offset: 0x00079024
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaderBoardUserRankings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderBoardUserRankings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderBoardUserRankings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0000B4DD File Offset: 0x000096DD
		public LeaderBoardUserRankings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x0007AE60 File Offset: 0x00079060
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x0000B4E6 File Offset: 0x000096E6
		public unsafe Dictionary<string, Il2CppReferenceArray<LeaderBoardEntry>> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardUserRankings.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppReferenceArray<LeaderBoardEntry>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardUserRankings.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
