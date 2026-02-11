using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.ranked.menus
{
	// Token: 0x0200001C RID: 28
	public class RankedLeaderboardButton : MonoBehaviour
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00005AB4 File Offset: 0x00003CB4
		// Note: this type is marked as 'beforefieldinit'.
		static RankedLeaderboardButton()
		{
			Il2CppClassPointerStore<RankedLeaderboardButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedLeaderboardButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedLeaderboardButton>.NativeClassPtr);
			RankedLeaderboardButton.NativeMethodInfoPtr_Event_Leaderboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardButton>.NativeClassPtr, 100663345);
			RankedLeaderboardButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardButton>.NativeClassPtr, 100663346);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005B0C File Offset: 0x00003D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224956, XrefRangeEnd = 1224961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Leaderboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboardButton.NativeMethodInfoPtr_Event_Leaderboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005B40 File Offset: 0x00003D40
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedLeaderboardButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedLeaderboardButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboardButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002A26 File Offset: 0x00000C26
		public RankedLeaderboardButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_Event_Leaderboard_Public_Void_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
