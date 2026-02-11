using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.ranked.networking.responses
{
	// Token: 0x0200000D RID: 13
	public class RankedLeaderboard : NetworkMessageEvent
	{
		// Token: 0x0600003E RID: 62 RVA: 0x0000431C File Offset: 0x0000251C
		// Note: this type is marked as 'beforefieldinit'.
		static RankedLeaderboard()
		{
			Il2CppClassPointerStore<RankedLeaderboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.responses", "RankedLeaderboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedLeaderboard>.NativeClassPtr);
			RankedLeaderboard.NativeFieldInfoPtr_OrderedEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboard>.NativeClassPtr, "OrderedEntries");
			RankedLeaderboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboard>.NativeClassPtr, 100663319);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004374 File Offset: 0x00002574
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedLeaderboard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedLeaderboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000022A4 File Offset: 0x000004A4
		public RankedLeaderboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000043B0 File Offset: 0x000025B0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000022AD File Offset: 0x000004AD
		public unsafe Il2CppReferenceArray<RankedLeaderboardEntry> OrderedEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboard.NativeFieldInfoPtr_OrderedEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RankedLeaderboardEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboard.NativeFieldInfoPtr_OrderedEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_OrderedEntries;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
