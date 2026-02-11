using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.abilities.ConflictAbilities;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002B7 RID: 695
	[Serializable]
	public class SerializedPlayerReward : Object
	{
		// Token: 0x06001CCE RID: 7374 RVA: 0x000C8E7C File Offset: 0x000C707C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedPlayerReward()
		{
			Il2CppClassPointerStore<SerializedPlayerReward>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedPlayerReward");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedPlayerReward>.NativeClassPtr);
			SerializedPlayerReward.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedPlayerReward>.NativeClassPtr, "PlayerID");
			SerializedPlayerReward.NativeFieldInfoPtr_Place = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedPlayerReward>.NativeClassPtr, "Place");
			SerializedPlayerReward.NativeFieldInfoPtr_Tied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedPlayerReward>.NativeClassPtr, "Tied");
			SerializedPlayerReward.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedPlayerReward>.NativeClassPtr, "AbilityID");
			SerializedPlayerReward.NativeMethodInfoPtr_Make_Public_Static_SerializedPlayerReward_WormPlayer_Int32_Boolean_ConflictAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPlayerReward>.NativeClassPtr, 100669424);
			SerializedPlayerReward.NativeMethodInfoPtr_Deserialize_Public_Void_WormMatch_byref_WormPlayer_byref_Int32_byref_Boolean_byref_ConflictAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPlayerReward>.NativeClassPtr, 100669425);
			SerializedPlayerReward.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPlayerReward>.NativeClassPtr, 100669426);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000C8F38 File Offset: 0x000C7138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155472, RefRangeEnd = 155474, XrefRangeStart = 155465, XrefRangeEnd = 155472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializedPlayerReward Make(WormPlayer player, int place, bool tied, ConflictAbility ability)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref place;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tied;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ability);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedPlayerReward.NativeMethodInfoPtr_Make_Public_Static_SerializedPlayerReward_WormPlayer_Int32_Boolean_ConflictAbility_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedPlayerReward>(intPtr3) : null;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x000C8FAC File Offset: 0x000C71AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155489, RefRangeEnd = 155491, XrefRangeStart = 155474, XrefRangeEnd = 155489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deserialize(WormMatch wormMatch, out WormPlayer player, out int place, out bool tied, out ConflictAbility ability)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &place;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tied;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializedPlayerReward.NativeMethodInfoPtr_Deserialize_Public_Void_WormMatch_byref_WormPlayer_byref_Int32_byref_Boolean_byref_ConflictAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			player = ((intPtr5 == 0) ? null : new WormPlayer(intPtr5));
			IntPtr intPtr6 = intPtr2;
			ability = ((intPtr6 == 0) ? null : new ConflictAbility(intPtr6));
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000C9050 File Offset: 0x000C7250
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedPlayerReward()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedPlayerReward>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedPlayerReward.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0000C348 File Offset: 0x0000A548
		public SerializedPlayerReward(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x000C908C File Offset: 0x000C728C
		// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x0000C351 File Offset: 0x0000A551
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPlayerReward.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPlayerReward.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x000C90BC File Offset: 0x000C72BC
		// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x0000C370 File Offset: 0x0000A570
		public unsafe int Place
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPlayerReward.NativeFieldInfoPtr_Place);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPlayerReward.NativeFieldInfoPtr_Place)) = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x000C90E4 File Offset: 0x000C72E4
		// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x0000C38B File Offset: 0x0000A58B
		public unsafe bool Tied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPlayerReward.NativeFieldInfoPtr_Tied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPlayerReward.NativeFieldInfoPtr_Tied)) = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x000C910C File Offset: 0x000C730C
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x0000C3A6 File Offset: 0x0000A5A6
		public unsafe EntityID AbilityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPlayerReward.NativeFieldInfoPtr_AbilityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPlayerReward.NativeFieldInfoPtr_AbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeFieldInfoPtr_Place;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeFieldInfoPtr_Tied;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_Make_Public_Static_SerializedPlayerReward_WormPlayer_Int32_Boolean_ConflictAbility_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_WormMatch_byref_WormPlayer_byref_Int32_byref_Boolean_byref_ConflictAbility_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
