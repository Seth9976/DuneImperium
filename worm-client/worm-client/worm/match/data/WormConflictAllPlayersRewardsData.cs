using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.canis.actions.phases;

namespace worm.match.data
{
	// Token: 0x02000185 RID: 389
	public class WormConflictAllPlayersRewardsData : DataComponent
	{
		// Token: 0x06001188 RID: 4488 RVA: 0x0004CF68 File Offset: 0x0004B168
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictAllPlayersRewardsData()
		{
			Il2CppClassPointerStore<WormConflictAllPlayersRewardsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormConflictAllPlayersRewardsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictAllPlayersRewardsData>.NativeClassPtr);
			WormConflictAllPlayersRewardsData.NativeFieldInfoPtr_PlayerRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAllPlayersRewardsData>.NativeClassPtr, "PlayerRewards");
			WormConflictAllPlayersRewardsData.NativeMethodInfoPtr__ctor_Public_Void_List_1_SerializedPlayerReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAllPlayersRewardsData>.NativeClassPtr, 100665719);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0004CFC0 File Offset: 0x0004B1C0
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictAllPlayersRewardsData(List<SerializedPlayerReward> playerRewards)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictAllPlayersRewardsData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerRewards);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAllPlayersRewardsData.NativeMethodInfoPtr__ctor_Public_Void_List_1_SerializedPlayerReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0000B2E8 File Offset: 0x000094E8
		public WormConflictAllPlayersRewardsData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x0004D00C File Offset: 0x0004B20C
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x0000B2F1 File Offset: 0x000094F1
		public unsafe List<SerializedPlayerReward> PlayerRewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsData.NativeFieldInfoPtr_PlayerRewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedPlayerReward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsData.NativeFieldInfoPtr_PlayerRewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr_PlayerRewards;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_SerializedPlayerReward_0;
	}
}
