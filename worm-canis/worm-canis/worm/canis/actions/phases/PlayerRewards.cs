using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.abilities.ConflictAbilities;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002B5 RID: 693
	public sealed class PlayerRewards : ValueType
	{
		// Token: 0x06001CA0 RID: 7328 RVA: 0x000C8268 File Offset: 0x000C6468
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerRewards()
		{
			Il2CppClassPointerStore<PlayerRewards>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "PlayerRewards");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerRewards>.NativeClassPtr);
			PlayerRewards.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerRewards>.NativeClassPtr, "Player");
			PlayerRewards.NativeFieldInfoPtr_Place = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerRewards>.NativeClassPtr, "Place");
			PlayerRewards.NativeFieldInfoPtr_Tied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerRewards>.NativeClassPtr, "Tied");
			PlayerRewards.NativeFieldInfoPtr_RewardAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerRewards>.NativeClassPtr, "RewardAbility");
			PlayerRewards.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_Int32_Boolean_ConflictAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerRewards>.NativeClassPtr, 100669295);
			PlayerRewards.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_WormPlayer_byref_Int32_byref_Boolean_byref_ConflictAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerRewards>.NativeClassPtr, 100669296);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000C8310 File Offset: 0x000C6510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 152579, RefRangeEnd = 152582, XrefRangeStart = 152577, XrefRangeEnd = 152579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerRewards(WormPlayer player, int place, bool tied, ConflictAbility rewardAbility)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerRewards>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref place;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tied;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rewardAbility);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerRewards.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_Int32_Boolean_ConflictAbility_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x000C8390 File Offset: 0x000C6590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152584, RefRangeEnd = 152586, XrefRangeStart = 152582, XrefRangeEnd = 152584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deconstruct(out WormPlayer player, out int place, out bool tied, out ConflictAbility rewardAbility)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &place;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tied;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlayerRewards.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_WormPlayer_byref_Int32_byref_Boolean_byref_ConflictAbility_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			player = ((intPtr5 == 0) ? null : new WormPlayer(intPtr5));
			IntPtr intPtr6 = intPtr2;
			rewardAbility = ((intPtr6 == 0) ? null : new ConflictAbility(intPtr6));
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0000C224 File Offset: 0x0000A424
		public PlayerRewards(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0000C22D File Offset: 0x0000A42D
		public PlayerRewards()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerRewards>.NativeClassPtr))
		{
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x000C8428 File Offset: 0x000C6628
		// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x0000C23F File Offset: 0x0000A43F
		public unsafe WormPlayer Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRewards.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRewards.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x000C8458 File Offset: 0x000C6658
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x0000C25E File Offset: 0x0000A45E
		public unsafe int Place
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRewards.NativeFieldInfoPtr_Place);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRewards.NativeFieldInfoPtr_Place)) = value;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x000C8480 File Offset: 0x000C6680
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x0000C279 File Offset: 0x0000A479
		public unsafe bool Tied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRewards.NativeFieldInfoPtr_Tied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRewards.NativeFieldInfoPtr_Tied)) = value;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x000C84A8 File Offset: 0x000C66A8
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x0000C294 File Offset: 0x0000A494
		public unsafe ConflictAbility RewardAbility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRewards.NativeFieldInfoPtr_RewardAbility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConflictAbility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRewards.NativeFieldInfoPtr_RewardAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeFieldInfoPtr_Place;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeFieldInfoPtr_Tied;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeFieldInfoPtr_RewardAbility;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_Int32_Boolean_ConflictAbility_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_WormPlayer_byref_Int32_byref_Boolean_byref_ConflictAbility_0;
	}
}
