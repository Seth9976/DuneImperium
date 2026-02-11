using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.networking.responses;

namespace worm
{
	// Token: 0x0200004D RID: 77
	public class WormEventLeaderboardData : DataComponent
	{
		// Token: 0x06000339 RID: 825 RVA: 0x00022CD0 File Offset: 0x00020ED0
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventLeaderboardData()
		{
			Il2CppClassPointerStore<WormEventLeaderboardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormEventLeaderboardData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventLeaderboardData>.NativeClassPtr);
			WormEventLeaderboardData.NativeFieldInfoPtr__Entries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardData>.NativeClassPtr, "<Entries>k__BackingField");
			WormEventLeaderboardData.NativeMethodInfoPtr__ctor_Public_Void_EventLeaderboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardData>.NativeClassPtr, 100663813);
			WormEventLeaderboardData.NativeMethodInfoPtr_get_Entries_Public_get_IReadOnlyList_1_EventLeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardData>.NativeClassPtr, 100663814);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00022D3C File Offset: 0x00020F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691451, XrefRangeEnd = 691454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventLeaderboardData(EventLeaderboard leaderboard)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventLeaderboardData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaderboard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardData.NativeMethodInfoPtr__ctor_Public_Void_EventLeaderboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00022D88 File Offset: 0x00020F88
		public unsafe IReadOnlyList<EventLeaderboardEntry> Entries
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardData.NativeMethodInfoPtr_get_Entries_Public_get_IReadOnlyList_1_EventLeaderboardEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EventLeaderboardEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000037C9 File Offset: 0x000019C9
		public WormEventLeaderboardData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00022DC8 File Offset: 0x00020FC8
		// (set) Token: 0x0600033E RID: 830 RVA: 0x000037D2 File Offset: 0x000019D2
		public unsafe IReadOnlyList<EventLeaderboardEntry> _Entries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardData.NativeFieldInfoPtr__Entries_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EventLeaderboardEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardData.NativeFieldInfoPtr__Entries_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr__Entries_k__BackingField;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventLeaderboard_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_get_Entries_Public_get_IReadOnlyList_1_EventLeaderboardEntry_0;
	}
}
