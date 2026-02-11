using System;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.canis.actions.phases;

namespace worm.match.data
{
	// Token: 0x02000186 RID: 390
	public class WormConflictPlayerRewardData : DataComponent
	{
		// Token: 0x0600118D RID: 4493 RVA: 0x0004D03C File Offset: 0x0004B23C
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictPlayerRewardData()
		{
			Il2CppClassPointerStore<WormConflictPlayerRewardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormConflictPlayerRewardData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictPlayerRewardData>.NativeClassPtr);
			WormConflictPlayerRewardData.NativeFieldInfoPtr_PlayerRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardData>.NativeClassPtr, "PlayerRewards");
			WormConflictPlayerRewardData.NativeFieldInfoPtr_PlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardData>.NativeClassPtr, "PlayerData");
			WormConflictPlayerRewardData.NativeFieldInfoPtr_PlacedInConflict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardData>.NativeClassPtr, "PlacedInConflict");
			WormConflictPlayerRewardData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_SerializedPlayerReward_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayerRewardData>.NativeClassPtr, 100665720);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0004D0BC File Offset: 0x0004B2BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 711341, RefRangeEnd = 711343, XrefRangeStart = 711334, XrefRangeEnd = 711341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictPlayerRewardData(IReadOnlyList<SerializedPlayerReward> playerRewards, EntityComponent playerData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictPlayerRewardData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerRewards);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayerRewardData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_SerializedPlayerReward_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0000B310 File Offset: 0x00009510
		public WormConflictPlayerRewardData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x0004D11C File Offset: 0x0004B31C
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x0000B319 File Offset: 0x00009519
		public unsafe IReadOnlyList<SerializedPlayerReward> PlayerRewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardData.NativeFieldInfoPtr_PlayerRewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SerializedPlayerReward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardData.NativeFieldInfoPtr_PlayerRewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x0004D14C File Offset: 0x0004B34C
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x0000B338 File Offset: 0x00009538
		public unsafe EntityComponent PlayerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardData.NativeFieldInfoPtr_PlayerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardData.NativeFieldInfoPtr_PlayerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x0004D17C File Offset: 0x0004B37C
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x0000B357 File Offset: 0x00009557
		public unsafe bool PlacedInConflict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardData.NativeFieldInfoPtr_PlacedInConflict);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardData.NativeFieldInfoPtr_PlacedInConflict)) = value;
			}
		}

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeFieldInfoPtr_PlayerRewards;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeFieldInfoPtr_PlayerData;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeFieldInfoPtr_PlacedInConflict;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_SerializedPlayerReward_EntityComponent_0;
	}
}
